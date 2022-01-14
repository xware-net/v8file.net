using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
//using System.Windows.Forms;

namespace v8file.net
{
    public class V8FileManipulation
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        internal static CmFileInfo CMFileInfo = new();
        private static bool SaveToDir = false;
        private static string OutDir = null;
        private static Tree Tree;
        private static TreeNode RootNode;

        public static void V8DgnFreeAll(string outDir = null)
        {
            int i;

            if (!string.IsNullOrEmpty(outDir))
            {
                SaveToDir = true;
                OutDir = outDir;
            } else
            {
                SaveToDir = false;
                OutDir = null;
            }

            for (i = 0; i < CMFileInfo.NumFiles; i++)
            {
                V8DgnFreeDgnFileObj(CMFileInfo.Files[i]);
            }

            if (CMFileInfo.NumFiles > 0)
            {
                V8DeleteFiles("$*.*");
                V8DeleteFiles("dgn~*.*");
                V8DeleteFiles("dgn_*.*");
                V8DeleteFiles("dgn-*.*");
                V8DeleteFiles("modelelm.*");
                V8DeleteFiles(".Logfile*.*");
                V8DeleteFiles("v8file.log");
                V8DeleteFiles(".Embedded@.Index");
                V8DeleteFiles("GSX_*.*");
                V8DeleteFiles("*.bmp");
                V8DeleteFiles("*.modelIndexItem");
                V8DeleteFiles("*.modelIndex");
                V8DeleteFiles("*.models");
                V8DeleteFiles("*.model");
                V8DeleteFiles("prefix@*.*");
                V8DeleteFiles("*.Graphics", true);
                V8DeleteFiles("*.Control", true);
                V8DeleteFiles("*.GraphicAttributes", true);
                V8DeleteFiles("*.ControlAttributes", true);
                V8DeleteFiles("*.NonModel", true);
            }

            CMFileInfo = default;
        }

        public static void V8DgnFreeDgnFileObj(DgnFileObj dgnFileObj)
        {
        }

        public static void V8DgnMoveAll(string outDir)
        {
            if (!string.IsNullOrEmpty(outDir))
            {
                SaveToDir = true;
                OutDir = outDir;
            }
            else
            {
                SaveToDir = false;
                OutDir = null;
            }

            // key is (type, levelId, elementId)
            foreach (var key in Utils.ElementsWithIdAndTypeAndLevel.Keys)
            {
                string copyDir;
                if (key.Item2 != "*")
                {
                    copyDir = Path.Combine(OutDir, "elements", key.Item1.ToString(), key.Item2.ToString());
                }
                else
                {
                    copyDir = Path.Combine(OutDir, "elements", key.Item1.ToString());
                }

                if (!Directory.Exists(copyDir))
                    Directory.CreateDirectory(copyDir);

                var names = Utils.ElementsWithIdAndTypeAndLevel[key];
                foreach (var name in names)
                {
                    File.Copy(name, Path.Combine(copyDir, name), true);
                }

                Array.ForEach(names.ToArray(), f => File.Delete(f));

            }

            Utils.ElementsWithIdAndTypeAndLevel.Clear();
            foreach (var key in Utils.LinkagesWithIdAndTypeAndLevel.Keys)
            {
                var names = Utils.LinkagesWithIdAndTypeAndLevel[key];
                foreach (var name in names)
                {
                    var extension = Path.GetExtension(name).Replace(".", "").ToUpper();
                    // move it to OutDir\linkages\extension 
                    var copyDir = Path.Combine(OutDir, "linkages", extension);
                    if (!Directory.Exists(copyDir))
                        Directory.CreateDirectory(copyDir);
                    File.Copy(name, Path.Combine(copyDir, name), true);
                }

                Array.ForEach(names.ToArray(), f => File.Delete(f));
            }

            Utils.LinkagesWithIdAndTypeAndLevel.Clear();
        }

        private static void V8DeleteFiles(string pattern, bool dumps = false)
        {
            string[] files = Directory.GetFiles(".", pattern);
            if (SaveToDir)
            {
                if (pattern == "*.modelIndexItem")
                {
                    if (!Directory.Exists(Path.Combine(OutDir, "modelIndex")))
                        Directory.CreateDirectory(Path.Combine(OutDir, "modelIndex"));
                    Array.ForEach(files, f => File.Copy(f, Path.Combine(OutDir, "modelIndex", Path.GetFileName(f)), true));
                }
                else if (pattern == "*.modelIndex")
                {
                    if (!Directory.Exists(Path.Combine(OutDir, "modelIndex")))
                        Directory.CreateDirectory(Path.Combine(OutDir, "modelIndex"));
                    Array.ForEach(files, f => File.Copy(f, Path.Combine(OutDir, "modelIndex", Path.GetFileName(f)), true));
                }
                else if (pattern == "*.model")
                {
                    if (!Directory.Exists(Path.Combine(OutDir, "model")))
                        Directory.CreateDirectory(Path.Combine(OutDir, "model"));
                    Array.ForEach(files, f => File.Copy(f, Path.Combine(OutDir, "model", Path.GetFileName(f)), true));
                }
                else if (pattern == "*.bmp")
                {
                    if (!Directory.Exists(OutDir))
                        Directory.CreateDirectory(OutDir);
                    Array.ForEach(files, f => File.Copy(f, Path.Combine(OutDir, Path.GetFileName(f)), true));
                }
                else
                {
                    // must copy the files matching pattern to OutDir
                    string copyDir = Path.Combine(OutDir, Path.GetFileName(CMFileInfo.Files[CMFileInfo.NumFiles - 1].FileName).Replace(".dgn", dumps == false ? "" : "\\Dumps"));
                    if (!Directory.Exists(copyDir))
                        Directory.CreateDirectory(copyDir);
                    Array.ForEach(files, f => File.Copy(f, Path.Combine(copyDir, Path.GetFileName(f)), true));
                }
            }

            Array.ForEach(files, f => File.Delete(f));
        }

