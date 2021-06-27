using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ModelId = System.UInt32;
using T_Adouble = System.Double;

namespace v8file.net
{
    public struct Cache
    {
        public int Size;
        public byte[] Bytes;
    };

    public struct DgnCache
    {
        public bool Valid;
        public int ModelNum;
        public DgnFileObj DgnFileObj;
        public string ModelName;                    // name of the model
        public Cache ModelCache;                    // load the Dgn^Mh
        public int NumControlCaches;
        public Cache[] ControlCaches;               // load the Dgn^C...
        public int NumControlAttributesCaches;
        public Cache[] ControlAttributesCaches;     // load the Dgn^CA...
        public int NumGraphicCaches;
        public Cache[] GraphicCaches;               // load the Dgn^G...
        public int NumGraphicAttributesCaches;
        public Cache[] GraphicAttributesCaches;     // load the Dgn^GA...
    };

    public struct ModelHeaderElm
    {
        public Elm_hdr Ehdr;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 Dummy3;
        public UInt32 Dummy4;
        public UInt32 Dummy5;
        public UInt32 Dummy6;
        public UInt32 Dummy7;
        public UInt32 GridPerReference;
        public UInt32 Dummy9;
        public UInt32 Dummy10;
        public UInt32 Dummy11;
        public UInt32 Dummy12;
        public double MuNumerator;
        public double MuDenominator;
        public double SuNumerator;
        public double SuDenominator;
        public DPoint3d GlobalOrigin;
        public double LastModified; /* last time this element was changed */
        public Int64 Y0;
        public Int64 Y1;
        public Int64 Y2;
        public Int64 Y3;
        public Int64 Y4;
        public Int64 Y5;
        public Int64 Y6;
        public Int64 Y7;
        public Int64 Y8;
        public Int64 Y9;
        public double UorsPerStorage;
        public double StNumerator;
        public double StDenominator;
        public double Z0;
        public double Z1;
        public double Z2;
        public double Z3;
        public double Z4;
        public double Z5;
        public double Z6;
        public double Z7;
        public double Z8;
        public double Z9;
        public double Z10;
        public double Z11;
        public double Z12;
        public double Z13;
        public double Z14;
        public double Z15;
        public double Z16;
        public double Z17;
        public double Z18;
        public double Z19;
        public double Z20;
        public double Z21;
        public double Z22;
        public double Z23;
        public double Z24;
        public double Z25;
        public double Z26;
        public double Z27;
        public double Z28;
        public double Z29;
        public double Z30;
        public Linkage[] Linkages;

