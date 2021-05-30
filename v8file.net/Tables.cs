using System;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class LevelTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public LevelTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class FontTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public FontTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class TestStyleTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public TestStyleTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class FilterTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public FilterTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class DimStyleTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public DimStyleTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class MLineStyleTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public MLineStyleTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class LStyleNameTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public LStyleNameTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class LStyleDefTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public LStyleDefTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class DictionaryTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public DictionaryTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class RegAppTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public RegAppTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class ColorBookTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public ColorBookTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class SymbolStyleTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public SymbolStyleTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class ColorBook
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public ColorBook Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class MaterialPaletteTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public MaterialPaletteTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class LevelNameDictionaryTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public LevelNameDictionaryTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class AnimationParameterTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public AnimationParameterTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class AnimationScheduleInfoTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public AnimationScheduleInfoTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class RenderSetupTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public RenderSetupTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class LightSetupTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public LightSetupTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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

    public class NamedPresentationTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public Linkage[] Linkages;

        public NamedPresentationTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
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
