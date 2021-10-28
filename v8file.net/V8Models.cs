using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace v8file.net
{
    public class V8Models
    {
        public static void V8GetModelIndexInformation()
        {
            // get information from Dgn_Ix@Dgn~Mix stream
            byte[] bytes = File.ReadAllBytes(@"Dgn_Ix@Dgn~Mix");
            V8FileManipulation.CMFileInfo.Files[0].ModelIndex = new ModelIndex();
            V8FileManipulation.CMFileInfo.Files[0].ModelIndex.Read(bytes);
        }

        public static void V8DumpModelInformation(StreamWriter sw)
        {
            sw.WriteLine($"> Model Index Information");
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].ModelIndex.NumModels; i++)
            {
                sw.WriteLine($"    Model Index Item >");
                sw.WriteLine($"      Model Index Item Id                = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId}");
                sw.WriteLine($"      Model Index Item Name              = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelName}");
                sw.WriteLine($"      Model Index Item Description       = {V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelDescription}");
                sw.WriteLine($"      Model Index Item Last Saved Time   = {Utils.V8BentleyTime(V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].LastSavedTime)}");
            }
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
            {
                if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                {
                    V8DumpModelInfoFromCache(V8FileManipulation.CMFileInfo.Files[0].Caches[i]);
                }
            }
        }

        private static void V8DumpModelInfoFromCache(DgnCache dgnCache)
        {
            string modelFileName = Path.GetFileNameWithoutExtension(V8FileManipulation.CMFileInfo.Files[V8FileManipulation.CMFileInfo.NumFiles - 1].FileName) + "_" + dgnCache.ModelName + ".model";
            using BinaryWriter bw = new(File.Open(modelFileName, FileMode.Create));

            using MemoryStream ms = new(dgnCache.ModelCache.Bytes);
            using BinaryReader br = new(ms);
            ms.Seek(0x1004, SeekOrigin.Begin);
            var modelHeaderElm = new ModelHeaderElm().Read(br);
            br.BaseStream.Seek(0x1004, SeekOrigin.Begin);
            var bytes = br.ReadBytes((int)(2 * modelHeaderElm.Ehdr.AttrOffset/*.ElementSize*/));
            var type = modelHeaderElm.Ehdr.Type;
            if (type == 66)
{
                Linkage[] linkages = V8Linkages.V8GetLinkages(br, modelHeaderElm.Ehdr);
                for (int i=0; i<linkages.Length; i++)
                {
                    string modelLinkagesFileName = Path.GetFileNameWithoutExtension(V8FileManipulation.CMFileInfo.Files[V8FileManipulation.CMFileInfo.NumFiles - 1].FileName) + "_" + dgnCache.ModelName + "_" + i.ToString() + "." + linkages[i]./*Type*/LinkageHeader.PrimaryID.ToString("X");
                    using BinaryWriter bwl = new(File.Open(modelLinkagesFileName, FileMode.Create));
                    bwl.Write(linkages[i].Data, 0, linkages[i].Data.Length);
                }
                bw.Write(bytes, 0, bytes.Length);
            }
        }

        public static void V8GetModelsInformation()
        {
            // all models must exist in model index
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
            {
                if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                {
                    var modelExistsInIndex = V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems.Any(mii => mii.ModelId == V8FileManipulation.CMFileInfo.Files[0].Caches[i].ModelNum);
                    if (!modelExistsInIndex)
                        Debugger.Break();
                }
            }

            // all models in model index must exist in models
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].ModelIndex.NumModels; i++)
            {
                var modelId = V8FileManipulation.CMFileInfo.Files[0].ModelIndex.ModelIndexItems[i].ModelId;
                var modelIndexExistsInModels = V8FileManipulation.CMFileInfo.Files[0].Caches.Any(mii => mii.Valid && mii.ModelNum == modelId);
                if (!modelIndexExistsInModels)
                    Debugger.Break();
            }

            // now get information about each model
            for (int i = 0; i < V8FileManipulation.CMFileInfo.Files[0].NumModels; i++)
            {
                if (V8FileManipulation.CMFileInfo.Files[0].Caches[i].Valid)
                {
                    V8GetModelInfoFromCache(V8FileManipulation.CMFileInfo.Files[0].Caches[i]);
                }
            }
        }

        public static ModelInfo V8GetModelInfoFromCache(DgnCache cache)
        {
            var modelInfo =  new ModelInfo();
            var modelCache = cache.ModelCache;

            using MemoryStream ms = new(modelCache.Bytes);
            using BinaryReader br = new(ms);

            // what are bytes (ints) at 0x00, 0x04, 0x08 ???
            ms.Seek(0x1004, SeekOrigin.Begin);
            var modelHeaderElm = new ModelHeaderElm().Read(br);

            modelInfo.ModelId = cache.ModelNum;
            modelInfo.ModelName = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Name);
            modelInfo.ModelDescription = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_Description);
            modelInfo.MasterUnit = new UnitInfo
            {
                Numerator = modelHeaderElm.MuNumerator,
                Denominator = modelHeaderElm.MuDenominator,
                Flags = new UnitFlags
                { 
                },
                Label = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_MastUnitLabel)
            };
            modelInfo.SubUnit = new UnitInfo
            {
                Numerator = modelHeaderElm.SuNumerator,
                Denominator = modelHeaderElm.SuDenominator,
                Flags = new UnitFlags
                {
                },
                Label = V8Linkages.V8GetStringLinkage(modelHeaderElm.Linkages, LinkageKeyValuesString.STRING_LINKAGE_KEY_SubUnitLabel)
            };
            modelInfo.StorageUnit = new UnitInfo
            {
                Numerator = modelHeaderElm.StNumerator,
                Denominator = modelHeaderElm.StDenominator,
                Flags = new UnitFlags
                {
                },
                //Label =
            };
            modelInfo.UorPerSub = modelHeaderElm.UorsPerStorage * (modelHeaderElm.StNumerator / modelHeaderElm.StDenominator) / (modelHeaderElm.SuNumerator / modelHeaderElm.SuDenominator);
            modelInfo.UorPerStorage = modelHeaderElm.UorsPerStorage;
            modelInfo.UorPerMaster = modelHeaderElm.UorsPerStorage * (modelHeaderElm.StNumerator / modelHeaderElm.StDenominator) / (modelHeaderElm.MuNumerator / modelHeaderElm.MuDenominator);
            modelInfo.SubPerMaster = (modelHeaderElm.SuNumerator / modelHeaderElm.SuDenominator) / (modelHeaderElm.MuNumerator / modelHeaderElm.MuDenominator);
            modelInfo.LastModified = modelHeaderElm.LastModified;
            modelInfo.GlobalOrigin = modelHeaderElm.GlobalOrigin;
            modelInfo.GridPerRefernce = modelHeaderElm.GridPerReference;
            modelInfo.UorPerGrid = modelHeaderElm.Z15;
            modelInfo.GridRatio = modelHeaderElm.Z16;
            modelInfo.ModelType = (int)(modelHeaderElm.Dummy1 & 0xFFFF0000) >> 16;
            modelInfo.DgnModelType = (DgnModelType)(modelInfo.ModelType);
            modelInfo.AcsOrigin = modelHeaderElm.AcsOrigin;
            //modelInfo.AcsOrigin.X = modelHeaderElm.Z2;
            //modelInfo.AcsOrigin.Y = modelHeaderElm.Z3;
            //modelInfo.AcsOrigin.Z = modelHeaderElm.Z4;
            modelInfo.AcsRotMatrix.Form3d = new double[3, 3];
            modelInfo.AcsRotMatrix = modelHeaderElm.AcsRotMatrix;
            //modelInfo.AcsRotMatrix.Form3d[0, 0] = modelHeaderElm.Z5;
            //modelInfo.AcsRotMatrix.Form3d[0, 1] = modelHeaderElm.Z6;
            //modelInfo.AcsRotMatrix.Form3d[0, 2] = modelHeaderElm.Z7;
            //modelInfo.AcsRotMatrix.Form3d[1, 0] = modelHeaderElm.Z8;
            //modelInfo.AcsRotMatrix.Form3d[1, 1] = modelHeaderElm.Z9;
            //modelInfo.AcsRotMatrix.Form3d[1, 2] = modelHeaderElm.Z10;
            //modelInfo.AcsRotMatrix.Form3d[2, 0] = modelHeaderElm.Z11;
            //modelInfo.AcsRotMatrix.Form3d[2, 1] = modelHeaderElm.Z12;
            //modelInfo.AcsRotMatrix.Form3d[2, 2] = modelHeaderElm.Z13;

            modelInfo.Rng = modelHeaderElm.Rng;
            //modelInfo.Rng.Xlowlim = modelHeaderElm.Y0;
            //modelInfo.Rng.Ylowlim = modelHeaderElm.Y1;
            //modelInfo.Rng.Zlowlim = modelHeaderElm.Y2;
            //modelInfo.Rng.Xhighlim = modelHeaderElm.Y3;
            //modelInfo.Rng.Yhighlim = modelHeaderElm.Y4;
            //modelInfo.Rng.Zhighlim = modelHeaderElm.Y5;
            return modelInfo;
        }
    }
}