        public ModelHeaderElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Dummy6 = br.ReadUInt32();
            Dummy7 = br.ReadUInt32();
            GridPerReference = br.ReadUInt32();
            Dummy9 = br.ReadUInt32();
            Dummy10 = br.ReadUInt32();
            Dummy11 = br.ReadUInt32();
            Dummy12 = br.ReadUInt32();
            MuNumerator = br.ReadDouble();
            MuDenominator = br.ReadDouble();
            SuNumerator = br.ReadDouble();
            SuDenominator = br.ReadDouble();
            GlobalOrigin = new DPoint3d().Read(br);
            LastModified = br.ReadDouble();
            Y0 = br.ReadInt64();
            Y1 = br.ReadInt64();
            Y2 = br.ReadInt64();
            Y3 = br.ReadInt64();
            Y4 = br.ReadInt64();
            Y5 = br.ReadInt64();
            Y6 = br.ReadInt64();
            Y7 = br.ReadInt64();
            Y8 = br.ReadInt64();
            Y9 = br.ReadInt64();
            UorsPerStorage = br.ReadDouble();
            StNumerator = br.ReadDouble();
            StDenominator = br.ReadDouble();
            Z0 = br.ReadDouble();
            Z1 = br.ReadDouble();
            Z2 = br.ReadDouble();
            Z3 = br.ReadDouble();
            Z4 = br.ReadDouble();
            Z5 = br.ReadDouble();
            Z6 = br.ReadDouble();
            Z7 = br.ReadDouble();
            Z8 = br.ReadDouble();
            Z9 = br.ReadDouble();
            Z10 = br.ReadDouble();
            Z11 = br.ReadDouble();
            Z12 = br.ReadDouble();
            Z13 = br.ReadDouble();
            Z14 = br.ReadDouble();
            Z15 = br.ReadDouble();
            Z16 = br.ReadDouble();
            Z17 = br.ReadDouble();
            Z18 = br.ReadDouble();
            Z19 = br.ReadDouble();
            Z20 = br.ReadDouble();
            Z21 = br.ReadDouble();
            Z22 = br.ReadDouble();
            Z23 = br.ReadDouble();
            Z24 = br.ReadDouble();
            Z25 = br.ReadDouble();
            Z26 = br.ReadDouble();
            Z27 = br.ReadDouble();
            Z28 = br.ReadDouble();
            Z29 = br.ReadDouble();
            Z30 = br.ReadDouble();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }
    };

    public struct ModelInfo
    {
        public int CellType;
        public int ModelId;
        public string ModelName;
        public string ModelDescription;
        public int ModelType;
        public DgnModelType DgnModelType;
        public double UorPerMaster;
        public double UorPerSub;
        public double SubPerMaster;
        public double UorPerStorage;
        public UnitInfo StorageUnit;
        public UnitInfo MasterUnit;
        public UnitInfo SubUnit;
        public string MasterUnitLabel;
        public string SubUnitLabel;
        public DPoint3d GlobalOrigin;
        public double UorPerGrid;
        public UInt32 GridPerRefernce;
        public double GridRatio;
        public DPoint2d GridBase;
        public double GridAngle;
        public double RoundOffUnit;
        public double RoundOffRatio;
        public double LastModified;
        public DPoint3d AcsOrigin;
        public RotMatrix AcsRotMatrix;
        public ScanRange Rng;

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ModelId={ModelId}");
            sw.WriteLine($"{ident}ModelName=\"{ModelName}\"");
            sw.WriteLine($"{ident}ModelDescription=\"{ModelDescription}\"");
            sw.WriteLine($"{ident}DgnModelType={DgnModelType}");
        }
    };

    public struct DgnFileObj
    {
        public string FileName;
        public int MajorVersion;
        public int MinorVersion;
        public int HighestModelId;
        public int DefaultModelId;
        public ulong HighestElementId;
        public double LastSavedTime;
        public int NumModels;                       // number of models in file
        public ModelInfo[] Models;                  // models in file
        public ModelIndex ModelIndex;               // model index in file
        public DgnCache[] Caches;                   // caches in file (a cache for each model)
        public int NumNonModelCaches;               // the same for each model
        public Cache[] NonModelCaches;              // load the Dgn^Nm...
        public int NumNonModelAttributesCaches;     // the same for each model
        public Cache[] NonModelAttributesCaches;    // load the Dgn^Nm...
    };

    public struct CmFileInfo
    {
        public int NumFiles;
        public DgnFileObj[] Files;
    };

    public struct XAttribute
    {
        public Int32 XAttributeHandler;
        public Int32 AttributeId;
        public UInt32 Size;
        public Int32 Dummy2;
        public string Data;

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            if ((XAttributeHandler == 0x570b0003) ||
              (XAttributeHandler == 0x570b0004) ||
              (XAttributeHandler == 0x570b0005))
            {
                sw.WriteLine($"{ident}xattribute, handler=0x{XAttributeHandler:X8}, size={Size} is {Data}");
            }
            else
            {
                sw.WriteLine($"{ident}xattribute, handler=0x{XAttributeHandler:X8}, size={Size}");
            }
        }
    };

    public class ModelIndex
    {
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 NumModels;
        public UInt32 Dummy3;
        public ModelIndexItem[] ModelIndexItems;

        public void Read(byte[] bytes)
        {
            using MemoryStream ms = new(bytes);
            using BinaryReader br = new(ms, System.Text.Encoding.Unicode);
            // read each field
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            NumModels = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();

            ModelIndexItems = new ModelIndexItem[NumModels];
            for (int i = 0; i < NumModels; i++)
            {
                ModelIndexItems[i].Read(br);
            }
        }
    }

    public struct ModelIndexItem
    {
        public UInt32 Dummy;
        public Int32 ModelId;
        public double LastSavedTime;
        public DgnModelType DgnModelType;
        public CellLibraryType CellLibraryType;
        public string ModelName;
        public string ModelDescription;
        public UInt16 ModelIndexSize;
        public UInt16 NameLength;
        public UInt16 DescriptionLength;
        public UInt16 Dummy2;
        public UInt16 Dummy3;
        public UInt16 Dummy4;
        public UInt32 Dummy5;
        public UInt32 Dummy6;
        public UInt32 Dummy7;
        public UInt16 Dummy8;
        public UInt16 Dummy9;

        public void Read(BinaryReader br)
        {
            // read each field
            var modelIndexPosition = br.BaseStream.Position;

            Dummy = br.ReadUInt32();
            ModelId = br.ReadInt32();
            LastSavedTime = br.ReadDouble();
            ModelIndexSize = br.ReadUInt16();
            NameLength = br.ReadUInt16();
            DescriptionLength = br.ReadUInt16();
            Dummy2 = br.ReadUInt16();
            Dummy3 = br.ReadUInt16();
            Dummy4 = br.ReadUInt16();
            Dummy5 = br.ReadUInt32();

            // read Name
            ModelName = new string(br.ReadChars(NameLength / 2));

            // read description
            ModelDescription = new string(br.ReadChars(DescriptionLength / 2));
            if (modelIndexPosition + ModelIndexSize > br.BaseStream.Position)
            {
                // normal model (not sheet)
                Dummy6 = br.ReadUInt32();
                Dummy7 = br.ReadUInt32();
                Dummy8 = br.ReadUInt16();
            }

            if (modelIndexPosition + ModelIndexSize > br.BaseStream.Position)
            {
                // normal model (not sheet)
                Dummy9 = br.ReadUInt16();
            }

            br.BaseStream.Seek(modelIndexPosition + ModelIndexSize, SeekOrigin.Begin);
        }
    }

    public struct ExtendedElm
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Padding;
        public Linkage[] Linkages;

        public ExtendedElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Padding = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            //sw.WriteLine($"{ident}Padding={Padding}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct ExtendedNonGraphicElm
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32 Padding;
        public Linkage[] Linkages;

        public ExtendedNonGraphicElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Padding = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            //sw.WriteLine($"{ident}Padding={Padding}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct ViewElm
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32 Dummy1;
        public RotMatrix RMatrix;
        public DRectangle ViewportGlobalRect;
        public DPoint3d Origin;
        public DPoint3d Delta;
        public double[] Y;
        public double ActiveZ;
        public SRectangle PixelRect;
        public ViewFlags Flags;
        public UInt32 Dummy4;
        public UInt32 ViewNumber;
        public ModelId ModelId;
        public UInt32[] Z;
        // this are extra for saved views
        public string Name;
        public string Description;
        public Linkage[] Linkages;

        public ViewElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            RMatrix = new RotMatrix().Read(br);
            ViewportGlobalRect = new DRectangle().Read(br);
            Origin = new DPoint3d().Read(br);
            Delta = new DPoint3d().Read(br);
            Y = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Y[i] = br.ReadDouble();
            }
            ActiveZ = br.ReadDouble();
            PixelRect = new SRectangle().Read(br);
            Flags = new ViewFlags().Read(br);
            Dummy4 = br.ReadUInt32();
            ViewNumber = br.ReadUInt32();
            ModelId = br.ReadUInt32();
            Z = new UInt32[8];
            for (int i = 0; i < 8; i++)
            {
                Z[i] = br.ReadUInt32();
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            Name = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            Description = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}RMatrix >");
            RMatrix.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ViewportGlobalRect >");
            ViewportGlobalRect.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Delta >");
            Delta.Dump(sw, level + 1);
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine($"{ident}Y[{i}]={Y[i]}");
            }
            sw.WriteLine($"{ident}ActiveZ={ActiveZ}");
            sw.WriteLine($"{ident}PixelRect >");
            PixelRect.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy4={Dummy4}");
            sw.WriteLine($"{ident}ViewNumber={ViewNumber}");
            sw.WriteLine($"{ident}ModelId={ModelId}");
            for (int i = 0; i < 8; i++)
            {
                sw.WriteLine($"{ident}Z[{i}]={Z[i]}");
            }
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Name={Name}");
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Description={Description}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }

        public bool IsNamed => !string.IsNullOrEmpty(Name) && ViewNumber >= 0 && ViewNumber <= 7;
    }

    public struct ViewGroupElm
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        //public ViewElm[] Views;
        //public Bitmask[] ViewLevelsMasks;
        public ModelId ModelId;

        // extras
        public string Name;
        public string Description;
        public Linkage[] Linkages;

        public ViewGroupElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            //Views = new 


            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            Name = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            Description = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");


            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Name={Name}");
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Description={Description}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct Bitmask
    {
        public Int32 Size;
        public byte[] Bits;

        public Bitmask Read(BinaryReader br)
        {
            // read each field
            Size = br.ReadInt32();
            Bits = new byte[2 * Size];
            Bits = br.ReadBytes(2 * Size);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
        }

        public override string ToString()
        {
            return BitConverter.ToString(Bits).Replace("-", ",");
        }
    }

    public struct BitmaskOld
    {
        public Int32 Size;
        public byte[] Bits;

        public BitmaskOld Read(BinaryReader br)
        {
            // read each field
            Size = br.ReadInt32();
            Bits = new byte[Size / 8];
            Bits = br.ReadBytes(Size / 8);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}TODO=");
        }
    }

    public struct DimensionElm          // 33
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        // TODO
        public Linkage[] Linkages;

        public DimensionElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public enum MeshStyles : int
    {
        FaceLoops = 1,
        PointCloud = 2,
        TriangleList = 3,
        QuadList = 4,
        TriangleGrid = 5,
        QuadGrid = 6,
        LargeMesh = 7
    };

    public class MeshHeaderElm
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 MeshStyle;
        public Linkage[] Linkages;

        public MeshHeaderElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            MeshStyle = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}MeshStyle={(MeshStyles)MeshStyle}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public class MatrixHeaderElm
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32[] Dummy;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 Dummy3;
        public UInt32 Dummy4;
        public UInt32 Dummy5;
        // TODO
        public Linkage[] Linkages;

        public MatrixHeaderElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Dummy = new UInt32[18];
            for (int i = 0; i < 18; i++)
            {
                Dummy[i] = br.ReadUInt32();
            }

            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            for (int i = 0; i < 18; i++)
            {
                if (Dummy[i] != 0x00000000)
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!");
                    Debugger.Break();
                }
                sw.WriteLine($"{ident}Dummy[{i}]={Dummy[i]}");
            }

            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}Dummy3={Dummy3}");
            sw.WriteLine($"{ident}Dummy4={Dummy4}");
            sw.WriteLine($"{ident}Dummy5={Dummy5}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public class FaceIndexes
    {
        public UInt32 I1;
        public UInt32 I2;
        public UInt32 I3;
        public UInt32 I4;

        public FaceIndexes Read(BinaryReader br)
        {
            // read each field
            I1 = br.ReadUInt32();
            I2 = br.ReadUInt32();
            I3 = br.ReadUInt32();
            I4 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}(I1,I2,I3,I4)=({I1},{I2},{I3},{I4})");
        }
    }

    public class MatrixIntDataElm
    {
        public Elm_hdr Ehdr;
        public UInt32[] Dummy;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 Dummy3;
        public UInt32 Dummy4;
        public UInt32 NumFaces;
        public FaceIndexes[] Faces;
        // TODO
        public Linkage[] Linkages;

        public MatrixIntDataElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dummy = new UInt32[18];
            for (int i = 0; i < 18; i++)
            {
                Dummy[i] = br.ReadUInt32();
            }

            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            NumFaces = (2 * Ehdr.AttrOffset - 0x78) / (4 * sizeof(UInt32));
            Faces = new FaceIndexes[NumFaces];
            for (int i = 0; i < NumFaces; i++)
            {
                Faces[i] = new FaceIndexes().Read(br);
            }

            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            for (int i = 0; i < 18; i++)
            {
                if (Dummy[i] != 0x00000000)
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine($"{ident}Dummy[{i}]={Dummy[i]}");
                    Debugger.Break();
                }
            }

            if (Dummy1 != Dummy2)
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!&");
                sw.WriteLine($"{ident}Dummy1={Dummy1}");
                sw.WriteLine($"{ident}Dummy2={Dummy2}");
                Debugger.Break();
            }

            if ((Dummy3 != 0x00001122) && (Dummy3 != 0x00001121))
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!§");
                sw.WriteLine($"{ident}Dummy3={Dummy3}");
                Debugger.Break();
            }

            if (Dummy4 != 0x00000000)
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!%");
                sw.WriteLine($"{ident}Dummy4={Dummy4}");
                Debugger.Break();
            }

            sw.WriteLine($"{ident}NumFaces={NumFaces}");
            for (int i = 0; i < NumFaces; i++)
            {
                sw.WriteLine($"{ident}Faces[{i}] >");
                Faces[i].Dump(sw, level + 1);
            }

            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public class MatrixDoubleDataElm
    {
        public Elm_hdr Ehdr;
        public UInt32[] Dummy;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 Dummy3;
        public UInt32 Dummy4;
        // TODO
        public Linkage[] Linkages;

        public MatrixDoubleDataElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dummy = new UInt32[18];
            for (int i = 0; i < 18; i++)
            {
                Dummy[i] = br.ReadUInt32();
            }

            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            for (int i = 0; i < 18; i++)
            {
                if (Dummy[i] != 0x00000000)
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine($"{ident}Dummy[{i}]={Dummy[i]}");
                    Debugger.Break();
                }
            }

            if (Dummy1 != Dummy2)
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!&");
                sw.WriteLine($"{ident}Dummy1={Dummy1}");
                sw.WriteLine($"{ident}Dummy2={Dummy2}");
                Debugger.Break();
            }

            if ((Dummy3 != 0x00000133) && (Dummy3 != 0x00000031) && (Dummy3 != 0x00000000))
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!§");
                sw.WriteLine($"{ident}Dummy3={Dummy3}");
                Debugger.Break();
            }

            if (Dummy4 != 0x00000000)
            {
                sw.WriteLine("!!!!!!!!!!!!!!!!!%");
                sw.WriteLine($"{ident}Dummy4={Dummy4}");
                Debugger.Break();
            }

            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public class LevelMaskElm
    {
        public Elm_hdr Ehdr;
        public UInt32 Dummy1;
        public UInt16 Dummy2;
        public UInt16 ViewNumber;
        public UInt64 ReferenceId;  // an ElementId for a REFERENCE_ATTACH_ELM
        public BitmaskOld BitmaskOld;
        public Linkage[] Linkages;

        public LevelMaskElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt16();
            ViewNumber = br.ReadUInt16();
            ReferenceId = br.ReadUInt64();
            BitmaskOld = new BitmaskOld().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}ViewNumber={ViewNumber}");
            sw.WriteLine($"{ident}ReferenceId=0x{ReferenceId:X16}");
            sw.WriteLine($"{ident}Bitmask Old >");
            BitmaskOld.Dump(sw, level + 1);
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct NamedGroupHeaderElm
    {
        public Elm_hdr Ehdr;
        // TODO
        public Linkage[] Linkages;

        public NamedGroupHeaderElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct NamedGroupComponentElm
    {
        public Elm_hdr Ehdr;
        // TODO
        public Linkage[] Linkages;

        public NamedGroupComponentElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public class AttributeElm
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Dummy1;   // 0x68
        public UInt32 Dummy2;   // 0x6c
        public UInt32 Dummy3;   // 0x70
        public UInt32 Dummy4;   // 0x74
        public UInt32 Dummy5;   // 0x78
        public UInt32 Dummy6;   // 0x7c
        public UInt32 Dummy7;   // 0x80
        public UInt32 Dummy8;   // 0x84
        public UInt32 Dummy9;   // 0x88
        public UInt32 Dummy10;  // 0x8c
        public UInt32 Dummy11;  // 0x90
        public UInt32 Dummy12;  // 0x94
        public UInt16 Dummy13;  // 0x98
        public UInt16 Dummy14;  // 0x9a
        public UInt32 Dummy15;  // 0x9c
        public DPoint3d Origin; // 0xa0
        public DPoint3d Offset; // 0xb8
        public UInt16 Dummy16;  // 0xd0
        public UInt16 Dummy17;  // 0xd2
        public UInt32 Dummy18;  // 0xd4
        public UInt32 Dummy19;  // 0xd8
        public UInt32 Dummy20;  // 0xdc
        public UInt32 Dummy21;  // 0xe0
        public UInt32 Dummy22;  // 0xe4
        public UInt32 Dummy23;  // 0xe8
        public UInt32 Dummy24;  // 0xec     
        public double Dummy25;  // 0xf0
        public double Dummy26;  // 0xf8
        public T_Adouble[] Quat;    // ßx100
        public UInt32 Dummy27;  // 0x120    
        public UInt32 Dummy28;  // 0x124     
        public UInt32 Dummy29;  // 0x128    
        public UInt32 FontNumber;  // 0x12c     
        public UInt32 Dummy30;  // 0x130    
        public UInt32 Dummy31;  // 0x134    
        public UInt32 Dummy32;  // 0x138    
        public UInt32 Dummy33;  // 0x13c    
        public string Value;    // 0x140

        public Linkage[] Linkages;

        public AttributeElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Dummy6 = br.ReadUInt32();
            Dummy7 = br.ReadUInt32();
            Dummy8 = br.ReadUInt32();
            Dummy9 = br.ReadUInt32();
            Dummy10 = br.ReadUInt32();
            Dummy11 = br.ReadUInt32();
            Dummy12 = br.ReadUInt32();
            Dummy13 = br.ReadUInt16();
            Dummy14 = br.ReadUInt16();
            Dummy15 = br.ReadUInt32();
            Origin = new DPoint3d().Read(br);
            Offset = new DPoint3d().Read(br);
            Dummy16 = br.ReadUInt16();
            Dummy17 = br.ReadUInt16();
            Dummy18 = br.ReadUInt32();
            Dummy19 = br.ReadUInt32();
            Dummy20 = br.ReadUInt32();
            Dummy21 = br.ReadUInt32();
            Dummy22 = br.ReadUInt32();
            Dummy23 = br.ReadUInt32();
            Dummy24 = br.ReadUInt32();
            Dummy25 = br.ReadDouble();
            Dummy26 = br.ReadDouble();
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Dummy27 = br.ReadUInt32();
            Dummy28 = br.ReadUInt32();
            Dummy29 = br.ReadUInt32();
            FontNumber = br.ReadUInt32();
            Dummy30 = br.ReadUInt32();
            Dummy31 = br.ReadUInt32();
            Dummy32 = br.ReadUInt32();
            Dummy33 = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}Dummy3={Dummy3}");
            sw.WriteLine($"{ident}Dummy4={Dummy4}");
            sw.WriteLine($"{ident}Dummy5={Dummy5}");
            sw.WriteLine($"{ident}Dummy6={Dummy6}");
            sw.WriteLine($"{ident}Dummy7={Dummy7}");
            sw.WriteLine($"{ident}Dummy8={Dummy8}");
            sw.WriteLine($"{ident}Dummy9={Dummy9}");
            sw.WriteLine($"{ident}Dummy10={Dummy10}");
            sw.WriteLine($"{ident}Dummy11={Dummy11}");
            sw.WriteLine($"{ident}Dummy12={Dummy12}");
            sw.WriteLine($"{ident}Dummy13={Dummy13}");
            sw.WriteLine($"{ident}Dummy14={Dummy14}");
            sw.WriteLine($"{ident}Dummy15={Dummy15}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Offset >");
            Offset.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy16={Dummy16}");
            sw.WriteLine($"{ident}Dummy17={Dummy17}");
            sw.WriteLine($"{ident}Dummy18={Dummy18}");
            sw.WriteLine($"{ident}Dummy19={Dummy19}");
            sw.WriteLine($"{ident}Dummy20={Dummy20}");
            sw.WriteLine($"{ident}Dummy21={Dummy21}");
            sw.WriteLine($"{ident}Dummy22={Dummy22}");
            sw.WriteLine($"{ident}Dummy23={Dummy23}");
            sw.WriteLine($"{ident}Dummy24={Dummy24}");
            sw.WriteLine($"{ident}Dummy25={Dummy25}");
            sw.WriteLine($"{ident}Dummy26={Dummy26}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Dummy27={Dummy27}");
            sw.WriteLine($"{ident}Dummy28={Dummy28}");
            sw.WriteLine($"{ident}Dummy29={Dummy29}");
            sw.WriteLine($"{ident}FontNumber={FontNumber}");
            sw.WriteLine($"{ident}Dummy30={Dummy30}");
            sw.WriteLine($"{ident}Dummy31={Dummy31}");
            sw.WriteLine($"{ident}Dummy32={Dummy32}");
            sw.WriteLine($"{ident}Dummy33={Dummy33}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct SharedCellDefElm      // 34
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Dummy1;       // 0x6c
        public DRange3d Range;      // 0x70
        public RotMatrix RotMatrix; // 0xa0
        public DPoint3d Origin;     // 0xe8
        public string Name;
        public string Description;
        public Linkage[] Linkages;

        public SharedCellDefElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            Range = new DRange3d().Read(br);
            RotMatrix = new RotMatrix().Read(br);
            Origin = new DPoint3d().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            Name = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            Description = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Range >");
            Range.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RotMatrix >");
            RotMatrix.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Name={Name}");
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Description={Description}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    public struct SharedCellElm     // 35
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Dummy1;       // 0x68
        public ScOverride SCOverride;   // 0x6c
        public UInt16 ClassMap;     // 0x6e
        public DRange3d Range;      // 0x70
        public RotMatrix RotMatrix; // 0xa0
        public DPoint3d Origin;     // 0xe8
        public string Name;
        public string Description;
        public Linkage[] Linkages;

        public SharedCellElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Dummy1 = br.ReadUInt32();
            SCOverride = new ScOverride().Read(br);
            ClassMap = br.ReadUInt16();
            Range = new DRange3d().Read(br);
            RotMatrix = new RotMatrix().Read(br);
            Origin = new DPoint3d().Read(br);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            Name = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            Description = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}SCOverride >");
            SCOverride.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ClassMap={ClassMap}");
            sw.WriteLine($"{ident}Range >");
            Range.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RotMatrix >");
            RotMatrix.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Name={Name}");
            if (!string.IsNullOrEmpty(Name))
                sw.WriteLine($"{ident}Description={Description}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }

    //public struct MultilineBreak
    //{
    //    public UInt32 LinesMask;
    //    public MultilineBreakFlags Flags;
    //    public double Offset;
    //    public double Length;
    //    public double Angle;

    //    public MultilineBreak Read(BinaryReader br)
    //    {
    //        // read each field
    //        LinesMask = br.ReadUInt32();
    //        Flags = (MultilineBreakFlags)br.ReadUInt16();
    //        Offset = br.ReadDouble();
    //        Length = br.ReadDouble();
    //        Angle = br.ReadDouble();
    //        return this;
    //    }

    //    public void Dump(StreamWriter sw, int level)
    //    {
    //        var ident = new String(' ', 2 * level);
    //        sw.WriteLine($"{ident}LinesMask={LinesMask}");
    //        sw.WriteLine($"{ident}Flags={Flags}");
    //        sw.WriteLine($"{ident}Offset={Offset}");
    //        sw.WriteLine($"{ident}Length={Length}");
    //        sw.WriteLine($"{ident}Angle={Angle}");
    //    }
    //}

    //public struct MultilinePoint
    //{
    //    public DPoint3d Point;
    //    public MlinePoint_Flags Flags;
    //    public UInt16 Reserved;
    //    public UInt16 BreakNo;
    //    public UInt16 NBreaks;
    //    public MultilineBreak[] Breaks;
    //    public double Radius;

    //    public MultilinePoint Read(BinaryReader br)
    //    {
    //        // read each field
    //        Point = new DPoint3d().Read(br);
    //        Flags = new MlinePoint_Flags().Read(br);
    //        Reserved = br.ReadUInt16();
    //        BreakNo = br.ReadUInt16();
    //        NBreaks = br.ReadUInt16();
    //        Radius = br.ReadDouble();
    //        Breaks = new MultilineBreak[NBreaks];
    //        for (int i = 0; i < NBreaks; i++)
    //        {
    //            Breaks[i] = new MultilineBreak().Read(br);
    //        }
    //        return this;
    //    }

    //    public void Dump(StreamWriter sw, int level)
    //    {
    //        var ident = new String(' ', 2 * level);
    //        sw.WriteLine($"{ident}Point >");
    //        Point.Dump(sw, level + 1);
    //        sw.WriteLine($"{ident}Flags >");
    //        Flags.Dump(sw, level + 1);
    //        //sw.WriteLine($"{ident}Reserved={Reserved}");
    //        sw.WriteLine($"{ident}BreakNo={BreakNo}");
    //        sw.WriteLine($"{ident}NBreaks={NBreaks}");
    //        sw.WriteLine($"{ident}Radius={Radius}");
    //        for (int i = 0; i < NBreaks; i++)
    //        {
    //            sw.WriteLine($"Breaks[{i}] > ");
    //            Breaks[i].Dump(sw, level + 1);
    //        }
    //    }
    //}

    public struct MultilineElm     // 36
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public double OrgCapAngle;      // 0x68
        public double EndCapAngle;      // 0x70
        public UInt32 Dummy1;           // 0x78
        public UInt16 NPoints;          // 0x7c
        public byte Dummy2;             // 0x7e
        public byte NProfiles;          // 0x7f
        public byte NOptions;           // 0x80
        public byte NBreaks;            // 0x81
        public UInt16 Dummy3;           // 0x82
        public UInt32 Dummy4;           // 0x84
        public UInt32 Dummy5;           // 0x88
        public UInt32 Dummy6;           // 0x8c
        public UInt32 Dummy7;           // 0x90
        public UInt32 Dummy8;           // 0x94
        public double Dummy9;           // 0x98
        MlineSymbology OrgCap;          // 0xa0
        MlineSymbology EndCap;          // 0xb4
        MlineSymbology MidCap;          // 0xc8
        public UInt32 Dummy10;          // 0xdc
        public UInt32 Dummy11;          // 0xe0
        public UInt32 Dummy12;          // 0xe4
        public DPoint3d ZVector;        // 0xe8
        public MlineProfile[] Profiles; // begins at 0x100
        public MlinePoint[] Points;
        public MlineBreak[] Breaks;
        public Linkage[] Linkages;

        public MultilineElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            OrgCapAngle = br.ReadDouble();
            EndCapAngle = br.ReadDouble();
            Dummy1 = br.ReadUInt32();
            NPoints = br.ReadUInt16();
            Dummy2 = br.ReadByte();
            NProfiles = br.ReadByte();
            NOptions = br.ReadByte();
            NBreaks = br.ReadByte();
            Dummy3 = br.ReadUInt16();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Dummy6 = br.ReadUInt32();
            Dummy7 = br.ReadUInt32();
            Dummy8 = br.ReadUInt32();
            Dummy9 = br.ReadDouble();
            OrgCap = new MlineSymbology().Read(br);
            EndCap = new MlineSymbology().Read(br);
            MidCap = new MlineSymbology().Read(br);
            Dummy10 = br.ReadUInt32();
            Dummy11 = br.ReadUInt32();
            Dummy12 = br.ReadUInt32();
            ZVector = new DPoint3d().Read(br);
            Profiles = new MlineProfile[NProfiles];
            for (int i=0; i<NProfiles; i++)
            {
                Profiles[i] = new MlineProfile().Read(br);
            }
            Points = new MlinePoint[NPoints];
            for (int i = 0; i < NPoints; i++)
            {
                Points[i] = new MlinePoint().Read(br);
            }
            Breaks = new MlineBreak[NBreaks];
            for (int i = 0; i < NBreaks; i++)
            {
                Breaks[i] = new MlineBreak().Read(br);
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OrgCapAngle={OrgCapAngle}");
            sw.WriteLine($"{ident}EndCapAngle={EndCapAngle}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}NPoints={NPoints}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}NProfiles={NProfiles}");
            sw.WriteLine($"{ident}NOptions={NOptions}");
            sw.WriteLine($"{ident}NBreaks={NBreaks}");
            sw.WriteLine($"{ident}Dummy3={Dummy3}");
            sw.WriteLine($"{ident}Dummy4={Dummy4}");
            sw.WriteLine($"{ident}Dummy5={Dummy5}");
            sw.WriteLine($"{ident}Dummy6={Dummy6}");
            sw.WriteLine($"{ident}Dummy7={Dummy7}");
            sw.WriteLine($"{ident}Dummy8={Dummy8}");
            sw.WriteLine($"{ident}Dummy9={Dummy9}");
            sw.WriteLine($"{ident}OrgCap >");
            OrgCap.Dump(sw, level + 1);
            sw.WriteLine($"{ident}EndCap >");
            EndCap.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MidCap >");
            MidCap.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dummy10={Dummy10}");
            sw.WriteLine($"{ident}Dummy11={Dummy11}");
            sw.WriteLine($"{ident}Dummy12={Dummy12}");
            sw.WriteLine($"{ident}ZVector >");
            ZVector.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Profiles >");
            for (int i = 0; i < NProfiles; i++)
            {
                sw.WriteLine($"{ident}  Profiles[{i}] >");
                Profiles[i].Dump(sw, level + 2);
            }
            sw.WriteLine($"{ident}Points >");
            for (int i = 0; i < NPoints; i++)
            {
                sw.WriteLine($"{ident}  Points[{i}] >");
                Points[i].Dump(sw, level + 2);
            }
            sw.WriteLine($"{ident}Breaks >");
            for (int i = 0; i < NBreaks; i++)
            {
                sw.WriteLine($"{ident}  Breaks[{i}] >");
                Breaks[i].Dump(sw, level + 2);
            }
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
            if (V8FileLoader.Xattributes.ContainsKey(Ehdr.UniqueId))
            {
                var xattributes = V8FileLoader.Xattributes[Ehdr.UniqueId];
                if (xattributes != null)
                {
                    sw.WriteLine($"{ident}XAttribute Linkages > ({xattributes.Count} items)");
                    foreach (var xattribute in xattributes)
                    {
                        xattribute.Dump(sw, level + 1);
                    }
                }
            }
        }
    }
}
