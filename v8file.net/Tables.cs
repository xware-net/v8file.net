using System;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class LevelTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32 Dummy1;
        public UInt64 ElementId;    // when != 0 level table is associated with an REFERENCE_ATTACH_ELM (type 100)
        public Linkage[] Linkages;

        public LevelTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            ElementId = br.ReadUInt64();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}ElementId={ElementId}");
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

    public class FilterTable
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32 Dummy1;
        public Int32 ActiveFilterId;
        public UInt32 Dummy2;
        public Linkage[] Linkages;

        public FilterTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            ActiveFilterId = br.ReadInt32();
            Dummy2 = br.ReadUInt32();
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Dummy1={Dummy1}");
            sw.WriteLine($"{ident}ActiveFilterId={ActiveFilterId}");
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
