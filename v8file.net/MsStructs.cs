using System;
using System.Collections.Generic;
using System.IO;
using ModelId = System.UInt32;

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
        public ModelInfo[] Models;                // models in file
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

    public struct DimensionElm
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
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

}
