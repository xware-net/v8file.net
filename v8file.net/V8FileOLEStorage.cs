using Ionic.Zlib;
using NLog;
using OpenMcdf;
using OpenMcdf.Extensions;
using OpenMcdf.Extensions.OLEProperties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static OpenMcdf.Extensions.OLEProperties.OLEPropertiesContainer;

namespace v8file.net
{
    public class V8FileOLEStorage
    {
        [Flags]
        public enum Stgm : int
        {
            Direct = 0x00000000,
            Transacted = 0x00010000,
            Simple = 0x08000000,
            Read = 0x00000000,
            Write = 0x00000001,
            Readwrite = 0x00000002,
            ShareDenyNone = 0x00000040,
            ShareDenyRead = 0x00000030,
            ShareDenyWrite = 0x00000020,
            ShareExclusive = 0x00000010,
            Priority = 0x00040000,
            Deleteonrelease = 0x04000000,
            Noscratch = 0x00100000,
            Create = 0x00001000,
            Convert = 0x00020000,
            Failifthere = 0x00000000,
            Nosnapshot = 0x00200000,
            DirectSwmr = 0x00400000,
        }

        [ComImport, Guid("0000000c-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IStream
        {
            void Read([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, uint cb, out uint pcbRead);
            void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, uint cb, out uint pcbWritten);
            void Seek(long dlibMove, uint dwOrigin, out long plibNewPosition);
            void SetSize(long libNewSize);
            void CopyTo(IStream pstm, long cb, out long pcbRead, out long pcbWritten);
            void Commit(uint grfCommitFlags);
            void Revert();
            void LockRegion(long libOffset, long cb, uint dwLockType);
            void UnlockRegion(long libOffset, long cb, uint dwLockType);
            void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, uint grfStatFlag);
            void Clone(out IStream ppstm);
        }

        [ComImport]
        [Guid("0000000d-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IEnumSTATSTG
        {
            // The user needs to allocate an System.Runtime.InteropServices.ComTypes.STATSTG array whose size is celt.
            [PreserveSig]
            uint
                Next(
                    uint celt,
                    [MarshalAs(UnmanagedType.LPArray), Out]
                    System.Runtime.InteropServices.ComTypes.STATSTG[] rgelt,
                    out uint pceltFetched
                );

            void Skip(uint celt);

            void Reset();

            [return: MarshalAs(UnmanagedType.Interface)]
            IEnumSTATSTG Clone();
        }

        [ComImport]
        [Guid("0000000b-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IStorage
        {
            void CreateStream(
                /* [string][in] */ string pwcsName,
                /* [in] */ uint grfMode,
                /* [in] */ uint reserved1,
                /* [in] */ uint reserved2,
                /* [out] */ out IStream ppstm);

            void OpenStream(
                /* [string][in] */ string pwcsName,
                /* [unique][in] */ IntPtr reserved1,
                /* [in] */ uint grfMode,
                /* [in] */ uint reserved2,
                /* [out] */ out IStream ppstm);

            void CreateStorage(
                /* [string][in] */ string pwcsName,
                /* [in] */ uint grfMode,
                /* [in] */ uint reserved1,
                /* [in] */ uint reserved2,
                /* [out] */ out IStorage ppstg);

            void OpenStorage(
                /* [string][unique][in] */ string pwcsName,
                /* [unique][in] */ IStorage pstgPriority,
                /* [in] */ uint grfMode,
                /* [unique][in] */ IntPtr snbExclude,
                /* [in] */ uint reserved,
                /* [out] */ out IStorage ppstg);

            void CopyTo(
                /* [in] */ uint ciidExclude,
                /* [size_is][unique][in] */ [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] rgiidExclude,
                /* [unique][in] */ IntPtr snbExclude,
                /* [unique][in] */ IStorage pstgDest);

            void MoveElementTo(
                /* [string][in] */ string pwcsName,
                /* [unique][in] */ IStorage pstgDest,
                /* [string][in] */ string pwcsNewName,
                /* [in] */ uint grfFlags);

            void Commit(
                /* [in] */ uint grfCommitFlags);

            void Revert();

            void EnumElements(
                /* [in] */ uint reserved1,
                /* [size_is][unique][in] */ IntPtr reserved2,
                /* [in] */ uint reserved3,
                /* [out] */ out IEnumSTATSTG ppenum);

            void DestroyElement(
                /* [string][in] */ string pwcsName);

            void RenameElement(
                /* [string][in] */ string pwcsOldName,
                /* [string][in] */ string pwcsNewName);

            void SetElementTimes(
                /* [string][unique][in] */ string pwcsName,
                /* [unique][in] */ System.Runtime.InteropServices.ComTypes.FILETIME pctime,
                /* [unique][in] */ System.Runtime.InteropServices.ComTypes.FILETIME patime,
                /* [unique][in] */ System.Runtime.InteropServices.ComTypes.FILETIME pmtime);

            void SetClass(
                /* [in] */ Guid clsid);

            void SetStateBits(
                /* [in] */ uint grfStateBits,
                /* [in] */ uint grfMask);

            void Stat(
                /* [out] */ out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg,
                /* [in] */ uint grfStatFlag);

        }

        public enum Stgty
        {
            StgtyStorage = 1,
            StgtyStream = 2,
            StgtyLockbytes = 3,
            StgtyProperty = 4
        };


        [DllImport("ole32.dll", PreserveSig = false)]
        private static extern void StgOpenStorage([MarshalAs(UnmanagedType.LPWStr)] string pwcsName,
            IStorage pstgPriority, Stgm grfMode, IntPtr snbExclude, uint reserved,
            out IStorage ppstgOpen);

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static SummaryInfoProperties summaryInfoProperties;
        private static DocumentSummaryInfoProperties documentSummaryInfoProperties;
        private static string FileName;

        public const int MSuccess = 0;
        public const int MError = 0x8000;

        public static int V8DgnBreak(string fileName)
        {
            System.Runtime.InteropServices.ComTypes.STATSTG[] entry = new System.Runtime.InteropServices.ComTypes.STATSTG[1];
            uint numReturned;
            string[] typnam = { "STGTY_STORAGE", "STGTY_STREAM", "STGTY_LOCKBYTES", "STGTY_PROPERTY" };
            bool v8Dgn = false;

            StgOpenStorage(fileName, null, Stgm.Read | Stgm.ShareDenyWrite, IntPtr.Zero, 0, out IStorage storage);
            storage.EnumElements(0, IntPtr.Zero, 0, out IEnumSTATSTG pEnum);
            do
            {
                pEnum.Next(1, entry, out numReturned);
                if (numReturned != 0)
                {
                    switch (entry[0].type)
                    {
                        case (int)Stgty.StgtyStorage:
                            if (entry[0].pwcsName == "Dgn-Md")
                            {
                                v8Dgn = true;
                            }

                            break;
                        case (int)Stgty.StgtyStream:
                            break;
                        case (int)Stgty.StgtyLockbytes:
                            break;
                        case (int)Stgty.StgtyProperty:
                            break;
                    }
                }
            } while (numReturned > 0);

            Marshal.ReleaseComObject(pEnum);
            Marshal.ReleaseComObject(storage);
            GC.Collect();
            GC.Collect();  // call twice for good measure
            GC.WaitForPendingFinalizers();

            if (!v8Dgn)
                return MError;

            StgOpenStorage(fileName, null, Stgm.Read | Stgm.ShareDenyWrite, IntPtr.Zero, 0, out storage);
            storage.EnumElements(0, IntPtr.Zero, 0, out pEnum);
            do
            {
                pEnum.Next(1, entry, out numReturned);
                if (numReturned != 0)
                {
                    Logger.Info("{0}, type={1}, size={2}", entry[0].pwcsName, typnam[entry[0].type - 1], entry[0].cbSize);
                    switch (entry[0].type)
                    {
                        case (int)Stgty.StgtyStorage:
                            V8RecurseStorage(storage, "", entry[0].pwcsName, 1);
                            break;
                        case (int)Stgty.StgtyStream:
                            {
                                string pwzStream = entry[0].pwcsName;
                                uint cbSize = (uint)entry[0].cbSize;
                                byte[] buf = new byte[cbSize];
                                storage.OpenStream(entry[0].pwcsName, IntPtr.Zero, (uint)(Stgm.Read | Stgm.ShareExclusive), 0, out IStream stream);
                                stream.Read(buf, cbSize, out var cbRead);
                                pwzStream = pwzStream.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_');
                                if (!pwzStream.StartsWith("$"))
                                    V8DecodeAndWrite(pwzStream, buf, cbRead);
                                Marshal.ReleaseComObject(stream);
                            }
                            break;
                        case (int)Stgty.StgtyLockbytes:
                            break;
                        case (int)Stgty.StgtyProperty:
                            break;
                    }
                }
            } while (numReturned > 0);

            Marshal.ReleaseComObject(pEnum);
            Marshal.ReleaseComObject(storage);
            GC.Collect();
            GC.Collect();  // call twice for good measure
            GC.WaitForPendingFinalizers();

            return MSuccess;
        }

        private static void V8DecodeAndWrite(string streamName, byte[] buf, uint length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                if (buf[i] == 0x78 && buf[i + 1] == 0x5E)
                {
                    byte[] compressed = new byte[length - i];
                    Array.Copy(buf, i, compressed, 0, length - i);
                    byte[] decompressed = ZlibStream.UncompressBuffer(compressed);
                    using BinaryWriter bw = new BinaryWriter(File.Open(streamName, FileMode.Create));
                    bw.Write(decompressed, 0, decompressed.Length);
                    return;
                }
            }
            using (var bw = new BinaryWriter(File.Open(streamName, FileMode.Create)))
            {
                bw.Write(buf, 0, (int)length);
            }
        }

        private static void V8RecurseStorage(IStorage pStorage, string firstName, string name, int level)
        {
            System.Runtime.InteropServices.ComTypes.STATSTG[] entry = new System.Runtime.InteropServices.ComTypes.STATSTG[1];
            uint numReturned;
            string[] typnam = { "STGTY_STORAGE", "STGTY_STREAM", "STGTY_LOCKBYTES", "STGTY_PROPERTY" };

            pStorage.OpenStorage(name, null, (uint)(Stgm.Read | Stgm.ShareExclusive), IntPtr.Zero, 0, out IStorage storage);
            storage.EnumElements(0, IntPtr.Zero, 0, out IEnumSTATSTG pEnum);
            do
            {
                pEnum.Next(1, entry, out numReturned);
                if (numReturned != 0)
                {
                    string pad = new string(' ', level);
                    Logger.Info("{3}{0}, type={1}, size={2}", entry[0].pwcsName, typnam[entry[0].type - 1], entry[0].cbSize, pad);
                    switch (entry[0].type)
                    {
                        case (int)Stgty.StgtyStorage:
                            {
                                string pwzStream;
                                if (firstName == "")
                                {
                                    pwzStream = firstName;
                                }
                                else
                                {
                                    pwzStream = firstName + "@";
                                }

                                pwzStream += name;
                                V8RecurseStorage(storage, pwzStream, entry[0].pwcsName, level + 1);
                            }
                            break;
                        case (int)Stgty.StgtyStream:
                            {
                                string pwzStream;
                                if (firstName == "")
                                {
                                    pwzStream = firstName;
                                }
                                else
                                {
                                    pwzStream = firstName + "@";
                                }

                                pwzStream += name;
                                pwzStream += "@";
                                pwzStream += entry[0].pwcsName;

                                uint cbSize = (uint)entry[0].cbSize;
                                byte[] buf = new byte[cbSize];
                                storage.OpenStream(entry[0].pwcsName, IntPtr.Zero, (uint)(Stgm.Read | Stgm.ShareExclusive), 0, out IStream stream);
                                stream.Read(buf, cbSize, out var cbRead);
                                pwzStream = pwzStream.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_');
                                V8DecodeAndWrite(pwzStream, buf, cbRead);
                                Marshal.ReleaseComObject(stream);
                            }
                            break;
                        case (int)Stgty.StgtyLockbytes:
                            break;
                        case (int)Stgty.StgtyProperty:
                            break;
                    }
                }
            } while (numReturned > 0);

            Marshal.ReleaseComObject(pEnum);
            Marshal.ReleaseComObject(storage);
            GC.Collect();
            GC.Collect();  // call twice for good measure
            GC.WaitForPendingFinalizers();
        }

        public static void V8DgnDumpProperties(StreamWriter sw)
        {
            sw.WriteLine($"Dump of the file {FileName}");
            sw.WriteLine($"> Summary Information");
            sw.WriteLine($"  Title                          = {summaryInfoProperties.Title}");
            sw.WriteLine($"  Subject                        = {summaryInfoProperties.Subject}");
            sw.WriteLine($"  Author                         = {summaryInfoProperties.Author}");
            sw.WriteLine($"  Keywords                       = {summaryInfoProperties.Keywords}");
            sw.WriteLine($"  Comments                       = {summaryInfoProperties.Comments}");
            sw.WriteLine($"  Template                       = {summaryInfoProperties.Template}");
            sw.WriteLine($"  LastSavedBy                    = {summaryInfoProperties.LastSavedBy}");
            sw.WriteLine($"  RevisionNumber                 = {summaryInfoProperties.RevisionNumber}");
            sw.WriteLine($"  ApplicationName                = {summaryInfoProperties.ApplicationName}");
            sw.WriteLine($"  TotalEditingTime               = {summaryInfoProperties.TotalEditingTime}");
            sw.WriteLine($"  LastPrintedTime                = {summaryInfoProperties.LastPrintedTime}");
            sw.WriteLine($"  CreatedTime                    = {summaryInfoProperties.CreatedTime}");
            sw.WriteLine($"  LastSavedTime                  = {summaryInfoProperties.LastSavedTime}");
            sw.WriteLine($"  Security                       = {summaryInfoProperties.Security}");
            sw.WriteLine($"  ThumbnailBitmap Size           = {(summaryInfoProperties.Thumbnail != null ? summaryInfoProperties.Thumbnail.Length - 8 : 0)}");
            sw.WriteLine($"> Document Summary Information");
            sw.WriteLine($"  Category                       = {documentSummaryInfoProperties.Category}");
            sw.WriteLine($"  Manager                        = {documentSummaryInfoProperties.Manager}");
            sw.WriteLine($"  Company                        = {documentSummaryInfoProperties.Company}");
            if (documentSummaryInfoProperties.BentleyProjectProperties != null)
            {
                sw.WriteLine($"  BentleyProjectProperties       = {Dump(documentSummaryInfoProperties.BentleyProjectProperties)}");
            }

            if (documentSummaryInfoProperties.BentleyWorkSetProperties != null)
            {
                sw.WriteLine($"  BentleyWorkSetProperties       = {Dump(documentSummaryInfoProperties.BentleyWorkSetProperties)}");
            }

            if (summaryInfoProperties.Thumbnail != null && summaryInfoProperties.Thumbnail.Length - 8 != 0)
            {
                SaveThumbnail();
            }

            sw.WriteLine();
        }

        private static void SaveThumbnail()
        {
            using BinaryWriter bw = new BinaryWriter(File.Open(Path.ChangeExtension(Path.GetFileName(FileName), ".bmp"), FileMode.Create));
            bw.Write('B');
            bw.Write('M');
            bw.Write(summaryInfoProperties.Thumbnail.Length - 8);
            bw.Write(summaryInfoProperties.Thumbnail);
        }

        private static string Dump(byte[] bytes)
        {
            return "\r\n" + Utils.HexDump(bytes);
            //return BitConverter.ToString(bytes).Replace("-", ", ");
        }

        public static void V8DgnGetProperties(string fileName)
        {
            try
            {
                FileName = fileName;
                using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                var cf = new CompoundFile(fs);

                Action<CFItem> va = delegate (CFItem target)
                {
                    if (target.IsStream)
                    {
                        if (target.Name == "\u0005SummaryInformation")
                        {
                            OLEPropertiesContainer c = ((CFStream)target).AsOLEPropertiesContainer();
                            var thumbnail = GetThumbnailePropertyValue(c, "PIDSI_THUMBNAIL");
                            summaryInfoProperties = new SummaryInfoProperties
                            {
                                Title = GetPropertyValue(c, "PIDSI_TITLE"),
                                Subject = GetPropertyValue(c, "PIDSI_SUBJECT"),
                                Author = GetPropertyValue(c, "PIDSI_AUTHOR"),
                                Keywords = GetPropertyValue(c, "PIDSI_KEYWORDS"),
                                Comments = GetPropertyValue(c, "PIDSI_COMMENTS"),
                                Template = GetPropertyValue(c, "PIDSI_TEMPLATE"),
                                LastSavedBy = GetPropertyValue(c, "PIDSI_LASTAUTHOR"),
                                RevisionNumber = GetPropertyValue(c, "PIDSI_REVNUMBER"),
                                ApplicationName = GetPropertyValue(c, "PIDSI_APPNAME"),
                                TotalEditingTime = GetPropertyValue(c, "PIDSI_EDITTIME"),
                                LastPrintedTime = GetPropertyValue(c, "PIDSI_LASTPRINTED"),
                                CreatedTime = GetPropertyValue(c, "PIDSI_CREATE_DTM"),
                                LastSavedTime = GetPropertyValue(c, "PIDSI_LASTSAVE_DTM"),
                                Security = GetPropertyValue(c, "PIDSI_DOC_SECURITY"),
                                Thumbnail = thumbnail != null ? (byte[])thumbnail.Clone() : null,
                            };
                        }
                        else if (target.Name == "\u0005DocumentSummaryInformation")
                        {
                            OLEPropertiesContainer c = ((CFStream)target).AsOLEPropertiesContainer();
                            documentSummaryInfoProperties = new DocumentSummaryInfoProperties
                            {
                                Category = GetPropertyValue(c, "PIDDSI_CATEGORY"),
                                Manager = GetPropertyValue(c, "PIDDSI_MANAGER"),
                                Company = GetPropertyValue(c, "PIDDSI_COMPANY"),
                                BentleyProjectProperties = GetUserDeefinedPropertyValue(c, "BentleyProjectProperties"),
                                BentleyWorkSetProperties = GetUserDeefinedPropertyValue(c, "BentleyWorkSetProperties"),
                            };
                        }
                        else if (target.Name == "\u0005SebiesnrMkudrfcoIaamtykdDa")
                        {

                        }
                        else
                        {

                        }
                    }
                };

                // iterate over storage & streams
                cf.RootStorage.VisitEntries(va, true);
                cf.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static byte[] GetUserDeefinedPropertyValue(OLEPropertiesContainer c, string propertyName)
        {
            if (c.HasUserDefinedProperties)
            {
                OLEProperty property = c.UserDefinedProperties.Properties.FirstOrDefault(p => p.PropertyName == propertyName);
                if (property != null)
                {
                    return property.Value as byte[];
                }
            }

            return default;
        }

        private static byte[] GetThumbnailePropertyValue(OLEPropertiesContainer c, string propertyName)
        {
            OLEProperty property = c.Properties.FirstOrDefault(p => p.PropertyName == propertyName);
            if (property != null)
            {
                return property.Value as byte[];
            }

            return default;
        }

        private static string GetPropertyValue(OLEPropertiesContainer c, string propertyName)
        {
            OLEProperty property = c.Properties.FirstOrDefault(p => p.PropertyName == propertyName);
            if (property != null)
            {
                if (property.VTType == VTPropertyType.VT_FILETIME)
                {
                    DateTime time = (DateTime)property.Value;
                    Int64 filetime = time.ToFileTime();
                    if ((propertyName == "PIDSI_CREATE_DTM") ||
                        (propertyName == "PIDSI_LASTSAVE_DTM"))
                    {
                        return time.ToString("ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        if (time == new DateTime(1601, 1, 1, 1, 0, 0))
                        {
                            return "0";
                        }
                        else
                        {
                            // 7078598
                            // filetime is in ms increments
                            var filetimeinsecs = filetime / 1000;
                            var filetimehours = filetimeinsecs / 3600;
                            var filetimemins = (filetimeinsecs - 3600 * filetimehours) / 60;
                            var filetimesecs = filetimeinsecs - (filetimehours * 3600) - (filetimemins * 60);
                            return string.Format($"{filetimehours:D2}:{filetimemins:D2}:{filetimesecs:D2}");
                        }
                    }
                }

                return property.Value.ToString();
            }

            // missing properties
            if ((propertyName == "PIDSI_DOC_SECURITY") ||
                (propertyName == "PIDSI_EDITTIME") ||
                (propertyName == "PIDSI_LASTPRINTED"))
            {
                return "0";
            }

            return string.Empty;
        }
    }
}
