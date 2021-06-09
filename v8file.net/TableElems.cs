using System;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class LevelTableElm
    {
        public Elm_hdr Ehdr;
        public UInt32 LevelId;
        public UInt32 ParentId;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 OverrideStyle;
        public UInt32 OverrideWeight;
        public UInt32 OverrideColor;
        public UInt32 OverrideColor1;
        public UInt32 ByLevelStyle;
        public UInt32 ByLevelWeight;
        public UInt32 ByLevelColor;
        public UInt32 ByLevelColor1;
        public float Transparency;
        public Int32 Priority;
        public UInt32 Dummy7;
        public UInt32 LevelCode;
        public Linkage[] Linkages;
        public string LevelName;
        public string LevelDescription;

        public LevelTableElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            LevelId = br.ReadUInt32();
            ParentId = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            OverrideStyle = br.ReadUInt32();
            OverrideWeight = br.ReadUInt32();
            OverrideColor = br.ReadUInt32();
            OverrideColor1 = br.ReadUInt32();
            ByLevelStyle = br.ReadUInt32();
            ByLevelWeight = br.ReadUInt32();
            ByLevelColor = br.ReadUInt32();
            ByLevelColor1 = br.ReadUInt32();
            Transparency = br.ReadSingle();
            Priority = br.ReadInt32();
            Dummy7 = br.ReadUInt32();
            LevelCode = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            LevelName = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            LevelDescription = V8Linkages.V8GetStringLinkage(Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}LevelId={LevelId}");
            sw.WriteLine($"{ident}LevelName=\"{LevelName}\"");
            sw.WriteLine($"{ident}LevelDescription=\"{LevelDescription}\"");
            sw.WriteLine($"{ident}ParentId={ParentId}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}Dummy3={OverrideStyle}");
            sw.WriteLine($"{ident}Dummy4={OverrideWeight}");
            sw.WriteLine($"{ident}Dummy5={OverrideColor}");
            sw.WriteLine($"{ident}Dummy6={OverrideColor1}");
            sw.WriteLine($"{ident}Style={ByLevelStyle}");
            sw.WriteLine($"{ident}Weight={ByLevelWeight}");
            sw.WriteLine($"{ident}Color={ByLevelColor}");
            sw.WriteLine($"{ident}Color1={ByLevelColor1}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
            sw.WriteLine($"{ident}Priority={Priority}");
            sw.WriteLine($"{ident}Dummy7={Dummy7}");
            sw.WriteLine($"{ident}LevelCode={LevelCode}");
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

    public class FontTableElm
    {
        public Elm_hdr Ehdr;
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt32 FontNumber;
        public UInt16 NameLength;
        public byte[] NameBytes;
        public string FontName;
        public Linkage[] Linkages;

        public FontTableElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            FontNumber = br.ReadUInt32();
            NameLength = br.ReadUInt16();
            NameBytes = br.ReadBytes(NameLength);
            FontName = Encoding.Unicode.GetString(NameBytes);
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FontNumber={FontNumber}");
            sw.WriteLine($"{ident}FontName={FontName}");
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

    public class TestStyleTableElm
    {
        public Elm_hdr Ehdr;
        public UInt64 StyleId;
        public UInt32 FontNumber;
        public UInt32 Dummy1;
        public double Width;
        public double Height;
        public double Slant;
        public double LineSpacing;
        public double InterCharSpacing;
        public double UnderlineOffset;
        public double OverlineOffset;
        public double Dummy2;
        public DPoint2d LineOffset;
        public UInt16 Justification;
        public UInt16 Dummy8;
        public UInt16 LineLength;
        public UInt16 Dummy9;
        public UInt16 Dummy10;
        public UInt16 Dummy11;
        public Int32 BackgroudWeight;
        public Int32 BackgroudColor;
        public Int32 BackgroudFillColor;
        public DPoint2d BackgroundBorder;
        public Int32 UnderlineStyle;
        public UInt32 UnderlineWeight;
        public UInt32 UnderlineColor;
        public Int32 OverlineStyle;
        public UInt32 OverlineWeight;
        public UInt32 OverlineColor;
        public UInt32 Dummy4;
        public UInt32 Dummy5;
        public UInt32 Dummy6;
        public UInt32 Dummy7;
        public UInt32 ColorIndex;
        public UInt32 Dummy12;
        public UInt32 Dummy13;
        public UInt32 Dummy14;
        public UInt32 Dummy15;
        public UInt32 Dummy16;
        public UInt16 TextStyleNameLength;
        public string TextStyleName;
        public Linkage[] Linkages;

        public TestStyleTableElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            StyleId = br.ReadUInt64();              // 0x20
            FontNumber = br.ReadUInt32();           // 0x28
            Dummy1 = br.ReadUInt32();               // 0x2c
            Width = br.ReadDouble();                // 0x30
            Height = br.ReadDouble();               // 0x38
            Slant = br.ReadDouble();                // 0x40
            LineSpacing = br.ReadDouble();          // 0x48
            InterCharSpacing = br.ReadDouble();     // 0x50
            UnderlineOffset = br.ReadDouble();      // 0x58
            OverlineOffset = br.ReadDouble();       // 0x60
            Dummy2 = br.ReadDouble();               // 0x68
            LineOffset = new DPoint2d().Read(br);   // 0x70
            Justification = br.ReadUInt16();        // 0x80
            Dummy8 = br.ReadUInt16();               // 0x82
            LineLength = br.ReadUInt16();           // 0x84
            Dummy9 = br.ReadUInt16();               // 0x86
            Dummy10 = br.ReadUInt16();              // 0x88
            Dummy11 = br.ReadUInt16();              // 0x8a
            BackgroudWeight = br.ReadInt32();       // 0x8c
            BackgroudColor = br.ReadInt32();        // 0x90
            BackgroudFillColor = br.ReadInt32();    // 0x94
            BackgroundBorder = new DPoint2d().Read(br);   // 0x98
            UnderlineStyle = br.ReadInt32();        // 0xa8
            UnderlineWeight = br.ReadUInt32();      // 0xac
            UnderlineColor = br.ReadUInt32();       // 0xb0
            OverlineStyle = br.ReadInt32();         // 0xb4
            OverlineWeight = br.ReadUInt32();       // 0xb8
            OverlineColor = br.ReadUInt32();        // 0xbc
            Dummy4 = br.ReadUInt32();               // 0xc0
            Dummy5 = br.ReadUInt32();               // 0xc4
            Dummy6 = br.ReadUInt32();               // 0xc8
            Dummy7 = br.ReadUInt32();               // 0xcc
            ColorIndex = br.ReadUInt32();           // 0xd0
            Dummy12 = br.ReadUInt32();              // 0xd4
            Dummy13 = br.ReadUInt32();              // 0xd8
            Dummy14 = br.ReadUInt32();              // 0xdc
            Dummy15 = br.ReadUInt32();              // 0xe0
            Dummy16 = br.ReadUInt32();              // 0xe4
            TextStyleNameLength = br.ReadUInt16();  // 0xe8
            var namePosition = br.BaseStream.Position;
            var Data = br.ReadBytes(TextStyleNameLength);
            if ((TextStyleNameLength >= 4) && (Data[0] == 0xff) && (Data[1] == 0xfe) && (Data[2] == 0x01) && (Data[3] == 0x00))
            {
                // skip UTF32 LE BOM
                br.BaseStream.Seek(namePosition + 4, SeekOrigin.Begin);
                TextStyleNameLength -= 4;
            } else
            {
                br.BaseStream.Seek(namePosition, SeekOrigin.Begin);
            }

            TextStyleName = System.Text.Encoding.UTF8.GetString(br.ReadBytes(TextStyleNameLength));
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}StyleId={StyleId}");
            sw.WriteLine($"{ident}FontNumber={FontNumber}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}Height={Height}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}LineSpacing={LineSpacing}");
            sw.WriteLine($"{ident}InterCharSpacing={InterCharSpacing}");
            sw.WriteLine($"{ident}UnderlineOffset={UnderlineOffset}");
            sw.WriteLine($"{ident}OverlineOffset={OverlineOffset}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}LineOffset > ");
            LineOffset.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Justification={Justification}");
            sw.WriteLine($"{ident}Dummy8={Dummy8}");
            sw.WriteLine($"{ident}LineLength={LineLength}");
            sw.WriteLine($"{ident}Dummy9={Dummy9}");
            sw.WriteLine($"{ident}Dummy10={Dummy10}");
            sw.WriteLine($"{ident}Dummy11={Dummy11}");
            sw.WriteLine($"{ident}BackgroudWeight={BackgroudWeight}");
            sw.WriteLine($"{ident}BackgroudColor={BackgroudColor}");
            sw.WriteLine($"{ident}BackgroudFillColor={BackgroudFillColor}");
            sw.WriteLine($"{ident}BackgroundBorder > ");
            BackgroundBorder.Dump(sw, level + 1);
            sw.WriteLine($"{ident}UnderlineStyle={UnderlineStyle}");
            sw.WriteLine($"{ident}UnderlineWeight={UnderlineWeight}");
            sw.WriteLine($"{ident}UnderlineColor={UnderlineColor}");
            sw.WriteLine($"{ident}OverlineStyle={OverlineStyle}");
            sw.WriteLine($"{ident}OverlineWeight={OverlineWeight}");
            sw.WriteLine($"{ident}OverlineColor={OverlineColor}");
            sw.WriteLine($"{ident}Dummy4={Dummy4}");
            sw.WriteLine($"{ident}Dummy5={Dummy5}");
            sw.WriteLine($"{ident}Dummy6={Dummy6}");
            sw.WriteLine($"{ident}Dummy7={Dummy7}");
            sw.WriteLine($"{ident}ColorIndex={ColorIndex}");
            sw.WriteLine($"{ident}Dummy12={Dummy12}");
            sw.WriteLine($"{ident}Dummy13={Dummy13}");
            sw.WriteLine($"{ident}Dummy14={Dummy14}");
            sw.WriteLine($"{ident}Dummy15={Dummy15}");
            sw.WriteLine($"{ident}Dummy16={Dummy16}");
            sw.WriteLine($"{ident}TextStyleName=\"{TextStyleName}\"");
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

    public class FilterTableElm
    {
        public Elm_hdr Ehdr;
        public UInt32 FilterId;
        public UInt32 ParentFilterId;
        public UInt16 Dummy1;
        public UInt16 FilterType;
        public UInt32 Dummy2;
        public Linkage[] Linkages;

        public FilterTableElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            FilterId = br.ReadUInt32();
            ParentFilterId = br.ReadUInt32();
            Dummy1 = br.ReadUInt16();
            FilterType = br.ReadUInt16();
            Dummy2 = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FilterId={FilterId}");
            sw.WriteLine($"{ident}ParentFilterId={((ParentFilterId == 0xffffffff) ? -1 : ParentFilterId)}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}FilterType={FilterType}");
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
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

    public class DimStyleTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public DimStyleTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class MLineStyleTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public MLineStyleTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class LStyleNameTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LStyleNameTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class LStyleDefTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LStyleDefTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class DictionaryTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public DictionaryTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class RegAppTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public RegAppTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class ColorBookTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public ColorBookTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class SymbolStyleTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public SymbolStyleTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class ColorBookElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public ColorBookElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class MaterialPaletteTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public MaterialPaletteTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class LevelNameDictionaryTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LevelNameDictionaryTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class AnimationParameterTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public AnimationParameterTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class AnimationScheduleInfoTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public AnimationScheduleInfoTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class RenderSetupTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public RenderSetupTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class LightSetupTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LightSetupTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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

    public class NamedPresentationTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public NamedPresentationTableElm Read(BinaryReader br)
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
            Ehdr.Dump(sw, level + 1);
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
