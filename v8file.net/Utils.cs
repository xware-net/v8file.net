﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace v8file.net
{
    public class Utils
    {
        public struct SYSTEMTIME
        {
            internal short wYear;
            internal short wMonth;
            internal short wDayOfWeek;
            internal short wDay;
            internal short wHour;
            internal short wMinute;
            internal short wSecond;
            internal short wMilliseconds;
        }

        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToFileTime", SetLastError = true)]
        private static extern bool SystemTimeToFileTime(ref SYSTEMTIME lpSystemTime, ref System.Runtime.InteropServices.ComTypes.FILETIME lpFileTime);

        [DllImport("kernel32.dll")]
        private static extern bool FileTimeToLocalFileTime([In] ref System.Runtime.InteropServices.ComTypes.FILETIME lpFileTime, out System.Runtime.InteropServices.ComTypes.FILETIME lpLocalFileTime);

        [DllImport("kernel32.dll")]
        private static extern long FileTimeToSystemTime(ref System.Runtime.InteropServices.ComTypes.FILETIME FileTime, ref SYSTEMTIME SystemTime);

        static readonly string[] days =
       {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        static readonly string[] months =
        {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"
        };

        public static string V8BentleyTime(double milliseconds)
        {
            if (milliseconds == 0.0)
                return "None";

            SYSTEMTIME st;
            System.Runtime.InteropServices.ComTypes.FILETIME ft = new();
            Int64 y, x;
            Int64 q = (Int64)(milliseconds);

            st = new SYSTEMTIME
            {
                wYear = 1970,
                wMonth = 1,
                wDay = 1
            };

            SystemTimeToFileTime(ref st, ref ft);
            x = ((Int64)(ft.dwHighDateTime) << 32) | ((Int64)ft.dwLowDateTime & 0x00000000ffffffff);
            y = x + 10000 * q;

            ft.dwHighDateTime = (Int32)(((UInt64)y & 0xffffffff00000000) >> 32);
            ft.dwLowDateTime = (Int32)(y & 0x00000000ffffffff);
            FileTimeToLocalFileTime(ref ft, out System.Runtime.InteropServices.ComTypes.FILETIME lft);
            FileTimeToSystemTime(ref lft, ref st);
            string bt = string.Format("{0}, {1}-{2}-{3}, {4}:{5}:{6}:{7}", days[st.wDayOfWeek], st.wDay, months[st.wMonth - 1], st.wYear, st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);
            return bt;
        }

        public static int V8Power2(int x)
        {
            int pwr = 1;
            int xx = x;

            while (xx > 0)
            {
                pwr *= 2;
                xx--;
            }

            return pwr;
        }

        public static string V8GetElmType(Elm_hdr ehdr)
        {
            return ehdr.Type switch
            {
                1 => "CELL_LIB_ELM",
                2 => "CELL_HEADER_ELM",
                3 => "LINE_ELM",
                4 => "LINE_STRING_ELM",
                5 => ehdr.Level switch
                {
                    1 => "GROUP_DATA_ELM (COLOR_TABLE_ELM)",
                    3 => "GROUP_DATA_ELM (ACS_ELM)",
                    _ => $"???",
                },
                6 => "SHAPE_ELM",
                7 => "TEXT_NODE_ELM",
                8 => "DIG_SETDATA_ELM",
                9 => "DGNFIL_HEADER_ELM",
                10 => "LEV_SYM_ELM",
                11 => "CURVE_ELM",
                12 => "CMPLX_STRING_ELM",
                13 => "CONIC_ELM",
                14 => "CMPLX_SHAPE_ELM",
                15 => "ELLIPSE_ELM",
                16 => "ARC_ELM",
                17 => "TEXT_ELM",
                18 => "SURFACE_ELM",
                19 => "SOLID_ELM",
                21 => "BSPLINE_POLE_ELM",
                22 => "POINT_STRING_ELM",
                23 => "CONE_ELM",
                24 => "BSPLINE_SURFACE_ELM",
                25 => "BSURF_BOUNDARY_ELM",
                26 => "BSPLINE_KNOT_ELM",
                27 => "BSPLINE_CURVE_ELM",
                28 => "BSPLINE_WEIGHT_ELM",
                33 => "DIMENSION_ELM",
                34 => "SHAREDCELL_DEF_ELM",
                35 => "SHARED_CELL_ELM",
                36 => "MULTILINE_ELM",
                37 => "ATTRIBUTE_ELM",
                38 => "DGNSTORE_COMP",
                39 => "DGNSTORE_HDR",
                44 => "TYPE44_ELM",
                66 => "MICROSTATION_ELM",
                87 => "RASTER_HDR",
                88 => "RASTER_COMP",
                90 => "RASTER_REFERENCE_ELM",
                91 => "RASTER_REFERENCE_COMP",
                92 => "RASTER_HIERARCHY_ELM",
                93 => "RASTER_HIERARCHY_COMP",
                94 => "RASTER_FRAME_ELM",
                95 => ehdr.Level switch
                {
                    1 => "MS_LEVEL_TABLE_ENTRY",
                    2 => "MS_FONT_TABLE_ENTRY",
                    3 => "MS_TEXTSTYLE_TABLE_ENTRY",
                    4 => "MS_FILTER_TABLE_ENTRY",
                    5 => "MS_DIMSTYLE_TABLE_ENTRY",
                    6 => "MS_MLINESTYLE_TABLE_ENTRY",
                    7 => "MS_LSTYLE_NAME_ENTRY",
                    8 => "MS_LSTYLE_DEF_ENTRY",
                    9 => "MS_DICTIONARY_TABLE_ENTRY",
                    10 => "MS_REGAPP_TABLE_ENTRY",
                    11 => "MS_COLORBOOK_TABLE_ENTRY",
                    12 => "MS_CUSTOM_RENDERMODE_ENTRY",
                    16 => "MS_SYMBOLSTYLE_TABLE_ENTRY",
                    17 => "MS_COLORBOOK_ENTRY",
                    18 => "MS_MATERIAL_PALETTE_ENTRY",
                    19 => "MS_LEVEL_NAME_DICTIONARY_TABLE_ENTRY",
                    20 => "MS_ANIMATION_PARAMETER_TABLE_ENTRY",
                    21 => "MS_ANIMATION_SCHEDULEINFO_TABLE_ENTRY",
                    22 => "MS_RENDERSETUP_ENTRY",
                    23 => "MS_LIGHTSETUP_ENTRY",
                    24 => "MS_NAMED_PRESENTATION_TABLE_ENTRY",
                    _ => $"???",
                },
                96 => ehdr.Level switch
                {
                    1 => "MS_LEVEL_TABLE",
                    2 => "MS_FONT_TABLE",
                    3 => "MS_TEXTSTYLE_TABLE",
                    4 => "MS_FILTER_TABLE",
                    5 => "MS_DIMSTYLE_TABLE",
                    6 => "MS_MLINESTYLE_TABLE",
                    7 => "MS_LSTYLE_NAME",
                    8 => "MS_LSTYLE_DEF",
                    9 => "MS_DICTIONARY_TABLE",
                    10 => "MS_REGAPP_TABLE",
                    11 => "MS_COLORBOOK_TABLE",
                    12 => "MS_CUSTOM_RENDERMODE",
                    16 => "MS_SYMBOLSTYLE_TABLE",
                    17 => "MS_COLORBOOK",
                    18 => "MS_MATERIAL_PALETTE",
                    19 => "MS_LEVEL_NAME_DICTIONARY_TABLE",
                    20 => "MS_ANIMATION_PARAMETER_TABLE",
                    21 => "MS_ANIMATION_SCHEDULEINFO_TABLE",
                    22 => "MS_RENDERSETUP",
                    23 => "MS_LIGHTSETUP",
                    24 => "MS_NAMED_PRESENTATION_TABLE",
                    _ => $"???",
                },
                97 => "VIEW_GROUP_ELM",
                98 => "VIEW_ELM",
                99 => "LEVEL_MASK_ELM",
                100 => "REFERENCE_ATTACH_ELM",
                101 => "MATRIX_HEADER_ELM",
                102 => "MATRIX_INT_DATA_ELM",
                103 => "MATRIX_DOUBLE_DATA_ELM",
                105 => "MESH_HEADER_ELM",
                106 => "EXTENDED_ELM",
                107 => "EXTENDED_NONGRAPHIC_ELM",
                108 => "REFERENCE_OVERRIDE_ELM",
                110 => "NAMED_GROUP_HDR_ELM",
                111 => "NAMED_GROUP_COMPONENT_ELM",
                _ => $"??? {ehdr.Type} ({ehdr.Type:X2})",
            };
        }

        private static Dictionary<Tuple<int, string, string>, List<string>> elementsWithIdAndTypeAndLevel = new();
        private static Dictionary<Tuple<int, string, string>, List<string>> linkagesWithIdAndTypeAndLevel = new();

        public static Dictionary<Tuple<int, string, string>, List<string>> ElementsWithIdAndTypeAndLevel { get => elementsWithIdAndTypeAndLevel; set => elementsWithIdAndTypeAndLevel = value; }
        public static Dictionary<Tuple<int, string, string>, List<string>> LinkagesWithIdAndTypeAndLevel { get => linkagesWithIdAndTypeAndLevel; set => linkagesWithIdAndTypeAndLevel = value; }

        public static void WriteOutBytes(byte[] bytes, string fileName)
        {
            using BinaryWriter bw = new(File.Open(fileName, FileMode.Create));
            bw.Write(bytes, 0, bytes.Length);
        }

        public static void WriteOut(byte[] bytes, string fileName, int elementType, string elementId, string levelId)
        {
            // get actual element id from bytes
            BinaryReader br = new(new MemoryStream(bytes));
            var actualType = br.ReadInt16();
            br.BaseStream.Seek(12, SeekOrigin.Begin);
            var actualLevelId = br.ReadInt32();
            var actualLevelIdString = actualLevelId.ToString("X8").ToUpper();
            br.BaseStream.Seek(16, SeekOrigin.Begin);
            var actualElementId = br.ReadUInt64();
            var actualElementIdString = actualElementId.ToString("X16").ToUpper();
            if (elementId == "*")
            {
                if (levelId == "*")
                {
                    if (actualType == elementType)
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "." + elementType.ToString();
                        using BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(bytes, 0, bytes.Length);
                        AddToElementDictionary(actualType, levelId, actualElementIdString, newFileName);
                    }
                }
                else
                {
                    if ((actualType == elementType) && (actualLevelId == Convert.ToInt32(levelId)))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "_" + actualLevelIdString + "." + elementType.ToString();
                        using BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(bytes, 0, bytes.Length);
                        AddToElementDictionary(actualType, levelId, actualElementIdString, newFileName);
                    }
                }
            }
            else
            {
                if (levelId == "*")
                {
                    if ((actualElementIdString == elementId) && (actualType == elementType))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "." + elementType.ToString();
                        BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(bytes, 0, bytes.Length);
                        AddToElementDictionary(actualType, levelId, actualElementIdString, newFileName);
                    }
                }
                else
                {
                    if ((actualElementIdString == elementId) && (actualType == elementType) && (actualLevelId == Convert.ToInt32(levelId)))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "_" + actualLevelIdString + "." + elementType.ToString();
                        BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(bytes, 0, bytes.Length);
                        AddToElementDictionary(actualType, levelId, actualElementIdString, newFileName);
                    }
                }
            }
        }

        private static void AddToElementDictionary(int actualType, string lLevelId, string elementId, string name)
        {
            // name ends in .elementType ???
            var key = new Tuple<int, string, string>(actualType, lLevelId, elementId);
            if (!elementsWithIdAndTypeAndLevel.ContainsKey(key))
            {
                elementsWithIdAndTypeAndLevel.Add(key, new List<string>());
            }

            if (!elementsWithIdAndTypeAndLevel[key].Contains(name))
            {
                elementsWithIdAndTypeAndLevel[key].Add(name);
            }
        }

        public static void WriteOutAttr(byte[] bytes, string fileName, int elementType, string elementId, string levelId, Linkage linkage)
        {
            // get actual element id from bytes
            BinaryReader br = new(new MemoryStream(bytes));
            var actualType = br.ReadInt16();
            br.BaseStream.Seek(12, SeekOrigin.Begin);
            var actualLevelId = br.ReadInt32();
            var actualLevelIdString = actualLevelId.ToString("X8").ToUpper();
            br.BaseStream.Seek(16, SeekOrigin.Begin);
            var actualElementId = br.ReadUInt64();
            var actualElementIdString = actualElementId.ToString("X16").ToUpper();
            if (elementId == "*")
            {
                if (levelId == "*")
                {
                    if (actualType == elementType)
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "." + linkage.LinkageHeader.PrimaryID.ToString("X4");
                        using BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(linkage.Data, 0, linkage.Data.Length);
                        AddToLinkagesDictionary(actualType, actualLevelIdString, actualElementIdString, newFileName);
                    }
                }
                else
                {
                    if ((actualType == elementType) && (actualLevelId == Convert.ToInt32(levelId)))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "_" + actualLevelIdString + "." + linkage.LinkageHeader.PrimaryID.ToString("X4");
                        using BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(linkage.Data, 0, linkage.Data.Length);
                        AddToLinkagesDictionary(actualType, actualLevelIdString, actualElementIdString, newFileName);
                    }
                }
            }
            else
            {
                if (levelId == "*")
                {
                    if ((actualElementIdString == elementId) && (actualType == elementType))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "." + linkage.LinkageHeader.PrimaryID.ToString("X4");
                        BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(linkage.Data, 0, linkage.Data.Length);
                        AddToLinkagesDictionary(actualType, actualLevelIdString, actualElementIdString, newFileName);
                    }
                }
                else
                {
                    if ((actualElementIdString == elementId) && (actualType == elementType) && (actualLevelId == Convert.ToInt32(levelId)))
                    {
                        string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + actualElementIdString + "_" + actualLevelIdString + "." + linkage.LinkageHeader.PrimaryID.ToString("X4");
                        BinaryWriter bw = new(File.Open(newFileName, FileMode.Create));
                        bw.Write(linkage.Data, 0, linkage.Data.Length);
                        AddToLinkagesDictionary(actualType, actualLevelIdString, actualElementIdString, newFileName);
                    }
                }
            }
        }

        public static void AddToLinkagesDictionary(short actualType, string levelId, string elementId, string name)
        {
            // name ends in .linkageid (4 hex digits)
            var key = new Tuple<int, string, string>(actualType, levelId, elementId);
            if (!linkagesWithIdAndTypeAndLevel.ContainsKey(key))
            {
                linkagesWithIdAndTypeAndLevel.Add(key, new List<string>());
            }

            if (!linkagesWithIdAndTypeAndLevel[key].Contains(name))
            {
                linkagesWithIdAndTypeAndLevel[key].Add(name);
            }
        }

        public static string HexDump(byte[] bytes, int level = 0, int bytesPerLine = 16)
        {
            var ident = new String(' ', 2 * level);
            if (bytes == null)
                return $"{ident}<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  2 * level
                + 8                                         // 8 characters for the address
                + 3;                                        // 3 spaces

            int firstCharColumn =
                firstHexColumn
                + bytesPerLine * 3                          // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8                    // - 1 extra space every 8 characters from the 9th
                + 2;                                        // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine                              // - characters to show the ascii value
                + Environment.NewLine.Length;               // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[2 * level + 0] = HexChars[(i >> 28) & 0xF];
                line[2 * level + 1] = HexChars[(i >> 24) & 0xF];
                line[2 * level + 2] = HexChars[(i >> 20) & 0xF];
                line[2 * level + 3] = HexChars[(i >> 16) & 0xF];
                line[2 * level + 4] = HexChars[(i >> 12) & 0xF];
                line[2 * level + 5] = HexChars[(i >> 8) & 0xF];
                line[2 * level + 6] = HexChars[(i >> 4) & 0xF];
                line[2 * level + 7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '.' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }

                result.Append(line);
            }

            return result.ToString();
        }

        public static byte[] GetBytes<T>(T str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
    }
}
