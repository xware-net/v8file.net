using System;
using System.IO;
using System.Runtime.InteropServices;
using CommandNumber = System.UInt64;
using ElementId = System.UInt64;
using ModelId = System.UInt32;
using LevelId = System.UInt32;
using T_AUInt64 = System.UInt64;
using T_Adouble = System.Double;
using UShort = System.UInt16;
using UInt = System.UInt32;
using int32_t = System.Int32;
using int64_t = System.Int64;
using uint32_t = System.UInt32;
using UInt8 = System.Byte;
using WChar = System.UInt16;
using TagWChar = System.Char;
using UChar = System.Byte;
using VariChar = System.Byte;
using Utf16Char = System.Char;
using WString = System.String;
using System.Text;
using System.Diagnostics;

namespace v8file.net
{
    public struct DPoint2d
    {
        public double X;
        public double Y;

        public DPoint2d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}(X, Y)=({X}, {Y})");
            //sw.WriteLine($"{ident}X={X}");
            //sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct DPoint3d
    {
        public double X;
        public double Y;
        public double Z;

        public DPoint3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            Z = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}(X, Y, Z)=({X}, {Y}, {Z})");
            //sw.WriteLine($"{ident}X={X}");
            //sw.WriteLine($"{ident}Y={Y}");
            //sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct DPoint4d
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public DPoint4d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            Z = br.ReadDouble();
            W = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}(X, Y, Z, W)=({X}, {Y}, {Z}, {W})");
            //sw.WriteLine($"{ident}X={X}");
            //sw.WriteLine($"{ident}Y={Y}");
            //sw.WriteLine($"{ident}Z={Z}");
            //sw.WriteLine($"{ident}W={W}");
        }
    }

    public struct DMatrix4d
    {
        public double[,] Coff;

        public DMatrix4d Read(BinaryReader br)
        {
            // read each field
            Coff = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Coff[i, j] = br.ReadDouble();
                }
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sw.WriteLine($"{ident}Coff={Coff[i, j]}");
                }
            }
        }
    }

    public struct Transform
    {
        public double[,] Form3d;

        public Transform Read(BinaryReader br)
        {
            // read each field
            Form3d = new double[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Form3d[i, j] = br.ReadDouble();
                }
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine($"{ident}Form3d={Form3d[i, j]}");
                }
            }
        }
    }

    public struct RotMatrix
    {
        public double[,] Form3d;

        public RotMatrix Read(BinaryReader br)
        {
            // read each field
            Form3d = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Form3d[i, j] = br.ReadDouble();
                }
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine($"{ident}Form3d={Form3d[i, j]}");
                }
            }
        }
    }

    public struct DRange3d
    {
        public DPoint3d Low;
        public DPoint3d High;

        public DRange3d Read(BinaryReader br)
        {
            // read each field
            Low = new DPoint3d().Read(br);
            High = new DPoint3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low >");
            Low.Dump(sw, level + 1);
            sw.WriteLine($"{ident}High >");
            High.Dump(sw, level + 1);
        }
    }

    public struct DEllipse3d
    {
        public DPoint3d Center;
        public DVec3d Vector0;
        public DVec3d Vector90;
        public double Start;
        public double Sweep;

        public DEllipse3d Read(BinaryReader br)
        {
            // read each field
            Center = new DPoint3d().Read(br);
            Vector0 = new DVec3d().Read(br);
            Vector90 = new DVec3d().Read(br);
            Start = br.ReadDouble();
            Sweep = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Center >");
            Center.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Vector0 >");
            Vector0.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Vector90 >");
            Vector90.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Start={Start}");
            sw.WriteLine($"{ident}Sweep={Sweep}");
        }
    }

    public struct DSegment3d
    {
        public DPoint3d[] Point;

        public DSegment3d Read(BinaryReader br)
        {
            // read each field
            Point = new DPoint3d[2];
            for (int i = 0; i < 2; i++)
            {
                Point[i] = new DPoint3d().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}Point >");
                Point[i].Dump(sw, level + 1);
            }
        }
    }

    public struct DRay3d
    {
        public DPoint3d Origin;
        public DVec3d Direction;

        public DRay3d Read(BinaryReader br)
        {
            // read each field
            Origin = new DPoint3d().Read(br);
            Direction = new DVec3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Direction >");
            Direction.Dump(sw, level + 1);
        }
    }

    public struct DPlane3d
    {
        public DPoint3d Origin;
        public DVec3d Normal;

        public DPlane3d Read(BinaryReader br)
        {
            // read each field
            Origin = new DPoint3d().Read(br);
            Normal = new DVec3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Normal >");
            Normal.Dump(sw, level + 1);
        }
    }

    public struct DRange1d
    {
        public double Low;
        public double High;

        public DRange1d Read(BinaryReader br)
        {
            // read each field
            Low = br.ReadDouble();
            High = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low={Low}");
            sw.WriteLine($"{ident}High={High}");
        }
    }

    public struct DRange2d
    {
        public DPoint2d Low;
        public DPoint2d High;

        public DRange2d Read(BinaryReader br)
        {
            // read each field
            Low = new DPoint2d().Read(br);
            High = new DPoint2d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low >");
            Low.Dump(sw, level + 1);
            sw.WriteLine($"{ident}High >");
            High.Dump(sw, level + 1);
        }
    }

    public struct DMap4d
    {
        public DMatrix4d M0;
        public DMatrix4d M1;
        public int Mask;

        public DMap4d Read(BinaryReader br)
        {
            // read each field
            M0 = new DMatrix4d().Read(br);
            M1 = new DMatrix4d().Read(br);
            Mask = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M0 >");
            M0.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M1 >");
            M1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Mask={Mask}");
        }
    }

    public struct FaceId
    {
        public uint32_t NodeId;
        public uint32_t EntityId;

        public FaceId Read(BinaryReader br)
        {
            // read each field
            NodeId = br.ReadUInt32();
            EntityId = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}NodeId={NodeId}");
            sw.WriteLine($"{ident}EntityId={EntityId}");
        }
    }

    public struct BsplineDisplay
    {
        public int32_t PolygonDisplay;
        public int32_t CurveDisplay;
        public int32_t RulesByLength;

        public BsplineDisplay Read(BinaryReader br)
        {
            // read each field
            PolygonDisplay = br.ReadInt32();
            CurveDisplay = br.ReadInt32();
            RulesByLength = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}PolygonDisplay={PolygonDisplay}");
            sw.WriteLine($"{ident}CurveDisplay={CurveDisplay}");
            sw.WriteLine($"{ident}RulesByLength={RulesByLength}");
        }
    }

    public struct BsplineParam
    {
        public int32_t Order;
        public int32_t Closed;
        public int32_t NumPoles;
        public int32_t NumKnots;
        public int32_t NumRules;

        public BsplineParam Read(BinaryReader br)
        {
            // read each field
            Order = br.ReadInt32();
            Closed = br.ReadInt32();
            NumPoles = br.ReadInt32();
            NumKnots = br.ReadInt32();
            NumRules = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Closed={Closed}");
            sw.WriteLine($"{ident}NumPoles={NumPoles}");
            sw.WriteLine($"{ident}NumKnots={NumKnots}");
            sw.WriteLine($"{ident}NumRules={NumRules}");
        }
    }

    public struct InterpolationParam
    {
        public int32_t Order;
        public int32_t IsPeriodic;
        public int32_t NumPoints;
        public int32_t NumKnots;
        public int32_t IsChordLenKnots;
        public int32_t IsColinearTangents;
        public int32_t IsChordLenTangents;
        public int32_t IsNaturalTangents;

        public InterpolationParam Read(BinaryReader br)
        {
            // read each field
            Order = br.ReadInt32();
            IsPeriodic = br.ReadInt32();
            NumPoints = br.ReadInt32();
            NumKnots = br.ReadInt32();
            IsChordLenKnots = br.ReadInt32();
            IsColinearTangents = br.ReadInt32();
            IsChordLenTangents = br.ReadInt32();
            IsNaturalTangents = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}IsPeriodic={IsPeriodic}");
            sw.WriteLine($"{ident}NumPoints={NumPoints}");
            sw.WriteLine($"{ident}NumKnots={NumKnots}");
            sw.WriteLine($"{ident}IsChordLenKnots={IsChordLenKnots}");
            sw.WriteLine($"{ident}IsColinearTangents={IsColinearTangents}");
            sw.WriteLine($"{ident}IsChordLenTangents={IsChordLenTangents}");
            sw.WriteLine($"{ident}IsNaturalTangents={IsNaturalTangents}");
        }
    }

    public struct LocalRange
    {
        public Transform M_localToWorld;
        public Transform M_worldToLocal;
        public DRange3d M_localRange;
        public DRange3d M_worldRange;

        public LocalRange Read(BinaryReader br)
        {
            // read each field
            M_localToWorld = new Transform().Read(br);
            M_worldToLocal = new Transform().Read(br);
            M_localRange = new DRange3d().Read(br);
            M_worldRange = new DRange3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_localToWorld >");
            M_localToWorld.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_worldToLocal >");
            M_worldToLocal.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_localRange >");
            M_localRange.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_worldRange >");
            M_worldRange.Dump(sw, level + 1);
        }
    }

    public struct RgbFactor
    {
        public T_Adouble Red;
        public T_Adouble Green;
        public T_Adouble Blue;

        public RgbFactor Read(BinaryReader br)
        {
            // read each field
            Red = br.ReadDouble();
            Green = br.ReadDouble();
            Blue = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Red={Red}");
            sw.WriteLine($"{ident}Green={Green}");
            sw.WriteLine($"{ident}Blue={Blue}");
        }
    }

    public struct FloatRgb
    {
        public float Red;
        public float Green;
        public float Blue;

        public FloatRgb Read(BinaryReader br)
        {
            // read each field
            Red = br.ReadSingle();
            Green = br.ReadSingle();
            Blue = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Red={Red}");
            sw.WriteLine($"{ident}Green={Green}");
            sw.WriteLine($"{ident}Blue={Blue}");
        }
    }

    public struct DirectionalVolumeData
    {
        public double Volume;
        public DMatrix4d AreaProducts;

        public DirectionalVolumeData Read(BinaryReader br)
        {
            // read each field
            Volume = br.ReadDouble();
            AreaProducts = new DMatrix4d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Volume={Volume}");
            sw.WriteLine($"{ident}AreaProducts >");
            AreaProducts.Dump(sw, level + 1);
        }
    }

    public struct DSegment3dOnFacets
    {
        public uint32_t M_history;

        public DSegment3dOnFacets Read(BinaryReader br)
        {
            // read each field
            M_history = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_history={M_history}");
        }
    }

    public struct EdgeId
    {
        public FaceId[] Faces;

        public EdgeId Read(BinaryReader br)
        {
            // read each field
            Faces = new FaceId[2];
            for (int i = 0; i < 2; i++)
            {
                Faces[i] = new FaceId().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}Faces={Faces[i]}");
            }
        }
    }

    public struct DgnTorusPipeDetail
    {
        public DPoint3d M_center;
        public DVec3d M_vectorX;
        public DVec3d M_vectorY;
        public double M_majorRadius;
        public double M_minorRadius;
        public double M_sweepAngle;
        public bool M_capped;

        public DgnTorusPipeDetail Read(BinaryReader br)
        {
            // read each field
            M_center = new DPoint3d().Read(br);
            M_vectorX = new DVec3d().Read(br);
            M_vectorY = new DVec3d().Read(br);
            M_majorRadius = br.ReadDouble();
            M_minorRadius = br.ReadDouble();
            M_sweepAngle = br.ReadDouble();
            M_capped = br.ReadBoolean();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_center >");
            M_center.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vectorX >");
            M_vectorX.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vectorY >");
            M_vectorY.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_majorRadius={M_majorRadius}");
            sw.WriteLine($"{ident}M_minorRadius={M_minorRadius}");
            sw.WriteLine($"{ident}M_sweepAngle={M_sweepAngle}");
            sw.WriteLine($"{ident}M_capped={M_capped}");
        }
    }

    public struct DgnConeDetail
    {
        public DPoint3d M_centerA;
        public DPoint3d M_centerB;
        public DVec3d M_vector0;
        public DVec3d M_vector90;
        public double M_radiusA;
        public double M_radiusB;
        public bool M_capped;

        public DgnConeDetail Read(BinaryReader br)
        {
            // read each field
            M_centerA = new DPoint3d().Read(br);
            M_centerB = new DPoint3d().Read(br);
            M_vector0 = new DVec3d().Read(br);
            M_vector90 = new DVec3d().Read(br);
            M_radiusA = br.ReadDouble();
            M_radiusB = br.ReadDouble();
            M_capped = br.ReadBoolean();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_centerA >");
            M_centerA.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_centerB >");
            M_centerB.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vector0 >");
            M_vector0.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vector90 >");
            M_vector90.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_radiusA={M_radiusA}");
            sw.WriteLine($"{ident}M_radiusB={M_radiusB}");
            sw.WriteLine($"{ident}M_capped={M_capped}");
        }
    }

    public struct DgnBoxDetail
    {
        public DPoint3d M_baseOrigin;
        public DPoint3d M_topOrigin;
        public DVec3d M_vectorX;
        public DVec3d M_vectorY;
        public double M_baseX;
        public double M_baseY;
        public double M_topX;
        public double M_topY;
        public bool M_capped;

        public DgnBoxDetail Read(BinaryReader br)
        {
            // read each field
            M_baseOrigin = new DPoint3d().Read(br);
            M_topOrigin = new DPoint3d().Read(br);
            M_vectorX = new DVec3d().Read(br);
            M_vectorY = new DVec3d().Read(br);
            M_baseX = br.ReadDouble();
            M_baseY = br.ReadDouble();
            M_topX = br.ReadDouble();
            M_topY = br.ReadDouble();
            M_capped = br.ReadBoolean();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_baseOrigin >");
            M_baseOrigin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_topOrigin >");
            M_topOrigin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vectorX >");
            M_vectorX.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_vectorY >");
            M_vectorY.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_baseX={M_baseX}");
            sw.WriteLine($"{ident}M_baseY={M_baseY}");
            sw.WriteLine($"{ident}M_topX={M_topX}");
            sw.WriteLine($"{ident}M_topY={M_topY}");
            sw.WriteLine($"{ident}M_capped={M_capped}");
        }
    }

    public struct DgnSphereDetail
    {
        public Transform M_localToWorld;
        public double M_startLatitude;
        public double M_latitudeSweep;
        public bool M_capped;

        public DgnSphereDetail Read(BinaryReader br)
        {
            // read each field
            M_localToWorld = new Transform().Read(br);
            M_startLatitude = br.ReadDouble();
            M_latitudeSweep = br.ReadDouble();
            M_capped = br.ReadBoolean();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_localToWorld >");
            M_localToWorld.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_startLatitude={M_startLatitude}");
            sw.WriteLine($"{ident}M_latitudeSweep={M_latitudeSweep}");
            sw.WriteLine($"{ident}M_capped={M_capped}");
        }
    }

    public struct _fPoint3d
    {
        public float X;
        public float Y;
        public float Z;

        public _fPoint3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadSingle();
            Y = br.ReadSingle();
            Z = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct _fPoint2d
    {
        public float X;
        public float Y;

        public _fPoint2d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadSingle();
            Y = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct FPoint3d
    {
        public float X;
        public float Y;
        public float Z;

        public FPoint3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadSingle();
            Y = br.ReadSingle();
            Z = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct _fRange3d
    {
        public FPoint3d Low;
        public FPoint3d High;

        public _fRange3d Read(BinaryReader br)
        {
            // read each field
            Low = new FPoint3d().Read(br);
            High = new FPoint3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low={Low}");
            sw.WriteLine($"{ident}High={High}");
        }
    }

    public struct FPoint2d
    {
        public float X;
        public float Y;

        public FPoint2d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadSingle();
            Y = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct _fRange2d
    {
        public FPoint2d Low;
        public FPoint2d High;

        public _fRange2d Read(BinaryReader br)
        {
            // read each field
            Low = new FPoint2d().Read(br);
            High = new FPoint2d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low={Low}");
            sw.WriteLine($"{ident}High={High}");
        }
    }

    public struct GeoPoint
    {
        public double Longitude;
        public double Latitude;
        public double Elevation;

        public GeoPoint Read(BinaryReader br)
        {
            // read each field
            Longitude = br.ReadDouble();
            Latitude = br.ReadDouble();
            Elevation = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Longitude={Longitude}");
            sw.WriteLine($"{ident}Latitude={Latitude}");
            sw.WriteLine($"{ident}Elevation={Elevation}");
        }
    }

    public struct GeoPoint2d
    {
        public double Longitude;
        public double Latitude;

        public GeoPoint2d Read(BinaryReader br)
        {
            // read each field
            Longitude = br.ReadDouble();
            Latitude = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Longitude={Longitude}");
            sw.WriteLine($"{ident}Latitude={Latitude}");
        }
    }

    public struct VertexId
    {
        public FaceId[] Faces;

        public VertexId Read(BinaryReader br)
        {
            // read each field
            Faces = new FaceId[3];
            for (int i = 0; i < 3; i++)
            {
                Faces[i] = new FaceId().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}Faces={Faces[i]}");
            }
        }
    }

    public struct Point2d
    {
        public int32_t X;
        public int32_t Y;

        public Point2d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadInt32();
            Y = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct Point3d
    {
        public int32_t X;
        public int32_t Y;
        public int32_t Z;

        public Point3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadInt32();
            Y = br.ReadInt32();
            Z = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct BSIRect
    {
        public Point2d Origin;
        public Point2d Corner;

        public BSIRect Read(BinaryReader br)
        {
            // read each field
            Origin = new Point2d().Read(br);
            Corner = new Point2d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Corner >");
            Corner.Dump(sw, level + 1);
        }
    }

    public struct UsageSums
    {
        public double[] M_sums;
        public double M_min;
        public double M_max;

        public UsageSums Read(BinaryReader br)
        {
            // read each field
            M_sums = new double[3];
            for (int i = 0; i < 3; i++)
            {
                M_sums[i] = br.ReadDouble();
            }
            M_min = br.ReadDouble();
            M_max = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}M_sums={M_sums[i]}");
            }
            sw.WriteLine($"{ident}M_min={M_min}");
            sw.WriteLine($"{ident}M_max={M_max}");
        }
    }

    public struct Big_
    {
        public sbyte[] Dummy;

        public Big_ Read(BinaryReader br)
        {
            // read each field
            Dummy = new sbyte[2];
            for (int i = 0; i < 2; i++)
            {
                Dummy[i] = br.ReadSByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}Dummy={Dummy[i]}");
            }
        }
    }

    public struct PolyfaceVisitorNormalOrientationFilter
    {
        public double M_normalTolerance;
        public bool M_acceptNegative;
        public bool M_acceptSide;
        public bool M_acceptPositive;
        public DVec3d M_positiveDirectionVector;

        public PolyfaceVisitorNormalOrientationFilter Read(BinaryReader br)
        {
            // read each field
            M_normalTolerance = br.ReadDouble();
            M_acceptNegative = br.ReadBoolean();
            M_acceptSide = br.ReadBoolean();
            M_acceptPositive = br.ReadBoolean();
            M_positiveDirectionVector = new DVec3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_normalTolerance={M_normalTolerance}");
            sw.WriteLine($"{ident}M_acceptNegative={M_acceptNegative}");
            sw.WriteLine($"{ident}M_acceptSide={M_acceptSide}");
            sw.WriteLine($"{ident}M_acceptPositive={M_acceptPositive}");
            sw.WriteLine($"{ident}M_positiveDirectionVector >");
            M_positiveDirectionVector.Dump(sw, level + 1);
        }
    }

    public struct SPoint2d
    {
        public Int16 X;
        public Int16 Y;

        public SPoint2d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadInt16();
            Y = br.ReadInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct RgbaColorDef
    {
        public Byte Red;
        public Byte Green;
        public Byte Blue;
        public Byte Alpha;

        public RgbaColorDef Read(BinaryReader br)
        {
            // read each field
            Red = br.ReadByte();
            Green = br.ReadByte();
            Blue = br.ReadByte();
            Alpha = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Red={Red}");
            sw.WriteLine($"{ident}Green={Green}");
            sw.WriteLine($"{ident}Blue={Blue}");
            sw.WriteLine($"{ident}Alpha={Alpha}");
        }
    }

    public struct RgbColorDef
    {
        public Byte Red;
        public Byte Green;
        public Byte Blue;

        public RgbColorDef Read(BinaryReader br)
        {
            // read each field
            Red = br.ReadByte();
            Green = br.ReadByte();
            Blue = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Red={Red}");
            sw.WriteLine($"{ident}Green={Green}");
            sw.WriteLine($"{ident}Blue={Blue}");
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ExtScanList_union_Pcl
    {
        [FieldOffset(0)]
        public UInt16 Propval;
        [FieldOffset(0)]
        public UInt16 Cell0;

        public ExtScanList_union_Pcl Read(BinaryReader br)
        {
            // read each field
            Propval = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Propval={Propval}");
            sw.WriteLine($"{ident}Cell0={Cell0}");
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ExtScanList_union_Pch
    {
        [FieldOffset(0)]
        public UInt16 Propmsk;
        [FieldOffset(0)]
        public UInt16 Cell1;

        public ExtScanList_union_Pch Read(BinaryReader br)
        {
            // read each field
            Propmsk = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Propmsk={Propmsk}");
            sw.WriteLine($"{ident}Cell1={Cell1}");
        }
    }

    public struct Dpoint3d
    {
        public double X;
        public double Y;
        public double Z;

        public Dpoint3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            Z = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct ScanRange
    {
        public Int64 Xlowlim;
        public Int64 Ylowlim;
        public Int64 Zlowlim;
        public Int64 Xhighlim;
        public Int64 Yhighlim;
        public Int64 Zhighlim;

        public ScanRange Read(BinaryReader br)
        {
            // read each field
            Xlowlim = br.ReadInt64();
            Ylowlim = br.ReadInt64();
            Zlowlim = br.ReadInt64();
            Xhighlim = br.ReadInt64();
            Yhighlim = br.ReadInt64();
            Zhighlim = br.ReadInt64();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Xlowlim={Xlowlim}");
            sw.WriteLine($"{ident}Ylowlim={Ylowlim}");
            sw.WriteLine($"{ident}Zlowlim={Zlowlim}");
            sw.WriteLine($"{ident}Xhighlim={Xhighlim}");
            sw.WriteLine($"{ident}Yhighlim={Yhighlim}");
            sw.WriteLine($"{ident}Zhighlim={Zhighlim}");
        }
    }

    public struct ViewFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 1, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        private const int sz_1_22 = 1, loc_1_22 = loc_1_21 + sz_1_21, mask_1_22 = unchecked(((1 << sz_1_22) - 1) << loc_1_22);
        private const int sz_1_23 = 6, loc_1_23 = loc_1_22 + sz_1_22, mask_1_23 = unchecked(((1 << sz_1_23) - 1) << loc_1_23);
        private const int sz_1_24 = 1, loc_1_24 = loc_1_23 + sz_1_23, mask_1_24 = unchecked(((1 << sz_1_24) - 1) << loc_1_24);
        private const int sz_1_25 = 1, loc_1_25 = loc_1_24 + sz_1_24, mask_1_25 = unchecked(((1 << sz_1_25) - 1) << loc_1_25);
        private const int sz_1_26 = 1, loc_1_26 = loc_1_25 + sz_1_25, mask_1_26 = unchecked(((1 << sz_1_26) - 1) << loc_1_26);
        private UInt32 Data2;
        private const int sz_2_0 = 1, loc_2_0 = 0, mask_2_0 = unchecked(((1 << sz_2_0) - 1) << loc_2_0);
        private const int sz_2_1 = 1, loc_2_1 = loc_2_0 + sz_2_0, mask_2_1 = unchecked(((1 << sz_2_1) - 1) << loc_2_1);
        private const int sz_2_2 = 1, loc_2_2 = loc_2_1 + sz_2_1, mask_2_2 = unchecked(((1 << sz_2_2) - 1) << loc_2_2);
        private const int sz_2_3 = 1, loc_2_3 = loc_2_2 + sz_2_2, mask_2_3 = unchecked(((1 << sz_2_3) - 1) << loc_2_3);
        private const int sz_2_4 = 1, loc_2_4 = loc_2_3 + sz_2_3, mask_2_4 = unchecked(((1 << sz_2_4) - 1) << loc_2_4);
        private const int sz_2_5 = 1, loc_2_5 = loc_2_4 + sz_2_4, mask_2_5 = unchecked(((1 << sz_2_5) - 1) << loc_2_5);
        private const int sz_2_6 = 1, loc_2_6 = loc_2_5 + sz_2_5, mask_2_6 = unchecked(((1 << sz_2_6) - 1) << loc_2_6);
        private const int sz_2_7 = 1, loc_2_7 = loc_2_6 + sz_2_6, mask_2_7 = unchecked(((1 << sz_2_7) - 1) << loc_2_7);
        private const int sz_2_8 = 1, loc_2_8 = loc_2_7 + sz_2_7, mask_2_8 = unchecked(((1 << sz_2_8) - 1) << loc_2_8);
        private const int sz_2_9 = 1, loc_2_9 = loc_2_8 + sz_2_8, mask_2_9 = unchecked(((1 << sz_2_9) - 1) << loc_2_9);
        private const int sz_2_10 = 1, loc_2_10 = loc_2_9 + sz_2_9, mask_2_10 = unchecked(((1 << sz_2_10) - 1) << loc_2_10);
        private const int sz_2_11 = 1, loc_2_11 = loc_2_10 + sz_2_10, mask_2_11 = unchecked(((1 << sz_2_11) - 1) << loc_2_11);
        private const int sz_2_12 = 1, loc_2_12 = loc_2_11 + sz_2_11, mask_2_12 = unchecked(((1 << sz_2_12) - 1) << loc_2_12);
        private const int sz_2_13 = 1, loc_2_13 = loc_2_12 + sz_2_12, mask_2_13 = unchecked(((1 << sz_2_13) - 1) << loc_2_13);
        private const int sz_2_14 = 1, loc_2_14 = loc_2_13 + sz_2_13, mask_2_14 = unchecked(((1 << sz_2_14) - 1) << loc_2_14);
        private const int sz_2_15 = 1, loc_2_15 = loc_2_14 + sz_2_14, mask_2_15 = unchecked(((1 << sz_2_15) - 1) << loc_2_15);
        private const int sz_2_16 = 1, loc_2_16 = loc_2_15 + sz_2_15, mask_2_16 = unchecked(((1 << sz_2_16) - 1) << loc_2_16);
        private const int sz_2_17 = 1, loc_2_17 = loc_2_16 + sz_2_16, mask_2_17 = unchecked(((1 << sz_2_17) - 1) << loc_2_17);
        private const int sz_2_18 = 1, loc_2_18 = loc_2_17 + sz_2_17, mask_2_18 = unchecked(((1 << sz_2_18) - 1) << loc_2_18);
        private const int sz_2_19 = 1, loc_2_19 = loc_2_18 + sz_2_18, mask_2_19 = unchecked(((1 << sz_2_19) - 1) << loc_2_19);
        private const int sz_2_20 = 1, loc_2_20 = loc_2_19 + sz_2_19, mask_2_20 = unchecked(((1 << sz_2_20) - 1) << loc_2_20);
        private const int sz_2_21 = 1, loc_2_21 = loc_2_20 + sz_2_20, mask_2_21 = unchecked(((1 << sz_2_21) - 1) << loc_2_21);
        private const int sz_2_22 = 1, loc_2_22 = loc_2_21 + sz_2_21, mask_2_22 = unchecked(((1 << sz_2_22) - 1) << loc_2_22);
        private const int sz_2_23 = 1, loc_2_23 = loc_2_22 + sz_2_22, mask_2_23 = unchecked(((1 << sz_2_23) - 1) << loc_2_23);
        private const int sz_2_24 = 1, loc_2_24 = loc_2_23 + sz_2_23, mask_2_24 = unchecked(((1 << sz_2_24) - 1) << loc_2_24);
        private const int sz_2_25 = 1, loc_2_25 = loc_2_24 + sz_2_24, mask_2_25 = unchecked(((1 << sz_2_25) - 1) << loc_2_25);
        private const int sz_2_26 = 1, loc_2_26 = loc_2_25 + sz_2_25, mask_2_26 = unchecked(((1 << sz_2_26) - 1) << loc_2_26);
        private const int sz_2_27 = 3, loc_2_27 = loc_2_26 + sz_2_26, mask_2_27 = unchecked(((1 << sz_2_27) - 1) << loc_2_27);
        private const int sz_2_28 = 1, loc_2_28 = loc_2_27 + sz_2_27, mask_2_28 = unchecked(((1 << sz_2_28) - 1) << loc_2_28);
        private const int sz_2_29 = 1, loc_2_29 = loc_2_28 + sz_2_28, mask_2_29 = unchecked(((1 << sz_2_29) - 1) << loc_2_29);
        private UInt32 Data3;
        private const int sz_3_0 = 32, loc_3_0 = 0, mask_3_0 = unchecked(((1 << sz_3_0) - 1) << loc_3_0);
        public UInt32 Deprecated1
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Fast_text
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Deprecated2
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Line_wghts
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Patterns
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Text_nodes
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Ed_fields
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 On_off
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Deprecated3
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Grid
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Lev_symb
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Deprecated4
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Constructs
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Dimens
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Fast_cell
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 Def
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 Fill
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 Deprecated5
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 AuxDisplay
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 Deprecated6
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 Deprecated7
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 HideNamedPresentation
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }
        public UInt32 Camera
        {
            get => (UInt32)(Data1 & mask_1_22) >> loc_1_22;
            set => Data1 = (UInt32)(Data1 & ~mask_1_22 | (value << loc_1_22) & mask_1_22);
        }
        public UInt32 RenderMode
        {
            get => (UInt32)(Data1 & mask_1_23) >> loc_1_23;
            set => Data1 = (UInt32)(Data1 & ~mask_1_23 | (value << loc_1_23) & mask_1_23);
        }
        public UInt32 Background
        {
            get => (UInt32)(Data1 & mask_1_24) >> loc_1_24;
            set => Data1 = (UInt32)(Data1 & ~mask_1_24 | (value << loc_1_24) & mask_1_24);
        }
        public UInt32 RefBoundaryDisplay
        {
            get => (UInt32)(Data1 & mask_1_25) >> loc_1_25;
            set => Data1 = (UInt32)(Data1 & ~mask_1_25 | (value << loc_1_25) & mask_1_25);
        }
        public UInt32 Deprecated8
        {
            get => (UInt32)(Data1 & mask_1_26) >> loc_1_26;
            set => Data1 = (UInt32)(Data1 & ~mask_1_26 | (value << loc_1_26) & mask_1_26);
        }
        public UInt32 Deprecated9
        {
            get => (UInt32)(Data2 & mask_2_0) >> loc_2_0;
            set => Data2 = (UInt32)(Data2 & ~mask_2_0 | (value << loc_2_0) & mask_2_0);
        }
        public UInt32 Deprecated10
        {
            get => (UInt32)(Data2 & mask_2_1) >> loc_2_1;
            set => Data2 = (UInt32)(Data2 & ~mask_2_1 | (value << loc_2_1) & mask_2_1);
        }
        public UInt32 Deprecated11
        {
            get => (UInt32)(Data2 & mask_2_2) >> loc_2_2;
            set => Data2 = (UInt32)(Data2 & ~mask_2_2 | (value << loc_2_2) & mask_2_2);
        }
        public UInt32 Deprecated12
        {
            get => (UInt32)(Data2 & mask_2_3) >> loc_2_3;
            set => Data2 = (UInt32)(Data2 & ~mask_2_3 | (value << loc_2_3) & mask_2_3);
        }
        public UInt32 TextureMaps
        {
            get => (UInt32)(Data2 & mask_2_4) >> loc_2_4;
            set => Data2 = (UInt32)(Data2 & ~mask_2_4 | (value << loc_2_4) & mask_2_4);
        }
        public UInt32 Deprecated13
        {
            get => (UInt32)(Data2 & mask_2_5) >> loc_2_5;
            set => Data2 = (UInt32)(Data2 & ~mask_2_5 | (value << loc_2_5) & mask_2_5);
        }
        public UInt32 Transparency
        {
            get => (UInt32)(Data2 & mask_2_6) >> loc_2_6;
            set => Data2 = (UInt32)(Data2 & ~mask_2_6 | (value << loc_2_6) & mask_2_6);
        }
        public UInt32 Deprecated14
        {
            get => (UInt32)(Data2 & mask_2_7) >> loc_2_7;
            set => Data2 = (UInt32)(Data2 & ~mask_2_7 | (value << loc_2_7) & mask_2_7);
        }
        public UInt32 InhibitLineStyles
        {
            get => (UInt32)(Data2 & mask_2_8) >> loc_2_8;
            set => Data2 = (UInt32)(Data2 & ~mask_2_8 | (value << loc_2_8) & mask_2_8);
        }
        public UInt32 Deprecated15
        {
            get => (UInt32)(Data2 & mask_2_9) >> loc_2_9;
            set => Data2 = (UInt32)(Data2 & ~mask_2_9 | (value << loc_2_9) & mask_2_9);
        }
        public UInt32 PatternDynamics
        {
            get => (UInt32)(Data2 & mask_2_10) >> loc_2_10;
            set => Data2 = (UInt32)(Data2 & ~mask_2_10 | (value << loc_2_10) & mask_2_10);
        }
        public UInt32 Deprecated16
        {
            get => (UInt32)(Data2 & mask_2_11) >> loc_2_11;
            set => Data2 = (UInt32)(Data2 & ~mask_2_11 | (value << loc_2_11) & mask_2_11);
        }
        public UInt32 TagsOff
        {
            get => (UInt32)(Data2 & mask_2_12) >> loc_2_12;
            set => Data2 = (UInt32)(Data2 & ~mask_2_12 | (value << loc_2_12) & mask_2_12);
        }
        public UInt32 RenderDisplayEdges
        {
            get => (UInt32)(Data2 & mask_2_13) >> loc_2_13;
            set => Data2 = (UInt32)(Data2 & ~mask_2_13 | (value << loc_2_13) & mask_2_13);
        }
        public UInt32 RenderDisplayHidden
        {
            get => (UInt32)(Data2 & mask_2_14) >> loc_2_14;
            set => Data2 = (UInt32)(Data2 & ~mask_2_14 | (value << loc_2_14) & mask_2_14);
        }
        public UInt32 IsNamed_deprecated
        {
            get => (UInt32)(Data2 & mask_2_15) >> loc_2_15;
            set => Data2 = (UInt32)(Data2 & ~mask_2_15 | (value << loc_2_15) & mask_2_15);
        }
        public UInt32 Deprecated17
        {
            get => (UInt32)(Data2 & mask_2_16) >> loc_2_16;
            set => Data2 = (UInt32)(Data2 & ~mask_2_16 | (value << loc_2_16) & mask_2_16);
        }
        public UInt32 OverrideBackground
        {
            get => (UInt32)(Data2 & mask_2_17) >> loc_2_17;
            set => Data2 = (UInt32)(Data2 & ~mask_2_17 | (value << loc_2_17) & mask_2_17);
        }
        public UInt32 NoFrontClip
        {
            get => (UInt32)(Data2 & mask_2_18) >> loc_2_18;
            set => Data2 = (UInt32)(Data2 & ~mask_2_18 | (value << loc_2_18) & mask_2_18);
        }
        public UInt32 NoBackClip
        {
            get => (UInt32)(Data2 & mask_2_19) >> loc_2_19;
            set => Data2 = (UInt32)(Data2 & ~mask_2_19 | (value << loc_2_19) & mask_2_19);
        }
        public UInt32 NoClipVolume
        {
            get => (UInt32)(Data2 & mask_2_20) >> loc_2_20;
            set => Data2 = (UInt32)(Data2 & ~mask_2_20 | (value << loc_2_20) & mask_2_20);
        }
        public UInt32 UseDisplaySet
        {
            get => (UInt32)(Data2 & mask_2_21) >> loc_2_21;
            set => Data2 = (UInt32)(Data2 & ~mask_2_21 | (value << loc_2_21) & mask_2_21);
        }
        public UInt32 AssociativeClip
        {
            get => (UInt32)(Data2 & mask_2_22) >> loc_2_22;
            set => Data2 = (UInt32)(Data2 & ~mask_2_22 | (value << loc_2_22) & mask_2_22);
        }
        public UInt32 Minimized
        {
            get => (UInt32)(Data2 & mask_2_23) >> loc_2_23;
            set => Data2 = (UInt32)(Data2 & ~mask_2_23 | (value << loc_2_23) & mask_2_23);
        }
        public UInt32 Maximized
        {
            get => (UInt32)(Data2 & mask_2_24) >> loc_2_24;
            set => Data2 = (UInt32)(Data2 & ~mask_2_24 | (value << loc_2_24) & mask_2_24);
        }
        public UInt32 RenderDisplayShadows
        {
            get => (UInt32)(Data2 & mask_2_25) >> loc_2_25;
            set => Data2 = (UInt32)(Data2 & ~mask_2_25 | (value << loc_2_25) & mask_2_25);
        }
        public UInt32 DisableHeightMaps
        {
            get => (UInt32)(Data2 & mask_2_26) >> loc_2_26;
            set => Data2 = (UInt32)(Data2 & ~mask_2_26 | (value << loc_2_26) & mask_2_26);
        }
        public UInt32 HiddenLineStyle
        {
            get => (UInt32)(Data2 & mask_2_27) >> loc_2_27;
            set => Data2 = (UInt32)(Data2 & ~mask_2_27 | (value << loc_2_27) & mask_2_27);
        }
        public UInt32 InhibitRenderMaterials
        {
            get => (UInt32)(Data2 & mask_2_28) >> loc_2_28;
            set => Data2 = (UInt32)(Data2 & ~mask_2_28 | (value << loc_2_28) & mask_2_28);
        }
        public UInt32 IgnoreSceneLights
        {
            get => (UInt32)(Data2 & mask_2_29) >> loc_2_29;
            set => Data2 = (UInt32)(Data2 & ~mask_2_29 | (value << loc_2_29) & mask_2_29);
        }
        public UInt32 Reserved3
        {
            get => (UInt32)(Data3 & mask_3_0) >> loc_3_0;
            set => Data3 = (UInt32)(Data3 & ~mask_3_0 | (value << loc_3_0) & mask_3_0);
        }

        public ViewFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Data2 = br.ReadUInt32();
            Data3 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Deprecated1={Deprecated1}");
            sw.WriteLine($"{ident}Fast_text={Fast_text}");
            sw.WriteLine($"{ident}Deprecated2={Deprecated2}");
            sw.WriteLine($"{ident}Line_wghts={Line_wghts}");
            sw.WriteLine($"{ident}Patterns={Patterns}");
            sw.WriteLine($"{ident}Text_nodes={Text_nodes}");
            sw.WriteLine($"{ident}Ed_fields={Ed_fields}");
            sw.WriteLine($"{ident}On_off={On_off}");
            sw.WriteLine($"{ident}Deprecated3={Deprecated3}");
            sw.WriteLine($"{ident}Grid={Grid}");
            sw.WriteLine($"{ident}Lev_symb={Lev_symb}");
            sw.WriteLine($"{ident}Deprecated4={Deprecated4}");
            sw.WriteLine($"{ident}Constructs={Constructs}");
            sw.WriteLine($"{ident}Dimens={Dimens}");
            sw.WriteLine($"{ident}Fast_cell={Fast_cell}");
            sw.WriteLine($"{ident}Def={Def}");
            sw.WriteLine($"{ident}Fill={Fill}");
            sw.WriteLine($"{ident}Deprecated5={Deprecated5}");
            sw.WriteLine($"{ident}AuxDisplay={AuxDisplay}");
            sw.WriteLine($"{ident}Deprecated6={Deprecated6}");
            sw.WriteLine($"{ident}Deprecated7={Deprecated7}");
            sw.WriteLine($"{ident}HideNamedPresentation={HideNamedPresentation}");
            sw.WriteLine($"{ident}Camera={Camera}");
            sw.WriteLine($"{ident}RenderMode={RenderMode}");
            sw.WriteLine($"{ident}Background={Background}");
            sw.WriteLine($"{ident}RefBoundaryDisplay={RefBoundaryDisplay}");
            sw.WriteLine($"{ident}Deprecated8={Deprecated8}");
            sw.WriteLine($"{ident}Deprecated9={Deprecated9}");
            sw.WriteLine($"{ident}Deprecated10={Deprecated10}");
            sw.WriteLine($"{ident}Deprecated11={Deprecated11}");
            sw.WriteLine($"{ident}Deprecated12={Deprecated12}");
            sw.WriteLine($"{ident}TextureMaps={TextureMaps}");
            sw.WriteLine($"{ident}Deprecated13={Deprecated13}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
            sw.WriteLine($"{ident}Deprecated14={Deprecated14}");
            sw.WriteLine($"{ident}InhibitLineStyles={InhibitLineStyles}");
            sw.WriteLine($"{ident}Deprecated15={Deprecated15}");
            sw.WriteLine($"{ident}PatternDynamics={PatternDynamics}");
            sw.WriteLine($"{ident}Deprecated16={Deprecated16}");
            sw.WriteLine($"{ident}TagsOff={TagsOff}");
            sw.WriteLine($"{ident}RenderDisplayEdges={RenderDisplayEdges}");
            sw.WriteLine($"{ident}RenderDisplayHidden={RenderDisplayHidden}");
            sw.WriteLine($"{ident}IsNamed_deprecated={IsNamed_deprecated}");
            sw.WriteLine($"{ident}Deprecated17={Deprecated17}");
            sw.WriteLine($"{ident}OverrideBackground={OverrideBackground}");
            sw.WriteLine($"{ident}NoFrontClip={NoFrontClip}");
            sw.WriteLine($"{ident}NoBackClip={NoBackClip}");
            sw.WriteLine($"{ident}NoClipVolume={NoClipVolume}");
            sw.WriteLine($"{ident}UseDisplaySet={UseDisplaySet}");
            sw.WriteLine($"{ident}AssociativeClip={AssociativeClip}");
            sw.WriteLine($"{ident}Minimized={Minimized}");
            sw.WriteLine($"{ident}Maximized={Maximized}");
            sw.WriteLine($"{ident}RenderDisplayShadows={RenderDisplayShadows}");
            sw.WriteLine($"{ident}DisableHeightMaps={DisableHeightMaps}");
            sw.WriteLine($"{ident}HiddenLineStyle={HiddenLineStyle}");
            sw.WriteLine($"{ident}InhibitRenderMaterials={InhibitRenderMaterials}");
            sw.WriteLine($"{ident}IgnoreSceneLights={IgnoreSceneLights}");
            sw.WriteLine($"{ident}Reserved3={Reserved3}");
        }
    }

    public struct DirFormat_Flags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 15, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt16 Clockwise
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Unused
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public DirFormat_Flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Clockwise={Clockwise}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct DirFormat
    {
        public UInt16 Mode;
        public UInt16[] Unused;
        public DirFormat_Flags Flags;
        public double BaseDir;

        public DirFormat Read(BinaryReader br)
        {
            // read each field
            Mode = br.ReadUInt16();
            Unused = new UInt16[2];
            for (int i = 0; i < 2; i++)
            {
                Unused[i] = br.ReadUInt16();
            }
            Flags = new DirFormat_Flags().Read(br);
            BaseDir = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}Unused={Unused[i]}");
            }
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BaseDir={BaseDir}");
        }
    }

    public struct Autodim1_Format
    {
        private UInt16 Data1;
        private const int sz_1_0 = 8, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 3, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt16 Adres2
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Ref_mastersub
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Ref_decfract
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 AccuracyFlags
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public Autodim1_Format Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Adres2={Adres2}");
            sw.WriteLine($"{ident}Ref_mastersub={Ref_mastersub}");
            sw.WriteLine($"{ident}Ref_decfract={Ref_decfract}");
            sw.WriteLine($"{ident}AccuracyFlags={AccuracyFlags}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct Autodim1
    {
        public Autodim1_Format Format;

        public Autodim1 Read(BinaryReader br)
        {
            // read each field
            Format = new Autodim1_Format().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Format >");
            Format.Dump(sw, level + 1);
        }
    }

    public struct Symbology
    {
        public Int32 Style;
        public UInt32 Weight;
        public UInt32 Color;

        public Symbology Read(BinaryReader br)
        {
            // read each field
            Style = br.ReadInt32();
            Weight = br.ReadUInt32();
            Color = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Color={Color}");
        }
    }

    public struct DegreeOfFreedom
    {
        public Int32 Locked;
        public UInt32 Reserved1;
        public T_Adouble Value;

        public DegreeOfFreedom Read(BinaryReader br)
        {
            // read each field
            Locked = br.ReadInt32();
            Reserved1 = br.ReadUInt32();
            Value = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Locked={Locked}");
            sw.WriteLine($"{ident}Value={Value}");
        }
    }

    public struct HLineFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 3, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 3, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 3, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 7, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        public UInt32 IncludeHidden
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 IncludeRules
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 CalculateIntersections
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 OutputToMaster
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ThreeD
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Boundary
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MasterHiddenLine
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 MasterDisplayHidden
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Annotations
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 SmoothEdges
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 ExpandCustomLinestyles
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 ExpandHatch
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 AutoOpenOutputFile
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 FacetAllSurfaces
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 ColorFromMaterial
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 IgnoreTransparency
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 TransparencyThreshold
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 ExactMode
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 PlotExactMode
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }

        public HLineFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IncludeHidden={IncludeHidden}");
            sw.WriteLine($"{ident}IncludeRules={IncludeRules}");
            sw.WriteLine($"{ident}CalculateIntersections={CalculateIntersections}");
            sw.WriteLine($"{ident}OutputToMaster={OutputToMaster}");
            sw.WriteLine($"{ident}ThreeD={ThreeD}");
            sw.WriteLine($"{ident}Boundary={Boundary}");
            sw.WriteLine($"{ident}MasterHiddenLine={MasterHiddenLine}");
            sw.WriteLine($"{ident}MasterDisplayHidden={MasterDisplayHidden}");
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}Annotations={Annotations}");
            sw.WriteLine($"{ident}SmoothEdges={SmoothEdges}");
            sw.WriteLine($"{ident}ExpandCustomLinestyles={ExpandCustomLinestyles}");
            sw.WriteLine($"{ident}ExpandHatch={ExpandHatch}");
            sw.WriteLine($"{ident}AutoOpenOutputFile={AutoOpenOutputFile}");
            sw.WriteLine($"{ident}FacetAllSurfaces={FacetAllSurfaces}");
            sw.WriteLine($"{ident}ColorFromMaterial={ColorFromMaterial}");
            sw.WriteLine($"{ident}IgnoreTransparency={IgnoreTransparency}");
            sw.WriteLine($"{ident}TransparencyThreshold={TransparencyThreshold}");
            sw.WriteLine($"{ident}ExactMode={ExactMode}");
            sw.WriteLine($"{ident}PlotExactMode={PlotExactMode}");
        }
    }

    public struct HLineFlags2
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 29, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 M_edgeLineStyles
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_cveFastMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_retainCacheWhileValidOnly
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public HLineFlags2 Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_edgeLineStyles={M_edgeLineStyles}");
            sw.WriteLine($"{ident}M_cveFastMode={M_cveFastMode}");
            sw.WriteLine($"{ident}M_retainCacheWhileValidOnly={M_retainCacheWhileValidOnly}");
            sw.WriteLine($"{ident}M_unused={M_unused}");
        }
    }

    public struct HLineSymbology
    {
        public LevelId Level;
        public UInt32 Color;
        public Int32 Style;
        public UInt32 Weight;
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 28, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 LevelOverride
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ColorOverride
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 StyleOverride
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 WeightOverride
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public HLineSymbology Read(BinaryReader br)
        {
            // read each field
            Level = br.ReadUInt32();
            Color = br.ReadUInt32();
            Style = br.ReadInt32();
            Weight = br.ReadUInt32();
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Level={Level}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}LevelOverride={LevelOverride}");
            sw.WriteLine($"{ident}ColorOverride={ColorOverride}");
            sw.WriteLine($"{ident}StyleOverride={StyleOverride}");
            sw.WriteLine($"{ident}WeightOverride={WeightOverride}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct TextStyleOverrideFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private UInt16 Data2;
        private const int sz_2_0 = 1, loc_2_0 = 0, mask_2_0 = unchecked(((1 << sz_2_0) - 1) << loc_2_0);
        private const int sz_2_1 = 1, loc_2_1 = loc_2_0 + sz_2_0, mask_2_1 = unchecked(((1 << sz_2_1) - 1) << loc_2_1);
        private const int sz_2_2 = 1, loc_2_2 = loc_2_1 + sz_2_1, mask_2_2 = unchecked(((1 << sz_2_2) - 1) << loc_2_2);
        private const int sz_2_3 = 1, loc_2_3 = loc_2_2 + sz_2_2, mask_2_3 = unchecked(((1 << sz_2_3) - 1) << loc_2_3);
        private const int sz_2_4 = 1, loc_2_4 = loc_2_3 + sz_2_3, mask_2_4 = unchecked(((1 << sz_2_4) - 1) << loc_2_4);
        private const int sz_2_5 = 1, loc_2_5 = loc_2_4 + sz_2_4, mask_2_5 = unchecked(((1 << sz_2_5) - 1) << loc_2_5);
        private const int sz_2_6 = 1, loc_2_6 = loc_2_5 + sz_2_5, mask_2_6 = unchecked(((1 << sz_2_6) - 1) << loc_2_6);
        private const int sz_2_7 = 1, loc_2_7 = loc_2_6 + sz_2_6, mask_2_7 = unchecked(((1 << sz_2_7) - 1) << loc_2_7);
        private const int sz_2_8 = 1, loc_2_8 = loc_2_7 + sz_2_7, mask_2_8 = unchecked(((1 << sz_2_8) - 1) << loc_2_8);
        private const int sz_2_9 = 1, loc_2_9 = loc_2_8 + sz_2_8, mask_2_9 = unchecked(((1 << sz_2_9) - 1) << loc_2_9);
        private const int sz_2_10 = 1, loc_2_10 = loc_2_9 + sz_2_9, mask_2_10 = unchecked(((1 << sz_2_10) - 1) << loc_2_10);
        private const int sz_2_11 = 1, loc_2_11 = loc_2_10 + sz_2_10, mask_2_11 = unchecked(((1 << sz_2_11) - 1) << loc_2_11);
        private const int sz_2_12 = 1, loc_2_12 = loc_2_11 + sz_2_11, mask_2_12 = unchecked(((1 << sz_2_12) - 1) << loc_2_12);
        private const int sz_2_13 = 1, loc_2_13 = loc_2_12 + sz_2_12, mask_2_13 = unchecked(((1 << sz_2_13) - 1) << loc_2_13);
        private const int sz_2_14 = 1, loc_2_14 = loc_2_13 + sz_2_13, mask_2_14 = unchecked(((1 << sz_2_14) - 1) << loc_2_14);
        private const int sz_2_15 = 1, loc_2_15 = loc_2_14 + sz_2_14, mask_2_15 = unchecked(((1 << sz_2_15) - 1) << loc_2_15);
        private UInt16 Data3;
        private const int sz_3_0 = 1, loc_3_0 = 0, mask_3_0 = unchecked(((1 << sz_3_0) - 1) << loc_3_0);
        private const int sz_3_1 = 1, loc_3_1 = loc_3_0 + sz_3_0, mask_3_1 = unchecked(((1 << sz_3_1) - 1) << loc_3_1);
        private const int sz_3_2 = 1, loc_3_2 = loc_3_1 + sz_3_1, mask_3_2 = unchecked(((1 << sz_3_2) - 1) << loc_3_2);
        private const int sz_3_3 = 1, loc_3_3 = loc_3_2 + sz_3_2, mask_3_3 = unchecked(((1 << sz_3_3) - 1) << loc_3_3);
        private const int sz_3_4 = 1, loc_3_4 = loc_3_3 + sz_3_3, mask_3_4 = unchecked(((1 << sz_3_4) - 1) << loc_3_4);
        private const int sz_3_5 = 1, loc_3_5 = loc_3_4 + sz_3_4, mask_3_5 = unchecked(((1 << sz_3_5) - 1) << loc_3_5);
        private const int sz_3_6 = 1, loc_3_6 = loc_3_5 + sz_3_5, mask_3_6 = unchecked(((1 << sz_3_6) - 1) << loc_3_6);
        private const int sz_3_7 = 1, loc_3_7 = loc_3_6 + sz_3_6, mask_3_7 = unchecked(((1 << sz_3_7) - 1) << loc_3_7);
        private const int sz_3_8 = 1, loc_3_8 = loc_3_7 + sz_3_7, mask_3_8 = unchecked(((1 << sz_3_8) - 1) << loc_3_8);
        private const int sz_3_9 = 1, loc_3_9 = loc_3_8 + sz_3_8, mask_3_9 = unchecked(((1 << sz_3_9) - 1) << loc_3_9);
        private const int sz_3_10 = 1, loc_3_10 = loc_3_9 + sz_3_9, mask_3_10 = unchecked(((1 << sz_3_10) - 1) << loc_3_10);
        private const int sz_3_11 = 1, loc_3_11 = loc_3_10 + sz_3_10, mask_3_11 = unchecked(((1 << sz_3_11) - 1) << loc_3_11);
        private const int sz_3_12 = 4, loc_3_12 = loc_3_11 + sz_3_11, mask_3_12 = unchecked(((1 << sz_3_12) - 1) << loc_3_12);
        private UInt16 Data4;
        private const int sz_4_0 = 16, loc_4_0 = 0, mask_4_0 = unchecked(((1 << sz_4_0) - 1) << loc_4_0);
        public UInt16 FontNo
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 ShxBigFont
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Width
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Height
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Slant
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Linespacing
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 InterCharSpacing
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 UnderlineOffset
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 OverlineOffset
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt16 Just
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_9) >> loc_1_9);
            set => Data1 = (UInt16)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt16 NodeJust
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_10) >> loc_1_10);
            set => Data1 = (UInt16)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt16 LineLength
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_11) >> loc_1_11);
            set => Data1 = (UInt16)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt16 Direction
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_12) >> loc_1_12);
            set => Data1 = (UInt16)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt16 Underline
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_13) >> loc_1_13);
            set => Data1 = (UInt16)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt16 Overline
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_14) >> loc_1_14);
            set => Data1 = (UInt16)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt16 Italics
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_15) >> loc_1_15);
            set => Data1 = (UInt16)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt16 Bold
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_0) >> loc_2_0);
            set => Data2 = (UInt16)(Data2 & ~mask_2_0 | (value << loc_2_0) & mask_2_0);
        }
        public UInt16 Superscript
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_1) >> loc_2_1);
            set => Data2 = (UInt16)(Data2 & ~mask_2_1 | (value << loc_2_1) & mask_2_1);
        }
        public UInt16 Subscript
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_2) >> loc_2_2);
            set => Data2 = (UInt16)(Data2 & ~mask_2_2 | (value << loc_2_2) & mask_2_2);
        }
        public UInt16 FixedSpacing
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_3) >> loc_2_3);
            set => Data2 = (UInt16)(Data2 & ~mask_2_3 | (value << loc_2_3) & mask_2_3);
        }
        public UInt16 Background
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_4) >> loc_2_4);
            set => Data2 = (UInt16)(Data2 & ~mask_2_4 | (value << loc_2_4) & mask_2_4);
        }
        public UInt16 Backgroundstyle
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_5) >> loc_2_5);
            set => Data2 = (UInt16)(Data2 & ~mask_2_5 | (value << loc_2_5) & mask_2_5);
        }
        public UInt16 Backgroundweight
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_6) >> loc_2_6);
            set => Data2 = (UInt16)(Data2 & ~mask_2_6 | (value << loc_2_6) & mask_2_6);
        }
        public UInt16 Backgroundcolor
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_7) >> loc_2_7);
            set => Data2 = (UInt16)(Data2 & ~mask_2_7 | (value << loc_2_7) & mask_2_7);
        }
        public UInt16 Backgroundfillcolor
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_8) >> loc_2_8);
            set => Data2 = (UInt16)(Data2 & ~mask_2_8 | (value << loc_2_8) & mask_2_8);
        }
        public UInt16 Backgroundborder
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_9) >> loc_2_9);
            set => Data2 = (UInt16)(Data2 & ~mask_2_9 | (value << loc_2_9) & mask_2_9);
        }
        public UInt16 Underlinestyle
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_10) >> loc_2_10);
            set => Data2 = (UInt16)(Data2 & ~mask_2_10 | (value << loc_2_10) & mask_2_10);
        }
        public UInt16 Underlineweight
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_11) >> loc_2_11);
            set => Data2 = (UInt16)(Data2 & ~mask_2_11 | (value << loc_2_11) & mask_2_11);
        }
        public UInt16 Underlinecolor
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_12) >> loc_2_12);
            set => Data2 = (UInt16)(Data2 & ~mask_2_12 | (value << loc_2_12) & mask_2_12);
        }
        public UInt16 Overlinestyle
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_13) >> loc_2_13);
            set => Data2 = (UInt16)(Data2 & ~mask_2_13 | (value << loc_2_13) & mask_2_13);
        }
        public UInt16 Overlineweight
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_14) >> loc_2_14);
            set => Data2 = (UInt16)(Data2 & ~mask_2_14 | (value << loc_2_14) & mask_2_14);
        }
        public UInt16 Overlinecolor
        {
            get => (UInt16)((UInt16)(Data2 & mask_2_15) >> loc_2_15);
            set => Data2 = (UInt16)(Data2 & ~mask_2_15 | (value << loc_2_15) & mask_2_15);
        }
        public UInt16 LineOffset
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_0) >> loc_3_0);
            set => Data3 = (UInt16)(Data3 & ~mask_3_0 | (value << loc_3_0) & mask_3_0);
        }
        public UInt16 Fractions
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_1) >> loc_3_1);
            set => Data3 = (UInt16)(Data3 & ~mask_3_1 | (value << loc_3_1) & mask_3_1);
        }
        public UInt16 Overlinestyleflag
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_2) >> loc_3_2);
            set => Data3 = (UInt16)(Data3 & ~mask_3_2 | (value << loc_3_2) & mask_3_2);
        }
        public UInt16 Underlinestyleflag
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_3) >> loc_3_3);
            set => Data3 = (UInt16)(Data3 & ~mask_3_3 | (value << loc_3_3) & mask_3_3);
        }
        public UInt16 Color
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_4) >> loc_3_4);
            set => Data3 = (UInt16)(Data3 & ~mask_3_4 | (value << loc_3_4) & mask_3_4);
        }
        public UInt16 WidthFactor
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_5) >> loc_3_5);
            set => Data3 = (UInt16)(Data3 & ~mask_3_5 | (value << loc_3_5) & mask_3_5);
        }
        public UInt16 ColorFlag
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_6) >> loc_3_6);
            set => Data3 = (UInt16)(Data3 & ~mask_3_6 | (value << loc_3_6) & mask_3_6);
        }
        public UInt16 FullJustification
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_7) >> loc_3_7);
            set => Data3 = (UInt16)(Data3 & ~mask_3_7 | (value << loc_3_7) & mask_3_7);
        }
        public UInt16 AcadLineSpacingType
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_8) >> loc_3_8);
            set => Data3 = (UInt16)(Data3 & ~mask_3_8 | (value << loc_3_8) & mask_3_8);
        }
        public UInt16 Backwards
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_9) >> loc_3_9);
            set => Data3 = (UInt16)(Data3 & ~mask_3_9 | (value << loc_3_9) & mask_3_9);
        }
        public UInt16 Upsidedown
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_10) >> loc_3_10);
            set => Data3 = (UInt16)(Data3 & ~mask_3_10 | (value << loc_3_10) & mask_3_10);
        }
        public UInt16 AcadInterCharSpacing
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_11) >> loc_3_11);
            set => Data3 = (UInt16)(Data3 & ~mask_3_11 | (value << loc_3_11) & mask_3_11);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data3 & mask_3_12) >> loc_3_12);
            set => Data3 = (UInt16)(Data3 & ~mask_3_12 | (value << loc_3_12) & mask_3_12);
        }
        public UInt16 Reserved2
        {
            get => (UInt16)((UInt16)(Data4 & mask_4_0) >> loc_4_0);
            set => Data4 = (UInt16)(Data4 & ~mask_4_0 | (value << loc_4_0) & mask_4_0);
        }

        public TextStyleOverrideFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            Data2 = br.ReadUInt16();
            Data3 = br.ReadUInt16();
            Data4 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}FontNo={FontNo}");
            sw.WriteLine($"{ident}ShxBigFont={ShxBigFont}");
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}Height={Height}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}Linespacing={Linespacing}");
            sw.WriteLine($"{ident}InterCharSpacing={InterCharSpacing}");
            sw.WriteLine($"{ident}UnderlineOffset={UnderlineOffset}");
            sw.WriteLine($"{ident}OverlineOffset={OverlineOffset}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}NodeJust={NodeJust}");
            sw.WriteLine($"{ident}LineLength={LineLength}");
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}Underline={Underline}");
            sw.WriteLine($"{ident}Overline={Overline}");
            sw.WriteLine($"{ident}Italics={Italics}");
            sw.WriteLine($"{ident}Bold={Bold}");
            sw.WriteLine($"{ident}Superscript={Superscript}");
            sw.WriteLine($"{ident}Subscript={Subscript}");
            sw.WriteLine($"{ident}FixedSpacing={FixedSpacing}");
            sw.WriteLine($"{ident}Background={Background}");
            sw.WriteLine($"{ident}Backgroundstyle={Backgroundstyle}");
            sw.WriteLine($"{ident}Backgroundweight={Backgroundweight}");
            sw.WriteLine($"{ident}Backgroundcolor={Backgroundcolor}");
            sw.WriteLine($"{ident}Backgroundfillcolor={Backgroundfillcolor}");
            sw.WriteLine($"{ident}Backgroundborder={Backgroundborder}");
            sw.WriteLine($"{ident}Underlinestyle={Underlinestyle}");
            sw.WriteLine($"{ident}Underlineweight={Underlineweight}");
            sw.WriteLine($"{ident}Underlinecolor={Underlinecolor}");
            sw.WriteLine($"{ident}Overlinestyle={Overlinestyle}");
            sw.WriteLine($"{ident}Overlineweight={Overlineweight}");
            sw.WriteLine($"{ident}Overlinecolor={Overlinecolor}");
            sw.WriteLine($"{ident}LineOffset={LineOffset}");
            sw.WriteLine($"{ident}Fractions={Fractions}");
            sw.WriteLine($"{ident}Overlinestyleflag={Overlinestyleflag}");
            sw.WriteLine($"{ident}Underlinestyleflag={Underlinestyleflag}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}WidthFactor={WidthFactor}");
            sw.WriteLine($"{ident}ColorFlag={ColorFlag}");
            sw.WriteLine($"{ident}FullJustification={FullJustification}");
            sw.WriteLine($"{ident}AcadLineSpacingType={AcadLineSpacingType}");
            sw.WriteLine($"{ident}Backwards={Backwards}");
            sw.WriteLine($"{ident}Upsidedown={Upsidedown}");
            sw.WriteLine($"{ident}AcadInterCharSpacing={AcadInterCharSpacing}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Reserved2={Reserved2}");
        }
    }

    public struct TextStyleFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 2, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 15, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        public UInt32 Underline
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Overline
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Italics
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Bold
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Superscript
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Subscript
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Background
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 OverlineStyle
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 UnderlineStyle
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 FixedSpacing
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Fractions
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 AcadInterCharSpacing
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 FullJustification
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 AcadLineSpacingType
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 AcadShapeFile
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }

        public TextStyleFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Underline={Underline}");
            sw.WriteLine($"{ident}Overline={Overline}");
            sw.WriteLine($"{ident}Italics={Italics}");
            sw.WriteLine($"{ident}Bold={Bold}");
            sw.WriteLine($"{ident}Superscript={Superscript}");
            sw.WriteLine($"{ident}Subscript={Subscript}");
            sw.WriteLine($"{ident}Background={Background}");
            sw.WriteLine($"{ident}OverlineStyle={OverlineStyle}");
            sw.WriteLine($"{ident}UnderlineStyle={UnderlineStyle}");
            sw.WriteLine($"{ident}FixedSpacing={FixedSpacing}");
            sw.WriteLine($"{ident}Fractions={Fractions}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}AcadInterCharSpacing={AcadInterCharSpacing}");
            sw.WriteLine($"{ident}FullJustification={FullJustification}");
            sw.WriteLine($"{ident}AcadLineSpacingType={AcadLineSpacingType}");
            sw.WriteLine($"{ident}AcadShapeFile={AcadShapeFile}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct TextStyle
    {
        public UInt32 FontNo;
        public UInt32 ShxBigFont;
        public double Width;
        public double Height;
        public double Slant;
        public double LineSpacing;
        public double InterCharSpacing;
        public double UnderlineOffset;
        public double OverlineOffset;
        public double WidthFactor;
        public DPoint2d LineOffset;
        public UInt16 Just;
        public UInt16 NodeJust;
        public UInt16 LineLength;
        public UInt16 TextDirection;
        public Symbology BackgroundStyle;
        public UInt32 BackgroundFillColor;
        public DPoint2d BackgroundBorder;
        public Symbology UnderlineStyle;
        public Symbology OverlineStyle;
        public UInt32 ParentId;
        public TextStyleFlags Flags;
        public TextStyleOverrideFlags OverrideFlags;
        public UInt32 Color;
        public UInt32 Reserved1;
        public UInt32 Reserved2;
        public UInt32 Reserved3;
        public double Reserved4;

        public TextStyle Read(BinaryReader br)
        {
            // read each field
            FontNo = br.ReadUInt32();
            ShxBigFont = br.ReadUInt32();
            Width = br.ReadDouble();
            Height = br.ReadDouble();
            Slant = br.ReadDouble();
            LineSpacing = br.ReadDouble();
            InterCharSpacing = br.ReadDouble();
            UnderlineOffset = br.ReadDouble();
            OverlineOffset = br.ReadDouble();
            WidthFactor = br.ReadDouble();
            LineOffset = new DPoint2d().Read(br);
            Just = br.ReadUInt16();
            NodeJust = br.ReadUInt16();
            LineLength = br.ReadUInt16();
            TextDirection = br.ReadUInt16();
            BackgroundStyle = new Symbology().Read(br);
            BackgroundFillColor = br.ReadUInt32();
            BackgroundBorder = new DPoint2d().Read(br);
            UnderlineStyle = new Symbology().Read(br);
            OverlineStyle = new Symbology().Read(br);
            ParentId = br.ReadUInt32();
            Flags = new TextStyleFlags().Read(br);
            OverrideFlags = new TextStyleOverrideFlags().Read(br);
            Color = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Reserved2 = br.ReadUInt32();
            Reserved3 = br.ReadUInt32();
            Reserved4 = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}FontNo={FontNo}");
            sw.WriteLine($"{ident}ShxBigFont={ShxBigFont}");
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}Height={Height}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}LineSpacing={LineSpacing}");
            sw.WriteLine($"{ident}InterCharSpacing={InterCharSpacing}");
            sw.WriteLine($"{ident}UnderlineOffset={UnderlineOffset}");
            sw.WriteLine($"{ident}OverlineOffset={OverlineOffset}");
            sw.WriteLine($"{ident}WidthFactor={WidthFactor}");
            sw.WriteLine($"{ident}LineOffset >");
            LineOffset.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}NodeJust={NodeJust}");
            sw.WriteLine($"{ident}LineLength={LineLength}");
            sw.WriteLine($"{ident}TextDirection={TextDirection}");
            sw.WriteLine($"{ident}BackgroundStyle >");
            BackgroundStyle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BackgroundFillColor={BackgroundFillColor}");
            sw.WriteLine($"{ident}BackgroundBorder >");
            BackgroundBorder.Dump(sw, level + 1);
            sw.WriteLine($"{ident}UnderlineStyle >");
            UnderlineStyle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OverlineStyle >");
            OverlineStyle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ParentId={ParentId}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OverrideFlags >");
            OverrideFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Reserved2={Reserved2}");
            sw.WriteLine($"{ident}Reserved3={Reserved3}");
            sw.WriteLine($"{ident}Reserved4={Reserved4}");
        }
    }

    public struct UnitFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 26, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Base
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 System
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public UnitFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Base={Base}");
            sw.WriteLine($"{ident}System={System}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct StoredUnitInfo
    {
        public UnitFlags Flags;
        public double Numerator;
        public double Denominator;
        public byte[] Label;

        public StoredUnitInfo Read(BinaryReader br)
        {
            // read each field
            Flags = new UnitFlags().Read(br);
            Numerator = br.ReadDouble();
            Denominator = br.ReadDouble();
            Label = new byte[2 * 32];
            for (int i = 0; i < 2 * 32; i++)
            {
                Label[i] = br.ReadByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Numerator={Numerator}");
            sw.WriteLine($"{ident}Denominator={Denominator}");
            sw.WriteLine($"{ident}Label={Encoding.Unicode.GetString(Label, 0, Label.Length)}");
            //for (int i = 0; i < 32; i++)
            //{
            //    sw.WriteLine($"{ident}Label={Label[i]}");
            //}
        }
    }

    public struct DwgHatchDef
    {
        public short NDefLines;
        public double PixelSize;
        public short IslandStyle;

        public DwgHatchDef Read(BinaryReader br)
        {
            // read each field
            NDefLines = br.ReadInt16();
            PixelSize = br.ReadDouble();
            IslandStyle = br.ReadInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}NDefLines={NDefLines}");
            sw.WriteLine($"{ident}PixelSize={PixelSize}");
            sw.WriteLine($"{ident}IslandStyle={IslandStyle}");
        }
    }

    public struct LineStyleParamsResource
    {
        public UInt32 Modifiers;
        public UInt32 Reserved;
        public double Scale;
        public double DashScale;
        public double GapScale;
        public double StartWidth;
        public double EndWidth;
        public double DistPhase;
        public double FractPhase;
        public UInt32 LineMask;
        public UInt32 MlineFlags;
        public Dpoint3d Normal;
        public RotMatrix RMatrix;

        public LineStyleParamsResource Read(BinaryReader br)
        {
            // read each field
            Modifiers = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Scale = br.ReadDouble();
            DashScale = br.ReadDouble();
            GapScale = br.ReadDouble();
            StartWidth = br.ReadDouble();
            EndWidth = br.ReadDouble();
            DistPhase = br.ReadDouble();
            FractPhase = br.ReadDouble();
            LineMask = br.ReadUInt32();
            MlineFlags = br.ReadUInt32();
            Normal = new Dpoint3d().Read(br);
            RMatrix = new RotMatrix().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Modifiers={Modifiers}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Scale={Scale}");
            sw.WriteLine($"{ident}DashScale={DashScale}");
            sw.WriteLine($"{ident}GapScale={GapScale}");
            sw.WriteLine($"{ident}StartWidth={StartWidth}");
            sw.WriteLine($"{ident}EndWidth={EndWidth}");
            sw.WriteLine($"{ident}DistPhase={DistPhase}");
            sw.WriteLine($"{ident}FractPhase={FractPhase}");
            sw.WriteLine($"{ident}LineMask={LineMask}");
            sw.WriteLine($"{ident}MlineFlags={MlineFlags}");
            sw.WriteLine($"{ident}Normal >");
            Normal.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RMatrix >");
            RMatrix.Dump(sw, level + 1);
        }
    }

    public struct Elm_hdr
    {
        public UInt16 Type;
        private UInt16 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Archive
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Obsolete__
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Obsolete_2
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 NonModel
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Locked
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 IsGraphics
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 IsComplexHeader
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Complex
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt16 Deleted
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_9) >> loc_1_9);
            set => Data1 = (UInt16)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 ElementSize;
        public UInt32 AttrOffset;
        public LevelId Level;
        public T_AUInt64 UniqueId;
        public T_Adouble LastModified;
        public long HeaderPosition;

        public Elm_hdr Read(BinaryReader br)
        {
            HeaderPosition = br.BaseStream.Position;
            // read each field
            Type = br.ReadUInt16();
            Data1 = br.ReadUInt16();
            ElementSize = br.ReadUInt32();
            AttrOffset = br.ReadUInt32();
            Level = br.ReadUInt32();
            UniqueId = br.ReadUInt64();
            LastModified = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type} ({Type:X2}) - {Utils.V8GetElmType(this)}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Archive={Archive}");
            //sw.WriteLine($"{ident}Obsolete__={Obsolete__}");
            //sw.WriteLine($"{ident}Obsolete_2={Obsolete_2}");
            sw.WriteLine($"{ident}NonModel={NonModel}");
            sw.WriteLine($"{ident}Locked={Locked}");
            sw.WriteLine($"{ident}IsGraphics={IsGraphics}");
            sw.WriteLine($"{ident}IsComplexHeader={IsComplexHeader}");
            sw.WriteLine($"{ident}Complex={Complex}");
            sw.WriteLine($"{ident}Deleted={Deleted}");
            sw.WriteLine($"{ident}ElementSize={ElementSize} ({ElementSize:X8})");
            sw.WriteLine($"{ident}AttrOffset={AttrOffset} ({AttrOffset:X8})");
            sw.WriteLine($"{ident}Level={Level}");
            sw.WriteLine($"{ident}UniqueId={UniqueId} ({UniqueId:X16})");
            sw.WriteLine($"{ident}LastModified={Utils.V8BentleyTime(LastModified)}");
        }
    }

    public struct DispHdrProperties
    {
        private UInt16 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        public UInt16 ElementClass
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Unused2
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Unused3
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Invisible
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 DynamicRange
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 N
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 M
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Is3d
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt16 R
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_9) >> loc_1_9);
            set => Data1 = (UInt16)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt16 P
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_10) >> loc_1_10);
            set => Data1 = (UInt16)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt16 S
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_11) >> loc_1_11);
            set => Data1 = (UInt16)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt16 H
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_12) >> loc_1_12);
            set => Data1 = (UInt16)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }

        public DispHdrProperties Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ElementClass={ElementClass}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            //sw.WriteLine($"{ident}Unused2={Unused2}");
            //sw.WriteLine($"{ident}Unused3={Unused3}");
            sw.WriteLine($"{ident}Invisible={Invisible}");
            sw.WriteLine($"{ident}DynamicRange={DynamicRange}");
            sw.WriteLine($"{ident}N={N}");
            sw.WriteLine($"{ident}M={M}");
            sw.WriteLine($"{ident}Is3d={Is3d}");
            sw.WriteLine($"{ident}R={R}");
            sw.WriteLine($"{ident}P={P}");
            sw.WriteLine($"{ident}S={S}");
            sw.WriteLine($"{ident}H={H}");
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Disp_hdr_union_Props
    {
        [FieldOffset(0)]
        public Int16 S;
        [FieldOffset(0)]
        public DispHdrProperties B;

        public Disp_hdr_union_Props Read(BinaryReader br)
        {
            // read each field
            S = br.ReadInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}S={S}");
            sw.WriteLine($"{ident}B >");
            B.Dump(sw, level + 1);
        }
    }

    public struct Disp_hdr
    {
        public UInt32 Grphgrp;
        public Int32 Priority;
        public Disp_hdr_union_Props Props;
        public UInt16 Reserved;
        public Symbology Symb;
        public ScanRange Range;

        public Disp_hdr Read(BinaryReader br)
        {
            // read each field
            Grphgrp = br.ReadUInt32();
            Priority = br.ReadInt32();
            Props = new Disp_hdr_union_Props().Read(br);
            Reserved = br.ReadUInt16();
            Symb = new Symbology().Read(br);
            Range = new ScanRange().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Grphgrp={Grphgrp}");
            sw.WriteLine($"{ident}Priority={Priority}");
            sw.WriteLine($"{ident}Props >");
            Props.Dump(sw, level + 1);
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Symb >");
            Symb.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Range >");
            Range.Dump(sw, level + 1);
        }
    }

    public struct Header
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;

        public Header Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Dhdr >");
            Dhdr.Dump(sw, level + 1);
        }
    }

    public struct Cell_2d_Flags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 12, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt16 IsAnnotation
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 MatchSourceAnnotationSize
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 MatchSourceDimValue
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 MatchSourceMultilineOffset
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public Cell_2d_Flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IsAnnotation={IsAnnotation}");
            sw.WriteLine($"{ident}MatchSourceAnnotationSize={MatchSourceAnnotationSize}");
            sw.WriteLine($"{ident}MatchSourceDimValue={MatchSourceDimValue}");
            sw.WriteLine($"{ident}MatchSourceMultilineOffset={MatchSourceMultilineOffset}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct Cell_2d   // 2
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt16 ClassMap;
        public Cell_2d_Flags Flags;
        public DPoint2d Rnglow;
        public DPoint2d Rnghigh;
        public T_Adouble[,] Transform;
        public DPoint2d Origin;
        public Linkage[] Linkages;

        public Cell_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            ClassMap = br.ReadUInt16();
            Flags = new Cell_2d_Flags().Read(br);
            Rnglow = new DPoint2d().Read(br);
            Rnghigh = new DPoint2d().Read(br);
            Transform = new T_Adouble[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Transform[i, j] = br.ReadDouble();
                }
            }
            Origin = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}ClassMap={ClassMap}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rnglow >");
            Rnglow.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rnghigh >");
            Rnghigh.Dump(sw, level + 1);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sw.WriteLine($"{ident}Transform[{i}, {j}]={Transform[i, j]}");
                }
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Cell_3d_Flags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 12, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt16 IsAnnotation
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 MatchSourceAnnotationSize
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 MatchSourceDimValue
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 MatchSourceMultilineOffset
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public Cell_3d_Flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IsAnnotation={IsAnnotation}");
            sw.WriteLine($"{ident}MatchSourceAnnotationSize={MatchSourceAnnotationSize}");
            sw.WriteLine($"{ident}MatchSourceDimValue={MatchSourceDimValue}");
            sw.WriteLine($"{ident}MatchSourceMultilineOffset={MatchSourceMultilineOffset}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct Cell_3d   // 2
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt16 ClassMap;
        public Cell_3d_Flags Flags;
        public Dpoint3d Rnglow;
        public Dpoint3d Rnghigh;
        public T_Adouble[,] Transform;
        public Dpoint3d Origin;
        public Linkage[] Linkages;

        public Cell_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            ClassMap = br.ReadUInt16();
            Flags = new Cell_3d_Flags().Read(br);
            Rnglow = new Dpoint3d().Read(br);
            Rnghigh = new Dpoint3d().Read(br);
            Transform = new T_Adouble[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Transform[i, j] = br.ReadDouble();
                }
            }
            Origin = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}ClassMap={ClassMap}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rnglow >");
            Rnglow.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rnghigh >");
            Rnghigh.Dump(sw, level + 1);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine($"{ident}Transform[{i}, {j}]={Transform[i, j]}");
                }
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Line_2d   // 3
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public DPoint2d Start;
        public DPoint2d End;
        public Linkage[] Linkages;

        public Line_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Start = new DPoint2d().Read(br);
            End = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Start >");
            Start.Dump(sw, level + 1);
            sw.WriteLine($"{ident}End >");
            End.Dump(sw, level + 1);
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

    public struct Line_3d   // 3
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public Dpoint3d Start;
        public Dpoint3d End;
        public Linkage[] Linkages;

        public Line_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Start = new Dpoint3d().Read(br);
            End = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Start >");
            Start.Dump(sw, level + 1);
            sw.WriteLine($"{ident}End >");
            End.Dump(sw, level + 1);
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

    public struct Line_String_2d    // 4
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public DPoint2d[] Vertice;
        public Linkage[] Linkages;

        public Line_String_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new DPoint2d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Line_String_3d    // 4
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public Dpoint3d[] Vertice;
        public Linkage[] Linkages;

        public Line_String_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new Dpoint3d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Shape_2d    // 6
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public DPoint2d[] Vertice;
        public Linkage[] Linkages;

        public Shape_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new DPoint2d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Shape_3d    // 6
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public Dpoint3d[] Vertice;
        public Linkage[] Linkages;

        public Shape_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new Dpoint3d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Text_node_2d  // 7
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Nodenumber;
        public UInt32 Font;
        public UInt16 Maxlngth;
        public UInt16 Just;
        public T_Adouble Linespc;
        public T_Adouble Lngthmult;
        public T_Adouble Hghtmult;
        public T_Adouble RotationAngle;
        public DPoint2d Origin;
        public Linkage[] Linkages;

        public Text_node_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Nodenumber = br.ReadUInt32();
            Font = br.ReadUInt32();
            Maxlngth = br.ReadUInt16();
            Just = br.ReadUInt16();
            Linespc = br.ReadDouble();
            Lngthmult = br.ReadDouble();
            Hghtmult = br.ReadDouble();
            RotationAngle = br.ReadDouble();
            Origin = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Nodenumber={Nodenumber}");
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Maxlngth={Maxlngth}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}Linespc={Linespc}");
            sw.WriteLine($"{ident}Lngthmult={Lngthmult}");
            sw.WriteLine($"{ident}Hghtmult={Hghtmult}");
            sw.WriteLine($"{ident}RotationAngle={RotationAngle}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Text_node_3d  // 7
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Nodenumber;
        public UInt32 Font;
        public UInt16 Maxlngth;
        public UInt16 Just;
        public T_Adouble Linespc;
        public T_Adouble Lngthmult;
        public T_Adouble Hghtmult;
        public T_Adouble[] Quat;
        public Dpoint3d Origin;
        public Linkage[] Linkages;

        public Text_node_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Nodenumber = br.ReadUInt32();
            Font = br.ReadUInt32();
            Maxlngth = br.ReadUInt16();
            Just = br.ReadUInt16();
            Linespc = br.ReadDouble();
            Lngthmult = br.ReadDouble();
            Hghtmult = br.ReadDouble();
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Origin = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Nodenumber={Nodenumber}");
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Maxlngth={Maxlngth}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}Linespc={Linespc}");
            sw.WriteLine($"{ident}Lngthmult={Lngthmult}");
            sw.WriteLine($"{ident}Hghtmult={Hghtmult}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Curve_2d    // 11
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public DPoint2d[] Vertice;
        public Linkage[] Linkages;

        public Curve_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new DPoint2d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Curve_3d    // 11
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public Dpoint3d[] Vertice;
        public Linkage[] Linkages;

        public Curve_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new Dpoint3d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Complex_string    // 12
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Reserved;
        public Linkage[] Linkages;

        public Complex_string Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Reserved = br.ReadUInt32();
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
            //sw.WriteLine($"{ident}Reserved={Reserved}");
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

    public struct Conic_2d    // 13
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public DPoint2d[] Vertice;
        public Linkage[] Linkages;

        public Conic_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new DPoint2d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Conic_3d    // 13
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numverts;
        public UInt32 Reserved;
        public Dpoint3d[] Vertice;
        public Linkage[] Linkages;

        public Conic_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numverts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Vertice = new Dpoint3d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertice[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numverts={Numverts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertice[{i}] >");
                Vertice[i].Dump(sw, level + 1);
            }
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

    public struct Complex_shape    // 14
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Reserved;
        public Linkage[] Linkages;

        public Complex_shape Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Reserved = br.ReadUInt32();
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
            //sw.WriteLine($"{ident}Reserved={Reserved}");
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

    public struct Ellipse_2d    // 15
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public T_Adouble Primary;
        public T_Adouble Secondary;
        public T_Adouble RotationAngle;
        public DPoint2d Origin;
        public Linkage[] Linkages;

        public Ellipse_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Primary = br.ReadDouble();
            Secondary = br.ReadDouble();
            RotationAngle = br.ReadDouble();
            Origin = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Primary={Primary}");
            sw.WriteLine($"{ident}Secondary={Secondary}");
            sw.WriteLine($"{ident}RotationAngle={RotationAngle}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Ellipse_3d    // 15
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public T_Adouble Primary;
        public T_Adouble Secondary;
        public T_Adouble[] Quat;
        public Dpoint3d Origin;
        public Linkage[] Linkages;

        public Ellipse_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Primary = br.ReadDouble();
            Secondary = br.ReadDouble();
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Origin = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Primary={Primary}");
            sw.WriteLine($"{ident}Secondary={Secondary}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Arc_2d    // 16
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public T_Adouble StartAngle;
        public T_Adouble SweepAngle;
        public T_Adouble Primary;
        public T_Adouble Secondary;
        public T_Adouble RotationAngle;
        public DPoint2d Origin;
        public Linkage[] Linkages;

        public Arc_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            StartAngle = br.ReadDouble();
            SweepAngle = br.ReadDouble();
            Primary = br.ReadDouble();
            Secondary = br.ReadDouble();
            RotationAngle = br.ReadDouble();
            Origin = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}StartAngle={StartAngle}");
            sw.WriteLine($"{ident}SweepAngle={SweepAngle}");
            sw.WriteLine($"{ident}Primary={Primary}");
            sw.WriteLine($"{ident}Secondary={Secondary}");
            sw.WriteLine($"{ident}RotationAngle={RotationAngle}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Arc_3d    // 16
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public T_Adouble StartAngle;
        public T_Adouble SweepAngle;
        public T_Adouble Primary;
        public T_Adouble Secondary;
        public T_Adouble[] Quat;
        public Dpoint3d Origin;
        public Linkage[] Linkages;

        public Arc_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            StartAngle = br.ReadDouble();
            SweepAngle = br.ReadDouble();
            Primary = br.ReadDouble();
            Secondary = br.ReadDouble();
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Origin = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}StartAngle={StartAngle}");
            sw.WriteLine($"{ident}SweepAngle={SweepAngle}");
            sw.WriteLine($"{ident}Primary={Primary}");
            sw.WriteLine($"{ident}Secondary={Secondary}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
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

    public struct Text_2d   // 17
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Font;
        public UInt16 Just;
        public UInt16 Numchars;
        public T_Adouble Lngthmult;
        public T_Adouble Hghtmult;
        public T_Adouble Length;
        public T_Adouble Height;
        public T_Adouble RotationAngle;
        public DPoint2d Origin;
        public UInt16 Edflds;
        public VariChar[] String;
        public Linkage[] Linkages;

        public Text_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Font = br.ReadUInt32();
            Just = br.ReadUInt16();
            Numchars = br.ReadUInt16();
            Lngthmult = br.ReadDouble();
            Hghtmult = br.ReadDouble();
            Length = br.ReadDouble();
            Height = br.ReadDouble();
            RotationAngle = br.ReadDouble();
            Origin = new DPoint2d().Read(br);
            Edflds = br.ReadUInt16();
            String = new VariChar[6];
            for (int i = 0; i < 6; i++)
            {
                String[i] = br.ReadByte();
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
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}Numchars={Numchars}");
            sw.WriteLine($"{ident}Lngthmult={Lngthmult}");
            sw.WriteLine($"{ident}Hghtmult={Hghtmult}");
            sw.WriteLine($"{ident}Length={Length}");
            sw.WriteLine($"{ident}Height={Height}");
            sw.WriteLine($"{ident}RotationAngle={RotationAngle}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Edflds={Edflds}");
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine($"{ident}String={String[i]}");
            }
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

    public struct Text_3d   // 17
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Font;
        public UInt16 Just;
        public UInt16 Numchars;
        public T_Adouble Lngthmult;
        public T_Adouble Hghtmult;
        public T_Adouble Length;
        public T_Adouble Height;
        public T_Adouble[] Quat;
        public Dpoint3d Origin;
        public UInt16 Edflds;
        public VariChar[] String;
        public Linkage[] Linkages;

        public Text_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Font = br.ReadUInt32();
            Just = br.ReadUInt16();
            Numchars = br.ReadUInt16();
            Lngthmult = br.ReadDouble();
            Hghtmult = br.ReadDouble();
            Length = br.ReadDouble();
            Height = br.ReadDouble();
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Origin = new Dpoint3d().Read(br);
            Edflds = br.ReadUInt16();
            String = new VariChar[6];
            for (int i = 0; i < 6; i++)
            {
                String[i] = br.ReadByte();
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
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}Numchars={Numchars}");
            sw.WriteLine($"{ident}Lngthmult={Lngthmult}");
            sw.WriteLine($"{ident}Hghtmult={Hghtmult}");
            sw.WriteLine($"{ident}Length={Length}");
            sw.WriteLine($"{ident}Height={Height}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Edflds={Edflds}");
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine($"{ident}String={String[i]}");
            }
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

    public struct Point_string_2d   // 22
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numpts;
        public UInt32 Reserved;
        public DPoint2d[] Point;
        public Linkage[] Linkages;

        public Point_string_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numpts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Point = new DPoint2d[Numpts];
            for (int i = 0; i < Numpts; i++)
            {
                Point[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numpts={Numpts}");
            //  sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numpts; i++)
            {
                sw.WriteLine($"{ident}Point >");
                Point[i].Dump(sw, level + 1);
            }
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

    public struct Point_string_3d   // 22
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numpts;
        public UInt32 Reserved;
        public Dpoint3d[] Point;
        public Linkage[] Linkages;

        public Point_string_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numpts = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Point = new Dpoint3d[Numpts];
            for (int i = 0; i < Numpts; i++)
            {
                Point[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numpts={Numpts}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numpts; i++)
            {
                sw.WriteLine($"{ident}Point >");
                Point[i].Dump(sw, level + 1);
            }
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

    public struct Cone_3d_B
    {
        private UInt16 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 12, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt16 Type
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Rsrv
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Surf
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public Cone_3d_B Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Rsrv={Rsrv}");
            sw.WriteLine($"{ident}Surf={Surf}");
        }
    }

    public struct Cone_3d   // 23
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public Cone_3d_B B;
        public UInt16[] Reserved;
        public T_Adouble[] Quat;
        public Dpoint3d Center_1;
        public T_Adouble Radius_1;
        public Dpoint3d Center_2;
        public T_Adouble Radius_2;
        public Linkage[] Linkages;

        public Cone_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            B = new Cone_3d_B().Read(br);
            Reserved = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                Reserved[i] = br.ReadUInt16();
            }
            Quat = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                Quat[i] = br.ReadDouble();
            }
            Center_1 = new Dpoint3d().Read(br);
            Radius_1 = br.ReadDouble();
            Center_2 = new Dpoint3d().Read(br);
            Radius_2 = br.ReadDouble();
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
            sw.WriteLine($"{ident}B >");
            B.Dump(sw, level + 1);
            for (int i = 0; i < 3; i++)
            {
                //sw.WriteLine($"{ident}Reserved={Reserved[i]}");
            }
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Quat[{i}]={Quat[i]}");
            }
            sw.WriteLine($"{ident}Center_1 >");
            Center_1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Radius_1={Radius_1}");
            sw.WriteLine($"{ident}Center_2 >");
            Center_2.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Radius_2={Radius_2}");
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

    public struct Surface   // 18
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Boundelms;
        public UInt16 Surftype;
        public UInt16[] Reserved;
        public Linkage[] Linkages;

        public Surface Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Boundelms = br.ReadUInt32();
            Surftype = br.ReadUInt16();
            Reserved = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                Reserved[i] = br.ReadUInt16();
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
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Boundelms={Boundelms}");
            sw.WriteLine($"{ident}Surftype={Surftype}");
            for (int i = 0; i < 3; i++)
            {
                //sw.WriteLine($"{ident}Reserved={Reserved[i]}");
            }
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

    public struct Solid   // 19
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public UInt32 Boundelms;
        public UInt16 Solidtype;
        public UInt16[] Reserved;
        public Linkage[] Linkages;

        public Solid Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Boundelms = br.ReadUInt32();
            Solidtype = br.ReadUInt16();
            Reserved = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                Reserved[i] = br.ReadUInt16();
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
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Boundelms={Boundelms}");
            sw.WriteLine($"{ident}Surftype={Solidtype}");
            for (int i = 0; i < 3; i++)
            {
                //sw.WriteLine($"{ident}Reserved={Reserved[i]}");
            }
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

    public struct Bspline_pole_2d   // 21
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numpoles;
        public UInt32 Reserved;
        public DPoint2d[] Poles;
        public Linkage[] Linkages;

        public Bspline_pole_2d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numpoles = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Poles = new DPoint2d[Numpoles];
            for (int i = 0; i < Numpoles; i++)
            {
                Poles[i] = new DPoint2d().Read(br);
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
            sw.WriteLine($"{ident}Numpoles={Numpoles}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numpoles; i++)
            {
                sw.WriteLine($"{ident}Poles[{i}] >");
                Poles[i].Dump(sw, level + 1);
            }
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

    public struct Bspline_pole_3d   // 21
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 Numpoles;
        public UInt32 Reserved;
        public Dpoint3d[] Poles;
        public Linkage[] Linkages;

        public Bspline_pole_3d Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Numpoles = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Poles = new Dpoint3d[Numpoles];
            for (int i = 0; i < Numpoles; i++)
            {
                Poles[i] = new Dpoint3d().Read(br);
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
            sw.WriteLine($"{ident}Numpoles={Numpoles}");
            //sw.WriteLine($"{ident}Reserved={Reserved}");
            for (int i = 0; i < Numpoles; i++)
            {
                sw.WriteLine($"{ident}Poles[{i}] >");
                Poles[i].Dump(sw, level + 1);
            }
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

    public struct Bspline_flags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 5, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 8, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 4, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 4, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Curve_display
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Poly_display
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Rational
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Closed
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Curve_type
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Construct_type
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 IsNaturalTangents
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 IsChordLenTangents
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 IsColinearTangents
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 IsChordLenKnots
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 IsZeroStartTangent
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 IsZeroEndTangent
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 StoreFullKnots
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }

        public Bspline_flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Curve_display={Curve_display}");
            sw.WriteLine($"{ident}Poly_display={Poly_display}");
            sw.WriteLine($"{ident}Rational={Rational}");
            sw.WriteLine($"{ident}Closed={Closed}");
            sw.WriteLine($"{ident}Curve_type={Curve_type}");
            sw.WriteLine($"{ident}Construct_type={Construct_type}");
            sw.WriteLine($"{ident}IsNaturalTangents={IsNaturalTangents}");
            sw.WriteLine($"{ident}IsChordLenTangents={IsChordLenTangents}");
            sw.WriteLine($"{ident}IsColinearTangents={IsColinearTangents}");
            sw.WriteLine($"{ident}IsChordLenKnots={IsChordLenKnots}");
            sw.WriteLine($"{ident}IsZeroStartTangent={IsZeroStartTangent}");
            sw.WriteLine($"{ident}IsZeroEndTangent={IsZeroEndTangent}");
            sw.WriteLine($"{ident}StoreFullKnots={StoreFullKnots}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct Bspline_curve // 27
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public Bspline_flags Flags;
        public UInt32 Num_poles;
        public UInt32 Num_knots;
        public Linkage[] Linkages;

        public Bspline_curve Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Flags = new Bspline_flags().Read(br);
            Num_poles = br.ReadUInt32();
            Num_knots = br.ReadUInt32();
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
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Num_poles={Num_poles}");
            sw.WriteLine($"{ident}Num_knots={Num_knots}");
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

    public struct Bsurf_flags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 5, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 24, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 V_order
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ArcSpacing
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 V_closed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 StoreFullKnots
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public Bsurf_flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}V_order={V_order}");
            sw.WriteLine($"{ident}ArcSpacing={ArcSpacing}");
            sw.WriteLine($"{ident}V_closed={V_closed}");
            sw.WriteLine($"{ident}StoreFullKnots={StoreFullKnots}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct Bspline_surface   // 24
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public Bspline_flags Flags;
        public UInt32 Num_poles_u;
        public UInt32 Num_knots_u;
        public UInt32 Rule_lines_u;
        public Bsurf_flags Bsurf_flags;
        public UInt32 Num_poles_v;
        public UInt32 Num_knots_v;
        public UInt32 Rule_lines_v;
        public UInt32 Num_bounds;
        public Linkage[] Linkages;

        public Bspline_surface Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Flags = new Bspline_flags().Read(br);
            Num_poles_u = br.ReadUInt32();
            Num_knots_u = br.ReadUInt32();
            Rule_lines_u = br.ReadUInt32();
            Bsurf_flags = new Bsurf_flags().Read(br);
            Num_poles_v = br.ReadUInt32();
            Num_knots_v = br.ReadUInt32();
            Rule_lines_v = br.ReadUInt32();
            Num_bounds = br.ReadUInt32();
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
            sw.WriteLine($"{ident}Flags={Flags}");
            sw.WriteLine($"{ident}Num_poles_u={Num_poles_u}");
            sw.WriteLine($"{ident}Num_knots_u={Num_knots_u}");
            sw.WriteLine($"{ident}Rule_lines_u={Rule_lines_u}");
            sw.WriteLine($"{ident}Bsurf_flags={Bsurf_flags}");
            sw.WriteLine($"{ident}Num_poles_v={Num_poles_v}");
            sw.WriteLine($"{ident}Num_knots_v={Num_knots_v}");
            sw.WriteLine($"{ident}Rule_lines_v={Rule_lines_v}");
            sw.WriteLine($"{ident}Num_bounds={Num_bounds}");
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

    public struct Bspline_weight    // 26
    {
        public Elm_hdr Ehdr;
        public T_Adouble[] Weights;
        private int NumWeights;
        public Linkage[] Linkages;

        public Bspline_weight Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            NumWeights = (int)((2 * Ehdr.AttrOffset) - 0x20) / sizeof(double);
            Weights = new T_Adouble[NumWeights];
            for (int i = 0; i < NumWeights; i++)
            {
                Weights[i] = br.ReadDouble();
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}NumWeights={NumWeights}");
            for (int i = 0; i < NumWeights; i++)
            {
                sw.WriteLine($"{ident}Weights[{i}]={Weights[i]}");
            }
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

    public struct Bspline_knot  // 28
    {
        public Elm_hdr Ehdr;
        public T_Adouble[] Knots;
        private int NumKnots;
        public Linkage[] Linkages;

        public Bspline_knot Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            NumKnots = (int)((2 * Ehdr.AttrOffset) - 0x20) / sizeof(double);
            Knots = new T_Adouble[NumKnots];
            for (int i = 0; i < NumKnots; i++)
            {
                Knots[i] = br.ReadDouble();
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}NumKnots={NumKnots}");
            for (int i = 0; i < NumKnots; i++)
            {
                sw.WriteLine($"{ident}Knots[{i}]={Knots[i]}");
            }
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

    public struct Bsurf_boundary    // 25
    {
        public Elm_hdr Ehdr;
        public UInt32 Number;
        public UInt32 Numverts;
        public DPoint2d[] Vertices;
        public Linkage[] Linkages;

        public Bsurf_boundary Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Number = br.ReadUInt32();
            Numverts = br.ReadUInt32();
            Vertices = new DPoint2d[Numverts];
            for (int i = 0; i < Numverts; i++)
            {
                Vertices[i] = new DPoint2d().Read(br);
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Number={Number}");
            sw.WriteLine($"{ident}Numverts={Numverts}");
            for (int i = 0; i < Numverts; i++)
            {
                sw.WriteLine($"{ident}Vertices[{i}] >");
                Vertices[i].Dump(sw, level + 1);
            }
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

    public struct Raster_flags_B
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 5, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 5, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 Right
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Lower
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Horizontal
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Format
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Transparent
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Positive
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }

        public Raster_flags_B Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Right={Right}");
            sw.WriteLine($"{ident}Lower={Lower}");
            sw.WriteLine($"{ident}Horizontal={Horizontal}");
            sw.WriteLine($"{ident}Format={Format}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Transparent={Transparent}");
            sw.WriteLine($"{ident}Positive={Positive}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct Raster_flags
    {
        public Raster_flags_B B;
        public Int16 S;

        public Raster_flags Read(BinaryReader br)
        {
            // read each field
            B = new Raster_flags_B().Read(br);
            S = br.ReadInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}B >");
            B.Dump(sw, level + 1);
            sw.WriteLine($"{ident}S={S}");
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Raster_hdr_union_U
    {
        [FieldOffset(0)]
        public DPoint2d[] Vert2d;
        [FieldOffset(0)]
        public Dpoint3d[] Vert3d;

        public Raster_hdr_union_U Read(BinaryReader br)
        {
            // read each field
            Vert2d = new DPoint2d[1];
            for (int i = 0; i < 1; i++)
            {
                Vert2d[i] = new DPoint2d().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Vert2d >");
                Vert2d[i].Dump(sw, level + 1);
            }
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Vert3d >");
                Vert3d[i].Dump(sw, level + 1);
            }
        }
    }

    public struct Raster_hdr    // 87 // TODO
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public UInt32 ComponentCount;
        public Raster_flags Flags;
        public byte Background;
        public byte Foreground;
        public UInt16 Xextent;
        public UInt16 Yextent;
        public Int16 Reserved;
        public T_Adouble Resolution;
        public T_Adouble Scale;
        public Dpoint3d Origin;
        public UInt32 Numverts;
        public UInt32 Reserved2;
        public Raster_hdr_union_U U;
        public Linkage[] Linkages;

        public Raster_hdr Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Flags = new Raster_flags().Read(br);
            Background = br.ReadByte();
            Foreground = br.ReadByte();
            Xextent = br.ReadUInt16();
            Yextent = br.ReadUInt16();
            Reserved = br.ReadInt16();
            Resolution = br.ReadDouble();
            Scale = br.ReadDouble();
            Origin = new Dpoint3d().Read(br);
            Numverts = br.ReadUInt32();
            Reserved2 = br.ReadUInt32();
            U = new Raster_hdr_union_U().Read(br);
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
            sw.WriteLine($"{ident}Flags={Flags}");
            sw.WriteLine($"{ident}Background={Background}");
            sw.WriteLine($"{ident}Foreground={Foreground}");
            sw.WriteLine($"{ident}Xextent={Xextent}");
            sw.WriteLine($"{ident}Yextent={Yextent}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Resolution={Resolution}");
            sw.WriteLine($"{ident}Scale={Scale}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Numverts={Numverts}");
            sw.WriteLine($"{ident}Reserved2={Reserved2}");
            sw.WriteLine($"{ident}U >");
            U.Dump(sw, level + 1);
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

    public struct Raster_comp   // 88
    {
        public Elm_hdr Ehdr;
        public Disp_hdr Dhdr;
        public Raster_flags Flags;
        public byte Background;
        public byte Foreground;
        public UInt16 Xoffset;
        public UInt16 Yoffset;
        public UInt16 Numpixels;
        public byte[] Pixel;
        public Linkage[] Linkages;

        public Raster_comp Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Dhdr = new Disp_hdr().Read(br);
            Flags = new Raster_flags().Read(br);
            Background = br.ReadByte();
            Foreground = br.ReadByte();
            Xoffset = br.ReadUInt16();
            Yoffset = br.ReadUInt16();
            Numpixels = br.ReadUInt16();
            Pixel = new byte[4 * Numpixels];
            for (int i = 0; i < 4 * Numpixels; i++)
            {
                Pixel[i] = br.ReadByte();
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
            sw.WriteLine($"{ident}Flags={Flags}");
            sw.WriteLine($"{ident}Background={Background}");
            sw.WriteLine($"{ident}Foreground={Foreground}");
            sw.WriteLine($"{ident}Xoffset={Xoffset}");
            sw.WriteLine($"{ident}Yoffset={Yoffset}");
            sw.WriteLine($"{ident}Numpixels={Numpixels}");
            for (int i = 0; i < 4 * Numpixels; i++)
            {
                sw.WriteLine($"{ident}Pixel[{i}]={Pixel[i]}");
            }
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

    public struct ApplicationElm    // 66 // TODO
    {
        public Elm_hdr Ehdr;
        public Int16 SignatureWord;
        public Int16[] AppData;
        public Linkage[] Linkages;

        public ApplicationElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            SignatureWord = br.ReadInt16();
            AppData = new Int16[1];
            for (int i = 0; i < 1; i++)
            {
                AppData[i] = br.ReadInt16();
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SignatureWord={SignatureWord}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}AppData={AppData[i]}");
            }
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

    public struct ColorTable // 5 ?? // TODO
    {
        public Elm_hdr Ehdr;
        public Int16 Screen_flag;
        public byte[] Color_info;
        public Linkage[] Linkages;

        public ColorTable Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Screen_flag = br.ReadInt16();
            Color_info = new byte[1];
            for (int i = 0; i < 1; i++)
            {
                Color_info[i] = br.ReadByte();
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Screen_flag={Screen_flag}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Color_info={Color_info[i]}");
            }
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

    public struct Fb_opts
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 3, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 6, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 1, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        private const int sz_1_22 = 1, loc_1_22 = loc_1_21 + sz_1_21, mask_1_22 = unchecked(((1 << sz_1_22) - 1) << loc_1_22);
        private const int sz_1_23 = 1, loc_1_23 = loc_1_22 + sz_1_22, mask_1_23 = unchecked(((1 << sz_1_23) - 1) << loc_1_23);
        private const int sz_1_24 = 1, loc_1_24 = loc_1_23 + sz_1_23, mask_1_24 = unchecked(((1 << sz_1_24) - 1) << loc_1_24);
        public UInt32 One_one_map
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Db_diff_mf
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Snap_lock
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Locate_lock
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 HLineAttachment
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CompletePathStoredInV7
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Anonymous
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Inactive
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SynchPresentationWithNamedView
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Missing_file
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 LevelOverride
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 DontDetachOnAll
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 MetadataOnly
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 AttachmentFromDWG
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 TreatAsElement
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 Deprecated
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 AttachMethod
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 UseViewFlagsInAttachment
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 SynchWithNamedView
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 LevelControlsDisplay
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 UseAnnotationScale
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 IsAnnotationAttachment
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }
        public UInt32 UserSpecifiedZForGeoReprojected
        {
            get => (UInt32)(Data1 & mask_1_22) >> loc_1_22;
            set => Data1 = (UInt32)(Data1 & ~mask_1_22 | (value << loc_1_22) & mask_1_22);
        }
        public UInt32 ApplicationLocked
        {
            get => (UInt32)(Data1 & mask_1_23) >> loc_1_23;
            set => Data1 = (UInt32)(Data1 & ~mask_1_23 | (value << loc_1_23) & mask_1_23);
        }
        public UInt32 SynchVolumeWithNamedView
        {
            get => (UInt32)(Data1 & mask_1_24) >> loc_1_24;
            set => Data1 = (UInt32)(Data1 & ~mask_1_24 | (value << loc_1_24) & mask_1_24);
        }

        public Fb_opts Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}One_one_map={One_one_map}");
            sw.WriteLine($"{ident}Db_diff_mf={Db_diff_mf}");
            sw.WriteLine($"{ident}Snap_lock={Snap_lock}");
            sw.WriteLine($"{ident}Locate_lock={Locate_lock}");
            sw.WriteLine($"{ident}HLineAttachment={HLineAttachment}");
            sw.WriteLine($"{ident}CompletePathStoredInV7={CompletePathStoredInV7}");
            sw.WriteLine($"{ident}Anonymous={Anonymous}");
            sw.WriteLine($"{ident}Inactive={Inactive}");
            sw.WriteLine($"{ident}SynchPresentationWithNamedView={SynchPresentationWithNamedView}");
            sw.WriteLine($"{ident}Missing_file={Missing_file}");
            sw.WriteLine($"{ident}LevelOverride={LevelOverride}");
            sw.WriteLine($"{ident}DontDetachOnAll={DontDetachOnAll}");
            sw.WriteLine($"{ident}MetadataOnly={MetadataOnly}");
            sw.WriteLine($"{ident}AttachmentFromDWG={AttachmentFromDWG}");
            sw.WriteLine($"{ident}TreatAsElement={TreatAsElement}");
            sw.WriteLine($"{ident}Deprecated={Deprecated}");
            sw.WriteLine($"{ident}AttachMethod={AttachMethod}");
            sw.WriteLine($"{ident}UseViewFlagsInAttachment={UseViewFlagsInAttachment}");
            sw.WriteLine($"{ident}SynchWithNamedView={SynchWithNamedView}");
            sw.WriteLine($"{ident}LevelControlsDisplay={LevelControlsDisplay}");
            sw.WriteLine($"{ident}UseAnnotationScale={UseAnnotationScale}");
            sw.WriteLine($"{ident}IsAnnotationAttachment={IsAnnotationAttachment}");
            sw.WriteLine($"{ident}UserSpecifiedZForGeoReprojected={UserSpecifiedZForGeoReprojected}");
            sw.WriteLine($"{ident}ApplicationLocked={ApplicationLocked}");
            sw.WriteLine($"{ident}SynchVolumeWithNamedView={SynchVolumeWithNamedView}");
        }
    }

    public struct Fd_opts
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 2, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 1, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        private const int sz_1_22 = 1, loc_1_22 = loc_1_21 + sz_1_21, mask_1_22 = unchecked(((1 << sz_1_22) - 1) << loc_1_22);
        private const int sz_1_23 = 1, loc_1_23 = loc_1_22 + sz_1_22, mask_1_23 = unchecked(((1 << sz_1_23) - 1) << loc_1_23);
        private const int sz_1_24 = 2, loc_1_24 = loc_1_23 + sz_1_23, mask_1_24 = unchecked(((1 << sz_1_24) - 1) << loc_1_24);
        private const int sz_1_25 = 1, loc_1_25 = loc_1_24 + sz_1_24, mask_1_25 = unchecked(((1 << sz_1_25) - 1) << loc_1_25);
        private const int sz_1_26 = 2, loc_1_26 = loc_1_25 + sz_1_25, mask_1_26 = unchecked(((1 << sz_1_26) - 1) << loc_1_26);
        private const int sz_1_27 = 2, loc_1_27 = loc_1_26 + sz_1_26, mask_1_27 = unchecked(((1 << sz_1_27) - 1) << loc_1_27);
        public UInt32 View_ovr
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Display
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Line_width
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 LstyleScale
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 HiddenLine
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 DisplayHidden
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SurrogateHLine
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 RotateClipping
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SmoothEdges
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 ExtendedRef
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 ClipBack
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 ClipFront
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 CameraOn
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 ScaleByUnits
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 DisplayBoundary
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 LibraryRef
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 DisplayRasterRefs
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 UseAlternateFile
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 UseLights
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 DoNotDisplayAsNested
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 ColorTableUsage
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 Viewport
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }
        public UInt32 ScaleByStorageUnits
        {
            get => (UInt32)(Data1 & mask_1_22) >> loc_1_22;
            set => Data1 = (UInt32)(Data1 & ~mask_1_22 | (value << loc_1_22) & mask_1_22);
        }
        public UInt32 PrintColorAdjustment
        {
            get => (UInt32)(Data1 & mask_1_23) >> loc_1_23;
            set => Data1 = (UInt32)(Data1 & ~mask_1_23 | (value << loc_1_23) & mask_1_23);
        }
        public UInt32 NewLevelDisplay
        {
            get => (UInt32)(Data1 & mask_1_24) >> loc_1_24;
            set => Data1 = (UInt32)(Data1 & ~mask_1_24 | (value << loc_1_24) & mask_1_24);
        }
        public UInt32 Plot3D
        {
            get => (UInt32)(Data1 & mask_1_25) >> loc_1_25;
            set => Data1 = (UInt32)(Data1 & ~mask_1_25 | (value << loc_1_25) & mask_1_25);
        }
        public UInt32 NestOverrides
        {
            get => (UInt32)(Data1 & mask_1_26) >> loc_1_26;
            set => Data1 = (UInt32)(Data1 & ~mask_1_26 | (value << loc_1_26) & mask_1_26);
        }
        public UInt32 GlobalLineStyleScales
        {
            get => (UInt32)(Data1 & mask_1_27) >> loc_1_27;
            set => Data1 = (UInt32)(Data1 & ~mask_1_27 | (value << loc_1_27) & mask_1_27);
        }

        public Fd_opts Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}View_ovr={View_ovr}");
            sw.WriteLine($"{ident}Display={Display}");
            sw.WriteLine($"{ident}Line_width={Line_width}");
            sw.WriteLine($"{ident}LstyleScale={LstyleScale}");
            sw.WriteLine($"{ident}HiddenLine={HiddenLine}");
            sw.WriteLine($"{ident}DisplayHidden={DisplayHidden}");
            sw.WriteLine($"{ident}SurrogateHLine={SurrogateHLine}");
            sw.WriteLine($"{ident}RotateClipping={RotateClipping}");
            sw.WriteLine($"{ident}SmoothEdges={SmoothEdges}");
            sw.WriteLine($"{ident}ExtendedRef={ExtendedRef}");
            sw.WriteLine($"{ident}ClipBack={ClipBack}");
            sw.WriteLine($"{ident}ClipFront={ClipFront}");
            sw.WriteLine($"{ident}CameraOn={CameraOn}");
            sw.WriteLine($"{ident}ScaleByUnits={ScaleByUnits}");
            sw.WriteLine($"{ident}DisplayBoundary={DisplayBoundary}");
            sw.WriteLine($"{ident}LibraryRef={LibraryRef}");
            sw.WriteLine($"{ident}DisplayRasterRefs={DisplayRasterRefs}");
            sw.WriteLine($"{ident}UseAlternateFile={UseAlternateFile}");
            sw.WriteLine($"{ident}UseLights={UseLights}");
            sw.WriteLine($"{ident}DoNotDisplayAsNested={DoNotDisplayAsNested}");
            sw.WriteLine($"{ident}ColorTableUsage={ColorTableUsage}");
            sw.WriteLine($"{ident}Viewport={Viewport}");
            sw.WriteLine($"{ident}ScaleByStorageUnits={ScaleByStorageUnits}");
            sw.WriteLine($"{ident}PrintColorAdjustment={PrintColorAdjustment}");
            sw.WriteLine($"{ident}NewLevelDisplay={NewLevelDisplay}");
            sw.WriteLine($"{ident}Plot3D={Plot3D}");
            sw.WriteLine($"{ident}NestOverrides={NestOverrides}");
            sw.WriteLine($"{ident}GlobalLineStyleScales={GlobalLineStyleScales}");
        }
    }

    public struct ReferenceFileElm  // 100
    {
        public Elm_hdr Ehdr;
        public UInt32 ComponentCount;
        public UInt32 Version;
        public UInt32 GroupId;
        public UInt32 FileNumber;
        public T_AUInt64 ParentAttachmentId;
        public Fb_opts Fb_opts;
        public Fd_opts Fd_opts;
        public UInt32 Priority;
        public ViewFlags[] DisplayFlags;
        public UInt16 BaseNestDepth;
        public UInt16 Reserved;
        public Dpoint3d RefOrigin;
        public Dpoint3d MasterOrigin;
        public RotMatrix Transform;
        public T_Adouble Scale;
        public T_Adouble[] ReservedScale;
        public T_Adouble ZFront;
        public T_Adouble ZBack;
        public Dpoint3d CameraPosition;
        public T_Adouble CameraFocalLength;
        public UInt16 NestDepth;
        public UInt16 Reserved1;
        public Int16 ForeignUnitMode;
        public UInt16 NClipPoints;
        public DPoint2d[] ClipPoints;
        public Linkage[] Linkages;

        public ReferenceFileElm Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            ComponentCount = br.ReadUInt32();
            Version = br.ReadUInt32();
            GroupId = br.ReadUInt32();
            FileNumber = br.ReadUInt32();
            ParentAttachmentId = br.ReadUInt64();
            Fb_opts = new Fb_opts().Read(br);
            Fd_opts = new Fd_opts().Read(br);
            Priority = br.ReadUInt32();
            DisplayFlags = new ViewFlags[8];
            for (int i = 0; i < 8; i++)
            {
                DisplayFlags[i] = new ViewFlags().Read(br);
            }
            BaseNestDepth = br.ReadUInt16();
            Reserved = br.ReadUInt16();
            RefOrigin = new Dpoint3d().Read(br);
            MasterOrigin = new Dpoint3d().Read(br);
            Transform = new RotMatrix().Read(br);
            Scale = br.ReadDouble();
            ReservedScale = new T_Adouble[2];
            for (int i = 0; i < 2; i++)
            {
                ReservedScale[i] = br.ReadDouble();
            }
            ZFront = br.ReadDouble();
            ZBack = br.ReadDouble();
            CameraPosition = new Dpoint3d().Read(br);
            CameraFocalLength = br.ReadDouble();
            NestDepth = br.ReadUInt16();
            Reserved1 = br.ReadUInt16();
            ForeignUnitMode = br.ReadInt16();
            NClipPoints = br.ReadUInt16();
            ClipPoints = new DPoint2d[NClipPoints];
            for (int i = 0; i < NClipPoints; i++)
            {
                ClipPoints[i] = new DPoint2d().Read(br);
            }
            Linkages = V8Linkages.V8GetLinkages(br, Ehdr);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComponentCount={ComponentCount}");
            sw.WriteLine($"{ident}Version={Version}");
            sw.WriteLine($"{ident}GroupId={GroupId}");
            sw.WriteLine($"{ident}FileNumber={FileNumber}");
            sw.WriteLine($"{ident}ParentAttachmentId={ParentAttachmentId}");
            sw.WriteLine($"{ident}Fb_opts >");
            Fb_opts.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Fd_opts >");
            Fd_opts.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Priority={Priority}");
            for (int i = 0; i < 8; i++)
            {
                sw.WriteLine($"{ident}DisplayFlags >");
                DisplayFlags[i].Dump(sw, level + 1);
            }
            sw.WriteLine($"{ident}BaseNestDepth={BaseNestDepth}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}RefOrigin >");
            RefOrigin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MasterOrigin >");
            MasterOrigin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Transform >");
            Transform.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Scale={Scale}");
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}ReservedScale={ReservedScale[i]}");
            }
            sw.WriteLine($"{ident}ZFront={ZFront}");
            sw.WriteLine($"{ident}ZBack={ZBack}");
            sw.WriteLine($"{ident}CameraPosition >");
            CameraPosition.Dump(sw, level + 1);
            sw.WriteLine($"{ident}CameraFocalLength={CameraFocalLength}");
            sw.WriteLine($"{ident}NestDepth={NestDepth}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}ForeignUnitMode={ForeignUnitMode}");
            sw.WriteLine($"{ident}NClipPoints={NClipPoints}");
            for (int i = 0; i < NClipPoints; i++)
            {
                sw.WriteLine($"{ident}ClipPoints[{i}] >");
                ClipPoints[i].Dump(sw, level + 1);
            }
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

    public struct UnitInfo
    {
        public UnitFlags Flags;
        public double Numerator;
        public double Denominator;
        public string Label;

        public UnitInfo Read(BinaryReader br)
        {
            // read each field
            Flags = new UnitFlags().Read(br);
            Numerator = br.ReadDouble();
            Denominator = br.ReadDouble();
            var tempLabel = new WChar[32];
            Label = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                tempLabel[i] = br.ReadUInt16();
                Label += tempLabel[i];
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Numerator={Numerator}");
            sw.WriteLine($"{ident}Denominator={Denominator}");
            sw.WriteLine($"{ident}Label={Label}");
            //for (int i = 0; i < 32; i++)
            //{
            //sw.WriteLine($"{ident}Label={Label[i]}");
            //}
        }
    }

    public struct HsvColorDef
    {
        public Int32 Hue;
        public Int32 Saturation;
        public Int32 Value;

        public HsvColorDef Read(BinaryReader br)
        {
            // read each field
            Hue = br.ReadInt32();
            Saturation = br.ReadInt32();
            Value = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Hue={Hue}");
            sw.WriteLine($"{ident}Saturation={Saturation}");
            sw.WriteLine($"{ident}Value={Value}");
        }
    }

    public struct IntColorDef
    {
        public RgbColorDef M_rgb;
        public RgbaColorDef M_rgba;
        public UInt32 M_int;

        public IntColorDef Read(BinaryReader br)
        {
            // read each field
            M_rgb = new RgbColorDef().Read(br);
            M_rgba = new RgbaColorDef().Read(br);
            M_int = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_rgb >");
            M_rgb.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_rgba >");
            M_rgba.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_int={M_int}");
        }
    }

    public struct CameraInfo
    {
        public double M_angle;
        public double M_focalLength;
        public Dpoint3d M_position;

        public CameraInfo Read(BinaryReader br)
        {
            // read each field
            M_angle = br.ReadDouble();
            M_focalLength = br.ReadDouble();
            M_position = new Dpoint3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_angle={M_angle}");
            sw.WriteLine($"{ident}M_focalLength={M_focalLength}");
            sw.WriteLine($"{ident}M_position >");
            M_position.Dump(sw, level + 1);
        }
    }

    public struct ViewGeomInfo
    {
        public ViewFlags M_viewFlags;
        public Dpoint3d M_origin;
        public Dpoint3d M_delta;
        public RotMatrix M_rotation;
        public double M_activez;
        public CameraInfo M_camera;

        public ViewGeomInfo Read(BinaryReader br)
        {
            // read each field
            M_viewFlags = new ViewFlags().Read(br);
            M_origin = new Dpoint3d().Read(br);
            M_delta = new Dpoint3d().Read(br);
            M_rotation = new RotMatrix().Read(br);
            M_activez = br.ReadDouble();
            M_camera = new CameraInfo().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_viewFlags >");
            M_viewFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_origin >");
            M_origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_delta >");
            M_delta.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_rotation >");
            M_rotation.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_activez={M_activez}");
            sw.WriteLine($"{ident}M_camera >");
            M_camera.Dump(sw, level + 1);
        }
    }

    public struct DisplayStyleFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 3, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 11, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        public UInt32 M_displayMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_displayVisibleEdges
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_displayHiddenEdges
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_hiddenEdgeLineStyle
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 M_displayShadows
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 M_legacyDrawOrder
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 M_overrideBackgroundColor
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 M_applyEdgeStyleToLines
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 M_ignoreGeometryMaps
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 M_ignoreImageMaps
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 M_hideInPickers
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 M_invisibleToCamera
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 M_displayGroundPlane
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 M_overrideReflectionColor
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 M_unused
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }

        public DisplayStyleFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_displayMode={M_displayMode}");
            sw.WriteLine($"{ident}M_displayVisibleEdges={M_displayVisibleEdges}");
            sw.WriteLine($"{ident}M_displayHiddenEdges={M_displayHiddenEdges}");
            sw.WriteLine($"{ident}M_hiddenEdgeLineStyle={M_hiddenEdgeLineStyle}");
            sw.WriteLine($"{ident}M_displayShadows={M_displayShadows}");
            sw.WriteLine($"{ident}M_legacyDrawOrder={M_legacyDrawOrder}");
            sw.WriteLine($"{ident}M_overrideBackgroundColor={M_overrideBackgroundColor}");
            sw.WriteLine($"{ident}M_applyEdgeStyleToLines={M_applyEdgeStyleToLines}");
            sw.WriteLine($"{ident}M_ignoreGeometryMaps={M_ignoreGeometryMaps}");
            sw.WriteLine($"{ident}M_ignoreImageMaps={M_ignoreImageMaps}");
            sw.WriteLine($"{ident}M_hideInPickers={M_hideInPickers}");
            sw.WriteLine($"{ident}M_invisibleToCamera={M_invisibleToCamera}");
            sw.WriteLine($"{ident}M_displayGroundPlane={M_displayGroundPlane}");
            sw.WriteLine($"{ident}M_overrideReflectionColor={M_overrideReflectionColor}");
            sw.WriteLine($"{ident}M_unused={M_unused}");
        }
    }

    public struct OverrideFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 18, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        public UInt32 M_visibleEdgeColor
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_visibleEdgeWeight
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_useTransparency
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_elementColor
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 M_lineStyle
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 M_lineWeight
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 M_material
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 M_visibleEdgeStyle
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 M_hiddenEdgeStyle
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 M_hiddenEdgeWeightZero
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 M_hLineTransparency
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 M_hLineMaterialColors
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 M_smoothIgnoreLights
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 M_useDisplayHandler
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 M_unused
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }

        public OverrideFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_visibleEdgeColor={M_visibleEdgeColor}");
            sw.WriteLine($"{ident}M_visibleEdgeWeight={M_visibleEdgeWeight}");
            sw.WriteLine($"{ident}M_useTransparency={M_useTransparency}");
            sw.WriteLine($"{ident}M_elementColor={M_elementColor}");
            sw.WriteLine($"{ident}M_lineStyle={M_lineStyle}");
            sw.WriteLine($"{ident}M_lineWeight={M_lineWeight}");
            sw.WriteLine($"{ident}M_material={M_material}");
            sw.WriteLine($"{ident}M_visibleEdgeStyle={M_visibleEdgeStyle}");
            sw.WriteLine($"{ident}M_hiddenEdgeStyle={M_hiddenEdgeStyle}");
            sw.WriteLine($"{ident}M_hiddenEdgeWeightZero={M_hiddenEdgeWeightZero}");
            sw.WriteLine($"{ident}M_hLineTransparency={M_hLineTransparency}");
            sw.WriteLine($"{ident}M_hLineMaterialColors={M_hLineMaterialColors}");
            sw.WriteLine($"{ident}M_smoothIgnoreLights={M_smoothIgnoreLights}");
            sw.WriteLine($"{ident}M_useDisplayHandler={M_useDisplayHandler}");
            sw.WriteLine($"{ident}M_unused={M_unused}");
        }
    }

    public struct ViewDisplayOverrides
    {
        public OverrideFlags M_flags;
        public UInt32 M_visibleEdgeColor;
        public UInt32 M_visibleEdgeWeight;
        public UInt32 M_hiddenEdgeWeight;
        public double M_transparency;
        public UInt32 M_elementColor;
        public UInt32 M_lineStyle;
        public UInt32 M_lineWeight;
        public ElementId M_material;
        public UInt32 M_backgroundColor;
        public UInt32 M_reflectionColor;
        public double M_hLineTransparencyThreshold;

        public ViewDisplayOverrides Read(BinaryReader br)
        {
            // read each field
            M_flags = new OverrideFlags().Read(br);
            M_visibleEdgeColor = br.ReadUInt32();
            M_visibleEdgeWeight = br.ReadUInt32();
            M_hiddenEdgeWeight = br.ReadUInt32();
            M_transparency = br.ReadDouble();
            M_elementColor = br.ReadUInt32();
            M_lineStyle = br.ReadUInt32();
            M_lineWeight = br.ReadUInt32();
            M_material = br.ReadUInt64();
            M_backgroundColor = br.ReadUInt32();
            M_reflectionColor = br.ReadUInt32();
            M_hLineTransparencyThreshold = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_flags >");
            M_flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_visibleEdgeColor={M_visibleEdgeColor}");
            sw.WriteLine($"{ident}M_visibleEdgeWeight={M_visibleEdgeWeight}");
            sw.WriteLine($"{ident}M_hiddenEdgeWeight={M_hiddenEdgeWeight}");
            sw.WriteLine($"{ident}M_transparency={M_transparency}");
            sw.WriteLine($"{ident}M_elementColor={M_elementColor}");
            sw.WriteLine($"{ident}M_lineStyle={M_lineStyle}");
            sw.WriteLine($"{ident}M_lineWeight={M_lineWeight}");
            sw.WriteLine($"{ident}M_material={M_material}");
            sw.WriteLine($"{ident}M_backgroundColor={M_backgroundColor}");
            sw.WriteLine($"{ident}M_reflectionColor={M_reflectionColor}");
            sw.WriteLine($"{ident}M_hLineTransparencyThreshold={M_hLineTransparencyThreshold}");
        }
    }

    public struct ClipVolumeFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 29, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 M_reflected
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_ignoreBoundaryClipping
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_ignoreBoundaryCutPlanes
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public ClipVolumeFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_reflected={M_reflected}");
            sw.WriteLine($"{ident}M_ignoreBoundaryClipping={M_ignoreBoundaryClipping}");
            sw.WriteLine($"{ident}M_ignoreBoundaryCutPlanes={M_ignoreBoundaryCutPlanes}");
            sw.WriteLine($"{ident}M_unused={M_unused}");
        }
    }

    public struct ClipVolumeOverrides_M_flags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 28, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 M_display
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_disableLocate
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_disableSnap
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_reflected
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 M_unused
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public ClipVolumeOverrides_M_flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_display={M_display}");
            sw.WriteLine($"{ident}M_disableLocate={M_disableLocate}");
            sw.WriteLine($"{ident}M_disableSnap={M_disableSnap}");
            sw.WriteLine($"{ident}M_reflected={M_reflected}");
            sw.WriteLine($"{ident}M_unused={M_unused}");
        }
    }

    public struct ClipVolumeOverrides
    {
        public ClipVolumeOverrides_M_flags M_flags;
        public Int32 M_styleIndex;

        public ClipVolumeOverrides Read(BinaryReader br)
        {
            // read each field
            M_flags = new ClipVolumeOverrides_M_flags().Read(br);
            M_styleIndex = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_flags >");
            M_flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_styleIndex={M_styleIndex}");
        }
    }

    public struct DynamicViewSettings
    {
        public ClipVolumeFlags M_flags;
        public ClipVolumeOverrides M_forward;
        public ClipVolumeOverrides M_backward;
        public ClipVolumeOverrides M_cut;
        public ClipVolumeOverrides M_outside;

        public DynamicViewSettings Read(BinaryReader br)
        {
            // read each field
            M_flags = new ClipVolumeFlags().Read(br);
            M_forward = new ClipVolumeOverrides().Read(br);
            M_backward = new ClipVolumeOverrides().Read(br);
            M_cut = new ClipVolumeOverrides().Read(br);
            M_outside = new ClipVolumeOverrides().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_flags >");
            M_flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_forward >");
            M_forward.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_backward >");
            M_backward.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_cut >");
            M_cut.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_outside >");
            M_outside.Dump(sw, level + 1);
        }
    }

    public struct CameraParams
    {
        public Dpoint3d Position;
        public double FocalLength;
        public double Limit;

        public CameraParams Read(BinaryReader br)
        {
            // read each field
            Position = new Dpoint3d().Read(br);
            FocalLength = br.ReadDouble();
            Limit = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Position >");
            Position.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FocalLength={FocalLength}");
            sw.WriteLine($"{ident}Limit={Limit}");
        }
    }

    public struct DgnAttachmentLoadOptions
    {
        public bool M_loadCaches;
        public bool M_topLevelModel;
        public bool M_loadUndisplayed;
        public bool M_loadRasterRefs;
        public bool M_oneLevelDeep;
        public bool M_redundancyCheck;
        public bool M_applyOverrides;
        public bool M_showProgressMeter;
        public DgnModelSections M_sectionsToFill;
        public LimitRefLoading M_limitLoading;
        public int M_maxDepth;

        public DgnAttachmentLoadOptions Read(BinaryReader br)
        {
            // read each field
            M_loadCaches = br.ReadBoolean();
            M_topLevelModel = br.ReadBoolean();
            M_loadUndisplayed = br.ReadBoolean();
            M_loadRasterRefs = br.ReadBoolean();
            M_oneLevelDeep = br.ReadBoolean();
            M_redundancyCheck = br.ReadBoolean();
            M_applyOverrides = br.ReadBoolean();
            M_showProgressMeter = br.ReadBoolean();
            M_sectionsToFill = (DgnModelSections)br.ReadInt32();
            M_limitLoading = (LimitRefLoading)br.ReadInt32();
            M_maxDepth = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_loadCaches={M_loadCaches}");
            sw.WriteLine($"{ident}M_topLevelModel={M_topLevelModel}");
            sw.WriteLine($"{ident}M_loadUndisplayed={M_loadUndisplayed}");
            sw.WriteLine($"{ident}M_loadRasterRefs={M_loadRasterRefs}");
            sw.WriteLine($"{ident}M_oneLevelDeep={M_oneLevelDeep}");
            sw.WriteLine($"{ident}M_redundancyCheck={M_redundancyCheck}");
            sw.WriteLine($"{ident}M_applyOverrides={M_applyOverrides}");
            sw.WriteLine($"{ident}M_showProgressMeter={M_showProgressMeter}");
            sw.WriteLine($"{ident}M_sectionsToFill={M_sectionsToFill}");
            sw.WriteLine($"{ident}M_limitLoading={M_limitLoading}");
            sw.WriteLine($"{ident}M_maxDepth={M_maxDepth}");
        }
    }

    public struct LinkageHeader
    {
        private UInt16 Data1;
        private const int sz_1_0 = 8, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt16 WdMantissa
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 WdExponent
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 User
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Modified
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Remote
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Info
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 PrimaryID;

        public LinkageHeader Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            PrimaryID = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}WdMantissa={WdMantissa}");
            sw.WriteLine($"{ident}WdExponent={WdExponent}");
            sw.WriteLine($"{ident}User={User}");
            sw.WriteLine($"{ident}Modified={Modified}");
            sw.WriteLine($"{ident}Remote={Remote}");
            sw.WriteLine($"{ident}Info={Info}");
            sw.WriteLine($"{ident}PrimaryID={PrimaryID}");
        }
    }

    public struct AssocPoint
    {
        public UShort[] Buf;

        public AssocPoint Read(BinaryReader br)
        {
            // read each field
            Buf = new UShort[20];
            for (int i = 0; i < 20; i++)
            {
                Buf[i] = br.ReadUInt16();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine($"{ident}Buf={Buf[i]}");
            }
        }
    }

    public struct ChangeTrackInfo
    {
        public ChangeTrackAction Action;
        public Int32 ProcessNumber;
        public Int16 Funcname;
        public Int32 IdNumber;

        public ChangeTrackInfo Read(BinaryReader br)
        {
            // read each field
            Action = (ChangeTrackAction)br.ReadInt32();
            ProcessNumber = br.ReadInt32();
            Funcname = br.ReadInt16();
            IdNumber = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Action={Action}");
            sw.WriteLine($"{ident}ProcessNumber={ProcessNumber}");
            sw.WriteLine($"{ident}Funcname={Funcname}");
            sw.WriteLine($"{ident}IdNumber={IdNumber}");
        }
    }

    public struct DependencyLinkage_union_U_F
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 4, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt16 Invalid
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 DeleteRoots
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 DontRequireAppForDelete
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 __unused__
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 AllowRemapToOriginal
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 CopyOptions
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 RootDataType
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 RequireApp
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Disabled
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }

        public DependencyLinkage_union_U_F Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Invalid={Invalid}");
            sw.WriteLine($"{ident}DeleteRoots={DeleteRoots}");
            sw.WriteLine($"{ident}DontRequireAppForDelete={DontRequireAppForDelete}");
            sw.WriteLine($"{ident}__unused__={__unused__}");
            sw.WriteLine($"{ident}AllowRemapToOriginal={AllowRemapToOriginal}");
            sw.WriteLine($"{ident}CopyOptions={CopyOptions}");
            sw.WriteLine($"{ident}RootDataType={RootDataType}");
            sw.WriteLine($"{ident}RequireApp={RequireApp}");
            sw.WriteLine($"{ident}Disabled={Disabled}");
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DependencyLinkage_union_U
    {
        [FieldOffset(0)]
        public UInt16 Flags;
        [FieldOffset(0)]
        public DependencyLinkage_union_U_F F;

        public DependencyLinkage_union_U Read(BinaryReader br)
        {
            // read each field
            Flags = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Flags={Flags}");
            sw.WriteLine($"{ident}F >");
            F.Dump(sw, level + 1);
        }
    }

    public struct DependencyRootPath_V
    {
        public UInt32 NumElemsInPath;
        public UInt32 Reserved;
        public double Value;
        public ElementId[] Path;

        public DependencyRootPath_V Read(BinaryReader br)
        {
            // read each field
            NumElemsInPath = br.ReadUInt32();
            Reserved = br.ReadUInt32();
            Value = br.ReadDouble();
            Path = new ElementId[128];
            for (int i = 0; i < 128; i++)
            {
                Path[i] = br.ReadUInt64();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}NumElemsInPath={NumElemsInPath}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Value={Value}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Path={Path[i]}");
            }
        }
    }

    //[StructLayout(LayoutKind.Explicit)]
    public struct DependencyLinkage_union_Root
    {
        UInt16 NRoots;
        DependencyLinkageType RootDataType;
        //[FieldOffset(0)]
        //public byte[] Data;
        //[FieldOffset(0)]
        public ElementId[] Elemid;
        //[FieldOffset(0)]
        public DependencyRootFarElementID[] Far_elemid;
        //[FieldOffset(0)]
        public DependencyRootElementID_V[] E_v;
        //[FieldOffset(0)]
        public DependencyRootFarElementID_V[] Far_e_v;
        //[FieldOffset(0)]
        public AssocPoint[] Assoc;
        //[FieldOffset(0)]
        public DependencyRootPath_V Path_v;

        public DependencyLinkage_union_Root Read(BinaryReader br, UInt16 nRoots, DependencyLinkageType rootDataType)
        {
            NRoots = nRoots;
            RootDataType = rootDataType;
            // read each field
            switch (RootDataType)
            {
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID:
                    {
                        if (nRoots >= 128)
                            Debugger.Break();
                        Elemid = new ElementId[nRoots];
                        try
                        {
                            for (int i = 0; i < nRoots; i++)
                            {
                                Elemid[i] = br.ReadUInt64();
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID_V:
                    {
                        if (nRoots >= 64)
                            Debugger.Break();
                        E_v = new DependencyRootElementID_V[nRoots];
                        try
                        {
                            for (int i = 0; i < nRoots; i++)
                            {
                                E_v[i] = new DependencyRootElementID_V().Read(br);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT:
                    {
                        if (nRoots >= 25)
                            Debugger.Break();
                        Assoc = new AssocPoint[nRoots];
                        try
                        {
                            for (int i = 0; i < nRoots; i++)
                            {
                                Assoc[i] = new AssocPoint().Read(br);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT_I:
                    {
                        Debugger.Break();
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID:
                    {
                        if (nRoots >= 64)
                            Debugger.Break();
                        Far_elemid = new DependencyRootFarElementID[nRoots];
                        try
                        {
                            for (int i = 0; i < nRoots; i++)
                            {
                                Far_elemid[i] = new DependencyRootFarElementID().Read(br);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID_V:
                    {
                        if (nRoots >= 42)
                            Debugger.Break();
                        Far_e_v = new DependencyRootFarElementID_V[nRoots];
                        try
                        {
                            for (int i = 0; i < nRoots; i++)
                            {
                                Far_e_v[i] = new DependencyRootFarElementID_V().Read(br);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_PATH_V:
                    {
                        if (nRoots != 1)
                            Debugger.Break();
                        try
                        {
                            Path_v = new DependencyRootPath_V().Read(br);
                        }
                        catch (Exception)
                        {

                        }
                    }
                    break;
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            switch (RootDataType)
            {
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID:
                    {
                        for (int i = 0; i < NRoots; i++)
                        {
                            sw.WriteLine($"{ident}Elemid={Elemid[i]}");
                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID_V:
                    {
                        for (int i = 0; i < NRoots; i++)
                        {
                            sw.WriteLine($"{ident}E_v >");
                            E_v[i].Dump(sw, level + 1);
                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT:
                    {
                        for (int i = 0; i < NRoots; i++)
                        {
                            sw.WriteLine($"{ident}Assoc >");
                            Assoc[i].Dump(sw, level + 1);
                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT_I:
                    {
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID:
                    {
                        for (int i = 0; i < NRoots; i++)
                        {
                            sw.WriteLine($"{ident}Far_elemid >");
                            Far_elemid[i].Dump(sw, level + 1);
                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID_V:
                    {
                        for (int i = 0; i < NRoots; i++)
                        {
                            sw.WriteLine($"{ident}Far_e_v >");
                            Far_e_v[i].Dump(sw, level + 1);
                        }
                    }
                    break;
                case DependencyLinkageType.DEPENDENCY_DATA_TYPE_PATH_V:
                    {
                        sw.WriteLine($"{ident}Path_v >");
                        Path_v.Dump(sw, level + 1);
                    }
                    break;
            }
        }
    }

    public struct DependencyLinkage
    {
        public UInt16 AppID;
        public UInt16 AppValue;
        public DependencyLinkage_union_U U;
        public UInt16 NRoots;
        public DependencyLinkage_union_Root Root;

        public DependencyLinkage Read(BinaryReader br)
        {
            // read each field
            AppID = br.ReadUInt16();
            AppValue = br.ReadUInt16();
            U = new DependencyLinkage_union_U().Read(br);
            NRoots = br.ReadUInt16();
            Root = new DependencyLinkage_union_Root().Read(br, NRoots, (DependencyLinkageType)U.F.RootDataType);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AppID={AppID}");
            sw.WriteLine($"{ident}AppValue={AppValue}");
            sw.WriteLine($"{ident}U >");
            U.Dump(sw, level + 1);
            sw.WriteLine($"{ident}NRoots={NRoots}");
            sw.WriteLine($"{ident}Root >");
            Root.Dump(sw, level + 1);
        }
    }

    public struct DependencyRootFarElementID
    {
        public ElementId Elemid;
        public ElementId Refattid;

        public DependencyRootFarElementID Read(BinaryReader br)
        {
            // read each field
            Elemid = br.ReadUInt64();
            Refattid = br.ReadUInt64();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Elemid={Elemid}");
            sw.WriteLine($"{ident}Refattid={Refattid}");
        }
    }

    public struct DependencyRootElementID_V
    {
        public ElementId Elemid;
        public double Value;

        public DependencyRootElementID_V Read(BinaryReader br)
        {
            // read each field
            Elemid = br.ReadUInt64();
            Value = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Elemid={Elemid}");
            sw.WriteLine($"{ident}Value={Value}");
        }
    }

    public struct DependencyRootFarElementID_V
    {
        public DependencyRootElementID_V S;
        public ElementId Refattid;

        public DependencyRootFarElementID_V Read(BinaryReader br)
        {
            // read each field
            S = new DependencyRootElementID_V().Read(br);
            Refattid = br.ReadUInt64();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}S >");
            S.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Refattid={Refattid}");
        }
    }

    public struct DwgHatchDefLine
    {
        public double Angle;
        public DPoint2d Through;
        public DPoint2d Offset;
        public short NDashes;
        public double[] Dashes;

        public DwgHatchDefLine Read(BinaryReader br)
        {
            // read each field
            Angle = br.ReadDouble();
            Through = new DPoint2d().Read(br);
            Offset = new DPoint2d().Read(br);
            NDashes = br.ReadInt16();
            Dashes = new double[20];
            for (int i = 0; i < 20; i++)
            {
                Dashes[i] = br.ReadDouble();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Angle={Angle}");
            sw.WriteLine($"{ident}Through >");
            Through.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Offset >");
            Offset.Dump(sw, level + 1);
            sw.WriteLine($"{ident}NDashes={NDashes}");
            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine($"{ident}Dashes={Dashes[i]}");
            }
        }
    }

    public struct _RasterTransparentColorDef
    {
        public Byte Index;
        public Byte Transparency;

        public _RasterTransparentColorDef Read(BinaryReader br)
        {
            // read each field
            Index = br.ReadByte();
            Transparency = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Index={Index}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
        }
    }

    public struct _RGBColorCube
    {
        public RgbColorDef ColorMin;
        public RgbColorDef ColorMax;

        public _RGBColorCube Read(BinaryReader br)
        {
            // read each field
            ColorMin = new RgbColorDef().Read(br);
            ColorMax = new RgbColorDef().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ColorMin >");
            ColorMin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ColorMax >");
            ColorMax.Dump(sw, level + 1);
        }
    }

    public struct _rgbTransparentColorDef
    {
        public _RGBColorCube ColorCube;
        public Byte Transparency;

        public _rgbTransparentColorDef Read(BinaryReader br)
        {
            // read each field
            ColorCube = new _RGBColorCube().Read(br);
            Transparency = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ColorCube={ColorCube}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
        }
    }

    public struct TxnPos
    {
        public Int32 M_pos;

        public TxnPos Read(BinaryReader br)
        {
            // read each field
            M_pos = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_pos={M_pos}");
        }
    }

    public struct NamedGroupFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 26, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 M_allowDuplicates
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_exclusiveMembers
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_allowFarReferences
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_closed
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 M_selectMembers
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 M_anonymous
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 M_reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public NamedGroupFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_allowDuplicates={M_allowDuplicates}");
            sw.WriteLine($"{ident}M_exclusiveMembers={M_exclusiveMembers}");
            sw.WriteLine($"{ident}M_allowFarReferences={M_allowFarReferences}");
            sw.WriteLine($"{ident}M_closed={M_closed}");
            sw.WriteLine($"{ident}M_selectMembers={M_selectMembers}");
            sw.WriteLine($"{ident}M_anonymous={M_anonymous}");
            sw.WriteLine($"{ident}M_reserved={M_reserved}");
        }
    }

    public struct NamedGroupMemberFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 20, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 M_forwardPropagate
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 M_backwardPropagate
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 M_groupPropagate
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 M_reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public NamedGroupMemberFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_forwardPropagate={M_forwardPropagate}");
            sw.WriteLine($"{ident}M_backwardPropagate={M_backwardPropagate}");
            sw.WriteLine($"{ident}M_groupPropagate={M_groupPropagate}");
            sw.WriteLine($"{ident}M_reserved={M_reserved}");
        }
    }

    public struct DCompFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 26, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 SheetViews
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 HiddenLine
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DisplayHidden
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 AttachNested
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 StoreCompletePath
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 IncrementalHLine
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public DCompFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SheetViews={SheetViews}");
            sw.WriteLine($"{ident}HiddenLine={HiddenLine}");
            sw.WriteLine($"{ident}DisplayHidden={DisplayHidden}");
            sw.WriteLine($"{ident}AttachNested={AttachNested}");
            sw.WriteLine($"{ident}StoreCompletePath={StoreCompletePath}");
            sw.WriteLine($"{ident}IncrementalHLine={IncrementalHLine}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct DCompSettings
    {
        public double MarginPercent;
        public double ModelScale;
        public double SheetScale;
        public DCompFlags Flags;
        public Int16 RefMerge;
        public Int16 ViewAnnotationLevel;
        public Int16 SheetAnnotationLevel;
        public Int16[] ModelLevels;

        public DCompSettings Read(BinaryReader br)
        {
            // read each field
            MarginPercent = br.ReadDouble();
            ModelScale = br.ReadDouble();
            SheetScale = br.ReadDouble();
            Flags = new DCompFlags().Read(br);
            RefMerge = br.ReadInt16();
            ViewAnnotationLevel = br.ReadInt16();
            SheetAnnotationLevel = br.ReadInt16();
            ModelLevels = new Int16[4];
            for (int i = 0; i < 4; i++)
            {
                ModelLevels[i] = br.ReadInt16();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MarginPercent={MarginPercent}");
            sw.WriteLine($"{ident}ModelScale={ModelScale}");
            sw.WriteLine($"{ident}SheetScale={SheetScale}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RefMerge={RefMerge}");
            sw.WriteLine($"{ident}ViewAnnotationLevel={ViewAnnotationLevel}");
            sw.WriteLine($"{ident}SheetAnnotationLevel={SheetAnnotationLevel}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}ModelLevels={ModelLevels[i]}");
            }
        }
    }

    public struct Outflg
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 21, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 Dragen
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Dragact
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Allowuc
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Noele
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Inflin
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Noout
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Unused2
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Prompt_uc
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Uc_messages
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Inhibit_parse
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Spare
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }

        public Outflg Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Dragen={Dragen}");
            sw.WriteLine($"{ident}Dragact={Dragact}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Allowuc={Allowuc}");
            sw.WriteLine($"{ident}Noele={Noele}");
            sw.WriteLine($"{ident}Inflin={Inflin}");
            sw.WriteLine($"{ident}Noout={Noout}");
            sw.WriteLine($"{ident}Unused2={Unused2}");
            sw.WriteLine($"{ident}Prompt_uc={Prompt_uc}");
            sw.WriteLine($"{ident}Uc_messages={Uc_messages}");
            sw.WriteLine($"{ident}Inhibit_parse={Inhibit_parse}");
            sw.WriteLine($"{ident}Spare={Spare}");
        }
    }

    public struct Tcb_RefScale
    {
        public double Reference;
        public double Master;
        public double RescaleFactor;

        public Tcb_RefScale Read(BinaryReader br)
        {
            // read each field
            Reference = br.ReadDouble();
            Master = br.ReadDouble();
            RescaleFactor = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Reference={Reference}");
            sw.WriteLine($"{ident}Master={Master}");
            sw.WriteLine($"{ident}RescaleFactor={RescaleFactor}");
        }
    }

    public struct Cntrlwd
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 6, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 22, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Grid_lock_deprecated
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Unit_lock_deprecated
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserve1
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Inh_msg
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Inh_err
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserve2
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }

        public Cntrlwd Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Grid_lock_deprecated={Grid_lock_deprecated}");
            sw.WriteLine($"{ident}Unit_lock_deprecated={Unit_lock_deprecated}");
            sw.WriteLine($"{ident}Reserve1={Reserve1}");
            sw.WriteLine($"{ident}Inh_msg={Inh_msg}");
            sw.WriteLine($"{ident}Inh_err={Inh_err}");
            sw.WriteLine($"{ident}Reserve2={Reserve2}");
        }
    }

    public struct Cntrl1
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 9, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt16 Reserve1
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Boresite_deprecated
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Prj_key
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Cnstplane
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Stackfract
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Cellgg
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 Capsurf
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 Reserve2
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }

        public Cntrl1 Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Reserve1={Reserve1}");
            sw.WriteLine($"{ident}Boresite_deprecated={Boresite_deprecated}");
            sw.WriteLine($"{ident}Prj_key={Prj_key}");
            sw.WriteLine($"{ident}Cnstplane={Cnstplane}");
            sw.WriteLine($"{ident}Stackfract={Stackfract}");
            sw.WriteLine($"{ident}Cellgg={Cellgg}");
            sw.WriteLine($"{ident}Capsurf={Capsurf}");
            sw.WriteLine($"{ident}Reserve2={Reserve2}");
        }
    }

    public struct Fbfdcn
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 2, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 3, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        public UInt16 Solidhole
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Scalelk
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Txnodelk_deprecated
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Anglelk
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Snaplk
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Mirrorch
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 Unused
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 Linewidth
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Fenceclip
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt16 Gglk
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_9) >> loc_1_9);
            set => Data1 = (UInt16)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt16 Levellk
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_10) >> loc_1_10);
            set => Data1 = (UInt16)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_11) >> loc_1_11);
            set => Data1 = (UInt16)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt16 Overlap
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_12) >> loc_1_12);
            set => Data1 = (UInt16)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }

        public Fbfdcn Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Solidhole={Solidhole}");
            sw.WriteLine($"{ident}Scalelk={Scalelk}");
            sw.WriteLine($"{ident}Txnodelk_deprecated={Txnodelk_deprecated}");
            sw.WriteLine($"{ident}Anglelk={Anglelk}");
            sw.WriteLine($"{ident}Snaplk={Snaplk}");
            sw.WriteLine($"{ident}Mirrorch={Mirrorch}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Linewidth={Linewidth}");
            sw.WriteLine($"{ident}Fenceclip={Fenceclip}");
            sw.WriteLine($"{ident}Gglk={Gglk}");
            sw.WriteLine($"{ident}Levellk={Levellk}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Overlap={Overlap}");
        }
    }

    public struct Ext_locks
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 2, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 2, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 1, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        private const int sz_1_22 = 1, loc_1_22 = loc_1_21 + sz_1_21, mask_1_22 = unchecked(((1 << sz_1_22) - 1) << loc_1_22);
        private const int sz_1_23 = 1, loc_1_23 = loc_1_22 + sz_1_22, mask_1_23 = unchecked(((1 << sz_1_23) - 1) << loc_1_23);
        private const int sz_1_24 = 1, loc_1_24 = loc_1_23 + sz_1_23, mask_1_24 = unchecked(((1 << sz_1_24) - 1) << loc_1_24);
        private const int sz_1_25 = 1, loc_1_25 = loc_1_24 + sz_1_24, mask_1_25 = unchecked(((1 << sz_1_25) - 1) << loc_1_25);
        private const int sz_1_26 = 1, loc_1_26 = loc_1_25 + sz_1_25, mask_1_26 = unchecked(((1 << sz_1_26) - 1) << loc_1_26);
        private const int sz_1_27 = 1, loc_1_27 = loc_1_26 + sz_1_26, mask_1_27 = unchecked(((1 << sz_1_27) - 1) << loc_1_27);
        private const int sz_1_28 = 1, loc_1_28 = loc_1_27 + sz_1_27, mask_1_28 = unchecked(((1 << sz_1_28) - 1) << loc_1_28);
        private const int sz_1_29 = 1, loc_1_29 = loc_1_28 + sz_1_28, mask_1_29 = unchecked(((1 << sz_1_29) - 1) << loc_1_29);
        public UInt32 Axis_lock
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Auxinp
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Show_pos
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Autopan
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Unused1
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Cell_stretch
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Iso_grid_deprecated
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Iso_plane_deprecated
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Selection_set_deprecated
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Auto_handles
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Single_shot
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Dont_restart
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 ViewSingle_shot
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 SnapCnstplane
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 CnstPlanePerp
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 FillMode
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 Iso_lock_deprecated
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 ExtendedLevels
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 IntersectionSnap
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 Association
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 SharedCells
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 FenceVoid
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }
        public UInt32 FastDynamics
        {
            get => (UInt32)(Data1 & mask_1_22) >> loc_1_22;
            set => Data1 = (UInt32)(Data1 & ~mask_1_22 | (value << loc_1_22) & mask_1_22);
        }
        public UInt32 SnappablePatterns
        {
            get => (UInt32)(Data1 & mask_1_23) >> loc_1_23;
            set => Data1 = (UInt32)(Data1 & ~mask_1_23 | (value << loc_1_23) & mask_1_23);
        }
        public UInt32 DepthLock
        {
            get => (UInt32)(Data1 & mask_1_24) >> loc_1_24;
            set => Data1 = (UInt32)(Data1 & ~mask_1_24 | (value << loc_1_24) & mask_1_24);
        }
        public UInt32 RestrictLocate
        {
            get => (UInt32)(Data1 & mask_1_25) >> loc_1_25;
            set => Data1 = (UInt32)(Data1 & ~mask_1_25 | (value << loc_1_25) & mask_1_25);
        }
        public UInt32 AssociativePattern
        {
            get => (UInt32)(Data1 & mask_1_26) >> loc_1_26;
            set => Data1 = (UInt32)(Data1 & ~mask_1_26 | (value << loc_1_26) & mask_1_26);
        }
        public UInt32 TrueScaleCells
        {
            get => (UInt32)(Data1 & mask_1_27) >> loc_1_27;
            set => Data1 = (UInt32)(Data1 & ~mask_1_27 | (value << loc_1_27) & mask_1_27);
        }
        public UInt32 IgnoreReferenceLevelOverrides
        {
            get => (UInt32)(Data1 & mask_1_28) >> loc_1_28;
            set => Data1 = (UInt32)(Data1 & ~mask_1_28 | (value << loc_1_28) & mask_1_28);
        }
        public UInt32 ScaleViewportLineStyles
        {
            get => (UInt32)(Data1 & mask_1_29) >> loc_1_29;
            set => Data1 = (UInt32)(Data1 & ~mask_1_29 | (value << loc_1_29) & mask_1_29);
        }

        public Ext_locks Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Axis_lock={Axis_lock}");
            sw.WriteLine($"{ident}Auxinp={Auxinp}");
            sw.WriteLine($"{ident}Show_pos={Show_pos}");
            sw.WriteLine($"{ident}Autopan={Autopan}");
            sw.WriteLine($"{ident}Unused1={Unused1}");
            sw.WriteLine($"{ident}Cell_stretch={Cell_stretch}");
            sw.WriteLine($"{ident}Iso_grid_deprecated={Iso_grid_deprecated}");
            sw.WriteLine($"{ident}Iso_plane_deprecated={Iso_plane_deprecated}");
            sw.WriteLine($"{ident}Selection_set_deprecated={Selection_set_deprecated}");
            sw.WriteLine($"{ident}Auto_handles={Auto_handles}");
            sw.WriteLine($"{ident}Single_shot={Single_shot}");
            sw.WriteLine($"{ident}Dont_restart={Dont_restart}");
            sw.WriteLine($"{ident}ViewSingle_shot={ViewSingle_shot}");
            sw.WriteLine($"{ident}SnapCnstplane={SnapCnstplane}");
            sw.WriteLine($"{ident}CnstPlanePerp={CnstPlanePerp}");
            sw.WriteLine($"{ident}FillMode={FillMode}");
            sw.WriteLine($"{ident}Iso_lock_deprecated={Iso_lock_deprecated}");
            sw.WriteLine($"{ident}ExtendedLevels={ExtendedLevels}");
            sw.WriteLine($"{ident}IntersectionSnap={IntersectionSnap}");
            sw.WriteLine($"{ident}Association={Association}");
            sw.WriteLine($"{ident}SharedCells={SharedCells}");
            sw.WriteLine($"{ident}FenceVoid={FenceVoid}");
            sw.WriteLine($"{ident}FastDynamics={FastDynamics}");
            sw.WriteLine($"{ident}SnappablePatterns={SnappablePatterns}");
            sw.WriteLine($"{ident}DepthLock={DepthLock}");
            sw.WriteLine($"{ident}RestrictLocate={RestrictLocate}");
            sw.WriteLine($"{ident}AssociativePattern={AssociativePattern}");
            sw.WriteLine($"{ident}TrueScaleCells={TrueScaleCells}");
            sw.WriteLine($"{ident}IgnoreReferenceLevelOverrides={IgnoreReferenceLevelOverrides}");
            sw.WriteLine($"{ident}ScaleViewportLineStyles={ScaleViewportLineStyles}");
        }
    }

    public struct Ext_locks2
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 29, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 DisplayReferenceClipBoundaries
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ContinousLineStringStyles
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 CheckUserDesignLimits
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public Ext_locks2 Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}DisplayReferenceClipBoundaries={DisplayReferenceClipBoundaries}");
            sw.WriteLine($"{ident}ContinousLineStringStyles={ContinousLineStringStyles}");
            sw.WriteLine($"{ident}CheckUserDesignLimits={CheckUserDesignLimits}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct TransformFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 14, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt16 IgnoreScaleForDimValues
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 IgnoreScaleForAnnotations
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Unused
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public TransformFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IgnoreScaleForDimValues={IgnoreScaleForDimValues}");
            sw.WriteLine($"{ident}IgnoreScaleForAnnotations={IgnoreScaleForAnnotations}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct LineStyleInfo
    {
        public Int32 Deprecated;
        public UInt32 Modifiers;
        public UInt32[] Reserved;
        public T_Adouble Scale;
        public T_Adouble Shift;
        public T_Adouble StartWidth;
        public T_Adouble EndWidth;

        public LineStyleInfo Read(BinaryReader br)
        {
            // read each field
            Deprecated = br.ReadInt32();
            Modifiers = br.ReadUInt32();
            Reserved = new UInt32[4];
            for (int i = 0; i < 4; i++)
            {
                Reserved[i] = br.ReadUInt32();
            }
            Scale = br.ReadDouble();
            Shift = br.ReadDouble();
            StartWidth = br.ReadDouble();
            EndWidth = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Deprecated={Deprecated}");
            sw.WriteLine($"{ident}Modifiers={Modifiers}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}Reserved={Reserved[i]}");
            }
            sw.WriteLine($"{ident}Scale={Scale}");
            sw.WriteLine($"{ident}Shift={Shift}");
            sw.WriteLine($"{ident}StartWidth={StartWidth}");
            sw.WriteLine($"{ident}EndWidth={EndWidth}");
        }
    }

    public struct MlineTcbFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 7, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt16 Compatible
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Reserved1
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 OffsetMode
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 ScaleOffsets
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 MirrorOffsets
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 UseElementScale
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public MlineTcbFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Compatible={Compatible}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}OffsetMode={OffsetMode}");
            sw.WriteLine($"{ident}ScaleOffsets={ScaleOffsets}");
            sw.WriteLine($"{ident}MirrorOffsets={MirrorOffsets}");
            sw.WriteLine($"{ident}UseElementScale={UseElementScale}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct ActiveCellSettings
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 15, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt16 IsAnnotation
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public ActiveCellSettings Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IsAnnotation={IsAnnotation}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct AuxToolFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 13, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt16 Aux_rotation_viewInd
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Aux_rotation_absolute
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Aux_apply_all_views
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Aux_settings_reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public AuxToolFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Aux_rotation_viewInd={Aux_rotation_viewInd}");
            sw.WriteLine($"{ident}Aux_rotation_absolute={Aux_rotation_absolute}");
            sw.WriteLine($"{ident}Aux_apply_all_views={Aux_apply_all_views}");
            sw.WriteLine($"{ident}Aux_settings_reserved={Aux_settings_reserved}");
        }
    }

    public struct RenderFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 3, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 16, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 AmbientLight
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SolarLight
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 FlashLight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 AntiAliasGrid
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SolarShadows
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ShadowFilter
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 InterpolateTextures
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SolarByVector
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SaveShadowMaps
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 IgnoreLinear
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 RenderLinesAsVectors
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Unused_bits_pad
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt16 SolarShadowRes;
        public UInt16 Padding;

        public RenderFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            SolarShadowRes = br.ReadUInt16();
            Padding = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AmbientLight={AmbientLight}");
            sw.WriteLine($"{ident}SolarLight={SolarLight}");
            sw.WriteLine($"{ident}FlashLight={FlashLight}");
            sw.WriteLine($"{ident}AntiAliasGrid={AntiAliasGrid}");
            sw.WriteLine($"{ident}SolarShadows={SolarShadows}");
            sw.WriteLine($"{ident}ShadowFilter={ShadowFilter}");
            sw.WriteLine($"{ident}InterpolateTextures={InterpolateTextures}");
            sw.WriteLine($"{ident}SolarByVector={SolarByVector}");
            sw.WriteLine($"{ident}SaveShadowMaps={SaveShadowMaps}");
            sw.WriteLine($"{ident}IgnoreLinear={IgnoreLinear}");
            sw.WriteLine($"{ident}RenderLinesAsVectors={RenderLinesAsVectors}");
            sw.WriteLine($"{ident}Unused_bits_pad={Unused_bits_pad}");
            sw.WriteLine($"{ident}SolarShadowRes={SolarShadowRes}");
        }
    }

    public struct Latitude
    {
        public Int16 Degrees;
        public byte Minutes;
        public byte Seconds;

        public Latitude Read(BinaryReader br)
        {
            // read each field
            Degrees = br.ReadInt16();
            Minutes = br.ReadByte();
            Seconds = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Degrees={Degrees}");
            sw.WriteLine($"{ident}Minutes={Minutes}");
            sw.WriteLine($"{ident}Seconds={Seconds}");
        }
    }

    public struct Longitude
    {
        public Int16 Degrees;
        public byte Minutes;
        public byte Seconds;

        public Longitude Read(BinaryReader br)
        {
            // read each field
            Degrees = br.ReadInt16();
            Minutes = br.ReadByte();
            Seconds = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Degrees={Degrees}");
            sw.WriteLine($"{ident}Minutes={Minutes}");
            sw.WriteLine($"{ident}Seconds={Seconds}");
        }
    }

    public struct SolarTime
    {
        private UInt32 Data1;
        private const int sz_1_0 = 8, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 8, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 8, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 Day
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Hour
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Minute
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Month
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Pm
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Dst
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 UseCurrentTime
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }

        public SolarTime Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Day={Day}");
            sw.WriteLine($"{ident}Hour={Hour}");
            sw.WriteLine($"{ident}Minute={Minute}");
            sw.WriteLine($"{ident}Month={Month}");
            sw.WriteLine($"{ident}Pm={Pm}");
            sw.WriteLine($"{ident}Dst={Dst}");
            sw.WriteLine($"{ident}UseCurrentTime={UseCurrentTime}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MSToolSettings_Mirror
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 27, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 About
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_Mirror Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}About={About}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Parallel
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 29, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ByKeyIn
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 EliminateLoops
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public MSToolSettings_Parallel Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}ByKeyIn={ByKeyIn}");
            sw.WriteLine($"{ident}EliminateLoops={EliminateLoops}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Rotate
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 25, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ByAAKeyIn
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 By2Points
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public MSToolSettings_Rotate Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}ByAAKeyIn={ByAAKeyIn}");
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}By2Points={By2Points}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Change
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 27, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 FenceSymbology
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 FenceColor
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 FenceLineStyle
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 FenceWeight
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 FenceLevel
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }

        public MSToolSettings_Change Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}FenceSymbology={FenceSymbology}");
            sw.WriteLine($"{ident}FenceColor={FenceColor}");
            sw.WriteLine($"{ident}FenceLineStyle={FenceLineStyle}");
            sw.WriteLine($"{ident}FenceWeight={FenceWeight}");
            sw.WriteLine($"{ident}FenceLevel={FenceLevel}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Scale
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 26, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Proportional
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public MSToolSettings_Scale Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}Proportional={Proportional}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Curve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Planar
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 PointCurveStream
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_Curve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Planar={Planar}");
            sw.WriteLine($"{ident}PointCurveStream={PointCurveStream}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_General
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 22, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 UseFence
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SimplifyGeometry
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 LevelDisplayMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 LevelDisplayActiveView
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public MSToolSettings_General Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}UseFence={UseFence}");
            sw.WriteLine($"{ident}SimplifyGeometry={SimplifyGeometry}");
            sw.WriteLine($"{ident}LevelDisplayMode={LevelDisplayMode}");
            sw.WriteLine($"{ident}LevelDisplayActiveView={LevelDisplayActiveView}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Array
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 28, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_Array Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ScaleFence
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_ScaleFence Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_RotateFence
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ByAAKeyIn
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_RotateFence Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}ByAAKeyIn={ByAAKeyIn}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_MirrorFence
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 24, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 About
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_MirrorFence Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}About={About}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlaceText
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 22, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 NoteMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 NoteToolReverse
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 NoteToolMode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }

        public MSToolSettings_PlaceText Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}NoteMode={NoteMode}");
            sw.WriteLine($"{ident}NoteToolReverse={NoteToolReverse}");
            sw.WriteLine($"{ident}NoteToolMode={NoteToolMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlaceNode
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 ViewIndependent
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_PlaceNode Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ViewIndependent={ViewIndependent}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlaceCell
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 6, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 3, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 15, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 Relative
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Interactive
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 ExtededSettings
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Flatten
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 View
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Mirror
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MirrorType
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 InteractionType
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }

        public MSToolSettings_PlaceCell Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Relative={Relative}");
            sw.WriteLine($"{ident}Interactive={Interactive}");
            sw.WriteLine($"{ident}ExtededSettings={ExtededSettings}");
            sw.WriteLine($"{ident}Flatten={Flatten}");
            sw.WriteLine($"{ident}View={View}");
            sw.WriteLine($"{ident}Mirror={Mirror}");
            sw.WriteLine($"{ident}MirrorType={MirrorType}");
            sw.WriteLine($"{ident}InteractionType={InteractionType}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_SelectCell
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Relative
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DisplayAllCells
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_SelectCell Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Relative={Relative}");
            sw.WriteLine($"{ident}DisplayAllCells={DisplayAllCells}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Fillet
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 29, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Truncation
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_Fillet Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Truncation={Truncation}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Parabolic
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 26, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Horizontal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Truncation
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_Parabolic Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Horizontal={Horizontal}");
            sw.WriteLine($"{ident}Truncation={Truncation}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ExtendElement
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 ByKeyIn
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 FromEnd
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_ExtendElement Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ByKeyIn={ByKeyIn}");
            sw.WriteLine($"{ident}FromEnd={FromEnd}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ComplexChain
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 29, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_ComplexChain Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ComplexShape
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 29, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_ComplexShape Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_LinearPattern
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 28, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 CycleMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_LinearPattern Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}CycleMode={CycleMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_AreaPattern
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 13, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 RegionMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SearchForHoles
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 UseElementSymbology
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 InteriorShapes
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 InteriorText
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 InvisibleBoundary
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 DynamicArea
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 RegionParity
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 PatternFile
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 AssociativeBoundary
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }

        public MSToolSettings_AreaPattern Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}RegionMode={RegionMode}");
            sw.WriteLine($"{ident}SearchForHoles={SearchForHoles}");
            sw.WriteLine($"{ident}UseElementSymbology={UseElementSymbology}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}InteriorShapes={InteriorShapes}");
            sw.WriteLine($"{ident}InteriorText={InteriorText}");
            sw.WriteLine($"{ident}InvisibleBoundary={InvisibleBoundary}");
            sw.WriteLine($"{ident}DynamicArea={DynamicArea}");
            sw.WriteLine($"{ident}RegionParity={RegionParity}");
            sw.WriteLine($"{ident}PatternFile={PatternFile}");
            sw.WriteLine($"{ident}AssociativeBoundary={AssociativeBoundary}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_MeasureArea
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 26, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 RegionMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_MeasureArea Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}RegionMode={RegionMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_MeasureDistance
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 3, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 19, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 PerpendicularMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ExtendAdvOptions
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ProjectionMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }

        public MSToolSettings_MeasureDistance Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}PerpendicularMode={PerpendicularMode}");
            sw.WriteLine($"{ident}ExtendAdvOptions={ExtendAdvOptions}");
            sw.WriteLine($"{ident}ProjectionMode={ProjectionMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_MeasureProperties
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 2, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 3, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 2, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 15, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 DisplayMassProperties
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DisplayMoments
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DisplayPrincipal
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DisplayRadii
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 DisplayCentroid
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ActiveAreaUnitSystem
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 ActiveAreaUnitIndex
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 ActiveVolumeUnitSystem
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 ActiveVolumeUnitIndex
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 MomentSystem
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved1;    // padding
        public T_Adouble Tolerance;
        public T_Adouble WeightPerLength;
        public T_Adouble WeightPerArea;
        public T_Adouble WeightPerVolume;

        public MSToolSettings_MeasureProperties Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = br.ReadDouble();
            WeightPerLength = br.ReadDouble();
            WeightPerArea = br.ReadDouble();
            WeightPerVolume = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}DisplayMassProperties={DisplayMassProperties}");
            sw.WriteLine($"{ident}DisplayMoments={DisplayMoments}");
            sw.WriteLine($"{ident}DisplayPrincipal={DisplayPrincipal}");
            sw.WriteLine($"{ident}DisplayRadii={DisplayRadii}");
            sw.WriteLine($"{ident}DisplayCentroid={DisplayCentroid}");
            sw.WriteLine($"{ident}ActiveAreaUnitSystem={ActiveAreaUnitSystem}");
            sw.WriteLine($"{ident}ActiveAreaUnitIndex={ActiveAreaUnitIndex}");
            sw.WriteLine($"{ident}ActiveVolumeUnitSystem={ActiveVolumeUnitSystem}");
            sw.WriteLine($"{ident}ActiveVolumeUnitIndex={ActiveVolumeUnitIndex}");
            sw.WriteLine($"{ident}MomentSystem={MomentSystem}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            //sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
            sw.WriteLine($"{ident}WeightPerLength={WeightPerLength}");
            sw.WriteLine($"{ident}WeightPerArea={WeightPerArea}");
            sw.WriteLine($"{ident}WeightPerVolume={WeightPerVolume}");
        }
    }

    public struct MSToolSettings_CreateRegion
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 25, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 RegionMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_CreateRegion Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}RegionMode={RegionMode}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ChangeElement
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 19, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Style
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Weight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Level
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ElemClass
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Lstyle
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 ChangeMlinePlacement
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 ChangeMlineEndAngles
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Transparency
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Priority
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }

        public MSToolSettings_ChangeElement Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Level={Level}");
            sw.WriteLine($"{ident}ElemClass={ElemClass}");
            sw.WriteLine($"{ident}Lstyle={Lstyle}");
            sw.WriteLine($"{ident}ChangeMlinePlacement={ChangeMlinePlacement}");
            sw.WriteLine($"{ident}ChangeMlineEndAngles={ChangeMlineEndAngles}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
            sw.WriteLine($"{ident}Priority={Priority}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlaceBlock
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 26, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_PlaceBlock Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlaceShape
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 26, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_PlaceShape Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_PlacePolygon
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 26, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_PlacePolygon Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_RenderView
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 17, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Target
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Modifier
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 FacetSmoothMode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 RenderingFence
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CreateInternalMaterials
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 CreateInternalMaterialsDoNotPrompt
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }

        public MSToolSettings_RenderView Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Target={Target}");
            sw.WriteLine($"{ident}Modifier={Modifier}");
            sw.WriteLine($"{ident}FacetSmoothMode={FacetSmoothMode}");
            sw.WriteLine($"{ident}RenderingFence={RenderingFence}");
            sw.WriteLine($"{ident}CreateInternalMaterials={CreateInternalMaterials}");
            sw.WriteLine($"{ident}CreateInternalMaterialsDoNotPrompt={CreateInternalMaterialsDoNotPrompt}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_CameraSet
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 6, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 20, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ImagePlane
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_CameraSet Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}ImagePlane={ImagePlane}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ConsLineAA
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 25, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 LengthLock
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MSToolSettings_ConsLineAA Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}LengthLock={LengthLock}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Igen
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 4, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 2, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 3, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 13, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        public UInt32 IndexingLock
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 IndexingMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 NonPlanerLock
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 AaLock
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 PlaceCircleMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 PlaceEllipseMode
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 PlaceArcMode
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 ShowAsRadius
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 PlaceArcModeEx
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }

        public MSToolSettings_Igen Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IndexingLock={IndexingLock}");
            sw.WriteLine($"{ident}IndexingMode={IndexingMode}");
            sw.WriteLine($"{ident}NonPlanerLock={NonPlanerLock}");
            sw.WriteLine($"{ident}AaLock={AaLock}");
            sw.WriteLine($"{ident}PlaceCircleMode={PlaceCircleMode}");
            sw.WriteLine($"{ident}PlaceEllipseMode={PlaceEllipseMode}");
            sw.WriteLine($"{ident}PlaceArcMode={PlaceArcMode}");
            sw.WriteLine($"{ident}ShowAsRadius={ShowAsRadius}");
            sw.WriteLine($"{ident}PlaceArcModeEx={PlaceArcModeEx}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Fence
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 5, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 3, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 2, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 16, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 PlaceMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ModifyMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 ContentsMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DesignMode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 CopyToFileMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 OpenOutputFile
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public MSToolSettings_Fence Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}PlaceMode={PlaceMode}");
            sw.WriteLine($"{ident}ModifyMode={ModifyMode}");
            sw.WriteLine($"{ident}ContentsMode={ContentsMode}");
            sw.WriteLine($"{ident}DesignMode={DesignMode}");
            sw.WriteLine($"{ident}CopyToFileMode={CopyToFileMode}");
            sw.WriteLine($"{ident}OpenOutputFile={OpenOutputFile}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_ChangeText
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 19, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        public UInt32 Font
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Height
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Width
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Linespace
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Interchar
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Slant
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Underline
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Vertical
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Viewind
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Just
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Linelength
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Textstyle
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Linespacetype
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }

        public MSToolSettings_ChangeText Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Height={Height}");
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}Linespace={Linespace}");
            sw.WriteLine($"{ident}Interchar={Interchar}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}Underline={Underline}");
            sw.WriteLine($"{ident}Vertical={Vertical}");
            sw.WriteLine($"{ident}Viewind={Viewind}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}Linelength={Linelength}");
            sw.WriteLine($"{ident}Textstyle={Textstyle}");
            sw.WriteLine($"{ident}Linespacetype={Linespacetype}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Font
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Sort
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public MSToolSettings_Font Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Sort={Sort}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MSToolSettings_Smartline
    {
        private UInt32 Data1;
        private const int sz_1_0 = 16, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 5, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ArcMethod
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Open
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 NonOrtho
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Disjoint
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 VertexType
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SegmentType
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved1;
        public T_Adouble Radius;

        public MSToolSettings_Smartline Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}ArcMethod={ArcMethod}");
            sw.WriteLine($"{ident}Open={Open}");
            sw.WriteLine($"{ident}NonOrtho={NonOrtho}");
            sw.WriteLine($"{ident}Disjoint={Disjoint}");
            sw.WriteLine($"{ident}VertexType={VertexType}");
            sw.WriteLine($"{ident}SegmentType={SegmentType}");
            //sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Radius={Radius}");
        }
    }

    public struct MSToolSettings_RefTools
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 2, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 16, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 2, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 ClipMethod
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ScaleMethod
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 IgnoreRefDialog
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 MirrorMethod
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 RotateMethod
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 DeprecatedWasPresentation
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 UseRefCopies
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 MakeChildrenDirect
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 DiscardClipMasks
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 AllowOptimizedClip
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 FoldMethod
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 FoldProjection
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 NumRefCopies;

        public MSToolSettings_RefTools Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            NumRefCopies = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ClipMethod={ClipMethod}");
            sw.WriteLine($"{ident}ScaleMethod={ScaleMethod}");
            sw.WriteLine($"{ident}IgnoreRefDialog={IgnoreRefDialog}");
            sw.WriteLine($"{ident}MirrorMethod={MirrorMethod}");
            sw.WriteLine($"{ident}RotateMethod={RotateMethod}");
            sw.WriteLine($"{ident}DeprecatedWasPresentation={DeprecatedWasPresentation}");
            sw.WriteLine($"{ident}UseRefCopies={UseRefCopies}");
            sw.WriteLine($"{ident}MakeChildrenDirect={MakeChildrenDirect}");
            sw.WriteLine($"{ident}DiscardClipMasks={DiscardClipMasks}");
            sw.WriteLine($"{ident}AllowOptimizedClip={AllowOptimizedClip}");
            sw.WriteLine($"{ident}FoldMethod={FoldMethod}");
            sw.WriteLine($"{ident}FoldProjection={FoldProjection}");
            sw.WriteLine($"{ident}NumRefCopies={NumRefCopies}");
        }
    }

    public struct MSToolSettings_ClipViewTools
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 4, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 18, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 HideClipElement
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Deprecated
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MaskViewMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 CreateDynamicView
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ClipViewMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved2;

        public MSToolSettings_ClipViewTools Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved2 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}HideClipElement={HideClipElement}");
            sw.WriteLine($"{ident}Deprecated={Deprecated}");
            sw.WriteLine($"{ident}MaskViewMode={MaskViewMode}");
            sw.WriteLine($"{ident}CreateDynamicView={CreateDynamicView}");
            sw.WriteLine($"{ident}ClipViewMode={ClipViewMode}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Reserved2={Reserved2}");
        }
    }

    public struct MSToolSettings_AdditionalRefTools
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 DontMoveBoundary
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MergeRefMaskContents
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PresentationStyle;

        public MSToolSettings_AdditionalRefTools Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            PresentationStyle = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}DontMoveBoundary={DontMoveBoundary}");
            sw.WriteLine($"{ident}MergeRefMaskContents={MergeRefMaskContents}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}PresentationStyle={PresentationStyle}");
        }
    }

    public struct MSToolSettings_GlobalOrigin
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 28, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved2;
        public Dpoint3d Monument;

        public MSToolSettings_GlobalOrigin Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved2 = br.ReadUInt32();
            Monument = new Dpoint3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Reserved2={Reserved2}");
            sw.WriteLine($"{ident}Monument >");
            Monument.Dump(sw, level + 1);
        }
    }

    public struct MSToolSettings
    {
        public MSToolSettings_Mirror Mirror;
        public MSToolSettings_Parallel Parallel;
        public MSToolSettings_Rotate Rotate;
        public MSToolSettings_Change Change;
        public MSToolSettings_Scale Scale;
        public MSToolSettings_Curve Curve;
        public MSToolSettings_General General;
        public MSToolSettings_Array Array;
        public MSToolSettings_ScaleFence ScaleFence;
        public MSToolSettings_RotateFence RotateFence;
        public MSToolSettings_MirrorFence MirrorFence;
        public MSToolSettings_PlaceText PlaceText;
        public MSToolSettings_PlaceNode PlaceNode;
        public MSToolSettings_PlaceCell PlaceCell;
        public MSToolSettings_SelectCell SelectCell;
        public MSToolSettings_Fillet Fillet;
        public MSToolSettings_Parabolic Parabolic;
        public MSToolSettings_ExtendElement ExtendElement;
        public MSToolSettings_ComplexChain ComplexChain;
        public MSToolSettings_ComplexShape ComplexShape;
        public MSToolSettings_LinearPattern LinearPattern;
        public MSToolSettings_AreaPattern AreaPattern;
        public MSToolSettings_MeasureArea MeasureArea;
        public MSToolSettings_MeasureDistance MeasureDistance;
        public MSToolSettings_MeasureProperties MeasureProperties;
        public MSToolSettings_CreateRegion CreateRegion;
        public MSToolSettings_ChangeElement ChangeElement;
        public MSToolSettings_PlaceBlock PlaceBlock;
        public MSToolSettings_PlaceShape PlaceShape;
        public MSToolSettings_PlacePolygon PlacePolygon;
        public MSToolSettings_RenderView RenderView;
        public MSToolSettings_CameraSet CameraSet;
        public MSToolSettings_ConsLineAA ConsLineAA;
        public MSToolSettings_Igen Igen;
        public MSToolSettings_Fence Fence;
        public MSToolSettings_ChangeText ChangeText;
        public MSToolSettings_Font Font;
        public MSToolSettings_Smartline Smartline;
        public MSToolSettings_RefTools RefTools;
        public T_Adouble RegionTextMarginFactor;
        public MSToolSettings_ClipViewTools ClipViewTools;
        public MSToolSettings_AdditionalRefTools AdditionalRefTools;
        public MSToolSettings_GlobalOrigin GlobalOrigin;
        public T_Adouble[] ReservedForFuture;

        public MSToolSettings Read(BinaryReader br)
        {
            // read each field
            Mirror = new MSToolSettings_Mirror().Read(br);
            Parallel = new MSToolSettings_Parallel().Read(br);
            Rotate = new MSToolSettings_Rotate().Read(br);
            Change = new MSToolSettings_Change().Read(br);
            Scale = new MSToolSettings_Scale().Read(br);
            Curve = new MSToolSettings_Curve().Read(br);
            General = new MSToolSettings_General().Read(br);
            Array = new MSToolSettings_Array().Read(br);
            ScaleFence = new MSToolSettings_ScaleFence().Read(br);
            RotateFence = new MSToolSettings_RotateFence().Read(br);
            MirrorFence = new MSToolSettings_MirrorFence().Read(br);
            PlaceText = new MSToolSettings_PlaceText().Read(br);
            PlaceNode = new MSToolSettings_PlaceNode().Read(br);
            PlaceCell = new MSToolSettings_PlaceCell().Read(br);
            SelectCell = new MSToolSettings_SelectCell().Read(br);
            Fillet = new MSToolSettings_Fillet().Read(br);
            Parabolic = new MSToolSettings_Parabolic().Read(br);
            ExtendElement = new MSToolSettings_ExtendElement().Read(br);
            ComplexChain = new MSToolSettings_ComplexChain().Read(br);
            ComplexShape = new MSToolSettings_ComplexShape().Read(br);
            LinearPattern = new MSToolSettings_LinearPattern().Read(br);
            AreaPattern = new MSToolSettings_AreaPattern().Read(br);
            MeasureArea = new MSToolSettings_MeasureArea().Read(br);
            MeasureDistance = new MSToolSettings_MeasureDistance().Read(br);
            MeasureProperties = new MSToolSettings_MeasureProperties().Read(br);
            CreateRegion = new MSToolSettings_CreateRegion().Read(br);
            ChangeElement = new MSToolSettings_ChangeElement().Read(br);
            PlaceBlock = new MSToolSettings_PlaceBlock().Read(br);
            PlaceShape = new MSToolSettings_PlaceShape().Read(br);
            PlacePolygon = new MSToolSettings_PlacePolygon().Read(br);
            RenderView = new MSToolSettings_RenderView().Read(br);
            CameraSet = new MSToolSettings_CameraSet().Read(br);
            ConsLineAA = new MSToolSettings_ConsLineAA().Read(br);
            Igen = new MSToolSettings_Igen().Read(br);
            Fence = new MSToolSettings_Fence().Read(br);
            ChangeText = new MSToolSettings_ChangeText().Read(br);
            Font = new MSToolSettings_Font().Read(br);
            Smartline = new MSToolSettings_Smartline().Read(br);
            RefTools = new MSToolSettings_RefTools().Read(br);
            RegionTextMarginFactor = br.ReadDouble();
            ClipViewTools = new MSToolSettings_ClipViewTools().Read(br);
            AdditionalRefTools = new MSToolSettings_AdditionalRefTools().Read(br);
            GlobalOrigin = new MSToolSettings_GlobalOrigin().Read(br);
            ReservedForFuture = new T_Adouble[32];
            for (int i = 0; i < 32; i++)
            {
                ReservedForFuture[i] = br.ReadDouble();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mirror >");
            Mirror.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Parallel >");
            Parallel.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rotate >");
            Rotate.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Change >");
            Change.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Scale >");
            Scale.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Curve >");
            Curve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}General >");
            General.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Array >");
            Array.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ScaleFence >");
            ScaleFence.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RotateFence >");
            RotateFence.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MirrorFence >");
            MirrorFence.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceText >");
            PlaceText.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceNode >");
            PlaceNode.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceCell >");
            PlaceCell.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SelectCell >");
            SelectCell.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Fillet >");
            Fillet.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Parabolic >");
            Parabolic.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExtendElement >");
            ExtendElement.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComplexChain >");
            ComplexChain.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ComplexShape >");
            ComplexShape.Dump(sw, level + 1);
            sw.WriteLine($"{ident}LinearPattern >");
            LinearPattern.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AreaPattern >");
            AreaPattern.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MeasureArea >");
            MeasureArea.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MeasureDistance >");
            MeasureDistance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MeasureProperties >");
            MeasureProperties.Dump(sw, level + 1);
            sw.WriteLine($"{ident}CreateRegion >");
            CreateRegion.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ChangeElement >");
            ChangeElement.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceBlock >");
            PlaceBlock.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceShape >");
            PlaceShape.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlacePolygon >");
            PlacePolygon.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RenderView >");
            RenderView.Dump(sw, level + 1);
            sw.WriteLine($"{ident}CameraSet >");
            CameraSet.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ConsLineAA >");
            ConsLineAA.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Igen >");
            Igen.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Fence >");
            Fence.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ChangeText >");
            ChangeText.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Font >");
            Font.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Smartline >");
            Smartline.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RefTools >");
            RefTools.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RegionTextMarginFactor={RegionTextMarginFactor}");
            sw.WriteLine($"{ident}ClipViewTools >");
            ClipViewTools.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AdditionalRefTools >");
            AdditionalRefTools.Dump(sw, level + 1);
            sw.WriteLine($"{ident}GlobalOrigin >");
            GlobalOrigin.Dump(sw, level + 1);
            for (int i = 0; i < 32; i++)
            {
                sw.WriteLine($"{ident}ReservedForFuture={ReservedForFuture[i]}");
            }
        }
    }

    public struct MS3DToolSettings_Curve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 9, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 10, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Planar
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PointCurveStream
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ChangeDirMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CurvatureDisplay
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 CurvatureDisplayDensity
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 CurvatureDisplayScale
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 ChangeDirMakeCopy
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public BsplineParam Params;
        public BsplineDisplay Display;

        public MS3DToolSettings_Curve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Params = new BsplineParam().Read(br);
            Display = new BsplineDisplay().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Planar={Planar}");
            sw.WriteLine($"{ident}PointCurveStream={PointCurveStream}");
            sw.WriteLine($"{ident}ChangeDirMode={ChangeDirMode}");
            sw.WriteLine($"{ident}CurvatureDisplay={CurvatureDisplay}");
            sw.WriteLine($"{ident}CurvatureDisplayDensity={CurvatureDisplayDensity}");
            sw.WriteLine($"{ident}CurvatureDisplayScale={CurvatureDisplayScale}");
            sw.WriteLine($"{ident}ChangeDirMakeCopy={ChangeDirMakeCopy}");
            sw.WriteLine($"{ident}Params >");
            Params.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Display >");
            Display.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ChangeCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 2, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 13, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 9, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 Polygon
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Curve
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PreserveShape
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Periodicity
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ReduceMakeCopy
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Curvature
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 PoleNum
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 MakeUniKnotsCopy
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }

        public MS3DToolSettings_ChangeCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Polygon={Polygon}");
            sw.WriteLine($"{ident}Curve={Curve}");
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}PreserveShape={PreserveShape}");
            sw.WriteLine($"{ident}Periodicity={Periodicity}");
            sw.WriteLine($"{ident}ReduceMakeCopy={ReduceMakeCopy}");
            sw.WriteLine($"{ident}Curvature={Curvature}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}PoleNum={PoleNum}");
            sw.WriteLine($"{ident}MakeUniKnotsCopy={MakeUniKnotsCopy}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_MatchCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 2, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 26, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Polygon
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Curve
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Periodicity
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Closed
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_MatchCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Polygon={Polygon}");
            sw.WriteLine($"{ident}Curve={Curve}");
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Periodicity={Periodicity}");
            sw.WriteLine($"{ident}Closed={Closed}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_Conic
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 25, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved1;
        public T_Adouble HyperbolaRho;
        public T_Adouble EllipseRho;

        public MS3DToolSettings_Conic Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            HyperbolaRho = br.ReadDouble();
            EllipseRho = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}HyperbolaRho={HyperbolaRho}");
            sw.WriteLine($"{ident}EllipseRho={EllipseRho}");
        }
    }

    public struct MS3DToolSettings_Spiral
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 23, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Input
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;
        public DegreeOfFreedom StartDegree;
        public DegreeOfFreedom FinalDegree;
        public DegreeOfFreedom StartRadius;
        public DegreeOfFreedom FinalRadius;
        public DegreeOfFreedom Angle;
        public DegreeOfFreedom Length;

        public MS3DToolSettings_Spiral Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            StartDegree = new DegreeOfFreedom().Read(br);
            FinalDegree = new DegreeOfFreedom().Read(br);
            StartRadius = new DegreeOfFreedom().Read(br);
            FinalRadius = new DegreeOfFreedom().Read(br);
            Angle = new DegreeOfFreedom().Read(br);
            Length = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Input={Input}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}StartDegree >");
            StartDegree.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FinalDegree >");
            FinalDegree.Dump(sw, level + 1);
            sw.WriteLine($"{ident}StartRadius >");
            StartRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FinalRadius >");
            FinalRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Angle >");
            Angle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Length >");
            Length.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Helix
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 5, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 5, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 13, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PlanarSurfU
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 PlanarSurfV
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 PlanarSurfPolygon
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom BaseRadius;
        public DegreeOfFreedom TopRadius;
        public DegreeOfFreedom Height;
        public DegreeOfFreedom Pitch;

        public MS3DToolSettings_Helix Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            BaseRadius = new DegreeOfFreedom().Read(br);
            TopRadius = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            Pitch = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}PlanarSurfU={PlanarSurfU}");
            sw.WriteLine($"{ident}PlanarSurfV={PlanarSurfV}");
            sw.WriteLine($"{ident}PlanarSurfPolygon={PlanarSurfPolygon}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}BaseRadius >");
            BaseRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TopRadius >");
            TopRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Pitch >");
            Pitch.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ExtractCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 25, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Smooth
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Param;

        public MS3DToolSettings_ExtractCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Param = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}Smooth={Smooth}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Param >");
            Param.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Block
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 4, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 2, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 3, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SurfHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SurfWidthLocked
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 SurfLenthLocked
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 AxisModeSurf
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SkewedSurf
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SpherePlaceMethod
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 PyramidSurfTopEdgeLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 PyramidSurfBaseEdgeLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 PyramidSolidTopEdgeLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 PyramidSolidBaseEdgeLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 PyramidSurfBaseLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 PyramidSurfBaseWidthLocked
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 PyramidSolidBaseLengthLocked
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 PyramidSolidBaseWidthLocked
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 PyramidSolidRectHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 PyramidSurfRectHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Length;
        public DegreeOfFreedom Width;
        public DegreeOfFreedom Height;

        public MS3DToolSettings_Block Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Length = new DegreeOfFreedom().Read(br);
            Width = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}SurfHeightLocked={SurfHeightLocked}");
            sw.WriteLine($"{ident}SurfWidthLocked={SurfWidthLocked}");
            sw.WriteLine($"{ident}SurfLenthLocked={SurfLenthLocked}");
            sw.WriteLine($"{ident}AxisModeSurf={AxisModeSurf}");
            sw.WriteLine($"{ident}SkewedSurf={SkewedSurf}");
            sw.WriteLine($"{ident}SpherePlaceMethod={SpherePlaceMethod}");
            sw.WriteLine($"{ident}PyramidSurfTopEdgeLengthLocked={PyramidSurfTopEdgeLengthLocked}");
            sw.WriteLine($"{ident}PyramidSurfBaseEdgeLengthLocked={PyramidSurfBaseEdgeLengthLocked}");
            sw.WriteLine($"{ident}PyramidSolidTopEdgeLengthLocked={PyramidSolidTopEdgeLengthLocked}");
            sw.WriteLine($"{ident}PyramidSolidBaseEdgeLengthLocked={PyramidSolidBaseEdgeLengthLocked}");
            sw.WriteLine($"{ident}PyramidSurfBaseLengthLocked={PyramidSurfBaseLengthLocked}");
            sw.WriteLine($"{ident}PyramidSurfBaseWidthLocked={PyramidSurfBaseWidthLocked}");
            sw.WriteLine($"{ident}PyramidSolidBaseLengthLocked={PyramidSolidBaseLengthLocked}");
            sw.WriteLine($"{ident}PyramidSolidBaseWidthLocked={PyramidSolidBaseWidthLocked}");
            sw.WriteLine($"{ident}PyramidSolidRectHeightLocked={PyramidSolidRectHeightLocked}");
            sw.WriteLine($"{ident}PyramidSurfRectHeightLocked={PyramidSurfRectHeightLocked}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Length >");
            Length.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Width >");
            Width.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Sphere
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 16, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 8, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MeshSplitMaxFaces
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MeshSplitMinParts
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PolyhedronRadiusTo
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SphereRadiusOrDiameter
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Radius;

        public MS3DToolSettings_Sphere Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}MeshSplitMaxFaces={MeshSplitMaxFaces}");
            sw.WriteLine($"{ident}MeshSplitMinParts={MeshSplitMinParts}");
            sw.WriteLine($"{ident}PolyhedronRadiusTo={PolyhedronRadiusTo}");
            sw.WriteLine($"{ident}SphereRadiusOrDiameter={SphereRadiusOrDiameter}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Radius >");
            Radius.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Cylinder
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 4, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 2, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 3, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 7, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        public UInt32 SurfHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SurfRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 AxisModeSurf
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SkewedSurf
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 DomePlaceMethod
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 DomeSurfRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 DomeSurfHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 DomeSurfCutOffHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 DomeSurfCutOffRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 PolyhedronFaceNum
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Radius;
        public DegreeOfFreedom Height;

        public MS3DToolSettings_Cylinder Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SurfHeightLocked={SurfHeightLocked}");
            sw.WriteLine($"{ident}SurfRadiusLocked={SurfRadiusLocked}");
            sw.WriteLine($"{ident}AxisModeSurf={AxisModeSurf}");
            sw.WriteLine($"{ident}SkewedSurf={SkewedSurf}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}DomePlaceMethod={DomePlaceMethod}");
            sw.WriteLine($"{ident}DomeSurfRadiusLocked={DomeSurfRadiusLocked}");
            sw.WriteLine($"{ident}DomeSurfHeightLocked={DomeSurfHeightLocked}");
            sw.WriteLine($"{ident}DomeSurfCutOffHeightLocked={DomeSurfCutOffHeightLocked}");
            sw.WriteLine($"{ident}DomeSurfCutOffRadiusLocked={DomeSurfCutOffRadiusLocked}");
            sw.WriteLine($"{ident}PolyhedronFaceNum={PolyhedronFaceNum}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Radius >");
            Radius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Cone
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 6, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 6, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 4, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 4, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 4, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        public UInt32 ConeSurfRight
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ConeRight
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 PyramidSolidSideNum
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PyramidSurfSideNum
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SurfHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 SurfTopRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SurfBaseRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 AxisModeSurf
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SkewedSurf
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom BaseRadius;
        public DegreeOfFreedom TopRadius;
        public DegreeOfFreedom Height;

        public MS3DToolSettings_Cone Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            BaseRadius = new DegreeOfFreedom().Read(br);
            TopRadius = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ConeSurfRight={ConeSurfRight}");
            sw.WriteLine($"{ident}ConeRight={ConeRight}");
            sw.WriteLine($"{ident}PyramidSolidSideNum={PyramidSolidSideNum}");
            sw.WriteLine($"{ident}PyramidSurfSideNum={PyramidSurfSideNum}");
            sw.WriteLine($"{ident}SurfHeightLocked={SurfHeightLocked}");
            sw.WriteLine($"{ident}SurfTopRadiusLocked={SurfTopRadiusLocked}");
            sw.WriteLine($"{ident}SurfBaseRadiusLocked={SurfBaseRadiusLocked}");
            sw.WriteLine($"{ident}AxisModeSurf={AxisModeSurf}");
            sw.WriteLine($"{ident}SkewedSurf={SkewedSurf}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}BaseRadius >");
            BaseRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TopRadius >");
            TopRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Torus
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 4, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 4, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 2, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 11, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        public UInt32 PyramidSurfBaseMethod
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 PyramidSolidBaseMethod
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 SurfAngleLocked
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SurfSecondaryRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SurfPrimaryRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 AxisModeSurf
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 PolySolidPlaceBy
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom PrimaryRadius;
        public DegreeOfFreedom SecondaryRadius;
        public DegreeOfFreedom Angle;

        public MS3DToolSettings_Torus Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            PrimaryRadius = new DegreeOfFreedom().Read(br);
            SecondaryRadius = new DegreeOfFreedom().Read(br);
            Angle = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}PyramidSurfBaseMethod={PyramidSurfBaseMethod}");
            sw.WriteLine($"{ident}PyramidSolidBaseMethod={PyramidSolidBaseMethod}");
            sw.WriteLine($"{ident}SurfAngleLocked={SurfAngleLocked}");
            sw.WriteLine($"{ident}SurfSecondaryRadiusLocked={SurfSecondaryRadiusLocked}");
            sw.WriteLine($"{ident}SurfPrimaryRadiusLocked={SurfPrimaryRadiusLocked}");
            sw.WriteLine($"{ident}AxisModeSurf={AxisModeSurf}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}PolySolidPlaceBy={PolySolidPlaceBy}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}PrimaryRadius >");
            PrimaryRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SecondaryRadius >");
            SecondaryRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Angle >");
            Angle.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Wedge
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 4, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 4, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 4, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 13, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 SurfFlat
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Flat
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 SurfHeightLocked
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SurfAngleLocked
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SurfRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 AxisModeSurf
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 PyramidSurfHeightlocked
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 PyramidHeightlocked
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Radius;
        public DegreeOfFreedom Angle;
        public DegreeOfFreedom Height;

        public MS3DToolSettings_Wedge Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = new DegreeOfFreedom().Read(br);
            Angle = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SurfFlat={SurfFlat}");
            sw.WriteLine($"{ident}Flat={Flat}");
            sw.WriteLine($"{ident}SurfHeightLocked={SurfHeightLocked}");
            sw.WriteLine($"{ident}SurfAngleLocked={SurfAngleLocked}");
            sw.WriteLine($"{ident}SurfRadiusLocked={SurfRadiusLocked}");
            sw.WriteLine($"{ident}AxisModeSurf={AxisModeSurf}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}PyramidSurfHeightlocked={PyramidSurfHeightlocked}");
            sw.WriteLine($"{ident}PyramidHeightlocked={PyramidHeightlocked}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Radius >");
            Radius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Angle >");
            Angle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Extrude
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 2, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 7, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 BothWays
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ActiveAttrib
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SolidSkewed
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SolidIsDist
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SolidIsSpin
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 SolidIsDraft
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 SolidIsXScale
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 SolidIsYScale
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 SolidBothWays
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 SolidActiveAttib
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 SolidKeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 SurfaceCreateBspline
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 NonParametric
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 ThicknessMode
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Distance;
        public DegreeOfFreedom SpinAngle;
        public DegreeOfFreedom DraftAngle;
        public DegreeOfFreedom XScale;
        public DegreeOfFreedom YScale;

        public MS3DToolSettings_Extrude Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance = new DegreeOfFreedom().Read(br);
            SpinAngle = new DegreeOfFreedom().Read(br);
            DraftAngle = new DegreeOfFreedom().Read(br);
            XScale = new DegreeOfFreedom().Read(br);
            YScale = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}BothWays={BothWays}");
            sw.WriteLine($"{ident}ActiveAttrib={ActiveAttrib}");
            sw.WriteLine($"{ident}SolidSkewed={SolidSkewed}");
            sw.WriteLine($"{ident}SolidIsDist={SolidIsDist}");
            sw.WriteLine($"{ident}SolidIsSpin={SolidIsSpin}");
            sw.WriteLine($"{ident}SolidIsDraft={SolidIsDraft}");
            sw.WriteLine($"{ident}SolidIsXScale={SolidIsXScale}");
            sw.WriteLine($"{ident}SolidIsYScale={SolidIsYScale}");
            sw.WriteLine($"{ident}SolidBothWays={SolidBothWays}");
            sw.WriteLine($"{ident}SolidActiveAttib={SolidActiveAttib}");
            sw.WriteLine($"{ident}SolidKeepOriginal={SolidKeepOriginal}");
            sw.WriteLine($"{ident}SurfaceCreateBspline={SurfaceCreateBspline}");
            sw.WriteLine($"{ident}NonParametric={NonParametric}");
            sw.WriteLine($"{ident}ThicknessMode={ThicknessMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SpinAngle >");
            SpinAngle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}DraftAngle >");
            DraftAngle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}XScale >");
            XScale.Dump(sw, level + 1);
            sw.WriteLine($"{ident}YScale >");
            YScale.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Revolve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 4, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 2, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 11, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ActiveAttrib
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SolidMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 SolidKeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SolidActiveAttrib
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SolidAngleLock
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SurfaceCreateBspline
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 NonParametric
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 ThicknessMode
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Angle;

        public MS3DToolSettings_Revolve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Angle = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}ActiveAttrib={ActiveAttrib}");
            sw.WriteLine($"{ident}SolidMode={SolidMode}");
            sw.WriteLine($"{ident}SolidKeepOriginal={SolidKeepOriginal}");
            sw.WriteLine($"{ident}SolidActiveAttrib={SolidActiveAttrib}");
            sw.WriteLine($"{ident}SolidAngleLock={SolidAngleLock}");
            sw.WriteLine($"{ident}SurfaceCreateBspline={SurfaceCreateBspline}");
            sw.WriteLine($"{ident}NonParametric={NonParametric}");
            sw.WriteLine($"{ident}ThicknessMode={ThicknessMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Angle >");
            Angle.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Surface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 20, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 SuppressBSurf
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SuppressBlend
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 DisableCrossingEdge
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public BsplineParam UParams;
        public BsplineParam VParams;
        public BsplineDisplay Display;

        public MS3DToolSettings_Surface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            UParams = new BsplineParam().Read(br);
            VParams = new BsplineParam().Read(br);
            Display = new BsplineDisplay().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}SuppressBSurf={SuppressBSurf}");
            sw.WriteLine($"{ident}SuppressBlend={SuppressBlend}");
            sw.WriteLine($"{ident}DisableCrossingEdge={DisableCrossingEdge}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}UParams >");
            UParams.Dump(sw, level + 1);
            sw.WriteLine($"{ident}VParams >");
            VParams.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Display >");
            Display.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ChangeSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 4, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 2, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 13, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        public UInt32 Polygon
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Curve
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 RulesU
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 RulesV
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 OrderU
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 OrderV
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 PreserveShape
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 PeriodicityU
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 PeriodicityV
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Normal
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 ModifyLock
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 ReverseU
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 ReverseV
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 SwapUV
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }

        public MS3DToolSettings_ChangeSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Polygon={Polygon}");
            sw.WriteLine($"{ident}Curve={Curve}");
            sw.WriteLine($"{ident}RulesU={RulesU}");
            sw.WriteLine($"{ident}RulesV={RulesV}");
            sw.WriteLine($"{ident}OrderU={OrderU}");
            sw.WriteLine($"{ident}OrderV={OrderV}");
            sw.WriteLine($"{ident}PreserveShape={PreserveShape}");
            sw.WriteLine($"{ident}PeriodicityU={PeriodicityU}");
            sw.WriteLine($"{ident}PeriodicityV={PeriodicityV}");
            sw.WriteLine($"{ident}Normal={Normal}");
            sw.WriteLine($"{ident}ModifyLock={ModifyLock}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}ReverseU={ReverseU}");
            sw.WriteLine($"{ident}ReverseV={ReverseV}");
            sw.WriteLine($"{ident}SwapUV={SwapUV}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_MatchSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 24, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 Polygon
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Curve
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 RulesU
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 RulesV
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 OrderU
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 OrderV
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 PeriodicityU
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 PeriodicityV
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }

        public MS3DToolSettings_MatchSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Polygon={Polygon}");
            sw.WriteLine($"{ident}Curve={Curve}");
            sw.WriteLine($"{ident}RulesU={RulesU}");
            sw.WriteLine($"{ident}RulesV={RulesV}");
            sw.WriteLine($"{ident}OrderU={OrderU}");
            sw.WriteLine($"{ident}OrderV={OrderV}");
            sw.WriteLine($"{ident}PeriodicityU={PeriodicityU}");
            sw.WriteLine($"{ident}PeriodicityV={PeriodicityV}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_Section
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 4, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 3, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 5, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Smooth
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 End
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 AlignmentMode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CloseInV
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 FirstConstraint
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 LastConstraint
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 ExtendAdvOptions
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 UnforceStartPoint
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 KeepProfiles
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 SegmentedLoft
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 IsGuideLoft
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 NonParametric
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_Section Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Smooth={Smooth}");
            sw.WriteLine($"{ident}End={End}");
            sw.WriteLine($"{ident}AlignmentMode={AlignmentMode}");
            sw.WriteLine($"{ident}CloseInV={CloseInV}");
            sw.WriteLine($"{ident}FirstConstraint={FirstConstraint}");
            sw.WriteLine($"{ident}LastConstraint={LastConstraint}");
            sw.WriteLine($"{ident}ExtendAdvOptions={ExtendAdvOptions}");
            sw.WriteLine($"{ident}UnforceStartPoint={UnforceStartPoint}");
            sw.WriteLine($"{ident}KeepProfiles={KeepProfiles}");
            sw.WriteLine($"{ident}SegmentedLoft={SegmentedLoft}");
            sw.WriteLine($"{ident}IsGuideLoft={IsGuideLoft}");
            sw.WriteLine($"{ident}NonParametric={NonParametric}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_Tube
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 3, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 3, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 16, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 CuspTreatment
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Rigid
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 MoveByPlaner_Mode
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 MoveByPlaner_makyCopy
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom InsideRadius;
        public DegreeOfFreedom OutsideRadius;
        public DegreeOfFreedom CuspRadius;

        public MS3DToolSettings_Tube Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            InsideRadius = new DegreeOfFreedom().Read(br);
            OutsideRadius = new DegreeOfFreedom().Read(br);
            CuspRadius = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}CuspTreatment={CuspTreatment}");
            sw.WriteLine($"{ident}Rigid={Rigid}");
            sw.WriteLine($"{ident}MoveByPlaner_Mode={MoveByPlaner_Mode}");
            sw.WriteLine($"{ident}MoveByPlaner_makyCopy={MoveByPlaner_makyCopy}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}InsideRadius >");
            InsideRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OutsideRadius >");
            OutsideRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}CuspRadius >");
            CuspRadius.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Skin
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 23, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_Skin Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_Trim
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 8, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 3, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 5, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 9, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ColorOverride
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 StyleOverride
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 WeightOverride
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Style
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Weight
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Trim Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}ColorOverride={ColorOverride}");
            sw.WriteLine($"{ident}StyleOverride={StyleOverride}");
            sw.WriteLine($"{ident}WeightOverride={WeightOverride}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_BooleanOp
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 3, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 3, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 12, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MeshKeepContours
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MeshKeepXYPoints
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 MeshContoursExpand
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 MeshXYPointsExpand
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 MeshProjectReverse2
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MeshProjectDirMode
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 MeshGridCloseU
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 MeshGridCloseV
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 MeshHasContraints
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 MeshFromPointsDirMode
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_BooleanOp Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}MeshKeepContours={MeshKeepContours}");
            sw.WriteLine($"{ident}MeshKeepXYPoints={MeshKeepXYPoints}");
            sw.WriteLine($"{ident}MeshContoursExpand={MeshContoursExpand}");
            sw.WriteLine($"{ident}MeshXYPointsExpand={MeshXYPointsExpand}");
            sw.WriteLine($"{ident}MeshProjectReverse2={MeshProjectReverse2}");
            sw.WriteLine($"{ident}MeshProjectDirMode={MeshProjectDirMode}");
            sw.WriteLine($"{ident}MeshGridCloseU={MeshGridCloseU}");
            sw.WriteLine($"{ident}MeshGridCloseV={MeshGridCloseV}");
            sw.WriteLine($"{ident}MeshHasContraints={MeshHasContraints}");
            sw.WriteLine($"{ident}MeshFromPointsDirMode={MeshFromPointsDirMode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_FilletSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 22, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Trim
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Radius1;
        public DegreeOfFreedom Radius2;
        public DegreeOfFreedom StartRadius;
        public DegreeOfFreedom FinalRadius;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_FilletSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius1 = new DegreeOfFreedom().Read(br);
            Radius2 = new DegreeOfFreedom().Read(br);
            StartRadius = new DegreeOfFreedom().Read(br);
            FinalRadius = new DegreeOfFreedom().Read(br);
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Trim={Trim}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Radius1 >");
            Radius1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Radius2 >");
            Radius2.Dump(sw, level + 1);
            sw.WriteLine($"{ident}StartRadius >");
            StartRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FinalRadius >");
            FinalRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_FilletCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 22, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Trim
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Radius1;
        public DegreeOfFreedom Radius2;

        public MS3DToolSettings_FilletCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius1 = new DegreeOfFreedom().Read(br);
            Radius2 = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Trim={Trim}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Radius1 >");
            Radius1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Radius2 >");
            Radius2.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_BlendCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 3, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 3, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 18, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Continuity
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DropMakeCopy
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DropExtractBound
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DropMethod
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 DropType
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public T_Adouble Factor1;
        public T_Adouble Factor2;

        public MS3DToolSettings_BlendCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Factor1 = br.ReadDouble();
            Factor2 = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Continuity={Continuity}");
            sw.WriteLine($"{ident}DropMakeCopy={DropMakeCopy}");
            sw.WriteLine($"{ident}DropExtractBound={DropExtractBound}");
            sw.WriteLine($"{ident}DropMethod={DropMethod}");
            sw.WriteLine($"{ident}DropType={DropType}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Factor1={Factor1}");
            sw.WriteLine($"{ident}Factor2={Factor2}");
        }
    }

    public struct MS3DToolSettings_BlendSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 6, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 6, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 6, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 2, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 3, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 Continuity
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Continuity1
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DropNumURules
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DropNumVRules
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ReverseDirection1
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ReverseDirection2
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 DynamicSelect
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved1;
        public T_Adouble Factor1;
        public T_Adouble Factor2;

        public MS3DToolSettings_BlendSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Factor1 = br.ReadDouble();
            Factor2 = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Continuity={Continuity}");
            sw.WriteLine($"{ident}Continuity1={Continuity1}");
            sw.WriteLine($"{ident}DropNumURules={DropNumURules}");
            sw.WriteLine($"{ident}DropNumVRules={DropNumVRules}");
            sw.WriteLine($"{ident}ReverseDirection1={ReverseDirection1}");
            sw.WriteLine($"{ident}ReverseDirection2={ReverseDirection2}");
            sw.WriteLine($"{ident}DynamicSelect={DynamicSelect}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Factor1={Factor1}");
            sw.WriteLine($"{ident}Factor2={Factor2}");
        }
    }

    public struct MS3DToolSettings_Rails
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 20, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Continuity
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DropNumPoints
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 TrimBlendType
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 TrimWallType
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Rails Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Continuity={Continuity}");
            sw.WriteLine($"{ident}DropNumPoints={DropNumPoints}");
            sw.WriteLine($"{ident}TrimBlendType={TrimBlendType}");
            sw.WriteLine($"{ident}TrimWallType={TrimWallType}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Punch
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 18, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 Effect
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Capped
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 CapMode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Range;
        public DegreeOfFreedom Distance;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Punch Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Range = new DegreeOfFreedom().Read(br);
            Distance = new DegreeOfFreedom().Read(br);
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Effect={Effect}");
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}Capped={Capped}");
            sw.WriteLine($"{ident}CapMode={CapMode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Range >");
            Range.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Impose
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 26, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Nohole
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 CutDir
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Impose Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}Nohole={Nohole}");
            sw.WriteLine($"{ident}CutDir={CutDir}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Reduce
    {
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Reduce Read(BinaryReader br)
        {
            // read each field
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ExtendCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 16, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 10, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public T_Adouble Scale;

        public MS3DToolSettings_ExtendCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Scale = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Scale={Scale}");
        }
    }

    public struct MS3DToolSettings_ExtendSurface
    {
        public Int32 Order;
        public UInt32 Reserved1;
        public T_Adouble Scale;

        public MS3DToolSettings_ExtendSurface Read(BinaryReader br)
        {
            // read each field
            Order = br.ReadInt32();
            Reserved1 = br.ReadUInt32();
            Scale = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Scale={Scale}");
        }
    }

    public struct MS3DToolSettings_DeleteBound
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 16, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Infinite
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Extended
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 OutputType
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 OutputEnabled
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 AssembleSeg
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 InteractivePositioning
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 FlattenSection
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 ApplyActiveScaleAndAngle
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 RotateToView
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 UseActiveSymbology
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_DeleteBound Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Infinite={Infinite}");
            sw.WriteLine($"{ident}Extended={Extended}");
            sw.WriteLine($"{ident}OutputType={OutputType}");
            sw.WriteLine($"{ident}OutputEnabled={OutputEnabled}");
            sw.WriteLine($"{ident}AssembleSeg={AssembleSeg}");
            sw.WriteLine($"{ident}InteractivePositioning={InteractivePositioning}");
            sw.WriteLine($"{ident}FlattenSection={FlattenSection}");
            sw.WriteLine($"{ident}ApplyActiveScaleAndAngle={ApplyActiveScaleAndAngle}");
            sw.WriteLine($"{ident}RotateToView={RotateToView}");
            sw.WriteLine($"{ident}UseActiveSymbology={UseActiveSymbology}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_Convert
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 18, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Shape
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 KeepOriginalSolid
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ConvertToSolid
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 KeepOriginalSurface
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ConvertToSurface
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MergeInToSingleSurface
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 KeepOriginalCurve
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Convert Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Shape={Shape}");
            sw.WriteLine($"{ident}KeepOriginalSolid={KeepOriginalSolid}");
            sw.WriteLine($"{ident}ConvertToSolid={ConvertToSolid}");
            sw.WriteLine($"{ident}KeepOriginalSurface={KeepOriginalSurface}");
            sw.WriteLine($"{ident}ConvertToSurface={ConvertToSurface}");
            sw.WriteLine($"{ident}MergeInToSingleSurface={MergeInToSingleSurface}");
            sw.WriteLine($"{ident}KeepOriginalCurve={KeepOriginalCurve}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ChangeCap
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 28, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_ChangeCap Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Chamfer
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 22, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Trim
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Distance1;
        public DegreeOfFreedom Distance2;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_Chamfer Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance1 = new DegreeOfFreedom().Read(br);
            Distance2 = new DegreeOfFreedom().Read(br);
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Trim={Trim}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance1 >");
            Distance1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance2 >");
            Distance2.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_OffsetCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 15, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 2, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 6, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 CuspTreatment
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ActiveSymb
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 NumCopy
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Partial
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ResultType
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 PartialCurve
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Segment
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;
        public DegreeOfFreedom Distance;

        public MS3DToolSettings_OffsetCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            Distance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}CuspTreatment={CuspTreatment}");
            sw.WriteLine($"{ident}ActiveSymb={ActiveSymb}");
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}NumCopy={NumCopy}");
            sw.WriteLine($"{ident}Partial={Partial}");
            sw.WriteLine($"{ident}ResultType={ResultType}");
            sw.WriteLine($"{ident}PartialCurve={PartialCurve}");
            sw.WriteLine($"{ident}Segment={Segment}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_OffsetSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;
        public DegreeOfFreedom Distance;

        public MS3DToolSettings_OffsetSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            Distance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_HelicalSolid
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 3, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 21, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Method
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 HelixType
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 PitchType
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom BaseRadius;
        public DegreeOfFreedom TopRadius;
        public DegreeOfFreedom Height;
        public DegreeOfFreedom Pitch;

        public MS3DToolSettings_HelicalSolid Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            BaseRadius = new DegreeOfFreedom().Read(br);
            TopRadius = new DegreeOfFreedom().Read(br);
            Height = new DegreeOfFreedom().Read(br);
            Pitch = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Method={Method}");
            sw.WriteLine($"{ident}HelixType={HelixType}");
            sw.WriteLine($"{ident}PitchType={PitchType}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}BaseRadius >");
            BaseRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TopRadius >");
            TopRadius.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Height >");
            Height.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Pitch >");
            Pitch.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_FlattenCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 25, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_FlattenCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MS3DToolSettings_PlaceCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 3, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 22, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 TangentControl
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MaintainTangents
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 PassEnd
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Advanced
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public T_Adouble Tolerance;
        public DegreeOfFreedom FitLength;
        public DegreeOfFreedom FitAngle;

        public MS3DToolSettings_PlaceCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = br.ReadDouble();
            FitLength = new DegreeOfFreedom().Read(br);
            FitAngle = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}TangentControl={TangentControl}");
            sw.WriteLine($"{ident}MaintainTangents={MaintainTangents}");
            sw.WriteLine($"{ident}PassEnd={PassEnd}");
            sw.WriteLine($"{ident}Advanced={Advanced}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
            sw.WriteLine($"{ident}FitLength >");
            FitLength.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FitAngle >");
            FitAngle.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_HelixCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 5, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 5, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 22, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 HelixType
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 PitchType
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved1;
        public T_Adouble Tolerance;

        public MS3DToolSettings_HelixCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}HelixType={HelixType}");
            sw.WriteLine($"{ident}PitchType={PitchType}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
        }
    }

    public struct MS3DToolSettings_SweetenCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 13, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 12, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 MaintainTangent
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MaintainSharp
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;

        public MS3DToolSettings_SweetenCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MaintainTangent={MaintainTangent}");
            sw.WriteLine($"{ident}MaintainSharp={MaintainSharp}");
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_SweetenSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 13, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 13, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 UNumPoles
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 VNumPoles
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved1;
        public T_Adouble Tolerance;

        public MS3DToolSettings_SweetenSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}UNumPoles={UNumPoles}");
            sw.WriteLine($"{ident}VNumPoles={VNumPoles}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
        }
    }

    public struct MS3DToolSettings_ReduceSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 13, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 13, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 5, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 UNumRuleLines
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 VNumRuleLines
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public T_Adouble Tolerance;

        public MS3DToolSettings_ReduceSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}UNumRuleLines={UNumRuleLines}");
            sw.WriteLine($"{ident}VNumRuleLines={VNumRuleLines}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
        }
    }

    public struct MS3DToolSettings_CurveEvaluator
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 21, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 OutputMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 InputMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 ShowPoints
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ShowTangents
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ShowRadius
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ShowInflection
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 ShowPlane
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 ShowCusps
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public Int32 NumPoints;
        public T_Adouble Parameter;
        public T_Adouble DistAlong;
        public T_Adouble CurvatureScale;
        public T_Adouble TangentScale;
        public T_Adouble Radius;

        public MS3DToolSettings_CurveEvaluator Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            NumPoints = br.ReadInt32();
            Parameter = br.ReadDouble();
            DistAlong = br.ReadDouble();
            CurvatureScale = br.ReadDouble();
            TangentScale = br.ReadDouble();
            Radius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}OutputMode={OutputMode}");
            sw.WriteLine($"{ident}InputMode={InputMode}");
            sw.WriteLine($"{ident}ShowPoints={ShowPoints}");
            sw.WriteLine($"{ident}ShowTangents={ShowTangents}");
            sw.WriteLine($"{ident}ShowRadius={ShowRadius}");
            sw.WriteLine($"{ident}ShowInflection={ShowInflection}");
            sw.WriteLine($"{ident}ShowPlane={ShowPlane}");
            sw.WriteLine($"{ident}ShowCusps={ShowCusps}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}NumPoints={NumPoints}");
            sw.WriteLine($"{ident}Parameter={Parameter}");
            sw.WriteLine($"{ident}DistAlong={DistAlong}");
            sw.WriteLine($"{ident}CurvatureScale={CurvatureScale}");
            sw.WriteLine($"{ident}TangentScale={TangentScale}");
            sw.WriteLine($"{ident}Radius={Radius}");
        }
    }

    public struct MS3DToolSettings_SurfaceEvaluator
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 3, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 8, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 8, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 7, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 OutputMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 InputMode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 ShowPoints
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ShowTangents
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ShowNormal
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ShowPorcupine
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 NumUSample
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 NumVSample
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public Int32 NumUPoints;
        public Int32 NumVPoints;
        public UInt32 Reserved1;
        public T_Adouble DistUAlong;
        public T_Adouble DistVAlong;
        public T_Adouble UParam;
        public T_Adouble VParam;
        public T_Adouble NormalScale;
        public T_Adouble TangentScale;

        public MS3DToolSettings_SurfaceEvaluator Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            NumUPoints = br.ReadInt32();
            NumVPoints = br.ReadInt32();
            Reserved1 = br.ReadUInt32();
            DistUAlong = br.ReadDouble();
            DistVAlong = br.ReadDouble();
            UParam = br.ReadDouble();
            VParam = br.ReadDouble();
            NormalScale = br.ReadDouble();
            TangentScale = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}OutputMode={OutputMode}");
            sw.WriteLine($"{ident}InputMode={InputMode}");
            sw.WriteLine($"{ident}ShowPoints={ShowPoints}");
            sw.WriteLine($"{ident}ShowTangents={ShowTangents}");
            sw.WriteLine($"{ident}ShowNormal={ShowNormal}");
            sw.WriteLine($"{ident}ShowPorcupine={ShowPorcupine}");
            sw.WriteLine($"{ident}NumUSample={NumUSample}");
            sw.WriteLine($"{ident}NumVSample={NumVSample}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}NumUPoints={NumUPoints}");
            sw.WriteLine($"{ident}NumVPoints={NumVPoints}");
            sw.WriteLine($"{ident}DistUAlong={DistUAlong}");
            sw.WriteLine($"{ident}DistVAlong={DistVAlong}");
            sw.WriteLine($"{ident}UParam={UParam}");
            sw.WriteLine($"{ident}VParam={VParam}");
            sw.WriteLine($"{ident}NormalScale={NormalScale}");
            sw.WriteLine($"{ident}TangentScale={TangentScale}");
        }
    }

    public struct MS3DToolSettings_TrimCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 5, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 5, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 5, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 2, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 3, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        public UInt32 TrimMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 AutoChain
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MeshBoolean2ndAsTrimmer
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 MeshBooleanType
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 MeshCreateType
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 MeshModifyType
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MeshMergeFacetsMode
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 MeshSplitKeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 MeshUnfoldKeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 MeshSplitMode
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 MeshMergeCoplanarFaces
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 MeshMergeCoplanarEdges
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 MeshMergeSmallEdges
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }

        public MS3DToolSettings_TrimCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}TrimMode={TrimMode}");
            sw.WriteLine($"{ident}AutoChain={AutoChain}");
            sw.WriteLine($"{ident}MeshBoolean2ndAsTrimmer={MeshBoolean2ndAsTrimmer}");
            sw.WriteLine($"{ident}MeshBooleanType={MeshBooleanType}");
            sw.WriteLine($"{ident}MeshCreateType={MeshCreateType}");
            sw.WriteLine($"{ident}MeshModifyType={MeshModifyType}");
            sw.WriteLine($"{ident}MeshMergeFacetsMode={MeshMergeFacetsMode}");
            sw.WriteLine($"{ident}MeshSplitKeepOriginal={MeshSplitKeepOriginal}");
            sw.WriteLine($"{ident}MeshUnfoldKeepOriginal={MeshUnfoldKeepOriginal}");
            sw.WriteLine($"{ident}MeshSplitMode={MeshSplitMode}");
            sw.WriteLine($"{ident}MeshMergeCoplanarFaces={MeshMergeCoplanarFaces}");
            sw.WriteLine($"{ident}MeshMergeCoplanarEdges={MeshMergeCoplanarEdges}");
            sw.WriteLine($"{ident}MeshMergeSmallEdges={MeshMergeSmallEdges}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MS3DToolSettings_JoinCurve
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 25, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 AutoChain
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ChangeBoth
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 JoinMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public MS3DToolSettings_JoinCurve Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AutoChain={AutoChain}");
            sw.WriteLine($"{ident}ChangeBoth={ChangeBoth}");
            sw.WriteLine($"{ident}JoinMode={JoinMode}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MS3DToolSettings_ExtractCurveNew
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 28, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 ExtractMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 ExtractBound
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public Int32 UNum;
        public Int32 VNum;

        public MS3DToolSettings_ExtractCurveNew Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            UNum = br.ReadInt32();
            VNum = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ExtractMode={ExtractMode}");
            sw.WriteLine($"{ident}ExtractBound={ExtractBound}");
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}UNum={UNum}");
            sw.WriteLine($"{ident}VNum={VNum}");
        }
    }

    public struct MS3DToolSettings_EdgeSurface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 27, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MeshToSurfKeepOrigial
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 RestoreHidingEdges
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public MS3DToolSettings_EdgeSurface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}MeshToSurfKeepOrigial={MeshToSurfKeepOrigial}");
            sw.WriteLine($"{ident}RestoreHidingEdges={RestoreHidingEdges}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MS3DToolSettings_VectorInterpolation
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 24, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Order
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 AllowSelectAgain
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Closed
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_VectorInterpolation Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Order={Order}");
            sw.WriteLine($"{ident}AllowSelectAgain={AllowSelectAgain}");
            sw.WriteLine($"{ident}Closed={Closed}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MS3DToolSettings_RigidSweep
    {
        public T_Adouble XScale;
        public T_Adouble YScale;
        public T_Adouble Spin;
        public T_Adouble Tolerance;

        public MS3DToolSettings_RigidSweep Read(BinaryReader br)
        {
            // read each field
            XScale = br.ReadDouble();
            YScale = br.ReadDouble();
            Spin = br.ReadDouble();
            Tolerance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}XScale={XScale}");
            sw.WriteLine($"{ident}YScale={YScale}");
            sw.WriteLine($"{ident}Spin={Spin}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
        }
    }

    public struct MS3DToolSettings_TwoTraceSweep
    {
        private UInt32 Data1;
        private const int sz_1_0 = 6, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 2, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 3, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 12, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Scale
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 ScaleHeight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 KeepTrace
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 KeepSection
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Alignment
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 FirstConstraint
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 LastConstraint
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 KeepCurves
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 SelfRepair
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved1;

        public MS3DToolSettings_TwoTraceSweep Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Scale={Scale}");
            sw.WriteLine($"{ident}ScaleHeight={ScaleHeight}");
            sw.WriteLine($"{ident}KeepTrace={KeepTrace}");
            sw.WriteLine($"{ident}KeepSection={KeepSection}");
            sw.WriteLine($"{ident}Alignment={Alignment}");
            sw.WriteLine($"{ident}FirstConstraint={FirstConstraint}");
            sw.WriteLine($"{ident}LastConstraint={LastConstraint}");
            sw.WriteLine($"{ident}KeepCurves={KeepCurves}");
            sw.WriteLine($"{ident}SelfRepair={SelfRepair}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct MS3DToolSettings_ObsoleteOffsetCurve
    {
        public DegreeOfFreedom Tolerance;
        public DegreeOfFreedom Distance;

        public MS3DToolSettings_ObsoleteOffsetCurve Read(BinaryReader br)
        {
            // read each field
            Tolerance = new DegreeOfFreedom().Read(br);
            Distance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_ObsoleteOffsetSurface
    {
        public DegreeOfFreedom Tolerance;
        public DegreeOfFreedom Distance;

        public MS3DToolSettings_ObsoleteOffsetSurface Read(BinaryReader br)
        {
            // read each field
            Tolerance = new DegreeOfFreedom().Read(br);
            Distance = new DegreeOfFreedom().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Distance >");
            Distance.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings_Facet
    {
        private UInt32 Data1;
        private const int sz_1_0 = 10, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 3, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 3, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 2, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 2, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 2, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        public UInt32 MaxSides
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 OutputMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 LockChordTol
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 LockAngleTol
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 LockMaxEdgeLength
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 LockMaxSides
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 DecimateFixBnd
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SubtractSplit
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 TrimMode
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 TrimKeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 UniteKeepOriginals
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 BoolReverse1
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 BoolReverse2
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 IntersectKeepOriginals
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 SubtractKeepOriginals
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 Reserved1;
        public T_Adouble MaxEdgeLength;
        public T_Adouble ChordTol;
        public T_Adouble AngleTol;

        public MS3DToolSettings_Facet Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            MaxEdgeLength = br.ReadDouble();
            ChordTol = br.ReadDouble();
            AngleTol = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MaxSides={MaxSides}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}OutputMode={OutputMode}");
            sw.WriteLine($"{ident}LockChordTol={LockChordTol}");
            sw.WriteLine($"{ident}LockAngleTol={LockAngleTol}");
            sw.WriteLine($"{ident}LockMaxEdgeLength={LockMaxEdgeLength}");
            sw.WriteLine($"{ident}LockMaxSides={LockMaxSides}");
            sw.WriteLine($"{ident}DecimateFixBnd={DecimateFixBnd}");
            sw.WriteLine($"{ident}SubtractSplit={SubtractSplit}");
            sw.WriteLine($"{ident}TrimMode={TrimMode}");
            sw.WriteLine($"{ident}TrimKeepOriginal={TrimKeepOriginal}");
            sw.WriteLine($"{ident}UniteKeepOriginals={UniteKeepOriginals}");
            sw.WriteLine($"{ident}BoolReverse1={BoolReverse1}");
            sw.WriteLine($"{ident}BoolReverse2={BoolReverse2}");
            sw.WriteLine($"{ident}IntersectKeepOriginals={IntersectKeepOriginals}");
            sw.WriteLine($"{ident}SubtractKeepOriginals={SubtractKeepOriginals}");
            sw.WriteLine($"{ident}MaxEdgeLength={MaxEdgeLength}");
            sw.WriteLine($"{ident}ChordTol={ChordTol}");
            sw.WriteLine($"{ident}AngleTol={AngleTol}");
        }
    }

    public struct SmartSolidSettings_Solid
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 2, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 3, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 13, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 UniteKeep
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DiffKeep
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 IntKeep
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 ConvertType
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 DisplayModelerWarning
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 RepresentAsSurfaces
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 QvOptions
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 UniteAssociative
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 DiffAssociative
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 IntAssociative
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }

        public SmartSolidSettings_Solid Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}UniteKeep={UniteKeep}");
            sw.WriteLine($"{ident}DiffKeep={DiffKeep}");
            sw.WriteLine($"{ident}IntKeep={IntKeep}");
            sw.WriteLine($"{ident}ConvertType={ConvertType}");
            sw.WriteLine($"{ident}DisplayModelerWarning={DisplayModelerWarning}");
            sw.WriteLine($"{ident}RepresentAsSurfaces={RepresentAsSurfaces}");
            sw.WriteLine($"{ident}QvOptions={QvOptions}");
            sw.WriteLine($"{ident}UniteAssociative={UniteAssociative}");
            sw.WriteLine($"{ident}DiffAssociative={DiffAssociative}");
            sw.WriteLine($"{ident}IntAssociative={IntAssociative}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct SmartSolidSettings_Surface
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 4, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 4, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 14, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        public UInt32 IntCurve
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 TrimFirst
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 TrimSecond
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 FlipFirst
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 FlipSecond
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 KeepSecond
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 KeepFirst
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SaveSolid
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 RemoveSingle
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 UntrimMode
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 RemoveFaceSmooth
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 ConvertToBspline
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }

        public SmartSolidSettings_Surface Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}IntCurve={IntCurve}");
            sw.WriteLine($"{ident}TrimFirst={TrimFirst}");
            sw.WriteLine($"{ident}TrimSecond={TrimSecond}");
            sw.WriteLine($"{ident}FlipFirst={FlipFirst}");
            sw.WriteLine($"{ident}FlipSecond={FlipSecond}");
            sw.WriteLine($"{ident}KeepSecond={KeepSecond}");
            sw.WriteLine($"{ident}KeepFirst={KeepFirst}");
            sw.WriteLine($"{ident}SaveSolid={SaveSolid}");
            sw.WriteLine($"{ident}RemoveSingle={RemoveSingle}");
            sw.WriteLine($"{ident}UntrimMode={UntrimMode}");
            sw.WriteLine($"{ident}RemoveFaceSmooth={RemoveFaceSmooth}");
            sw.WriteLine($"{ident}ConvertToBspline={ConvertToBspline}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct SmartSolidSettings_Punch
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 4, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 20, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SaveSolid
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 ConvertToBspline
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 IsBidirectional
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public SmartSolidSettings_Punch Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}SaveSolid={SaveSolid}");
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}ConvertToBspline={ConvertToBspline}");
            sw.WriteLine($"{ident}IsBidirectional={IsBidirectional}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct SmartSolidSettings_Cut
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 2, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 23, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private UInt32 Data2;
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 SplitOnly
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Direction
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DepthMode
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Local
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 LockDepth
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SmartFeatureProfile
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public T_Adouble Depth;

        public SmartSolidSettings_Cut Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Data2 = br.ReadUInt32();
            Depth = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}SplitOnly={SplitOnly}");
            sw.WriteLine($"{ident}Direction={Direction}");
            sw.WriteLine($"{ident}DepthMode={DepthMode}");
            sw.WriteLine($"{ident}Local={Local}");
            sw.WriteLine($"{ident}LockDepth={LockDepth}");
            sw.WriteLine($"{ident}SmartFeatureProfile={SmartFeatureProfile}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Depth={Depth}");
        }
    }

    public struct SmartSolidSettings_Hollow
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Outward
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 UnlockedOffset
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved1;
        public T_Adouble Offset;

        public SmartSolidSettings_Hollow Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Offset = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Outward={Outward}");
            sw.WriteLine($"{ident}UnlockedOffset={UnlockedOffset}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Offset={Offset}");
        }
    }

    public struct SmartSolidSettings_Thicken
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 23, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt32 LockThickness
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Side
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 MakeThickenCopy
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 MakeOffsetCopy
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 LockDistance
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 PickThickenFace
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 PickOffsetFace
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 FullDynamic
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 Reserved1;
        public T_Adouble Thickness;

        public SmartSolidSettings_Thicken Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Thickness = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}LockThickness={LockThickness}");
            sw.WriteLine($"{ident}Side={Side}");
            sw.WriteLine($"{ident}MakeThickenCopy={MakeThickenCopy}");
            sw.WriteLine($"{ident}MakeOffsetCopy={MakeOffsetCopy}");
            sw.WriteLine($"{ident}LockDistance={LockDistance}");
            sw.WriteLine($"{ident}PickThickenFace={PickThickenFace}");
            sw.WriteLine($"{ident}PickOffsetFace={PickOffsetFace}");
            sw.WriteLine($"{ident}FullDynamic={FullDynamic}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Thickness={Thickness}");
        }
    }

    public struct SmartSolidSettings_Stretch
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 16, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 11, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 Lock
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 MaxFace
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 AdvOpt
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Extend
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 RealTime
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Simplify
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved1;
        public T_Adouble Distance;

        public SmartSolidSettings_Stretch Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Lock={Lock}");
            sw.WriteLine($"{ident}MaxFace={MaxFace}");
            sw.WriteLine($"{ident}AdvOpt={AdvOpt}");
            sw.WriteLine($"{ident}Extend={Extend}");
            sw.WriteLine($"{ident}RealTime={RealTime}");
            sw.WriteLine($"{ident}Simplify={Simplify}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance={Distance}");
        }
    }

    public struct SmartSolidSettings_Move
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Lock
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public T_Adouble Distance;

        public SmartSolidSettings_Move Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Lock={Lock}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance={Distance}");
        }
    }

    public struct SmartSolidSettings_Display
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 ExpandList
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;

        public SmartSolidSettings_Display Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ExpandList={ExpandList}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct SmartSolidSettings_Extend
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 26, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 DistLock
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 OutBoundary
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 RebuildSurface
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved1;
        public T_Adouble Distance;
        public T_Adouble Angle;

        public SmartSolidSettings_Extend Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance = br.ReadDouble();
            Angle = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}DistLock={DistLock}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}OutBoundary={OutBoundary}");
            sw.WriteLine($"{ident}RebuildSurface={RebuildSurface}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance={Distance}");
            sw.WriteLine($"{ident}Angle={Angle}");
        }
    }

    public struct SmartSolidSettings_Intersect
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 30, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Point
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Normal
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public SmartSolidSettings_Intersect Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Point={Point}");
            sw.WriteLine($"{ident}Normal={Normal}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct SmartSolidSettings_Extract_Overrides
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 25, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        public UInt32 FaceEdge
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Weight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Style
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Level
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 ToFile
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }

        public SmartSolidSettings_Extract_Overrides Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}FaceEdge={FaceEdge}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Level={Level}");
            sw.WriteLine($"{ident}ToFile={ToFile}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct SmartSolidSettings_Extract
    {
        public SmartSolidSettings_Extract_Overrides Overrides;
        public UInt32 Color;
        public UInt32 Weight;
        public UInt32 Style;
        public UInt32 Level;

        public SmartSolidSettings_Extract Read(BinaryReader br)
        {
            // read each field
            Overrides = new SmartSolidSettings_Extract_Overrides().Read(br);
            Color = br.ReadUInt32();
            Weight = br.ReadUInt32();
            Style = br.ReadUInt32();
            Level = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Overrides >");
            Overrides.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Level={Level}");
        }
    }

    public struct SmartSolidSettings_Tube
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 3, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 3, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 1, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        private const int sz_1_22 = 1, loc_1_22 = loc_1_21 + sz_1_21, mask_1_22 = unchecked(((1 << sz_1_22) - 1) << loc_1_22);
        private const int sz_1_23 = 2, loc_1_23 = loc_1_22 + sz_1_22, mask_1_23 = unchecked(((1 << sz_1_23) - 1) << loc_1_23);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 OutsideLocked
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 InsideLocked
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Align
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Attach
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 UseBspline
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SolidKeepPath
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SolidKeepProfile
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 SolidScale
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 SolidLockDir
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 SolidSpin
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 SurfaceKeepPath
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 SurfaceKeepProfile
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 SurfaceAlign
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 SurfaceScale
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 SurfaceSpin
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 SurfaceLockDir
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 SurfaceMode
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 SurfaceRadiusLocked
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 SurfaceRepair
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 SolidRepair
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }
        public UInt32 CheckResult
        {
            get => (UInt32)(Data1 & mask_1_22) >> loc_1_22;
            set => Data1 = (UInt32)(Data1 & ~mask_1_22 | (value << loc_1_22) & mask_1_22);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_23) >> loc_1_23;
            set => Data1 = (UInt32)(Data1 & ~mask_1_23 | (value << loc_1_23) & mask_1_23);
        }
        public UInt32 Reserved1;
        public T_Adouble InsideRadius;
        public T_Adouble OutsideRadius;

        public SmartSolidSettings_Tube Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            InsideRadius = br.ReadDouble();
            OutsideRadius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}OutsideLocked={OutsideLocked}");
            sw.WriteLine($"{ident}InsideLocked={InsideLocked}");
            sw.WriteLine($"{ident}Align={Align}");
            sw.WriteLine($"{ident}Attach={Attach}");
            sw.WriteLine($"{ident}UseBspline={UseBspline}");
            sw.WriteLine($"{ident}SolidKeepPath={SolidKeepPath}");
            sw.WriteLine($"{ident}SolidKeepProfile={SolidKeepProfile}");
            sw.WriteLine($"{ident}SolidScale={SolidScale}");
            sw.WriteLine($"{ident}SolidLockDir={SolidLockDir}");
            sw.WriteLine($"{ident}SolidSpin={SolidSpin}");
            sw.WriteLine($"{ident}SurfaceKeepPath={SurfaceKeepPath}");
            sw.WriteLine($"{ident}SurfaceKeepProfile={SurfaceKeepProfile}");
            sw.WriteLine($"{ident}SurfaceAlign={SurfaceAlign}");
            sw.WriteLine($"{ident}SurfaceScale={SurfaceScale}");
            sw.WriteLine($"{ident}SurfaceSpin={SurfaceSpin}");
            sw.WriteLine($"{ident}SurfaceLockDir={SurfaceLockDir}");
            sw.WriteLine($"{ident}SurfaceMode={SurfaceMode}");
            sw.WriteLine($"{ident}SurfaceRadiusLocked={SurfaceRadiusLocked}");
            sw.WriteLine($"{ident}SurfaceRepair={SurfaceRepair}");
            sw.WriteLine($"{ident}SolidRepair={SolidRepair}");
            sw.WriteLine($"{ident}CheckResult={CheckResult}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}InsideRadius={InsideRadius}");
            sw.WriteLine($"{ident}OutsideRadius={OutsideRadius}");
        }
    }

    public struct SmartSolidSettings_Skin
    {
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 16, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Skewed
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 SolidJoinUnit
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 SolidJoinTrimFirst
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 SolidJoinTrimSecond
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 SolidJoinFlipFirst
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 SolidJoinFlipSecond
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 SolidJoinKeepFirst
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 SolidJoinKeepSecond
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Reserved1;

        public SmartSolidSettings_Skin Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Skewed={Skewed}");
            sw.WriteLine($"{ident}SolidJoinUnit={SolidJoinUnit}");
            sw.WriteLine($"{ident}SolidJoinTrimFirst={SolidJoinTrimFirst}");
            sw.WriteLine($"{ident}SolidJoinTrimSecond={SolidJoinTrimSecond}");
            sw.WriteLine($"{ident}SolidJoinFlipFirst={SolidJoinFlipFirst}");
            sw.WriteLine($"{ident}SolidJoinFlipSecond={SolidJoinFlipSecond}");
            sw.WriteLine($"{ident}SolidJoinKeepFirst={SolidJoinKeepFirst}");
            sw.WriteLine($"{ident}SolidJoinKeepSecond={SolidJoinKeepSecond}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct SmartSolidSettings_Taper
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 SmoothFaces
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public T_Adouble Angle;

        public SmartSolidSettings_Taper Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Angle = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SmoothFaces={SmoothFaces}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Angle={Angle}");
        }
    }

    public struct SmartSolidSettings_Isoln
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Lock
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public T_Adouble Distance;

        public SmartSolidSettings_Isoln Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Distance = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Lock={Lock}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Distance={Distance}");
        }
    }

    public struct SmartSolidSettings_Round
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 Smooth
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Reserved1;
        public T_Adouble Radius;

        public SmartSolidSettings_Round Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Smooth={Smooth}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Radius={Radius}");
        }
    }

    public struct SmartSolidSettings_Chamfer
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 26, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 Flip
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Smooth
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Mode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 Reserved1;
        public T_Adouble Left;
        public T_Adouble Right;

        public SmartSolidSettings_Chamfer Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Left = br.ReadDouble();
            Right = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Flip={Flip}");
            sw.WriteLine($"{ident}Smooth={Smooth}");
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Left={Left}");
            sw.WriteLine($"{ident}Right={Right}");
        }
    }

    public struct SmartSolidSettings_FilletSrf
    {
        private UInt32 Data1;
        private const int sz_1_0 = 2, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 29, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 TrimMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 FaceOnly
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Reserved1;
        public T_Adouble Radius;

        public SmartSolidSettings_FilletSrf Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Radius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}TrimMode={TrimMode}");
            sw.WriteLine($"{ident}FaceOnly={FaceOnly}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Radius={Radius}");
        }
    }

    public struct SmartSolidSettings
    {
        public T_Adouble Tolerance;
        public UInt32 NIsoparametrics;
        public SmartSolidSettings_Solid Solid;
        public SmartSolidSettings_Surface Surface;
        public SmartSolidSettings_Punch Punch;
        public SmartSolidSettings_Cut Cut;
        public SmartSolidSettings_Hollow Hollow;
        public SmartSolidSettings_Thicken Thicken;
        public SmartSolidSettings_Stretch Stretch;
        public SmartSolidSettings_Move Move;
        public SmartSolidSettings_Display Display;
        public SmartSolidSettings_Extend Extend;
        public SmartSolidSettings_Intersect Intersect;
        public SmartSolidSettings_Extract Extract;
        public SmartSolidSettings_Tube Tube;
        public SmartSolidSettings_Skin Skin;
        public SmartSolidSettings_Taper Taper;
        public SmartSolidSettings_Isoln Isoln;
        public SmartSolidSettings_Round Round;
        public SmartSolidSettings_Chamfer Chamfer;
        public SmartSolidSettings_FilletSrf FilletSrf;

        public SmartSolidSettings Read(BinaryReader br)
        {
            // read each field
            Tolerance = br.ReadDouble();
            NIsoparametrics = br.ReadUInt32();
            Solid = new SmartSolidSettings_Solid().Read(br);
            Surface = new SmartSolidSettings_Surface().Read(br);
            Punch = new SmartSolidSettings_Punch().Read(br);
            Cut = new SmartSolidSettings_Cut().Read(br);
            Hollow = new SmartSolidSettings_Hollow().Read(br);
            Thicken = new SmartSolidSettings_Thicken().Read(br);
            Stretch = new SmartSolidSettings_Stretch().Read(br);
            Move = new SmartSolidSettings_Move().Read(br);
            Display = new SmartSolidSettings_Display().Read(br);
            Extend = new SmartSolidSettings_Extend().Read(br);
            Intersect = new SmartSolidSettings_Intersect().Read(br);
            Extract = new SmartSolidSettings_Extract().Read(br);
            Tube = new SmartSolidSettings_Tube().Read(br);
            Skin = new SmartSolidSettings_Skin().Read(br);
            Taper = new SmartSolidSettings_Taper().Read(br);
            Isoln = new SmartSolidSettings_Isoln().Read(br);
            Round = new SmartSolidSettings_Round().Read(br);
            Chamfer = new SmartSolidSettings_Chamfer().Read(br);
            FilletSrf = new SmartSolidSettings_FilletSrf().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
            sw.WriteLine($"{ident}NIsoparametrics={NIsoparametrics}");
            sw.WriteLine($"{ident}Solid >");
            Solid.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Surface >");
            Surface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Punch >");
            Punch.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Cut >");
            Cut.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Hollow >");
            Hollow.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Thicken >");
            Thicken.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Stretch >");
            Stretch.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Move >");
            Move.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Display >");
            Display.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Extend >");
            Extend.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Intersect >");
            Intersect.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Extract >");
            Extract.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Tube >");
            Tube.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Skin >");
            Skin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Taper >");
            Taper.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Isoln >");
            Isoln.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Round >");
            Round.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Chamfer >");
            Chamfer.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FilletSrf >");
            FilletSrf.Dump(sw, level + 1);
        }
    }

    public struct MS3DToolSettings
    {
        public Int32 DCount;
        public Int32 OrientationView;
        private UInt32 Data1;
        private const int sz_1_0 = 4, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 4, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 4, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 16, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt32 AxisMode
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Type
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 SkewedMode
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Nonperiodic
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 MakeCopy
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 KeepOriginal
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 ParametricSolid
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 Reserved1;
        public DegreeOfFreedom Tolerance;
        public MS3DToolSettings_Curve Curve;
        public MS3DToolSettings_ChangeCurve ChangeCurve;
        public MS3DToolSettings_MatchCurve MatchCurve;
        public MS3DToolSettings_Conic Conic;
        public MS3DToolSettings_Spiral Spiral;
        public MS3DToolSettings_Helix Helix;
        public MS3DToolSettings_ExtractCurve ExtractCurve;
        public MS3DToolSettings_Block Block;
        public MS3DToolSettings_Sphere Sphere;
        public MS3DToolSettings_Cylinder Cylinder;
        public MS3DToolSettings_Cone Cone;
        public MS3DToolSettings_Torus Torus;
        public MS3DToolSettings_Wedge Wedge;
        public MS3DToolSettings_Extrude Extrude;
        public MS3DToolSettings_Revolve Revolve;
        public MS3DToolSettings_Surface Surface;
        public MS3DToolSettings_ChangeSurface ChangeSurface;
        public MS3DToolSettings_MatchSurface MatchSurface;
        public MS3DToolSettings_Section Section;
        public MS3DToolSettings_Tube Tube;
        public MS3DToolSettings_Skin Skin;
        public MS3DToolSettings_Trim Trim;
        public MS3DToolSettings_BooleanOp BooleanOp;
        public MS3DToolSettings_FilletSurface FilletSurface;
        public MS3DToolSettings_FilletCurve FilletCurve;
        public MS3DToolSettings_BlendCurve BlendCurve;
        public MS3DToolSettings_BlendSurface BlendSurface;
        public MS3DToolSettings_Rails Rails;
        public MS3DToolSettings_Punch Punch;
        public MS3DToolSettings_Impose Impose;
        public MS3DToolSettings_Reduce Reduce;
        public MS3DToolSettings_ExtendCurve ExtendCurve;
        public MS3DToolSettings_ExtendSurface ExtendSurface;
        public MS3DToolSettings_DeleteBound DeleteBound;
        public MS3DToolSettings_Convert Convert;
        public MS3DToolSettings_ChangeCap ChangeCap;
        public MS3DToolSettings_Chamfer Chamfer;
        public MS3DToolSettings_OffsetCurve OffsetCurve;
        public MS3DToolSettings_OffsetSurface OffsetSurface;
        public MS3DToolSettings_HelicalSolid HelicalSolid;
        public MS3DToolSettings_FlattenCurve FlattenCurve;
        public MS3DToolSettings_PlaceCurve PlaceCurve;
        public MS3DToolSettings_HelixCurve HelixCurve;
        public MS3DToolSettings_SweetenCurve SweetenCurve;
        public MS3DToolSettings_SweetenSurface SweetenSurface;
        public MS3DToolSettings_ReduceSurface ReduceSurface;
        public MS3DToolSettings_CurveEvaluator CurveEvaluator;
        public MS3DToolSettings_SurfaceEvaluator SurfaceEvaluator;
        public MS3DToolSettings_TrimCurve TrimCurve;
        public MS3DToolSettings_JoinCurve JoinCurve;
        public MS3DToolSettings_ExtractCurveNew ExtractCurveNew;
        public MS3DToolSettings_EdgeSurface EdgeSurface;
        public MS3DToolSettings_VectorInterpolation VectorInterpolation;
        public MS3DToolSettings_RigidSweep RigidSweep;
        public MS3DToolSettings_TwoTraceSweep TwoTraceSweep;
        public MS3DToolSettings_ObsoleteOffsetCurve ObsoleteOffsetCurve;
        public MS3DToolSettings_ObsoleteOffsetSurface ObsoleteOffsetSurface;
        public MS3DToolSettings_Facet Facet;
        public SmartSolidSettings SmartSolid;
        public T_Adouble FacetDecimatePercent;
        public T_Adouble FacetTrimTolerance;
        public T_Adouble FacetSmallEdgeLength;
        public T_Adouble CurveEvaluatordistAlongAbs;
        public T_Adouble FacetDecimateChordTol;
        public T_Adouble BlockSurfLength;
        public T_Adouble BlockSurfWidth;
        public T_Adouble BlockSurfHeight;
        public T_Adouble CylinderSurfRadius;
        public T_Adouble CylinderSurfHeight;
        public T_Adouble ConeSurfBaseRadius;
        public T_Adouble ConeSurfTopRadius;
        public T_Adouble ConeSurfHeight;
        public T_Adouble TorusSurfPrimaryRadius;
        public T_Adouble TorusSurfSecondaryRadius;
        public T_Adouble TorusSurfAngle;
        public T_Adouble WedgeSurfRadius;
        public T_Adouble WedgeSurfAngle;
        public T_Adouble WedgeSurfHeight;
        public T_Adouble OffsetSurfaceDistance;
        public T_Adouble TubeSurfScale;
        public T_Adouble TubeSurfTwist;
        public T_Adouble TubeSurfRad;
        public T_Adouble TubeSolidScale;
        public T_Adouble TubeSolidTwist;
        public T_Adouble TubeSolidRadInside;
        public T_Adouble TubeSolidRadOutside;
        public T_Adouble ExtrudeSolidDistance;
        public T_Adouble ExtrudeSolidSpinAng;
        public T_Adouble ExtrudeSolidDraftAng;
        public T_Adouble ExtrudeSolidXScale;
        public T_Adouble ExtrudeSolidYScale;
        public T_Adouble RevoleSolidAngle;
        public T_Adouble SquishFlattenGrid;
        public T_Adouble MeshToSurfTol;
        public T_Adouble PolySolidWidth;
        public T_Adouble PolySolidHeight;
        public T_Adouble HideMeshEdgesAngle;
        public T_Adouble ExtrudeThickness;
        public T_Adouble RevolveThickness;
        public T_Adouble[] ReservedForFuture;

        public MS3DToolSettings Read(BinaryReader br)
        {
            // read each field
            DCount = br.ReadInt32();
            OrientationView = br.ReadInt32();
            Data1 = br.ReadUInt32();
            Reserved1 = br.ReadUInt32();
            Tolerance = new DegreeOfFreedom().Read(br);
            Curve = new MS3DToolSettings_Curve().Read(br);
            ChangeCurve = new MS3DToolSettings_ChangeCurve().Read(br);
            MatchCurve = new MS3DToolSettings_MatchCurve().Read(br);
            Conic = new MS3DToolSettings_Conic().Read(br);
            Spiral = new MS3DToolSettings_Spiral().Read(br);
            Helix = new MS3DToolSettings_Helix().Read(br);
            ExtractCurve = new MS3DToolSettings_ExtractCurve().Read(br);
            Block = new MS3DToolSettings_Block().Read(br);
            Sphere = new MS3DToolSettings_Sphere().Read(br);
            Cylinder = new MS3DToolSettings_Cylinder().Read(br);
            Cone = new MS3DToolSettings_Cone().Read(br);
            Torus = new MS3DToolSettings_Torus().Read(br);
            Wedge = new MS3DToolSettings_Wedge().Read(br);
            Extrude = new MS3DToolSettings_Extrude().Read(br);
            Revolve = new MS3DToolSettings_Revolve().Read(br);
            Surface = new MS3DToolSettings_Surface().Read(br);
            ChangeSurface = new MS3DToolSettings_ChangeSurface().Read(br);
            MatchSurface = new MS3DToolSettings_MatchSurface().Read(br);
            Section = new MS3DToolSettings_Section().Read(br);
            Tube = new MS3DToolSettings_Tube().Read(br);
            Skin = new MS3DToolSettings_Skin().Read(br);
            Trim = new MS3DToolSettings_Trim().Read(br);
            BooleanOp = new MS3DToolSettings_BooleanOp().Read(br);
            FilletSurface = new MS3DToolSettings_FilletSurface().Read(br);
            FilletCurve = new MS3DToolSettings_FilletCurve().Read(br);
            BlendCurve = new MS3DToolSettings_BlendCurve().Read(br);
            BlendSurface = new MS3DToolSettings_BlendSurface().Read(br);
            Rails = new MS3DToolSettings_Rails().Read(br);
            Punch = new MS3DToolSettings_Punch().Read(br);
            Impose = new MS3DToolSettings_Impose().Read(br);
            Reduce = new MS3DToolSettings_Reduce().Read(br);
            ExtendCurve = new MS3DToolSettings_ExtendCurve().Read(br);
            ExtendSurface = new MS3DToolSettings_ExtendSurface().Read(br);
            DeleteBound = new MS3DToolSettings_DeleteBound().Read(br);
            Convert = new MS3DToolSettings_Convert().Read(br);
            ChangeCap = new MS3DToolSettings_ChangeCap().Read(br);
            Chamfer = new MS3DToolSettings_Chamfer().Read(br);
            OffsetCurve = new MS3DToolSettings_OffsetCurve().Read(br);
            OffsetSurface = new MS3DToolSettings_OffsetSurface().Read(br);
            HelicalSolid = new MS3DToolSettings_HelicalSolid().Read(br);
            FlattenCurve = new MS3DToolSettings_FlattenCurve().Read(br);
            PlaceCurve = new MS3DToolSettings_PlaceCurve().Read(br);
            HelixCurve = new MS3DToolSettings_HelixCurve().Read(br);
            SweetenCurve = new MS3DToolSettings_SweetenCurve().Read(br);
            SweetenSurface = new MS3DToolSettings_SweetenSurface().Read(br);
            ReduceSurface = new MS3DToolSettings_ReduceSurface().Read(br);
            CurveEvaluator = new MS3DToolSettings_CurveEvaluator().Read(br);
            SurfaceEvaluator = new MS3DToolSettings_SurfaceEvaluator().Read(br);
            TrimCurve = new MS3DToolSettings_TrimCurve().Read(br);
            JoinCurve = new MS3DToolSettings_JoinCurve().Read(br);
            ExtractCurveNew = new MS3DToolSettings_ExtractCurveNew().Read(br);
            EdgeSurface = new MS3DToolSettings_EdgeSurface().Read(br);
            VectorInterpolation = new MS3DToolSettings_VectorInterpolation().Read(br);
            RigidSweep = new MS3DToolSettings_RigidSweep().Read(br);
            TwoTraceSweep = new MS3DToolSettings_TwoTraceSweep().Read(br);
            ObsoleteOffsetCurve = new MS3DToolSettings_ObsoleteOffsetCurve().Read(br);
            ObsoleteOffsetSurface = new MS3DToolSettings_ObsoleteOffsetSurface().Read(br);
            Facet = new MS3DToolSettings_Facet().Read(br);
            SmartSolid = new SmartSolidSettings().Read(br);
            FacetDecimatePercent = br.ReadDouble();
            FacetTrimTolerance = br.ReadDouble();
            FacetSmallEdgeLength = br.ReadDouble();
            CurveEvaluatordistAlongAbs = br.ReadDouble();
            FacetDecimateChordTol = br.ReadDouble();
            BlockSurfLength = br.ReadDouble();
            BlockSurfWidth = br.ReadDouble();
            BlockSurfHeight = br.ReadDouble();
            CylinderSurfRadius = br.ReadDouble();
            CylinderSurfHeight = br.ReadDouble();
            ConeSurfBaseRadius = br.ReadDouble();
            ConeSurfTopRadius = br.ReadDouble();
            ConeSurfHeight = br.ReadDouble();
            TorusSurfPrimaryRadius = br.ReadDouble();
            TorusSurfSecondaryRadius = br.ReadDouble();
            TorusSurfAngle = br.ReadDouble();
            WedgeSurfRadius = br.ReadDouble();
            WedgeSurfAngle = br.ReadDouble();
            WedgeSurfHeight = br.ReadDouble();
            OffsetSurfaceDistance = br.ReadDouble();
            TubeSurfScale = br.ReadDouble();
            TubeSurfTwist = br.ReadDouble();
            TubeSurfRad = br.ReadDouble();
            TubeSolidScale = br.ReadDouble();
            TubeSolidTwist = br.ReadDouble();
            TubeSolidRadInside = br.ReadDouble();
            TubeSolidRadOutside = br.ReadDouble();
            ExtrudeSolidDistance = br.ReadDouble();
            ExtrudeSolidSpinAng = br.ReadDouble();
            ExtrudeSolidDraftAng = br.ReadDouble();
            ExtrudeSolidXScale = br.ReadDouble();
            ExtrudeSolidYScale = br.ReadDouble();
            RevoleSolidAngle = br.ReadDouble();
            SquishFlattenGrid = br.ReadDouble();
            MeshToSurfTol = br.ReadDouble();
            PolySolidWidth = br.ReadDouble();
            PolySolidHeight = br.ReadDouble();
            HideMeshEdgesAngle = br.ReadDouble();
            ExtrudeThickness = br.ReadDouble();
            RevolveThickness = br.ReadDouble();
            ReservedForFuture = new T_Adouble[6];
            for (int i = 0; i < 6; i++)
            {
                ReservedForFuture[i] = br.ReadDouble();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}DCount={DCount}");
            sw.WriteLine($"{ident}OrientationView={OrientationView}");
            sw.WriteLine($"{ident}AxisMode={AxisMode}");
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}SkewedMode={SkewedMode}");
            sw.WriteLine($"{ident}Nonperiodic={Nonperiodic}");
            sw.WriteLine($"{ident}MakeCopy={MakeCopy}");
            sw.WriteLine($"{ident}KeepOriginal={KeepOriginal}");
            sw.WriteLine($"{ident}ParametricSolid={ParametricSolid}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            //sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}Tolerance >");
            Tolerance.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Curve >");
            Curve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ChangeCurve >");
            ChangeCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MatchCurve >");
            MatchCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Conic >");
            Conic.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Spiral >");
            Spiral.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Helix >");
            Helix.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExtractCurve >");
            ExtractCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Block >");
            Block.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Sphere >");
            Sphere.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Cylinder >");
            Cylinder.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Cone >");
            Cone.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Torus >");
            Torus.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Wedge >");
            Wedge.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Extrude >");
            Extrude.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Revolve >");
            Revolve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Surface >");
            Surface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ChangeSurface >");
            ChangeSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MatchSurface >");
            MatchSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Section >");
            Section.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Tube >");
            Tube.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Skin >");
            Skin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Trim >");
            Trim.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BooleanOp >");
            BooleanOp.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FilletSurface >");
            FilletSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FilletCurve >");
            FilletCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BlendCurve >");
            BlendCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BlendSurface >");
            BlendSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rails >");
            Rails.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Punch >");
            Punch.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Impose >");
            Impose.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Reduce >");
            Reduce.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExtendCurve >");
            ExtendCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExtendSurface >");
            ExtendSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}DeleteBound >");
            DeleteBound.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Convert >");
            Convert.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ChangeCap >");
            ChangeCap.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Chamfer >");
            Chamfer.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OffsetCurve >");
            OffsetCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}OffsetSurface >");
            OffsetSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}HelicalSolid >");
            HelicalSolid.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FlattenCurve >");
            FlattenCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlaceCurve >");
            PlaceCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}HelixCurve >");
            HelixCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SweetenCurve >");
            SweetenCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SweetenSurface >");
            SweetenSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ReduceSurface >");
            ReduceSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}CurveEvaluator >");
            CurveEvaluator.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SurfaceEvaluator >");
            SurfaceEvaluator.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TrimCurve >");
            TrimCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}JoinCurve >");
            JoinCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExtractCurveNew >");
            ExtractCurveNew.Dump(sw, level + 1);
            sw.WriteLine($"{ident}EdgeSurface >");
            EdgeSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}VectorInterpolation >");
            VectorInterpolation.Dump(sw, level + 1);
            sw.WriteLine($"{ident}RigidSweep >");
            RigidSweep.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TwoTraceSweep >");
            TwoTraceSweep.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ObsoleteOffsetCurve >");
            ObsoleteOffsetCurve.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ObsoleteOffsetSurface >");
            ObsoleteOffsetSurface.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Facet >");
            Facet.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SmartSolid >");
            SmartSolid.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FacetDecimatePercent={FacetDecimatePercent}");
            sw.WriteLine($"{ident}FacetTrimTolerance={FacetTrimTolerance}");
            sw.WriteLine($"{ident}FacetSmallEdgeLength={FacetSmallEdgeLength}");
            sw.WriteLine($"{ident}CurveEvaluatordistAlongAbs={CurveEvaluatordistAlongAbs}");
            sw.WriteLine($"{ident}FacetDecimateChordTol={FacetDecimateChordTol}");
            sw.WriteLine($"{ident}BlockSurfLength={BlockSurfLength}");
            sw.WriteLine($"{ident}BlockSurfWidth={BlockSurfWidth}");
            sw.WriteLine($"{ident}BlockSurfHeight={BlockSurfHeight}");
            sw.WriteLine($"{ident}CylinderSurfRadius={CylinderSurfRadius}");
            sw.WriteLine($"{ident}CylinderSurfHeight={CylinderSurfHeight}");
            sw.WriteLine($"{ident}ConeSurfBaseRadius={ConeSurfBaseRadius}");
            sw.WriteLine($"{ident}ConeSurfTopRadius={ConeSurfTopRadius}");
            sw.WriteLine($"{ident}ConeSurfHeight={ConeSurfHeight}");
            sw.WriteLine($"{ident}TorusSurfPrimaryRadius={TorusSurfPrimaryRadius}");
            sw.WriteLine($"{ident}TorusSurfSecondaryRadius={TorusSurfSecondaryRadius}");
            sw.WriteLine($"{ident}TorusSurfAngle={TorusSurfAngle}");
            sw.WriteLine($"{ident}WedgeSurfRadius={WedgeSurfRadius}");
            sw.WriteLine($"{ident}WedgeSurfAngle={WedgeSurfAngle}");
            sw.WriteLine($"{ident}WedgeSurfHeight={WedgeSurfHeight}");
            sw.WriteLine($"{ident}OffsetSurfaceDistance={OffsetSurfaceDistance}");
            sw.WriteLine($"{ident}TubeSurfScale={TubeSurfScale}");
            sw.WriteLine($"{ident}TubeSurfTwist={TubeSurfTwist}");
            sw.WriteLine($"{ident}TubeSurfRad={TubeSurfRad}");
            sw.WriteLine($"{ident}TubeSolidScale={TubeSolidScale}");
            sw.WriteLine($"{ident}TubeSolidTwist={TubeSolidTwist}");
            sw.WriteLine($"{ident}TubeSolidRadInside={TubeSolidRadInside}");
            sw.WriteLine($"{ident}TubeSolidRadOutside={TubeSolidRadOutside}");
            sw.WriteLine($"{ident}ExtrudeSolidDistance={ExtrudeSolidDistance}");
            sw.WriteLine($"{ident}ExtrudeSolidSpinAng={ExtrudeSolidSpinAng}");
            sw.WriteLine($"{ident}ExtrudeSolidDraftAng={ExtrudeSolidDraftAng}");
            sw.WriteLine($"{ident}ExtrudeSolidXScale={ExtrudeSolidXScale}");
            sw.WriteLine($"{ident}ExtrudeSolidYScale={ExtrudeSolidYScale}");
            sw.WriteLine($"{ident}RevoleSolidAngle={RevoleSolidAngle}");
            sw.WriteLine($"{ident}SquishFlattenGrid={SquishFlattenGrid}");
            sw.WriteLine($"{ident}MeshToSurfTol={MeshToSurfTol}");
            sw.WriteLine($"{ident}PolySolidWidth={PolySolidWidth}");
            sw.WriteLine($"{ident}PolySolidHeight={PolySolidHeight}");
            sw.WriteLine($"{ident}HideMeshEdgesAngle={HideMeshEdgesAngle}");
            sw.WriteLine($"{ident}ExtrudeThickness={ExtrudeThickness}");
            sw.WriteLine($"{ident}RevolveThickness={RevolveThickness}");
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine($"{ident}ReservedForFuture={ReservedForFuture[i]}");
            }
        }
    }

    public struct HLineSettings
    {
        public HLineFlags Flags;
        public HLineSymbology Visible;
        public HLineSymbology Hidden;
        public UInt32 Deprecated_zbResolution;
        public UInt32 Deprecated_zbWorkingMemory;
        public HLineFlags2 Flags2;

        public HLineSettings Read(BinaryReader br)
        {
            // read each field
            Flags = new HLineFlags().Read(br);
            Visible = new HLineSymbology().Read(br);
            Hidden = new HLineSymbology().Read(br);
            Deprecated_zbResolution = br.ReadUInt32();
            Deprecated_zbWorkingMemory = br.ReadUInt32();
            Flags2 = new HLineFlags2().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Visible >");
            Visible.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Hidden >");
            Hidden.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Deprecated_zbResolution={Deprecated_zbResolution}");
            sw.WriteLine($"{ident}Deprecated_zbWorkingMemory={Deprecated_zbWorkingMemory}");
            sw.WriteLine($"{ident}Flags2 >");
            Flags2.Dump(sw, level + 1);
        }
    }

    public struct SmartGeomSettings_Flags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 31, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        public UInt32 RepresentAsSurfaces
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }

        public SmartGeomSettings_Flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}RepresentAsSurfaces={RepresentAsSurfaces}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct SmartGeomSettings
    {
        public Int32 NIsoparametrics;
        public SmartGeomSettings_Flags Flags;

        public SmartGeomSettings Read(BinaryReader br)
        {
            // read each field
            NIsoparametrics = br.ReadInt32();
            Flags = new SmartGeomSettings_Flags().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}NIsoparametrics={NIsoparametrics}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
        }
    }

    public struct PersistentTcb
    {
        public UInt32 MajorVersion;
        public UInt32 MinorVersion;
        public Cntrlwd Control;
        public Cntrl1 Cntrl1;
        public Fbfdcn Fbfdcn;
        public Ext_locks Ext_locks;
        public Ext_locks2 Ext_locks2;
        public T_Adouble Rndunit_deprecated;
        public UInt32 Uorgrid_deprecated;
        public UInt32 Refgrid_deprecated;
        public T_Adouble Grid_ratio_deprecated;
        public T_Adouble Uorpermast_deprecated;
        public T_Adouble Actangle;
        public T_Adouble Anglernd;
        public T_Adouble Xactscle;
        public T_Adouble Yactscle;
        public T_Adouble Zactscle;
        public T_Adouble Rndscle;
        public T_Adouble Azimuth_deprecated;
        public T_Adouble[] ReservedGeneral;
        public Dpoint3d Low;
        public Dpoint3d High;
        public LevelId ActiveLevel;
        public Symbology Symbology;
        public UInt32 FillColor;
        public Int16 Props;
        public TransformFlags TransformFlags;
        public LineStyleInfo LineStyle;
        public T_Adouble LineStyleScale_deprecated;
        public MlineTcbFlags MlineFlags;
        public Int16 ReservedSymb16;
        public Int32 ReservedSymb32;
        public T_Adouble[] ReservedSymbology;
        public TextStyle TextStyle_deprecated;
        public UInt32 TextStyleID_deprecated;
        public UInt16 TextScaleLock;
        public UInt16 ReservedTextShort;
        public UInt32[] ReservedTextLong;
        public T_Adouble[] ReservedText;
        public T_AUInt64 ActiveViewGroup;
        public ModelId ActiveModel;
        public UInt16 Anglefmt_deprecated;
        public UInt16 AngleReadoutPrec_deprecated;
        public UInt16 Tentmode;
        public UInt16 Tentsubmode_deprecated;
        public UInt16 Keypnt_divd;
        public UInt16 DefaultSnapMode;
        public UInt16 Sysclass;
        public UInt8 Dmrsflg;
        public UInt8 ReserveByte;
        public Int16 Linkgen;
        public UInt16 Obsolete_tutvw;
        public Autodim1 Ad1_deprecated;
        public UInt16 AssocLockMask;
        public UInt16[] ReservedDimShort;
        public T_Adouble[] ReservedDim;
        public DirFormat DirectionFormat_deprecated;
        public byte[] ActiveCellUtf16;
        public byte[] ActiveTermCellUtf16;
        public T_Adouble Actterm_scale;
        public byte[] ActivePatternCellUtf16;
        public T_Adouble Actpat_scale;
        public T_Adouble Actpat_angle;
        public T_Adouble Actpat_angle2;
        public T_Adouble Actpat_rowspc;
        public T_Adouble Actpat_colspc;
        public T_Adouble PatternTolerance;
        public Int32 ActivePointType;
        public UInt16 ActivePointSymbol;
        public byte[] ActivePointCellUtf16;
        public ActiveCellSettings ActiveCellSettings;
        public T_Adouble Areapat_angle;
        public T_Adouble Areapat_rowspc;
        public T_Adouble Areapat_colspc;
        public T_Adouble ReservedCell;
        public Transform Digtrans;
        public T_Adouble ZRange2dLow;
        public T_Adouble ZRange2dHigh;
        public T_Adouble StreamDelta;
        public T_Adouble StreamTol;
        public T_Adouble AngleTol;
        public T_Adouble AreaTol;
        public UInt32 DigTransformSet;
        public UInt32 ReservedDigInt;
        public T_Adouble[] ReservedDig;
        public UInt32 HiliteColor;
        public UInt32 XorColor;
        public T_Adouble Axlock_angle;
        public T_Adouble Axlock_origin;
        public T_Adouble Chamfer_dist1;
        public T_Adouble Chamfer_dist2;
        public T_Adouble Autochain_tolerance;
        public T_Adouble Consline_distance;
        public T_Adouble Arc_radius;
        public T_Adouble Arc_length;
        public T_Adouble Cone_radius1;
        public T_Adouble Cone_radius2;
        public T_Adouble Polygon_radius;
        public T_Adouble Surrev_angle;
        public T_Adouble Extend_distance;
        public T_Adouble Fillet_radius;
        public T_Adouble Coppar_distance;
        public T_Adouble Array_row_distance;
        public T_Adouble Array_column_distance;
        public T_Adouble Array_fillangle;
        public T_Adouble Point_distance;
        public Int16 Polygon_edges;
        public Int16 Points_between;
        public Int16 Array_numitems;
        public Int16 Array_numrows;
        public Int16 Array_numcols;
        public UInt8 Array_rotate;
        public UInt8 Bspline_order;
        public UInt8 Disp_attr_type;
        public UInt8 Aux_coord_def;
        public AuxToolFlags Aux_tool_flags;
        public Dpoint3d AuxOrigin_deprecated;
        public RotMatrix AuxMatrix_deprecated;
        public T_Adouble[] ReservedMisc;
        public RenderFlags RenderFlags;
        public Latitude Latitude;
        public Longitude Longitude;
        public SolarTime SolarTime;
        public UInt32 SolarYear;
        public T_Adouble GmtOffset;
        public Dpoint3d SolarDirection;
        public Dpoint3d SolarVectorOverride;
        public RgbFactor SolarIntensity;
        public T_Adouble SolarIntensityScale;
        public RgbFactor AmbientIntensity;
        public T_Adouble AmbientIntensityScale;
        public RgbFactor FlashIntensity;
        public T_Adouble FlashIntensityScale;
        public T_Adouble NearDepthDensity;
        public T_Adouble FarDepthDensity;
        public T_Adouble NearDepthDistance;
        public RgbFactor HazeColor;
        public T_Adouble ShadowTolerance;
        public T_Adouble StrokeTolerance;
        public Int16 MaxPolygonSize;
        public Int16 ArcMinimum;
        public Int32 ExactHLineAccuracy;
        public T_Adouble ExactHLineTolerance;
        public T_Adouble AmbientPercentageOfSolar;
        public T_Adouble[] ReserveRender;
        public UInt32 SelectionHiliteOverride;
        public UInt32 SelectionHiliteColor;
        public byte[] Celfilenm_deprecated;
        public byte[] BackgroundFile;
        public MSToolSettings MsToolSettings;
        public MS3DToolSettings Ms3DToolSettings;
        public HLineSettings HiddenLine;
        public SmartGeomSettings SmartGeomSettings;
        public DrawingScaleName MsDrawingScaleName;
        public UInt32 PlotAutoInvertColor;
        public UInt32 PlotReservedUInt32;
        public T_AUInt64 MainDictionaryId;
        public HLineSymbology HlineSmooth;
        public byte DefaultFontType_deprecated;
        public byte[] DefaultFontName_deprecated;
        public UInt32 GridOrientation;
        public UInt32 InvisGeomDisplayMode;
        public UInt16 DesignCenterUnits;
        public UInt16 ReservedSetting16;
        public DRange3d UserDefinedLimits;
        public UInt32 ActiveColorRGB;
        public UInt32 ActiveFillColorRGB;
        public T_Adouble LongitudeSecondsFraction;
        public T_Adouble LatitudeSecondsFraction;
        public T_Adouble MaxMeshSmoothAngle;
        public T_Adouble[] ReservedSettings;

        public PersistentTcb Read(BinaryReader br)
        {
            // read each field
            MajorVersion = br.ReadUInt32();
            MinorVersion = br.ReadUInt32();
            Control = new Cntrlwd().Read(br);
            Cntrl1 = new Cntrl1().Read(br);
            Fbfdcn = new Fbfdcn().Read(br);
            Ext_locks = new Ext_locks().Read(br);
            Ext_locks2 = new Ext_locks2().Read(br);
            Rndunit_deprecated = br.ReadDouble();
            Uorgrid_deprecated = br.ReadUInt32();
            Refgrid_deprecated = br.ReadUInt32();
            Grid_ratio_deprecated = br.ReadDouble();
            Uorpermast_deprecated = br.ReadDouble();
            Actangle = br.ReadDouble();
            Anglernd = br.ReadDouble();
            Xactscle = br.ReadDouble();
            Yactscle = br.ReadDouble();
            Zactscle = br.ReadDouble();
            Rndscle = br.ReadDouble();
            Azimuth_deprecated = br.ReadDouble();
            ReservedGeneral = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                ReservedGeneral[i] = br.ReadDouble();
            }
            Low = new Dpoint3d().Read(br);
            High = new Dpoint3d().Read(br);
            ActiveLevel = br.ReadUInt32();
            Symbology = new Symbology().Read(br);
            FillColor = br.ReadUInt32();
            Props = br.ReadInt16();
            TransformFlags = new TransformFlags().Read(br);
            LineStyle = new LineStyleInfo().Read(br);
            LineStyleScale_deprecated = br.ReadDouble();
            MlineFlags = new MlineTcbFlags().Read(br);
            ReservedSymb16 = br.ReadInt16();
            ReservedSymb32 = br.ReadInt32();
            ReservedSymbology = new T_Adouble[3];
            for (int i = 0; i < 3; i++)
            {
                ReservedSymbology[i] = br.ReadDouble();
            }
            TextStyle_deprecated = new TextStyle().Read(br);
            TextStyleID_deprecated = br.ReadUInt32();
            TextScaleLock = br.ReadUInt16();
            ReservedTextShort = br.ReadUInt16();
            ReservedTextLong = new UInt32[2];
            for (int i = 0; i < 2; i++)
            {
                ReservedTextLong[i] = br.ReadUInt32();
            }
            ReservedText = new T_Adouble[4];
            for (int i = 0; i < 4; i++)
            {
                ReservedText[i] = br.ReadDouble();
            }
            ActiveViewGroup = br.ReadUInt64();
            ActiveModel = br.ReadUInt32();
            Anglefmt_deprecated = br.ReadUInt16();
            AngleReadoutPrec_deprecated = br.ReadUInt16();
            Tentmode = br.ReadUInt16();
            Tentsubmode_deprecated = br.ReadUInt16();
            Keypnt_divd = br.ReadUInt16();
            DefaultSnapMode = br.ReadUInt16();
            Sysclass = br.ReadUInt16();
            Dmrsflg = br.ReadByte();
            ReserveByte = br.ReadByte();
            Linkgen = br.ReadInt16();
            Obsolete_tutvw = br.ReadUInt16();
            Ad1_deprecated = new Autodim1().Read(br);
            AssocLockMask = br.ReadUInt16();
            ReservedDimShort = new UInt16[2];
            for (int i = 0; i < 2; i++)
            {
                ReservedDimShort[i] = br.ReadUInt16();
            }
            ReservedDim = new T_Adouble[14];
            for (int i = 0; i < 14; i++)
            {
                ReservedDim[i] = br.ReadDouble();
            }
            DirectionFormat_deprecated = new DirFormat().Read(br);
            ActiveCellUtf16 = new byte[2 * 512];
            for (int i = 0; i < 2 * 512; i++)
            {
                ActiveCellUtf16[i] = br.ReadByte();
            }
            ActiveTermCellUtf16 = new byte[2 * 512];
            for (int i = 0; i < 2 * 512; i++)
            {
                ActiveTermCellUtf16[i] = br.ReadByte();
            }
            Actterm_scale = br.ReadDouble();
            ActivePatternCellUtf16 = new byte[2 * 512];
            for (int i = 0; i < 2 * 512; i++)
            {
                ActivePatternCellUtf16[i] = br.ReadByte();
            }
            Actpat_scale = br.ReadDouble();
            Actpat_angle = br.ReadDouble();
            Actpat_angle2 = br.ReadDouble();
            Actpat_rowspc = br.ReadDouble();
            Actpat_colspc = br.ReadDouble();
            PatternTolerance = br.ReadDouble();
            ActivePointType = br.ReadInt32();
            ActivePointSymbol = br.ReadUInt16();
            ActivePointCellUtf16 = new byte[2 * 512];
            for (int i = 0; i < 2 * 512; i++)
            {
                ActivePointCellUtf16[i] = br.ReadByte();
            }
            ActiveCellSettings = new ActiveCellSettings().Read(br);
            Areapat_angle = br.ReadDouble();
            Areapat_rowspc = br.ReadDouble();
            Areapat_colspc = br.ReadDouble();
            ReservedCell = br.ReadDouble();
            Digtrans = new Transform().Read(br);
            ZRange2dLow = br.ReadDouble();
            ZRange2dHigh = br.ReadDouble();
            StreamDelta = br.ReadDouble();
            StreamTol = br.ReadDouble();
            AngleTol = br.ReadDouble();
            AreaTol = br.ReadDouble();
            DigTransformSet = br.ReadUInt32();
            ReservedDigInt = br.ReadUInt32();
            ReservedDig = new T_Adouble[2];
            for (int i = 0; i < 2; i++)
            {
                ReservedDig[i] = br.ReadDouble();
            }
            HiliteColor = br.ReadUInt32();
            XorColor = br.ReadUInt32();
            Axlock_angle = br.ReadDouble();
            Axlock_origin = br.ReadDouble();
            Chamfer_dist1 = br.ReadDouble();
            Chamfer_dist2 = br.ReadDouble();
            Autochain_tolerance = br.ReadDouble();
            Consline_distance = br.ReadDouble();
            Arc_radius = br.ReadDouble();
            Arc_length = br.ReadDouble();
            Cone_radius1 = br.ReadDouble();
            Cone_radius2 = br.ReadDouble();
            Polygon_radius = br.ReadDouble();
            Surrev_angle = br.ReadDouble();
            Extend_distance = br.ReadDouble();
            Fillet_radius = br.ReadDouble();
            Coppar_distance = br.ReadDouble();
            Array_row_distance = br.ReadDouble();
            Array_column_distance = br.ReadDouble();
            Array_fillangle = br.ReadDouble();
            Point_distance = br.ReadDouble();
            Polygon_edges = br.ReadInt16();
            Points_between = br.ReadInt16();
            Array_numitems = br.ReadInt16();
            Array_numrows = br.ReadInt16();
            Array_numcols = br.ReadInt16();
            Array_rotate = br.ReadByte();
            Bspline_order = br.ReadByte();
            Disp_attr_type = br.ReadByte();
            Aux_coord_def = br.ReadByte();
            Aux_tool_flags = new AuxToolFlags().Read(br);
            AuxOrigin_deprecated = new Dpoint3d().Read(br);
            AuxMatrix_deprecated = new RotMatrix().Read(br);
            ReservedMisc = new T_Adouble[16];
            for (int i = 0; i < 16; i++)
            {
                ReservedMisc[i] = br.ReadDouble();
            }
            RenderFlags = new RenderFlags().Read(br);
            Latitude = new Latitude().Read(br);
            Longitude = new Longitude().Read(br);
            SolarTime = new SolarTime().Read(br);
            SolarYear = br.ReadUInt32();
            GmtOffset = br.ReadDouble();
            SolarDirection = new Dpoint3d().Read(br);
            SolarVectorOverride = new Dpoint3d().Read(br);
            SolarIntensity = new RgbFactor().Read(br);
            SolarIntensityScale = br.ReadDouble();
            AmbientIntensity = new RgbFactor().Read(br);
            AmbientIntensityScale = br.ReadDouble();
            FlashIntensity = new RgbFactor().Read(br);
            FlashIntensityScale = br.ReadDouble();
            NearDepthDensity = br.ReadDouble();
            FarDepthDensity = br.ReadDouble();
            NearDepthDistance = br.ReadDouble();
            HazeColor = new RgbFactor().Read(br);
            ShadowTolerance = br.ReadDouble();
            StrokeTolerance = br.ReadDouble();
            MaxPolygonSize = br.ReadInt16();
            ArcMinimum = br.ReadInt16();
            ExactHLineAccuracy = br.ReadInt32();
            ExactHLineTolerance = br.ReadDouble();
            AmbientPercentageOfSolar = br.ReadDouble();
            ReserveRender = new T_Adouble[19];
            for (int i = 0; i < 19; i++)
            {
                ReserveRender[i] = br.ReadDouble();
            }
            SelectionHiliteOverride = br.ReadUInt32();
            SelectionHiliteColor = br.ReadUInt32();
            Celfilenm_deprecated = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                Celfilenm_deprecated[i] = br.ReadByte();
            }
            BackgroundFile = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                BackgroundFile[i] = br.ReadByte();
            }
            MsToolSettings = new MSToolSettings().Read(br);
            Ms3DToolSettings = new MS3DToolSettings().Read(br);
            HiddenLine = new HLineSettings().Read(br);
            SmartGeomSettings = new SmartGeomSettings().Read(br);
            MsDrawingScaleName = new DrawingScaleName().Read(br);
            PlotAutoInvertColor = br.ReadUInt32();
            PlotReservedUInt32 = br.ReadUInt32();
            MainDictionaryId = br.ReadUInt64();
            HlineSmooth = new HLineSymbology().Read(br);
            DefaultFontType_deprecated = br.ReadByte();
            DefaultFontName_deprecated = new byte[63];
            for (int i = 0; i < 63; i++)
            {
                DefaultFontName_deprecated[i] = br.ReadByte();
            }
            GridOrientation = br.ReadUInt32();
            InvisGeomDisplayMode = br.ReadUInt32();
            DesignCenterUnits = br.ReadUInt16();
            ReservedSetting16 = br.ReadUInt16();
            UserDefinedLimits = new DRange3d().Read(br);
            ActiveColorRGB = br.ReadUInt32();
            ActiveFillColorRGB = br.ReadUInt32();
            LongitudeSecondsFraction = br.ReadDouble();
            LatitudeSecondsFraction = br.ReadDouble();
            MaxMeshSmoothAngle = br.ReadDouble();
            ReservedSettings = new T_Adouble[67];
            for (int i = 0; i < 67; i++)
            {
                ReservedSettings[i] = br.ReadDouble();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}MajorVersion={MajorVersion}");
            sw.WriteLine($"{ident}MinorVersion={MinorVersion}");
            sw.WriteLine($"{ident}Control >");
            Control.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Cntrl1 >");
            Cntrl1.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Fbfdcn >");
            Fbfdcn.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Ext_locks >");
            Ext_locks.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Ext_locks2 >");
            Ext_locks2.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Rndunit_deprecated={Rndunit_deprecated}");
            sw.WriteLine($"{ident}Uorgrid_deprecated={Uorgrid_deprecated}");
            sw.WriteLine($"{ident}Refgrid_deprecated={Refgrid_deprecated}");
            sw.WriteLine($"{ident}Grid_ratio_deprecated={Grid_ratio_deprecated}");
            sw.WriteLine($"{ident}Uorpermast_deprecated={Uorpermast_deprecated}");
            sw.WriteLine($"{ident}Actangle={Actangle}");
            sw.WriteLine($"{ident}Anglernd={Anglernd}");
            sw.WriteLine($"{ident}Xactscle={Xactscle}");
            sw.WriteLine($"{ident}Yactscle={Yactscle}");
            sw.WriteLine($"{ident}Zactscle={Zactscle}");
            sw.WriteLine($"{ident}Rndscle={Rndscle}");
            sw.WriteLine($"{ident}Azimuth_deprecated={Azimuth_deprecated}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}ReservedGeneral={ReservedGeneral[i]}");
            }
            sw.WriteLine($"{ident}Low >");
            Low.Dump(sw, level + 1);
            sw.WriteLine($"{ident}High >");
            High.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ActiveLevel={ActiveLevel}");
            sw.WriteLine($"{ident}Symbology >");
            Symbology.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FillColor={FillColor}");
            sw.WriteLine($"{ident}Props={Props}");
            sw.WriteLine($"{ident}TransformFlags >");
            TransformFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}LineStyle >");
            LineStyle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}LineStyleScale_deprecated={LineStyleScale_deprecated}");
            sw.WriteLine($"{ident}MlineFlags >");
            MlineFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ReservedSymb16={ReservedSymb16}");
            sw.WriteLine($"{ident}ReservedSymb32={ReservedSymb32}");
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}ReservedSymbology={ReservedSymbology[i]}");
            }
            sw.WriteLine($"{ident}TextStyle_deprecated >");
            TextStyle_deprecated.Dump(sw, level + 1);
            sw.WriteLine($"{ident}TextStyleID_deprecated={TextStyleID_deprecated}");
            sw.WriteLine($"{ident}TextScaleLock={TextScaleLock}");
            sw.WriteLine($"{ident}ReservedTextShort={ReservedTextShort}");
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}ReservedTextLong={ReservedTextLong[i]}");
            }
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}ReservedText={ReservedText[i]}");
            }
            sw.WriteLine($"{ident}ActiveViewGroup={ActiveViewGroup}");
            sw.WriteLine($"{ident}ActiveModel={ActiveModel}");
            sw.WriteLine($"{ident}Anglefmt_deprecated={Anglefmt_deprecated}");
            sw.WriteLine($"{ident}AngleReadoutPrec_deprecated={AngleReadoutPrec_deprecated}");
            sw.WriteLine($"{ident}Tentmode={Tentmode}");
            sw.WriteLine($"{ident}Tentsubmode_deprecated={Tentsubmode_deprecated}");
            sw.WriteLine($"{ident}Keypnt_divd={Keypnt_divd}");
            sw.WriteLine($"{ident}DefaultSnapMode={DefaultSnapMode}");
            sw.WriteLine($"{ident}Sysclass={Sysclass}");
            sw.WriteLine($"{ident}Dmrsflg={Dmrsflg}");
            sw.WriteLine($"{ident}ReserveByte={ReserveByte}");
            sw.WriteLine($"{ident}Linkgen={Linkgen}");
            sw.WriteLine($"{ident}Obsolete_tutvw={Obsolete_tutvw}");
            sw.WriteLine($"{ident}Ad1_deprecated >");
            Ad1_deprecated.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AssocLockMask={AssocLockMask}");
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}ReservedDimShort={ReservedDimShort[i]}");
            }
            for (int i = 0; i < 14; i++)
            {
                sw.WriteLine($"{ident}ReservedDim={ReservedDim[i]}");
            }
            sw.WriteLine($"{ident}DirectionFormat_deprecated >");
            DirectionFormat_deprecated.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ActiveCellUtf16={Encoding.Unicode.GetString(ActiveCellUtf16, 0, ActiveCellUtf16.Length)}");
            //for (int i = 0; i < 512; i++)
            //{
            //    sw.WriteLine($"{ident}ActiveCellUtf16={ActiveCellUtf16[i]}");
            //}
            sw.WriteLine($"{ident}ActiveTermCellUtf16={Encoding.Unicode.GetString(ActiveTermCellUtf16, 0, ActiveTermCellUtf16.Length)}");
            //for (int i = 0; i < 512; i++)
            //{
            //    sw.WriteLine($"{ident}ActiveTermCellUtf16={ActiveTermCellUtf16[i]}");
            //}
            sw.WriteLine($"{ident}Actterm_scale={Actterm_scale}");
            sw.WriteLine($"{ident}ActivePatternCellUtf16={Encoding.Unicode.GetString(ActivePatternCellUtf16, 0, ActivePatternCellUtf16.Length)}");
            //for (int i = 0; i < 512; i++)
            //{
            //    sw.WriteLine($"{ident}ActivePatternCellUtf16={ActivePatternCellUtf16[i]}");
            //}
            sw.WriteLine($"{ident}Actpat_scale={Actpat_scale}");
            sw.WriteLine($"{ident}Actpat_angle={Actpat_angle}");
            sw.WriteLine($"{ident}Actpat_angle2={Actpat_angle2}");
            sw.WriteLine($"{ident}Actpat_rowspc={Actpat_rowspc}");
            sw.WriteLine($"{ident}Actpat_colspc={Actpat_colspc}");
            sw.WriteLine($"{ident}PatternTolerance={PatternTolerance}");
            sw.WriteLine($"{ident}ActivePointType={ActivePointType}");
            sw.WriteLine($"{ident}ActivePointSymbol={ActivePointSymbol}");
            sw.WriteLine($"{ident}ActivePointCellUtf16={Encoding.Unicode.GetString(ActivePointCellUtf16, 0, ActivePointCellUtf16.Length)}");
            //for (int i = 0; i < 512; i++)
            //{
            //    sw.WriteLine($"{ident}ActivePointCellUtf16={ActivePointCellUtf16[i]}");
            //}
            sw.WriteLine($"{ident}ActiveCellSettings >");
            ActiveCellSettings.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Areapat_angle={Areapat_angle}");
            sw.WriteLine($"{ident}Areapat_rowspc={Areapat_rowspc}");
            sw.WriteLine($"{ident}Areapat_colspc={Areapat_colspc}");
            sw.WriteLine($"{ident}ReservedCell={ReservedCell}");
            sw.WriteLine($"{ident}Digtrans >");
            Digtrans.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ZRange2dLow={ZRange2dLow}");
            sw.WriteLine($"{ident}ZRange2dHigh={ZRange2dHigh}");
            sw.WriteLine($"{ident}StreamDelta={StreamDelta}");
            sw.WriteLine($"{ident}StreamTol={StreamTol}");
            sw.WriteLine($"{ident}AngleTol={AngleTol}");
            sw.WriteLine($"{ident}AreaTol={AreaTol}");
            sw.WriteLine($"{ident}DigTransformSet={DigTransformSet}");
            sw.WriteLine($"{ident}ReservedDigInt={ReservedDigInt}");
            for (int i = 0; i < 2; i++)
            {
                sw.WriteLine($"{ident}ReservedDig={ReservedDig[i]}");
            }
            sw.WriteLine($"{ident}HiliteColor={HiliteColor}");
            sw.WriteLine($"{ident}XorColor={XorColor}");
            sw.WriteLine($"{ident}Axlock_angle={Axlock_angle}");
            sw.WriteLine($"{ident}Axlock_origin={Axlock_origin}");
            sw.WriteLine($"{ident}Chamfer_dist1={Chamfer_dist1}");
            sw.WriteLine($"{ident}Chamfer_dist2={Chamfer_dist2}");
            sw.WriteLine($"{ident}Autochain_tolerance={Autochain_tolerance}");
            sw.WriteLine($"{ident}Consline_distance={Consline_distance}");
            sw.WriteLine($"{ident}Arc_radius={Arc_radius}");
            sw.WriteLine($"{ident}Arc_length={Arc_length}");
            sw.WriteLine($"{ident}Cone_radius1={Cone_radius1}");
            sw.WriteLine($"{ident}Cone_radius2={Cone_radius2}");
            sw.WriteLine($"{ident}Polygon_radius={Polygon_radius}");
            sw.WriteLine($"{ident}Surrev_angle={Surrev_angle}");
            sw.WriteLine($"{ident}Extend_distance={Extend_distance}");
            sw.WriteLine($"{ident}Fillet_radius={Fillet_radius}");
            sw.WriteLine($"{ident}Coppar_distance={Coppar_distance}");
            sw.WriteLine($"{ident}Array_row_distance={Array_row_distance}");
            sw.WriteLine($"{ident}Array_column_distance={Array_column_distance}");
            sw.WriteLine($"{ident}Array_fillangle={Array_fillangle}");
            sw.WriteLine($"{ident}Point_distance={Point_distance}");
            sw.WriteLine($"{ident}Polygon_edges={Polygon_edges}");
            sw.WriteLine($"{ident}Points_between={Points_between}");
            sw.WriteLine($"{ident}Array_numitems={Array_numitems}");
            sw.WriteLine($"{ident}Array_numrows={Array_numrows}");
            sw.WriteLine($"{ident}Array_numcols={Array_numcols}");
            sw.WriteLine($"{ident}Array_rotate={Array_rotate}");
            sw.WriteLine($"{ident}Bspline_order={Bspline_order}");
            sw.WriteLine($"{ident}Disp_attr_type={Disp_attr_type}");
            sw.WriteLine($"{ident}Aux_coord_def={Aux_coord_def}");
            sw.WriteLine($"{ident}Aux_tool_flags >");
            Aux_tool_flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AuxOrigin_deprecated >");
            AuxOrigin_deprecated.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AuxMatrix_deprecated >");
            AuxMatrix_deprecated.Dump(sw, level + 1);
            for (int i = 0; i < 16; i++)
            {
                sw.WriteLine($"{ident}ReservedMisc={ReservedMisc[i]}");
            }
            sw.WriteLine($"{ident}RenderFlags >");
            RenderFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Latitude >");
            Latitude.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Longitude >");
            Longitude.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarTime >");
            SolarTime.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarYear={SolarYear}");
            sw.WriteLine($"{ident}GmtOffset={GmtOffset}");
            sw.WriteLine($"{ident}SolarDirection >");
            SolarDirection.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarVectorOverride >");
            SolarVectorOverride.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarIntensity >");
            SolarIntensity.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarIntensityScale={SolarIntensityScale}");
            sw.WriteLine($"{ident}AmbientIntensity >");
            AmbientIntensity.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AmbientIntensityScale={AmbientIntensityScale}");
            sw.WriteLine($"{ident}FlashIntensity >");
            FlashIntensity.Dump(sw, level + 1);
            sw.WriteLine($"{ident}FlashIntensityScale={FlashIntensityScale}");
            sw.WriteLine($"{ident}NearDepthDensity={NearDepthDensity}");
            sw.WriteLine($"{ident}FarDepthDensity={FarDepthDensity}");
            sw.WriteLine($"{ident}NearDepthDistance={NearDepthDistance}");
            sw.WriteLine($"{ident}HazeColor >");
            HazeColor.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ShadowTolerance={ShadowTolerance}");
            sw.WriteLine($"{ident}StrokeTolerance={StrokeTolerance}");
            sw.WriteLine($"{ident}MaxPolygonSize={MaxPolygonSize}");
            sw.WriteLine($"{ident}ArcMinimum={ArcMinimum}");
            sw.WriteLine($"{ident}ExactHLineAccuracy={ExactHLineAccuracy}");
            sw.WriteLine($"{ident}ExactHLineTolerance={ExactHLineTolerance}");
            sw.WriteLine($"{ident}AmbientPercentageOfSolar={AmbientPercentageOfSolar}");
            for (int i = 0; i < 19; i++)
            {
                sw.WriteLine($"{ident}ReserveRender={ReserveRender[i]}");
            }
            sw.WriteLine($"{ident}SelectionHiliteOverride={SelectionHiliteOverride}");
            sw.WriteLine($"{ident}SelectionHiliteColor={SelectionHiliteColor}");
            sw.WriteLine($"{ident}Celfilenm_deprecated={Encoding.ASCII.GetString(Celfilenm_deprecated, 0, Celfilenm_deprecated.Length)}");
            //for (int i = 0; i < 256; i++)
            //{
            //    sw.WriteLine($"{ident}Celfilenm_deprecated={Celfilenm_deprecated[i]}");
            //}
            sw.WriteLine($"{ident}BackgroundFile={Encoding.ASCII.GetString(BackgroundFile, 0, BackgroundFile.Length)}");
            //for (int i = 0; i < 256; i++)
            //{
            //    sw.WriteLine($"{ident}BackgroundFile={BackgroundFile[i]}");
            //}
            sw.WriteLine($"{ident}MsToolSettings >");
            MsToolSettings.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Ms3DToolSettings >");
            Ms3DToolSettings.Dump(sw, level + 1);
            sw.WriteLine($"{ident}HiddenLine >");
            HiddenLine.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SmartGeomSettings >");
            SmartGeomSettings.Dump(sw, level + 1);
            sw.WriteLine($"{ident}MsDrawingScaleName >");
            MsDrawingScaleName.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PlotAutoInvertColor={PlotAutoInvertColor}");
            sw.WriteLine($"{ident}PlotReservedUInt32={PlotReservedUInt32}");
            sw.WriteLine($"{ident}MainDictionaryId={MainDictionaryId}");
            sw.WriteLine($"{ident}HlineSmooth >");
            HlineSmooth.Dump(sw, level + 1);
            sw.WriteLine($"{ident}DefaultFontType_deprecated={DefaultFontType_deprecated}");
            sw.WriteLine($"{ident}DefaultFontName_deprecated={Encoding.ASCII.GetString(DefaultFontName_deprecated, 0, DefaultFontName_deprecated.Length)}");
            //for (int i = 0; i < 63; i++)
            //{
            //    sw.WriteLine($"{ident}DefaultFontName_deprecated={DefaultFontName_deprecated[i]}");
            //}
            sw.WriteLine($"{ident}GridOrientation={GridOrientation}");
            sw.WriteLine($"{ident}InvisGeomDisplayMode={InvisGeomDisplayMode}");
            sw.WriteLine($"{ident}DesignCenterUnits={DesignCenterUnits}");
            sw.WriteLine($"{ident}ReservedSetting16={ReservedSetting16}");
            sw.WriteLine($"{ident}UserDefinedLimits >");
            UserDefinedLimits.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ActiveColorRGB={ActiveColorRGB}");
            sw.WriteLine($"{ident}ActiveFillColorRGB={ActiveFillColorRGB}");
            sw.WriteLine($"{ident}LongitudeSecondsFraction={LongitudeSecondsFraction}");
            sw.WriteLine($"{ident}LatitudeSecondsFraction={LatitudeSecondsFraction}");
            sw.WriteLine($"{ident}MaxMeshSmoothAngle={MaxMeshSmoothAngle}");
            for (int i = 0; i < 67; i++)
            {
                sw.WriteLine($"{ident}ReservedSettings={ReservedSettings[i]}");
            }
        }
    }

    public struct Ucm_register
    {
        public short Len;
        public sbyte[] C;

        public Ucm_register Read(BinaryReader br)
        {
            // read each field
            Len = br.ReadInt16();
            C = new sbyte[42];
            for (int i = 0; i < 42; i++)
            {
                C[i] = br.ReadSByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Len={Len}");
            for (int i = 0; i < 42; i++)
            {
                sw.WriteLine($"{ident}C={C[i]}");
            }
        }
    }

    public struct TextDrawFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        public UInt16 InterCharSpacing
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 FixedWidthSpacing
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Underline
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Slant
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Vertical
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 RightToLeft_deprecated
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 Unused2
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 Unused
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Offset
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt16 CodePage_deprecated
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_9) >> loc_1_9);
            set => Data1 = (UInt16)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt16 ShxBigFont
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_10) >> loc_1_10);
            set => Data1 = (UInt16)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt16 BgColor
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_11) >> loc_1_11);
            set => Data1 = (UInt16)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt16 Subscript
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_12) >> loc_1_12);
            set => Data1 = (UInt16)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt16 Superscript
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_13) >> loc_1_13);
            set => Data1 = (UInt16)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt16 Unused3
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_14) >> loc_1_14);
            set => Data1 = (UInt16)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt16 TextStyle
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_15) >> loc_1_15);
            set => Data1 = (UInt16)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }

        public TextDrawFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}InterCharSpacing={InterCharSpacing}");
            sw.WriteLine($"{ident}FixedWidthSpacing={FixedWidthSpacing}");
            sw.WriteLine($"{ident}Underline={Underline}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}Vertical={Vertical}");
            sw.WriteLine($"{ident}RightToLeft_deprecated={RightToLeft_deprecated}");
            sw.WriteLine($"{ident}Unused2={Unused2}");
            sw.WriteLine($"{ident}Unused={Unused}");
            sw.WriteLine($"{ident}Offset={Offset}");
            sw.WriteLine($"{ident}CodePage_deprecated={CodePage_deprecated}");
            sw.WriteLine($"{ident}ShxBigFont={ShxBigFont}");
            sw.WriteLine($"{ident}BgColor={BgColor}");
            sw.WriteLine($"{ident}Subscript={Subscript}");
            sw.WriteLine($"{ident}Superscript={Superscript}");
            sw.WriteLine($"{ident}Unused3={Unused3}");
            sw.WriteLine($"{ident}TextStyle={TextStyle}");
        }
    }

    public struct TextExFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 2, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 8, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 2, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 1, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 1, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        public UInt32 Overline
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 StackedFractionSection
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 StackedFractionAlign
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 StackedFractionType
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 CrCount
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Bold
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 UnderlineStyle
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 OverlineStyle
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 StyleOverrides
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 WordWrapTextNode
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 FullJustification
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 Color
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 AcadInterCharSpacing
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 AcadLineSpacingType
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Backwards
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 Upsidedown
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 AcadFittedText
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 AnnotationScale
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 RenderPercentsAsMText
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 BitMaskContainsTabCRLF
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 IsField
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }

        public TextExFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Overline={Overline}");
            sw.WriteLine($"{ident}StackedFractionSection={StackedFractionSection}");
            sw.WriteLine($"{ident}StackedFractionAlign={StackedFractionAlign}");
            sw.WriteLine($"{ident}StackedFractionType={StackedFractionType}");
            sw.WriteLine($"{ident}CrCount={CrCount}");
            sw.WriteLine($"{ident}Bold={Bold}");
            sw.WriteLine($"{ident}UnderlineStyle={UnderlineStyle}");
            sw.WriteLine($"{ident}OverlineStyle={OverlineStyle}");
            sw.WriteLine($"{ident}StyleOverrides={StyleOverrides}");
            sw.WriteLine($"{ident}WordWrapTextNode={WordWrapTextNode}");
            sw.WriteLine($"{ident}FullJustification={FullJustification}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}AcadInterCharSpacing={AcadInterCharSpacing}");
            sw.WriteLine($"{ident}AcadLineSpacingType={AcadLineSpacingType}");
            sw.WriteLine($"{ident}Backwards={Backwards}");
            sw.WriteLine($"{ident}Upsidedown={Upsidedown}");
            sw.WriteLine($"{ident}AcadFittedText={AcadFittedText}");
            sw.WriteLine($"{ident}AnnotationScale={AnnotationScale}");
            sw.WriteLine($"{ident}RenderPercentsAsMText={RenderPercentsAsMText}");
            sw.WriteLine($"{ident}BitMaskContainsTabCRLF={BitMaskContainsTabCRLF}");
            sw.WriteLine($"{ident}IsField={IsField}");
        }
    }

    public struct TextRenderingFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 2, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 2, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 27, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        public UInt32 AlignEdge
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 LineAlignment
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DocumentType
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }

        public TextRenderingFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}AlignEdge={AlignEdge}");
            sw.WriteLine($"{ident}LineAlignment={LineAlignment}");
            sw.WriteLine($"{ident}DocumentType={DocumentType}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct TextParamWide
    {
        public UInt32 Font;
        public TextElementJustification Just;
        public int LineStyle_deprecated;
        public int ViewIndependent;
        public int CodePage_deprecated;
        public UInt32 NodeNumber;
        public UInt32 ShxBigFont;
        public UInt32 BackgroundFillColor;
        public UInt32 TextStyleId;
        public UInt32 Color;
        public double Slant;
        public double LineSpacing;
        public double CharacterSpacing;
        public double UnderlineSpacing;
        public double TextnodeWordWrapLength;
        public TextDrawFlags Flags;
        public TextExFlags ExFlags;
        public DPoint2d LineOffset;
        public DPoint2d BackgroundBorder;
        public Int64 AssocId;
        public UInt32 BackgroundColor;
        public Int32 BackgroundStyle;
        public UInt32 BackgroundWeight;
        public UInt32 UnderlineColor;
        public Int32 UnderlineStyle;
        public UInt32 UnderlineWeight;
        public UInt32 OverlineColor;
        public Int32 OverlineStyle;
        public UInt32 OverlineWeight;
        public double OverlineSpacing;
        public TextStyleOverrideFlags OverridesFromStyle;
        public double WidthFactor;
        public double AnnotationScale;
        public TextRenderingFlags RenderingFlags;

        public TextParamWide Read(BinaryReader br)
        {
            // read each field
            Font = br.ReadUInt32();
            Just = (TextElementJustification)br.ReadInt32();
            LineStyle_deprecated = br.ReadInt32();
            ViewIndependent = br.ReadInt32();
            CodePage_deprecated = br.ReadInt32();
            NodeNumber = br.ReadUInt32();
            ShxBigFont = br.ReadUInt32();
            BackgroundFillColor = br.ReadUInt32();
            TextStyleId = br.ReadUInt32();
            Color = br.ReadUInt32();
            Slant = br.ReadDouble();
            LineSpacing = br.ReadDouble();
            CharacterSpacing = br.ReadDouble();
            UnderlineSpacing = br.ReadDouble();
            TextnodeWordWrapLength = br.ReadDouble();
            Flags = new TextDrawFlags().Read(br);
            ExFlags = new TextExFlags().Read(br);
            LineOffset = new DPoint2d().Read(br);
            BackgroundBorder = new DPoint2d().Read(br);
            AssocId = br.ReadInt64();
            BackgroundColor = br.ReadUInt32();
            BackgroundStyle = br.ReadInt32();
            BackgroundWeight = br.ReadUInt32();
            UnderlineColor = br.ReadUInt32();
            UnderlineStyle = br.ReadInt32();
            UnderlineWeight = br.ReadUInt32();
            OverlineColor = br.ReadUInt32();
            OverlineStyle = br.ReadInt32();
            OverlineWeight = br.ReadUInt32();
            OverlineSpacing = br.ReadDouble();
            OverridesFromStyle = new TextStyleOverrideFlags().Read(br);
            WidthFactor = br.ReadDouble();
            AnnotationScale = br.ReadDouble();
            RenderingFlags = new TextRenderingFlags().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}LineStyle_deprecated={LineStyle_deprecated}");
            sw.WriteLine($"{ident}ViewIndependent={ViewIndependent}");
            sw.WriteLine($"{ident}CodePage_deprecated={CodePage_deprecated}");
            sw.WriteLine($"{ident}NodeNumber={NodeNumber}");
            sw.WriteLine($"{ident}ShxBigFont={ShxBigFont}");
            sw.WriteLine($"{ident}BackgroundFillColor={BackgroundFillColor}");
            sw.WriteLine($"{ident}TextStyleId={TextStyleId}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}LineSpacing={LineSpacing}");
            sw.WriteLine($"{ident}CharacterSpacing={CharacterSpacing}");
            sw.WriteLine($"{ident}UnderlineSpacing={UnderlineSpacing}");
            sw.WriteLine($"{ident}TextnodeWordWrapLength={TextnodeWordWrapLength}");
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ExFlags >");
            ExFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}LineOffset >");
            LineOffset.Dump(sw, level + 1);
            sw.WriteLine($"{ident}BackgroundBorder >");
            BackgroundBorder.Dump(sw, level + 1);
            sw.WriteLine($"{ident}AssocId={AssocId}");
            sw.WriteLine($"{ident}BackgroundColor={BackgroundColor}");
            sw.WriteLine($"{ident}BackgroundStyle={BackgroundStyle}");
            sw.WriteLine($"{ident}BackgroundWeight={BackgroundWeight}");
            sw.WriteLine($"{ident}UnderlineColor={UnderlineColor}");
            sw.WriteLine($"{ident}UnderlineStyle={UnderlineStyle}");
            sw.WriteLine($"{ident}UnderlineWeight={UnderlineWeight}");
            sw.WriteLine($"{ident}OverlineColor={OverlineColor}");
            sw.WriteLine($"{ident}OverlineStyle={OverlineStyle}");
            sw.WriteLine($"{ident}OverlineWeight={OverlineWeight}");
            sw.WriteLine($"{ident}OverlineSpacing={OverlineSpacing}");
            sw.WriteLine($"{ident}OverridesFromStyle >");
            OverridesFromStyle.Dump(sw, level + 1);
            sw.WriteLine($"{ident}WidthFactor={WidthFactor}");
            sw.WriteLine($"{ident}AnnotationScale={AnnotationScale}");
            sw.WriteLine($"{ident}RenderingFlags >");
            RenderingFlags.Dump(sw, level + 1);
        }
    }

    public struct Mlinesymbology
    {
        private UInt32 Data1;
        private const int sz_1_0 = 16, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 6, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 UseStyle
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 UseWeight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 UseColor
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 CapInArc
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CapOutArc
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 CapLine
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 UseClass
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 CustomStyle
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 CapColorFromSeg
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 ConClass
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public Int32 Style;
        public UInt32 Weight;
        public UInt32 Color;
        public LevelId Level;

        public Mlinesymbology Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Style = br.ReadInt32();
            Weight = br.ReadUInt32();
            Color = br.ReadUInt32();
            Level = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}UseStyle={UseStyle}");
            sw.WriteLine($"{ident}UseWeight={UseWeight}");
            sw.WriteLine($"{ident}UseColor={UseColor}");
            sw.WriteLine($"{ident}CapInArc={CapInArc}");
            sw.WriteLine($"{ident}CapOutArc={CapOutArc}");
            sw.WriteLine($"{ident}CapLine={CapLine}");
            sw.WriteLine($"{ident}UseClass={UseClass}");
            sw.WriteLine($"{ident}CustomStyle={CustomStyle}");
            sw.WriteLine($"{ident}CapColorFromSeg={CapColorFromSeg}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}ConClass={ConClass}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Level={Level}");
        }
    }

    public struct MlineSymbology
    {
        private UInt32 Data1;
        private const int sz_1_0 = 16, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 6, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 UseStyle
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 UseWeight
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 UseColor
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 CapInArc
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 CapOutArc
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 CapLine
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 UseClass
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 CustomStyle
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 CapColorFromSeg
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 ConClass
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public Int32 Style;
        public UInt32 Weight;
        public UInt32 Color;
        public LevelId Level;

        public MlineSymbology Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            Style = br.ReadInt32();
            Weight = br.ReadUInt32();
            Color = br.ReadUInt32();
            Level = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}UseStyle={UseStyle}");
            sw.WriteLine($"{ident}UseWeight={UseWeight}");
            sw.WriteLine($"{ident}UseColor={UseColor}");
            sw.WriteLine($"{ident}CapInArc={CapInArc}");
            sw.WriteLine($"{ident}CapOutArc={CapOutArc}");
            sw.WriteLine($"{ident}CapLine={CapLine}");
            sw.WriteLine($"{ident}UseClass={UseClass}");
            sw.WriteLine($"{ident}CustomStyle={CustomStyle}");
            sw.WriteLine($"{ident}CapColorFromSeg={CapColorFromSeg}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}ConClass={ConClass}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Level={Level}");
        }
    }

    public struct Mlineprofile
    {
        public double Dist;
        public Int32 Reserved;
        public MlineSymbology Symb;

        public Mlineprofile Read(BinaryReader br)
        {
            // read each field
            Dist = br.ReadDouble();
            Reserved = br.ReadInt32();
            Symb = new MlineSymbology().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Dist={Dist}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}Symb={Symb}");
        }
    }

    public struct RgbColorShort
    {
        public UInt16 Red;
        public UInt16 Green;
        public UInt16 Blue;

        public RgbColorShort Read(BinaryReader br)
        {
            // read each field
            Red = br.ReadUInt16();
            Green = br.ReadUInt16();
            Blue = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Red={Red}");
            sw.WriteLine($"{ident}Green={Green}");
            sw.WriteLine($"{ident}Blue={Blue}");
        }
    }

    public struct FColor3
    {
        public float R;
        public float G;
        public float B;

        public FColor3 Read(BinaryReader br)
        {
            // read each field
            R = br.ReadSingle();
            G = br.ReadSingle();
            B = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}R={R}");
            sw.WriteLine($"{ident}G={G}");
            sw.WriteLine($"{ident}B={B}");
        }
    }

    public struct FColor4
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public FColor4 Read(BinaryReader br)
        {
            // read each field
            R = br.ReadSingle();
            G = br.ReadSingle();
            B = br.ReadSingle();
            A = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}R={R}");
            sw.WriteLine($"{ident}G={G}");
            sw.WriteLine($"{ident}B={B}");
            sw.WriteLine($"{ident}A={A}");
        }
    }

    public struct FTexture2
    {
        public float U;
        public float V;

        public FTexture2 Read(BinaryReader br)
        {
            // read each field
            U = br.ReadSingle();
            V = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}U={U}");
            sw.WriteLine($"{ident}V={V}");
        }
    }

    public struct FTexture3
    {
        public float U;
        public float V;
        public float W;

        public FTexture3 Read(BinaryReader br)
        {
            // read each field
            U = br.ReadSingle();
            V = br.ReadSingle();
            W = br.ReadSingle();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}U={U}");
            sw.WriteLine($"{ident}V={V}");
            sw.WriteLine($"{ident}W={W}");
        }
    }

    public struct RenderInfo
    {
        public Int16 Version;
        public Int16 ArcMinimum;
        public Int16 MaxPolygonSize;
        public UInt16[] AmbientIntensity;
        public UInt16[] FlashIntensity;
        public UInt16[] SolarIntensity;
        public T_Adouble StrokeTolerance;
        public RenderFlags RenderFlags;
        public Longitude Latitude;
        public SolarTime SolarTime;
        public Longitude Longitude;

        public RenderInfo Read(BinaryReader br)
        {
            // read each field
            Version = br.ReadInt16();
            ArcMinimum = br.ReadInt16();
            MaxPolygonSize = br.ReadInt16();
            AmbientIntensity = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                AmbientIntensity[i] = br.ReadUInt16();
            }
            FlashIntensity = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                FlashIntensity[i] = br.ReadUInt16();
            }
            SolarIntensity = new UInt16[3];
            for (int i = 0; i < 3; i++)
            {
                SolarIntensity[i] = br.ReadUInt16();
            }
            StrokeTolerance = br.ReadDouble();
            RenderFlags = new RenderFlags().Read(br);
            Latitude = new Longitude().Read(br);
            SolarTime = new SolarTime().Read(br);
            Longitude = new Longitude().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Version={Version}");
            sw.WriteLine($"{ident}ArcMinimum={ArcMinimum}");
            sw.WriteLine($"{ident}MaxPolygonSize={MaxPolygonSize}");
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}AmbientIntensity={AmbientIntensity[i]}");
            }
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}FlashIntensity={FlashIntensity[i]}");
            }
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine($"{ident}SolarIntensity={SolarIntensity[i]}");
            }
            sw.WriteLine($"{ident}StrokeTolerance={StrokeTolerance}");
            sw.WriteLine($"{ident}RenderFlags >");
            RenderFlags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Latitude >");
            Latitude.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SolarTime >");
            SolarTime.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Longitude={Longitude}");
        }
    }

    public struct MSTextSize
    {
        public double Width;
        public double Height;

        public MSTextSize Read(BinaryReader br)
        {
            // read each field
            Width = br.ReadDouble();
            Height = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}Height={Height}");
        }
    }

    public struct TextSizeParam
    {
        public int Mode;
        public MSTextSize Size;
        public double AspectRatio;

        public TextSizeParam Read(BinaryReader br)
        {
            // read each field
            Mode = br.ReadInt32();
            Size = new MSTextSize().Read(br);
            AspectRatio = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Mode={Mode}");
            sw.WriteLine($"{ident}Size={Size}");
            sw.WriteLine($"{ident}AspectRatio={AspectRatio}");
        }
    }

    public struct TextEDField
    {
        public byte Start;
        public byte Len;
        public byte Just;

        public TextEDField Read(BinaryReader br)
        {
            // read each field
            Start = br.ReadByte();
            Len = br.ReadByte();
            Just = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Start={Start}");
            sw.WriteLine($"{ident}Len={Len}");
            sw.WriteLine($"{ident}Just={Just}");
        }
    }

    public struct TextStyleInfo
    {
        public UInt32 Font;
        public double Slant;
        public byte Bold;
        public byte Italics;
        public short LineStyle_deprecated;
        public UInt32 BigFont;

        public TextStyleInfo Read(BinaryReader br)
        {
            // read each field
            Font = br.ReadUInt32();
            Slant = br.ReadDouble();
            Bold = br.ReadByte();
            Italics = br.ReadByte();
            LineStyle_deprecated = br.ReadInt16();
            BigFont = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Slant={Slant}");
            sw.WriteLine($"{ident}Bold={Bold}");
            sw.WriteLine($"{ident}Italics={Italics}");
            sw.WriteLine($"{ident}LineStyle_deprecated={LineStyle_deprecated}");
            sw.WriteLine($"{ident}BigFont={BigFont}");
        }
    }

    public struct TextParam
    {
        public UInt32 Font;
        public TextElementJustification Just;
        public int LineStyle_deprecated;
        public int ViewIndependent;

        public TextParam Read(BinaryReader br)
        {
            // read each field
            Font = br.ReadUInt32();
            Just = (TextElementJustification)br.ReadInt32();
            LineStyle_deprecated = br.ReadInt32();
            ViewIndependent = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Font={Font}");
            sw.WriteLine($"{ident}Just={Just}");
            sw.WriteLine($"{ident}LineStyle_deprecated={LineStyle_deprecated}");
            sw.WriteLine($"{ident}ViewIndependent={ViewIndependent}");
        }
    }

    public struct TextScale
    {
        public double X;
        public double Y;

        public TextScale Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
        }
    }

    public struct TextFlags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 9, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        public UInt16 Upper
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Lower
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Fract
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Intl
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Fast
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Space
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 Filled
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }

        public TextFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Upper={Upper}");
            sw.WriteLine($"{ident}Lower={Lower}");
            sw.WriteLine($"{ident}Fract={Fract}");
            sw.WriteLine($"{ident}Intl={Intl}");
            sw.WriteLine($"{ident}Fast={Fast}");
            sw.WriteLine($"{ident}Space={Space}");
            sw.WriteLine($"{ident}Filled={Filled}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct TextFontInfo
    {
        public TextFlags LettersType;
        public byte CharType;
        public byte VectorSize;
        public byte GraphicType;
        public byte CharSize;
        public short TileSize;
        public int DataSize;
        public Point2d Origin;
        public TextScale Scale;

        public TextFontInfo Read(BinaryReader br)
        {
            // read each field
            LettersType = new TextFlags().Read(br);
            CharType = br.ReadByte();
            VectorSize = br.ReadByte();
            GraphicType = br.ReadByte();
            CharSize = br.ReadByte();
            TileSize = br.ReadInt16();
            DataSize = br.ReadInt32();
            Origin = new Point2d().Read(br);
            Scale = new TextScale().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}LettersType={LettersType}");
            sw.WriteLine($"{ident}CharType={CharType}");
            sw.WriteLine($"{ident}VectorSize={VectorSize}");
            sw.WriteLine($"{ident}GraphicType={GraphicType}");
            sw.WriteLine($"{ident}CharSize={CharSize}");
            sw.WriteLine($"{ident}TileSize={TileSize}");
            sw.WriteLine($"{ident}DataSize={DataSize}");
            sw.WriteLine($"{ident}Origin >");
            Origin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Scale={Scale}");
        }
    }

    public struct Dgn_header
    {
        public Elm_hdr Ehdr;
        public PersistentTcb Tcbinfo;

        public Dgn_header Read(BinaryReader br)
        {
            // read each field
            Ehdr = new Elm_hdr().Read(br);
            Tcbinfo = new PersistentTcb().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Ehdr >");
            Ehdr.Dump(sw, level + 1);
            sw.WriteLine($"{ident}PersistentTcb >");
            Tcbinfo.Dump(sw, level + 1);
        }
    }

    public struct ScOverride
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 8, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        public UInt16 Level
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 Relative
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 ClassValue
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt16 Color
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_3) >> loc_1_3);
            set => Data1 = (UInt16)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt16 Weight
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_4) >> loc_1_4);
            set => Data1 = (UInt16)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt16 Style
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_5) >> loc_1_5);
            set => Data1 = (UInt16)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt16 AssocPnt
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_6) >> loc_1_6);
            set => Data1 = (UInt16)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt16 ScaleDimsWysiwyg
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_7) >> loc_1_7);
            set => Data1 = (UInt16)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt16 Unused
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_8) >> loc_1_8);
            set => Data1 = (UInt16)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }

        public ScOverride Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Level={Level}");
            sw.WriteLine($"{ident}Relative={Relative}");
            sw.WriteLine($"{ident}ClassValue={ClassValue}");
            sw.WriteLine($"{ident}Color={Color}");
            sw.WriteLine($"{ident}Weight={Weight}");
            sw.WriteLine($"{ident}Style={Style}");
            sw.WriteLine($"{ident}AssocPnt={AssocPnt}");
            sw.WriteLine($"{ident}ScaleDimsWysiwyg={ScaleDimsWysiwyg}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct JointDef
    {
        public Dpoint3d Dir;
        public T_Adouble Scale;

        public JointDef Read(BinaryReader br)
        {
            // read each field
            Dir = new Dpoint3d().Read(br);
            Scale = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Dir >");
            Dir.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Scale={Scale}");
        }
    }

    public struct MlinePoint_Flags
    {
        private UInt16 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 14, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt16 Assoc
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_0) >> loc_1_0);
            set => Data1 = (UInt16)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt16 RoundCorner
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_1) >> loc_1_1);
            set => Data1 = (UInt16)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt16 Reserved
        {
            get => (UInt16)((UInt16)(Data1 & mask_1_2) >> loc_1_2);
            set => Data1 = (UInt16)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public MlinePoint_Flags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt16();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Assoc={Assoc}");
            sw.WriteLine($"{ident}RoundCorner={RoundCorner}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
        }
    }

    public struct MlinePoint
    {
        public Dpoint3d Point;
        public MlinePoint_Flags Flags;
        public UInt16 Reserved;
        public UInt16 BreakNo;
        public UInt16 NBreaks;
        public T_Adouble Radius;

        public MlinePoint Read(BinaryReader br)
        {
            // read each field
            Point = new Dpoint3d().Read(br);
            Flags = new MlinePoint_Flags().Read(br);
            Reserved = br.ReadUInt16();
            BreakNo = br.ReadUInt16();
            NBreaks = br.ReadUInt16();
            Radius = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Point >");
            Point.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Flags >");
            Flags.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}BreakNo={BreakNo}");
            sw.WriteLine($"{ident}NBreaks={NBreaks}");
            sw.WriteLine($"{ident}Radius={Radius}");
        }
    }

    public struct MlineBreak
    {
        public UInt32 LineMask;
        public UInt32 Flags;
        public T_Adouble Offset;
        public T_Adouble Length;
        public T_Adouble Angle;

        public MlineBreak Read(BinaryReader br)
        {
            // read each field
            LineMask = br.ReadUInt32();
            Flags = br.ReadUInt32();
            Offset = br.ReadDouble();
            Length = br.ReadDouble();
            Angle = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}LineMask={LineMask}");
            sw.WriteLine($"{ident}Flags={Flags}");
            sw.WriteLine($"{ident}Offset={Offset}");
            sw.WriteLine($"{ident}Length={Length}");
            sw.WriteLine($"{ident}Angle={Angle}");
        }
    }

    public struct _rasterRgbColorCube
    {
        public RgbaColorDef ColorMin;
        public RgbaColorDef ColorMax;

        public _rasterRgbColorCube Read(BinaryReader br)
        {
            // read each field
            ColorMin = new RgbaColorDef().Read(br);
            ColorMax = new RgbaColorDef().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ColorMin >");
            ColorMin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ColorMax >");
            ColorMax.Dump(sw, level + 1);
        }
    }

    public struct _RasterRGBColorCube
    {
        public RgbaColorDef ColorMin;
        public RgbaColorDef ColorMax;

        public _RasterRGBColorCube Read(BinaryReader br)
        {
            // read each field
            ColorMin = new RgbaColorDef().Read(br);
            ColorMax = new RgbaColorDef().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ColorMin >");
            ColorMin.Dump(sw, level + 1);
            sw.WriteLine($"{ident}ColorMax >");
            ColorMax.Dump(sw, level + 1);
        }
    }

    public struct _RasterRGBTransparentColorDef
    {
        public _RasterRGBColorCube ColorCube;
        public Byte Transparency;
        public Byte[] Padding;

        public _RasterRGBTransparentColorDef Read(BinaryReader br)
        {
            // read each field
            ColorCube = new _RasterRGBColorCube().Read(br);
            Transparency = br.ReadByte();
            Padding = new Byte[7];
            for (int i = 0; i < 7; i++)
            {
                Padding[i] = br.ReadByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}ColorCube={ColorCube}");
            sw.WriteLine($"{ident}Transparency={Transparency}");
            for (int i = 0; i < 7; i++)
            {
                sw.WriteLine($"{ident}Padding={Padding[i]}");
            }
        }
    }

    public struct _transparentColors
    {
        public _RasterTransparentColorDef[] Index;
        public _RasterRGBTransparentColorDef[] Rgb;

        public _transparentColors Read(BinaryReader br)
        {
            // read each field
            Index = new _RasterTransparentColorDef[256];
            for (int i = 0; i < 256; i++)
            {
                Index[i] = new _RasterTransparentColorDef().Read(br);
            }
            Rgb = new _RasterRGBTransparentColorDef[32];
            for (int i = 0; i < 32; i++)
            {
                Rgb[i] = new _RasterRGBTransparentColorDef().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 256; i++)
            {
                sw.WriteLine($"{ident}Index={Index[i]}");
            }
            for (int i = 0; i < 32; i++)
            {
                sw.WriteLine($"{ident}Rgb={Rgb[i]}");
            }
        }
    }

    public struct DgnDocumentNameProperty
    {
        public WString M_name;

        public DgnDocumentNameProperty Read(BinaryReader br)
        {
            // read each field
            M_name = br.ReadString(); //Utils.Read<WString>(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_name={M_name}");
        }
    }

    public struct DependencyRootAssocPoint_I
    {
        public AssocPoint Assoc;
        public int I;
        public int I2;

        public DependencyRootAssocPoint_I Read(BinaryReader br)
        {
            // read each field
            Assoc = new AssocPoint().Read(br);
            I = br.ReadInt32();
            I2 = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Assoc >");
            Assoc.Dump(sw, level + 1);
            sw.WriteLine($"{ident}I={I}");
            sw.WriteLine($"{ident}I2={I2}");
        }
    }

    public struct ComponentInfo
    {
        public UInt32 Type;
        public UInt32 Id;
        public UInt32 LReserved1;
        public UInt32 LReserved2;
        public UInt32 LReserved3;
        public UInt32 LReserved4;
        public double Offset;
        public double DReserved1;
        public double DReserved2;
        public double DReserved3;

        public ComponentInfo Read(BinaryReader br)
        {
            // read each field
            Type = br.ReadUInt32();
            Id = br.ReadUInt32();
            LReserved1 = br.ReadUInt32();
            LReserved2 = br.ReadUInt32();
            LReserved3 = br.ReadUInt32();
            LReserved4 = br.ReadUInt32();
            Offset = br.ReadDouble();
            DReserved1 = br.ReadDouble();
            DReserved2 = br.ReadDouble();
            DReserved3 = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Type={Type}");
            sw.WriteLine($"{ident}Id={Id}");
            sw.WriteLine($"{ident}LReserved1={LReserved1}");
            sw.WriteLine($"{ident}LReserved2={LReserved2}");
            sw.WriteLine($"{ident}LReserved3={LReserved3}");
            sw.WriteLine($"{ident}LReserved4={LReserved4}");
            sw.WriteLine($"{ident}Offset={Offset}");
            sw.WriteLine($"{ident}DReserved1={DReserved1}");
            sw.WriteLine($"{ident}DReserved2={DReserved2}");
            sw.WriteLine($"{ident}DReserved3={DReserved3}");
        }
    }

    public struct LineStyleRsc
    {
        public sbyte[] Descr;
        public UInt32 __lHdr1;
        public UInt32 __lHdr2;
        public UInt32 AuxType;
        public UInt32 __auxID;
        public UInt32 __lRes1;
        public UInt32 __lRes2;
        public double DReserved1;
        public double DReserved2;
        public UInt32 __lRes3;
        public UInt32 NComp;
        public ComponentInfo[] Component;

        public LineStyleRsc Read(BinaryReader br)
        {
            // read each field
            Descr = new sbyte[128];
            for (int i = 0; i < 128; i++)
            {
                Descr[i] = br.ReadSByte();
            }
            __lHdr1 = br.ReadUInt32();
            __lHdr2 = br.ReadUInt32();
            AuxType = br.ReadUInt32();
            __auxID = br.ReadUInt32();
            __lRes1 = br.ReadUInt32();
            __lRes2 = br.ReadUInt32();
            DReserved1 = br.ReadDouble();
            DReserved2 = br.ReadDouble();
            __lRes3 = br.ReadUInt32();
            NComp = br.ReadUInt32();
            Component = new ComponentInfo[1];
            for (int i = 0; i < 1; i++)
            {
                Component[i] = new ComponentInfo().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 128; i++)
            {
                sw.WriteLine($"{ident}Descr={Descr[i]}");
            }
            sw.WriteLine($"{ident}__lHdr1={__lHdr1}");
            sw.WriteLine($"{ident}__lHdr2={__lHdr2}");
            sw.WriteLine($"{ident}AuxType={AuxType}");
            sw.WriteLine($"{ident}__auxID={__auxID}");
            sw.WriteLine($"{ident}__lRes1={__lRes1}");
            sw.WriteLine($"{ident}__lRes2={__lRes2}");
            sw.WriteLine($"{ident}DReserved1={DReserved1}");
            sw.WriteLine($"{ident}DReserved2={DReserved2}");
            sw.WriteLine($"{ident}__lRes3={__lRes3}");
            sw.WriteLine($"{ident}NComp={NComp}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Component >");
                Component[i].Dump(sw, level + 1);
            }
        }
    }

    public struct StrokeData
    {
        public double Length;
        public double Width;
        public double EndWidth;
        public double DReserved;
        public int LReserved1;
        public int LReserved2;
        public int LReserved3;
        public UInt8 StrokeMode;
        public UInt8 WidthMode;
        public UInt8 CapMode;
        public UInt8 BReserved;

        public StrokeData Read(BinaryReader br)
        {
            // read each field
            Length = br.ReadDouble();
            Width = br.ReadDouble();
            EndWidth = br.ReadDouble();
            DReserved = br.ReadDouble();
            LReserved1 = br.ReadInt32();
            LReserved2 = br.ReadInt32();
            LReserved3 = br.ReadInt32();
            StrokeMode = br.ReadByte();
            WidthMode = br.ReadByte();
            CapMode = br.ReadByte();
            BReserved = br.ReadByte();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Length={Length}");
            sw.WriteLine($"{ident}Width={Width}");
            sw.WriteLine($"{ident}EndWidth={EndWidth}");
            sw.WriteLine($"{ident}DReserved={DReserved}");
            sw.WriteLine($"{ident}LReserved1={LReserved1}");
            sw.WriteLine($"{ident}LReserved2={LReserved2}");
            sw.WriteLine($"{ident}LReserved3={LReserved3}");
            sw.WriteLine($"{ident}StrokeMode={StrokeMode}");
            sw.WriteLine($"{ident}WidthMode={WidthMode}");
            sw.WriteLine($"{ident}CapMode={CapMode}");
            sw.WriteLine($"{ident}BReserved={BReserved}");
        }
    }

    public struct LineCodeRsc
    {
        public sbyte[] Descr;
        public UInt32 LHdr1;
        public UInt32 LHdr2;
        public UInt32 AuxType;
        public UInt32 AuxID;
        public double Phase;
        public double OrgAngle_unused;
        public double EndAngle_unused;
        public double DReserved1;
        public double DReserved2;
        public double DReserved3;
        public UInt32 Options;
        public UInt32 MaxIterate;
        public UInt32 LReserved;
        public UInt32 NStrokes;
        public StrokeData[] Stroke;

        public LineCodeRsc Read(BinaryReader br)
        {
            // read each field
            Descr = new sbyte[128];
            for (int i = 0; i < 128; i++)
            {
                Descr[i] = br.ReadSByte();
            }
            LHdr1 = br.ReadUInt32();
            LHdr2 = br.ReadUInt32();
            AuxType = br.ReadUInt32();
            AuxID = br.ReadUInt32();
            Phase = br.ReadDouble();
            OrgAngle_unused = br.ReadDouble();
            EndAngle_unused = br.ReadDouble();
            DReserved1 = br.ReadDouble();
            DReserved2 = br.ReadDouble();
            DReserved3 = br.ReadDouble();
            Options = br.ReadUInt32();
            MaxIterate = br.ReadUInt32();
            LReserved = br.ReadUInt32();
            NStrokes = br.ReadUInt32();
            Stroke = new StrokeData[1];
            for (int i = 0; i < 1; i++)
            {
                Stroke[i] = new StrokeData().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 128; i++)
            {
                sw.WriteLine($"{ident}Descr={Descr[i]}");
            }
            sw.WriteLine($"{ident}LHdr1={LHdr1}");
            sw.WriteLine($"{ident}LHdr2={LHdr2}");
            sw.WriteLine($"{ident}AuxType={AuxType}");
            sw.WriteLine($"{ident}AuxID={AuxID}");
            sw.WriteLine($"{ident}Phase={Phase}");
            sw.WriteLine($"{ident}OrgAngle_unused={OrgAngle_unused}");
            sw.WriteLine($"{ident}EndAngle_unused={EndAngle_unused}");
            sw.WriteLine($"{ident}DReserved1={DReserved1}");
            sw.WriteLine($"{ident}DReserved2={DReserved2}");
            sw.WriteLine($"{ident}DReserved3={DReserved3}");
            sw.WriteLine($"{ident}Options={Options}");
            sw.WriteLine($"{ident}MaxIterate={MaxIterate}");
            sw.WriteLine($"{ident}LReserved={LReserved}");
            sw.WriteLine($"{ident}NStrokes={NStrokes}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Stroke >");
                Stroke[i].Dump(sw, level + 1);
            }
        }
    }

    public struct PointSymInfo
    {
        public UInt32 SymType;
        public UInt32 SymID;
        public UInt16 StrokeNo;
        public UInt16 Mod1;
        public UInt32 Mod2;
        public double XOffset;
        public double YOffset;
        public double ZOffset;
        public double XAngle;
        public double YAngle;
        public double ZAngle;
        public double XScale;
        public double YScale;
        public double ZScale;

        public PointSymInfo Read(BinaryReader br)
        {
            // read each field
            SymType = br.ReadUInt32();
            SymID = br.ReadUInt32();
            StrokeNo = br.ReadUInt16();
            Mod1 = br.ReadUInt16();
            Mod2 = br.ReadUInt32();
            XOffset = br.ReadDouble();
            YOffset = br.ReadDouble();
            ZOffset = br.ReadDouble();
            XAngle = br.ReadDouble();
            YAngle = br.ReadDouble();
            ZAngle = br.ReadDouble();
            XScale = br.ReadDouble();
            YScale = br.ReadDouble();
            ZScale = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SymType={SymType}");
            sw.WriteLine($"{ident}SymID={SymID}");
            sw.WriteLine($"{ident}StrokeNo={StrokeNo}");
            sw.WriteLine($"{ident}Mod1={Mod1}");
            sw.WriteLine($"{ident}Mod2={Mod2}");
            sw.WriteLine($"{ident}XOffset={XOffset}");
            sw.WriteLine($"{ident}YOffset={YOffset}");
            sw.WriteLine($"{ident}ZOffset={ZOffset}");
            sw.WriteLine($"{ident}XAngle={XAngle}");
            sw.WriteLine($"{ident}YAngle={YAngle}");
            sw.WriteLine($"{ident}ZAngle={ZAngle}");
            sw.WriteLine($"{ident}XScale={XScale}");
            sw.WriteLine($"{ident}YScale={YScale}");
            sw.WriteLine($"{ident}ZScale={ZScale}");
        }
    }

    public struct LinePointRsc
    {
        public sbyte[] Descr;
        public UInt32 LHdr1;
        public UInt32 LHdr2;
        public UInt32 AuxType;
        public UInt32 AuxID;
        public double DReserved1;
        public UInt32 LcType;
        public UInt32 LcID;
        public UInt32 LReserved1;
        public UInt32 NSym;
        public PointSymInfo[] Symbol;

        public LinePointRsc Read(BinaryReader br)
        {
            // read each field
            Descr = new sbyte[128];
            for (int i = 0; i < 128; i++)
            {
                Descr[i] = br.ReadSByte();
            }
            LHdr1 = br.ReadUInt32();
            LHdr2 = br.ReadUInt32();
            AuxType = br.ReadUInt32();
            AuxID = br.ReadUInt32();
            DReserved1 = br.ReadDouble();
            LcType = br.ReadUInt32();
            LcID = br.ReadUInt32();
            LReserved1 = br.ReadUInt32();
            NSym = br.ReadUInt32();
            Symbol = new PointSymInfo[1];
            for (int i = 0; i < 1; i++)
            {
                Symbol[i] = new PointSymInfo().Read(br);
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 128; i++)
            {
                sw.WriteLine($"{ident}Descr={Descr[i]}");
            }
            sw.WriteLine($"{ident}LHdr1={LHdr1}");
            sw.WriteLine($"{ident}LHdr2={LHdr2}");
            sw.WriteLine($"{ident}AuxType={AuxType}");
            sw.WriteLine($"{ident}AuxID={AuxID}");
            sw.WriteLine($"{ident}DReserved1={DReserved1}");
            sw.WriteLine($"{ident}LcType={LcType}");
            sw.WriteLine($"{ident}LcID={LcID}");
            sw.WriteLine($"{ident}LReserved1={LReserved1}");
            sw.WriteLine($"{ident}NSym={NSym}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}Symbol >");
                Symbol[i].Dump(sw, level + 1);
            }
        }
    }

    public struct T_DPoint3d
    {
        public double X;
        public double Y;
        public double Z;

        public T_DPoint3d Read(BinaryReader br)
        {
            // read each field
            X = br.ReadDouble();
            Y = br.ReadDouble();
            Z = br.ReadDouble();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}X={X}");
            sw.WriteLine($"{ident}Y={Y}");
            sw.WriteLine($"{ident}Z={Z}");
        }
    }

    public struct SymbolRange
    {
        public T_DPoint3d Low;
        public T_DPoint3d High;

        public SymbolRange Read(BinaryReader br)
        {
            // read each field
            Low = new T_DPoint3d().Read(br);
            High = new T_DPoint3d().Read(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Low={Low}");
            sw.WriteLine($"{ident}High={High}");
        }
    }

    public struct PointSymRsc_Header
    {
        public sbyte[] Descr;
        public UInt32 LHdr1;
        public UInt32 LHdr2;
        public UInt32 AuxType;
        public UInt32 AuxID;
        public SymbolRange Range;
        public T_DPoint3d Offset;
        public double Scale;
        public double[] DReserve;

        public PointSymRsc_Header Read(BinaryReader br)
        {
            // read each field
            Descr = new sbyte[128];
            for (int i = 0; i < 128; i++)
            {
                Descr[i] = br.ReadSByte();
            }
            LHdr1 = br.ReadUInt32();
            LHdr2 = br.ReadUInt32();
            AuxType = br.ReadUInt32();
            AuxID = br.ReadUInt32();
            Range = new SymbolRange().Read(br);
            Offset = new T_DPoint3d().Read(br);
            Scale = br.ReadDouble();
            DReserve = new double[12];
            for (int i = 0; i < 12; i++)
            {
                DReserve[i] = br.ReadDouble();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 128; i++)
            {
                sw.WriteLine($"{ident}Descr={Descr[i]}");
            }
            sw.WriteLine($"{ident}LHdr1={LHdr1}");
            sw.WriteLine($"{ident}LHdr2={LHdr2}");
            sw.WriteLine($"{ident}AuxType={AuxType}");
            sw.WriteLine($"{ident}AuxID={AuxID}");
            sw.WriteLine($"{ident}Range >");
            Range.Dump(sw, level + 1);
            sw.WriteLine($"{ident}Offset={Offset}");
            sw.WriteLine($"{ident}Scale={Scale}");
            for (int i = 0; i < 12; i++)
            {
                sw.WriteLine($"{ident}DReserve={DReserve[i]}");
            }
        }
    }

    public struct PointSymRsc
    {
        public PointSymRsc_Header Header;
        public UInt32 SymFlags;
        public UInt32 NBytes;
        public UInt8[] SymBuf;

        public PointSymRsc Read(BinaryReader br)
        {
            // read each field
            Header = new PointSymRsc_Header().Read(br);
            SymFlags = br.ReadUInt32();
            NBytes = br.ReadUInt32();
            SymBuf = new UInt8[8];
            for (int i = 0; i < 8; i++)
            {
                SymBuf[i] = br.ReadByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Header >");
            Header.Dump(sw, level + 1);
            sw.WriteLine($"{ident}SymFlags={SymFlags}");
            sw.WriteLine($"{ident}NBytes={NBytes}");
            for (int i = 0; i < 8; i++)
            {
                sw.WriteLine($"{ident}SymBuf={SymBuf[i]}");
            }
        }
    }

    public struct RasterLineStyleRsc
    {
        public sbyte[] Descr;
        public UInt32 LHdr1;
        public UInt32 LHdr2;
        public UInt32 AuxType;
        public UInt32 AuxID;
        public UInt32 M_flags;
        public Point2d M_size;
        public double M_trueWidth;
        public double[] M_reserved2;
        public UInt32[] M_reserved1;
        public UInt32 M_nImageBytes;
        public UInt8[] M_imageData;

        public RasterLineStyleRsc Read(BinaryReader br)
        {
            // read each field
            Descr = new sbyte[128];
            for (int i = 0; i < 128; i++)
            {
                Descr[i] = br.ReadSByte();
            }
            LHdr1 = br.ReadUInt32();
            LHdr2 = br.ReadUInt32();
            AuxType = br.ReadUInt32();
            AuxID = br.ReadUInt32();
            M_flags = br.ReadUInt32();
            M_size = new Point2d().Read(br);
            M_trueWidth = br.ReadDouble();
            M_reserved2 = new double[4];
            for (int i = 0; i < 4; i++)
            {
                M_reserved2[i] = br.ReadDouble();
            }
            M_reserved1 = new UInt32[4];
            for (int i = 0; i < 4; i++)
            {
                M_reserved1[i] = br.ReadUInt32();
            }
            M_nImageBytes = br.ReadUInt32();
            M_imageData = new UInt8[1];
            for (int i = 0; i < 1; i++)
            {
                M_imageData[i] = br.ReadByte();
            }
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            for (int i = 0; i < 128; i++)
            {
                sw.WriteLine($"{ident}Descr={Descr[i]}");
            }
            sw.WriteLine($"{ident}LHdr1={LHdr1}");
            sw.WriteLine($"{ident}LHdr2={LHdr2}");
            sw.WriteLine($"{ident}AuxType={AuxType}");
            sw.WriteLine($"{ident}AuxID={AuxID}");
            sw.WriteLine($"{ident}M_flags={M_flags}");
            sw.WriteLine($"{ident}M_size >");
            M_size.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_trueWidth={M_trueWidth}");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}M_reserved2={M_reserved2[i]}");
            }
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine($"{ident}M_reserved1={M_reserved1[i]}");
            }
            sw.WriteLine($"{ident}M_nImageBytes={M_nImageBytes}");
            for (int i = 0; i < 1; i++)
            {
                sw.WriteLine($"{ident}M_imageData={M_imageData[i]}");
            }
        }
    }

    public struct RefDisplayFlags
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        private const int sz_1_3 = 1, loc_1_3 = loc_1_2 + sz_1_2, mask_1_3 = unchecked(((1 << sz_1_3) - 1) << loc_1_3);
        private const int sz_1_4 = 1, loc_1_4 = loc_1_3 + sz_1_3, mask_1_4 = unchecked(((1 << sz_1_4) - 1) << loc_1_4);
        private const int sz_1_5 = 1, loc_1_5 = loc_1_4 + sz_1_4, mask_1_5 = unchecked(((1 << sz_1_5) - 1) << loc_1_5);
        private const int sz_1_6 = 1, loc_1_6 = loc_1_5 + sz_1_5, mask_1_6 = unchecked(((1 << sz_1_6) - 1) << loc_1_6);
        private const int sz_1_7 = 1, loc_1_7 = loc_1_6 + sz_1_6, mask_1_7 = unchecked(((1 << sz_1_7) - 1) << loc_1_7);
        private const int sz_1_8 = 1, loc_1_8 = loc_1_7 + sz_1_7, mask_1_8 = unchecked(((1 << sz_1_8) - 1) << loc_1_8);
        private const int sz_1_9 = 1, loc_1_9 = loc_1_8 + sz_1_8, mask_1_9 = unchecked(((1 << sz_1_9) - 1) << loc_1_9);
        private const int sz_1_10 = 1, loc_1_10 = loc_1_9 + sz_1_9, mask_1_10 = unchecked(((1 << sz_1_10) - 1) << loc_1_10);
        private const int sz_1_11 = 1, loc_1_11 = loc_1_10 + sz_1_10, mask_1_11 = unchecked(((1 << sz_1_11) - 1) << loc_1_11);
        private const int sz_1_12 = 1, loc_1_12 = loc_1_11 + sz_1_11, mask_1_12 = unchecked(((1 << sz_1_12) - 1) << loc_1_12);
        private const int sz_1_13 = 1, loc_1_13 = loc_1_12 + sz_1_12, mask_1_13 = unchecked(((1 << sz_1_13) - 1) << loc_1_13);
        private const int sz_1_14 = 1, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        private const int sz_1_17 = 1, loc_1_17 = loc_1_16 + sz_1_16, mask_1_17 = unchecked(((1 << sz_1_17) - 1) << loc_1_17);
        private const int sz_1_18 = 2, loc_1_18 = loc_1_17 + sz_1_17, mask_1_18 = unchecked(((1 << sz_1_18) - 1) << loc_1_18);
        private const int sz_1_19 = 2, loc_1_19 = loc_1_18 + sz_1_18, mask_1_19 = unchecked(((1 << sz_1_19) - 1) << loc_1_19);
        private const int sz_1_20 = 1, loc_1_20 = loc_1_19 + sz_1_19, mask_1_20 = unchecked(((1 << sz_1_20) - 1) << loc_1_20);
        private const int sz_1_21 = 9, loc_1_21 = loc_1_20 + sz_1_20, mask_1_21 = unchecked(((1 << sz_1_21) - 1) << loc_1_21);
        public UInt32 SymbologySet
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 HiliteBoundary
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 DisplayHilitedManip
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 DisplayHilitedSelected
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 DontUpdateChildren
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 Redundant
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 MissingModel
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 RightNotGranted
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 NamedGroupFound
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 RevisionNotAvailable
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 ResolvedHistoryTag
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 RevisionFromParent
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 FindModelByID
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 MissingGeoCoordApp
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 MissingGeoCoordSys
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 IsCircular
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 CalculatedTransformUsed
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }
        public UInt32 NamedGroupProcessingComplete
        {
            get => (UInt32)(Data1 & mask_1_17) >> loc_1_17;
            set => Data1 = (UInt32)(Data1 & ~mask_1_17 | (value << loc_1_17) & mask_1_17);
        }
        public UInt32 HiddenLineCaching
        {
            get => (UInt32)(Data1 & mask_1_18) >> loc_1_18;
            set => Data1 = (UInt32)(Data1 & ~mask_1_18 | (value << loc_1_18) & mask_1_18);
        }
        public UInt32 ProxyCacheSynchOption
        {
            get => (UInt32)(Data1 & mask_1_19) >> loc_1_19;
            set => Data1 = (UInt32)(Data1 & ~mask_1_19 | (value << loc_1_19) & mask_1_19);
        }
        public UInt32 DontAddRefClip
        {
            get => (UInt32)(Data1 & mask_1_20) >> loc_1_20;
            set => Data1 = (UInt32)(Data1 & ~mask_1_20 | (value << loc_1_20) & mask_1_20);
        }
        public UInt32 Unused
        {
            get => (UInt32)(Data1 & mask_1_21) >> loc_1_21;
            set => Data1 = (UInt32)(Data1 & ~mask_1_21 | (value << loc_1_21) & mask_1_21);
        }

        public RefDisplayFlags Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}SymbologySet={SymbologySet}");
            sw.WriteLine($"{ident}HiliteBoundary={HiliteBoundary}");
            sw.WriteLine($"{ident}DisplayHilitedManip={DisplayHilitedManip}");
            sw.WriteLine($"{ident}DisplayHilitedSelected={DisplayHilitedSelected}");
            sw.WriteLine($"{ident}DontUpdateChildren={DontUpdateChildren}");
            sw.WriteLine($"{ident}Redundant={Redundant}");
            sw.WriteLine($"{ident}MissingModel={MissingModel}");
            sw.WriteLine($"{ident}RightNotGranted={RightNotGranted}");
            sw.WriteLine($"{ident}NamedGroupFound={NamedGroupFound}");
            sw.WriteLine($"{ident}RevisionNotAvailable={RevisionNotAvailable}");
            sw.WriteLine($"{ident}ResolvedHistoryTag={ResolvedHistoryTag}");
            sw.WriteLine($"{ident}RevisionFromParent={RevisionFromParent}");
            sw.WriteLine($"{ident}FindModelByID={FindModelByID}");
            sw.WriteLine($"{ident}MissingGeoCoordApp={MissingGeoCoordApp}");
            sw.WriteLine($"{ident}MissingGeoCoordSys={MissingGeoCoordSys}");
            sw.WriteLine($"{ident}IsCircular={IsCircular}");
            sw.WriteLine($"{ident}CalculatedTransformUsed={CalculatedTransformUsed}");
            sw.WriteLine($"{ident}NamedGroupProcessingComplete={NamedGroupProcessingComplete}");
            sw.WriteLine($"{ident}HiddenLineCaching={HiddenLineCaching}");
            sw.WriteLine($"{ident}ProxyCacheSynchOption={ProxyCacheSynchOption}");
            sw.WriteLine($"{ident}DontAddRefClip={DontAddRefClip}");
            sw.WriteLine($"{ident}Unused={Unused}");
        }
    }

    public struct SchemaNameClassNamePair
    {
        public WString M_schemaName;
        public WString M_className;

        public SchemaNameClassNamePair Read(BinaryReader br)
        {
            // read each field
            M_schemaName = br.ReadString(); //Utils.Read<WString>(br);
            M_className = br.ReadString(); //Utils.Read<WString>(br);
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_schemaName={M_schemaName}");
            sw.WriteLine($"{ident}M_className={M_className}");
        }
    }

    public struct SearchClass
    {
        public SchemaNameClassNamePair M_class;
        public bool M_isPolymorphic;

        public SearchClass Read(BinaryReader br)
        {
            // read each field
            M_class = new SchemaNameClassNamePair().Read(br);
            M_isPolymorphic = br.ReadBoolean();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}M_class >");
            M_class.Dump(sw, level + 1);
            sw.WriteLine($"{ident}M_isPolymorphic={M_isPolymorphic}");
        }
    }

    public struct DimStringConfig
    {
        private UInt32 Data1;
        private const int sz_1_0 = 1, loc_1_0 = 0, mask_1_0 = unchecked(((1 << sz_1_0) - 1) << loc_1_0);
        private const int sz_1_1 = 1, loc_1_1 = loc_1_0 + sz_1_0, mask_1_1 = unchecked(((1 << sz_1_1) - 1) << loc_1_1);
        private const int sz_1_2 = 1, loc_1_2 = loc_1_1 + sz_1_1, mask_1_2 = unchecked(((1 << sz_1_2) - 1) << loc_1_2);
        public UInt32 Dual
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 Tolerance
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 Limit
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }

        public DimStringConfig Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}Dual={Dual}");
            sw.WriteLine($"{ident}Tolerance={Tolerance}");
            sw.WriteLine($"{ident}Limit={Limit}");
        }
    }

    public struct LineStyleNameInfo
    {
        public UInt32 RscFile;
        public UInt32 RscType;
        public ElementId RscID;
        public UInt32 Attributes;
        public int StyleID;

        public LineStyleNameInfo Read(BinaryReader br)
        {
            // read each field
            RscFile = br.ReadUInt32();
            RscType = br.ReadUInt32();
            RscID = br.ReadUInt64();
            Attributes = br.ReadUInt32();
            StyleID = br.ReadInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}RscFile={RscFile}");
            sw.WriteLine($"{ident}RscType={RscType}");
            sw.WriteLine($"{ident}RscID={RscID}");
            sw.WriteLine($"{ident}Attributes={Attributes}");
            sw.WriteLine($"{ident}StyleID={StyleID}");
        }
    }
}
