using System;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class LevelTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LevelTableElm Read(BinaryReader br)
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
        }
    }

    public class TestStyleTableElm
    {
        public Elm_hdr Ehdr;
        public UInt64 StyleId;
        public UInt32 FontNumber;
        public UInt32 Dummy1;
        public double Dummy2;
        public double Dummy3;
        public Linkage[] Linkages;

        public TestStyleTableElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            StyleId = br.ReadUInt64();
            FontNumber = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadDouble();
            Dummy3 = br.ReadDouble();
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
            sw.WriteLine($"{ident}Dummy2={Dummy2}");
            sw.WriteLine($"{ident}Dummy3={Dummy3}");
            if (Linkages.Length > 0)
            {
                sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
                for (int i = 0; i < Linkages.Length; i++)
                {
                    Linkages[i].Dump(sw, level + 1);
                }
            }
        }
    }

    public class FilterTableElm
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public FilterTableElm Read(BinaryReader br)
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
        }
    }

}
