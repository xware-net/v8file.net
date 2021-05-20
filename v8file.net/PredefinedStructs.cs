using System;
using System.IO;

namespace v8file.net
{
    public struct SRectangle
    {
        public SPoint2d Origin;
        public SPoint2d Corner;

        public SRectangle Read(BinaryReader br)
        {
            // read each field
            Origin = new SPoint2d().Read(br);
            Corner = new SPoint2d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Corner >");
            Corner.Dump(sw, level + 1);
        }
    }

    public struct DRectangle
    {
        public DPoint2d Origin;
        public DPoint2d Corner;

        public DRectangle Read(BinaryReader br)
        {
            // read each field
            Origin = new DPoint2d().Read(br);
            Corner = new DPoint2d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Corner >");
            Corner.Dump(sw, level + 1);
        }
    }

    public struct DVec3d
    {
        public double X;
        public double Y;
        public double Z;

        public DVec3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            Z = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct DrawingScaleName
    {
        public byte[] Name;

        public DrawingScaleName Read(BinaryReader br)
        {
            // read each field
            Name = br.ReadBytes(32);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Name={System.Text.Encoding.UTF8.GetString(Name)}");
        }
    }
}
