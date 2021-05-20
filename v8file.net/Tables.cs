using System;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class LevelTable : Table
    {
        //public Elm_hdr Ehdr;
        //public Linkage[] Linkages;

        public new LevelTable Read(BinaryReader br)
        {
            // read each field
            //Ehdr = new Elm_hdr().Read(br);
            //Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return (LevelTable)base.Read(br);
        }

        public new void Dump(StreamWriter sw, int level)
        {
            //var ident = new String(' ', 2 * level);
            //sw.WriteLine($"{ident}Ehdr >");
            //Ehdr.Dump(sw, level + 1);
            //if (Linkages.Length > 0)
            //{
            //    sw.WriteLine($"{ident}Attribute Linkages > ({Linkages.Length} items)");
            //    for (int i = 0; i < Linkages.Length; i++)
            //    {
            //        Linkages[i].Dump(sw, level + 1);
            //    }
            //}
        }
    }

    public struct FontTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public FontTable Read(BinaryReader br)
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

    public struct TestStyleTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public TestStyleTable Read(BinaryReader br)
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

    public struct FilterTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public FilterTable Read(BinaryReader br)
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

    public struct DimStyleTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public DimStyleTable Read(BinaryReader br)
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

    public struct MLineStyleTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public MLineStyleTable Read(BinaryReader br)
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

    public struct LStyleNameTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LStyleNameTable Read(BinaryReader br)
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

    public struct LStyleDefTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LStyleDefTable Read(BinaryReader br)
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

    public struct DictionaryTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public DictionaryTable Read(BinaryReader br)
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

    public struct RegAppTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public RegAppTable Read(BinaryReader br)
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

    public struct ColorBookTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public ColorBookTable Read(BinaryReader br)
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

    public struct SymbolStyleTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public SymbolStyleTable Read(BinaryReader br)
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

    public struct ColorBook
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public ColorBook Read(BinaryReader br)
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

    public struct MaterialPaletteTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public MaterialPaletteTable Read(BinaryReader br)
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

    public struct LevelNameDictionaryTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LevelNameDictionaryTable Read(BinaryReader br)
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

    public struct AnimationParameterTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public AnimationParameterTable Read(BinaryReader br)
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

    public struct AnimationScheduleInfoTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public AnimationScheduleInfoTable Read(BinaryReader br)
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

    public struct RenderSetupTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public RenderSetupTable Read(BinaryReader br)
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

    public struct LightSetupTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public LightSetupTable Read(BinaryReader br)
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

    public struct NamedPresentationTable
    {
        public Elm_hdr Ehdr;
        public Linkage[] Linkages;

        public NamedPresentationTable Read(BinaryReader br)
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
