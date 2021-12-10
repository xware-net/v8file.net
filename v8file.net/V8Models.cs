using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace v8file.net
{
    public class V8Models
    {
        public static void V8GetModelIndexInformation()
        {
            // get information from Dgn_Ix@Dgn~Mix stream
            byte[] bytes = File.ReadAllBytes(@"Dgn_Ix@Dgn~Mix");
            V8FileManipulation.CMFileInfo.Files[0].ModelIndex = new ModelIndex();
            V8FileManipulation.CMFileInfo.Files[0].ModelIndex.Read(bytes);
        }

        public static void V8DumpModelInformation(StreamWriter sw = null)
        {
            if (sw != null)
            {
                sw.WriteLine($"> Model Index Information");
                for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].ModelIndex.NumModels; i++)
                {
                    sw.WriteLine($"    Model Index Item >");
                    sw.WriteLine($"      Model Index Item Id                = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId}");
                    sw.WriteLine($"      Model Index Item Name              = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelName}");
                    sw.WriteLine($"      Model Index Item Description       = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelDescription}");
                    sw.WriteLine($"      Model Index Item Last Saved Time   = {Utils.V8BentleyTime(V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].LastSavedTime)}");
                    Dict.Instance.Models.Add((UInt32)V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId);
                }
            }
            else
            {
                for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
                {
                    if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                    {
                        V8DumpModelInfoFromCache(V8FileManipulation.CMFileInfo.Files[0].Caches[i]);
                    }
                }
            }
        }

        private static void V8DumpModelInfoFromCache(DgnCache dgnCache)
        {
            string modelFileName = Path.GetFileNameWithoutExtension(V8FileManipulation.CMFileInfo.Files[V8FileManipulation.CMFileInfo.NumFiles - 1].FileName) + "_" + dgnCache.ModelName + ".model";
            using BinaryWriter bw = new(File.Open(modelFileName, FileMode.Create));

            using MemoryStream ms = new(dgnCache.ModelCache.Bytes);
            using BinaryReader br = new(ms);
            ms.Seek(0x1004, SeekOrigin.Begin);
            var modelHeaderElm = new ModelHeaderElm().Read(br);
            br.BaseStream.Seek(0x1004, SeekOrigin.Begin);
            var bytes = br.ReadBytes((int)(2 * modelHeaderElm.Ehdr.AttrOffset/*.ElementSize*/));
            var type = modelHeaderElm.Ehdr.Type;
            if (type == 66)
{
                Linkage[] linkages = V8Linkages.V8GetLinkages(br, modelHeaderElm.Ehdr);
                for (int i=0; i<linkages.Length; i++)
                {
                    string modelLinkagesFileName = Path.GetFileNameWithoutExtension(V8FileManipulation.CMFileInfo.Files[V8FileManipulation.CMFileInfo.NumFiles - 1].FileName) + "_" + dgnCache.ModelName + "_" + i.ToString() + "." + linkages[i]./*Type*/LinkageHeader.PrimaryID.ToString("X");
                    using BinaryWriter bwl = new(File.Open(modelLinkagesFileName, FileMode.Create));
                    bwl.Write(linkages[i].Data, 0, linkages[i].Data.Length);

                    // and set to move it to OutDir
                    Utils.AddToLinkagesDictionary(-1, "*", "*", modelLinkagesFileName);
                }
                bw.Write(bytes, 0, bytes.Length);
            }
        }

        public static void V8GetModelsInformation()
        {
            // all models must exist in model index
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
            {
                if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                {
                    var modelExistsInIndex = V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems.Any(mii => mii.ModelId == V8FileManipulation.CMFileInfo.Files[0].Caches[i].ModelNum);
                    if (!modelExistsInIndex)
                        Debugger.Break();
                }
            }

            // all models in model index must exist in models
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].ModelIndex.NumModels; i++)
            {
                var modelId = V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId;
                var modelIndexExistsInModels = V8FileManipulation.CMFileInfo.Files[0].Caches.Any(mii => mii.Valid && mii.ModelNum == modelId);
                if (!modelIndexExistsInModels)
                    Debugger.Break();
            }

            // now get information about each model
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
            {
                if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                {
                    V8GetModelInfoFromCache(V8FileManipulation.CMFileInfo.Files[0].Caches[i]);
                }
            }
        }

        public static ModelInfo V8GetModelInfoFromCache(DgnCache cache)
        {
            var modelInfo =  new ModelInfo();
            var modelCache = cache.ModelCache;

            using MemoryStream ms = new(modelCache.Bytes);
            using BinaryReader br = new(ms);

            // what are bytes (ints) at 0x00, 0x04, 0x08 ???
            ms.Seek(0x1004, SeekOrigin.Begin);
            var modelHeaderElm = new ModelHeaderElm().Read(br);

            modelInfo.ModelId = cache.ModelNum;
            modelInfo.ModelName = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            modelInfo.ModelDescription = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            modelInfo.DefaultRefLogical = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_DefaultRefLogical);
            modelInfo.MasterUnit = new UnitDefinition
            {
                Numerator = modelHeaderElm.MuNumerator,
                Denominator = modelHeaderElm.MuDenominator,
                Base = (UnitBase)(modelHeaderElm.MasterUnitFlags.Base),
                System = (UnitSystem)(modelHeaderElm.MasterUnitFlags.System),
                Label = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_MastUnitLabel)
            };
            modelInfo.MasterUnitLabel = modelInfo.MasterUnit.Label;
            modelInfo.SubUnit = new UnitDefinition
            {
                Numerator = modelHeaderElm.SuNumerator,
                Denominator = modelHeaderElm.SuDenominator,
                Base = (UnitBase)(modelHeaderElm.SubUnitFlags.Base),
                System = (UnitSystem)(modelHeaderElm.SubUnitFlags.System),
                Label = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_SubUnitLabel)
            };
            modelInfo.SubUnitLabel = modelInfo.SubUnit.Label;
            modelInfo.StorageUnit = new UnitDefinition
            {
                Numerator = modelHeaderElm.StNumerator,
                Denominator = modelHeaderElm.StDenominator,
                Base = (UnitBase)(modelHeaderElm.StorageUnitFlags.Base),
                System = (UnitSystem)(modelHeaderElm.StorageUnitFlags.System),
                Label = string.Empty
            };
            modelInfo.UorPerSub = modelHeaderElm.UorsPerStorage * (modelHeaderElm.StNumerator / modelHeaderElm.StDenominator) / (modelHeaderElm.SuNumerator / modelHeaderElm.SuDenominator);
            modelInfo.UorPerStorage = modelHeaderElm.UorsPerStorage;
            modelInfo.UorPerMaster = modelHeaderElm.UorsPerStorage * (modelHeaderElm.StNumerator / modelHeaderElm.StDenominator) / (modelHeaderElm.MuNumerator / modelHeaderElm.MuDenominator);
            modelInfo.SubPerMaster = (modelHeaderElm.SuNumerator / modelHeaderElm.SuDenominator) / (modelHeaderElm.MuNumerator / modelHeaderElm.MuDenominator);
            modelInfo.LastModified = modelHeaderElm.LastModified;
            modelInfo.GlobalOrigin = modelHeaderElm.GlobalOrigin;
            modelInfo.GridPerReference = modelHeaderElm.GridPerReference;
            modelInfo.UorPerGrid = modelHeaderElm.UorPerGrid;
            modelInfo.GridBase = modelHeaderElm.GridBase;
            modelInfo.GridRatio = modelHeaderElm.GridRatio;
            modelInfo.GridAngle = modelHeaderElm.GridAngle;
            modelInfo.ModelType = (int)(modelHeaderElm.Dummy1 & 0xFFFF0000) >> 16;
            modelInfo.DgnModelType = (DgnModelType)modelInfo.ModelType;
            if (modelInfo.DgnModelType == DgnModelType.Sheet)
            {
                // complete the SheetDef & SheetDefScale
            }
            modelInfo.AcsOrigin = modelHeaderElm.AcsOrigin;
            modelInfo.AcsRotMatrix.Form3d = new double[3, 3];
            modelInfo.AcsRotMatrix = modelHeaderElm.AcsRotMatrix;
            modelInfo.AcsScale = modelHeaderElm.AcsScale;
            modelInfo.AcsType = (int)(modelHeaderElm.Dummy2 & 0x0000FFFF);
            modelInfo.ACSType = (ACSType)modelInfo.AcsType;
            modelInfo.Rng = modelHeaderElm.Rng;
            modelInfo.RoundOffUnit = modelHeaderElm.RoundoffUnit;
            modelInfo.RoundOffRatio = modelHeaderElm.RoundoffRatio;
            modelInfo.InsertionBase = modelHeaderElm.InsertionBase;
            modelInfo.Azimuth = modelHeaderElm.Azimuth;
            modelInfo.SolidExtent = modelHeaderElm.SolidExtent;
            modelInfo.LineStyleScale = modelHeaderElm.LineStyleScale;
            modelInfo.AcsElementId = modelHeaderElm.AcsElementId;
            modelInfo.DirectionBaseDir = modelHeaderElm.DirectionBaseDir;
            modelInfo.Transparency = modelHeaderElm.Transparency;
            modelInfo.BackgroundColor = modelHeaderElm.BackgroundColor;
            modelInfo.SettingFlags = modelHeaderElm.SettingsFlags;
            modelInfo.SettingFlags1 = modelHeaderElm.SettingFlags1;
            modelInfo.PropertyFlags = modelHeaderElm.PropertyFlags;
            return modelInfo;
        }
    }
}
