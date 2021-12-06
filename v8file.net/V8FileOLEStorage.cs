using Ionic.Zlib;
using NLog;
using OpenMcdf;
using OpenMcdf.Extensions;
using OpenMcdf.Extensions.OLEProperties;
using RedBlackTree;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using static OpenMcdf.Extensions.OLEProperties.OLEPropertiesContainer;
using static v8file.net.V8FileOLEStorage;

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

        [ComVisible(false)]
        [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0000000A-0000-0000-C000-000000000046")]
        internal interface ILockBytes
        {
            void ReadAt(long ulOffset, System.IntPtr pv, int cb, out UIntPtr pcbRead);
            void WriteAt(long ulOffset, System.IntPtr pv, int cb, out UIntPtr pcbWritten);
            void Flush();
            void SetSize(long cb);
            void LockRegion(long libOffset, long cb, int dwLockType);
            void UnlockRegion(long libOffset, long cb, int dwLockType);
            void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
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

        [DllImport("ole32.dll")]
        static extern int StgOpenStorageOnILockBytes(ILockBytes plkbyt, IStorage pStgPriority, Stgm grfMode,
            IntPtr snbEnclude, uint reserved, out IStorage ppstgOpen);

        [DllImport("ole32.dll")]
        static extern int CreateILockBytesOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease,
            out ILockBytes ppLkbyt);

        [DllImport("ole32.dll")]
        static extern int StgCreateDocfileOnILockBytes(ILockBytes plkbyt, Stgm grfMode, int reserved, out IStorage ppstgOpen);

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static SummaryInfoProperties summaryInfoProperties;
        private static DocumentSummaryInfoProperties documentSummaryInfoProperties;
        private static string FileName;

        public const int MSuccess = 0;
        public const int MError = 0x8000;

        private static Tree OLETree = null;

        public static Tree GetOLETree() => OLETree;

        public static int V8DgnBreak(string fileName)
        {
            System.Runtime.InteropServices.ComTypes.STATSTG[] entry = new System.Runtime.InteropServices.ComTypes.STATSTG[1];
            uint numReturned;
            int start = 0, b1 = 0, b2 = 0;
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

            OLETree = new();
            OLETree.PathSeparator = "@";

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
                            {
                                // add to Root Node
                                var Node = new TreeNode(entry[0].pwcsName)
                                {
                                    Name = entry[0].pwcsName.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_'),
                                    Tag = new OLETag
                                    {
                                        Name = entry[0].pwcsName,
                                        Type = entry[0].type,
                                        TypeString = typnam[entry[0].type - 1],
                                        Size = entry[0].cbSize,
                                        Compressed = false,
                                        Status = Status.Unchanged
                                    }
                                };
                                OLETree.Nodes.Add(Node);
                                V8RecurseStorage(storage, "", entry[0].pwcsName, 1, Node);
                            }
                            break;
                        case (int)Stgty.StgtyStream:
                            {
                                var Node = new TreeNode(entry[0].pwcsName)
                                {
                                    Name = entry[0].pwcsName.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_'),
                                    Tag = new OLETag
                                    {
                                        Name = entry[0].pwcsName,
                                        Type = entry[0].type,
                                        TypeString = typnam[entry[0].type - 1],
                                        Size = entry[0].cbSize,
                                        Compressed = false,
                                        Status = Status.Unchanged
                                    }
                                };

                                string pwzStream = entry[0].pwcsName;
                                uint cbSize = (uint)entry[0].cbSize;
                                byte[] buf = new byte[cbSize];
                                storage.OpenStream(entry[0].pwcsName, IntPtr.Zero, (uint)(Stgm.Read | Stgm.ShareExclusive), 0, out IStream stream);
                                stream.Read(buf, cbSize, out var cbRead);
                                pwzStream = pwzStream.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_');
                                if (V8DecodeAndWrite(pwzStream, buf, cbRead, ref start, ref b1, ref b2) == MSuccess)
                                {
                                    ((OLETag)Node.Tag).Compressed = true;
                                    Logger.Info("                   start={0}, b1={1} (0x{1:X8}), b2={2} (0x{2:X8})", start, b1, b2);
                                }
                                else
                                {
                                    ((OLETag)Node.Tag).Compressed = false;
                                }

                                OLETree.Nodes.Add(Node);
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

        private static int V8DecodeAndWrite(string streamName, byte[] buf, uint length, ref int start, ref int b1, ref int b2)
        {
            start = 0;
            b1 = 0;
            b2 = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (buf[i] == 0x78 && buf[i + 1] == 0x5E)
                {
                    byte[] compressed = new byte[length - i];
                    Array.Copy(buf, i, compressed, 0, length - i);
                    byte[] decompressed = ZlibStream.UncompressBuffer(compressed);
                    using BinaryWriter bw = new BinaryWriter(File.Open(streamName, FileMode.Create));
                    bw.Write(decompressed, 0, decompressed.Length);
                    if (i != 0)
                    {
                        start = i;
                        b1 = BitConverter.ToInt32(buf);
                        b2 = BitConverter.ToInt32(buf, 4);
                        using BinaryWriter bw1 = new BinaryWriter(File.Open("prefix@" + streamName, FileMode.Create));
                        bw1.Write(buf, 0, i);
                    }
                    return MSuccess;
                }
            }
            using (var bw = new BinaryWriter(File.Open(streamName, FileMode.Create)))
            {
                bw.Write(buf, 0, (int)length);
            }
            return MError;
        }

        private static void V8RecurseStorage(IStorage pStorage, string firstName, string name, int level, TreeNode node)
        {
            System.Runtime.InteropServices.ComTypes.STATSTG[] entry = new System.Runtime.InteropServices.ComTypes.STATSTG[1];
            uint numReturned;
            int start = 0, b1 = 0, b2 = 0;
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
                                // add to node
                                var Node = new TreeNode(entry[0].pwcsName)
                                {
                                    Name = entry[0].pwcsName.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_'),
                                    Tag = new OLETag
                                    {
                                        Name = entry[0].pwcsName,

                                        Type = entry[0].type,
                                        TypeString = typnam[entry[0].type - 1],
                                        Size = entry[0].cbSize,
                                        Compressed = false,
                                        Status = Status.Unchanged
                                    }
                                };
                                node.Nodes.Add(Node);
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
                                V8RecurseStorage(storage, pwzStream, entry[0].pwcsName, level + 1, Node);
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

                                // add to node
                                var Node = new TreeNode(entry[0].pwcsName)
                                {
                                    Name = entry[0].pwcsName.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_'),
                                    Tag = new OLETag
                                    {
                                        Name = entry[0].pwcsName,
                                        Type = entry[0].type,
                                        TypeString = typnam[entry[0].type - 1],
                                        Size = entry[0].cbSize,
                                        Compressed = false,
                                        Status = Status.Unchanged
                                    }
                                };

                                uint cbSize = (uint)entry[0].cbSize;
                                byte[] buf = new byte[cbSize];
                                storage.OpenStream(entry[0].pwcsName, IntPtr.Zero, (uint)(Stgm.Read | Stgm.ShareExclusive), 0, out IStream stream);
                                stream.Read(buf, cbSize, out var cbRead);
                                pwzStream = pwzStream.Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$').Replace('^', '_');
                                if (V8DecodeAndWrite(pwzStream, buf, cbRead, ref start, ref b1, ref b2) == MSuccess)
                                {
                                    ((OLETag)Node.Tag).Compressed = true;
                                    Logger.Info("                   start={0}, b1={1} (0x{1:X8}), b2={2} (0x{2:X8})", start, b1, b2);
                                }
                                else
                                {
                                    ((OLETag)Node.Tag).Compressed = false;
                                }

                                node.Nodes.Add(Node);
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

        private static StoragePart BuildStorageFromOLETree(Tree oleTree)
        {
            StoragePart storage = new StoragePart();
            BuildStorageFromOLENode(oleTree.Root, ref storage);
            return storage;
        }

        private static void BuildStorageFromOLENode(TreeNode node, ref StoragePart storage)
        {
            OLETag tag = (OLETag)node.Tag;
            if (node == node.Tree.Root)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    BuildStorageFromOLENode(subNode, ref storage);
                }
            }
            else
            {
                if (tag.Type == (int)Stgty.StgtyStream)
                {
                    if (tag.Status != Status.Deleted)
                    {
                        var fileName = node.FullPath.Replace("^", "_").Replace(Convert.ToChar(Convert.ToUInt32("0x05", 16)), '$');
                        byte[] bytes = File.ReadAllBytes(fileName);
                        if (!tag.Compressed)
                        {
                            storage.DataStreams.Add(node.Text, bytes);
                        }
                        else
                        {
                            //byte[] hdr = new byte[2] { 0x78, 0x5E };
                            byte[] hdr = new byte[0];
                            var prefixFileName = "prefix@" + fileName;
                            if (File.Exists(prefixFileName))
                            {
                                byte[] prefix = File.ReadAllBytes(prefixFileName);
                                //Array.Fill<byte>(prefix, 0, 0, 4);
                                byte[] compressedBytes = Compress(bytes);
                                var outputBytes = prefix.Concat(hdr).Concat(compressedBytes).ToArray();
                                storage.DataStreams.Add(node.Text, outputBytes);
                            }
                            else
                            {
                                byte[] compressedBytes = Compress(bytes);
                                var outputBytes = hdr.Concat(compressedBytes).ToArray();
                                storage.DataStreams.Add(node.Text, outputBytes);
                            }
                        }
                    }
                }
                else if (tag.Type == (int)Stgty.StgtyStorage)
                {
                    var subStorage = new StoragePart();
                    storage.SubStorage.Add(node.Text, subStorage);
                    foreach (TreeNode subNode in node.Nodes)
                    {
                        BuildStorageFromOLENode(subNode, ref subStorage);
                    }
                }
            }
        }

        private static byte[] Compress(byte[] bytes)
        {
            using var ms = new MemoryStream();
            ms.Position = 0;
            ms.SetLength(0);
            using (ZlibStream compressor = new(ms, CompressionMode.Compress, CompressionLevel.BestCompression/*Level4*/))
            {
                compressor.Write(bytes, 0, bytes.Length);
                compressor.Flush();
            }

            return ms.ToArray();
        }

        public static byte[] V8DgnWriteToBuffer()
        {
            StoragePart Storage = BuildStorageFromOLETree(OLETree);
            // create a new OLE storage
            ILockBytes lb;
            var iret = CreateILockBytesOnHGlobal(IntPtr.Zero, true, out lb);

            IStorage storage = null;
            byte[] ret = null;

            //Create the document in-memory
            if (StgCreateDocfileOnILockBytes(lb, Stgm.Create | Stgm.Readwrite | Stgm.ShareExclusive | Stgm.Transacted, 0, out storage) == 0)
            {
                foreach (var store in Storage.SubStorage)
                {
                    CreateStore(store.Key, store.Value, storage);
                }

                CreateStreams(Storage, storage);
                lb.Flush();

                //Now copy the unmanaged stream to a byte array --> memory stream
                var statstg = new System.Runtime.InteropServices.ComTypes.STATSTG();
                lb.Stat(out statstg, 0);
                int size = (int)statstg.cbSize;
                IntPtr buffer = Marshal.AllocHGlobal(size);
                UIntPtr readSize;
                ret = new byte[size];
                lb.ReadAt(0, buffer, size, out readSize);
                Marshal.Copy(buffer, ret, 0, size);
                Marshal.FreeHGlobal(buffer);
            }

            Marshal.ReleaseComObject(storage);
            Marshal.ReleaseComObject(lb);

            return ret;
        }

        private static void CreateStore(string name, StoragePart subStore, IStorage storage)
        {
            IStorage subStorage;
            storage.CreateStorage(name, (uint)(Stgm.Create | Stgm.Write | Stgm.Direct | Stgm.ShareExclusive), 0, 0, out subStorage);
            storage.Commit(0);
            foreach (var store in subStore.SubStorage)
            {
                CreateStore(store.Key, store.Value, subStorage);
            }

            CreateStreams(subStore, subStorage);
        }

        private static void CreateStreams(StoragePart subStore, IStorage subStorage)
        {
            foreach (var ds in subStore.DataStreams)
            {
                IStream stream;
                uint dwWritten;
                subStorage.CreateStream(ds.Key, (uint)(Stgm.Create | Stgm.Write | Stgm.Direct | Stgm.ShareExclusive), 0, 0, out stream);
                stream.Write(ds.Value, (uint)ds.Value.Length, out dwWritten);
            }

            subStorage.Commit(0);
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

    public class StoragePart
    {
        public StoragePart()
        {
        }

        public Dictionary<string, StoragePart> SubStorage = new Dictionary<string, StoragePart>();
        public Dictionary<string, byte[]> DataStreams = new Dictionary<string, byte[]>();
    }
}