        public static void V8DgnLoad(string name)
        {
            CMFileInfo.NumFiles++;
            Array.Resize(ref CMFileInfo.Files, CMFileInfo.NumFiles);

            CMFileInfo.Files[CMFileInfo.NumFiles - 1].FileName = name;
            V8FileLoader.V8LoadNonModels(ref CMFileInfo.Files[CMFileInfo.NumFiles - 1]);
            V8FileLoader.V8LoadModels(ref CMFileInfo.Files[CMFileInfo.NumFiles - 1]);
            for (int i = 0; i < CMFileInfo.NumFiles; i++)
            {
                for (int j = 0; j < CMFileInfo.Files[i].NumModels; j++)
                {
                    for (int k = 0; k < CMFileInfo.Files[i].Caches[j].NumControlAttributesCaches; k++)
                    {
                        V8FileLoader.V8ParseAttributeCache(CMFileInfo.Files[i].FileName, "ControlAttributes", j, k, CMFileInfo.Files[i].Caches[j].ControlAttributesCaches[k]);
                        //V8FileLoader.V8ParseAttributeCache(StreamWriter.Null, CMFileInfo.Files[i].Caches[j].ControlAttributesCaches[k]);
                    }

                    for (int k = 0; k < CMFileInfo.Files[i].Caches[j].NumGraphicAttributesCaches; k++)
                    {
                        V8FileLoader.V8ParseAttributeCache(CMFileInfo.Files[i].FileName, "GraphicAttributes", j, k, CMFileInfo.Files[i].Caches[j].GraphicAttributesCaches[k]);
                        //V8FileLoader.V8ParseAttributeCache(StreamWriter.Null, CMFileInfo.Files[i].Caches[j].GraphicAttributesCaches[k]);
                    }
                }
            }
        }

        public static int ElementType { get; set; }
        public static string ElementId { get; set; }
        public static string LevelId { get; set; }

        public static void V8DgnParse(StreamWriter sw, bool saveToDir = true)
        {
            SaveToDir = saveToDir;

            V8FileOLEStorage.V8DgnDumpProperties(sw);
            V8ParseDgnHeader();
            V8Models.V8GetModelIndexInformation();
            V8Models.V8GetModelsInformation();
            V8Models.V8DumpModelInformation(sw);
            V8ParseCaches();
            V8DumpCaches(sw);
        }

        public static void V8DgnParse(string elementType, string elementId = "*", string levelId = "*")
        {
            //SaveToDir = saveToDir;

            //V8FileOLEStorage.V8DgnDumpProperties(sw);
            V8ParseDgnHeader();
            V8Models.V8GetModelIndexInformation();
            V8Models.V8GetModelsInformation();
            if (elementType == "-1")
            {
                V8Models.V8DumpModelInformation();
            }
            else
            {
                ElementType = Convert.ToInt32(elementType);
                ElementId = elementId;
                LevelId = levelId;

                V8ParseCaches();
                //V8DumpCaches(sw);
            }
        }

        private static void V8ParseDgnHeader()
        {
            // parse Dgn~H
            using Stream stream = new StreamReader("Dgn~H").BaseStream;
            using BinaryReader br = new(stream);
            // at 0x114 we have the 
            // at 0x118 we have the 
            // at 0x11c we have the 

            // at 0x120 we have the max model id
            br.BaseStream.Seek(0x120, SeekOrigin.Begin);
            CMFileInfo.Files[0].HighestModelId = br.ReadInt32();

            // at 0x124 we have the default model id
            br.BaseStream.Seek(0x124, SeekOrigin.Begin);
            CMFileInfo.Files[0].DefaultModelId = br.ReadInt32();

            // at 0x128 we have max element id
            br.BaseStream.Seek(0x128, SeekOrigin.Begin);
            CMFileInfo.Files[0].HighestElementId = br.ReadUInt64();

            // at 0x130 we have last saved ti,e
            br.BaseStream.Seek(0x130, SeekOrigin.Begin);
            CMFileInfo.Files[0].LastSavedTime = br.ReadDouble();

            // at 0x138 we have
            // at 0x13c we have
            // at 0x140 we have
            // at 0x308 we have
            // at 0x310 we have
            // at 0x314 we have

            // at 0x388 we have
        }

        private static void V8DumpCaches(StreamWriter sw)
        {
            foreach (TreeNode n in Tree.Nodes)
            {
                PrintRecursive(sw, n, 0);
            }
        }

