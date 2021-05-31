using Ionic.Zlib;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace v8file.net
{
    public class V8FileLoader
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<UInt64, List<XAttribute>> xattributes = new();

        public static Dictionary<ulong, List<XAttribute>> Xattributes => xattributes;

        public static void V8ParseAttributeCache(StreamWriter sw, Cache cache)
        {
            if (cache.Bytes == null)
                return;

            MemoryStream ms = new(cache.Bytes);
            BinaryReader br = new(ms);
            long streamPosition = ms.Position;
            while (streamPosition < ms.Length)
            {
                Int32 sign = br.ReadInt32();
                if (sign != 0xa11b)
                    Debugger.Break();
                Int32 size = br.ReadInt32();
                Int32 dummy2 = br.ReadInt32();
                if (dummy2 != 0xaa)
                    Debugger.Break();
                Int32 dummy3 = br.ReadInt32();
                if (dummy3 != 0x00)
                    Debugger.Break();
                UInt64 elementId = br.ReadUInt64();

                if (!Xattributes.ContainsKey(elementId))
                {
                    Xattributes.Add(elementId, new List<XAttribute>());
                }

                if (sw != StreamWriter.Null)
                    sw.Write("ElementId={0} (0x{0:X16}", elementId);
                Int32 numXAttributes = br.ReadInt32();
                if (sw != StreamWriter.Null)
                    sw.WriteLine(" has {0} XAttributes", numXAttributes);
                for (int i = 0; i < numXAttributes; i++)
                {
                    var xAttribute = ReadXAttribute(sw, br);
                    if ((xAttribute.XAttributeHandler == 0x570b0003) ||
                        (xAttribute.XAttributeHandler == 0x570b0004) ||
                        (xAttribute.XAttributeHandler == 0x570b0005))
                    {
                        if (sw != StreamWriter.Null)
                            sw.WriteLine("\t xattribute {0}, handler={1:X8}, size={2} is {3}", i, xAttribute.XAttributeHandler, xAttribute.Size, xAttribute.Data);
                    }
                    else
                    {
                        if (sw != StreamWriter.Null)
                            sw.WriteLine("\t xattribute {0}, handler={1:X8}, size={2}", i, xAttribute.XAttributeHandler, xAttribute.Size);
                    }

                    Xattributes[elementId].Add(xAttribute);
                }

                Int64 dummy4 = br.ReadInt32();
                streamPosition = ms.Position;
            }
        }

        private static XAttribute ReadXAttribute(StreamWriter sw, BinaryReader br)
        {
            Int32 xAttributeHandler = br.ReadInt32(); // eg 570b0005
            Int32 dummy1 = br.ReadInt32();
            UInt32 size = br.ReadUInt32();
            if ((size & 0x80000000) == 0x80000000)
            {
                size &= 0x7fffffff;
            }
            Int32 dummy2 = br.ReadInt32();
            byte[] bytes = br.ReadBytes((int)size);

            if (bytes.Length >= 10 && bytes[8] == 0x78 && bytes[9] == 0x9c)
            {
                return new XAttribute
                {
                    XAttributeHandler = xAttributeHandler,
                    AttributeId = dummy1,
                    Size = size,
                    Dummy2 = dummy2,
                    Data = Decode(bytes)
                };
            }
            else
            {
                return new XAttribute
                {
                    XAttributeHandler = xAttributeHandler,
                    AttributeId = dummy1,
                    Size = size,
                    Dummy2 = dummy2,
                    Data = Encoding.Unicode.GetString(bytes, 0, bytes.Length).Replace("\x00", "")
                };
            }
        }

        private static string Decode(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length - 1; i++)
            {
                if (bytes[i] == 0x78 && bytes[i + 1] == 0x9C)
                {
                    byte[] compressed = new byte[bytes.Length - i];
                    Array.Copy(bytes, i, compressed, 0, bytes.Length - i);
                    byte[] decompressed = ZlibStream.UncompressBuffer(compressed);
                    return Encoding.UTF8.GetString(decompressed, 0, decompressed.Length);
                }
            }

            return "???";
        }

        public static void V8LoadModels(ref DgnFileObj dgnFileObj)
        {
            int maxModelNum = -1;
            string mn, pattern;

            pattern = "Dgn-Md@#??????@Dgn~Mh";
            string[] fileNames = Directory.GetFiles(".", pattern);
            int currModelNum;
            foreach (var fileName in fileNames)
            {
                mn = fileName.Substring(10, 6);
                currModelNum = V8Htol(mn);
                if (currModelNum > maxModelNum)
                {
                    maxModelNum = currModelNum;
                }
            }

            dgnFileObj.NumModels = maxModelNum + 1;
            Array.Resize(ref dgnFileObj.Models, dgnFileObj.NumModels);
            Array.Resize(ref dgnFileObj.Caches, dgnFileObj.NumModels);
            foreach (var fileName in fileNames)
            {
                mn = fileName.Substring(10, 6);
                currModelNum = V8Htol(mn);
                V8LoadModel(dgnFileObj, fileName, currModelNum);
            }
        }

        private static int V8Htol(string str)
        {
            int nn = 0;

            for (int i = 0; i < str.Length; i++)
            {
                nn *= 16;
                if ((str[i] >= '0') && (str[i] <= '9'))
                    nn += str[i] - '0';
                if ((str[i] >= 'a') && (str[i] <= 'f'))
                    nn += (str[i] - 'a' + 10);
                if ((str[i] >= 'A') && (str[i] <= 'F'))
                    nn += (str[i] - 'A' + 10);
            }

            return nn;
        }

        private static void V8LoadModel(DgnFileObj dgnFileObj, string fileName, int modelNum)
        {
            dgnFileObj.Caches[modelNum].DgnFileObj = dgnFileObj;
            dgnFileObj.Caches[modelNum].ModelCache.Size = (int)(new FileInfo(fileName).Length);
            dgnFileObj.Caches[modelNum].ModelCache.Bytes = File.ReadAllBytes(fileName);

            dgnFileObj.Caches[modelNum].ModelName =
                V8GetModelNameFromModelCache(dgnFileObj.Caches[modelNum].ModelCache);
            V8LoadControlCaches(ref dgnFileObj.Caches[modelNum], modelNum);
            V8LoadGraphicCaches(ref dgnFileObj.Caches[modelNum], modelNum);
            V8LoadControlAttributesCaches(ref dgnFileObj.Caches[modelNum], modelNum);
            V8LoadGraphicAttributesCaches(ref dgnFileObj.Caches[modelNum], modelNum);
            dgnFileObj.Caches[modelNum].Valid = true;
            dgnFileObj.Caches[modelNum].ModelNum = modelNum;
        }

        private static void V8LoadGraphicAttributesCaches(ref DgnCache dgnCache, int modelNum)
        {
            var pattern = $"Dgn-Md@#{modelNum:X6}@Dgn_GA@$*";
            string[] fileNames = Directory.GetFiles(".", pattern);
            int max = 0;
            foreach (var fileName in fileNames)
            {
                var num = Convert.ToInt32(fileName[25..]);
                if (num > max)
                    max = num;
            }

            dgnCache.NumGraphicAttributesCaches = max;

            Array.Resize(ref dgnCache.GraphicAttributesCaches, dgnCache.NumGraphicAttributesCaches);
            foreach (var fileName in fileNames)
            {
                // get non model num
                var num = Convert.ToInt32(fileName[25..]);
                V8LoadGraphicAttributeCache(ref dgnCache, fileName, num);
            }
        }

        private static void V8LoadGraphicAttributeCache(ref DgnCache dgnCache, string fileName, int cacheNum)
        {
            dgnCache.GraphicAttributesCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnCache.GraphicAttributesCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

        private static void V8LoadControlAttributesCaches(ref DgnCache dgnCache, int modelNum)
        {
            var pattern = $"Dgn-Md@#{modelNum:X6}@Dgn_CA@$*";
            string[] fileNames = Directory.GetFiles(".", pattern);
            int max = 0;
            foreach (var fileName in fileNames)
            {
                var num = Convert.ToInt32(fileName[25..]);
                if (num > max)
                    max = num;
            }

            dgnCache.NumControlAttributesCaches = max;

            Array.Resize(ref dgnCache.ControlAttributesCaches, dgnCache.NumControlAttributesCaches);
            foreach (var fileName in fileNames)
            {
                // get non model num
                var num = Convert.ToInt32(fileName[25..]);
                V8LoadControlAttributeCache(ref dgnCache, fileName, num);
            }
        }

        private static void V8LoadControlAttributeCache(ref DgnCache dgnCache, string fileName, int cacheNum)
        {
            dgnCache.ControlAttributesCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnCache.ControlAttributesCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

        private static void V8LoadGraphicCaches(ref DgnCache dgnCache, int modelNum)
        {
            int num;
            string pattern;

            pattern = String.Format("Dgn-Md@#{0:X6}@Dgn_G@$*", modelNum);
            string[] fileNames = Directory.GetFiles(".", pattern);
            foreach (var fileName in fileNames)
            {
                dgnCache.NumGraphicCaches++;
            }

            Array.Resize(ref dgnCache.GraphicCaches, dgnCache.NumGraphicCaches);
            foreach (var fileName in fileNames)
            {
                // get non model num
                num = Convert.ToInt32(fileName[24..]);
                V8LoadGraphicCache(ref dgnCache, fileName, num);
            }
        }

        private static void V8LoadGraphicCache(ref DgnCache dgnCache, string fileName, int cacheNum)
        {
            dgnCache.GraphicCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnCache.GraphicCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

        private static void V8LoadControlCaches(ref DgnCache dgnCache, int modelNum)
        {
            int num;
            string pattern;

            pattern = String.Format("Dgn-Md@#{0:X6}@Dgn_C@$*", modelNum);
            string[] fileNames = Directory.GetFiles(".", pattern);
            foreach (var fileName in fileNames)
            {
                dgnCache.NumControlCaches++;
            }

            Array.Resize(ref dgnCache.ControlCaches, dgnCache.NumControlCaches);
            foreach (var fileName in fileNames)
            {
                // get non model num
                num = Convert.ToInt32(fileName[24..]);
                V8LoadControlCache(ref dgnCache, fileName, num);
            }
        }

        private static void V8LoadControlCache(ref DgnCache dgnCache, string fileName, int cacheNum)
        {
            dgnCache.ControlCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnCache.ControlCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

        private static string V8GetModelNameFromModelCache(Cache modelCache)
        {
            return string.Empty;
        }

        public static void V8LoadNonModels(ref DgnFileObj dgnFileObj)
        {
            V8LoadNonModelCaches(ref dgnFileObj);
            V8LoadNonModelAttributesCaches(ref dgnFileObj);
        }

        private static void V8LoadNonModelAttributesCaches(ref DgnFileObj dgnFileObj)
        {
            var header = "Dgn_NmA@_AH";
            if (!File.Exists(header))
                return;

            // read from file
            using (FileStream fileStream = new(header, FileMode.Open))
            {
                using BinaryReader br = new(fileStream);
                dgnFileObj.NumNonModelAttributesCaches = br.ReadInt32();
            }

            Array.Resize(ref dgnFileObj.NonModelAttributesCaches, dgnFileObj.NumNonModelAttributesCaches);

            var pattern = "Dgn_NmA@$*";
            string[] fileNames = Directory.GetFiles(".", pattern);
            foreach (var fileName in fileNames)
            {
                // get non model num
                var num = Convert.ToInt32(fileName[11..]);
                V8LoadNonModelAttributesCache(ref dgnFileObj, fileName, num);
            }
        }

        private static void V8LoadNonModelAttributesCache(ref DgnFileObj dgnFileObj, string fileName, int cacheNum)
        {
            dgnFileObj.NonModelAttributesCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnFileObj.NonModelAttributesCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

        private static void V8LoadNonModelCaches(ref DgnFileObj dgnFileObj)
        {
            int num;
            string pattern;

            pattern = "Dgn_Nm@$*";
            string[] fileNames = Directory.GetFiles(".", pattern);
            foreach (var fileName in fileNames)
            {
                dgnFileObj.NumNonModelCaches++;
            }

            Array.Resize(ref dgnFileObj.NonModelCaches, dgnFileObj.NumNonModelCaches);
            foreach (var fileName in fileNames)
            {
                // get non model num
                num = Convert.ToInt32(fileName[10..]);
                V8LoadNonModelCache(ref dgnFileObj, fileName, num);
            }
        }

        private static void V8LoadNonModelCache(ref DgnFileObj dgnFileObj, string fileName, int cacheNum)
        {
            dgnFileObj.NonModelCaches[cacheNum - 1].Size = (int)(new FileInfo(fileName).Length);
            dgnFileObj.NonModelCaches[cacheNum - 1].Bytes = File.ReadAllBytes(fileName);
        }

    }
}
