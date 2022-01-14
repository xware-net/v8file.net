using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using T_Adouble = System.Double;

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
        //LINKAGEID_CellDef = 20371,        /* 0x4f93 */
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

        LINKAGEID_SharedCellFlags = 22250,      /* 0x56ea */
        LINKAGEID_RasterMetadata = 22251,      /* 0x56eb */

        LINKAGEID_SheetModel = 22253,        /* 0x56ed */
        LINKAGEID_SheetScale = 22254,        /* 0x56ee */

        LINKAGEID_StandardsChecker = 22255,      /* 0x56ef */
        LINKAGEID_StandardsCheckerSettings = 22256,      /* 0x56f0 */

        LINKAGEID_ReferenceAttachmentPath = 22257,        /* 0x56f1 */
        LINKAGEID_TextAnnotation = 22259,        /* 0x56f3 */

        LINKAGEID_AnimationModel = 22262,      /* 0x56f6 */
        LINKAGEID_AnimationScriptParameter = 22263,      /* 0x56f7 */
        LINKAGEID_AnimationData = 22264,      /* 0x56f8 */
        LINKAGEID_AnimationPlugins = 22265,      /* 0x56f9 */
        LINKAGEID_AnimationEntryDescription = 22266,      /* 0x56fa */
        LINKAGEID_CustomKeypoint = 22267,      /* 0x56fb */
        LINKAGEID_AnimationTimeElement = 22268,      /* 0x56fc */
        LINKAGEID_TestLinkage = 22269,      /* 0x56fd */
        LINKAGEID_AnimationKeyFrameElement = 22270,      /* 0x56fe */
        LINKAGEID_ECXAttributes = 22271,      /* 0x56ff */

        LINKAGEID_SheetModelEx = 22273,        /* 0x5701 */

        LINKAGEID_PersistentTopology = 22285,       /* 0x570d */
        LINKAGEID_ConflictRevisions = 22287,       /* 0x570f XATTRIBUTEID_ConflictRevisions */

        LINKAGEID_LevelMask = 22288,        /* 0x5710 */

        LINKAGEID_MstnApplicationSetting = 22289,       /* 0x5711 */
        LINKAGEID_MaxwellMaterialMapping = 22291,       /* 0x5713 */
        LINKAGEID_DGNECPlugin = 22294,       /* 0x5716 XATTRIBUTEID_DGNECPlugin */
        LINKAGEID_ModelID = 22295,       /* 0x5717 */
        LINKAGEID_ModelHandler = 22296,       /* 0x5718 */
        LINKAGEID_ComponentSet = 22297,       /* 0x5719 */
        LINKAGEID_PrintStyle = 22298,       /* 0x571a XATTRIBUTEID_PrintStyle  */
        LINKAGEID_ECOMConnection = 22299,       /* 0x571b */
        LINKAGEID_LuxologyPresetMapping = 22300,       /* 0x571c */
        LINKAGEID_GeotechnicalData = 22301,       /* 0x571d */

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
        public bool Is3d;

        public Linkage Read(BinaryReader br, bool is3d = false)
        {
            Is3d = is3d;
            LinkageHeader = new LinkageHeader().Read(br);
            int exponent = 0; // LinkageHeader.WdExponent;
            if ((LinkageIds)LinkageHeader.PrimaryID == LinkageIds.LINKAGEID_DMRS)
            {
                LinkageHeader.WdMantissa = 3;
            }
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

        public void LinkageDump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}PrimaryId=0x{LinkageHeader.PrimaryID:X4} ({(LinkageIds)LinkageHeader.PrimaryID}), DataSize={Data.Length}");
            switch (Type)
            {
                case LinkageIds.LINKAGEID_String:
                    {
                        StringLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_TextAnnotation:
                    {
                        TextAnnotationScaleLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_Thickness:
                    {
                        ThicknessLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_Dependency:
                    {
                        DepLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_ByteArray:
                    {
                        ByteArrayLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_DoubleArray:
                    {
                        DoubleArrayLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_FilterMember:
                    {
                        FilterMemberLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_FillStyle:
                    {
                        FillStyleLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_BitMask:
                    {
                        BitMaskLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_LevelMask:
                    {
                        LevelMaskLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_DMRS:
                    {
                        DMRSLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_LineStyleMod:
                    {
                        LineStyleModLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_SheetModel:
                    {
                        SheetModelLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_SheetModelEx:
                    {
                        SheetModelExLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_SheetScale:
                    {
                        SheetScaleLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_XML:
                    {
                        XmlLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_InfiniteLine:
                    {
                        InfiniteLineLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
                case LinkageIds.LINKAGEID_Hatch:
                    {
                        HatchLinkage linkage = new(Data);
                        linkage.Dump(sw, level + 1);
                    }
                    break;
            }
        }
    }

    public class HatchLinkage : Linkage
    {
        PatternParamsModifierFlags PatternParamsModifierFlags;
        PatternParams PatternParams = new PatternParams();
        public T_Adouble[] Quat;

        public HatchLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            PatternParamsModifierFlags = (PatternParamsModifierFlags)br.ReadUInt32();
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Space1) != 0)
            {
                PatternParams.Space1 = br.ReadDouble();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Angle1) != 0)
            {
                PatternParams.Angle1 = br.ReadDouble();
                if (PatternParams.Angle1 >= -6.283185307179586)
                {
                    if (PatternParams.Angle1 > 6.283185307179586)
                        PatternParams.Angle1 = 6.283185307179586;
                }
                else
                {
                    PatternParams.Angle1 = -6.283185307179586;
                }
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Space2) != 0)
            {
                PatternParams.Space2 = br.ReadDouble();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Angle2) != 0)
            {
                PatternParams.Angle2 = br.ReadDouble();
                if (PatternParams.Angle2 >= -6.283185307179586)
                {
                    if (PatternParams.Angle2 > 6.283185307179586)
                        PatternParams.Angle2 = 6.283185307179586;
                }
                else
                {
                    PatternParams.Angle2 = -6.283185307179586;
                }
            } else
            {
                PatternParams.Angle2 = PatternParams.Angle1 + 1.570796326794897;
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Scale) != 0)
            {
                PatternParams.Scale = br.ReadDouble();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Tolerance) != 0)
            {
                PatternParams.Tolerance = br.ReadDouble();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Style) != 0)
            {
                PatternParams.Style = br.ReadInt32();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Weight) != 0)
            {
                PatternParams.Weight = br.ReadUInt32();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Color) != 0)
            {
                PatternParams.Color = br.ReadUInt32();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.RotMatrix) != 0)
            {
                Quat = new T_Adouble[4];
                for (int i = 0; i < 4; i++)
                {
                    Quat[i] = br.ReadDouble();
                }
                // generate PatternParams.RotMatrix
                if (Is3d)
                {

                } else
                {

                }
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Offset) != 0)
            {
                PatternParams.Offset = new DPoint3d().Read(br);
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.Multiline) != 0)
            {
                PatternParams.MinLine = br.ReadInt32();
                PatternParams.MaxLine = br.ReadInt32();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.HoleStyle) != 0)
            {
                PatternParams.PatternParamsHoleStyleType = (PatternParamsHoleStyleType)br.ReadInt16();
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.DwgHatchDef) != 0)
            {
                PatternParams.DwgHatchDef = new DwgHatchDef().Read(br);
            }
            if ((PatternParamsModifierFlags & PatternParamsModifierFlags.AnnotationScale) != 0)
            {
                PatternParams.AnnotationScale = br.ReadDouble();
            }

            // we must get also the Origin, ...
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Hatch Linkage");
            sw.WriteLine($"{ident}  Pattern Params >");
            PatternParams.Dump(sw, level + 2);
        }
    }

    public enum InfiniteLineType : uint
    {
        LineSegment = 0,
        FromStartPoint = 1,
        FromEndPoint = 2,
        InfiniteLine = 3
    };

    public class InfiniteLineLinkage : Linkage // 56e9, size xxx
    {
        public InfiniteLineType InfiniteLineType;       // 0x00

        public InfiniteLineLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            InfiniteLineType = (InfiniteLineType)br.ReadUInt32();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Infinite Line Linkage");
            sw.WriteLine($"{ident}  InfiniteLineType={InfiniteLineType}");
        }
    }

    public class XmlLinkage : Linkage // 56e3, size xxx
    {
        public UInt16 Dummy1;       // 0x00
        public UInt16 Dummy2;       // 0x02
        public UInt32 Dummy3;       // 0x04
        public UInt32 Dummy4;       // 0x08
        public UInt32 Dummy5;       // 0x0c
        public UInt32 Dummy6;       // 0x10
        public UInt32 Dummy7;       // 0x14
        public Int32 NameLength;    // 0x18
        public string Name;
        public Int32 XmlLength;
        public string XmlString;

        public XmlLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy1 = br.ReadUInt16();
            Dummy2 = br.ReadUInt16();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Dummy6 = br.ReadUInt32();
            Dummy7 = br.ReadUInt32();
            NameLength = br.ReadInt32();
            XmlString = System.Text.Encoding.Unicode.GetString(br.ReadBytes(NameLength));
            XmlLength = br.ReadInt32();
            XmlString = System.Text.Encoding.Unicode.GetString(br.ReadBytes(XmlLength));
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Xml Linkage");
            sw.WriteLine($"{ident}  Dummy1={Dummy1}, Dummy2={Dummy2}, Dummy3={Dummy3}, Dummy4={Dummy4}, Dummy5={Dummy5}, Dummy6={Dummy6}, Dummy7={Dummy7}, NameLength={NameLength}, Name={Name}, XmlLength={XmlLength}, XmlString={XmlString}");
        }
    }

    public class SheetModelExLinkage : Linkage // 5701, size 20
    {
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public UInt64 Dummy3;
        public UInt32 Dummy4;

        public SheetModelExLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt64();
            Dummy4 = br.ReadUInt32();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Sheet Def Linkage");
            sw.WriteLine($"{ident}  Dummy1={Dummy1}, Dummy2={Dummy2}, Dummy3={Dummy3}, Dummy4={Dummy4}");
        }
    };

    public class SheetModelLinkage : Linkage // 56ed, size 312 (0x138)
    {
        public UInt16 Dummy10;                  // 0x00
        public SheetDef_Flags Flags;            // 0x02
        public UInt32 Dummy12;                  // 0x04
        public DPoint2d Origin;                 // 0x08
        public double Rotation;                 // 0x18
        public double SheetWidth;               // 0x20
        public double SheetHeight;              // 0x28
        public RgbColorDef Color;               // 0x30
        public byte Dummy14;                    // 0x33
        public UInt32 Dummy11;                  // 0x34
        public UnitFlags UnitFlags;             // 0x38
        public UInt32 Dummy15;                  // 0x3c
        public double Numerator;                // 0x40
        public double Denominator;              // 0x48
        public string UnitName;                 // 0x50
        public double Dummy7;                   // 0x58
        public double DWGPaperOrientation;      // 0x60
        public double TopMargin;                // 0x68
        public double LeftMargin;               // 0x70
        public double BottomMargin;             // 0x78
        public double RightMargin;              // 0x80
        public double PlotScaleFactor;          // 0x88
        public double Dummy8;                   // 0x90
        public double Dummy9;                   // 0x98
        public UInt32 SheetNumber;              // 0xa0
        public UInt32 Dummy1;                   // 0xa4
        public UInt64 BorderAttachmentId;       // 0xa8
        public double Dummy90;                  // 0xb0
        public double Dummy91;                  // 0xb8
        public double Dummy92;                  // 0xc0
        public UnitDefinition UnitDefinition;
        public string Label;

        public SheetModelLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy10 = br.ReadUInt16();
            Flags = new SheetDef_Flags().Read(br);
            Dummy12 = br.ReadUInt32();
            Origin = new DPoint2d().Read(br);
            Rotation = br.ReadDouble();
            SheetWidth = br.ReadDouble();
            SheetHeight = br.ReadDouble();
            Color = new RgbColorDef().Read(br);
            Dummy14 = br.ReadByte();
            Dummy11 = br.ReadUInt32();
            UnitFlags = new UnitFlags().Read(br);
            Dummy15 = br.ReadUInt32();
            Numerator = br.ReadDouble();
            Denominator = br.ReadDouble();
            Label = System.Text.Encoding.Unicode.GetString(br.ReadBytes(8));
            UnitDefinition = new UnitDefinition
            {
                Base = (UnitBase)(UnitFlags.Base),
                System = (UnitSystem)(UnitFlags.System),
                Numerator = Numerator,
                Denominator = Denominator,
                Label = Label.Replace("\x00", "")
            };
            Dummy7 = br.ReadDouble();
            DWGPaperOrientation = br.ReadDouble();
            TopMargin = br.ReadDouble();
            LeftMargin = br.ReadDouble();
            BottomMargin = br.ReadDouble();
            RightMargin = br.ReadDouble();
            PlotScaleFactor = br.ReadDouble();
            Dummy8 = br.ReadDouble();
            Dummy9 = br.ReadDouble();
            SheetNumber = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            BorderAttachmentId = br.ReadUInt64();
            Dummy90 = br.ReadDouble();
            Dummy91 = br.ReadDouble();
            Dummy92 = br.ReadDouble();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Sheet Def Linkage");
        }
    };

    public class SheetScaleLinkage : Linkage // 56ee, size 40
    {
        public UInt32 Dummy1;
        public UInt32 Dummy2;
        public DPoint3d Scale;
        public UInt64 Dummy3;

        public SheetScaleLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Scale = new DPoint3d().Read(br);
            Dummy3 = br.ReadUInt64();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Sheet Scale Linkage");
            sw.WriteLine($"{ident}  Dummy1={Dummy1}, Dummy2={Dummy2}, Scale =({Scale.X},{Scale.Y},{Scale.Z}), Dummy3={Dummy3}");
        }
    };

    public class DoubleArrayLinkage : Linkage
    {
        public UInt32 ArrayId;
        public UInt32 Dummy1;
        private int ArraySize;
        public double[] Array;

        public DoubleArrayLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            ArrayId = br.ReadUInt32();
            Dummy1 = br.ReadUInt32();
            ArraySize = (data.Length - 8) / sizeof(double);
            Array = new double[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Array[i] = br.ReadDouble();
            }
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Double Array Linkage");
            sw.WriteLine($"{ident}  ArraySize={ArraySize}");
            for (int i = 0; i < ArraySize; i++)
            {
                sw.WriteLine($"{ident}    Array[{i}]={Array[i]}");
            }
        }
    }

    public enum LsMultilineDataType : uint
    {
        LsMultilineTypeLine = 0,
        LsMultilineTypeStartCap = 1,
        LsMultilineTypeEndCap = 2,
        LsMultilineTypeJoints = 3
    };

    public enum LsModWidthMode : uint
    {
        LsModNoWidth = 0,
        LsModConstantWidth = 1,
        LsModTaperedWidth = 2
    };

    public enum LsModShiftMode : uint
    {
        LsModNoShift = 0,
        LsModDistance = 1,
        LsModFraction = 2,
        LsModCentered = 3
    };

    public enum LsModCornerMode : uint
    {
        LsModFromLineStyle = 0,
        LsModBreakAtCorners = 1,
        LsModRunThroughCorners = 2
    };

    public struct LineStyleModProperties
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
        private const int sz_1_14 = 16, loc_1_14 = loc_1_13 + sz_1_13, mask_1_14 = unchecked(((1 << sz_1_14) - 1) << loc_1_14);
        private const int sz_1_15 = 1, loc_1_15 = loc_1_14 + sz_1_14, mask_1_15 = unchecked(((1 << sz_1_15) - 1) << loc_1_15);
        private const int sz_1_16 = 1, loc_1_16 = loc_1_15 + sz_1_15, mask_1_16 = unchecked(((1 << sz_1_16) - 1) << loc_1_16);
        public UInt32 STYLEMOD_Scale
        {
            get => (UInt32)(Data1 & mask_1_0) >> loc_1_0;
            set => Data1 = (UInt32)(Data1 & ~mask_1_0 | (value << loc_1_0) & mask_1_0);
        }
        public UInt32 STYLEMOD_DScale
        {
            get => (UInt32)(Data1 & mask_1_1) >> loc_1_1;
            set => Data1 = (UInt32)(Data1 & ~mask_1_1 | (value << loc_1_1) & mask_1_1);
        }
        public UInt32 STYLEMOD_GScale
        {
            get => (UInt32)(Data1 & mask_1_2) >> loc_1_2;
            set => Data1 = (UInt32)(Data1 & ~mask_1_2 | (value << loc_1_2) & mask_1_2);
        }
        public UInt32 STYLEMOD_SWidth
        {
            get => (UInt32)(Data1 & mask_1_3) >> loc_1_3;
            set => Data1 = (UInt32)(Data1 & ~mask_1_3 | (value << loc_1_3) & mask_1_3);
        }
        public UInt32 STYLEMOD_EWidth
        {
            get => (UInt32)(Data1 & mask_1_4) >> loc_1_4;
            set => Data1 = (UInt32)(Data1 & ~mask_1_4 | (value << loc_1_4) & mask_1_4);
        }
        public UInt32 STYLEMOD_DistPhase
        {
            get => (UInt32)(Data1 & mask_1_5) >> loc_1_5;
            set => Data1 = (UInt32)(Data1 & ~mask_1_5 | (value << loc_1_5) & mask_1_5);
        }
        public UInt32 STYLEMOD_FractPhase
        {
            get => (UInt32)(Data1 & mask_1_6) >> loc_1_6;
            set => Data1 = (UInt32)(Data1 & ~mask_1_6 | (value << loc_1_6) & mask_1_6);
        }
        public UInt32 STYLEMOD_CenterPhase
        {
            get => (UInt32)(Data1 & mask_1_7) >> loc_1_7;
            set => Data1 = (UInt32)(Data1 & ~mask_1_7 | (value << loc_1_7) & mask_1_7);
        }
        public UInt32 STYLEMOD_Normal
        {
            get => (UInt32)(Data1 & mask_1_8) >> loc_1_8;
            set => Data1 = (UInt32)(Data1 & ~mask_1_8 | (value << loc_1_8) & mask_1_8);
        }
        public UInt32 STYLEMOD_RMatrix
        {
            get => (UInt32)(Data1 & mask_1_9) >> loc_1_9;
            set => Data1 = (UInt32)(Data1 & ~mask_1_9 | (value << loc_1_9) & mask_1_9);
        }
        public UInt32 Reserved
        {
            get => (UInt32)(Data1 & mask_1_10) >> loc_1_10;
            set => Data1 = (UInt32)(Data1 & ~mask_1_10 | (value << loc_1_10) & mask_1_10);
        }
        public UInt32 STYLEMOD_LineMask
        {
            get => (UInt32)(Data1 & mask_1_11) >> loc_1_11;
            set => Data1 = (UInt32)(Data1 & ~mask_1_11 | (value << loc_1_11) & mask_1_11);
        }
        public UInt32 STYLEMOD_MLineFlags
        {
            get => (UInt32)(Data1 & mask_1_12) >> loc_1_12;
            set => Data1 = (UInt32)(Data1 & ~mask_1_12 | (value << loc_1_12) & mask_1_12);
        }
        public UInt32 STYLEMOD_TrueWidth
        {
            get => (UInt32)(Data1 & mask_1_13) >> loc_1_13;
            set => Data1 = (UInt32)(Data1 & ~mask_1_13 | (value << loc_1_13) & mask_1_13);
        }
        public UInt32 Reserved1
        {
            get => (UInt32)(Data1 & mask_1_14) >> loc_1_14;
            set => Data1 = (UInt32)(Data1 & ~mask_1_14 | (value << loc_1_14) & mask_1_14);
        }
        public UInt32 STYLEMOD_SegMode
        {
            get => (UInt32)(Data1 & mask_1_15) >> loc_1_15;
            set => Data1 = (UInt32)(Data1 & ~mask_1_15 | (value << loc_1_15) & mask_1_15);
        }
        public UInt32 STYLEMOD_NoSegMode
        {
            get => (UInt32)(Data1 & mask_1_16) >> loc_1_16;
            set => Data1 = (UInt32)(Data1 & ~mask_1_16 | (value << loc_1_16) & mask_1_16);
        }

        public LineStyleModProperties Read(BinaryReader br)
        {
            // read each field
            Data1 = br.ReadUInt32();
            return this;
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new String(' ', 2 * level);
            sw.WriteLine($"{ident}STYLEMOD_Scale={STYLEMOD_Scale}");
            sw.WriteLine($"{ident}STYLEMOD_DScale={STYLEMOD_DScale}");
            sw.WriteLine($"{ident}STYLEMOD_GScale={STYLEMOD_GScale}");
            sw.WriteLine($"{ident}STYLEMOD_SWidth={STYLEMOD_SWidth}");
            sw.WriteLine($"{ident}STYLEMOD_EWidth={STYLEMOD_EWidth}");
            sw.WriteLine($"{ident}STYLEMOD_DistPhase={STYLEMOD_DistPhase}");
            sw.WriteLine($"{ident}STYLEMOD_FractPhase={STYLEMOD_FractPhase}");
            sw.WriteLine($"{ident}STYLEMOD_CenterPhase={STYLEMOD_CenterPhase}");
            sw.WriteLine($"{ident}STYLEMOD_Normal={STYLEMOD_Normal}");
            sw.WriteLine($"{ident}STYLEMOD_RMatrix={STYLEMOD_RMatrix}");
            sw.WriteLine($"{ident}Reserved={Reserved}");
            sw.WriteLine($"{ident}STYLEMOD_LineMask={STYLEMOD_LineMask}");
            sw.WriteLine($"{ident}STYLEMOD_MLineFlags={STYLEMOD_MLineFlags}");
            sw.WriteLine($"{ident}STYLEMOD_TrueWidth={STYLEMOD_TrueWidth}");
            sw.WriteLine($"{ident}Reserved1={Reserved1}");
            sw.WriteLine($"{ident}STYLEMOD_SegMode={STYLEMOD_SegMode}");
            sw.WriteLine($"{ident}STYLEMOD_NoSegMode={STYLEMOD_NoSegMode}");
        }
    }

    public class LineStyleModLinkage : Linkage   // 0x79f9
    {
        public LineStyleModProperties LineStyleModProperties;   // 12 or 20 bytes
        public double LineStyleScale;
        public double DashScale;
        public double GapScale;
        public double StartWidth;
        public double EndWidth;
        public double DistPhase;
        public double FractPhase;
        public double ShiftDistance;
        public DPoint3d Normal;
        public T_Adouble[] Quat;
        public UInt32 LineMask;
        public UInt32 MLineFlags;

        public LineStyleModLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            LineStyleModProperties = new LineStyleModProperties().Read(br);
            if (LineStyleModProperties.STYLEMOD_Scale != 0)
                LineStyleScale = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_DScale != 0)
                DashScale = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_GScale != 0)
                GapScale = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_SWidth != 0)
                StartWidth = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_EWidth != 0)
                EndWidth = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_DistPhase != 0)
                DistPhase = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_FractPhase != 0)
                FractPhase = br.ReadDouble();
            if (LineStyleModProperties.STYLEMOD_Normal != 0)
                Normal = new DPoint3d().Read(br);
            if (LineStyleModProperties.STYLEMOD_RMatrix != 0)
            {
                Quat = new T_Adouble[4];
                for (int i = 0; i < 4; i++)
                {
                    Quat[i] = br.ReadDouble();
                }
            }
            if (LineStyleModProperties.STYLEMOD_LineMask != 0)
                LineMask = br.ReadUInt32();
            if (LineStyleModProperties.STYLEMOD_MLineFlags != 0)
                MLineFlags = br.ReadUInt32();

            //LineStyleScale = br.ReadDouble();
            //StartWidth = br.ReadDouble();
            //EndWidth = br.ReadDouble();
            //ShiftDistance = br.ReadDouble();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Line Style Modification Linkage");
        }
    }

    public class DMRSLinkage : Linkage
    {
        public DMRSLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data), Encoding.UTF8);
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}DMRS Linkage");
        }
    }

    public enum GradientType : int
    {
        Linear = 1,
        Curved = 2,
        Cylindrical = 3,
        Spherical = 4,
        Hemispherical = 5
    };

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct COLORREF
    {
        public COLORREF(byte r, byte g, byte b)
        {
            this.Value = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public COLORREF(uint value)
        {
            this.R = 0;
            this.G = 0;
            this.B = 0;
            this.Value = value & 0x00FFFFFF;
        }

        [FieldOffset(0)]
        public byte R;
        [FieldOffset(1)]
        public byte G;
        [FieldOffset(2)]
        public byte B;

        [FieldOffset(0)]
        public uint Value;

        public override string ToString()
        {
            return $"0x00{R:X2}{G:X2}{B:X2}";
        }
    }

    public class GradientKey
    {
        public double KeyPosition;
        public COLORREF ColorRef;

        public GradientKey Read(BinaryReader br)
        {
            // read each field
            KeyPosition = br.ReadDouble();
            var x = br.ReadByte();
            var y = br.ReadByte();
            var z = br.ReadByte();
            br.ReadByte();
            ColorRef = new COLORREF(y, z, x);
            br.ReadUInt32();
            return this;
        }
    }

    public class FillStyleLinkage : Linkage  // 0x0041
    {
        public UInt16 Dummy1;       // 0x000c (LevelOverride), 0x000d (ByLevelAssigned), 0x000e (ElementAssigned) - InternalMaterialLinkage
                                    // 0x0009 - TransparencyLinkage
                                    // 0x0008 - FillColorLinkage (Dummy2 == 0x0000)
                                    // 0x0008 - GradientFillLinkage (Dummy2 == 0x0001)
                                    // 0x000b - ????
                                    // 0x0010 - DisplayStyleLinkage
        public UInt16 Dummy2;
        public UInt64 MaterialId;   // for 0x0c, 0x0d, 0x0e
        public UInt32 FillColor;
        public UInt32 DisplayStyleId;
        public double Transparency;
        public double GradientAngle;
        public double WhiteIntensity;
        public double Shift;
        public bool InvertFlag;
        public UInt16 GradientType;
        public GradientKey[] GradientKeys;
        public UInt16 KeyCount;
        public string Keys;
        public UInt32 UserDefinedColorBookEntry;

        public FillStyleLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy1 = br.ReadUInt16();
            Dummy2 = br.ReadUInt16();
            if (Dummy1 == 0x0008)
            {
                if (Dummy2 == 0x0000)
                {
                    // Fill Color
                    FillColor = br.ReadUInt32();
                }
                else
                {
                    // Gradient Fill
                    GradientAngle = br.ReadDouble();
                    // 0x10
                    WhiteIntensity = br.ReadDouble();
                    // 0x18
                    Shift = br.ReadDouble();
                    // 0x20
                    KeyCount = br.ReadUInt16();
                    // 0x22
                    GradientType = br.ReadUInt16();
                    GradientKeys = new GradientKey[KeyCount];
                    // 0x24
                    InvertFlag = (br.ReadUInt32() & 0x00000001) == 0x00000001;
                    Keys = string.Empty;
                    for (int i = 0; i < KeyCount; i++)
                    {
                        GradientKeys[i] = new GradientKey().Read(br);
                        Keys += string.Format($"Key Number={i}, Key Position={GradientKeys[i].KeyPosition}, Key Color={GradientKeys[i].ColorRef}");
                        if (i != KeyCount - 1)
                            Keys += ", ";
                    }
                }
            }
            else if (Dummy1 == 0x0009)
            {
                if (Dummy2 == 0x0000)
                {
                    Debugger.Break();
                }
                else
                {
                    Transparency = br.ReadDouble();
                }
            }
            else if (Dummy1 == 0x000b)
            {
                if (Dummy2 == 0x0000)
                {
                    Debugger.Break();
                }
                else
                {
                    UserDefinedColorBookEntry = br.ReadUInt32();
                }
            }
            else if (Dummy1 == 0x000c)
            {
                MaterialId = br.ReadUInt64();
            }
            else if (Dummy1 == 0x000d)
            {
                MaterialId = br.ReadUInt64();
            }
            else if (Dummy1 == 0x000e)
            {
                MaterialId = br.ReadUInt64();
            }
            else if (Dummy1 == 0x0010)
            {
                if (Dummy2 == 0x0000)
                {
                    Debugger.Break();
                }
                else
                {
                    DisplayStyleId = br.ReadUInt32();
                }
            }
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            string message;
            _ = Dummy1 switch
            {
                0x0008 => _ = Dummy2 switch
                {
                    0x0000 => message = $"{ident}Fill Color Linkage\r\n{ident}  FillColor={FillColor}",
                    0x0001 => message = $"{ident}Gradient Fill Linkage\r\n{ident}  GradientType={(GradientType)GradientType}, GradientAngle={GradientAngle}, WhiteIntensity={WhiteIntensity}, Shift={Shift}, InvertFlag={InvertFlag}, Keys=({Keys})",
                    _ => message = "???",
                },
                0x0009 => message = $"{ident}Transparency Linkage\r\n{ident}  Transparency={Transparency}",
                0x000b => message = $"{ident}User Defined Color Book Linkage\r\n{ident}  UserDefinedColorBookEntry={UserDefinedColorBookEntry}",
                0x000c => message = $"{ident}Internal Material Linkage\r\n{ident}  Linkage Type=LevelOverride, MaterialId=0x{MaterialId:X}",
                0x000d => message = $"{ident}Internal Material Linkage\r\n{ident}  Linkage Type=ByLevelAssigned, MaterialId=0x{MaterialId:X}",
                0x000e => message = $"{ident}Internal Material Linkage\r\n{ident}  Linkage Type=ElementAssigned, MaterialId=0x{MaterialId:X}",
                0x0010 => message = $"{ident}Display Style Linkage\r\n{ident}  DisplayStyleId={DisplayStyleId}",
                _ => message = $"{ident}Fill Style Linkage\r\n{ident}  Dummy1=0x{Dummy1:X4},  Dummy2=0x{Dummy2:X4}",
            };

            sw.WriteLine(message);
        }
    }

    public class BitMaskLinkage : Linkage        // 0x56d3
    {
        public UInt32 BitMaskId;
        public UInt32 BitCount;
        public Bitmask BitMask;

        public BitMaskLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            BitMaskId = br.ReadUInt32();
            BitCount = br.ReadUInt32();
            BitMask = new Bitmask().Read(br);
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}BitMask Linkage");
            sw.WriteLine($"{ident}  BitMaskId={BitMaskId}, BitCount={BitCount}, BitMaskSize={BitMask.Size}, BitMaskData={BitMask}");
        }
    }

    public class LevelMaskLinkage : Linkage      // 0x5710
    {
        public UInt16 Dummy1;           // always 0x0001 ?
        public UInt16 Dummy2;           // always 0x0002 ?
        public UInt32 Dummy3;           // always 0x00000002 ?
        public UInt32 MaxLevelEntryId;
        public Bitmask BitMask;

        public LevelMaskLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data));
            Dummy1 = br.ReadUInt16();
            Dummy2 = br.ReadUInt16();
            Dummy3 = br.ReadUInt32();
            MaxLevelEntryId = br.ReadUInt32();
            BitMask = new Bitmask().Read(br);
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}LevelMask Linkage");
            sw.WriteLine($"{ident}  MaxLevelEntryId={MaxLevelEntryId}, BitMaskSize={BitMask.Size}, BitMaskData={BitMask}");
        }
    }

    public class FilterMemberLinkage : Linkage   // 0x56dd
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
            if (Size1 != 0)
            {
                NameString = System.Text.Encoding.UTF8.GetString(br.ReadBytes(Length));
            }
            else if (Size2 != 0)
            {
                ExpressionString = System.Text.Encoding.UTF8.GetString(br.ReadBytes(Length));
            }
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Filter Member Linkage");
            sw.WriteLine($"{ident}  MemberId={MemberId}, MemberType={(FilterMemberType)MemberType}, NameString=\"{NameString}\", ExpressionString=\"{ExpressionString}\"");
        }
    }

    public class ByteArrayLinkage : Linkage
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
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Byte Array Linkage");
            sw.WriteLine($"{ident}  ByteArrayId=0x{ByteArrayId:X}, ByteArraySize={ByteArraySize}");
        }
    }

    public class StringLinkage : Linkage
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
            sw.WriteLine($"{ident}String Linkage");
            sw.WriteLine($"{ident}  Key={Key}, Value=\"{String}\"");
        }
    }

    public class DepLinkage : Linkage
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
            sw.WriteLine($"{ident}Dependency Linkage");
            sw.WriteLine($"{ident}  AppId=0x{DependencyLinkage.AppID:X4}, AppValue={DependencyLinkage.AppValue}, Root Data Type={(DependencyLinkageType)DependencyLinkage.U.F.RootDataType}, NRoots={DependencyLinkage.NRoots}, Roots >");
            for (int i = 0; i < DependencyLinkage.NRoots; i++)
            {
                switch ((DependencyLinkageType)DependencyLinkage.U.F.RootDataType)
                {
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID:
                        sw.WriteLine($"{ident}    Root[{i}]=0x{DependencyLinkage.Root.Elemid[i]:X16}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT:
                        sw.WriteLine($"{ident}    Root[{i}]={(AssocPointRootType)DependencyLinkage.Root.Assoc[i].Type}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ASSOC_POINT_I:
                        sw.WriteLine($"{ident}    Root[{i}]={(AssocPointRootType)DependencyLinkage.Root.Assoc_I[i].Assoc.Type}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_ELEM_ID_V:
                        sw.WriteLine($"{ident}    Root[{i}]=0x{DependencyLinkage.Root.E_v[i].Elemid:X16}, Value={DependencyLinkage.Root.E_v[i].Value}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID:
                        sw.WriteLine($"{ident}    Root[{i}]=0x{DependencyLinkage.Root.Far_elemid[i].Elemid:X16}, Refattid={DependencyLinkage.Root.Far_elemid[i].Refattid:X16}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_FAR_ELEM_ID_V:
                        sw.WriteLine($"{ident}    Root[{i}]=0x{DependencyLinkage.Root.Far_e_v[i].S.Elemid:X16}, Value={DependencyLinkage.Root.Far_e_v[i].S.Value}, Refattid={DependencyLinkage.Root.Far_e_v[i]:X16}");
                        break;
                    case DependencyLinkageType.DEPENDENCY_DATA_TYPE_PATH_V:
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public class TextAnnotationScaleLinkage : Linkage
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
            sw.WriteLine($"{ident}Text Annotation Scale Linkage");
            sw.WriteLine($"{ident}  Value={Scale}");
        }
    }

    public class ThicknessLinkage : Linkage  // 0x56d4
    {
        public UInt32 Dummy1;           // 0x00
        public UInt32 Dummy2;           // 0x04
        public UInt32 Dummy3;           // 0x08
        public UInt32 Dummy4;           // 0x0c
        public UInt32 Dummy5;           // 0x10
        public double Thickness;        // 0x14

        public ThicknessLinkage(byte[] data)
        {
            BinaryReader br = new(new MemoryStream(data), Encoding.UTF8);
            Dummy1 = br.ReadUInt32();
            Dummy2 = br.ReadUInt32();
            Dummy3 = br.ReadUInt32();
            Dummy4 = br.ReadUInt32();
            Dummy5 = br.ReadUInt32();
            Thickness = br.ReadDouble();
        }

        public void Dump(StreamWriter sw, int level)
        {
            var ident = new string(' ', 2 * level);
            sw.WriteLine($"{ident}Thickness Linkage");
            sw.WriteLine($"{ident}  Dummy1={Dummy1}, Dummy2={Dummy2}, Dummy3={Dummy3}, Dummy4={Dummy4}, Dummy5={Dummy5}, Thickness={Thickness}");
        }
    }
}