        private static void PrintRecursive(StreamWriter sw, TreeNode treeNode, int level)
        {
            DumpNodeBegin(sw, treeNode, level);
            Dump(sw, treeNode, level);
            // Print each node recursively.  
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(sw, tn, level + 1);
            }
            DumpNodeEnd(sw, treeNode, level);
        }

        private static void DumpNodeBegin(StreamWriter sw, TreeNode treeNode, int level)
        {
            var ident = new String(' ', 2 * level);
            string nodeName = string.Empty;
            UInt32 modelId = 0xffffffff;
            if (treeNode.Name == "0")
            {
                nodeName = "Root";
                sw.WriteLine($"{ident}{nodeName} > ");
            }
            else if (treeNode.Name == "-1")
            {
                nodeName = "NonModel";
                sw.WriteLine($"{ident}{nodeName} > ");
            }
            else if (treeNode.Name == "-2")
            {
                nodeName = "Models";
                sw.WriteLine($"{ident}{nodeName} > ");
            }
            else if (treeNode.Name.StartsWith("-"))
            {
                int n = Convert.ToInt32(treeNode.Name[1..]);
                int m = n % 3;
                if (m == 0)
                {
                    nodeName = "Model: " + V8GetModelName((n / 3) - 1);
                    modelId = (uint)((n / 3) - 1);
                    sw.WriteLine($"{ident}{nodeName} > ");
                }
                else if (m == 1)
                {
                    nodeName = "Graphics";
                    sw.WriteLine($"{ident}{nodeName} > ");
                }
                else if (m == 2)
                {
                    nodeName = "Control";
                    sw.WriteLine($"{ident}{nodeName} > ");
                }
            }
            else
            {
                if (treeNode.Tag is ElementTag tag1)
                {
                    nodeName = $"{tag1.ElementId:X16} - {Utils.V8GetElmType(tag1.ElementHeader)} - {tag1.CachePos:X}";
                    sw.WriteLine($"{ident}{nodeName} > ");
                }
                else
                {
                    nodeName = treeNode.Name;
                    sw.WriteLine($"{ident}{nodeName} > ");
                }
            }

            if (modelId != 0xffffffff)
            {
                V8Models.V8GetModelInfoFromCache(V8FileManipulation.CMFileInfo.Files[0].Caches[modelId]).Dump(sw, level + 1);
            }
        }

        private static void DumpNodeEnd(StreamWriter sw, TreeNode treeNode, int level)
        {
            var ident = new String(' ', 2 * level);
            string nodeName = string.Empty;
            UInt32 modelId = 0xffffffff;
            if (treeNode.Name == "0")
            {
                nodeName = "Root";
                sw.WriteLine($"{ident}< {nodeName}");
            }
            else if (treeNode.Name == "-1")
            {
                nodeName = "NonModel";
                sw.WriteLine($"{ident}< {nodeName}");
            }
            else if (treeNode.Name == "-2")
            {
                nodeName = "Models";
                sw.WriteLine($"{ident}< {nodeName}");
            }
            else if (treeNode.Name.StartsWith("-"))
            {
                int n = Convert.ToInt32(treeNode.Name[1..]);
                int m = n % 3;
                if (m == 0)
                {
                    nodeName = "Model: " + V8GetModelName((n / 3) - 1);
                    modelId = (uint)((n / 3) - 1);
                    sw.WriteLine($"{ident}< {nodeName}");
                }
                else if (m == 1)
                {
                    nodeName = "Graphics";
                    sw.WriteLine($"{ident}< {nodeName}");
                }
                else if (m == 2)
                {
                    nodeName = "Control";
                    sw.WriteLine($"{ident}< {nodeName}");
                }
            }
            else
            {
                if (treeNode.Tag is ElementTag tag1)
                {
                    nodeName = $"{tag1.ElementId:X16} - {Utils.V8GetElmType(tag1.ElementHeader)} - {tag1.CachePos:X}";
                    sw.WriteLine($"{ident}< {nodeName}");
                }
                else
                {
                    nodeName = treeNode.Name;
                    sw.WriteLine($"{ident}< {nodeName}");
                }
            }
        }

        private static void Dump(StreamWriter sw, TreeNode treeNode, int level)
        {
            if (treeNode.Tag is ElementTag tag)
            {
                object element = V8ReadElementFromCache(tag);
                if (element != null)
                {
                    switch (element)
                    {
                        case AcsElm t:
                            t.Dump(sw, level);
                            break;
                        case AnimationParameterTable t:
                            t.Dump(sw, level);
                            break;
                        case AnimationParameterTableElm t:
                            t.Dump(sw, level);
                            break;
                        case AnimationScheduleInfoTable t:
                            t.Dump(sw, level);
                            break;
                        case AnimationScheduleInfoTableElm t:
                            t.Dump(sw, level);
                            break;
                        case AttributeElm t:
                            t.Dump(sw, level);
                            break;
                        case Arc_2d t:
                            t.Dump(sw, level);
                            break;
                        case Arc_3d t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_curve t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_knot t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_pole_2d t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_pole_3d t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_surface t:
                            t.Dump(sw, level);
                            break;
                        case Bspline_weight t:
                            t.Dump(sw, level);
                            break;
                        case Cell_2d t:
                            t.Dump(sw, level);
                            break;
                        case Cell_3d t:
                            t.Dump(sw, level);
                            break;
                        case ColorBook t:
                            t.Dump(sw, level);
                            break;
                        case ColorBookElm t:
                            t.Dump(sw, level);
                            break;
                        case ColorBookTable t:
                            t.Dump(sw, level);
                            break;
                        case ColorBookTableElm t:
                            t.Dump(sw, level);
                            break;
                        case ColorTable t:
                            t.Dump(sw, level);
                            break;
                        case Complex_shape t:
                            t.Dump(sw, level);
                            break;
                        case Complex_string t:
                            t.Dump(sw, level);
                            break;
                        case Dgn_header t:
                            t.Dump(sw, level);
                            break;
                        case DictionaryTable t:
                            t.Dump(sw, level);
                            break;
                        case DictionaryTableElm t:
                            t.Dump(sw, level);
                            break;
                        case DimensionElm t:
                            t.Dump(sw, level);
                            break;
                        case DimStyleTable t:
                            t.Dump(sw, level);
                            break;
                        case DimStyleTableElm t:
                            t.Dump(sw, level);
                            break;
                        case Ellipse_2d t:
                            t.Dump(sw, level);
                            break;
                        case Ellipse_3d t:
                            t.Dump(sw, level);
                            break;
                        case ExtendedElm t:
                            t.Dump(sw, level);
                            break;
                        case ExtendedNonGraphicElm t:
                            t.Dump(sw, level);
                            break;
                        case FilterTable t:
                            t.Dump(sw, level);
                            break;
                        case FilterTableElm t:
                            t.Dump(sw, level);
                            break;
                        case FontTable t:
                            t.Dump(sw, level);
                            break;
                        case FontTableElm t:
                            t.Dump(sw, level);
                            break;
                        case LevelMaskElm t:
                            t.Dump(sw, level);
                            break;
                        case LevelNameDictionaryTable t:
                            t.Dump(sw, level);
                            break;
                        case LevelNameDictionaryTableElm t:
                            t.Dump(sw, level);
                            break;
                        case LevelTable t:
                            t.Dump(sw, level);
                            break;
                        case LevelTableElm t:
                            t.Dump(sw, level);
                            break;
                        case LightSetupTable t:
                            t.Dump(sw, level);
                            break;
                        case LightSetupTableElm t:
                            t.Dump(sw, level);
                            break;
                        case Line_2d t:
                            t.Dump(sw, level);
                            break;
                        case Line_3d t:
                            t.Dump(sw, level);
                            break;
                        case Line_String_2d t:
                            t.Dump(sw, level);
                            break;
                        case Line_String_3d t:
                            t.Dump(sw, level);
                            break;
                        case LStyleDefTable t:
                            t.Dump(sw, level);
                            break;
                        case LStyleDefTableElm t:
                            t.Dump(sw, level);
                            break;
                        case LStyleNameTable t:
                            t.Dump(sw, level);
                            break;
                        case LStyleNameTableElm t:
                            t.Dump(sw, level);
                            break;
                        case MaterialPaletteTable t:
                            t.Dump(sw, level);
                            break;
                        case MaterialPaletteTableElm t:
                            t.Dump(sw, level);
                            break;
                        case MatrixDoubleDataElm t:
                            t.Dump(sw, level);
                            break;
                        case MatrixHeaderElm t:
                            t.Dump(sw, level);
                            break;
                        case MatrixIntDataElm t:
                            t.Dump(sw, level);
                            break;
                        case MeshHeaderElm t:
                            t.Dump(sw, level);
                            break;
                        case MLineStyleTable t:
                            t.Dump(sw, level);
                            break;
                        case MLineStyleTableElm t:
                            t.Dump(sw, level);
                            break;
                        case MultilineElm t:
                            t.Dump(sw, level);
                            break;
                        case NamedPresentationTable t:
                            t.Dump(sw, level);
                            break;
                        case NamedGroupComponentElm t:
                            t.Dump(sw, level);
                            break;
                        case NamedGroupHeaderElm t:
                            t.Dump(sw, level);
                            break;
                        case NamedPresentationTableElm t:
                            t.Dump(sw, level);
                            break;
                        case RasterReferenceAttachmentElm t:
                            t.Dump(sw, level);
                            break;
                        case RasterReferenceComponentElm t:
                            t.Dump(sw, level);
                            break;
                        case ReferenceFileElm t:
                            t.Dump(sw, level);
                            break;
                        case RegAppTable t:
                            t.Dump(sw, level);
                            break;
                        case RegAppTableElm t:
                            t.Dump(sw, level);
                            break;
                        case RenderSetupTable t:
                            t.Dump(sw, level);
                            break;
                        case RenderSetupTableElm t:
                            t.Dump(sw, level);
                            break;
                        case Shape_2d t:
                            t.Dump(sw, level);
                            break;
                        case Shape_3d t:
                            t.Dump(sw, level);
                            break;
                        case Surface t:
                            t.Dump(sw, level);
                            break;
                        case SymbolStyleTable t:
                            t.Dump(sw, level);
                            break;
                        case SymbolStyleTableElm t:
                            t.Dump(sw, level);
                            break;
                        case Text_2d t:
                            t.Dump(sw, level);
                            break;
                        case Text_3d t:
                            t.Dump(sw, level);
                            break;
                        case Text_node_2d t:
                            t.Dump(sw, level);
                            break;
                        case Text_node_3d t:
                            t.Dump(sw, level);
                            break;
                        case TextStyleTable t:
                            t.Dump(sw, level);
                            break;
                        case TextStyleTableElm t:
                            t.Dump(sw, level);
                            break;
                        case SharedCellDefElm t:
                            t.Dump(sw, level);
                            break;
                        case SharedCellElm t:
                            t.Dump(sw, level);
                            break;
                        case ViewElm t:
                            t.Dump(sw, level);
                            break;
                        case ViewGroupElm t:
                            t.Dump(sw, level);
                            break;
                        case Elm_hdr t:
                            t.Dump(sw, level);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static object V8ReadElementFromCache(ElementTag tag)
        {
            Cache cache;
            switch (tag.CacheType)
            {
                case "NonModel":
                    cache = CMFileInfo.Files[0].NonModelCaches[tag.CacheNum];
                    break;
                case "Graphics":
                    cache = CMFileInfo.Files[0].Caches[tag.ModelNum].GraphicCaches[tag.CacheNum];
                    break;
                case "Control":
                    cache = CMFileInfo.Files[0].Caches[tag.ModelNum].ControlCaches[tag.CacheNum];
                    break;
                default:
                    _ = new Cache();
                    Debugger.Break();
                    return null;
            }

            using MemoryStream ms = new(cache.Bytes);
            using BinaryReader br = new(ms);
            br.BaseStream.Seek(tag.CachePos, SeekOrigin.Begin);
            Elm_hdr ehdr = tag.ElementHeader;
            Disp_hdr dhdr = tag.DisplayHeader;
            if (ehdr.IsGraphics != 0)
            {
                // graphic elements
                switch (ehdr.Type)
                {
                    case 2:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Cell_2d().Read(br);
                        else
                            return new Cell_3d().Read(br);
                    case 3:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Line_2d().Read(br);
                        else
                            return new Line_3d().Read(br);
                    case 4:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Line_String_2d().Read(br);
                        else
                            return new Line_String_3d().Read(br);
                    case 6:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Shape_2d().Read(br);
                        else
                            return new Shape_3d().Read(br);
                    case 7:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Text_node_2d().Read(br);
                        else
                            return new Text_node_3d().Read(br);
                    case 11:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Curve_2d().Read(br);
                        else
                            return new Curve_3d().Read(br);
                    case 12:
                        return new Complex_string().Read(br);
                    case 13:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Conic_2d().Read(br);
                        else
                            return new Conic_3d().Read(br);
                    case 14:
                        return new Complex_shape().Read(br);
                    case 15:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Ellipse_2d().Read(br);
                        else
                            return new Ellipse_3d().Read(br);
                    case 16:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Arc_2d().Read(br);
                        else
                            return new Arc_3d().Read(br);
                    case 17:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Text_2d().Read(br);
                        else
                            return new Text_3d().Read(br);
                    case 18:
                        if (dhdr.Props.B.Is3d == 0)
                        {
                            Debugger.Break();
                            return null;
                        }
                        else
                            return new Surface().Read(br);
                    case 19:
                        if (dhdr.Props.B.Is3d == 0)
                        {
                            Debugger.Break();
                            return null;
                        }
                        else
                            return new Solid().Read(br);
                    case 21:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Bspline_pole_2d().Read(br);
                        else
                            return new Bspline_pole_3d().Read(br);
                    case 22:
                        if (dhdr.Props.B.Is3d == 0)
                            return new Point_string_2d().Read(br);
                        else
                            return new Point_string_3d().Read(br);
                    case 23:
                        if (dhdr.Props.B.Is3d == 0)
                        {
                            Debugger.Break();
                            return null;
                        }
                        else
                            return new Cone_3d().Read(br);
                    case 24:
                        return new Bspline_surface().Read(br);
                    case 27:
                        return new Bspline_curve().Read(br);
                    case 33:    // dimension element
                        return new DimensionElm().Read(br);
                    case 34:    // shared cell definition element
                        return new SharedCellDefElm().Read(br);
                    case 35:    // shared cell element
                        return new SharedCellElm().Read(br);
                    case 36:    // multiline element
                        return new MultilineElm().Read(br);
                    case 37:    // attribute element
                        return new AttributeElm().Read(br);
                    case 94:    // raster frame element
                        return null;
                    case 105:   // mesh header
                        return new MeshHeaderElm().Read(br);
                    case 106:   // extended graphic element (complex)
                        return new ExtendedElm().Read(br);
                    default:
                        return null;
                }
            }
            else
            {
                // non graphic elements
                return ehdr.Type switch
                {
                    // color table (level 1), ACS (level 3)
                    5 => ehdr.Level switch
                    {
                        1 => new ColorTable().Read(br),
                        3 => new AcsElm().Read(br),
                        _ => null,
                    },
                    9 => new Dgn_header().Read(br),
                    25 => new Bsurf_boundary().Read(br),
                    26 => new Bspline_knot().Read(br),
                    28 => new Bspline_weight().Read(br),
                    // dgnstore component
                    38 => null,
                    // dgnstore header
                    39 => null,
                    // microstation application element
                    66 => null,
                    // raster reference attachment
                    90 => new RasterReferenceAttachmentElm().Read(br),
                    // raster reference component
                    91 => new RasterReferenceComponentElm().Read(br),
                    // raster hierarchy element
                    92 => null,
                    // raster hierarchy component
                    93 => null,
                    // table entry
                    95 => ehdr.Level switch
                    {
                        1 => new LevelTableElm().Read(br),
                        2 => new FontTableElm().Read(br),
                        3 => new TextStyleTableElm().Read(br),
                        4 => new FilterTableElm().Read(br),
                        5 => new DimStyleTableElm().Read(br),
                        6 => new MLineStyleTableElm().Read(br),
                        7 => new LStyleNameTableElm().Read(br),
                        8 => new LStyleDefTableElm().Read(br),
                        9 => new DictionaryTableElm().Read(br),
                        10 => new RegAppTableElm().Read(br),
                        11 => new ColorBookTableElm().Read(br),
                        16 => new SymbolStyleTableElm().Read(br),
                        17 => new ColorBookElm().Read(br),
                        18 => new MaterialPaletteTableElm().Read(br),
                        19 => new LevelNameDictionaryTableElm().Read(br),
                        20 => new AnimationParameterTableElm().Read(br),
                        21 => new AnimationScheduleInfoTableElm().Read(br),
                        22 => new RenderSetupTableElm().Read(br),
                        23 => new LightSetupTableElm().Read(br),
                        24 => new NamedPresentationTableElm().Read(br),
                        _ => null,
                    },
                    // table header
                    96 => ehdr.Level switch
                    {
                        1 => new LevelTable().Read(br),
                        2 => new FontTable().Read(br),
                        3 => new TextStyleTable().Read(br),
                        4 => new FilterTable().Read(br),
                        5 => new DimStyleTable().Read(br),
                        6 => new MLineStyleTable().Read(br),
                        7 => new LStyleNameTable().Read(br),
                        8 => new LStyleDefTable().Read(br),
                        9 => new DictionaryTable().Read(br),
                        10 => new RegAppTable().Read(br),
                        11 => new ColorBookTable().Read(br),
                        16 => new SymbolStyleTable().Read(br),
                        17 => new ColorBook().Read(br),
                        18 => new MaterialPaletteTable().Read(br),
                        19 => new LevelNameDictionaryTable().Read(br),
                        20 => new AnimationParameterTable().Read(br),
                        21 => new AnimationScheduleInfoTable().Read(br),
                        22 => new RenderSetupTable().Read(br),
                        23 => new LightSetupTable().Read(br),
                        24 => new NamedPresentationTable().Read(br),
                        _ => null,
                    },
                    // view group element
                    97 => new ViewGroupElm().Read(br),
                    // view element
                    98 => new ViewElm().Read(br),
                    // level mask element
                    99 => new LevelMaskElm().Read(br),
                    // reference file element
                    100 => new ReferenceFileElm().Read(br),
                    // matrix header
                    101 => new MatrixHeaderElm().Read(br),
                    // matrix int data
                    102 => new MatrixIntDataElm().Read(br),
                    // matrix double data
                    103 => new MatrixDoubleDataElm().Read(br),
                    // extended element (non-graphic) (complex)
                    107 => new ExtendedNonGraphicElm().Read(br),
                    // reference override element
                    108 => null,
                    // named group header
                    110 => new NamedGroupHeaderElm().Read(br),
                    // named group component
                    111 => new NamedGroupComponentElm().Read(br),
                    _ => null,
                };
            }
        }

        private static TreeNode FindNode(string searchKey)
        {
            //var result = Tree.Descendants().Single(d => d.Name == searchKey);
            var result = Tree.Nodes.Find(searchKey, true).FirstOrDefault();
            if (result != null)
                return result;
            return null;
        }

        private static TreeNode FindNode(TreeNode pNode, string searchKey)
        {
            //var result = pNode.Descendants().Single(d => d.Name == searchKey);
            var result = pNode.Nodes.Find(searchKey, false).FirstOrDefault();
            if (result != null)
                return result;
            return null;
        }

        private static void V8ParseCaches()
        {
            AddDefaultNodesToTree();
            for (int i = 0; i < CMFileInfo.NumFiles; i++)
            {
                for (int j = 0; j < CMFileInfo.Files[i].NumNonModelCaches; j++)
                {
                    V8ParseCache("NonModel", -1, j, CMFileInfo.Files[i].NonModelCaches[j], 0);
                }

                for (int j = 0; j < CMFileInfo.Files[i].NumModels; j++)
                {
                    for (int k = 0; k < CMFileInfo.Files[i].Caches[j].NumGraphicCaches; k++)
                    {
                        if (CMFileInfo.Files[i].Caches[j].Valid)
                            V8ParseCache("Graphics", j, k, CMFileInfo.Files[i].Caches[j].GraphicCaches[k], 0);
                    }

                    for (int k = 0; k < CMFileInfo.Files[i].Caches[j].NumControlCaches; k++)
                    {
                        if (CMFileInfo.Files[i].Caches[j].Valid)
                            V8ParseCache("Control", j, k, CMFileInfo.Files[i].Caches[j].ControlCaches[k], 0);
                    }
                }
            }
        }

        private static void AddDefaultNodesToTree()
        {
            // create tree & some nodes
            Tree = new Tree();
            // Root Node
            RootNode = new TreeNode("Root")
            {
                Name = "0",
                Tag = null
            };
            Tree.Nodes.Add(RootNode);

            // NonModel
            var NonModelNode = new TreeNode("NonModel")
            {
                Name = "-1",
                Tag = null
            };
            RootNode.Nodes.Add(NonModelNode);

            // Models
            var ModelsNode = new TreeNode("Models")
            {
                Name = "-2",
                Tag = null
            };
            RootNode.Nodes.Add(ModelsNode);

            for (int i = 0; i < CMFileInfo.Files[0].ModelIndex.NumModels; i++)
            {
                // get model id
                var modelId = CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId;
                // for each model a model node
                var ModelNode = new TreeNode("Model #" + modelId.ToString())
                {
                    Name = (-3 * (modelId + 1)).ToString(),
                    Tag = null
                };
                ModelsNode.Nodes.Add(ModelNode);

                // for each model node a graphics & control node
                var GraphicsNode = new TreeNode("Graphics")
                {
                    Name = (-3 * (modelId + 1) - 1).ToString(),
                    Tag = null
                };
                ModelNode.Nodes.Add(GraphicsNode);

                var ControlNode = new TreeNode("Control")
                {
                    Name = (-3 * (modelId + 1) - 2).ToString(),
                    Tag = null
                };
                ModelNode.Nodes.Add(ControlNode);
            }
        }

        private static void V8ParseCache(string cacheType, int modelNum, int cacheNum, Cache cache, int level)
        {
            Elm_hdr ehdr;
            Disp_hdr dhdr;
            int componentCount;
            var parentNode = FindNode(modelNum == -1 ? "-1" : (cacheType == "Graphics" ? (-3 * (modelNum + 1) - 1).ToString() : (-3 * (modelNum + 1) - 2).ToString()));
            if (parentNode == null)
                return;

            string streamName = Path.GetFileNameWithoutExtension(CMFileInfo.Files[CMFileInfo.NumFiles - 1].FileName) + string.Format("_{0}_{1}.{2}", modelNum + 1, cacheNum, cacheType);
            using StreamWriter sw = new(streamName);
            using MemoryStream ms = new(cache.Bytes);
            int pos = 4;
            ms.Seek(pos, SeekOrigin.Begin);
            using BinaryReader br = new(ms);
            while (pos + Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long) <= cache.Size)
            {
                var cachePos = pos;
                ehdr = new Elm_hdr().Read(br);
                if (2 * ehdr.ElementSize < Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long))
                {
                    // invalid element
                    // skip it
                    ehdr.ElementSize = (uint)(Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long) / 2);
                }

                // do we have a Disp_hdr ??
                dhdr = new Disp_hdr();
                if (ehdr.IsGraphics != 0)
                {
                    dhdr = new Disp_hdr().Read(br);
                }

                // seek to next element
                pos += (int)(2 * ehdr.ElementSize + 4);
                // do we have a complex header element ??
                int nextPos = pos;

                if (ehdr.IsComplexHeader != 0)
                {
                    componentCount = br.ReadInt32();

                    var ident = new String(' ', 2 * level);
                    sw.WriteLine($"{ident}id={ehdr.UniqueId:X16}");
                    sw.WriteLine($"{ident}cache pos={cachePos} ({cachePos:X})");
                    sw.WriteLine($"{ident}component count={componentCount}");
                    sw.WriteLine();

                    ehdr.Dump(sw, level);
                    sw.WriteLine();
                    if (ehdr.IsGraphics != 0)
                    {
                        dhdr.Dump(sw, level);
                        sw.WriteLine();
                    }

                    // save stream position
                    var currentPosition = br.BaseStream.Position;

                    // read bytes
                    br.BaseStream.Seek(cachePos, SeekOrigin.Begin);
                    byte[] bytes = br.ReadBytes((int)(2 * ehdr.AttrOffset));
                    byte[] attributes = br.ReadBytes((int)(2 * (ehdr.ElementSize - ehdr.AttrOffset)));

                    // dump the element
                    sw.WriteLine($"{Utils.HexDump(bytes, level)}");
                    Utils.WriteOut(bytes, streamName, ElementType, ElementId, LevelId);

                    {
                        Linkage[] linkages = V8Linkages.V8GetLinkages(br, ehdr);
                        for (int i = 0; i < linkages?.Length; i++)
                        {
                            Utils.WriteOutAttr(bytes, streamName, ElementType, ElementId, LevelId, linkages[i]);
                        }
                    }

                    // dump the linkages
                    if (attributes.Length > 0)
                    {
                        sw.WriteLine($"{Utils.HexDump(attributes, level)}");
                    }

                    // restore stream position
                    br.BaseStream.Seek(currentPosition, SeekOrigin.Begin);

                    var Node = new TreeNode(ehdr.UniqueId.ToString("X16"))
                    {
                        Name = ehdr.UniqueId.ToString("X16"),
                        Tag = new ElementTag
                        {
                            CacheType = cacheType,
                            ModelNum = modelNum,
                            CacheNum = cacheNum,
                            CachePos = cachePos,
                            ElementHeader = ehdr,
                            DisplayHeader = dhdr,
                            ComponentCount = componentCount,
                            ParentId = (UInt64)Convert.ToInt64(parentNode.Name),
                            ElementId = ehdr.UniqueId
                        }
                    };

                    parentNode.Nodes.Add(Node);

                    nextPos = ReadComponents(sw, parentNode, pos, componentCount, ehdr.UniqueId, cacheType, modelNum, cacheNum, cache, br, level + 1);
                }
                else
                {
                    componentCount = 0;

                    var ident = new String(' ', 2 * level);
                    sw.WriteLine($"{ident}id={ehdr.UniqueId:X16}");
                    sw.WriteLine($"{ident}cache pos={cachePos} ({cachePos:X})");
                    sw.WriteLine($"{ident}component count={componentCount}");
                    sw.WriteLine();

                    ehdr.Dump(sw, level);
                    sw.WriteLine();
                    if (ehdr.IsGraphics != 0)
                    {
                        dhdr.Dump(sw, level);
                        sw.WriteLine();
                    }

                    // save stream position
                    var currentPosition = br.BaseStream.Position;

                    // read bytes
                    br.BaseStream.Seek(cachePos, SeekOrigin.Begin);
                    byte[] bytes = br.ReadBytes((int)(2 * ehdr.AttrOffset));
                    byte[] attributes = br.ReadBytes((int)(2 * (ehdr.ElementSize - ehdr.AttrOffset)));

                    // dump the element
                    sw.WriteLine($"{Utils.HexDump(bytes, level)}");
                    Utils.WriteOut(bytes, streamName, ElementType, ElementId, LevelId);

                    {
                        Linkage[] linkages = V8Linkages.V8GetLinkages(br, ehdr);
                        for (int i = 0; i < linkages?.Length; i++)
                        {
                            Utils.WriteOutAttr(bytes, streamName, ElementType, ElementId, LevelId, linkages[i]);
                        }
                    }

                    // dump the linkages
                    if (attributes.Length > 0)
                    {
                        sw.WriteLine($"{Utils.HexDump(attributes, level)}");
                    }

                    // restore stream position
                    br.BaseStream.Seek(currentPosition, SeekOrigin.Begin);

                    var Node = new TreeNode(ehdr.UniqueId.ToString("X16"))
                    {
                        Name = ehdr.UniqueId.ToString("X16"),
                        Tag = new ElementTag
                        {
                            CacheType = cacheType,
                            ModelNum = modelNum,
                            CacheNum = cacheNum,
                            CachePos = cachePos,
                            ElementHeader = ehdr,
                            DisplayHeader = dhdr,
                            ComponentCount = componentCount,
                            ParentId = (UInt64)Convert.ToInt64(parentNode.Name),
                            ElementId = ehdr.UniqueId
                        }
                    };

                    parentNode.Nodes.Add(Node);
                }

                ms.Seek(nextPos, SeekOrigin.Begin);
                pos = nextPos;
            }

            // clear parentNode children

            //parentNode.Clear();
        }

        private static int ReadComponents(StreamWriter sw, TreeNode pNode, int pos, int componentCount, UInt64 parentId, string cacheType, int modelNum, int cacheNum, Cache cache, BinaryReader br, int level)
        {
            Elm_hdr ehdr;
            Disp_hdr dhdr;
            int nextComponentCount;

            var parentNode = FindNode(pNode, parentId.ToString("X16"));
            if (parentNode == null)
            {
                Debugger.Break();
                return -1;
            }

            var nextPos = pos;
            br.BaseStream.Seek(pos, SeekOrigin.Begin);
            for (int i = 0; i < componentCount; i++)
            {
                var cachePos = br.BaseStream.Position;
                (ehdr, dhdr, nextComponentCount, nextPos) = ReadComponent(sw, pNode, nextPos, parentId, /*cacheType, modelNum, cacheNum,*/ cache, br, level);

                var Node = new TreeNode(ehdr.UniqueId.ToString("X16"))
                {
                    Name = ehdr.UniqueId.ToString("X16"),
                    Tag = new ElementTag
                    {
                        CacheType = cacheType,
                        ModelNum = modelNum,
                        CacheNum = cacheNum,
                        CachePos = (int)cachePos,
                        ElementHeader = ehdr,
                        DisplayHeader = dhdr,
                        ComponentCount = nextComponentCount,
                        ParentId = parentId,
                        ElementId = ehdr.UniqueId
                    }
                };

                parentNode.Nodes.Add(Node);

                if (ehdr.IsComplexHeader != 0)
                {
                    nextPos = ReadComponents(sw, parentNode, nextPos, nextComponentCount, ehdr.UniqueId, cacheType, modelNum, cacheNum, cache, br, level + 1);
                    i += nextComponentCount;
                }
                else
                {

                }

                try
                {
                    br.BaseStream.Seek(nextPos, SeekOrigin.Begin);
                }
                catch (Exception)
                {

                }
            }

            return nextPos;
        }

        private static (Elm_hdr ehdr, Disp_hdr dhdr, int componentCount, int nextPos) ReadComponent(StreamWriter sw, TreeNode pNode, int pos, ulong parentId, /*string cacheType, int modelNum, int cacheNum,*/ Cache cache, BinaryReader br, int level)
        {
            Elm_hdr ehdr;
            Disp_hdr dhdr;
            int componentCount;
            int nextPos;
            int cachePos = pos;

            var parentNode = FindNode(pNode, parentId.ToString("X16"));
            if (parentNode == null)
            {
                Debugger.Break();
                return (new Elm_hdr(), new Disp_hdr(), 0, -1);
            }

            if (pos + Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long) <= cache.Size)
            {
                ehdr = new Elm_hdr().Read(br);
                if (2 * ehdr.ElementSize < Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long))
                {
                    // invalid element
                    // skip it
                    ehdr.ElementSize = (uint)(Marshal.SizeOf(typeof(Elm_hdr)) - sizeof(long) / 2);
                }

                // do we have a Disp_hdr ??
                dhdr = new Disp_hdr();
                if (ehdr.IsGraphics != 0)
                {
                    dhdr = new Disp_hdr().Read(br);
                }


                // seek to next element
                pos += (int)(2 * ehdr.ElementSize + 4);
                // do we have a complex header element ??
                nextPos = pos;
                if (ehdr.IsComplexHeader != 0)
                {
                    componentCount = br.ReadInt32();
                }
                else
                {
                    componentCount = 0;
                }

                var ident = new String(' ', 2 * level);
                sw.WriteLine($"{ident}id={ehdr.UniqueId:X16}");
                sw.WriteLine($"{ident}cache pos={cachePos} ({cachePos:X})");
                sw.WriteLine($"{ident}component count={componentCount}");
                sw.WriteLine();

                ehdr.Dump(sw, level);
                sw.WriteLine();
                if (ehdr.IsGraphics != 0)
                {
                    dhdr.Dump(sw, level);
                    sw.WriteLine();
                }

                // save stream position
                var currentPosition = br.BaseStream.Position;

                // read bytes
                br.BaseStream.Seek(cachePos, SeekOrigin.Begin);
                byte[] bytes = br.ReadBytes((int)(2 * ehdr.AttrOffset));
                byte[] attributes = br.ReadBytes((int)(2 * (ehdr.ElementSize - ehdr.AttrOffset)));

                // dump the element
                sw.WriteLine($"{Utils.HexDump(bytes, level)}");
                Utils.WriteOut(bytes, (sw.BaseStream as FileStream)?.Name, ElementType, ElementId, LevelId);

                {
                    Linkage[] linkages = V8Linkages.V8GetLinkages(br, ehdr);
                    for (int i = 0; i < linkages?.Length; i++)
                    {
                        Utils.WriteOutAttr(bytes, (sw.BaseStream as FileStream)?.Name, ElementType, ElementId, LevelId, linkages[i]);
                    }
                }

                // dump the linkages
                if (attributes.Length > 0)
                {
                    sw.WriteLine($"{Utils.HexDump(attributes, level)}");
                }

                // restore stream position
                br.BaseStream.Seek(currentPosition, SeekOrigin.Begin);

                br.BaseStream.Seek(nextPos, SeekOrigin.Begin);
                return (ehdr, dhdr, componentCount, nextPos);
            }

            return (new Elm_hdr(), new Disp_hdr(), 0, -1);
        }

        private static string V8GetModelName(int modelId)
        {
            return CMFileInfo.Files[0].ModelIndex.ModelIndexItems.Single(mi => mi.ModelId == modelId).ModelName;
        }
    }
}
