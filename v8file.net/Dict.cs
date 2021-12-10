using Fclp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace v8file.net
{
    public enum DictType : int
    {
        ElementId,
        ModelId,
        LevelId,
        ReferenceId,
        RasterHierarchyId,
    }

    public class Dict<T> where T : struct
    {
        private static DictType DictType;
        private static string Name;
        private static readonly HashSet<T> entries = new();

        public void SetNameAndType(string name, DictType dictType)
        {
            Name = name;
            DictType = dictType;
        }

        public bool Add(T entry)
        {
            return entries.Add(entry);
        }

        public void Save(BinaryWriter bw, T t)
        {
            // save each dictionary as 
            // Name
            // DictType (int)
            // number of elements (int)
            // elements ...
            bw.Write(Name);
            bw.Write((Int32)DictType);
            bw.Write(entries.Count);
            var size = Marshal.SizeOf(t);
            if (size == 8)
            {
                Array.ForEach(entries.ToArray<T>(), e => bw.Write((UInt64)(object)e));
            }
            else if (size == 4)
            {
                Array.ForEach(entries.ToArray<T>(), e => bw.Write((UInt32)(object)e));
            }

        }

        public void Load(BinaryReader br, T t)
        {
            Name = br.ReadString();
            DictType = (DictType)br.ReadInt32();
            var numElements = br.ReadInt32();
            var size = Marshal.SizeOf(t);
            if (size == 8)
            {
                UInt64[] numbers = new UInt64[numElements];
                for (int i = 0; i < numElements; i++)
                {
                    numbers[i] = br.ReadUInt64();
                    entries.Add((T)(object)numbers[i]);
                }
            }
            else if (size == 4)
            {
                UInt32[] numbers = new UInt32[numElements];
                for (int i = 0; i < numElements; i++)
                {
                    numbers[i] = br.ReadUInt32();
                    entries.Add((T)(object)numbers[i]);
                }
            }
        }
    }

    // singleton
    public sealed class Dict
    {
        public Dict<UInt64> Elements { get => elements; set => elements = value; }
        public Dict<UInt32> Models { get => models; set => models = value; }

        private Dict<UInt64> elements;
        private Dict<UInt32> models;

        private static readonly Lazy<Dict> lazy = new(() => new Dict());

        private Dict()
        {
            elements = new Dict<UInt64>();
            elements.SetNameAndType("elements", DictType.ElementId);
            models = new Dict<UInt32>();
            models.SetNameAndType("models", DictType.ModelId);
        }

        public static Dict Instance => lazy.Value;

        public void Save(string outDir, string fileName)
        {
            try
            {
                using BinaryWriter bw = new(File.Open(Path.ChangeExtension(Path.Combine(outDir, Path.GetFileName(fileName)), ".dict"), FileMode.Create));
                elements.Save(bw, new UInt64());
                models.Save(bw, new UInt32());
            }
            catch (Exception)
            {
            }
        }

        public void Load(string outDir, string fileName)
        {
            try
            {
                using BinaryReader bw = new(File.Open(Path.ChangeExtension(Path.Combine(outDir, Path.GetFileName(fileName)), ".dict"), FileMode.Open));
                elements.Load(bw, new UInt64());
                models.Load(bw, new UInt32());
            }
            catch (Exception)
            {
            }
        }
    }
}
