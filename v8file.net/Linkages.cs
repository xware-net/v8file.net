using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8file.net
{
    public enum LinkageIds : int
    {
        LINKAGEID_DMRS = 0, // 0x0000, fictive value for DMRS linkages as only non-DMRS linkages can have any primaryId
        LINKAGEID_FillStyle = 65, // 0x0041
        LINKAGEID_RefExtractor = 13333, // 0x3415
        LINKAGEID_DDE_LINK = 20285,        //  0x4f3d
        LINKAGEID_ExternalMaterial = 20314,        //  0x4f5a
        LINKAGEID_Node = 20357,        /* 0x4f85 */
        LINKAGEID_CellDef = 20372,        /* 0x4f94 */
        LINKAGEID_ACS = 20389,        /* 0x4fa5 */
        LINKAGEID_AssociatedElements = 20394,        /* 0x4faa */
        LINKAGEID_UvVertex = 20799,        // 0x513f
        LINKAGEID_RenderVertex = 20899,        // 0x51a3
        LINKAGEID_AnimatorCompressionCell = 20904,        /* 0x51a8 */
        LINKAGEID_Feature = 21033,        /* 0x5229 */
        LINKAGEID_EmbeddedBRep = 21038,        /* 0x522e */
        LINKAGEID_Profile = 21041,        /* 0x5231 */
        LINKAGEID_Compression = 21047,        /* 0x5237 */
        LINKAGEID_NoteLinkage = 22062,        /* 0x562e */
        TEXTNODE_Linkage = 22220,        /* 0x56CC */
        TEXT_Linkage = 22221,        /* 0x56CD */
        LINKAGEID_Dependency = 22224,        // 0x56d0 */
        LINKAGEID_String = 22226,        /* 0x56d2 XATTRIBUTEID_String */
        LINKAGEID_BitMask = 22227,        /* 0x56d3 */
        LINKAGEID_Thickness = 22228,        /* 0x56d4 */
        LINKAGEID_DoubleArray = 22229,        /* 0x56d5 */
        LINKAGEID_ToolTemplate = 22230,        /* 0x56d6 */
        LINKAGEID_AssocRegion = 22232,        /* 0x56d8 */
        LINKAGEID_SeedPoints = 22234,        /* 0x56da */
        LINKAGEID_MultipleLevels = 22235,        /* 0x56db */
        LINKAGEID_ClipBoundary = 22236,        /* 0x56dc */
        LINKAGEID_FilterMember = 22237,        /* 0x56dd */
        LINKAGEID_DimExtensionLinkage = 22238,        /* 0x56de */
        LINKAGEID_Symbology = 22241,        /* 0x56e1 */
        LINKAGEID_XML = 22243,        /* 0x56e3 XATTRIBUTEID_XML */
        LINKAGEID_XData = 22244,        /* 0x56e4 */
        LINKAGEID_BoundaryAssociations = 22245,        /* 0x56e5 */
        LINKAGEID_LoopOEDCode = 22247,        /* 0x56e7 */
        LINKAGEID_LevelLibrary = 22248,        /* 0x56e8 */
        LINKAGEID_InfiniteLine = 22249,        /* 0x56e9 */
        LINKAGEID_SheetModel = 22253,        /* 0x56ed */
        LINKAGEID_SheetScale = 22254,        /* 0x56ee */
        LINKAGEID_ReferenceAttachmentPath = 22257,        /* 0x56f1 */
        LINKAGEID_TextAnnotation = 22259,        /* 0x56f3 */
        LINKAGEID_SheetModelEx = 22273,        /* 0x5701 */
        LINKAGEID_LevelMask = 22288,        /* 0x5710 */
        LINKAGEID_ByteArray = 22353,        /* 0x5751 */
        LINKAGEID_DimTextStyle = 22529,        /* 0x5801 */
        LINKAGEID_TextIdentation = 22544,        /* 0x5810 */
        LINKAGEID_LineStyleMod = 31225,        /* 0x79f9 */
        LINKAGEID_Hatch = 32040,        /* 0x7d28 */
        LINKAGEID_TextStyle = 32980,        /* 0x80d4 */
        LINKAGEID_OLE = 45086,        /* 0xb01e */

        FRAMME_ID = 0x0020,   // DB Linkage - FRAMME tag data signature
        BSI_ID = 0x0F81,   // DB Linkage - secondary id link (BSI radix 50)
        XBASE_ID = 0x1971,   // DB Linkage - XBase (DBase)
        INFORMIX_ID = 0x3948,   // DB Linkage - Informix
        INGRES_ID = 0x3A77,   // DB Linkage - INGRES
        SYBASE_ID = 0x4F58,   // DB Linkage - Sybase
        ODBC_ID = 0x5E62,   // DB Linkage - ODBC
        OLEDB_ID = 0x5800,   // DB Linkage - OLEDB
        ORACLE_ID = 0x6091,   // DB Linkage - Oracle
        RIS_ID = 0x71FB,   // DB Linkage - RIS
        BUDBC_ID = 0x5834, // DB Linkage - BUDBC
    };

    public enum FilterMemberType : int
    {
        TypeNull = 0,
        TypeShort = 1,
        TypeInt = 2,
        TypeBool = 3,
        TypeChar = 4,
        TypeWChar = 5,
        TypeDouble = 6,
        TypeTime = 7,
        TypeUInt = 8,
        TypeColor = 9,
        TypeStyle = 10,
    }

    public enum LinkageKeyValuesString : int
    {
        STRING_LINKAGE_KEY_Generic = 0,
        STRING_LINKAGE_KEY_Name = 1,
        STRING_LINKAGE_KEY_Description = 2,
        STRING_LINKAGE_KEY_FileName = 3,
        STRING_LINKAGE_KEY_LogicalName = 4,
        STRING_LINKAGE_KEY_PatternCell = 5,
        STRING_LINKAGE_KEY_DimensionStyle = 6,
        STRING_LINKAGE_KEY_DimStyleDescr = 7,
        STRING_LINKAGE_KEY_Library = 8,
        STRING_LINKAGE_KEY_ProfileName = 9,
        STRING_LINKAGE_KEY_LevelNameExpr = 10,
        STRING_LINKAGE_KEY_LevelDescriptionExpr = 11,
        STRING_LINKAGE_KEY_LevelColorExpr = 12,
        STRING_LINKAGE_KEY_LevelStyleExpr = 13,
        STRING_LINKAGE_KEY_LevelWeightExpr = 14,
        STRING_LINKAGE_KEY_ElementColorExpr = 15,
        STRING_LINKAGE_KEY_ElementStyleExpr = 16,
        STRING_LINKAGE_KEY_ElementWeightExpr = 17,
        STRING_LINKAGE_KEY_FileExpr = 18,
        STRING_LINKAGE_KEY_MastUnitLabel = 19,
        STRING_LINKAGE_KEY_SubUnitLabel = 20,
        STRING_LINKAGE_KEY_ModelName = 21,
        STRING_LINKAGE_KEY_SecondaryMastUnitLabel = 22,
        STRING_LINKAGE_KEY_SecondarySubUnitLabel = 23,
        STRING_LINKAGE_KEY_DimArrowCellName = 24,
        STRING_LINKAGE_KEY_DimStrokeCellName = 25,
        STRING_LINKAGE_KEY_DimDotCellName = 26,
        STRING_LINKAGE_KEY_DimOriginCellName = 27,
        STRING_LINKAGE_KEY_DimPrefixCellName = 28,
        STRING_LINKAGE_KEY_DimSuffixCellName = 29,
        STRING_LINKAGE_KEY_NameSpace = 30,
        STRING_LINKAGE_KEY_FullReferencePath = 31,
        STRING_LINKAGE_KEY_FilterMember = 32,
        STRING_LINKAGE_KEY_XData = 33,
        STRING_LINKAGE_KEY_ReportName = 34,
        STRING_LINKAGE_KEY_RefAlternateFile = 35,
        STRING_LINKAGE_KEY_RefAlternateModel = 36,
        STRING_LINKAGE_KEY_RefAlternateFullPath = 37,
        STRING_LINKAGE_KEY_DWGPatternName = 38,
        STRING_LINKAGE_KEY_DWGMTextFile = 39,
        STRING_LINKAGE_KEY_DWGDieselTextFile = 40,
        STRING_LINKAGE_KEY_AlternateFontName = 41,
        STRING_LINKAGE_KEY_DwgBlockName = 42,
        STRING_LINKAGE_KEY_NamedGroupName = 43,
        STRING_LINKAGE_KEY_NamedGroupDescription = 44,
        STRING_LINKAGE_KEY_NamedGroupType = 45,
        STRING_LINKAGE_KEY_ReferenceNamedGroup = 46,
        STRING_LINKAGE_KEY_DefaultRefLogical = 47,
        STRING_LINKAGE_KEY_ReferenceRevision = 48,
        STRING_LINKAGE_KEY_DimNoteCellName = 49,
        STRING_LINKAGE_KEY_ClipName = 50,
        STRING_LINKAGE_KEY_GeoFeature = 51,
        STRING_LINKAGE_KEY_GeoPbaName = 52,
        STRING_LINKAGE_KEY_SheetFormName = 53,
        STRING_LINKAGE_KEY_PaperFormName = 54,
        STRING_LINKAGE_KEY_WindowsPrinterName = 55,
        STRING_LINKAGE_KEY_PltFileName = 56,
        STRING_LINKAGE_KEY_ColorBook = 57,
        STRING_LINKAGE_KEY_AnimationParameter = 58,
        STRING_LINKAGE_KEY_AnimationActionType = 59,
        STRING_LINKAGE_KEY_AnimationOriginalActorName = 60,
        STRING_LINKAGE_KEY_SchemaName = 61,
        STRING_LINKAGE_KEY_EndField = 62,
        STRING_LINKAGE_KEY_PstFileName = 63,
        STRING_LINKAGE_KEY_ReferenceProviderID = 64,
        STRING_LINKAGE_KEY_IlluminatedMesh = 66,
        STRING_LINKAGE_KEY_LevelColor = 67,
        STRING_LINKAGE_KEY_LevelElementColor = 68,
        STRING_LINKAGE_KEY_LevelStyle = 69,
        STRING_LINKAGE_KEY_LevelElementStyle = 70,
        STRING_LINKAGE_KEY_LevelMaterial = 71,
        STRING_LINKAGE_KEY_LevelElementMaterial = 72,
        STRING_LINKAGE_KEY_SheetName = 73,
        STRING_LINKAGE_KEY_Sheet_UNUSED_74 = 74,
        STRING_LINKAGE_KEY_EcInstance = 75,
        STRING_LINKAGE_KEY_ECOMConnectionLinkage = 76,
        STRING_LINKAGE_KEY_ComponentSetExpressionSummary = 77,
        STRING_LINKAGE_KEY_ECOMConnectionNamedGroupLinkage = 78,
        STRING_LINKAGE_KEY_ComponentSetExpression = 79,
        STRING_LINKAGE_KEY_SchemaVersion = 80,
        STRING_LINKAGE_KEY_CommonGeometryType = 81,
        STRING_LINKAGE_KEY_CommonGeometryOperation = 82,
        STRING_LINKAGE_KEY_PrintStyleName = 83,
        STRING_LINKAGE_KEY_SchemaProviderName = 84,
        STRING_LINKAGE_KEY_DwgEntityPropertyList = 85,
        STRING_LINKAGE_KEY_EmbeddedReference = 86,
        STRING_LINKAGE_KEY_ReferenceSymbologyTemplate = 87,
        STRING_LINKAGE_KEY_SheetIndexDefaultProperties = 88,
        STRING_LINKAGE_KEY_BackgroundMapJson = 89,
        STRING_LINKAGE_KEY_NamedPresentationCondition = 90,
    };

    public enum LinkageKeyValuesDoubleArray : int
    {
        DOUBLEARRAY_LINKAGE_KEY_Generic = 0,
        DOUBLEARRAY_LINKAGE_KEY_Fence = 1,
        DOUBLEARRAY_LINKAGE_KEY_ClippingRct = 2,
        DOUBLEARRAY_LINKAGE_KEY_ClippingMsk = 3,
        DOUBLEARRAY_LINKAGE_KEY_ClippingRotation = 4,
        DOUBLEARRAY_LINKAGE_KEY_WorldToViewXForm = 5,
        DOUBLEARRAY_LINKAGE_KEY_ViewToWorldXForm = 6,
        DOUBLEARRAY_LINKAGE_KEY_FlattenTransform = 7,
        DOUBLEARRAY_LINKAGE_KEY_DwgTransform = 8,
        DOUBLEARRAY_LINKAGE_KEY_RefColorAdjustment = 9,
        DOUBLEARRAY_LINKAGE_KEY_HLinePathInfo = 10,
        DOUBLEARRAY_LINKAGE_KEY_RefColorAdvancedAdjustment = 11,
        DOUBLEARRAY_LINKAGE_KEY_RegionTextMarginFactor = 12,
        DOUBLEARRAY_LINKAGE_KEY_AuxCoordScale = 13,
        DOUBLEARRAY_LINKAGE_KEY_RefTransparency = 14,
        DOUBLEARRAY_LINKAGE_KEY_Transform = 15,
        DOUBLEARRAY_LINKAGE_KEY_PlacemarkMonument = 16,
        DOUBLEARRAY_LINKAGE_KEY_AnnotationScale = 17,
        DOUBLEARRAY_LINKAGE_KEY_ClippingDepth = 18,
        DOUBLEARRAY_LINKAGE_KEY_RefAdditionalFlags = 19,
        DOUBLEARRAY_LINKAGE_KEY_OriginRelativeOffset = 20,
    };

    public enum LinkageKeyValuesByteArray : int
    {
        BYTEARRAY_LINKAGE_KEY_FontNameCP = 0,
        BYTEARRAY_LINKAGE_KEY_AlternateFontNameCP = 1,
        BYTEARRAY_LINKAGE_KEY_HLineTiling = 2,
        BYTEARRAY_LINKAGE_KEY_SectionEdgeId = 3,
        BYTEARRAY_LINKAGE_KEY_VectorIconModel = 4,
        BYTEARRAY_LINKAGE_KEY_AuxCoordGrid = 5,
    };

    public enum LinkageKeyValuesBitmask : int
    {
        BITMASK_LINKAGE_KEY_Generic = 0,
        BITMASK_LINKAGE_KEY__________Unused = 1,
        BITMASK_LINKAGE_KEY_Level = 2,
        BITMASK_LINKAGE_KEY_HiddenLineFlags = 4,
        BITMASK_LINKAGE_KEY_LibraryRefs = 5,
        BITMASK_LINKAGE_KEY_TextWhiteSpace = 6,
        BITMASK_LINKAGE_KEY_RasterOverrideFlags = 7,
        BITMASK_LINKAGE_KEY_MlineOverrideFlags = 8,
        BITMASK_LINKAGE_KEY_LevelAttributes = 9,
        BITMASK_LINKAGE_KEY_DimShieldsBase = 100,
        BITMASK_LINKAGE_KEY_DimBallAndChainShields = 100,
        BITMASK_LINKAGE_KEY_DimExtensionLineShields = 101,
        BITMASK_LINKAGE_KEY_DimGeneralShields = 102,
        BITMASK_LINKAGE_KEY_DimMuliLineShields = 103,
        BITMASK_LINKAGE_KEY_DimPlacementShields = 104,
        BITMASK_LINKAGE_KEY_DimSymbolShields = 105,
        BITMASK_LINKAGE_KEY_DimTerminatorShields = 106,
        BITMASK_LINKAGE_KEY_DimTextShields = 107,
        BITMASK_LINKAGE_KEY_DimToleranceShields = 108,
        BITMASK_LINKAGE_KEY_DimValueShields = 109,
        BITMASK_LINKAGE_KEY_DimTemplate0Shields = 110,
        BITMASK_LINKAGE_KEY_DimTemplate1Shields = 111,
        BITMASK_LINKAGE_KEY_DimTemplate2Shields = 112,
        BITMASK_LINKAGE_KEY_DimTemplate3Shields = 113,
        BITMASK_LINKAGE_KEY_DimTemplate4Shields = 114,
        BITMASK_LINKAGE_KEY_DimTemplate5Shields = 115,
        BITMASK_LINKAGE_KEY_DimTemplate6Shields = 116,
        BITMASK_LINKAGE_KEY_DimTemplate7Shields = 117,
        BITMASK_LINKAGE_KEY_DimTemplate8Shields = 118,
        BITMASK_LINKAGE_KEY_DimTemplate9Shields = 119,
        BITMASK_LINKAGE_KEY_DimTemplate10Shields = 120,
        BITMASK_LINKAGE_KEY_DimTemplate11Shields = 121,
        BITMASK_LINKAGE_KEY_DimTemplate12Shields = 122,
        BITMASK_LINKAGE_KEY_DimTemplate13Shields = 123,
        BITMASK_LINKAGE_KEY_DimTemplate14Shields = 124,
        BITMASK_LINKAGE_KEY_DimTemplate15Shields = 125,
        BITMASK_LINKAGE_KEY_DimTemplate16Shields = 126,
        BITMASK_LINKAGE_KEY_DimTemplate17Shields = 127,
        BITMASK_LINKAGE_KEY_DimTemplate18Shields = 128,
        BITMASK_LINKAGE_KEY_DimTemplate19Shields = 129,
        BITMASK_LINKAGE_KEY_DimTemplate20Shields = 130,
        BITMASK_LINKAGE_KEY_DimTemplate21Shields = 131,
        BITMASK_LINKAGE_KEY_DimTemplate22Shields = 132,
        BITMASK_LINKAGE_KEY_DimTemplate23Shields = 133,
    };

    public enum LinkageKeyValuesMultiStateMask : int
    {
        MULTISTATEMASK_LINKAGE_KEY_NamedLevelMask = 1,
    };

    public enum LinkageKeyValuesSymbology : int
    {
        SYMBOLOGY_LINKAGE_KEY_RefBound = 0,
        SYMBOLOGY_LINKAGE_KEY_HLineVisible = 1,
        SYMBOLOGY_LINKAGE_KEY_HLineHidden = 2,
        SYMBOLOGY_LINKAGE_KEY_HLineSmooth = 3,
    };

    public enum LinkageKeyValuesElementId : int
    {
        ELEMENTID_LINKAGE_KEY_Generic = 0,
        ELEMENTID_LINKAGE_KEY_NestedAttachmentLevelTable = 1,
        ELEMENTID_LINKAGE_KEY_glyphId = 2,
        ELEMENTID_LINKAGE_KEY_LevelMaskAttachmentId = 3,
    };

    public enum LinkageKeyValuesModelId : int
    {
        MODELID_LINKAGE_KEY_ReferenceAttachment = 0,
    };

    public enum DependencyLinkageType : int
    {
        DEPENDENCY_DATA_TYPE_ELEM_ID = 0,
        DEPENDENCY_DATA_TYPE_ELEM_ID_V = 1,
        DEPENDENCY_DATA_TYPE_ASSOC_POINT = 2,
        DEPENDENCY_DATA_TYPE_ASSOC_POINT_I = 3,
        DEPENDENCY_DATA_TYPE_FAR_ELEM_ID = 4,
        DEPENDENCY_DATA_TYPE_FAR_ELEM_ID_V = 5,
        DEPENDENCY_DATA_TYPE_PATH_V = 6,
    };

    public class Linkage
    {
        public LinkageHeader LinkageHeader;
        public byte[] Data;

        public Linkage Read(BinaryReader br)
        {
            LinkageHeader = new LinkageHeader().Read(br);
            int exponent = 0; // LinkageHeader.WdExponent;
            int length = LinkageHeader.WdMantissa * Utils.V8Power2(exponent);
            if (exponent == 0)
            {
                Data = new byte[2 * (length - 1)];
                for (int i = 0; i < 2 * (length - 1); i++)
                    Data[i] = br.ReadByte();
            }
            else
            {
                Data = new byte[2 * (length - 2)];
                for (int i = 0; i < 2 * (length - 2); i++)
                    Data[i] = br.ReadByte();
            }
            return this;
        }

        public LinkageIds Type => (LinkageIds)LinkageHeader.PrimaryID;

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.Write($"{ident}PrimaryId=0x{LinkageHeader.PrimaryID:X4}, DataSize={Data.Length}");
            switch (Type)
            {
                case LinkageIds.LINKAGEID_String:
                    {
                        StringLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
                case LinkageIds.LINKAGEID_TextAnnotation:
                    {
                        TextAnnotationScaleLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
                case LinkageIds.LINKAGEID_Thickness:
                    {
                        ThicknessLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
                case LinkageIds.LINKAGEID_Dependency:
                    {
                        DepLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
                case LinkageIds.LINKAGEID_ByteArray:
                    {
                        ByteArrayLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
                case LinkageIds.LINKAGEID_FilterMember:
                    {
                        FilterMemberLinkage linkage = new(Data);
                        linkage.Dump(sw, level);
                    }
                    break;
            }
            sw.WriteLine();
        }
    }

    public class FilterMemberLinkage
    {
        public UInt32 MemberId;
        public UInt32 MemberType;
        public UInt32 Size1;
        public UInt32 Size2;
        public Int32 Length;
        public string NameString;
        public string ExpressionString;

        public FilterMemberLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            MemberId = br.ReadUInt32();
            MemberType = br.ReadUInt32();
            Size1 = br.ReadUInt32();    // 0x12
            Size2 = br.ReadUInt32();    // 0x00
            Length = br.ReadInt32();
            if ((data[0x14] == 0xff) && (data[0x15] == 0xfe) && (data[0x16] == 0x01) && (data[0x17] == 0x00))
            {
                // skip UTF32 LE BOM
                br.ReadInt32();
                Length -= 4;
            }
            NameString = System.Text.Encoding.UTF8.GetString(br.ReadBytes(Length));
        }

        public void Dump(StreamWriter sw, int level)
        {
            sw.Write($" (Filter Member Linkage, MemberId={MemberId}, MemberType={(FilterMemberType)MemberType}, NameString=\"{NameString}\", ExpressionString=\"{ExpressionString}\" )");
        }
    }

    public class ByteArrayLinkage
    {
        public UInt32 ByteArrayId;
        public Int32 ByteArraySize;
        public byte[] ByteArrayData;

        public ByteArrayLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            ByteArrayId = br.ReadUInt32();
            ByteArraySize = br.ReadInt32();
            ByteArrayData = new byte[ByteArraySize];
            ByteArrayData = br.ReadBytes(ByteArraySize);
        }

        public void Dump(StreamWriter sw, int level)
        {
            sw.Write($" (Byte Array Linkage, ByteArrayId=0x{ByteArrayId:X}, ByteArraySize={ByteArraySize} )");
        }
    }

    public class StringLinkage
    {
        public LinkageKeyValuesString Key;
        public int Length;
        public string String;

        public StringLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data), Encoding.UTF8);
            Key = (LinkageKeyValuesString)br.ReadInt32();
            Length = br.ReadInt32();
            if ((data[8] == 0xff) && (data[9] == 0xfe) && (data[10] == 0x01) && (data[11] == 0x00))
            {
                // skip UTF32 LE BOM
                br.ReadInt32();
                Length -= 4;
            }
            String = System.Text.Encoding.UTF8.GetString(br.ReadBytes(Length));
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.Write($" (String Linkage, Key={Key}, Value=\"{String}\")");
        }
    }

    public class DepLinkage
    {
        DependencyLinkage DependencyLinkage;

        public DepLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            DependencyLinkage = new DependencyLinkage().Read(br);
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.Write($" (Dependency Linkage, AppId=0x{DependencyLinkage.AppID:X4}, AppValue={DependencyLinkage.AppValue}, Root Data Type={(DependencyLinkageType)DependencyLinkage.U.F.RootDataType}, NRoots={DependencyLinkage.NRoots}, Roots=(");
            for (int i = 0; i < DependencyLinkage.NRoots; i++)
            {
                switch ((DependencyLinkageType)DependencyLinkage.U.F.RootDataType)
                {
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID:
                        sw.Write($"Root[{i}]=0x{DependencyLinkage.Root.Elemid[i]:X16}");
                        break;
                }
                if (i != DependencyLinkage.NRoots - 1)
                {
                    sw.Write($", ");
                }
            }
            sw.Write($") )");
        }
    }

    public class TextAnnotationScaleLinkage
    {
        public double Scale;

        public TextAnnotationScaleLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            // skip 4 bytes
            br.ReadInt32();
            Scale = br.ReadDouble();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.Write($" (Text Annotation Scale Linkage, Value={Scale})");
        }
    }

    public class ThicknessLinkage
    {
        public LinkageKeyValuesString Key;
        public int Length;
        public string String;

        public ThicknessLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data), Encoding.UTF8);
            Key = (LinkageKeyValuesString)br.ReadInt32();
            Length = br.ReadInt32();
            String = System.Text.Encoding.UTF8.GetString(br.ReadBytes(Length));
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.Write($" (String Linkage, Key={Key}, Value=\"{String}\")");
        }
    }
}
