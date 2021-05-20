namespace v8file.net
{
    public enum _EXCEPTION_DISPOSITION : int
    {
        ExceptionContinueExecution,
        ExceptionContinueSearch,
        ExceptionNestedException,
        ExceptionCollidedUnwind,
    };

    public enum COMPARTMENT_ID : int
    {
        UNSPECIFIED_COMPARTMENT_ID = 0,
        DEFAULT_COMPARTMENT_ID,
    };

    public enum _SID_NAME_USE : int
    {
        SidTypeUser = 1,
        SidTypeGroup,
        SidTypeDomain,
        SidTypeAlias,
        SidTypeWellKnownGroup,
        SidTypeDeletedAccount,
        SidTypeInvalid,
        SidTypeUnknown,
        SidTypeComputer,
        SidTypeLabel,
    };

    public enum WELL_KNOWN_SID_TYPE : int
    {
        WinNullSid = 0,
        WinWorldSid = 1,
        WinLocalSid = 2,
        WinCreatorOwnerSid = 3,
        WinCreatorGroupSid = 4,
        WinCreatorOwnerServerSid = 5,
        WinCreatorGroupServerSid = 6,
        WinNtAuthoritySid = 7,
        WinDialupSid = 8,
        WinNetworkSid = 9,
        WinBatchSid = 10,
        WinInteractiveSid = 11,
        WinServiceSid = 12,
        WinAnonymousSid = 13,
        WinProxySid = 14,
        WinEnterpriseControllersSid = 15,
        WinSelfSid = 16,
        WinAuthenticatedUserSid = 17,
        WinRestrictedCodeSid = 18,
        WinTerminalServerSid = 19,
        WinRemoteLogonIdSid = 20,
        WinLogonIdsSid = 21,
        WinLocalSystemSid = 22,
        WinLocalServiceSid = 23,
        WinNetworkServiceSid = 24,
        WinBuiltinDomainSid = 25,
        WinBuiltinAdministratorsSid = 26,
        WinBuiltinUsersSid = 27,
        WinBuiltinGuestsSid = 28,
        WinBuiltinPowerUsersSid = 29,
        WinBuiltinAccountOperatorsSid = 30,
        WinBuiltinSystemOperatorsSid = 31,
        WinBuiltinPrintOperatorsSid = 32,
        WinBuiltinBackupOperatorsSid = 33,
        WinBuiltinReplicatorSid = 34,
        WinBuiltinPreWindows2000CompatibleAccessSid = 35,
        WinBuiltinRemoteDesktopUsersSid = 36,
        WinBuiltinNetworkConfigurationOperatorsSid = 37,
        WinAccountAdministratorSid = 38,
        WinAccountGuestSid = 39,
        WinAccountKrbtgtSid = 40,
        WinAccountDomainAdminsSid = 41,
        WinAccountDomainUsersSid = 42,
        WinAccountDomainGuestsSid = 43,
        WinAccountComputersSid = 44,
        WinAccountControllersSid = 45,
        WinAccountCertAdminsSid = 46,
        WinAccountSchemaAdminsSid = 47,
        WinAccountEnterpriseAdminsSid = 48,
        WinAccountPolicyAdminsSid = 49,
        WinAccountRasAndIasServersSid = 50,
        WinNTLMAuthenticationSid = 51,
        WinDigestAuthenticationSid = 52,
        WinSChannelAuthenticationSid = 53,
        WinThisOrganizationSid = 54,
        WinOtherOrganizationSid = 55,
        WinBuiltinIncomingForestTrustBuildersSid = 56,
        WinBuiltinPerfMonitoringUsersSid = 57,
        WinBuiltinPerfLoggingUsersSid = 58,
        WinBuiltinAuthorizationAccessSid = 59,
        WinBuiltinTerminalServerLicenseServersSid = 60,
        WinBuiltinDCOMUsersSid = 61,
        WinBuiltinIUsersSid = 62,
        WinIUserSid = 63,
        WinBuiltinCryptoOperatorsSid = 64,
        WinUntrustedLabelSid = 65,
        WinLowLabelSid = 66,
        WinMediumLabelSid = 67,
        WinHighLabelSid = 68,
        WinSystemLabelSid = 69,
        WinWriteRestrictedCodeSid = 70,
        WinCreatorOwnerRightsSid = 71,
        WinCacheablePrincipalsGroupSid = 72,
        WinNonCacheablePrincipalsGroupSid = 73,
        WinEnterpriseReadonlyControllersSid = 74,
        WinAccountReadonlyControllersSid = 75,
        WinBuiltinEventLogReadersGroup = 76,
        WinNewEnterpriseReadonlyControllersSid = 77,
        WinBuiltinCertSvcDComAccessGroup = 78,
        WinMediumPlusLabelSid = 79,
        WinLocalLogonSid = 80,
        WinConsoleLogonSid = 81,
        WinThisOrganizationCertificateSid = 82,
        WinApplicationPackageAuthoritySid = 83,
        WinBuiltinAnyPackageSid = 84,
        WinCapabilityInternetClientSid = 85,
        WinCapabilityInternetClientServerSid = 86,
        WinCapabilityPrivateNetworkClientServerSid = 87,
        WinCapabilityPicturesLibrarySid = 88,
        WinCapabilityVideosLibrarySid = 89,
        WinCapabilityMusicLibrarySid = 90,
        WinCapabilityDocumentsLibrarySid = 91,
        WinCapabilitySharedUserCertificatesSid = 92,
        WinCapabilityEnterpriseAuthenticationSid = 93,
        WinCapabilityRemovableStorageSid = 94,
        WinBuiltinRDSRemoteAccessServersSid = 95,
        WinBuiltinRDSEndpointServersSid = 96,
        WinBuiltinRDSManagementServersSid = 97,
        WinUserModeDriversSid = 98,
        WinBuiltinHyperVAdminsSid = 99,
        WinAccountCloneableControllersSid = 100,
        WinBuiltinAccessControlAssistanceOperatorsSid = 101,
        WinBuiltinRemoteManagementUsersSid = 102,
        WinAuthenticationAuthorityAssertedSid = 103,
        WinAuthenticationServiceAssertedSid = 104,
        WinLocalAccountSid = 105,
        WinLocalAccountAndAdministratorSid = 106,
        WinAccountProtectedUsersSid = 107,
    };

    public enum _ACL_INFORMATION_CLASS : int
    {
        AclRevisionInformation = 1,
        AclSizeInformation,
    };

    public enum _AUDIT_EVENT_TYPE : int
    {
        AuditEventObjectAccess,
        AuditEventDirectoryServiceAccess,
    };

    public enum _ACCESS_REASON_TYPE : int
    {
        AccessReasonNone = 0,
        AccessReasonAllowedAce = 65536,
        AccessReasonDeniedAce = 131072,
        AccessReasonAllowedParentAce = 196608,
        AccessReasonDeniedParentAce = 262144,
        AccessReasonNotGrantedByCape = 327680,
        AccessReasonNotGrantedByParentCape = 393216,
        AccessReasonNotGrantedToAppContainer = 458752,
        AccessReasonMissingPrivilege = 1048576,
        AccessReasonFromPrivilege = 2097152,
        AccessReasonIntegrityLevel = 3145728,
        AccessReasonOwnership = 4194304,
        AccessReasonNullDacl = 5242880,
        AccessReasonEmptyDacl = 6291456,
        AccessReasonNoSD = 7340032,
        AccessReasonNoGrant = 8388608,
        AccessReasonTrustLabel = 9437184,
    };

    public enum _SECURITY_IMPERSONATION_LEVEL : int
    {
        SecurityAnonymous,
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation,
    };

    public enum _TOKEN_TYPE : int
    {
        TokenPrimary = 1,
        TokenImpersonation,
    };

    public enum _TOKEN_ELEVATION_TYPE : int
    {
        TokenElevationTypeDefault = 1,
        TokenElevationTypeFull,
        TokenElevationTypeLimited,
    };

    public enum _TOKEN_INFORMATION_CLASS : int
    {
        TokenUser = 1,
        TokenGroups,
        TokenPrivileges,
        TokenOwner,
        TokenPrimaryGroup,
        TokenDefaultDacl,
        TokenSource,
        TokenType,
        TokenImpersonationLevel,
        TokenStatistics,
        TokenRestrictedSids,
        TokenSessionId,
        TokenGroupsAndPrivileges,
        TokenSessionReference,
        TokenSandBoxInert,
        TokenAuditPolicy,
        TokenOrigin,
        TokenElevationType,
        TokenLinkedToken,
        TokenElevation,
        TokenHasRestrictions,
        TokenAccessInformation,
        TokenVirtualizationAllowed,
        TokenVirtualizationEnabled,
        TokenIntegrityLevel,
        TokenUIAccess,
        TokenMandatoryPolicy,
        TokenLogonSid,
        TokenIsAppContainer,
        TokenCapabilities,
        TokenAppContainerSid,
        TokenAppContainerNumber,
        TokenUserClaimAttributes,
        TokenDeviceClaimAttributes,
        TokenRestrictedUserClaimAttributes,
        TokenRestrictedDeviceClaimAttributes,
        TokenDeviceGroups,
        TokenRestrictedDeviceGroups,
        TokenSecurityAttributes,
        TokenIsRestricted,
        TokenProcessTrustLevel,
        MaxTokenInfoClass,
    };

    public enum _MANDATORY_LEVEL : int
    {
        MandatoryLevelUntrusted = 0,
        MandatoryLevelLow,
        MandatoryLevelMedium,
        MandatoryLevelHigh,
        MandatoryLevelSystem,
        MandatoryLevelSecureProcess,
        MandatoryLevelCount,
    };

    public enum _SE_LEARNING_MODE_DATA_TYPE : int
    {
        SeLearningModeInvalidType = 0,
        SeLearningModeSettings,
        SeLearningModeMax,
    };

    public enum _HARDWARE_COUNTER_TYPE : int
    {
        PMCCounter,
        MaxHardwareCounterType,
    };

    public enum _PROCESS_MITIGATION_POLICY : int
    {
        ProcessDEPPolicy,
        ProcessASLRPolicy,
        ProcessDynamicCodePolicy,
        ProcessStrictHandleCheckPolicy,
        ProcessSystemCallDisablePolicy,
        ProcessMitigationOptionsMask,
        ProcessExtensionPointDisablePolicy,
        ProcessReserved1Policy,
        ProcessSignaturePolicy,
        MaxProcessMitigationPolicy,
    };

    public enum _JOBOBJECT_RATE_CONTROL_TOLERANCE : int
    {
        ToleranceLow = 1,
        ToleranceMedium,
        ToleranceHigh,
    };

    public enum _JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL : int
    {
        ToleranceIntervalShort = 1,
        ToleranceIntervalMedium,
        ToleranceIntervalLong,
    };

    public enum _JOBOBJECTINFOCLASS : int
    {
        JobObjectBasicAccountingInformation = 1,
        JobObjectBasicLimitInformation,
        JobObjectBasicProcessIdList,
        JobObjectBasicUIRestrictions,
        JobObjectSecurityLimitInformation,
        JobObjectEndOfJobTimeInformation,
        JobObjectAssociateCompletionPortInformation,
        JobObjectBasicAndIoAccountingInformation,
        JobObjectExtendedLimitInformation,
        JobObjectJobSetInformation,
        JobObjectGroupInformation,
        JobObjectNotificationLimitInformation,
        JobObjectLimitViolationInformation,
        JobObjectGroupInformationEx,
        JobObjectCpuRateControlInformation,
        JobObjectCompletionFilter,
        JobObjectCompletionCounter,
        JobObjectReserved1Information = 18,
        JobObjectReserved2Information,
        JobObjectReserved3Information,
        JobObjectReserved4Information,
        JobObjectReserved5Information,
        JobObjectReserved6Information,
        JobObjectReserved7Information,
        JobObjectReserved8Information,
        JobObjectReserved9Information,
        MaxJobObjectInfoClass,
    };

    public enum _FIRMWARE_TYPE : int
    {
        FirmwareTypeUnknown,
        FirmwareTypeBios,
        FirmwareTypeUefi,
        FirmwareTypeMax,
    };

    public enum _LOGICAL_PROCESSOR_RELATIONSHIP : int
    {
        RelationProcessorCore,
        RelationNumaNode,
        RelationCache,
        RelationProcessorPackage,
        RelationGroup,
        RelationAll = 65535,
    };

    public enum _PROCESSOR_CACHE_TYPE : int
    {
        CacheUnified,
        CacheInstruction,
        CacheData,
        CacheTrace,
    };

    public enum _SharedVirtualDiskSupportType : int
    {
        SharedVirtualDisksUnsupported = 0,
        SharedVirtualDisksSupported = 1,
    };

    public enum _SharedVirtualDiskHandleState : int
    {
        SharedVirtualDiskHandleStateNone = 0,
        SharedVirtualDiskHandleStateFileShared = 1,
        SharedVirtualDiskHandleStateHandleShared = 3,
    };

    public enum _SYSTEM_POWER_STATE : int
    {
        PowerSystemUnspecified = 0,
        PowerSystemWorking = 1,
        PowerSystemSleeping1 = 2,
        PowerSystemSleeping2 = 3,
        PowerSystemSleeping3 = 4,
        PowerSystemHibernate = 5,
        PowerSystemShutdown = 6,
        PowerSystemMaximum = 7,
    };

    public enum POWER_ACTION : int
    {
        PowerActionNone = 0,
        PowerActionReserved,
        PowerActionSleep,
        PowerActionHibernate,
        PowerActionShutdown,
        PowerActionShutdownReset,
        PowerActionShutdownOff,
        PowerActionWarmEject,
    };

    public enum _DEVICE_POWER_STATE : int
    {
        PowerDeviceUnspecified = 0,
        PowerDeviceD0,
        PowerDeviceD1,
        PowerDeviceD2,
        PowerDeviceD3,
        PowerDeviceMaximum,
    };

    public enum _MONITOR_DISPLAY_STATE : int
    {
        PowerMonitorOff = 0,
        PowerMonitorOn,
        PowerMonitorDim,
    };

    public enum _USER_ACTIVITY_PRESENCE : int
    {
        PowerUserPresent = 0,
        PowerUserNotPresent,
        PowerUserInactive,
        PowerUserMaximum,
        PowerUserInvalid = 3,
    };

    public enum LATENCY_TIME : int
    {
        LT_DONT_CARE,
        LT_LOWEST_LATENCY,
    };

    public enum _POWER_REQUEST_TYPE : int
    {
        PowerRequestDisplayRequired,
        PowerRequestSystemRequired,
        PowerRequestAwayModeRequired,
        PowerRequestExecutionRequired,
    };

    public enum POWER_INFORMATION_LEVEL : int
    {
        SystemPowerPolicyAc,
        SystemPowerPolicyDc,
        VerifySystemPolicyAc,
        VerifySystemPolicyDc,
        SystemPowerCapabilities,
        SystemBatteryState,
        SystemPowerStateHandler,
        ProcessorStateHandler,
        SystemPowerPolicyCurrent,
        AdministratorPowerPolicy,
        SystemReserveHiberFile,
        ProcessorInformation,
        SystemPowerInformation,
        ProcessorStateHandler2,
        LastWakeTime,
        LastSleepTime,
        SystemExecutionState,
        SystemPowerStateNotifyHandler,
        ProcessorPowerPolicyAc,
        ProcessorPowerPolicyDc,
        VerifyProcessorPowerPolicyAc,
        VerifyProcessorPowerPolicyDc,
        ProcessorPowerPolicyCurrent,
        SystemPowerStateLogging,
        SystemPowerLoggingEntry,
        SetPowerSettingValue,
        NotifyUserPowerSetting,
        PowerInformationLevelUnused0,
        SystemMonitorHiberBootPowerOff,
        SystemVideoState,
        TraceApplicationPowerMessage,
        TraceApplicationPowerMessageEnd,
        ProcessorPerfStates,
        ProcessorIdleStates,
        ProcessorCap,
        SystemWakeSource,
        SystemHiberFileInformation,
        TraceServicePowerMessage,
        ProcessorLoad,
        PowerShutdownNotification,
        MonitorCapabilities,
        SessionPowerInit,
        SessionDisplayState,
        PowerRequestCreate,
        PowerRequestAction,
        GetPowerRequestList,
        ProcessorInformationEx,
        NotifyUserModeLegacyPowerEvent,
        GroupPark,
        ProcessorIdleDomains,
        WakeTimerList,
        SystemHiberFileSize,
        ProcessorIdleStatesHv,
        ProcessorPerfStatesHv,
        ProcessorPerfCapHv,
        ProcessorSetIdle,
        LogicalProcessorIdling,
        UserPresence,
        PowerSettingNotificationName,
        GetPowerSettingValue,
        IdleResiliency,
        SessionRITState,
        SessionConnectNotification,
        SessionPowerCleanup,
        SessionLockState,
        SystemHiberbootState,
        PlatformInformation,
        PdcInvocation,
        MonitorInvocation,
        FirmwareTableInformationRegistered,
        SetShutdownSelectedTime,
        SuspendResumeInvocation,
        PlmPowerRequestCreate,
        ScreenOff,
        CsDeviceNotification,
        PlatformRole,
        LastResumePerformance,
        DisplayBurst,
        ExitLatencySamplingPercentage,
        RegisterSpmPowerSettings,
        PlatformIdleStates,
        ProcessorIdleVeto,
        PlatformIdleVeto,
        SystemBatteryStatePrecise,
        ThermalEvent,
        PowerInformationLevelMaximum,
    };

    public enum POWER_USER_PRESENCE_TYPE : int
    {
        UserNotPresent = 0,
        UserPresent = 1,
        UserUnknown = 255,
    };

    public enum POWER_MONITOR_REQUEST_REASON : int
    {
        MonitorRequestReasonUnknown,
        MonitorRequestReasonPowerButton,
        MonitorRequestReasonRemoteConnection,
        MonitorRequestReasonScMonitorpower,
        MonitorRequestReasonUserInput,
        MonitorRequestReasonAcDcDisplayBurst,
        MonitorRequestReasonUserDisplayBurst,
        MonitorRequestReasonPoSetSystemState,
        MonitorRequestReasonSetThreadExecutionState,
        MonitorRequestReasonFullWake,
        MonitorRequestReasonSessionUnlock,
        MonitorRequestReasonScreenOffRequest,
        MonitorRequestReasonIdleTimeout,
        MonitorRequestReasonPolicyChange,
        MonitorRequestReasonSleepButton,
        MonitorRequestReasonLid,
        MonitorRequestReasonBatteryCountChange,
        MonitorRequestReasonMax,
    };

    public enum SYSTEM_POWER_CONDITION : int
    {
        PoAc,
        PoDc,
        PoHot,
        PoConditionMaximum,
    };

    public enum _POWER_PLATFORM_ROLE : int
    {
        PlatformRoleUnspecified = 0,
        PlatformRoleDesktop,
        PlatformRoleMobile,
        PlatformRoleWorkstation,
        PlatformRoleEnterpriseServer,
        PlatformRoleSOHOServer,
        PlatformRoleAppliancePC,
        PlatformRolePerformanceServer,
        PlatformRoleSlate,
        PlatformRoleMaximum,
    };

    public enum IMAGE_AUX_SYMBOL_TYPE : int
    {
        IMAGE_AUX_SYMBOL_TYPE_TOKEN_DEF = 1,
    };

    public enum IMPORT_OBJECT_TYPE : int
    {
        IMPORT_OBJECT_CODE = 0,
        IMPORT_OBJECT_DATA = 1,
        IMPORT_OBJECT_CONST = 2,
    };

    public enum IMPORT_OBJECT_NAME_TYPE : int
    {
        IMPORT_OBJECT_ORDINAL = 0,
        IMPORT_OBJECT_NAME = 1,
        IMPORT_OBJECT_NAME_NO_PREFIX = 2,
        IMPORT_OBJECT_NAME_UNDECORATE = 3,
    };

    public enum ReplacesCorHdrNumericDefines : int
    {
        COMIMAGE_FLAGS_ILONLY = 1,
        COMIMAGE_FLAGS_32BITREQUIRED = 2,
        COMIMAGE_FLAGS_IL_LIBRARY = 4,
        COMIMAGE_FLAGS_STRONGNAMESIGNED = 8,
        COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 16,
        COMIMAGE_FLAGS_TRACKDEBUGDATA = 65536,
        COR_VERSION_MAJOR_V2 = 2,
        COR_VERSION_MAJOR = 2,
        COR_VERSION_MINOR = 5,
        COR_DELETED_NAME_LENGTH = 8,
        COR_VTABLEGAP_NAME_LENGTH = 8,
        NATIVE_TYPE_MAX_CB = 1,
        COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 255,
        IMAGE_COR_MIH_METHODRVA = 1,
        IMAGE_COR_MIH_EHRVA = 2,
        IMAGE_COR_MIH_BASICBLOCK = 8,
        COR_VTABLE_32BIT = 1,
        COR_VTABLE_64BIT = 2,
        COR_VTABLE_FROM_UNMANAGED = 4,
        COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 8,
        COR_VTABLE_CALL_MOST_DERIVED = 16,
        IMAGE_COR_EATJ_THUNK_SIZE = 32,
        MAX_CLASS_NAME = 1024,
        MAX_PACKAGE_NAME = 1024,
    };

    public enum _RTL_UMS_THREAD_INFO_CLASS : int
    {
        UmsThreadInvalidInfoClass = 0,
        UmsThreadUserContext,
        UmsThreadPriority,
        UmsThreadAffinity,
        UmsThreadTeb,
        UmsThreadIsSuspended,
        UmsThreadIsTerminated,
        UmsThreadMaxInfoClass,
    };

    public enum _RTL_UMS_SCHEDULER_REASON : int
    {
        UmsSchedulerStartup = 0,
        UmsSchedulerThreadBlocked,
        UmsSchedulerThreadYield,
    };

    public enum _HEAP_INFORMATION_CLASS : int
    {
        HeapCompatibilityInformation = 0,
        HeapEnableTerminationOnCorruption = 1,
    };

    public enum _ACTIVATION_CONTEXT_INFO_CLASS : int
    {
        ActivationContextBasicInformation = 1,
        ActivationContextDetailedInformation = 2,
        AssemblyDetailedInformationInActivationContext = 3,
        FileInformationInAssemblyOfAssemblyInActivationContext = 4,
        RunlevelInformationInActivationContext = 5,
        CompatibilityInformationInActivationContext = 6,
        ActivationContextManifestResourceName = 7,
        MaxActivationContextInfoClass,
        AssemblyDetailedInformationInActivationContxt = 3,
        FileInformationInAssemblyOfAssemblyInActivationContxt = 4,
    };

    public enum ACTCTX_REQUESTED_RUN_LEVEL : int
    {
        ACTCTX_RUN_LEVEL_UNSPECIFIED = 0,
        ACTCTX_RUN_LEVEL_AS_INVOKER,
        ACTCTX_RUN_LEVEL_HIGHEST_AVAILABLE,
        ACTCTX_RUN_LEVEL_REQUIRE_ADMIN,
        ACTCTX_RUN_LEVEL_NUMBERS,
    };

    public enum ACTCTX_COMPATIBILITY_ELEMENT_TYPE : int
    {
        ACTCTX_COMPATIBILITY_ELEMENT_TYPE_UNKNOWN = 0,
        ACTCTX_COMPATIBILITY_ELEMENT_TYPE_OS,
        ACTCTX_COMPATIBILITY_ELEMENT_TYPE_MITIGATION,
    };

    public enum _CM_SERVICE_NODE_TYPE : int
    {
        DriverType = 1,
        FileSystemType = 2,
        Win32ServiceOwnProcess = 16,
        Win32ServiceShareProcess = 32,
        AdapterType = 4,
        RecognizerType = 8,
    };

    public enum _CM_SERVICE_LOAD_TYPE : int
    {
        BootLoad = 0,
        SystemLoad = 1,
        AutoLoad = 2,
        DemandLoad = 3,
        DisableLoad = 4,
    };

    public enum _CM_ERROR_CONTROL_TYPE : int
    {
        IgnoreError = 0,
        NormalError = 1,
        SevereError = 2,
        CriticalError = 3,
    };

    public enum _TAPE_DRIVE_PROBLEM_TYPE : int
    {
        TapeDriveProblemNone,
        TapeDriveReadWriteWarning,
        TapeDriveReadWriteError,
        TapeDriveReadWarning,
        TapeDriveWriteWarning,
        TapeDriveReadError,
        TapeDriveWriteError,
        TapeDriveHardwareError,
        TapeDriveUnsupportedMedia,
        TapeDriveScsiConnectionError,
        TapeDriveTimetoClean,
        TapeDriveCleanDriveNow,
        TapeDriveMediaLifeExpired,
        TapeDriveSnappedTape,
    };

    public enum _TRANSACTION_OUTCOME : int
    {
        TransactionOutcomeUndetermined = 1,
        TransactionOutcomeCommitted,
        TransactionOutcomeAborted,
    };

    public enum _TRANSACTION_STATE : int
    {
        TransactionStateNormal = 1,
        TransactionStateIndoubt,
        TransactionStateCommittedNotify,
    };

    public enum _TRANSACTION_INFORMATION_CLASS : int
    {
        TransactionBasicInformation,
        TransactionPropertiesInformation,
        TransactionEnlistmentInformation,
        TransactionSuperiorEnlistmentInformation,
        TransactionBindInformation,
        TransactionDTCPrivateInformation,
    };

    public enum _TRANSACTIONMANAGER_INFORMATION_CLASS : int
    {
        TransactionManagerBasicInformation,
        TransactionManagerLogInformation,
        TransactionManagerLogPathInformation,
        TransactionManagerRecoveryInformation = 4,
        TransactionManagerOnlineProbeInformation = 3,
        TransactionManagerOldestTransactionInformation = 5,
    };

    public enum _RESOURCEMANAGER_INFORMATION_CLASS : int
    {
        ResourceManagerBasicInformation,
        ResourceManagerCompletionInformation,
    };

    public enum _ENLISTMENT_INFORMATION_CLASS : int
    {
        EnlistmentBasicInformation,
        EnlistmentRecoveryInformation,
        EnlistmentCrmInformation,
    };

    public enum _KTMOBJECT_TYPE : int
    {
        KTMOBJECT_TRANSACTION,
        KTMOBJECT_TRANSACTION_MANAGER,
        KTMOBJECT_RESOURCE_MANAGER,
        KTMOBJECT_ENLISTMENT,
        KTMOBJECT_INVALID,
    };

    public enum _TP_CALLBACK_PRIORITY : int
    {
        TP_CALLBACK_PRIORITY_HIGH,
        TP_CALLBACK_PRIORITY_NORMAL,
        TP_CALLBACK_PRIORITY_LOW,
        TP_CALLBACK_PRIORITY_INVALID,
        TP_CALLBACK_PRIORITY_COUNT = 3,
    };

    public enum _FINDEX_INFO_LEVELS : int
    {
        FindExInfoStandard,
        FindExInfoBasic,
        FindExInfoMaxInfoLevel,
    };

    public enum _FINDEX_SEARCH_OPS : int
    {
        FindExSearchNameMatch,
        FindExSearchLimitToDirectories,
        FindExSearchLimitToDevices,
        FindExSearchMaxSearchOp,
    };

    public enum _GET_FILEEX_INFO_LEVELS : int
    {
        GetFileExInfoStandard,
        GetFileExMaxInfoLevel,
    };

    public enum _FILE_INFO_BY_HANDLE_CLASS : int
    {
        FileBasicInfo,
        FileStandardInfo,
        FileNameInfo,
        FileRenameInfo,
        FileDispositionInfo,
        FileAllocationInfo,
        FileEndOfFileInfo,
        FileStreamInfo,
        FileCompressionInfo,
        FileAttributeTagInfo,
        FileIdBothDirectoryInfo,
        FileIdBothDirectoryRestartInfo,
        FileIoPriorityHintInfo,
        FileRemoteProtocolInfo,
        FileFullDirectoryInfo,
        FileFullDirectoryRestartInfo,
        FileStorageInfo,
        FileAlignmentInfo,
        FileIdInfo,
        FileIdExtdDirectoryInfo,
        FileIdExtdDirectoryRestartInfo,
        MaximumFileInfoByHandleClass,
    };

    public enum _THREAD_INFORMATION_CLASS : int
    {
        ThreadMemoryPriority,
        ThreadAbsoluteCpuPriority,
        ThreadInformationClassMax,
    };

    public enum _COMPUTER_NAME_FORMAT : int
    {
        ComputerNameNetBIOS,
        ComputerNameDnsHostname,
        ComputerNameDnsDomain,
        ComputerNameDnsFullyQualified,
        ComputerNamePhysicalNetBIOS,
        ComputerNamePhysicalDnsHostname,
        ComputerNamePhysicalDnsDomain,
        ComputerNamePhysicalDnsFullyQualified,
        ComputerNameMax,
    };

    public enum _MEMORY_RESOURCE_NOTIFICATION_TYPE : int
    {
        LowMemoryResourceNotification,
        HighMemoryResourceNotification,
    };

    public enum _PROCESS_INFORMATION_CLASS : int
    {
        ProcessMemoryPriority,
        ProcessInformationClassMax,
    };

    public enum _DEP_SYSTEM_POLICY_TYPE : int
    {
        DEPPolicyAlwaysOff = 0,
        DEPPolicyAlwaysOn,
        DEPPolicyOptIn,
        DEPPolicyOptOut,
        DEPTotalPolicyCount,
    };

    public enum _PROC_THREAD_ATTRIBUTE_NUM : int
    {
        ProcThreadAttributeParentProcess = 0,
        ProcThreadAttributeHandleList = 2,
        ProcThreadAttributeGroupAffinity = 3,
        ProcThreadAttributePreferredNode = 4,
        ProcThreadAttributeIdealProcessor = 5,
        ProcThreadAttributeUmsThread = 6,
        ProcThreadAttributeMitigationPolicy = 7,
        ProcThreadAttributeSecurityCapabilities = 9,
        ProcThreadAttributeProtectionLevel = 11,
    };

    public enum _COPYFILE2_MESSAGE_TYPE : int
    {
        COPYFILE2_CALLBACK_NONE = 0,
        COPYFILE2_CALLBACK_CHUNK_STARTED,
        COPYFILE2_CALLBACK_CHUNK_FINISHED,
        COPYFILE2_CALLBACK_STREAM_STARTED,
        COPYFILE2_CALLBACK_STREAM_FINISHED,
        COPYFILE2_CALLBACK_POLL_CONTINUE,
        COPYFILE2_CALLBACK_ERROR,
        COPYFILE2_CALLBACK_MAX,
    };

    public enum _COPYFILE2_MESSAGE_ACTION : int
    {
        COPYFILE2_PROGRESS_CONTINUE = 0,
        COPYFILE2_PROGRESS_CANCEL,
        COPYFILE2_PROGRESS_STOP,
        COPYFILE2_PROGRESS_QUIET,
        COPYFILE2_PROGRESS_PAUSE,
    };

    public enum _COPYFILE2_COPY_PHASE : int
    {
        COPYFILE2_PHASE_NONE = 0,
        COPYFILE2_PHASE_PREPARE_SOURCE,
        COPYFILE2_PHASE_PREPARE_DEST,
        COPYFILE2_PHASE_READ_SOURCE,
        COPYFILE2_PHASE_WRITE_DESTINATION,
        COPYFILE2_PHASE_SERVER_COPY,
        COPYFILE2_PHASE_NAMEGRAFT_COPY,
        COPYFILE2_PHASE_MAX,
    };

    public enum _STREAM_INFO_LEVELS : int
    {
        FindStreamInfoStandard,
        FindStreamInfoMaxInfoLevel,
    };

    public enum _PRIORITY_HINT : int
    {
        IoPriorityHintVeryLow = 0,
        IoPriorityHintLow,
        IoPriorityHintNormal,
        MaximumIoPriorityHintType,
    };

    public enum _FILE_ID_TYPE : int
    {
        FileIdType,
        ObjectIdType,
        ExtendedFileIdType,
        MaximumFileIdType,
    };

    public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY : int
    {
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = -1,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = -2147483648,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_SCANLINE_ORDERING : int
    {
        DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,
        DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = 2,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,
        DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_SCALING : int
    {
        DISPLAYCONFIG_SCALING_IDENTITY = 1,
        DISPLAYCONFIG_SCALING_CENTERED = 2,
        DISPLAYCONFIG_SCALING_STRETCHED = 3,
        DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX = 4,
        DISPLAYCONFIG_SCALING_CUSTOM = 5,
        DISPLAYCONFIG_SCALING_PREFERRED = 128,
        DISPLAYCONFIG_SCALING_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_ROTATION : int
    {
        DISPLAYCONFIG_ROTATION_IDENTITY = 1,
        DISPLAYCONFIG_ROTATION_ROTATE90 = 2,
        DISPLAYCONFIG_ROTATION_ROTATE180 = 3,
        DISPLAYCONFIG_ROTATION_ROTATE270 = 4,
        DISPLAYCONFIG_ROTATION_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_MODE_INFO_TYPE : int
    {
        DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1,
        DISPLAYCONFIG_MODE_INFO_TYPE_TARGET = 2,
        DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_PIXELFORMAT : int
    {
        DISPLAYCONFIG_PIXELFORMAT_8BPP = 1,
        DISPLAYCONFIG_PIXELFORMAT_16BPP = 2,
        DISPLAYCONFIG_PIXELFORMAT_24BPP = 3,
        DISPLAYCONFIG_PIXELFORMAT_32BPP = 4,
        DISPLAYCONFIG_PIXELFORMAT_NONGDI = 5,
        DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_TOPOLOGY_ID : int
    {
        DISPLAYCONFIG_TOPOLOGY_INTERNAL = 1,
        DISPLAYCONFIG_TOPOLOGY_CLONE = 2,
        DISPLAYCONFIG_TOPOLOGY_EXTEND = 4,
        DISPLAYCONFIG_TOPOLOGY_EXTERNAL = 8,
        DISPLAYCONFIG_TOPOLOGY_FORCE_UINT32 = -1,
    };

    public enum DISPLAYCONFIG_DEVICE_INFO_TYPE : int
    {
        DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME = 1,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME = 2,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_PREFERRED_MODE = 3,
        DISPLAYCONFIG_DEVICE_INFO_GET_ADAPTER_NAME = 4,
        DISPLAYCONFIG_DEVICE_INFO_SET_TARGET_PERSISTENCE = 5,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_BASE_TYPE = 6,
        DISPLAYCONFIG_DEVICE_INFO_FORCE_UINT32 = -1,
    };

    public enum tagPOINTER_INPUT_TYPE : int
    {
        PT_POINTER = 1,
        PT_TOUCH = 2,
        PT_PEN = 3,
        PT_MOUSE = 4,
        PT_TOUCHPAD = 5,
    };

    public enum tagPOINTER_BUTTON_CHANGE_TYPE : int
    {
        POINTER_CHANGE_NONE,
        POINTER_CHANGE_FIRSTBUTTON_DOWN,
        POINTER_CHANGE_FIRSTBUTTON_UP,
        POINTER_CHANGE_SECONDBUTTON_DOWN,
        POINTER_CHANGE_SECONDBUTTON_UP,
        POINTER_CHANGE_THIRDBUTTON_DOWN,
        POINTER_CHANGE_THIRDBUTTON_UP,
        POINTER_CHANGE_FOURTHBUTTON_DOWN,
        POINTER_CHANGE_FOURTHBUTTON_UP,
        POINTER_CHANGE_FIFTHBUTTON_DOWN,
        POINTER_CHANGE_FIFTHBUTTON_UP,
    };

    public enum tagFEEDBACK_TYPE : int
    {
        FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,
        FEEDBACK_PEN_BARRELVISUALIZATION = 2,
        FEEDBACK_PEN_TAP = 3,
        FEEDBACK_PEN_DOUBLETAP = 4,
        FEEDBACK_PEN_PRESSANDHOLD = 5,
        FEEDBACK_PEN_RIGHTTAP = 6,
        FEEDBACK_TOUCH_TAP = 7,
        FEEDBACK_TOUCH_DOUBLETAP = 8,
        FEEDBACK_TOUCH_PRESSANDHOLD = 9,
        FEEDBACK_TOUCH_RIGHTTAP = 10,
        FEEDBACK_GESTURE_PRESSANDTAP = 11,
        FEEDBACK_MAX = -1,
    };

    public enum tagPOINTER_DEVICE_TYPE : int
    {
        POINTER_DEVICE_TYPE_INTEGRATED_PEN = 1,
        POINTER_DEVICE_TYPE_EXTERNAL_PEN = 2,
        POINTER_DEVICE_TYPE_TOUCH = 3,
        POINTER_DEVICE_TYPE_TOUCH_PAD = 4,
        POINTER_DEVICE_TYPE_MAX = -1,
    };

    public enum tagPOINTER_DEVICE_CURSOR_TYPE : int
    {
        POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0,
        POINTER_DEVICE_CURSOR_TYPE_TIP = 1,
        POINTER_DEVICE_CURSOR_TYPE_ERASER = 2,
        POINTER_DEVICE_CURSOR_TYPE_MAX = -1,
    };

    public enum tagINPUT_MESSAGE_DEVICE_TYPE : int
    {
        IMDT_UNAVAILABLE = 0,
        IMDT_KEYBOARD = 1,
        IMDT_MOUSE = 2,
        IMDT_TOUCH = 4,
        IMDT_PEN = 8,
        IMDT_TOUCHPAD = 16,
    };

    public enum tagINPUT_MESSAGE_ORIGIN_ID : int
    {
        IMO_UNAVAILABLE = 0,
        IMO_HARDWARE = 1,
        IMO_INJECTED = 2,
        IMO_SYSTEM = 4,
    };

    public enum tagAR_STATE : int
    {
        AR_ENABLED = 0,
        AR_DISABLED = 1,
        AR_SUPPRESSED = 2,
        AR_REMOTESESSION = 4,
        AR_MULTIMON = 8,
        AR_NOSENSOR = 16,
        AR_NOT_SUPPORTED = 32,
        AR_DOCKED = 64,
        AR_LAPTOP = 128,
    };

    public enum ORIENTATION_PREFERENCE : int
    {
        ORIENTATION_PREFERENCE_NONE = 0,
        ORIENTATION_PREFERENCE_LANDSCAPE = 1,
        ORIENTATION_PREFERENCE_PORTRAIT = 2,
        ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 4,
        ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 8,
    };

    public enum SYSNLS_FUNCTION : int
    {
        COMPARE_STRING = 1,
    };

    public enum SYSGEOTYPE : int
    {
        GEO_NATION = 1,
        GEO_LATITUDE = 2,
        GEO_LONGITUDE = 3,
        GEO_ISO2 = 4,
        GEO_ISO3 = 5,
        GEO_RFC1766 = 6,
        GEO_LCID = 7,
        GEO_FRIENDLYNAME = 8,
        GEO_OFFICIALNAME = 9,
        GEO_TIMEZONES = 10,
        GEO_OFFICIALLANGUAGES = 11,
        GEO_ISO_UN_NUMBER = 12,
        GEO_PARENT = 13,
    };

    public enum SYSGEOCLASS : int
    {
        GEOCLASS_NATION = 16,
        GEOCLASS_REGION = 14,
        GEOCLASS_ALL = 0,
    };

    public enum _NORM_FORM : int
    {
        NormalizationOther = 0,
        NormalizationC = 1,
        NormalizationD = 2,
        NormalizationKC = 5,
        NormalizationKD = 6,
    };

    public enum _TVITEMPART : int
    {
        TVGIPR_BUTTON = 1,
    };

    public enum _TASKDIALOG_FLAGS : int
    {
        TDF_ENABLE_HYPERLINKS = 1,
        TDF_USE_HICON_MAIN = 2,
        TDF_USE_HICON_FOOTER = 4,
        TDF_ALLOW_DIALOG_CANCELLATION = 8,
        TDF_USE_COMMAND_LINKS = 16,
        TDF_USE_COMMAND_LINKS_NO_ICON = 32,
        TDF_EXPAND_FOOTER_AREA = 64,
        TDF_EXPANDED_BY_DEFAULT = 128,
        TDF_VERIFICATION_FLAG_CHECKED = 256,
        TDF_SHOW_PROGRESS_BAR = 512,
        TDF_SHOW_MARQUEE_PROGRESS_BAR = 1024,
        TDF_CALLBACK_TIMER = 2048,
        TDF_POSITION_RELATIVE_TO_WINDOW = 4096,
        TDF_RTL_LAYOUT = 8192,
        TDF_NO_DEFAULT_RADIO_BUTTON = 16384,
        TDF_CAN_BE_MINIMIZED = 32768,
        TDF_NO_SET_FOREGROUND = 65536,
        TDF_SIZE_TO_CONTENT = 16777216,
    };

    public enum _TASKDIALOG_MESSAGES : int
    {
        TDM_NAVIGATE_PAGE = 1125,
        TDM_CLICK_BUTTON = 1126,
        TDM_SET_MARQUEE_PROGRESS_BAR = 1127,
        TDM_SET_PROGRESS_BAR_STATE = 1128,
        TDM_SET_PROGRESS_BAR_RANGE = 1129,
        TDM_SET_PROGRESS_BAR_POS = 1130,
        TDM_SET_PROGRESS_BAR_MARQUEE = 1131,
        TDM_SET_ELEMENT_TEXT = 1132,
        TDM_CLICK_RADIO_BUTTON = 1134,
        TDM_ENABLE_BUTTON = 1135,
        TDM_ENABLE_RADIO_BUTTON = 1136,
        TDM_CLICK_VERIFICATION = 1137,
        TDM_UPDATE_ELEMENT_TEXT = 1138,
        TDM_SET_BUTTON_ELEVATION_REQUIRED_STATE = 1139,
        TDM_UPDATE_ICON = 1140,
    };

    public enum _TASKDIALOG_NOTIFICATIONS : int
    {
        TDN_CREATED = 0,
        TDN_NAVIGATED = 1,
        TDN_BUTTON_CLICKED = 2,
        TDN_HYPERLINK_CLICKED = 3,
        TDN_TIMER = 4,
        TDN_DESTROYED = 5,
        TDN_RADIO_BUTTON_CLICKED = 6,
        TDN_DIALOG_CONSTRUCTED = 7,
        TDN_VERIFICATION_CLICKED = 8,
        TDN_HELP = 9,
        TDN_EXPANDO_BUTTON_CLICKED = 10,
    };

    public enum _TASKDIALOG_ELEMENTS : int
    {
        TDE_CONTENT,
        TDE_EXPANDED_INFORMATION,
        TDE_FOOTER,
        TDE_MAIN_INSTRUCTION,
    };

    public enum _TASKDIALOG_ICON_ELEMENTS : int
    {
        TDIE_ICON_MAIN,
        TDIE_ICON_FOOTER,
    };

    public enum _TASKDIALOG_COMMON_BUTTON_FLAGS : int
    {
        TDCBF_OK_BUTTON = 1,
        TDCBF_YES_BUTTON = 2,
        TDCBF_NO_BUTTON = 4,
        TDCBF_CANCEL_BUTTON = 8,
        TDCBF_RETRY_BUTTON = 16,
        TDCBF_CLOSE_BUTTON = 32,
    };

    public enum _LI_METRIC : int
    {
        LIM_SMALL,
        LIM_LARGE,
    };

    public enum tagTYPEKIND : int
    {
        TKIND_ENUM = 0,
        TKIND_RECORD = 1,
        TKIND_MODULE = 2,
        TKIND_INTERFACE = 3,
        TKIND_DISPATCH = 4,
        TKIND_COCLASS = 5,
        TKIND_ALIAS = 6,
        TKIND_UNION = 7,
        TKIND_MAX = 8,
    };

    public enum tagDESCKIND : int
    {
        DESCKIND_NONE = 0,
        DESCKIND_FUNCDESC = 1,
        DESCKIND_VARDESC = 2,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
    };

    public enum tagFUNCKIND : int
    {
        FUNC_VIRTUAL = 0,
        FUNC_PUREVIRTUAL = 1,
        FUNC_NONVIRTUAL = 2,
        FUNC_STATIC = 3,
        FUNC_DISPATCH = 4,
    };

    public enum tagINVOKEKIND : int
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    };

    public enum tagCALLCONV : int
    {
        CC_FASTCALL = 0,
        CC_CDECL = 1,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_MACPASCAL = 3,
        CC_STDCALL = 4,
        CC_FPFASTCALL = 5,
        CC_SYSCALL = 6,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MAX = 9,
    };

    public enum tagVARKIND : int
    {
        VAR_PERINSTANCE = 0,
        VAR_STATIC = 1,
        VAR_CONST = 2,
        VAR_DISPATCH = 3,
    };

    public enum tagSYSKIND : int
    {
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
        SYS_MAC = 2,
        SYS_WIN64 = 3,
    };

    public enum TBPFLAG : int
    {
        TBPF_NOPROGRESS = 0,
        TBPF_INDETERMINATE = 1,
        TBPF_NORMAL = 2,
        TBPF_ERROR = 4,
        TBPF_PAUSED = 8,
    };

    public enum AFX_DISPMAP_FLAGS : int
    {
        afxDispCustom = 0,
        afxDispStock = 1,
    };

    public enum tagDBCOLKIND : int
    {
        DBCOLKIND_GUID_NAME = 0,
        DBCOLKIND_GUID_NUMBER = 1,
        DBCOLKIND_NAME = 2,
    };

    public enum DSCSTATE : int
    {
        dscNoState = 0,
        dscOKToDo,
        dscCancelled,
        dscSyncBefore,
        dscAboutToDo,
        dscFailedToDo,
        dscSyncAfter,
        dscDidEvent,
    };

    public enum D2D1_CAP_STYLE : int
    {
        D2D1_CAP_STYLE_FLAT = 0,
        D2D1_CAP_STYLE_SQUARE = 1,
        D2D1_CAP_STYLE_ROUND = 2,
        D2D1_CAP_STYLE_TRIANGLE = 3,
        D2D1_CAP_STYLE_FORCE_DWORD = -1,
    };

    public enum D2D1_LINE_JOIN : int
    {
        D2D1_LINE_JOIN_MITER = 0,
        D2D1_LINE_JOIN_BEVEL = 1,
        D2D1_LINE_JOIN_ROUND = 2,
        D2D1_LINE_JOIN_MITER_OR_BEVEL = 3,
        D2D1_LINE_JOIN_FORCE_DWORD = -1,
    };

    public enum D2D1_DASH_STYLE : int
    {
        D2D1_DASH_STYLE_SOLID = 0,
        D2D1_DASH_STYLE_DASH = 1,
        D2D1_DASH_STYLE_DOT = 2,
        D2D1_DASH_STYLE_DASH_DOT = 3,
        D2D1_DASH_STYLE_DASH_DOT_DOT = 4,
        D2D1_DASH_STYLE_CUSTOM = 5,
        D2D1_DASH_STYLE_FORCE_DWORD = -1,
    };

    public enum D2D1_GEOMETRY_RELATION : int
    {
        D2D1_GEOMETRY_RELATION_UNKNOWN = 0,
        D2D1_GEOMETRY_RELATION_DISJOINT = 1,
        D2D1_GEOMETRY_RELATION_IS_CONTAINED = 2,
        D2D1_GEOMETRY_RELATION_CONTAINS = 3,
        D2D1_GEOMETRY_RELATION_OVERLAP = 4,
        D2D1_GEOMETRY_RELATION_FORCE_DWORD = -1,
    };

    public enum D2D1_GEOMETRY_SIMPLIFICATION_OPTION : int
    {
        D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES = 0,
        D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES = 1,
        D2D1_GEOMETRY_SIMPLIFICATION_OPTION_FORCE_DWORD = -1,
    };

    public enum D2D1_FILL_MODE : int
    {
        D2D1_FILL_MODE_ALTERNATE = 0,
        D2D1_FILL_MODE_WINDING = 1,
        D2D1_FILL_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_PATH_SEGMENT : int
    {
        D2D1_PATH_SEGMENT_NONE = 0,
        D2D1_PATH_SEGMENT_FORCE_UNSTROKED = 1,
        D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN = 2,
        D2D1_PATH_SEGMENT_FORCE_DWORD = -1,
    };

    public enum D2D1_FIGURE_BEGIN : int
    {
        D2D1_FIGURE_BEGIN_FILLED = 0,
        D2D1_FIGURE_BEGIN_HOLLOW = 1,
        D2D1_FIGURE_BEGIN_FORCE_DWORD = -1,
    };

    public enum D2D1_FIGURE_END : int
    {
        D2D1_FIGURE_END_OPEN = 0,
        D2D1_FIGURE_END_CLOSED = 1,
        D2D1_FIGURE_END_FORCE_DWORD = -1,
    };

    public enum D2D1_COMBINE_MODE : int
    {
        D2D1_COMBINE_MODE_UNION = 0,
        D2D1_COMBINE_MODE_INTERSECT = 1,
        D2D1_COMBINE_MODE_XOR = 2,
        D2D1_COMBINE_MODE_EXCLUDE = 3,
        D2D1_COMBINE_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_SWEEP_DIRECTION : int
    {
        D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE = 0,
        D2D1_SWEEP_DIRECTION_CLOCKWISE = 1,
        D2D1_SWEEP_DIRECTION_FORCE_DWORD = -1,
    };

    public enum D2D1_ARC_SIZE : int
    {
        D2D1_ARC_SIZE_SMALL = 0,
        D2D1_ARC_SIZE_LARGE = 1,
        D2D1_ARC_SIZE_FORCE_DWORD = -1,
    };

    public enum D2D1_ANTIALIAS_MODE : int
    {
        D2D1_ANTIALIAS_MODE_PER_PRIMITIVE = 0,
        D2D1_ANTIALIAS_MODE_ALIASED = 1,
        D2D1_ANTIALIAS_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_TEXT_ANTIALIAS_MODE : int
    {
        D2D1_TEXT_ANTIALIAS_MODE_DEFAULT = 0,
        D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE = 1,
        D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE = 2,
        D2D1_TEXT_ANTIALIAS_MODE_ALIASED = 3,
        D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD = -1,
    };

    public enum DWRITE_PIXEL_GEOMETRY : int
    {
        DWRITE_PIXEL_GEOMETRY_FLAT,
        DWRITE_PIXEL_GEOMETRY_RGB,
        DWRITE_PIXEL_GEOMETRY_BGR,
    };

    public enum DWRITE_RENDERING_MODE : int
    {
        DWRITE_RENDERING_MODE_DEFAULT,
        DWRITE_RENDERING_MODE_ALIASED,
        DWRITE_RENDERING_MODE_GDI_CLASSIC,
        DWRITE_RENDERING_MODE_GDI_NATURAL,
        DWRITE_RENDERING_MODE_NATURAL,
        DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC,
        DWRITE_RENDERING_MODE_OUTLINE,
        DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC = 2,
        DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL = 3,
        DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL = 4,
        DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL_SYMMETRIC = 5,
    };

    public enum WICBitmapPaletteType : int
    {
        WICBitmapPaletteTypeCustom = 0,
        WICBitmapPaletteTypeMedianCut = 1,
        WICBitmapPaletteTypeFixedBW = 2,
        WICBitmapPaletteTypeFixedHalftone8 = 3,
        WICBitmapPaletteTypeFixedHalftone27 = 4,
        WICBitmapPaletteTypeFixedHalftone64 = 5,
        WICBitmapPaletteTypeFixedHalftone125 = 6,
        WICBitmapPaletteTypeFixedHalftone216 = 7,
        WICBitmapPaletteTypeFixedWebPalette = 7,
        WICBitmapPaletteTypeFixedHalftone252 = 8,
        WICBitmapPaletteTypeFixedHalftone256 = 9,
        WICBitmapPaletteTypeFixedGray4 = 10,
        WICBitmapPaletteTypeFixedGray16 = 11,
        WICBitmapPaletteTypeFixedGray256 = 12,
        WICBITMAPPALETTETYPE_FORCE_DWORD = 2147483647,
    };

    public enum D2D1_RENDER_TARGET_TYPE : int
    {
        D2D1_RENDER_TARGET_TYPE_DEFAULT = 0,
        D2D1_RENDER_TARGET_TYPE_SOFTWARE = 1,
        D2D1_RENDER_TARGET_TYPE_HARDWARE = 2,
        D2D1_RENDER_TARGET_TYPE_FORCE_DWORD = -1,
    };

    public enum DXGI_FORMAT : int
    {
        DXGI_FORMAT_UNKNOWN = 0,
        DXGI_FORMAT_R32G32B32A32_TYPELESS = 1,
        DXGI_FORMAT_R32G32B32A32_FLOAT = 2,
        DXGI_FORMAT_R32G32B32A32_UINT = 3,
        DXGI_FORMAT_R32G32B32A32_SINT = 4,
        DXGI_FORMAT_R32G32B32_TYPELESS = 5,
        DXGI_FORMAT_R32G32B32_FLOAT = 6,
        DXGI_FORMAT_R32G32B32_UINT = 7,
        DXGI_FORMAT_R32G32B32_SINT = 8,
        DXGI_FORMAT_R16G16B16A16_TYPELESS = 9,
        DXGI_FORMAT_R16G16B16A16_FLOAT = 10,
        DXGI_FORMAT_R16G16B16A16_UNORM = 11,
        DXGI_FORMAT_R16G16B16A16_UINT = 12,
        DXGI_FORMAT_R16G16B16A16_SNORM = 13,
        DXGI_FORMAT_R16G16B16A16_SINT = 14,
        DXGI_FORMAT_R32G32_TYPELESS = 15,
        DXGI_FORMAT_R32G32_FLOAT = 16,
        DXGI_FORMAT_R32G32_UINT = 17,
        DXGI_FORMAT_R32G32_SINT = 18,
        DXGI_FORMAT_R32G8X24_TYPELESS = 19,
        DXGI_FORMAT_D32_FLOAT_S8X24_UINT = 20,
        DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS = 21,
        DXGI_FORMAT_X32_TYPELESS_G8X24_UINT = 22,
        DXGI_FORMAT_R10G10B10A2_TYPELESS = 23,
        DXGI_FORMAT_R10G10B10A2_UNORM = 24,
        DXGI_FORMAT_R10G10B10A2_UINT = 25,
        DXGI_FORMAT_R11G11B10_FLOAT = 26,
        DXGI_FORMAT_R8G8B8A8_TYPELESS = 27,
        DXGI_FORMAT_R8G8B8A8_UNORM = 28,
        DXGI_FORMAT_R8G8B8A8_UNORM_SRGB = 29,
        DXGI_FORMAT_R8G8B8A8_UINT = 30,
        DXGI_FORMAT_R8G8B8A8_SNORM = 31,
        DXGI_FORMAT_R8G8B8A8_SINT = 32,
        DXGI_FORMAT_R16G16_TYPELESS = 33,
        DXGI_FORMAT_R16G16_FLOAT = 34,
        DXGI_FORMAT_R16G16_UNORM = 35,
        DXGI_FORMAT_R16G16_UINT = 36,
        DXGI_FORMAT_R16G16_SNORM = 37,
        DXGI_FORMAT_R16G16_SINT = 38,
        DXGI_FORMAT_R32_TYPELESS = 39,
        DXGI_FORMAT_D32_FLOAT = 40,
        DXGI_FORMAT_R32_FLOAT = 41,
        DXGI_FORMAT_R32_UINT = 42,
        DXGI_FORMAT_R32_SINT = 43,
        DXGI_FORMAT_R24G8_TYPELESS = 44,
        DXGI_FORMAT_D24_UNORM_S8_UINT = 45,
        DXGI_FORMAT_R24_UNORM_X8_TYPELESS = 46,
        DXGI_FORMAT_X24_TYPELESS_G8_UINT = 47,
        DXGI_FORMAT_R8G8_TYPELESS = 48,
        DXGI_FORMAT_R8G8_UNORM = 49,
        DXGI_FORMAT_R8G8_UINT = 50,
        DXGI_FORMAT_R8G8_SNORM = 51,
        DXGI_FORMAT_R8G8_SINT = 52,
        DXGI_FORMAT_R16_TYPELESS = 53,
        DXGI_FORMAT_R16_FLOAT = 54,
        DXGI_FORMAT_D16_UNORM = 55,
        DXGI_FORMAT_R16_UNORM = 56,
        DXGI_FORMAT_R16_UINT = 57,
        DXGI_FORMAT_R16_SNORM = 58,
        DXGI_FORMAT_R16_SINT = 59,
        DXGI_FORMAT_R8_TYPELESS = 60,
        DXGI_FORMAT_R8_UNORM = 61,
        DXGI_FORMAT_R8_UINT = 62,
        DXGI_FORMAT_R8_SNORM = 63,
        DXGI_FORMAT_R8_SINT = 64,
        DXGI_FORMAT_A8_UNORM = 65,
        DXGI_FORMAT_R1_UNORM = 66,
        DXGI_FORMAT_R9G9B9E5_SHAREDEXP = 67,
        DXGI_FORMAT_R8G8_B8G8_UNORM = 68,
        DXGI_FORMAT_G8R8_G8B8_UNORM = 69,
        DXGI_FORMAT_BC1_TYPELESS = 70,
        DXGI_FORMAT_BC1_UNORM = 71,
        DXGI_FORMAT_BC1_UNORM_SRGB = 72,
        DXGI_FORMAT_BC2_TYPELESS = 73,
        DXGI_FORMAT_BC2_UNORM = 74,
        DXGI_FORMAT_BC2_UNORM_SRGB = 75,
        DXGI_FORMAT_BC3_TYPELESS = 76,
        DXGI_FORMAT_BC3_UNORM = 77,
        DXGI_FORMAT_BC3_UNORM_SRGB = 78,
        DXGI_FORMAT_BC4_TYPELESS = 79,
        DXGI_FORMAT_BC4_UNORM = 80,
        DXGI_FORMAT_BC4_SNORM = 81,
        DXGI_FORMAT_BC5_TYPELESS = 82,
        DXGI_FORMAT_BC5_UNORM = 83,
        DXGI_FORMAT_BC5_SNORM = 84,
        DXGI_FORMAT_B5G6R5_UNORM = 85,
        DXGI_FORMAT_B5G5R5A1_UNORM = 86,
        DXGI_FORMAT_B8G8R8A8_UNORM = 87,
        DXGI_FORMAT_B8G8R8X8_UNORM = 88,
        DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM = 89,
        DXGI_FORMAT_B8G8R8A8_TYPELESS = 90,
        DXGI_FORMAT_B8G8R8A8_UNORM_SRGB = 91,
        DXGI_FORMAT_B8G8R8X8_TYPELESS = 92,
        DXGI_FORMAT_B8G8R8X8_UNORM_SRGB = 93,
        DXGI_FORMAT_BC6H_TYPELESS = 94,
        DXGI_FORMAT_BC6H_UF16 = 95,
        DXGI_FORMAT_BC6H_SF16 = 96,
        DXGI_FORMAT_BC7_TYPELESS = 97,
        DXGI_FORMAT_BC7_UNORM = 98,
        DXGI_FORMAT_BC7_UNORM_SRGB = 99,
        DXGI_FORMAT_AYUV = 100,
        DXGI_FORMAT_Y410 = 101,
        DXGI_FORMAT_Y416 = 102,
        DXGI_FORMAT_NV12 = 103,
        DXGI_FORMAT_P010 = 104,
        DXGI_FORMAT_P016 = 105,
        DXGI_FORMAT_420_OPAQUE = 106,
        DXGI_FORMAT_YUY2 = 107,
        DXGI_FORMAT_Y210 = 108,
        DXGI_FORMAT_Y216 = 109,
        DXGI_FORMAT_NV11 = 110,
        DXGI_FORMAT_AI44 = 111,
        DXGI_FORMAT_IA44 = 112,
        DXGI_FORMAT_P8 = 113,
        DXGI_FORMAT_A8P8 = 114,
        DXGI_FORMAT_B4G4R4A4_UNORM = 115,
        DXGI_FORMAT_FORCE_UINT = -1,
    };

    public enum D2D1_ALPHA_MODE : int
    {
        D2D1_ALPHA_MODE_UNKNOWN = 0,
        D2D1_ALPHA_MODE_PREMULTIPLIED = 1,
        D2D1_ALPHA_MODE_STRAIGHT = 2,
        D2D1_ALPHA_MODE_IGNORE = 3,
        D2D1_ALPHA_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_RENDER_TARGET_USAGE : int
    {
        D2D1_RENDER_TARGET_USAGE_NONE = 0,
        D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 1,
        D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 2,
        D2D1_RENDER_TARGET_USAGE_FORCE_DWORD = -1,
    };

    public enum D2D1_FEATURE_LEVEL : int
    {
        D2D1_FEATURE_LEVEL_DEFAULT = 0,
        D2D1_FEATURE_LEVEL_9 = 37120,
        D2D1_FEATURE_LEVEL_10 = 40960,
        D2D1_FEATURE_LEVEL_FORCE_DWORD = -1,
    };

    public enum D2D1_PRESENT_OPTIONS : int
    {
        D2D1_PRESENT_OPTIONS_NONE = 0,
        D2D1_PRESENT_OPTIONS_RETAIN_CONTENTS = 1,
        D2D1_PRESENT_OPTIONS_IMMEDIATELY = 2,
        D2D1_PRESENT_OPTIONS_FORCE_DWORD = -1,
    };

    public enum D2D1_WINDOW_STATE : int
    {
        D2D1_WINDOW_STATE_NONE = 0,
        D2D1_WINDOW_STATE_OCCLUDED = 1,
        D2D1_WINDOW_STATE_FORCE_DWORD = -1,
    };

    public enum D2D1_EXTEND_MODE : int
    {
        D2D1_EXTEND_MODE_CLAMP = 0,
        D2D1_EXTEND_MODE_WRAP = 1,
        D2D1_EXTEND_MODE_MIRROR = 2,
        D2D1_EXTEND_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_BITMAP_INTERPOLATION_MODE : int
    {
        D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
        D2D1_BITMAP_INTERPOLATION_MODE_LINEAR = 1,
        D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_GAMMA : int
    {
        D2D1_GAMMA_2_2 = 0,
        D2D1_GAMMA_1_0 = 1,
        D2D1_GAMMA_FORCE_DWORD = -1,
    };

    public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS : int
    {
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 1,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD = -1,
    };

    public enum D2D1_OPACITY_MASK_CONTENT : int
    {
        D2D1_OPACITY_MASK_CONTENT_GRAPHICS = 0,
        D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL = 1,
        D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE = 2,
        D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD = -1,
    };

    public enum DWRITE_TEXT_ALIGNMENT : int
    {
        DWRITE_TEXT_ALIGNMENT_LEADING,
        DWRITE_TEXT_ALIGNMENT_TRAILING,
        DWRITE_TEXT_ALIGNMENT_CENTER,
        DWRITE_TEXT_ALIGNMENT_JUSTIFIED,
    };

    public enum DWRITE_PARAGRAPH_ALIGNMENT : int
    {
        DWRITE_PARAGRAPH_ALIGNMENT_NEAR,
        DWRITE_PARAGRAPH_ALIGNMENT_FAR,
        DWRITE_PARAGRAPH_ALIGNMENT_CENTER,
    };

    public enum DWRITE_WORD_WRAPPING : int
    {
        DWRITE_WORD_WRAPPING_WRAP = 0,
        DWRITE_WORD_WRAPPING_NO_WRAP = 1,
        DWRITE_WORD_WRAPPING_EMERGENCY_BREAK = 2,
        DWRITE_WORD_WRAPPING_WHOLE_WORD = 3,
        DWRITE_WORD_WRAPPING_CHARACTER = 4,
    };

    public enum DWRITE_READING_DIRECTION : int
    {
        DWRITE_READING_DIRECTION_LEFT_TO_RIGHT = 0,
        DWRITE_READING_DIRECTION_RIGHT_TO_LEFT = 1,
        DWRITE_READING_DIRECTION_TOP_TO_BOTTOM = 2,
        DWRITE_READING_DIRECTION_BOTTOM_TO_TOP = 3,
    };

    public enum DWRITE_FLOW_DIRECTION : int
    {
        DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM = 0,
        DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP = 1,
        DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT = 2,
        DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT = 3,
    };

    public enum DWRITE_TRIMMING_GRANULARITY : int
    {
        DWRITE_TRIMMING_GRANULARITY_NONE,
        DWRITE_TRIMMING_GRANULARITY_CHARACTER,
        DWRITE_TRIMMING_GRANULARITY_WORD,
    };

    public enum DWRITE_MEASURING_MODE : int
    {
        DWRITE_MEASURING_MODE_NATURAL,
        DWRITE_MEASURING_MODE_GDI_CLASSIC,
        DWRITE_MEASURING_MODE_GDI_NATURAL,
    };

    public enum DWRITE_FONT_FACE_TYPE : int
    {
        DWRITE_FONT_FACE_TYPE_CFF,
        DWRITE_FONT_FACE_TYPE_TRUETYPE,
        DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION,
        DWRITE_FONT_FACE_TYPE_TYPE1,
        DWRITE_FONT_FACE_TYPE_VECTOR,
        DWRITE_FONT_FACE_TYPE_BITMAP,
        DWRITE_FONT_FACE_TYPE_UNKNOWN,
        DWRITE_FONT_FACE_TYPE_RAW_CFF,
    };

    public enum DWRITE_FONT_FILE_TYPE : int
    {
        DWRITE_FONT_FILE_TYPE_UNKNOWN,
        DWRITE_FONT_FILE_TYPE_CFF,
        DWRITE_FONT_FILE_TYPE_TRUETYPE,
        DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION,
        DWRITE_FONT_FILE_TYPE_TYPE1_PFM,
        DWRITE_FONT_FILE_TYPE_TYPE1_PFB,
        DWRITE_FONT_FILE_TYPE_VECTOR,
        DWRITE_FONT_FILE_TYPE_BITMAP,
    };

    public enum DWRITE_FONT_SIMULATIONS : int
    {
        DWRITE_FONT_SIMULATIONS_NONE = 0,
        DWRITE_FONT_SIMULATIONS_BOLD = 1,
        DWRITE_FONT_SIMULATIONS_OBLIQUE = 2,
    };

    public enum DWRITE_BREAK_CONDITION : int
    {
        DWRITE_BREAK_CONDITION_NEUTRAL,
        DWRITE_BREAK_CONDITION_CAN_BREAK,
        DWRITE_BREAK_CONDITION_MAY_NOT_BREAK,
        DWRITE_BREAK_CONDITION_MUST_BREAK,
    };

    public enum DWRITE_LINE_SPACING_METHOD : int
    {
        DWRITE_LINE_SPACING_METHOD_DEFAULT,
        DWRITE_LINE_SPACING_METHOD_UNIFORM,
    };

    public enum DWRITE_FONT_WEIGHT : int
    {
        DWRITE_FONT_WEIGHT_THIN = 100,
        DWRITE_FONT_WEIGHT_EXTRA_LIGHT = 200,
        DWRITE_FONT_WEIGHT_ULTRA_LIGHT = 200,
        DWRITE_FONT_WEIGHT_LIGHT = 300,
        DWRITE_FONT_WEIGHT_SEMI_LIGHT = 350,
        DWRITE_FONT_WEIGHT_NORMAL = 400,
        DWRITE_FONT_WEIGHT_REGULAR = 400,
        DWRITE_FONT_WEIGHT_MEDIUM = 500,
        DWRITE_FONT_WEIGHT_DEMI_BOLD = 600,
        DWRITE_FONT_WEIGHT_SEMI_BOLD = 600,
        DWRITE_FONT_WEIGHT_BOLD = 700,
        DWRITE_FONT_WEIGHT_EXTRA_BOLD = 800,
        DWRITE_FONT_WEIGHT_ULTRA_BOLD = 800,
        DWRITE_FONT_WEIGHT_BLACK = 900,
        DWRITE_FONT_WEIGHT_HEAVY = 900,
        DWRITE_FONT_WEIGHT_EXTRA_BLACK = 950,
        DWRITE_FONT_WEIGHT_ULTRA_BLACK = 950,
    };

    public enum DWRITE_FONT_STRETCH : int
    {
        DWRITE_FONT_STRETCH_UNDEFINED = 0,
        DWRITE_FONT_STRETCH_ULTRA_CONDENSED = 1,
        DWRITE_FONT_STRETCH_EXTRA_CONDENSED = 2,
        DWRITE_FONT_STRETCH_CONDENSED = 3,
        DWRITE_FONT_STRETCH_SEMI_CONDENSED = 4,
        DWRITE_FONT_STRETCH_NORMAL = 5,
        DWRITE_FONT_STRETCH_MEDIUM = 5,
        DWRITE_FONT_STRETCH_SEMI_EXPANDED = 6,
        DWRITE_FONT_STRETCH_EXPANDED = 7,
        DWRITE_FONT_STRETCH_EXTRA_EXPANDED = 8,
        DWRITE_FONT_STRETCH_ULTRA_EXPANDED = 9,
    };

    public enum DWRITE_FONT_STYLE : int
    {
        DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STYLE_OBLIQUE,
        DWRITE_FONT_STYLE_ITALIC,
    };

    public enum DWRITE_INFORMATIONAL_STRING_ID : int
    {
        DWRITE_INFORMATIONAL_STRING_NONE,
        DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE,
        DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS,
        DWRITE_INFORMATIONAL_STRING_TRADEMARK,
        DWRITE_INFORMATIONAL_STRING_MANUFACTURER,
        DWRITE_INFORMATIONAL_STRING_DESIGNER,
        DWRITE_INFORMATIONAL_STRING_DESIGNER_URL,
        DWRITE_INFORMATIONAL_STRING_DESCRIPTION,
        DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL,
        DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION,
        DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL,
        DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES,
        DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES,
        DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES,
        DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES,
        DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT,
        DWRITE_INFORMATIONAL_STRING_FULL_NAME,
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME,
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME,
    };

    public enum D2D1_DRAW_TEXT_OPTIONS : int
    {
        D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 1,
        D2D1_DRAW_TEXT_OPTIONS_CLIP = 2,
        D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 4,
        D2D1_DRAW_TEXT_OPTIONS_NONE = 0,
        D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD = -1,
    };

    public enum DWRITE_FONT_FEATURE_TAG : int
    {
        DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS = 1668441697,
        DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS = 1668297315,
        DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS = 1668493923,
        DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES = 1953259875,
        DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS = 1702060387,
        DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION = 1886217059,
        DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES = 1734962275,
        DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING = 1886613603,
        DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH = 1752658787,
        DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING = 1936880995,
        DWRITE_FONT_FEATURE_TAG_DEFAULT = 1953261156,
        DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES = 1734962276,
        DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS = 1953527909,
        DWRITE_FONT_FEATURE_TAG_FRACTIONS = 1667330662,
        DWRITE_FONT_FEATURE_TAG_FULL_WIDTH = 1684633446,
        DWRITE_FONT_FEATURE_TAG_HALF_FORMS = 1718378856,
        DWRITE_FONT_FEATURE_TAG_HALANT_FORMS = 1852596584,
        DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH = 1953259880,
        DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS = 1953720680,
        DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES = 1634626408,
        DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES = 1734962280,
        DWRITE_FONT_FEATURE_TAG_HALF_WIDTH = 1684633448,
        DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS = 1869246312,
        DWRITE_FONT_FEATURE_TAG_JIS04_FORMS = 875589738,
        DWRITE_FONT_FEATURE_TAG_JIS78_FORMS = 943157354,
        DWRITE_FONT_FEATURE_TAG_JIS83_FORMS = 859336810,
        DWRITE_FONT_FEATURE_TAG_JIS90_FORMS = 809070698,
        DWRITE_FONT_FEATURE_TAG_KERNING = 1852990827,
        DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES = 1634167148,
        DWRITE_FONT_FEATURE_TAG_LINING_FIGURES = 1836412524,
        DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS = 1818455916,
        DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING = 1802658157,
        DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK = 1802659693,
        DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING = 1802333037,
        DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS = 1953259886,
        DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS = 1801677934,
        DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES = 1836412527,
        DWRITE_FONT_FEATURE_TAG_ORDINALS = 1852076655,
        DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH = 1953259888,
        DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS = 1885430640,
        DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES = 1836412528,
        DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS = 1684633456,
        DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS = 1684633457,
        DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES = 1734962290,
        DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS = 2036495730,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES = 1953259891,
        DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS = 1718511987,
        DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS = 1885564275,
        DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS = 1819307379,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1 = 825258867,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2 = 842036083,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3 = 858813299,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4 = 875590515,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5 = 892367731,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6 = 909144947,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7 = 925922163,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8 = 942699379,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9 = 959476595,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10 = 808547187,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11 = 825324403,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12 = 842101619,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13 = 858878835,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14 = 875656051,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15 = 892433267,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16 = 909210483,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17 = 925987699,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18 = 942764915,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19 = 959542131,
        DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20 = 808612723,
        DWRITE_FONT_FEATURE_TAG_SUBSCRIPT = 1935832435,
        DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT = 1936749939,
        DWRITE_FONT_FEATURE_TAG_SWASH = 1752397683,
        DWRITE_FONT_FEATURE_TAG_TITLING = 1819568500,
        DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS = 1835101812,
        DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES = 1836412532,
        DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS = 1684107892,
        DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS = 1684633460,
        DWRITE_FONT_FEATURE_TAG_UNICASE = 1667853941,
        DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING = 1953654134,
        DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION = 846492278,
        DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO = 1869768058,
    };

    public enum D2D1_LAYER_OPTIONS : int
    {
        D2D1_LAYER_OPTIONS_NONE = 0,
        D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE = 1,
        D2D1_LAYER_OPTIONS_FORCE_DWORD = -1,
    };

    public enum tagSERVERCALL : int
    {
        SERVERCALL_ISHANDLED = 0,
        SERVERCALL_REJECTED = 1,
        SERVERCALL_RETRYLATER = 2,
    };

    public enum AFX_HELP_TYPE : int
    {
        afxWinHelp = 0,
        afxHTMLHelp = 1,
    };

    public enum THUMBBUTTONMASK : int
    {
        THB_BITMAP = 1,
        THB_ICON = 2,
        THB_TOOLTIP = 4,
        THB_FLAGS = 8,
    };

    public enum THUMBBUTTONFLAGS : int
    {
        THBF_ENABLED = 0,
        THBF_DISABLED = 1,
        THBF_DISMISSONCLICK = 2,
        THBF_NOBACKGROUND = 4,
        THBF_HIDDEN = 8,
        THBF_NONINTERACTIVE = 16,
    };

    public enum D2D1_FACTORY_TYPE : int
    {
        D2D1_FACTORY_TYPE_SINGLE_THREADED = 0,
        D2D1_FACTORY_TYPE_MULTI_THREADED = 1,
        D2D1_FACTORY_TYPE_FORCE_DWORD = -1,
    };

    public enum DWRITE_FACTORY_TYPE : int
    {
        DWRITE_FACTORY_TYPE_SHARED,
        DWRITE_FACTORY_TYPE_ISOLATED,
    };

    public enum WTS_ALPHATYPE : int
    {
        WTSAT_UNKNOWN = 0,
        WTSAT_RGB = 1,
        WTSAT_ARGB = 2,
    };

    public enum tagCHUNK_BREAKTYPE : int
    {
        CHUNK_NO_BREAK = 0,
        CHUNK_EOW = 1,
        CHUNK_EOS = 2,
        CHUNK_EOP = 3,
        CHUNK_EOC = 4,
    };

    public enum tagCHUNKSTATE : int
    {
        CHUNK_TEXT = 1,
        CHUNK_VALUE = 2,
        CHUNK_FILTER_OWNED_VALUE = 4,
    };

    public enum _RPC_HTTP_REDIRECTOR_STAGE : int
    {
        RPCHTTP_RS_REDIRECT = 1,
        RPCHTTP_RS_ACCESS_1,
        RPCHTTP_RS_SESSION,
        RPCHTTP_RS_ACCESS_2,
        RPCHTTP_RS_INTERFACE,
    };

    public enum RPC_ADDRESS_CHANGE_TYPE : int
    {
        PROTOCOL_NOT_LOADED = 1,
        PROTOCOL_LOADED,
        PROTOCOL_ADDRESS_CHANGE,
    };

    public enum RpcProxyPerfCounters : int
    {
        RpcCurrentUniqueUser = 1,
        RpcBackEndConnectionAttempts,
        RpcBackEndConnectionFailed,
        RpcRequestsPerSecond,
        RpcIncomingConnections,
        RpcIncomingBandwidth,
        RpcOutgoingBandwidth,
        RpcAttemptedLbsDecisions,
        RpcFailedLbsDecisions,
        RpcAttemptedLbsMessages,
        RpcFailedLbsMessages,
        RpcLastCounter,
    };

    public enum _RPC_NOTIFICATION_TYPES : int
    {
        RpcNotificationTypeNone,
        RpcNotificationTypeEvent,
        RpcNotificationTypeApc,
        RpcNotificationTypeIoc,
        RpcNotificationTypeHwnd,
        RpcNotificationTypeCallback,
    };

    public enum _RPC_ASYNC_EVENT : int
    {
        RpcCallComplete,
        RpcSendComplete,
        RpcReceiveComplete,
        RpcClientDisconnect,
        RpcClientCancel,
    };

    public enum tagExtendedErrorParamTypes : int
    {
        eeptAnsiString = 1,
        eeptUnicodeString,
        eeptLongVal,
        eeptShortVal,
        eeptPointerVal,
        eeptNone,
        eeptBinary,
    };

    public enum tagRpcLocalAddressFormat : int
    {
        rlafInvalid = 0,
        rlafIPv4,
        rlafIPv6,
    };

    public enum tagRpcCallType : int
    {
        rctInvalid = 0,
        rctNormal,
        rctTraining,
        rctGuaranteed,
    };

    public enum tagRpcCallClientLocality : int
    {
        rcclInvalid = 0,
        rcclLocal,
        rcclRemote,
        rcclClientUnknownLocality,
    };

    public enum _RPC_NOTIFICATIONS : int
    {
        RpcNotificationCallNone = 0,
        RpcNotificationClientDisconnect = 1,
        RpcNotificationCallCancel = 2,
    };

    public enum _IDL_CS_CONVERT : int
    {
        IDL_CS_NO_CONVERT,
        IDL_CS_IN_PLACE_CONVERT,
        IDL_CS_NEW_BUFFER_CONVERT,
    };

    public enum XLAT_SIDE : int
    {
        XLAT_SERVER = 1,
        XLAT_CLIENT,
    };

    public enum _USER_MARSHAL_CB_TYPE : int
    {
        USER_MARSHAL_CB_BUFFER_SIZE,
        USER_MARSHAL_CB_MARSHALL,
        USER_MARSHAL_CB_UNMARSHALL,
        USER_MARSHAL_CB_FREE,
    };

    public enum _system_handle_t : int
    {
        SYSTEM_HANDLE_FILE = 0,
        SYSTEM_HANDLE_SEMAPHORE = 1,
        SYSTEM_HANDLE_EVENT = 2,
        SYSTEM_HANDLE_MUTEX = 3,
        SYSTEM_HANDLE_PROCESS = 4,
        SYSTEM_HANDLE_TOKEN = 5,
        SYSTEM_HANDLE_INVALID = 255,
    };

    public enum STUB_PHASE : int
    {
        STUB_UNMARSHAL,
        STUB_CALL_SERVER,
        STUB_MARSHAL,
        STUB_CALL_SERVER_NO_HRESULT,
    };

    public enum PROXY_PHASE : int
    {
        PROXY_CALCSIZE,
        PROXY_GETBUFFER,
        PROXY_MARSHAL,
        PROXY_SENDRECEIVE,
        PROXY_UNMARSHAL,
    };

    public enum tagREGCLS : int
    {
        REGCLS_SINGLEUSE = 0,
        REGCLS_MULTIPLEUSE = 1,
        REGCLS_MULTI_SEPARATE = 2,
        REGCLS_SUSPENDED = 4,
        REGCLS_SURROGATE = 8,
    };

    public enum tagCOINITBASE : int
    {
        COINITBASE_MULTITHREADED = 0,
    };

    public enum tagMEMCTX : int
    {
        MEMCTX_TASK = 1,
        MEMCTX_SHARED = 2,
        MEMCTX_MACSYSTEM = 3,
        MEMCTX_UNKNOWN = -1,
        MEMCTX_SAME = -2,
    };

    public enum tagCLSCTX : int
    {
        CLSCTX_INPROC_SERVER = 1,
        CLSCTX_INPROC_HANDLER = 2,
        CLSCTX_LOCAL_SERVER = 4,
        CLSCTX_INPROC_SERVER16 = 8,
        CLSCTX_REMOTE_SERVER = 16,
        CLSCTX_INPROC_HANDLER16 = 32,
        CLSCTX_RESERVED1 = 64,
        CLSCTX_RESERVED2 = 128,
        CLSCTX_RESERVED3 = 256,
        CLSCTX_RESERVED4 = 512,
        CLSCTX_NO_CODE_DOWNLOAD = 1024,
        CLSCTX_RESERVED5 = 2048,
        CLSCTX_NO_CUSTOM_MARSHAL = 4096,
        CLSCTX_ENABLE_CODE_DOWNLOAD = 8192,
        CLSCTX_NO_FAILURE_LOG = 16384,
        CLSCTX_DISABLE_AAA = 32768,
        CLSCTX_ENABLE_AAA = 65536,
        CLSCTX_FROM_DEFAULT_CONTEXT = 131072,
        CLSCTX_ACTIVATE_32_BIT_SERVER = 262144,
        CLSCTX_ACTIVATE_64_BIT_SERVER = 524288,
        CLSCTX_ENABLE_CLOAKING = 1048576,
        CLSCTX_APPCONTAINER = 4194304,
        CLSCTX_ACTIVATE_AAA_AS_IU = 8388608,
        CLSCTX_PS_DLL = -2147483648,
    };

    public enum tagMSHLFLAGS : int
    {
        MSHLFLAGS_NORMAL = 0,
        MSHLFLAGS_TABLESTRONG = 1,
        MSHLFLAGS_TABLEWEAK = 2,
        MSHLFLAGS_NOPING = 4,
        MSHLFLAGS_RESERVED1 = 8,
        MSHLFLAGS_RESERVED2 = 16,
        MSHLFLAGS_RESERVED3 = 32,
        MSHLFLAGS_RESERVED4 = 64,
    };

    public enum tagMSHCTX : int
    {
        MSHCTX_LOCAL = 0,
        MSHCTX_NOSHAREDMEM = 1,
        MSHCTX_DIFFERENTMACHINE = 2,
        MSHCTX_INPROC = 3,
        MSHCTX_CROSSCTX = 4,
    };

    public enum tagRPCOPT_PROPERTIES : int
    {
        COMBND_RPCTIMEOUT = 1,
        COMBND_SERVER_LOCALITY = 2,
        COMBND_RESERVED1 = 4,
        COMBND_RESERVED2 = 5,
    };

    public enum tagGLOBALOPT_PROPERTIES : int
    {
        COMGLB_EXCEPTION_HANDLING = 1,
        COMGLB_APPID = 2,
        COMGLB_RPC_THREADPOOL_SETTING = 3,
        COMGLB_RO_SETTINGS = 4,
        COMGLB_UNMARSHALING_POLICY = 5,
    };

    public enum _APTTYPE : int
    {
        APTTYPE_CURRENT = -1,
        APTTYPE_STA = 0,
        APTTYPE_MTA = 1,
        APTTYPE_NA = 2,
        APTTYPE_MAINSTA = 3,
    };

    public enum _THDTYPE : int
    {
        THDTYPE_BLOCKMESSAGES = 0,
        THDTYPE_PROCESSMESSAGES = 1,
    };

    public enum CO_MARSHALING_CONTEXT_ATTRIBUTES : int
    {
        CO_MARSHALING_SOURCE_IS_APP_CONTAINER = 0,
        CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1 = -2147483648,
        CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2 = -2147483647,
    };

    public enum tagACTIVATIONTYPE : int
    {
        ACTIVATIONTYPE_UNCATEGORIZED = 0,
        ACTIVATIONTYPE_FROM_MONIKER = 1,
        ACTIVATIONTYPE_FROM_DATA = 2,
        ACTIVATIONTYPE_FROM_STORAGE = 4,
        ACTIVATIONTYPE_FROM_STREAM = 8,
        ACTIVATIONTYPE_FROM_FILE = 16,
    };

    public enum tagEXTCONN : int
    {
        EXTCONN_STRONG = 1,
        EXTCONN_WEAK = 2,
        EXTCONN_CALLABLE = 4,
    };

    public enum tagSTGTY : int
    {
        STGTY_STORAGE = 1,
        STGTY_STREAM = 2,
        STGTY_LOCKBYTES = 3,
        STGTY_PROPERTY = 4,
    };

    public enum tagSTREAM_SEEK : int
    {
        STREAM_SEEK_SET = 0,
        STREAM_SEEK_CUR = 1,
        STREAM_SEEK_END = 2,
    };

    public enum tagLOCKTYPE : int
    {
        LOCK_WRITE = 1,
        LOCK_EXCLUSIVE = 2,
        LOCK_ONLYONCE = 4,
    };

    public enum tagEOLE_AUTHENTICATION_CAPABILITIES : int
    {
        EOAC_NONE = 0,
        EOAC_MUTUAL_AUTH = 1,
        EOAC_STATIC_CLOAKING = 32,
        EOAC_DYNAMIC_CLOAKING = 64,
        EOAC_ANY_AUTHORITY = 128,
        EOAC_MAKE_FULLSIC = 256,
        EOAC_DEFAULT = 2048,
        EOAC_SECURE_REFS = 2,
        EOAC_ACCESS_CONTROL = 4,
        EOAC_APPID = 8,
        EOAC_DYNAMIC = 16,
        EOAC_REQUIRE_FULLSIC = 512,
        EOAC_AUTO_IMPERSONATE = 1024,
        EOAC_NO_CUSTOM_MARSHAL = 8192,
        EOAC_DISABLE_AAA = 4096,
    };

    public enum tagRPCOPT_SERVER_LOCALITY_VALUES : int
    {
        SERVER_LOCALITY_PROCESS_LOCAL = 0,
        SERVER_LOCALITY_MACHINE_LOCAL = 1,
        SERVER_LOCALITY_REMOTE = 2,
    };

    public enum tagGLOBALOPT_EH_VALUES : int
    {
        COMGLB_EXCEPTION_HANDLE = 0,
        COMGLB_EXCEPTION_DONOT_HANDLE_FATAL = 1,
        COMGLB_EXCEPTION_DONOT_HANDLE = 1,
        COMGLB_EXCEPTION_DONOT_HANDLE_ANY = 2,
    };

    public enum tagGLOBALOPT_RPCTP_VALUES : int
    {
        COMGLB_RPC_THREADPOOL_SETTING_DEFAULT_POOL = 0,
        COMGLB_RPC_THREADPOOL_SETTING_PRIVATE_POOL = 1,
    };

    public enum tagGLOBALOPT_RO_FLAGS : int
    {
        COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES = 1,
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES = 2,
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES = 4,
        COMGLB_FAST_RUNDOWN = 8,
        COMGLB_RESERVED1 = 16,
        COMGLB_RESERVED2 = 32,
        COMGLB_RESERVED3 = 64,
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES = 128,
        COMGLB_RESERVED4 = 256,
        COMGLB_RESERVED5 = 512,
    };

    public enum tagGLOBALOPT_UNMARSHALING_POLICY_VALUES : int
    {
        COMGLB_UNMARSHALING_POLICY_NORMAL = 0,
        COMGLB_UNMARSHALING_POLICY_STRONG = 1,
        COMGLB_UNMARSHALING_POLICY_HYBRID = 2,
    };

    public enum tagDCOM_CALL_STATE : int
    {
        DCOM_NONE = 0,
        DCOM_CALL_COMPLETE = 1,
        DCOM_CALL_CANCELED = 2,
    };

    public enum _APTTYPEQUALIFIER : int
    {
        APTTYPEQUALIFIER_NONE = 0,
        APTTYPEQUALIFIER_IMPLICIT_MTA = 1,
        APTTYPEQUALIFIER_NA_ON_MTA = 2,
        APTTYPEQUALIFIER_NA_ON_STA = 3,
        APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 4,
        APTTYPEQUALIFIER_NA_ON_MAINSTA = 5,
        APTTYPEQUALIFIER_APPLICATION_STA = 6,
    };

    public enum tagSTDMSHLFLAGS : int
    {
        SMEXF_SERVER = 1,
        SMEXF_HANDLER = 2,
    };

    public enum tagCOWAIT_FLAGS : int
    {
        COWAIT_DEFAULT = 0,
        COWAIT_WAITALL = 1,
        COWAIT_ALERTABLE = 2,
        COWAIT_INPUTAVAILABLE = 4,
        COWAIT_DISPATCH_CALLS = 8,
        COWAIT_DISPATCH_WINDOW_MESSAGES = 16,
    };

    public enum CWMO_FLAGS : int
    {
        CWMO_DEFAULT = 0,
        CWMO_DISPATCH_CALLS = 1,
        CWMO_DISPATCH_WINDOW_MESSAGES = 2,
    };

    public enum AgileReferenceOptions : int
    {
        AGILEREFERENCE_DEFAULT = 0,
        AGILEREFERENCE_DELAYEDMARSHAL = 1,
    };

    public enum tagCOINIT : int
    {
        COINIT_APARTMENTTHREADED = 2,
        COINIT_MULTITHREADED = 0,
        COINIT_DISABLE_OLE1DDE = 4,
        COINIT_SPEED_OVER_MEMORY = 8,
    };

    public enum tagApplicationType : int
    {
        ServerApplication = 0,
        LibraryApplication = 1,
    };

    public enum tagShutdownType : int
    {
        IdleShutdown = 0,
        ForcedShutdown = 1,
    };

    public enum tagDVASPECT : int
    {
        DVASPECT_CONTENT = 1,
        DVASPECT_THUMBNAIL = 2,
        DVASPECT_ICON = 4,
        DVASPECT_DOCPRINT = 8,
    };

    public enum tagSTGC : int
    {
        STGC_DEFAULT = 0,
        STGC_OVERWRITE = 1,
        STGC_ONLYIFCURRENT = 2,
        STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
        STGC_CONSOLIDATE = 8,
    };

    public enum tagSTGMOVE : int
    {
        STGMOVE_MOVE = 0,
        STGMOVE_COPY = 1,
        STGMOVE_SHALLOWCOPY = 2,
    };

    public enum tagSTATFLAG : int
    {
        STATFLAG_DEFAULT = 0,
        STATFLAG_NONAME = 1,
        STATFLAG_NOOPEN = 2,
    };

    public enum VARENUM : int
    {
        VT_EMPTY = 0,
        VT_NULL = 1,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_CY = 6,
        VT_DATE = 7,
        VT_BSTR = 8,
        VT_DISPATCH = 9,
        VT_ERROR = 10,
        VT_BOOL = 11,
        VT_VARIANT = 12,
        VT_UNKNOWN = 13,
        VT_DECIMAL = 14,
        VT_I1 = 16,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_I8 = 20,
        VT_UI8 = 21,
        VT_INT = 22,
        VT_UINT = 23,
        VT_VOID = 24,
        VT_HRESULT = 25,
        VT_PTR = 26,
        VT_SAFEARRAY = 27,
        VT_CARRAY = 28,
        VT_USERDEFINED = 29,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_RECORD = 36,
        VT_INT_PTR = 37,
        VT_UINT_PTR = 38,
        VT_FILETIME = 64,
        VT_BLOB = 65,
        VT_STREAM = 66,
        VT_STORAGE = 67,
        VT_STREAMED_OBJECT = 68,
        VT_STORED_OBJECT = 69,
        VT_BLOB_OBJECT = 70,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_VERSIONED_STREAM = 73,
        VT_BSTR_BLOB = 4095,
        VT_VECTOR = 4096,
        VT_ARRAY = 8192,
        VT_BYREF = 16384,
        VT_RESERVED = 32768,
        VT_ILLEGAL = 65535,
        VT_ILLEGALMASKED = 4095,
        VT_TYPEMASK = 4095,
    };

    public enum tagTYSPEC : int
    {
        TYSPEC_CLSID = 0,
        TYSPEC_FILEEXT = 1,
        TYSPEC_MIMETYPE = 2,
        TYSPEC_FILENAME = 3,
        TYSPEC_PROGID = 4,
        TYSPEC_PACKAGENAME = 5,
        TYSPEC_OBJECTID = 6,
    };

    public enum tagBIND_FLAGS : int
    {
        BIND_MAYBOTHERUSER = 1,
        BIND_JUSTTESTEXISTENCE = 2,
    };

    public enum tagMKSYS : int
    {
        MKSYS_NONE = 0,
        MKSYS_GENERICCOMPOSITE = 1,
        MKSYS_FILEMONIKER = 2,
        MKSYS_ANTIMONIKER = 3,
        MKSYS_ITEMMONIKER = 4,
        MKSYS_POINTERMONIKER = 5,
        MKSYS_CLASSMONIKER = 7,
        MKSYS_OBJREFMONIKER = 8,
        MKSYS_SESSIONMONIKER = 9,
        MKSYS_LUAMONIKER = 10,
    };

    public enum tagMKREDUCE : int
    {
        MKRREDUCE_ONE = 196608,
        MKRREDUCE_TOUSER = 131072,
        MKRREDUCE_THROUGHUSER = 65536,
        MKRREDUCE_ALL = 0,
    };

    public enum tagADVF : int
    {
        ADVF_NODATA = 1,
        ADVF_PRIMEFIRST = 2,
        ADVF_ONLYONCE = 4,
        ADVF_DATAONSTOP = 64,
        ADVFCACHE_NOHANDLER = 8,
        ADVFCACHE_FORCEBUILTIN = 16,
        ADVFCACHE_ONSAVE = 32,
    };

    public enum tagTYMED : int
    {
        TYMED_HGLOBAL = 1,
        TYMED_FILE = 2,
        TYMED_ISTREAM = 4,
        TYMED_ISTORAGE = 8,
        TYMED_GDI = 16,
        TYMED_MFPICT = 32,
        TYMED_ENHMF = 64,
        TYMED_NULL = 0,
    };

    public enum tagDATADIR : int
    {
        DATADIR_GET = 1,
        DATADIR_SET = 2,
    };

    public enum tagCALLTYPE : int
    {
        CALLTYPE_TOPLEVEL = 1,
        CALLTYPE_NESTED = 2,
        CALLTYPE_ASYNC = 3,
        CALLTYPE_TOPLEVEL_CALLPENDING = 4,
        CALLTYPE_ASYNC_CALLPENDING = 5,
    };

    public enum tagPENDINGTYPE : int
    {
        PENDINGTYPE_TOPLEVEL = 1,
        PENDINGTYPE_NESTED = 2,
    };

    public enum tagPENDINGMSG : int
    {
        PENDINGMSG_CANCELCALL = 0,
        PENDINGMSG_WAITNOPROCESS = 1,
        PENDINGMSG_WAITDEFPROCESS = 2,
    };

    public enum tagCOMSD : int
    {
        SD_LAUNCHPERMISSIONS = 0,
        SD_ACCESSPERMISSIONS = 1,
        SD_LAUNCHRESTRICTIONS = 2,
        SD_ACCESSRESTRICTIONS = 3,
    };

    public enum __MIDL_IMonikerProp_0001 : int
    {
        MIMETYPEPROP = 0,
        USE_SRC_URL = 1,
        CLASSIDPROP = 2,
        TRUSTEDDOWNLOADPROP = 3,
        POPUPLEVELPROP = 4,
    };

    public enum __MIDL_IUri_0001 : int
    {
        Uri_PROPERTY_ABSOLUTE_URI = 0,
        Uri_PROPERTY_STRING_START = 0,
        Uri_PROPERTY_AUTHORITY = 1,
        Uri_PROPERTY_DISPLAY_URI = 2,
        Uri_PROPERTY_DOMAIN = 3,
        Uri_PROPERTY_EXTENSION = 4,
        Uri_PROPERTY_FRAGMENT = 5,
        Uri_PROPERTY_HOST = 6,
        Uri_PROPERTY_PASSWORD = 7,
        Uri_PROPERTY_PATH = 8,
        Uri_PROPERTY_PATH_AND_QUERY = 9,
        Uri_PROPERTY_QUERY = 10,
        Uri_PROPERTY_RAW_URI = 11,
        Uri_PROPERTY_SCHEME_NAME = 12,
        Uri_PROPERTY_USER_INFO = 13,
        Uri_PROPERTY_USER_NAME = 14,
        Uri_PROPERTY_STRING_LAST = 14,
        Uri_PROPERTY_HOST_TYPE = 15,
        Uri_PROPERTY_DWORD_START = 15,
        Uri_PROPERTY_PORT = 16,
        Uri_PROPERTY_SCHEME = 17,
        Uri_PROPERTY_ZONE = 18,
        Uri_PROPERTY_DWORD_LAST = 18,
    };

    public enum _tagPARSEACTION : int
    {
        PARSE_CANONICALIZE = 1,
        PARSE_FRIENDLY = 2,
        PARSE_SECURITY_URL = 3,
        PARSE_ROOTDOCUMENT = 4,
        PARSE_DOCUMENT = 5,
        PARSE_ANCHOR = 6,
        PARSE_ENCODE_IS_UNESCAPE = 7,
        PARSE_DECODE_IS_ESCAPE = 8,
        PARSE_PATH_FROM_URL = 9,
        PARSE_URL_FROM_PATH = 10,
        PARSE_MIME = 11,
        PARSE_SERVER = 12,
        PARSE_SCHEMA = 13,
        PARSE_SITE = 14,
        PARSE_DOMAIN = 15,
        PARSE_LOCATION = 16,
        PARSE_SECURITY_DOMAIN = 17,
        PARSE_ESCAPE = 18,
        PARSE_UNESCAPE = 19,
    };

    public enum _tagQUERYOPTION : int
    {
        QUERY_EXPIRATION_DATE = 1,
        QUERY_TIME_OF_LAST_CHANGE = 2,
        QUERY_CONTENT_ENCODING = 3,
        QUERY_CONTENT_TYPE = 4,
        QUERY_REFRESH = 5,
        QUERY_RECOMBINE = 6,
        QUERY_CAN_NAVIGATE = 7,
        QUERY_USES_NETWORK = 8,
        QUERY_IS_CACHED = 9,
        QUERY_IS_INSTALLEDENTRY = 10,
        QUERY_IS_CACHED_OR_MAPPED = 11,
        QUERY_USES_CACHE = 12,
        QUERY_IS_SECURE = 13,
        QUERY_IS_SAFE = 14,
        QUERY_USES_HISTORYFOLDER = 15,
        QUERY_IS_CACHED_AND_USABLE_OFFLINE = 16,
    };

    public enum _URLZONEREG : int
    {
        URLZONEREG_DEFAULT = 0,
        URLZONEREG_HKLM = 1,
        URLZONEREG_HKCU = 2,
    };

    public enum __MIDL_IGetBindHandle_0001 : int
    {
        BINDHANDLETYPES_APPCACHE = 0,
        BINDHANDLETYPES_DEPENDENCY = 1,
        BINDHANDLETYPES_COUNT = 2,
    };

    public enum tagDISCARDCACHE : int
    {
        DISCARDCACHE_SAVEIFDIRTY = 0,
        DISCARDCACHE_NOSAVE = 1,
    };

    public enum tagOLEGETMONIKER : int
    {
        OLEGETMONIKER_ONLYIFTHERE = 1,
        OLEGETMONIKER_FORCEASSIGN = 2,
        OLEGETMONIKER_UNASSIGN = 3,
        OLEGETMONIKER_TEMPFORUSER = 4,
    };

    public enum tagOLEWHICHMK : int
    {
        OLEWHICHMK_CONTAINER = 1,
        OLEWHICHMK_OBJREL = 2,
        OLEWHICHMK_OBJFULL = 3,
    };

    public enum tagUSERCLASSTYPE : int
    {
        USERCLASSTYPE_FULL = 1,
        USERCLASSTYPE_SHORT = 2,
        USERCLASSTYPE_APPNAME = 3,
    };

    public enum tagOLEMISC : int
    {
        OLEMISC_RECOMPOSEONRESIZE = 1,
        OLEMISC_ONLYICONIC = 2,
        OLEMISC_INSERTNOTREPLACE = 4,
        OLEMISC_STATIC = 8,
        OLEMISC_CANTLINKINSIDE = 16,
        OLEMISC_CANLINKBYOLE1 = 32,
        OLEMISC_ISLINKOBJECT = 64,
        OLEMISC_INSIDEOUT = 128,
        OLEMISC_ACTIVATEWHENVISIBLE = 256,
        OLEMISC_RENDERINGISDEVICEINDEPENDENT = 512,
        OLEMISC_INVISIBLEATRUNTIME = 1024,
        OLEMISC_ALWAYSRUN = 2048,
        OLEMISC_ACTSLIKEBUTTON = 4096,
        OLEMISC_ACTSLIKELABEL = 8192,
        OLEMISC_NOUIACTIVATE = 16384,
        OLEMISC_ALIGNABLE = 32768,
        OLEMISC_SIMPLEFRAME = 65536,
        OLEMISC_SETCLIENTSITEFIRST = 131072,
        OLEMISC_IMEMODE = 262144,
        OLEMISC_IGNOREACTIVATEWHENVISIBLE = 524288,
        OLEMISC_WANTSTOMENUMERGE = 1048576,
        OLEMISC_SUPPORTSMULTILEVELUNDO = 2097152,
    };

    public enum tagOLECLOSE : int
    {
        OLECLOSE_SAVEIFDIRTY = 0,
        OLECLOSE_NOSAVE = 1,
        OLECLOSE_PROMPTSAVE = 2,
    };

    public enum tagOLERENDER : int
    {
        OLERENDER_NONE = 0,
        OLERENDER_DRAW = 1,
        OLERENDER_FORMAT = 2,
        OLERENDER_ASIS = 3,
    };

    public enum tagOLEUPDATE : int
    {
        OLEUPDATE_ALWAYS = 1,
        OLEUPDATE_ONCALL = 3,
    };

    public enum tagOLELINKBIND : int
    {
        OLELINKBIND_EVENIFCLASSDIFF = 1,
    };

    public enum tagBINDSPEED : int
    {
        BINDSPEED_INDEFINITE = 1,
        BINDSPEED_MODERATE = 2,
        BINDSPEED_IMMEDIATE = 3,
    };

    public enum tagOLECONTF : int
    {
        OLECONTF_EMBEDDINGS = 1,
        OLECONTF_LINKS = 2,
        OLECONTF_OTHERS = 4,
        OLECONTF_ONLYUSER = 8,
        OLECONTF_ONLYIFRUNNING = 16,
    };

    public enum tagOLEVERBATTRIB : int
    {
        OLEVERBATTRIB_NEVERDIRTIES = 1,
        OLEVERBATTRIB_ONCONTAINERMENU = 2,
    };

    public enum tagDOMNodeType : int
    {
        NODE_INVALID = 0,
        NODE_ELEMENT = 1,
        NODE_ATTRIBUTE = 2,
        NODE_TEXT = 3,
        NODE_CDATA_SECTION = 4,
        NODE_ENTITY_REFERENCE = 5,
        NODE_ENTITY = 6,
        NODE_PROCESSING_INSTRUCTION = 7,
        NODE_COMMENT = 8,
        NODE_DOCUMENT = 9,
        NODE_DOCUMENT_TYPE = 10,
        NODE_DOCUMENT_FRAGMENT = 11,
        NODE_NOTATION = 12,
    };

    public enum tagCHANGEKIND : int
    {
        CHANGEKIND_ADDMEMBER = 0,
        CHANGEKIND_DELETEMEMBER = 1,
        CHANGEKIND_SETNAMES = 2,
        CHANGEKIND_SETDOCUMENTATION = 3,
        CHANGEKIND_GENERAL = 4,
        CHANGEKIND_INVALIDATE = 5,
        CHANGEKIND_CHANGEFAILED = 6,
        CHANGEKIND_MAX = 7,
    };

    public enum tagSF_TYPE : int
    {
        SF_ERROR = 10,
        SF_I1 = 16,
        SF_I2 = 2,
        SF_I4 = 3,
        SF_I8 = 20,
        SF_BSTR = 8,
        SF_UNKNOWN = 13,
        SF_DISPATCH = 9,
        SF_VARIANT = 12,
        SF_RECORD = 36,
        SF_HAVEIID = 32781,
    };

    public enum tagTYPEFLAGS : int
    {
        TYPEFLAG_FAPPOBJECT = 1,
        TYPEFLAG_FCANCREATE = 2,
        TYPEFLAG_FLICENSED = 4,
        TYPEFLAG_FPREDECLID = 8,
        TYPEFLAG_FHIDDEN = 16,
        TYPEFLAG_FCONTROL = 32,
        TYPEFLAG_FDUAL = 64,
        TYPEFLAG_FNONEXTENSIBLE = 128,
        TYPEFLAG_FOLEAUTOMATION = 256,
        TYPEFLAG_FRESTRICTED = 512,
        TYPEFLAG_FAGGREGATABLE = 1024,
        TYPEFLAG_FREPLACEABLE = 2048,
        TYPEFLAG_FDISPATCHABLE = 4096,
        TYPEFLAG_FREVERSEBIND = 8192,
        TYPEFLAG_FPROXY = 16384,
    };

    public enum tagFUNCFLAGS : int
    {
        FUNCFLAG_FRESTRICTED = 1,
        FUNCFLAG_FSOURCE = 2,
        FUNCFLAG_FBINDABLE = 4,
        FUNCFLAG_FREQUESTEDIT = 8,
        FUNCFLAG_FDISPLAYBIND = 16,
        FUNCFLAG_FDEFAULTBIND = 32,
        FUNCFLAG_FHIDDEN = 64,
        FUNCFLAG_FUSESGETLASTERROR = 128,
        FUNCFLAG_FDEFAULTCOLLELEM = 256,
        FUNCFLAG_FUIDEFAULT = 512,
        FUNCFLAG_FNONBROWSABLE = 1024,
        FUNCFLAG_FREPLACEABLE = 2048,
        FUNCFLAG_FIMMEDIATEBIND = 4096,
    };

    public enum tagVARFLAGS : int
    {
        VARFLAG_FREADONLY = 1,
        VARFLAG_FSOURCE = 2,
        VARFLAG_FBINDABLE = 4,
        VARFLAG_FREQUESTEDIT = 8,
        VARFLAG_FDISPLAYBIND = 16,
        VARFLAG_FDEFAULTBIND = 32,
        VARFLAG_FHIDDEN = 64,
        VARFLAG_FRESTRICTED = 128,
        VARFLAG_FDEFAULTCOLLELEM = 256,
        VARFLAG_FUIDEFAULT = 512,
        VARFLAG_FNONBROWSABLE = 1024,
        VARFLAG_FREPLACEABLE = 2048,
        VARFLAG_FIMMEDIATEBIND = 4096,
    };

    public enum tagLIBFLAGS : int
    {
        LIBFLAG_FRESTRICTED = 1,
        LIBFLAG_FCONTROL = 2,
        LIBFLAG_FHIDDEN = 4,
        LIBFLAG_FHASDISKIMAGE = 8,
    };

    public enum tagXMLEMEM_TYPE : int
    {
        XMLELEMTYPE_ELEMENT = 0,
        XMLELEMTYPE_TEXT = 1,
        XMLELEMTYPE_COMMENT = 2,
        XMLELEMTYPE_DOCUMENT = 3,
        XMLELEMTYPE_DTD = 4,
        XMLELEMTYPE_PI = 5,
        XMLELEMTYPE_OTHER = 6,
    };

    public enum __MIDL_IBindStatusCallback_0001 : int
    {
        BINDVERB_GET = 0,
        BINDVERB_POST = 1,
        BINDVERB_PUT = 2,
        BINDVERB_CUSTOM = 3,
        BINDVERB_RESERVED1 = 4,
    };

    public enum __MIDL_IBindStatusCallback_0002 : int
    {
        BINDINFOF_URLENCODESTGMEDDATA = 1,
        BINDINFOF_URLENCODEDEXTRAINFO = 2,
    };

    public enum __MIDL_IBindStatusCallback_0003 : int
    {
        BINDF_ASYNCHRONOUS = 1,
        BINDF_ASYNCSTORAGE = 2,
        BINDF_NOPROGRESSIVERENDERING = 4,
        BINDF_OFFLINEOPERATION = 8,
        BINDF_GETNEWESTVERSION = 16,
        BINDF_NOWRITECACHE = 32,
        BINDF_NEEDFILE = 64,
        BINDF_PULLDATA = 128,
        BINDF_IGNORESECURITYPROBLEM = 256,
        BINDF_RESYNCHRONIZE = 512,
        BINDF_HYPERLINK = 1024,
        BINDF_NO_UI = 2048,
        BINDF_SILENTOPERATION = 4096,
        BINDF_PRAGMA_NO_CACHE = 8192,
        BINDF_GETCLASSOBJECT = 16384,
        BINDF_RESERVED_1 = 32768,
        BINDF_FREE_THREADED = 65536,
        BINDF_DIRECT_READ = 131072,
        BINDF_FORMS_SUBMIT = 262144,
        BINDF_GETFROMCACHE_IF_NET_FAIL = 524288,
        BINDF_FROMURLMON = 1048576,
        BINDF_FWD_BACK = 2097152,
        BINDF_PREFERDEFAULTHANDLER = 4194304,
        BINDF_ENFORCERESTRICTED = 8388608,
        BINDF_RESERVED_2 = -2147483648,
        BINDF_RESERVED_3 = 16777216,
        BINDF_RESERVED_4 = 33554432,
        BINDF_RESERVED_5 = 67108864,
        BINDF_RESERVED_6 = 134217728,
        BINDF_RESERVED_7 = 1073741824,
        BINDF_RESERVED_8 = 536870912,
    };

    public enum __MIDL_IBindStatusCallback_0004 : int
    {
        URL_ENCODING_NONE = 0,
        URL_ENCODING_ENABLE_UTF8 = 268435456,
        URL_ENCODING_DISABLE_UTF8 = 536870912,
    };

    public enum __MIDL_IBindStatusCallback_0005 : int
    {
        BINDINFO_OPTIONS_WININETFLAG = 65536,
        BINDINFO_OPTIONS_ENABLE_UTF8 = 131072,
        BINDINFO_OPTIONS_DISABLE_UTF8 = 262144,
        BINDINFO_OPTIONS_USE_IE_ENCODING = 524288,
        BINDINFO_OPTIONS_BINDTOOBJECT = 1048576,
        BINDINFO_OPTIONS_SECURITYOPTOUT = 2097152,
        BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN = 4194304,
        BINDINFO_OPTIONS_USEBINDSTRINGCREDS = 8388608,
        BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS = 16777216,
        BINDINFO_OPTIONS_IGNORE_SSLERRORS_ONCE = 33554432,
        BINDINFO_WPC_DOWNLOADBLOCKED = 134217728,
        BINDINFO_WPC_LOGGING_ENABLED = 268435456,
        BINDINFO_OPTIONS_ALLOWCONNECTDATA = 536870912,
        BINDINFO_OPTIONS_DISABLEAUTOREDIRECTS = 1073741824,
        BINDINFO_OPTIONS_SHDOCVW_NAVIGATE = -2147483648,
    };

    public enum __MIDL_IBindStatusCallback_0006 : int
    {
        BSCF_FIRSTDATANOTIFICATION = 1,
        BSCF_INTERMEDIATEDATANOTIFICATION = 2,
        BSCF_LASTDATANOTIFICATION = 4,
        BSCF_DATAFULLYAVAILABLE = 8,
        BSCF_AVAILABLEDATASIZEUNKNOWN = 16,
        BSCF_SKIPDRAINDATAFORFILEURLS = 32,
        BSCF_64BITLENGTHDOWNLOAD = 64,
    };

    public enum tagBINDSTATUS : int
    {
        BINDSTATUS_FINDINGRESOURCE = 1,
        BINDSTATUS_CONNECTING = 2,
        BINDSTATUS_REDIRECTING = 3,
        BINDSTATUS_BEGINDOWNLOADDATA = 4,
        BINDSTATUS_DOWNLOADINGDATA = 5,
        BINDSTATUS_ENDDOWNLOADDATA = 6,
        BINDSTATUS_BEGINDOWNLOADCOMPONENTS = 7,
        BINDSTATUS_INSTALLINGCOMPONENTS = 8,
        BINDSTATUS_ENDDOWNLOADCOMPONENTS = 9,
        BINDSTATUS_USINGCACHEDCOPY = 10,
        BINDSTATUS_SENDINGREQUEST = 11,
        BINDSTATUS_CLASSIDAVAILABLE = 12,
        BINDSTATUS_MIMETYPEAVAILABLE = 13,
        BINDSTATUS_CACHEFILENAMEAVAILABLE = 14,
        BINDSTATUS_BEGINSYNCOPERATION = 15,
        BINDSTATUS_ENDSYNCOPERATION = 16,
        BINDSTATUS_BEGINUPLOADDATA = 17,
        BINDSTATUS_UPLOADINGDATA = 18,
        BINDSTATUS_ENDUPLOADDATA = 19,
        BINDSTATUS_PROTOCOLCLASSID = 20,
        BINDSTATUS_ENCODING = 21,
        BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE = 22,
        BINDSTATUS_CLASSINSTALLLOCATION = 23,
        BINDSTATUS_DECODING = 24,
        BINDSTATUS_LOADINGMIMEHANDLER = 25,
        BINDSTATUS_CONTENTDISPOSITIONATTACH = 26,
        BINDSTATUS_FILTERREPORTMIMETYPE = 27,
        BINDSTATUS_CLSIDCANINSTANTIATE = 28,
        BINDSTATUS_IUNKNOWNAVAILABLE = 29,
        BINDSTATUS_DIRECTBIND = 30,
        BINDSTATUS_RAWMIMETYPE = 31,
        BINDSTATUS_PROXYDETECTING = 32,
        BINDSTATUS_ACCEPTRANGES = 33,
        BINDSTATUS_COOKIE_SENT = 34,
        BINDSTATUS_COMPACT_POLICY_RECEIVED = 35,
        BINDSTATUS_COOKIE_SUPPRESSED = 36,
        BINDSTATUS_COOKIE_STATE_UNKNOWN = 37,
        BINDSTATUS_COOKIE_STATE_ACCEPT = 38,
        BINDSTATUS_COOKIE_STATE_REJECT = 39,
        BINDSTATUS_COOKIE_STATE_PROMPT = 40,
        BINDSTATUS_COOKIE_STATE_LEASH = 41,
        BINDSTATUS_COOKIE_STATE_DOWNGRADE = 42,
        BINDSTATUS_POLICY_HREF = 43,
        BINDSTATUS_P3P_HEADER = 44,
        BINDSTATUS_SESSION_COOKIE_RECEIVED = 45,
        BINDSTATUS_PERSISTENT_COOKIE_RECEIVED = 46,
        BINDSTATUS_SESSION_COOKIES_ALLOWED = 47,
        BINDSTATUS_CACHECONTROL = 48,
        BINDSTATUS_CONTENTDISPOSITIONFILENAME = 49,
        BINDSTATUS_MIMETEXTPLAINMISMATCH = 50,
        BINDSTATUS_PUBLISHERAVAILABLE = 51,
        BINDSTATUS_DISPLAYNAMEAVAILABLE = 52,
        BINDSTATUS_SSLUX_NAVBLOCKED = 53,
        BINDSTATUS_SERVER_MIMETYPEAVAILABLE = 54,
        BINDSTATUS_SNIFFED_CLASSIDAVAILABLE = 55,
        BINDSTATUS_64BIT_PROGRESS = 56,
        BINDSTATUS_LAST = 56,
        BINDSTATUS_RESERVED_0 = 57,
        BINDSTATUS_RESERVED_1 = 58,
        BINDSTATUS_RESERVED_2 = 59,
        BINDSTATUS_RESERVED_3 = 60,
        BINDSTATUS_RESERVED_4 = 61,
        BINDSTATUS_RESERVED_5 = 62,
        BINDSTATUS_RESERVED_6 = 63,
        BINDSTATUS_RESERVED_7 = 64,
        BINDSTATUS_RESERVED_8 = 65,
        BINDSTATUS_RESERVED_9 = 66,
        BINDSTATUS_RESERVED_A = 67,
        BINDSTATUS_RESERVED_B = 68,
        BINDSTATUS_RESERVED_C = 69,
        BINDSTATUS_RESERVED_D = 70,
        BINDSTATUS_RESERVED_E = 71,
        BINDSTATUS_LAST_PRIVATE = 71,
    };

    public enum __MIDL_IBindStatusCallbackEx_0001 : int
    {
        BINDF2_DISABLEBASICOVERHTTP = 1,
        BINDF2_DISABLEAUTOCOOKIEHANDLING = 2,
        BINDF2_READ_DATA_GREATER_THAN_4GB = 4,
        BINDF2_DISABLE_HTTP_REDIRECT_XSECURITYID = 8,
        BINDF2_SETDOWNLOADMODE = 32,
        BINDF2_DISABLE_HTTP_REDIRECT_CACHING = 64,
        BINDF2_KEEP_CALLBACK_MODULE_LOADED = 128,
        BINDF2_ALLOW_PROXY_CRED_PROMPT = 256,
        BINDF2_RESERVED_15 = 2048,
        BINDF2_RESERVED_14 = 4096,
        BINDF2_RESERVED_13 = 8192,
        BINDF2_RESERVED_12 = 16384,
        BINDF2_RESERVED_11 = 32768,
        BINDF2_RESERVED_10 = 65536,
        BINDF2_RESERVED_F = 131072,
        BINDF2_RESERVED_E = 262144,
        BINDF2_RESERVED_D = 524288,
        BINDF2_RESERVED_C = 1048576,
        BINDF2_RESERVED_B = 2097152,
        BINDF2_RESERVED_A = 4194304,
        BINDF2_RESERVED_9 = 8388608,
        BINDF2_RESERVED_8 = 16777216,
        BINDF2_RESERVED_7 = 33554432,
        BINDF2_RESERVED_6 = 67108864,
        BINDF2_RESERVED_5 = 134217728,
        BINDF2_RESERVED_4 = 268435456,
        BINDF2_RESERVED_3 = 536870912,
        BINDF2_RESERVED_2 = 1073741824,
        BINDF2_RESERVED_1 = -2147483648,
    };

    public enum __MIDL_IAuthenticateEx_0001 : int
    {
        AUTHENTICATEF_PROXY = 1,
        AUTHENTICATEF_BASIC = 2,
        AUTHENTICATEF_HTTP = 4,
    };

    public enum __MIDL_ICodeInstall_0001 : int
    {
        CIP_DISK_FULL = 0,
        CIP_ACCESS_DENIED = 1,
        CIP_NEWER_VERSION_EXISTS = 2,
        CIP_OLDER_VERSION_EXISTS = 3,
        CIP_NAME_CONFLICT = 4,
        CIP_TRUST_VERIFICATION_COMPONENT_MISSING = 5,
        CIP_EXE_SELF_REGISTERATION_TIMEOUT = 6,
        CIP_UNSAFE_TO_ABORT = 7,
        CIP_NEED_REBOOT = 8,
        CIP_NEED_REBOOT_UI_PERMISSION = 9,
    };

    public enum __MIDL_IUri_0002 : int
    {
        Uri_HOST_UNKNOWN = 0,
        Uri_HOST_DNS = 1,
        Uri_HOST_IPV4 = 2,
        Uri_HOST_IPV6 = 3,
        Uri_HOST_IDN = 4,
    };

    public enum tagBINDSTRING : int
    {
        BINDSTRING_HEADERS = 1,
        BINDSTRING_ACCEPT_MIMES = 2,
        BINDSTRING_EXTRA_URL = 3,
        BINDSTRING_LANGUAGE = 4,
        BINDSTRING_USERNAME = 5,
        BINDSTRING_PASSWORD = 6,
        BINDSTRING_UA_PIXELS = 7,
        BINDSTRING_UA_COLOR = 8,
        BINDSTRING_OS = 9,
        BINDSTRING_USER_AGENT = 10,
        BINDSTRING_ACCEPT_ENCODINGS = 11,
        BINDSTRING_POST_COOKIE = 12,
        BINDSTRING_POST_DATA_MIME = 13,
        BINDSTRING_URL = 14,
        BINDSTRING_IID = 15,
        BINDSTRING_FLAG_BIND_TO_OBJECT = 16,
        BINDSTRING_PTR_BIND_CONTEXT = 17,
        BINDSTRING_XDR_ORIGIN = 18,
        BINDSTRING_DOWNLOADPATH = 19,
        BINDSTRING_ROOTDOC_URL = 20,
        BINDSTRING_INITIAL_FILENAME = 21,
        BINDSTRING_PROXY_USERNAME = 22,
        BINDSTRING_PROXY_PASSWORD = 23,
    };

    public enum _tagPI_FLAGS : int
    {
        PI_PARSE_URL = 1,
        PI_FILTER_MODE = 2,
        PI_FORCE_ASYNC = 4,
        PI_USE_WORKERTHREAD = 8,
        PI_MIMEVERIFICATION = 16,
        PI_CLSIDLOOKUP = 32,
        PI_DATAPROGRESS = 64,
        PI_SYNCHRONOUS = 128,
        PI_APARTMENTTHREADED = 256,
        PI_CLASSINSTALL = 512,
        PI_PASSONBINDCTX = 8192,
        PI_NOMIMEHANDLER = 32768,
        PI_LOADAPPDIRECT = 16384,
        PD_FORCE_SWITCH = 65536,
        PI_PREFERDEFAULTHANDLER = 131072,
    };

    public enum _tagOIBDG_FLAGS : int
    {
        OIBDG_APARTMENTTHREADED = 256,
        OIBDG_DATAONLY = 4096,
    };

    public enum _tagPSUACTION : int
    {
        PSU_DEFAULT = 1,
        PSU_SECURITY_URL_ONLY = 2,
    };

    public enum _tagINTERNETFEATURELIST : int
    {
        FEATURE_OBJECT_CACHING = 0,
        FEATURE_ZONE_ELEVATION = 1,
        FEATURE_MIME_HANDLING = 2,
        FEATURE_MIME_SNIFFING = 3,
        FEATURE_WINDOW_RESTRICTIONS = 4,
        FEATURE_WEBOC_POPUPMANAGEMENT = 5,
        FEATURE_BEHAVIORS = 6,
        FEATURE_DISABLE_MK_PROTOCOL = 7,
        FEATURE_LOCALMACHINE_LOCKDOWN = 8,
        FEATURE_SECURITYBAND = 9,
        FEATURE_RESTRICT_ACTIVEXINSTALL = 10,
        FEATURE_VALIDATE_NAVIGATE_URL = 11,
        FEATURE_RESTRICT_FILEDOWNLOAD = 12,
        FEATURE_ADDON_MANAGEMENT = 13,
        FEATURE_PROTOCOL_LOCKDOWN = 14,
        FEATURE_HTTP_USERNAME_PASSWORD_DISABLE = 15,
        FEATURE_SAFE_BINDTOOBJECT = 16,
        FEATURE_UNC_SAVEDFILECHECK = 17,
        FEATURE_GET_URL_DOM_FILEPATH_UNENCODED = 18,
        FEATURE_TABBED_BROWSING = 19,
        FEATURE_SSLUX = 20,
        FEATURE_DISABLE_NAVIGATION_SOUNDS = 21,
        FEATURE_DISABLE_LEGACY_COMPRESSION = 22,
        FEATURE_FORCE_ADDR_AND_STATUS = 23,
        FEATURE_XMLHTTP = 24,
        FEATURE_DISABLE_TELNET_PROTOCOL = 25,
        FEATURE_FEEDS = 26,
        FEATURE_BLOCK_INPUT_PROMPTS = 27,
        FEATURE_ENTRY_COUNT = 28,
    };

    public enum __MIDL_IInternetSecurityManager_0001 : int
    {
        PUAF_DEFAULT = 0,
        PUAF_NOUI = 1,
        PUAF_ISFILE = 2,
        PUAF_WARN_IF_DENIED = 4,
        PUAF_FORCEUI_FOREGROUND = 8,
        PUAF_CHECK_TIFS = 16,
        PUAF_DONTCHECKBOXINDIALOG = 32,
        PUAF_TRUSTED = 64,
        PUAF_ACCEPT_WILDCARD_SCHEME = 128,
        PUAF_ENFORCERESTRICTED = 256,
        PUAF_NOSAVEDFILECHECK = 512,
        PUAF_REQUIRESAVEDFILECHECK = 1024,
        PUAF_DONT_USE_CACHE = 4096,
        PUAF_RESERVED1 = 8192,
        PUAF_RESERVED2 = 16384,
        PUAF_LMZ_UNLOCKED = 65536,
        PUAF_LMZ_LOCKED = 131072,
        PUAF_DEFAULTZONEPOL = 262144,
        PUAF_NPL_USE_LOCKED_IF_RESTRICTED = 524288,
        PUAF_NOUIIFLOCKED = 1048576,
        PUAF_DRAGPROTOCOLCHECK = 2097152,
    };

    public enum __MIDL_IInternetSecurityManager_0002 : int
    {
        PUAFOUT_DEFAULT = 0,
        PUAFOUT_ISLOCKZONEPOLICY = 1,
    };

    public enum __MIDL_IInternetSecurityManager_0003 : int
    {
        SZM_CREATE = 0,
        SZM_DELETE = 1,
    };

    public enum tagURLZONE : int
    {
        URLZONE_INVALID = -1,
        URLZONE_PREDEFINED_MIN = 0,
        URLZONE_LOCAL_MACHINE = 0,
        URLZONE_INTRANET = 1,
        URLZONE_TRUSTED = 2,
        URLZONE_INTERNET = 3,
        URLZONE_UNTRUSTED = 4,
        URLZONE_PREDEFINED_MAX = 999,
        URLZONE_USER_MIN = 1000,
        URLZONE_USER_MAX = 10000,
    };

    public enum tagURLTEMPLATE : int
    {
        URLTEMPLATE_CUSTOM = 0,
        URLTEMPLATE_PREDEFINED_MIN = 65536,
        URLTEMPLATE_LOW = 65536,
        URLTEMPLATE_MEDLOW = 66816,
        URLTEMPLATE_MEDIUM = 69632,
        URLTEMPLATE_MEDHIGH = 70912,
        URLTEMPLATE_HIGH = 73728,
        URLTEMPLATE_PREDEFINED_MAX = 131072,
    };

    public enum __MIDL_IInternetZoneManager_0001 : int
    {
        MAX_ZONE_PATH = 260,
        MAX_ZONE_DESCRIPTION = 200,
    };

    public enum __MIDL_IInternetZoneManager_0002 : int
    {
        ZAFLAGS_CUSTOM_EDIT = 1,
        ZAFLAGS_ADD_SITES = 2,
        ZAFLAGS_REQUIRE_VERIFICATION = 4,
        ZAFLAGS_INCLUDE_PROXY_OVERRIDE = 8,
        ZAFLAGS_INCLUDE_INTRANET_SITES = 16,
        ZAFLAGS_NO_UI = 32,
        ZAFLAGS_SUPPORTS_VERIFICATION = 64,
        ZAFLAGS_UNC_AS_INTRANET = 128,
        ZAFLAGS_DETECT_INTRANET = 256,
        ZAFLAGS_USE_LOCKED_ZONES = 65536,
        ZAFLAGS_VERIFY_TEMPLATE_SETTINGS = 131072,
        ZAFLAGS_NO_CACHE = 262144,
    };

    public enum PIDMSI_STATUS_VALUE : int
    {
        PIDMSI_STATUS_NORMAL = 0,
        PIDMSI_STATUS_NEW = 1,
        PIDMSI_STATUS_PRELIM = 2,
        PIDMSI_STATUS_DRAFT = 3,
        PIDMSI_STATUS_INPROGRESS = 4,
        PIDMSI_STATUS_EDIT = 5,
        PIDMSI_STATUS_REVIEW = 6,
        PIDMSI_STATUS_PROOF = 7,
        PIDMSI_STATUS_FINAL = 8,
        PIDMSI_STATUS_OTHER = 32767,
    };

    public enum tagREGKIND : int
    {
        REGKIND_DEFAULT,
        REGKIND_REGISTER,
        REGKIND_NONE,
    };

    public enum tagUASFLAGS : int
    {
        UAS_NORMAL = 0,
        UAS_BLOCKED = 1,
        UAS_NOPARENTENABLE = 2,
        UAS_MASK = 3,
    };

    public enum tagREADYSTATE : int
    {
        READYSTATE_UNINITIALIZED = 0,
        READYSTATE_LOADING = 1,
        READYSTATE_LOADED = 2,
        READYSTATE_INTERACTIVE = 3,
        READYSTATE_COMPLETE = 4,
    };

    public enum tagGUIDKIND : int
    {
        GUIDKIND_DEFAULT_SOURCE_DISP_IID = 1,
    };

    public enum tagCTRLINFO : int
    {
        CTRLINFO_EATS_RETURN = 1,
        CTRLINFO_EATS_ESCAPE = 2,
    };

    public enum tagXFORMCOORDS : int
    {
        XFORMCOORDS_POSITION = 1,
        XFORMCOORDS_SIZE = 2,
        XFORMCOORDS_HIMETRICTOCONTAINER = 4,
        XFORMCOORDS_CONTAINERTOHIMETRIC = 8,
        XFORMCOORDS_EVENTCOMPAT = 16,
    };

    public enum tagPROPPAGESTATUS : int
    {
        PROPPAGESTATUS_DIRTY = 1,
        PROPPAGESTATUS_VALIDATE = 2,
        PROPPAGESTATUS_CLEAN = 4,
    };

    public enum tagPictureAttributes : int
    {
        PICTURE_SCALABLE = 1,
        PICTURE_TRANSPARENT = 2,
    };

    public enum tagACTIVATEFLAGS : int
    {
        ACTIVATE_WINDOWLESS = 1,
    };

    public enum tagOLEDCFLAGS : int
    {
        OLEDC_NODRAW = 1,
        OLEDC_PAINTBKGND = 2,
        OLEDC_OFFSCREEN = 4,
    };

    public enum tagVIEWSTATUS : int
    {
        VIEWSTATUS_OPAQUE = 1,
        VIEWSTATUS_SOLIDBKGND = 2,
        VIEWSTATUS_DVASPECTOPAQUE = 4,
        VIEWSTATUS_DVASPECTTRANSPARENT = 8,
        VIEWSTATUS_SURFACE = 16,
        VIEWSTATUS_3DSURFACE = 32,
    };

    public enum tagHITRESULT : int
    {
        HITRESULT_OUTSIDE = 0,
        HITRESULT_TRANSPARENT = 1,
        HITRESULT_CLOSE = 2,
        HITRESULT_HIT = 3,
    };

    public enum tagDVASPECT2 : int
    {
        DVASPECT_OPAQUE = 16,
        DVASPECT_TRANSPARENT = 32,
    };

    public enum tagExtentMode : int
    {
        DVEXTENT_CONTENT = 0,
        DVEXTENT_INTEGRAL = 1,
    };

    public enum tagAspectInfoFlag : int
    {
        DVASPECTINFOFLAG_CANOPTIMIZE = 1,
    };

    public enum tagPOINTERINACTIVE : int
    {
        POINTERINACTIVE_ACTIVATEONENTRY = 1,
        POINTERINACTIVE_DEACTIVATEONLEAVE = 2,
        POINTERINACTIVE_ACTIVATEONDRAG = 4,
    };

    public enum tagPROPBAG2_TYPE : int
    {
        PROPBAG2_TYPE_UNDEFINED = 0,
        PROPBAG2_TYPE_DATA = 1,
        PROPBAG2_TYPE_URL = 2,
        PROPBAG2_TYPE_OBJECT = 3,
        PROPBAG2_TYPE_STREAM = 4,
        PROPBAG2_TYPE_STORAGE = 5,
        PROPBAG2_TYPE_MONIKER = 6,
    };

    public enum tagQACONTAINERFLAGS : int
    {
        QACONTAINER_SHOWHATCHING = 1,
        QACONTAINER_SHOWGRABHANDLES = 2,
        QACONTAINER_USERMODE = 4,
        QACONTAINER_DISPLAYASDEFAULT = 8,
        QACONTAINER_UIDEAD = 16,
        QACONTAINER_AUTOCLIP = 32,
        QACONTAINER_MESSAGEREFLECT = 64,
        QACONTAINER_SUPPORTSMNEMONICS = 128,
    };

    public enum OLE_TRISTATE : int
    {
        triUnchecked = 0,
        triChecked = 1,
        triGray = 2,
    };

    public enum _MULTIPLE_TRUSTEE_OPERATION : int
    {
        NO_MULTIPLE_TRUSTEE,
        TRUSTEE_IS_IMPERSONATE,
    };

    public enum _TRUSTEE_FORM : int
    {
        TRUSTEE_IS_SID,
        TRUSTEE_IS_NAME,
        TRUSTEE_BAD_FORM,
        TRUSTEE_IS_OBJECTS_AND_SID,
        TRUSTEE_IS_OBJECTS_AND_NAME,
    };

    public enum _TRUSTEE_TYPE : int
    {
        TRUSTEE_IS_UNKNOWN,
        TRUSTEE_IS_USER,
        TRUSTEE_IS_GROUP,
        TRUSTEE_IS_DOMAIN,
        TRUSTEE_IS_ALIAS,
        TRUSTEE_IS_WELL_KNOWN_GROUP,
        TRUSTEE_IS_DELETED,
        TRUSTEE_IS_INVALID,
        TRUSTEE_IS_COMPUTER,
    };

    public enum _ACCESS_MODE : int
    {
        NOT_USED_ACCESS = 0,
        GRANT_ACCESS,
        SET_ACCESS,
        DENY_ACCESS,
        REVOKE_ACCESS,
        SET_AUDIT_SUCCESS,
        SET_AUDIT_FAILURE,
    };

    public enum TX_MISC_CONSTANTS : int
    {
        MAX_TRAN_DESC = 40,
    };

    public enum ISOLATIONLEVEL : int
    {
        ISOLATIONLEVEL_UNSPECIFIED = -1,
        ISOLATIONLEVEL_CHAOS = 16,
        ISOLATIONLEVEL_READUNCOMMITTED = 256,
        ISOLATIONLEVEL_BROWSE = 256,
        ISOLATIONLEVEL_CURSORSTABILITY = 4096,
        ISOLATIONLEVEL_READCOMMITTED = 4096,
        ISOLATIONLEVEL_REPEATABLEREAD = 65536,
        ISOLATIONLEVEL_SERIALIZABLE = 1048576,
        ISOLATIONLEVEL_ISOLATED = 1048576,
    };

    public enum ISOFLAG : int
    {
        ISOFLAG_RETAIN_COMMIT_DC = 1,
        ISOFLAG_RETAIN_COMMIT = 2,
        ISOFLAG_RETAIN_COMMIT_NO = 3,
        ISOFLAG_RETAIN_ABORT_DC = 4,
        ISOFLAG_RETAIN_ABORT = 8,
        ISOFLAG_RETAIN_ABORT_NO = 12,
        ISOFLAG_RETAIN_DONTCARE = 5,
        ISOFLAG_RETAIN_BOTH = 10,
        ISOFLAG_RETAIN_NONE = 15,
        ISOFLAG_OPTIMISTIC = 16,
        ISOFLAG_READONLY = 32,
    };

    public enum XACTTC : int
    {
        XACTTC_NONE = 0,
        XACTTC_SYNC_PHASEONE = 1,
        XACTTC_SYNC_PHASETWO = 2,
        XACTTC_SYNC = 2,
        XACTTC_ASYNC_PHASEONE = 4,
        XACTTC_ASYNC = 4,
    };

    public enum XACTRM : int
    {
        XACTRM_OPTIMISTICLASTWINS = 1,
        XACTRM_NOREADONLYPREPARES = 2,
    };

    public enum XACTCONST : int
    {
        XACTCONST_TIMEOUTINFINITE = 0,
    };

    public enum XACTHEURISTIC : int
    {
        XACTHEURISTIC_ABORT = 1,
        XACTHEURISTIC_COMMIT = 2,
        XACTHEURISTIC_DAMAGE = 3,
        XACTHEURISTIC_DANGER = 4,
    };

    public enum XACTSTAT : int
    {
        XACTSTAT_NONE = 0,
        XACTSTAT_OPENNORMAL = 1,
        XACTSTAT_OPENREFUSED = 2,
        XACTSTAT_PREPARING = 4,
        XACTSTAT_PREPARED = 8,
        XACTSTAT_PREPARERETAINING = 16,
        XACTSTAT_PREPARERETAINED = 32,
        XACTSTAT_COMMITTING = 64,
        XACTSTAT_COMMITRETAINING = 128,
        XACTSTAT_ABORTING = 256,
        XACTSTAT_ABORTED = 512,
        XACTSTAT_COMMITTED = 1024,
        XACTSTAT_HEURISTIC_ABORT = 2048,
        XACTSTAT_HEURISTIC_COMMIT = 4096,
        XACTSTAT_HEURISTIC_DAMAGE = 8192,
        XACTSTAT_HEURISTIC_DANGER = 16384,
        XACTSTAT_FORCED_ABORT = 32768,
        XACTSTAT_FORCED_COMMIT = 65536,
        XACTSTAT_INDOUBT = 131072,
        XACTSTAT_CLOSED = 262144,
        XACTSTAT_OPEN = 3,
        XACTSTAT_NOTPREPARED = 524227,
        XACTSTAT_ALL = 524287,
    };

    public enum DBKINDENUM : int
    {
        DBKIND_GUID_NAME = 0,
        DBKIND_GUID_PROPID = 1,
        DBKIND_NAME = 2,
        DBKIND_PGUID_NAME = 3,
        DBKIND_PGUID_PROPID = 4,
        DBKIND_PROPID = 5,
        DBKIND_GUID = 6,
    };

    public enum DBTYPEENUM : int
    {
        DBTYPE_EMPTY = 0,
        DBTYPE_NULL = 1,
        DBTYPE_I2 = 2,
        DBTYPE_I4 = 3,
        DBTYPE_R4 = 4,
        DBTYPE_R8 = 5,
        DBTYPE_CY = 6,
        DBTYPE_DATE = 7,
        DBTYPE_BSTR = 8,
        DBTYPE_IDISPATCH = 9,
        DBTYPE_ERROR = 10,
        DBTYPE_BOOL = 11,
        DBTYPE_VARIANT = 12,
        DBTYPE_IUNKNOWN = 13,
        DBTYPE_DECIMAL = 14,
        DBTYPE_UI1 = 17,
        DBTYPE_ARRAY = 8192,
        DBTYPE_BYREF = 16384,
        DBTYPE_I1 = 16,
        DBTYPE_UI2 = 18,
        DBTYPE_UI4 = 19,
        DBTYPE_I8 = 20,
        DBTYPE_UI8 = 21,
        DBTYPE_GUID = 72,
        DBTYPE_VECTOR = 4096,
        DBTYPE_RESERVED = 32768,
        DBTYPE_BYTES = 128,
        DBTYPE_STR = 129,
        DBTYPE_WSTR = 130,
        DBTYPE_NUMERIC = 131,
        DBTYPE_UDT = 132,
        DBTYPE_DBDATE = 133,
        DBTYPE_DBTIME = 134,
        DBTYPE_DBTIMESTAMP = 135,
    };

    public enum DBTYPEENUM15 : int
    {
        DBTYPE_HCHAPTER = 136,
    };

    public enum DBTYPEENUM20 : int
    {
        DBTYPE_FILETIME = 64,
        DBTYPE_PROPVARIANT = 138,
        DBTYPE_VARNUMERIC = 139,
    };

    public enum DBPARTENUM : int
    {
        DBPART_INVALID = 0,
        DBPART_VALUE = 1,
        DBPART_LENGTH = 2,
        DBPART_STATUS = 4,
    };

    public enum DBPARAMIOENUM : int
    {
        DBPARAMIO_NOTPARAM = 0,
        DBPARAMIO_INPUT = 1,
        DBPARAMIO_OUTPUT = 2,
    };

    public enum DBBINDFLAGENUM : int
    {
        DBBINDFLAG_HTML = 1,
    };

    public enum DBMEMOWNERENUM : int
    {
        DBMEMOWNER_CLIENTOWNED = 0,
        DBMEMOWNER_PROVIDEROWNED = 1,
    };

    public enum DBSTATUSENUM : int
    {
        DBSTATUS_S_OK = 0,
        DBSTATUS_E_BADACCESSOR = 1,
        DBSTATUS_E_CANTCONVERTVALUE = 2,
        DBSTATUS_S_ISNULL = 3,
        DBSTATUS_S_TRUNCATED = 4,
        DBSTATUS_E_SIGNMISMATCH = 5,
        DBSTATUS_E_DATAOVERFLOW = 6,
        DBSTATUS_E_CANTCREATE = 7,
        DBSTATUS_E_UNAVAILABLE = 8,
        DBSTATUS_E_PERMISSIONDENIED = 9,
        DBSTATUS_E_INTEGRITYVIOLATION = 10,
        DBSTATUS_E_SCHEMAVIOLATION = 11,
        DBSTATUS_E_BADSTATUS = 12,
        DBSTATUS_S_DEFAULT = 13,
    };

    public enum DBSTATUSENUM20 : int
    {
        MDSTATUS_S_CELLEMPTY = 14,
        DBSTATUS_S_IGNORE = 15,
    };

    public enum DBSTATUSENUM21 : int
    {
        DBSTATUS_E_DOESNOTEXIST = 16,
        DBSTATUS_E_INVALIDURL = 17,
        DBSTATUS_E_RESOURCELOCKED = 18,
        DBSTATUS_E_RESOURCEEXISTS = 19,
        DBSTATUS_E_CANNOTCOMPLETE = 20,
        DBSTATUS_E_VOLUMENOTFOUND = 21,
        DBSTATUS_E_OUTOFSPACE = 22,
        DBSTATUS_S_CANNOTDELETESOURCE = 23,
        DBSTATUS_E_READONLY = 24,
        DBSTATUS_E_RESOURCEOUTOFSCOPE = 25,
        DBSTATUS_S_ALREADYEXISTS = 26,
    };

    public enum DBBINDURLFLAGENUM : int
    {
        DBBINDURLFLAG_READ = 1,
        DBBINDURLFLAG_WRITE = 2,
        DBBINDURLFLAG_READWRITE = 3,
        DBBINDURLFLAG_SHARE_DENY_READ = 4,
        DBBINDURLFLAG_SHARE_DENY_WRITE = 8,
        DBBINDURLFLAG_SHARE_EXCLUSIVE = 12,
        DBBINDURLFLAG_SHARE_DENY_NONE = 16,
        DBBINDURLFLAG_ASYNCHRONOUS = 4096,
        DBBINDURLFLAG_COLLECTION = 8192,
        DBBINDURLFLAG_DELAYFETCHSTREAM = 16384,
        DBBINDURLFLAG_DELAYFETCHCOLUMNS = 32768,
        DBBINDURLFLAG_RECURSIVE = 4194304,
        DBBINDURLFLAG_OUTPUT = 8388608,
        DBBINDURLFLAG_WAITFORINIT = 16777216,
        DBBINDURLFLAG_OPENIFEXISTS = 33554432,
        DBBINDURLFLAG_OVERWRITE = 67108864,
        DBBINDURLFLAG_ISSTRUCTUREDDOCUMENT = 134217728,
    };

    public enum DBBINDURLSTATUSENUM : int
    {
        DBBINDURLSTATUS_S_OK = 0,
        DBBINDURLSTATUS_S_DENYNOTSUPPORTED = 1,
        DBBINDURLSTATUS_S_DENYTYPENOTSUPPORTED = 4,
        DBBINDURLSTATUS_S_REDIRECTED = 8,
    };

    public enum DBSTATUSENUM25 : int
    {
        DBSTATUS_E_CANCELED = 27,
        DBSTATUS_E_NOTCOLLECTION = 28,
    };

    public enum DBROWSTATUSENUM : int
    {
        DBROWSTATUS_S_OK = 0,
        DBROWSTATUS_S_MULTIPLECHANGES = 2,
        DBROWSTATUS_S_PENDINGCHANGES = 3,
        DBROWSTATUS_E_CANCELED = 4,
        DBROWSTATUS_E_CANTRELEASE = 6,
        DBROWSTATUS_E_CONCURRENCYVIOLATION = 7,
        DBROWSTATUS_E_DELETED = 8,
        DBROWSTATUS_E_PENDINGINSERT = 9,
        DBROWSTATUS_E_NEWLYINSERTED = 10,
        DBROWSTATUS_E_INTEGRITYVIOLATION = 11,
        DBROWSTATUS_E_INVALID = 12,
        DBROWSTATUS_E_MAXPENDCHANGESEXCEEDED = 13,
        DBROWSTATUS_E_OBJECTOPEN = 14,
        DBROWSTATUS_E_OUTOFMEMORY = 15,
        DBROWSTATUS_E_PERMISSIONDENIED = 16,
        DBROWSTATUS_E_LIMITREACHED = 17,
        DBROWSTATUS_E_SCHEMAVIOLATION = 18,
        DBROWSTATUS_E_FAIL = 19,
    };

    public enum DBROWSTATUSENUM20 : int
    {
        DBROWSTATUS_S_NOCHANGE = 20,
    };

    public enum DBSTATUSENUM26 : int
    {
        DBSTATUS_S_ROWSETCOLUMN = 29,
    };

    public enum DBCOLUMNFLAGSENUM : int
    {
        DBCOLUMNFLAGS_ISBOOKMARK = 1,
        DBCOLUMNFLAGS_MAYDEFER = 2,
        DBCOLUMNFLAGS_WRITE = 4,
        DBCOLUMNFLAGS_WRITEUNKNOWN = 8,
        DBCOLUMNFLAGS_ISFIXEDLENGTH = 16,
        DBCOLUMNFLAGS_ISNULLABLE = 32,
        DBCOLUMNFLAGS_MAYBENULL = 64,
        DBCOLUMNFLAGS_ISLONG = 128,
        DBCOLUMNFLAGS_ISROWID = 256,
        DBCOLUMNFLAGS_ISROWVER = 512,
        DBCOLUMNFLAGS_CACHEDEFERRED = 4096,
    };

    public enum DBCOLUMNFLAGSENUM20 : int
    {
        DBCOLUMNFLAGS_SCALEISNEGATIVE = 16384,
        DBCOLUMNFLAGS_RESERVED = 32768,
    };

    public enum DBCOLUMNFLAGS15ENUM : int
    {
        DBCOLUMNFLAGS_ISCHAPTER = 8192,
    };

    public enum DBCOLUMNFLAGSENUM21 : int
    {
        DBCOLUMNFLAGS_ISROWURL = 65536,
        DBCOLUMNFLAGS_ISDEFAULTSTREAM = 131072,
        DBCOLUMNFLAGS_ISCOLLECTION = 262144,
    };

    public enum DBCOLUMNFLAGSENUM26 : int
    {
        DBCOLUMNFLAGS_ISSTREAM = 524288,
        DBCOLUMNFLAGS_ISROWSET = 1048576,
        DBCOLUMNFLAGS_ISROW = 2097152,
        DBCOLUMNFLAGS_ROWSPECIFICCOLUMN = 4194304,
    };

    public enum DBTABLESTATISTICSTYPE26 : int
    {
        DBSTAT_HISTOGRAM = 1,
        DBSTAT_COLUMN_CARDINALITY = 2,
        DBSTAT_TUPLE_CARDINALITY = 4,
    };

    public enum tagDBBOOKMARK : int
    {
        DBBMK_INVALID = 0,
        DBBMK_FIRST = 1,
        DBBMK_LAST = 2,
    };

    public enum DBPROPENUM : int
    {
        DBPROP_ABORTPRESERVE = 2,
        DBPROP_ACTIVESESSIONS = 3,
        DBPROP_APPENDONLY = 187,
        DBPROP_ASYNCTXNABORT = 168,
        DBPROP_ASYNCTXNCOMMIT = 4,
        DBPROP_AUTH_CACHE_AUTHINFO = 5,
        DBPROP_AUTH_ENCRYPT_PASSWORD = 6,
        DBPROP_AUTH_INTEGRATED = 7,
        DBPROP_AUTH_MASK_PASSWORD = 8,
        DBPROP_AUTH_PASSWORD = 9,
        DBPROP_AUTH_PERSIST_ENCRYPTED = 10,
        DBPROP_AUTH_PERSIST_SENSITIVE_AUTHINFO = 11,
        DBPROP_AUTH_USERID = 12,
        DBPROP_BLOCKINGSTORAGEOBJECTS = 13,
        DBPROP_BOOKMARKS = 14,
        DBPROP_BOOKMARKSKIPPED = 15,
        DBPROP_BOOKMARKTYPE = 16,
        DBPROP_BYREFACCESSORS = 120,
        DBPROP_CACHEDEFERRED = 17,
        DBPROP_CANFETCHBACKWARDS = 18,
        DBPROP_CANHOLDROWS = 19,
        DBPROP_CANSCROLLBACKWARDS = 21,
        DBPROP_CATALOGLOCATION = 22,
        DBPROP_CATALOGTERM = 23,
        DBPROP_CATALOGUSAGE = 24,
        DBPROP_CHANGEINSERTEDROWS = 188,
        DBPROP_COL_AUTOINCREMENT = 26,
        DBPROP_COL_DEFAULT = 27,
        DBPROP_COL_DESCRIPTION = 28,
        DBPROP_COL_FIXEDLENGTH = 167,
        DBPROP_COL_NULLABLE = 29,
        DBPROP_COL_PRIMARYKEY = 30,
        DBPROP_COL_UNIQUE = 31,
        DBPROP_COLUMNDEFINITION = 32,
        DBPROP_COLUMNRESTRICT = 33,
        DBPROP_COMMANDTIMEOUT = 34,
        DBPROP_COMMITPRESERVE = 35,
        DBPROP_CONCATNULLBEHAVIOR = 36,
        DBPROP_CURRENTCATALOG = 37,
        DBPROP_DATASOURCENAME = 38,
        DBPROP_DATASOURCEREADONLY = 39,
        DBPROP_DBMSNAME = 40,
        DBPROP_DBMSVER = 41,
        DBPROP_DEFERRED = 42,
        DBPROP_DELAYSTORAGEOBJECTS = 43,
        DBPROP_DSOTHREADMODEL = 169,
        DBPROP_GROUPBY = 44,
        DBPROP_HETEROGENEOUSTABLES = 45,
        DBPROP_IAccessor = 121,
        DBPROP_IColumnsInfo = 122,
        DBPROP_IColumnsRowset = 123,
        DBPROP_IConnectionPointContainer = 124,
        DBPROP_IConvertType = 194,
        DBPROP_IRowset = 126,
        DBPROP_IRowsetChange = 127,
        DBPROP_IRowsetIdentity = 128,
        DBPROP_IRowsetIndex = 159,
        DBPROP_IRowsetInfo = 129,
        DBPROP_IRowsetLocate = 130,
        DBPROP_IRowsetResynch = 132,
        DBPROP_IRowsetScroll = 133,
        DBPROP_IRowsetUpdate = 134,
        DBPROP_ISupportErrorInfo = 135,
        DBPROP_ILockBytes = 136,
        DBPROP_ISequentialStream = 137,
        DBPROP_IStorage = 138,
        DBPROP_IStream = 139,
        DBPROP_IDENTIFIERCASE = 46,
        DBPROP_IMMOBILEROWS = 47,
        DBPROP_INDEX_AUTOUPDATE = 48,
        DBPROP_INDEX_CLUSTERED = 49,
        DBPROP_INDEX_FILLFACTOR = 50,
        DBPROP_INDEX_INITIALSIZE = 51,
        DBPROP_INDEX_NULLCOLLATION = 52,
        DBPROP_INDEX_NULLS = 53,
        DBPROP_INDEX_PRIMARYKEY = 54,
        DBPROP_INDEX_SORTBOOKMARKS = 55,
        DBPROP_INDEX_TEMPINDEX = 163,
        DBPROP_INDEX_TYPE = 56,
        DBPROP_INDEX_UNIQUE = 57,
        DBPROP_INIT_DATASOURCE = 59,
        DBPROP_INIT_HWND = 60,
        DBPROP_INIT_IMPERSONATION_LEVEL = 61,
        DBPROP_INIT_LCID = 186,
        DBPROP_INIT_LOCATION = 62,
        DBPROP_INIT_MODE = 63,
        DBPROP_INIT_PROMPT = 64,
        DBPROP_INIT_PROTECTION_LEVEL = 65,
        DBPROP_INIT_PROVIDERSTRING = 160,
        DBPROP_INIT_TIMEOUT = 66,
        DBPROP_LITERALBOOKMARKS = 67,
        DBPROP_LITERALIDENTITY = 68,
        DBPROP_MAXINDEXSIZE = 70,
        DBPROP_MAXOPENROWS = 71,
        DBPROP_MAXPENDINGROWS = 72,
        DBPROP_MAXROWS = 73,
        DBPROP_MAXROWSIZE = 74,
        DBPROP_MAXROWSIZEINCLUDESBLOB = 75,
        DBPROP_MAXTABLESINSELECT = 76,
        DBPROP_MAYWRITECOLUMN = 77,
        DBPROP_MEMORYUSAGE = 78,
        DBPROP_MULTIPLEPARAMSETS = 191,
        DBPROP_MULTIPLERESULTS = 196,
        DBPROP_MULTIPLESTORAGEOBJECTS = 80,
        DBPROP_MULTITABLEUPDATE = 81,
        DBPROP_NOTIFICATIONGRANULARITY = 198,
        DBPROP_NOTIFICATIONPHASES = 82,
        DBPROP_NOTIFYCOLUMNSET = 171,
        DBPROP_NOTIFYROWDELETE = 173,
        DBPROP_NOTIFYROWFIRSTCHANGE = 174,
        DBPROP_NOTIFYROWINSERT = 175,
        DBPROP_NOTIFYROWRESYNCH = 177,
        DBPROP_NOTIFYROWSETCHANGED = 211,
        DBPROP_NOTIFYROWSETRELEASE = 178,
        DBPROP_NOTIFYROWSETFETCHPOSITIONCHANGE = 179,
        DBPROP_NOTIFYROWUNDOCHANGE = 180,
        DBPROP_NOTIFYROWUNDODELETE = 181,
        DBPROP_NOTIFYROWUNDOINSERT = 182,
        DBPROP_NOTIFYROWUPDATE = 183,
        DBPROP_NULLCOLLATION = 83,
        DBPROP_OLEOBJECTS = 84,
        DBPROP_ORDERBYCOLUMNSINSELECT = 85,
        DBPROP_ORDEREDBOOKMARKS = 86,
        DBPROP_OTHERINSERT = 87,
        DBPROP_OTHERUPDATEDELETE = 88,
        DBPROP_OUTPUTPARAMETERAVAILABILITY = 184,
        DBPROP_OWNINSERT = 89,
        DBPROP_OWNUPDATEDELETE = 90,
        DBPROP_PERSISTENTIDTYPE = 185,
        DBPROP_PREPAREABORTBEHAVIOR = 91,
        DBPROP_PREPARECOMMITBEHAVIOR = 92,
        DBPROP_PROCEDURETERM = 93,
        DBPROP_PROVIDERNAME = 96,
        DBPROP_PROVIDEROLEDBVER = 97,
        DBPROP_PROVIDERVER = 98,
        DBPROP_QUICKRESTART = 99,
        DBPROP_QUOTEDIDENTIFIERCASE = 100,
        DBPROP_REENTRANTEVENTS = 101,
        DBPROP_REMOVEDELETED = 102,
        DBPROP_REPORTMULTIPLECHANGES = 103,
        DBPROP_RETURNPENDINGINSERTS = 189,
        DBPROP_ROWRESTRICT = 104,
        DBPROP_ROWSETCONVERSIONSONCOMMAND = 192,
        DBPROP_ROWTHREADMODEL = 105,
        DBPROP_SCHEMATERM = 106,
        DBPROP_SCHEMAUSAGE = 107,
        DBPROP_SERVERCURSOR = 108,
        DBPROP_SESS_AUTOCOMMITISOLEVELS = 190,
        DBPROP_SQLSUPPORT = 109,
        DBPROP_STRONGIDENTITY = 119,
        DBPROP_STRUCTUREDSTORAGE = 111,
        DBPROP_SUBQUERIES = 112,
        DBPROP_SUPPORTEDTXNDDL = 161,
        DBPROP_SUPPORTEDTXNISOLEVELS = 113,
        DBPROP_SUPPORTEDTXNISORETAIN = 114,
        DBPROP_TABLETERM = 115,
        DBPROP_TBL_TEMPTABLE = 140,
        DBPROP_TRANSACTEDOBJECT = 116,
        DBPROP_UPDATABILITY = 117,
        DBPROP_USERNAME = 118,
    };

    public enum DBPROPENUM15 : int
    {
        DBPROP_FILTERCOMPAREOPS = 209,
        DBPROP_FINDCOMPAREOPS = 210,
        DBPROP_IChapteredRowset = 202,
        DBPROP_IDBAsynchStatus = 203,
        DBPROP_IRowsetFind = 204,
        DBPROP_IRowsetView = 212,
        DBPROP_IViewChapter = 213,
        DBPROP_IViewFilter = 214,
        DBPROP_IViewRowset = 215,
        DBPROP_IViewSort = 216,
        DBPROP_INIT_ASYNCH = 200,
        DBPROP_MAXOPENCHAPTERS = 199,
        DBPROP_MAXORSINFILTER = 205,
        DBPROP_MAXSORTCOLUMNS = 206,
        DBPROP_ROWSET_ASYNCH = 201,
        DBPROP_SORTONINDEX = 207,
    };

    public enum DBPROPENUM20 : int
    {
        DBPROP_IMultipleResults = 217,
        DBPROP_DATASOURCE_TYPE = 251,
        MDPROP_AXES = 252,
        MDPROP_FLATTENING_SUPPORT = 253,
        MDPROP_MDX_JOINCUBES = 254,
        MDPROP_NAMED_LEVELS = 255,
        MDPROP_RANGEROWSET = 256,
        MDPROP_MDX_SLICER = 218,
        MDPROP_MDX_CUBEQUALIFICATION = 219,
        MDPROP_MDX_OUTERREFERENCE = 220,
        MDPROP_MDX_QUERYBYPROPERTY = 221,
        MDPROP_MDX_CASESUPPORT = 222,
        MDPROP_MDX_STRING_COMPOP = 224,
        MDPROP_MDX_DESCFLAGS = 225,
        MDPROP_MDX_SET_FUNCTIONS = 226,
        MDPROP_MDX_MEMBER_FUNCTIONS = 227,
        MDPROP_MDX_NUMERIC_FUNCTIONS = 228,
        MDPROP_MDX_FORMULAS = 229,
        MDPROP_AGGREGATECELL_UPDATE = 230,
        MDPROP_MDX_AGGREGATECELL_UPDATE = 230,
        MDPROP_MDX_OBJQUALIFICATION = 261,
        MDPROP_MDX_NONMEASURE_EXPRESSIONS = 262,
        DBPROP_ACCESSORDER = 231,
        DBPROP_BOOKMARKINFO = 232,
        DBPROP_INIT_CATALOG = 233,
        DBPROP_ROW_BULKOPS = 234,
        DBPROP_PROVIDERFRIENDLYNAME = 235,
        DBPROP_LOCKMODE = 236,
        DBPROP_MULTIPLECONNECTIONS = 237,
        DBPROP_UNIQUEROWS = 238,
        DBPROP_SERVERDATAONINSERT = 239,
        DBPROP_STORAGEFLAGS = 240,
        DBPROP_CONNECTIONSTATUS = 244,
        DBPROP_ALTERCOLUMN = 245,
        DBPROP_COLUMNLCID = 246,
        DBPROP_RESETDATASOURCE = 247,
        DBPROP_INIT_OLEDBSERVICES = 248,
        DBPROP_IRowsetRefresh = 249,
        DBPROP_SERVERNAME = 250,
        DBPROP_IParentRowset = 257,
        DBPROP_HIDDENCOLUMNS = 258,
        DBPROP_PROVIDERMEMORY = 259,
        DBPROP_CLIENTCURSOR = 260,
    };

    public enum DBPROPENUM21 : int
    {
        DBPROP_TRUSTEE_USERNAME = 241,
        DBPROP_TRUSTEE_AUTHENTICATION = 242,
        DBPROP_TRUSTEE_NEWAUTHENTICATION = 243,
        DBPROP_IRow = 263,
        DBPROP_IRowChange = 264,
        DBPROP_IRowSchemaChange = 265,
        DBPROP_IGetRow = 266,
        DBPROP_IScopedOperations = 267,
        DBPROP_IBindResource = 268,
        DBPROP_ICreateRow = 269,
        DBPROP_INIT_BINDFLAGS = 270,
        DBPROP_INIT_LOCKOWNER = 271,
        DBPROP_GENERATEURL = 273,
        DBPROP_IDBBinderProperties = 274,
        DBPROP_IColumnsInfo2 = 275,
        DBPROP_IRegisterProvider = 276,
        DBPROP_IGetSession = 277,
        DBPROP_IGetSourceRow = 278,
        DBPROP_IRowsetCurrentIndex = 279,
        DBPROP_OPENROWSETSUPPORT = 280,
        DBPROP_COL_ISLONG = 281,
    };

    public enum DBPROPENUM25 : int
    {
        DBPROP_COL_SEED = 282,
        DBPROP_COL_INCREMENT = 283,
        DBPROP_INIT_GENERALTIMEOUT = 284,
        DBPROP_COMSERVICES = 285,
    };

    public enum DBPROPENUM26 : int
    {
        DBPROP_OUTPUTSTREAM = 286,
        DBPROP_OUTPUTENCODING = 287,
        DBPROP_TABLESTATISTICS = 288,
        DBPROP_SKIPROWCOUNTRESULTS = 291,
        DBPROP_IRowsetBookmark = 292,
        MDPROP_VISUALMODE = 293,
    };

    public enum DBPARAMFLAGSENUM : int
    {
        DBPARAMFLAGS_ISINPUT = 1,
        DBPARAMFLAGS_ISOUTPUT = 2,
        DBPARAMFLAGS_ISSIGNED = 16,
        DBPARAMFLAGS_ISNULLABLE = 64,
        DBPARAMFLAGS_ISLONG = 128,
    };

    public enum DBPARAMFLAGSENUM20 : int
    {
        DBPARAMFLAGS_SCALEISNEGATIVE = 256,
    };

    public enum DBPROPFLAGSENUM : int
    {
        DBPROPFLAGS_NOTSUPPORTED = 0,
        DBPROPFLAGS_COLUMN = 1,
        DBPROPFLAGS_DATASOURCE = 2,
        DBPROPFLAGS_DATASOURCECREATE = 4,
        DBPROPFLAGS_DATASOURCEINFO = 8,
        DBPROPFLAGS_DBINIT = 16,
        DBPROPFLAGS_INDEX = 32,
        DBPROPFLAGS_ROWSET = 64,
        DBPROPFLAGS_TABLE = 128,
        DBPROPFLAGS_COLUMNOK = 256,
        DBPROPFLAGS_READ = 512,
        DBPROPFLAGS_WRITE = 1024,
        DBPROPFLAGS_REQUIRED = 2048,
        DBPROPFLAGS_SESSION = 4096,
    };

    public enum DBPROPFLAGSENUM21 : int
    {
        DBPROPFLAGS_TRUSTEE = 8192,
    };

    public enum DBPROPFLAGSENUM25 : int
    {
        DBPROPFLAGS_VIEW = 16384,
    };

    public enum DBPROPFLAGSENUM26 : int
    {
        DBPROPFLAGS_STREAM = 32768,
    };

    public enum DBPROPOPTIONSENUM : int
    {
        DBPROPOPTIONS_REQUIRED = 0,
        DBPROPOPTIONS_SETIFCHEAP = 1,
        DBPROPOPTIONS_OPTIONAL = 1,
    };

    public enum DBPROPSTATUSENUM : int
    {
        DBPROPSTATUS_OK = 0,
        DBPROPSTATUS_NOTSUPPORTED = 1,
        DBPROPSTATUS_BADVALUE = 2,
        DBPROPSTATUS_BADOPTION = 3,
        DBPROPSTATUS_BADCOLUMN = 4,
        DBPROPSTATUS_NOTALLSETTABLE = 5,
        DBPROPSTATUS_NOTSETTABLE = 6,
        DBPROPSTATUS_NOTSET = 7,
        DBPROPSTATUS_CONFLICTING = 8,
    };

    public enum DBPROPSTATUSENUM21 : int
    {
        DBPROPSTATUS_NOTAVAILABLE = 9,
    };

    public enum DBINDEX_COL_ORDERENUM : int
    {
        DBINDEX_COL_ORDER_ASC = 0,
        DBINDEX_COL_ORDER_DESC = 1,
    };

    public enum DBCOLUMNDESCFLAGSENUM : int
    {
        DBCOLUMNDESCFLAGS_TYPENAME = 1,
        DBCOLUMNDESCFLAGS_ITYPEINFO = 2,
        DBCOLUMNDESCFLAGS_PROPERTIES = 4,
        DBCOLUMNDESCFLAGS_CLSID = 8,
        DBCOLUMNDESCFLAGS_COLSIZE = 16,
        DBCOLUMNDESCFLAGS_DBCID = 32,
        DBCOLUMNDESCFLAGS_WTYPE = 64,
        DBCOLUMNDESCFLAGS_PRECISION = 128,
        DBCOLUMNDESCFLAGS_SCALE = 256,
    };

    public enum DBEVENTPHASEENUM : int
    {
        DBEVENTPHASE_OKTODO = 0,
        DBEVENTPHASE_ABOUTTODO = 1,
        DBEVENTPHASE_SYNCHAFTER = 2,
        DBEVENTPHASE_FAILEDTODO = 3,
        DBEVENTPHASE_DIDEVENT = 4,
    };

    public enum DBREASONENUM : int
    {
        DBREASON_ROWSET_FETCHPOSITIONCHANGE = 0,
        DBREASON_ROWSET_RELEASE = 1,
        DBREASON_COLUMN_SET = 2,
        DBREASON_COLUMN_RECALCULATED = 3,
        DBREASON_ROW_ACTIVATE = 4,
        DBREASON_ROW_RELEASE = 5,
        DBREASON_ROW_DELETE = 6,
        DBREASON_ROW_FIRSTCHANGE = 7,
        DBREASON_ROW_INSERT = 8,
        DBREASON_ROW_RESYNCH = 9,
        DBREASON_ROW_UNDOCHANGE = 10,
        DBREASON_ROW_UNDOINSERT = 11,
        DBREASON_ROW_UNDODELETE = 12,
        DBREASON_ROW_UPDATE = 13,
        DBREASON_ROWSET_CHANGED = 14,
    };

    public enum DBREASONENUM15 : int
    {
        DBREASON_ROWPOSITION_CHANGED = 15,
        DBREASON_ROWPOSITION_CHAPTERCHANGED = 16,
        DBREASON_ROWPOSITION_CLEARED = 17,
        DBREASON_ROW_ASYNCHINSERT = 18,
    };

    public enum DBCOMPAREOPSENUM : int
    {
        DBCOMPAREOPS_LT = 0,
        DBCOMPAREOPS_LE = 1,
        DBCOMPAREOPS_EQ = 2,
        DBCOMPAREOPS_GE = 3,
        DBCOMPAREOPS_GT = 4,
        DBCOMPAREOPS_BEGINSWITH = 5,
        DBCOMPAREOPS_CONTAINS = 6,
        DBCOMPAREOPS_NE = 7,
        DBCOMPAREOPS_IGNORE = 8,
        DBCOMPAREOPS_CASESENSITIVE = 4096,
        DBCOMPAREOPS_CASEINSENSITIVE = 8192,
    };

    public enum DBCOMPAREOPSENUM20 : int
    {
        DBCOMPAREOPS_NOTBEGINSWITH = 9,
        DBCOMPAREOPS_NOTCONTAINS = 10,
    };

    public enum DBASYNCHOPENUM : int
    {
        DBASYNCHOP_OPEN = 0,
    };

    public enum DBASYNCHPHASEENUM : int
    {
        DBASYNCHPHASE_INITIALIZATION = 0,
        DBASYNCHPHASE_POPULATION = 1,
        DBASYNCHPHASE_COMPLETE = 2,
        DBASYNCHPHASE_CANCELED = 3,
    };

    public enum DBSORTENUM : int
    {
        DBSORT_ASCENDING = 0,
        DBSORT_DESCENDING = 1,
    };

    public enum DBCOMMANDPERSISTFLAGENUM : int
    {
        DBCOMMANDPERSISTFLAG_NOSAVE = 1,
    };

    public enum DBCOMMANDPERSISTFLAGENUM21 : int
    {
        DBCOMMANDPERSISTFLAG_DEFAULT = 0,
        DBCOMMANDPERSISTFLAG_PERSISTVIEW = 2,
        DBCOMMANDPERSISTFLAG_PERSISTPROCEDURE = 4,
    };

    public enum DBCONSTRAINTTYPEENUM : int
    {
        DBCONSTRAINTTYPE_UNIQUE = 0,
        DBCONSTRAINTTYPE_FOREIGNKEY = 1,
        DBCONSTRAINTTYPE_PRIMARYKEY = 2,
        DBCONSTRAINTTYPE_CHECK = 3,
    };

    public enum DBUPDELRULEENUM : int
    {
        DBUPDELRULE_NOACTION = 0,
        DBUPDELRULE_CASCADE = 1,
        DBUPDELRULE_SETNULL = 2,
        DBUPDELRULE_SETDEFAULT = 3,
    };

    public enum DBMATCHTYPEENUM : int
    {
        DBMATCHTYPE_FULL = 0,
        DBMATCHTYPE_NONE = 1,
        DBMATCHTYPE_PARTIAL = 2,
    };

    public enum DBDEFERRABILITYENUM : int
    {
        DBDEFERRABILITY_DEFERRED = 1,
        DBDEFERRABILITY_DEFERRABLE = 2,
    };

    public enum DBACCESSORFLAGSENUM : int
    {
        DBACCESSOR_INVALID = 0,
        DBACCESSOR_PASSBYREF = 1,
        DBACCESSOR_ROWDATA = 2,
        DBACCESSOR_PARAMETERDATA = 4,
        DBACCESSOR_OPTIMIZED = 8,
        DBACCESSOR_INHERITED = 16,
    };

    public enum DBBINDSTATUSENUM : int
    {
        DBBINDSTATUS_OK = 0,
        DBBINDSTATUS_BADORDINAL = 1,
        DBBINDSTATUS_UNSUPPORTEDCONVERSION = 2,
        DBBINDSTATUS_BADBINDINFO = 3,
        DBBINDSTATUS_BADSTORAGEFLAGS = 4,
        DBBINDSTATUS_NOINTERFACE = 5,
        DBBINDSTATUS_MULTIPLESTORAGE = 6,
    };

    public enum DBCOMPAREENUM : int
    {
        DBCOMPARE_LT = 0,
        DBCOMPARE_EQ = 1,
        DBCOMPARE_GT = 2,
        DBCOMPARE_NE = 3,
        DBCOMPARE_NOTCOMPARABLE = 4,
    };

    public enum DBPOSITIONFLAGSENUM : int
    {
        DBPOSITION_OK = 0,
        DBPOSITION_NOROW = 1,
        DBPOSITION_BOF = 2,
        DBPOSITION_EOF = 3,
    };

    public enum DBPENDINGSTATUSENUM : int
    {
        DBPENDINGSTATUS_NEW = 1,
        DBPENDINGSTATUS_CHANGED = 2,
        DBPENDINGSTATUS_DELETED = 4,
        DBPENDINGSTATUS_UNCHANGED = 8,
        DBPENDINGSTATUS_INVALIDROW = 16,
    };

    public enum DBSEEKENUM : int
    {
        DBSEEK_INVALID = 0,
        DBSEEK_FIRSTEQ = 1,
        DBSEEK_LASTEQ = 2,
        DBSEEK_AFTEREQ = 4,
        DBSEEK_AFTER = 8,
        DBSEEK_BEFOREEQ = 16,
        DBSEEK_BEFORE = 32,
    };

    public enum DBRANGEENUM : int
    {
        DBRANGE_INCLUSIVESTART = 0,
        DBRANGE_INCLUSIVEEND = 0,
        DBRANGE_EXCLUSIVESTART = 1,
        DBRANGE_EXCLUSIVEEND = 2,
        DBRANGE_EXCLUDENULLS = 4,
        DBRANGE_PREFIX = 8,
        DBRANGE_MATCH = 16,
    };

    public enum DBRANGEENUM20 : int
    {
        DBRANGE_MATCH_N_SHIFT = 24,
        DBRANGE_MATCH_N_MASK = 255,
    };

    public enum DBRESULTFLAGENUM : int
    {
        DBRESULTFLAG_DEFAULT = 0,
        DBRESULTFLAG_ROWSET = 1,
        DBRESULTFLAG_ROW = 2,
    };

    public enum DBCONVERTFLAGSENUM : int
    {
        DBCONVERTFLAGS_COLUMN = 0,
        DBCONVERTFLAGS_PARAMETER = 1,
    };

    public enum DBCONVERTFLAGSENUM20 : int
    {
        DBCONVERTFLAGS_ISLONG = 2,
        DBCONVERTFLAGS_ISFIXEDLENGTH = 4,
        DBCONVERTFLAGS_FROMVARIANT = 8,
    };

    public enum DBSOURCETYPEENUM : int
    {
        DBSOURCETYPE_DATASOURCE = 1,
        DBSOURCETYPE_ENUMERATOR = 2,
    };

    public enum DBSOURCETYPEENUM20 : int
    {
        DBSOURCETYPE_DATASOURCE_TDP = 1,
        DBSOURCETYPE_DATASOURCE_MDP = 3,
    };

    public enum DBSOURCETYPEENUM25 : int
    {
        DBSOURCETYPE_BINDER = 4,
    };

    public enum DBLITERALENUM : int
    {
        DBLITERAL_INVALID = 0,
        DBLITERAL_BINARY_LITERAL = 1,
        DBLITERAL_CATALOG_NAME = 2,
        DBLITERAL_CATALOG_SEPARATOR = 3,
        DBLITERAL_CHAR_LITERAL = 4,
        DBLITERAL_COLUMN_ALIAS = 5,
        DBLITERAL_COLUMN_NAME = 6,
        DBLITERAL_CORRELATION_NAME = 7,
        DBLITERAL_CURSOR_NAME = 8,
        DBLITERAL_ESCAPE_PERCENT = 9,
        DBLITERAL_ESCAPE_UNDERSCORE = 10,
        DBLITERAL_INDEX_NAME = 11,
        DBLITERAL_LIKE_PERCENT = 12,
        DBLITERAL_LIKE_UNDERSCORE = 13,
        DBLITERAL_PROCEDURE_NAME = 14,
        DBLITERAL_QUOTE = 15,
        DBLITERAL_SCHEMA_NAME = 16,
        DBLITERAL_TABLE_NAME = 17,
        DBLITERAL_TEXT_COMMAND = 18,
        DBLITERAL_USER_NAME = 19,
        DBLITERAL_VIEW_NAME = 20,
    };

    public enum DBLITERALENUM20 : int
    {
        DBLITERAL_CUBE_NAME = 21,
        DBLITERAL_DIMENSION_NAME = 22,
        DBLITERAL_HIERARCHY_NAME = 23,
        DBLITERAL_LEVEL_NAME = 24,
        DBLITERAL_MEMBER_NAME = 25,
        DBLITERAL_PROPERTY_NAME = 26,
        DBLITERAL_SCHEMA_SEPARATOR = 27,
        DBLITERAL_QUOTE_SUFFIX = 28,
    };

    public enum DBLITERALENUM21 : int
    {
        DBLITERAL_ESCAPE_PERCENT_SUFFIX = 29,
        DBLITERAL_ESCAPE_UNDERSCORE_SUFFIX = 30,
    };

    public enum _SE_OBJECT_TYPE : int
    {
        SE_UNKNOWN_OBJECT_TYPE = 0,
        SE_FILE_OBJECT,
        SE_SERVICE,
        SE_PRINTER,
        SE_REGISTRY_KEY,
        SE_LMSHARE,
        SE_KERNEL_OBJECT,
        SE_WINDOW_OBJECT,
        SE_DS_OBJECT,
        SE_DS_OBJECT_ALL,
        SE_PROVIDER_DEFINED_OBJECT,
        SE_WMIGUID_OBJECT,
        SE_REGISTRY_WOW64_32KEY,
    };

    public enum _PROGRESS_INVOKE_SETTING : int
    {
        ProgressInvokeNever = 1,
        ProgressInvokeEveryObject,
        ProgressInvokeOnError,
        ProgressCancelOperation,
        ProgressRetryOperation,
        ProgressInvokePrePostError,
    };

    public enum ACCESS_MASKENUM : int
    {
        PERM_EXCLUSIVE = 512,
        PERM_READDESIGN = 1024,
        PERM_WRITEDESIGN = 2048,
        PERM_WITHGRANT = 4096,
        PERM_REFERENCE = 8192,
        PERM_CREATE = 16384,
        PERM_INSERT = 32768,
        PERM_DELETE = 65536,
        PERM_READCONTROL = 131072,
        PERM_WRITEPERMISSIONS = 262144,
        PERM_WRITEOWNER = 524288,
        PERM_MAXIMUM_ALLOWED = 33554432,
        PERM_ALL = 268435456,
        PERM_EXECUTE = 536870912,
        PERM_READ = -2147483648,
        PERM_UPDATE = 1073741824,
        PERM_DROP = 256,
    };

    public enum DBCOPYFLAGSENUM : int
    {
        DBCOPY_ASYNC = 256,
        DBCOPY_REPLACE_EXISTING = 512,
        DBCOPY_ALLOW_EMULATION = 1024,
        DBCOPY_NON_RECURSIVE = 2048,
        DBCOPY_ATOMIC = 4096,
    };

    public enum DBMOVEFLAGSENUM : int
    {
        DBMOVE_REPLACE_EXISTING = 1,
        DBMOVE_ASYNC = 256,
        DBMOVE_DONT_UPDATE_LINKS = 512,
        DBMOVE_ALLOW_EMULATION = 1024,
        DBMOVE_ATOMIC = 4096,
    };

    public enum DBDELETEFLAGSENUM : int
    {
        DBDELETE_ASYNC = 256,
        DBDELETE_ATOMIC = 4096,
    };

    public enum AfxMemDF : int
    {
        allocMemDF = 1,
        delayFreeMemDF = 2,
        checkAlwaysMemDF = 4,
        checkEvery16MemDF = 1048576,
        checkEvery128MemDF = 8388608,
        checkEvery1024MemDF = 67108864,
        checkDefaultMemDF = 0,
    };

    public enum ASSOCCLASS : int
    {
        ASSOCCLASS_SHELL_KEY = 0,
        ASSOCCLASS_PROGID_KEY,
        ASSOCCLASS_PROGID_STR,
        ASSOCCLASS_CLSID_KEY,
        ASSOCCLASS_CLSID_STR,
        ASSOCCLASS_APP_KEY,
        ASSOCCLASS_APP_STR,
        ASSOCCLASS_SYSTEM_STR,
        ASSOCCLASS_FOLDER,
        ASSOCCLASS_STAR,
        ASSOCCLASS_FIXED_PROGID_STR,
        ASSOCCLASS_PROTOCOL_STR,
    };

    public enum QUERY_USER_NOTIFICATION_STATE : int
    {
        QUNS_NOT_PRESENT = 1,
        QUNS_BUSY = 2,
        QUNS_RUNNING_D3D_FULL_SCREEN = 3,
        QUNS_PRESENTATION_MODE = 4,
        QUNS_ACCEPTS_NOTIFICATIONS = 5,
        QUNS_QUIET_TIME = 6,
        QUNS_APP = 7,
    };

    public enum SHSTOCKICONID : int
    {
        SIID_DOCNOASSOC = 0,
        SIID_DOCASSOC = 1,
        SIID_APPLICATION = 2,
        SIID_FOLDER = 3,
        SIID_FOLDEROPEN = 4,
        SIID_DRIVE525 = 5,
        SIID_DRIVE35 = 6,
        SIID_DRIVEREMOVE = 7,
        SIID_DRIVEFIXED = 8,
        SIID_DRIVENET = 9,
        SIID_DRIVENETDISABLED = 10,
        SIID_DRIVECD = 11,
        SIID_DRIVERAM = 12,
        SIID_WORLD = 13,
        SIID_SERVER = 15,
        SIID_PRINTER = 16,
        SIID_MYNETWORK = 17,
        SIID_FIND = 22,
        SIID_HELP = 23,
        SIID_SHARE = 28,
        SIID_LINK = 29,
        SIID_SLOWFILE = 30,
        SIID_RECYCLER = 31,
        SIID_RECYCLERFULL = 32,
        SIID_MEDIACDAUDIO = 40,
        SIID_LOCK = 47,
        SIID_AUTOLIST = 49,
        SIID_PRINTERNET = 50,
        SIID_SERVERSHARE = 51,
        SIID_PRINTERFAX = 52,
        SIID_PRINTERFAXNET = 53,
        SIID_PRINTERFILE = 54,
        SIID_STACK = 55,
        SIID_MEDIASVCD = 56,
        SIID_STUFFEDFOLDER = 57,
        SIID_DRIVEUNKNOWN = 58,
        SIID_DRIVEDVD = 59,
        SIID_MEDIADVD = 60,
        SIID_MEDIADVDRAM = 61,
        SIID_MEDIADVDRW = 62,
        SIID_MEDIADVDR = 63,
        SIID_MEDIADVDROM = 64,
        SIID_MEDIACDAUDIOPLUS = 65,
        SIID_MEDIACDRW = 66,
        SIID_MEDIACDR = 67,
        SIID_MEDIACDBURN = 68,
        SIID_MEDIABLANKCD = 69,
        SIID_MEDIACDROM = 70,
        SIID_AUDIOFILES = 71,
        SIID_IMAGEFILES = 72,
        SIID_VIDEOFILES = 73,
        SIID_MIXEDFILES = 74,
        SIID_FOLDERBACK = 75,
        SIID_FOLDERFRONT = 76,
        SIID_SHIELD = 77,
        SIID_WARNING = 78,
        SIID_INFO = 79,
        SIID_ERROR = 80,
        SIID_KEY = 81,
        SIID_SOFTWARE = 82,
        SIID_RENAME = 83,
        SIID_DELETE = 84,
        SIID_MEDIAAUDIODVD = 85,
        SIID_MEDIAMOVIEDVD = 86,
        SIID_MEDIAENHANCEDCD = 87,
        SIID_MEDIAENHANCEDDVD = 88,
        SIID_MEDIAHDDVD = 89,
        SIID_MEDIABLURAY = 90,
        SIID_MEDIAVCD = 91,
        SIID_MEDIADVDPLUSR = 92,
        SIID_MEDIADVDPLUSRW = 93,
        SIID_DESKTOPPC = 94,
        SIID_MOBILEPC = 95,
        SIID_USERS = 96,
        SIID_MEDIASMARTMEDIA = 97,
        SIID_MEDIACOMPACTFLASH = 98,
        SIID_DEVICECELLPHONE = 99,
        SIID_DEVICECAMERA = 100,
        SIID_DEVICEVIDEOCAMERA = 101,
        SIID_DEVICEAUDIOPLAYER = 102,
        SIID_NETWORKCONNECT = 103,
        SIID_INTERNET = 104,
        SIID_ZIPFILE = 105,
        SIID_SETTINGS = 106,
        SIID_DRIVEHDDVD = 132,
        SIID_DRIVEBD = 133,
        SIID_MEDIAHDDVDROM = 134,
        SIID_MEDIAHDDVDR = 135,
        SIID_MEDIAHDDVDRAM = 136,
        SIID_MEDIABDROM = 137,
        SIID_MEDIABDR = 138,
        SIID_MEDIABDRE = 139,
        SIID_CLUSTEREDDRIVE = 140,
        SIID_MAX_ICONS = 175,
    };

    public enum NET_ADDRESS_FORMAT_ : int
    {
        NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
        NET_ADDRESS_DNS_NAME,
        NET_ADDRESS_IPV4,
        NET_ADDRESS_IPV6,
    };

    public enum MERGE_UPDATE_STATUS : int
    {
        MUS_COMPLETE = 0,
        MUS_USERINPUTNEEDED = 1,
        MUS_FAILED = 2,
    };

    public enum FOLDER_ENUM_MODE : int
    {
        FEM_VIEWRESULT = 0,
        FEM_NAVIGATION = 1,
    };

    public enum _SIGDN : int
    {
        SIGDN_NORMALDISPLAY = 0,
        SIGDN_PARENTRELATIVEPARSING = -2147385343,
        SIGDN_DESKTOPABSOLUTEPARSING = -2147319808,
        SIGDN_PARENTRELATIVEEDITING = -2147282943,
        SIGDN_DESKTOPABSOLUTEEDITING = -2147172352,
        SIGDN_FILESYSPATH = -2147123200,
        SIGDN_URL = -2147057664,
        SIGDN_PARENTRELATIVEFORADDRESSBAR = -2146975743,
        SIGDN_PARENTRELATIVE = -2146959359,
        SIGDN_PARENTRELATIVEFORUI = -2146877439,
    };

    public enum FOLDERVIEWOPTIONS : int
    {
        FVO_DEFAULT = 0,
        FVO_VISTALAYOUT = 1,
        FVO_CUSTOMPOSITION = 2,
        FVO_CUSTOMORDERING = 4,
        FVO_SUPPORTHYPERLINKS = 8,
        FVO_NOANIMATIONS = 16,
        FVO_NOSCROLLTIPS = 32,
    };

    public enum FOLDERFLAGS : int
    {
        FWF_NONE = 0,
        FWF_AUTOARRANGE = 1,
        FWF_ABBREVIATEDNAMES = 2,
        FWF_SNAPTOGRID = 4,
        FWF_OWNERDATA = 8,
        FWF_BESTFITWINDOW = 16,
        FWF_DESKTOP = 32,
        FWF_SINGLESEL = 64,
        FWF_NOSUBFOLDERS = 128,
        FWF_TRANSPARENT = 256,
        FWF_NOCLIENTEDGE = 512,
        FWF_NOSCROLL = 1024,
        FWF_ALIGNLEFT = 2048,
        FWF_NOICONS = 4096,
        FWF_SHOWSELALWAYS = 8192,
        FWF_NOVISIBLE = 16384,
        FWF_SINGLECLICKACTIVATE = 32768,
        FWF_NOWEBVIEW = 65536,
        FWF_HIDEFILENAMES = 131072,
        FWF_CHECKSELECT = 262144,
        FWF_NOENUMREFRESH = 524288,
        FWF_NOGROUPING = 1048576,
        FWF_FULLROWSELECT = 2097152,
        FWF_NOFILTERS = 4194304,
        FWF_NOCOLUMNHEADER = 8388608,
        FWF_NOHEADERINALLVIEWS = 16777216,
        FWF_EXTENDEDTILES = 33554432,
        FWF_TRICHECKSELECT = 67108864,
        FWF_AUTOCHECKSELECT = 134217728,
        FWF_NOBROWSERVIEWSTATE = 268435456,
        FWF_SUBSETGROUPS = 536870912,
        FWF_USESEARCHFOLDER = 1073741824,
        FWF_ALLOWRTLREADING = -2147483648,
    };

    public enum FOLDERVIEWMODE : int
    {
        FVM_AUTO = -1,
        FVM_FIRST = 1,
        FVM_ICON = 1,
        FVM_SMALLICON = 2,
        FVM_LIST = 3,
        FVM_DETAILS = 4,
        FVM_THUMBNAIL = 5,
        FVM_TILE = 6,
        FVM_THUMBSTRIP = 7,
        FVM_CONTENT = 8,
        FVM_LAST = 8,
    };

    public enum FVTEXTTYPE : int
    {
        FVST_EMPTYTEXT = 0,
    };

    public enum GETPROPERTYSTOREFLAGS : int
    {
        GPS_DEFAULT = 0,
        GPS_HANDLERPROPERTIESONLY = 1,
        GPS_READWRITE = 2,
        GPS_TEMPORARY = 4,
        GPS_FASTPROPERTIESONLY = 8,
        GPS_OPENSLOWITEM = 16,
        GPS_DELAYCREATION = 32,
        GPS_BESTEFFORT = 64,
        GPS_NO_OPLOCK = 128,
        GPS_PREFERQUERYPROPERTIES = 256,
        GPS_EXTRINSICPROPERTIES = 512,
        GPS_EXTRINSICPROPERTIESONLY = 1024,
        GPS_MASK_VALID = 2047,
    };

    public enum SIATTRIBFLAGS : int
    {
        SIATTRIBFLAGS_AND = 1,
        SIATTRIBFLAGS_OR = 2,
        SIATTRIBFLAGS_APPCOMPAT = 3,
        SIATTRIBFLAGS_MASK = 3,
        SIATTRIBFLAGS_ALLITEMS = 16384,
    };

    public enum FOLDERLOGICALVIEWMODE : int
    {
        FLVM_UNSPECIFIED = -1,
        FLVM_FIRST = 1,
        FLVM_DETAILS = 1,
        FLVM_TILES = 2,
        FLVM_ICONS = 3,
        FLVM_LIST = 4,
        FLVM_CONTENT = 5,
        FLVM_LAST = 5,
    };

    public enum VPWATERMARKFLAGS : int
    {
        VPWF_DEFAULT = 0,
        VPWF_ALPHABLEND = 1,
    };

    public enum VPCOLORFLAGS : int
    {
        VPCF_TEXT = 1,
        VPCF_BACKGROUND = 2,
        VPCF_SORTCOLUMN = 3,
        VPCF_SUBTEXT = 4,
        VPCF_TEXTBACKGROUND = 5,
    };

    public enum CM_ENUM_FLAGS : int
    {
        CM_ENUM_ALL = 1,
        CM_ENUM_VISIBLE = 2,
    };

    public enum CATEGORYINFO_FLAGS : int
    {
        CATINFO_NORMAL = 0,
        CATINFO_COLLAPSED = 1,
        CATINFO_HIDDEN = 2,
        CATINFO_EXPANDED = 4,
        CATINFO_NOHEADER = 8,
        CATINFO_NOTCOLLAPSIBLE = 16,
        CATINFO_NOHEADERCOUNT = 32,
        CATINFO_SUBSETTED = 64,
    };

    public enum CATSORT_FLAGS : int
    {
        CATSORT_DEFAULT = 0,
        CATSORT_NAME = 1,
    };

    public enum _SPACTION : int
    {
        SPACTION_NONE = 0,
        SPACTION_MOVING = 1,
        SPACTION_COPYING = 2,
        SPACTION_RECYCLING = 3,
        SPACTION_APPLYINGATTRIBS = 4,
        SPACTION_DOWNLOADING = 5,
        SPACTION_SEARCHING_INTERNET = 6,
        SPACTION_CALCULATING = 7,
        SPACTION_UPLOADING = 8,
        SPACTION_SEARCHING_FILES = 9,
        SPACTION_DELETING = 10,
        SPACTION_RENAMING = 11,
        SPACTION_FORMATTING = 12,
        SPACTION_COPY_MOVING = 13,
    };

    public enum _SPTEXT : int
    {
        SPTEXT_ACTIONDESCRIPTION = 1,
        SPTEXT_ACTIONDETAIL = 2,
    };

    public enum tagCONDITION_TYPE : int
    {
        CT_AND_CONDITION = 0,
        CT_OR_CONDITION = 1,
        CT_NOT_CONDITION = 2,
        CT_LEAF_CONDITION = 3,
    };

    public enum tagCONDITION_OPERATION : int
    {
        COP_IMPLICIT = 0,
        COP_EQUAL = 1,
        COP_NOTEQUAL = 2,
        COP_LESSTHAN = 3,
        COP_GREATERTHAN = 4,
        COP_LESSTHANOREQUAL = 5,
        COP_GREATERTHANOREQUAL = 6,
        COP_VALUE_STARTSWITH = 7,
        COP_VALUE_ENDSWITH = 8,
        COP_VALUE_CONTAINS = 9,
        COP_VALUE_NOTCONTAINS = 10,
        COP_DOSWILDCARDS = 11,
        COP_WORD_EQUAL = 12,
        COP_WORD_STARTSWITH = 13,
        COP_APPLICATION_SPECIFIC = 14,
    };

    public enum STPFLAG : int
    {
        STPF_NONE = 0,
        STPF_USEAPPTHUMBNAILALWAYS = 1,
        STPF_USEAPPTHUMBNAILWHENACTIVE = 2,
        STPF_USEAPPPEEKALWAYS = 4,
        STPF_USEAPPPEEKWHENACTIVE = 8,
    };

    public enum EXPLORER_BROWSER_OPTIONS : int
    {
        EBO_NONE = 0,
        EBO_NAVIGATEONCE = 1,
        EBO_SHOWFRAMES = 2,
        EBO_ALWAYSNAVIGATE = 4,
        EBO_NOTRAVELLOG = 8,
        EBO_NOWRAPPERWINDOW = 16,
        EBO_HTMLSHAREPOINTVIEW = 32,
        EBO_NOBORDER = 64,
        EBO_NOPERSISTVIEWSTATE = 128,
    };

    public enum EXPLORER_BROWSER_FILL_FLAGS : int
    {
        EBF_NONE = 0,
        EBF_SELECTFROMDATAOBJECT = 256,
        EBF_NODROPTARGET = 512,
    };

    public enum PDOPSTATUS : int
    {
        PDOPS_RUNNING = 1,
        PDOPS_PAUSED = 2,
        PDOPS_CANCELLED = 3,
        PDOPS_STOPPED = 4,
        PDOPS_ERRORS = 5,
    };

    public enum FILE_USAGE_TYPE : int
    {
        FUT_PLAYING = 0,
        FUT_EDITING = 1,
        FUT_GENERIC = 2,
    };

    public enum FDAP : int
    {
        FDAP_BOTTOM = 0,
        FDAP_TOP = 1,
    };

    public enum FDE_SHAREVIOLATION_RESPONSE : int
    {
        FDESVR_DEFAULT = 0,
        FDESVR_ACCEPT = 1,
        FDESVR_REFUSE = 2,
    };

    public enum FDE_OVERWRITE_RESPONSE : int
    {
        FDEOR_DEFAULT = 0,
        FDEOR_ACCEPT = 1,
        FDEOR_REFUSE = 2,
    };

    public enum CDCONTROLSTATEF : int
    {
        CDCS_INACTIVE = 0,
        CDCS_ENABLED = 1,
        CDCS_VISIBLE = 2,
        CDCS_ENABLEDVISIBLE = 3,
    };

    public enum ASSOCIATIONTYPE : int
    {
        AT_FILEEXTENSION = 0,
        AT_URLPROTOCOL = 1,
        AT_STARTMENUCLIENT = 2,
        AT_MIMETYPE = 3,
    };

    public enum ASSOCIATIONLEVEL : int
    {
        AL_MACHINE = 0,
        AL_EFFECTIVE = 1,
        AL_USER = 2,
    };

    public enum ATTACHMENT_PROMPT : int
    {
        ATTACHMENT_PROMPT_NONE = 0,
        ATTACHMENT_PROMPT_SAVE = 1,
        ATTACHMENT_PROMPT_EXEC = 2,
        ATTACHMENT_PROMPT_EXEC_OR_SAVE = 3,
    };

    public enum ATTACHMENT_ACTION : int
    {
        ATTACHMENT_ACTION_CANCEL = 0,
        ATTACHMENT_ACTION_SAVE = 1,
        ATTACHMENT_ACTION_EXEC = 2,
    };

    public enum KF_CATEGORY : int
    {
        KF_CATEGORY_VIRTUAL = 1,
        KF_CATEGORY_FIXED = 2,
        KF_CATEGORY_COMMON = 3,
        KF_CATEGORY_PERUSER = 4,
    };

    public enum FFFP_MODE : int
    {
        FFFP_EXACTMATCH = 0,
        FFFP_NEARESTPARENTMATCH = 1,
    };

    public enum DEF_SHARE_ID : int
    {
        DEFSHAREID_USERS = 1,
        DEFSHAREID_PUBLIC = 2,
    };

    public enum SHARE_ROLE : int
    {
        SHARE_ROLE_INVALID = -1,
        SHARE_ROLE_READER = 0,
        SHARE_ROLE_CONTRIBUTOR = 1,
        SHARE_ROLE_CO_OWNER = 2,
        SHARE_ROLE_OWNER = 3,
        SHARE_ROLE_CUSTOM = 4,
        SHARE_ROLE_MIXED = 5,
    };

    public enum NSTCGNI : int
    {
        NSTCGNI_NEXT = 0,
        NSTCGNI_NEXTVISIBLE = 1,
        NSTCGNI_PREV = 2,
        NSTCGNI_PREVVISIBLE = 3,
        NSTCGNI_PARENT = 4,
        NSTCGNI_CHILD = 5,
        NSTCGNI_FIRSTVISIBLE = 6,
        NSTCGNI_LASTVISIBLE = 7,
    };

    public enum NSTCSTYLE2 : int
    {
        NSTCS2_DEFAULT = 0,
        NSTCS2_INTERRUPTNOTIFICATIONS = 1,
        NSTCS2_SHOWNULLSPACEMENU = 2,
        NSTCS2_DISPLAYPADDING = 4,
        NSTCS2_DISPLAYPINNEDONLY = 8,
        NTSCS2_NOSINGLETONAUTOEXPAND = 16,
        NTSCS2_NEVERINSERTNONENUMERATED = 32,
    };

    public enum NSTCFOLDERCAPABILITIES : int
    {
        NSTCFC_NONE = 0,
        NSTCFC_PINNEDITEMFILTERING = 1,
        NSTCFC_DELAY_REGISTER_NOTIFY = 2,
    };

    public enum CPVIEW : int
    {
        CPVIEW_CLASSIC = 0,
        CPVIEW_ALLITEMS = 0,
        CPVIEW_CATEGORY = 1,
        CPVIEW_HOME = 1,
    };

    public enum KNOWNDESTCATEGORY : int
    {
        KDC_FREQUENT = 1,
        KDC_RECENT = 2,
    };

    public enum APPDOCLISTTYPE : int
    {
        ADLT_RECENT = 0,
        ADLT_FREQUENT = 1,
    };

    public enum DESKTOP_WALLPAPER_POSITION : int
    {
        DWPOS_CENTER = 0,
        DWPOS_TILE = 1,
        DWPOS_STRETCH = 2,
        DWPOS_FIT = 3,
        DWPOS_FILL = 4,
        DWPOS_SPAN = 5,
    };

    public enum DESKTOP_SLIDESHOW_OPTIONS : int
    {
        DSO_SHUFFLEIMAGES = 1,
    };

    public enum DESKTOP_SLIDESHOW_DIRECTION : int
    {
        DSD_FORWARD = 0,
        DSD_BACKWARD = 1,
    };

    public enum DESKTOP_SLIDESHOW_STATE : int
    {
        DSS_ENABLED = 1,
        DSS_SLIDESHOW = 2,
        DSS_DISABLED_BY_REMOTE_SESSION = 4,
    };

    public enum HOMEGROUPSHARINGCHOICES : int
    {
        HGSC_NONE = 0,
        HGSC_MUSICLIBRARY = 1,
        HGSC_PICTURESLIBRARY = 2,
        HGSC_VIDEOSLIBRARY = 4,
        HGSC_DOCUMENTSLIBRARY = 8,
        HGSC_PRINTERS = 16,
    };

    public enum LIBRARYFOLDERFILTER : int
    {
        LFF_FORCEFILESYSTEM = 1,
        LFF_STORAGEITEMS = 2,
        LFF_ALLITEMS = 3,
    };

    public enum DEFAULTSAVEFOLDERTYPE : int
    {
        DSFT_DETECT = 1,
        DSFT_PRIVATE = 2,
        DSFT_PUBLIC = 3,
    };

    public enum LIBRARYOPTIONFLAGS : int
    {
        LOF_DEFAULT = 0,
        LOF_PINNEDTONAVPANE = 1,
        LOF_MASK_ALL = 1,
    };

    public enum LIBRARYSAVEFLAGS : int
    {
        LSF_FAILIFTHERE = 0,
        LSF_OVERRIDEEXISTING = 1,
        LSF_MAKEUNIQUENAME = 2,
    };

    public enum DEFAULT_FOLDER_MENU_RESTRICTIONS : int
    {
        DFMR_DEFAULT = 0,
        DFMR_NO_STATIC_VERBS = 8,
        DFMR_STATIC_VERBS_ONLY = 16,
        DFMR_NO_RESOURCE_VERBS = 32,
        DFMR_OPTIN_HANDLERS_ONLY = 64,
        DFMR_RESOURCE_AND_FOLDER_VERBS_ONLY = 128,
        DFMR_USE_SPECIFIED_HANDLERS = 256,
        DFMR_USE_SPECIFIED_VERBS = 512,
        DFMR_NO_ASYNC_VERBS = 1024,
    };

    public enum ACTIVATEOPTIONS : int
    {
        AO_NONE = 0,
        AO_DESIGNMODE = 1,
        AO_NOERRORUI = 2,
        AO_NOSPLASHSCREEN = 4,
    };

    public enum UNDOCK_REASON : int
    {
        UR_RESOLUTION_CHANGE = 0,
        UR_MONITOR_DISCONNECT = 1,
    };

    public enum MONITOR_APP_VISIBILITY : int
    {
        MAV_UNKNOWN = 0,
        MAV_NO_APP_VISIBLE = 1,
        MAV_APP_VISIBLE = 2,
    };

    public enum PACKAGE_EXECUTION_STATE : int
    {
        PES_UNKNOWN = 0,
        PES_RUNNING = 1,
        PES_SUSPENDING = 2,
        PES_SUSPENDED = 3,
        PES_TERMINATED = 4,
    };

    public enum AHE_TYPE : int
    {
        AHE_DESKTOP = 0,
        AHE_IMMERSIVE = 1,
    };

    public enum EC_HOST_UI_MODE : int
    {
        ECHUIM_DESKTOP = 0,
        ECHUIM_IMMERSIVE = 1,
        ECHUIM_SYSTEM_LAUNCHER = 2,
    };

    public enum DEVICE_SCALE_FACTOR : int
    {
        SCALE_100_PERCENT = 100,
        SCALE_120_PERCENT = 120,
        SCALE_140_PERCENT = 140,
        SCALE_150_PERCENT = 150,
        SCALE_160_PERCENT = 160,
        SCALE_180_PERCENT = 180,
        SCALE_225_PERCENT = 225,
    };

    public enum APPLICATION_VIEW_STATE : int
    {
        AVS_FULLSCREEN_LANDSCAPE = 0,
        AVS_FILLED = 1,
        AVS_SNAPPED = 2,
        AVS_FULLSCREEN_PORTRAIT = 3,
    };

    public enum EDGE_GESTURE_KIND : int
    {
        EGK_TOUCH = 0,
        EGK_KEYBOARD = 1,
        EGK_MOUSE = 2,
    };

    public enum NATIVE_DISPLAY_ORIENTATION : int
    {
        NDO_LANDSCAPE = 0,
        NDO_PORTRAIT = 1,
    };

    public enum APPLICATION_VIEW_ORIENTATION : int
    {
        AVO_LANDSCAPE = 0,
        AVO_PORTRAIT = 1,
    };

    public enum ADJACENT_DISPLAY_EDGES : int
    {
        ADE_NONE = 0,
        ADE_LEFT = 1,
        ADE_RIGHT = 2,
    };

    public enum APPLICATION_VIEW_MIN_WIDTH : int
    {
        AVMW_DEFAULT = 0,
        AVMW_320 = 1,
        AVMW_500 = 2,
    };

    public enum APPLICATION_VIEW_SIZE_PREFERENCE : int
    {
        AVSP_DEFAULT = 0,
        AVSP_USE_LESS = 1,
        AVSP_USE_HALF = 2,
        AVSP_USE_MORE = 3,
        AVSP_USE_MINIMUM = 4,
        AVSP_USE_NONE = 5,
    };

    public enum FLYOUT_PLACEMENT : int
    {
        FP_DEFAULT = 0,
        FP_ABOVE = 1,
        FP_BELOW = 2,
        FP_LEFT = 3,
        FP_RIGHT = 4,
    };

    public enum __MIDL_IOleDocument_0001 : int
    {
        DOCMISC_CANCREATEMULTIPLEVIEWS = 1,
        DOCMISC_SUPPORTCOMPLEXRECTANGLES = 2,
        DOCMISC_CANTOPENEDIT = 4,
        DOCMISC_NOFILESUPPORT = 8,
    };

    public enum __MIDL_IPrint_0001 : int
    {
        PRINTFLAG_MAYBOTHERUSER = 1,
        PRINTFLAG_PROMPTUSER = 2,
        PRINTFLAG_USERMAYCHANGEPRINTER = 4,
        PRINTFLAG_RECOMPOSETODEVICE = 8,
        PRINTFLAG_DONTACTUALLYPRINT = 16,
        PRINTFLAG_FORCEPROPERTIES = 32,
        PRINTFLAG_PRINTTOFILE = 64,
    };

    public enum OLECMDF : int
    {
        OLECMDF_SUPPORTED = 1,
        OLECMDF_ENABLED = 2,
        OLECMDF_LATCHED = 4,
        OLECMDF_NINCHED = 8,
        OLECMDF_INVISIBLE = 16,
        OLECMDF_DEFHIDEONCTXTMENU = 32,
    };

    public enum OLECMDTEXTF : int
    {
        OLECMDTEXTF_NONE = 0,
        OLECMDTEXTF_NAME = 1,
        OLECMDTEXTF_STATUS = 2,
    };

    public enum OLECMDEXECOPT : int
    {
        OLECMDEXECOPT_DODEFAULT = 0,
        OLECMDEXECOPT_PROMPTUSER = 1,
        OLECMDEXECOPT_DONTPROMPTUSER = 2,
        OLECMDEXECOPT_SHOWHELP = 3,
    };

    public enum OLECMDID : int
    {
        OLECMDID_OPEN = 1,
        OLECMDID_NEW = 2,
        OLECMDID_SAVE = 3,
        OLECMDID_SAVEAS = 4,
        OLECMDID_SAVECOPYAS = 5,
        OLECMDID_PRINT = 6,
        OLECMDID_PRINTPREVIEW = 7,
        OLECMDID_PAGESETUP = 8,
        OLECMDID_SPELL = 9,
        OLECMDID_PROPERTIES = 10,
        OLECMDID_CUT = 11,
        OLECMDID_COPY = 12,
        OLECMDID_PASTE = 13,
        OLECMDID_PASTESPECIAL = 14,
        OLECMDID_UNDO = 15,
        OLECMDID_REDO = 16,
        OLECMDID_SELECTALL = 17,
        OLECMDID_CLEARSELECTION = 18,
        OLECMDID_ZOOM = 19,
        OLECMDID_GETZOOMRANGE = 20,
        OLECMDID_UPDATECOMMANDS = 21,
        OLECMDID_REFRESH = 22,
        OLECMDID_STOP = 23,
        OLECMDID_HIDETOOLBARS = 24,
        OLECMDID_SETPROGRESSMAX = 25,
        OLECMDID_SETPROGRESSPOS = 26,
        OLECMDID_SETPROGRESSTEXT = 27,
        OLECMDID_SETTITLE = 28,
        OLECMDID_SETDOWNLOADSTATE = 29,
        OLECMDID_STOPDOWNLOAD = 30,
        OLECMDID_ONTOOLBARACTIVATED = 31,
        OLECMDID_FIND = 32,
        OLECMDID_DELETE = 33,
        OLECMDID_HTTPEQUIV = 34,
        OLECMDID_HTTPEQUIV_DONE = 35,
        OLECMDID_ENABLE_INTERACTION = 36,
        OLECMDID_ONUNLOAD = 37,
        OLECMDID_PROPERTYBAG2 = 38,
        OLECMDID_PREREFRESH = 39,
        OLECMDID_SHOWSCRIPTERROR = 40,
        OLECMDID_SHOWMESSAGE = 41,
        OLECMDID_SHOWFIND = 42,
        OLECMDID_SHOWPAGESETUP = 43,
        OLECMDID_SHOWPRINT = 44,
        OLECMDID_CLOSE = 45,
        OLECMDID_ALLOWUILESSSAVEAS = 46,
        OLECMDID_DONTDOWNLOADCSS = 47,
        OLECMDID_UPDATEPAGESTATUS = 48,
        OLECMDID_PRINT2 = 49,
        OLECMDID_PRINTPREVIEW2 = 50,
        OLECMDID_SETPRINTTEMPLATE = 51,
        OLECMDID_GETPRINTTEMPLATE = 52,
        OLECMDID_PAGEACTIONBLOCKED = 55,
        OLECMDID_PAGEACTIONUIQUERY = 56,
        OLECMDID_FOCUSVIEWCONTROLS = 57,
        OLECMDID_FOCUSVIEWCONTROLSQUERY = 58,
        OLECMDID_SHOWPAGEACTIONMENU = 59,
        OLECMDID_ADDTRAVELENTRY = 60,
        OLECMDID_UPDATETRAVELENTRY = 61,
        OLECMDID_UPDATEBACKFORWARDSTATE = 62,
        OLECMDID_OPTICAL_ZOOM = 63,
        OLECMDID_OPTICAL_GETZOOMRANGE = 64,
        OLECMDID_WINDOWSTATECHANGED = 65,
        OLECMDID_ACTIVEXINSTALLSCOPE = 66,
        OLECMDID_UPDATETRAVELENTRY_DATARECOVERY = 67,
        OLECMDID_SHOWTASKDLG = 68,
        OLECMDID_POPSTATEEVENT = 69,
        OLECMDID_VIEWPORT_MODE = 70,
        OLECMDID_LAYOUT_VIEWPORT_WIDTH = 71,
        OLECMDID_VISUAL_VIEWPORT_EXCLUDE_BOTTOM = 72,
        OLECMDID_USER_OPTICAL_ZOOM = 73,
        OLECMDID_PAGEAVAILABLE = 74,
        OLECMDID_GETUSERSCALABLE = 75,
        OLECMDID_UPDATE_CARET = 76,
        OLECMDID_ENABLE_VISIBILITY = 77,
        OLECMDID_MEDIA_PLAYBACK = 78,
        OLECMDID_SETFAVICON = 79,
        OLECMDID_SET_HOST_FULLSCREENMODE = 80,
        OLECMDID_EXITFULLSCREEN = 81,
        OLECMDID_SCROLLCOMPLETE = 82,
        OLECMDID_ONBEFOREUNLOAD = 83,
    };

    public enum MEDIAPLAYBACK_STATE : int
    {
        MEDIAPLAYBACK_RESUME = 0,
        MEDIAPLAYBACK_PAUSE = 1,
        MEDIAPLAYBACK_PAUSE_AND_SUSPEND = 2,
        MEDIAPLAYBACK_RESUME_FROM_SUSPEND = 3,
    };

    public enum IGNOREMIME : int
    {
        IGNOREMIME_PROMPT = 1,
        IGNOREMIME_TEXT = 2,
    };

    public enum WPCSETTING : int
    {
        WPCSETTING_LOGGING_ENABLED = 1,
        WPCSETTING_FILEDOWNLOAD_BLOCKED = 2,
    };

    public enum OLECMDID_REFRESHFLAG : int
    {
        OLECMDIDF_REFRESH_NORMAL = 0,
        OLECMDIDF_REFRESH_IFEXPIRED = 1,
        OLECMDIDF_REFRESH_CONTINUE = 2,
        OLECMDIDF_REFRESH_COMPLETELY = 3,
        OLECMDIDF_REFRESH_NO_CACHE = 4,
        OLECMDIDF_REFRESH_RELOAD = 5,
        OLECMDIDF_REFRESH_LEVELMASK = 255,
        OLECMDIDF_REFRESH_CLEARUSERINPUT = 4096,
        OLECMDIDF_REFRESH_PROMPTIFOFFLINE = 8192,
        OLECMDIDF_REFRESH_THROUGHSCRIPT = 16384,
        OLECMDIDF_REFRESH_SKIPBEFOREUNLOADEVENT = 32768,
        OLECMDIDF_REFRESH_PAGEACTION_ACTIVEXINSTALL = 65536,
        OLECMDIDF_REFRESH_PAGEACTION_FILEDOWNLOAD = 131072,
        OLECMDIDF_REFRESH_PAGEACTION_LOCALMACHINE = 262144,
        OLECMDIDF_REFRESH_PAGEACTION_POPUPWINDOW = 524288,
        OLECMDIDF_REFRESH_PAGEACTION_PROTLOCKDOWNLOCALMACHINE = 1048576,
        OLECMDIDF_REFRESH_PAGEACTION_PROTLOCKDOWNTRUSTED = 2097152,
        OLECMDIDF_REFRESH_PAGEACTION_PROTLOCKDOWNINTRANET = 4194304,
        OLECMDIDF_REFRESH_PAGEACTION_PROTLOCKDOWNINTERNET = 8388608,
        OLECMDIDF_REFRESH_PAGEACTION_PROTLOCKDOWNRESTRICTED = 16777216,
        OLECMDIDF_REFRESH_PAGEACTION_MIXEDCONTENT = 33554432,
        OLECMDIDF_REFRESH_PAGEACTION_INVALID_CERT = 67108864,
        OLECMDIDF_REFRESH_PAGEACTION_ALLOW_VERSION = 134217728,
    };

    public enum OLECMDID_PAGEACTIONFLAG : int
    {
        OLECMDIDF_PAGEACTION_FILEDOWNLOAD = 1,
        OLECMDIDF_PAGEACTION_ACTIVEXINSTALL = 2,
        OLECMDIDF_PAGEACTION_ACTIVEXTRUSTFAIL = 4,
        OLECMDIDF_PAGEACTION_ACTIVEXUSERDISABLE = 8,
        OLECMDIDF_PAGEACTION_ACTIVEXDISALLOW = 16,
        OLECMDIDF_PAGEACTION_ACTIVEXUNSAFE = 32,
        OLECMDIDF_PAGEACTION_POPUPWINDOW = 64,
        OLECMDIDF_PAGEACTION_LOCALMACHINE = 128,
        OLECMDIDF_PAGEACTION_MIMETEXTPLAIN = 256,
        OLECMDIDF_PAGEACTION_SCRIPTNAVIGATE = 512,
        OLECMDIDF_PAGEACTION_SCRIPTNAVIGATE_ACTIVEXINSTALL = 512,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNLOCALMACHINE = 1024,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNTRUSTED = 2048,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNINTRANET = 4096,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNINTERNET = 8192,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNRESTRICTED = 16384,
        OLECMDIDF_PAGEACTION_PROTLOCKDOWNDENY = 32768,
        OLECMDIDF_PAGEACTION_POPUPALLOWED = 65536,
        OLECMDIDF_PAGEACTION_SCRIPTPROMPT = 131072,
        OLECMDIDF_PAGEACTION_ACTIVEXUSERAPPROVAL = 262144,
        OLECMDIDF_PAGEACTION_MIXEDCONTENT = 524288,
        OLECMDIDF_PAGEACTION_INVALID_CERT = 1048576,
        OLECMDIDF_PAGEACTION_INTRANETZONEREQUEST = 2097152,
        OLECMDIDF_PAGEACTION_XSSFILTERED = 4194304,
        OLECMDIDF_PAGEACTION_SPOOFABLEIDNHOST = 8388608,
        OLECMDIDF_PAGEACTION_ACTIVEX_EPM_INCOMPATIBLE = 16777216,
        OLECMDIDF_PAGEACTION_SCRIPTNAVIGATE_ACTIVEXUSERAPPROVAL = 33554432,
        OLECMDIDF_PAGEACTION_WPCBLOCKED = 67108864,
        OLECMDIDF_PAGEACTION_WPCBLOCKED_ACTIVEX = 134217728,
        OLECMDIDF_PAGEACTION_EXTENSION_COMPAT_BLOCKED = 268435456,
        OLECMDIDF_PAGEACTION_NORESETACTIVEX = 536870912,
        OLECMDIDF_PAGEACTION_GENERIC_STATE = 1073741824,
        OLECMDIDF_PAGEACTION_RESET = -2147483648,
    };

    public enum OLECMDID_BROWSERSTATEFLAG : int
    {
        OLECMDIDF_BROWSERSTATE_EXTENSIONSOFF = 1,
        OLECMDIDF_BROWSERSTATE_IESECURITY = 2,
        OLECMDIDF_BROWSERSTATE_PROTECTEDMODE_OFF = 4,
        OLECMDIDF_BROWSERSTATE_RESET = 8,
        OLECMDIDF_BROWSERSTATE_REQUIRESACTIVEX = 16,
        OLECMDIDF_BROWSERSTATE_DESKTOPHTMLDIALOG = 32,
        OLECMDIDF_BROWSERSTATE_BLOCKEDVERSION = 64,
    };

    public enum OLECMDID_OPTICAL_ZOOMFLAG : int
    {
        OLECMDIDF_OPTICAL_ZOOM_NOPERSIST = 1,
        OLECMDIDF_OPTICAL_ZOOM_NOLAYOUT = 16,
        OLECMDIDF_OPTICAL_ZOOM_NOTRANSIENT = 32,
        OLECMDIDF_OPTICAL_ZOOM_RELOADFORNEWTAB = 64,
    };

    public enum PAGEACTION_UI : int
    {
        PAGEACTION_UI_DEFAULT = 0,
        PAGEACTION_UI_MODAL = 1,
        PAGEACTION_UI_MODELESS = 2,
        PAGEACTION_UI_SILENT = 3,
    };

    public enum OLECMDID_WINDOWSTATE_FLAG : int
    {
        OLECMDIDF_WINDOWSTATE_USERVISIBLE = 1,
        OLECMDIDF_WINDOWSTATE_ENABLED = 2,
        OLECMDIDF_WINDOWSTATE_USERVISIBLE_VALID = 65536,
        OLECMDIDF_WINDOWSTATE_ENABLED_VALID = 131072,
    };

    public enum OLECMDID_VIEWPORT_MODE_FLAG : int
    {
        OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH = 1,
        OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM = 2,
        OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH_VALID = 65536,
        OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM_VALID = 131072,
    };

    public enum tagSTRRET_TYPE : int
    {
        STRRET_WSTR = 0,
        STRRET_OFFSET = 1,
        STRRET_CSTR = 2,
    };

    public enum tagPERCEIVED : int
    {
        PERCEIVED_TYPE_FIRST = -3,
        PERCEIVED_TYPE_CUSTOM = -3,
        PERCEIVED_TYPE_UNSPECIFIED = -2,
        PERCEIVED_TYPE_FOLDER = -1,
        PERCEIVED_TYPE_UNKNOWN = 0,
        PERCEIVED_TYPE_TEXT = 1,
        PERCEIVED_TYPE_IMAGE = 2,
        PERCEIVED_TYPE_AUDIO = 3,
        PERCEIVED_TYPE_VIDEO = 4,
        PERCEIVED_TYPE_COMPRESSED = 5,
        PERCEIVED_TYPE_DOCUMENT = 6,
        PERCEIVED_TYPE_SYSTEM = 7,
        PERCEIVED_TYPE_APPLICATION = 8,
        PERCEIVED_TYPE_GAMEMEDIA = 9,
        PERCEIVED_TYPE_CONTACTS = 10,
        PERCEIVED_TYPE_LAST = 10,
    };

    public enum tagSHCOLSTATE : int
    {
        SHCOLSTATE_DEFAULT = 0,
        SHCOLSTATE_TYPE_STR = 1,
        SHCOLSTATE_TYPE_INT = 2,
        SHCOLSTATE_TYPE_DATE = 3,
        SHCOLSTATE_TYPEMASK = 15,
        SHCOLSTATE_ONBYDEFAULT = 16,
        SHCOLSTATE_SLOW = 32,
        SHCOLSTATE_EXTENDED = 64,
        SHCOLSTATE_SECONDARYUI = 128,
        SHCOLSTATE_HIDDEN = 256,
        SHCOLSTATE_PREFER_VARCMP = 512,
        SHCOLSTATE_PREFER_FMTCMP = 1024,
        SHCOLSTATE_NOSORTBYFOLDERNESS = 2048,
        SHCOLSTATE_VIEWONLY = 65536,
        SHCOLSTATE_BATCHREAD = 131072,
        SHCOLSTATE_NO_GROUPBY = 262144,
        SHCOLSTATE_FIXED_WIDTH = 4096,
        SHCOLSTATE_NODPISCALE = 8192,
        SHCOLSTATE_FIXED_RATIO = 16384,
        SHCOLSTATE_DISPLAYMASK = 61440,
    };

    public enum PSC_STATE : int
    {
        PSC_NORMAL = 0,
        PSC_NOTINSOURCE = 1,
        PSC_DIRTY = 2,
        PSC_READONLY = 3,
    };

    public enum PROPENUMTYPE : int
    {
        PET_DISCRETEVALUE = 0,
        PET_RANGEDVALUE = 1,
        PET_DEFAULTVALUE = 2,
        PET_ENDRANGE = 3,
    };

    public enum PROPDESC_TYPE_FLAGS : int
    {
        PDTF_DEFAULT = 0,
        PDTF_MULTIPLEVALUES = 1,
        PDTF_ISINNATE = 2,
        PDTF_ISGROUP = 4,
        PDTF_CANGROUPBY = 8,
        PDTF_CANSTACKBY = 16,
        PDTF_ISTREEPROPERTY = 32,
        PDTF_INCLUDEINFULLTEXTQUERY = 64,
        PDTF_ISVIEWABLE = 128,
        PDTF_ISQUERYABLE = 256,
        PDTF_CANBEPURGED = 512,
        PDTF_SEARCHRAWVALUE = 1024,
        PDTF_ISSYSTEMPROPERTY = -2147483648,
        PDTF_MASK_ALL = -2147481601,
    };

    public enum PROPDESC_VIEW_FLAGS : int
    {
        PDVF_DEFAULT = 0,
        PDVF_CENTERALIGN = 1,
        PDVF_RIGHTALIGN = 2,
        PDVF_BEGINNEWGROUP = 4,
        PDVF_FILLAREA = 8,
        PDVF_SORTDESCENDING = 16,
        PDVF_SHOWONLYIFPRESENT = 32,
        PDVF_SHOWBYDEFAULT = 64,
        PDVF_SHOWINPRIMARYLIST = 128,
        PDVF_SHOWINSECONDARYLIST = 256,
        PDVF_HIDELABEL = 512,
        PDVF_HIDDEN = 2048,
        PDVF_CANWRAP = 4096,
        PDVF_MASK_ALL = 7167,
    };

    public enum PROPDESC_DISPLAYTYPE : int
    {
        PDDT_STRING = 0,
        PDDT_NUMBER = 1,
        PDDT_BOOLEAN = 2,
        PDDT_DATETIME = 3,
        PDDT_ENUMERATED = 4,
    };

    public enum PROPDESC_GROUPING_RANGE : int
    {
        PDGR_DISCRETE = 0,
        PDGR_ALPHANUMERIC = 1,
        PDGR_SIZE = 2,
        PDGR_DYNAMIC = 3,
        PDGR_DATE = 4,
        PDGR_PERCENT = 5,
        PDGR_ENUMERATED = 6,
    };

    public enum PROPDESC_RELATIVEDESCRIPTION_TYPE : int
    {
        PDRDT_GENERAL = 0,
        PDRDT_DATE = 1,
        PDRDT_SIZE = 2,
        PDRDT_COUNT = 3,
        PDRDT_REVISION = 4,
        PDRDT_LENGTH = 5,
        PDRDT_DURATION = 6,
        PDRDT_SPEED = 7,
        PDRDT_RATE = 8,
        PDRDT_RATING = 9,
        PDRDT_PRIORITY = 10,
    };

    public enum PROPDESC_SORTDESCRIPTION : int
    {
        PDSD_GENERAL = 0,
        PDSD_A_Z = 1,
        PDSD_LOWEST_HIGHEST = 2,
        PDSD_SMALLEST_BIGGEST = 3,
        PDSD_OLDEST_NEWEST = 4,
    };

    public enum PROPDESC_AGGREGATION_TYPE : int
    {
        PDAT_DEFAULT = 0,
        PDAT_FIRST = 1,
        PDAT_SUM = 2,
        PDAT_AVERAGE = 3,
        PDAT_DATERANGE = 4,
        PDAT_UNION = 5,
        PDAT_MAX = 6,
        PDAT_MIN = 7,
    };

    public enum PROPDESC_CONDITION_TYPE : int
    {
        PDCOT_NONE = 0,
        PDCOT_STRING = 1,
        PDCOT_SIZE = 2,
        PDCOT_DATETIME = 3,
        PDCOT_BOOLEAN = 4,
        PDCOT_NUMBER = 5,
    };

    public enum PROPDESC_FORMAT_FLAGS : int
    {
        PDFF_DEFAULT = 0,
        PDFF_PREFIXNAME = 1,
        PDFF_FILENAME = 2,
        PDFF_ALWAYSKB = 4,
        PDFF_RESERVED_RIGHTTOLEFT = 8,
        PDFF_SHORTTIME = 16,
        PDFF_LONGTIME = 32,
        PDFF_HIDETIME = 64,
        PDFF_SHORTDATE = 128,
        PDFF_LONGDATE = 256,
        PDFF_HIDEDATE = 512,
        PDFF_RELATIVEDATE = 1024,
        PDFF_USEEDITINVITATION = 2048,
        PDFF_READONLY = 4096,
        PDFF_NOAUTOREADINGORDER = 8192,
    };

    public enum PROPDESC_SEARCHINFO_FLAGS : int
    {
        PDSIF_DEFAULT = 0,
        PDSIF_ININVERTEDINDEX = 1,
        PDSIF_ISCOLUMN = 2,
        PDSIF_ISCOLUMNSPARSE = 4,
        PDSIF_ALWAYSINCLUDE = 8,
        PDSIF_USEFORTYPEAHEAD = 16,
    };

    public enum PROPDESC_COLUMNINDEX_TYPE : int
    {
        PDCIT_NONE = 0,
        PDCIT_ONDISK = 1,
        PDCIT_INMEMORY = 2,
        PDCIT_ONDEMAND = 3,
        PDCIT_ONDISKALL = 4,
        PDCIT_ONDISKVECTOR = 5,
    };

    public enum PROPDESC_ENUMFILTER : int
    {
        PDEF_ALL = 0,
        PDEF_SYSTEM = 1,
        PDEF_NONSYSTEM = 2,
        PDEF_VIEWABLE = 3,
        PDEF_QUERYABLE = 4,
        PDEF_INFULLTEXTQUERY = 5,
        PDEF_COLUMN = 6,
    };

    public enum PKA_FLAGS : int
    {
        PKA_SET = 0,
        PKA_APPEND = 1,
        PKA_DELETE = 2,
    };

    public enum _PERSIST_SPROPSTORE_FLAGS : int
    {
        FPSPS_DEFAULT = 0,
        FPSPS_READONLY = 1,
        FPSPS_TREAT_NEW_VALUES_AS_DIRTY = 2,
    };

    public enum _SHGDNF : int
    {
        SHGDN_NORMAL = 0,
        SHGDN_INFOLDER = 1,
        SHGDN_FOREDITING = 4096,
        SHGDN_FORADDRESSBAR = 16384,
        SHGDN_FORPARSING = 32768,
    };

    public enum _SHCONTF : int
    {
        SHCONTF_CHECKING_FOR_CHILDREN = 16,
        SHCONTF_FOLDERS = 32,
        SHCONTF_NONFOLDERS = 64,
        SHCONTF_INCLUDEHIDDEN = 128,
        SHCONTF_INIT_ON_FIRST_NEXT = 256,
        SHCONTF_NETPRINTERSRCH = 512,
        SHCONTF_SHAREABLE = 1024,
        SHCONTF_STORAGE = 2048,
        SHCONTF_NAVIGATION_ENUM = 4096,
        SHCONTF_FASTITEMS = 8192,
        SHCONTF_FLATLIST = 16384,
        SHCONTF_ENABLE_ASYNC = 32768,
        SHCONTF_INCLUDESUPERHIDDEN = 65536,
    };

    public enum SYNC_TRANSFER_STATUS : int
    {
        STS_NONE = 0,
        STS_NEEDSUPLOAD = 1,
        STS_NEEDSDOWNLOAD = 2,
        STS_TRANSFERRING = 4,
        STS_PAUSED = 8,
        STS_HASERROR = 16,
        STS_FETCHING_METADATA = 32,
        STS_USER_REQUESTED_REFRESH = 64,
    };

    public enum PLACEHOLDER_STATES : int
    {
        PS_NONE = 0,
        PS_MARKED_FOR_OFFLINE_AVAILABILITY = 1,
        PS_FULL_PRIMARY_STREAM_AVAILABLE = 2,
        PS_CREATE_FILE_ACCESSIBLE = 4,
        PS_ALL = 7,
    };

    public enum SYNC_ENGINE_STATE_FLAGS : int
    {
        SESF_NONE = 0,
        SESF_SERVICE_QUOTA_NEARING_LIMIT = 1,
        SESF_SERVICE_QUOTA_EXCEEDED_LIMIT = 2,
        SESF_AUTHENTICATION_ERROR = 4,
        SESF_PAUSED_DUE_TO_METERED_NETWORK = 8,
        SESF_PAUSED_DUE_TO_DISK_SPACE_FULL = 16,
        SESF_PAUSED_DUE_TO_CLIENT_POLICY = 32,
        SESF_PAUSED_DUE_TO_SERVICE_POLICY = 64,
        SESF_SERVICE_UNAVAILABLE = 128,
        SESF_PAUSED_DUE_TO_USER_REQUEST = 256,
        SESF_ALL_FLAGS = 511,
    };

    public enum _SVSIF : int
    {
        SVSI_DESELECT = 0,
        SVSI_SELECT = 1,
        SVSI_EDIT = 3,
        SVSI_DESELECTOTHERS = 4,
        SVSI_ENSUREVISIBLE = 8,
        SVSI_FOCUSED = 16,
        SVSI_TRANSLATEPT = 32,
        SVSI_SELECTIONMARK = 64,
        SVSI_POSITIONITEM = 128,
        SVSI_CHECK = 256,
        SVSI_CHECK2 = 512,
        SVSI_KEYBOARDSELECT = 1025,
        SVSI_NOTAKEFOCUS = 1073741824,
    };

    public enum _SVGIO : int
    {
        SVGIO_BACKGROUND = 0,
        SVGIO_SELECTION = 1,
        SVGIO_ALLVIEW = 2,
        SVGIO_CHECKED = 3,
        SVGIO_TYPE_MASK = 15,
        SVGIO_FLAG_VIEWORDER = -2147483648,
    };

    public enum SVUIA_STATUS : int
    {
        SVUIA_DEACTIVATE = 0,
        SVUIA_ACTIVATE_NOFOCUS = 1,
        SVUIA_ACTIVATE_FOCUS = 2,
        SVUIA_INPLACEACTIVATE = 3,
    };

    public enum _SV3CVW3_FLAGS : int
    {
        SV3CVW3_DEFAULT = 0,
        SV3CVW3_NONINTERACTIVE = 1,
        SV3CVW3_FORCEVIEWMODE = 2,
        SV3CVW3_FORCEFOLDERFLAGS = 4,
    };

    public enum tagSORTDIRECTION : int
    {
        SORT_DESCENDING = -1,
        SORT_ASCENDING = 1,
    };

    public enum CM_MASK : int
    {
        CM_MASK_WIDTH = 1,
        CM_MASK_DEFAULTWIDTH = 2,
        CM_MASK_IDEALWIDTH = 4,
        CM_MASK_NAME = 8,
        CM_MASK_STATE = 16,
    };

    public enum CM_STATE : int
    {
        CM_STATE_NONE = 0,
        CM_STATE_VISIBLE = 1,
        CM_STATE_FIXEDWIDTH = 2,
        CM_STATE_NOSORTBYFOLDERNESS = 4,
        CM_STATE_ALWAYSVISIBLE = 8,
    };

    public enum CM_SET_WIDTH_VALUE : int
    {
        CM_WIDTH_USEDEFAULT = -1,
        CM_WIDTH_AUTOSIZE = -2,
    };

    public enum _SICHINTF : int
    {
        SICHINT_DISPLAY = 0,
        SICHINT_ALLFIELDS = -2147483648,
        SICHINT_CANONICAL = 268435456,
        SICHINT_TEST_FILESYSPATH_IF_NOT_EQUAL = 536870912,
    };

    public enum DATAOBJ_GET_ITEM_FLAGS : int
    {
        DOGIF_DEFAULT = 0,
        DOGIF_TRAVERSE_LINK = 1,
        DOGIF_NO_HDROP = 2,
        DOGIF_NO_URL = 4,
        DOGIF_ONLY_IF_ONE = 8,
    };

    public enum _SIIGBF : int
    {
        SIIGBF_RESIZETOFIT = 0,
        SIIGBF_BIGGERSIZEOK = 1,
        SIIGBF_MEMORYONLY = 2,
        SIIGBF_ICONONLY = 4,
        SIIGBF_THUMBNAILONLY = 8,
        SIIGBF_INCACHEONLY = 16,
        SIIGBF_CROPTOSQUARE = 32,
        SIIGBF_WIDETHUMBNAILS = 64,
        SIIGBF_ICONBACKGROUND = 128,
        SIIGBF_SCALEUP = 256,
    };

    public enum STGOP : int
    {
        STGOP_MOVE = 1,
        STGOP_COPY = 2,
        STGOP_SYNC = 3,
        STGOP_REMOVE = 5,
        STGOP_RENAME = 6,
        STGOP_APPLYPROPERTIES = 8,
        STGOP_NEW = 10,
    };

    public enum _TRANSFER_SOURCE_FLAGS : int
    {
        TSF_NORMAL = 0,
        TSF_FAIL_EXIST = 0,
        TSF_RENAME_EXIST = 1,
        TSF_OVERWRITE_EXIST = 2,
        TSF_ALLOW_DECRYPTION = 4,
        TSF_NO_SECURITY = 8,
        TSF_COPY_CREATION_TIME = 16,
        TSF_COPY_WRITE_TIME = 32,
        TSF_USE_FULL_ACCESS = 64,
        TSF_DELETE_RECYCLE_IF_POSSIBLE = 128,
        TSF_COPY_HARD_LINK = 256,
        TSF_COPY_LOCALIZED_NAME = 512,
        TSF_MOVE_AS_COPY_DELETE = 1024,
        TSF_SUSPEND_SHELLEVENTS = 2048,
    };

    public enum _TRANSFER_ADVISE_STATE : int
    {
        TS_NONE = 0,
        TS_PERFORMING = 1,
        TS_PREPARING = 2,
        TS_INDETERMINATE = 4,
    };

    public enum _PROPERTYUI_NAME_FLAGS : int
    {
        PUIFNF_DEFAULT = 0,
        PUIFNF_MNEMONIC = 1,
    };

    public enum _PROPERTYUI_FLAGS : int
    {
        PUIF_DEFAULT = 0,
        PUIF_RIGHTALIGN = 1,
        PUIF_NOLABELININFOTIP = 2,
    };

    public enum _PROPERTYUI_FORMAT_FLAGS : int
    {
        PUIFFDF_DEFAULT = 0,
        PUIFFDF_RIGHTTOLEFT = 1,
        PUIFFDF_SHORTFORMAT = 2,
        PUIFFDF_NOTIME = 4,
        PUIFFDF_FRIENDLYDATE = 8,
    };

    public enum DSH_FLAGS : int
    {
        DSH_ALLOWDROPDESCRIPTIONTEXT = 1,
    };

    public enum SLR_FLAGS : int
    {
        SLR_NO_UI = 1,
        SLR_ANY_MATCH = 2,
        SLR_UPDATE = 4,
        SLR_NOUPDATE = 8,
        SLR_NOSEARCH = 16,
        SLR_NOTRACK = 32,
        SLR_NOLINKINFO = 64,
        SLR_INVOKE_MSI = 128,
        SLR_NO_UI_WITH_MSG_PUMP = 257,
        SLR_OFFER_DELETE_WITHOUT_FILE = 512,
        SLR_KNOWNFOLDER = 1024,
        SLR_MACHINE_IN_LOCAL_TARGET = 2048,
        SLR_UPDATE_MACHINE_AND_SID = 4096,
    };

    public enum SLGP_FLAGS : int
    {
        SLGP_SHORTPATH = 1,
        SLGP_UNCPRIORITY = 2,
        SLGP_RAWPATH = 4,
        SLGP_RELATIVEPRIORITY = 8,
    };

    public enum _SPINITF : int
    {
        SPINITF_NORMAL = 0,
        SPINITF_MODAL = 1,
        SPINITF_NOMINIMIZE = 8,
    };

    public enum _SPBEGINF : int
    {
        SPBEGINF_NORMAL = 0,
        SPBEGINF_AUTOTIME = 2,
        SPBEGINF_NOPROGRESSBAR = 16,
        SPBEGINF_MARQUEEPROGRESS = 32,
        SPBEGINF_NOCANCELBUTTON = 64,
    };

    public enum _EXPPS : int
    {
        EXPPS_FILETYPES = 1,
    };

    public enum tagDESKBANDCID : int
    {
        DBID_BANDINFOCHANGED = 0,
        DBID_SHOWONLY = 1,
        DBID_MAXIMIZEBAND = 2,
        DBID_PUSHCHEVRON = 3,
        DBID_DELAYINIT = 4,
        DBID_FINISHINIT = 5,
        DBID_SETWINDOWTHEME = 6,
        DBID_PERMITAUTOHIDE = 7,
    };

    public enum _OPPROGDLGF : int
    {
        OPPROGDLG_DEFAULT = 0,
        OPPROGDLG_ENABLEPAUSE = 128,
        OPPROGDLG_ALLOWUNDO = 256,
        OPPROGDLG_DONTDISPLAYSOURCEPATH = 512,
        OPPROGDLG_DONTDISPLAYDESTPATH = 1024,
        OPPROGDLG_NOMULTIDAYESTIMATES = 2048,
        OPPROGDLG_DONTDISPLAYLOCATIONS = 4096,
    };

    public enum _PDMODE : int
    {
        PDM_DEFAULT = 0,
        PDM_RUN = 1,
        PDM_PREFLIGHT = 2,
        PDM_UNDOING = 4,
        PDM_ERRORSBLOCKING = 8,
        PDM_INDETERMINATE = 16,
    };

    public enum NAMESPACEWALKFLAG : int
    {
        NSWF_DEFAULT = 0,
        NSWF_NONE_IMPLIES_ALL = 1,
        NSWF_ONE_IMPLIES_ALL = 2,
        NSWF_DONT_TRAVERSE_LINKS = 4,
        NSWF_DONT_ACCUMULATE_RESULT = 8,
        NSWF_TRAVERSE_STREAM_JUNCTIONS = 16,
        NSWF_FILESYSTEM_ONLY = 32,
        NSWF_SHOW_PROGRESS = 64,
        NSWF_FLAG_VIEWORDER = 128,
        NSWF_IGNORE_AUTOPLAY_HIDA = 256,
        NSWF_ASYNC = 512,
        NSWF_DONT_RESOLVE_LINKS = 1024,
        NSWF_ACCUMULATE_FOLDERS = 2048,
        NSWF_DONT_SORT = 4096,
        NSWF_USE_TRANSFER_MEDIUM = 8192,
        NSWF_DONT_TRAVERSE_STREAM_JUNCTIONS = 16384,
        NSWF_ANY_IMPLIES_ALL = 32768,
    };

    public enum tagBANDSITECID : int
    {
        BSID_BANDADDED = 0,
        BSID_BANDREMOVED = 1,
    };

    public enum tagCDBURNINGEXTENSIONRET : int
    {
        CDBE_RET_DEFAULT = 0,
        CDBE_RET_DONTRUNOTHEREXTS = 1,
        CDBE_RET_STOPWIZARD = 2,
    };

    public enum _CDBE_ACTIONS : int
    {
        CDBE_TYPE_MUSIC = 1,
        CDBE_TYPE_DATA = 2,
        CDBE_TYPE_ALL = -1,
    };

    public enum tagMENUBANDHANDLERCID : int
    {
        MBHANDCID_PIDLSELECT = 0,
    };

    public enum tagMENUPOPUPSELECT : int
    {
        MPOS_EXECUTE = 0,
        MPOS_FULLCANCEL = 1,
        MPOS_CANCELLEVEL = 2,
        MPOS_SELECTLEFT = 3,
        MPOS_SELECTRIGHT = 4,
        MPOS_CHILDTRACKING = 5,
    };

    public enum tagMENUPOPUPPOPUPFLAGS : int
    {
        MPPF_SETFOCUS = 1,
        MPPF_INITIALSELECT = 2,
        MPPF_NOANIMATE = 4,
        MPPF_KEYBOARD = 16,
        MPPF_REPOSITION = 32,
        MPPF_FORCEZORDER = 64,
        MPPF_FINALSELECT = 128,
        MPPF_TOP = 536870912,
        MPPF_LEFT = 1073741824,
        MPPF_RIGHT = 1610612736,
        MPPF_BOTTOM = -2147483648,
        MPPF_POS_MASK = -536870912,
        MPPF_ALIGN_LEFT = 33554432,
        MPPF_ALIGN_RIGHT = 67108864,
    };

    public enum _FILEOPENDIALOGOPTIONS : int
    {
        FOS_OVERWRITEPROMPT = 2,
        FOS_STRICTFILETYPES = 4,
        FOS_NOCHANGEDIR = 8,
        FOS_PICKFOLDERS = 32,
        FOS_FORCEFILESYSTEM = 64,
        FOS_ALLNONSTORAGEITEMS = 128,
        FOS_NOVALIDATE = 256,
        FOS_ALLOWMULTISELECT = 512,
        FOS_PATHMUSTEXIST = 2048,
        FOS_FILEMUSTEXIST = 4096,
        FOS_CREATEPROMPT = 8192,
        FOS_SHAREAWARE = 16384,
        FOS_NOREADONLYRETURN = 32768,
        FOS_NOTESTFILECREATE = 65536,
        FOS_HIDEMRUPLACES = 131072,
        FOS_HIDEPINNEDPLACES = 262144,
        FOS_NODEREFERENCELINKS = 1048576,
        FOS_DONTADDTORECENT = 33554432,
        FOS_FORCESHOWHIDDEN = 268435456,
        FOS_DEFAULTNOMINIMODE = 536870912,
        FOS_FORCEPREVIEWPANEON = 1073741824,
        FOS_SUPPORTSTREAMABLEITEMS = -2147483648,
    };

    public enum _BROWSERFRAMEOPTIONS : int
    {
        BFO_NONE = 0,
        BFO_BROWSER_PERSIST_SETTINGS = 1,
        BFO_RENAME_FOLDER_OPTIONS_TOINTERNET = 2,
        BFO_BOTH_OPTIONS = 4,
        BIF_PREFER_INTERNET_SHORTCUT = 8,
        BFO_BROWSE_NO_IN_NEW_PROCESS = 16,
        BFO_ENABLE_HYPERLINK_TRACKING = 32,
        BFO_USE_IE_OFFLINE_SUPPORT = 64,
        BFO_SUBSTITUE_INTERNET_START_PAGE = 128,
        BFO_USE_IE_LOGOBANDING = 256,
        BFO_ADD_IE_TOCAPTIONBAR = 512,
        BFO_USE_DIALUP_REF = 1024,
        BFO_USE_IE_TOOLBAR = 2048,
        BFO_NO_PARENT_FOLDER_SUPPORT = 4096,
        BFO_NO_REOPEN_NEXT_RESTART = 8192,
        BFO_GO_HOME_PAGE = 16384,
        BFO_PREFER_IEPROCESS = 32768,
        BFO_SHOW_NAVIGATION_CANCELLED = 65536,
        BFO_USE_IE_STATUSBAR = 131072,
        BFO_QUERY_ALL = -1,
    };

    public enum NWMF : int
    {
        NWMF_UNLOADING = 1,
        NWMF_USERINITED = 2,
        NWMF_FIRST = 4,
        NWMF_OVERRIDEKEY = 8,
        NWMF_SHOWHELP = 16,
        NWMF_HTMLDIALOG = 32,
        NWMF_FROMDIALOGCHILD = 64,
        NWMF_USERREQUESTED = 128,
        NWMF_USERALLOWED = 256,
        NWMF_FORCEWINDOW = 65536,
        NWMF_FORCETAB = 131072,
        NWMF_SUGGESTWINDOW = 262144,
        NWMF_SUGGESTTAB = 524288,
        NWMF_INACTIVETAB = 1048576,
    };

    public enum tagSMINFOMASK : int
    {
        SMIM_TYPE = 1,
        SMIM_FLAGS = 2,
        SMIM_ICON = 4,
    };

    public enum tagSMINFOTYPE : int
    {
        SMIT_SEPARATOR = 1,
        SMIT_STRING = 2,
    };

    public enum tagSMINFOFLAGS : int
    {
        SMIF_ICON = 1,
        SMIF_ACCELERATOR = 2,
        SMIF_DROPTARGET = 4,
        SMIF_SUBMENU = 8,
        SMIF_CHECKED = 32,
        SMIF_DROPCASCADE = 64,
        SMIF_HIDDEN = 128,
        SMIF_DISABLED = 256,
        SMIF_TRACKPOPUP = 512,
        SMIF_DEMOTED = 1024,
        SMIF_ALTSTATE = 2048,
        SMIF_DRAGNDROP = 4096,
        SMIF_NEW = 8192,
    };

    public enum _KF_DEFINITION_FLAGS : int
    {
        KFDF_LOCAL_REDIRECT_ONLY = 2,
        KFDF_ROAMABLE = 4,
        KFDF_PRECREATE = 8,
        KFDF_STREAM = 16,
        KFDF_PUBLISHEXPANDEDPATH = 32,
        KFDF_NO_REDIRECT_UI = 64,
    };

    public enum _KF_REDIRECT_FLAGS : int
    {
        KF_REDIRECT_USER_EXCLUSIVE = 1,
        KF_REDIRECT_COPY_SOURCE_DACL = 2,
        KF_REDIRECT_OWNER_USER = 4,
        KF_REDIRECT_SET_OWNER_EXPLICIT = 8,
        KF_REDIRECT_CHECK_ONLY = 16,
        KF_REDIRECT_WITH_UI = 32,
        KF_REDIRECT_UNPIN = 64,
        KF_REDIRECT_PIN = 128,
        KF_REDIRECT_COPY_CONTENTS = 512,
        KF_REDIRECT_DEL_SOURCE_CONTENTS = 1024,
        KF_REDIRECT_EXCLUDE_ALL_KNOWN_SUBFOLDERS = 2048,
    };

    public enum _KF_REDIRECTION_CAPABILITIES : int
    {
        KF_REDIRECTION_CAPABILITIES_ALLOW_ALL = 255,
        KF_REDIRECTION_CAPABILITIES_REDIRECTABLE = 1,
        KF_REDIRECTION_CAPABILITIES_DENY_ALL = 1048320,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY_REDIRECTED = 256,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY = 512,
        KF_REDIRECTION_CAPABILITIES_DENY_PERMISSIONS = 1024,
    };

    public enum _NMCII_FLAGS : int
    {
        NMCII_NONE = 0,
        NMCII_ITEMS = 1,
        NMCII_FOLDERS = 2,
    };

    public enum _NMCSAEI_FLAGS : int
    {
        NMCSAEI_SELECT = 0,
        NMCSAEI_EDIT = 1,
    };

    public enum _NSTCSTYLE : int
    {
        NSTCS_HASEXPANDOS = 1,
        NSTCS_HASLINES = 2,
        NSTCS_SINGLECLICKEXPAND = 4,
        NSTCS_FULLROWSELECT = 8,
        NSTCS_SPRINGEXPAND = 16,
        NSTCS_HORIZONTALSCROLL = 32,
        NSTCS_ROOTHASEXPANDO = 64,
        NSTCS_SHOWSELECTIONALWAYS = 128,
        NSTCS_NOINFOTIP = 512,
        NSTCS_EVENHEIGHT = 1024,
        NSTCS_NOREPLACEOPEN = 2048,
        NSTCS_DISABLEDRAGDROP = 4096,
        NSTCS_NOORDERSTREAM = 8192,
        NSTCS_RICHTOOLTIP = 16384,
        NSTCS_BORDER = 32768,
        NSTCS_NOEDITLABELS = 65536,
        NSTCS_TABSTOP = 131072,
        NSTCS_FAVORITESMODE = 524288,
        NSTCS_AUTOHSCROLL = 1048576,
        NSTCS_FADEINOUTEXPANDOS = 2097152,
        NSTCS_EMPTYTEXT = 4194304,
        NSTCS_CHECKBOXES = 8388608,
        NSTCS_PARTIALCHECKBOXES = 16777216,
        NSTCS_EXCLUSIONCHECKBOXES = 33554432,
        NSTCS_DIMMEDCHECKBOXES = 67108864,
        NSTCS_NOINDENTCHECKS = 134217728,
        NSTCS_ALLOWJUNCTIONS = 268435456,
        NSTCS_SHOWTABSBUTTON = 536870912,
        NSTCS_SHOWDELETEBUTTON = 1073741824,
        NSTCS_SHOWREFRESHBUTTON = -2147483648,
    };

    public enum _NSTCROOTSTYLE : int
    {
        NSTCRS_VISIBLE = 0,
        NSTCRS_HIDDEN = 1,
        NSTCRS_EXPANDED = 2,
    };

    public enum _NSTCITEMSTATE : int
    {
        NSTCIS_NONE = 0,
        NSTCIS_SELECTED = 1,
        NSTCIS_EXPANDED = 2,
        NSTCIS_BOLD = 4,
        NSTCIS_DISABLED = 8,
        NSTCIS_SELECTEDNOEXPAND = 16,
    };

    public enum _NSTCEHITTEST : int
    {
        NSTCEHT_NOWHERE = 1,
        NSTCEHT_ONITEMICON = 2,
        NSTCEHT_ONITEMLABEL = 4,
        NSTCEHT_ONITEMINDENT = 8,
        NSTCEHT_ONITEMBUTTON = 16,
        NSTCEHT_ONITEMRIGHT = 32,
        NSTCEHT_ONITEMSTATEICON = 64,
        NSTCEHT_ONITEM = 70,
        NSTCEHT_ONITEMTABBUTTON = 4096,
    };

    public enum _NSTCECLICKTYPE : int
    {
        NSTCECT_LBUTTON = 1,
        NSTCECT_MBUTTON = 2,
        NSTCECT_RBUTTON = 3,
        NSTCECT_BUTTON = 3,
        NSTCECT_DBLCLICK = 4,
    };

    public enum _EXPLORERPANESTATE : int
    {
        EPS_DONTCARE = 0,
        EPS_DEFAULT_ON = 1,
        EPS_DEFAULT_OFF = 2,
        EPS_STATEMASK = 65535,
        EPS_INITIALSTATE = 65536,
        EPS_FORCE = 131072,
    };

    public enum _EXPCMDSTATE : int
    {
        ECS_ENABLED = 0,
        ECS_DISABLED = 1,
        ECS_HIDDEN = 2,
        ECS_CHECKBOX = 4,
        ECS_CHECKED = 8,
        ECS_RADIOCHECK = 16,
    };

    public enum _EXPCMDFLAGS : int
    {
        ECF_DEFAULT = 0,
        ECF_HASSUBCOMMANDS = 1,
        ECF_HASSPLITBUTTON = 2,
        ECF_HIDELABEL = 4,
        ECF_ISSEPARATOR = 8,
        ECF_HASLUASHIELD = 16,
        ECF_SEPARATORBEFORE = 32,
        ECF_SEPARATORAFTER = 64,
        ECF_ISDROPDOWN = 128,
        ECF_TOGGLEABLE = 256,
        ECF_AUTOMENUICONS = 512,
    };

    public enum MARKUPSIZE : int
    {
        MARKUPSIZE_CALCWIDTH = 0,
        MARKUPSIZE_CALCHEIGHT = 1,
    };

    public enum MARKUPLINKTEXT : int
    {
        MARKUPLINKTEXT_URL = 0,
        MARKUPLINKTEXT_ID = 1,
        MARKUPLINKTEXT_TEXT = 2,
    };

    public enum _MARKUPSTATE : int
    {
        MARKUPSTATE_FOCUSED = 1,
        MARKUPSTATE_ENABLED = 2,
        MARKUPSTATE_VISITED = 4,
        MARKUPSTATE_HOT = 8,
        MARKUPSTATE_DEFAULTCOLORS = 16,
        MARKUPSTATE_ALLOWMARKUP = 1073741824,
    };

    public enum MARKUPMESSAGE : int
    {
        MARKUPMESSAGE_KEYEXECUTE = 0,
        MARKUPMESSAGE_CLICKEXECUTE = 1,
        MARKUPMESSAGE_WANTFOCUS = 2,
    };

    public enum LIBRARYMANAGEDIALOGOPTIONS : int
    {
        LMD_DEFAULT = 0,
        LMD_ALLOWUNINDEXABLENETWORKLOCATIONS = 1,
    };

    public enum ASSOC_FILTER : int
    {
        ASSOC_FILTER_NONE = 0,
        ASSOC_FILTER_RECOMMENDED = 1,
    };

    public enum WTS_FLAGS : int
    {
        WTS_NONE = 0,
        WTS_EXTRACT = 0,
        WTS_INCACHEONLY = 1,
        WTS_FASTEXTRACT = 2,
        WTS_FORCEEXTRACTION = 4,
        WTS_SLOWRECLAIM = 8,
        WTS_EXTRACTDONOTCACHE = 32,
        WTS_SCALETOREQUESTEDSIZE = 64,
        WTS_SKIPFASTEXTRACT = 128,
        WTS_EXTRACTINPROC = 256,
        WTS_CROPTOSQUARE = 512,
        WTS_INSTANCESURROGATE = 1024,
        WTS_REQUIRESURROGATE = 2048,
        WTS_APPSTYLE = 8192,
        WTS_WIDETHUMBNAILS = 16384,
        WTS_IDEALCACHESIZEONLY = 32768,
        WTS_SCALEUP = 65536,
    };

    public enum WTS_CACHEFLAGS : int
    {
        WTS_DEFAULT = 0,
        WTS_LOWQUALITY = 1,
        WTS_CACHED = 2,
    };

    public enum WTS_CONTEXTFLAGS : int
    {
        WTSCF_DEFAULT = 0,
        WTSCF_APPSTYLE = 1,
        WTSCF_SQUARE = 2,
        WTSCF_WIDE = 4,
        WTSCF_FAST = 8,
    };

    public enum tagIFILTER_INIT : int
    {
        IFILTER_INIT_CANON_PARAGRAPHS = 1,
        IFILTER_INIT_HARD_LINE_BREAKS = 2,
        IFILTER_INIT_CANON_HYPHENS = 4,
        IFILTER_INIT_CANON_SPACES = 8,
        IFILTER_INIT_APPLY_INDEX_ATTRIBUTES = 16,
        IFILTER_INIT_APPLY_OTHER_ATTRIBUTES = 32,
        IFILTER_INIT_APPLY_CRAWL_ATTRIBUTES = 256,
        IFILTER_INIT_INDEXING_ONLY = 64,
        IFILTER_INIT_SEARCH_LINKS = 128,
        IFILTER_INIT_FILTER_OWNED_VALUE_OK = 512,
        IFILTER_INIT_FILTER_AGGRESSIVE_BREAK = 1024,
        IFILTER_INIT_DISABLE_EMBEDDED = 2048,
        IFILTER_INIT_EMIT_FORMATTING = 4096,
    };

    public enum tagIFILTER_FLAGS : int
    {
        IFILTER_FLAGS_OLE_PROPERTIES = 1,
    };

    public enum IPPROTO : int
    {
        IPPROTO_HOPOPTS = 0,
        IPPROTO_ICMP = 1,
        IPPROTO_IGMP = 2,
        IPPROTO_GGP = 3,
        IPPROTO_IPV4 = 4,
        IPPROTO_ST = 5,
        IPPROTO_TCP = 6,
        IPPROTO_CBT = 7,
        IPPROTO_EGP = 8,
        IPPROTO_IGP = 9,
        IPPROTO_PUP = 12,
        IPPROTO_UDP = 17,
        IPPROTO_IDP = 22,
        IPPROTO_RDP = 27,
        IPPROTO_IPV6 = 41,
        IPPROTO_ROUTING = 43,
        IPPROTO_FRAGMENT = 44,
        IPPROTO_ESP = 50,
        IPPROTO_AH = 51,
        IPPROTO_ICMPV6 = 58,
        IPPROTO_NONE = 59,
        IPPROTO_DSTOPTS = 60,
        IPPROTO_ND = 77,
        IPPROTO_ICLFXBM = 78,
        IPPROTO_PIM = 103,
        IPPROTO_PGM = 113,
        IPPROTO_L2TP = 115,
        IPPROTO_SCTP = 132,
        IPPROTO_RAW = 255,
        IPPROTO_MAX = 256,
        IPPROTO_RESERVED_RAW = 257,
        IPPROTO_RESERVED_IPSEC = 258,
        IPPROTO_RESERVED_IPSECOFFLOAD = 259,
        IPPROTO_RESERVED_WNV = 260,
        IPPROTO_RESERVED_MAX = 261,
    };

    public enum SCOPE_LEVEL : int
    {
        ScopeLevelInterface = 1,
        ScopeLevelLink = 2,
        ScopeLevelSubnet = 3,
        ScopeLevelAdmin = 4,
        ScopeLevelSite = 5,
        ScopeLevelOrganization = 8,
        ScopeLevelGlobal = 14,
        ScopeLevelCount = 16,
    };

    public enum _WSACOMPLETIONTYPE : int
    {
        NSP_NOTIFY_IMMEDIATELY = 0,
        NSP_NOTIFY_HWND,
        NSP_NOTIFY_EVENT,
        NSP_NOTIFY_PORT,
        NSP_NOTIFY_APC,
    };

    public enum _WSAEcomparator : int
    {
        COMP_EQUAL = 0,
        COMP_NOTLESS,
    };

    public enum _WSAESETSERVICEOP : int
    {
        RNRSERVICE_REGISTER = 0,
        RNRSERVICE_DEREGISTER,
        RNRSERVICE_DELETE,
    };

    public enum AnnoScope : int
    {
        ANNO_THIS = 0,
        ANNO_CONTAINER = 1,
    };

    public enum tagDOCHOSTUIDBLCLKDispatch : int
    {
        docHostUIDblClkDEFAULT = 0,
        docHostUIDblClkSHOWPROPERTIES = 1,
        docHostUIDblClkSHOWCODE = 2,
    };

    public enum tagDocHostUIFlagDispatch : int
    {
        docHostUIFlagDIALOG = 1,
        docHostUIFlagDISABLE_HELP_MENU = 2,
        docHostUIFlagNO3DBORDER = 4,
        docHostUIFlagSCROLL_NO = 8,
        docHostUIFlagDISABLE_SCRIPT_INACTIVE = 16,
        docHostUIFlagOPENNEWWIN = 32,
        docHostUIFlagDISABLE_OFFSCREEN = 64,
        docHostUIFlagFLAT_SCROLLBAR = 128,
        docHostUIFlagDIV_BLOCKDEFAULT = 256,
        docHostUIFlagACTIVATE_CLIENTHIT_ONLY = 512,
    };

    public enum _crt_argv_mode : int
    {
        _crt_argv_no_arguments,
        _crt_argv_unexpanded_arguments,
        _crt_argv_expanded_arguments,
    };

    public enum _crt_exit_return_mode : int
    {
        _crt_exit_terminate_process,
        _crt_exit_return_to_caller,
    };

    public enum _crt_exit_cleanup_mode : int
    {
        _crt_exit_full_cleanup,
        _crt_exit_quick_cleanup,
        _crt_exit_no_cleanup,
    };

    public enum _crt_app_type : int
    {
        _crt_unknown_app,
        _crt_console_app,
        _crt_gui_app,
    };

    public enum tagSFBS_FLAGS : int
    {
        SFBS_FLAGS_ROUND_TO_NEAREST_DISPLAYED_DIGIT = 1,
        SFBS_FLAGS_TRUNCATE_UNDISPLAYED_DECIMAL_DIGITS = 2,
    };

    public enum URL_SCHEME : int
    {
        URL_SCHEME_INVALID = -1,
        URL_SCHEME_UNKNOWN = 0,
        URL_SCHEME_FTP,
        URL_SCHEME_HTTP,
        URL_SCHEME_GOPHER,
        URL_SCHEME_MAILTO,
        URL_SCHEME_NEWS,
        URL_SCHEME_NNTP,
        URL_SCHEME_TELNET,
        URL_SCHEME_WAIS,
        URL_SCHEME_FILE,
        URL_SCHEME_MK,
        URL_SCHEME_HTTPS,
        URL_SCHEME_SHELL,
        URL_SCHEME_SNEWS,
        URL_SCHEME_LOCAL,
        URL_SCHEME_JAVASCRIPT,
        URL_SCHEME_VBSCRIPT,
        URL_SCHEME_ABOUT,
        URL_SCHEME_RES,
        URL_SCHEME_MSSHELLROOTED,
        URL_SCHEME_MSSHELLIDLIST,
        URL_SCHEME_MSHELP,
        URL_SCHEME_MSSHELLDEVICE,
        URL_SCHEME_WILDCARD,
        URL_SCHEME_SEARCH_MS,
        URL_SCHEME_SEARCH,
        URL_SCHEME_KNOWNFOLDER,
        URL_SCHEME_MAXVALUE,
    };

    public enum URL_PART : int
    {
        URL_PART_NONE = 0,
        URL_PART_SCHEME = 1,
        URL_PART_HOSTNAME,
        URL_PART_USERNAME,
        URL_PART_PASSWORD,
        URL_PART_PORT,
        URL_PART_QUERY,
    };

    public enum URLIS : int
    {
        URLIS_URL,
        URLIS_OPAQUE,
        URLIS_NOHISTORY,
        URLIS_FILEURL,
        URLIS_APPLIABLE,
        URLIS_DIRECTORY,
        URLIS_HASQUERY,
    };

    public enum SHREGDEL_FLAGS : int
    {
        SHREGDEL_DEFAULT = 0,
        SHREGDEL_HKCU = 1,
        SHREGDEL_HKLM = 16,
        SHREGDEL_BOTH = 17,
    };

    public enum SHREGENUM_FLAGS : int
    {
        SHREGENUM_DEFAULT = 0,
        SHREGENUM_HKCU = 1,
        SHREGENUM_HKLM = 16,
        SHREGENUM_BOTH = 17,
    };

    public enum ASSOCSTR : int
    {
        ASSOCSTR_COMMAND = 1,
        ASSOCSTR_EXECUTABLE,
        ASSOCSTR_FRIENDLYDOCNAME,
        ASSOCSTR_FRIENDLYAPPNAME,
        ASSOCSTR_NOOPEN,
        ASSOCSTR_SHELLNEWVALUE,
        ASSOCSTR_DDECOMMAND,
        ASSOCSTR_DDEIFEXEC,
        ASSOCSTR_DDEAPPLICATION,
        ASSOCSTR_DDETOPIC,
        ASSOCSTR_INFOTIP,
        ASSOCSTR_QUICKTIP,
        ASSOCSTR_TILEINFO,
        ASSOCSTR_CONTENTTYPE,
        ASSOCSTR_DEFAULTICON,
        ASSOCSTR_SHELLEXTENSION,
        ASSOCSTR_SUPPORTED_URI_PROTOCOLS,
        ASSOCSTR_MAX,
    };

    public enum ASSOCKEY : int
    {
        ASSOCKEY_SHELLEXECCLASS = 1,
        ASSOCKEY_APP,
        ASSOCKEY_CLASS,
        ASSOCKEY_BASECLASS,
        ASSOCKEY_MAX,
    };

    public enum ASSOCDATA : int
    {
        ASSOCDATA_MSIDESCRIPTOR = 1,
        ASSOCDATA_NOACTIVATEHANDLER,
        ASSOCDATA_QUERYCLASSSTORE,
        ASSOCDATA_HASPERUSERASSOC,
        ASSOCDATA_EDITFLAGS,
        ASSOCDATA_VALUE,
        ASSOCDATA_MAX,
    };

    public enum ASSOCENUM : int
    {
        ASSOCENUM_NONE,
    };

    public enum FILETYPEATTRIBUTEFLAGS : int
    {
        FTA_None = 0,
        FTA_Exclude = 1,
        FTA_Show = 2,
        FTA_HasExtension = 4,
        FTA_NoEdit = 8,
        FTA_NoRemove = 16,
        FTA_NoNewVerb = 32,
        FTA_NoEditVerb = 64,
        FTA_NoRemoveVerb = 128,
        FTA_NoEditDesc = 256,
        FTA_NoEditIcon = 512,
        FTA_NoEditDflt = 1024,
        FTA_NoEditVerbCmd = 2048,
        FTA_NoEditVerbExe = 4096,
        FTA_NoDDE = 8192,
        FTA_NoEditMIME = 32768,
        FTA_OpenIsSafe = 65536,
        FTA_AlwaysUnsafe = 131072,
        FTA_NoRecentDocs = 1048576,
        FTA_SafeForElevation = 2097152,
        FTA_AlwaysUseDirectInvoke = 4194304,
    };

    public enum SHGLOBALCOUNTER : int
    {
        GLOBALCOUNTER_SEARCHMANAGER,
        GLOBALCOUNTER_SEARCHOPTIONS,
        GLOBALCOUNTER_FOLDERSETTINGSCHANGE,
        GLOBALCOUNTER_RATINGS,
        GLOBALCOUNTER_APPROVEDSITES,
        GLOBALCOUNTER_RESTRICTIONS,
        GLOBALCOUNTER_SHELLSETTINGSCHANGED,
        GLOBALCOUNTER_SYSTEMPIDLCHANGE,
        GLOBALCOUNTER_OVERLAYMANAGER,
        GLOBALCOUNTER_QUERYASSOCIATIONS,
        GLOBALCOUNTER_IESESSIONS,
        GLOBALCOUNTER_IEONLY_SESSIONS,
        GLOBALCOUNTER_APPLICATION_DESTINATIONS,
        __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_CSCSYNCINPROGRESS,
        GLOBALCOUNTER_BITBUCKETNUMDELETERS,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SHARES,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_A,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_B,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_C,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_D,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_E,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_F,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_G,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_H,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_I,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_J,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_K,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_L,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_M,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_N,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_O,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_P,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Q,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_R,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_S,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_T,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_U,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_V,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_W,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_X,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Y,
        GLOBALCOUNTER_RECYCLEDIRTYCOUNT_DRIVE_Z,
        __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEDIRTYCOUNT_SERVERDRIVE,
        __UNUSED_RECYCLE_WAS_GLOBALCOUNTER_RECYCLEGLOBALDIRTYCOUNT,
        GLOBALCOUNTER_RECYCLEBINENUM,
        GLOBALCOUNTER_RECYCLEBINCORRUPTED,
        GLOBALCOUNTER_RATINGS_STATECOUNTER,
        GLOBALCOUNTER_PRIVATE_PROFILE_CACHE,
        GLOBALCOUNTER_INTERNETTOOLBAR_LAYOUT,
        GLOBALCOUNTER_FOLDERDEFINITION_CACHE,
        GLOBALCOUNTER_COMMONPLACES_LIST_CACHE,
        GLOBALCOUNTER_PRIVATE_PROFILE_CACHE_MACHINEWIDE,
        GLOBALCOUNTER_ASSOCCHANGED,
        GLOBALCOUNTER_APP_ITEMS_STATE_STORE_CACHE,
        GLOBALCOUNTER_SETTINGSYNC_ENABLED,
        GLOBALCOUNTER_APPSFOLDER_FILETYPEASSOCIATION_COUNTER,
        GLOBALCOUNTER_USERINFOCHANGED,
        GLOBALCOUNTER_SYNC_ENGINE_INFORMATION_CACHE_MACHINEWIDE,
        GLOBALCOUNTER_MAXIMUMVALUE,
    };

    public enum _PROPERTY_UNITS : int
    {
        PROPERTY_UNITS_DEFAULT = 0,
        PROPERTY_UNITS_INCHES = 1,
        PROPERTY_UNITS_CENTIMETERS = 2,
        PROPERTY_UNITS_DEGREES = 3,
        PROPERTY_UNITS_RADIANS = 4,
        PROPERTY_UNITS_SECONDS = 5,
        PROPERTY_UNITS_POUNDS = 6,
        PROPERTY_UNITS_GRAMS = 7,
        PROPERTY_UNITS_SILINEAR = 8,
        PROPERTY_UNITS_SIROTATION = 9,
        PROPERTY_UNITS_ENGLINEAR = 10,
        PROPERTY_UNITS_ENGROTATION = 11,
        PROPERTY_UNITS_SLUGS = 12,
        PROPERTY_UNITS_KELVIN = 13,
        PROPERTY_UNITS_FAHRENHEIT = 14,
        PROPERTY_UNITS_AMPERE = 15,
        PROPERTY_UNITS_CANDELA = 16,
    };

    public enum AEROWIZARDPARTS : int
    {
        AW_TITLEBAR = 1,
        AW_HEADERAREA = 2,
        AW_CONTENTAREA = 3,
        AW_COMMANDAREA = 4,
        AW_BUTTON = 5,
    };

    public enum TITLEBARSTATES : int
    {
        AW_S_TITLEBAR_ACTIVE = 1,
        AW_S_TITLEBAR_INACTIVE = 2,
    };

    public enum HEADERAREASTATES : int
    {
        AW_S_HEADERAREA_NOMARGIN = 1,
    };

    public enum CONTENTAREASTATES : int
    {
        AW_S_CONTENTAREA_NOMARGIN = 1,
    };

    public enum BUTTONPARTS : int
    {
        BP_PUSHBUTTON = 1,
        BP_RADIOBUTTON = 2,
        BP_CHECKBOX = 3,
        BP_GROUPBOX = 4,
        BP_USERBUTTON = 5,
        BP_COMMANDLINK = 6,
        BP_COMMANDLINKGLYPH = 7,
    };

    public enum PUSHBUTTONSTATES : int
    {
        PBS_NORMAL = 1,
        PBS_HOT = 2,
        PBS_PRESSED = 3,
        PBS_DISABLED = 4,
        PBS_DEFAULTED = 5,
        PBS_DEFAULTED_ANIMATING = 6,
    };

    public enum RADIOBUTTONSTATES : int
    {
        RBS_UNCHECKEDNORMAL = 1,
        RBS_UNCHECKEDHOT = 2,
        RBS_UNCHECKEDPRESSED = 3,
        RBS_UNCHECKEDDISABLED = 4,
        RBS_CHECKEDNORMAL = 5,
        RBS_CHECKEDHOT = 6,
        RBS_CHECKEDPRESSED = 7,
        RBS_CHECKEDDISABLED = 8,
    };

    public enum CHECKBOXSTATES : int
    {
        CBS_UNCHECKEDNORMAL = 1,
        CBS_UNCHECKEDHOT = 2,
        CBS_UNCHECKEDPRESSED = 3,
        CBS_UNCHECKEDDISABLED = 4,
        CBS_CHECKEDNORMAL = 5,
        CBS_CHECKEDHOT = 6,
        CBS_CHECKEDPRESSED = 7,
        CBS_CHECKEDDISABLED = 8,
        CBS_MIXEDNORMAL = 9,
        CBS_MIXEDHOT = 10,
        CBS_MIXEDPRESSED = 11,
        CBS_MIXEDDISABLED = 12,
        CBS_IMPLICITNORMAL = 13,
        CBS_IMPLICITHOT = 14,
        CBS_IMPLICITPRESSED = 15,
        CBS_IMPLICITDISABLED = 16,
        CBS_EXCLUDEDNORMAL = 17,
        CBS_EXCLUDEDHOT = 18,
        CBS_EXCLUDEDPRESSED = 19,
        CBS_EXCLUDEDDISABLED = 20,
    };

    public enum GROUPBOXSTATES : int
    {
        GBS_NORMAL = 1,
        GBS_DISABLED = 2,
    };

    public enum COMMANDLINKSTATES : int
    {
        CMDLS_NORMAL = 1,
        CMDLS_HOT = 2,
        CMDLS_PRESSED = 3,
        CMDLS_DISABLED = 4,
        CMDLS_DEFAULTED = 5,
        CMDLS_DEFAULTED_ANIMATING = 6,
    };

    public enum COMMANDLINKGLYPHSTATES : int
    {
        CMDLGS_NORMAL = 1,
        CMDLGS_HOT = 2,
        CMDLGS_PRESSED = 3,
        CMDLGS_DISABLED = 4,
        CMDLGS_DEFAULTED = 5,
    };

    public enum COMBOBOXPARTS : int
    {
        CP_DROPDOWNBUTTON = 1,
        CP_BACKGROUND = 2,
        CP_TRANSPARENTBACKGROUND = 3,
        CP_BORDER = 4,
        CP_READONLY = 5,
        CP_DROPDOWNBUTTONRIGHT = 6,
        CP_DROPDOWNBUTTONLEFT = 7,
        CP_CUEBANNER = 8,
    };

    public enum COMBOBOXSTYLESTATES : int
    {
        CBXS_NORMAL = 1,
        CBXS_HOT = 2,
        CBXS_PRESSED = 3,
        CBXS_DISABLED = 4,
    };

    public enum DROPDOWNBUTTONRIGHTSTATES : int
    {
        CBXSR_NORMAL = 1,
        CBXSR_HOT = 2,
        CBXSR_PRESSED = 3,
        CBXSR_DISABLED = 4,
    };

    public enum DROPDOWNBUTTONLEFTSTATES : int
    {
        CBXSL_NORMAL = 1,
        CBXSL_HOT = 2,
        CBXSL_PRESSED = 3,
        CBXSL_DISABLED = 4,
    };

    public enum TRANSPARENTBACKGROUNDSTATES : int
    {
        CBTBS_NORMAL = 1,
        CBTBS_HOT = 2,
        CBTBS_DISABLED = 3,
        CBTBS_FOCUSED = 4,
    };

    public enum BORDERSTATES : int
    {
        CBB_NORMAL = 1,
        CBB_HOT = 2,
        CBB_FOCUSED = 3,
        CBB_DISABLED = 4,
    };

    public enum READONLYSTATES : int
    {
        CBRO_NORMAL = 1,
        CBRO_HOT = 2,
        CBRO_PRESSED = 3,
        CBRO_DISABLED = 4,
    };

    public enum CUEBANNERSTATES : int
    {
        CBCB_NORMAL = 1,
        CBCB_HOT = 2,
        CBCB_PRESSED = 3,
        CBCB_DISABLED = 4,
    };

    public enum COMMUNICATIONSPARTS : int
    {
        CSST_TAB = 1,
    };

    public enum TABSTATES : int
    {
        CSTB_NORMAL = 1,
        CSTB_HOT = 2,
        CSTB_SELECTED = 3,
    };

    public enum CONTROLPANELPARTS : int
    {
        CPANEL_NAVIGATIONPANE = 1,
        CPANEL_CONTENTPANE = 2,
        CPANEL_NAVIGATIONPANELABEL = 3,
        CPANEL_CONTENTPANELABEL = 4,
        CPANEL_TITLE = 5,
        CPANEL_BODYTEXT = 6,
        CPANEL_HELPLINK = 7,
        CPANEL_TASKLINK = 8,
        CPANEL_GROUPTEXT = 9,
        CPANEL_CONTENTLINK = 10,
        CPANEL_SECTIONTITLELINK = 11,
        CPANEL_LARGECOMMANDAREA = 12,
        CPANEL_SMALLCOMMANDAREA = 13,
        CPANEL_BUTTON = 14,
        CPANEL_MESSAGETEXT = 15,
        CPANEL_NAVIGATIONPANELINE = 16,
        CPANEL_CONTENTPANELINE = 17,
        CPANEL_BANNERAREA = 18,
        CPANEL_BODYTITLE = 19,
    };

    public enum HELPLINKSTATES : int
    {
        CPHL_NORMAL = 1,
        CPHL_HOT = 2,
        CPHL_PRESSED = 3,
        CPHL_DISABLED = 4,
    };

    public enum TASKLINKSTATES : int
    {
        CPTL_NORMAL = 1,
        CPTL_HOT = 2,
        CPTL_PRESSED = 3,
        CPTL_DISABLED = 4,
        CPTL_PAGE = 5,
    };

    public enum CONTENTLINKSTATES : int
    {
        CPCL_NORMAL = 1,
        CPCL_HOT = 2,
        CPCL_PRESSED = 3,
        CPCL_DISABLED = 4,
    };

    public enum SECTIONTITLELINKSTATES : int
    {
        CPSTL_NORMAL = 1,
        CPSTL_HOT = 2,
    };

    public enum DATEPICKERPARTS : int
    {
        DP_DATETEXT = 1,
        DP_DATEBORDER = 2,
        DP_SHOWCALENDARBUTTONRIGHT = 3,
    };

    public enum DATETEXTSTATES : int
    {
        DPDT_NORMAL = 1,
        DPDT_DISABLED = 2,
        DPDT_SELECTED = 3,
    };

    public enum DATEBORDERSTATES : int
    {
        DPDB_NORMAL = 1,
        DPDB_HOT = 2,
        DPDB_FOCUSED = 3,
        DPDB_DISABLED = 4,
    };

    public enum SHOWCALENDARBUTTONRIGHTSTATES : int
    {
        DPSCBR_NORMAL = 1,
        DPSCBR_HOT = 2,
        DPSCBR_PRESSED = 3,
        DPSCBR_DISABLED = 4,
    };

    public enum DRAGDROPPARTS : int
    {
        DD_COPY = 1,
        DD_MOVE = 2,
        DD_UPDATEMETADATA = 3,
        DD_CREATELINK = 4,
        DD_WARNING = 5,
        DD_NONE = 6,
        DD_IMAGEBG = 7,
        DD_TEXTBG = 8,
    };

    public enum COPYSTATES : int
    {
        DDCOPY_HIGHLIGHT = 1,
        DDCOPY_NOHIGHLIGHT = 2,
    };

    public enum MOVESTATES : int
    {
        DDMOVE_HIGHLIGHT = 1,
        DDMOVE_NOHIGHLIGHT = 2,
    };

    public enum UPDATEMETADATASTATES : int
    {
        DDUPDATEMETADATA_HIGHLIGHT = 1,
        DDUPDATEMETADATA_NOHIGHLIGHT = 2,
    };

    public enum CREATELINKSTATES : int
    {
        DDCREATELINK_HIGHLIGHT = 1,
        DDCREATELINK_NOHIGHLIGHT = 2,
    };

    public enum WARNINGSTATES : int
    {
        DDWARNING_HIGHLIGHT = 1,
        DDWARNING_NOHIGHLIGHT = 2,
    };

    public enum NONESTATES : int
    {
        DDNONE_HIGHLIGHT = 1,
        DDNONE_NOHIGHLIGHT = 2,
    };

    public enum EDITPARTS : int
    {
        EP_EDITTEXT = 1,
        EP_CARET = 2,
        EP_BACKGROUND = 3,
        EP_PASSWORD = 4,
        EP_BACKGROUNDWITHBORDER = 5,
        EP_EDITBORDER_NOSCROLL = 6,
        EP_EDITBORDER_HSCROLL = 7,
        EP_EDITBORDER_VSCROLL = 8,
        EP_EDITBORDER_HVSCROLL = 9,
    };

    public enum EDITTEXTSTATES : int
    {
        ETS_NORMAL = 1,
        ETS_HOT = 2,
        ETS_SELECTED = 3,
        ETS_DISABLED = 4,
        ETS_FOCUSED = 5,
        ETS_READONLY = 6,
        ETS_ASSIST = 7,
        ETS_CUEBANNER = 8,
    };

    public enum BACKGROUNDSTATES : int
    {
        EBS_NORMAL = 1,
        EBS_HOT = 2,
        EBS_DISABLED = 3,
        EBS_FOCUSED = 4,
        EBS_READONLY = 5,
        EBS_ASSIST = 6,
    };

    public enum BACKGROUNDWITHBORDERSTATES : int
    {
        EBWBS_NORMAL = 1,
        EBWBS_HOT = 2,
        EBWBS_DISABLED = 3,
        EBWBS_FOCUSED = 4,
    };

    public enum EDITBORDER_NOSCROLLSTATES : int
    {
        EPSN_NORMAL = 1,
        EPSN_HOT = 2,
        EPSN_FOCUSED = 3,
        EPSN_DISABLED = 4,
    };

    public enum EDITBORDER_HSCROLLSTATES : int
    {
        EPSH_NORMAL = 1,
        EPSH_HOT = 2,
        EPSH_FOCUSED = 3,
        EPSH_DISABLED = 4,
    };

    public enum EDITBORDER_VSCROLLSTATES : int
    {
        EPSV_NORMAL = 1,
        EPSV_HOT = 2,
        EPSV_FOCUSED = 3,
        EPSV_DISABLED = 4,
    };

    public enum EDITBORDER_HVSCROLLSTATES : int
    {
        EPSHV_NORMAL = 1,
        EPSHV_HOT = 2,
        EPSHV_FOCUSED = 3,
        EPSHV_DISABLED = 4,
    };

    public enum EXPLORERBARPARTS : int
    {
        EBP_HEADERBACKGROUND = 1,
        EBP_HEADERCLOSE = 2,
        EBP_HEADERPIN = 3,
        EBP_IEBARMENU = 4,
        EBP_NORMALGROUPBACKGROUND = 5,
        EBP_NORMALGROUPCOLLAPSE = 6,
        EBP_NORMALGROUPEXPAND = 7,
        EBP_NORMALGROUPHEAD = 8,
        EBP_SPECIALGROUPBACKGROUND = 9,
        EBP_SPECIALGROUPCOLLAPSE = 10,
        EBP_SPECIALGROUPEXPAND = 11,
        EBP_SPECIALGROUPHEAD = 12,
    };

    public enum HEADERCLOSESTATES : int
    {
        EBHC_NORMAL = 1,
        EBHC_HOT = 2,
        EBHC_PRESSED = 3,
    };

    public enum HEADERPINSTATES : int
    {
        EBHP_NORMAL = 1,
        EBHP_HOT = 2,
        EBHP_PRESSED = 3,
        EBHP_SELECTEDNORMAL = 4,
        EBHP_SELECTEDHOT = 5,
        EBHP_SELECTEDPRESSED = 6,
    };

    public enum IEBARMENUSTATES : int
    {
        EBM_NORMAL = 1,
        EBM_HOT = 2,
        EBM_PRESSED = 3,
    };

    public enum NORMALGROUPCOLLAPSESTATES : int
    {
        EBNGC_NORMAL = 1,
        EBNGC_HOT = 2,
        EBNGC_PRESSED = 3,
    };

    public enum NORMALGROUPEXPANDSTATES : int
    {
        EBNGE_NORMAL = 1,
        EBNGE_HOT = 2,
        EBNGE_PRESSED = 3,
    };

    public enum SPECIALGROUPCOLLAPSESTATES : int
    {
        EBSGC_NORMAL = 1,
        EBSGC_HOT = 2,
        EBSGC_PRESSED = 3,
    };

    public enum SPECIALGROUPEXPANDSTATES : int
    {
        EBSGE_NORMAL = 1,
        EBSGE_HOT = 2,
        EBSGE_PRESSED = 3,
    };

    public enum FLYOUTPARTS : int
    {
        FLYOUT_HEADER = 1,
        FLYOUT_BODY = 2,
        FLYOUT_LABEL = 3,
        FLYOUT_LINK = 4,
        FLYOUT_DIVIDER = 5,
        FLYOUT_WINDOW = 6,
        FLYOUT_LINKAREA = 7,
        FLYOUT_LINKHEADER = 8,
    };

    public enum LABELSTATES : int
    {
        FLS_NORMAL = 1,
        FLS_SELECTED = 2,
        FLS_EMPHASIZED = 3,
        FLS_DISABLED = 4,
    };

    public enum LINKSTATES : int
    {
        FLYOUTLINK_NORMAL = 1,
        FLYOUTLINK_HOVER = 2,
    };

    public enum BODYSTATES : int
    {
        FBS_NORMAL = 1,
        FBS_EMPHASIZED = 2,
    };

    public enum LINKHEADERSTATES : int
    {
        FLH_NORMAL = 1,
        FLH_HOVER = 2,
    };

    public enum HEADERPARTS : int
    {
        HP_HEADERITEM = 1,
        HP_HEADERITEMLEFT = 2,
        HP_HEADERITEMRIGHT = 3,
        HP_HEADERSORTARROW = 4,
        HP_HEADERDROPDOWN = 5,
        HP_HEADERDROPDOWNFILTER = 6,
        HP_HEADEROVERFLOW = 7,
    };

    public enum HEADERSTYLESTATES : int
    {
        HBG_DETAILS = 1,
        HBG_ICON = 2,
    };

    public enum HEADERITEMSTATES : int
    {
        HIS_NORMAL = 1,
        HIS_HOT = 2,
        HIS_PRESSED = 3,
        HIS_SORTEDNORMAL = 4,
        HIS_SORTEDHOT = 5,
        HIS_SORTEDPRESSED = 6,
        HIS_ICONNORMAL = 7,
        HIS_ICONHOT = 8,
        HIS_ICONPRESSED = 9,
        HIS_ICONSORTEDNORMAL = 10,
        HIS_ICONSORTEDHOT = 11,
        HIS_ICONSORTEDPRESSED = 12,
    };

    public enum HEADERITEMLEFTSTATES : int
    {
        HILS_NORMAL = 1,
        HILS_HOT = 2,
        HILS_PRESSED = 3,
    };

    public enum HEADERITEMRIGHTSTATES : int
    {
        HIRS_NORMAL = 1,
        HIRS_HOT = 2,
        HIRS_PRESSED = 3,
    };

    public enum HEADERSORTARROWSTATES : int
    {
        HSAS_SORTEDUP = 1,
        HSAS_SORTEDDOWN = 2,
    };

    public enum HEADERDROPDOWNSTATES : int
    {
        HDDS_NORMAL = 1,
        HDDS_SOFTHOT = 2,
        HDDS_HOT = 3,
    };

    public enum HEADERDROPDOWNFILTERSTATES : int
    {
        HDDFS_NORMAL = 1,
        HDDFS_SOFTHOT = 2,
        HDDFS_HOT = 3,
    };

    public enum HEADEROVERFLOWSTATES : int
    {
        HOFS_NORMAL = 1,
        HOFS_HOT = 2,
    };

    public enum LISTBOXPARTS : int
    {
        LBCP_BORDER_HSCROLL = 1,
        LBCP_BORDER_HVSCROLL = 2,
        LBCP_BORDER_NOSCROLL = 3,
        LBCP_BORDER_VSCROLL = 4,
        LBCP_ITEM = 5,
    };

    public enum BORDER_HSCROLLSTATES : int
    {
        LBPSH_NORMAL = 1,
        LBPSH_FOCUSED = 2,
        LBPSH_HOT = 3,
        LBPSH_DISABLED = 4,
    };

    public enum BORDER_HVSCROLLSTATES : int
    {
        LBPSHV_NORMAL = 1,
        LBPSHV_FOCUSED = 2,
        LBPSHV_HOT = 3,
        LBPSHV_DISABLED = 4,
    };

    public enum BORDER_NOSCROLLSTATES : int
    {
        LBPSN_NORMAL = 1,
        LBPSN_FOCUSED = 2,
        LBPSN_HOT = 3,
        LBPSN_DISABLED = 4,
    };

    public enum BORDER_VSCROLLSTATES : int
    {
        LBPSV_NORMAL = 1,
        LBPSV_FOCUSED = 2,
        LBPSV_HOT = 3,
        LBPSV_DISABLED = 4,
    };

    public enum ITEMSTATES : int
    {
        LBPSI_HOT = 1,
        LBPSI_HOTSELECTED = 2,
        LBPSI_SELECTED = 3,
        LBPSI_SELECTEDNOTFOCUS = 4,
    };

    public enum LISTVIEWPARTS : int
    {
        LVP_LISTITEM = 1,
        LVP_LISTGROUP = 2,
        LVP_LISTDETAIL = 3,
        LVP_LISTSORTEDDETAIL = 4,
        LVP_EMPTYTEXT = 5,
        LVP_GROUPHEADER = 6,
        LVP_GROUPHEADERLINE = 7,
        LVP_EXPANDBUTTON = 8,
        LVP_COLLAPSEBUTTON = 9,
        LVP_COLUMNDETAIL = 10,
    };

    public enum LISTITEMSTATES : int
    {
        LISS_NORMAL = 1,
        LISS_HOT = 2,
        LISS_SELECTED = 3,
        LISS_DISABLED = 4,
        LISS_SELECTEDNOTFOCUS = 5,
        LISS_HOTSELECTED = 6,
    };

    public enum GROUPHEADERSTATES : int
    {
        LVGH_OPEN = 1,
        LVGH_OPENHOT = 2,
        LVGH_OPENSELECTED = 3,
        LVGH_OPENSELECTEDHOT = 4,
        LVGH_OPENSELECTEDNOTFOCUSED = 5,
        LVGH_OPENSELECTEDNOTFOCUSEDHOT = 6,
        LVGH_OPENMIXEDSELECTION = 7,
        LVGH_OPENMIXEDSELECTIONHOT = 8,
        LVGH_CLOSE = 9,
        LVGH_CLOSEHOT = 10,
        LVGH_CLOSESELECTED = 11,
        LVGH_CLOSESELECTEDHOT = 12,
        LVGH_CLOSESELECTEDNOTFOCUSED = 13,
        LVGH_CLOSESELECTEDNOTFOCUSEDHOT = 14,
        LVGH_CLOSEMIXEDSELECTION = 15,
        LVGH_CLOSEMIXEDSELECTIONHOT = 16,
    };

    public enum GROUPHEADERLINESTATES : int
    {
        LVGHL_OPEN = 1,
        LVGHL_OPENHOT = 2,
        LVGHL_OPENSELECTED = 3,
        LVGHL_OPENSELECTEDHOT = 4,
        LVGHL_OPENSELECTEDNOTFOCUSED = 5,
        LVGHL_OPENSELECTEDNOTFOCUSEDHOT = 6,
        LVGHL_OPENMIXEDSELECTION = 7,
        LVGHL_OPENMIXEDSELECTIONHOT = 8,
        LVGHL_CLOSE = 9,
        LVGHL_CLOSEHOT = 10,
        LVGHL_CLOSESELECTED = 11,
        LVGHL_CLOSESELECTEDHOT = 12,
        LVGHL_CLOSESELECTEDNOTFOCUSED = 13,
        LVGHL_CLOSESELECTEDNOTFOCUSEDHOT = 14,
        LVGHL_CLOSEMIXEDSELECTION = 15,
        LVGHL_CLOSEMIXEDSELECTIONHOT = 16,
    };

    public enum EXPANDBUTTONSTATES : int
    {
        LVEB_NORMAL = 1,
        LVEB_HOVER = 2,
        LVEB_PUSHED = 3,
    };

    public enum COLLAPSEBUTTONSTATES : int
    {
        LVCB_NORMAL = 1,
        LVCB_HOVER = 2,
        LVCB_PUSHED = 3,
    };

    public enum MENUPARTS : int
    {
        MENU_MENUITEM_TMSCHEMA = 1,
        MENU_MENUDROPDOWN_TMSCHEMA = 2,
        MENU_MENUBARITEM_TMSCHEMA = 3,
        MENU_MENUBARDROPDOWN_TMSCHEMA = 4,
        MENU_CHEVRON_TMSCHEMA = 5,
        MENU_SEPARATOR_TMSCHEMA = 6,
        MENU_BARBACKGROUND = 7,
        MENU_BARITEM = 8,
        MENU_POPUPBACKGROUND = 9,
        MENU_POPUPBORDERS = 10,
        MENU_POPUPCHECK = 11,
        MENU_POPUPCHECKBACKGROUND = 12,
        MENU_POPUPGUTTER = 13,
        MENU_POPUPITEM = 14,
        MENU_POPUPSEPARATOR = 15,
        MENU_POPUPSUBMENU = 16,
        MENU_SYSTEMCLOSE = 17,
        MENU_SYSTEMMAXIMIZE = 18,
        MENU_SYSTEMMINIMIZE = 19,
        MENU_SYSTEMRESTORE = 20,
    };

    public enum BARBACKGROUNDSTATES : int
    {
        MB_ACTIVE = 1,
        MB_INACTIVE = 2,
    };

    public enum BARITEMSTATES : int
    {
        MBI_NORMAL = 1,
        MBI_HOT = 2,
        MBI_PUSHED = 3,
        MBI_DISABLED = 4,
        MBI_DISABLEDHOT = 5,
        MBI_DISABLEDPUSHED = 6,
    };

    public enum POPUPCHECKSTATES : int
    {
        MC_CHECKMARKNORMAL = 1,
        MC_CHECKMARKDISABLED = 2,
        MC_BULLETNORMAL = 3,
        MC_BULLETDISABLED = 4,
    };

    public enum POPUPCHECKBACKGROUNDSTATES : int
    {
        MCB_DISABLED = 1,
        MCB_NORMAL = 2,
        MCB_BITMAP = 3,
    };

    public enum POPUPITEMSTATES : int
    {
        MPI_NORMAL = 1,
        MPI_HOT = 2,
        MPI_DISABLED = 3,
        MPI_DISABLEDHOT = 4,
    };

    public enum POPUPSUBMENUSTATES : int
    {
        MSM_NORMAL = 1,
        MSM_DISABLED = 2,
    };

    public enum SYSTEMCLOSESTATES : int
    {
        MSYSC_NORMAL = 1,
        MSYSC_DISABLED = 2,
    };

    public enum SYSTEMMAXIMIZESTATES : int
    {
        MSYSMX_NORMAL = 1,
        MSYSMX_DISABLED = 2,
    };

    public enum SYSTEMMINIMIZESTATES : int
    {
        MSYSMN_NORMAL = 1,
        MSYSMN_DISABLED = 2,
    };

    public enum SYSTEMRESTORESTATES : int
    {
        MSYSR_NORMAL = 1,
        MSYSR_DISABLED = 2,
    };

    public enum NAVIGATIONPARTS : int
    {
        NAV_BACKBUTTON = 1,
        NAV_FORWARDBUTTON = 2,
        NAV_MENUBUTTON = 3,
    };

    public enum NAV_BACKBUTTONSTATES : int
    {
        NAV_BB_NORMAL = 1,
        NAV_BB_HOT = 2,
        NAV_BB_PRESSED = 3,
        NAV_BB_DISABLED = 4,
    };

    public enum NAV_FORWARDBUTTONSTATES : int
    {
        NAV_FB_NORMAL = 1,
        NAV_FB_HOT = 2,
        NAV_FB_PRESSED = 3,
        NAV_FB_DISABLED = 4,
    };

    public enum NAV_MENUBUTTONSTATES : int
    {
        NAV_MB_NORMAL = 1,
        NAV_MB_HOT = 2,
        NAV_MB_PRESSED = 3,
        NAV_MB_DISABLED = 4,
    };

    public enum PROGRESSPARTS : int
    {
        PP_BAR = 1,
        PP_BARVERT = 2,
        PP_CHUNK = 3,
        PP_CHUNKVERT = 4,
        PP_FILL = 5,
        PP_FILLVERT = 6,
        PP_PULSEOVERLAY = 7,
        PP_MOVEOVERLAY = 8,
        PP_PULSEOVERLAYVERT = 9,
        PP_MOVEOVERLAYVERT = 10,
        PP_TRANSPARENTBAR = 11,
        PP_TRANSPARENTBARVERT = 12,
    };

    public enum TRANSPARENTBARSTATES : int
    {
        PBBS_NORMAL = 1,
        PBBS_PARTIAL = 2,
    };

    public enum TRANSPARENTBARVERTSTATES : int
    {
        PBBVS_NORMAL = 1,
        PBBVS_PARTIAL = 2,
    };

    public enum FILLSTATES : int
    {
        PBFS_NORMAL = 1,
        PBFS_ERROR = 2,
        PBFS_PAUSED = 3,
        PBFS_PARTIAL = 4,
    };

    public enum FILLVERTSTATES : int
    {
        PBFVS_NORMAL = 1,
        PBFVS_ERROR = 2,
        PBFVS_PAUSED = 3,
        PBFVS_PARTIAL = 4,
    };

    public enum REBARPARTS : int
    {
        RP_GRIPPER = 1,
        RP_GRIPPERVERT = 2,
        RP_BAND = 3,
        RP_CHEVRON = 4,
        RP_CHEVRONVERT = 5,
        RP_BACKGROUND = 6,
        RP_SPLITTER = 7,
        RP_SPLITTERVERT = 8,
    };

    public enum CHEVRONSTATES : int
    {
        CHEVS_NORMAL = 1,
        CHEVS_HOT = 2,
        CHEVS_PRESSED = 3,
    };

    public enum CHEVRONVERTSTATES : int
    {
        CHEVSV_NORMAL = 1,
        CHEVSV_HOT = 2,
        CHEVSV_PRESSED = 3,
    };

    public enum SPLITTERSTATES : int
    {
        SPLITS_NORMAL = 1,
        SPLITS_HOT = 2,
        SPLITS_PRESSED = 3,
    };

    public enum SPLITTERVERTSTATES : int
    {
        SPLITSV_NORMAL = 1,
        SPLITSV_HOT = 2,
        SPLITSV_PRESSED = 3,
    };

    public enum SCROLLBARPARTS : int
    {
        SBP_ARROWBTN = 1,
        SBP_THUMBBTNHORZ = 2,
        SBP_THUMBBTNVERT = 3,
        SBP_LOWERTRACKHORZ = 4,
        SBP_UPPERTRACKHORZ = 5,
        SBP_LOWERTRACKVERT = 6,
        SBP_UPPERTRACKVERT = 7,
        SBP_GRIPPERHORZ = 8,
        SBP_GRIPPERVERT = 9,
        SBP_SIZEBOX = 10,
    };

    public enum ARROWBTNSTATES : int
    {
        ABS_UPNORMAL = 1,
        ABS_UPHOT = 2,
        ABS_UPPRESSED = 3,
        ABS_UPDISABLED = 4,
        ABS_DOWNNORMAL = 5,
        ABS_DOWNHOT = 6,
        ABS_DOWNPRESSED = 7,
        ABS_DOWNDISABLED = 8,
        ABS_LEFTNORMAL = 9,
        ABS_LEFTHOT = 10,
        ABS_LEFTPRESSED = 11,
        ABS_LEFTDISABLED = 12,
        ABS_RIGHTNORMAL = 13,
        ABS_RIGHTHOT = 14,
        ABS_RIGHTPRESSED = 15,
        ABS_RIGHTDISABLED = 16,
        ABS_UPHOVER = 17,
        ABS_DOWNHOVER = 18,
        ABS_LEFTHOVER = 19,
        ABS_RIGHTHOVER = 20,
    };

    public enum SCROLLBARSTYLESTATES : int
    {
        SCRBS_NORMAL = 1,
        SCRBS_HOT = 2,
        SCRBS_PRESSED = 3,
        SCRBS_DISABLED = 4,
        SCRBS_HOVER = 5,
    };

    public enum SIZEBOXSTATES : int
    {
        SZB_RIGHTALIGN = 1,
        SZB_LEFTALIGN = 2,
        SZB_TOPRIGHTALIGN = 3,
        SZB_TOPLEFTALIGN = 4,
        SZB_HALFBOTTOMRIGHTALIGN = 5,
        SZB_HALFBOTTOMLEFTALIGN = 6,
        SZB_HALFTOPRIGHTALIGN = 7,
        SZB_HALFTOPLEFTALIGN = 8,
    };

    public enum SPINPARTS : int
    {
        SPNP_UP = 1,
        SPNP_DOWN = 2,
        SPNP_UPHORZ = 3,
        SPNP_DOWNHORZ = 4,
    };

    public enum UPSTATES : int
    {
        UPS_NORMAL = 1,
        UPS_HOT = 2,
        UPS_PRESSED = 3,
        UPS_DISABLED = 4,
    };

    public enum DOWNSTATES : int
    {
        DNS_NORMAL = 1,
        DNS_HOT = 2,
        DNS_PRESSED = 3,
        DNS_DISABLED = 4,
    };

    public enum UPHORZSTATES : int
    {
        UPHZS_NORMAL = 1,
        UPHZS_HOT = 2,
        UPHZS_PRESSED = 3,
        UPHZS_DISABLED = 4,
    };

    public enum DOWNHORZSTATES : int
    {
        DNHZS_NORMAL = 1,
        DNHZS_HOT = 2,
        DNHZS_PRESSED = 3,
        DNHZS_DISABLED = 4,
    };

    public enum STATUSPARTS : int
    {
        SP_PANE = 1,
        SP_GRIPPERPANE = 2,
        SP_GRIPPER = 3,
    };

    public enum TABPARTS : int
    {
        TABP_TABITEM = 1,
        TABP_TABITEMLEFTEDGE = 2,
        TABP_TABITEMRIGHTEDGE = 3,
        TABP_TABITEMBOTHEDGE = 4,
        TABP_TOPTABITEM = 5,
        TABP_TOPTABITEMLEFTEDGE = 6,
        TABP_TOPTABITEMRIGHTEDGE = 7,
        TABP_TOPTABITEMBOTHEDGE = 8,
        TABP_PANE = 9,
        TABP_BODY = 10,
        TABP_AEROWIZARDBODY = 11,
    };

    public enum TABITEMSTATES : int
    {
        TIS_NORMAL = 1,
        TIS_HOT = 2,
        TIS_SELECTED = 3,
        TIS_DISABLED = 4,
        TIS_FOCUSED = 5,
    };

    public enum TABITEMLEFTEDGESTATES : int
    {
        TILES_NORMAL = 1,
        TILES_HOT = 2,
        TILES_SELECTED = 3,
        TILES_DISABLED = 4,
        TILES_FOCUSED = 5,
    };

    public enum TABITEMRIGHTEDGESTATES : int
    {
        TIRES_NORMAL = 1,
        TIRES_HOT = 2,
        TIRES_SELECTED = 3,
        TIRES_DISABLED = 4,
        TIRES_FOCUSED = 5,
    };

    public enum TABITEMBOTHEDGESTATES : int
    {
        TIBES_NORMAL = 1,
        TIBES_HOT = 2,
        TIBES_SELECTED = 3,
        TIBES_DISABLED = 4,
        TIBES_FOCUSED = 5,
    };

    public enum TOPTABITEMSTATES : int
    {
        TTIS_NORMAL = 1,
        TTIS_HOT = 2,
        TTIS_SELECTED = 3,
        TTIS_DISABLED = 4,
        TTIS_FOCUSED = 5,
    };

    public enum TOPTABITEMLEFTEDGESTATES : int
    {
        TTILES_NORMAL = 1,
        TTILES_HOT = 2,
        TTILES_SELECTED = 3,
        TTILES_DISABLED = 4,
        TTILES_FOCUSED = 5,
    };

    public enum TOPTABITEMRIGHTEDGESTATES : int
    {
        TTIRES_NORMAL = 1,
        TTIRES_HOT = 2,
        TTIRES_SELECTED = 3,
        TTIRES_DISABLED = 4,
        TTIRES_FOCUSED = 5,
    };

    public enum TOPTABITEMBOTHEDGESTATES : int
    {
        TTIBES_NORMAL = 1,
        TTIBES_HOT = 2,
        TTIBES_SELECTED = 3,
        TTIBES_DISABLED = 4,
        TTIBES_FOCUSED = 5,
    };

    public enum TASKDIALOGPARTS : int
    {
        TDLG_PRIMARYPANEL = 1,
        TDLG_MAININSTRUCTIONPANE = 2,
        TDLG_MAINICON = 3,
        TDLG_CONTENTPANE = 4,
        TDLG_CONTENTICON = 5,
        TDLG_EXPANDEDCONTENT = 6,
        TDLG_COMMANDLINKPANE = 7,
        TDLG_SECONDARYPANEL = 8,
        TDLG_CONTROLPANE = 9,
        TDLG_BUTTONSECTION = 10,
        TDLG_BUTTONWRAPPER = 11,
        TDLG_EXPANDOTEXT = 12,
        TDLG_EXPANDOBUTTON = 13,
        TDLG_VERIFICATIONTEXT = 14,
        TDLG_FOOTNOTEPANE = 15,
        TDLG_FOOTNOTEAREA = 16,
        TDLG_FOOTNOTESEPARATOR = 17,
        TDLG_EXPANDEDFOOTERAREA = 18,
        TDLG_PROGRESSBAR = 19,
        TDLG_IMAGEALIGNMENT = 20,
        TDLG_RADIOBUTTONPANE = 21,
    };

    public enum CONTENTPANESTATES : int
    {
        TDLGCPS_STANDALONE = 1,
    };

    public enum EXPANDOBUTTONSTATES : int
    {
        TDLGEBS_NORMAL = 1,
        TDLGEBS_HOVER = 2,
        TDLGEBS_PRESSED = 3,
        TDLGEBS_EXPANDEDNORMAL = 4,
        TDLGEBS_EXPANDEDHOVER = 5,
        TDLGEBS_EXPANDEDPRESSED = 6,
        TDLGEBS_NORMALDISABLED = 7,
        TDLGEBS_EXPANDEDDISABLED = 8,
    };

    public enum TEXTSTYLEPARTS : int
    {
        TEXT_MAININSTRUCTION = 1,
        TEXT_INSTRUCTION = 2,
        TEXT_BODYTITLE = 3,
        TEXT_BODYTEXT = 4,
        TEXT_SECONDARYTEXT = 5,
        TEXT_HYPERLINKTEXT = 6,
        TEXT_EXPANDED = 7,
        TEXT_LABEL = 8,
        TEXT_CONTROLLABEL = 9,
    };

    public enum HYPERLINKTEXTSTATES : int
    {
        TS_HYPERLINK_NORMAL = 1,
        TS_HYPERLINK_HOT = 2,
        TS_HYPERLINK_PRESSED = 3,
        TS_HYPERLINK_DISABLED = 4,
    };

    public enum CONTROLLABELSTATES : int
    {
        TS_CONTROLLABEL_NORMAL = 1,
        TS_CONTROLLABEL_DISABLED = 2,
    };

    public enum TOOLBARPARTS : int
    {
        TP_BUTTON = 1,
        TP_DROPDOWNBUTTON = 2,
        TP_SPLITBUTTON = 3,
        TP_SPLITBUTTONDROPDOWN = 4,
        TP_SEPARATOR = 5,
        TP_SEPARATORVERT = 6,
        TP_DROPDOWNBUTTONGLYPH = 7,
    };

    public enum TOOLBARSTYLESTATES : int
    {
        TS_NORMAL = 1,
        TS_HOT = 2,
        TS_PRESSED = 3,
        TS_DISABLED = 4,
        TS_CHECKED = 5,
        TS_HOTCHECKED = 6,
        TS_NEARHOT = 7,
        TS_OTHERSIDEHOT = 8,
    };

    public enum TOOLTIPPARTS : int
    {
        TTP_STANDARD = 1,
        TTP_STANDARDTITLE = 2,
        TTP_BALLOON = 3,
        TTP_BALLOONTITLE = 4,
        TTP_CLOSE = 5,
        TTP_BALLOONSTEM = 6,
        TTP_WRENCH = 7,
    };

    public enum CLOSESTATES : int
    {
        TTCS_NORMAL = 1,
        TTCS_HOT = 2,
        TTCS_PRESSED = 3,
    };

    public enum STANDARDSTATES : int
    {
        TTSS_NORMAL = 1,
        TTSS_LINK = 2,
    };

    public enum BALLOONSTATES : int
    {
        TTBS_NORMAL = 1,
        TTBS_LINK = 2,
    };

    public enum BALLOONSTEMSTATES : int
    {
        TTBSS_POINTINGUPLEFTWALL = 1,
        TTBSS_POINTINGUPCENTERED = 2,
        TTBSS_POINTINGUPRIGHTWALL = 3,
        TTBSS_POINTINGDOWNRIGHTWALL = 4,
        TTBSS_POINTINGDOWNCENTERED = 5,
        TTBSS_POINTINGDOWNLEFTWALL = 6,
    };

    public enum WRENCHSTATES : int
    {
        TTWS_NORMAL = 1,
        TTWS_HOT = 2,
        TTWS_PRESSED = 3,
    };

    public enum TRACKBARPARTS : int
    {
        TKP_TRACK = 1,
        TKP_TRACKVERT = 2,
        TKP_THUMB = 3,
        TKP_THUMBBOTTOM = 4,
        TKP_THUMBTOP = 5,
        TKP_THUMBVERT = 6,
        TKP_THUMBLEFT = 7,
        TKP_THUMBRIGHT = 8,
        TKP_TICS = 9,
        TKP_TICSVERT = 10,
    };

    public enum TRACKBARSTYLESTATES : int
    {
        TKS_NORMAL = 1,
    };

    public enum TRACKSTATES : int
    {
        TRS_NORMAL = 1,
    };

    public enum TRACKVERTSTATES : int
    {
        TRVS_NORMAL = 1,
    };

    public enum THUMBSTATES : int
    {
        TUS_NORMAL = 1,
        TUS_HOT = 2,
        TUS_PRESSED = 3,
        TUS_FOCUSED = 4,
        TUS_DISABLED = 5,
    };

    public enum THUMBBOTTOMSTATES : int
    {
        TUBS_NORMAL = 1,
        TUBS_HOT = 2,
        TUBS_PRESSED = 3,
        TUBS_FOCUSED = 4,
        TUBS_DISABLED = 5,
    };

    public enum THUMBTOPSTATES : int
    {
        TUTS_NORMAL = 1,
        TUTS_HOT = 2,
        TUTS_PRESSED = 3,
        TUTS_FOCUSED = 4,
        TUTS_DISABLED = 5,
    };

    public enum THUMBVERTSTATES : int
    {
        TUVS_NORMAL = 1,
        TUVS_HOT = 2,
        TUVS_PRESSED = 3,
        TUVS_FOCUSED = 4,
        TUVS_DISABLED = 5,
    };

    public enum THUMBLEFTSTATES : int
    {
        TUVLS_NORMAL = 1,
        TUVLS_HOT = 2,
        TUVLS_PRESSED = 3,
        TUVLS_FOCUSED = 4,
        TUVLS_DISABLED = 5,
    };

    public enum THUMBRIGHTSTATES : int
    {
        TUVRS_NORMAL = 1,
        TUVRS_HOT = 2,
        TUVRS_PRESSED = 3,
        TUVRS_FOCUSED = 4,
        TUVRS_DISABLED = 5,
    };

    public enum TICSSTATES : int
    {
        TSS_NORMAL = 1,
    };

    public enum TICSVERTSTATES : int
    {
        TSVS_NORMAL = 1,
    };

    public enum TREEVIEWPARTS : int
    {
        TVP_TREEITEM = 1,
        TVP_GLYPH = 2,
        TVP_BRANCH = 3,
        TVP_HOTGLYPH = 4,
    };

    public enum TREEITEMSTATES : int
    {
        TREIS_NORMAL = 1,
        TREIS_HOT = 2,
        TREIS_SELECTED = 3,
        TREIS_DISABLED = 4,
        TREIS_SELECTEDNOTFOCUS = 5,
        TREIS_HOTSELECTED = 6,
    };

    public enum GLYPHSTATES : int
    {
        GLPS_CLOSED = 1,
        GLPS_OPENED = 2,
    };

    public enum HOTGLYPHSTATES : int
    {
        HGLPS_CLOSED = 1,
        HGLPS_OPENED = 2,
    };

    public enum USERTILEPARTS : int
    {
        UTP_STROKEBACKGROUND = 1,
        UTP_HOVERBACKGROUND = 2,
    };

    public enum HOVERBACKGROUNDSTATES : int
    {
        UTS_NORMAL = 1,
        UTS_HOT = 2,
        UTS_PRESSED = 3,
    };

    public enum TEXTSELECTIONGRIPPERPARTS : int
    {
        TSGP_GRIPPER = 1,
    };

    public enum GRIPPERSTATES : int
    {
        TSGS_NORMAL = 1,
        TSGS_CENTERED = 2,
    };

    public enum WINDOWPARTS : int
    {
        WP_CAPTION = 1,
        WP_SMALLCAPTION = 2,
        WP_MINCAPTION = 3,
        WP_SMALLMINCAPTION = 4,
        WP_MAXCAPTION = 5,
        WP_SMALLMAXCAPTION = 6,
        WP_FRAMELEFT = 7,
        WP_FRAMERIGHT = 8,
        WP_FRAMEBOTTOM = 9,
        WP_SMALLFRAMELEFT = 10,
        WP_SMALLFRAMERIGHT = 11,
        WP_SMALLFRAMEBOTTOM = 12,
        WP_SYSBUTTON = 13,
        WP_MDISYSBUTTON = 14,
        WP_MINBUTTON = 15,
        WP_MDIMINBUTTON = 16,
        WP_MAXBUTTON = 17,
        WP_CLOSEBUTTON = 18,
        WP_SMALLCLOSEBUTTON = 19,
        WP_MDICLOSEBUTTON = 20,
        WP_RESTOREBUTTON = 21,
        WP_MDIRESTOREBUTTON = 22,
        WP_HELPBUTTON = 23,
        WP_MDIHELPBUTTON = 24,
        WP_HORZSCROLL = 25,
        WP_HORZTHUMB = 26,
        WP_VERTSCROLL = 27,
        WP_VERTTHUMB = 28,
        WP_DIALOG = 29,
        WP_CAPTIONSIZINGTEMPLATE = 30,
        WP_SMALLCAPTIONSIZINGTEMPLATE = 31,
        WP_FRAMELEFTSIZINGTEMPLATE = 32,
        WP_SMALLFRAMELEFTSIZINGTEMPLATE = 33,
        WP_FRAMERIGHTSIZINGTEMPLATE = 34,
        WP_SMALLFRAMERIGHTSIZINGTEMPLATE = 35,
        WP_FRAMEBOTTOMSIZINGTEMPLATE = 36,
        WP_SMALLFRAMEBOTTOMSIZINGTEMPLATE = 37,
        WP_FRAME = 38,
    };

    public enum FRAMESTATES : int
    {
        FS_ACTIVE = 1,
        FS_INACTIVE = 2,
    };

    public enum CAPTIONSTATES : int
    {
        CS_ACTIVE = 1,
        CS_INACTIVE = 2,
        CS_DISABLED = 3,
    };

    public enum MAXCAPTIONSTATES : int
    {
        MXCS_ACTIVE = 1,
        MXCS_INACTIVE = 2,
        MXCS_DISABLED = 3,
    };

    public enum MINCAPTIONSTATES : int
    {
        MNCS_ACTIVE = 1,
        MNCS_INACTIVE = 2,
        MNCS_DISABLED = 3,
    };

    public enum HORZSCROLLSTATES : int
    {
        HSS_NORMAL = 1,
        HSS_HOT = 2,
        HSS_PUSHED = 3,
        HSS_DISABLED = 4,
    };

    public enum HORZTHUMBSTATES : int
    {
        HTS_NORMAL = 1,
        HTS_HOT = 2,
        HTS_PUSHED = 3,
        HTS_DISABLED = 4,
    };

    public enum VERTSCROLLSTATES : int
    {
        VSS_NORMAL = 1,
        VSS_HOT = 2,
        VSS_PUSHED = 3,
        VSS_DISABLED = 4,
    };

    public enum VERTTHUMBSTATES : int
    {
        VTS_NORMAL = 1,
        VTS_HOT = 2,
        VTS_PUSHED = 3,
        VTS_DISABLED = 4,
    };

    public enum SYSBUTTONSTATES : int
    {
        SBS_NORMAL = 1,
        SBS_HOT = 2,
        SBS_PUSHED = 3,
        SBS_DISABLED = 4,
    };

    public enum MINBUTTONSTATES : int
    {
        MINBS_NORMAL = 1,
        MINBS_HOT = 2,
        MINBS_PUSHED = 3,
        MINBS_DISABLED = 4,
    };

    public enum MAXBUTTONSTATES : int
    {
        MAXBS_NORMAL = 1,
        MAXBS_HOT = 2,
        MAXBS_PUSHED = 3,
        MAXBS_DISABLED = 4,
    };

    public enum RESTOREBUTTONSTATES : int
    {
        RBS_NORMAL = 1,
        RBS_HOT = 2,
        RBS_PUSHED = 3,
        RBS_DISABLED = 4,
    };

    public enum HELPBUTTONSTATES : int
    {
        HBS_NORMAL = 1,
        HBS_HOT = 2,
        HBS_PUSHED = 3,
        HBS_DISABLED = 4,
    };

    public enum CLOSEBUTTONSTATES : int
    {
        CBS_NORMAL = 1,
        CBS_HOT = 2,
        CBS_PUSHED = 3,
        CBS_DISABLED = 4,
    };

    public enum SMALLCLOSEBUTTONSTATES : int
    {
        SCBS_NORMAL = 1,
        SCBS_HOT = 2,
        SCBS_PUSHED = 3,
        SCBS_DISABLED = 4,
    };

    public enum FRAMEBOTTOMSTATES : int
    {
        FRB_ACTIVE = 1,
        FRB_INACTIVE = 2,
    };

    public enum FRAMELEFTSTATES : int
    {
        FRL_ACTIVE = 1,
        FRL_INACTIVE = 2,
    };

    public enum FRAMERIGHTSTATES : int
    {
        FRR_ACTIVE = 1,
        FRR_INACTIVE = 2,
    };

    public enum SMALLCAPTIONSTATES : int
    {
        SCS_ACTIVE = 1,
        SCS_INACTIVE = 2,
        SCS_DISABLED = 3,
    };

    public enum SMALLFRAMEBOTTOMSTATES : int
    {
        SFRB_ACTIVE = 1,
        SFRB_INACTIVE = 2,
    };

    public enum SMALLFRAMELEFTSTATES : int
    {
        SFRL_ACTIVE = 1,
        SFRL_INACTIVE = 2,
    };

    public enum SMALLFRAMERIGHTSTATES : int
    {
        SFRR_ACTIVE = 1,
        SFRR_INACTIVE = 2,
    };

    public enum MDICLOSEBUTTONSTATES : int
    {
        MDCL_NORMAL = 1,
        MDCL_HOT = 2,
        MDCL_PUSHED = 3,
        MDCL_DISABLED = 4,
    };

    public enum MDIMINBUTTONSTATES : int
    {
        MDMI_NORMAL = 1,
        MDMI_HOT = 2,
        MDMI_PUSHED = 3,
        MDMI_DISABLED = 4,
    };

    public enum MDIRESTOREBUTTONSTATES : int
    {
        MDRE_NORMAL = 1,
        MDRE_HOT = 2,
        MDRE_PUSHED = 3,
        MDRE_DISABLED = 4,
    };

    public enum BGTYPE : int
    {
        BT_IMAGEFILE = 0,
        BT_BORDERFILL = 1,
        BT_NONE = 2,
    };

    public enum IMAGELAYOUT : int
    {
        IL_VERTICAL = 0,
        IL_HORIZONTAL = 1,
    };

    public enum BORDERTYPE : int
    {
        BT_RECT = 0,
        BT_ROUNDRECT = 1,
        BT_ELLIPSE = 2,
    };

    public enum FILLTYPE : int
    {
        FT_SOLID = 0,
        FT_VERTGRADIENT = 1,
        FT_HORZGRADIENT = 2,
        FT_RADIALGRADIENT = 3,
        FT_TILEIMAGE = 4,
    };

    public enum SIZINGTYPE : int
    {
        ST_TRUESIZE = 0,
        ST_STRETCH = 1,
        ST_TILE = 2,
    };

    public enum HALIGN : int
    {
        HA_LEFT = 0,
        HA_CENTER = 1,
        HA_RIGHT = 2,
    };

    public enum CONTENTALIGNMENT : int
    {
        CA_LEFT = 0,
        CA_CENTER = 1,
        CA_RIGHT = 2,
    };

    public enum VALIGN : int
    {
        VA_TOP = 0,
        VA_CENTER = 1,
        VA_BOTTOM = 2,
    };

    public enum OFFSETTYPE : int
    {
        OT_TOPLEFT = 0,
        OT_TOPRIGHT = 1,
        OT_TOPMIDDLE = 2,
        OT_BOTTOMLEFT = 3,
        OT_BOTTOMRIGHT = 4,
        OT_BOTTOMMIDDLE = 5,
        OT_MIDDLELEFT = 6,
        OT_MIDDLERIGHT = 7,
        OT_LEFTOFCAPTION = 8,
        OT_RIGHTOFCAPTION = 9,
        OT_LEFTOFLASTBUTTON = 10,
        OT_RIGHTOFLASTBUTTON = 11,
        OT_ABOVELASTBUTTON = 12,
        OT_BELOWLASTBUTTON = 13,
    };

    public enum ICONEFFECT : int
    {
        ICE_NONE = 0,
        ICE_GLOW = 1,
        ICE_SHADOW = 2,
        ICE_PULSE = 3,
        ICE_ALPHA = 4,
    };

    public enum TEXTSHADOWTYPE : int
    {
        TST_NONE = 0,
        TST_SINGLE = 1,
        TST_CONTINUOUS = 2,
    };

    public enum GLYPHTYPE : int
    {
        GT_NONE = 0,
        GT_IMAGEGLYPH = 1,
        GT_FONTGLYPH = 2,
    };

    public enum IMAGESELECTTYPE : int
    {
        IST_NONE = 0,
        IST_SIZE = 1,
        IST_DPI = 2,
    };

    public enum TRUESIZESCALINGTYPE : int
    {
        TSST_NONE = 0,
        TSST_SIZE = 1,
        TSST_DPI = 2,
    };

    public enum GLYPHFONTSIZINGTYPE : int
    {
        GFST_NONE = 0,
        GFST_SIZE = 1,
        GFST_DPI = 2,
    };

    public enum LINKPARTS : int
    {
        LP_HYPERLINK = 1,
    };

    public enum HYPERLINKSTATES : int
    {
        HLS_NORMALTEXT = 1,
        HLS_LINKTEXT = 2,
    };

    public enum EMPTYMARKUPPARTS : int
    {
        EMP_MARKUPTEXT = 1,
    };

    public enum MARKUPTEXTSTATES : int
    {
        EMT_NORMALTEXT = 1,
        EMT_LINKTEXT = 2,
    };

    public enum STATICPARTS : int
    {
        STAT_TEXT = 1,
    };

    public enum PAGEPARTS : int
    {
        PGRP_UP = 1,
        PGRP_DOWN = 2,
        PGRP_UPHORZ = 3,
        PGRP_DOWNHORZ = 4,
    };

    public enum MONTHCALPARTS : int
    {
        MC_BACKGROUND = 1,
        MC_BORDERS = 2,
        MC_GRIDBACKGROUND = 3,
        MC_COLHEADERSPLITTER = 4,
        MC_GRIDCELLBACKGROUND = 5,
        MC_GRIDCELL = 6,
        MC_GRIDCELLUPPER = 7,
        MC_TRAILINGGRIDCELL = 8,
        MC_TRAILINGGRIDCELLUPPER = 9,
        MC_NAVNEXT = 10,
        MC_NAVPREV = 11,
    };

    public enum GRIDCELLBACKGROUNDSTATES : int
    {
        MCGCB_SELECTED = 1,
        MCGCB_HOT = 2,
        MCGCB_SELECTEDHOT = 3,
        MCGCB_SELECTEDNOTFOCUSED = 4,
        MCGCB_TODAY = 5,
        MCGCB_TODAYSELECTED = 6,
    };

    public enum GRIDCELLSTATES : int
    {
        MCGC_HOT = 1,
        MCGC_HASSTATE = 2,
        MCGC_HASSTATEHOT = 3,
        MCGC_TODAY = 4,
        MCGC_TODAYSELECTED = 5,
        MCGC_SELECTED = 6,
        MCGC_SELECTEDHOT = 7,
    };

    public enum GRIDCELLUPPERSTATES : int
    {
        MCGCU_HOT = 1,
        MCGCU_HASSTATE = 2,
        MCGCU_HASSTATEHOT = 3,
        MCGCU_SELECTED = 4,
        MCGCU_SELECTEDHOT = 5,
    };

    public enum TRAILINGGRIDCELLSTATES : int
    {
        MCTGC_HOT = 1,
        MCTGC_HASSTATE = 2,
        MCTGC_HASSTATEHOT = 3,
        MCTGC_TODAY = 4,
        MCTGC_TODAYSELECTED = 5,
        MCTGC_SELECTED = 6,
        MCTGC_SELECTEDHOT = 7,
    };

    public enum TRAILINGGRIDCELLUPPERSTATES : int
    {
        MCTGCU_HOT = 1,
        MCTGCU_HASSTATE = 2,
        MCTGCU_HASSTATEHOT = 3,
        MCTGCU_SELECTED = 4,
        MCTGCU_SELECTEDHOT = 5,
    };

    public enum NAVNEXTSTATES : int
    {
        MCNN_NORMAL = 1,
        MCNN_HOT = 2,
        MCNN_PRESSED = 3,
        MCNN_DISABLED = 4,
    };

    public enum NAVPREVSTATES : int
    {
        MCNP_NORMAL = 1,
        MCNP_HOT = 2,
        MCNP_PRESSED = 3,
        MCNP_DISABLED = 4,
    };

    public enum CLOCKPARTS : int
    {
        CLP_TIME = 1,
    };

    public enum CLOCKSTATES : int
    {
        CLS_NORMAL = 1,
        CLS_HOT = 2,
        CLS_PRESSED = 3,
    };

    public enum TRAYNOTIFYPARTS : int
    {
        TNP_BACKGROUND = 1,
        TNP_ANIMBACKGROUND = 2,
    };

    public enum TASKBARPARTS : int
    {
        TBP_BACKGROUNDBOTTOM = 1,
        TBP_BACKGROUNDRIGHT = 2,
        TBP_BACKGROUNDTOP = 3,
        TBP_BACKGROUNDLEFT = 4,
        TBP_SIZINGBARBOTTOM = 5,
        TBP_SIZINGBARRIGHT = 6,
        TBP_SIZINGBARTOP = 7,
        TBP_SIZINGBARLEFT = 8,
    };

    public enum TASKBANDPARTS : int
    {
        TDP_GROUPCOUNT = 1,
        TDP_FLASHBUTTON = 2,
        TDP_FLASHBUTTONGROUPMENU = 3,
    };

    public enum STARTPANELPARTS : int
    {
        SPP_USERPANE = 1,
        SPP_MOREPROGRAMS = 2,
        SPP_MOREPROGRAMSARROW = 3,
        SPP_PROGLIST = 4,
        SPP_PROGLISTSEPARATOR = 5,
        SPP_PLACESLIST = 6,
        SPP_PLACESLISTSEPARATOR = 7,
        SPP_LOGOFF = 8,
        SPP_LOGOFFBUTTONS = 9,
        SPP_USERPICTURE = 10,
        SPP_PREVIEW = 11,
        SPP_MOREPROGRAMSTAB = 12,
        SPP_NSCHOST = 13,
        SPP_SOFTWAREEXPLORER = 14,
        SPP_OPENBOX = 15,
        SPP_SEARCHVIEW = 16,
        SPP_MOREPROGRAMSARROWBACK = 17,
        SPP_TOPMATCH = 18,
        SPP_LOGOFFSPLITBUTTONDROPDOWN = 19,
    };

    public enum MOREPROGRAMSTABSTATES : int
    {
        SPMPT_NORMAL = 1,
        SPMPT_HOT = 2,
        SPMPT_SELECTED = 3,
        SPMPT_DISABLED = 4,
        SPMPT_FOCUSED = 5,
    };

    public enum SOFTWAREEXPLORERSTATES : int
    {
        SPSE_NORMAL = 1,
        SPSE_HOT = 2,
        SPSE_SELECTED = 3,
        SPSE_DISABLED = 4,
        SPSE_FOCUSED = 5,
    };

    public enum OPENBOXSTATES : int
    {
        SPOB_NORMAL = 1,
        SPOB_HOT = 2,
        SPOB_SELECTED = 3,
        SPOB_DISABLED = 4,
        SPOB_FOCUSED = 5,
    };

    public enum MOREPROGRAMSARROWSTATES : int
    {
        SPS_NORMAL = 1,
        SPS_HOT = 2,
        SPS_PRESSED = 3,
    };

    public enum MOREPROGRAMSARROWBACKSTATES : int
    {
        SPSB_NORMAL = 1,
        SPSB_HOT = 2,
        SPSB_PRESSED = 3,
    };

    public enum LOGOFFBUTTONSSTATES : int
    {
        SPLS_NORMAL = 1,
        SPLS_HOT = 2,
        SPLS_PRESSED = 3,
    };

    public enum MENUBANDPARTS : int
    {
        MDP_NEWAPPBUTTON = 1,
        MDP_SEPERATOR = 2,
    };

    public enum MENUBANDSTATES : int
    {
        MDS_NORMAL = 1,
        MDS_HOT = 2,
        MDS_PRESSED = 3,
        MDS_DISABLED = 4,
        MDS_CHECKED = 5,
        MDS_HOTCHECKED = 6,
    };

    public enum MULTICAST_MODE_TYPE : int
    {
        MCAST_INCLUDE = 0,
        MCAST_EXCLUDE,
    };

    public enum DNS_CONFIG_TYPE : int
    {
        DnsConfigPrimaryDomainName_W,
        DnsConfigPrimaryDomainName_A,
        DnsConfigPrimaryDomainName_UTF8,
        DnsConfigAdapterDomainName_W,
        DnsConfigAdapterDomainName_A,
        DnsConfigAdapterDomainName_UTF8,
        DnsConfigDnsServerList,
        DnsConfigSearchList,
        DnsConfigAdapterInfo,
        DnsConfigPrimaryHostNameRegistrationEnabled,
        DnsConfigAdapterHostNameRegistrationEnabled,
        DnsConfigAddressRegistrationMaxCount,
        DnsConfigHostName_W,
        DnsConfigHostName_A,
        DnsConfigHostName_UTF8,
        DnsConfigFullHostName_W,
        DnsConfigFullHostName_A,
        DnsConfigFullHostName_UTF8,
    };

    public enum _DnsSection : int
    {
        DnsSectionQuestion,
        DnsSectionAnswer,
        DnsSectionAuthority,
        DnsSectionAddtional,
    };

    public enum DNS_PROXY_INFORMATION_TYPE : int
    {
        DNS_PROXY_INFORMATION_DIRECT,
        DNS_PROXY_INFORMATION_DEFAULT_SETTINGS,
        DNS_PROXY_INFORMATION_PROXY_NAME,
        DNS_PROXY_INFORMATION_DOES_NOT_EXIST,
    };

    public enum _DNS_CHARSET : int
    {
        DnsCharSetUnknown,
        DnsCharSetUnicode,
        DnsCharSetUtf8,
        DnsCharSetAnsi,
    };

    public enum DNS_FREE_TYPE : int
    {
        DnsFreeFlat = 0,
        DnsFreeRecordList,
        DnsFreeParsedMessageFields,
    };

    public enum _DNS_NAME_FORMAT : int
    {
        DnsNameDomain,
        DnsNameDomainLabel,
        DnsNameHostnameFull,
        DnsNameHostnameLabel,
        DnsNameWildcard,
        DnsNameSrvRecord,
        DnsNameValidateTld,
    };

    public enum _IF_ACCESS_TYPE : int
    {
        IF_ACCESS_LOOPBACK = 1,
        IF_ACCESS_BROADCAST = 2,
        IF_ACCESS_POINT_TO_POINT = 3,
        IF_ACCESS_POINTTOPOINT = 3,
        IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        IF_ACCESS_POINTTOMULTIPOINT = 4,
    };

    public enum _INTERNAL_IF_OPER_STATUS : int
    {
        IF_OPER_STATUS_NON_OPERATIONAL = 0,
        IF_OPER_STATUS_UNREACHABLE = 1,
        IF_OPER_STATUS_DISCONNECTED = 2,
        IF_OPER_STATUS_CONNECTING = 3,
        IF_OPER_STATUS_CONNECTED = 4,
        IF_OPER_STATUS_OPERATIONAL = 5,
    };

    public enum _NET_IF_ADMIN_STATUS : int
    {
        NET_IF_ADMIN_STATUS_UP = 1,
        NET_IF_ADMIN_STATUS_DOWN = 2,
        NET_IF_ADMIN_STATUS_TESTING = 3,
    };

    public enum _NET_IF_OPER_STATUS : int
    {
        NET_IF_OPER_STATUS_UP = 1,
        NET_IF_OPER_STATUS_DOWN = 2,
        NET_IF_OPER_STATUS_TESTING = 3,
        NET_IF_OPER_STATUS_UNKNOWN = 4,
        NET_IF_OPER_STATUS_DORMANT = 5,
        NET_IF_OPER_STATUS_NOT_PRESENT = 6,
        NET_IF_OPER_STATUS_LOWER_LAYER_DOWN = 7,
    };

    public enum _NET_IF_RCV_ADDRESS_TYPE : int
    {
        NET_IF_RCV_ADDRESS_TYPE_OTHER = 1,
        NET_IF_RCV_ADDRESS_TYPE_VOLATILE = 2,
        NET_IF_RCV_ADDRESS_TYPE_NON_VOLATILE = 3,
    };

    public enum _NET_IF_ACCESS_TYPE : int
    {
        NET_IF_ACCESS_LOOPBACK = 1,
        NET_IF_ACCESS_BROADCAST = 2,
        NET_IF_ACCESS_POINT_TO_POINT = 3,
        NET_IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        NET_IF_ACCESS_MAXIMUM = 5,
    };

    public enum _NET_IF_DIRECTION_TYPE : int
    {
        NET_IF_DIRECTION_SENDRECEIVE,
        NET_IF_DIRECTION_SENDONLY,
        NET_IF_DIRECTION_RECEIVEONLY,
        NET_IF_DIRECTION_MAXIMUM,
    };

    public enum _NET_IF_CONNECTION_TYPE : int
    {
        NET_IF_CONNECTION_DEDICATED = 1,
        NET_IF_CONNECTION_PASSIVE = 2,
        NET_IF_CONNECTION_DEMAND = 3,
        NET_IF_CONNECTION_MAXIMUM = 4,
    };

    public enum _NET_IF_MEDIA_CONNECT_STATE : int
    {
        MediaConnectStateUnknown,
        MediaConnectStateConnected,
        MediaConnectStateDisconnected,
    };

    public enum _NET_IF_MEDIA_DUPLEX_STATE : int
    {
        MediaDuplexStateUnknown,
        MediaDuplexStateHalf,
        MediaDuplexStateFull,
    };

    public enum TUNNEL_TYPE : int
    {
        TUNNEL_TYPE_NONE = 0,
        TUNNEL_TYPE_OTHER = 1,
        TUNNEL_TYPE_DIRECT = 2,
        TUNNEL_TYPE_6TO4 = 11,
        TUNNEL_TYPE_ISATAP = 13,
        TUNNEL_TYPE_TEREDO = 14,
        TUNNEL_TYPE_IPHTTPS = 15,
    };

    public enum _IF_ADMINISTRATIVE_STATE : int
    {
        IF_ADMINISTRATIVE_DISABLED,
        IF_ADMINISTRATIVE_ENABLED,
        IF_ADMINISTRATIVE_DEMANDDIAL,
    };

    public enum IF_OPER_STATUS : int
    {
        IfOperStatusUp = 1,
        IfOperStatusDown,
        IfOperStatusTesting,
        IfOperStatusUnknown,
        IfOperStatusDormant,
        IfOperStatusNotPresent,
        IfOperStatusLowerLayerDown,
    };

    public enum NL_PREFIX_ORIGIN : int
    {
        IpPrefixOriginOther = 0,
        IpPrefixOriginManual,
        IpPrefixOriginWellKnown,
        IpPrefixOriginDhcp,
        IpPrefixOriginRouterAdvertisement,
        IpPrefixOriginUnchanged = 16,
    };

    public enum NL_SUFFIX_ORIGIN : int
    {
        NlsoOther = 0,
        NlsoManual,
        NlsoWellKnown,
        NlsoDhcp,
        NlsoLinkLayerAddress,
        NlsoRandom,
        IpSuffixOriginOther = 0,
        IpSuffixOriginManual,
        IpSuffixOriginWellKnown,
        IpSuffixOriginDhcp,
        IpSuffixOriginLinkLayerAddress,
        IpSuffixOriginRandom,
        IpSuffixOriginUnchanged = 16,
    };

    public enum NL_DAD_STATE : int
    {
        NldsInvalid,
        NldsTentative,
        NldsDuplicate,
        NldsDeprecated,
        NldsPreferred,
        IpDadStateInvalid = 0,
        IpDadStateTentative,
        IpDadStateDuplicate,
        IpDadStateDeprecated,
        IpDadStatePreferred,
    };

    public enum NL_ROUTE_PROTOCOL : int
    {
        RouteProtocolOther = 1,
        RouteProtocolLocal = 2,
        RouteProtocolNetMgmt = 3,
        RouteProtocolIcmp = 4,
        RouteProtocolEgp = 5,
        RouteProtocolGgp = 6,
        RouteProtocolHello = 7,
        RouteProtocolRip = 8,
        RouteProtocolIsIs = 9,
        RouteProtocolEsIs = 10,
        RouteProtocolCisco = 11,
        RouteProtocolBbn = 12,
        RouteProtocolOspf = 13,
        RouteProtocolBgp = 14,
        RouteProtocolIdpr = 15,
        RouteProtocolEigrp = 16,
        RouteProtocolDvmrp = 17,
        RouteProtocolRpl = 18,
        RouteProtocolDhcp = 19,
        MIB_IPPROTO_OTHER = 1,
        PROTO_IP_OTHER = 1,
        MIB_IPPROTO_LOCAL = 2,
        PROTO_IP_LOCAL = 2,
        MIB_IPPROTO_NETMGMT = 3,
        PROTO_IP_NETMGMT = 3,
        MIB_IPPROTO_ICMP = 4,
        PROTO_IP_ICMP = 4,
        MIB_IPPROTO_EGP = 5,
        PROTO_IP_EGP = 5,
        MIB_IPPROTO_GGP = 6,
        PROTO_IP_GGP = 6,
        MIB_IPPROTO_HELLO = 7,
        PROTO_IP_HELLO = 7,
        MIB_IPPROTO_RIP = 8,
        PROTO_IP_RIP = 8,
        MIB_IPPROTO_IS_IS = 9,
        PROTO_IP_IS_IS = 9,
        MIB_IPPROTO_ES_IS = 10,
        PROTO_IP_ES_IS = 10,
        MIB_IPPROTO_CISCO = 11,
        PROTO_IP_CISCO = 11,
        MIB_IPPROTO_BBN = 12,
        PROTO_IP_BBN = 12,
        MIB_IPPROTO_OSPF = 13,
        PROTO_IP_OSPF = 13,
        MIB_IPPROTO_BGP = 14,
        PROTO_IP_BGP = 14,
        MIB_IPPROTO_IDPR = 15,
        PROTO_IP_IDPR = 15,
        MIB_IPPROTO_EIGRP = 16,
        PROTO_IP_EIGRP = 16,
        MIB_IPPROTO_DVMRP = 17,
        PROTO_IP_DVMRP = 17,
        MIB_IPPROTO_RPL = 18,
        PROTO_IP_RPL = 18,
        MIB_IPPROTO_DHCP = 19,
        PROTO_IP_DHCP = 19,
        MIB_IPPROTO_NT_AUTOSTATIC = 10002,
        PROTO_IP_NT_AUTOSTATIC = 10002,
        MIB_IPPROTO_NT_STATIC = 10006,
        PROTO_IP_NT_STATIC = 10006,
        MIB_IPPROTO_NT_STATIC_NON_DOD = 10007,
        PROTO_IP_NT_STATIC_NON_DOD = 10007,
    };

    public enum NL_ADDRESS_TYPE : int
    {
        NlatUnspecified,
        NlatUnicast,
        NlatAnycast,
        NlatMulticast,
        NlatBroadcast,
        NlatInvalid,
    };

    public enum _NL_ROUTE_ORIGIN : int
    {
        NlroManual,
        NlroWellKnown,
        NlroDHCP,
        NlroRouterAdvertisement,
        Nlro6to4,
    };

    public enum _NL_NEIGHBOR_STATE : int
    {
        NlnsUnreachable,
        NlnsIncomplete,
        NlnsProbe,
        NlnsDelay,
        NlnsStale,
        NlnsReachable,
        NlnsPermanent,
        NlnsMaximum,
    };

    public enum _NL_LINK_LOCAL_ADDRESS_BEHAVIOR : int
    {
        LinkLocalAlwaysOff = 0,
        LinkLocalDelayed,
        LinkLocalAlwaysOn,
        LinkLocalUnchanged = -1,
    };

    public enum _NL_ROUTER_DISCOVERY_BEHAVIOR : int
    {
        RouterDiscoveryDisabled = 0,
        RouterDiscoveryEnabled,
        RouterDiscoveryDhcp,
        RouterDiscoveryUnchanged = -1,
    };

    public enum _NL_BANDWIDTH_FLAG : int
    {
        NlbwDisabled = 0,
        NlbwEnabled,
        NlbwUnchanged = -1,
    };

    public enum _NL_NETWORK_CATEGORY : int
    {
        NetworkCategoryPublic,
        NetworkCategoryPrivate,
        NetworkCategoryDomainAuthenticated,
        NetworkCategoryUnchanged = -1,
        NetworkCategoryUnknown = -1,
    };

    public enum _NL_INTERFACE_NETWORK_CATEGORY_STATE : int
    {
        NlincCategoryUnknown = 0,
        NlincPublic = 1,
        NlincPrivate = 2,
        NlincDomainAuthenticated = 3,
        NlincCategoryStateMax,
    };

    public enum MIB_IPFORWARD_TYPE : int
    {
        MIB_IPROUTE_TYPE_OTHER = 1,
        MIB_IPROUTE_TYPE_INVALID = 2,
        MIB_IPROUTE_TYPE_DIRECT = 3,
        MIB_IPROUTE_TYPE_INDIRECT = 4,
    };

    public enum MIB_IPNET_TYPE : int
    {
        MIB_IPNET_TYPE_OTHER = 1,
        MIB_IPNET_TYPE_INVALID = 2,
        MIB_IPNET_TYPE_DYNAMIC = 3,
        MIB_IPNET_TYPE_STATIC = 4,
    };

    public enum MIB_IPSTATS_FORWARDING : int
    {
        MIB_IP_FORWARDING = 1,
        MIB_IP_NOT_FORWARDING = 2,
    };

    public enum ICMP6_TYPE : int
    {
        ICMP6_DST_UNREACH = 1,
        ICMP6_PACKET_TOO_BIG = 2,
        ICMP6_TIME_EXCEEDED = 3,
        ICMP6_PARAM_PROB = 4,
        ICMP6_ECHO_REQUEST = 128,
        ICMP6_ECHO_REPLY = 129,
        ICMP6_MEMBERSHIP_QUERY = 130,
        ICMP6_MEMBERSHIP_REPORT = 131,
        ICMP6_MEMBERSHIP_REDUCTION = 132,
        ND_ROUTER_SOLICIT = 133,
        ND_ROUTER_ADVERT = 134,
        ND_NEIGHBOR_SOLICIT = 135,
        ND_NEIGHBOR_ADVERT = 136,
        ND_REDIRECT = 137,
        ICMP6_V2_MEMBERSHIP_REPORT = 143,
    };

    public enum ICMP4_TYPE : int
    {
        ICMP4_ECHO_REPLY = 0,
        ICMP4_DST_UNREACH = 3,
        ICMP4_SOURCE_QUENCH = 4,
        ICMP4_REDIRECT = 5,
        ICMP4_ECHO_REQUEST = 8,
        ICMP4_ROUTER_ADVERT = 9,
        ICMP4_ROUTER_SOLICIT = 10,
        ICMP4_TIME_EXCEEDED = 11,
        ICMP4_PARAM_PROB = 12,
        ICMP4_TIMESTAMP_REQUEST = 13,
        ICMP4_TIMESTAMP_REPLY = 14,
        ICMP4_MASK_REQUEST = 17,
        ICMP4_MASK_REPLY = 18,
    };

    public enum MIB_TCP_STATE : int
    {
        MIB_TCP_STATE_CLOSED = 1,
        MIB_TCP_STATE_LISTEN = 2,
        MIB_TCP_STATE_SYN_SENT = 3,
        MIB_TCP_STATE_SYN_RCVD = 4,
        MIB_TCP_STATE_ESTAB = 5,
        MIB_TCP_STATE_FIN_WAIT1 = 6,
        MIB_TCP_STATE_FIN_WAIT2 = 7,
        MIB_TCP_STATE_CLOSE_WAIT = 8,
        MIB_TCP_STATE_CLOSING = 9,
        MIB_TCP_STATE_LAST_ACK = 10,
        MIB_TCP_STATE_TIME_WAIT = 11,
        MIB_TCP_STATE_DELETE_TCB = 12,
    };

    public enum TCP_CONNECTION_OFFLOAD_STATE : int
    {
        TcpConnectionOffloadStateInHost,
        TcpConnectionOffloadStateOffloading,
        TcpConnectionOffloadStateOffloaded,
        TcpConnectionOffloadStateUploading,
        TcpConnectionOffloadStateMax,
    };

    public enum TCP_RTO_ALGORITHM : int
    {
        TcpRtoAlgorithmOther,
        TcpRtoAlgorithmConstant,
        TcpRtoAlgorithmRsre,
        TcpRtoAlgorithmVanj,
        MIB_TCP_RTO_OTHER = 1,
        MIB_TCP_RTO_CONSTANT = 2,
        MIB_TCP_RTO_RSRE = 3,
        MIB_TCP_RTO_VANJ = 4,
    };

    public enum _TCP_TABLE_CLASS : int
    {
        TCP_TABLE_BASIC_LISTENER,
        TCP_TABLE_BASIC_CONNECTIONS,
        TCP_TABLE_BASIC_ALL,
        TCP_TABLE_OWNER_PID_LISTENER,
        TCP_TABLE_OWNER_PID_CONNECTIONS,
        TCP_TABLE_OWNER_PID_ALL,
        TCP_TABLE_OWNER_MODULE_LISTENER,
        TCP_TABLE_OWNER_MODULE_CONNECTIONS,
        TCP_TABLE_OWNER_MODULE_ALL,
    };

    public enum _UDP_TABLE_CLASS : int
    {
        UDP_TABLE_BASIC,
        UDP_TABLE_OWNER_PID,
        UDP_TABLE_OWNER_MODULE,
    };

    public enum _TCPIP_OWNER_MODULE_INFO_CLASS : int
    {
        TCPIP_OWNER_MODULE_INFO_BASIC,
    };

    public enum TCP_ESTATS_TYPE : int
    {
        TcpConnectionEstatsSynOpts,
        TcpConnectionEstatsData,
        TcpConnectionEstatsSndCong,
        TcpConnectionEstatsPath,
        TcpConnectionEstatsSendBuff,
        TcpConnectionEstatsRec,
        TcpConnectionEstatsObsRec,
        TcpConnectionEstatsBandwidth,
        TcpConnectionEstatsFineRtt,
        TcpConnectionEstatsMaximum,
    };

    public enum _TCP_BOOLEAN_OPTIONAL : int
    {
        TcpBoolOptDisabled = 0,
        TcpBoolOptEnabled,
        TcpBoolOptUnchanged = -1,
    };

    public enum TCP_SOFT_ERROR : int
    {
        TcpErrorNone = 0,
        TcpErrorBelowDataWindow,
        TcpErrorAboveDataWindow,
        TcpErrorBelowAckWindow,
        TcpErrorAboveAckWindow,
        TcpErrorBelowTsWindow,
        TcpErrorAboveTsWindow,
        TcpErrorDataChecksumError,
        TcpErrorDataLengthError,
        TcpErrorMaxSoftError,
    };

    public enum _MIB_NOTIFICATION_TYPE : int
    {
        MibParameterNotification,
        MibAddInstance,
        MibDeleteInstance,
        MibInitialNotification,
    };

    public enum _DEVPROPSTORE : int
    {
        DEVPROP_STORE_SYSTEM,
        DEVPROP_STORE_USER,
    };

    public enum _NDIS_REQUEST_TYPE : int
    {
        NdisRequestQueryInformation,
        NdisRequestSetInformation,
        NdisRequestQueryStatistics,
        NdisRequestOpen,
        NdisRequestClose,
        NdisRequestSend,
        NdisRequestTransferData,
        NdisRequestReset,
        NdisRequestGeneric1,
        NdisRequestGeneric2,
        NdisRequestGeneric3,
        NdisRequestGeneric4,
    };

    public enum _NDIS_INTERRUPT_MODERATION : int
    {
        NdisInterruptModerationUnknown,
        NdisInterruptModerationNotSupported,
        NdisInterruptModerationEnabled,
        NdisInterruptModerationDisabled,
    };

    public enum _NDIS_802_11_STATUS_TYPE : int
    {
        Ndis802_11StatusType_Authentication,
        Ndis802_11StatusType_MediaStreamMode,
        Ndis802_11StatusType_PMKID_CandidateList,
        Ndis802_11StatusTypeMax,
    };

    public enum _NDIS_802_11_NETWORK_TYPE : int
    {
        Ndis802_11FH,
        Ndis802_11DS,
        Ndis802_11OFDM5,
        Ndis802_11OFDM24,
        Ndis802_11Automode,
        Ndis802_11NetworkTypeMax,
    };

    public enum _NDIS_802_11_POWER_MODE : int
    {
        Ndis802_11PowerModeCAM,
        Ndis802_11PowerModeMAX_PSP,
        Ndis802_11PowerModeFast_PSP,
        Ndis802_11PowerModeMax,
    };

    public enum _NDIS_802_11_NETWORK_INFRASTRUCTURE : int
    {
        Ndis802_11IBSS,
        Ndis802_11Infrastructure,
        Ndis802_11AutoUnknown,
        Ndis802_11InfrastructureMax,
    };

    public enum _NDIS_802_11_AUTHENTICATION_MODE : int
    {
        Ndis802_11AuthModeOpen,
        Ndis802_11AuthModeShared,
        Ndis802_11AuthModeAutoSwitch,
        Ndis802_11AuthModeWPA,
        Ndis802_11AuthModeWPAPSK,
        Ndis802_11AuthModeWPANone,
        Ndis802_11AuthModeWPA2,
        Ndis802_11AuthModeWPA2PSK,
        Ndis802_11AuthModeMax,
    };

    public enum _NDIS_802_11_PRIVACY_FILTER : int
    {
        Ndis802_11PrivFilterAcceptAll,
        Ndis802_11PrivFilter8021xWEP,
    };

    public enum _NDIS_802_11_WEP_STATUS : int
    {
        Ndis802_11WEPEnabled,
        Ndis802_11Encryption1Enabled = 0,
        Ndis802_11WEPDisabled,
        Ndis802_11EncryptionDisabled = 1,
        Ndis802_11WEPKeyAbsent,
        Ndis802_11Encryption1KeyAbsent = 2,
        Ndis802_11WEPNotSupported,
        Ndis802_11EncryptionNotSupported = 3,
        Ndis802_11Encryption2Enabled,
        Ndis802_11Encryption2KeyAbsent,
        Ndis802_11Encryption3Enabled,
        Ndis802_11Encryption3KeyAbsent,
    };

    public enum _NDIS_802_11_RELOAD_DEFAULTS : int
    {
        Ndis802_11ReloadWEPKeys,
    };

    public enum _NDIS_802_11_MEDIA_STREAM_MODE : int
    {
        Ndis802_11MediaStreamOff,
        Ndis802_11MediaStreamOn,
    };

    public enum _NDIS_802_11_RADIO_STATUS : int
    {
        Ndis802_11RadioStatusOn,
        Ndis802_11RadioStatusHardwareOff,
        Ndis802_11RadioStatusSoftwareOff,
        Ndis802_11RadioStatusHardwareSoftwareOff,
        Ndis802_11RadioStatusMax,
    };

    public enum _OFFLOAD_OPERATION_E : int
    {
        AUTHENTICATE = 1,
        ENCRYPT,
    };

    public enum _OFFLOAD_CONF_ALGO : int
    {
        OFFLOAD_IPSEC_CONF_NONE,
        OFFLOAD_IPSEC_CONF_DES,
        OFFLOAD_IPSEC_CONF_RESERVED,
        OFFLOAD_IPSEC_CONF_3_DES,
        OFFLOAD_IPSEC_CONF_MAX,
    };

    public enum _OFFLOAD_INTEGRITY_ALGO : int
    {
        OFFLOAD_IPSEC_INTEGRITY_NONE,
        OFFLOAD_IPSEC_INTEGRITY_MD5,
        OFFLOAD_IPSEC_INTEGRITY_SHA,
        OFFLOAD_IPSEC_INTEGRITY_MAX,
    };

    public enum _UDP_ENCAP_TYPE : int
    {
        OFFLOAD_IPSEC_UDPESP_ENCAPTYPE_IKE,
        OFFLOAD_IPSEC_UDPESP_ENCAPTYPE_OTHER,
    };

    public enum _NDIS_MEDIUM : int
    {
        NdisMedium802_3,
        NdisMedium802_5,
        NdisMediumFddi,
        NdisMediumWan,
        NdisMediumLocalTalk,
        NdisMediumDix,
        NdisMediumArcnetRaw,
        NdisMediumArcnet878_2,
        NdisMediumAtm,
        NdisMediumWirelessWan,
        NdisMediumIrda,
        NdisMediumBpc,
        NdisMediumCoWan,
        NdisMedium1394,
        NdisMediumInfiniBand,
        NdisMediumTunnel,
        NdisMediumNative802_11,
        NdisMediumLoopback,
        NdisMediumWiMAX,
        NdisMediumIP,
        NdisMediumMax,
    };

    public enum _NDIS_PHYSICAL_MEDIUM : int
    {
        NdisPhysicalMediumUnspecified,
        NdisPhysicalMediumWirelessLan,
        NdisPhysicalMediumCableModem,
        NdisPhysicalMediumPhoneLine,
        NdisPhysicalMediumPowerLine,
        NdisPhysicalMediumDSL,
        NdisPhysicalMediumFibreChannel,
        NdisPhysicalMedium1394,
        NdisPhysicalMediumWirelessWan,
        NdisPhysicalMediumNative802_11,
        NdisPhysicalMediumBluetooth,
        NdisPhysicalMediumInfiniband,
        NdisPhysicalMediumWiMax,
        NdisPhysicalMediumUWB,
        NdisPhysicalMedium802_3,
        NdisPhysicalMedium802_5,
        NdisPhysicalMediumIrda,
        NdisPhysicalMediumWiredWAN,
        NdisPhysicalMediumWiredCoWan,
        NdisPhysicalMediumOther,
        NdisPhysicalMediumMax,
    };

    public enum _NDIS_HARDWARE_STATUS : int
    {
        NdisHardwareStatusReady,
        NdisHardwareStatusInitializing,
        NdisHardwareStatusReset,
        NdisHardwareStatusClosing,
        NdisHardwareStatusNotReady,
    };

    public enum _NDIS_DEVICE_POWER_STATE : int
    {
        NdisDeviceStateUnspecified = 0,
        NdisDeviceStateD0,
        NdisDeviceStateD1,
        NdisDeviceStateD2,
        NdisDeviceStateD3,
        NdisDeviceStateMaximum,
    };

    public enum _NDIS_FDDI_ATTACHMENT_TYPE : int
    {
        NdisFddiTypeIsolated = 1,
        NdisFddiTypeLocalA,
        NdisFddiTypeLocalB,
        NdisFddiTypeLocalAB,
        NdisFddiTypeLocalS,
        NdisFddiTypeWrapA,
        NdisFddiTypeWrapB,
        NdisFddiTypeWrapAB,
        NdisFddiTypeWrapS,
        NdisFddiTypeCWrapA,
        NdisFddiTypeCWrapB,
        NdisFddiTypeCWrapS,
        NdisFddiTypeThrough,
    };

    public enum _NDIS_FDDI_RING_MGT_STATE : int
    {
        NdisFddiRingIsolated = 1,
        NdisFddiRingNonOperational,
        NdisFddiRingOperational,
        NdisFddiRingDetect,
        NdisFddiRingNonOperationalDup,
        NdisFddiRingOperationalDup,
        NdisFddiRingDirected,
        NdisFddiRingTrace,
    };

    public enum _NDIS_FDDI_LCONNECTION_STATE : int
    {
        NdisFddiStateOff = 1,
        NdisFddiStateBreak,
        NdisFddiStateTrace,
        NdisFddiStateConnect,
        NdisFddiStateNext,
        NdisFddiStateSignal,
        NdisFddiStateJoin,
        NdisFddiStateVerify,
        NdisFddiStateActive,
        NdisFddiStateMaintenance,
    };

    public enum _NDIS_WAN_MEDIUM_SUBTYPE : int
    {
        NdisWanMediumHub,
        NdisWanMediumX_25,
        NdisWanMediumIsdn,
        NdisWanMediumSerial,
        NdisWanMediumFrameRelay,
        NdisWanMediumAtm,
        NdisWanMediumSonet,
        NdisWanMediumSW56K,
        NdisWanMediumPPTP,
        NdisWanMediumL2TP,
        NdisWanMediumIrda,
        NdisWanMediumParallel,
        NdisWanMediumPppoe,
        NdisWanMediumSSTP,
        NdisWanMediumAgileVPN,
        NdisWanMediumGre,
        NdisWanMediumSubTypeMax,
    };

    public enum _NDIS_WAN_HEADER_FORMAT : int
    {
        NdisWanHeaderNative,
        NdisWanHeaderEthernet,
    };

    public enum _NDIS_WAN_QUALITY : int
    {
        NdisWanRaw,
        NdisWanErrorControl,
        NdisWanReliable,
    };

    public enum _NDIS_802_5_RING_STATE : int
    {
        NdisRingStateOpened = 1,
        NdisRingStateClosed,
        NdisRingStateOpening,
        NdisRingStateClosing,
        NdisRingStateOpenFailure,
        NdisRingStateRingFailure,
    };

    public enum _NDIS_MEDIA_STATE : int
    {
        NdisMediaStateConnected,
        NdisMediaStateDisconnected,
    };

    public enum _DOT11_BSS_TYPE : int
    {
        dot11_BSS_type_infrastructure = 1,
        dot11_BSS_type_independent = 2,
        dot11_BSS_type_any = 3,
    };

    public enum _DOT11_AUTH_ALGORITHM : int
    {
        DOT11_AUTH_ALGO_80211_OPEN = 1,
        DOT11_AUTH_ALGO_80211_SHARED_KEY = 2,
        DOT11_AUTH_ALGO_WPA = 3,
        DOT11_AUTH_ALGO_WPA_PSK = 4,
        DOT11_AUTH_ALGO_WPA_NONE = 5,
        DOT11_AUTH_ALGO_RSNA = 6,
        DOT11_AUTH_ALGO_RSNA_PSK = 7,
        DOT11_AUTH_ALGO_IHV_START = -2147483648,
        DOT11_AUTH_ALGO_IHV_END = -1,
    };

    public enum _DOT11_CIPHER_ALGORITHM : int
    {
        DOT11_CIPHER_ALGO_NONE = 0,
        DOT11_CIPHER_ALGO_WEP40 = 1,
        DOT11_CIPHER_ALGO_TKIP = 2,
        DOT11_CIPHER_ALGO_CCMP = 4,
        DOT11_CIPHER_ALGO_WEP104 = 5,
        DOT11_CIPHER_ALGO_BIP = 6,
        DOT11_CIPHER_ALGO_WPA_USE_GROUP = 256,
        DOT11_CIPHER_ALGO_RSN_USE_GROUP = 256,
        DOT11_CIPHER_ALGO_WEP = 257,
        DOT11_CIPHER_ALGO_IHV_START = -2147483648,
        DOT11_CIPHER_ALGO_IHV_END = -1,
    };

    public enum _DOT11_PHY_TYPE : int
    {
        dot11_phy_type_unknown = 0,
        dot11_phy_type_any = 0,
        dot11_phy_type_fhss = 1,
        dot11_phy_type_dsss = 2,
        dot11_phy_type_irbaseband = 3,
        dot11_phy_type_ofdm = 4,
        dot11_phy_type_hrdsss = 5,
        dot11_phy_type_erp = 6,
        dot11_phy_type_ht = 7,
        dot11_phy_type_vht = 8,
        dot11_phy_type_IHV_start = -2147483648,
        dot11_phy_type_IHV_end = -1,
    };

    public enum _DOT11_OFFLOAD_TYPE : int
    {
        dot11_offload_type_wep = 1,
        dot11_offload_type_auth = 2,
    };

    public enum _DOT11_KEY_DIRECTION : int
    {
        dot11_key_direction_both = 1,
        dot11_key_direction_inbound = 2,
        dot11_key_direction_outbound = 3,
    };

    public enum _DOT11_SCAN_TYPE : int
    {
        dot11_scan_type_active = 1,
        dot11_scan_type_passive = 2,
        dot11_scan_type_auto = 3,
        dot11_scan_type_forced = -2147483648,
    };

    public enum _CH_DESCRIPTION_TYPE : int
    {
        ch_description_type_logical = 1,
        ch_description_type_center_frequency = 2,
        ch_description_type_phy_specific,
    };

    public enum _DOT11_UPDATE_IE_OP : int
    {
        dot11_update_ie_op_create_replace = 1,
        dot11_update_ie_op_delete = 2,
    };

    public enum _DOT11_RESET_TYPE : int
    {
        dot11_reset_type_phy = 1,
        dot11_reset_type_mac = 2,
        dot11_reset_type_phy_and_mac = 3,
    };

    public enum _DOT11_POWER_MODE : int
    {
        dot11_power_mode_unknown = 0,
        dot11_power_mode_active = 1,
        dot11_power_mode_powersave = 2,
    };

    public enum _DOT11_TEMP_TYPE : int
    {
        dot11_temp_type_unknown = 0,
        dot11_temp_type_1 = 1,
        dot11_temp_type_2 = 2,
    };

    public enum _DOT11_DIVERSITY_SUPPORT : int
    {
        dot11_diversity_support_unknown = 0,
        dot11_diversity_support_fixedlist = 1,
        dot11_diversity_support_notsupported = 2,
        dot11_diversity_support_dynamic = 3,
    };

    public enum _DOT11_HOP_ALGO_ADOPTED : int
    {
        dot11_hop_algo_current = 0,
        dot11_hop_algo_hop_index = 1,
        dot11_hop_algo_hcc = 2,
    };

    public enum _DOT11_AC_PARAM : int
    {
        dot11_AC_param_BE = 0,
        dot11_AC_param_BK = 1,
        dot11_AC_param_VI = 2,
        dot11_AC_param_VO = 3,
        dot11_AC_param_max,
    };

    public enum DOT11_DIRECTION : int
    {
        DOT11_DIR_INBOUND = 1,
        DOT11_DIR_OUTBOUND,
        DOT11_DIR_BOTH,
    };

    public enum _DOT11_ASSOCIATION_STATE : int
    {
        dot11_assoc_state_zero = 0,
        dot11_assoc_state_unauth_unassoc = 1,
        dot11_assoc_state_auth_unassoc = 2,
        dot11_assoc_state_auth_assoc = 3,
    };

    public enum DOT11_DS_INFO : int
    {
        DOT11_DS_CHANGED,
        DOT11_DS_UNCHANGED,
        DOT11_DS_UNKNOWN,
    };

    public enum _DOT11_WPS_CONFIG_METHOD : int
    {
        DOT11_WPS_CONFIG_METHOD_NULL = 0,
        DOT11_WPS_CONFIG_METHOD_DISPLAY = 8,
        DOT11_WPS_CONFIG_METHOD_PUSHBUTTON = 128,
        DOT11_WPS_CONFIG_METHOD_KEYPAD = 256,
    };

    public enum _DOT11_WPS_DEVICE_PASSWORD_ID : int
    {
        DOT11_WPS_PASSWORD_ID_DEFAULT = 0,
        DOT11_WPS_PASSWORD_ID_USER_SPECIFIED = 1,
        DOT11_WPS_PASSWORD_ID_MACHINE_SPECIFIED = 2,
        DOT11_WPS_PASSWORD_ID_REKEY = 3,
        DOT11_WPS_PASSWORD_ID_PUSHBUTTON = 4,
        DOT11_WPS_PASSWORD_ID_REGISTRAR_SPECIFIED = 5,
    };

    public enum _DOT11_WFD_DISCOVER_TYPE : int
    {
        dot11_wfd_discover_type_scan_only = 1,
        dot11_wfd_discover_type_find_only = 2,
        dot11_wfd_discover_type_auto = 3,
        dot11_wfd_discover_type_scan_social_channels = 4,
        dot11_wfd_discover_type_forced = -2147483648,
    };

    public enum _DOT11_WFD_SCAN_TYPE : int
    {
        dot11_wfd_scan_type_active = 1,
        dot11_wfd_scan_type_passive = 2,
        dot11_wfd_scan_type_auto = 3,
    };

    public enum _DOT11_POWER_MODE_REASON : int
    {
        dot11_power_mode_reason_no_change = 0,
        dot11_power_mode_reason_noncompliant_AP = 1,
        dot11_power_mode_reason_legacy_WFD_device = 2,
        dot11_power_mode_reason_compliant_AP = 3,
        dot11_power_mode_reason_compliant_WFD_device = 4,
        dot11_power_mode_reason_others = 5,
    };

    public enum _DOT11_MANUFACTURING_TEST_TYPE : int
    {
        dot11_manufacturing_test_unknown = 0,
        dot11_manufacturing_test_self_start = 1,
        dot11_manufacturing_test_self_query_result = 2,
        dot11_manufacturing_test_rx = 3,
        dot11_manufacturing_test_tx = 4,
        dot11_manufacturing_test_query_adc = 5,
        dot11_manufacturing_test_set_data = 6,
        dot11_manufacturing_test_query_data = 7,
        dot11_manufacturing_test_sleep = 8,
        dot11_manufacturing_test_awake = 9,
        dot11_manufacturing_test_IHV_start = -2147483648,
        dot11_manufacturing_test_IHV_end = -1,
    };

    public enum DOT11_MANUFACTURING_SELF_TEST_TYPE : int
    {
        DOT11_MANUFACTURING_SELF_TEST_TYPE_INTERFACE = 1,
        DOT11_MANUFACTURING_SELF_TEST_TYPE_RF_INTERFACE,
        DOT11_MANUFACTURING_SELF_TEST_TYPE_BT_COEXISTENCE,
    };

    public enum DOT11_BAND : int
    {
        dot11_band_2p4g = 1,
        dot11_band_4p9g,
        dot11_band_5g,
    };

    public enum _DOT11_MANUFACTURING_CALLBACK_TYPE : int
    {
        dot11_manufacturing_callback_unknown = 0,
        dot11_manufacturing_callback_self_test_complete = 1,
        dot11_manufacturing_callback_sleep_complete = 2,
        dot11_manufacturing_callback_IHV_start = -2147483648,
        dot11_manufacturing_callback_IHV_end = -1,
    };

    public enum _NDIS_SUPPORTED_PAUSE_FUNCTIONS : int
    {
        NdisPauseFunctionsUnsupported,
        NdisPauseFunctionsSendOnly,
        NdisPauseFunctionsReceiveOnly,
        NdisPauseFunctionsSendAndReceive,
        NdisPauseFunctionsUnknown,
    };

    public enum _NDIS_PORT_TYPE : int
    {
        NdisPortTypeUndefined,
        NdisPortTypeBridge,
        NdisPortTypeRasConnection,
        NdisPortType8021xSupplicant,
        NdisPortTypeMax,
    };

    public enum _NDIS_PORT_AUTHORIZATION_STATE : int
    {
        NdisPortAuthorizationUnknown,
        NdisPortAuthorized,
        NdisPortUnauthorized,
        NdisPortReauthorizing,
    };

    public enum _NDIS_PORT_CONTROL_STATE : int
    {
        NdisPortControlStateUnknown,
        NdisPortControlStateControlled,
        NdisPortControlStateUncontrolled,
    };

    public enum _NDIS_NETWORK_CHANGE_TYPE : int
    {
        NdisPossibleNetworkChange = 1,
        NdisDefinitelyNetworkChange,
        NdisNetworkChangeFromMediaConnect,
        NdisNetworkChangeMax,
    };

    public enum _NDIS_PROCESSOR_VENDOR : int
    {
        NdisProcessorVendorUnknown,
        NdisProcessorVendorGenuinIntel,
        NdisProcessorVendorGenuineIntel = 1,
        NdisProcessorVendorAuthenticAMD,
    };

    public enum _MIB_IF_TABLE_LEVEL : int
    {
        MibIfTableNormal,
        MibIfTableRaw,
    };

    public enum TA_PROPERTY : int
    {
        TAP_FLAGS,
        TAP_TRANSFORMCOUNT,
        TAP_STAGGERDELAY,
        TAP_STAGGERDELAYCAP,
        TAP_STAGGERDELAYFACTOR,
        TAP_ZORDER,
    };

    public enum TA_PROPERTY_FLAG : int
    {
        TAPF_NONE = 0,
        TAPF_HASSTAGGER = 1,
        TAPF_ISRTLAWARE = 2,
        TAPF_ALLOWCOLLECTION = 4,
        TAPF_HASBACKGROUND = 8,
        TAPF_HASPERSPECTIVE = 16,
    };

    public enum TA_TRANSFORM_TYPE : int
    {
        TATT_TRANSLATE_2D,
        TATT_SCALE_2D,
        TATT_OPACITY,
        TATT_CLIP,
    };

    public enum TA_TRANSFORM_FLAG : int
    {
        TATF_NONE = 0,
        TATF_TARGETVALUES_USER = 1,
        TATF_HASINITIALVALUES = 2,
        TATF_HASORIGINVALUES = 4,
    };

    public enum TA_TIMINGFUNCTION_TYPE : int
    {
        TTFT_UNDEFINED,
        TTFT_CUBIC_BEZIER,
    };

    public enum THEMESIZE : int
    {
        TS_MIN,
        TS_TRUE,
        TS_DRAW,
    };

    public enum PROPERTYORIGIN : int
    {
        PO_STATE,
        PO_PART,
        PO_CLASS,
        PO_GLOBAL,
        PO_NOTFOUND,
    };

    public enum WINDOWTHEMEATTRIBUTETYPE : int
    {
        WTA_NONCLIENT = 1,
    };

    public enum _BP_BUFFERFORMAT : int
    {
        BPBF_COMPATIBLEBITMAP,
        BPBF_DIB,
        BPBF_TOPDOWNDIB,
        BPBF_TOPDOWNMONODIB,
    };

    public enum _BP_ANIMATIONSTYLE : int
    {
        BPAS_NONE,
        BPAS_LINEAR,
        BPAS_CUBIC,
        BPAS_SINE,
    };

    public enum DWMWINDOWATTRIBUTE : int
    {
        DWMWA_NCRENDERING_ENABLED = 1,
        DWMWA_NCRENDERING_POLICY,
        DWMWA_TRANSITIONS_FORCEDISABLED,
        DWMWA_ALLOW_NCPAINT,
        DWMWA_CAPTION_BUTTON_BOUNDS,
        DWMWA_NONCLIENT_RTL_LAYOUT,
        DWMWA_FORCE_ICONIC_REPRESENTATION,
        DWMWA_FLIP3D_POLICY,
        DWMWA_EXTENDED_FRAME_BOUNDS,
        DWMWA_HAS_ICONIC_BITMAP,
        DWMWA_DISALLOW_PEEK,
        DWMWA_EXCLUDED_FROM_PEEK,
        DWMWA_CLOAK,
        DWMWA_CLOAKED,
        DWMWA_FREEZE_REPRESENTATION,
        DWMWA_LAST,
    };

    public enum DWMNCRENDERINGPOLICY : int
    {
        DWMNCRP_USEWINDOWSTYLE,
        DWMNCRP_DISABLED,
        DWMNCRP_ENABLED,
        DWMNCRP_LAST,
    };

    public enum DWMFLIP3DWINDOWPOLICY : int
    {
        DWMFLIP3D_DEFAULT,
        DWMFLIP3D_EXCLUDEBELOW,
        DWMFLIP3D_EXCLUDEABOVE,
        DWMFLIP3D_LAST,
    };

    public enum DWM_SOURCE_FRAME_SAMPLING : int
    {
        DWM_SOURCE_FRAME_SAMPLING_POINT,
        DWM_SOURCE_FRAME_SAMPLING_COVERAGE,
        DWM_SOURCE_FRAME_SAMPLING_LAST,
    };

    public enum DWMTRANSITION_OWNEDWINDOW_TARGET : int
    {
        DWMTRANSITION_OWNEDWINDOW_NULL = -1,
        DWMTRANSITION_OWNEDWINDOW_REPOSITION = 0,
    };

    public enum GESTURE_TYPE : int
    {
        GT_PEN_TAP = 0,
        GT_PEN_DOUBLETAP = 1,
        GT_PEN_RIGHTTAP = 2,
        GT_PEN_PRESSANDHOLD = 3,
        GT_PEN_PRESSANDHOLDABORT = 4,
        GT_TOUCH_TAP = 5,
        GT_TOUCH_DOUBLETAP = 6,
        GT_TOUCH_RIGHTTAP = 7,
        GT_TOUCH_PRESSANDHOLD = 8,
        GT_TOUCH_PRESSANDHOLDABORT = 9,
        GT_TOUCH_PRESSANDTAP = 10,
    };

    public enum DWM_SHOWCONTACT : int
    {
        DWMSC_DOWN = 1,
        DWMSC_UP = 2,
        DWMSC_DRAG = 4,
        DWMSC_HOLD = 8,
        DWMSC_PENBARREL = 16,
        DWMSC_NONE = 0,
        DWMSC_ALL = -1,
    };

    public enum tagHH_GPROPID : int
    {
        HH_GPROPID_SINGLETHREAD = 1,
        HH_GPROPID_TOOLBAR_MARGIN = 2,
        HH_GPROPID_UI_LANGUAGE = 3,
        HH_GPROPID_CURRENT_SUBSET = 4,
        HH_GPROPID_CONTENT_LANGUAGE = 5,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0002_0002 : int
    {
        UI_ANIMATION_SCHEDULING_UNEXPECTED_FAILURE = 0,
        UI_ANIMATION_SCHEDULING_INSUFFICIENT_PRIORITY = 1,
        UI_ANIMATION_SCHEDULING_ALREADY_SCHEDULED = 2,
        UI_ANIMATION_SCHEDULING_SUCCEEDED = 3,
        UI_ANIMATION_SCHEDULING_DEFERRED = 4,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0002_0001 : int
    {
        UI_ANIMATION_STORYBOARD_BUILDING = 0,
        UI_ANIMATION_STORYBOARD_SCHEDULED = 1,
        UI_ANIMATION_STORYBOARD_CANCELLED = 2,
        UI_ANIMATION_STORYBOARD_PLAYING = 3,
        UI_ANIMATION_STORYBOARD_TRUNCATED = 4,
        UI_ANIMATION_STORYBOARD_FINISHED = 5,
        UI_ANIMATION_STORYBOARD_READY = 6,
        UI_ANIMATION_STORYBOARD_INSUFFICIENT_PRIORITY = 7,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0001_0001 : int
    {
        UI_ANIMATION_ROUNDING_NEAREST = 0,
        UI_ANIMATION_ROUNDING_FLOOR = 1,
        UI_ANIMATION_ROUNDING_CEILING = 2,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0000_0001 : int
    {
        UI_ANIMATION_UPDATE_NO_CHANGE = 0,
        UI_ANIMATION_UPDATE_VARIABLES_CHANGED = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0000_0002 : int
    {
        UI_ANIMATION_MANAGER_IDLE = 0,
        UI_ANIMATION_MANAGER_BUSY = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0000_0003 : int
    {
        UI_ANIMATION_MODE_DISABLED = 0,
        UI_ANIMATION_MODE_SYSTEM_DEFAULT = 1,
        UI_ANIMATION_MODE_ENABLED = 2,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0008_0001 : int
    {
        UI_ANIMATION_PRIORITY_EFFECT_FAILURE = 0,
        UI_ANIMATION_PRIORITY_EFFECT_DELAY = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0009_0001 : int
    {
        UI_ANIMATION_SLOPE_INCREASING = 0,
        UI_ANIMATION_SLOPE_DECREASING = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0010_0001 : int
    {
        UI_ANIMATION_DEPENDENCY_NONE = 0,
        UI_ANIMATION_DEPENDENCY_INTERMEDIATE_VALUES = 1,
        UI_ANIMATION_DEPENDENCY_FINAL_VALUE = 2,
        UI_ANIMATION_DEPENDENCY_FINAL_VELOCITY = 4,
        UI_ANIMATION_DEPENDENCY_DURATION = 8,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0014_0001 : int
    {
        UI_ANIMATION_TIMER_CLIENT_IDLE = 0,
        UI_ANIMATION_TIMER_CLIENT_BUSY = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0012_0001 : int
    {
        UI_ANIMATION_IDLE_BEHAVIOR_CONTINUE = 0,
        UI_ANIMATION_IDLE_BEHAVIOR_DISABLE = 1,
    };

    public enum __MIDL___MIDL_itf_UIAnimation_0000_0000_0004 : int
    {
        UI_ANIMATION_REPEAT_MODE_NORMAL = 0,
        UI_ANIMATION_REPEAT_MODE_ALTERNATE = 1,
    };

    public enum AfxSig : int
    {
        AfxSig_end = 0,
        AfxSig_b_D_v,
        AfxSig_b_b_v,
        AfxSig_b_u_v,
        AfxSig_b_h_v,
        AfxSig_b_W_uu,
        AfxSig_b_W_COPYDATASTRUCT,
        AfxSig_b_v_HELPINFO,
        AfxSig_CTLCOLOR,
        AfxSig_CTLCOLOR_REFLECT,
        AfxSig_i_u_W_u,
        AfxSig_i_uu_v,
        AfxSig_i_W_uu,
        AfxSig_i_v_s,
        AfxSig_l_w_l,
        AfxSig_l_uu_M,
        AfxSig_v_b_h,
        AfxSig_v_h_v,
        AfxSig_v_h_h,
        AfxSig_v_v_v,
        AfxSig_v_u_v,
        AfxSig_v_up_v,
        AfxSig_v_u_u,
        AfxSig_v_uu_v,
        AfxSig_v_v_ii,
        AfxSig_v_u_uu,
        AfxSig_v_u_ii,
        AfxSig_v_u_W,
        AfxSig_i_u_v,
        AfxSig_u_u_v,
        AfxSig_b_v_v,
        AfxSig_v_w_l,
        AfxSig_MDIACTIVATE,
        AfxSig_v_D_v,
        AfxSig_v_M_v,
        AfxSig_v_M_ub,
        AfxSig_v_W_v,
        AfxSig_v_v_W,
        AfxSig_v_W_uu,
        AfxSig_v_W_p,
        AfxSig_v_W_h,
        AfxSig_C_v_v,
        AfxSig_ACTIVATE,
        AfxSig_SCROLL,
        AfxSig_SCROLL_REFLECT,
        AfxSig_v_v_s,
        AfxSig_v_u_cs,
        AfxSig_OWNERDRAW,
        AfxSig_i_i_s,
        AfxSig_u_v_p,
        AfxSig_u_v_v,
        AfxSig_v_b_NCCALCSIZEPARAMS,
        AfxSig_v_v_WINDOWPOS,
        AfxSig_v_uu_M,
        AfxSig_v_u_p,
        AfxSig_SIZING,
        AfxSig_MOUSEWHEEL,
        AfxSig_MOUSEHWHEEL,
        AfxSigCmd_v,
        AfxSigCmd_b,
        AfxSigCmd_RANGE,
        AfxSigCmd_EX,
        AfxSigNotify_v,
        AfxSigNotify_b,
        AfxSigNotify_RANGE,
        AfxSigNotify_EX,
        AfxSigCmdUI,
        AfxSigCmdUI_RANGE,
        AfxSigCmd_v_pv,
        AfxSigCmd_b_pv,
        AfxSig_l,
        AfxSig_l_p,
        AfxSig_u_W_u,
        AfxSig_v_u_M,
        AfxSig_u_u_M,
        AfxSig_u_v_MENUGETOBJECTINFO,
        AfxSig_v_M_u,
        AfxSig_v_u_LPMDINEXTMENU,
        AfxSig_APPCOMMAND,
        AfxSig_RAWINPUT,
        AfxSig_u_u_u,
        AfxSig_MOUSE_XBUTTON,
        AfxSig_MOUSE_NCXBUTTON,
        AfxSig_INPUTLANGCHANGE,
        AfxSig_v_u_hkl,
        AfxSig_INPUTDEVICECHANGE,
        AfxSig_l_D_u,
        AfxSig_i_v_S,
        AfxSig_v_F_b,
        AfxSig_h_v_v,
        AfxSig_h_b_h,
        AfxSig_b_v_ii,
        AfxSig_h_h_h,
        AfxSig_MDINext,
        AfxSig_u_u_l,
        AfxSig_bD = 1,
        AfxSig_bb = 2,
        AfxSig_bWww = 5,
        AfxSig_hDWw = 8,
        AfxSig_hDw = 9,
        AfxSig_iwWw = 10,
        AfxSig_iww = 11,
        AfxSig_iWww = 12,
        AfxSig_is = 13,
        AfxSig_lwl = 14,
        AfxSig_lwwM = 15,
        AfxSig_vv = 19,
        AfxSig_vw = 20,
        AfxSig_vww = 22,
        AfxSig_vww2 = 23,
        AfxSig_vvii = 24,
        AfxSig_vwww = 25,
        AfxSig_vwii = 26,
        AfxSig_vwl = 31,
        AfxSig_vbWW = 32,
        AfxSig_vD = 33,
        AfxSig_vM = 34,
        AfxSig_vMwb = 35,
        AfxSig_vW = 36,
        AfxSig_vWww = 38,
        AfxSig_vWp = 39,
        AfxSig_vWh = 40,
        AfxSig_vwW = 27,
        AfxSig_vwWb = 42,
        AfxSig_vwwW = 43,
        AfxSig_vwwx = 44,
        AfxSig_vs = 45,
        AfxSig_vOWNER = 47,
        AfxSig_iis = 48,
        AfxSig_wp = 49,
        AfxSig_wv = 50,
        AfxSig_vPOS = 52,
        AfxSig_vCALC = 51,
        AfxSig_vNMHDRpl = 62,
        AfxSig_bNMHDRpl = 63,
        AfxSig_vwNMHDRpl = 64,
        AfxSig_bwNMHDRpl = 65,
        AfxSig_bHELPINFO = 7,
        AfxSig_vwSIZING = 55,
        AfxSig_cmdui = 66,
        AfxSig_cmduiw = 67,
        AfxSig_vpv = 68,
        AfxSig_bpv = 69,
        AfxSig_vwwh = 53,
        AfxSig_vwp = 54,
        AfxSig_bw = 3,
        AfxSig_bh = 4,
        AfxSig_iw = 28,
        AfxSig_ww = 29,
        AfxSig_bv = 30,
        AfxSig_hv = 41,
        AfxSig_vb = 20,
        AfxSig_vbh = 16,
        AfxSig_vbw = 22,
        AfxSig_vhh = 18,
        AfxSig_vh = 17,
        AfxSig_viSS = 31,
        AfxSig_bwl = 14,
        AfxSig_vwMOVING = 55,
        AfxSig_vW2 = 37,
        AfxSig_bWCDS = 6,
        AfxSig_bwsp = 56,
        AfxSig_vws = 46,
    };

    public enum DSCREASON : int
    {
        dscNoReason = 0,
        dscClose,
        dscCommit,
        dscDelete,
        dscEdit,
        dscInsert,
        dscModify,
        dscMove,
    };

    public enum _D3DLIGHTTYPE : int
    {
        D3DLIGHT_POINT = 1,
        D3DLIGHT_SPOT = 2,
        D3DLIGHT_DIRECTIONAL = 3,
        D3DLIGHT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADEMODE : int
    {
        D3DSHADE_FLAT = 1,
        D3DSHADE_GOURAUD = 2,
        D3DSHADE_PHONG = 3,
        D3DSHADE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DFILLMODE : int
    {
        D3DFILL_POINT = 1,
        D3DFILL_WIREFRAME = 2,
        D3DFILL_SOLID = 3,
        D3DFILL_FORCE_DWORD = 2147483647,
    };

    public enum _D3DBLEND : int
    {
        D3DBLEND_ZERO = 1,
        D3DBLEND_ONE = 2,
        D3DBLEND_SRCCOLOR = 3,
        D3DBLEND_INVSRCCOLOR = 4,
        D3DBLEND_SRCALPHA = 5,
        D3DBLEND_INVSRCALPHA = 6,
        D3DBLEND_DESTALPHA = 7,
        D3DBLEND_INVDESTALPHA = 8,
        D3DBLEND_DESTCOLOR = 9,
        D3DBLEND_INVDESTCOLOR = 10,
        D3DBLEND_SRCALPHASAT = 11,
        D3DBLEND_BOTHSRCALPHA = 12,
        D3DBLEND_BOTHINVSRCALPHA = 13,
        D3DBLEND_BLENDFACTOR = 14,
        D3DBLEND_INVBLENDFACTOR = 15,
        D3DBLEND_SRCCOLOR2 = 16,
        D3DBLEND_INVSRCCOLOR2 = 17,
        D3DBLEND_FORCE_DWORD = 2147483647,
    };

    public enum _D3DBLENDOP : int
    {
        D3DBLENDOP_ADD = 1,
        D3DBLENDOP_SUBTRACT = 2,
        D3DBLENDOP_REVSUBTRACT = 3,
        D3DBLENDOP_MIN = 4,
        D3DBLENDOP_MAX = 5,
        D3DBLENDOP_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTEXTUREADDRESS : int
    {
        D3DTADDRESS_WRAP = 1,
        D3DTADDRESS_MIRROR = 2,
        D3DTADDRESS_CLAMP = 3,
        D3DTADDRESS_BORDER = 4,
        D3DTADDRESS_MIRRORONCE = 5,
        D3DTADDRESS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DCULL : int
    {
        D3DCULL_NONE = 1,
        D3DCULL_CW = 2,
        D3DCULL_CCW = 3,
        D3DCULL_FORCE_DWORD = 2147483647,
    };

    public enum _D3DCMPFUNC : int
    {
        D3DCMP_NEVER = 1,
        D3DCMP_LESS = 2,
        D3DCMP_EQUAL = 3,
        D3DCMP_LESSEQUAL = 4,
        D3DCMP_GREATER = 5,
        D3DCMP_NOTEQUAL = 6,
        D3DCMP_GREATEREQUAL = 7,
        D3DCMP_ALWAYS = 8,
        D3DCMP_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSTENCILOP : int
    {
        D3DSTENCILOP_KEEP = 1,
        D3DSTENCILOP_ZERO = 2,
        D3DSTENCILOP_REPLACE = 3,
        D3DSTENCILOP_INCRSAT = 4,
        D3DSTENCILOP_DECRSAT = 5,
        D3DSTENCILOP_INVERT = 6,
        D3DSTENCILOP_INCR = 7,
        D3DSTENCILOP_DECR = 8,
        D3DSTENCILOP_FORCE_DWORD = 2147483647,
    };

    public enum _D3DFOGMODE : int
    {
        D3DFOG_NONE = 0,
        D3DFOG_EXP = 1,
        D3DFOG_EXP2 = 2,
        D3DFOG_LINEAR = 3,
        D3DFOG_FORCE_DWORD = 2147483647,
    };

    public enum _D3DZBUFFERTYPE : int
    {
        D3DZB_FALSE = 0,
        D3DZB_TRUE = 1,
        D3DZB_USEW = 2,
        D3DZB_FORCE_DWORD = 2147483647,
    };

    public enum _D3DPRIMITIVETYPE : int
    {
        D3DPT_POINTLIST = 1,
        D3DPT_LINELIST = 2,
        D3DPT_LINESTRIP = 3,
        D3DPT_TRIANGLELIST = 4,
        D3DPT_TRIANGLESTRIP = 5,
        D3DPT_TRIANGLEFAN = 6,
        D3DPT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTRANSFORMSTATETYPE : int
    {
        D3DTS_VIEW = 2,
        D3DTS_PROJECTION = 3,
        D3DTS_TEXTURE0 = 16,
        D3DTS_TEXTURE1 = 17,
        D3DTS_TEXTURE2 = 18,
        D3DTS_TEXTURE3 = 19,
        D3DTS_TEXTURE4 = 20,
        D3DTS_TEXTURE5 = 21,
        D3DTS_TEXTURE6 = 22,
        D3DTS_TEXTURE7 = 23,
        D3DTS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DRENDERSTATETYPE : int
    {
        D3DRS_ZENABLE = 7,
        D3DRS_FILLMODE = 8,
        D3DRS_SHADEMODE = 9,
        D3DRS_ZWRITEENABLE = 14,
        D3DRS_ALPHATESTENABLE = 15,
        D3DRS_LASTPIXEL = 16,
        D3DRS_SRCBLEND = 19,
        D3DRS_DESTBLEND = 20,
        D3DRS_CULLMODE = 22,
        D3DRS_ZFUNC = 23,
        D3DRS_ALPHAREF = 24,
        D3DRS_ALPHAFUNC = 25,
        D3DRS_DITHERENABLE = 26,
        D3DRS_ALPHABLENDENABLE = 27,
        D3DRS_FOGENABLE = 28,
        D3DRS_SPECULARENABLE = 29,
        D3DRS_FOGCOLOR = 34,
        D3DRS_FOGTABLEMODE = 35,
        D3DRS_FOGSTART = 36,
        D3DRS_FOGEND = 37,
        D3DRS_FOGDENSITY = 38,
        D3DRS_RANGEFOGENABLE = 48,
        D3DRS_STENCILENABLE = 52,
        D3DRS_STENCILFAIL = 53,
        D3DRS_STENCILZFAIL = 54,
        D3DRS_STENCILPASS = 55,
        D3DRS_STENCILFUNC = 56,
        D3DRS_STENCILREF = 57,
        D3DRS_STENCILMASK = 58,
        D3DRS_STENCILWRITEMASK = 59,
        D3DRS_TEXTUREFACTOR = 60,
        D3DRS_WRAP0 = 128,
        D3DRS_WRAP1 = 129,
        D3DRS_WRAP2 = 130,
        D3DRS_WRAP3 = 131,
        D3DRS_WRAP4 = 132,
        D3DRS_WRAP5 = 133,
        D3DRS_WRAP6 = 134,
        D3DRS_WRAP7 = 135,
        D3DRS_CLIPPING = 136,
        D3DRS_LIGHTING = 137,
        D3DRS_AMBIENT = 139,
        D3DRS_FOGVERTEXMODE = 140,
        D3DRS_COLORVERTEX = 141,
        D3DRS_LOCALVIEWER = 142,
        D3DRS_NORMALIZENORMALS = 143,
        D3DRS_DIFFUSEMATERIALSOURCE = 145,
        D3DRS_SPECULARMATERIALSOURCE = 146,
        D3DRS_AMBIENTMATERIALSOURCE = 147,
        D3DRS_EMISSIVEMATERIALSOURCE = 148,
        D3DRS_VERTEXBLEND = 151,
        D3DRS_CLIPPLANEENABLE = 152,
        D3DRS_POINTSIZE = 154,
        D3DRS_POINTSIZE_MIN = 155,
        D3DRS_POINTSPRITEENABLE = 156,
        D3DRS_POINTSCALEENABLE = 157,
        D3DRS_POINTSCALE_A = 158,
        D3DRS_POINTSCALE_B = 159,
        D3DRS_POINTSCALE_C = 160,
        D3DRS_MULTISAMPLEANTIALIAS = 161,
        D3DRS_MULTISAMPLEMASK = 162,
        D3DRS_PATCHEDGESTYLE = 163,
        D3DRS_DEBUGMONITORTOKEN = 165,
        D3DRS_POINTSIZE_MAX = 166,
        D3DRS_INDEXEDVERTEXBLENDENABLE = 167,
        D3DRS_COLORWRITEENABLE = 168,
        D3DRS_TWEENFACTOR = 170,
        D3DRS_BLENDOP = 171,
        D3DRS_POSITIONDEGREE = 172,
        D3DRS_NORMALDEGREE = 173,
        D3DRS_SCISSORTESTENABLE = 174,
        D3DRS_SLOPESCALEDEPTHBIAS = 175,
        D3DRS_ANTIALIASEDLINEENABLE = 176,
        D3DRS_MINTESSELLATIONLEVEL = 178,
        D3DRS_MAXTESSELLATIONLEVEL = 179,
        D3DRS_ADAPTIVETESS_X = 180,
        D3DRS_ADAPTIVETESS_Y = 181,
        D3DRS_ADAPTIVETESS_Z = 182,
        D3DRS_ADAPTIVETESS_W = 183,
        D3DRS_ENABLEADAPTIVETESSELLATION = 184,
        D3DRS_TWOSIDEDSTENCILMODE = 185,
        D3DRS_CCW_STENCILFAIL = 186,
        D3DRS_CCW_STENCILZFAIL = 187,
        D3DRS_CCW_STENCILPASS = 188,
        D3DRS_CCW_STENCILFUNC = 189,
        D3DRS_COLORWRITEENABLE1 = 190,
        D3DRS_COLORWRITEENABLE2 = 191,
        D3DRS_COLORWRITEENABLE3 = 192,
        D3DRS_BLENDFACTOR = 193,
        D3DRS_SRGBWRITEENABLE = 194,
        D3DRS_DEPTHBIAS = 195,
        D3DRS_WRAP8 = 198,
        D3DRS_WRAP9 = 199,
        D3DRS_WRAP10 = 200,
        D3DRS_WRAP11 = 201,
        D3DRS_WRAP12 = 202,
        D3DRS_WRAP13 = 203,
        D3DRS_WRAP14 = 204,
        D3DRS_WRAP15 = 205,
        D3DRS_SEPARATEALPHABLENDENABLE = 206,
        D3DRS_SRCBLENDALPHA = 207,
        D3DRS_DESTBLENDALPHA = 208,
        D3DRS_BLENDOPALPHA = 209,
        D3DRS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DMATERIALCOLORSOURCE : int
    {
        D3DMCS_MATERIAL = 0,
        D3DMCS_COLOR1 = 1,
        D3DMCS_COLOR2 = 2,
        D3DMCS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTEXTURESTAGESTATETYPE : int
    {
        D3DTSS_COLOROP = 1,
        D3DTSS_COLORARG1 = 2,
        D3DTSS_COLORARG2 = 3,
        D3DTSS_ALPHAOP = 4,
        D3DTSS_ALPHAARG1 = 5,
        D3DTSS_ALPHAARG2 = 6,
        D3DTSS_BUMPENVMAT00 = 7,
        D3DTSS_BUMPENVMAT01 = 8,
        D3DTSS_BUMPENVMAT10 = 9,
        D3DTSS_BUMPENVMAT11 = 10,
        D3DTSS_TEXCOORDINDEX = 11,
        D3DTSS_BUMPENVLSCALE = 22,
        D3DTSS_BUMPENVLOFFSET = 23,
        D3DTSS_TEXTURETRANSFORMFLAGS = 24,
        D3DTSS_COLORARG0 = 26,
        D3DTSS_ALPHAARG0 = 27,
        D3DTSS_RESULTARG = 28,
        D3DTSS_CONSTANT = 32,
        D3DTSS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSAMPLERSTATETYPE : int
    {
        D3DSAMP_ADDRESSU = 1,
        D3DSAMP_ADDRESSV = 2,
        D3DSAMP_ADDRESSW = 3,
        D3DSAMP_BORDERCOLOR = 4,
        D3DSAMP_MAGFILTER = 5,
        D3DSAMP_MINFILTER = 6,
        D3DSAMP_MIPFILTER = 7,
        D3DSAMP_MIPMAPLODBIAS = 8,
        D3DSAMP_MAXMIPLEVEL = 9,
        D3DSAMP_MAXANISOTROPY = 10,
        D3DSAMP_SRGBTEXTURE = 11,
        D3DSAMP_ELEMENTINDEX = 12,
        D3DSAMP_DMAPOFFSET = 13,
        D3DSAMP_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTEXTUREOP : int
    {
        D3DTOP_DISABLE = 1,
        D3DTOP_SELECTARG1 = 2,
        D3DTOP_SELECTARG2 = 3,
        D3DTOP_MODULATE = 4,
        D3DTOP_MODULATE2X = 5,
        D3DTOP_MODULATE4X = 6,
        D3DTOP_ADD = 7,
        D3DTOP_ADDSIGNED = 8,
        D3DTOP_ADDSIGNED2X = 9,
        D3DTOP_SUBTRACT = 10,
        D3DTOP_ADDSMOOTH = 11,
        D3DTOP_BLENDDIFFUSEALPHA = 12,
        D3DTOP_BLENDTEXTUREALPHA = 13,
        D3DTOP_BLENDFACTORALPHA = 14,
        D3DTOP_BLENDTEXTUREALPHAPM = 15,
        D3DTOP_BLENDCURRENTALPHA = 16,
        D3DTOP_PREMODULATE = 17,
        D3DTOP_MODULATEALPHA_ADDCOLOR = 18,
        D3DTOP_MODULATECOLOR_ADDALPHA = 19,
        D3DTOP_MODULATEINVALPHA_ADDCOLOR = 20,
        D3DTOP_MODULATEINVCOLOR_ADDALPHA = 21,
        D3DTOP_BUMPENVMAP = 22,
        D3DTOP_BUMPENVMAPLUMINANCE = 23,
        D3DTOP_DOTPRODUCT3 = 24,
        D3DTOP_MULTIPLYADD = 25,
        D3DTOP_LERP = 26,
        D3DTOP_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTEXTUREFILTERTYPE : int
    {
        D3DTEXF_NONE = 0,
        D3DTEXF_POINT = 1,
        D3DTEXF_LINEAR = 2,
        D3DTEXF_ANISOTROPIC = 3,
        D3DTEXF_PYRAMIDALQUAD = 6,
        D3DTEXF_GAUSSIANQUAD = 7,
        D3DTEXF_CONVOLUTIONMONO = 8,
        D3DTEXF_FORCE_DWORD = 2147483647,
    };

    public enum _D3DDECLUSAGE : int
    {
        D3DDECLUSAGE_POSITION = 0,
        D3DDECLUSAGE_BLENDWEIGHT,
        D3DDECLUSAGE_BLENDINDICES,
        D3DDECLUSAGE_NORMAL,
        D3DDECLUSAGE_PSIZE,
        D3DDECLUSAGE_TEXCOORD,
        D3DDECLUSAGE_TANGENT,
        D3DDECLUSAGE_BINORMAL,
        D3DDECLUSAGE_TESSFACTOR,
        D3DDECLUSAGE_POSITIONT,
        D3DDECLUSAGE_COLOR,
        D3DDECLUSAGE_FOG,
        D3DDECLUSAGE_DEPTH,
        D3DDECLUSAGE_SAMPLE,
    };

    public enum _D3DDECLMETHOD : int
    {
        D3DDECLMETHOD_DEFAULT = 0,
        D3DDECLMETHOD_PARTIALU,
        D3DDECLMETHOD_PARTIALV,
        D3DDECLMETHOD_CROSSUV,
        D3DDECLMETHOD_UV,
        D3DDECLMETHOD_LOOKUP,
        D3DDECLMETHOD_LOOKUPPRESAMPLED,
    };

    public enum _D3DDECLTYPE : int
    {
        D3DDECLTYPE_FLOAT1 = 0,
        D3DDECLTYPE_FLOAT2 = 1,
        D3DDECLTYPE_FLOAT3 = 2,
        D3DDECLTYPE_FLOAT4 = 3,
        D3DDECLTYPE_D3DCOLOR = 4,
        D3DDECLTYPE_UBYTE4 = 5,
        D3DDECLTYPE_SHORT2 = 6,
        D3DDECLTYPE_SHORT4 = 7,
        D3DDECLTYPE_UBYTE4N = 8,
        D3DDECLTYPE_SHORT2N = 9,
        D3DDECLTYPE_SHORT4N = 10,
        D3DDECLTYPE_USHORT2N = 11,
        D3DDECLTYPE_USHORT4N = 12,
        D3DDECLTYPE_UDEC3 = 13,
        D3DDECLTYPE_DEC3N = 14,
        D3DDECLTYPE_FLOAT16_2 = 15,
        D3DDECLTYPE_FLOAT16_4 = 16,
        D3DDECLTYPE_UNUSED = 17,
    };

    public enum _D3DSHADER_INSTRUCTION_OPCODE_TYPE : int
    {
        D3DSIO_NOP = 0,
        D3DSIO_MOV,
        D3DSIO_ADD,
        D3DSIO_SUB,
        D3DSIO_MAD,
        D3DSIO_MUL,
        D3DSIO_RCP,
        D3DSIO_RSQ,
        D3DSIO_DP3,
        D3DSIO_DP4,
        D3DSIO_MIN,
        D3DSIO_MAX,
        D3DSIO_SLT,
        D3DSIO_SGE,
        D3DSIO_EXP,
        D3DSIO_LOG,
        D3DSIO_LIT,
        D3DSIO_DST,
        D3DSIO_LRP,
        D3DSIO_FRC,
        D3DSIO_M4x4,
        D3DSIO_M4x3,
        D3DSIO_M3x4,
        D3DSIO_M3x3,
        D3DSIO_M3x2,
        D3DSIO_CALL,
        D3DSIO_CALLNZ,
        D3DSIO_LOOP,
        D3DSIO_RET,
        D3DSIO_ENDLOOP,
        D3DSIO_LABEL,
        D3DSIO_DCL,
        D3DSIO_POW,
        D3DSIO_CRS,
        D3DSIO_SGN,
        D3DSIO_ABS,
        D3DSIO_NRM,
        D3DSIO_SINCOS,
        D3DSIO_REP,
        D3DSIO_ENDREP,
        D3DSIO_IF,
        D3DSIO_IFC,
        D3DSIO_ELSE,
        D3DSIO_ENDIF,
        D3DSIO_BREAK,
        D3DSIO_BREAKC,
        D3DSIO_MOVA,
        D3DSIO_DEFB,
        D3DSIO_DEFI,
        D3DSIO_TEXCOORD = 64,
        D3DSIO_TEXKILL,
        D3DSIO_TEX,
        D3DSIO_TEXBEM,
        D3DSIO_TEXBEML,
        D3DSIO_TEXREG2AR,
        D3DSIO_TEXREG2GB,
        D3DSIO_TEXM3x2PAD,
        D3DSIO_TEXM3x2TEX,
        D3DSIO_TEXM3x3PAD,
        D3DSIO_TEXM3x3TEX,
        D3DSIO_RESERVED0,
        D3DSIO_TEXM3x3SPEC,
        D3DSIO_TEXM3x3VSPEC,
        D3DSIO_EXPP,
        D3DSIO_LOGP,
        D3DSIO_CND,
        D3DSIO_DEF,
        D3DSIO_TEXREG2RGB,
        D3DSIO_TEXDP3TEX,
        D3DSIO_TEXM3x2DEPTH,
        D3DSIO_TEXDP3,
        D3DSIO_TEXM3x3,
        D3DSIO_TEXDEPTH,
        D3DSIO_CMP,
        D3DSIO_BEM,
        D3DSIO_DP2ADD,
        D3DSIO_DSX,
        D3DSIO_DSY,
        D3DSIO_TEXLDD,
        D3DSIO_SETP,
        D3DSIO_TEXLDL,
        D3DSIO_BREAKP,
        D3DSIO_PHASE = 65533,
        D3DSIO_COMMENT = 65534,
        D3DSIO_END = 65535,
        D3DSIO_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_COMPARISON : int
    {
        D3DSPC_RESERVED0 = 0,
        D3DSPC_GT = 1,
        D3DSPC_EQ = 2,
        D3DSPC_GE = 3,
        D3DSPC_LT = 4,
        D3DSPC_NE = 5,
        D3DSPC_LE = 6,
        D3DSPC_RESERVED1 = 7,
    };

    public enum _D3DSAMPLER_TEXTURE_TYPE : int
    {
        D3DSTT_UNKNOWN = 0,
        D3DSTT_2D = 268435456,
        D3DSTT_CUBE = 402653184,
        D3DSTT_VOLUME = 536870912,
        D3DSTT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_PARAM_REGISTER_TYPE : int
    {
        D3DSPR_TEMP = 0,
        D3DSPR_INPUT = 1,
        D3DSPR_CONST = 2,
        D3DSPR_ADDR = 3,
        D3DSPR_TEXTURE = 3,
        D3DSPR_RASTOUT = 4,
        D3DSPR_ATTROUT = 5,
        D3DSPR_TEXCRDOUT = 6,
        D3DSPR_OUTPUT = 6,
        D3DSPR_CONSTINT = 7,
        D3DSPR_COLOROUT = 8,
        D3DSPR_DEPTHOUT = 9,
        D3DSPR_SAMPLER = 10,
        D3DSPR_CONST2 = 11,
        D3DSPR_CONST3 = 12,
        D3DSPR_CONST4 = 13,
        D3DSPR_CONSTBOOL = 14,
        D3DSPR_LOOP = 15,
        D3DSPR_TEMPFLOAT16 = 16,
        D3DSPR_MISCTYPE = 17,
        D3DSPR_LABEL = 18,
        D3DSPR_PREDICATE = 19,
        D3DSPR_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_MISCTYPE_OFFSETS : int
    {
        D3DSMO_POSITION = 0,
        D3DSMO_FACE = 1,
    };

    public enum _D3DVS_RASTOUT_OFFSETS : int
    {
        D3DSRO_POSITION = 0,
        D3DSRO_FOG,
        D3DSRO_POINT_SIZE,
        D3DSRO_FORCE_DWORD = 2147483647,
    };

    public enum _D3DVS_ADDRESSMODE_TYPE : int
    {
        D3DVS_ADDRMODE_ABSOLUTE = 0,
        D3DVS_ADDRMODE_RELATIVE = 8192,
        D3DVS_ADDRMODE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_ADDRESSMODE_TYPE : int
    {
        D3DSHADER_ADDRMODE_ABSOLUTE = 0,
        D3DSHADER_ADDRMODE_RELATIVE = 8192,
        D3DSHADER_ADDRMODE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_PARAM_SRCMOD_TYPE : int
    {
        D3DSPSM_NONE = 0,
        D3DSPSM_NEG = 16777216,
        D3DSPSM_BIAS = 33554432,
        D3DSPSM_BIASNEG = 50331648,
        D3DSPSM_SIGN = 67108864,
        D3DSPSM_SIGNNEG = 83886080,
        D3DSPSM_COMP = 100663296,
        D3DSPSM_X2 = 117440512,
        D3DSPSM_X2NEG = 134217728,
        D3DSPSM_DZ = 150994944,
        D3DSPSM_DW = 167772160,
        D3DSPSM_ABS = 184549376,
        D3DSPSM_ABSNEG = 201326592,
        D3DSPSM_NOT = 218103808,
        D3DSPSM_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSHADER_MIN_PRECISION : int
    {
        D3DMP_DEFAULT = 0,
        D3DMP_16 = 1,
        D3DMP_2_8 = 2,
    };

    public enum _D3DBASISTYPE : int
    {
        D3DBASIS_BEZIER = 0,
        D3DBASIS_BSPLINE = 1,
        D3DBASIS_CATMULL_ROM = 2,
        D3DBASIS_FORCE_DWORD = 2147483647,
    };

    public enum _D3DDEGREETYPE : int
    {
        D3DDEGREE_LINEAR = 1,
        D3DDEGREE_QUADRATIC = 2,
        D3DDEGREE_CUBIC = 3,
        D3DDEGREE_QUINTIC = 5,
        D3DDEGREE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DPATCHEDGESTYLE : int
    {
        D3DPATCHEDGE_DISCRETE = 0,
        D3DPATCHEDGE_CONTINUOUS = 1,
        D3DPATCHEDGE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSTATEBLOCKTYPE : int
    {
        D3DSBT_ALL = 1,
        D3DSBT_PIXELSTATE = 2,
        D3DSBT_VERTEXSTATE = 3,
        D3DSBT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DVERTEXBLENDFLAGS : int
    {
        D3DVBF_DISABLE = 0,
        D3DVBF_1WEIGHTS = 1,
        D3DVBF_2WEIGHTS = 2,
        D3DVBF_3WEIGHTS = 3,
        D3DVBF_TWEENING = 255,
        D3DVBF_0WEIGHTS = 256,
        D3DVBF_FORCE_DWORD = 2147483647,
    };

    public enum _D3DTEXTURETRANSFORMFLAGS : int
    {
        D3DTTFF_DISABLE = 0,
        D3DTTFF_COUNT1 = 1,
        D3DTTFF_COUNT2 = 2,
        D3DTTFF_COUNT3 = 3,
        D3DTTFF_COUNT4 = 4,
        D3DTTFF_PROJECTED = 256,
        D3DTTFF_FORCE_DWORD = 2147483647,
    };

    public enum _D3DDEVTYPE : int
    {
        D3DDEVTYPE_HAL = 1,
        D3DDEVTYPE_REF = 2,
        D3DDEVTYPE_SW = 3,
        D3DDEVTYPE_NULLREF = 4,
        D3DDEVTYPE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DMULTISAMPLE_TYPE : int
    {
        D3DMULTISAMPLE_NONE = 0,
        D3DMULTISAMPLE_NONMASKABLE = 1,
        D3DMULTISAMPLE_2_SAMPLES = 2,
        D3DMULTISAMPLE_3_SAMPLES = 3,
        D3DMULTISAMPLE_4_SAMPLES = 4,
        D3DMULTISAMPLE_5_SAMPLES = 5,
        D3DMULTISAMPLE_6_SAMPLES = 6,
        D3DMULTISAMPLE_7_SAMPLES = 7,
        D3DMULTISAMPLE_8_SAMPLES = 8,
        D3DMULTISAMPLE_9_SAMPLES = 9,
        D3DMULTISAMPLE_10_SAMPLES = 10,
        D3DMULTISAMPLE_11_SAMPLES = 11,
        D3DMULTISAMPLE_12_SAMPLES = 12,
        D3DMULTISAMPLE_13_SAMPLES = 13,
        D3DMULTISAMPLE_14_SAMPLES = 14,
        D3DMULTISAMPLE_15_SAMPLES = 15,
        D3DMULTISAMPLE_16_SAMPLES = 16,
        D3DMULTISAMPLE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DFORMAT : int
    {
        D3DFMT_UNKNOWN = 0,
        D3DFMT_R8G8B8 = 20,
        D3DFMT_A8R8G8B8 = 21,
        D3DFMT_X8R8G8B8 = 22,
        D3DFMT_R5G6B5 = 23,
        D3DFMT_X1R5G5B5 = 24,
        D3DFMT_A1R5G5B5 = 25,
        D3DFMT_A4R4G4B4 = 26,
        D3DFMT_R3G3B2 = 27,
        D3DFMT_A8 = 28,
        D3DFMT_A8R3G3B2 = 29,
        D3DFMT_X4R4G4B4 = 30,
        D3DFMT_A2B10G10R10 = 31,
        D3DFMT_A8B8G8R8 = 32,
        D3DFMT_X8B8G8R8 = 33,
        D3DFMT_G16R16 = 34,
        D3DFMT_A2R10G10B10 = 35,
        D3DFMT_A16B16G16R16 = 36,
        D3DFMT_A8P8 = 40,
        D3DFMT_P8 = 41,
        D3DFMT_L8 = 50,
        D3DFMT_A8L8 = 51,
        D3DFMT_A4L4 = 52,
        D3DFMT_V8U8 = 60,
        D3DFMT_L6V5U5 = 61,
        D3DFMT_X8L8V8U8 = 62,
        D3DFMT_Q8W8V8U8 = 63,
        D3DFMT_V16U16 = 64,
        D3DFMT_A2W10V10U10 = 67,
        D3DFMT_UYVY = 1498831189,
        D3DFMT_R8G8_B8G8 = 1195525970,
        D3DFMT_YUY2 = 844715353,
        D3DFMT_G8R8_G8B8 = 1111970375,
        D3DFMT_DXT1 = 827611204,
        D3DFMT_DXT2 = 844388420,
        D3DFMT_DXT3 = 861165636,
        D3DFMT_DXT4 = 877942852,
        D3DFMT_DXT5 = 894720068,
        D3DFMT_D16_LOCKABLE = 70,
        D3DFMT_D32 = 71,
        D3DFMT_D15S1 = 73,
        D3DFMT_D24S8 = 75,
        D3DFMT_D24X8 = 77,
        D3DFMT_D24X4S4 = 79,
        D3DFMT_D16 = 80,
        D3DFMT_D32F_LOCKABLE = 82,
        D3DFMT_D24FS8 = 83,
        D3DFMT_D32_LOCKABLE = 84,
        D3DFMT_S8_LOCKABLE = 85,
        D3DFMT_L16 = 81,
        D3DFMT_VERTEXDATA = 100,
        D3DFMT_INDEX16 = 101,
        D3DFMT_INDEX32 = 102,
        D3DFMT_Q16W16V16U16 = 110,
        D3DFMT_MULTI2_ARGB8 = 827606349,
        D3DFMT_R16F = 111,
        D3DFMT_G16R16F = 112,
        D3DFMT_A16B16G16R16F = 113,
        D3DFMT_R32F = 114,
        D3DFMT_G32R32F = 115,
        D3DFMT_A32B32G32R32F = 116,
        D3DFMT_CxV8U8 = 117,
        D3DFMT_A1 = 118,
        D3DFMT_A2B10G10R10_XR_BIAS = 119,
        D3DFMT_BINARYBUFFER = 199,
        D3DFMT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DSWAPEFFECT : int
    {
        D3DSWAPEFFECT_DISCARD = 1,
        D3DSWAPEFFECT_FLIP = 2,
        D3DSWAPEFFECT_COPY = 3,
        D3DSWAPEFFECT_OVERLAY = 4,
        D3DSWAPEFFECT_FLIPEX = 5,
        D3DSWAPEFFECT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DPOOL : int
    {
        D3DPOOL_DEFAULT = 0,
        D3DPOOL_MANAGED = 1,
        D3DPOOL_SYSTEMMEM = 2,
        D3DPOOL_SCRATCH = 3,
        D3DPOOL_FORCE_DWORD = 2147483647,
    };

    public enum _D3DBACKBUFFER_TYPE : int
    {
        D3DBACKBUFFER_TYPE_MONO = 0,
        D3DBACKBUFFER_TYPE_LEFT = 1,
        D3DBACKBUFFER_TYPE_RIGHT = 2,
        D3DBACKBUFFER_TYPE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DRESOURCETYPE : int
    {
        D3DRTYPE_SURFACE = 1,
        D3DRTYPE_VOLUME = 2,
        D3DRTYPE_TEXTURE = 3,
        D3DRTYPE_VOLUMETEXTURE = 4,
        D3DRTYPE_CUBETEXTURE = 5,
        D3DRTYPE_VERTEXBUFFER = 6,
        D3DRTYPE_INDEXBUFFER = 7,
        D3DRTYPE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DCUBEMAP_FACES : int
    {
        D3DCUBEMAP_FACE_POSITIVE_X = 0,
        D3DCUBEMAP_FACE_NEGATIVE_X = 1,
        D3DCUBEMAP_FACE_POSITIVE_Y = 2,
        D3DCUBEMAP_FACE_NEGATIVE_Y = 3,
        D3DCUBEMAP_FACE_POSITIVE_Z = 4,
        D3DCUBEMAP_FACE_NEGATIVE_Z = 5,
        D3DCUBEMAP_FACE_FORCE_DWORD = 2147483647,
    };

    public enum _D3DDEBUGMONITORTOKENS : int
    {
        D3DDMT_ENABLE = 0,
        D3DDMT_DISABLE = 1,
        D3DDMT_FORCE_DWORD = 2147483647,
    };

    public enum _D3DQUERYTYPE : int
    {
        D3DQUERYTYPE_VCACHE = 4,
        D3DQUERYTYPE_RESOURCEMANAGER = 5,
        D3DQUERYTYPE_VERTEXSTATS = 6,
        D3DQUERYTYPE_EVENT = 8,
        D3DQUERYTYPE_OCCLUSION = 9,
        D3DQUERYTYPE_TIMESTAMP = 10,
        D3DQUERYTYPE_TIMESTAMPDISJOINT = 11,
        D3DQUERYTYPE_TIMESTAMPFREQ = 12,
        D3DQUERYTYPE_PIPELINETIMINGS = 13,
        D3DQUERYTYPE_INTERFACETIMINGS = 14,
        D3DQUERYTYPE_VERTEXTIMINGS = 15,
        D3DQUERYTYPE_PIXELTIMINGS = 16,
        D3DQUERYTYPE_BANDWIDTHTIMINGS = 17,
        D3DQUERYTYPE_CACHEUTILIZATION = 18,
        D3DQUERYTYPE_MEMORYPRESSURE = 19,
    };

    public enum _D3DCOMPOSERECTSOP : int
    {
        D3DCOMPOSERECTS_COPY = 1,
        D3DCOMPOSERECTS_OR = 2,
        D3DCOMPOSERECTS_AND = 3,
        D3DCOMPOSERECTS_NEG = 4,
        D3DCOMPOSERECTS_FORCE_DWORD = 2147483647,
    };

    public enum D3DSCANLINEORDERING : int
    {
        D3DSCANLINEORDERING_UNKNOWN = 0,
        D3DSCANLINEORDERING_PROGRESSIVE = 1,
        D3DSCANLINEORDERING_INTERLACED = 2,
    };

    public enum D3DDISPLAYROTATION : int
    {
        D3DDISPLAYROTATION_IDENTITY = 1,
        D3DDISPLAYROTATION_90 = 2,
        D3DDISPLAYROTATION_180 = 3,
        D3DDISPLAYROTATION_270 = 4,
    };

    public enum _D3DAUTHENTICATEDCHANNELTYPE : int
    {
        D3DAUTHENTICATEDCHANNEL_D3D9 = 1,
        D3DAUTHENTICATEDCHANNEL_DRIVER_SOFTWARE = 2,
        D3DAUTHENTICATEDCHANNEL_DRIVER_HARDWARE = 3,
    };

    public enum _D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE : int
    {
        PROCESSIDTYPE_UNKNOWN = 0,
        PROCESSIDTYPE_DWM = 1,
        PROCESSIDTYPE_HANDLE = 2,
    };

    public enum _D3DBUSTYPE : int
    {
        D3DBUSTYPE_OTHER = 0,
        D3DBUSTYPE_PCI = 1,
        D3DBUSTYPE_PCIX = 2,
        D3DBUSTYPE_PCIEXPRESS = 3,
        D3DBUSTYPE_AGP = 4,
        D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET = 65536,
        D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 131072,
        D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 196608,
        D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 262144,
        D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 327680,
        D3DBUSIMPL_MODIFIER_NON_STANDARD = -2147483648,
    };

    public enum DXGI_MODE_SCANLINE_ORDER : int
    {
        DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED = 0,
        DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE = 1,
        DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST = 2,
        DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST = 3,
    };

    public enum DXGI_MODE_SCALING : int
    {
        DXGI_MODE_SCALING_UNSPECIFIED = 0,
        DXGI_MODE_SCALING_CENTERED = 1,
        DXGI_MODE_SCALING_STRETCHED = 2,
    };

    public enum DXGI_MODE_ROTATION : int
    {
        DXGI_MODE_ROTATION_UNSPECIFIED = 0,
        DXGI_MODE_ROTATION_IDENTITY = 1,
        DXGI_MODE_ROTATION_ROTATE90 = 2,
        DXGI_MODE_ROTATION_ROTATE180 = 3,
        DXGI_MODE_ROTATION_ROTATE270 = 4,
    };

    public enum D3D10_RESOURCE_DIMENSION : int
    {
        D3D10_RESOURCE_DIMENSION_UNKNOWN = 0,
        D3D10_RESOURCE_DIMENSION_BUFFER = 1,
        D3D10_RESOURCE_DIMENSION_TEXTURE1D = 2,
        D3D10_RESOURCE_DIMENSION_TEXTURE2D = 3,
        D3D10_RESOURCE_DIMENSION_TEXTURE3D = 4,
    };

    public enum D3D10_MAP : int
    {
        D3D10_MAP_READ = 1,
        D3D10_MAP_WRITE = 2,
        D3D10_MAP_READ_WRITE = 3,
        D3D10_MAP_WRITE_DISCARD = 4,
        D3D10_MAP_WRITE_NO_OVERWRITE = 5,
    };

    public enum D3D10_USAGE : int
    {
        D3D10_USAGE_DEFAULT = 0,
        D3D10_USAGE_IMMUTABLE = 1,
        D3D10_USAGE_DYNAMIC = 2,
        D3D10_USAGE_STAGING = 3,
    };

    public enum D3D_SRV_DIMENSION : int
    {
        D3D_SRV_DIMENSION_UNKNOWN = 0,
        D3D_SRV_DIMENSION_BUFFER = 1,
        D3D_SRV_DIMENSION_TEXTURE1D = 2,
        D3D_SRV_DIMENSION_TEXTURE1DARRAY = 3,
        D3D_SRV_DIMENSION_TEXTURE2D = 4,
        D3D_SRV_DIMENSION_TEXTURE2DARRAY = 5,
        D3D_SRV_DIMENSION_TEXTURE2DMS = 6,
        D3D_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,
        D3D_SRV_DIMENSION_TEXTURE3D = 8,
        D3D_SRV_DIMENSION_TEXTURECUBE = 9,
        D3D_SRV_DIMENSION_TEXTURECUBEARRAY = 10,
        D3D_SRV_DIMENSION_BUFFEREX = 11,
        D3D10_SRV_DIMENSION_UNKNOWN = 0,
        D3D10_SRV_DIMENSION_BUFFER = 1,
        D3D10_SRV_DIMENSION_TEXTURE1D = 2,
        D3D10_SRV_DIMENSION_TEXTURE1DARRAY = 3,
        D3D10_SRV_DIMENSION_TEXTURE2D = 4,
        D3D10_SRV_DIMENSION_TEXTURE2DARRAY = 5,
        D3D10_SRV_DIMENSION_TEXTURE2DMS = 6,
        D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,
        D3D10_SRV_DIMENSION_TEXTURE3D = 8,
        D3D10_SRV_DIMENSION_TEXTURECUBE = 9,
        D3D10_1_SRV_DIMENSION_UNKNOWN = 0,
        D3D10_1_SRV_DIMENSION_BUFFER = 1,
        D3D10_1_SRV_DIMENSION_TEXTURE1D = 2,
        D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY = 3,
        D3D10_1_SRV_DIMENSION_TEXTURE2D = 4,
        D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY = 5,
        D3D10_1_SRV_DIMENSION_TEXTURE2DMS = 6,
        D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,
        D3D10_1_SRV_DIMENSION_TEXTURE3D = 8,
        D3D10_1_SRV_DIMENSION_TEXTURECUBE = 9,
        D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY = 10,
        D3D11_SRV_DIMENSION_UNKNOWN = 0,
        D3D11_SRV_DIMENSION_BUFFER = 1,
        D3D11_SRV_DIMENSION_TEXTURE1D = 2,
        D3D11_SRV_DIMENSION_TEXTURE1DARRAY = 3,
        D3D11_SRV_DIMENSION_TEXTURE2D = 4,
        D3D11_SRV_DIMENSION_TEXTURE2DARRAY = 5,
        D3D11_SRV_DIMENSION_TEXTURE2DMS = 6,
        D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,
        D3D11_SRV_DIMENSION_TEXTURE3D = 8,
        D3D11_SRV_DIMENSION_TEXTURECUBE = 9,
        D3D11_SRV_DIMENSION_TEXTURECUBEARRAY = 10,
        D3D11_SRV_DIMENSION_BUFFEREX = 11,
    };

    public enum D3D10_FILTER : int
    {
        D3D10_FILTER_MIN_MAG_MIP_POINT = 0,
        D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR = 1,
        D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 4,
        D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR = 5,
        D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT = 16,
        D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 17,
        D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT = 20,
        D3D10_FILTER_MIN_MAG_MIP_LINEAR = 21,
        D3D10_FILTER_ANISOTROPIC = 85,
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 128,
        D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 129,
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 132,
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 133,
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 144,
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 145,
        D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 148,
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 149,
        D3D10_FILTER_COMPARISON_ANISOTROPIC = 213,
        D3D10_FILTER_TEXT_1BIT = -2147483648,
    };

    public enum D3D10_TEXTURE_ADDRESS_MODE : int
    {
        D3D10_TEXTURE_ADDRESS_WRAP = 1,
        D3D10_TEXTURE_ADDRESS_MIRROR = 2,
        D3D10_TEXTURE_ADDRESS_CLAMP = 3,
        D3D10_TEXTURE_ADDRESS_BORDER = 4,
        D3D10_TEXTURE_ADDRESS_MIRROR_ONCE = 5,
    };

    public enum D3D10_COMPARISON_FUNC : int
    {
        D3D10_COMPARISON_NEVER = 1,
        D3D10_COMPARISON_LESS = 2,
        D3D10_COMPARISON_EQUAL = 3,
        D3D10_COMPARISON_LESS_EQUAL = 4,
        D3D10_COMPARISON_GREATER = 5,
        D3D10_COMPARISON_NOT_EQUAL = 6,
        D3D10_COMPARISON_GREATER_EQUAL = 7,
        D3D10_COMPARISON_ALWAYS = 8,
    };

    public enum D3D_PRIMITIVE_TOPOLOGY : int
    {
        D3D_PRIMITIVE_TOPOLOGY_UNDEFINED = 0,
        D3D_PRIMITIVE_TOPOLOGY_POINTLIST = 1,
        D3D_PRIMITIVE_TOPOLOGY_LINELIST = 2,
        D3D_PRIMITIVE_TOPOLOGY_LINESTRIP = 3,
        D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 4,
        D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 5,
        D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 10,
        D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 11,
        D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 12,
        D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 13,
        D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST = 33,
        D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST = 34,
        D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST = 35,
        D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST = 36,
        D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST = 37,
        D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST = 38,
        D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST = 39,
        D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST = 40,
        D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST = 41,
        D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST = 42,
        D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST = 43,
        D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST = 44,
        D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST = 45,
        D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST = 46,
        D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST = 47,
        D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST = 48,
        D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST = 49,
        D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST = 50,
        D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST = 51,
        D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST = 52,
        D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST = 53,
        D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST = 54,
        D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST = 55,
        D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST = 56,
        D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST = 57,
        D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST = 58,
        D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST = 59,
        D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST = 60,
        D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST = 61,
        D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST = 62,
        D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST = 63,
        D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST = 64,
        D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED = 0,
        D3D10_PRIMITIVE_TOPOLOGY_POINTLIST = 1,
        D3D10_PRIMITIVE_TOPOLOGY_LINELIST = 2,
        D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP = 3,
        D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 4,
        D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 5,
        D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 10,
        D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 11,
        D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 12,
        D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 13,
        D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED = 0,
        D3D11_PRIMITIVE_TOPOLOGY_POINTLIST = 1,
        D3D11_PRIMITIVE_TOPOLOGY_LINELIST = 2,
        D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP = 3,
        D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 4,
        D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 5,
        D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 10,
        D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 11,
        D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 12,
        D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 13,
        D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST = 33,
        D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST = 34,
        D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST = 35,
        D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST = 36,
        D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST = 37,
        D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST = 38,
        D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST = 39,
        D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST = 40,
        D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST = 41,
        D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST = 42,
        D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST = 43,
        D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST = 44,
        D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST = 45,
        D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST = 46,
        D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST = 47,
        D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST = 48,
        D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST = 49,
        D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST = 50,
        D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST = 51,
        D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST = 52,
        D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST = 53,
        D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST = 54,
        D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST = 55,
        D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST = 56,
        D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST = 57,
        D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST = 58,
        D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST = 59,
        D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST = 60,
        D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST = 61,
        D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST = 62,
        D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST = 63,
        D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST = 64,
    };

    public enum D3D10_QUERY : int
    {
        D3D10_QUERY_EVENT = 0,
        D3D10_QUERY_OCCLUSION = 1,
        D3D10_QUERY_TIMESTAMP = 2,
        D3D10_QUERY_TIMESTAMP_DISJOINT = 3,
        D3D10_QUERY_PIPELINE_STATISTICS = 4,
        D3D10_QUERY_OCCLUSION_PREDICATE = 5,
        D3D10_QUERY_SO_STATISTICS = 6,
        D3D10_QUERY_SO_OVERFLOW_PREDICATE = 7,
    };

    public enum D3D10_RTV_DIMENSION : int
    {
        D3D10_RTV_DIMENSION_UNKNOWN = 0,
        D3D10_RTV_DIMENSION_BUFFER = 1,
        D3D10_RTV_DIMENSION_TEXTURE1D = 2,
        D3D10_RTV_DIMENSION_TEXTURE1DARRAY = 3,
        D3D10_RTV_DIMENSION_TEXTURE2D = 4,
        D3D10_RTV_DIMENSION_TEXTURE2DARRAY = 5,
        D3D10_RTV_DIMENSION_TEXTURE2DMS = 6,
        D3D10_RTV_DIMENSION_TEXTURE2DMSARRAY = 7,
        D3D10_RTV_DIMENSION_TEXTURE3D = 8,
    };

    public enum D3D10_DSV_DIMENSION : int
    {
        D3D10_DSV_DIMENSION_UNKNOWN = 0,
        D3D10_DSV_DIMENSION_TEXTURE1D = 1,
        D3D10_DSV_DIMENSION_TEXTURE1DARRAY = 2,
        D3D10_DSV_DIMENSION_TEXTURE2D = 3,
        D3D10_DSV_DIMENSION_TEXTURE2DARRAY = 4,
        D3D10_DSV_DIMENSION_TEXTURE2DMS = 5,
        D3D10_DSV_DIMENSION_TEXTURE2DMSARRAY = 6,
    };

    public enum D3D10_DEPTH_WRITE_MASK : int
    {
        D3D10_DEPTH_WRITE_MASK_ZERO = 0,
        D3D10_DEPTH_WRITE_MASK_ALL = 1,
    };

    public enum D3D10_STENCIL_OP : int
    {
        D3D10_STENCIL_OP_KEEP = 1,
        D3D10_STENCIL_OP_ZERO = 2,
        D3D10_STENCIL_OP_REPLACE = 3,
        D3D10_STENCIL_OP_INCR_SAT = 4,
        D3D10_STENCIL_OP_DECR_SAT = 5,
        D3D10_STENCIL_OP_INVERT = 6,
        D3D10_STENCIL_OP_INCR = 7,
        D3D10_STENCIL_OP_DECR = 8,
    };

    public enum D3D10_FILL_MODE : int
    {
        D3D10_FILL_WIREFRAME = 2,
        D3D10_FILL_SOLID = 3,
    };

    public enum D3D10_CULL_MODE : int
    {
        D3D10_CULL_NONE = 1,
        D3D10_CULL_FRONT = 2,
        D3D10_CULL_BACK = 3,
    };

    public enum D3D10_INPUT_CLASSIFICATION : int
    {
        D3D10_INPUT_PER_VERTEX_DATA = 0,
        D3D10_INPUT_PER_INSTANCE_DATA = 1,
    };

    public enum D3D10_BLEND : int
    {
        D3D10_BLEND_ZERO = 1,
        D3D10_BLEND_ONE = 2,
        D3D10_BLEND_SRC_COLOR = 3,
        D3D10_BLEND_INV_SRC_COLOR = 4,
        D3D10_BLEND_SRC_ALPHA = 5,
        D3D10_BLEND_INV_SRC_ALPHA = 6,
        D3D10_BLEND_DEST_ALPHA = 7,
        D3D10_BLEND_INV_DEST_ALPHA = 8,
        D3D10_BLEND_DEST_COLOR = 9,
        D3D10_BLEND_INV_DEST_COLOR = 10,
        D3D10_BLEND_SRC_ALPHA_SAT = 11,
        D3D10_BLEND_BLEND_FACTOR = 14,
        D3D10_BLEND_INV_BLEND_FACTOR = 15,
        D3D10_BLEND_SRC1_COLOR = 16,
        D3D10_BLEND_INV_SRC1_COLOR = 17,
        D3D10_BLEND_SRC1_ALPHA = 18,
        D3D10_BLEND_INV_SRC1_ALPHA = 19,
    };

    public enum D3D10_BLEND_OP : int
    {
        D3D10_BLEND_OP_ADD = 1,
        D3D10_BLEND_OP_SUBTRACT = 2,
        D3D10_BLEND_OP_REV_SUBTRACT = 3,
        D3D10_BLEND_OP_MIN = 4,
        D3D10_BLEND_OP_MAX = 5,
    };

    public enum D3D10_COUNTER : int
    {
        D3D10_COUNTER_GPU_IDLE = 0,
        D3D10_COUNTER_VERTEX_PROCESSING = 1,
        D3D10_COUNTER_GEOMETRY_PROCESSING = 2,
        D3D10_COUNTER_PIXEL_PROCESSING = 3,
        D3D10_COUNTER_OTHER_GPU_PROCESSING = 4,
        D3D10_COUNTER_HOST_ADAPTER_BANDWIDTH_UTILIZATION = 5,
        D3D10_COUNTER_LOCAL_VIDMEM_BANDWIDTH_UTILIZATION = 6,
        D3D10_COUNTER_VERTEX_THROUGHPUT_UTILIZATION = 7,
        D3D10_COUNTER_TRIANGLE_SETUP_THROUGHPUT_UTILIZATION = 8,
        D3D10_COUNTER_FILLRATE_THROUGHPUT_UTILIZATION = 9,
        D3D10_COUNTER_VS_MEMORY_LIMITED = 10,
        D3D10_COUNTER_VS_COMPUTATION_LIMITED = 11,
        D3D10_COUNTER_GS_MEMORY_LIMITED = 12,
        D3D10_COUNTER_GS_COMPUTATION_LIMITED = 13,
        D3D10_COUNTER_PS_MEMORY_LIMITED = 14,
        D3D10_COUNTER_PS_COMPUTATION_LIMITED = 15,
        D3D10_COUNTER_POST_TRANSFORM_CACHE_HIT_RATE = 16,
        D3D10_COUNTER_TEXTURE_CACHE_HIT_RATE = 17,
        D3D10_COUNTER_DEVICE_DEPENDENT_0 = 1073741824,
    };

    public enum D3D10_COUNTER_TYPE : int
    {
        D3D10_COUNTER_TYPE_FLOAT32 = 0,
        D3D10_COUNTER_TYPE_UINT16 = 1,
        D3D10_COUNTER_TYPE_UINT32 = 2,
        D3D10_COUNTER_TYPE_UINT64 = 3,
    };

    public enum D3D10_FEATURE_LEVEL1 : int
    {
        D3D10_FEATURE_LEVEL_10_0 = 40960,
        D3D10_FEATURE_LEVEL_10_1 = 41216,
        D3D10_FEATURE_LEVEL_9_1 = 37120,
        D3D10_FEATURE_LEVEL_9_2 = 37376,
        D3D10_FEATURE_LEVEL_9_3 = 37632,
    };

    public enum DXGI_SWAP_EFFECT : int
    {
        DXGI_SWAP_EFFECT_DISCARD = 0,
        DXGI_SWAP_EFFECT_SEQUENTIAL = 1,
        DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL = 3,
    };

    public enum DXGI_RESIDENCY : int
    {
        DXGI_RESIDENCY_FULLY_RESIDENT = 1,
        DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY = 2,
        DXGI_RESIDENCY_EVICTED_TO_DISK = 3,
    };

    public enum DXGI_SWAP_CHAIN_FLAG : int
    {
        DXGI_SWAP_CHAIN_FLAG_NONPREROTATED = 1,
        DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH = 2,
        DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE = 4,
        DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT = 8,
        DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 16,
        DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY = 32,
        DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT = 64,
        DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER = 128,
        DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO = 256,
        DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO = 512,
    };

    public enum DXGI_ADAPTER_FLAG : int
    {
        DXGI_ADAPTER_FLAG_NONE = 0,
        DXGI_ADAPTER_FLAG_REMOTE = 1,
        DXGI_ADAPTER_FLAG_SOFTWARE = 2,
        DXGI_ADAPTER_FLAG_FORCE_DWORD = -1,
    };

    public enum D3D_DRIVER_TYPE : int
    {
        D3D_DRIVER_TYPE_UNKNOWN = 0,
        D3D_DRIVER_TYPE_HARDWARE = 1,
        D3D_DRIVER_TYPE_REFERENCE = 2,
        D3D_DRIVER_TYPE_NULL = 3,
        D3D_DRIVER_TYPE_SOFTWARE = 4,
        D3D_DRIVER_TYPE_WARP = 5,
    };

    public enum D3D_FEATURE_LEVEL : int
    {
        D3D_FEATURE_LEVEL_9_1 = 37120,
        D3D_FEATURE_LEVEL_9_2 = 37376,
        D3D_FEATURE_LEVEL_9_3 = 37632,
        D3D_FEATURE_LEVEL_10_0 = 40960,
        D3D_FEATURE_LEVEL_10_1 = 41216,
        D3D_FEATURE_LEVEL_11_0 = 45056,
        D3D_FEATURE_LEVEL_11_1 = 45312,
    };

    public enum D3D_PRIMITIVE : int
    {
        D3D_PRIMITIVE_UNDEFINED = 0,
        D3D_PRIMITIVE_POINT = 1,
        D3D_PRIMITIVE_LINE = 2,
        D3D_PRIMITIVE_TRIANGLE = 3,
        D3D_PRIMITIVE_LINE_ADJ = 6,
        D3D_PRIMITIVE_TRIANGLE_ADJ = 7,
        D3D_PRIMITIVE_1_CONTROL_POINT_PATCH = 8,
        D3D_PRIMITIVE_2_CONTROL_POINT_PATCH = 9,
        D3D_PRIMITIVE_3_CONTROL_POINT_PATCH = 10,
        D3D_PRIMITIVE_4_CONTROL_POINT_PATCH = 11,
        D3D_PRIMITIVE_5_CONTROL_POINT_PATCH = 12,
        D3D_PRIMITIVE_6_CONTROL_POINT_PATCH = 13,
        D3D_PRIMITIVE_7_CONTROL_POINT_PATCH = 14,
        D3D_PRIMITIVE_8_CONTROL_POINT_PATCH = 15,
        D3D_PRIMITIVE_9_CONTROL_POINT_PATCH = 16,
        D3D_PRIMITIVE_10_CONTROL_POINT_PATCH = 17,
        D3D_PRIMITIVE_11_CONTROL_POINT_PATCH = 18,
        D3D_PRIMITIVE_12_CONTROL_POINT_PATCH = 19,
        D3D_PRIMITIVE_13_CONTROL_POINT_PATCH = 20,
        D3D_PRIMITIVE_14_CONTROL_POINT_PATCH = 21,
        D3D_PRIMITIVE_15_CONTROL_POINT_PATCH = 22,
        D3D_PRIMITIVE_16_CONTROL_POINT_PATCH = 23,
        D3D_PRIMITIVE_17_CONTROL_POINT_PATCH = 24,
        D3D_PRIMITIVE_18_CONTROL_POINT_PATCH = 25,
        D3D_PRIMITIVE_19_CONTROL_POINT_PATCH = 26,
        D3D_PRIMITIVE_20_CONTROL_POINT_PATCH = 28,
        D3D_PRIMITIVE_21_CONTROL_POINT_PATCH = 29,
        D3D_PRIMITIVE_22_CONTROL_POINT_PATCH = 30,
        D3D_PRIMITIVE_23_CONTROL_POINT_PATCH = 31,
        D3D_PRIMITIVE_24_CONTROL_POINT_PATCH = 32,
        D3D_PRIMITIVE_25_CONTROL_POINT_PATCH = 33,
        D3D_PRIMITIVE_26_CONTROL_POINT_PATCH = 34,
        D3D_PRIMITIVE_27_CONTROL_POINT_PATCH = 35,
        D3D_PRIMITIVE_28_CONTROL_POINT_PATCH = 36,
        D3D_PRIMITIVE_29_CONTROL_POINT_PATCH = 37,
        D3D_PRIMITIVE_30_CONTROL_POINT_PATCH = 38,
        D3D_PRIMITIVE_31_CONTROL_POINT_PATCH = 39,
        D3D_PRIMITIVE_32_CONTROL_POINT_PATCH = 40,
        D3D10_PRIMITIVE_UNDEFINED = 0,
        D3D10_PRIMITIVE_POINT = 1,
        D3D10_PRIMITIVE_LINE = 2,
        D3D10_PRIMITIVE_TRIANGLE = 3,
        D3D10_PRIMITIVE_LINE_ADJ = 6,
        D3D10_PRIMITIVE_TRIANGLE_ADJ = 7,
        D3D11_PRIMITIVE_UNDEFINED = 0,
        D3D11_PRIMITIVE_POINT = 1,
        D3D11_PRIMITIVE_LINE = 2,
        D3D11_PRIMITIVE_TRIANGLE = 3,
        D3D11_PRIMITIVE_LINE_ADJ = 6,
        D3D11_PRIMITIVE_TRIANGLE_ADJ = 7,
        D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH = 8,
        D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH = 9,
        D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH = 10,
        D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH = 11,
        D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH = 12,
        D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH = 13,
        D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH = 14,
        D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH = 15,
        D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH = 16,
        D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH = 17,
        D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH = 18,
        D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH = 19,
        D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH = 20,
        D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH = 21,
        D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH = 22,
        D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH = 23,
        D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH = 24,
        D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH = 25,
        D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH = 26,
        D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH = 28,
        D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH = 29,
        D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH = 30,
        D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH = 31,
        D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH = 32,
        D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH = 33,
        D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH = 34,
        D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH = 35,
        D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH = 36,
        D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH = 37,
        D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH = 38,
        D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH = 39,
        D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH = 40,
    };

    public enum _D3D_INCLUDE_TYPE : int
    {
        D3D_INCLUDE_LOCAL = 0,
        D3D_INCLUDE_SYSTEM = 1,
        D3D10_INCLUDE_LOCAL = 0,
        D3D10_INCLUDE_SYSTEM = 1,
        D3D_INCLUDE_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_SHADER_VARIABLE_CLASS : int
    {
        D3D_SVC_SCALAR = 0,
        D3D_SVC_VECTOR = 1,
        D3D_SVC_MATRIX_ROWS = 2,
        D3D_SVC_MATRIX_COLUMNS = 3,
        D3D_SVC_OBJECT = 4,
        D3D_SVC_STRUCT = 5,
        D3D_SVC_INTERFACE_CLASS = 6,
        D3D_SVC_INTERFACE_POINTER = 7,
        D3D10_SVC_SCALAR = 0,
        D3D10_SVC_VECTOR = 1,
        D3D10_SVC_MATRIX_ROWS = 2,
        D3D10_SVC_MATRIX_COLUMNS = 3,
        D3D10_SVC_OBJECT = 4,
        D3D10_SVC_STRUCT = 5,
        D3D11_SVC_INTERFACE_CLASS = 6,
        D3D11_SVC_INTERFACE_POINTER = 7,
        D3D_SVC_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_SHADER_VARIABLE_FLAGS : int
    {
        D3D_SVF_USERPACKED = 1,
        D3D_SVF_USED = 2,
        D3D_SVF_INTERFACE_POINTER = 4,
        D3D_SVF_INTERFACE_PARAMETER = 8,
        D3D10_SVF_USERPACKED = 1,
        D3D10_SVF_USED = 2,
        D3D11_SVF_INTERFACE_POINTER = 4,
        D3D11_SVF_INTERFACE_PARAMETER = 8,
        D3D_SVF_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_SHADER_VARIABLE_TYPE : int
    {
        D3D_SVT_VOID = 0,
        D3D_SVT_BOOL = 1,
        D3D_SVT_INT = 2,
        D3D_SVT_FLOAT = 3,
        D3D_SVT_STRING = 4,
        D3D_SVT_TEXTURE = 5,
        D3D_SVT_TEXTURE1D = 6,
        D3D_SVT_TEXTURE2D = 7,
        D3D_SVT_TEXTURE3D = 8,
        D3D_SVT_TEXTURECUBE = 9,
        D3D_SVT_SAMPLER = 10,
        D3D_SVT_SAMPLER1D = 11,
        D3D_SVT_SAMPLER2D = 12,
        D3D_SVT_SAMPLER3D = 13,
        D3D_SVT_SAMPLERCUBE = 14,
        D3D_SVT_PIXELSHADER = 15,
        D3D_SVT_VERTEXSHADER = 16,
        D3D_SVT_PIXELFRAGMENT = 17,
        D3D_SVT_VERTEXFRAGMENT = 18,
        D3D_SVT_UINT = 19,
        D3D_SVT_UINT8 = 20,
        D3D_SVT_GEOMETRYSHADER = 21,
        D3D_SVT_RASTERIZER = 22,
        D3D_SVT_DEPTHSTENCIL = 23,
        D3D_SVT_BLEND = 24,
        D3D_SVT_BUFFER = 25,
        D3D_SVT_CBUFFER = 26,
        D3D_SVT_TBUFFER = 27,
        D3D_SVT_TEXTURE1DARRAY = 28,
        D3D_SVT_TEXTURE2DARRAY = 29,
        D3D_SVT_RENDERTARGETVIEW = 30,
        D3D_SVT_DEPTHSTENCILVIEW = 31,
        D3D_SVT_TEXTURE2DMS = 32,
        D3D_SVT_TEXTURE2DMSARRAY = 33,
        D3D_SVT_TEXTURECUBEARRAY = 34,
        D3D_SVT_HULLSHADER = 35,
        D3D_SVT_DOMAINSHADER = 36,
        D3D_SVT_INTERFACE_POINTER = 37,
        D3D_SVT_COMPUTESHADER = 38,
        D3D_SVT_DOUBLE = 39,
        D3D_SVT_RWTEXTURE1D = 40,
        D3D_SVT_RWTEXTURE1DARRAY = 41,
        D3D_SVT_RWTEXTURE2D = 42,
        D3D_SVT_RWTEXTURE2DARRAY = 43,
        D3D_SVT_RWTEXTURE3D = 44,
        D3D_SVT_RWBUFFER = 45,
        D3D_SVT_BYTEADDRESS_BUFFER = 46,
        D3D_SVT_RWBYTEADDRESS_BUFFER = 47,
        D3D_SVT_STRUCTURED_BUFFER = 48,
        D3D_SVT_RWSTRUCTURED_BUFFER = 49,
        D3D_SVT_APPEND_STRUCTURED_BUFFER = 50,
        D3D_SVT_CONSUME_STRUCTURED_BUFFER = 51,
        D3D_SVT_MIN8FLOAT = 52,
        D3D_SVT_MIN10FLOAT = 53,
        D3D_SVT_MIN16FLOAT = 54,
        D3D_SVT_MIN12INT = 55,
        D3D_SVT_MIN16INT = 56,
        D3D_SVT_MIN16UINT = 57,
        D3D10_SVT_VOID = 0,
        D3D10_SVT_BOOL = 1,
        D3D10_SVT_INT = 2,
        D3D10_SVT_FLOAT = 3,
        D3D10_SVT_STRING = 4,
        D3D10_SVT_TEXTURE = 5,
        D3D10_SVT_TEXTURE1D = 6,
        D3D10_SVT_TEXTURE2D = 7,
        D3D10_SVT_TEXTURE3D = 8,
        D3D10_SVT_TEXTURECUBE = 9,
        D3D10_SVT_SAMPLER = 10,
        D3D10_SVT_SAMPLER1D = 11,
        D3D10_SVT_SAMPLER2D = 12,
        D3D10_SVT_SAMPLER3D = 13,
        D3D10_SVT_SAMPLERCUBE = 14,
        D3D10_SVT_PIXELSHADER = 15,
        D3D10_SVT_VERTEXSHADER = 16,
        D3D10_SVT_PIXELFRAGMENT = 17,
        D3D10_SVT_VERTEXFRAGMENT = 18,
        D3D10_SVT_UINT = 19,
        D3D10_SVT_UINT8 = 20,
        D3D10_SVT_GEOMETRYSHADER = 21,
        D3D10_SVT_RASTERIZER = 22,
        D3D10_SVT_DEPTHSTENCIL = 23,
        D3D10_SVT_BLEND = 24,
        D3D10_SVT_BUFFER = 25,
        D3D10_SVT_CBUFFER = 26,
        D3D10_SVT_TBUFFER = 27,
        D3D10_SVT_TEXTURE1DARRAY = 28,
        D3D10_SVT_TEXTURE2DARRAY = 29,
        D3D10_SVT_RENDERTARGETVIEW = 30,
        D3D10_SVT_DEPTHSTENCILVIEW = 31,
        D3D10_SVT_TEXTURE2DMS = 32,
        D3D10_SVT_TEXTURE2DMSARRAY = 33,
        D3D10_SVT_TEXTURECUBEARRAY = 34,
        D3D11_SVT_HULLSHADER = 35,
        D3D11_SVT_DOMAINSHADER = 36,
        D3D11_SVT_INTERFACE_POINTER = 37,
        D3D11_SVT_COMPUTESHADER = 38,
        D3D11_SVT_DOUBLE = 39,
        D3D11_SVT_RWTEXTURE1D = 40,
        D3D11_SVT_RWTEXTURE1DARRAY = 41,
        D3D11_SVT_RWTEXTURE2D = 42,
        D3D11_SVT_RWTEXTURE2DARRAY = 43,
        D3D11_SVT_RWTEXTURE3D = 44,
        D3D11_SVT_RWBUFFER = 45,
        D3D11_SVT_BYTEADDRESS_BUFFER = 46,
        D3D11_SVT_RWBYTEADDRESS_BUFFER = 47,
        D3D11_SVT_STRUCTURED_BUFFER = 48,
        D3D11_SVT_RWSTRUCTURED_BUFFER = 49,
        D3D11_SVT_APPEND_STRUCTURED_BUFFER = 50,
        D3D11_SVT_CONSUME_STRUCTURED_BUFFER = 51,
        D3D_SVT_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_SHADER_INPUT_FLAGS : int
    {
        D3D_SIF_USERPACKED = 1,
        D3D_SIF_COMPARISON_SAMPLER = 2,
        D3D_SIF_TEXTURE_COMPONENT_0 = 4,
        D3D_SIF_TEXTURE_COMPONENT_1 = 8,
        D3D_SIF_TEXTURE_COMPONENTS = 12,
        D3D_SIF_UNUSED = 16,
        D3D10_SIF_USERPACKED = 1,
        D3D10_SIF_COMPARISON_SAMPLER = 2,
        D3D10_SIF_TEXTURE_COMPONENT_0 = 4,
        D3D10_SIF_TEXTURE_COMPONENT_1 = 8,
        D3D10_SIF_TEXTURE_COMPONENTS = 12,
        D3D_SIF_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_SHADER_INPUT_TYPE : int
    {
        D3D_SIT_CBUFFER = 0,
        D3D_SIT_TBUFFER = 1,
        D3D_SIT_TEXTURE = 2,
        D3D_SIT_SAMPLER = 3,
        D3D_SIT_UAV_RWTYPED = 4,
        D3D_SIT_STRUCTURED = 5,
        D3D_SIT_UAV_RWSTRUCTURED = 6,
        D3D_SIT_BYTEADDRESS = 7,
        D3D_SIT_UAV_RWBYTEADDRESS = 8,
        D3D_SIT_UAV_APPEND_STRUCTURED = 9,
        D3D_SIT_UAV_CONSUME_STRUCTURED = 10,
        D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = 11,
        D3D10_SIT_CBUFFER = 0,
        D3D10_SIT_TBUFFER = 1,
        D3D10_SIT_TEXTURE = 2,
        D3D10_SIT_SAMPLER = 3,
        D3D11_SIT_UAV_RWTYPED = 4,
        D3D11_SIT_STRUCTURED = 5,
        D3D11_SIT_UAV_RWSTRUCTURED = 6,
        D3D11_SIT_BYTEADDRESS = 7,
        D3D11_SIT_UAV_RWBYTEADDRESS = 8,
        D3D11_SIT_UAV_APPEND_STRUCTURED = 9,
        D3D11_SIT_UAV_CONSUME_STRUCTURED = 10,
        D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = 11,
    };

    public enum _D3D_SHADER_CBUFFER_FLAGS : int
    {
        D3D_CBF_USERPACKED = 1,
        D3D10_CBF_USERPACKED = 1,
        D3D_CBF_FORCE_DWORD = 2147483647,
    };

    public enum _D3D_CBUFFER_TYPE : int
    {
        D3D_CT_CBUFFER = 0,
        D3D_CT_TBUFFER = 1,
        D3D_CT_INTERFACE_POINTERS = 2,
        D3D_CT_RESOURCE_BIND_INFO = 3,
        D3D10_CT_CBUFFER = 0,
        D3D10_CT_TBUFFER = 1,
        D3D11_CT_CBUFFER = 0,
        D3D11_CT_TBUFFER = 1,
        D3D11_CT_INTERFACE_POINTERS = 2,
        D3D11_CT_RESOURCE_BIND_INFO = 3,
    };

    public enum D3D_NAME : int
    {
        D3D_NAME_UNDEFINED = 0,
        D3D_NAME_POSITION = 1,
        D3D_NAME_CLIP_DISTANCE = 2,
        D3D_NAME_CULL_DISTANCE = 3,
        D3D_NAME_RENDER_TARGET_ARRAY_INDEX = 4,
        D3D_NAME_VIEWPORT_ARRAY_INDEX = 5,
        D3D_NAME_VERTEX_ID = 6,
        D3D_NAME_PRIMITIVE_ID = 7,
        D3D_NAME_INSTANCE_ID = 8,
        D3D_NAME_IS_FRONT_FACE = 9,
        D3D_NAME_SAMPLE_INDEX = 10,
        D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR = 11,
        D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = 12,
        D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR = 13,
        D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 14,
        D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 15,
        D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 16,
        D3D_NAME_TARGET = 64,
        D3D_NAME_DEPTH = 65,
        D3D_NAME_COVERAGE = 66,
        D3D_NAME_DEPTH_GREATER_EQUAL = 67,
        D3D_NAME_DEPTH_LESS_EQUAL = 68,
        D3D10_NAME_UNDEFINED = 0,
        D3D10_NAME_POSITION = 1,
        D3D10_NAME_CLIP_DISTANCE = 2,
        D3D10_NAME_CULL_DISTANCE = 3,
        D3D10_NAME_RENDER_TARGET_ARRAY_INDEX = 4,
        D3D10_NAME_VIEWPORT_ARRAY_INDEX = 5,
        D3D10_NAME_VERTEX_ID = 6,
        D3D10_NAME_PRIMITIVE_ID = 7,
        D3D10_NAME_INSTANCE_ID = 8,
        D3D10_NAME_IS_FRONT_FACE = 9,
        D3D10_NAME_SAMPLE_INDEX = 10,
        D3D10_NAME_TARGET = 64,
        D3D10_NAME_DEPTH = 65,
        D3D10_NAME_COVERAGE = 66,
        D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR = 11,
        D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = 12,
        D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR = 13,
        D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 14,
        D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 15,
        D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 16,
        D3D11_NAME_DEPTH_GREATER_EQUAL = 67,
        D3D11_NAME_DEPTH_LESS_EQUAL = 68,
    };

    public enum D3D_RESOURCE_RETURN_TYPE : int
    {
        D3D_RETURN_TYPE_UNORM = 1,
        D3D_RETURN_TYPE_SNORM = 2,
        D3D_RETURN_TYPE_SINT = 3,
        D3D_RETURN_TYPE_UINT = 4,
        D3D_RETURN_TYPE_FLOAT = 5,
        D3D_RETURN_TYPE_MIXED = 6,
        D3D_RETURN_TYPE_DOUBLE = 7,
        D3D_RETURN_TYPE_CONTINUED = 8,
        D3D10_RETURN_TYPE_UNORM = 1,
        D3D10_RETURN_TYPE_SNORM = 2,
        D3D10_RETURN_TYPE_SINT = 3,
        D3D10_RETURN_TYPE_UINT = 4,
        D3D10_RETURN_TYPE_FLOAT = 5,
        D3D10_RETURN_TYPE_MIXED = 6,
        D3D11_RETURN_TYPE_UNORM = 1,
        D3D11_RETURN_TYPE_SNORM = 2,
        D3D11_RETURN_TYPE_SINT = 3,
        D3D11_RETURN_TYPE_UINT = 4,
        D3D11_RETURN_TYPE_FLOAT = 5,
        D3D11_RETURN_TYPE_MIXED = 6,
        D3D11_RETURN_TYPE_DOUBLE = 7,
        D3D11_RETURN_TYPE_CONTINUED = 8,
    };

    public enum D3D_REGISTER_COMPONENT_TYPE : int
    {
        D3D_REGISTER_COMPONENT_UNKNOWN = 0,
        D3D_REGISTER_COMPONENT_UINT32 = 1,
        D3D_REGISTER_COMPONENT_SINT32 = 2,
        D3D_REGISTER_COMPONENT_FLOAT32 = 3,
        D3D10_REGISTER_COMPONENT_UNKNOWN = 0,
        D3D10_REGISTER_COMPONENT_UINT32 = 1,
        D3D10_REGISTER_COMPONENT_SINT32 = 2,
        D3D10_REGISTER_COMPONENT_FLOAT32 = 3,
    };

    public enum D3D_TESSELLATOR_DOMAIN : int
    {
        D3D_TESSELLATOR_DOMAIN_UNDEFINED = 0,
        D3D_TESSELLATOR_DOMAIN_ISOLINE = 1,
        D3D_TESSELLATOR_DOMAIN_TRI = 2,
        D3D_TESSELLATOR_DOMAIN_QUAD = 3,
        D3D11_TESSELLATOR_DOMAIN_UNDEFINED = 0,
        D3D11_TESSELLATOR_DOMAIN_ISOLINE = 1,
        D3D11_TESSELLATOR_DOMAIN_TRI = 2,
        D3D11_TESSELLATOR_DOMAIN_QUAD = 3,
    };

    public enum D3D_TESSELLATOR_PARTITIONING : int
    {
        D3D_TESSELLATOR_PARTITIONING_UNDEFINED = 0,
        D3D_TESSELLATOR_PARTITIONING_INTEGER = 1,
        D3D_TESSELLATOR_PARTITIONING_POW2 = 2,
        D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD = 3,
        D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN = 4,
        D3D11_TESSELLATOR_PARTITIONING_UNDEFINED = 0,
        D3D11_TESSELLATOR_PARTITIONING_INTEGER = 1,
        D3D11_TESSELLATOR_PARTITIONING_POW2 = 2,
        D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD = 3,
        D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN = 4,
    };

    public enum D3D_TESSELLATOR_OUTPUT_PRIMITIVE : int
    {
        D3D_TESSELLATOR_OUTPUT_UNDEFINED = 0,
        D3D_TESSELLATOR_OUTPUT_POINT = 1,
        D3D_TESSELLATOR_OUTPUT_LINE = 2,
        D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW = 3,
        D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 4,
        D3D11_TESSELLATOR_OUTPUT_UNDEFINED = 0,
        D3D11_TESSELLATOR_OUTPUT_POINT = 1,
        D3D11_TESSELLATOR_OUTPUT_LINE = 2,
        D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW = 3,
        D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 4,
    };

    public enum D3D_MIN_PRECISION : int
    {
        D3D_MIN_PRECISION_DEFAULT = 0,
        D3D_MIN_PRECISION_FLOAT_16 = 1,
        D3D_MIN_PRECISION_FLOAT_2_8 = 2,
        D3D_MIN_PRECISION_RESERVED = 3,
        D3D_MIN_PRECISION_SINT_16 = 4,
        D3D_MIN_PRECISION_UINT_16 = 5,
        D3D_MIN_PRECISION_ANY_16 = 240,
        D3D_MIN_PRECISION_ANY_10 = 241,
    };

    public enum D3D_INTERPOLATION_MODE : int
    {
        D3D_INTERPOLATION_UNDEFINED = 0,
        D3D_INTERPOLATION_CONSTANT = 1,
        D3D_INTERPOLATION_LINEAR = 2,
        D3D_INTERPOLATION_LINEAR_CENTROID = 3,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE = 4,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID = 5,
        D3D_INTERPOLATION_LINEAR_SAMPLE = 6,
        D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE = 7,
    };

    public enum D3D10_BIND_FLAG : int
    {
        D3D10_BIND_VERTEX_BUFFER = 1,
        D3D10_BIND_INDEX_BUFFER = 2,
        D3D10_BIND_CONSTANT_BUFFER = 4,
        D3D10_BIND_SHADER_RESOURCE = 8,
        D3D10_BIND_STREAM_OUTPUT = 16,
        D3D10_BIND_RENDER_TARGET = 32,
        D3D10_BIND_DEPTH_STENCIL = 64,
    };

    public enum D3D10_CPU_ACCESS_FLAG : int
    {
        D3D10_CPU_ACCESS_WRITE = 65536,
        D3D10_CPU_ACCESS_READ = 131072,
    };

    public enum D3D10_RESOURCE_MISC_FLAG : int
    {
        D3D10_RESOURCE_MISC_GENERATE_MIPS = 1,
        D3D10_RESOURCE_MISC_SHARED = 2,
        D3D10_RESOURCE_MISC_TEXTURECUBE = 4,
        D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 16,
        D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 32,
    };

    public enum D3D10_MAP_FLAG : int
    {
        D3D10_MAP_FLAG_DO_NOT_WAIT = 1048576,
    };

    public enum D3D10_RAISE_FLAG : int
    {
        D3D10_RAISE_FLAG_DRIVER_INTERNAL_ERROR = 1,
    };

    public enum D3D10_CLEAR_FLAG : int
    {
        D3D10_CLEAR_DEPTH = 1,
        D3D10_CLEAR_STENCIL = 2,
    };

    public enum D3D10_COLOR_WRITE_ENABLE : int
    {
        D3D10_COLOR_WRITE_ENABLE_RED = 1,
        D3D10_COLOR_WRITE_ENABLE_GREEN = 2,
        D3D10_COLOR_WRITE_ENABLE_BLUE = 4,
        D3D10_COLOR_WRITE_ENABLE_ALPHA = 8,
        D3D10_COLOR_WRITE_ENABLE_ALL = 15,
    };

    public enum D3D10_TEXTURECUBE_FACE : int
    {
        D3D10_TEXTURECUBE_FACE_POSITIVE_X = 0,
        D3D10_TEXTURECUBE_FACE_NEGATIVE_X = 1,
        D3D10_TEXTURECUBE_FACE_POSITIVE_Y = 2,
        D3D10_TEXTURECUBE_FACE_NEGATIVE_Y = 3,
        D3D10_TEXTURECUBE_FACE_POSITIVE_Z = 4,
        D3D10_TEXTURECUBE_FACE_NEGATIVE_Z = 5,
    };

    public enum D3D10_FILTER_TYPE : int
    {
        D3D10_FILTER_TYPE_POINT = 0,
        D3D10_FILTER_TYPE_LINEAR = 1,
    };

    public enum D3D10_FORMAT_SUPPORT : int
    {
        D3D10_FORMAT_SUPPORT_BUFFER = 1,
        D3D10_FORMAT_SUPPORT_IA_VERTEX_BUFFER = 2,
        D3D10_FORMAT_SUPPORT_IA_INDEX_BUFFER = 4,
        D3D10_FORMAT_SUPPORT_SO_BUFFER = 8,
        D3D10_FORMAT_SUPPORT_TEXTURE1D = 16,
        D3D10_FORMAT_SUPPORT_TEXTURE2D = 32,
        D3D10_FORMAT_SUPPORT_TEXTURE3D = 64,
        D3D10_FORMAT_SUPPORT_TEXTURECUBE = 128,
        D3D10_FORMAT_SUPPORT_SHADER_LOAD = 256,
        D3D10_FORMAT_SUPPORT_SHADER_SAMPLE = 512,
        D3D10_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON = 1024,
        D3D10_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT = 2048,
        D3D10_FORMAT_SUPPORT_MIP = 4096,
        D3D10_FORMAT_SUPPORT_MIP_AUTOGEN = 8192,
        D3D10_FORMAT_SUPPORT_RENDER_TARGET = 16384,
        D3D10_FORMAT_SUPPORT_BLENDABLE = 32768,
        D3D10_FORMAT_SUPPORT_DEPTH_STENCIL = 65536,
        D3D10_FORMAT_SUPPORT_CPU_LOCKABLE = 131072,
        D3D10_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE = 262144,
        D3D10_FORMAT_SUPPORT_DISPLAY = 524288,
        D3D10_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT = 1048576,
        D3D10_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET = 2097152,
        D3D10_FORMAT_SUPPORT_MULTISAMPLE_LOAD = 4194304,
        D3D10_FORMAT_SUPPORT_SHADER_GATHER = 8388608,
        D3D10_FORMAT_SUPPORT_BACK_BUFFER_CAST = 16777216,
    };

    public enum D3D10_ASYNC_GETDATA_FLAG : int
    {
        D3D10_ASYNC_GETDATA_DONOTFLUSH = 1,
    };

    public enum D3D10_QUERY_MISC_FLAG : int
    {
        D3D10_QUERY_MISC_PREDICATEHINT = 1,
    };

    public enum D3D10_CREATE_DEVICE_FLAG : int
    {
        D3D10_CREATE_DEVICE_SINGLETHREADED = 1,
        D3D10_CREATE_DEVICE_DEBUG = 2,
        D3D10_CREATE_DEVICE_SWITCH_TO_REF = 4,
        D3D10_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 8,
        D3D10_CREATE_DEVICE_ALLOW_NULL_FROM_MAP = 16,
        D3D10_CREATE_DEVICE_BGRA_SUPPORT = 32,
        D3D10_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 128,
        D3D10_CREATE_DEVICE_STRICT_VALIDATION = 512,
        D3D10_CREATE_DEVICE_DEBUGGABLE = 1024,
    };

    public enum D3D10_MESSAGE_CATEGORY : int
    {
        D3D10_MESSAGE_CATEGORY_APPLICATION_DEFINED = 0,
        D3D10_MESSAGE_CATEGORY_MISCELLANEOUS = 1,
        D3D10_MESSAGE_CATEGORY_INITIALIZATION = 2,
        D3D10_MESSAGE_CATEGORY_CLEANUP = 3,
        D3D10_MESSAGE_CATEGORY_COMPILATION = 4,
        D3D10_MESSAGE_CATEGORY_STATE_CREATION = 5,
        D3D10_MESSAGE_CATEGORY_STATE_SETTING = 6,
        D3D10_MESSAGE_CATEGORY_STATE_GETTING = 7,
        D3D10_MESSAGE_CATEGORY_RESOURCE_MANIPULATION = 8,
        D3D10_MESSAGE_CATEGORY_EXECUTION = 9,
        D3D10_MESSAGE_CATEGORY_SHADER = 10,
    };

    public enum D3D10_MESSAGE_SEVERITY : int
    {
        D3D10_MESSAGE_SEVERITY_CORRUPTION = 0,
        D3D10_MESSAGE_SEVERITY_ERROR = 1,
        D3D10_MESSAGE_SEVERITY_WARNING = 2,
        D3D10_MESSAGE_SEVERITY_INFO = 3,
        D3D10_MESSAGE_SEVERITY_MESSAGE = 4,
    };

    public enum D3D10_MESSAGE_ID : int
    {
        D3D10_MESSAGE_ID_UNKNOWN = 0,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD = 1,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD = 2,
        D3D10_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD = 3,
        D3D10_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD = 4,
        D3D10_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD = 5,
        D3D10_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD = 6,
        D3D10_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD = 7,
        D3D10_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD = 8,
        D3D10_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD = 9,
        D3D10_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD = 10,
        D3D10_MESSAGE_ID_STRING_FROM_APPLICATION = 11,
        D3D10_MESSAGE_ID_CORRUPTED_THIS = 12,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER1 = 13,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER2 = 14,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER3 = 15,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER4 = 16,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER5 = 17,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER6 = 18,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER7 = 19,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER8 = 20,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER9 = 21,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER10 = 22,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER11 = 23,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER12 = 24,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER13 = 25,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER14 = 26,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER15 = 27,
        D3D10_MESSAGE_ID_CORRUPTED_MULTITHREADING = 28,
        D3D10_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY = 29,
        D3D10_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT = 30,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT = 31,
        D3D10_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT = 32,
        D3D10_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT = 33,
        D3D10_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 34,
        D3D10_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 35,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT = 36,
        D3D10_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT = 37,
        D3D10_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 38,
        D3D10_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 39,
        D3D10_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT = 40,
        D3D10_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT = 41,
        D3D10_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT = 42,
        D3D10_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 43,
        D3D10_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 44,
        D3D10_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT = 45,
        D3D10_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT = 46,
        D3D10_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT = 47,
        D3D10_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT = 48,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT = 49,
        D3D10_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT = 50,
        D3D10_MESSAGE_ID_GETPRIVATEDATA_MOREDATA = 51,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA = 52,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN = 53,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS = 54,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS = 55,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY = 56,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT = 57,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES = 58,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE = 59,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS = 60,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS = 61,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS = 62,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS = 63,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS = 64,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA = 65,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS = 66,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS = 67,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS = 68,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN = 69,
        D3D10_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN = 70,
        D3D10_MESSAGE_ID_CREATEBUFFER_NULLDESC = 71,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS = 72,
        D3D10_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION = 73,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT = 74,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT = 75,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES = 76,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE = 77,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS = 78,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS = 79,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS = 80,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS = 81,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS = 82,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA = 83,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS = 84,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS = 85,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS = 86,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN = 87,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN = 88,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_NULLDESC = 89,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION = 90,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT = 91,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT = 92,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES = 93,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE = 94,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS = 95,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS = 96,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS = 97,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS = 98,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS = 99,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA = 100,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS = 101,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS = 102,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS = 103,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN = 104,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN = 105,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_NULLDESC = 106,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION = 107,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT = 108,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT = 109,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES = 110,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE = 111,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS = 112,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS = 113,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS = 114,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS = 115,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS = 116,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA = 117,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS = 118,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS = 119,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS = 120,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN = 121,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN = 122,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_NULLDESC = 123,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION = 124,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT = 125,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC = 126,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT = 127,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS = 128,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE = 129,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS = 130,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN = 131,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN = 132,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT = 133,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT = 134,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC = 135,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT = 136,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS = 137,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE = 138,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS = 139,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN = 140,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN = 141,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT = 142,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC = 143,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT = 144,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS = 145,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE = 146,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS = 147,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN = 148,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN = 149,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY = 150,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS = 151,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT = 152,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT = 153,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT = 154,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS = 155,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH = 156,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE = 157,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE = 158,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT = 159,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC = 160,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE = 161,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC = 162,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT = 163,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC = 164,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY = 165,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE = 166,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE = 167,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY = 168,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE = 169,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE = 170,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY = 171,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE = 172,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE = 173,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES = 174,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED = 175,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL = 176,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL = 177,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED = 178,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT = 179,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT = 180,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT = 181,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT = 182,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION = 183,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT = 184,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE = 185,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC = 186,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH = 187,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS = 188,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX = 189,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE = 190,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY = 191,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE = 192,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE = 193,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE = 194,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE = 195,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP = 196,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS = 197,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS = 198,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC = 199,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK = 200,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC = 201,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP = 202,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP = 203,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP = 204,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC = 205,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP = 206,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP = 207,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP = 208,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC = 209,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS = 210,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC = 211,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND = 212,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND = 213,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP = 214,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA = 215,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA = 216,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA = 217,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK = 218,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS = 219,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC = 220,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER = 221,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU = 222,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV = 223,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW = 224,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS = 225,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY = 226,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC = 227,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD = 228,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD = 229,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS = 230,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC = 231,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY = 232,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS = 233,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG = 234,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC = 235,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED = 236,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED = 237,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER = 238,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE = 239,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY = 240,
        D3D10_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER = 241,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID = 242,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE = 243,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED = 244,
        D3D10_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY = 245,
        D3D10_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER = 246,
        D3D10_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 247,
        D3D10_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY = 248,
        D3D10_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY = 249,
        D3D10_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER = 250,
        D3D10_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 251,
        D3D10_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY = 252,
        D3D10_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER = 253,
        D3D10_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED = 254,
        D3D10_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY = 255,
        D3D10_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER = 256,
        D3D10_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 257,
        D3D10_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY = 258,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT = 259,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR = 260,
        D3D10_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH = 261,
        D3D10_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH = 262,
        D3D10_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID = 263,
        D3D10_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY = 264,
        D3D10_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY = 265,
        D3D10_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 266,
        D3D10_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY = 267,
        D3D10_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY = 268,
        D3D10_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 269,
        D3D10_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY = 270,
        D3D10_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY = 271,
        D3D10_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY = 272,
        D3D10_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 273,
        D3D10_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY = 274,
        D3D10_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY = 275,
        D3D10_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY = 276,
        D3D10_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID = 277,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE = 278,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE = 279,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX = 280,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE = 281,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE = 282,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE = 283,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE = 284,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE = 285,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE = 286,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE = 287,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX = 288,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE = 289,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID = 290,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID = 291,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID = 292,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID = 293,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID = 294,
        D3D10_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE = 295,
        D3D10_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS = 296,
        D3D10_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED = 297,
        D3D10_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN = 298,
        D3D10_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED = 299,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE = 300,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE = 301,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS = 302,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED = 303,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN = 304,
        D3D10_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE = 305,
        D3D10_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED = 306,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE = 307,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE = 308,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS = 309,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED = 310,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN = 311,
        D3D10_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE = 312,
        D3D10_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED = 313,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE = 314,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE = 315,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS = 316,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED = 317,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN = 318,
        D3D10_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE = 319,
        D3D10_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED = 320,
        D3D10_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED = 321,
        D3D10_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED = 322,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS = 323,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN = 324,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN = 325,
        D3D10_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE = 326,
        D3D10_MESSAGE_ID_REF_THREADING_MODE = 327,
        D3D10_MESSAGE_ID_REF_UMDRIVER_EXCEPTION = 328,
        D3D10_MESSAGE_ID_REF_KMDRIVER_EXCEPTION = 329,
        D3D10_MESSAGE_ID_REF_HARDWARE_EXCEPTION = 330,
        D3D10_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE = 331,
        D3D10_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER = 332,
        D3D10_MESSAGE_ID_REF_OUT_OF_MEMORY = 333,
        D3D10_MESSAGE_ID_REF_INFO = 334,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW = 335,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW = 336,
        D3D10_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW = 337,
        D3D10_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW = 338,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW = 339,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW = 340,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET = 341,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND = 342,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX = 343,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE = 344,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK = 345,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE = 346,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS = 347,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET = 348,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET = 349,
        D3D10_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET = 350,
        D3D10_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL = 351,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET = 352,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET = 353,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH = 354,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL = 355,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL = 356,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET = 357,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID = 358,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL = 359,
        D3D10_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH = 360,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH = 361,
        D3D10_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT = 362,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET = 363,
        D3D10_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED = 364,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY = 365,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED = 366,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED = 367,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED = 368,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED = 369,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED = 370,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED = 371,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED = 372,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED = 373,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE = 374,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER = 375,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING = 376,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0 = 377,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT = 378,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT = 379,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT = 380,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN = 381,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN = 382,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN = 383,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET = 384,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC = 385,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC = 386,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH = 387,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW = 388,
        D3D10_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS = 389,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH = 390,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH = 391,
        D3D10_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY = 392,
        D3D10_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY = 393,
        D3D10_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN = 394,
        D3D10_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN = 395,
        D3D10_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER = 396,
        D3D10_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED = 397,
        D3D10_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER = 398,
        D3D10_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN = 399,
        D3D10_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN = 400,
        D3D10_MESSAGE_ID_CREATECOUNTER_NULLDESC = 401,
        D3D10_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER = 402,
        D3D10_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER = 403,
        D3D10_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE = 404,
        D3D10_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED = 405,
        D3D10_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION = 406,
        D3D10_MESSAGE_ID_QUERY_BEGIN_DUPLICATE = 407,
        D3D10_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS = 408,
        D3D10_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION = 409,
        D3D10_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS = 410,
        D3D10_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN = 411,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE = 412,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS = 413,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL = 414,
        D3D10_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH = 415,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED = 416,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN = 417,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE = 418,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE = 419,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT = 420,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH = 421,
        D3D10_MESSAGE_ID_LIVE_OBJECT_SUMMARY = 422,
        D3D10_MESSAGE_ID_LIVE_BUFFER = 423,
        D3D10_MESSAGE_ID_LIVE_TEXTURE1D = 424,
        D3D10_MESSAGE_ID_LIVE_TEXTURE2D = 425,
        D3D10_MESSAGE_ID_LIVE_TEXTURE3D = 426,
        D3D10_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW = 427,
        D3D10_MESSAGE_ID_LIVE_RENDERTARGETVIEW = 428,
        D3D10_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW = 429,
        D3D10_MESSAGE_ID_LIVE_VERTEXSHADER = 430,
        D3D10_MESSAGE_ID_LIVE_GEOMETRYSHADER = 431,
        D3D10_MESSAGE_ID_LIVE_PIXELSHADER = 432,
        D3D10_MESSAGE_ID_LIVE_INPUTLAYOUT = 433,
        D3D10_MESSAGE_ID_LIVE_SAMPLER = 434,
        D3D10_MESSAGE_ID_LIVE_BLENDSTATE = 435,
        D3D10_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE = 436,
        D3D10_MESSAGE_ID_LIVE_RASTERIZERSTATE = 437,
        D3D10_MESSAGE_ID_LIVE_QUERY = 438,
        D3D10_MESSAGE_ID_LIVE_PREDICATE = 439,
        D3D10_MESSAGE_ID_LIVE_COUNTER = 440,
        D3D10_MESSAGE_ID_LIVE_DEVICE = 441,
        D3D10_MESSAGE_ID_LIVE_SWAPCHAIN = 442,
        D3D10_MESSAGE_ID_D3D10_MESSAGES_END = 443,
        D3D10_MESSAGE_ID_D3D10L9_MESSAGES_START = 1048576,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED = 1048577,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED = 1048578,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT = 1048579,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY = 1048580,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE = 1048581,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED = 1048582,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS = 1048583,
        D3D10_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS = 1048584,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS = 1048585,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND = 1048586,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D = 1048587,
        D3D10_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE = 1048588,
        D3D10_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE = 1048589,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS = 1048590,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS = 1048591,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX = 1048592,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS = 1048593,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED = 1048594,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS = 1048595,
        D3D10_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY = 1048596,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK = 1048597,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK = 1048598,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT = 1048599,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE = 1048600,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE = 1048601,
        D3D10_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE = 1048602,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD = 1048603,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL = 1048604,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX = 1048605,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO = 1048606,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES = 1048607,
        D3D10_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET = 1048608,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER = 1048609,
        D3D10_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE = 1048610,
        D3D10_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE = 1048611,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE = 1048612,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS = 1048613,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT = 1048614,
        D3D10_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS = 1048615,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES = 1048616,
        D3D10_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED = 1048617,
        D3D10_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED = 1048618,
        D3D10_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED = 1048619,
        D3D10_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED = 1048620,
        D3D10_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED = 1048621,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND = 1048622,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND = 1048623,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED = 1048624,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE = 1048625,
        D3D10_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED = 1048626,
        D3D10_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3 = 1048627,
        D3D10_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED = 1048628,
        D3D10_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO = 1048629,
        D3D10_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION = 1048630,
        D3D10_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED = 1048631,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR = 1048632,
        D3D10_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA = 1048633,
        D3D10_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP = 1048634,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED = 1048635,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT = 1048636,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES = 1048637,
        D3D10_MESSAGE_ID_D3D10L9_MESSAGES_END = 1048638,
    };

    public enum D3D10_DRIVER_TYPE : int
    {
        D3D10_DRIVER_TYPE_HARDWARE = 0,
        D3D10_DRIVER_TYPE_REFERENCE = 1,
        D3D10_DRIVER_TYPE_NULL = 2,
        D3D10_DRIVER_TYPE_SOFTWARE = 3,
        D3D10_DRIVER_TYPE_WARP = 5,
    };

    public enum _D3D10_DEVICE_STATE_TYPES : int
    {
        D3D10_DST_SO_BUFFERS = 1,
        D3D10_DST_OM_RENDER_TARGETS,
        D3D10_DST_OM_DEPTH_STENCIL_STATE,
        D3D10_DST_OM_BLEND_STATE,
        D3D10_DST_VS,
        D3D10_DST_VS_SAMPLERS,
        D3D10_DST_VS_SHADER_RESOURCES,
        D3D10_DST_VS_CONSTANT_BUFFERS,
        D3D10_DST_GS,
        D3D10_DST_GS_SAMPLERS,
        D3D10_DST_GS_SHADER_RESOURCES,
        D3D10_DST_GS_CONSTANT_BUFFERS,
        D3D10_DST_PS,
        D3D10_DST_PS_SAMPLERS,
        D3D10_DST_PS_SHADER_RESOURCES,
        D3D10_DST_PS_CONSTANT_BUFFERS,
        D3D10_DST_IA_VERTEX_BUFFERS,
        D3D10_DST_IA_INDEX_BUFFER,
        D3D10_DST_IA_INPUT_LAYOUT,
        D3D10_DST_IA_PRIMITIVE_TOPOLOGY,
        D3D10_DST_RS_VIEWPORTS,
        D3D10_DST_RS_SCISSOR_RECTS,
        D3D10_DST_RS_RASTERIZER_STATE,
        D3D10_DST_PREDICATION,
    };

    public enum D3D10_STANDARD_MULTISAMPLE_QUALITY_LEVELS : int
    {
        D3D10_STANDARD_MULTISAMPLE_PATTERN = -1,
        D3D10_CENTER_MULTISAMPLE_PATTERN = -2,
    };

    public enum _D3D10_SHADER_DEBUG_REGTYPE : int
    {
        D3D10_SHADER_DEBUG_REG_INPUT,
        D3D10_SHADER_DEBUG_REG_OUTPUT,
        D3D10_SHADER_DEBUG_REG_CBUFFER,
        D3D10_SHADER_DEBUG_REG_TBUFFER,
        D3D10_SHADER_DEBUG_REG_TEMP,
        D3D10_SHADER_DEBUG_REG_TEMPARRAY,
        D3D10_SHADER_DEBUG_REG_TEXTURE,
        D3D10_SHADER_DEBUG_REG_SAMPLER,
        D3D10_SHADER_DEBUG_REG_IMMEDIATECBUFFER,
        D3D10_SHADER_DEBUG_REG_LITERAL,
        D3D10_SHADER_DEBUG_REG_UNUSED,
        D3D11_SHADER_DEBUG_REG_INTERFACE_POINTERS,
        D3D11_SHADER_DEBUG_REG_UAV,
        D3D10_SHADER_DEBUG_REG_FORCE_DWORD = 2147483647,
    };

    public enum _D3D10_SHADER_DEBUG_SCOPETYPE : int
    {
        D3D10_SHADER_DEBUG_SCOPE_GLOBAL,
        D3D10_SHADER_DEBUG_SCOPE_BLOCK,
        D3D10_SHADER_DEBUG_SCOPE_FORLOOP,
        D3D10_SHADER_DEBUG_SCOPE_STRUCT,
        D3D10_SHADER_DEBUG_SCOPE_FUNC_PARAMS,
        D3D10_SHADER_DEBUG_SCOPE_STATEBLOCK,
        D3D10_SHADER_DEBUG_SCOPE_NAMESPACE,
        D3D10_SHADER_DEBUG_SCOPE_ANNOTATION,
        D3D10_SHADER_DEBUG_SCOPE_FORCE_DWORD = 2147483647,
    };

    public enum _D3D10_SHADER_DEBUG_VARTYPE : int
    {
        D3D10_SHADER_DEBUG_VAR_VARIABLE,
        D3D10_SHADER_DEBUG_VAR_FUNCTION,
        D3D10_SHADER_DEBUG_VAR_FORCE_DWORD = 2147483647,
    };

    public enum D2D1_DC_INITIALIZE_MODE : int
    {
        D2D1_DC_INITIALIZE_MODE_COPY = 0,
        D2D1_DC_INITIALIZE_MODE_CLEAR = 1,
        D2D1_DC_INITIALIZE_MODE_FORCE_DWORD = -1,
    };

    public enum D2D1_DEBUG_LEVEL : int
    {
        D2D1_DEBUG_LEVEL_NONE = 0,
        D2D1_DEBUG_LEVEL_ERROR = 1,
        D2D1_DEBUG_LEVEL_WARNING = 2,
        D2D1_DEBUG_LEVEL_INFORMATION = 3,
        D2D1_DEBUG_LEVEL_FORCE_DWORD = -1,
    };

    public enum DWRITE_SCRIPT_SHAPES : int
    {
        DWRITE_SCRIPT_SHAPES_DEFAULT = 0,
        DWRITE_SCRIPT_SHAPES_NO_VISUAL = 1,
    };

    public enum DWRITE_NUMBER_SUBSTITUTION_METHOD : int
    {
        DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE,
        DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL,
        DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE,
        DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL,
        DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL,
    };

    public enum DWRITE_TEXTURE_TYPE : int
    {
        DWRITE_TEXTURE_ALIASED_1x1,
        DWRITE_TEXTURE_CLEARTYPE_3x1,
    };

    public enum WICBitmapDitherType : int
    {
        WICBitmapDitherTypeNone = 0,
        WICBitmapDitherTypeSolid = 0,
        WICBitmapDitherTypeOrdered4x4 = 1,
        WICBitmapDitherTypeOrdered8x8 = 2,
        WICBitmapDitherTypeOrdered16x16 = 3,
        WICBitmapDitherTypeSpiral4x4 = 4,
        WICBitmapDitherTypeSpiral8x8 = 5,
        WICBitmapDitherTypeDualSpiral4x4 = 6,
        WICBitmapDitherTypeDualSpiral8x8 = 7,
        WICBitmapDitherTypeErrorDiffusion = 8,
        WICBITMAPDITHERTYPE_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapInterpolationMode : int
    {
        WICBitmapInterpolationModeNearestNeighbor = 0,
        WICBitmapInterpolationModeLinear = 1,
        WICBitmapInterpolationModeCubic = 2,
        WICBitmapInterpolationModeFant = 3,
        WICBITMAPINTERPOLATIONMODE_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapTransformOptions : int
    {
        WICBitmapTransformRotate0 = 0,
        WICBitmapTransformRotate90 = 1,
        WICBitmapTransformRotate180 = 2,
        WICBitmapTransformRotate270 = 3,
        WICBitmapTransformFlipHorizontal = 8,
        WICBitmapTransformFlipVertical = 16,
        WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD = 2147483647,
    };

    public enum WICColorContextType : int
    {
        WICColorContextUninitialized = 0,
        WICColorContextProfile = 1,
        WICColorContextExifColorSpace = 2,
    };

    public enum WICBitmapEncoderCacheOption : int
    {
        WICBitmapEncoderCacheInMemory = 0,
        WICBitmapEncoderCacheTempFile = 1,
        WICBitmapEncoderNoCache = 2,
        WICBITMAPENCODERCACHEOPTION_FORCE_DWORD = 2147483647,
    };

    public enum WICComponentType : int
    {
        WICDecoder = 1,
        WICEncoder = 2,
        WICPixelFormatConverter = 4,
        WICMetadataReader = 8,
        WICMetadataWriter = 16,
        WICPixelFormat = 32,
        WICAllComponents = 63,
        WICCOMPONENTTYPE_FORCE_DWORD = 2147483647,
    };

    public enum WICDecodeOptions : int
    {
        WICDecodeMetadataCacheOnDemand = 0,
        WICDecodeMetadataCacheOnLoad = 1,
        WICMETADATACACHEOPTION_FORCE_DWORD = 2147483647,
    };

    public enum WICPlanarOptions : int
    {
        WICPlanarOptionsDefault = 0,
        WICPlanarOptionsPreserveSubsampling = 1,
        WICPLANAROPTIONS_FORCE_DWORD = 2147483647,
    };

    public enum WICProgressOperation : int
    {
        WICProgressOperationCopyPixels = 1,
        WICProgressOperationWritePixels = 2,
        WICProgressOperationAll = 65535,
        WICPROGRESSOPERATION_FORCE_DWORD = 2147483647,
    };

    public enum WICPixelFormatNumericRepresentation : int
    {
        WICPixelFormatNumericRepresentationUnspecified = 0,
        WICPixelFormatNumericRepresentationIndexed = 1,
        WICPixelFormatNumericRepresentationUnsignedInteger = 2,
        WICPixelFormatNumericRepresentationSignedInteger = 3,
        WICPixelFormatNumericRepresentationFixed = 4,
        WICPixelFormatNumericRepresentationFloat = 5,
        WICPixelFormatNumericRepresentation_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapCreateCacheOption : int
    {
        WICBitmapNoCache = 0,
        WICBitmapCacheOnDemand = 1,
        WICBitmapCacheOnLoad = 2,
        WICBITMAPCREATECACHEOPTION_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapAlphaChannelOption : int
    {
        WICBitmapUseAlpha = 0,
        WICBitmapUsePremultipliedAlpha = 1,
        WICBitmapIgnoreAlpha = 2,
        WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD = 2147483647,
    };

    public enum WICRawCapabilities : int
    {
        WICRawCapabilityNotSupported = 0,
        WICRawCapabilityGetSupported = 1,
        WICRawCapabilityFullySupported = 2,
        WICRAWCAPABILITIES_FORCE_DWORD = 2147483647,
    };

    public enum WICRawRotationCapabilities : int
    {
        WICRawRotationCapabilityNotSupported = 0,
        WICRawRotationCapabilityGetSupported = 1,
        WICRawRotationCapabilityNinetyDegreesSupported = 2,
        WICRawRotationCapabilityFullySupported = 3,
        WICRAWROTATIONCAPABILITIES_FORCE_DWORD = 2147483647,
    };

    public enum WICRawParameterSet : int
    {
        WICAsShotParameterSet = 1,
        WICUserAdjustedParameterSet = 2,
        WICAutoAdjustedParameterSet = 3,
        WICRAWPARAMETERSET_FORCE_DWORD = 2147483647,
    };

    public enum WICNamedWhitePoint : int
    {
        WICWhitePointDefault = 1,
        WICWhitePointDaylight = 2,
        WICWhitePointCloudy = 4,
        WICWhitePointShade = 8,
        WICWhitePointTungsten = 16,
        WICWhitePointFluorescent = 32,
        WICWhitePointFlash = 64,
        WICWhitePointUnderwater = 128,
        WICWhitePointCustom = 256,
        WICWhitePointAutoWhiteBalance = 512,
        WICWhitePointAsShot = 1,
        WICNAMEDWHITEPOINT_FORCE_DWORD = 2147483647,
    };

    public enum WICRawRenderMode : int
    {
        WICRawRenderModeDraft = 1,
        WICRawRenderModeNormal = 2,
        WICRawRenderModeBestQuality = 3,
        WICRAWRENDERMODE_FORCE_DWORD = 2147483647,
    };

    public enum WICDdsDimension : int
    {
        WICDdsTexture1D = 0,
        WICDdsTexture2D = 1,
        WICDdsTexture3D = 2,
        WICDdsTextureCube = 3,
        WICDDSTEXTURE_FORCE_DWORD = 2147483647,
    };

    public enum WICDdsAlphaMode : int
    {
        WICDdsAlphaModeUnknown = 0,
        WICDdsAlphaModeStraight = 1,
        WICDdsAlphaModePremultiplied = 2,
        WICDdsAlphaModeOpaque = 3,
        WICDdsAlphaModeCustom = 4,
        WICDDSALPHAMODE_FORCE_DWORD = 2147483647,
    };

    public enum WICComponentEnumerateOptions : int
    {
        WICComponentEnumerateDefault = 0,
        WICComponentEnumerateRefresh = 1,
        WICComponentEnumerateDisabled = -2147483648,
        WICComponentEnumerateUnsigned = 1073741824,
        WICComponentEnumerateBuiltInOnly = 536870912,
        WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapLockFlags : int
    {
        WICBitmapLockRead = 1,
        WICBitmapLockWrite = 2,
        WICBITMAPLOCKFLAGS_FORCE_DWORD = 2147483647,
    };

    public enum WICBitmapDecoderCapabilities : int
    {
        WICBitmapDecoderCapabilitySameEncoder = 1,
        WICBitmapDecoderCapabilityCanDecodeAllImages = 2,
        WICBitmapDecoderCapabilityCanDecodeSomeImages = 4,
        WICBitmapDecoderCapabilityCanEnumerateMetadata = 8,
        WICBitmapDecoderCapabilityCanDecodeThumbnail = 16,
        WICBITMAPDECODERCAPABILITIES_FORCE_DWORD = 2147483647,
    };

    public enum WICProgressNotification : int
    {
        WICProgressNotificationBegin = 65536,
        WICProgressNotificationEnd = 131072,
        WICProgressNotificationFrequent = 262144,
        WICProgressNotificationAll = -65536,
        WICPROGRESSNOTIFICATION_FORCE_DWORD = 2147483647,
    };

    public enum WICComponentSigning : int
    {
        WICComponentSigned = 1,
        WICComponentUnsigned = 2,
        WICComponentSafe = 4,
        WICComponentDisabled = -2147483648,
        WICCOMPONENTSIGNING_FORCE_DWORD = 2147483647,
    };

    public enum WICGifLogicalScreenDescriptorProperties : int
    {
        WICGifLogicalScreenSignature = 1,
        WICGifLogicalScreenDescriptorWidth = 2,
        WICGifLogicalScreenDescriptorHeight = 3,
        WICGifLogicalScreenDescriptorGlobalColorTableFlag = 4,
        WICGifLogicalScreenDescriptorColorResolution = 5,
        WICGifLogicalScreenDescriptorSortFlag = 6,
        WICGifLogicalScreenDescriptorGlobalColorTableSize = 7,
        WICGifLogicalScreenDescriptorBackgroundColorIndex = 8,
        WICGifLogicalScreenDescriptorPixelAspectRatio = 9,
        WICGifLogicalScreenDescriptorProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICGifImageDescriptorProperties : int
    {
        WICGifImageDescriptorLeft = 1,
        WICGifImageDescriptorTop = 2,
        WICGifImageDescriptorWidth = 3,
        WICGifImageDescriptorHeight = 4,
        WICGifImageDescriptorLocalColorTableFlag = 5,
        WICGifImageDescriptorInterlaceFlag = 6,
        WICGifImageDescriptorSortFlag = 7,
        WICGifImageDescriptorLocalColorTableSize = 8,
        WICGifImageDescriptorProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICGifGraphicControlExtensionProperties : int
    {
        WICGifGraphicControlExtensionDisposal = 1,
        WICGifGraphicControlExtensionUserInputFlag = 2,
        WICGifGraphicControlExtensionTransparencyFlag = 3,
        WICGifGraphicControlExtensionDelay = 4,
        WICGifGraphicControlExtensionTransparentColorIndex = 5,
        WICGifGraphicControlExtensionProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICGifApplicationExtensionProperties : int
    {
        WICGifApplicationExtensionApplication = 1,
        WICGifApplicationExtensionData = 2,
        WICGifApplicationExtensionProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICGifCommentExtensionProperties : int
    {
        WICGifCommentExtensionText = 1,
        WICGifCommentExtensionProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICJpegCommentProperties : int
    {
        WICJpegCommentText = 1,
        WICJpegCommentProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICJpegLuminanceProperties : int
    {
        WICJpegLuminanceTable = 1,
        WICJpegLuminanceProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICJpegChrominanceProperties : int
    {
        WICJpegChrominanceTable = 1,
        WICJpegChrominanceProperties_FORCE_DWORD = 2147483647,
    };

    public enum WIC8BIMIptcProperties : int
    {
        WIC8BIMIptcPString = 0,
        WIC8BIMIptcEmbeddedIPTC = 1,
        WIC8BIMIptcProperties_FORCE_DWORD = 2147483647,
    };

    public enum WIC8BIMResolutionInfoProperties : int
    {
        WIC8BIMResolutionInfoPString = 1,
        WIC8BIMResolutionInfoHResolution = 2,
        WIC8BIMResolutionInfoHResolutionUnit = 3,
        WIC8BIMResolutionInfoWidthUnit = 4,
        WIC8BIMResolutionInfoVResolution = 5,
        WIC8BIMResolutionInfoVResolutionUnit = 6,
        WIC8BIMResolutionInfoHeightUnit = 7,
        WIC8BIMResolutionInfoProperties_FORCE_DWORD = 2147483647,
    };

    public enum WIC8BIMIptcDigestProperties : int
    {
        WIC8BIMIptcDigestPString = 1,
        WIC8BIMIptcDigestIptcDigest = 2,
        WIC8BIMIptcDigestProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngGamaProperties : int
    {
        WICPngGamaGamma = 1,
        WICPngGamaProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngBkgdProperties : int
    {
        WICPngBkgdBackgroundColor = 1,
        WICPngBkgdProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngItxtProperties : int
    {
        WICPngItxtKeyword = 1,
        WICPngItxtCompressionFlag = 2,
        WICPngItxtLanguageTag = 3,
        WICPngItxtTranslatedKeyword = 4,
        WICPngItxtText = 5,
        WICPngItxtProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngChrmProperties : int
    {
        WICPngChrmWhitePointX = 1,
        WICPngChrmWhitePointY = 2,
        WICPngChrmRedX = 3,
        WICPngChrmRedY = 4,
        WICPngChrmGreenX = 5,
        WICPngChrmGreenY = 6,
        WICPngChrmBlueX = 7,
        WICPngChrmBlueY = 8,
        WICPngChrmProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngHistProperties : int
    {
        WICPngHistFrequencies = 1,
        WICPngHistProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngIccpProperties : int
    {
        WICPngIccpProfileName = 1,
        WICPngIccpProfileData = 2,
        WICPngIccpProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngSrgbProperties : int
    {
        WICPngSrgbRenderingIntent = 1,
        WICPngSrgbProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICPngTimeProperties : int
    {
        WICPngTimeYear = 1,
        WICPngTimeMonth = 2,
        WICPngTimeDay = 3,
        WICPngTimeHour = 4,
        WICPngTimeMinute = 5,
        WICPngTimeSecond = 6,
        WICPngTimeProperties_FORCE_DWORD = 2147483647,
    };

    public enum WICSectionAccessLevel : int
    {
        WICSectionAccessLevelRead = 1,
        WICSectionAccessLevelReadWrite = 3,
        WICSectionAccessLevel_FORCE_DWORD = 2147483647,
    };

    public enum WICTiffCompressionOption : int
    {
        WICTiffCompressionDontCare = 0,
        WICTiffCompressionNone = 1,
        WICTiffCompressionCCITT3 = 2,
        WICTiffCompressionCCITT4 = 3,
        WICTiffCompressionLZW = 4,
        WICTiffCompressionRLE = 5,
        WICTiffCompressionZIP = 6,
        WICTiffCompressionLZWHDifferencing = 7,
        WICTIFFCOMPRESSIONOPTION_FORCE_DWORD = 2147483647,
    };

    public enum WICJpegYCrCbSubsamplingOption : int
    {
        WICJpegYCrCbSubsamplingDefault = 0,
        WICJpegYCrCbSubsampling420 = 1,
        WICJpegYCrCbSubsampling422 = 2,
        WICJpegYCrCbSubsampling444 = 3,
        WICJpegYCrCbSubsampling440 = 4,
        WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD = 2147483647,
    };

    public enum WICPngFilterOption : int
    {
        WICPngFilterUnspecified = 0,
        WICPngFilterNone = 1,
        WICPngFilterSub = 2,
        WICPngFilterUp = 3,
        WICPngFilterAverage = 4,
        WICPngFilterPaeth = 5,
        WICPngFilterAdaptive = 6,
        WICPNGFILTEROPTION_FORCE_DWORD = 2147483647,
    };

    public enum tagTextMode : int
    {
        TM_PLAINTEXT = 1,
        TM_RICHTEXT = 2,
        TM_SINGLELEVELUNDO = 4,
        TM_MULTILEVELUNDO = 8,
        TM_SINGLECODEPAGE = 16,
        TM_MULTICODEPAGE = 32,
    };

    public enum _undonameid : int
    {
        UID_UNKNOWN = 0,
        UID_TYPING = 1,
        UID_DELETE = 2,
        UID_DRAGDROP = 3,
        UID_CUT = 4,
        UID_PASTE = 5,
        UID_AUTOTABLE = 6,
    };

    public enum tagKHYPH : int
    {
        khyphNil,
        khyphNormal,
        khyphAddBefore,
        khyphChangeBefore,
        khyphDeleteBefore,
        khyphChangeAfter,
        khyphDelAndChange,
    };

    public enum CommandStateChangeConstants : int
    {
        CSC_UPDATECOMMANDS = -1,
        CSC_NAVIGATEFORWARD = 1,
        CSC_NAVIGATEBACK = 2,
    };

    public enum SecureLockIconConstants : int
    {
        secureLockIconUnsecure = 0,
        secureLockIconMixed = 1,
        secureLockIconSecureUnknownBits = 2,
        secureLockIconSecure40Bit = 3,
        secureLockIconSecure56Bit = 4,
        secureLockIconSecureFortezza = 5,
        secureLockIconSecure128Bit = 6,
    };

    public enum NewProcessCauseConstants : int
    {
        ProtectedModeRedirect = 1,
    };

    public enum ShellWindowTypeConstants : int
    {
        SWC_EXPLORER = 0,
        SWC_BROWSER = 1,
        SWC_3RDPARTY = 2,
        SWC_CALLBACK = 4,
        SWC_DESKTOP = 8,
    };

    public enum ShellWindowFindWindowOptions : int
    {
        SWFO_NEEDDISPATCH = 1,
        SWFO_INCLUDEPENDING = 2,
        SWFO_COOKIEPASSED = 4,
    };

    public enum BrowserNavConstants : int
    {
        navOpenInNewWindow = 1,
        navNoHistory = 2,
        navNoReadFromCache = 4,
        navNoWriteToCache = 8,
        navAllowAutosearch = 16,
        navBrowserBar = 32,
        navHyperlink = 64,
        navEnforceRestricted = 128,
        navNewWindowsManaged = 256,
        navUntrustedForDownload = 512,
        navTrustedForActiveX = 1024,
        navOpenInNewTab = 2048,
        navOpenInBackgroundTab = 4096,
        navKeepWordWheelText = 8192,
        navVirtualTab = 16384,
        navBlockRedirectsXDomain = 32768,
        navOpenNewForegroundTab = 65536,
        navTravelLogScreenshot = 131072,
        navDeferUnload = 262144,
        navSpeculative = 524288,
        navSuggestNewWindow = 1048576,
        navSuggestNewTab = 2097152,
        navReserved1 = 4194304,
        navHomepageNavigate = 8388608,
    };

    public enum RefreshConstants : int
    {
        REFRESH_NORMAL = 0,
        REFRESH_IFEXPIRED = 1,
        REFRESH_COMPLETELY = 3,
    };

    public enum OfflineFolderStatus : int
    {
        OFS_INACTIVE = -1,
        OFS_ONLINE = 0,
        OFS_OFFLINE = 1,
        OFS_SERVERBACK = 2,
        OFS_DIRTYCACHE = 3,
    };

    public enum ShellFolderViewOptions : int
    {
        SFVVO_SHOWALLOBJECTS = 1,
        SFVVO_SHOWEXTENSIONS = 2,
        SFVVO_SHOWCOMPCOLOR = 8,
        SFVVO_SHOWSYSFILES = 32,
        SFVVO_WIN95CLASSIC = 64,
        SFVVO_DOUBLECLICKINWEBVIEW = 128,
        SFVVO_DESKTOPHTML = 512,
    };

    public enum ShellSpecialFolderConstants : int
    {
        ssfDESKTOP = 0,
        ssfPROGRAMS = 2,
        ssfCONTROLS = 3,
        ssfPRINTERS = 4,
        ssfPERSONAL = 5,
        ssfFAVORITES = 6,
        ssfSTARTUP = 7,
        ssfRECENT = 8,
        ssfSENDTO = 9,
        ssfBITBUCKET = 10,
        ssfSTARTMENU = 11,
        ssfDESKTOPDIRECTORY = 16,
        ssfDRIVES = 17,
        ssfNETWORK = 18,
        ssfNETHOOD = 19,
        ssfFONTS = 20,
        ssfTEMPLATES = 21,
        ssfCOMMONSTARTMENU = 22,
        ssfCOMMONPROGRAMS = 23,
        ssfCOMMONSTARTUP = 24,
        ssfCOMMONDESKTOPDIR = 25,
        ssfAPPDATA = 26,
        ssfPRINTHOOD = 27,
        ssfLOCALAPPDATA = 28,
        ssfALTSTARTUP = 29,
        ssfCOMMONALTSTARTUP = 30,
        ssfCOMMONFAVORITES = 31,
        ssfINTERNETCACHE = 32,
        ssfCOOKIES = 33,
        ssfHISTORY = 34,
        ssfCOMMONAPPDATA = 35,
        ssfWINDOWS = 36,
        ssfSYSTEM = 37,
        ssfPROGRAMFILES = 38,
        ssfMYPICTURES = 39,
        ssfPROFILE = 40,
        ssfSYSTEMx86 = 41,
        ssfPROGRAMFILESx86 = 48,
    };

    public enum _tagAUTOCOMPLETEOPTIONS : int
    {
        ACO_NONE = 0,
        ACO_AUTOSUGGEST = 1,
        ACO_AUTOAPPEND = 2,
        ACO_SEARCH = 4,
        ACO_FILTERPREFIXES = 8,
        ACO_USETAB = 16,
        ACO_UPDOWNKEYDROPSLIST = 32,
        ACO_RTLREADING = 64,
        ACO_WORD_FILTER = 128,
        ACO_NOPREFIXFILTERING = 256,
    };

    public enum _tagACENUMOPTION : int
    {
        ACEO_NONE = 0,
        ACEO_MOSTRECENTFIRST = 1,
        ACEO_FIRSTUNUSED = 65536,
    };

    public enum SHELL_LINK_DATA_FLAGS : int
    {
        SLDF_DEFAULT = 0,
        SLDF_HAS_ID_LIST = 1,
        SLDF_HAS_LINK_INFO = 2,
        SLDF_HAS_NAME = 4,
        SLDF_HAS_RELPATH = 8,
        SLDF_HAS_WORKINGDIR = 16,
        SLDF_HAS_ARGS = 32,
        SLDF_HAS_ICONLOCATION = 64,
        SLDF_UNICODE = 128,
        SLDF_FORCE_NO_LINKINFO = 256,
        SLDF_HAS_EXP_SZ = 512,
        SLDF_RUN_IN_SEPARATE = 1024,
        SLDF_HAS_DARWINID = 4096,
        SLDF_RUNAS_USER = 8192,
        SLDF_HAS_EXP_ICON_SZ = 16384,
        SLDF_NO_PIDL_ALIAS = 32768,
        SLDF_FORCE_UNCNAME = 65536,
        SLDF_RUN_WITH_SHIMLAYER = 131072,
        SLDF_FORCE_NO_LINKTRACK = 262144,
        SLDF_ENABLE_TARGET_METADATA = 524288,
        SLDF_DISABLE_LINK_PATH_TRACKING = 1048576,
        SLDF_DISABLE_KNOWNFOLDER_RELATIVE_TRACKING = 2097152,
        SLDF_NO_KF_ALIAS = 4194304,
        SLDF_ALLOW_LINK_TO_LINK = 8388608,
        SLDF_UNALIAS_ON_SAVE = 16777216,
        SLDF_PREFER_ENVIRONMENT_PATH = 33554432,
        SLDF_KEEP_LOCAL_IDLIST_FOR_UNC_TARGET = 67108864,
        SLDF_PERSIST_VOLUME_ID_RELATIVE = 134217728,
        SLDF_VALID = 268433407,
        SLDF_RESERVED = -2147483648,
    };

    public enum SHGFP_TYPE : int
    {
        SHGFP_TYPE_CURRENT = 0,
        SHGFP_TYPE_DEFAULT = 1,
    };

    public enum KNOWN_FOLDER_FLAG : int
    {
        KF_FLAG_DEFAULT = 0,
        KF_FLAG_NO_APPCONTAINER_REDIRECTION = 65536,
        KF_FLAG_CREATE = 32768,
        KF_FLAG_DONT_VERIFY = 16384,
        KF_FLAG_DONT_UNEXPAND = 8192,
        KF_FLAG_NO_ALIAS = 4096,
        KF_FLAG_INIT = 2048,
        KF_FLAG_DEFAULT_PATH = 1024,
        KF_FLAG_NOT_PARENT_RELATIVE = 512,
        KF_FLAG_SIMPLE_IDLIST = 256,
        KF_FLAG_ALIAS_ONLY = -2147483648,
    };

    public enum _tagAUTOCOMPLETELISTOPTIONS : int
    {
        ACLO_NONE = 0,
        ACLO_CURRENTDIR = 1,
        ACLO_MYCOMPUTER = 2,
        ACLO_DESKTOP = 4,
        ACLO_FAVORITES = 8,
        ACLO_FILESYSONLY = 16,
        ACLO_FILESYSDIRS = 32,
        ACLO_VIRTUALNAMESPACE = 64,
    };

    public enum FD_FLAGS : int
    {
        FD_CLSID = 1,
        FD_SIZEPOINT = 2,
        FD_ATTRIBUTES = 4,
        FD_CREATETIME = 8,
        FD_ACCESSTIME = 16,
        FD_WRITESTIME = 32,
        FD_FILESIZE = 64,
        FD_PROGRESSUI = 16384,
        FD_LINKUI = 32768,
        FD_UNICODE = -2147483648,
    };

    public enum DROPIMAGETYPE : int
    {
        DROPIMAGE_INVALID = -1,
        DROPIMAGE_NONE = 0,
        DROPIMAGE_COPY = 1,
        DROPIMAGE_MOVE = 2,
        DROPIMAGE_LINK = 4,
        DROPIMAGE_LABEL = 6,
        DROPIMAGE_WARNING = 7,
        DROPIMAGE_NOIMAGE = 8,
    };

    public enum SHARD : int
    {
        SHARD_PIDL = 1,
        SHARD_PATHA = 2,
        SHARD_PATHW = 3,
        SHARD_APPIDINFO = 4,
        SHARD_APPIDINFOIDLIST = 5,
        SHARD_LINK = 6,
        SHARD_APPIDINFOLINK = 7,
        SHARD_SHELLITEM = 8,
    };

    public enum SCNRT_STATUS : int
    {
        SCNRT_ENABLE = 0,
        SCNRT_DISABLE = 1,
    };

    public enum RESTRICTIONS : int
    {
        REST_NONE = 0,
        REST_NORUN = 1,
        REST_NOCLOSE = 2,
        REST_NOSAVESET = 4,
        REST_NOFILEMENU = 8,
        REST_NOSETFOLDERS = 16,
        REST_NOSETTASKBAR = 32,
        REST_NODESKTOP = 64,
        REST_NOFIND = 128,
        REST_NODRIVES = 256,
        REST_NODRIVEAUTORUN = 512,
        REST_NODRIVETYPEAUTORUN = 1024,
        REST_NONETHOOD = 2048,
        REST_STARTBANNER = 4096,
        REST_RESTRICTRUN = 8192,
        REST_NOPRINTERTABS = 16384,
        REST_NOPRINTERDELETE = 32768,
        REST_NOPRINTERADD = 65536,
        REST_NOSTARTMENUSUBFOLDERS = 131072,
        REST_MYDOCSONNET = 262144,
        REST_NOEXITTODOS = 524288,
        REST_ENFORCESHELLEXTSECURITY = 1048576,
        REST_LINKRESOLVEIGNORELINKINFO = 2097152,
        REST_NOCOMMONGROUPS = 4194304,
        REST_SEPARATEDESKTOPPROCESS = 8388608,
        REST_NOWEB = 16777216,
        REST_NOTRAYCONTEXTMENU = 33554432,
        REST_NOVIEWCONTEXTMENU = 67108864,
        REST_NONETCONNECTDISCONNECT = 134217728,
        REST_STARTMENULOGOFF = 268435456,
        REST_NOSETTINGSASSIST = 536870912,
        REST_NOINTERNETICON = 1073741825,
        REST_NORECENTDOCSHISTORY = 1073741826,
        REST_NORECENTDOCSMENU = 1073741827,
        REST_NOACTIVEDESKTOP = 1073741828,
        REST_NOACTIVEDESKTOPCHANGES = 1073741829,
        REST_NOFAVORITESMENU = 1073741830,
        REST_CLEARRECENTDOCSONEXIT = 1073741831,
        REST_CLASSICSHELL = 1073741832,
        REST_NOCUSTOMIZEWEBVIEW = 1073741833,
        REST_NOHTMLWALLPAPER = 1073741840,
        REST_NOCHANGINGWALLPAPER = 1073741841,
        REST_NODESKCOMP = 1073741842,
        REST_NOADDDESKCOMP = 1073741843,
        REST_NODELDESKCOMP = 1073741844,
        REST_NOCLOSEDESKCOMP = 1073741845,
        REST_NOCLOSE_DRAGDROPBAND = 1073741846,
        REST_NOMOVINGBAND = 1073741847,
        REST_NOEDITDESKCOMP = 1073741848,
        REST_NORESOLVESEARCH = 1073741849,
        REST_NORESOLVETRACK = 1073741850,
        REST_FORCECOPYACLWITHFILE = 1073741851,
        REST_NOFORGETSOFTWAREUPDATE = 1073741853,
        REST_NOSETACTIVEDESKTOP = 1073741854,
        REST_NOUPDATEWINDOWS = 1073741855,
        REST_NOCHANGESTARMENU = 1073741856,
        REST_NOFOLDEROPTIONS = 1073741857,
        REST_HASFINDCOMPUTERS = 1073741858,
        REST_INTELLIMENUS = 1073741859,
        REST_RUNDLGMEMCHECKBOX = 1073741860,
        REST_ARP_ShowPostSetup = 1073741861,
        REST_NOCSC = 1073741862,
        REST_NOCONTROLPANEL = 1073741863,
        REST_ENUMWORKGROUP = 1073741864,
        REST_ARP_NOARP = 1073741865,
        REST_ARP_NOREMOVEPAGE = 1073741866,
        REST_ARP_NOADDPAGE = 1073741867,
        REST_ARP_NOWINSETUPPAGE = 1073741868,
        REST_GREYMSIADS = 1073741869,
        REST_NOCHANGEMAPPEDDRIVELABEL = 1073741870,
        REST_NOCHANGEMAPPEDDRIVECOMMENT = 1073741871,
        REST_MaxRecentDocs = 1073741872,
        REST_NONETWORKCONNECTIONS = 1073741873,
        REST_FORCESTARTMENULOGOFF = 1073741874,
        REST_NOWEBVIEW = 1073741875,
        REST_NOCUSTOMIZETHISFOLDER = 1073741876,
        REST_NOENCRYPTION = 1073741877,
        REST_DONTSHOWSUPERHIDDEN = 1073741879,
        REST_NOSHELLSEARCHBUTTON = 1073741880,
        REST_NOHARDWARETAB = 1073741881,
        REST_NORUNASINSTALLPROMPT = 1073741882,
        REST_PROMPTRUNASINSTALLNETPATH = 1073741883,
        REST_NOMANAGEMYCOMPUTERVERB = 1073741884,
        REST_DISALLOWRUN = 1073741886,
        REST_NOWELCOMESCREEN = 1073741887,
        REST_RESTRICTCPL = 1073741888,
        REST_DISALLOWCPL = 1073741889,
        REST_NOSMBALLOONTIP = 1073741890,
        REST_NOSMHELP = 1073741891,
        REST_NOWINKEYS = 1073741892,
        REST_NOENCRYPTONMOVE = 1073741893,
        REST_NOLOCALMACHINERUN = 1073741894,
        REST_NOCURRENTUSERRUN = 1073741895,
        REST_NOLOCALMACHINERUNONCE = 1073741896,
        REST_NOCURRENTUSERRUNONCE = 1073741897,
        REST_FORCEACTIVEDESKTOPON = 1073741898,
        REST_NOVIEWONDRIVE = 1073741900,
        REST_NONETCRAWL = 1073741901,
        REST_NOSHAREDDOCUMENTS = 1073741902,
        REST_NOSMMYDOCS = 1073741903,
        REST_NOSMMYPICS = 1073741904,
        REST_ALLOWBITBUCKDRIVES = 1073741905,
        REST_NONLEGACYSHELLMODE = 1073741906,
        REST_NOCONTROLPANELBARRICADE = 1073741907,
        REST_NOSTARTPAGE = 1073741908,
        REST_NOAUTOTRAYNOTIFY = 1073741909,
        REST_NOTASKGROUPING = 1073741910,
        REST_NOCDBURNING = 1073741911,
        REST_MYCOMPNOPROP = 1073741912,
        REST_MYDOCSNOPROP = 1073741913,
        REST_NOSTARTPANEL = 1073741914,
        REST_NODISPLAYAPPEARANCEPAGE = 1073741915,
        REST_NOTHEMESTAB = 1073741916,
        REST_NOVISUALSTYLECHOICE = 1073741917,
        REST_NOSIZECHOICE = 1073741918,
        REST_NOCOLORCHOICE = 1073741919,
        REST_SETVISUALSTYLE = 1073741920,
        REST_STARTRUNNOHOMEPATH = 1073741921,
        REST_NOUSERNAMEINSTARTPANEL = 1073741922,
        REST_NOMYCOMPUTERICON = 1073741923,
        REST_NOSMNETWORKPLACES = 1073741924,
        REST_NOSMPINNEDLIST = 1073741925,
        REST_NOSMMYMUSIC = 1073741926,
        REST_NOSMEJECTPC = 1073741927,
        REST_NOSMMOREPROGRAMS = 1073741928,
        REST_NOSMMFUPROGRAMS = 1073741929,
        REST_NOTRAYITEMSDISPLAY = 1073741930,
        REST_NOTOOLBARSONTASKBAR = 1073741931,
        REST_NOSMCONFIGUREPROGRAMS = 1073741935,
        REST_HIDECLOCK = 1073741936,
        REST_NOLOWDISKSPACECHECKS = 1073741937,
        REST_NOENTIRENETWORK = 1073741938,
        REST_NODESKTOPCLEANUP = 1073741939,
        REST_BITBUCKNUKEONDELETE = 1073741940,
        REST_BITBUCKCONFIRMDELETE = 1073741941,
        REST_BITBUCKNOPROP = 1073741942,
        REST_NODISPBACKGROUND = 1073741943,
        REST_NODISPSCREENSAVEPG = 1073741944,
        REST_NODISPSETTINGSPG = 1073741945,
        REST_NODISPSCREENSAVEPREVIEW = 1073741946,
        REST_NODISPLAYCPL = 1073741947,
        REST_HIDERUNASVERB = 1073741948,
        REST_NOTHUMBNAILCACHE = 1073741949,
        REST_NOSTRCMPLOGICAL = 1073741950,
        REST_NOPUBLISHWIZARD = 1073741951,
        REST_NOONLINEPRINTSWIZARD = 1073741952,
        REST_NOWEBSERVICES = 1073741953,
        REST_ALLOWUNHASHEDWEBVIEW = 1073741954,
        REST_ALLOWLEGACYWEBVIEW = 1073741955,
        REST_REVERTWEBVIEWSECURITY = 1073741956,
        REST_INHERITCONSOLEHANDLES = 1073741958,
        REST_NOREMOTERECURSIVEEVENTS = 1073741961,
        REST_NOREMOTECHANGENOTIFY = 1073741969,
        REST_NOENUMENTIRENETWORK = 1073741971,
        REST_NOINTERNETOPENWITH = 1073741973,
        REST_DONTRETRYBADNETNAME = 1073741979,
        REST_ALLOWFILECLSIDJUNCTIONS = 1073741980,
        REST_NOUPNPINSTALL = 1073741981,
        REST_ARP_DONTGROUPPATCHES = 1073741996,
        REST_ARP_NOCHOOSEPROGRAMSPAGE = 1073741997,
        REST_NODISCONNECT = 1090519041,
        REST_NOSECURITY = 1090519042,
        REST_NOFILEASSOCIATE = 1090519043,
        REST_ALLOWCOMMENTTOGGLE = 1090519044,
    };

    public enum tagOPEN_AS_INFO_FLAGS : int
    {
        OAIF_ALLOW_REGISTRATION = 1,
        OAIF_REGISTER_EXT = 2,
        OAIF_EXEC = 4,
        OAIF_FORCE_REGISTRATION = 8,
        OAIF_HIDE_REGISTRATION = 32,
        OAIF_URL_PROTOCOL = 64,
        OAIF_FILE_IS_URI = 128,
    };

    public enum tagIESHORTCUTFLAGS : int
    {
        IESHORTCUT_NEWBROWSER = 1,
        IESHORTCUT_OPENNEWTAB = 2,
        IESHORTCUT_FORCENAVIGATE = 4,
        IESHORTCUT_BACKGROUNDTAB = 8,
    };

    public enum AFX_REG_FLAGS : int
    {
        afxRegDefault = 0,
        afxRegInsertable = 1,
        afxRegApartmentThreading = 2,
        afxRegFreeThreading = 4,
    };

    public enum OLE_APPTYPE : int
    {
        OAT_UNKNOWN = -1,
        OAT_INPLACE_SERVER = 0,
        OAT_SERVER = 1,
        OAT_CONTAINER = 2,
        OAT_DISPATCH_OBJECT = 3,
        OAT_DOC_OBJECT_SERVER = 4,
        OAT_DOC_OBJECT_CONTAINER = 5,
    };

    public enum tagDBROWFETCH : int
    {
        DBROWFETCH_DEFAULT = 0,
        DBROWFETCH_CALLEEALLOCATES = 1,
        DBROWFETCH_FORCEREFRESH = 2,
    };

    public enum _DBBINDING : int
    {
        DBBINDING_DEFAULT = 0,
        DBBINDING_VARIANT = 1,
        DBBINDING_ENTRYID = 2,
    };

    public enum tagDBBINDTYPE : int
    {
        DBBINDTYPE_DATA = 0,
        DBBINDTYPE_ENTRYID = 1,
        DBBDINTYPE_EITHER = 2,
        DBBINDTYPE_BOTH = 3,
    };

    public enum tagDBCOLUMNBINDOPTS : int
    {
        DBCOLUMNBINDOPTS_REPLACE = 0,
        DBCOLUMNBINDOPTS_ADD = 1,
    };

    public enum tagDBUPDATELOCK : int
    {
        DBUPDATELOCK_PESSIMISTIC = 0,
        DBUPDATELOCK_OPTIMISTIC = 1,
    };

    public enum tagDBCOLUMNDATA : int
    {
        DBCOLUMNDATA_UNCHANGED = 0,
        DBCOLUMNDATA_CHANGED = 1,
        DBCOLUMNDATA_UNKNOWN = 2,
    };

    public enum tagDBROWACTION : int
    {
        DBROWACTION_IGNORE = 0,
        DBROWACTION_UPDATE = 1,
        DBROWACTION_DELETE = 2,
        DBROWACTION_ADD = 3,
        DBROWACTION_LOCK = 4,
        DBROWACTION_UNLOCK = 5,
    };

    public enum tagDBUPDATEABLE : int
    {
        DBUPDATEABLE_UPDATEABLE = 0,
        DBUPDATEABLE_NOTUPDATEABLE = 1,
        DBUPDATEABLE_UNKNOWN = 2,
    };

    public enum tagDBEVENTWHATS : int
    {
        DBEVENT_CURRENT_ROW_CHANGED = 1,
        DBEVENT_CURRENT_ROW_DATA_CHANGED = 2,
        DBEVENT_NONCURRENT_ROW_DATA_CHANGED = 4,
        DBEVENT_SET_OF_COLUMNS_CHANGED = 8,
        DBEVENT_ORDER_OF_COLUMNS_CHANGED = 16,
        DBEVENT_SET_OF_ROWS_CHANGED = 32,
        DBEVENT_ORDER_OF_ROWS_CHANGED = 64,
        DBEVENT_METADATA_CHANGED = 128,
        DBEVENT_ASYNCH_OP_FINISHED = 256,
        DBEVENT_FIND_CRITERIA_CHANGED = 512,
    };

    public enum tagDBREASON : int
    {
        DBREASON_DELETED = 1,
        DBREASON_INSERTED = 2,
        DBREASON_MODIFIED = 3,
        DBREASON_REMOVEDFROMCURSOR = 4,
        DBREASON_MOVEDINCURSOR = 5,
        DBREASON_MOVE = 6,
        DBREASON_FIND = 7,
        DBREASON_NEWINDEX = 8,
        DBREASON_ROWFIXUP = 9,
        DBREASON_RECALC = 10,
        DBREASON_REFRESH = 11,
        DBREASON_NEWPARAMETERS = 12,
        DBREASON_SORTCHANGED = 13,
        DBREASON_FILTERCHANGED = 14,
        DBREASON_QUERYSPECCHANGED = 15,
        DBREASON_SEEK = 16,
        DBREASON_PERCENT = 17,
        DBREASON_FINDCRITERIACHANGED = 18,
        DBREASON_SETRANGECHANGED = 19,
        DBREASON_ADDNEW = 20,
        DBREASON_MOVEPERCENT = 21,
        DBREASON_BEGINTRANSACT = 22,
        DBREASON_ROLLBACK = 23,
        DBREASON_COMMIT = 24,
        DBREASON_CLOSE = 25,
        DBREASON_BULK_ERROR = 26,
        DBREASON_BULK_NOTTRANSACTABLE = 27,
        DBREASON_BULK_ABOUTTOEXECUTE = 28,
        DBREASON_CANCELUPDATE = 29,
        DBREASON_SETCOLUMN = 30,
        DBREASON_EDIT = 31,
        DBREASON_UNLOAD = 32,
    };

    public enum tagDBFINDTYPES : int
    {
        DB_FINDFIRST = 1,
        DB_FINDLAST = 2,
        DB_FINDNEXT = 3,
        DB_FINDPRIOR = 4,
        DB_FIND = 5,
    };

    public enum tagDBCLONEOPTS : int
    {
        DBCLONEOPTS_DEFAULT = 0,
        DBCLONEOPTS_SAMEROW = 1,
    };

    public enum tagDBCURSORPOPULATED : int
    {
        DBCURSORPOPULATED_FULLY = 0,
        DBCURSORPOPULATED_PARTIALLY = 1,
    };

    public enum tagDBEDITMODE : int
    {
        DBEDITMODE_NONE = 1,
        DBEDITMODE_UPDATE = 2,
        DBEDITMODE_ADD = 3,
    };

    public enum tagDBFINDFLAGS : int
    {
        DBFINDFLAGS_FINDNEXT = 1,
        DBFINDFLAGS_FINDPRIOR = 2,
        DBFINDFLAGS_INCLUDECURRENT = 4,
    };

    public enum OLE_NOTIFICATION : int
    {
        OLE_CHANGED,
        OLE_SAVED,
        OLE_CLOSED,
        OLE_RENAMED,
        OLE_CHANGED_STATE,
        OLE_CHANGED_ASPECT,
    };

    public enum OLE_OBJTYPE : int
    {
        OT_UNKNOWN = 0,
        OT_LINK = 1,
        OT_EMBEDDED = 2,
        OT_STATIC = 3,
        OT_OLE2 = 256,
    };

    public enum tagOLEUIPASTEFLAG : int
    {
        OLEUIPASTE_ENABLEICON = 2048,
        OLEUIPASTE_PASTEONLY = 0,
        OLEUIPASTE_PASTE = 512,
        OLEUIPASTE_LINKANYTYPE = 1024,
        OLEUIPASTE_LINKTYPE1 = 1,
        OLEUIPASTE_LINKTYPE2 = 2,
        OLEUIPASTE_LINKTYPE3 = 4,
        OLEUIPASTE_LINKTYPE4 = 8,
        OLEUIPASTE_LINKTYPE5 = 16,
        OLEUIPASTE_LINKTYPE6 = 32,
        OLEUIPASTE_LINKTYPE7 = 64,
        OLEUIPASTE_LINKTYPE8 = 128,
    };

    public enum SQLINTERVAL : int
    {
        SQL_IS_YEAR = 1,
        SQL_IS_MONTH = 2,
        SQL_IS_DAY = 3,
        SQL_IS_HOUR = 4,
        SQL_IS_MINUTE = 5,
        SQL_IS_SECOND = 6,
        SQL_IS_YEAR_TO_MONTH = 7,
        SQL_IS_DAY_TO_HOUR = 8,
        SQL_IS_DAY_TO_MINUTE = 9,
        SQL_IS_DAY_TO_SECOND = 10,
        SQL_IS_HOUR_TO_MINUTE = 11,
        SQL_IS_HOUR_TO_SECOND = 12,
        SQL_IS_MINUTE_TO_SECOND = 13,
    };

    public enum HASHALGORITHM_ENUM : int
    {
        DSA_HASH_ALGORITHM_SHA1,
        DSA_HASH_ALGORITHM_SHA256,
        DSA_HASH_ALGORITHM_SHA512,
    };

    public enum DSAFIPSVERSION_ENUM : int
    {
        DSA_FIPS186_2,
        DSA_FIPS186_3,
    };

    public enum BCRYPT_HASH_OPERATION_TYPE : int
    {
        BCRYPT_HASH_OPERATION_HASH_DATA = 1,
        BCRYPT_HASH_OPERATION_FINISH_HASH = 2,
    };

    public enum BCRYPT_MULTI_OPERATION_TYPE : int
    {
        BCRYPT_OPERATION_TYPE_HASH = 1,
    };

    public enum MdlTypecodes : int
    {
        TYPECODE_NONE = 0,
        TYPECODE_CHAR = 1,
        TYPECODE_SHORT = 2,
        TYPECODE_INT = 3,
        TYPECODE_LONG = 4,
        TYPECODE_FLOAT = 5,
        TYPECODE_DOUBLE = 6,
        TYPECODE_U_CHAR = 7,
        TYPECODE_U_SHORT = 8,
        TYPECODE_WCHAR = 8,
        TYPECODE_UNICODE = 8,
        TYPECODE_U_LONG = 9,
        TYPECODE_U_INT = 9,
        TYPECODE_MDL_FUNC = 10,
        TYPECODE_BOOL = 11,
        TYPECODE_ENUM = 12,
        TYPECODE_LONG64 = 13,
        TYPECODE_U_LONG64 = 14,
        TYPECODE_POINTER = 15,
        TYPECODE_VOID = 17,
        TYPECODE_STRUCT = 18,
        TYPECODE_UNION = 19,
        TYPECODE_INTERFACE = 19,
        TYPECODE_US_BITFIELD = 20,
        TYPECODE_UI_BITFIELD = 21,
        TYPECODE_SAFEARRAY = 22,
        TYPECODE_DISP_INTERFACE = 23,
        TYPECODE_COCLASS = 24,
        TYPECODE_FUNCTION = 44,
    };

    public enum WheelAction : int
    {
        WHEEL_ACTION_Zoom = 0,
        WHEEL_ACTION_Walk = 1,
        WHEEL_ACTION_PanZoom = 2,
        WHEEL_ACTION_PanLeftRight = 3,
        WHEEL_ACTION_PanUpDown = 4,
        WHEEL_ACTION_Slide = 5,
        WHEEL_ACTION_None = 6,
    };

    public enum DockPosition : int
    {
        DOCK_NOTDOCKED = 0,
        DOCK_LEFT = 1,
        DOCK_RIGHT = 2,
        DOCK_TOP = 3,
        DOCK_BOTTOM = 4,
        DOCK_NOTSHOWN = 5,
        DOCK_CENTER = 6,
        DOCK_FILL = 6,
    };

    public enum DockPriority : int
    {
        DOCKPRIORITY_CMDWINDOW = 1000,
        DOCKPRIORITY_STATUS = 950,
        DOCKPRIORITY_BASELEFT = 750,
        DOCKPRIORITY_BASERIGHT = 800,
        DOCKPRIORITY_BASETOP = 850,
        DOCKPRIORITY_BASEBOTTOM = 900,
        DOCKEXTENT_DONTCARE = 0,
        DOCKEXTENT_FULLWIDTHORHEIGHT = 1,
        DOCKEXTENT_SPECIFIED = 2,
        DOCKEXTENT_INVALIDREGION = 3,
    };

    public enum HideReasonCode : int
    {
        HideWindow = 0,
        Exiting = 1,
        WindowClose = 2,
        NoDgnFile = 3,
        UserClose = 4,
        MdlUnload = 5,
    };

    public enum MessageBoxIconType : int
    {
        NoSymbol = 0,
        Information = 1,
        Question = 2,
        Warning = 3,
        Critical = 4,
        BentleyB = 6,
        Pantone = 7,
        VBACompatibility = 8,
    };

    public enum MSInputQueuePos : int
    {
        INPUTQ_HEAD = 0,
        INPUTQ_EOQ = -1,
    };

    public enum ItemColorType : int
    {
        DITEM_COLORTYPE_BACKGROUND = 0,
        DITEM_COLORTYPE_FOREGROUND = 1,
        DITEM_COLORTYPE_TOPSHADOW = 2,
        DITEM_COLORTYPE_BOTTOMSHADOW = 3,
        DITEM_COLORTYPE_SELECT = 4,
        DITEM_COLORTYPE_AUXLABEL = 5,
        DITEM_COLORTYPE_SELECTTEXT = 6,
        DITEM_COLORTYPE_GRAYTEXT = 7,
        DITEM_COLORTYPE_FRAME = 8,
        DITEM_COLORTYPE_DLOGBACKGROUND = 9,
        DITEM_COLORTYPE_TRAVHIGHLIGHT = 10,
        DITEM_COLORTYPE_SCROLLBAR = 11,
        DITEM_COLORTYPE_TOOLTIPBG = 12,
        DITEM_COLORTYPE_TOOLTIPTEXT = 13,
        DITEM_COLORTYPE_LIGHT = 14,
        DITEM_COLORTYPE_DARKSHADOW = 15,
        DITEM_COLORTYPE_MAXCOLOR = 15,
        DITEM_COLORTYPE_NCOLORS = 64,
    };

    public enum FormatType : int
    {
        FMT_NONE = 0,
        FMT_ARRAY = -2147483648,
        FMT_SHORT = 2,
        FMT_LONG = 3,
        FMT_DPFP = 4,
        FMT_DOUBLE = 4,
        FMT_BYTE = 5,
        FMT_RAD5 = 9,
        FMT_UWORD = 10,
        FMT_USHORT = 10,
        FMT_UINT = 11,
        FMT_ULONG = 11,
        FMT_LONG64 = 16,
        FMT_TIME = 17,
        FMT_VOIDP = 18,
        FMT_WCHAR = 19,
        FMT_ULONG64 = 20,
        FMT_BOOL = 21,
        FMT_MIN = 0,
        FMT_MAX = 21,
    };

    public enum GuiDropSourceMsg : int
    {
        Begin,
        Query,
        PreCancel,
        PreDrop,
        Drop,
        End,
    };

    public enum GuiDragDropStatus : int
    {
        OK = 0,
        Drop,
        Cancel,
        Error = 32768,
    };

    public enum GuiDropTargetMsg : int
    {
        Enter,
        Over,
        Leave,
        Drop,
        QueryCursorUpdate,
    };

    public enum EditMenuItemStatus : int
    {
        Enable = 0,
        Disable = 1,
        Remove = 2,
    };

    public enum FocusOutType : int
    {
        None = 0,
        KeySwitch = 1,
        ButtonSwitch = 2,
        SetItem = 3,
        HideItem = 4,
        DisableItem = 5,
        SwitchDialog = 10,
        ApplyDialog = 11,
    };

    public enum MotionTransType : int
    {
        InItem = 0,
        Enter = 1,
        Exit = 2,
        InDialog = 3,
    };

    public enum StateChangingResponse : int
    {
        Allow,
        Disallow,
        Cancel,
    };

    public enum StateChangingType : int
    {
        ValueChange,
        NodeExpanding,
        NodeCollapsing,
        PopOpen,
        PopClose,
        ColumnShow,
        ColumnHide,
        TabShow,
        TabHide,
        NodeExpanded,
        NodeCollapsed,
    };

    public enum StateChangingCause : int
    {
        HandleClick,
        DoubleClick,
        Programmatic,
        Keystroke,
    };

    public enum AutoHideState : int
    {
        None,
        Pinned,
        UnpinnedCollapsed,
        UnpinnedExpanded,
    };

    public enum DockingState : int
    {
        Docking,
        Docked,
        Undocking,
        Undocked,
    };

    public enum DialogMessageType : int
    {
        DIALOG_MESSAGE_CREATE = 0,
        DIALOG_MESSAGE_INIT = 1,
        DIALOG_MESSAGE_DESTROY = 2,
        DIALOG_MESSAGE_UPDATE = 3,
        DIALOG_MESSAGE_RESIZE = 4,
        DIALOG_MESSAGE_CALCSIZE = 5,
        DIALOG_MESSAGE_FONTCHANGED = 6,
        DIALOG_MESSAGE_SYNCH = 7,
        DIALOG_MESSAGE_BUTTON = 8,
        DIALOG_MESSAGE_KEYSTROKE = 9,
        DIALOG_MESSAGE_FOCUSIN = 10,
        DIALOG_MESSAGE_FOCUSOUT = 11,
        DIALOG_MESSAGE_ITEMFOCUSIN = 12,
        DIALOG_MESSAGE_ITEMFOCUSOUT = 13,
        DIALOG_MESSAGE_CHILDDESTROYED = 14,
        DIALOG_MESSAGE_ACTIONBUTTON = 15,
        DIALOG_MESSAGE_USER = 16,
        DIALOG_MESSAGE_ANOTHEROPENED = 17,
        DIALOG_MESSAGE_ANOTHERCLOSED = 18,
        DIALOG_MESSAGE_STATECHANGED = 19,
        DIALOG_MESSAGE_HIDE = 20,
        DIALOG_MESSAGE_MINIMIZE = 21,
        DIALOG_MESSAGE_MAXIMIZE = 22,
        DIALOG_MESSAGE_ACTIVATE = 23,
        DIALOG_MESSAGE_BEFOREDESTROY = 24,
        DIALOG_MESSAGE_PREBUTTON = 25,
        DIALOG_MESSAGE_DOCKEDEXTENT = 26,
        DIALOG_MESSAGE_WINDOWMOVING = 28,
        DIALOG_MESSAGE_BEFOREUNDOCK = 29,
        DIALOG_MESSAGE_SCREENCHANGE = 30,
        DIALOG_MESSAGE_ATTACH = 31,
        DIALOG_MESSAGE_CREATED = 32,
        DIALOG_MESSAGE_MOTION = 33,
        DIALOG_MESSAGE_MOUSEWHEEL = 34,
        DIALOG_MESSAGE_DETACH = 35,
        DIALOG_MESSAGE_DROPTARGET = 36,
        DIALOG_MESSAGE_TITLECHANGED = 37,
        DIALOG_MESSAGE_RESTORED = 38,
        DIALOG_MESSAGE_DOCKINGSTATE = 39,
        DIALOG_MESSAGE_AUTOHIDESTATE = 40,
        DIALOG_MESSAGE_LAYOUT = 41,
        DIALOG_MESSAGE_HOOKRESOLVE = 49,
    };

    public enum FontIndex : int
    {
        FONT_INDEX_ACTIVE = -1,
        FONT_INDEX_SYSTEM = 0,
        FONT_INDEX_BORDER = 1,
        FONT_INDEX_DIALOG = 2,
        FONT_INDEX_BOLD = 3,
        FONT_INDEX_FIXED = 4,
        FONT_INDEX_FIXEDBOLD = 5,
        FONT_INDEX_ROTUP = 6,
        FONT_INDEX_ROTDOWN = 7,
        FONT_INDEX_MESSAGEBOX = 8,
        FONT_INDEX_TOOLTIP = 9,
        FONT_INDEX_ITALIC = 10,
        FONT_INDEX_BOLDITALIC = 11,
        FONT_INDEX_FIXEDITALIC = 12,
        FONT_INDEX_FIXEDBOLDITALIC = 13,
    };

    public enum GraphicsFileType : int
    {
        GRAPHICSFILE_WildCard = 0,
        GRAPHICSFILE_UStn = 1,
        GRAPHICSFILE_Sheet = 2,
        GRAPHICSFILE_HLine = 3,
        GRAPHICSFILE_DWG = 4,
        GRAPHICSFILE_DXF = 5,
        GRAPHICSFILE_DXB = 6,
        GRAPHICSFILE_IGES = 7,
        GRAPHICSFILE_CGM = 8,
        GRAPHICSFILE_RDL = 9,
        GRAPHICSFILE_TriForma = 10,
        GRAPHICSFILE_UStnV7 = 11,
        GRAPHICSFILE_CAD = 12,
        GRAPHICSFILE_CEL = 13,
        GRAPHICSFILE_3DStudio = 14,
        GRAPHICSFILE_DgnLib = 15,
        GRAPHICSFILE_OBJ = 16,
        GRAPHICSFILE_SKP = 17,
    };

    public enum LevelDisplayDialogMode : int
    {
        LEVELMODE_VIEW = 0,
        LEVELMODE_GLOBAL = 1,
        LEVELMODE_FREEZE = 2,
        LEVELMODE_VIEWPORT_FREEZE = 3,
        LEVELMODE_UNKNOWN = 4,
    };

    public enum LevelDisplayState : int
    {
        Off = 0,
        On = 1,
        VariesByView = 2,
    };

    public enum DialogBoxColor : int
    {
        CTLBG_COLOR_INDEX = -2,
        DEFAULT_COLOR_INDEX = -1,
        BLACK_INDEX = 0,
        BLUE_INDEX = 1,
        GREEN_INDEX = 2,
        CYAN_INDEX = 3,
        RED_INDEX = 4,
        MAGENTA_INDEX = 5,
        YELLOW_INDEX = 6,
        WHITE_INDEX = 7,
        LGREY_INDEX = 8,
        DGREY_INDEX = 9,
        MGREY_INDEX = 10,
        PSEUDOWHITE_INDEX = 11,
        DARKBLUE_INDEX = 12,
        TURQUOISE_INDEX = 13,
        DARKGREEN_INDEX = 14,
        MAROON_INDEX = 15,
        VIOLET_INDEX = 16,
        DARKYELLOW_INDEX = 17,
        PALEYELLOW_INDEX = 18,
        SECONDARYBG_INDEX = 19,
        SECONDARYFG_INDEX = 20,
        MAX_FIXED_COLORS = 32,
    };

    public enum ActiveBoolParams : int
    {
        ACTIVEPARAM_AREAMODE = 31,
        ACTIVEPARAM_CAPMODE = 34,
        ACTIVEPARAM_GRIDMODE = 35,
        ACTIVEPARAM_DIMCOMPAT = 40,
        ACTIVEPARAM_MLINECOMPAT = 41,
        ACTIVEPARAM_DESIGNFILE3D = 48,
        ACTIVEPARAM_DESIGNFILEREADONLY = 49,
        ACTIVEPARAM_SCALEDIMVALUES = 77,
        ACTIVEPARAM_SCALEANNOTATIONS = 78,
        ACTIVEPARAM_SCALEMLINEOFFSETS = 79,
    };

    public enum ActiveInt32Params : int
    {
        ACTIVEPARAM_LINESTYLE = 3,
        ACTIVEPARAM_DISPLAYPRIORITY = 75,
    };

    public enum ActiveStringParams : int
    {
        ACTIVEPARAM_COLOR_BY_NAME = 2,
        ACTIVEPARAM_CELLNAME = 15,
        ACTIVEPARAM_TERMINATOR = 18,
        ACTIVEPARAM_POINT = 25,
        ACTIVEPARAM_PATTERNCELL = 30,
        ACTIVEPARAM_LINESTYLENAME = 44,
        ACTIVEPARAM_DESIGNFILENAME = 50,
        ACTIVEPARAM_MASTERUNITLABEL = 51,
        ACTIVEPARAM_SUBUNITLABEL = 52,
        ACTIVEPARAM_CELLLIBFILENAME = 66,
        ACTIVEPARAM_TEXTSTYLE = 73,
        ACTIVEPARAM_LEVEL_FILTER = 74,
        ACTIVEPARAM_FONTNAME = 80,
    };

    public enum ActiveLineStyleParams : int
    {
        ACTIVEPARAM_LINESTYLEPARAMS = 45,
    };

    public enum ActiveGradientFillParams : int
    {
        ACTIVEPARAM_GRADIENTFILL = 100,
    };

    public enum RefBooleanParams : int
    {
        REFERENCE_DISPLAY = 1,
        REFERENCE_SNAP = 2,
        REFERENCE_LOCATE = 3,
        REFERENCE_SLOTACTIVE = 4,
        REFERENCE_SCALELINESTYLES = 5,
        REFERENCE_FILENOTFOUND = 6,
        REFERENCE_HIDDEN_LINE = 18,
        REFERENCE_DISPLAY_HIDDEN = 19,
        REFERENCE_SCALE_BY_UNITS = 24,
        REFERENCE_ANONYMOUS = 25,
        REFERENCE_DISPLAYRASTERREFS = 30,
        REFERENCE_USE_LIGHTS = 32,
        REFERENCE_DONOTNEST = 33,
        REFERENCE_CLIPBACK = 34,
        REFERENCE_CLIPFRONT = 35,
        REFERENCE_REDUNDANT = 38,
        REFERENCE_DONTDETACHONALL = 44,
        REFERENCE_DISPLAYFLAG = 45,
        REFERENCE_MODELNOTFOUND = 46,
        REFERENCE_RIGHTNOTGRANTED = 53,
        REFERENCE_PRINTCOLORADJUST = 54,
        REFERENCE_METADATAONLY = 55,
        REFERENCE_EXTENDED = 56,
        REFERENCE_PLOT_3D = 63,
        REFERENCE_TREAT_AS_ELEMENT = 67,
        REFERENCE_USEANNOTATIONSCALE = 71,
        REFERENCE_REVISIONNOTFOUND = 70,
        REFERENCE_USEVIEWFLAGS = 76,
        REFERENCE_LEVELCONTROLSDISPLAY = 79,
        REFERENCE_APPLICATIONLOCKED = 80,
    };

    public enum RefDoubleParams : int
    {
        REFERENCE_SCALE = 10,
        REFERENCE_SCALE_MASTERUNITS = 15,
        REFERENCE_SCALE_STORED = 23,
        REFERENCE_TRANSPARENCY = 62,
    };

    public enum RefStringParams : int
    {
        REFERENCE_FILENAME = 7,
        REFERENCE_DESCRIPTION = 8,
        REFERENCE_LOGICAL = 9,
        REFERENCE_ATTACHNAME = 13,
        REFERENCE_MODELNAME = 31,
        REFERENCE_DISPLAYFILENAME = 40,
        REFERENCE_DISPLAYATTACHNAME = 41,
        REFERENCE_DISPLAYMODELNAME = 42,
        REFERENCE_DWGBLOCKNAME = 43,
        REFERENCE_NAMEDGROUP = 60,
        REFERENCE_REVISION = 61,
        REFERENCE_RAWREVISION = 69,
        REFERENCE_SAVEDVIEWNAME = 77,
        REFERENCE_SYMBOLOGYTEMPLATE = 81,
    };

    public enum RefInt64Params : int
    {
        REFERENCE_ELEMENTID = 29,
        REFERENCE_SAVEDVIEWELEMENTID = 78,
    };

    public enum RefMatrixParams : int
    {
        REFERENCE_CLIP_ROTMATRIX = 47,
        REFERENCE_ROTATION = 11,
    };

    public enum RefIntegerParams : int
    {
        REFERENCE_CLIP_ROTATE = 20,
        REFERENCE_SOURCEMODELID = 27,
        REFERENCE_REFNUM = 28,
        REFERENCE_NESTDEPTH = 36,
        REFERENCE_RENDERMODE = 37,
        REFERENCE_LEVEL_OVERRIDES = 39,
        REFERENCE_LEVEL = 48,
        REFERENCE_DWGUNITMODE = 49,
        REFERENCE_HSVVALUEADJUST = 50,
        REFERENCE_HSVSATURATIONADJUST = 51,
        REFERENCE_BASENESTDEPTH = 52,
        REFERENCE_HSVHUESETTING = 57,
        REFERENCE_HSVADJUSTMENTFLAGS = 58,
        REFERENCE_DISPLAYPRIORITY = 59,
        REFERENCE_NESTOVERRIDES = 64,
        REFERENCE_NEWLEVELDISPLAY = 65,
        REFERENCE_GLOBALLINESTYLESCALES = 66,
        REFERENCE_SYNCHWITHNAMEDVIEWOPTION = 72,
        REFERENCE_ATTACHMETHOD = 73,
        REFERENCE_ACTIVATESTATUS = 74,
    };

    public enum SYSTEMCURSOR : int
    {
        CURSOR_APPSTARTING,
        CURSOR_ARROW,
        CURSOR_CROSS,
        CURSOR_HAND,
        CURSOR_HELP,
        CURSOR_IBEAM,
        CURSOR_NO,
        CURSOR_SIZEALL,
        CURSOR_SIZENESW,
        CURSOR_SIZENS,
        CURSOR_SIZENWSE,
        CURSOR_SIZEWE,
        CURSOR_UPARROW,
        CURSOR_WAIT,
    };

    public enum ActiveLocks : int
    {
        ACTIVELOCK_ASSOCIATION = 500,
        ACTIVELOCK_SNAP = 501,
        ACTIVELOCK_GRID = 502,
        ACTIVELOCK_UNIT = 503,
        ACTIVELOCK_ANGLE = 505,
        ACTIVELOCK_TEXTNODE = 506,
        ACTIVELOCK_AXIS = 507,
        ACTIVELOCK_SCALE = 508,
        ACTIVELOCK_GRAPHGROUP = 509,
        ACTIVELOCK_LEVEL = 510,
        ACTIVELOCK_FENCEOVERLAP = 511,
        ACTIVELOCK_FENCECLIP = 512,
        ACTIVELOCK_FENCEVOID = 513,
        ACTIVELOCK_CELLSTRETCH = 514,
        ACTIVELOCK_CONSTRUCTION = 516,
        ACTIVELOCK_ISOMETRIC = 517,
        ACTIVELOCK_DEPTH = 518,
        ACTIVELOCK_ISOPLANE = 519,
        ACTIVELOCK_USEANNOTATIONSCALE = 520,
        ACTIVELOCK_ACS = 521,
        ACTIVELOCK_CONSTRUCTIONSNAP = 522,
        ACTIVELOCK_SHAREDCELLS = 523,
    };

    public enum ActiveUInt32Params : int
    {
        ACTIVEPARAM_COLOR = 1,
        ACTIVEPARAM_LINEWEIGHT = 4,
        ACTIVEPARAM_LEVEL = 5,
        ACTIVEPARAM_FONT = 7,
        ACTIVEPARAM_GRIDREF = 9,
        ACTIVEPARAM_TEXTJUST = 13,
        ACTIVEPARAM_NODEJUST = 14,
        ACTIVEPARAM_LINELENGTH = 16,
        ACTIVEPARAM_TAGINCREMENT = 19,
        ACTIVEPARAM_TAB = 20,
        ACTIVEPARAM_KEYPOINT = 26,
        ACTIVEPARAM_CLASS = 33,
        ACTIVEPARAM_FILLMODE = 37,
        ACTIVEPARAM_FILLCOLOR = 46,
        ACTIVEPARAM_SNAPOVERRIDE = 47,
        ACTIVEPARAM_NEXTGGROUP = 59,
        ACTIVEPARAM_NUMSCREENS = 55,
        ACTIVEPARAM_FENCE = 56,
        ACTIVEPARAM_FENCEVIEW = 57,
        ACTIVEPARAM_NEXTTEXTNODE = 60,
        ACTIVEPARAM_GRIDORIENTATION = 70,
        ACTIVEPARAM_SNAPMODE = 501,
        ACTIVELOCK_SNAPMODE = 501,
    };

    public enum ActiveDPoint3dParams : int
    {
        ACTIVEPARAM_PATTERNDELTA = 27,
        ACTIVEPARAM_PATTERNANGLE = 28,
        ACTIVEPARAM_SCALE = 38,
        ACTIVEPARAM_GLOBALORIGIN = 54,
        ACTIVEPARAM_AREAPATTERNDELTA = 67,
        ACTIVEPARAM_AREAPATTERNANGLE = 68,
    };

    public enum ActiveDoubleParams : int
    {
        ACTIVEPARAM_ANGLE = 6,
        ACTIVEPARAM_GRIDUNITS = 8,
        ACTIVEPARAM_TEXTHEIGHT = 10,
        ACTIVEPARAM_TEXTWIDTH = 11,
        ACTIVEPARAM_UNITROUNDOFF = 12,
        ACTIVEPARAM_LINESPACING = 17,
        ACTIVEPARAM_STREAMDELTA = 21,
        ACTIVEPARAM_STREAMTOLERANCE = 22,
        ACTIVEPARAM_STREAMANGLE = 23,
        ACTIVEPARAM_STREAMAREA = 24,
        ACTIVEPARAM_PATTERNSCALE = 29,
        ACTIVEPARAM_AXISANGLE = 32,
        ACTIVEPARAM_GRIDRATIO = 36,
        ACTIVEPARAM_TERMINATORSCALE = 39,
        ACTIVEPARAM_AXISORIGIN = 42,
        ACTIVEPARAM_PATTERNTOLERANCE = 43,
        ACTIVEPARAM_SUBPERMASTER = 53,
        ACTIVEPARAM_UORPERSUB = 58,
        ACTIVEPARAM_TEXTSLANT = 61,
        ACTIVEPARAM_UORPERMASTER = 69,
        ACTIVEPARAM_GRIDANGLE = 71,
        ACTIVEPARAM_UNITROUNDRATIO = 72,
        ACTIVEPARAM_TRANSPARENCY = 76,
        ACTIVEPARAM_ANGLETOLERANCE = 81,
        ACTIVEPARAM_SCALETOLERANCE = 82,
    };

    public enum ButtonTrans : int
    {
        Up = 1,
        Down = 2,
        Timeout = 4,
        Motion = 8,
        Click = 16,
        StartDrag = 32,
        Undefined = 0,
    };

    public enum MdlApplicationClass : int
    {
        NoChange = -1,
        User = 0,
        MSRequired = 1,
        InitApp = 2,
        DGNApp = 3,
        UIServer = 4,
        PlotDriver = 5,
        AutoDGN = 6,
        StayResidentServer = 7,
        Managed = 8,
        LicenseApp = 9,
        RibbonProvider = 10,
    };

    public enum Workmode : int
    {
        WORKMODE_DGN = 0,
        WORKMODE_DWG = 1,
        WORKMODE_V7 = 2,
    };

    public enum IconStyle : int
    {
        ICON_STYLE_NORMAL = 0,
        ICON_STYLE_LGREY = 1,
        ICON_STYLE_DGREY = 2,
        ICON_STYLE_DISABLED = 3,
        ICON_STYLE_HIGHLIGHT = 4,
    };

    public enum SysColor : int
    {
        SYSCOLOR_FIXED_BASE = 0,
        SYSCOLOR_FIXED_BLACK = 0,
        SYSCOLOR_FIXED_BLUE = 1,
        SYSCOLOR_FIXED_GREEN = 2,
        SYSCOLOR_FIXED_CYAN = 3,
        SYSCOLOR_FIXED_RED = 4,
        SYSCOLOR_FIXED_MAGENTA = 5,
        SYSCOLOR_FIXED_YELLOW = 6,
        SYSCOLOR_FIXED_WHITE = 7,
        SYSCOLOR_FIXED_LGREY = 8,
        SYSCOLOR_FIXED_DGREY = 9,
        SYSCOLOR_FIXED_MGREY = 10,
        SYSCOLOR_FIXED_PSEUDOWHITE = 11,
        SYSCOLOR_FIXED_DARKBLUE = 12,
        SYSCOLOR_FIXED_TURQUOISE = 13,
        SYSCOLOR_FIXED_DARKGREEN = 14,
        SYSCOLOR_FIXED_MAROON = 15,
        SYSCOLOR_FIXED_VIOLET = 16,
        SYSCOLOR_FIXED_DARKYELLOW = 17,
        SYSCOLOR_BACKGROUND_PALEYELLOW = 18,
        SYSCOLOR_FIXED_MAXCOLORS = 32,
        SYSCOLOR_WINDOWS_BASE = 32,
        SYSCOLOR_WINDOWS_WINBACKGROUND = 32,
        SYSCOLOR_WINDOWS_WINTEXT = 33,
        SYSCOLOR_WINDOWS_MENU = 34,
        SYSCOLOR_WINDOWS_MENUTEXT = 35,
        SYSCOLOR_WINDOWS_SCROLLBAR = 36,
        SYSCOLOR_WINDOWS_BTNFACE = 37,
        SYSCOLOR_WINDOWS_BTNSHADOW = 38,
        SYSCOLOR_WINDOWS_BTNTEXT = 39,
        SYSCOLOR_WINDOWS_BTNHIGHLIGHT = 40,
        SYSCOLOR_WINDOWS_GRAYTEXT = 41,
        SYSCOLOR_WINDOWS_HIGHLIGHT = 42,
        SYSCOLOR_WINDOWS_HIGHLIGHTTEXT = 43,
        SYSCOLOR_WINDOWS_WINFRAME = 44,
        SYSCOLOR_WINDOWS_DESKTOP = 45,
        SYSCOLOR_WINDOWS_APPWORKSPACE = 46,
        SYSCOLOR_WINDOWS_TITLEBAR = 47,
        SYSCOLOR_WINDOWS_ITITLEBAR = 48,
        SYSCOLOR_WINDOWS_TITLEBARTEXT = 49,
        SYSCOLOR_WINDOWS_ITITLEBARTEXT = 50,
        SYSCOLOR_WINDOWS_BORDER = 51,
        SYSCOLOR_WINDOWS_IBORDER = 52,
        SYSCOLOR_WINDOWS_DLOGBACKGROUND = 53,
        SYSCOLOR_WINDOWS_TOOLTIPBG = 54,
        SYSCOLOR_WINDOWS_TOOLTIPTEXT = 55,
        SYSCOLOR_WINDOWS_LIGHT = 56,
        SYSCOLOR_WINDOWS_DARKSHADOW = 57,
        SYSCOLOR_WINDOWS_GRADIENTTITLEBAR = 58,
        SYSCOLOR_WINDOWS_GRADIENTITITLEBAR = 59,
        SYSCOLOR_WINDOWS_MENUBAR = 60,
        SYSCOLOR_WINDOWS_MENUHILIGHT = 61,
        SYSCOLOR_WINDOWS_TOOLBARAREABG = 62,
        SYSCOLOR_WINDOWS_DIALOGAREABG = 63,
        SYSCOLOR_WINDOWS_STATUSBAR = 64,
        SYSCOLOR_WINDOWS_RIBBONBG = 65,
        SYSCOLOR_WINDOWS_MAXCOLORS = 64,
        SYSCOLOR_MAXCOLOR = 96,
        SYSCOLOR_NCOLORS = 96,
    };

    public enum GuiDrawMode : int
    {
        XORDRAW = 6,
        TEMPERASE = 4,
        SET_ALLOWBGCOLOR = 7,
        HILITE_XORDRAW = 8,
        XORINCLUDEBACKSTORE = 9,
        HILITE_XORINCLUDEBACKSTORE = 10,
    };

    public enum MstnCapabilityValues : int
    {
        CAPABILITY_ELEMENT_ASSOCIATION = 0,
        CAPABILITY_ELEMENT_LOCK = 1,
        CAPABILITY_ELEMENT_CLASS = 2,
        CAPABILITY_ELEMENT_TRANSPARENCY = 3,
        CAPABILITY_ELEMENT_PRIORITY = 4,
        CAPABILITY_BYCELL = 5,
        CAPABILITY_BYLEVEL = 6,
        CAPABILITY_ELEMENT_VIEWINDEPENDENT = 7,
        CAPABILITY_TYPE2_CELL = 21,
        CAPABILITY_SHAREDCELLS_FROM_ATTACHED_LIB = 22,
        CAPABILITY_SHAREDCELLS_FROM_REFERENCES = 23,
        CAPABILITY_DGN_BLOCKS = 24,
        CAPABILITY_CELLLIB_ALLOWUPGRADEV7 = 25,
        CAPABILITY_CELLS_ATTRIBUTE_CHANGES = 26,
        CAPABILITY_MASK_CLIP = 41,
        CAPABILITY_SELF_REFERENCE = 42,
        CAPABILITY_REF_SCALELINESTYLE = 43,
        CAPABILITY_REF_AUX_INFO = 44,
        CAPABILITY_REF_FROM_URL = 45,
        CAPABILITY_REF_DISP_PER_VIEW = 46,
        CAPABILITY_REF_SAVE_PATH_REL = 47,
        CAPABILITY_REF_RASTERDISPLAY_OFF = 48,
        CAPABILITY_REF_ADJUSTCOLORS = 49,
        CAPABILITY_REF_NONDEFAULT_MODEL = 50,
        CAPABILITY_REF_NESTING_OPTIONS = 51,
        CAPABILITY_REFERENCE_ATTACHLEVEL = 52,
        CAPABILITY_REFERENCE_VIEWLEVELDISPLAY = 53,
        CAPABILITY_REFERENCE_SHEET_LOGICALNAME = 54,
        CAPABILITY_REFERENCE_GEOREPROJECT = 55,
        CAPABILITY_REFERENCE_HIDDENLINE = 56,
        CAPABILITY_REFERENCE_3DTO2D = 57,
        CAPABILITY_REFERENCE_V8 = 58,
        CAPABILITY_REFERENCE_DWG = 59,
        CAPABILITY_REFERENCE_ALLOW_DXF = 60,
        CAPABILITY_REFERENCE_LINESTYLESCALE = 61,
        CAPABILITY_REFERENCE_TRANSPARENCY = 62,
        CAPABILITY_REFERENCE_PRIORITY = 63,
        CAPABILITY_REFERENCE_DISPLAYOVERRIDES = 64,
        CAPABILITY_REFERENCE_NEWLEVELDISPLAY = 65,
        CAPABILITY_ACTIVATE_REFERENCE_INTERNAL = 66,
        CAPABILITY_ACTIVATE_REFERENCE_EXTERNAL = 67,
        CAPABILITY_REFERENCE_ANNOTATIONSCALE = 68,
        CAPABILITY_TYPE90_ALL = 101,
        CAPABILITY_TYPE87_RASTER = 102,
        CAPABILITY_RASTER_TINT = 103,
        CAPABILITY_RASTER_TRANSP_FULL_CONTROL = 104,
        CAPABILITY_RASTER_BACKGROUND = 105,
        CAPABILITY_RASTER_PROJECT = 106,
        CAPABILITY_RASTER_DISP_GAMMA = 107,
        CAPABILITY_RASTER_PRINT_GAMMA = 108,
        CAPABILITY_RASTER_PRINT = 109,
        CAPABILITY_RASTER_ALL_TYPES = 110,
        CAPABILITY_RASTER_INVERT = 111,
        CAPABILITY_RASTER_APPLYROTATIONANDAFFINITY = 112,
        CAPABILITY_RASTER_GEOREFERENCEPRIORITY = 113,
        CAPABILITY_RASTER_PHOTOMATCH = 114,
        CAPABILITY_DEFAULT_FONTS = 131,
        CAPABILITY_TEXT_FONTS = 132,
        CAPABILITY_TEXT_FONTS_RSC = 133,
        CAPABILITY_TEXT_FONTS_SHX = 134,
        CAPABILITY_TEXT_FONTS_TRUETYPE = 135,
        CAPABILITY_TEXT_SHXBIGFONTS = 136,
        CAPABILITY_TEXT_HEIGHT = 137,
        CAPABILITY_TEXT_WIDTH = 138,
        CAPABILITY_TEXT_COLOR = 139,
        CAPABILITY_TEXT_JUSTIFICATION = 140,
        CAPABILITY_TEXT_JUSTIFICATION_LT = 141,
        CAPABILITY_TEXT_JUSTIFICATION_LC = 142,
        CAPABILITY_TEXT_JUSTIFICATION_LB = 143,
        CAPABILITY_TEXT_JUSTIFICATION_LMT = 144,
        CAPABILITY_TEXT_JUSTIFICATION_LMC = 145,
        CAPABILITY_TEXT_JUSTIFICATION_LMB = 146,
        CAPABILITY_TEXT_JUSTIFICATION_CT = 147,
        CAPABILITY_TEXT_JUSTIFICATION_CC = 148,
        CAPABILITY_TEXT_JUSTIFICATION_CB = 149,
        CAPABILITY_TEXT_JUSTIFICATION_RMT = 150,
        CAPABILITY_TEXT_JUSTIFICATION_RMC = 151,
        CAPABILITY_TEXT_JUSTIFICATION_RMB = 152,
        CAPABILITY_TEXT_JUSTIFICATION_RT = 153,
        CAPABILITY_TEXT_JUSTIFICATION_RC = 154,
        CAPABILITY_TEXT_JUSTIFICATION_RB = 155,
        CAPABILITY_TEXT_NODEJUSTIFICATION = 156,
        CAPABILITY_TEXT_BOLD = 157,
        CAPABILITY_TEXT_UNDERLINE = 158,
        CAPABILITY_TEXT_UNDERLINE_STYLE = 159,
        CAPABILITY_TEXT_UNDERLINE_COLOR = 160,
        CAPABILITY_TEXT_UNDERLINE_WEIGHT = 161,
        CAPABILITY_TEXT_UNDERLINE_OFFSET = 162,
        CAPABILITY_TEXT_OVERLINE = 163,
        CAPABILITY_TEXT_OVERLINE_STYLE = 164,
        CAPABILITY_TEXT_OVERLINE_COLOR = 165,
        CAPABILITY_TEXT_OVERLINE_WEIGHT = 166,
        CAPABILITY_TEXT_OVERLINE_OFFSET = 167,
        CAPABILITY_TEXT_VERTICAL = 168,
        CAPABILITY_TEXT_ITALICS = 169,
        CAPABILITY_TEXT_SLANTANGLE = 170,
        CAPABILITY_TEXT_BACKGROUND = 171,
        CAPABILITY_TEXT_BACKGROUND_BORDER_X = 172,
        CAPABILITY_TEXT_BACKGROUND_BORDER_Y = 173,
        CAPABILITY_TEXT_BACKGROUND_COLOR = 174,
        CAPABILITY_TEXT_BACKGROUND_FILL_COLOR = 175,
        CAPABILITY_TEXT_BACKGROUND_STYLE = 176,
        CAPABILITY_TEXT_BACKGROUND_WEIGHT = 177,
        CAPABILITY_TEXT_SUPERSCRIPT = 178,
        CAPABILITY_TEXT_SUBSCRIPT = 179,
        CAPABILITY_TEXT_LINELENGTH = 180,
        CAPABILITY_TEXT_LINESPACING = 181,
        CAPABILITY_TEXT_LINESPACINGTYPE = 182,
        CAPABILITY_TEXT_INTERCHARACTERSPACING = 183,
        CAPABILITY_TEXT_FIXEDSPACING = 184,
        CAPABILITY_TEXT_FRACTIONS = 185,
        CAPABILITY_TEXT_LINEOFFSET_X = 186,
        CAPABILITY_TEXT_LINEOFFSET_Y = 187,
        CAPABILITY_TEXT_FULLJUSTIFICATION = 188,
        CAPABILITY_TEXT_BACKWARDS = 189,
        CAPABILITY_TEXT_UPSIDEDOWN = 190,
        CAPABILITY_TEXT_AUTOSTACKFRACTIONS = 191,
        CAPABILITY_TEXT_TTF_VERTICAL = 192,
        CAPABILITY_PLACETEXT_DISPLAY_TOGGLES = 193,
        CAPABILITY_TEXTSTYLE_ACTIVE_DGNSETTINGS = 194,
        CAPABILITY_TEXTSTYLE_ACTIVE_DWGSETTINGS = 195,
        CAPABILITY_TEXTSTYLE_STYLE_DGNSETTINGS = 196,
        CAPABILITY_TEXTSTYLE_STYLE_DWGSETTINGS = 197,
        CAPABILITY_TEXTSTYLE_ALLOW_CREATE = 198,
        CAPABILITY_TEXTSTYLE_ALLOW_DELETE = 199,
        CAPABILITY_TEXTSTYLE_ALLOW_MODIFY = 200,
        CAPABILITY_TEXTSTYLE_NOSTYLE = 201,
        CAPABILITY_WORDPROCESSOR_USE_RSCFRACTIONS = 251,
        CAPABILITY_WORDPROC_FIELD_MODELPROPERTIES = 252,
        CAPABILITY_WORDPROC_FIELD_SIGNATUREPLACEHOLDER = 253,
        CAPABILITY_WORDPROC_FIELD_LINKPLACEHOLDER = 254,
        CAPABILITY_WORDPROC_FIELD_CELLPLACEHOLDER = 255,
        CAPABILITY_WORDPROC_FIELD_PRINTPROPERTIES = 256,
        CAPABILITY_TAGS_COPY_WITH_BASE = 271,
        CAPABILITY_TAG_NOCELL_ELEMS = 272,
        CAPABILITY_IGDS_LINESTYLE = 301,
        CAPABILITY_CREATE_POINT_STYLE = 302,
        CAPABILITY_CREATE_COMPOUND_STYLE = 303,
        CAPABILITY_DWGINCOMPATIBLE_LINESTYLES = 304,
        CAPABILITY_ALLOW_NON_SHX_STYLES = 305,
        CAPABILITY_LINESTYLE_SCALEDWIDTH = 306,
        CAPABILITY_LINESTYLE_CREATE_STDTXT = 307,
        CAPABILITY_LINESTYLE_CREATE_TEXTSTYLE = 308,
        CAPABILITY_LINESTYLE_SCALE_PER_MODEL = 309,
        CAPABILITY_DIMENSION_NOSTYLE = 331,
        CAPABILITY_DIMENSION_CUSTOM_PREFIX = 332,
        CAPABILITY_DIMENSION_DIMLINE_LEVEL = 333,
        CAPABILITY_DIMENSION_ARBITARY = 334,
        CAPABILITY_DIMENSION_TERM_ATTRIBS = 335,
        CAPABILITY_DIMENSION_TERM_SYMBOL = 336,
        CAPABILITY_DIMENSION_TERM_FIRST = 337,
        CAPABILITY_DIMENSION_TERM_JOINT = 338,
        CAPABILITY_DIMENSION_WORKING_UNITS = 339,
        CAPABILITY_DIMENSION_METRIC_FORMAT = 340,
        CAPABILITY_DIMENSION_SECONDARY_ZEROS = 341,
        CAPABILITY_DIMENSION_ALT_LABEL = 342,
        CAPABILITY_DIMENSION_ARC_ABOVE = 343,
        CAPABILITY_DIMENSION_ARC_LENGTH = 344,
        CAPABILITY_DIMENSION_CELLTERM_HEIGHT = 345,
        CAPABILITY_DIMENSION_UNDERLINE_TEXT = 346,
        CAPABILITY_DIMENSION_BALLNCHAIN = 347,
        CAPABILITY_DIMENSION_UNIT_LABEL = 348,
        CAPABILITY_DIMENSION_UNIT_FORMAT = 349,
        CAPABILITY_DIMENSION_TEXT_WEIGHT = 350,
        CAPABILITY_DIMENSION_LSTYLE_OVERRIDE = 351,
        CAPABILITY_DIMENSION_CAPSULE_FRAME = 352,
        CAPABILITY_DIMENSION_CUSTOM_SYMBOLS = 353,
        CAPABILITY_DIMENSION_TEXT_MARGIN = 354,
        CAPABILITY_DIMENSION_MINIMUM_LEADER = 355,
        CAPABILITY_DIMENSION_FONT = 356,
        CAPABILITY_DIMENSION_TEXT_WIDTH = 357,
        CAPABILITY_DIMENSION_NEG_EXTOFFSET = 358,
        CAPABILITY_DIMENSION_TEXT_HEIGHT_SCALE = 359,
        CAPABILITY_DIMENSION_TERM_SIDES = 360,
        CAPABILITY_DIMENSION_USE_MINLEADER = 361,
        CAPABILITY_DIMENSION_TEXT_JUSTIFICATION = 362,
        CAPABILITY_DIMENSION_WIDEFIT_TEXTABOVE = 363,
        CAPABILITY_DIMENSION_INCLINED_FIT = 364,
        CAPABILITY_DIMENSION_FRACTION_SCALE = 365,
        CAPABILITY_DIMENSION_DIN = 366,
        CAPABILITY_DIMENSION_TOL_MARGINS = 367,
        CAPABILITY_NOTE_ELBOWLENGTH = 368,
        CAPABILITY_NOTE_LEFTMARGIN = 369,
        CAPABILITY_NOTE_LOWERMARGIN = 370,
        CAPABILITY_NOTE_ALL_FRAME_TYPES = 371,
        CAPABILITY_NOTE_MANUALATTACHMENT = 372,
        CAPABILITY_NOTE_MANUALJUSTIFICATION = 373,
        CAPABILITY_NOTE_FRAME_SCALE = 374,
        CAPABILITY_DIMSTYLE_REQUIRESTANDARD = 375,
        CAPABILITY_DIMENSION_ORDDIM_DATUM = 376,
        CAPABILITY_MODEL_CREATE_DESIGN = 431,
        CAPABILITY_MODEL_CREATE_SHEET = 432,
        CAPABILITY_MODEL_WITHOUT_VIEWGROUP = 433,
        CAPABILITY_MODEL_CREATE_2D = 434,
        CAPABILITY_MODEL_CREATE_3D = 435,
        CAPABILITY_MODEL_CHANGE_TYPE = 436,
        CAPABILITY_MODEL_DELETE_DESIGN = 437,
        CAPABILITY_MODEL_DELETE_SHEET = 438,
        CAPABILITY_MODEL_DELETE_LAST_DESIGN = 439,
        CAPABILITY_MODEL_DELETE_LAST_SHEET = 440,
        CAPABILITY_MODEL_EDIT_PROPERTIES_DESIGN = 441,
        CAPABILITY_MODEL_EDIT_PROPERTIES_SHEET = 442,
        CAPABILITY_NONDEFAULTMODEL_ANNOTATION_SCALE = 443,
        CAPABILITY_NONDEFAULTMODEL_ANNOTATION_SCALE_LOCK = 444,
        CAPABILITY_MODEL_DISPLAY_SHEETLAYOUT = 445,
        CAPABILITY_MODEL_PLACE_AS_CELL = 446,
        CAPABILITY_MODEL_UNITS_IN_SHEET = 447,
        CAPABILITY_MODEL_CREATE_DRAWING = 458,
        CAPABILITY_MODEL_DELETE_DRAWING = 459,
        CAPABILITY_MODEL_DELETE_LAST_DRAWING = 450,
        CAPABILITY_MODEL_EDIT_PROPERTIES_DRAWING = 451,
        CAPABILITY_MODEL_LINESTYLE_SCALE_OPTIONS = 452,
        CAPABILITY_MODEL_SHEET_INDEXING = 453,
        CAPABILITY_VIEWGROUP_CREATION = 471,
        CAPABILITY_VIEWGROUP_DELETION = 472,
        CAPABILITY_VIEWGROUP_UPDATE = 473,
        CAPABILITY_VIEW_ROTATE_SHEET_MODEL_VIEW = 474,
        CAPABILITY_VIEW_CLIP = 475,
        CAPABILITY_SAVEDVIEWS_CREATE_FOR_SHEETS = 476,
        CAPABILITY_SAVEDVIEWS_APPLY_TO_SHEETS = 477,
        CAPABILITY_SAVEDVIEWS_DELETE_FOR_SHEETS = 478,
        CAPABILITY_SAVEDVIEWS_PROPS_FOR_SHEETS = 479,
        CAPABILITY_SAVEDVIEWS_UPDATE_FOR_SHEETS = 480,
        CAPABILITY_VIEWATTRIBUTES = 481,
        CAPABILITY_MULTILINE_NOSTYLE = 501,
        CAPABILITY_MULTILINE_REQUIRESTANDARDSTYLE = 502,
        CAPABILITY_MULTILINE_ALLOW_ACTIVE = 503,
        CAPABILITY_MULTILINE_LINESTYLEMODS = 504,
        CAPABILITY_MULTILINE_CAPSYMBOLOGY = 505,
        CAPABILITY_MULTILINE_WEIGHTS = 506,
        CAPABILITY_MULTILINE_CLASS = 507,
        CAPABILITY_LEVELS_GLOBALDISPLAY = 521,
        CAPABILITY_LEVELS_GLOBALFREEZE = 522,
        CAPABILITY_LEVELS_NUMBERS = 523,
        CAPABILITY_LEVELS_DESCRIPTION = 524,
        CAPABILITY_LEVELS_VPFREEZE = 525,
        CAPABILITY_LEVELS_OVERRIDES_PER_LEVEL = 526,
        CAPABILITY_LEVELS_OVERRIDE_SYMBOLOGY = 527,
        CAPABILITY_LEVEL_LIBRARY_ATTACH = 528,
        CAPABILITY_LEVEL_LIBRARY_DETACH = 529,
        CAPABILITY_LEVELS_CREATE = 530,
        CAPABILITY_LEVELS_ALLOW_DELETE = 531,
        CAPABILITY_LEVELS_ALLOW_CREATE = 532,
        CAPABILITY_LEVELS_VIEWDISPLAY = 533,
        CAPABILITY_LEVELS_PRIORITY = 534,
        CAPABILITY_LEVELS_TRANSPARENCY = 535,
        CAPABILITY_LEVELS_ELEMENT_ACCESS = 536,
        CAPABILITY_LEVELS_MATERIAL = 537,
        CAPABILITY_LEVELS_USE_AUTO_GENERATED_NUMBERS = 538,
        CAPABILITY_LEVELS_OVERRIDE_LSTYLE_PROPERTIES = 539,
        CAPABILITY_LEVEL_ALLOW_LEVELMANAGER = 540,
        CAPABILITY_CUSTOM_KEYPOINTS = 561,
        CAPABILITY_UNITS_DGNFORMAT = 582,
        CAPABILITY_UNITS_DGNCOORDREADOUT = 583,
        CAPABILITY_UNITS_SUB = 584,
        CAPABILITY_UNITS_LABEL = 585,
        CAPABILITY_UNITS_SCIENTIFIC_ACCURACY = 586,
        CAPABILITY_DGNLINK_MULTILINKS_PER_ELEM = 601,
        CAPABILITY_DGNLINK_NONDGN_REGIONLINKS = 602,
        CAPABILITY_DGNLINK_FOLLOW_TOLINKSET = 603,
        CAPABILITY_DGNLINK_FOLLOW_TOCONFIGVAR = 604,
        CAPABILITY_COLORTABLE = 621,
        CAPABILITY_COLOR_SHOW_INDEXEDTAB = 622,
        CAPABILITY_COLOR_SHOW_TRUECOLORTAB = 623,
        CAPABILITY_COLOR_SHOW_BOOKTAB = 624,
        CAPABILITY_COLOR_SHOW_GRADIENTTAB = 625,
        CAPABILITY_COLOR_MULTI_GRADIENT = 626,
        CAPABILITY_COLOR_SHOW_BACKGROUND = 627,
        CAPABILITY_UI_LOADFROMACTIVEFILE = 641,
        CAPABILITY_UI_IGNOREMENUSFROMRSCMODFILE = 642,
        CAPABILITY_UI_IGNOREMENUSFROMDGNLIBS = 643,
        CAPABILITY_ELEMENTTEMPLATE_HONORLEVELLOCK = 644,
        CAPABILITY_ELEMENTTEMPLATE_HONORELEMENTLOCK = 645,
        CAPABILITY_UI_ALWAYSSHOWADMINWORKFLOW = 646,
        CAPABILITY_DESIGN_HISTORY = 681,
        CAPABILITY_DDDESIGN = 682,
        CAPABILITY_STANDARDSCHECKER = 683,
        CAPABILITY_FILE_PROTECT = 701,
        CAPABILITY_DIGITAL_SIGNATURES = 702,
        CAPABILITY_MATERIAL_ASSIGNBYLEVELCOLOR = 721,
        CAPABILITY_LIGHTING_ALLOWLONGLIGHTNAMES = 722,
        CAPABILITY_PARASOLID = 751,
        CAPABILITY_CURVE_IN_CMPLXCH = 752,
        CAPABILITY_BSPLINE_DISPLAY_CONTROL = 753,
        CAPABILITY_GRAPHIC_GROUP = 801,
        CAPABILITY_NAMED_GROUPS = 802,
        CAPABILITY_CELLPATTERN = 821,
        CAPABILITY_DISPLAY_STYLE_EDITING = 831,
        CAPABILITY_ITEMTYPE_ALLOW_MODIFY = 861,
        CAPABILITY_ITEMTYPE_ALLOW_IMPORT = 862,
        CAPABILITY_ITEMTYPE_ALLOW_NONDWG_LIBRARIES = 863,
        CAPABILITY_ITEMTYPE_ALLOW_UNITS = 864,
        CAPABILITY_ITEMTYPE_ALLOW_CHANGE_PROPERTY_TYPE = 865,
        CAPABILITY_ITEMTYPE_ALLOW_ARRAYS = 866,
        CAPABILITY_ITEMTYPE_ALLOW_RENAME_USED_ITEMTYPES = 867,
        CAPABILITY_ITEMTYPE_ALLOW_ATTACH_TO_NONCELL = 868,
        CAPABILITY_ITEMTYPE_ALLOW_CREATE_PROPERTY_TYPES = 869,
        CAPABILITY_ITEMTYPE_ALLOW_ITEM_NAME = 870,
        CAPABILITY_REPORTS_ALLOW_MODIFY = 881,
        CAPABILITY_REPORTS_ALLOW_IMPORT = 882,
        CAPABILITY_REPORTS_ASSOCIATION = 883,
        CAPABILITY_CONSTRAINTS = 951,
        CAPABILITY_DETAILINGSYMBOLS = 971,
        CAPABILITY_POINTCLOUD = 991,
        CAPABILITY_TERRAINMODEL = 1011,
        CAPABILITY_SAVEDVIEW = 1031,
        CAPABILITY_REALITYMESH = 1051,
        CAPABILITY_PRINT3D = 1071,
        CAPABILITY_MODELINGMESH = 1091,
        CAPABILITY_IMPORTRFA = 1111,
        CAPABILITY_PICKLIST = 1131,
        CAPABILITY_ITEMTYPEIMPORTEXPORT = 1151,
        CAPABILITY_COMPONENTMODEL = 1171,
        CAPABILITY_SCALE_AXIS_INDEP = 2001,
        CAPABILITY_LEVEL_PLOT = 2002,
        CAPABILITY_TABLE_DESCRIPTION = 2003,
        CAPABILITY_GRID_ORIENTATION = 2004,
        CAPABILITY_INVISGEOM_BYELEMENT = 2005,
        CAPABILITY_MODIFY_SELECTSERVER = 2006,
        CAPABILITY_FENCE_NAME = 2007,
        CAPABILITY_LARGE_DESIGN_PLANE = 2008,
        MAX_CAPABILITIES,
    };

    public enum AngularUnits : int
    {
        ANGULAR_UNITS_DecimalDegrees = 0,
        ANGULAR_UNITS_DegreesMinutesSeconds = 1,
        ANGULAR_UNITS_Gradians = 2,
        ANGULAR_UNITS_Radians = 3,
        ANGULAR_UNITS_Bearing = 4,
    };

    public enum CellLibAsyncMsgType : int
    {
        CELL_LIBRARY_MSG_ERROR = -1,
        CELL_LIBRARY_PRE_ATTACH = 0,
        CELL_LIBRARY_POST_ATTACH = 1,
        CELL_LIBRARY_PRE_DETACH = 2,
        CELL_LIBRARY_POST_DETACH = 3,
        CELL_LIBRARY_PRE_CREATE = 4,
        CELL_LIBRARY_POST_CREATE = 5,
    };

    public enum CellLibraryOptions : int
    {
        CELL_LIBRARY_OPT_None = 0,
        CELL_LIBRARY_OPT_Include3d = 1,
        CELL_LIBRARY_OPT_IncludeAllLibraries = 2,
        CELL_LIBRARY_OPT_IncludeParametric = 4,
        CELL_LIBRARY_OPT_IncludeNonParametric = 8,
        CELL_LIBRARY_OPT_IncludeShared = 16,
    };

    public enum TextStyleChangeType : int
    {
        TEXTSTYLE_CHANGE_ADD = 1,
        TEXTSTYLE_CHANGE_DELETE = 2,
        TEXTSTYLE_CHANGE_MODIFY = 3,
        TEXTSTYLE_CHANGE_DELETEUNUSED = 4,
        TEXTSTYLE_CHANGE_BEFORE_ADD = 10,
        TEXTSTYLE_CHANGE_BEFORE_DELETE = 11,
        TEXTSTYLE_CHANGE_BEFORE_MODIFY = 12,
    };

    public enum DimensionStyleChangeType : int
    {
        DIMSTYLE_TABLE_CHANGE = 1,
        DIMSTYLE_CHANGE_ACTIVE = 2,
        DIMSTYLE_CHANGE_PREACTIVE = 3,
        DIMSTYLE_CHANGE_SETTINGS = 4,
    };

    public enum CompressType : int
    {
        PRE_COMPRESS_DGNFILE = 1,
        POST_COMPRESS_DGNFILE = 2,
    };

    public enum MlineCapFlags : int
    {
        MLINE_CAPFLAG_None = 0,
        MLINE_CAPFLAG_ColorBySegment = 1,
    };

    public enum ReferenceActivateStatus : int
    {
        REFERENCE_ACTIVATE_ReadOnly = 0,
        REFERENCE_ACTIVATE_Activated = 1,
        REFERENCE_ACTIVATE_WriteLocked = 2,
    };

    public enum CmdClassEnum : int
    {
        CMDCLASS_INHERIT = 0,
        CMDCLASS_PLACEMENT = 1,
        CMDCLASS_VIEWING = 2,
        CMDCLASS_FENCE = 3,
        CMDCLASS_PARAMETERS = 4,
        CMDCLASS_LOCKS = 5,
        CMDCLASS_MACROCMD = 6,
        CMDCLASS_MANIPULATION = 7,
        CMDCLASS_SHOW = 8,
        CMDCLASS_PLOT = 9,
        CMDCLASS_NEWFILE = 10,
        CMDCLASS_MEASURE = 11,
        CMDCLASS_INPUT = 12,
        CMDCLASS_CELLLIB = 13,
        CMDCLASS_FILEDESIGN = 14,
        CMDCLASS_COMPRESS = 15,
        CMDCLASS_REFERENCE = 16,
        CMDCLASS_DATABASE = 17,
        CMDCLASS_DIMENSION = 18,
        CMDCLASS_LOCATE = 19,
        CMDCLASS_TUTCLASS = 20,
        CMDCLASS_WORKINGSET = 21,
        CMDCLASS_ELEMENTLIST = 22,
        CMDCLASS_UNDO = 23,
        CMDCLASS_SUBPROCESS = 24,
        CMDCLASS_VIEWPARAM = 25,
        CMDCLASS_VIEWIMMED = 26,
        CMDCLASS_WINDOWMAN = 27,
        CMDCLASS_DIALOGMAN = 28,
        CMDCLASS_INPUTGEN = 29,
        CMDCLASS_DIALOGOPEN = 30,
        CMDCLASS_LEVEL = 31,
        CMDCLASS_DEFAULTCMD = 32,
        CMDCLASS_REPORTCMD = 33,
        CMDCLASS_SELECTCMD = 34,
    };

    public enum MSQueueEntryTypes : int
    {
        RAWBUTTON = 800,
        RAWKEYSTROKE = 801,
        RAWICONEVENT = 802,
        RAWKEYRETURN = 803,
        UNINTERPBUTTON = 804,
        MOUSEWHEELMOTION = 805,
        THREEDINPUTDEV = 806,
        QUEUED_ACTION = 807,
    };

    public enum InputQueueSourceEnum : int
    {
        FROM_KEYBOARD = 400,
        FROM_CMDFILE = 401,
        FROM_APP = 403,
        FROM_UCM = 404,
        TABLET_MENU = 405,
        SCREEN_MENU = 406,
        FUNCKEY_MENU = 407,
        CURSOR_BUTTON_MENU = 408,
        PULLDOWN_MENU = 409,
        CONTROL_STRIP_MENU = 410,
        HIERARCHICAL_MENU = 411,
        WINDOW_ICON = 413,
        PALETTE_MENU = 414,
        FROM_STARTUP = 415,
        FROM_DIALOG = 416,
        FROM_PROCESS = 417,
        FROM_MDL = 418,
        FROM_PRDFPI = 419,
        FROM_OPER_SYSTEM = 420,
    };

    public enum MessageListNumber : int
    {
        MsgList_NONE = 0,
        MsgList_MESSAGES = -1,
        MsgList_MESSAGES2 = -2,
        MsgList_CMDNAMES = -3,
        MsgList_COMMONSTRINGS = -25,
        MsgList_EDUCATIONAL = -13,
        MsgList_ERRORS = -101,
    };

    public enum SizePolicyFlag : int
    {
        SPF_FixedFlag = 1,
        SPF_GrowFlag = 2,
        SPF_ExpandFlag = 4,
        SPF_ShrinkFlag = 8,
        SPF_IgnoreFlag = 16,
    };

    public enum SizePolicyType : int
    {
        SP_None = 0,
        SP_Fixed = 1,
        SP_Minimum = 2,
        SP_Maximum = 8,
        SP_Preferred = 10,
        SP_MinimumExpanding = 6,
        SP_Expanding = 14,
        SP_Ignored = 26,
    };

    public enum ItemExtendedAttributes : int
    {
        EXTATTR_FLYTEXT = 0,
        EXTATTR_BALLOON = 1,
        EXTATTR_HOOKID = 2,
        EXTATTR_HOOKARG = 3,
        EXTATTR_DBACCESS = 4,
        EXTATTR_DBPAGENUMBER = 5,
        EXTATTR_APPDATA1 = 6,
        EXTATTR_APPDATA2 = 7,
        EXTATTR_APPDATA3 = 8,
        EXTATTR_APPDATA4 = 9,
        EXTATTR_APPDATA5 = 10,
        EXTATTR_DISABLED_BALLOON = 11,
        EXTATTR_RCLICK_MENUID = 12,
        EXTATTR_RCLICK_MENUOWNER = 13,
        EXTATTR_POPUPMENUTEXT = 14,
        EXTATTR_ITEMNAME = 15,
    };

    public enum ItemExtendedIntAttributes : int
    {
        EXTINTATTR_HOOKID = 1,
        EXTINTATTR_HOOKARG = 2,
        EXTINTATTR_DBPAGENUMBER = 3,
        EXTINTATTR_ITEMATTRS = 4,
        EXTINTATTR_DROPSOURCE = 5,
        EXTINTATTR_DROPTARGET = 6,
        EXTINTATTR_RCLICK_MENUID = 7,
        EXTINTATTR_MARGIN = 8,
        EXTINTATTR_MARGIN_LEFT = 9,
        EXTINTATTR_MARGIN_TOP = 10,
        EXTINTATTR_MARGIN_RIGHT = 11,
        EXTINTATTR_MARGIN_BOTTOM = 12,
        EXTINTATTR_SPACING = 13,
        EXTINTATTR_STRETCH = 14,
        EXTINTATTR_DOCK_POSITION = 15,
        EXTINTATTR_COLUMN = 16,
        EXTINTATTR_COLSPAN = 17,
        EXTINTATTR_ROW = 18,
        EXTINTATTR_ROWSPAN = 19,
        EXTINTATTR_HORIZONTAL_ALIGNMENT = 20,
        EXTINTATTR_VERTICAL_ALIGNMENT = 21,
        EXTINTATTR_HORIZONTAL_SIZEPOLICY = 22,
        EXTINTATTR_VERTICAL_SIZEPOLICY = 23,
        EXTINTATTR_MINWIDTH = 24,
        EXTINTATTR_MINHEIGHT = 25,
        EXTINTATTR_MAXWIDTH = 26,
        EXTINTATTR_MAXHEIGHT = 27,
        EXTINTATTR_GRID_WIDTHPOLICY = 28,
    };

    public enum ItemExtendedWideAttributes : int
    {
        EXTWATTR_LABEL = 1,
        EXTWATTR_FLYTEXT = 2,
        EXTWATTR_BALLOON = 3,
        EXTWATTR_DISABLED_BALLOON = 4,
        EXTWATTR_POPUPMENUTEXT = 5,
        EXTWATTR_ITEMNAME = 6,
    };

    public enum ActionButtonValue : int
    {
        ACTIONBUTTON_APPLY = 1,
        ACTIONBUTTON_RESET = 2,
        ACTIONBUTTON_OK = 3,
        ACTIONBUTTON_CANCEL = 4,
        ACTIONBUTTON_DEFAULT = 5,
        ACTIONBUTTON_YES = 6,
        ACTIONBUTTON_NO = 7,
        ACTIONBUTTON_RETRY = 8,
        ACTIONBUTTON_STOP = 9,
        ACTIONBUTTON_HELP = 10,
        ACTIONBUTTON_YESTOALL = 11,
        ACTIONBUTTON_NOTOALL = 12,
        ACTIONBUTTON_OPEN = 13,
    };

    public enum MenuMarkType : int
    {
        MARK_NONE = 0,
        MARK_TOGGLE_OUT = 1,
        MARK_TOGGLE_IN = 2,
        MARK_RADIO_OUT = 3,
        MARK_RADIO_IN = 4,
        MARK_RIGHT_ARROW = 5,
    };

    public enum HorizontalAlignment : int
    {
        HorizontalAlignment_None,
        HorizontalAlignment_Left,
        HorizontalAlignment_Center,
        HorizontalAlignment_Right,
        HorizontalAlignment_Stretch,
    };

    public enum VerticalAlignment : int
    {
        VerticalAlignment_None,
        VerticalAlignment_Top,
        VerticalAlignment_Center,
        VerticalAlignment_Bottom,
        VerticalAlignment_Stretch,
    };

    public enum GridWidthPolicy : int
    {
        GridWidthPolicy_Default,
        GridWidthPolicy_Fixed,
        GridWidthPolicy_Ignored,
    };

    public enum DialogItemMessageType : int
    {
        DITEM_MESSAGE_CREATE = 50,
        DITEM_MESSAGE_DESTROY = 51,
        DITEM_MESSAGE_DRAW = 52,
        DITEM_MESSAGE_FONTCHANGED = 53,
        DITEM_MESSAGE_BUTTON = 54,
        DITEM_MESSAGE_SETSTATE = 55,
        DITEM_MESSAGE_SYNCHRONIZE = 56,
        DITEM_MESSAGE_HIGHLIGHT = 57,
        DITEM_MESSAGE_KEYSTROKE = 58,
        DITEM_MESSAGE_POSTKEYSTROKE = 59,
        DITEM_MESSAGE_FOCUSIN = 60,
        DITEM_MESSAGE_FOCUSOUT = 61,
        DITEM_MESSAGE_SETENABLEDSTATE = 62,
        DITEM_MESSAGE_MOVE = 63,
        DITEM_MESSAGE_SETEXTENT = 64,
        DITEM_MESSAGE_SETLABEL = 65,
        DITEM_MESSAGE_GETSTATE = 66,
        DITEM_MESSAGE_GETVALUE = 67,
        DITEM_MESSAGE_SETVALUE = 68,
        DITEM_MESSAGE_INIT = 69,
        DITEM_MESSAGE_QUEUECOMMAND = 70,
        DITEM_MESSAGE_STATECHANGED = 71,
        DITEM_MESSAGE_USER = 72,
        DITEM_MESSAGE_ALLCREATED = 73,
        DITEM_MESSAGE_POSTSETEXTENT = 74,
        DITEM_MESSAGE_MOTION = 75,
        DITEM_MESSAGE_NOMOTION = 76,
        DITEM_MESSAGE_WINDOWMOVING = 77,
        DITEM_MESSAGE_DROPFROM = 78,
        DITEM_MESSAGE_DROPTO = 79,
        DITEM_MESSAGE_STARTDRAG = 80,
        DITEM_MESSAGE_STATECHANGING = 81,
        DITEM_MESSAGE_RESETPREBUTTON = 82,
        DITEM_MESSAGE_SCREENCHANGE = 83,
        DITEM_MESSAGE_POSTDRAW = 84,
        DITEM_MESSAGE_POPUPWINDOW = 85,
        DITEM_MESSAGE_HANDLERLOADED = 100,
        DITEM_MESSAGE_HANDLERUNLOADED = 101,
        DITEM_MESSAGE_PREDESTROY = 102,
        DITEM_MESSAGE_ACTIVATE = 110,
        DITEM_MESSAGE_ATTACH = 111,
        DITEM_MESSAGE_SHOW = 112,
        DITEM_MESSAGE_GETMNEMONICS = 114,
        DITEM_MESSAGE_SHOWHELP = 115,
        DITEM_MESSAGE_CLEANUP = 116,
        DITEM_MESSAGE_JOURNALSTATE = 117,
        DITEM_MESSAGE_REDIRECT = 118,
        DITEM_MESSAGE_HIDE = 119,
        DITEM_MESSAGE_OBSCURED = 120,
        DITEM_MESSAGE_UNOBSCURED = 121,
        DITEM_MESSAGE_RELOADDATA = 122,
        DITEM_MESSAGE_POPUP = 123,
        DITEM_MESSAGE_POPUPCLOSED = 124,
        DITEM_MESSAGE_GETEDITMENUINFO = 126,
        DITEM_MESSAGE_SCROLLING = 127,
        DITEM_MESSAGE_MOUSEWHEEL = 128,
        DITEM_MESSAGE_DROPSOURCE = 129,
        DITEM_MESSAGE_DROPTARGET = 130,
        DITEM_MESSAGE_POPUPCREATED = 131,
        DITEM_MESSAGE_DIALOGHIDE = 132,
        DITEM_MESSAGE_DIALOGSHOW = 133,
        DITEM_MESSAGE_SETNAMEDITEM = 134,
        DITEM_MESSAGE_CHILDDRAWBG = 135,
        DITEM_MESSAGE_LAYOUT = 136,
        DITEM_MESSAGE_CHILDRENLOADED = 137,
        DITEM_MESSAGE_LINKLABEL = 138,
        DITEM_MESSAGE_AUTOUPDATE = 139,
        DITEM_MESSAGE_HOOKRESOLVE = 200,
    };

    public enum tagTreeCompareStatus : int
    {
        TreeCompareStatus_NotChecked = 0,
        TreeCompareStatus_Same,
        TreeCompareStatus_Change,
        TreeCompareStatus_Rename,
        TreeCompareStatus_DifferentNode,
    };

    public enum tagTreeChangeMod : int
    {
        TreeChangeMod_NotDetermined = 0,
        TreeChangeMod_None,
        TreeChangeMod_Change,
        TreeChangeMod_Rename,
        TreeChangeMod_Add,
        TreeChangeMod_Delete,
        TreeChangeMod_Move,
    };

    public enum tagTreeAddRelative : int
    {
        TreeAddRelative_None = 0,
        TreeAddRelative_Before,
        TreeAddRelative_After,
        TreeAddRelative_Child,
    };

    public enum ViewIconSize : int
    {
        Small = 0,
        Medium = 1,
        Large = 2,
    };

    public enum IconCmdSelectType : int
    {
        UseLast = -1,
        Off = 0,
        SingleShot = 1,
        Locked = 2,
        On = 2,
        Disabled = 3,
    };

    public enum TextAutoUpdateSpeed : int
    {
        Faster,
        Fast,
        Medium,
        Slow,
        Slower,
    };

    public enum TreeNodePortion : int
    {
        None = 0,
        CellEditor,
        VerticalScrollBar,
        HorizontalScrollBar,
        ExpansionHandle,
        ColumnHeading,
        Data,
        HookHandled,
    };

    public enum NativeContentType : int
    {
        None = 0,
        MFC = 1,
        WinForms = 2,
        WPF = 3,
    };

    public enum FilterChangeType : int
    {
        FILTER_TABLE_CHANGE = 1,
        FILTER_CHANGE_ACTIVE = 2,
        FILTER_CREATE = 3,
        FILTER_DELETE = 4,
        FILTER_CHANGE_NAME = 5,
        FILTER_CHANGE_DESCRIPTION = 6,
        FILTER_CHANGE_TYPE = 7,
        FILTER_CHANGE_PERSISTENT = 8,
        FILTER_CHANGE_FLAG = 9,
        FILTER_CHANGE_PARENT = 10,
        FILTER_CHANGE_EXPRESSION = 11,
        FILTER_TABLE_IMPORT = 12,
        FILTER_TABLE_UNDO = 13,
        FILTER_TABLE_REDO = 14,
    };

    public enum FilterLibraryFormat : int
    {
        FILTER_LIBRARY_FORMAT_ANY = 0,
        FILTER_LIBRARY_FORMAT_DGN = 1,
    };

    public enum LevelChangeType : int
    {
        LEVEL_TABLE_REWRITE = 1,
        LEVEL_CREATE = 2,
        LEVEL_DELETE = 3,
        LEVEL_CHANGE_NAME = 4,
        LEVEL_CHANGE_CODE = 5,
        LEVEL_CHANGE_PARENT = 6,
        LEVEL_CHANGE_DISPLAY = 7,
        LEVEL_CHANGE_ATTRIBUTE = 8,
        LEVEL_CHANGE_ACTIVE = 9,
        LEVEL_LIBRARY_ATTACH = 10,
        LEVEL_LIBRARY_DETACH = 11,
        LEVEL_CHANGE_USAGE = 12,
        LEVEL_CHANGE_ELEMENT_COUNT = 13,
        LEVEL_TABLE_UNDO = 14,
        LEVEL_TABLE_REDO = 15,
        LEVEL_TABLE_IMPORT = 16,
        LEVEL_PRE_CHANGE_ACTIVE = 17,
        LEVEL_PRE_DELETE = 18,
        LEVEL_REWRITE = 19,
    };

    public enum LevelLibraryFormat : int
    {
        LEVEL_LIBRARY_FORMAT_ANY = 0,
        LEVEL_LIBRARY_FORMAT_DGN = 1,
        LEVEL_LIBRARY_FORMAT_CSV = 2,
        LEVEL_LIBRARY_FORMAT_XML = 3,
        LEVEL_LIBRARY_FORMAT_V7_LVL = 4,
        LEVEL_LIBRARY_FORMAT_DWG = 5,
    };

    public enum LevelLibraryImportMethod : int
    {
        LEVEL_LIBRARY_IMPORT_BY_ANY = 1,
        LEVEL_LIBRARY_IMPORT_BY_NAME = 2,
        LEVEL_LIBRARY_IMPORT_BY_CODE = 3,
    };

    public enum LevelCountType : int
    {
        LEVEL_COUNT_TYPE_ALL = 1,
        LEVEL_COUNT_TYPE_USED = 2,
        LEVEL_COUNT_TYPE_UNUSED = 3,
        LEVEL_COUNT_TYPE_HIDDEN = 5,
    };

    public enum LevelIterateType : int
    {
        LEVEL_ITERATE_TYPE_ALL_LEVELS = 1,
        LEVEL_ITERATE_TYPE_USED_LEVELS = 4,
        LEVEL_ITERATE_TYPE_UNUSED_LEVELS = 5,
    };

    public enum LevelLibraryCountType : int
    {
        LEVEL_LIBRARY_COUNT_TYPE_ALL = 1,
        LEVEL_LIBRARY_COUNT_TYPE_MANUAL_ATTACHED = 2,
        LEVEL_LIBRARY_COUNT_TYPE_AUTO_ATTACHED = 3,
    };

    public enum LevelFrozenType : int
    {
        LEVEL_FROZEN_TYPE_GLOBAL = 1,
        LEVEL_FROZEN_TYPE_VP_FREEZE = 2,
        LEVEL_FROZEN_TYPE_EFFECTIVE = 3,
    };

    public enum LevelAttributeMaskType : int
    {
        LIBRARY_LEVEL_ATTRIBUTE_EDIT_MASK = 1,
        LIBRARY_LEVEL_ATTRIBUTE_SYNC_MASK = 2,
        REFERENCE_LEVEL_ATTRIBUTE_EDIT_MASK = 3,
        REFERENCE_LEVEL_ATTRIBUTE_SYNC_MASK = 4,
        LIBRARY_LEVEL_ATTRIBUTE_AUTO_SYNC_MASK = 6,
        REFERENCE_LEVEL_ATTRIBUTE_AUTO_SYNC_MASK = 7,
        LEVEL_CREATE_FROM_SEED_ATTRIBUTE_MASK = 8,
        REFERENCE_LEVEL_ATTRIBUTE_COMPARE_MASK = 9,
        LIBRARY_LEVEL_ATTRIBUTE_COMPARE_MASK = 10,
    };

    public enum LineStyleChangeType : int
    {
        LINESTYLE_ADD = 1,
        LINESTYLE_REMOVE = 2,
        LINESTYLE_RENAME = 3,
    };

    public enum MdlErrorValues : int
    {
        MDLERR_NOTRANSFORM = -101,
        MDLERR_BADVIEWNUMBER = -102,
        MDLERR_INSFINFO = -103,
        MDLERR_FILE2SUB3 = -104,
        MDLERR_BADELEMENT = -105,
        MDLERR_INVREGEX = -106,
        MDLERR_BADMODELREF = -107,
        MDLERR_BADFILENUMBER = -107,
        MDLERR_BADSLOT = -107,
        MDLERR_FILEREADONLY = -108,
        MDLERR_DISKFULL = -109,
        MDLERR_WRITEINHIBIT = -110,
        MDLERR_WRITEFAILED = -111,
        MDLERR_MODIFYCOMPLEX = -112,
        MDLERR_CANNOTOPENFILE = -113,
        MDLERR_ENDOFFILE = -114,
        MDLERR_BADSCANLIST = -115,
        MDLERR_INSFMEMORY = -116,
        MDLERR_NOTCMPLXHDR = -117,
        MDLERR_ALREADYLOADED = -118,
        MDLERR_BADFILETYPE = -119,
        MDLERR_READFAILED = -120,
        MDLERR_NOSUCHAPPLICATION = -121,
        MDLERR_REJECTED = -122,
        MDLERR_NOMATCH = -123,
        MDLERR_AMBIGUOUS = -124,
        MDLERR_BADARG = -126,
        MDLERR_BADCOPYPARALLEL = -127,
        MDLERR_RESOURCENOTFOUND = -128,
        MDLERR_NOCELLLIBRARY = -129,
        MDLERR_VIEWNOTDISPLAYED = -130,
        MDLERR_CELLNOTFOUND = -131,
        MDLERR_CELLEXISTS = -132,
        MDLERR_INVALIDCELL = -133,
        MDLERR_BADINDEX = -134,
        MDLERR_CELLTOOLARGE = -135,
        MDLERR_INVALIDLIBRARY = -136,
        MDLERR_BADLINKERINFO = -137,
        MDLERR_NOTAVAILABLE = -138,
        MDLERR_CELLLIB2DGN3 = -139,
        MDLERR_MAXMCSLTASKS = -140,
        MDLERR_SYSTEMERROR = -141,
        MDLERR_TIMEOUT = -142,
        MDLERR_PROGRAMTERMINATED = -143,
        MDLERR_USERABORT = -144,
        MDLERR_ELEMENTFROZEN = -145,
        MDLERR_NOEXTPGMSTACK = -146,
        MDLERR_REJECTEDBYINIT = -147,
        MDLERR_TOOLARGE = -148,
        MDLERR_NOKEYS = -149,
        MDLERR_SHMEMNOTFOUND = -150,
        MDLERR_DUPTASKID = -151,
        MDLERR_BADSCREENNUMBER = -152,
        MDLERR_NULLOUTPUTBUFFER = -153,
        MDLERR_BADRASTERFORMAT = -154,
        MDLERR_NOTSUPPORTED = -156,
        MDLERR_DLMNOTALLOWED = -157,
        MDLERR_TOOMANYSURFACEELMS = -158,
        MDLERR_ELEMTOOLARGE = -159,
        MDLERR_LINKAGENOTFOUND = -160,
        MDLERR_NAMENOTUNIQUE = -161,
        MDLERR_MODELNOTEMPTY = -162,
        MDLERR_NOCHANGE = -163,
        MDLERR_OPERVIOLATESCONSTRAINTS = -164,
        MDLERR_RELATIVECELLLEVELNOTFOUND = -165,
        MDLERR_FILENOTFOUND = -166,
        MDLERR_NOFENCE = -167,
        MDLERR_NOCLIPVOLUME = -168,
        MDLERR_NAMETOOLONG = -169,
        MDLERR_BADMODELID = -170,
        MDLERR_MODELNAMEEXISTS = -171,
        MDLERR_MODELIDEXISTS = -172,
        MDLERR_NOMODELINFO = -173,
        MDLERR_NOPARENTMODEL = -174,
        MDLERR_CANTCREATEFILE = -175,
        MDLERR_CANTSAVEFILE = -176,
        MDLERR_V7CELLLIBRARY = -177,
        MDLERR_FILEEXISTS = -178,
        MDLERR_V8B2CELLLIBRARY = -179,
        MDLERR_FARASSOCREQUIRED = -180,
        MDLERR_ELMENTNOTFOUND = -181,
        MDLERR_IDNOTFOUND = -182,
        MDLERR_IDEXISTS = -183,
        MDLERR_CACHENOTENABLED = -184,
        MDLERR_WRONGELEMID = -185,
        MDLERR_CACHEINUSE = -186,
        MDLERR_CACHENOTFOUND = -187,
        MDLERR_BADNAME = -188,
        MDLERR_NOTOPEN = -189,
        MDLERR_SHARINGVIOLATION = -190,
        MDLERR_ACCESSVIOLATION = -191,
        MDLERR_ALREADYOPEN = -192,
        MDLERR_BADWORDSTOFOLLOW = -193,
        MDLERR_ALREADYEXISTS = -194,
        MDLERR_BADFORMAT = -195,
        MDLERR_BADVERSION = -196,
        MDLERR_TOOMANYOPENFILES = -197,
        MDLERR_OPERATIONCANCELED = -198,
        MDLERR_UNKNOWNERROR = -199,
        MDLERR_BADFILE = -200,
        MDLERR_CANNOTOPENSEED = -201,
        MDLERR_INVALIDOPERATIONFORNESTED = -202,
        MDLERR_INVALIDOPERATIONFORNONNESTED = -203,
        MDLERR_NOTLOADED = -204,
        MDLERR_NOMODEL = -205,
        MDLERR_HASCHANGES = -206,
        MDLERR_LOADINGINTERFACE = -207,
        MDLERR_COMPRESSIONERROR = -208,
        MDLERR_UNKNOWNFORMAT = -209,
        MDLERR_NOSUCHMODEL = -210,
        MDLERR_NOTLOCKED = -211,
        MDLERR_CANNOTIMPORTSEED = -212,
        MDLERR_CACHELOADERROR = -213,
        MDLERR_RENAMEERROR = -214,
        MDLERR_COPYERROR = -215,
        MDLERR_CACHENOTFILLED = -216,
        MDLERR_ACCUDRAWNOTENABLED = -217,
        MDLERR_MUNOTLARGERTHANSU = -218,
        MDLERR_NOTSAMEUNITBASE = -219,
        MDLERR_NOTCOMPLEXHEADER = -220,
        MDLERR_ADDINGCOMPLEXELEMENT = -221,
        MDLERR_2D3D_MISMATCH = -222,
        MDLERR_REPLACING_DELETED = -223,
        MDLERR_OVERSIZE_ELEMENT = -224,
        MDLERR_UNDERSIZE_ELEMENT = -225,
        MDLERR_BADELEMENTTYPE = -226,
        MDLERR_STYLENOTFOUND = -227,
        MDLERR_TOOMANYITERATIONS = -228,
        MDLERR_ANONYMOUS_SHAREDCELL = -229,
        MDLERR_STYLEISUSED = -230,
        MDLERR_CAPABILITYRESTRICTION = -229,
        MDLERR_INVALIDFORNEUTRALMDL = -230,
        MDLERR_ALLMODELSFILTEREDOUT = -231,
        MDLERR_NONPLANARELEMENT = -232,
        MDLERR_NOASSOCIATEDTEMPLATE = -233,
        MDLERR_HISTORYREVISIONNOTFOUND = -234,
        MDLERR_MISSINGIMAGEBAND = -235,
        MDLERR_NOMASTERFILE = -236,
        MDLERR_NOTSUPPORTEDACTIVATEDREF = -237,
        MDLERR_GEOCOORD_REFTRANSFORMDISABLED = -480,
        MDLERR_GEOCOORD_NOMASTERGCS = -481,
        MDLERR_GEOCOORD_NOREFGCS = -482,
        MDLERR_GEOCOORD_NOGEOCODE = -483,
        MDLERR_GEOCOORD_NOTGEOTRANSFORMED = -484,
        MDLERR_GEOCOORD_NEEDSRECALCULATION = -485,
        MDLERR_GEOCOORD_UNITSWRONG = -486,
        MDLERR_NOPOLES = -500,
        MDLERR_NOKNOTS = -501,
        MDLERR_NOWEIGHTS = -502,
        MDLERR_NOBOUNDS = -503,
        MDLERR_NONUMBOUNDS = -504,
        MDLERR_NOBSPHEADER = -505,
        MDLERR_TOOFEWPOLES = -506,
        MDLERR_TOOMANYPOLES = -507,
        MDLERR_BADBSPELM = -508,
        MDLERR_BADPARAMETER = -509,
        MDLERR_BADORDER = -510,
        MDLERR_BADPERIODICITY = -511,
        MDLERR_BADPOLES = -512,
        MDLERR_BADKNOTS = -513,
        MDLERR_BADWEIGHTS = -514,
        MDLERR_BADSPIRALDEFINITION = -515,
        MDLERR_TOOMANYKNOTS = -516,
        MDLERR_NOOFFSETINTERSECTION = -517,
        MDLERR_BADCONTINUITY = -518,
        MDLERR_RECURSELIMIT = -519,
        MDLERR_CANNOTDELETEDEFAULTMODEL = -520,
        MDLERR_SYMBOLTOOLONG = -600,
        MDLERR_INVALID_FOR_RESTRICTED_PRODUCT = -601,
        MDLERR_FIRSTEXPRERROR = -700,
        MDLERR_ALREADYINUSE = -700,
        MDLERR_BADTYPE = -701,
        MDLERR_NEEDINT = -702,
        MDLERR_STRUCTNEEDED = -703,
        MDLERR_RIGHT_NOT_GRANTED_FOR_OPERATION = -704,
        MDLERR_BADHEX = -705,
        MDLERR_NEEDEXPONENT = -706,
        MDLERR_BADOCTAL = -707,
        MDLERR_BADFLOAT = -708,
        MDLERR_BADSTRING = -709,
        MDLERR_BADCHARCONS = -710,
        MDLERR_ILLEGALCHAR = -711,
        MDLERR_UNSUPPORTED = -712,
        MDLERR_NOSYMBOL = -713,
        MDLERR_SYNTAXERROR = -714,
        MDLERR_INVALIDSYMBOL = -715,
        MDLERR_TYPESINCOMPATIBLE = -716,
        MDLERR_CANNOTDEREF = -717,
        MDLERR_NOTSTRUCT = -718,
        MDLERR_NOTMEMBER = -719,
        MDLERR_ADDRNOTKNOWN = -720,
        MDLERR_TOOCOMPLEX = -721,
        MDLERR_INVALIDFORSTRUCT = -722,
        MDLERR_INVALIDFORFLOAT = -723,
        MDLERR_DIVIDEBYZERO = -724,
        MDLERR_ADDRNOTVALID = -725,
        MDLERR_INVALIDFORTYPE = -726,
        MDLERR_INTEGRALNEEDED = -727,
        MDLERR_NOTVALIDEXPRESS = -728,
        MDLERR_NOTFUNCTION = -729,
        MDLERR_TOOMANYARGUMENTS = -730,
        MDLERR_TOOFEWARGUMENTS = -731,
        MDLERR_BADRSCTYPE = -732,
        MDLERR_INVALIDFORFUNC = -733,
        MDLERR_LASTEXPRERROR = -733,
        MDLERR_INVALIDACSTYPE = -734,
        MDLERR_INVALIDBUTTON = -735,
        MDLERR_NOTDESIGNFILE = -736,
        MDLERR_3DREF2DMASTER = -737,
        MDLERR_DUPLICATELOGICAL = -738,
        MDLERR_NOTSINGLEVIEW = -739,
        MDLERR_INVALIDREFORG = -740,
        MDLERR_INVALIDMASTERORG = -741,
        MDLERR_INVALIDREF = -742,
        MDLERR_INVALIDCLIP = -743,
        MDLERR_INVALIDPATSPACE = -744,
        MDLERR_NONCLOSEDPATELM = -745,
        MDLERR_NONSOLIDPATELM = -746,
        MDLERR_NONCLOSEDELM = -747,
        MDLERR_ELMFILLED = -748,
        MDLERR_ELMNOTFILLED = -749,
        MDLERR_ELMTOOLARGE = -750,
        MDLERR_ELMNOTPLANAR = -751,
        MDLERR_NULLSOLUTION = -752,
        MDLERR_UNBOUNDEDSOLUTION = -753,
        MDLERR_NONCOPLANARSHAPES = -754,
        MDLERR_OLDMATERIALTABLE = -755,
        MDLERR_NOSELECTIONSET = -756,
        MDLERR_NOREFSLOTS = -757,
        MDLERR_NOACSDEFINED = -758,
        MDLERR_ACSREPLACED = -759,
        MDLERR_ACSNOTFOUND = -760,
        MDLERR_VIEWNOTFOUND = -761,
        MDLERR_NOGRAPHICGROUP = -762,
        MDLERR_VIEWGROUPNOTFOUND = -763,
        MDLERR_NOLEVELMASK = -764,
        MDLERR_NOTDIRECTATTACHMENT = -765,
        MDLERR_MODELNOTFOUND = -766,
        MDLERR_RELOADNOTNEEDED = -767,
        MDLERR_COINCIDENTSELFREF = -768,
        MDLERR_REDUNDANTREF = -769,
        MDLERR_BADFONT = -770,
        MDLERR_BADTEXTSTYLE = -771,
        MDLERR_NOINTERNALMATERIALS = -772,
        MDLERR_COMMANDRECEIVED = -800,
        MDLERR_RSCERROR = -900,
        MDLERR_RSCFILEERROR = -901,
        MDLERR_RSCHANDLEINVALID = -902,
        MDLERR_RSCFILENOTFOUND = -903,
        MDLERR_RSCINSFMEM = -904,
        MDLERR_RSCWRITEERROR = -905,
        MDLERR_RSCWRITEVIOLATION = -906,
        MDLERR_RSCADDRINVALID = -907,
        MDLERR_RSCTYPEINVALID = -908,
        MDLERR_RSCALREADYEXISTS = -909,
        MDLERR_RSCBADVERSION = -910,
        MDLERR_RSCINUSE = -911,
        MDLERR_RSCNOTFOUND = -912,
        MDLERR_RSCSTRINGNOTFOUND = -913,
        MDLERR_RSCQRYIDINVALID = -914,
        MDLERR_RSCDIRECTADDPEND = -915,
        MDLERR_RSCBADRANGETREE = -916,
        MDLERR_RSCFILENOTOPEN = -917,
        MDLERR_RSCBADRSCSIZE = -918,
        MDLERR_RSCINVALIDFILEHANDLE = -919,
        MDLERR_RSCALIASREQUIRED = -920,
        MDLERR_RSCFILECORRUPT = -921,
        MDLERR_RSCFOPENFAILURE = -922,
        MDLERR_RSCFILEHANDLETABLEFULL = -923,
        MDLERR_RSCCONDITIONFALSE = -924,
        MDLERR_LICHANDLENOTFOUND = -1000,
        MDLERR_NOLICENSEAVAILABLE = -1001,
        MDLERR_BADVRBLARRAYSIZE = -1100,
        MDLERR_NOTCONVRULES = -1101,
        MDLERR_BADDATADEF = -1102,
        MDLERR_DATADEFNOTFOUND = -1103,
        MDLERR_BUFFERALIGNMENTSDIFFER = -1104,
        MDLERR_OUTPUTBUFFERWRONGALIGNMENT = -1105,
        MDLERR_INVALIDPLATFORMID = -1106,
        MDLERR_VOIDDATATYPE = -1107,
        MDLERR_INPUTBUFFERWRONGALIGNMENT = -1108,
        MDLERR_BADCOLORPALETTE = -1200,
        MDLERR_BADCOLORPALETTEINDEX = -1201,
        MDLERR_BADCOLORPALETTEDATA = -1202,
        MDLERR_BADSETMETHODID = -1203,
        MDLERR_PALETTEWRONGSIZE = -1204,
        MDLERR_BADCOLORTABLE = -1205,
        MDLERR_COLORMGRNOTINITIALIZED = -1206,
        MDLERR_BADCOLORDESCR = -1207,
        MDLERR_NOQUEUEENTRIES = -1300,
        MDLERR_QUEUEFULL = -1301,
        MDLERR_QUEUEERROR = -1302,
        MDLERR_NOMESSAGE = -1303,
        MDLERR_ATTRUNDEFTYPE = -1400,
        MDLERR_ATTRSETNAMELONG = -1401,
        MDLERR_ATTRSETNOTFOUND = -1402,
        MDLERR_ATTRNOTINSET = -1403,
        MDLERR_ATTRSETPREVDEFINED = -1404,
        MDLERR_ATTRSETTOOBIG = -1405,
        MDLERR_ATTRBADRPTFILE = -1406,
        MDLERR_ATTRBADRPTKEYWORD = -1407,
        MDLERR_ATTRBADASSOC = -1408,
        MDLERR_ATTRNOTARGET = -1409,
        MDLERR_ATTRPREVDEFINED = -1410,
        MDLERR_ATTRNOTFOUND = -1411,
        MDLERR_NOMDLPLOTDRIVERINPLT = -1500,
        MDLERR_MACROSTILLRUNNING = -1600,
        MDLERR_MACRONOTSTARTED = -1601,
        MDLERR_CANNOTLOADMACROHOST = -1602,
        MDLERR_CANNOTFINDMACRO = -1603,
        MDLERR_MACROVARNOTDEFINED = -1604,
        MDLERR_NOTATOMICDATATYPE = -1605,
        MDLERR_VARWRONGSIZE = -1606,
        MDLERR_CANNOTSETVALUE = -1607,
        MDLERR_ARRAYWRONGSIZE = -1608,
        MDLERR_THREADUNKNOWN = -1609,
        MDLERR_SYMBOLNOTRESOLVED = -1800,
        MDLERR_MODELERNOTLOADED = -1801,
        MDLERR_PARASOLID_ERROR = -1801,
        MDLERR_CIRCULARDEPENDENCY = -1900,
        MDLERR_INVALIDDEPENDENCY = -1901,
        MDLERR_EXCEPTION = -2000,
        MDLERR_DGNFILEOBJINUSE = -2001,
        MDLERR_SIGNATURE_NOT_FOUND = -2002,
        MDLERR_SIGNATURE_NOT_VERIFIED = -2003,
        MDLERR_SIGNATURE_NOT_RECOGNIZED = -2004,
        MDLERR_RIGHT_NOT_GRANTED = -2005,
        MDLERR_SIGNATURE_SILENT = -2006,
        MDLERR_NOTAVALIDSHAPEFILE = -2100,
        MDLERR_SHAPEFILEFULL = -2101,
        MDLERR_SHAPEALREADYEXISTS = -2102,
        MDLERR_CLOSEDGROUP = -2201,
        MDLERR_DUPLICATEMEMBER = -2202,
        MDLERR_FARREFERENCE = -2203,
        MDLERR_GROUPOPINPROGRESS = -2204,
        MDLERR_INVALIDCOLORMODE = -3000,
        MDLERR_NO_TRANSPARENCY = -3001,
        MDLERR_INVALID_COLOR = -3002,
        MDLERR_MULTIPLE_TRANSPARENCY = -3003,
        MDLERR_BADRASTER = -3004,
        MDLERR_INVALIDACCESSMODE = -3005,
        MDLERR_NO_GEOCODINGELM = -3006,
        MDLERR_SERVER_MAX_USER_REACHED = -3007,
        MDLERR_INTERSECTSITSELF = -3008,
        MDLERR_ELEMENTISHOLED = -3009,
        MDLERR_INVALIDLOGICALNAME = -3010,
        MDLERR_CONNECTIONERROR = -3011,
        MDLERR_INVALIDPAGE = -3012,
        MDLERR_EMPTYSOURCE = -3013,
        MDLERR_INVALIDPASSWORD = -3014,
        MDLERR_MSELEMENTDESCRCOLLECTOR_TERMINATE_COLLECTION = -4000,
        MDLERR_DOCMGR_CREATE_FAILED = -5000,
    };

    public enum AcsChangeType : int
    {
        ACS_CHANGE_SAVE = 1,
        ACS_CHANGE_DELETE = 2,
        ACS_CHANGE_REWRITE = 3,
        ACS_SYNCH_TO_DATA = 4,
    };

    public enum CellAddType : int
    {
        FromContext = -1,
        NormalCell = 1,
        PointCell = 2,
    };

    public enum CExprSymbolClass : int
    {
        SYMBOL_CLASS_SOURCE = 1,
        SYMBOL_CLASS_SCOPE = 2,
        SYMBOL_CLASS_VAR = 4,
        SYMBOL_CLASS_STRUCT = 8,
        SYMBOL_CLASS_FUNCTION = 32,
        SYMBOL_CLASS_BLOCK = 64,
    };

    public enum CExprVisibilityMask : int
    {
        VISIBILITY_DEBUGGER = 1,
        VISIBILITY_CALCULATOR = 2,
        VISIBILITY_DIALOG_BOX = 4,
        VISIBILITY_LOCAL = 8,
        VISIBILITY_DBASE_HOOK = 16,
    };

    public enum CExprResultClass : int
    {
        CL_VALUE = 1,
        CL_LVALUE = 2,
        CL_ERROR = 3,
    };

    public enum CExprValueType : int
    {
        CEXPR_TYPE_POINTER = 1,
        CEXPR_TYPE_LONG = 2,
        CEXPR_TYPE_ULONG = 3,
        CEXPR_TYPE_DOUBLE = 4,
        CEXPR_TYPE_LONG64 = 5,
    };

    public enum ModelChangeType : int
    {
        MODEL_CHANGE_Create = 1,
        MODEL_CHANGE_Delete = 2,
        MODEL_CHANGE_Properties = 3,
        MODEL_CHANGE_Settings = 4,
        MODEL_CHANGE_Active = 5,
        MODEL_CHANGE_BeforeDelete = 6,
        MODEL_CHANGE_UnCreate = 7,
        MODEL_CHANGE_UnDelete = 8,
        MODEL_CHANGE_BeforeUnCreate = 9,
        MODEL_CHANGE_Name = 10,
        MODEL_CHANGE_BeforeActive = 11,
        MODEL_CHANGE_BeforeName = 12,
        MODEL_CHANGE_BeforeSettings = 13,
        MODEL_CHANGE_BeforeProperties = 14,
        MODEL_CHANGE_BeforeCreate = 15,
        MODEL_CHANGE_BeforeUnDelete = 16,
        MODEL_CHANGE_PropagateAnnotationScale = 17,
        MODEL_CHANGE_BeforeCopy = 18,
        MODEL_CHANGE_Copied = 19,
        MODEL_CHANGE_BeforeUndoProperties = 20,
        MODEL_CHANGE_UndoProperties = 21,
    };

    public enum MessageDestination : int
    {
        MESSAGE_DEST_None = 0,
        MESSAGE_DEST_MessageCenter = 1,
        MESSAGE_DEST_WarningDialog = 2,
    };

    public enum FINDFILE_Options : int
    {
        FINDFILEOPTION_Default = 0,
        FINDFILEOPTION_CurrentDirectoryLast = 8,
        FINDFILEOPTION_SkipCurrentDir = 16,
    };

    public enum CommandFilterReturnValue : int
    {
        INPUT_COMMAND_ACCEPT = 0,
        INPUT_COMMAND_REJECT = 1,
        INPUT_COMMAND_CHANGED = 2,
    };

    public enum InputFilterReturnValue : int
    {
        INPUT_ACCEPT = 0,
        INPUT_REJECT = 1,
    };

    public enum InputMonitorFilter : int
    {
        MONITOR_NOT_FROM_APP = 1,
        MONITOR_FROM_APP = 2,
        MONITOR_ALL = 3,
    };

    public enum LicenseVariety : int
    {
        MDLLICENSE_TYPE_ERROR = -1,
        MDLLICENSE_TYPE_UNKNOWN = 0,
        MDLLICENSE_USERTYPE_COMMERCIAL = 1,
        MDLLICENSE_USERTYPE_ACADEMIC = 2,
        MDLLICENSE_USERTYPE_HOMEUSE = 3,
        MDLLICENSE_TYPE_NONCOMMERCIAL = 4,
        MDLLICENSE_TYPE_TRIAL = 5,
        MDLLICENSE_TYPE_FUTURETYPE2 = 6,
    };

    public enum FenceChangedType : int
    {
        SYSTEM_FENCE_CLEARED = 0,
        SYSTEM_FENCE_CREATED = 1,
    };

    public enum WindowModifyType : int
    {
        WINDOW_SHOWEVENT = 1,
        WINDOW_HIDEEVENT = 2,
        WINDOW_ORDEREVENT = 3,
        WINDOW_MOVEEVENT = 4,
        WINDOW_CHANGESCREENEVENT = 5,
        WINDOW_MINIMIZEEVENT = 6,
    };

    public enum LOCATE_FILTER_Status : int
    {
        LOCATE_ELEMENT_REJECT = 0,
        LOCATE_ELEMENT_NEUTRAL = 1,
        LOCATE_ELEMENT_ACCEPT = 2,
    };

    public enum LocateMethod : int
    {
        LOCATE_METHOD_SelectionSet = 1,
        LOCATE_METHOD_AutoLocate = 2,
        LOCATE_METHOD_Manual = 3,
    };

    public enum LstyleInfoFields : int
    {
        LS_InfoField_Reserved = 0,
        LS_InfoField_FileKey = 1,
        LS_InfoField_Type = 2,
        LS_InfoField_IdLow = 3,
        LS_InfoField_IdHigh = 4,
        LS_InfoField_ResourcePtr = 5,
        LS_InfoField_Count = 6,
    };

    public enum ResetMenuAccess : int
    {
        RESET_MENU_ACCESS_Click = 0,
        RESET_MENU_ACCESS_PressHold = 1,
    };

    public enum TaskNavigationPresentation : int
    {
        TASKNAV_ToolBox = 0,
        TASKNAV_Dialog = 1,
        TASKNAV_InViews = 2,
        TASKNAV_Combo = 3,
        TASKNAV_RibbonWorkflow = 4,
        TASKNAV_None = 65535,
    };

    public enum MarkerSize : int
    {
        MarkerSize_Default = 0,
        MarkerSize_16X16 = 1,
        MarkerSize_24X24 = 2,
        MarkerSize_32X32 = 3,
        MarkerSize_48X48 = 4,
        MarkerSize_Variable = 5,
    };

    public enum RibbonSize : int
    {
        RibbonSize_Standard = 0,
        RibbonSize_Medium = 1,
        RibbonSize_Touch = 2,
    };

    public enum RibbonTaskNavPickerSize : int
    {
        RibbonTaskNavPickerSize_Button = 0,
        RibbonTaskNavPickerSize_Combo = 1,
    };

    public enum RibbonPMGroupPresentation : int
    {
        RibbonPMGroupPresentation_GroupPopup = 0,
        RibbonPMGroupPresentation_TraditionalMenu = 1,
        RibbonPMGroupPresentation_RadialMenu = 2,
    };

    public enum ViewGroupChangeType : int
    {
        VIEWGROUP_CACHE_CHANGE_CREATE = 1,
        VIEWGROUP_CACHE_CHANGE_DELETE = 2,
        VIEWGROUP_CACHE_CHANGE_PROPERTY_EDIT = 3,
        VIEWGROUP_CACHE_CHANGE_ACTIVATE = 4,
        VIEWGROUP_CACHE_CHANGE_REDIRECT = 5,
    };

    public enum CreateViewgroup : int
    {
        CREATEVIEWGROUP_UseSource = -1,
        CREATEVIEWGROUP_False = 0,
        CREATEVIEWGROUP_True = 1,
    };

    public enum ElmDscrToFile_Actions : int
    {
        ELMDTF_ACTION_APPEND = 1,
        ELMDTF_ACTION_DELETE = 2,
        ELMDTF_ACTION_REPLACE = 3,
    };

    public enum ElmDscrToFile_Status : int
    {
        ELMDTF_STATUS_SUCCESS = 0,
        ELMDTF_STATUS_ABORT = 1,
        ELMDTF_STATUS_REPLACE = 2,
    };

    public enum UnloadProgramReason : int
    {
        SYSTEM_TERMINATED_UNLOADING_APPDOMAIN = -6,
        SYSTEM_TERMINATED_ENTERING_RESTRICTED_RIGHTS_MODE = -5,
        SYSTEM_TERMINATED_UNLOAD_UI_SERVERS = -4,
        SYSTEM_TERMINATED_LIBRARY_UNLOAD = -3,
        SYSTEM_TERMINATED_SHUTDOWN = -2,
        SYSTEM_TERMINATED_FATAL = -1,
        SYSTEM_TERMINATED_COMMAND = 1,
        SYSTEM_TERMINATED_EXIT = 2,
        SYSTEM_TERMINATED_BY_APP = 3,
        SYSTEM_TERMINATED_EXCEPTION = 4,
    };

    public enum NewDesignFileReason : int
    {
        SYSTEM_NEWFILE_CLOSE = 0,
        SYSTEM_NEWFILE_COMPLETE = 1,
    };

    public enum FileOutdatedCheck_Reason : int
    {
        FILEOUTDATED_REF_QUERY = 1,
        FILEOUTDATED_REF_RELOAD = 2,
        FILEOUTDATED_REF_FORCERELOAD = 3,
    };

    public enum LockChanged_Events : int
    {
        LOCKCHANGED_Snap = 1,
        LOCKCHANGED_Grid = 2,
        LOCKCHANGED_Unit = 3,
        LOCKCHANGED_Angle = 5,
        LOCKCHANGED_Textnode = 6,
        LOCKCHANGED_Axis = 7,
        LOCKCHANGED_Scale = 8,
        LOCKCHANGED_GraphicGroup = 9,
        LOCKCHANGED_Level = 10,
        LOCKCHANGED_CellStretch = 11,
        LOCKCHANGED_ConstructionPlane = 13,
        LOCKCHANGED_Isometric = 14,
        LOCKCHANGED_Association = 15,
        LOCKCHANGED_Depth = 16,
        LOCKCHANGED_ConstructionPlanePerp = 17,
        LOCKCHANGED_FenceMode = 18,
        LOCKCHANGED_IsometricPlane = 19,
        LOCKCHANGED_UseAnnotationScale = 20,
        LOCKCHANGED_ACSContext = 21,
        LOCKCHANGED_ElementTemplateAssociation = 22,
        LOCKCHANGED_SharedCells = 23,
    };

    public enum BatchProcessing_States : int
    {
        PROCESSSTATE_Inactive = 0,
        PROCESSSTATE_Processing = 1,
        PROCESSSTATE_Paused = 2,
        PROCESSSTATE_Done = 3,
        PROCESSSTATE_Cancelled = 4,
        PROCESSSTATE_OpeningFile = 5,
        PROCESSSTATE_AnalyzeFile = 6,
        PROCESSSTATE_ClosedFile = 7,
    };

    public enum MlineStyleMsgType : int
    {
        MLINESTYLE_PreActivate = 0,
        MLINESTYLE_PostActivate,
        MLINESTYLE_PostAdd,
        MLINESTYLE_PostDelete,
        MLINESTYLE_PostChange,
        MLINESTYLE_UndoDelete,
        MLINESTYLE_UndoAdd,
        MLINESTYLE_UndoModify,
        MLINESTYLE_RedoDelete,
        MLINESTYLE_RedoAdd,
        MLINESTYLE_RedoModify,
        MLINESTYLE_PreActivateByName,
    };

    public enum SymbChangeMsgType : int
    {
        SYMBCHANGE_PreColorChange = 0,
        SYMBCHANGE_PostColorChange,
        SYMBCHANGE_PreWeightChange,
        SYMBCHANGE_PostWeightChange,
        SYMBCHANGE_PreLinestyleChange,
        SYMBCHANGE_PostLinestyleChange,
    };

    public enum SystemRefAttachQueueState : int
    {
        SYSTEM_REFATTACHQUEUE_Start = 1,
        SYSTEM_REFATTACHQUEUE_Done = 2,
    };

    public enum DigitalRightsEncryptionPermissions : int
    {
        DIGITAL_RIGHTS_ENCRYPTION_PERMISSIONS_None = 0,
        DIGITAL_RIGHTS_ENCRYPTION_PERMISSIONS_Password = 1,
        DIGITAL_RIGHTS_ENCRYPTION_PERMISSIONS_Certificate = 2,
        DIGITAL_RIGHTS_ENCRYPTION_PERMISSIONS_Everyone = 4,
        DIGITAL_RIGHTS_ENCRYPTION_PERMISSIONS_Any = 7,
    };

    public enum SubstituteElemStatus : int
    {
        SUBSTELEM_STATUS_Normal = 0,
        SUBSTELEM_STATUS_Block = 1,
    };

    public enum LevelMaskOperation : int
    {
        Off = 0,
        On = 1,
        Toggle = 2,
    };

    public enum RasterTileMode : int
    {
        TILE_DEFAULT = 0,
        TILE_MANDATORY = 1,
        TILE_NO = 2,
        TILE_YES = 3,
    };

    public enum ImageBlockType : int
    {
        BLOCKTYPE_LINE = 1,
        BLOCKTYPE_TILE = 2,
        BLOCKTYPE_STRIP = 3,
        BLOCKTYPE_IMAGE = 4,
    };

    public enum _Uninitialized : int
    {
        _Noinit,
    };

    public enum float_denorm_style : int
    {
        denorm_indeterminate = -1,
        denorm_absent = 0,
        denorm_present = 1,
    };

    public enum float_round_style : int
    {
        round_indeterminate = -1,
        round_toward_zero = 0,
        round_to_nearest = 1,
        round_toward_infinity = 2,
        round_toward_neg_infinity = 3,
    };

    public enum memory_order : int
    {
        memory_order_relaxed,
        memory_order_consume,
        memory_order_acquire,
        memory_order_release,
        memory_order_acq_rel,
        memory_order_seq_cst,
    };

    public enum pointer_safety : int
    {
        relaxed,
        preferred,
        strict,
    };

    public enum _Codecvt_mode : int
    {
        _Consume_header = 4,
        _Generate_header = 2,
    };

    public enum errc : int
    {
        address_family_not_supported = 102,
        address_in_use = 100,
        address_not_available = 101,
        already_connected = 113,
        argument_list_too_long = 7,
        argument_out_of_domain = 33,
        bad_address = 14,
        bad_file_descriptor = 9,
        bad_message = 104,
        broken_pipe = 32,
        connection_aborted = 106,
        connection_already_in_progress = 103,
        connection_refused = 107,
        connection_reset = 108,
        cross_device_link = 18,
        destination_address_required = 109,
        device_or_resource_busy = 16,
        directory_not_empty = 41,
        executable_format_error = 8,
        file_exists = 17,
        file_too_large = 27,
        filename_too_long = 38,
        function_not_supported = 40,
        host_unreachable = 110,
        identifier_removed = 111,
        illegal_byte_sequence = 42,
        inappropriate_io_control_operation = 25,
        interrupted = 4,
        invalid_argument = 22,
        invalid_seek = 29,
        io_error = 5,
        is_a_directory = 21,
        message_size = 115,
        network_down = 116,
        network_reset = 117,
        network_unreachable = 118,
        no_buffer_space = 119,
        no_child_process = 10,
        no_link = 121,
        no_lock_available = 39,
        no_message_available = 120,
        no_message = 122,
        no_protocol_option = 123,
        no_space_on_device = 28,
        no_stream_resources = 124,
        no_such_device_or_address = 6,
        no_such_device = 19,
        no_such_file_or_directory = 2,
        no_such_process = 3,
        not_a_directory = 20,
        not_a_socket = 128,
        not_a_stream = 125,
        not_connected = 126,
        not_enough_memory = 12,
        not_supported = 129,
        operation_canceled = 105,
        operation_in_progress = 112,
        operation_not_permitted = 1,
        operation_not_supported = 130,
        operation_would_block = 140,
        owner_dead = 133,
        permission_denied = 13,
        protocol_error = 134,
        protocol_not_supported = 135,
        read_only_file_system = 30,
        resource_deadlock_would_occur = 36,
        resource_unavailable_try_again = 11,
        result_out_of_range = 34,
        state_not_recoverable = 127,
        stream_timeout = 137,
        text_file_busy = 139,
        timed_out = 138,
        too_many_files_open_in_system = 23,
        too_many_files_open = 24,
        too_many_links = 31,
        too_many_symbolic_link_levels = 114,
        value_too_large = 132,
        wrong_protocol_type = 136,
    };

    public enum io_errc : int
    {
        stream = 1,
    };

    public enum _CTIMESPANFORMATSTEP : int
    {
        _CTFS_NONE = 0,
        _CTFS_FORMAT = 1,
        _CTFS_NZ = 2,
    };

    public enum BentleyTrueFalse : int
    {
        TRUE = 1,
        FALSE = 0,
    };

    public enum BentleyStatus : int
    {
        SUCCESS = 0,
        BSISUCCESS = 0,
        ERROR = 32768,
        BSIERROR = 32768,
    };

    public enum BentleyCharEncoding : int
    {
        Locale = 0,
        Utf8 = 1,
    };

    public enum BeFileNameStatus : int
    {
        Success = 0,
        IllegalName = 1,
        AlreadyExists = 2,
        CantCreate = 3,
        FileNotFound = 4,
        CantDeleteFile = 5,
        AccessViolation = 6,
        CantDeleteDir = 7,
        UnknownError = 32768,
    };

    public enum BeFileNameAccess : int
    {
        Exists = 0,
        Read = 4,
        Write = 2,
        ReadWrite = 6,
    };

    public enum LangCodePage : int
    {
        Unknown = -1,
        None = 0,
        OEM_US = 437,
        Transparent_ASMO = 720,
        OEM_Greek = 737,
        OEM_Baltic = 775,
        OEM_Multilingual = 850,
        OEM_LatinII = 852,
        OEM_Cryllic = 855,
        OEM_Turkish = 857,
        OEM_LatinI = 858,
        OEM_Hebrew = 862,
        OEM_Russian = 866,
        OEM_Thai = 874,
        Japanese = 932,
        Simplified_Chinese = 936,
        Korean = 949,
        Traditional_Chinese = 950,
        Unicode = 1200,
        UNICODE_UCS2_Little_Endian = 1200,
        UNICODE_UCS2_Big_Endian = 1201,
        Central_European = 1250,
        Cyrillic = 1251,
        LatinI = 1252,
        Greek = 1253,
        Turkish = 1254,
        Hebrew = 1255,
        Arabic = 1256,
        Baltic = 1257,
        Vietnamese = 1258,
        Johab = 1361,
        ISO_8859_1 = 28591,
        ISO_8859_2 = 28592,
        ISO_8859_3 = 28593,
        ISO_8859_4 = 28594,
        ISO_8859_5 = 28595,
        ISO_8859_6 = 28596,
        ISO_8859_7 = 28597,
        ISO_8859_8 = 28598,
        ISO_8859_9 = 28599,
        ISO_8859_15 = 28605,
        ISCII_UNICODE_UTF_7 = 65000,
        ISCII_UNICODE_UTF_8 = 65001,
    };

    public enum HexFormatOptions : int
    {
        None = 0,
        LeftJustify = 1,
        IncludePrefix = 2,
        Uppercase = 4,
        LeadingZeros = 8,
        UsePrecision = 16,
    };

    public enum LocalCoordinateSelect : int
    {
        LOCAL_COORDINATE_SCALE_UnitAxesAtStart,
        LOCAL_COORDINATE_SCALE_UnitAxesAtLowerLeft,
        LOCAL_COORDINATE_SCALE_01RangeBothAxes,
        LOCAL_COORDINATE_SCALE_01RangeLargerAxis,
    };

    public enum CurveParameterMapping : int
    {
        CURVE_PARAMETER_MAPPING_BezierFraction = 0,
        CURVE_PARAMETER_MAPPING_CurveKnot = 1,
        CURVE_PARAMETER_MAPPING_CurveFraction = 2,
    };

    public enum FacetParamMode : int
    {
        FACET_PARAM_01BothAxes = 0,
        FACET_PARAM_01LargerAxis = 1,
        FACET_PARAM_Distance = 2,
    };

    public enum BlendType : int
    {
        CURVE_CURVE_BLEND_BisectorParabola,
        CURVE_CURVE_BLEND_VerticalAxisParabola,
    };

    public enum AreaSelect : int
    {
        AreaSelect_Parity = 0,
        AreaSelect_CCWPositiveWindingNumber = 1,
        AreaSelect_CCWNonzeroWindingNumber = 2,
        AreaSelect_CCWNegativeWindingNumber = 3,
    };

    public enum BoolSelect : int
    {
        BoolSelect_Parity = 0,
        BoolSelect_Union = 2,
        BoolSelect_Summed_Parity = 3,
        BoolSelect_Summed_Positive = 4,
        BoolSelect_Summed_NonZero = 5,
        BoolSelect_Summed_Negative = 6,
        BoolSelect_FromStructure = 1000,
    };

    public enum ClipPlaneContainment : int
    {
        ClipPlaneContainment_StronglyInside = 1,
        ClipPlaneContainment_Ambiguous = 2,
        ClipPlaneContainment_StronglyOutside = 3,
    };

    public enum SolidPrimitiveType : int
    {
        SolidPrimitiveType_None,
        SolidPrimitiveType_DgnTorusPipe,
        SolidPrimitiveType_DgnCone,
        SolidPrimitiveType_DgnBox,
        SolidPrimitiveType_DgnSphere,
        SolidPrimitiveType_DgnExtrusion,
        SolidPrimitiveType_DgnRotationalSweep,
        SolidPrimitiveType_DgnRuledSweep,
    };

    public enum ReprojectStatus : int
    {
        REPROJECT_Success = 0,
        REPROJECT_CSMAPERR_OutOfUsefulRange = 1,
        REPROJECT_CSMAPERR_OutOfMathematicalDomain = 2,
        REPROJECT_CSMAPERR_DatumConverterNotSet = 25,
        REPROJECT_CSMAPERR_VerticalDatumConversionError = 26,
        REPROJECT_CSMAPERR_Error = 4096,
        REPROJECT_BadArgument = 100,
        REPROJECT_NoChange = 101,
        REPROJECT_StrokeError = 102,
        REPROJECT_DataError = 103,
        REPROJECT_DontValidateRange = 104,
    };

    public enum PlanePolygonSSICode : int
    {
        Unknown = 0,
        Transverse = 1,
        Coincident = 2,
    };

    public enum PrecisionType : int
    {
        Decimal = 0,
        Fractional = 1,
        Scientific = 2,
    };

    public enum PrecisionFormat : int
    {
        DecimalWhole = 100,
        Decimal1Place = 101,
        Decimal2Places = 102,
        Decimal3Places = 103,
        Decimal4Places = 104,
        Decimal5Places = 105,
        Decimal6Places = 106,
        Decimal7Places = 107,
        Decimal8Places = 108,
        FractionalWhole = 200,
        FractionalHalf = 201,
        FractionalQuarter = 202,
        FractionalEighth = 203,
        FractionalSixteenth = 204,
        Fractional1_Over_32 = 205,
        Fractional1_Over_64 = 206,
        Fractional1_Over_128 = 207,
        Fractional1_Over_256 = 208,
        ScientificWhole = 300,
        Scientific1Place = 301,
        Scientific2Places = 302,
        Scientific3Places = 303,
        Scientific4Places = 304,
        Scientific5Places = 305,
        Scientific6Places = 306,
        Scientific7Places = 307,
        Scientific8Places = 308,
    };

    public enum BitMaskOperation : int
    {
        Or = 1,
        And = 2,
        Xor = 3,
        OrNot = 4,
        AndNot = 5,
    };

    public enum GPCurveType : int
    {
        Invalid = 0,
        LineString = 1,
        Ellipse = 2,
        Bezier = 3,
        BSpline = 4,
    };

    public enum ScanListTypeMasks : int
    {
        ELEMDATA = 1,
        NESTCELL = 2,
        PICKCELL = 4,
        PROPCLAS = 8,
        GRPHGRP = 16,
        MULTI = 32,
        SKEW = 64,
        BOTH = 128,
        ONEELEM = 256,
        ATTRENT = 1024,
        ATTROCC = 2048,
        STOPSECT = 4096,
        LEVELS = 8192,
        ELEMTYPE = 16384,
        RETURN3D = 1,
        FILEPOS = 2,
        EXTATTR = 8,
        ITERATEFUNC = 16,
        ELENEW = 512,
        ELEMOD = 1024,
        ELEINVISIBLE = 128,
        ELERELTVE = 4096,
        ELEPLANR = 8192,
        ELESNAP = 16384,
        ELEHOLE = 32768,
    };

    public enum RefAttachNestMode : int
    {
        None = 0,
        Copy = 1,
        Display = 2,
    };

    public enum DgnModelType : int
    {
        Normal = 0,
        Sheet = 1,
        Extraction_Deprecated = 2,
        Drawing = 3,
        DgnComponentDefinition = 4,
    };

    public enum CellLibraryType : int
    {
        Invalid = -1,
        Graphic = 0,
        Menu = 1,
        CBMenu = 2,
        MatrixMenu = 4,
        Point = 7,
        Parametric = 8,
        Block = 101,
    };

    public enum StandardView : int
    {
        NotStandard = -1,
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4,
        Front = 5,
        Back = 6,
        Iso = 7,
        RightIso = 8,
    };

    public enum MSRenderMode : int
    {
        Invalid = -1,
        Wireframe = 0,
        CrossSection = 1,
        Wiremesh = 2,
        HiddenLine = 3,
        SolidFill = 4,
        ConstantShade = 5,
        SmoothShade = 6,
        Phong = 7,
        RayTrace = 8,
        RenderWireframe = 9,
        Radiosity = 10,
        ParticleTrace = 11,
        RenderLuxology = 12,
        RenderVue = 13,
        GPUPathTrace = 14,
    };

    public enum GradientMode : int
    {
        None = 0,
        Linear = 1,
        Curved = 2,
        Cylindrical = 3,
        Spherical = 4,
        Hemispherical = 5,
    };

    public enum AngleFormatVals : int
    {
        None = -2,
        Active = -1,
        Degrees = 0,
        DegMinSec = 1,
        Centesimal = 2,
        Radians = 3,
        DegMin = 4,
        Surveyor = 5,
    };

    public enum SelectionMode : int
    {
        New = 0,
        Add = 1,
        Subtract = 2,
        Inverse = 3,
        Clear = 4,
        All = 5,
    };

    public enum LocateSurfacesPref : int
    {
        Never = 0,
        ByView = 1,
        Always = 2,
    };

    public enum UnitBase : int
    {
        None = 0,
        Meter = 1,
        Degree = 2,
    };

    public enum StandardUnit : int
    {
        None = 0,
        EnglishFirst = 1000,
        EnglishMiles = 1050,
        EnglishYards = 1075,
        EnglishFeet = 1100,
        EnglishInches = 1125,
        EnglishPicas = 1130,
        EnglishPoints = 1135,
        EnglishMils = 1150,
        EnglishMicroInches = 1175,
        EnglishLast = 1225,
        EnglishSurveyMiles = 1049,
        EnglishFurlongs = 1055,
        EnglishChains = 1060,
        EnglishRods = 1065,
        EnglishFathoms = 1070,
        EnglishSurveyFeet = 1099,
        EnglishSurveyInches = 1124,
        MetricFirst = 2000,
        MetricPetameters = 2010,
        MetricTerameters = 2020,
        MetricGigameters = 2030,
        MetricMegameters = 2040,
        MetricKilometers = 2050,
        MetricHectometers = 2060,
        MetricDekameters = 2070,
        MetricMeters = 2075,
        MetricDecimeters = 2090,
        MetricCentimeters = 2100,
        MetricMillimeters = 2125,
        MetricMicrometers = 2150,
        MetricNanometers = 2160,
        MetricPicometers = 2180,
        MetricFemtometers = 2190,
        MetricLast = 2225,
        NoSystemFirst = 3000,
        NoSystemParsecs = 3100,
        NoSystemLightYears = 3200,
        NoSystemAstronomicalUnits = 3300,
        NoSystemNauticalMiles = 3500,
        NoSystemAngstroms = 3800,
        NoSystemLast = 3900,
        UnitlessWhole = 4000,
        AngleRadians = 4500,
        AngleDegrees = 4550,
        AngleGrads = 4575,
        AngleMinutes = 4600,
        AngleSeconds = 4650,
        Custom = 5000,
    };

    public enum AngleMode : int
    {
        Invalid = 0,
        Degrees = 1,
        DegMin = 2,
        DegMinSec = 3,
        Centesimal = 4,
        Radians = 5,
    };

    public enum AnglePrecision : int
    {
        Whole = 0,
        Use1Place = 1,
        Use2Places = 2,
        Use3Places = 3,
        Use4Places = 4,
        Use5Places = 5,
        Use6Places = 6,
        Use7Places = 7,
        Use8Places = 8,
    };

    public enum DgnUnitFormat : int
    {
        MUSU = 0,
        MU = 1,
        MUSUPU = 2,
        SU = 3,
    };

    public enum DirectionMode : int
    {
        Invalid = 0,
        Azimuth = 1,
        Bearing = 2,
    };

    public enum DirectionBase : int
    {
        North = 0,
        South = 1,
        East = 2,
        West = 3,
        Custom = 4,
    };

    public enum GridConfiguration : int
    {
        Orthogonal = 0,
        Isometric = 1,
        Offset = 2,
    };

    public enum IsometricPlane : int
    {
        Top = 0,
        Left = 1,
        Right = 2,
        All = 3,
    };

    public enum FenceMode : int
    {
        Inside = 0,
        Overlap = 1,
        Clip = 2,
        Void = 3,
        VoidOverlap = 4,
        VoidClip = 5,
    };

    public enum DateTimeFormatPart : int
    {
        DATETIME_PART_DayOfWeek,
        DATETIME_PART_DoW,
        DATETIME_PART_D,
        DATETIME_PART_DD,
        DATETIME_PART_Month,
        DATETIME_PART_Mon,
        DATETIME_PART_M,
        DATETIME_PART_MM,
        DATETIME_PART_d,
        DATETIME_PART_ddd,
        DATETIME_PART_YYYY,
        DATETIME_PART_YY,
        DATETIME_PART_h,
        DATETIME_PART_hh,
        DATETIME_PART_H,
        DATETIME_PART_HH,
        DATETIME_PART_m,
        DATETIME_PART_mm,
        DATETIME_PART_s,
        DATETIME_PART_ss,
        DATETIME_PART_FractionalSeconds,
        DATETIME_PART_Comma,
        DATETIME_PART_DateSeparator,
        DATETIME_PART_TimeSeparator,
        DATETIME_PART_DecimalSeparator,
        DATETIME_PART_Space,
        DATETIME_PART_AMPM,
        DATETIME_PART_AP,
        DATETIME_PART_U,
        DATETIME_PART_UU,
        DATETIME_PART_U_UU,
        DATETIME_PART_UU_UU,
        DATETIME_PART_UTC,
        DATETIME_PART_h_mm_AMPM = 100,
        DATETIME_PART_h_mm_ss_AMPM,
        DATETIME_PART_M_D_YYYY,
        DATETIME_PART_MM_DD_YYYY,
        DATETIME_PART_Day_D_Month_YYYY,
        DATETIME_PART_Day_Month_D_YYYY,
        DATETIME_PART_Full,
        DATETIME_PART_General,
    };

    public enum DgnFileFormatType : int
    {
        Invalid = -1,
        Current = 0,
        V7 = 1,
        V8 = 2,
        DWG = 3,
        DXF = 4,
    };

    public enum DwgUnitFormat : int
    {
        Scientific = 1,
        Decimal = 2,
        Engineering = 3,
        Architectural = 4,
        Fractional = 5,
    };

    public enum ResourceTextStyleProperty : int
    {
        DGNPLATFORM_RESOURCE_TextStyle_LineSpacing = 30,
        DGNPLATFORM_RESOURCE_TextStyle_InterCharSpacing = 33,
    };

    public enum DimensionType : int
    {
        None = 0,
        SizeArrow = 1,
        SizeStroke = 2,
        LocateSingle = 3,
        LocateStacked = 4,
        AngleSize = 5,
        ArcSize = 6,
        AngleLocation = 7,
        ArcLocation = 8,
        AngleLines = 9,
        AngleAxis = 10,
        Radius = 11,
        Diameter = 12,
        DiameterParallel = 13,
        DiameterPerpendicular = 14,
        CustomLinear = 15,
        Ordinate = 16,
        RadiusExtended = 17,
        DiameterExtended = 18,
        Center = 19,
        AngleAxisX = 50,
        AngleAxisY = 51,
        LabelLine = 52,
        Note = 53,
        MaxThatHasTemplate = 19,
        Max = 53,
    };

    public enum TextElementJustification : int
    {
        LeftTop = 0,
        LeftMiddle = 1,
        LeftBaseline = 2,
        LeftDescender = 16,
        CenterTop = 6,
        CenterMiddle = 7,
        CenterBaseline = 8,
        CenterDescender = 20,
        RightTop = 12,
        RightMiddle = 13,
        RightBaseline = 14,
        RightDescender = 24,
        LeftMarginTop = 3,
        LeftMarginMiddle = 4,
        LeftMarginBaseline = 5,
        LeftMarginDescender = 18,
        RightMarginTop = 9,
        RightMarginMiddle = 10,
        RightMarginBaseline = 11,
        RightMarginDescender = 22,
        LeftCap = 15,
        LeftMarginCap = 17,
        CenterCap = 19,
        RightCap = 23,
        RightMarginCap = 21,
        Invalid = 127,
    };

    public enum MlineOffsetMode : int
    {
        Unknown = -1,
        ByWork = 0,
        ByCenter = 1,
        ByMax = 2,
        ByMin = 3,
        Custom = 4,
    };

    public enum MlineBreakLengthType : int
    {
        MLBREAK_STD = 0,
        MLBREAK_FROM_JOINT = 32768,
        MLBREAK_TO_JOINT = 16384,
        MLBREAK_BETWEEN_JOINTS = 49152,
    };

    public enum LineStyleProp : int
    {
        LINESTYLE_PROP_Invalid = 0,
        LINESTYLE_PROP_Stroke = 101,
        LINESTYLE_PROP_Component = 102,
        LINESTYLE_PROP_LineCode = 103,
        LINESTYLE_PROP_PointSymbol = 104,
        LINESTYLE_PROP_LinePoint = 105,
        LINESTYLE_PROP_Compound = 106,
        LINESTYLE_PROP_Symbol = 107,
        LINESTYLE_PROP_Type_WCHAR = 150,
        LINESTYLE_PROP_LineCode_Description_WCHAR = 200,
        LINESTYLE_PROP_LineCode_PhaseMode_INTEGER = 201,
        LINESTYLE_PROP_LineCode_PhaseDist_DOUBLE = 202,
        LINESTYLE_PROP_LineCode_SegmentMode_BOOLINT = 203,
        LINESTYLE_PROP_LineCode_NumIterations_INTEGER = 204,
        LINESTYLE_PROP_LineCode_NumStrokes_INTEGER = 205,
        LINESTYLE_PROP_Stroke_Length_DOUBLE = 250,
        LINESTYLE_PROP_Stroke_StartWidth_DOUBLE = 251,
        LINESTYLE_PROP_Stroke_EndWidth_DOUBLE = 252,
        LINESTYLE_PROP_Stroke_Type_BOOLINT = 253,
        LINESTYLE_PROP_Stroke_Corner_BOOLINT = 254,
        LINESTYLE_PROP_Stroke_Fixed_BOOLINT = 255,
        LINESTYLE_PROP_Stroke_StartInvert_BOOLINT = 256,
        LINESTYLE_PROP_Stroke_EndInvert_BOOLINT = 257,
        LINESTYLE_PROP_Stroke_WidthMode_INTEGER = 258,
        LINESTYLE_PROP_Stroke_DashCaps_INTEGER = 259,
        LINESTYLE_PROP_Compound_Description_WCHAR = 300,
        LINESTYLE_PROP_Compound_NumComponents_INTEGER = 301,
        LINESTYLE_PROP_CompoundComp_Offset_DOUBLE = 351,
        LINESTYLE_PROP_LinePoint_Description_WCHAR = 400,
        LINESTYLE_PROP_LinePoint_NumSymbols_INTEGER = 401,
        LINESTYLE_PROP_PointSym_StrokeNum_INTEGER = 450,
        LINESTYLE_PROP_PointSym_Location_INTEGER = 451,
        LINESTYLE_PROP_PointSym_ColorFromSymbol_BOOLINT = 452,
        LINESTYLE_PROP_PointSym_WeightFromSymbol_BOOLINT = 453,
        LINESTYLE_PROP_PointSym_Partial_INTEGER = 454,
        LINESTYLE_PROP_PointSym_Clip_BOOLINT = 455,
        LINESTYLE_PROP_PointSym_AllowStretch_BOOLINT = 456,
        LINESTYLE_PROP_PointSym_Justification_INTEGER = 457,
        LINESTYLE_PROP_PointSym_OffsetX_DOUBLE = 458,
        LINESTYLE_PROP_PointSym_OffsetY_DOUBLE = 459,
        LINESTYLE_PROP_PointSym_OffsetZ_DOUBLE = 460,
        LINESTYLE_PROP_PointSym_Rotation_INTEGER = 461,
        LINESTYLE_PROP_PointSym_AngleX_DOUBLE = 462,
        LINESTYLE_PROP_PointSym_AngleY_DOUBLE = 463,
        LINESTYLE_PROP_PointSym_AngleZ_DOUBLE = 464,
        LINESTYLE_PROP_PointSym_ScaleX_DOUBLE = 465,
        LINESTYLE_PROP_PointSym_ScaleY_DOUBLE = 466,
        LINESTYLE_PROP_PointSym_ScaleZ_DOUBLE = 467,
        LINESTYLE_PROP_PointSymCell_Name_WCHAR = 500,
    };

    public enum LineStyleProp_Type : int
    {
        LSTYLE_PROPTYPE_None = 0,
        LSTYLE_PROPTYPE_BoolInt = 1,
        LSTYLE_PROPTYPE_Distance = 2,
        LSTYLE_PROPTYPE_Double = 3,
        LSTYLE_PROPTYPE_Integer = 4,
        LSTYLE_PROPTYPE_MSWChar = 5,
    };

    public enum LineCodeOptionFlags : int
    {
        LCOPT_NONE = 0,
        LCOPT_AUTOPHASE = 1,
        LCOPT_RES1 = 2,
        LCOPT_RES2 = 4,
        LCOPT_ITERATION = 8,
        LCOPT_SEGMENT = 16,
        LCOPT_CENTERSTRETCH = 32,
    };

    public enum LineCodeStrokeFlags : int
    {
        LCSTROKE_DASH = 1,
        LCSTROKE_GAP = 0,
        LCSTROKE_RAY = 2,
        LCSTROKE_SCALE = 4,
        LCSTROKE_SDASH = 5,
        LCSTROKE_SGAP = 4,
        LCSTROKE_SINVERT = 8,
        LCSTROKE_EINVERT = 16,
    };

    public enum LineCodeWidth : int
    {
        LCWIDTH_NONE = 0,
        LCWIDTH_LEFT = 1,
        LCWIDTH_RIGHT = 2,
        LCWIDTH_FULL = 3,
        LCWIDTH_TAPER = 4,
        LCWIDTH_TAPEREND = 8,
    };

    public enum LineCodeCap : int
    {
        LCCAP_CLOSED = 0,
        LCCAP_OPEN = 1,
        LCCAP_EXTENDED = 2,
        LCCAP_HEXAGON = 3,
        LCCAP_OCTAGON = 4,
        LCCAP_DECAGON = 5,
        LCCAP_ARC = 30,
    };

    public enum LineCodeMod : int
    {
        LCPOINT_NONE = 0,
        LCPOINT_ORIGIN = 1,
        LCPOINT_END = 2,
        LCPOINT_CENTER = 3,
        LCPOINT_ONSTROKE = 3,
        LCPOINT_LINEORG = 4,
        LCPOINT_LINEEND = 8,
        LCPOINT_LINEVERT = 16,
        LCPOINT_ADJROT = 32,
        LCPOINT_ABSROT = 64,
        LCPOINT_NOSCALE = 256,
        LCPOINT_NOCLIP = 512,
        LCPOINT_NOPARTIAL = 1024,
        LCPOINT_PROJECT = 2048,
        LCPOINT_COLOR = 16384,
        LCPOINT_WEIGHT = 32768,
    };

    public enum SnapMode : int
    {
        Invalid = -1,
        First = 0,
        None = 0,
        Nearest = 1,
        NearestKeypoint = 2,
        MidPoint = 4,
        Center = 8,
        Origin = 16,
        Bisector = 32,
        Intersection = 64,
        Tangency = 128,
        TangentPoint = 256,
        Perpendicular = 512,
        PerpendicularPoint = 1024,
        Parallel = 2048,
        Multi3 = 4096,
        PointOn = 8192,
        Multi1 = 16384,
        Multi2 = 32768,
        MultiSnaps = 53248,
    };

    public enum DgnElementClass : int
    {
        Primary = 0,
        PatternComponent = 1,
        Construction = 2,
        Dimension = 3,
        PrimaryRule = 4,
        LinearPatterned = 5,
        ConstructionRule = 6,
    };

    public enum Visualization : int
    {
        ShadowQuality_PerLight,
        ShadowQuality_Sharp,
        ShadowQuality_SoftCoarse,
        ShadowQuality_SoftMedium,
        ShadowQuality_SoftFine,
        ShadowQuality_SoftVeryFine,
        AntialiasFilter_Box,
        AntialiasFilter_Triangle,
        AntialiasFilter_Gaussian,
        AntialiasFilter_CatmullRom,
        AntialiasFilter_MitchellNetravali,
        AntialiasQuality_None,
        AntialiasQuality_Low,
        AntialiasQuality_Medium,
        AntialiasQuality_High,
        AntialiasQuality_VeryHigh,
        Custom,
        TextureFilteringOverride_PerMaterial,
        TextureFilteringOverride_Nearest,
        TextureFilteringOverride_Bilinear,
        TextureFilteringOverride_Bicubic,
        TextureAntialiasingOverride_PerMaterial,
        TextureAntialiasingOverride_On,
        TextureAntialiasingOverride_Off,
        IndirectCaustics_None,
        IndirectCaustics_Reflection,
        IndirectCaustics_Refraction,
        IndirectCaustics_Both,
        SubSurfaceScattering_DirectOnly,
        SubSurfaceScattering_IndirectAffectsScattering,
        SubSurfaceScattering_ScatteringAffectsDirect,
        SubSurfaceScattering_Both,
        UseIrradianceCacheFor_FirstAndSecondBounces,
        UseIrradianceCacheFor_FirstBounceOnly,
        UseIrradianceCacheFor_SecondBounceOnly,
        RenderOutput_ColorAlpha,
        RenderOutput_AmbientOcclusion,
        RenderOutput_Depth,
        RenderOutput_ShadowDensity,
        RenderOutput_ColorOnly,
        RenderOutput_Alpha,
        RenderOutput_ReflectionShading,
        RenderOutput_SpecularShading,
        RenderOutput_SubsurfaceShading,
        RenderOutput_TransparentShading,
        RenderOutput_IlluminationTotal,
        RenderOutput_IlluminationIndirect,
        RenderOutput_IlluminationDirect,
        RenderEnvironment_Main,
        RenderEnvironment_Indirect,
        RenderEnvironment_Sky,
        RenderEnvironment_LightProbe,
        RenderEnvironment_Image,
        RenderEnvironment_ImageCube,
        RenderEnvironment_Gradient,
        RenderEnvironment_Planar,
        RenderEnvironment_Cylindrical,
        RenderEnvironment_Spherical,
        RenderEnvironment_Cubic,
        RenderEnvironment_Front,
        RenderEnvironment_BackgroundBlank,
        RenderEnvironment_BackgroundColor,
        RenderEnvironment_BackgroundImage,
        RenderEnvironment_FogExponential,
        RenderEnvironment_FogLinear,
        LIGHTTYPE_Distant,
        LIGHTTYPE_Point,
        LIGHTTYPE_Spot,
        LIGHTTYPE_Area,
        LIGHTTYPE_SkyOpening,
        Light_Raytrace,
        Ligth_DeepShadowMap,
        ColorType_Custom,
        ColorType_ColorMap,
        ColorMapStype_Image,
        ColorMapStype_Procedure,
        LxoProcedureType_Noise,
        LxoProcedureType_Checker,
        LxoProcedureType_Grid,
        LxoProcedureType_Dots,
        LxoProcedureType_Constant,
        LxoProcedureType_Cellular,
        LxoProcedureType_Wood,
        LxoProcedureType_Weave,
        LxoProcedureType_Ripples,
        LxoProcedureType_Gradient,
        LxoNoiseType_Simple,
        LxoNoiseType_Fractal,
        LxoNoiseType_Turbulence,
        LxoCheckerType_Square,
        LxoCheckerType_Cube,
        LxoGridType_Line,
        LxoGridType_Triangle,
        LxoGridType_Square,
        LxoGridType_Hexagon,
        LxoGridType_Cube,
        LxoDotType_Square,
        LxoDotType_Hexagon,
        LxoDotType_Cube,
        LxoCellType_Round,
        LxoCellType_Angular,
        ColorMap_Wrap_Repeat,
        ColorMap_Wrap_Reset,
        ColorMap_Wrap_Mirror,
        ColorMap_Wrap_Edge,
        DirectLightMIS_None,
        DirectLightMIS_Diffuse,
        DirectLightMIS_Specular,
        DirectLightMIS_Both,
        Glow_None,
        Glow_DimNeon,
        Glow_ComputerScreen,
        Glow_FluorescentLamp,
        Glow_BrightNeon,
        StereoOutput_Anaglyph,
        StereoOutput_StereoPair,
        IRNone,
        IRRotationOnly,
        IRTranslationOnly,
        IRBoth,
        Refract_Air,
        Refract_Ice,
        Refract_Water,
        Refract_Plastic,
        Refract_GlassPyrex,
        Refract_Plexiglas,
        Refract_LapisLazuli,
        Refract_Salt,
        Refract_GlassCrown,
        Refract_Amethyst,
        Refract_Amber,
        Refract_Emerald,
        Refract_GlassFlintLight,
        Refract_Topaz,
        Refract_GlassFlintMedium,
        Refract_Ruby,
        Refract_Zircon,
        Refract_GlassFlintDense,
        Refract_Crystal,
        Refract_Diamond,
        Refract_CopperOxide,
        Refract_IodineCrystal,
        Dispersion_None,
        Dispersion_Fluorite,
        Dispersion_SilicaGlass,
        Dispersion_Quartz,
        Dispersion_Zircon,
        Dispersion_Diamond,
        RoughnessState_Custom,
        RoughnessState_LinkToSpecular,
        FresnelState_Custom,
        FresnelState_LinkToReflect,
        BaseColorState_Custom,
        BaseColorState_UseElementColor,
        FurType_Strips,
        FurType_Cylinders,
        Billboard_None,
        Billboard_Trees,
        Billboard_Leaves,
        FinishState_On,
        FinishState_Off,
        FinishState_LockToSpecular,
        IndirectIllumType_None,
        IndirectIllumType_MonteCarlo,
        IndirectIllumType_IrradianceCaching,
        BackFaceCulling_UseGeometryDefault,
        BackFaceCulling_ForceSingleSided,
        BackFaceCulling_ForceDoubleSided,
        SpecularColarState_Custom,
        SpecularColorState_Plastic,
        SpecularColarState_Metallic,
        SpecularColarState_UseElement,
        SpecularColarState_ColorMap,
        ReflectColorState_Custom,
        ReflectColorState_LinkToSpecular,
        ReflectColorState_ColorMap,
        GlowColorState_Custom,
        GlowColorState_LinkToDiffuse,
        GlowColorState_LinkToSpecular,
        GlowColorState_ColorMap,
        MaterialMapState_On,
        MaterialMapState_Off,
        MaterialMapState_LinkToPattern,
        MaterialMapState_LinkToBump,
        MaterialMapState_LinkToSpecular,
        MaterialMapState_LinkToReflect,
        MaterialMapState_LinkToOpacity,
        MaterialMapState_LinkToTranslucency,
        MaterialMapState_LinkToFinish,
        MaterialMapState_LinkToDiffuse,
        MaterialMapState_LinkToGlow,
        MaterialMapState_LinkToClearcoat,
        MaterialMapState_LinkToAnisotropy,
        MaterialMapState_LinkToDisplacement,
        MaterialMapState_LinkToNormal,
        MaterialMapState_LinkToFurLength,
        MaterialMapState_LinkToFurDensity,
        MaterialMapState_LinkToFurJitter,
        MaterialMapState_LinkToFurFlex,
        MaterialMapState_LinkToFurClumps,
        MaterialMapState_LinkToFurDirection,
        MaterialMapState_LinkToFurVector,
        MaterialMapState_LinkToFurBump,
        MaterialMapState_LinkToFurCurls,
        MaterialMapState_LinkToGlowColor,
        MaterialMapState_LinkToReflectColor,
        MaterialMapState_LinkToRefractionRoughness,
        MaterialMapState_LinkToSpecularFresnel,
        MaterialMapState_LinkToGeometry,
        Projection_FromView,
        Projection_Spherical,
        Projection_Cylindrical,
        Projection_SphericalVR,
        Projection_CylindricalVR,
    };

    public enum RefUseColorTable : int
    {
        REFCOLORTABLE_USEPREF = 0,
        REFCOLORTABLE_ALWAYS = 1,
        REFCOLORTABLE_NEVER = 2,
    };

    public enum RefInitialLevelDisplay : int
    {
        REF_FILE_LEVEL_DISPLAY_DEFAULT = 0,
        REF_FILE_LEVEL_DISPLAY_ALL_ON = 1,
        REF_FILE_LEVEL_DISPLAY_ALL_OFF = 2,
    };

    public enum RefLevelOverrides : int
    {
        REFERENCE_LEVEL_OVERRIDES_PER_ATTACHMENT = 0,
        REFERENCE_LEVEL_OVERRIDES_AS_REQUIRED = 1,
        REFERENCE_LEVEL_OVERRIDES_NONE = 2,
    };

    public enum RefNestOverrides : int
    {
        REF_NESTOVERRIDES_ASREQUIRED = 0,
        REF_NESTOVERRIDES_ALWAYS = 1,
        REF_NESTOVERRIDES_NEVER = 2,
    };

    public enum RefNewLevelDisplay : int
    {
        REF_NEWLEVELDISPLAY_FROMCONFIG = 0,
        REF_NEWLEVELDISPLAY_ALWAYS = 1,
        REF_NEWLEVELDISPLAY_NEVER = 2,
    };

    public enum RefGlobalLinestyleScale : int
    {
        REF_GLOBALLINESTYLESCALE_MASTER = 0,
        REF_GLOBALLINESTYLESCALE_NONE = 1,
        REF_GLOBALLINESTYLESCALE_BOTH = 2,
        REF_GLOBALLINESTYLESCALE_REFERENCE = 3,
    };

    public enum RefPlotType : int
    {
        REF_PLOTTYPE_AsDisplayed = 0,
        REF_PLOTTYPE_Wireframe = 1,
        REF_PLOTTYPE_Hidden = 2,
        REF_PLOTTYPE_Rendered = 3,
        REF_PLOTTYPE_UseDisplayStyle = 4,
        REF_PLOTTYPE_UseRenderingStyle = 5,
    };

    public enum MSElementTypes : int
    {
        CELL_HEADER_ELM = 2,
        LINE_ELM = 3,
        LINE_STRING_ELM = 4,
        GROUP_DATA_ELM = 5,
        SHAPE_ELM = 6,
        TEXT_NODE_ELM = 7,
        DIG_SETDATA_ELM = 8,
        DGNFIL_HEADER_ELM = 9,
        LEV_SYM_ELM = 10,
        CURVE_ELM = 11,
        CMPLX_STRING_ELM = 12,
        CMPLX_SHAPE_ELM = 14,
        ELLIPSE_ELM = 15,
        ARC_ELM = 16,
        TEXT_ELM = 17,
        SURFACE_ELM = 18,
        SOLID_ELM = 19,
        BSPLINE_POLE_ELM = 21,
        POINT_STRING_ELM = 22,
        CONE_ELM = 23,
        BSPLINE_SURFACE_ELM = 24,
        BSURF_BOUNDARY_ELM = 25,
        BSPLINE_KNOT_ELM = 26,
        BSPLINE_CURVE_ELM = 27,
        BSPLINE_WEIGHT_ELM = 28,
        DIMENSION_ELM = 33,
        SHAREDCELL_DEF_ELM = 34,
        SHARED_CELL_ELM = 35,
        MULTILINE_ELM = 36,
        ATTRIBUTE_ELM = 37,
        DGNSTORE_COMP = 38,
        DGNSTORE_HDR = 39,
        TYPE44_ELM = 44,
        MICROSTATION_ELM = 66,
        RASTER_HDR = 87,
        RASTER_COMP = 88,
        RASTER_REFERENCE_ELM = 90,
        RASTER_REFERENCE_COMP = 91,
        RASTER_HIERARCHY_ELM = 92,
        RASTER_HIERARCHY_COMP = 93,
        RASTER_FRAME_ELM = 94,
        TABLE_ENTRY_ELM = 95,
        TABLE_ELM = 96,
        VIEW_GROUP_ELM = 97,
        VIEW_ELM = 98,
        LEVEL_MASK_ELM = 99,
        REFERENCE_ATTACH_ELM = 100,
        MSELEMENTTYPES_MaxElements = 113,
    };

    public enum TagType : int
    {
        MS_TAGTYPE_CHAR = 1,
        MS_TAGTYPE_SINT = 2,
        MS_TAGTYPE_LINT = 3,
        MS_TAGTYPE_DOUBLE = 4,
        MS_TAGTYPE_BINARY = 5,
        MS_TAGTYPE_WCHAR = 6,
    };

    public enum TagProperty : int
    {
        TAG_PROP_DISPOFF = 1,
        TAG_PROP_DEF = 2,
        TAG_PROP_CONF = 4,
        TAG_PROP_CONST = 8,
    };

    public enum TagExport : int
    {
        TAG_EXPORT_TAGGED = 1,
        TAG_EXPORT_ALL = 2,
        TAG_EXPORT_TEXT = 1,
        TAG_EXPORT_XML = 2,
    };

    public enum ProxyCachingOption : int
    {
        Live = 0,
        Cached = 1,
        Static = 2,
    };

    public enum ProxyCacheSynch : int
    {
        Manual = 0,
        Alert = 1,
        Automatic = 2,
        Disconnected = 3,
        Unspecified = 65535,
    };

    public enum ReferenceSynchOption : int
    {
        NamedViewClip = 0,
        NamedViewAllSettings = 1,
        NamedViewNotsynced = 2,
        NamedViewCameraAndClip = 3,
        NamedViewPresentation = 4,
    };

    public enum ImageColorMode : int
    {
        Unknown = 65535,
        Any = 0,
        RGB = 1,
        Palette16 = 2,
        Palette256 = 3,
        GreyScale = 4,
        Monochrome = 5,
        RGBA = 6,
        Palette256Alpha = 7,
        GreyScale16 = 8,
        Palette2 = 9,
    };

    public enum DgnErrorCategories : int
    {
        DGNMODEL_ERROR_BASE = 69632,
        DGNLOAD_ERROR_BASE = 73728,
        DGNOPEN_STATUS_BASE = 77824,
        DGNFILE_ERROR_BASE = 81920,
        DGNSTREAM_ERROR_BASE = 86016,
        DGNHISTORY_ERROR_BASE = 90112,
        DGNSHAREDFILE_ERROR_BASE = 94208,
        DGNEMBED_ERROR_BASE = 98304,
        DGNELEMENT_ERROR_BASE = 102400,
        GEOCOORD_ATTACH_ERROR_BASE = 106496,
        VIEW_INFO_ERROR_BASE = 110592,
        VIEW_GROUP_ERROR_BASE = 114688,
        NAMED_VIEW_ERROR_BASE = 118784,
        VIEW_GROUP_MANAGER_ERROR_BASE = 122880,
        LINESTYLE_ERROR_BASE = 126976,
        NAMED_GROUP_ERROR_BASE = 131072,
        GEOREFERENCE_ERROR_BASE = 135168,
        VIEWFRUSTUM_ERROR_BASE = 139264,
        VIEWPORT_ERROR_BASE = 143360,
        REGISTERED_APP_ERROR_BASE = 147456,
        PATHNAME_ERROR_BASE = 151552,
        ANNOTATIONATTACHMENT_ERROR_BASE = 155648,
        REFRANGEPATH_ERROR_BASE = 159744,
        DETAILINGSYMBOL_ERROR_BASE = 163840,
        DCMODEL_ERROR_BASE = 167936,
        SHEETINDEX_ERROR_BASE = 196608,
        WORKSET_ERROR_BASE = 200704,
    };

    public enum DgnFileStatus : int
    {
        DGNFILE_STATUS_Success = 0,
        DGNFILE_STATUS_UnknownError = 32768,
        DGNOPEN_STATUS_SharingViolation = 77827,
        DGNOPEN_STATUS_AccessViolation = 77828,
        DGNOPEN_STATUS_AlreadyOpen = 77829,
        DGNOPEN_STATUS_FileAlreadyExists = 77830,
        DGNOPEN_STATUS_BadFilename = 77831,
        DGNOPEN_STATUS_UnrecognizedFormat = 77832,
        DGNOPEN_STATUS_VersionMismatch = 77833,
        DGNOPEN_STATUS_TooManyOpenFiles = 77840,
        DGNOPEN_STATUS_FileNotFound = 77841,
        DGNOPEN_STATUS_OpenCanceled = 77842,
        DGNOPEN_STATUS_BAD_FILE = 77844,
        FILE_OPEN_STATUS_UnableToLoadInterface = 77846,
        FILE_OPEN_STATUS_UnableToOpenSeed = 77847,
        DWGOPEN_STATUS_InvalidSeed = 77848,
        DGNOPEN_STATUS_InvalidOperationForNestedFile = 77849,
        DGNOPEN_STATUS_InvalidOperationForNonNestedFile = 77856,
        DGNOPEN_STATUS_IsEncrypted = 77857,
        DGNOPEN_STATUS_CorruptFile = 77858,
        DGNOPEN_STATUS_FileHasNewFeatures = 77859,
        DGNOPEN_STATUS_SaveToPerformed = 77860,
        DGNOPEN_STATUS_InsecureEnvironment = 77862,
        DWGOPEN_STATUS_BadFile = 77863,
        DWGOPEN_STATUS_CannotOpenSeed = 77864,
        DWGSAVE_STATUS_UserAbort = 77865,
        DGNOPEN_STATUS_ProjectMismatch = 77872,
        DGNFILE_ERROR_NotLoaded = 81921,
        DGNFILE_ERROR_NotOpen = 81922,
        DGNFILE_ERROR_AlreadyLoaded = 81923,
        DGNFILE_ERROR_HasChanges = 81925,
        DGNFILE_ERROR_BadArg = 81926,
        DGNFILE_ERROR_ReadError = 81927,
        DGNFILE_ERROR_WriteError = 81928,
        DGNFILE_ERROR_CompressionError = 81929,
        DGNFILE_ERROR_ModelAlreadyLoaded = 81936,
        DGNFILE_ERROR_UnknownFormat = 81937,
        DGNFILE_ERROR_NotOpenForWrite = 81938,
        DGNFILE_ERROR_NoSuchModel = 81939,
        DGNFILE_ERROR_NotLocked = 81940,
        DGNFILE_ERROR_UnableToImportSeed = 81941,
        DGNFILE_ERROR_ModelLoadError = 81942,
        DGNFILE_ERROR_RenameError = 81943,
        DGNFILE_ERROR_CopyError = 81944,
        DGNFILE_ERROR_ModelNotFilled = 81945,
        DGNFILE_ERROR_NoModel = 81952,
        DGNFILE_ERROR_InvalidOperationForNestedFile = 81953,
        DGNFILE_ERROR_RightNotGranted = 81954,
        DGNFILE_ERROR_PasswordAlreadyUsed = 81955,
        DGNFILE_ERROR_CertificatePurpose = 81956,
        DGNFILE_ERROR_NeverWriteable = 81957,
        DGNFILE_ERROR_NoDictionaryModelReader = 81958,
        DGNLOAD_STATUS_Badname = 73729,
        DGNLOAD_STATUS_NotOpened = 73730,
        DGNLOAD_STATUS_EndOfDgn = 73731,
        DGNLOAD_STATUS_OutOfData = 73732,
        DGNLOAD_STATUS_BadWtf = 73733,
        DGNPATHNAME_AlreadyExists = 151553,
        DGNPATHNAME_DoesNotExist = 151554,
        DGNPATHNAME_CantCreate = 151555,
        DGNPATHNAME_NotEmpty = 151556,
        DGNPATHNAME_IllegalName = 151557,
        DGNPATHNAME_CantDeleteFile = 151558,
        DGNPATHNAME_CantDeleteDir = 151559,
    };

    public enum DgnModelStatus : int
    {
        DGNMODEL_STATUS_Success = 0,
        DGNMODEL_STATUS_ReadOnly = 69633,
        DGNMODEL_STATUS_BadElement = 69634,
        DGNMODEL_STATUS_BadRequest = 69635,
        DGNMODEL_STATUS_OutOfMemory = 69636,
        DGNMODEL_STATUS_ElementNotFound = 69637,
        DGNMODEL_STATUS_BadModelPtr = 69638,
        DGNMODEL_STATUS_IdNotFound = 69640,
        DGNMODEL_STATUS_IdExists = 69641,
        DGNMODEL_STATUS_InvalidId = 69642,
        DGNMODEL_STATUS_CircularDependency = 69643,
        DGNMODEL_STATUS_NotEnabled = 69644,
        DGNMODEL_STATUS_ComplexComponent = 69645,
        DGNMODEL_STATUS_WrongElemId = 69646,
        DGNMODEL_STATUS_IsInUse = 69647,
        DGNMODEL_STATUS_NotFound = 69648,
        DGNMODEL_STATUS_InvalidDependency = 69649,
        DGNMODEL_STATUS_NotComplexHeader = 69650,
        DGNMODEL_STATUS_2d3dMismatch = 69651,
        DGNMODEL_STATUS_ReplacingDeleted = 69652,
        DGNMODEL_STATUS_OversizeElement = 69653,
        DGNMODEL_STATUS_UndersizeElement = 69654,
        DGNMODEL_STATUS_InvalidAttrOffset = 69655,
        DGNMODEL_STATUS_InvalidXattribute = 69656,
        DGNMODEL_STATUS_InvalidXattributeId = 69657,
        DGNMODEL_STATUS_DuplicateModelName = 69658,
        DGNMODEL_STATUS_NoChange = 69659,
        DGNMODEL_STATUS_DuplicateDependency = 69660,
        DGNMODEL_STATUS_DuplicateModelID = 69661,
        DGNMODEL_STATUS_InvalidModelName = 69662,
        DGNMODEL_STATUS_BadArg = 69663,
        DGNMODEL_STATUS_MuNotLargerThanSu = 69664,
        DGNMODEL_STATUS_NotSameUnitBase = 69665,
        DGNMODEL_STATUS_WrongModel = 69666,
        DGNMODEL_STATUS_DrawingModelMustBe2d = 69667,
        DGNMODEL_STATUS_InvalidModelTypeSwitch = 69668,
        DGNMODEL_STATUS_BadFileRefCount = 69669,
        DGNMODEL_STATUS_ElementListNotFilled = 69670,
    };

    public enum DgnFileEmbedStatus : int
    {
        DGNEMBED_STATUS_Success = 0,
        DGNEMBED_STATUS_InvalidContainerFormat = 98305,
        DGNEMBED_STATUS_InvalidDonor = 98306,
        DGNEMBED_STATUS_InvalidDonorFormat = 98307,
        DGNEMBED_STATUS_CopyError = 98308,
        DGNEMBED_STATUS_NotFound = 98309,
        DGNEMBED_STATUS_WriteError = 98310,
        DGNEMBED_STATUS_ReadError = 98311,
        DGNEMBED_STATUS_DuplicateFilename = 98312,
        DGNEMBED_STATUS_DuplicateAlias = 98313,
    };

    public enum LineStyleStatus : int
    {
        LINESTYLE_STATUS_Success = 0,
        LINESTYLE_STATUS_Error = 32768,
        LINESTYLE_STATUS_BadArgument = 126977,
        LINESTYLE_STATUS_UnknownResourceError = 126978,
        LINESTYLE_STATUS_FileNotFound = 126979,
        LINESTYLE_STATUS_NotSameFile = 126980,
        LINESTYLE_STATUS_InvalidForV7Symbol = 126981,
        LINESTYLE_STATUS_InvalidForV8Symbol = 126982,
        LINESTYLE_STATUS_FileReadOnly = 126983,
        LINESTYLE_STATUS_AlreadyExists = 126984,
        LINESTYLE_STATUS_BadFormat = 126985,
        LINESTYLE_STATUS_StyleNotFound = 126986,
        LINESTYLE_STATUS_UnsavedSubcomponent = 126987,
        LINESTYLE_STATUS_MissingSubcomponent = 126988,
    };

    public enum ViewFrustumError : int
    {
        VIEW_FRUSTERR_InvalidWindow = 139265,
        VIEW_FRUSTERR_MinWindow = 139266,
        VIEW_FRUSTERR_MaxWindow = 139267,
        VIEW_FRUSTERR_MinDisplayDepth = 139268,
        VIEW_FRUSTERR_MaxDisplayDepth = 139269,
    };

    public enum DgnHandlersStatus : int
    {
        DGNHANDLERS_STATUS_Success = 0,
        DGNHANDLERS_STATUS_BadElement = -105,
        DGNHANDLERS_STATUS_FileReadonly = -108,
        DGNHANDLERS_STATUS_WriteInhibit = -110,
        DGNHANDLERS_STATUS_BadArg = -126,
        DGNHANDLERS_STATUS_UserAbort = -144,
        DGNHANDLERS_STATUS_ElementTooLarge = -159,
        DGNHANDLERS_STATUS_LinkageNotFound = -160,
        DGNHANDLERS_STATUS_AlreadyExists = -194,
        DGNHANDLERS_STATUS_NoModel = -205,
        DGNHANDLERS_STATUS_NotCmplxHdr = -220,
    };

    public enum DgnPlatformStatus : int
    {
        DGNPLATFORM_STATUS_Success = 0,
        DGNPLATFORM_STATUS_BadArg = -126,
        DGNPLATFORM_STATUS_InsfMemory = -116,
        DGNPLATFORM_STATUS_TooLarge = -148,
        DGNPLATFORM_STATUS_LinkageNotFound = -160,
        DGNPLATFORM_STATUS_NoChange = -163,
        DGNPLATFORM_STATUS_BadParameter = -509,
        DGNPLATFORM_STATUS_ElemTooLarge = -750,
        DGNPLATFORM_STATUS_ViewNotFound = -761,
    };

    public enum GeoCoordAttachmentErrors : int
    {
        GEOCOORD_ERROR_NoGeocode = 106497,
        GEOCOORD_ERROR_NotGeoTransformed = 106498,
    };

    public enum BSplineStatus : int
    {
        BSPLINE_STATUS_Success = 0,
        BSPLINE_STATUS_NoPoles = -500,
        BSPLINE_STATUS_NoKnots = -501,
        BSPLINE_STATUS_NoWeights = -502,
        BSPLINE_STATUS_NoBounds = -503,
        BSPLINE_STATUS_NoNumBounds = -504,
        BSPLINE_STATUS_NoBspHeader = -505,
        BSPLINE_STATUS_TooFewPoles = -506,
        BSPLINE_STATUS_TooManyPoles = -507,
        BSPLINE_STATUS_BadBspElement = -508,
        BSPLINE_STATUS_BadParameter = -509,
        BSPLINE_STATUS_BadOrder = -510,
        BSPLINE_STATUS_BadPeriodicity = -511,
        BSPLINE_STATUS_BadPoles = -512,
        BSPLINE_STATUS_BadKnots = -513,
        BSPLINE_STATUS_BadWeights = -514,
        BSPLINE_STATUS_BadSpiralDefinition = -515,
        BSPLINE_STATUS_TooManyKnots = -516,
        BSPLINE_STATUS_NoOffsetIntersection = -517,
        BSPLINE_STATUS_BadContinuity = -518,
        BSPLINE_STATUS_RecurseLimit = -519,
    };

    public enum DgnPlatformToolsStatus : int
    {
        DGNPLATFORMTOOLS_STATUS_WriteFailed = -111,
        DGNPLATFORMTOOLS_STATUS_InsfMemory = -116,
        DGNPLATFORMTOOLS_STATUS_ReadFailed = -120,
        DGNPLATFORMTOOLS_STATUS_NoMatch = -123,
        DGNPLATFORMTOOLS_STATUS_Ambiguous = -124,
        DGNPLATFORMTOOLS_STATUS_BadArg = -126,
        DGNPLATFORMTOOLS_STATUS_BadStringListIndex = -134,
        DGNPLATFORMTOOLS_STATUS_TooLarge = -148,
        DGNPLATFORMTOOLS_STATUS_FileNotFound = -166,
        DGNPLATFORMTOOLS_STATUS_NameTooLong = -169,
        DGNPLATFORMTOOLS_STATUS_BadParameter = -509,
        DGNPLATFORMTOOLS_STATUS_AddressNotValid = -725,
        DGNPLATFORMTOOLS_STATUS_BadVariableArraySize = -1100,
        DGNPLATFORMTOOLS_STATUS_NotConversionRules = -1101,
        DGNPLATFORMTOOLS_STATUS_BadDataDef = -1102,
        DGNPLATFORMTOOLS_STATUS_DataDefNotFound = -1103,
        DGNPLATFORMTOOLS_STATUS_BufferAlignmentsDiffer = -1104,
        DGNPLATFORMTOOLS_STATUS_InvalidPlatformId = -1106,
        DGNPLATFORMTOOLS_STATUS_VoidDataType = -1107,
        DGNPLATFORMTOOLS_STATUS_InvalidDependency = -1901,
    };

    public enum RscStatus : int
    {
        RSC_STATUS_Error = -900,
        RSC_STATUS_FileError = -901,
        RSC_STATUS_HandleInvalid = -902,
        RSC_STATUS_FileNotFound = -903,
        RSC_STATUS_InsufficientMemory = -904,
        RSC_STATUS_WriteViolation = -906,
        RSC_STATUS_AddressInvalid = -907,
        RSC_STATUS_ResourceTypeInvalid = -908,
        RSC_STATUS_AlreadyExists = -909,
        RSC_STATUS_InUse = -911,
        RSC_STATUS_NotFound = -912,
        RSC_STATUS_StringNotFound = -913,
        RSC_STATUS_QueryIdInvalid = -914,
        RSC_STATUS_DirectAddPending = -915,
        RSC_STATUS_BadRangeTree = -916,
        RSC_STATUS_FileNotOpen = -917,
        RSC_STATUS_BadResourceSize = -918,
        RSC_STATUS_InvalidFileHandle = -919,
        RSC_STATUS_AliasRequired = -920,
        RSC_STATUS_ResourceFileCorrupt = -921,
        RSC_STATUS_FileOpenFailure = -922,
        RSC_STATUS_FileHandleTableFull = -923,
        RSC_STATUS_ConditionFalse = -924,
    };

    public enum AkimaCurveStatus : int
    {
        AKIMACURVE_STATUS_Success = 0,
        AKIMACURVE_STATUS_BadElement = 32768,
        AKIMACURVE_STATUS_NullSolution = -752,
    };

    public enum StyleTableErrors : int
    {
        STYLETABLE_ERROR_NoMatch = -123,
        STYLETABLE_ERROR_BadIndex = -134,
        STYLETABLE_ERROR_DuplicateName = -161,
        STYLETABLE_ERROR_NoChange = -163,
        STYLETABLE_ERROR_BadName = -188,
        STYLETABLE_ERROR_StyleNotFound = -227,
        STYLETABLE_ERROR_StyleIsUsed = -230,
    };

    public enum DgnAttachmentErrors : int
    {
        DGNATTACHMENT_ERROR_DuplicateLogical = -738,
        DGNATTACHMENT_ERROR_CantRewriteNewAttachment = -773,
    };

    public enum SignatureErrors : int
    {
        SIGNATURE_STATUS_NotFound = -2002,
        SIGNATURE_STATUS_NotVerified = -2003,
        SIGNATURE_STATUS_NotRecognized = -2004,
        SIGNATURE_STATUS_RightNotGranted = -2005,
        SIGNATURE_STATUS_Sileng = -2006,
    };

    public enum ElemRefChangeReason : int
    {
        ELEMREF_CHANGE_REASON_Delete = 1,
        ELEMREF_CHANGE_REASON_Modify = 2,
        ELEMREF_CHANGE_REASON_MovedToNewElemRef = 4,
        ELEMREF_CHANGE_REASON_ClearQVData = 5,
    };

    public enum RelativePathPreference : int
    {
        Never = 0,
        Allow = 1,
        CreateIfPossible = 2,
    };

    public enum DgnAttachmentLocateStatus : int
    {
        LocateOn = 0,
        LocateOff = 1,
        ParentLocateOff = 2,
        NoLocateRights = 3,
        ParentNoLocateRights = 4,
    };

    public enum ClipMask : int
    {
        None = 0,
        XLow = 1,
        XHigh = 2,
        YLow = 4,
        YHigh = 8,
        ZLow = 16,
        ZHigh = 32,
        XAndY = 15,
        All = 63,
    };

    public enum MapMode : int
    {
        None = -1,
        Parametric = 0,
        ElevationDrape = 1,
        Planar = 2,
        DirectionalDrape = 3,
        Cubic = 4,
        Spherical = 5,
        Cylindrical = 6,
        Solid = 7,
        FrontProject = 8,
    };

    public enum MapUnits : int
    {
        Relative = 0,
        MasterUnits = 1,
        SubUnits = 2,
        Meters = 3,
        Millimeters = 4,
        Feet = 5,
        Inches = 6,
    };

    public enum PatternParamsCompareFlags : int
    {
        PATTERNPARAMSCOMPAREFLAGS_RMatrix = 1,
        PATTERNPARAMSCOMPAREFLAGS_Offset = 2,
        PATTERNPARAMSCOMPAREFLAGS_Default = 4,
        PATTERNPARAMSCOMPAREFLAGS_Origin = 16,
        PATTERNPARAMSCOMPAREFLAGS_Symbology = 32,
        PATTERNPARAMSCOMPAREFLAGS_Mline = 64,
        PATTERNPARAMSCOMPAREFLAGS_Tolerance = 128,
        PATTERNPARAMSCOMPAREFLAGS_HoleStyle = 256,
        PATTERNPARAMSCOMPAREFLAGS_DwgHatch = 512,
        PATTERNPARAMSCOMPAREFLAGS_AnnotationScale = 1024,
        PATTERNPARAMSCOMPAREFLAGS_All = 65535,
    };

    public enum PatternParamsModifierFlags : int
    {
        None = 0,
        Space1 = 1,
        Angle1 = 2,
        Space2 = 4,
        Angle2 = 8,
        Scale = 16,
        Cell = 32,
        Tolerance = 64,
        Style = 128,
        Weight = 256,
        Color = 512,
        Snap = 1024,
        RotMatrix = 2048,
        Offset = 4096,
        HoleStyle = 8192,
        DwgHatchDef = 16384,
        Multiline = 32768,
        Origin = 65536,
        PixelSize = 131072,
        IslandStyle = 262144,
        TrueScale = 524288,
        RawDwgLoops = 1048576,
        DwgHatchOrigin = 2097152,
        AnnotationScale = 4194304,
    };

    public enum PatternParamsHoleStyleType : int
    {
        Normal = 0,
        Parity = 1,
    };

    public enum DrawPurpose : int
    {
        NotSpecified = 0,
        Update = 1,
        UpdateDynamic = 2,
        UpdateHealing = 3,
        Hilite = 5,
        Unhilite = 6,
        ChangedPre = 9,
        ChangedPost = 10,
        RestoredPre = 11,
        RestoredPost = 12,
        Dynamics = 15,
        RangeCalculation = 20,
        Plot = 21,
        Pick = 22,
        Flash = 23,
        TransientChanged = 25,
        CaptureGeometry = 26,
        GenerateThumbnail = 27,
        ForceRedraw = 29,
        FenceAccept = 30,
        RegionFlood = 31,
        FitView = 32,
        XGraphicsCreate = 34,
        CaptureShadowList = 35,
        ExportVisibleEdges = 36,
        InterferenceDetection = 37,
        CutXGraphicsCreate = 38,
        ModelFacet = 39,
        Measure = 40,
        VisibilityCalculation = 41,
        ProxyHashExtraction = 42,
        ComputeModelRefRange = 43,
        DgnDbConvert = 44,
        VueRender = 45,
    };

    public enum ExposeChildrenReason : int
    {
        Query = 200,
        Edit = 300,
    };

    public enum FillDisplay : int
    {
        Never = 0,
        ByView = 1,
        Always = 2,
        Blanking = 3,
    };

    public enum DgnFontType : int
    {
        None = 0,
        Rsc = 1,
        TrueType = 2,
        Shx = 3,
    };

    public enum DgnFontNamedSymbolSource : int
    {
        HardCoded,
        CustomFromFontConfig,
    };

    public enum CharacterSpacingType : int
    {
        Absolute = 0,
        FixedWidth = 1,
        Factor = 2,
    };

    public enum StackedFractionType : int
    {
        None = 0,
        NoBar = 1,
        DiagonalBar = 2,
        HorizontalBar = 3,
    };

    public enum StackedFractionSection : int
    {
        None = 0,
        Numerator = 1,
        Denominator = 2,
    };

    public enum DgnECHostType : int
    {
        Unknown = 0,
        Element = 1,
        Model = 4,
        File = 8,
        DesignLink = 16,
        View = 32,
        Attachment = 64,
        Level = 128,
        All = -1,
    };

    public enum DgnModelSections : int
    {
        None = 0,
        Dictionary = 1,
        ControlElements = 2,
        GraphicElements = 4,
        Model = 6,
        All = 2147483647,
    };

    public enum DgnSaveReason : int
    {
        UserInitiated = 1,
        ApplInitiated = 2,
        ReferenceFileSave = 3,
        FileClose = 4,
        FileCompress = 5,
        FileSaveAs = 6,
        AutoTime = 7,
        PreCommit = 8,
        SaveSettings = 9,
        Backup = 10,
        Encrypt = 11,
        PreCompress = 12,
    };

    public enum LevelCacheErrorCode : int
    {
        None = 0,
        Error = 32768,
        TableIsReadOnly = 2,
        LevelIsReadOnly = 4,
        LevelNameIsNull = 7,
        LevelNameIsInvalid = 8,
        LevelNameIsDuplicate = 9,
        LevelIsUsed = 11,
        LevelCodeIsDuplicate = 23,
        LevelIdIsDuplicate = 46,
        LibraryLevelNotEditable = 49,
        CannotFindLevel = 56,
        LevelTableIntegrityFailure = 59,
        DgnAttachmentNotResolved = 60,
        LevelNullId = 92,
        NoLevels = 1000,
        AttachmentSharesFileLevelCache = 1001,
    };

    public enum LevelElementAccess : int
    {
        All = 0,
        Locked = 1,
        ReadOnly = 2,
        ViewOnly = 3,
    };

    public enum DimensionPartType : int
    {
        ADTYPE_INHERIT = 0,
        ADTYPE_EXT_LEFT = 1,
        ADTYPE_EXT_RIGHT = 2,
        ADTYPE_TEXT_UPPER = 3,
        ADTYPE_TEXT_LOWER = 4,
        ADTYPE_TEXT_SINGLE = 5,
        ADTYPE_TERM_LEFT = 6,
        ADTYPE_TERM_RIGHT = 7,
        ADTYPE_DIMLINE = 8,
        ADTYPE_CENTER = 9,
        ADTYPE_TEXT_SYMBOLS = 10,
        ADTYPE_CHAIN = 11,
    };

    public enum DimensionPartSubType : int
    {
        ADSUB_NONE = 0,
        ADSUB_TOL_UPPER = 1,
        ADSUB_TOL_LOWER = 2,
        ADSUB_TOL_SINGLE = 3,
        ADSUB_LIM_UPPER = 4,
        ADSUB_LIM_LOWER = 5,
        ADSUB_LIM_SINGLE = 6,
        ADSUB_PREFIX = 7,
        ADSUB_SUFFIX = 8,
        ADSUB_TERMSYMBOL = 9,
        ADSUB_LEADER = 10,
    };

    public enum PropsCallbackFlags : int
    {
        PROPSCALLBACK_FLAGS_NoFlagsSet = 0,
        PROPSCALLBACK_FLAGS_ElementIgnoresID = 1,
        PROPSCALLBACK_FLAGS_IsBaseID = 2,
        PROPSCALLBACK_FLAGS_IsBackgroundID = 4,
        PROPSCALLBACK_FLAGS_IsDecorationID = 8,
        PROPSCALLBACK_FLAGS_UndisplayedID = 16,
        PROPSCALLBACK_FLAGS_MaterialAssigned = 32,
    };

    public enum StyleParamsRemapping : int
    {
        Invalid = -1,
        NoChange = 0,
        ApplyStyle = 1,
        Override = 2,
    };

    public enum ElementProperties : int
    {
        ELEMENT_PROPERTY_None = 0,
        ELEMENT_PROPERTY_Level = 1,
        ELEMENT_PROPERTY_Color = 2,
        ELEMENT_PROPERTY_Linestyle = 4,
        ELEMENT_PROPERTY_Font = 8,
        ELEMENT_PROPERTY_TextStyle = 16,
        ELEMENT_PROPERTY_DimStyle = 32,
        ELEMENT_PROPERTY_MLineStyle = 64,
        ELEMENT_PROPERTY_Material = 128,
        ELEMENT_PROPERTY_Weight = 256,
        ELEMENT_PROPERTY_ElementClass = 512,
        ELEMENT_PROPERTY_Transparency = 1024,
        ELEMENT_PROPERTY_DisplayPriority = 2048,
        ELEMENT_PROPERTY_ElementTemplate = 4096,
        ELEMENT_PROPERTY_Thickness = 8192,
        ELEMENT_PROPERTY_MaterialAssignment = 16384,
        ELEMENT_PROPERTY_LastValue = 16384,
        ELEMENT_PROPERTY_All = -1,
    };

    public enum QueryPropertyPurpose : int
    {
        NotSpecified = -1,
        Match = 0,
    };

    public enum EditPropertyPurpose : int
    {
        Change = 0,
        Remap = 1,
    };

    public enum EditPropertiesChangeWrite : int
    {
        Always = 0,
        IfNewChangesOnly = 1,
        Never = 2,
    };

    public enum LsLocationType : int
    {
        Unknown = 0,
        ResourceFile = 1,
        DgnFile = 2,
        System = 3,
        LinFile = 4,
        Importer = 5,
    };

    public enum DgnFileOpenMode : int
    {
        ReadOnly = 1,
        ReadWrite = 2,
        PreferablyReadWrite = 3,
        ReadWriteFromCopiedFile = 4,
    };

    public enum SeedCopyFlags : int
    {
        None = 0,
        TCBData = 2,
        DefaultViews = 4,
        AllViewGroups = 8,
        LevelTable = 16,
        ColorTable = 32,
        FontTable = 64,
        TextStyleTable = 128,
        DimStyleTable = 256,
        MlineStyleTable = 512,
        LineStyleTable = 1024,
        FilterTable = 2048,
        DictionaryTable = 4096,
        ReferenceAttach = 8192,
        RasterRefs = 16384,
        AllNamedViews = 32768,
        NamedViewsOfSeed = 65536,
        ApplicationInfo = 131072,
        AuxCoordSystem = 262144,
        AllLevelTables = 524288,
        CreateDefaultModel = 1048576,
        MaterialPalette = 2097152,
        GeoCoordinateSystem = 4194304,
        LevelNameDictionary = 8388608,
        NoViewGroups = 16777216,
        DisplayStyles = 33554432,
        DefaultData = 14681142,
        AllData = 2145910783,
    };

    public enum IsoPlaneValues : int
    {
        IsoPlaneTop = 0,
        IsoPlaneLeft,
        IsoPlaneRight,
        IsoPlaneAll,
    };

    public enum UnitSystem : int
    {
        Undefined = 0,
        English = 1,
        Metric = 2,
        USSurvey = 3,
    };

    public enum ProcessChangesWhen : int
    {
        BeforeProcessing = 0,
        AfterProcessing = 1,
    };

    public enum DgnFileChanges : int
    {
        Abandon = 0,
        Save = 1,
        FullSave = 2,
    };

    public enum DgnFontFilter : int
    {
        None = 0,
        Resource = 1,
        Shx = 2,
        ShxBig = 4,
        TrueType = 8,
        Missing = 16,
        Symbol = 32,
        Hidden = 64,
        Normal = 11,
        AllShx = 6,
        All = 127,
        ResourceShx = 3,
    };

    public enum FileCompareMask : int
    {
        None = 0,
        BaseNameAndExtension = 1,
        FileStat = 2,
        All = 2147483647,
    };

    public enum ViewGroupStatus : int
    {
        VG_Success = 0,
        VG_NameTooShort = 114689,
        VG_NameTooLong = 114690,
        VG_NameNotUnique = 114691,
        VG_NameIllegalCharacter = 114692,
        VG_OwningDgnFileUnknown = 114693,
        VG_WrongFile = 114694,
        VG_CantCreateElement = 114695,
        VG_CantWriteToFile = 114696,
        VG_TransientNotSaved = 114697,
        VG_CantDeleteFromFile = 114698,
        VG_NotInCollection = 114699,
        VG_ActivateRejected = 114700,
        VG_NoReplacementActiveFound = 114701,
        VG_CantSetElementId = 114702,
        VG_BadArgument = 114703,
        VG_ViewGroupNotFound = 114704,
        VG_OpenViewNotFound = 114705,
    };

    public enum ViewInfoStatus : int
    {
        VI_Success = 0,
        VI_BadModelRef = 110593,
        VI_CameraNotInUse = 110594,
    };

    public enum ACSType : int
    {
        None = 0,
        Rectangular = 1,
        Cylindrical = 2,
        Spherical = 3,
        Extended = 4,
    };

    public enum ACSFlags : int
    {
        None = 0,
        Default = 0,
        ViewIndependent = 1,
    };

    public enum ACSSaveOptions : int
    {
        OverwriteByElemId = 0,
        OverwriteByName = 1,
        AllowNew = 2,
    };

    public enum DisplayStyleApplyValidity : int
    {
        CanBeApplied,
        NonWireframeForSheet,
        ShadowedOn2DModel,
        NotValidForHandler,
    };

    public enum EnvironmentDisplay : int
    {
        Color = 0,
        Luxology = 1,
    };

    public enum ViewChangeType : int
    {
        None = 0,
        Geometry = 1,
        RootModel = 2,
        Levels = 4,
        BGColor = 8,
        DisplayFlags = 16,
        DynamicView = 32,
        ACS = 64,
        BackgroundMap = 128,
        All = 65535,
    };

    public enum ViewGroupCopyTypeOption : int
    {
        SourceType = -1,
        MakeTransient = 0,
        MakePermanent = 1,
    };

    public enum DgnLinkTreeKey : int
    {
        Invalid = 0,
        Project = 1,
        Bookmarks = 2,
        Annotation = 3,
        SheetIndex = 4,
    };

    public enum DgnLinkAddChildStatus : int
    {
        Success = 0,
        GeneralError,
        DuplicateChild,
    };

    public enum DgnECInstanceStatus : int
    {
        DGNECINSTANCESTATUS_Success = 0,
        DGNECINSTANCESTATUS_InstanceIsStale = 1,
        DGNECINSTANCESTATUS_InstanceIsDeletedOrUndone = 2,
        DGNECINSTANCESTATUS_InvalidElementRef = 3,
        DGNECINSTANCESTATUS_InstanceIsAlreadyAsleep = 4,
        DGNECINSTANCESTATUS_IncompatibleWipInstance = 5,
        DGNECINSTANCESTATUS_UnableToAddInstance = 6,
        DGNECINSTANCESTATUS_NoInstanceFound = 7,
        DGNECINSTANCESTATUS_InvalidInstance = 8,
        DGNECINSTANCESTATUS_UnableToUpdateInstance = 9,
        DGNECINSTANCESTATUS_XAttributeHasBeenRemoved = 10,
        DGNECINSTANCESTATUS_ClassLayoutNotStored = 11,
        DGNECINSTANCESTATUS_RelationshipInstanceNotCreated = 12,
        DGNECINSTANCESTATUS_EnablerNotValidForFile = 13,
        DGNECINSTANCESTATUS_DuplicateRelationshipFound = 14,
        DGNECINSTANCESTATUS_RequiresSingleEndedRelationshipClass = 15,
        DGNECINSTANCESTATUS_PropertyNotFound = 16,
        DGNECINSTANCESTATUS_Error = 32768,
    };

    public enum TextStyleProperty : int
    {
        TextStyle_InvalidProperty = 0,
        TextStyle_Color = 1,
        TextStyle_ColorFlag = 2,
        TextStyle_Font = 3,
        TextStyle_ShxBigFont = 4,
        TextStyle_Width = 5,
        TextStyle_Height = 6,
        TextStyle_Slant = 7,
        TextStyle_Underline = 8,
        TextStyle_Overline = 9,
        TextStyle_Italics = 10,
        TextStyle_Bold = 11,
        TextStyle_Superscript = 12,
        TextStyle_Subscript = 13,
        TextStyle_Backgroundstyleflag = 14,
        TextStyle_Backgroundstyle = 15,
        TextStyle_Backgroundweight = 16,
        TextStyle_Backgroundcolor = 17,
        TextStyle_Backgroundfillcolor = 18,
        TextStyle_Backgroundborder = 19,
        TextStyle_Underlinestyle = 20,
        TextStyle_Underlineweight = 21,
        TextStyle_Underlinecolor = 22,
        TextStyle_Underlinestyleflag = 23,
        TextStyle_UnderlineOffset = 24,
        TextStyle_Overlinestyle = 25,
        TextStyle_Overlineweight = 26,
        TextStyle_Overlinecolor = 27,
        TextStyle_Overlinestyleflag = 28,
        TextStyle_OverlineOffset = 29,
        TextStyle_LineSpacing = 30,
        TextStyle_FixedSpacing = 31,
        TextStyle_LineOffset = 32,
        TextStyle_InterCharSpacing = 33,
        TextStyle_LineSpacingType = 34,
        TextStyle_AcadInterCharSpacing = 35,
        TextStyle_Justification = 36,
        TextStyle_FullJustification = 38,
        TextStyle_LineLength = 39,
        TextStyle_Backwards = 41,
        TextStyle_Upsidedown = 42,
        TextStyle_Fractions = 43,
        TextStyle_Vertical = 45,
        TextStyle_RightToLeft = 47,
    };

    public enum StyleIteratorMode : int
    {
        Invalid = -1,
        ActiveFileOnly = 0,
        LibrariesOnly = 1,
        ActiveFileAndLibraries = 2,
    };

    public enum StyleEventType : int
    {
        Invalid = -1,
        Add = 0,
        Delete = 1,
        Change = 2,
        SetActive = 3,
        ModifyActive = 4,
        BeforeSetActive = 5,
    };

    public enum StyleEventSource : int
    {
        Invalid = -1,
        Action = 0,
        Undo = 1,
        Redo = 2,
    };

    public enum DgnLineSpacingType : int
    {
        Exact = 0,
        Automatic = 1,
        ExactFromLineTop = 2,
        AtLeast = 3,
    };

    public enum StackedFractionAlignment : int
    {
        Bottom = 0,
        Middle = 1,
        Top = 2,
        None = 3,
    };

    public enum EdfJustification : int
    {
        Left = -1,
        Center = 0,
        Right = 1,
    };

    public enum DgnCoordSystem : int
    {
        Screen = 0,
        View = 1,
        Npc = 2,
        Root = 3,
        Active = 4,
        Frustum = 5,
    };

    public enum ClipVolumePass : int
    {
        None,
        InsideForward,
        InsideBackward,
        Outside,
        Inside,
        Cut,
        Maximum,
    };

    public enum LimitRefLoading : int
    {
        None = 0,
        DoNotFillCaches = 1,
        IgnoreAttachments = 2,
    };

    public enum DgnModelRefType : int
    {
        Root = 1,
        PrimaryRef = 2,
        Proxy = 4,
        NonModel = 7,
        Transient = 8,
    };

    public enum ModifyElementSource : int
    {
        Selected = 0,
        SelectionSet = 1,
        Fence = 2,
        WorkingSet = 3,
        GraphicGroup = 4,
        NamedGroup = 5,
        DragSelection = 6,
        Unknown = 10,
    };

    public enum AgendaHilitedState : int
    {
        Unknown = 0,
        Yes = 1,
        No = 2,
    };

    public enum DgnDrawMode : int
    {
        DRAW_MODE_Normal = 0,
        DRAW_MODE_Erase = 1,
        DRAW_MODE_Hilite = 2,
        DRAW_MODE_TempDraw = 3,
        DRAW_MODE_Flash = 11,
    };

    public enum AgendaOperation : int
    {
        NotSpecified = 0,
        Translate = 1,
        Scale = 2,
        Rotate = 3,
        Mirror = 4,
        Array = 5,
        Stretch = 6,
        Delete = 7,
        Clipboard = 8,
        DragDrop = 9,
        ChangeAttrib = 10,
        FileFence = 11,
        Drop = 12,
    };

    public enum AgendaModify : int
    {
        Original = 0,
        Copy = 1,
        ClipOriginal = 2,
        ClipCopy = 3,
    };

    public enum CopyContextLevelOption : int
    {
        ByUserPreference = 0,
        CopyIfNotFound = 1,
        CopyIfDifferent = 2,
        CopyAlways = 3,
        AlreadyRemapped = 4,
        CopyByNumber = 5,
    };

    public enum ChangeTrackAction : int
    {
        Delete = 1,
        Add = 2,
        Modify = 3,
        AddComplete = 4,
        ModifyFence = 5,
        Mark = 7,
        ModelAdd = 9,
        ModelDelete = 10,
        XAttributeAdd = 11,
        XAttributeDelete = 12,
        XAttributeModify = 13,
        XAttributeReplace = 14,
        ModelPropModify = 15,
        CustomEntry = 16,
        ModifyComplete = 17,
        Last = 17,
    };

    public enum ChangeTrackSource : int
    {
        UndoRedo = 1,
        HistoryRestore = 2,
        HistoryMerge = 3,
    };

    public enum AnnotationScaleAction : int
    {
        Update = 0,
        Add = 1,
        Remove = 2,
    };

    public enum FenceClipMode : int
    {
        None = 0,
        Original = 1,
        Copy = 3,
    };

    public enum FenceStretchFlags : int
    {
        None = 0,
        Cells = 1,
    };

    public enum FenceClipFlags : int
    {
        None = 0,
        Optimized = 1,
    };

    public enum MissingHandlerPermissions : int
    {
        MISSING_HANDLER_PERMISSION_None = 0,
        MISSING_HANDLER_PERMISSION_Delete = 1,
        MISSING_HANDLER_PERMISSION_Copy = 2,
        MISSING_HANDLER_PERMISSION_Draw = 8,
        MISSING_HANDLER_PERMISSION_Manipulators = 16,
        MISSING_HANDLER_PERMISSION_Move = 32,
        MISSING_HANDLER_PERMISSION_Transform = 64,
        MISSING_HANDLER_PERMISSION_CurveEdit = 128,
        MISSING_HANDLER_PERMISSION_ChangeAttrib = 512,
        MISSING_HANDLER_PERMISSION_All_ = -1,
    };

    public enum OpenRepositoryStatus : int
    {
        OPENREPOSITORY_STATUS_Success = 0,
        OPENREPOSITORY_STATUS_UnknownError = 1,
        OPENREPOSITORY_STATUS_InvalidArgument = 2,
        OPENREPOSITORY_STATUS_UserCanceled = 3,
        OPENREPOSITORY_STATUS_AccessDenied = 4,
    };

    public enum LoadIntegrationStatus : int
    {
        LOADINTEGRATION_STATUS_Success = 0,
        LOADINTEGRATION_STATUS_MalformedRegistryKey = 1,
        LOADINTEGRATION_STATUS_LibraryNotFound = 2,
        LOADINTEGRATION_STATUS_FailedToInitialize = 3,
        LOADINTEGRATION_STATUS_RequestedClassNotFound = 4,
    };

    public enum IntegratedApplicationType : int
    {
        APPLICATION_TYPE_Default = 0,
        APPLICATION_TYPE_Plugin = 1,
    };

    public enum WorkSetStatus : int
    {
        Success = 0,
        Error = 200705,
        InvalidWorkSet = 200706,
        NameRequired = 200707,
        PropertyNotFound = 200708,
        FailedToWriteData = 200709,
        FileIsReadOnly = 200710,
    };

    public enum DisplayFilterHandler_MinorId : int
    {
        DisplayFilterHandlerMinorId_Base = 0,
        DisplayFilterHandlerMinorId_ViewXFlag = 1,
        DisplayFilterHandlerMinorId_ViewXInteger = 2,
    };

    public enum DisplayFilterOpCode : int
    {
        DisplayFilterOpCode_And = 1,
        DisplayFilterOpCode_Or = 2,
        DisplayFilterOpCode_Not = 3,
        DisplayFilterOpCode_Parameter = 4,
        DisplayFilterOpCode_ViewFlag = 5,
        DisplayFilterOpCode_ViewXFlag = 6,
        DisplayFilterOpCode_ViewSize = 7,
        DisplayFilterOpCode_Level = 8,
        DisplayFilterOpCode_ViewAxisAngle = 9,
        DisplayFilterOpCode_ViewXInteger = 10,
        DisplayFilterOpCode_PresentationFormId = 12,
        DisplayFilterOpCode_PresentationFormFlag = 13,
        DisplayFilterOpCode_ViewContextFlag = 14,
        DisplayFilterOpCode_MAX,
    };

    public enum DisplayStyleListOptions : int
    {
        DISPLAY_STYLE_LIST_OPTIONS_IncludeHiddenForPickers = 1,
        DISPLAY_STYLE_LIST_OPTIONS_Default = 0,
        DISPLAY_STYLE_LIST_OPTIONS_IncludeAll = 65535,
    };

    public enum DisplayStyleImportStatus : int
    {
        InvalidSourceIndex,
        NotRemapped,
        RemappedToExistingStyle,
        RemappedToNewStyle,
    };

    public enum ACSEventType : int
    {
        None = 0,
        ParameterChanged = 1,
        GeometryChanged = 2,
        ChangeWritten = 4,
        NewACS = 8,
        Delete = 16,
    };

    public enum MaterialAnnouncerPurpose : int
    {
        ViewUpdate = 0,
        ModelFacetExport = 1,
        VueRender = 2,
    };

    public enum MaterialOpenMode : int
    {
        ReadOnly = 0,
        PreferablyReadWrite = 1,
        ReadWrite = 2,
    };

    public enum PaletteUnloadOption : int
    {
        RemoveAssignmentsAndAttachments = 0,
        ConvertToExternalAssignmentsAndAttachments = 1,
    };

    public enum CustomUndoListenerPurpose : int
    {
        PaletteUnload = 0,
        ConvertInternalToExternal = 1,
    };

    public enum GeoreferencePriority : int
    {
        GeoreferencePriority_Default = 0,
        GeoreferencePriority_Attachment = 1,
        GeoreferencePriority_RasterFile = 2,
        GeoreferencePriority_SisterFile = 3,
    };

    public enum RasterDisplayPriorityPlane : int
    {
        DisplayPriority_BackPlane = 1,
        DisplayPriority_DesignPlane = 2,
        DisplayPriority_FrontPlane = 3,
    };

    public enum TransparentColorType : int
    {
        TransparentColorType_Colordef = 1,
        TransparentColorType_CubeDef = 2,
    };

    public enum GeotiffUnitPriority : int
    {
        GeotiffUnitPriority_PCS_Default = 0,
        GeotiffUnitPriority_PCS_Linear = 1,
        GeotiffUnitPriority_Unknown = 2,
    };

    public enum UpdateAbortReason : int
    {
        UPDATE_ABORT_None = 0,
        UPDATE_ABORT_BadView = 1,
        UPDATE_ABORT_Motion = 2,
        UPDATE_ABORT_MotionStopped = 3,
        UPDATE_ABORT_Keystroke = 4,
        UPDATE_ABORT_ControlC = 5,
        UPDATE_ABORT_MouseWheel = 6,
        UPDATE_ABORT_Timeout = 7,
        UPDATE_ABORT_Button = 8,
        UPDATE_ABORT_Paint = 9,
        UPDATE_ABORT_Focus = 10,
        UPDATE_ABORT_ModifierKey = 11,
    };

    public enum LsElementType : int
    {
        Unknown = 0,
        PointSymbol = 1,
        Compound = 2,
        LineCode = 3,
        LinePoint = 4,
        Internal = 6,
        RasterImage = 7,
    };

    public enum LsPhaseMode : int
    {
        LsPhaseMode_None = 0,
        LsPhaseMode_Fixed = 1,
        LsPhaseMode_Fraction = 2,
        LsPhaseMode_Center = 3,
    };

    public enum LsCapMode : int
    {
        LCCAP_Closed = 0,
        LCCAP_Open = 1,
        LCCAP_Extended = 2,
        LCCAP_Hexagon = 3,
        LCCAP_Octagon = 4,
        LCCAP_Decagon = 5,
        LCCAP_Arc = 30,
    };

    public enum SymbolLocation : int
    {
        SymbolStroke = 0,
        SymbolLineOrigin = 1,
        SymbolLineEnd = 2,
        SymbolLineVertex = 3,
        SymbolUnknown = 4,
    };

    public enum SymbolStrokeLocation : int
    {
        SymbolStrokeOrigin = 1,
        SymbolStrokeEnd = 2,
        SymbolStrokeCenter = 3,
    };

    public enum SymbolRotation : int
    {
        SymbolRotationRelative = 0,
        SymbolRotationAbsolute = 1,
        SymbolRotationAdjusted = 2,
    };

    public enum PartialTreatment : int
    {
        SymbolPartialOrigin = 0,
        SymbolPartialProject = 1,
        SymbolPartialNone = 2,
    };

    public enum LsUnit : int
    {
        Master = 0,
        Uor = 1,
        Device = 2,
    };

    public enum MaterialSearchStatus : int
    {
        Success = 0,
        InvalidId = 1,
        InvalidModelRef = 2,
        NotFound = 3,
        CouldNotLoadSource = 4,
        InvalidLevelId = 5,
    };

    public enum MaterialAnnouncerPriority : int
    {
        First = 0,
        DCDrape = 1,
        RasterDrape = 2,
        GeoDTM = 3,
        DynamicTextureManipulation = 10,
        Animation = 10000,
    };

    public enum ProjectionVariant : int
    {
        None = 0,
        CylindricalCapped = 1,
    };

    public enum NamedGroupStatus : int
    {
        NG_Success = 0,
        NG_ClosedGroup = 131073,
        NG_FarReferenceDisallowed = 131074,
        NG_DuplicateMember = 131075,
        NG_BadMember = 131076,
        NG_NameTooLong = 131077,
        NG_NameTooShort = 131078,
        NG_DescriptionTooLong = 131079,
        NG_TypeTooLong = 131080,
        NG_CircularDependency = 131081,
        NG_CantCreateSubgroup = 131082,
        NG_BadArg = 131083,
        NG_NotNamedGroupElement = 131084,
        NG_FileReadOnly = 131085,
        NG_ExistsNotOverwriting = 131086,
        NG_NameNotUnique = 131087,
        NG_NotFound = 131088,
        NG_NotPersistent = 131089,
        NG_OperationInProgress = 131090,
        NG_IsFarReference = 131091,
    };

    public enum MemberTraverseType : int
    {
        Simple = 0,
        Manipulate = 1,
        Copy = 2,
        Enumerate = 3,
        DirectMembers = 4,
    };

    public enum MemberTraverseStatus : int
    {
        Continue = 0,
        SkipElement = 1,
        SkipGroup = 2,
        Abort = 3,
    };

    public enum OutputMessagePriority : int
    {
        None = 0,
        Error = 10,
        Warning = 11,
        Info = 12,
        Debug = 13,
        OldStyle = 14,
        TempRight = 15,
        TempLeft = 16,
        Fatal = 17,
    };

    public enum OutputMessageAlert : int
    {
        None = 0,
        Dialog = 1,
        Balloon = 2,
    };

    public enum RegisteredAppStatus : int
    {
        RA_Success = 0,
        RA_NameNotUnique = 147457,
        RA_NotFound = 147458,
        RA_CantWriteToFile = 147459,
        RA_CantCreateElement = 147460,
    };

    public enum ScanTestResult : int
    {
        Pass = 0,
        Fail = 1,
    };

    public enum SelectionSetAction : int
    {
        SELECT_NOTHING = 0,
        SELECT_STRETCH = 1,
        SELECT_WINDOW = 2,
        SELECT_DRAG = 3,
        SELECT_DRAG_NEW = 4,
        SELECT_SS_EMPTY = 6,
        SELECT_SS_CHANGED = 8,
        SELECT_DOUBLECLICK_HANDLE = 10,
        SELECT_DOUBLECLICK_ELEMENT = 11,
    };

    public enum ViewportResizeMode : int
    {
        KeepCurrent = 0,
        RelativeRect = 1,
        AspectRatio = 2,
        Size = 3,
        SizeAndPosition = 4,
    };

    public enum ECQueryProcessFlags : int
    {
        ECQUERY_PROCESS_Empty = 0,
        ECQUERY_PROCESS_SearchAllIntrinsic = 2,
        ECQUERY_PROCESS_SearchAllExtrinsic = 4,
        ECQUERY_PROCESS_SearchSpecifiedClasses = 8,
        ECQUERY_PROCESS_SearchAllClasses = 6,
    };

    public enum EvaluationReason : int
    {
        None = 0,
        Editor = 1,
        Update = 2,
        Plot = 4,
        ModelLoad = 8,
        ModelSave = 16,
        DesignHistory = 32,
        Unconditional = -1,
    };

    public enum ConfigurationVariableLevel : int
    {
        Predefined = -2,
        SysEnv = -1,
        System = 0,
        Application = 1,
        Organization = 2,
        WorkSpace = 3,
        WorkSet = 4,
        Role = 5,
        User = 6,
    };

    public enum DependencyStatus : int
    {
        Success = 0,
        CallbackError = 32768,
        MaxIterationsError = -1001,
        MissingCallBackError = -1002,
        RefToTentativeError = -1003,
        DisabledError = -1004,
        SuspendedError = -1005,
        RecursiveError = -1006,
    };

    public enum DependencyGraphEvaluationStatus : int
    {
        Success = 0,
        RedundantFailure = -2001,
        BadConstraintFailure = -2002,
        WeakConstraintsRejectedSuccess = -2003,
    };

    public enum LinkageKeyValues : int
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
        BYTEARRAY_LINKAGE_KEY_FontNameCP = 0,
        BYTEARRAY_LINKAGE_KEY_AlternateFontNameCP = 1,
        BYTEARRAY_LINKAGE_KEY_HLineTiling = 2,
        BYTEARRAY_LINKAGE_KEY_SectionEdgeId = 3,
        BYTEARRAY_LINKAGE_KEY_VectorIconModel = 4,
        BYTEARRAY_LINKAGE_KEY_AuxCoordGrid = 5,
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
        MULTISTATEMASK_LINKAGE_KEY_NamedLevelMask = 1,
        SYMBOLOGY_LINKAGE_KEY_RefBound = 0,
        SYMBOLOGY_LINKAGE_KEY_HLineVisible = 1,
        SYMBOLOGY_LINKAGE_KEY_HLineHidden = 2,
        SYMBOLOGY_LINKAGE_KEY_HLineSmooth = 3,
        ELEMENTID_LINKAGE_KEY_Generic = 0,
        ELEMENTID_LINKAGE_KEY_NestedAttachmentLevelTable = 1,
        ELEMENTID_LINKAGE_KEY_glyphId = 2,
        ELEMENTID_LINKAGE_KEY_LevelMaskAttachmentId = 3,
        MODELID_LINKAGE_KEY_ReferenceAttachment = 0,
    };

    public enum GradientFlags : int
    {
        Invert = 1,
        Outline = 2,
        AlwaysFilled = 4,
    };

    public enum BackgroundMapType : int
    {
        None = 0,
        Street = 1,
        Aerial = 2,
        Hybrid = 3,
    };

    public enum ViewLevelDisplayType : int
    {
        Normal = 1,
        Effective = 2,
    };

    public enum SnapStatus : int
    {
        Success = 0,
        Aborted = 1,
        NoElements = 2,
        Disabled = 100,
        NoSnapPossible = 200,
        NotSnappable = 300,
        RefNotSnappable = 301,
        FilteredByLevel = 400,
        FilteredByUser = 500,
        FilteredByApp = 600,
        FilteredByAppQuietly = 700,
    };

    public enum FileOpenConstants : int
    {
        OPEN_FOR_WRITE = 2,
        OPEN_FOR_READ = 0,
        UF_WTR_SUCCESS = 42,
        UF_OPEN_READ = 0,
        UF_OPEN_WRITE = 1,
        UF_OPEN_CREATE = 2,
        UF_TRY_WRITE_THEN_READ = 4,
        UF_CUR_DIR_SWAP = 8,
        UF_NO_CUR_DIR = 16,
        UF_JUST_BUILD = 32,
        UF_FIND_FOLDER = 256,
    };

    public enum TransformOptionValues : int
    {
        TRANSFORM_OPTIONS_ModelFromElmdscr = 1,
        TRANSFORM_OPTIONS_DimValueMatchSource = 2,
        TRANSFORM_OPTIONS_DimSizeMatchSource = 4,
        TRANSFORM_OPTIONS_MlineScaleOffsets = 8,
        TRANSFORM_OPTIONS_MlineMirrorOffsets = 16,
        TRANSFORM_OPTIONS_DisableMirrorCharacters = 32,
        TRANSFORM_OPTIONS_AnnotationSizeMatchSource = 128,
        TRANSFORM_OPTIONS_RotateDimView = 256,
        TRANSFORM_OPTIONS_ApplyAnnotationScale = 512,
        TRANSFORM_OPTIONS_FromClone = 1024,
        TRANSFORM_OPTIONS_NoteScaleSize = 2048,
        TRANSFORM_OPTIONS_DisableRotateCharacters = 4096,
    };

    public enum GridOrientationType : int
    {
        View = 0,
        WorldXY = 1,
        WorldYZ = 2,
        WorldXZ = 3,
        ACS = 4,
        Maximum = 4,
    };

    public enum DisplayPathType : int
    {
        Display = 0,
        Selection = 1,
        Hit = 2,
        Snap = 3,
        Intersection = 4,
    };

    public enum DitherModes : int
    {
        DITHERMODE_Pattern = 0,
        DITHERMODE_ErrorDiffusion = 1,
    };

    public enum DgnAttachmentAttachedReason : int
    {
        NewAttachment = 0,
        Reattached = 1,
        UndoneDetach = 2,
        RedoneAttach = 3,
        Reloaded = 4,
        ReattachUndoRedo = 5,
        ChildrenReloaded = 6,
        NewNonActiveModel = 7,
    };

    public enum DgnAttachmentDetachedReason : int
    {
        Detached = 0,
        UndoneAttach = 1,
        RedoneDetach = 2,
        Reattached = 3,
        ModelDeleted = 4,
        Reloaded = 5,
        MergedIntoMaster = 6,
    };

    public enum AgendaEvent : int
    {
        ModifyEntries = 1,
        PreModify = 2,
        PostModify = 3,
        AddClipboardFormats = 4,
        Redraw = 5,
        PreCopy = 6,
    };

    public enum MlineModifyPoint : int
    {
        None = 0,
        ShiftBreaks = 2,
        RemoveAssociations = 4,
    };

    public enum LevelMaskReferenceState : int
    {
        Unknown = 0,
        Off = 1,
        On = 2,
    };

    public enum StandardElementECDelegateId : int
    {
        MstnHeader = 1,
        MstnGraphHeader,
        MstnClosedBoundary,
        MstnComplex,
        MstnElementRange,
        MstnLockedElement,
        MstnRotation,
        MstnScale,
        MstnSurface,
        MstnVolume,
        NamedGroupInfo,
        MstnFaceAttachedMaterial,
        MstnHatchRegion,
        MstnMaterial,
        ElementNamedPresentation,
        MAX,
    };

    public enum VideoFileFormat : int
    {
        VIDEOFILE_FLI = 14,
        VIDEOFILE_FLC = 15,
        VIDEOFILE_AVI = 26,
        VIDEOFILE_WMV = 53,
    };

    public enum ImageFileFormat : int
    {
        IMAGEFILE_UNKNOWN = -1,
        IMAGEFILE_RGB = 1,
        IMAGEFILE_TARGA = 2,
        IMAGEFILE_TIFF = 3,
        IMAGEFILE_PICT = 4,
        IMAGEFILE_PCX = 5,
        IMAGEFILE_POSTSCRIPT = 6,
        IMAGEFILE_GIF = 7,
        IMAGEFILE_WPG = 8,
        IMAGEFILE_BMP = 9,
        IMAGEFILE_SUNRASTER = 10,
        IMAGEFILE_IMGMAPPED = 11,
        IMAGEFILE_IMGRGB = 12,
        IMAGEFILE_RLE = 13,
        _IMAGEFILE_FLI = 14,
        _IMAGEFILE_FLC = 15,
        IMAGEFILE_BUMP = 16,
        IMAGEFILE_COT = 17,
        IMAGEFILE_JPEG = 18,
        IMAGEFILE_CIT = 19,
        IMAGEFILE_TG4 = 20,
        IMAGEFILE_FAX = 21,
        IMAGEFILE_CALS = 22,
        IMAGEFILE_INGR = 23,
        IMAGEFILE_RLC = 24,
        IMAGEFILE_PACKBYTE = 25,
        _IMAGEFILE_AVI = 26,
        IMAGEFILE_PROCEDURE = 27,
        IMAGEFILE_PNG = 28,
        IMAGEFILE_GEOTIFF = 29,
        IMAGEFILE_HMR = 30,
        IMAGEFILE_ITIFF = 31,
        IMAGEFILE_C29 = 32,
        IMAGEFILE_MRSID = 33,
        IMAGEFILE_ERMAPPER = 34,
        IMAGEFILE_TIFFINTGR = 35,
        IMAGEFILE_MULTICHANNEL = 36,
        IMAGEFILE_C30 = 37,
        IMAGEFILE_C31 = 38,
        IMAGEFILE_EPX = 39,
        IMAGEFILE_BIL = 40,
        IMAGEFILE_JPEG2000 = 41,
        IMAGEFILE_MPF = 43,
        IMAGEFILE_CRL = 44,
        IMAGEFILE_LRD = 45,
        IMAGEFILE_DOQ = 46,
        IMAGEFILE_WBMP = 47,
        IMAGEFILE_ERDASIMG = 48,
        IMAGEFILE_NITF = 49,
        IMAGEFILE_DTED = 50,
        IMAGEFILE_ITIFF64 = 51,
        IMAGEFILE_XWMS = 52,
        _IMAGEFILE_WMV = 53,
        IMAGEFILE_PDF = 54,
        IMAGEFILE_BINGMAPS = 55,
        IMAGEFILE_BSB = 56,
        IMAGEFILE_XWCS = 57,
        IMAGEFILE_USGSDEM = 58,
        IMAGEFILE_USGSSDTSDEM = 59,
        IMAGEFILE_XORA = 60,
        IMAGEFILE_SPOTDIMAP = 61,
        IMAGEFILE_AIG = 62,
        IMAGEFILE_AAIG = 63,
        IMAGEFILE_PSD = 64,
        IMAGEFILE_POWERVRTEXTURE = 4096,
    };

    public enum ImageFormat : int
    {
        IMAGEFORMAT_BitMap = 1,
        IMAGEFORMAT_RLEBitMap = 2,
        IMAGEFORMAT_ByteMap = 3,
        IMAGEFORMAT_GreyScale = 4,
        IMAGEFORMAT_RGBSeparate = 5,
        IMAGEFORMAT_RGB = 6,
        IMAGEFORMAT_RGBA = 7,
        IMAGEFORMAT_PackByte = 8,
        IMAGEFORMAT_RLEByteMap = 9,
        IMAGEFORMAT_BGRA = 10,
        IMAGEFORMAT_RGBASeparate = 11,
        IMAGEFORMAT_BGRSeparate = 12,
    };

    public enum CompressionRatio : int
    {
        COMPRESSIONRATIO_LOSSLESS = 100,
        COMPRESSIONRATIO_MIN = 90,
        COMPRESSIONRATIO_LOW = 75,
        COMPRESSIONRATIO_MED = 55,
        COMPRESSIONRATIO_HIGH = 40,
        COMPRESSIONRATIO_DEFAULT = 0,
    };

    public enum CompressionType : int
    {
        COMPRESSTYPE_UNKNOWN = -99,
        COMPRESSTYPE_NONE = 0,
        COMPRESSTYPE_DEFAULT = 1,
        COMPRESSTYPE_CCITTRLE = 2,
        COMPRESSTYPE_CCITTFAX3 = 3,
        COMPRESSTYPE_CCITTFAX4 = 4,
        COMPRESSTYPE_LZW = 5,
        COMPRESSTYPE_OJPEG = 6,
        COMPRESSTYPE_JPEG = 7,
        COMPRESSTYPE_BMPRLE8 = 8,
        COMPRESSTYPE_BMPRLE4 = 9,
        COMPRESSTYPE_GIFLZW = 10,
        COMPRESSTYPE_NEXT = 32766,
        COMPRESSTYPE_CCITTRLEW = 32771,
        COMPRESSTYPE_PACKBITS = 32773,
        COMPRESSTYPE_THUNDERSCAN = 32809,
        COMPRESSTYPE_PIXARFILM = 32908,
        COMPRESSTYPE_DEFLATE = 32946,
        COMPRESSTYPE_JBIG = 34661,
        COMPRESSTYPE_JPEG2000 = 34712,
        COMPRESSTYPE_ECW = 34811,
        COMPRESSTYPE_RLE1 = 40000,
        COMPRESSTYPE_RLE8 = 40001,
        COMPRESSTYPE_ZLIB = 40002,
        COMPRESSTYPE_FLASHPIX = 40003,
        COMPRESSTYPE_TGARLE = 40213,
        COMPRESSTYPE_LRD = 40214,
        COMPRESSTYPE_FLIRLE8 = 40215,
        COMPRESSTYPE_CRL8 = 40216,
    };

    public enum ImageIngrOrientation : int
    {
        INGR_ORIENT_UpperLeftVertical = 0,
        INGR_ORIENT_UpperRightVertical = 1,
        INGR_ORIENT_LowerLeftVertical = 2,
        INGR_ORIENT_LowerRightVertical = 3,
        INGR_ORIENT_UpperLeftHorizontal = 4,
        INGR_ORIENT_UpperRightHorizontal = 5,
        INGR_ORIENT_LowerLeftHorizontal = 6,
        INGR_ORIENT_LowerRightHorizontal = 7,
    };

    public enum ImageOriginOrientation : int
    {
        TOP_LEFT = 0,
        TOP_RIGHT = 1,
        LOWER_LEFT = 2,
        LOWER_RIGHT = 3,
    };

    public enum MovieFrameTransition : int
    {
        MOVIE_FrameCut = 0,
        MOVIE_HorizontalWipe = 1,
        MOVIE_VerticalWipe = 2,
        MOVIE_Fade = 3,
    };

    public enum ResourcePlatformValues : int
    {
        PLATFORM_NOTSPECIFIED = 0,
        PLATFORM_4X = 0,
        PLATFORM_PC_BSIWINMGR = 1,
        PLATFORM_MAC_MACOS = 3,
        PLATFORM_SPARC_X = 4,
        PLATFORM_HP_X = 6,
        PLATFORM_SGIMIPS_X = 7,
        PLATFORM_RS6000_X = 9,
        PLATFORM_PC_WINNT = 10,
        PLATFORM_ALPHA_WINNT = 11,
        PLATFORM_SOLARISX86_X = 12,
        PLATFORM_POWERMAC = 14,
        PLATFORM_PPC_WINNT = 15,
        PLATFORM_PC_OS2 = 16,
        PLATFORM_PC_LINUX_X = 18,
    };

    public enum RasterRefFlagValue : int
    {
        RASTREF_MASK_ELEMENTFOUND = 1,
        RASTREF_SHIFT_ELEMENTFOUND = 0,
        RASTREF_MASK_UPDATESEQUENCE = 6,
        RASTREF_SHIFT_UPDATESEQUENCE = 1,
        RASTREF_MASK_TYPE87FOUND = 8,
        RASTREF_SHIFT_TYPE87FOUND = 3,
        RASTREF_MASK_IMAGEMANAGER = 112,
        RASTREF_SHIFT_IMAGEMANAGER = 4,
        RASTREF_MASK_RESERVED = 16,
        RASTREF_SHIFT_RESERVED = 7,
    };

    public enum MSRasterElemTypes : int
    {
        BITMAP_RASTER = 1,
        BYTE_DATA_RASTER = 2,
        BINARY_RLE_RASTER = 9,
        BYTE_RLE_RASTER = 24,
    };

    public enum ElementRefType : int
    {
        ELEMENT_REF_TYPE_Persistent = 1,
        ELEMENT_REF_TYPE_TransientElm = 2,
        ELEMENT_REF_TYPE_ViewTemp = 3,
        ELEMENT_REF_TYPE_ProxyDisplay = 4,
    };

    public enum ElementHiliteState : int
    {
        HILITED_None = 0,
        HILITED_Normal = 1,
        HILITED_Bold = 2,
        HILITED_Dashed = 3,
        HILITED_ComponentsNormal = 4,
        HILITED_ComponentsOnly = 5,
        HILITED_Background = 6,
    };

    public enum ACSDisplayOptions : int
    {
        None = 0,
        Inactive = 0,
        Active = 1,
        Hilite = 4,
        Deemphasized = 2,
        CheckVisible = 8,
    };

    public enum GeoAttachmentHandling : int
    {
        Default = 0,
        DoNotReproject = 1,
        AcceptUnprojected = 2,
    };

    public enum ModelFlags : int
    {
        MODELFLAG_NOT_IN_MODEL_LIST = 1,
        MODELFLAG_NOT_IN_CELL_LIST = 3,
        MODELFLAG_LSSCALE_COMP_ANNSCALE = 4,
        MODELFLAG_LSSCALE_IS_ANNSCALE = 5,
        MODELFLAG_IS_ANNOTATION_CELL = 6,
        MODELFLAG_AUTO_UPDATE_FIELDS = 7,
        MODELFLAG_NON_INDEXED = 8,
        MODELFLAG_IS_MARKUP = 9,
        MODELFLAG_DRAW_MASTERMODEL_LAST = 11,
        MODELFLAG_NO_PROPAGATE_ANNSCALE = 12,
        MODELFLAG_UNIT_LOCK = 32,
        MODELFLAG_GRID_LOCK = 33,
        MODELFLAG_ISO_GRID = 34,
        MODELFLAG_ISO_LOCK = 35,
        MODELFLAG_ISO_PLANE = 36,
        MODELFLAG_USE_ANNOTATION_SCALE = 38,
        MODELFLAG_ACS_LOCK = 39,
    };

    public enum SupportOperation : int
    {
        Selection = 0,
        CellGroup = 1,
        CellUnGroup = 2,
        TransientManipulators = 3,
        CacheCutGraphics = 4,
        LineStyle = 5,
        CustomHilite = 6,
    };

    public enum DgnFileRights : int
    {
        DGNFILE_RIGHT_Any = 0,
        DGNFILE_RIGHT_Print = 1,
        DGNFILE_RIGHT_Export = 2,
        DGNFILE_RIGHT_Edit = 4,
        DGNFILE_RIGHT_Unlimited_Bit = -2147483648,
        DGNFILE_RIGHT_Unlimited = -1,
    };

    public enum DgnFilePurpose : int
    {
        Unknown = 0,
        MasterFile = 1,
        DgnAttachment = 2,
        DgnLib = 3,
        ActivatedAttachment = 4,
        CellLibrary = 5,
        WorkDgn = 6,
        Clipboard = 7,
        Temporary = 8,
        Icons = 9,
        LevelLibrary = 10,
        Overlay = 11,
    };

    public enum DgnECChangeType : int
    {
        None = 0,
        Added,
        Deleted,
        Modified,
    };

    public enum ColorDefConstants : int
    {
        MAX_COLOR_NAME_SIZE = 30,
        MAX_CMAPENTRIES = 256,
        MAX_CTBLBYTES = 768,
        MAX_CTBLNAMESIZE = 64,
        MAX_ExtendedColorIndex = 1048575,
        BLACK_MENU_COLOR_INDEX = 0,
        BLUE_MENU_COLOR_INDEX = 1,
        GREEN_MENU_COLOR_INDEX = 2,
        CYAN_MENU_COLOR_INDEX = 3,
        RED_MENU_COLOR_INDEX = 4,
        MAGENTA_MENU_COLOR_INDEX = 5,
        YELLOW_MENU_COLOR_INDEX = 6,
        WHITE_MENU_COLOR_INDEX = 7,
        LGREY_MENU_COLOR_INDEX = 8,
        DGREY_MENU_COLOR_INDEX = 9,
        MGREY_MENU_COLOR_INDEX = 10,
        NUM_MENU_COLORS = 12,
        NUM_NEW_FIXED_COLORS = 6,
        NEW_NUM_MENU_COLORS = 18,
        COLORD_RGB = 1,
        COLORD_HSV = 2,
        COLORD_XCOLORID = 3,
        COLORD_XNAMEID = 3,
        COLORD_XCOLORSTRING = 4,
        COLORD_XNAMESTR = 4,
        COLORD_ELEM_COLOR_NUMBER = 5,
        COLORD_MENUCOLORID = 6,
        COLORD_ATTRDATA = 7,
        COLORD_RGBDITHERED = 8,
        COLORD_VPAL_INDEX = 9,
        COLORD_ELEM_COLOR_REF = 10,
        COLORD_DRAW_VALUE = 20,
        COLORD_DRAW_INDEX = 20,
        PALFLAG_MATCHLOADEDCOLORS = 0,
        PALFLAG_MATCHDGNCTBL = 1,
        PALSTATUS_SYNCHABLE = 1,
        COLOR_STRESS_DEFAULT = 0,
        COLOR_STRESS_HUE = 1,
        COLOR_STRESS_SATURATION = 2,
        COLOR_STRESS_VALUE = 4,
        SYNCH_DUE_TO_LOAD_COLORS = 1,
        SYNCH_DUE_TO_CMAP_CHG = 2,
    };

    public enum PatternPlacementTypes : int
    {
        PATTERN_HATCH = 0,
        PATTERN_CROSSHATCH = 1,
        PATTERN_AREA = 2,
    };

    public enum DrawExpense : int
    {
        Medium = 1,
        High = 2,
    };

    public enum LineJoin : int
    {
        None = 0,
        Bevel = 1,
        Miter = 2,
        Round = 3,
    };

    public enum LineCap : int
    {
        None = 0,
        Flat = 1,
        Square = 2,
        Round = 3,
        Triangle = 4,
    };

    public enum RangeResult : int
    {
        Outside = -1,
        Overlap = 0,
        Inside = 1,
    };

    public enum RasterFormat : int
    {
        RGBA = 0,
        BGRA = 1,
        RGB = 2,
        BGR = 3,
        Gray = 4,
        Alpha = 5,
        RGBS = 6,
        BGRS = 7,
    };

    public enum OvrMatSymbFlags : int
    {
        MATSYMB_OVERRIDE_None = 0,
        MATSYMB_OVERRIDE_Color = 1,
        MATSYMB_OVERRIDE_ColorTransparency = 2,
        MATSYMB_OVERRIDE_FillColor = -2147483644,
        MATSYMB_OVERRIDE_FillColorTransparency = 8,
        MATSYMB_OVERRIDE_RastWidth = 16,
        MATSYMB_OVERRIDE_Style = 32,
        MATSYMB_OVERRIDE_TrueWidth = 64,
        MATSYMB_OVERRIDE_ExtSymb = 128,
        MATSYMB_OVERRIDE_RenderMaterial = 256,
    };

    public enum ProxyCacheStatus : int
    {
        NotCached = 0,
        UpToDate = 1,
        ModelChanged = 2,
        ViewChanged = 3,
        NotUsedInView = 4,
        AttachmentChanged = 5,
        ObsoleteVersion = 6,
        NotDisplayedInView = 7,
        MissingReferences = 8,
        Disconnected = 9,
        ReferenceNotFound = 10,
        ReferenceLoadDisabled = 11,
        ObsoleteValidityHash = 12,
    };

    public enum DimStyleProp_BallAndChain_Mode : int
    {
        DIMSTYLE_VALUE_BallAndChain_Mode_None = 0,
        DIMSTYLE_VALUE_BallAndChain_Mode_On = 1,
        DIMSTYLE_VALUE_BallAndChain_Mode_Auto = 2,
        DIMSTYLE_VALUE_BallAndChain_MODE_COUNT = 3,
    };

    public enum DimStyleProp_BallAndChain_Alignment : int
    {
        DIMSTYLE_VALUE_BallAndChain_Alignment_Auto = 0,
        DIMSTYLE_VALUE_BallAndChain_Alignment_Left = 1,
        DIMSTYLE_VALUE_BallAndChain_Alignment_Right = 2,
        DIMSTYLE_VALUE_BallAndChain_Alignment_COUNT = 3,
    };

    public enum DimStyleProp_Terminator_Type : int
    {
        DIMSTYLE_VALUE_Terminator_Type_None = 0,
        DIMSTYLE_VALUE_Terminator_Type_Arrow = 1,
        DIMSTYLE_VALUE_Terminator_Type_Stroke = 2,
        DIMSTYLE_VALUE_Terminator_Type_Origin = 3,
        DIMSTYLE_VALUE_Terminator_Type_Dot = 4,
        DIMSTYLE_VALUE_Terminator_Type_Note = 5,
        DIMSTYLE_VALUE_Terminator_Type_COUNT = 6,
    };

    public enum DimStyleProp_BallAndChain_ChainType : int
    {
        DIMSTYLE_VALUE_BallAndChain_ChainType_None = 0,
        DIMSTYLE_VALUE_BallAndChain_ChainType_Line = 1,
        DIMSTYLE_VALUE_BallAndChain_ChainType_Arc = 2,
        DIMSTYLE_VALUE_BallAndChain_ChainType_BSpline = 3,
        DIMSTYLE_VALUE_BallAndChain_ChainType_COUNT = 4,
    };

    public enum DimStyleProp_General_Alignment : int
    {
        DIMSTYLE_VALUE_General_Alignment_View = 0,
        DIMSTYLE_VALUE_General_Alignment_Drawing = 1,
        DIMSTYLE_VALUE_General_Alignment_True = 2,
        DIMSTYLE_VALUE_General_Alignment_Arbitrary = 3,
        DIMSTYLE_VALUE_General_Alignment_COUNT = 4,
    };

    public enum DimStyleProp_General_RadialMode : int
    {
        DIMSTYLE_VALUE_General_RadialMode_CenterMark = 0,
        DIMSTYLE_VALUE_General_RadialMode_Radius = 1,
        DIMSTYLE_VALUE_General_RadialMode_RadiusExtended = 2,
        DIMSTYLE_VALUE_General_RadialMode_Diameter = 3,
        DIMSTYLE_VALUE_General_RadialMode_DiameterExtended = 4,
        DIMSTYLE_VALUE_General_RadialMode_COUNT = 5,
    };

    public enum DimStyleProp_MLNote_FrameType : int
    {
        DIMSTYLE_VALUE_MLNote_FrameType_None = 0,
        DIMSTYLE_VALUE_MLNote_FrameType_Line = 1,
        DIMSTYLE_VALUE_MLNote_FrameType_Box = 2,
        DIMSTYLE_VALUE_MLNote_FrameType_RotatedBox = 3,
        DIMSTYLE_VALUE_MLNote_FrameType_Circle = 4,
        DIMSTYLE_VALUE_MLNote_FrameType_Capsule = 5,
        DIMSTYLE_VALUE_MLNote_FrameType_Hexagon = 6,
        DIMSTYLE_VALUE_MLNote_FrameType_RotatedHexagon = 7,
        DIMSTYLE_VALUE_MLNote_FrameType_Triangle = 8,
        DIMSTYLE_VALUE_MLNote_FrameType_Pentagon = 9,
        DIMSTYLE_VALUE_MLNote_FrameType_Octagon = 10,
        DIMSTYLE_VALUE_MLNote_FrameType_COUNT = 11,
    };

    public enum DimStyleProp_MLNote_Justification : int
    {
        DIMSTYLE_VALUE_MLNote_Justification_Left = 0,
        DIMSTYLE_VALUE_MLNote_Justification_Right = 1,
        DIMSTYLE_VALUE_MLNote_Justification_Dynamic = 2,
        DIMSTYLE_VALUE_MLNote_Justification_Center = 3,
        DIMSTYLE_VALUE_MLNote_Justification_COUNT = 4,
    };

    public enum DimStyleProp_MLNote_VerticalJustification : int
    {
        DIMSTYLE_VALUE_MLNote_VerticalJustification_Top = 0,
        DIMSTYLE_VALUE_MLNote_VerticalJustification_Center = 1,
        DIMSTYLE_VALUE_MLNote_VerticalJustification_Bottom = 2,
        DIMSTYLE_VALUE_MLNote_VerticalJustification_Dynamic = 3,
        DIMSTYLE_VALUE_MLNote_VerticalJustification_COUNT = 4,
    };

    public enum DimStyleProp_MLNote_TextRotation : int
    {
        DIMSTYLE_VALUE_MLNote_TextRotation_Horizontal = 0,
        DIMSTYLE_VALUE_MLNote_TextRotation_Vertical = 1,
        DIMSTYLE_VALUE_MLNote_TextRotation_Inline = 2,
        DIMSTYLE_VALUE_MLNote_TextRotation_COUNT = 3,
    };

    public enum DimStyleProp_MLNote_HorAttachment : int
    {
        DIMSTYLE_VALUE_MLNote_HorAttachment_Auto = 0,
        DIMSTYLE_VALUE_MLNote_HorAttachment_Left = 1,
        DIMSTYLE_VALUE_MLNote_HorAttachment_Right = 2,
        DIMSTYLE_VALUE_MLNote_HorAttachment_COUNT = 3,
    };

    public enum DimStyleProp_MLNote_VerAttachment : int
    {
        DIMSTYLE_VALUE_MLNote_VerAttachment_Top = 0,
        DIMSTYLE_VALUE_MLNote_VerAttachment_TopLine = 1,
        DIMSTYLE_VALUE_MLNote_VerAttachment_Middle = 2,
        DIMSTYLE_VALUE_MLNote_VerAttachment_BottomLine = 3,
        DIMSTYLE_VALUE_MLNote_VerAttachment_Bottom = 4,
        DIMSTYLE_VALUE_MLNote_VerAttachment_DynamicLine = 5,
        DIMSTYLE_VALUE_MLNote_VerAttachment_DynamicCorner = 6,
        DIMSTYLE_VALUE_MLNote_VerAttachment_Underline = 7,
        DIMSTYLE_VALUE_MLNote_VerAttachment_COUNT = 8,
    };

    public enum DimStyleProp_Symbol_Standard : int
    {
        DIMSTYLE_VALUE_Symbol_Standard_None = 0,
        DIMSTYLE_VALUE_Symbol_Standard_Diameter = 1,
        DIMSTYLE_VALUE_Symbol_Standard_Radius = 2,
        DIMSTYLE_VALUE_Symbol_Standard_Area = 3,
        DIMSTYLE_VALUE_Symbol_Standard_SphericalRadius = 4,
        DIMSTYLE_VALUE_Symbol_Standard_SphericalDiameter = 5,
        DIMSTYLE_VALUE_Symbol_Standard_COUNT = 6,
    };

    public enum DimStyleProp_Symbol_CustomType : int
    {
        DIMSTYLE_VALUE_Symbol_CustomType_Default = 0,
        DIMSTYLE_VALUE_Symbol_CustomType_Character = 1,
        DIMSTYLE_VALUE_Symbol_CustomType_COUNT = 2,
    };

    public enum DimStyleProp_Symbol_PreSufType : int
    {
        DIMSTYLE_VALUE_Symbol_PreSufType_None = 0,
        DIMSTYLE_VALUE_Symbol_PreSufType_Character = 1,
        DIMSTYLE_VALUE_Symbol_PreSufType_Cell = 2,
        DIMSTYLE_VALUE_Symbol_PreSufType_COUNT = 3,
    };

    public enum DimStyleProp_Symbol_TermType : int
    {
        DIMSTYLE_VALUE_Symbol_TermType_Default = 0,
        DIMSTYLE_VALUE_Symbol_TermType_Character = 1,
        DIMSTYLE_VALUE_Symbol_TermType_Cell = 2,
        DIMSTYLE_VALUE_Symbol_TermType_COUNT = 3,
    };

    public enum DimStyleProp_Terminator_Mode : int
    {
        DIMSTYLE_VALUE_Terminator_Mode_Auto = 0,
        DIMSTYLE_VALUE_Terminator_Mode_Reversed = 1,
        DIMSTYLE_VALUE_Terminator_Mode_Inside = 2,
        DIMSTYLE_VALUE_Terminator_Mode_Outside = 3,
        DIMSTYLE_VALUE_Terminator_Mode_COUNT = 4,
    };

    public enum DimStyleProp_Terminator_Arrowhead : int
    {
        DIMSTYLE_VALUE_Terminator_Arrowhead_Open = 0,
        DIMSTYLE_VALUE_Terminator_Arrowhead_Closed = 1,
        DIMSTYLE_VALUE_Terminator_Arrowhead_Filled = 2,
        DIMSTYLE_VALUE_Terminator_Arrowhead_COUNT = 3,
    };

    public enum DimStyleProp_Text_Justification : int
    {
        DIMSTYLE_VALUE_Text_Justification_Offset = 0,
        DIMSTYLE_VALUE_Text_Justification_Left = 1,
        DIMSTYLE_VALUE_Text_Justification_CenterLeft = 2,
        DIMSTYLE_VALUE_Text_Justification_Right = 3,
        DIMSTYLE_VALUE_Text_Justification_CenterRight = 4,
        DIMSTYLE_VALUE_Text_Justification_COUNT = 5,
    };

    public enum DimStyleProp_Value_AngleFormat : int
    {
        DIMSTYLE_VALUE_Value_AngleFormat_Degrees = 0,
        DIMSTYLE_VALUE_Value_AngleFormat_DegMinSec = 1,
        DIMSTYLE_VALUE_Value_AngleFormat_Centesimal = 2,
        DIMSTYLE_VALUE_Value_AngleFormat_Radians = 3,
        DIMSTYLE_VALUE_Value_AngleFormat_DegMin = 4,
        DIMSTYLE_VALUE_Value_AngleFormat_COUNT = 5,
    };

    public enum DimStyleProp_Value_AnglePrecision : int
    {
        DIMSTYLE_VALUE_Value_AnglePrecision_Whole = 0,
        DIMSTYLE_VALUE_Value_AnglePrecision_1_Place = 1,
        DIMSTYLE_VALUE_Value_AnglePrecision_2_Place = 2,
        DIMSTYLE_VALUE_Value_AnglePrecision_3_Place = 3,
        DIMSTYLE_VALUE_Value_AnglePrecision_4_Place = 4,
        DIMSTYLE_VALUE_Value_AnglePrecision_5_Place = 5,
        DIMSTYLE_VALUE_Value_AnglePrecision_6_Place = 6,
        DIMSTYLE_VALUE_Value_AnglePrecision_COUNT = 7,
    };

    public enum DimStyleProp_Value_DMSPrecisionMode : int
    {
        DIMSTYLE_VALUE_Value_DMSPrecisionMode_Fixed = 0,
        DIMSTYLE_VALUE_Value_DMSPrecisionMode_Floating = 1,
        DIMSTYLE_VALUE_Value_DMSPrecisionMode_COUNT = 2,
    };

    public enum DimStyleProp_Text_StackedFractionAlignment : int
    {
        DIMSTYLE_VALUE_Text_StackedFractionAlignment_Top = 0,
        DIMSTYLE_VALUE_Text_StackedFractionAlignment_Center = 1,
        DIMSTYLE_VALUE_Text_StackedFractionAlignment_Bottom = 2,
        DIMSTYLE_VALUE_Text_StackedFractionAlignment_COUNT = 3,
    };

    public enum DimStyleProp_Text_StackedFractionType : int
    {
        DIMSTYLE_VALUE_Text_StackedFractionType_FromFont = 0,
        DIMSTYLE_VALUE_Text_StackedFractionType_Horizontal = 1,
        DIMSTYLE_VALUE_Text_StackedFractionType_Diagonal = 2,
        DIMSTYLE_VALUE_Text_StackedFractionType_COUNT = 3,
    };

    public enum DimStyleProp_Placement_TextPosition : int
    {
        DIMSTYLE_VALUE_Placement_TextPosition_Manual = 0,
        DIMSTYLE_VALUE_Placement_TextPosition_SemiAuto = 1,
        DIMSTYLE_VALUE_Placement_TextPosition_Auto = 2,
        DIMSTYLE_VALUE_Placement_TextPosition_COUNT = 3,
    };

    public enum DimStyleProp_Text_Location : int
    {
        DIMSTYLE_VALUE_Text_Location_Inline = 0,
        DIMSTYLE_VALUE_Text_Location_Above = 1,
        DIMSTYLE_VALUE_Text_Location_Outside = 2,
        DIMSTYLE_VALUE_Text_Location_TopLeft = 3,
        DIMSTYLE_VALUE_Text_Location_COUNT = 4,
    };

    public enum DimStyleProp_Text_SuperscriptMode : int
    {
        DIMSTYLE_VALUE_Text_SuperscriptMode_FromFont = 0,
        DIMSTYLE_VALUE_Text_SuperscriptMode_Generated = 1,
        DIMSTYLE_VALUE_Text_SuperscriptMode_COUNT = 2,
    };

    public enum DimStyleProp_Value_Format : int
    {
        DIMSTYLE_VALUE_Value_Format_MU = 0,
        DIMSTYLE_VALUE_Value_Format_MU_Label = 1,
        DIMSTYLE_VALUE_Value_Format_SU = 2,
        DIMSTYLE_VALUE_Value_Format_SU_Label = 3,
        DIMSTYLE_VALUE_Value_Format_MU_dash_SU = 4,
        DIMSTYLE_VALUE_Value_Format_MU_Label_SU_Label = 5,
        DIMSTYLE_VALUE_Value_Format_MU_Label_dash_SU_Label = 6,
        DIMSTYLE_VALUE_Value_Format_COUNT = 7,
    };

    public enum DimStyleProp_Value_Comparison : int
    {
        DIMSTYLE_VALUE_Value_Compare_Less = 0,
        DIMSTYLE_VALUE_Value_Compare_Greater = 1,
        DIMSTYLE_VALUE_Value_Compare_LessOrEqual = 2,
        DIMSTYLE_VALUE_Value_Compare_GreaterOrEqual = 3,
        DIMSTYLE_VALUE_Value_Compare_COUNT = 4,
    };

    public enum DimStyleProp_Text_Vertical : int
    {
        DIMSTYLE_VALUE_Text_Vertical_Never = 0,
        DIMSTYLE_VALUE_Text_Vertical_Always = 1,
        DIMSTYLE_VALUE_Text_Vertical_NoFit = 2,
        DIMSTYLE_VALUE_Text_Vertical_COUNT = 3,
    };

    public enum DimStyleProp_Value_ThousandsOpts : int
    {
        DIMSTYLE_VALUE_Value_ThousandsSep_None = 0,
        DIMSTYLE_VALUE_Value_ThousandsSep_Space = 1,
        DIMSTYLE_VALUE_Value_ThousandsSep_Comma = 2,
        DIMSTYLE_VALUE_Value_Thousands_COUNT = 3,
    };

    public enum DimStyleProp_Text_FrameType : int
    {
        DIMSTYLE_VALUE_Text_FrameType_None = 0,
        DIMSTYLE_VALUE_Text_FrameType_Box = 1,
        DIMSTYLE_VALUE_Text_FrameType_Capsule = 2,
        DIMSTYLE_VALUE_Text_FrameType_COUNT = 3,
    };

    public enum DimStyleProp_Value_LabelLineFormat : int
    {
        DIMSTYLE_VALUE_Value_LabelLineFormat_Standard = 0,
        DIMSTYLE_VALUE_Value_LabelLineFormat_AngleOverLength = 1,
        DIMSTYLE_VALUE_Value_LabelLineFormat_LengthAbove = 2,
        DIMSTYLE_VALUE_Value_LabelLineFormat_AngleAbove = 3,
        DIMSTYLE_VALUE_Value_LabelLineFormat_LengthBelow = 4,
        DIMSTYLE_VALUE_Value_LabelLineFormat_AngleBelow = 5,
        DIMSTYLE_VALUE_Value_LabelLineFormat_LengthAngleAbove = 6,
        DIMSTYLE_VALUE_Value_LabelLineFormat_LengthAngleBelow = 7,
        DIMSTYLE_VALUE_Value_LabelLineFormat_COUNT = 8,
    };

    public enum DimStyleProp_Value_Accuracy : int
    {
        DIMSTYLE_VALUE_Value_Accuracy_Whole = 0,
        DIMSTYLE_VALUE_Value_Accuracy_1_Decimal = 129,
        DIMSTYLE_VALUE_Value_Accuracy_2_Decimal = 130,
        DIMSTYLE_VALUE_Value_Accuracy_3_Decimal = 132,
        DIMSTYLE_VALUE_Value_Accuracy_4_Decimal = 136,
        DIMSTYLE_VALUE_Value_Accuracy_5_Decimal = 144,
        DIMSTYLE_VALUE_Value_Accuracy_6_Decimal = 160,
        DIMSTYLE_VALUE_Value_Accuracy_7_Decimal = 192,
        DIMSTYLE_VALUE_Value_Accuracy_8_Decimal = 128,
        DIMSTYLE_VALUE_Value_Accuracy_Half = 1,
        DIMSTYLE_VALUE_Value_Accuracy_Quarter = 2,
        DIMSTYLE_VALUE_Value_Accuracy_Eighth = 4,
        DIMSTYLE_VALUE_Value_Accuracy_Sixteenth = 8,
        DIMSTYLE_VALUE_Value_Accuracy_ThirtySecond = 16,
        DIMSTYLE_VALUE_Value_Accuracy_SixtyFourth = 32,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_1_Decimal = 64,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_2_Decimal = 65,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_3_Decimal = 66,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_4_Decimal = 67,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_5_Decimal = 68,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_6_Decimal = 69,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_7_Decimal = 70,
        DIMSTYLE_VALUE_Value_Accuracy_Scientific_8_Decimal = 71,
    };

    public enum DimStyleProp_FitOptions : int
    {
        DIMSTYLE_VALUE_FitOption_MoveTermsFirst = 0,
        DIMSTYLE_VALUE_FitOption_ReverseTerms = 1,
        DIMSTYLE_VALUE_FitOption_KeepTermsInside = 2,
        DIMSTYLE_VALUE_FitOption_KeepTermsOutside = 3,
        DIMSTYLE_VALUE_FitOption_KeepTextInside = 4,
        DIMSTYLE_VALUE_FitOption_MoveTextFirst = 5,
        DIMSTYLE_VALUE_FitOption_MoveBoth = 6,
        DIMSTYLE_VALUE_FitOption_MoveEither = 7,
        DIMSTYLE_VALUE_FitOption_COUNT = 8,
    };

    public enum DimStyleProp : int
    {
        DIMSTYLE_PROP_Invalid = 0,
        DIMSTYLE_PROP_BallAndChain_Alignment_INTEGER = 101,
        DIMSTYLE_PROP_BallAndChain_ChainTerminator_INTEGER = 102,
        DIMSTYLE_PROP_BallAndChain_ChainType_INTEGER = 103,
        DIMSTYLE_PROP_BallAndChain_IsActive_BOOLINT = 104,
        DIMSTYLE_PROP_BallAndChain_ShowTextLeader_BOOLINT = 105,
        DIMSTYLE_PROP_BallAndChain_NoDockOnDimLine_BOOLINT = 106,
        DIMSTYLE_PROP_BallAndChain_ElbowLength_DOUBLE = 107,
        DIMSTYLE_PROP_MLNote_ElbowLength_DOUBLE = 108,
        DIMSTYLE_PROP_BallAndChain_UseElbowLength_BOOLINT = 109,
        DIMSTYLE_PROP_BallAndChain_Mode_INTEGER = 110,
        DIMSTYLE_PROP_ExtensionLine_Color_COLOR = 201,
        DIMSTYLE_PROP_ExtensionLine_Extend_DOUBLE = 202,
        DIMSTYLE_PROP_ExtensionLine_Join_BOOLINT = 203,
        DIMSTYLE_PROP_ExtensionLine_Left_TEMPLATEFLAG = 204,
        DIMSTYLE_PROP_ExtensionLine_LineStyle_LINESTYLE = 205,
        DIMSTYLE_PROP_ExtensionLine_Offset_DOUBLE = 206,
        DIMSTYLE_PROP_ExtensionLine_OverrideColor_BOOLINT = 207,
        DIMSTYLE_PROP_ExtensionLine_OverrideLineStyle_BOOLINT = 208,
        DIMSTYLE_PROP_ExtensionLine_OverrideWeight_BOOLINT = 209,
        DIMSTYLE_PROP_ExtensionLine_Right_TEMPLATEFLAG = 210,
        DIMSTYLE_PROP_ExtensionLine_ShowAny_BOOLINT = 211,
        DIMSTYLE_PROP_ExtensionLine_Weight_WEIGHT = 212,
        DIMSTYLE_PROP_ExtensionLine_AngleChordAlign_TEMPLATEFLAG = 213,
        DIMSTYLE_PROP_General_Alignment_INTEGER = 301,
        DIMSTYLE_PROP_General_CenterMarkSize_DISTANCE = 302,
        DIMSTYLE_PROP_General_Color_COLOR = 303,
        DIMSTYLE_PROP_General_DimensionScale_DOUBLE = 304,
        DIMSTYLE_PROP_General_DimStyleDescription_MSWCHAR = 305,
        DIMSTYLE_PROP_General_DimStyleName_MSWCHAR = 306,
        DIMSTYLE_PROP_General_Font_FONT = 307,
        DIMSTYLE_PROP_General_IgnoreLevelSymbology_BOOLINT = 308,
        DIMSTYLE_PROP_General_LineStyle_LINESTYLE = 309,
        DIMSTYLE_PROP_General_OverrideColor_BOOLINT = 310,
        DIMSTYLE_PROP_General_OverrideLineStyle_BOOLINT = 311,
        DIMSTYLE_PROP_General_OverrideWeight_BOOLINT = 312,
        DIMSTYLE_PROP_General_RadialMode_INTEGER = 313,
        DIMSTYLE_PROP_General_RelativeDimLine_BOOLINT = 314,
        DIMSTYLE_PROP_General_ShowCenterMark_TEMPLATEFLAG = 315,
        DIMSTYLE_PROP_General_Stacked_TEMPLATEFLAG = 316,
        DIMSTYLE_PROP_General_StackOffset_DISTANCE = 317,
        DIMSTYLE_PROP_General_Weight_WEIGHT = 318,
        DIMSTYLE_PROP_General_FitOption_INTEGER = 319,
        DIMSTYLE_PROP_General_SuppressUnfitTerminators_BOOLINT = 320,
        DIMSTYLE_PROP_General_PushTextRight_BOOLINT = 321,
        DIMSTYLE_PROP_General_TightFitTextAbove_BOOLINT = 322,
        DIMSTYLE_PROP_General_UseMinLeader_BOOLINT = 323,
        DIMSTYLE_PROP_General_FitInclinedTextBox_BOOLINT = 324,
        DIMSTYLE_PROP_General_FrozenInSharedCell_BOOLINT = 325,
        DIMSTYLE_PROP_General_ExtendDimLineUnderText_BOOLINT = 326,
        DIMSTYLE_PROP_MLNote_FrameType_INTEGER = 401,
        DIMSTYLE_PROP_MLNote_Justification_INTEGER = 402,
        DIMSTYLE_PROP_MLNote_ShowLeader_BOOLINT = 403,
        DIMSTYLE_PROP_MLNote_VerticalJustification_INTEGER = 404,
        DIMSTYLE_PROP_MLNote_LeaderType_BOOLINT = 405,
        DIMSTYLE_PROP_MLNote_TextRotation_INTEGER = 406,
        DIMSTYLE_PROP_MLNote_HorAttachment_INTEGER = 407,
        DIMSTYLE_PROP_MLNote_VerLeftAttachment_INTEGER = 408,
        DIMSTYLE_PROP_MLNote_VerRightAttachment_INTEGER = 409,
        DIMSTYLE_PROP_MLNote_LeftMargin_DOUBLE = 410,
        DIMSTYLE_PROP_MLNote_LowerMargin_DOUBLE = 411,
        DIMSTYLE_PROP_MLNote_ScaleFrame_BOOLINT = 412,
        DIMSTYLE_PROP_MLNote_FrameScale_DOUBLE = 413,
        DIMSTYLE_PROP_Placement_CompatibleV3_BOOLINT = 501,
        DIMSTYLE_PROP_Placement_Level_LEVEL = 502,
        DIMSTYLE_PROP_Placement_OverrideLevel_BOOLINT = 503,
        DIMSTYLE_PROP_Placement_TextPosition_INTEGER = 504,
        DIMSTYLE_PROP_Placement_UseReferenceScale_BOOLINT = 505,
        DIMSTYLE_PROP_Placement_UseStyleAnnotationScale_BOOLINT = 506,
        DIMSTYLE_PROP_Placement_AnnotationScale_DOUBLE = 507,
        DIMSTYLE_PROP_Symbol_DiameterChar_CHAR = 601,
        DIMSTYLE_PROP_Symbol_DiameterFont_FONT = 602,
        DIMSTYLE_PROP_Symbol_DiameterType_INTEGER = 603,
        DIMSTYLE_PROP_Symbol_LowerPrefixChar_CHAR = 604,
        DIMSTYLE_PROP_Symbol_LowerSuffixChar_CHAR = 605,
        DIMSTYLE_PROP_Symbol_MainPrefixChar_CHAR = 606,
        DIMSTYLE_PROP_Symbol_MainSuffixChar_CHAR = 607,
        DIMSTYLE_PROP_Symbol_PlusMinusChar_CHAR = 608,
        DIMSTYLE_PROP_Symbol_PlusMinusType_INTEGER = 609,
        DIMSTYLE_PROP_Symbol_Prefix_TEMPLATEFLAG = 610,
        DIMSTYLE_PROP_Symbol_PrefixCellName_MSWCHAR = 611,
        DIMSTYLE_PROP_Symbol_PrefixChar_CHAR = 612,
        DIMSTYLE_PROP_Symbol_PrefixFont_FONT = 613,
        DIMSTYLE_PROP_Symbol_PrefixType_INTEGER = 614,
        DIMSTYLE_PROP_Symbol_Suffix_TEMPLATEFLAG = 615,
        DIMSTYLE_PROP_Symbol_SuffixCellName_MSWCHAR = 616,
        DIMSTYLE_PROP_Symbol_SuffixChar_CHAR = 617,
        DIMSTYLE_PROP_Symbol_SuffixFont_FONT = 618,
        DIMSTYLE_PROP_Symbol_SuffixType_INTEGER = 619,
        DIMSTYLE_PROP_Symbol_TolPrefixChar_CHAR = 620,
        DIMSTYLE_PROP_Symbol_TolSuffixChar_CHAR = 621,
        DIMSTYLE_PROP_Symbol_UpperPrefixChar_CHAR = 622,
        DIMSTYLE_PROP_Symbol_UpperSuffixChar_CHAR = 623,
        DIMSTYLE_PROP_Terminator_ArrowCellName_MSWCHAR = 701,
        DIMSTYLE_PROP_Terminator_ArrowChar_CHAR = 702,
        DIMSTYLE_PROP_Terminator_ArrowFont_FONT = 703,
        DIMSTYLE_PROP_Terminator_ArrowType_INTEGER = 704,
        DIMSTYLE_PROP_Terminator_Color_COLOR = 705,
        DIMSTYLE_PROP_Terminator_DotCellName_MSWCHAR = 706,
        DIMSTYLE_PROP_Terminator_DotChar_CHAR = 707,
        DIMSTYLE_PROP_Terminator_DotFont_FONT = 708,
        DIMSTYLE_PROP_Terminator_DotType_INTEGER = 709,
        DIMSTYLE_PROP_Terminator_First_TEMPLATEFLAG = 710,
        DIMSTYLE_PROP_Terminator_Height_DOUBLE = 711,
        DIMSTYLE_PROP_Terminator_Joint_TEMPLATEFLAG = 712,
        DIMSTYLE_PROP_Terminator_Left_TEMPLATEFLAG = 713,
        DIMSTYLE_PROP_Terminator_LineStyle_LINESTYLE = 714,
        DIMSTYLE_PROP_Terminator_MinLeader_DOUBLE = 715,
        DIMSTYLE_PROP_Terminator_Mode_INTEGER = 716,
        DIMSTYLE_PROP_Terminator_NoLineThruArrow_BOOLINT = 717,
        DIMSTYLE_PROP_Terminator_NoLineThruDot_BOOLINT = 718,
        DIMSTYLE_PROP_Terminator_NoLineThruOrigin_BOOLINT = 719,
        DIMSTYLE_PROP_Terminator_NoLineThruStroke_BOOLINT = 720,
        DIMSTYLE_PROP_Terminator_OriginCellName_MSWCHAR = 721,
        DIMSTYLE_PROP_Terminator_OriginChar_CHAR = 722,
        DIMSTYLE_PROP_Terminator_OriginFont_FONT = 723,
        DIMSTYLE_PROP_Terminator_OriginType_INTEGER = 724,
        DIMSTYLE_PROP_Terminator_OverrideColor_BOOLINT = 725,
        DIMSTYLE_PROP_Terminator_OverrideLineStyle_BOOLINT = 726,
        DIMSTYLE_PROP_Terminator_OverrideWeight_BOOLINT = 727,
        DIMSTYLE_PROP_Terminator_Right_TEMPLATEFLAG = 728,
        DIMSTYLE_PROP_Terminator_Arrowhead_INTEGER = 729,
        DIMSTYLE_PROP_Terminator_StrokeCellName_MSWCHAR = 730,
        DIMSTYLE_PROP_Terminator_StrokeChar_CHAR = 731,
        DIMSTYLE_PROP_Terminator_StrokeFont_FONT = 732,
        DIMSTYLE_PROP_Terminator_StrokeType_INTEGER = 733,
        DIMSTYLE_PROP_Terminator_Weight_WEIGHT = 734,
        DIMSTYLE_PROP_Terminator_Width_DOUBLE = 735,
        DIMSTYLE_PROP_Terminator_Note_INTEGER = 736,
        DIMSTYLE_PROP_Terminator_NoteType_INTEGER = 737,
        DIMSTYLE_PROP_Terminator_NoteCellName_MSWCHAR = 738,
        DIMSTYLE_PROP_Terminator_NoteChar_CHAR = 739,
        DIMSTYLE_PROP_Terminator_NoteFont_FONT = 740,
        DIMSTYLE_PROP_Terminator_UniformCellScale_BOOLINT = 741,
        DIMSTYLE_PROP_Terminator_DimLineThruArrow_BOOLINT = 742,
        DIMSTYLE_PROP_Terminator_DimLineThruDot_BOOLINT = 743,
        DIMSTYLE_PROP_Terminator_DimLineThruOrigin_BOOLINT = 744,
        DIMSTYLE_PROP_Terminator_DimLineThruStroke_BOOLINT = 745,
        DIMSTYLE_PROP_Text_ArcLengthSymbol_TEMPLATEFLAG = 801,
        DIMSTYLE_PROP_Text_AutoLift_BOOLINT = 802,
        DIMSTYLE_PROP_Text_Box_BOOLINT = 803,
        DIMSTYLE_PROP_Text_Capsule_BOOLINT = 804,
        DIMSTYLE_PROP_Text_Color_COLOR = 805,
        DIMSTYLE_PROP_Text_DecimalComma_BOOLINT = 806,
        DIMSTYLE_PROP_Text_Embed_BOOLINT = 807,
        DIMSTYLE_PROP_Text_Font_BOOLINT = 808,
        DIMSTYLE_PROP_Text_Height_DISTANCE = 809,
        DIMSTYLE_PROP_Text_Horizontal_BOOLINT = 810,
        DIMSTYLE_PROP_Text_HorizontalMargin_DOUBLE = 811,
        DIMSTYLE_PROP_Text_Justification_INTEGER = 812,
        DIMSTYLE_PROP_Text_LeadingZero_BOOLINT = 813,
        DIMSTYLE_PROP_Text_NoFitVertical_TEMPLATEFLAG = 814,
        DIMSTYLE_PROP_Text_OmitLeadingDelimiter_BOOLINT = 815,
        DIMSTYLE_PROP_Text_OverrideColor_BOOLINT = 816,
        DIMSTYLE_PROP_Text_OverrideHeight_BOOLINT = 817,
        DIMSTYLE_PROP_Text_OverrideWeight_BOOLINT = 818,
        DIMSTYLE_PROP_Text_OverrideWidth_BOOLINT = 819,
        DIMSTYLE_PROP_Text_SecLeadingZero_BOOLINT = 820,
        DIMSTYLE_PROP_Text_ShowSecondary_BOOLINT = 821,
        DIMSTYLE_PROP_Text_Underline_BOOLINT = 822,
        DIMSTYLE_PROP_Text_Vertical_TEMPLATEFLAG = 823,
        DIMSTYLE_PROP_Text_VerticalMargin_DOUBLE = 824,
        DIMSTYLE_PROP_Text_Weight_WEIGHT = 825,
        DIMSTYLE_PROP_Text_Width_DISTANCE = 826,
        DIMSTYLE_PROP_Text_TextStyle_TEXTSTYLE = 827,
        DIMSTYLE_PROP_Text_TextStyleID_INTEGER = 828,
        DIMSTYLE_PROP_Text_StackedFractionAlignment_INTEGER = 829,
        DIMSTYLE_PROP_Text_StackedFractions_BOOLINT = 830,
        DIMSTYLE_PROP_Text_StackedFractionType_INTEGER = 831,
        DIMSTYLE_PROP_Text_StackedFractionScale_DOUBLE = 832,
        DIMSTYLE_PROP_Text_OverrideStackedFractions_BOOLINT = 833,
        DIMSTYLE_PROP_Text_OverrideUnderline_BOOLINT = 834,
        DIMSTYLE_PROP_Text_Location_INTEGER = 835,
        DIMSTYLE_PROP_Text_VerticalOpts_TEMPLATEFLAG = 836,
        DIMSTYLE_PROP_Text_FrameType_INTEGER = 837,
        DIMSTYLE_PROP_Text_InlineTextLift_DOUBLE = 838,
        DIMSTYLE_PROP_Text_SuperscriptMode_INTEGER = 839,
        DIMSTYLE_PROP_Tolerance_LowerValue_DISTANCE = 901,
        DIMSTYLE_PROP_Tolerance_Mode_BOOLINT = 902,
        DIMSTYLE_PROP_Tolerance_Show_BOOLINT = 903,
        DIMSTYLE_PROP_Tolerance_StackEqual_BOOLINT = 904,
        DIMSTYLE_PROP_Tolerance_TextHorizontalMargin_DOUBLE = 905,
        DIMSTYLE_PROP_Tolerance_TextScale_DOUBLE = 906,
        DIMSTYLE_PROP_Tolerance_TextVerticalMargin_DOUBLE = 907,
        DIMSTYLE_PROP_Tolerance_TextVerticalSeparation_DOUBLE = 908,
        DIMSTYLE_PROP_Tolerance_UpperValue_DISTANCE = 909,
        DIMSTYLE_PROP_Tolerance_Accuracy_ACCURACY = 910,
        DIMSTYLE_PROP_Tolerance_SecAccuracy_ACCURACY = 911,
        DIMSTYLE_PROP_Tolerance_ShowSignForZero_BOOLINT = 912,
        DIMSTYLE_PROP_Value_Accuracy_ACCURACY = 1001,
        DIMSTYLE_PROP_Value_AltAccuracy_ACCURACY = 1002,
        DIMSTYLE_PROP_Value_AltIsActive_BOOLINT = 1003,
        DIMSTYLE_PROP_Value_AltSecAccuracy_ACCURACY = 1004,
        DIMSTYLE_PROP_Value_AltSecIsActive_BOOLINT = 1005,
        DIMSTYLE_PROP_Value_AltSecShowDelimiter_BOOLINT = 1006,
        DIMSTYLE_PROP_Value_AltSecShowMasterUnit_BOOLINT = 1007,
        DIMSTYLE_PROP_Value_AltSecShowSubUnit_BOOLINT = 1008,
        DIMSTYLE_PROP_Value_AltSecShowUnitLabel_BOOLINT = 1009,
        DIMSTYLE_PROP_Value_AltSecShowWhenThresholdEqual_BOOLINT = 1010,
        DIMSTYLE_PROP_Value_AltSecShowWhenThresholdLess_BOOLINT = 1011,
        DIMSTYLE_PROP_Value_AltSecShowZeroMasterUnit_BOOLINT = 1012,
        DIMSTYLE_PROP_Value_AltSecThreshold_DISTANCE = 1013,
        DIMSTYLE_PROP_Value_AltShowDelimiter_BOOLINT = 1014,
        DIMSTYLE_PROP_Value_AltShowMasterUnit_BOOLINT = 1015,
        DIMSTYLE_PROP_Value_AltShowSubUnit_BOOLINT = 1016,
        DIMSTYLE_PROP_Value_AltShowUnitLabel_BOOLINT = 1017,
        DIMSTYLE_PROP_Value_AltShowWhenThresholdEqual_BOOLINT = 1018,
        DIMSTYLE_PROP_Value_AltShowWhenThresholdLess_BOOLINT = 1019,
        DIMSTYLE_PROP_Value_AltShowZeroMasterUnit_BOOLINT = 1020,
        DIMSTYLE_PROP_Value_AltThreshold_DISTANCE = 1021,
        DIMSTYLE_PROP_Value_AngleFormat_INTEGER = 1023,
        DIMSTYLE_PROP_Value_AngleLeadingZero_BOOLINT = 1024,
        DIMSTYLE_PROP_Value_AngleMeasure_BOOLINT = 1025,
        DIMSTYLE_PROP_Value_AnglePrecision_INTEGER = 1026,
        DIMSTYLE_PROP_Value_AngleTrailingZeros_BOOLINT = 1027,
        DIMSTYLE_PROP_Value_RoundLSD_BOOLINT = 1028,
        DIMSTYLE_PROP_Value_SecAccuracy_ACCURACY = 1029,
        DIMSTYLE_PROP_Value_SecShowDelimiter_BOOLINT = 1030,
        DIMSTYLE_PROP_Value_SecShowMasterUnit_BOOLINT = 1031,
        DIMSTYLE_PROP_Value_SecShowSubUnit_BOOLINT = 1032,
        DIMSTYLE_PROP_Value_SecShowTrailingZeros_BOOLINT = 1033,
        DIMSTYLE_PROP_Value_SecShowUnitLabel_BOOLINT = 1034,
        DIMSTYLE_PROP_Value_SecShowZeroMasterUnit_BOOLINT = 1035,
        DIMSTYLE_PROP_Value_ShowDelimiter_BOOLINT = 1036,
        DIMSTYLE_PROP_Value_ShowMasterUnit_BOOLINT = 1037,
        DIMSTYLE_PROP_Value_ShowSubUnit_BOOLINT = 1038,
        DIMSTYLE_PROP_Value_ShowTrailingZeros_BOOLINT = 1039,
        DIMSTYLE_PROP_Value_ShowUnitLabel_BOOLINT = 1040,
        DIMSTYLE_PROP_Value_ShowZeroMasterUnit_BOOLINT = 1041,
        DIMSTYLE_PROP_Value_NoReduceFraction_BOOLINT = 1042,
        DIMSTYLE_PROP_Value_NoReduceAltFraction_BOOLINT = 1043,
        DIMSTYLE_PROP_Value_NoReduceTolFraction_BOOLINT = 1044,
        DIMSTYLE_PROP_Value_SuperscriptLSD_BOOLINT = 1045,
        DIMSTYLE_PROP_Value_ThousandsSeparator_BOOLINT = 1046,
        DIMSTYLE_PROP_Value_ThousandsSpace_BOOLINT = 1047,
        DIMSTYLE_PROP_Value_Unit_UNITS = 1048,
        DIMSTYLE_PROP_Value_UnitLabelMaster_MSWCHAR = 1049,
        DIMSTYLE_PROP_Value_UnitLabelSecMaster_MSWCHAR = 1050,
        DIMSTYLE_PROP_Value_UnitLabelSecSub_MSWCHAR = 1051,
        DIMSTYLE_PROP_Value_UnitLabelSub_MSWCHAR = 1052,
        DIMSTYLE_PROP_Value_UnitSec_UNITS = 1053,
        DIMSTYLE_PROP_Value_UseWorkingUnits_BOOLINT = 1054,
        DIMSTYLE_PROP_Value_OrdDecrementReverse_BOOLINT = 1055,
        DIMSTYLE_PROP_Value_OrdUseDatumValue_BOOLINT = 1056,
        DIMSTYLE_PROP_Value_OrdDatumValue_DISTANCE = 1057,
        DIMSTYLE_PROP_Value_LabelLineSuppressAngle_BOOLINT = 1058,
        DIMSTYLE_PROP_Value_LabelLineSuppressLength_BOOLINT = 1059,
        DIMSTYLE_PROP_Value_LabelLineInvertLabels_BOOLINT = 1060,
        DIMSTYLE_PROP_Value_NoReduceSecFraction_BOOLINT = 1061,
        DIMSTYLE_PROP_Value_NoReduceAltSecFraction_BOOLINT = 1062,
        DIMSTYLE_PROP_Value_NoReduceTolSecFraction_BOOLINT = 1063,
        DIMSTYLE_PROP_Value_LabelLineAdjacentLabels_BOOLINT = 1064,
        DIMSTYLE_PROP_Value_OrdFreeLocation_BOOLINT = 1065,
        DIMSTYLE_PROP_Value_Format_INTEGER = 1066,
        DIMSTYLE_PROP_Value_AltFormat_INTEGER = 1067,
        DIMSTYLE_PROP_Value_SecFormat_INTEGER = 1068,
        DIMSTYLE_PROP_Value_AltSecFormat_INTEGER = 1069,
        DIMSTYLE_PROP_Value_AltThresholdComparison_INTEGER = 1070,
        DIMSTYLE_PROP_Value_AltSecThresholdComparison_INTEGER = 1071,
        DIMSTYLE_PROP_Value_ThousandsOpts_INTEGER = 1072,
        DIMSTYLE_PROP_Value_UnitMaster_ONEUNIT = 1073,
        DIMSTYLE_PROP_Value_UnitSub_ONEUNIT = 1074,
        DIMSTYLE_PROP_Value_SecUnitMaster_ONEUNIT = 1075,
        DIMSTYLE_PROP_Value_SecUnitSub_ONEUNIT = 1076,
        DIMSTYLE_PROP_Value_LabelLineFormat_INTEGER = 1077,
        DIMSTYLE_PROP_Value_ShowZeroSubUnit_BOOLINT = 1078,
        DIMSTYLE_PROP_Value_AltShowZeroSubUnit_BOOLINT = 1079,
        DIMSTYLE_PROP_Value_SecShowZeroSubUnit_BOOLINT = 1080,
        DIMSTYLE_PROP_Value_AltSecShowZeroSubUnit_BOOLINT = 1081,
        DIMSTYLE_PROP_Value_DMSPrecisionMode_INTEGER = 1082,
        DIMSTYLE_PROP_Value_RoundOff_DOUBLE = 1083,
        DIMSTYLE_PROP_Value_SecRoundOff_DOUBLE = 1084,
        DIMSTYLE_PROP_Value_SpaceAfterNonStackedFraction_BOOLINT = 1085,
    };

    public enum DimStyleProp_Category : int
    {
        DIMSTYLE_PROPCATEGORY_Root = -10000,
        DIMSTYLE_PROPCATEGORY_General = -10100,
        DIMSTYLE_PROPCATEGORY_Placement = -10101,
        DIMSTYLE_PROPCATEGORY_BallAndChain = -10102,
        DIMSTYLE_PROPCATEGORY_Tolerance = -10103,
        DIMSTYLE_PROPCATEGORY_Value = -10200,
        DIMSTYLE_PROPCATEGORY_Angle = -10201,
        DIMSTYLE_PROPCATEGORY_Metric = -10202,
        DIMSTYLE_PROPCATEGORY_Fractions = -10203,
        DIMSTYLE_PROPCATEGORY_Primary = -10204,
        DIMSTYLE_PROPCATEGORY_PrimaryAlt = -10205,
        DIMSTYLE_PROPCATEGORY_Secondary = -10206,
        DIMSTYLE_PROPCATEGORY_SecondaryAlt = -10207,
        DIMSTYLE_PROPCATEGORY_DINDimensioning = -10208,
        DIMSTYLE_PROPCATEGORY_Graphics = -10300,
        DIMSTYLE_PROPCATEGORY_DimLines = -10301,
        DIMSTYLE_PROPCATEGORY_ExtLines = -10302,
        DIMSTYLE_PROPCATEGORY_Terminators = -10303,
        DIMSTYLE_PROPCATEGORY_FitOptions = -10304,
        DIMSTYLE_PROPCATEGORY_Text = -10400,
        DIMSTYLE_PROPCATEGORY_Format = -10401,
        DIMSTYLE_PROPCATEGORY_Style = -10402,
        DIMSTYLE_PROPCATEGORY_Notes = -10500,
        DIMSTYLE_PROPCATEGORY_Symbols = -10600,
        DIMSTYLE_PROPCATEGORY_Prefix = -10601,
        DIMSTYLE_PROPCATEGORY_Suffix = -10602,
        DIMSTYLE_PROPCATEGORY_Diameter = -10603,
        DIMSTYLE_PROPCATEGORY_PlusMinus = -10604,
        DIMSTYLE_PROPCATEGORY_ArrowTerm = -10605,
        DIMSTYLE_PROPCATEGORY_StrokeTerm = -10606,
        DIMSTYLE_PROPCATEGORY_OriginTerm = -10607,
        DIMSTYLE_PROPCATEGORY_DotTerm = -10608,
        DIMSTYLE_PROPCATEGORY_NoteTerm = -10609,
        DIMSTYLE_PROPCATEGORY_Tools = -10700,
        DIMSTYLE_PROPCATEGORY_LinearTool = -10701,
        DIMSTYLE_PROPCATEGORY_AngleTool = -10702,
        DIMSTYLE_PROPCATEGORY_ArcSizeTool = -10703,
        DIMSTYLE_PROPCATEGORY_AngleLocTool = -10704,
        DIMSTYLE_PROPCATEGORY_RadialTool = -10705,
        DIMSTYLE_PROPCATEGORY_OrdinateTool = -10706,
    };

    public enum DimStyleProp_Type : int
    {
        PROPTYPE_None = 0,
        PROPTYPE_Accuracy = 1,
        PROPTYPE_BoolInt = 2,
        PROPTYPE_Char = 3,
        PROPTYPE_Color = 4,
        PROPTYPE_Distance = 5,
        PROPTYPE_Double = 6,
        PROPTYPE_Integer = 7,
        PROPTYPE_Font = 8,
        PROPTYPE_Level = 9,
        PROPTYPE_LineStyle = 10,
        PROPTYPE_MSWChar = 11,
        PROPTYPE_OneUnit = 12,
        PROPTYPE_TemplateFlag = 13,
        PROPTYPE_Units = 14,
        PROPTYPE_Weight = 15,
    };

    public enum DimensionTextPartType : int
    {
        DIMTEXTPART_Primary = 3,
        DIMTEXTPART_Secondary = 4,
    };

    public enum DimensionTextPartSubType : int
    {
        DIMTEXTSUBPART_Main = 0,
        DIMTEXTSUBPART_Tolerance_Plus = 1,
        DIMTEXTSUBPART_Tolerance_Minus = 2,
        DIMTEXTSUBPART_Limit_Upper = 4,
        DIMTEXTSUBPART_Limit_Lower = 5,
    };

    public enum SpecialCharValues : int
    {
        SPECIALCHAR_Degree_Shx = 127,
        SPECIALCHAR_PlusMinus_Shx = 128,
        SPECIALCHAR_Diameter_Shx = 129,
        SPECIALCHAR_Degree_Unicode = 176,
        SPECIALCHAR_PlusMinus_Unicode = 177,
        SPECIALCHAR_Diameter_Unicode = 8709,
        SPECIALCHAR_DiameterSign_Unicode = 8960,
        SPECIALCHAR_CapitalOWithStroke_Unicode = 216,
        SPECIALCHAR_SmallOWithStroke_Unicode = 248,
        SPECIALCHAR_FirstStandardRscFraction = 129,
        SPECIALCHAR_LastStandardRscFraction = 191,
        SPECIALCHAR_UnicodeFraction_1_4 = 188,
        SPECIALCHAR_UnicodeFraction_1_2 = 189,
        SPECIALCHAR_UnicodeFraction_3_4 = 190,
        SPECIALCHAR_UnicodeFraction_1_7 = 8528,
        SPECIALCHAR_UnicodeFraction_1_9 = 8529,
        SPECIALCHAR_UnicodeFraction_1_10 = 8530,
        SPECIALCHAR_UnicodeFraction_1_3 = 8531,
        SPECIALCHAR_UnicodeFraction_2_3 = 8532,
        SPECIALCHAR_UnicodeFraction_1_5 = 8533,
        SPECIALCHAR_UnicodeFraction_2_5 = 8534,
        SPECIALCHAR_UnicodeFraction_3_5 = 8535,
        SPECIALCHAR_UnicodeFraction_4_5 = 8536,
        SPECIALCHAR_UnicodeFraction_1_6 = 8537,
        SPECIALCHAR_UnicodeFraction_5_6 = 8538,
        SPECIALCHAR_UnicodeFraction_1_8 = 8539,
        SPECIALCHAR_UnicodeFraction_3_8 = 8540,
        SPECIALCHAR_UnicodeFraction_5_8 = 8541,
        SPECIALCHAR_UnicodeFraction_7_8 = 8542,
        SPECIALCHAR_PrivateUse_Degree_Unicode = 57344,
        SPECIALCHAR_PrivateUse_PlusMinus_Unicode = 57345,
        SPECIALCHAR_PrivateUse_Diameter_Unicode = 57346,
        SPECIALCHAR_PrivateUse_FirstRscFraction = 57600,
        SPECIALCHAR_PrivateUse_LastRscFraction = 57663,
    };

    public enum TextBlockToElementResult : int
    {
        TEXTBLOCK_TO_ELEMENT_RESULT_Success,
        TEXTBLOCK_TO_ELEMENT_RESULT_Error,
        TEXTBLOCK_TO_ELEMENT_RESULT_Empty,
    };

    public enum ScanCriteriaConstants : int
    {
        MSSCANCRIT_RETURN_FILEPOS = 1,
        MSSCANCRIT_RETURN_ELEMENTDATA = 2,
        MSSCANCRIT_RETURN_POSANDDATA = 3,
        MSSCANCRIT_RETURN_UNIQUEID = 4,
        MSSCANCRIT_ITERATE_ELMDSCR = 5,
        MSSCANCRIT_ITERATE_ELMREF = 6,
        MSSCANCRIT_ITERATE_ELMREF_UNORDERED = 7,
        SCANALL_ABORT_SCAN = -101,
        SCANALL_ABORT_CURRENT_MODEL = -102,
        END_OF_DGN = 10,
        BUFF_FULL = 11,
        READ_LIMIT = 12,
        BAD_FILE = 65,
        BAD_REQUEST = 67,
        BAD_ELEMENT = 68,
        BUFF_TOO_SMALL = 69,
    };

    public enum LsKnownStyleNumber : int
    {
        STYLE_MinLineCode = 0,
        STYLE_MaxLineCode = 7,
        STYLE_ByLevel = 2147483647,
        STYLE_ByCell = 2147483646,
        STYLE_Invalid = 2147483392,
    };

    public enum LsResourceType : int
    {
        Unknown = 1,
        Internal = 0,
        Compound = 1819495507,
        LineCode = 1819495491,
        LinePoint = 1819495504,
        PointSymbol = 1815629907,
        PointSymbolV7 = 1819496531,
        RasterImage = 1819497033,
        NameEntry = 1819496045,
    };

    public enum DisplayStyleBuiltInUsage : int
    {
        View = 0,
        ClipVolume = 1,
    };

    public enum DisplayStyleSource : int
    {
        File,
        HardCodedDefault,
    };

    public enum SpecialDisplayStyleIndex : int
    {
        SpecialDisplayStyleIndex_None = -1,
        SpecialDisplayStyleIndex_FromParent = -2,
    };

    public enum GeomRepresentations : int
    {
        DISPLAY_INFO_None = 0,
        DISPLAY_INFO_Edge = 1,
        DISPLAY_INFO_Fill = 2,
        DISPLAY_INFO_Surface = 4,
        DISPLAY_INFO_Thickness = 8,
        DISPLAY_INFO_Pattern = 16,
    };

    public enum FilterLODFlags : int
    {
        FILTER_LOD_Off = 0,
        FILTER_LOD_ShowRange = 1,
        FILTER_LOD_ShowNothing = 2,
    };

    public enum HitPriority : int
    {
        Highest = 0,
        Vertex = 300,
        Origin = 400,
        CellOrigin = 400,
        Edge = 400,
        Compound = 500,
        TestBox = 550,
        Interior = 600,
    };

    public enum HitSource : int
    {
        None = 0,
        FromUser = 1,
        MotionLocate = 2,
        AccuSnap = 3,
        TentativeSnap = 4,
        DataPoint = 5,
        Application = 6,
        EditAction = 7,
        EditActionSS = 8,
    };

    public enum HitGeomType : int
    {
        None = 0,
        Point = 1,
        Segment = 2,
        Curve = 3,
        Arc = 4,
        Surface = 5,
    };

    public enum ComponentMode : int
    {
        None = 0,
        Innermost = 1,
        NormalChild = 3,
        SharedChild = 4,
    };

    public enum TestPathStatus : int
    {
        TESTPATH_NotOnPath = 0,
        TESTPATH_IsOnPath = 1,
        TESTPATH_TestAborted = 2,
    };

    public enum LOCATE_Action : int
    {
        GLOBAL_LOCATE_IDENTIFY = 1,
        GLOBAL_LOCATE_SELECTIONSET = 2,
        GLOBAL_LOCATE_FENCE = 3,
        GLOBAL_LOCATE_FENCECLIP = 4,
        GLOBAL_LOCATE_SNAP = 5,
        GLOBAL_LOCATE_AUTOLOCATE = 6,
    };

    public enum LocateFilterStatus : int
    {
        LOCATE_FILTER_STATUS_Reject = 0,
        LOCATE_FILTER_STATUS_Neutral = 1,
        LOCATE_FILTER_STATUS_Accept = 2,
    };

    public enum LocateFailureValue : int
    {
        LOCATE_FAILURE_None = 0,
        LOCATE_FAILURE_NoElements = 1,
        LOCATE_FAILURE_LockedFile = 2,
        LOCATE_FAILURE_LevelLock = 3,
        LOCATE_FAILURE_LockedElem = 4,
        LOCATE_FAILURE_LockedLevel = 5,
        LOCATE_FAILURE_ViewOnly = 6,
        LOCATE_FAILURE_ByApp = 7,
        LOCATE_FAILURE_ByCommand = 8,
        LOCATE_FAILURE_ByType = 9,
        LOCATE_FAILURE_ByProperties = 10,
        LOCATE_FAILURE_Transient = 11,
        LOCATE_FAILURE_FileNotAllowed = 12,
        LOCATE_FAILURE_FileReadOnly = 13,
        LOCATE_FAILURE_RefernceFile = 14,
        LOCATE_FAILURE_NotSnappable = 15,
        LOCATE_FAILURE_NonSnappableRef = 16,
        LOCATE_FAILURE_ParentNoLocate = 17,
        LOCATE_FAILURE_RefNoRights = 18,
        LOCATE_FAILURE_ParentRefNoRights = 19,
        LOCATE_FAILURE_LockedComponent = 20,
        LOCATE_FAILURE_NotInWorkingSet = 21,
        LOCATE_FAILURE_RejectedByElement = 22,
        LOCATE_FAILURE_NotInActiveRef = 23,
        LOCATE_FAILURE_RefNotNowActive = 24,
    };

    public enum SnapTypeEnum : int
    {
        SNAP_TYPE_Points = 1,
        SNAP_TYPE_Constraints = 2,
    };

    public enum ViewCategory : int
    {
        Default = 0,
        Drafting,
        Modeling,
        Visualization,
        Sheet,
    };

    public enum DgnDrawBuffer : int
    {
        None = 0,
        Screen = 1,
        Dynamic = 2,
        BackingStore = 4,
        Drawing = 8,
    };

    public enum NpcCorners : int
    {
        NPC_000 = 0,
        NPC_100 = 1,
        NPC_010 = 2,
        NPC_110 = 3,
        NPC_001 = 4,
        NPC_101 = 5,
        NPC_011 = 6,
        NPC_111 = 7,
        NPC_CORNER_COUNT = 8,
    };

    public enum ViewportStatus : int
    {
        Success = 0,
        ViewNotInitialized = 143361,
        AlreadyAttached = 143362,
        NotAttached = 143363,
        DrawFailure = 143364,
        NotResized = 143365,
        ModelNotFound = 143366,
        ViewInfoNotOpen = 143367,
    };

    public enum AntiAliasPref : int
    {
        Detect = 0,
        On = 1,
        Off = 2,
    };

    public enum DrawExportFlags : int
    {
        UseDefault = 0,
        ClipToFrustum = 1,
        LinesAsPolys = 2,
        DeferTransparent = 4,
    };

    public enum AccuSnapEnableFlag : int
    {
        ACCUSNAP_ENABLE_OffByDefault = 0,
        ACCUSNAP_ENABLE_OnByDefault = 1,
        ACCUSNAP_ENABLE_Never = 2,
    };

    public enum KeyModifierMasks : int
    {
        KEYMODIFIER_ShiftKey = 4,
        KEYMODIFIER_ControlKey = 8,
        KEYMODIFIER_AltKey = 16,
    };

    public enum CoordinateLockOverrides : int
    {
        OVERRIDE_COORDINATE_LOCK_None = 0,
        OVERRIDE_COORDINATE_LOCK_Axis = 1,
        OVERRIDE_COORDINATE_LOCK_ACS = 2,
        OVERRIDE_COORDINATE_LOCK_Grid = 4,
        OVERRIDE_COORDINATE_LOCK_All = 65535,
    };

    public enum LocateIntegrationStatus : int
    {
        LOCATEINTEGRATION_STATUS_Found = 0,
        LOCATEINTEGRATION_STATUS_NoneRegistered = 1,
    };

    public enum NoiseFunctionType : int
    {
        Perlin = 0,
        EnhancedPerlin = 1,
        Gradient = 2,
        Value = 3,
        GradientValue = 4,
        Impulse = 5,
        Lattice = 6,
        Bubble = 7,
    };

    public enum AxisType : int
    {
        AXISTYPE_XAxis = 0,
        AXISTYPE_YAxis = 1,
        AXISTYPE_ZAxis = 2,
    };

    public enum LxoEnvelopeSlopeType : int
    {
        Direct = 0,
        Auto = 1,
        LinearIn = 2,
        LinearOut = 4,
        Flat = 8,
        AutoFlat = 16,
        Stepped = 32,
    };

    public enum LxoEnvelopeWeightType : int
    {
        Auto = 0,
        Manual = 1,
    };

    public enum LxoEnvelopeBreak : int
    {
        Value = 1,
        Slope = 2,
        Weight = 4,
        ActiveValue = 8,
    };

    public enum ProjectionAttachmentType : int
    {
        None = -1,
        Material = 0,
        Group = 1,
        Element = 2,
    };

    public enum TransactionType : int
    {
        TRANSACTIONTYPE_Action = 1,
        TRANSACTIONTYPE_Reverse = 2,
        TRANSACTIONTYPE_Reinstate = 3,
    };

    public enum ToneMappingMode : int
    {
        Ward97 = 0,
        Ward97Histogram = 1,
        Drago03 = 2,
        Reinhard05 = 3,
        Fattal02 = 4,
        NaturalFilmResponse = 5,
    };

    public enum LightAnnouncerPurpose : int
    {
        ViewUpdate = 0,
        ModelFacetExport = 1,
        SolarTimeElementHandler = 2,
        VueRender = 3,
    };

    public enum LightAnnouncerPriority : int
    {
        First = 0,
        Animation = 10000,
    };

    public enum LineStyleDwgExportReason : int
    {
        LS_DWG_Ok = 0,
        LS_DWG_NoComponents = 1,
        LS_DWG_ShxOnlyCompatSet = 2,
        LS_DWG_CompoundHasOffsets = 3,
        LS_DWG_TooManySegments = 4,
        LS_DWG_SymbolAtStartOrEnd = 5,
        LS_DWG_PartialWidthDash = 6,
        LS_DWG_OpenDashCap = 7,
        LS_DWG_WidthsChange = 8,
        LS_DWG_WidthTapers = 9,
        LS_DWG_IterationLimit = 10,
    };

    public enum ReferenceType : int
    {
        REFERENCE_File,
        REFERENCE_Model,
        REFERENCE_Component,
        REFERENCE_Property,
    };

    public enum SourceType : int
    {
        SOURCE_TYPE_INCLUDE = 0,
        SOURCE_TYPE_REFERENCE,
    };

    public enum EventType : int
    {
        EVENT_TYPE_File,
        EVENT_TYPE_Model,
        EVENT_TYPE_Component,
        EVENT_TYPE_Property,
    };

    public enum ProcessType : int
    {
        PROCESS_Extract,
        PROCESS_Transform,
    };

    public enum MultilineCapType : int
    {
        MULTILINE_ORG_CAP = 0,
        MULTILINE_END_CAP = 1,
        MULTILINE_MID_CAP = 2,
        MULTILINE_MAX = 16,
    };

    public enum MultilineCapIndex : int
    {
        MULTILINE_ORG_CAP_INDEX = 16,
        MULTILINE_END_CAP_INDEX = 17,
        MULTILINE_MID_CAP_INDEX = 18,
        MULTILINE_ITERATE_MAX = 19,
    };

    public enum GeoCodingType : int
    {
        GeoCodingType_None = 0,
        GeoCodingType_Type66 = 1,
    };

    public enum ElementChangeType : int
    {
        Missing = 0,
        Added = 1,
        Deleted = 2,
        Replaced = 4,
    };

    public enum AuditTrailRecordType : int
    {
        AUDIT_TRAIL_RECORD_TYPE_CombineRevisions = 0,
        AUDIT_TRAIL_RECORD_TYPE_RetireRevisions = 1,
        AUDIT_TRAIL_RECORD_TYPE_ChangeDescription = 2,
        AUDIT_TRAIL_RECORD_TYPE_ChangeUser = 3,
        AUDIT_TRAIL_RECORD_TYPE_MakeShared = 4,
        AUDIT_TRAIL_RECORD_TYPE_Create = 5,
    };

    public enum HistoryCapabilities : int
    {
        HistoryCapabilities_Supported = 1,
        HistoryCapabilities_Create = 2,
        HistoryCapabilities_Combine = 4,
        HistoryCapabilities_Commit = 8,
        HistoryCapabilities_Browse = 16,
        HistoryCapabilities_Delete = 32,
        HistoryCapabilities_Retire = 64,
        HistoryCapabilities_Trace = 128,
        HistoryCapabilities_Tag = 256,
        HistoryCapabilities_ChangeDesc = 512,
        HistoryCapabilities_AutoUpgrade = 1024,
        HistoryCapabilities_ChangeAuthor = 2048,
        HistoryCapabilities_SetRevisionFormat = 4096,
        HistoryCapabilities_SetVersion = 8192,
        HistoryCapabilities_ALL = 65535,
    };

    public enum MonochromeDisplayMode : int
    {
        MONODISPLAYMODE_ATLEASTONE = 0,
        MONODISPLAYMODE_BOLD = 1,
    };

    public enum DefaultZValueProvider : int
    {
        GlobalOrigin = 0,
        ActiveACS = 1,
        ActiveViewDepth = 2,
        UserDefined = 3,
    };

    public enum PDFDrawOptions : int
    {
        PDF_DRAW_SmoothText = 1,
        PDF_DRAW_SmoothLineArt = 2,
        PDF_DRAW_SmoothImage = 4,
    };

    public enum RasterBorderDisplayMode : int
    {
        RASTERBORDER_DISPLAYMODE_Default = 0,
        RASTERBORDER_DISPLAYMODE_NeverHilited = 1,
        RASTERBORDER_DISPLAYMODE_Always = 2,
    };

    public enum ResamplingMethod : int
    {
        RESAMPLING_INTERPOLATION_DEFAULT = 0,
        RESAMPLING_INTERPOLATION_UNKNOWN = 1,
        RESAMPLING_INTERPOLATION_NEAREST = 2,
        RESAMPLING_INTERPOLATION_AVERAGE = 3,
        RESAMPLING_INTERPOLATION_VECTOR_AWARENESS = 4,
        RESAMPLING_INTERPOLATION_CUBIC_CONVOLUTION = 5,
        RESAMPLING_INTERPOLATION_BILINEAR = 6,
    };

    public enum RasterLoadMode : int
    {
        RASTERLOADMODE_AUTOMATIC = 0,
        RASTERLOADMODE_RAM = 2,
        RASTERLOADMODE_STANDARD = 3,
        RASTERLOADMODE_NOTLOADED = 4,
    };

    public enum RasterLoadState : int
    {
        RASTERLOADSTATE_CACHE = 1,
        RASTERLOADSTATE_RAM = 2,
        RASTERLOADSTATE_STANDARD = 3,
        RASTERLOADSTATE_NOTLOADED = 4,
    };

    public enum RasterSisterFileType : int
    {
        RASTER_SISTERFILE_NONE = 0,
        RASTER_SISTERFILE_HGR = 1,
        RASTER_SISTERFILE_WORLDFILE = 2,
        RASTER_SISTERFILE_ERS = 3,
    };

    public enum RasterGCSInputSource : int
    {
        TakeGCSFrom_CurrentModel = 0,
        TakeGCSFrom_InputRaster = 1,
        TakeGCSFrom_NameSpecified = 2,
    };

    public enum IModelRasterOption : int
    {
        RasterOption_Exclude = 0,
        RasterOption_KeepOriginal = 1,
        RasterOption_ReduceSize = 2,
    };

    public enum IModelGeoRasterOption : int
    {
        GeoRasterOption_Exclude = 0,
        GeoRasterOption_FullSize = 1,
        GeoRasterOption_ReduceSize = 2,
    };

    public enum IModelRasterDEMOption : int
    {
        RasterDEMOption_Exclude = 0,
        RasterDEMOption_FullSize = 1,
        RasterDEMOption_ReduceSize = 2,
    };

    public enum RasterFileAccessMode : int
    {
        FILE_ACCESSMODE_READ = 1,
        FILE_ACCESSMODE_WRITE = 2,
        FILE_ACCESSMODE_CREATE = 4,
        FILE_ACCESSMODE_READWRITE = 3,
    };

    public enum RasterGeoReferenceSupport : int
    {
        GEOREF_SUPPORT_NONE = 0,
        GEOREF_SUPPORT_NATIVE = 1,
        GEOREF_SUPPORT_SISTERFILE = 2,
    };

    public enum ValueKind : int
    {
        VALUEKIND_Uninitialized = 0,
        VALUEKIND_Primitive = 1,
        VALUEKIND_Struct = 2,
        VALUEKIND_Array = 4,
    };

    public enum PrimitiveType : int
    {
        PRIMITIVETYPE_Binary = 257,
        PRIMITIVETYPE_Boolean = 513,
        PRIMITIVETYPE_DateTime = 769,
        PRIMITIVETYPE_Double = 1025,
        PRIMITIVETYPE_Integer = 1281,
        PRIMITIVETYPE_Long = 1537,
        PRIMITIVETYPE_Point2D = 1793,
        PRIMITIVETYPE_Point3D = 2049,
        PRIMITIVETYPE_String = 2305,
        PRIMITIVETYPE_IGeometry = 2561,
    };

    public enum ECObjectsStatus : int
    {
        ECOBJECTS_STATUS_Success = 0,
        ECOBJECTS_STATUS_PropertyNotFound = 200705,
        ECOBJECTS_STATUS_DataTypeMismatch = 200706,
        ECOBJECTS_STATUS_ECInstanceImplementationNotSupported = 200707,
        ECOBJECTS_STATUS_InvalidPropertyAccessString = 200708,
        ECOBJECTS_STATUS_IndexOutOfRange = 200709,
        ECOBJECTS_STATUS_ECClassNotSupported = 200710,
        ECOBJECTS_STATUS_ECSchemaNotSupported = 200711,
        ECOBJECTS_STATUS_AccessStringDisagreesWithNIndices = 200712,
        ECOBJECTS_STATUS_EnablerNotFound = 200713,
        ECOBJECTS_STATUS_OperationNotSupported = 200714,
        ECOBJECTS_STATUS_ParseError = 200715,
        ECOBJECTS_STATUS_NamedItemAlreadyExists = 200716,
        ECOBJECTS_STATUS_PreconditionViolated = 200717,
        ECOBJECTS_STATUS_SchemaNotFound = 200718,
        ECOBJECTS_STATUS_ClassNotFound = 200719,
        ECOBJECTS_STATUS_BaseClassUnacceptable = 200720,
        ECOBJECTS_STATUS_SchemaInUse = 200721,
        ECOBJECTS_STATUS_InvalidName = 200722,
        ECOBJECTS_STATUS_DataTypeNotSupported = 200723,
        ECOBJECTS_STATUS_UnableToAllocateMemory = 200724,
        ECOBJECTS_STATUS_MemoryBoundsOverrun = 200725,
        ECOBJECTS_STATUS_NullPointerValue = 200726,
        ECOBJECTS_STATUS_NotCustomAttributeClass = 200727,
        ECOBJECTS_STATUS_DuplicateSchema = 200728,
        ECOBJECTS_STATUS_UnableToSetReadOnlyInstance = 200729,
        ECOBJECTS_STATUS_UnableToSetReadOnlyProperty = 200730,
        ECOBJECTS_STATUS_ArrayIndexDoesNotExist = 200731,
        ECOBJECTS_STATUS_PropertyValueMatchesNoChange = 200732,
        ECOBJECTS_STATUS_NoChildProperties = 200733,
        ECOBJECTS_STATUS_UnableToAllocateManagedMemory = 200734,
        ECOBJECTS_STATUS_MemoryAllocationCallbackRequired = 200735,
        ECOBJECTS_STATUS_UnableToAddStructArrayMember = 200736,
        ECOBJECTS_STATUS_UnableToSetStructArrayMemberInstance = 200737,
        ECOBJECTS_STATUS_UnableToGetStructArrayMemberInstance = 200738,
        ECOBJECTS_STATUS_InvalidIndexForPerPropertyFlag = 200739,
        ECOBJECTS_STATUS_SchemaHasReferenceCycle = 200740,
        ECOBJECTS_STATUS_SchemaNotSupplemented = 200741,
        ECOBJECTS_STATUS_UnableToQueryForNullPropertyFlag = 200742,
        ECOBJECTS_STATUS_UnableToResizeFixedSizedArray = 200743,
        ECOBJECTS_STATUS_SchemaIsImmutable = 200744,
        ECOBJECTS_STATUS_Error = 204799,
    };

    public enum ArrayKind : int
    {
        ARRAYKIND_Primitive = 1,
        ARRAYKIND_Struct = 2,
    };

    public enum ECRelationshipEnd : int
    {
        ECRelationshipEnd_Source = 0,
        ECRelationshipEnd_Target,
    };

    public enum SchemaMatchType : int
    {
        SCHEMAMATCHTYPE_Identical = 0,
        SCHEMAMATCHTYPE_Exact = 1,
        SCHEMAMATCHTYPE_LatestCompatible = 2,
        SCHEMAMATCHTYPE_Latest = 3,
    };

    public enum StrengthType : int
    {
        STRENGTHTYPE_Referencing,
        STRENGTHTYPE_Holding,
        STRENGTHTYPE_Embedding,
    };

    public enum ECRelatedInstanceDirection : int
    {
        STRENGTHDIRECTION_Forward = 1,
        STRENGTHDIRECTION_Backward = 2,
    };

    public enum OrderIdStorageMode : int
    {
        ORDERIDSTORAGEMODE_None = 0,
        ORDERIDSTORAGEMODE_ProvidedByPersistence = 1,
        ORDERIDSTORAGEMODE_ProvidedByClient = 2,
    };

    public enum SchemaWriteStatus : int
    {
        SCHEMA_WRITE_STATUS_Success = 0,
        SCHEMA_WRITE_STATUS_FailedToSaveXml = 208897,
        SCHEMA_WRITE_STATUS_FailedToCreateXml = 208898,
        SCHEMA_WRITE_STATUS_FailedToWriteFile = 208899,
    };

    public enum SchemaReadStatus : int
    {
        SCHEMA_READ_STATUS_Success = 0,
        SCHEMA_READ_STATUS_FailedToParseXml = 204802,
        SCHEMA_READ_STATUS_InvalidECSchemaXml = 204803,
        SCHEMA_READ_STATUS_ReferencedSchemaNotFound = 204804,
        SCHEMA_READ_STATUS_DuplicateSchema = 204805,
        SCHEMA_READ_STATUS_InvalidPrimitiveType = 204806,
        SCHEMA_READ_STATUS_HasReferenceCycle = 204807,
    };

    public enum InstanceReadStatus : int
    {
        INSTANCE_READ_STATUS_Success = 0,
        INSTANCE_READ_STATUS_FileNotFound = 212993,
        INSTANCE_READ_STATUS_CantCreateStream = 212994,
        INSTANCE_READ_STATUS_CantCreateXmlReader = 212995,
        INSTANCE_READ_STATUS_CantSetStream = 212996,
        INSTANCE_READ_STATUS_NoElementName = 212997,
        INSTANCE_READ_STATUS_BadElement = 212998,
        INSTANCE_READ_STATUS_UnexpectedElement = 212999,
        INSTANCE_READ_STATUS_EmptyElement = 213000,
        INSTANCE_READ_STATUS_EndElementDoesntMatch = 213001,
        INSTANCE_READ_STATUS_XmlFileIncomplete = 213002,
        INSTANCE_READ_STATUS_XmlParseError = 213012,
        INSTANCE_READ_STATUS_ECClassNotFound = 213022,
        INSTANCE_READ_STATUS_BadECProperty = 213023,
        INSTANCE_READ_STATUS_BadPrimitivePropertyType = 213024,
        INSTANCE_READ_STATUS_BadBinaryData = 213025,
        INSTANCE_READ_STATUS_BadTimeValue = 213026,
        INSTANCE_READ_STATUS_BadDoubleValue = 213027,
        INSTANCE_READ_STATUS_BadIntegerValue = 213028,
        INSTANCE_READ_STATUS_BadLongValue = 213029,
        INSTANCE_READ_STATUS_BadPoint2dValue = 213030,
        INSTANCE_READ_STATUS_BadPoint3dValue = 213031,
        INSTANCE_READ_STATUS_BadArrayElement = 213032,
        INSTANCE_READ_STATUS_TypeMismatch = 213033,
        INSTANCE_READ_STATUS_CantSetValue = 213034,
        INSTANCE_READ_STATUS_ECSchemaNotFound = 213035,
        INSTANCE_READ_STATUS_UnableToGetStandaloneEnabler = 213036,
        INSTANCE_READ_STATUS_CommentOnly = 213037,
        INSTANCE_READ_STATUS_PropertyNotFound = 213038,
    };

    public enum InstanceWriteStatus : int
    {
        INSTANCE_WRITE_STATUS_Success = 0,
        INSTANCE_WRITE_STATUS_CantCreateStream = 217089,
        INSTANCE_WRITE_STATUS_CantCreateXmlWriter = 217091,
        INSTANCE_WRITE_STATUS_CantSetStream = 217092,
        INSTANCE_WRITE_STATUS_XmlWriteError = 217093,
        INSTANCE_WRITE_STATUS_CantReadFromStream = 217094,
        INSTANCE_WRITE_STATUS_FailedToWriteFile = 217095,
        INSTANCE_WRITE_STATUS_BadPrimitivePropertyType = 217118,
    };

    public enum UnitConversionType : int
    {
        UnitConversionType_Identity,
        UnitConversionType_Slope,
        UnitConversionType_Factor,
        UnitConversionType_FactorAndOffset,
    };

    public enum ECErrorCategories : int
    {
        ECOBJECTS_ERROR_BASE = 200704,
        SCHEMA_READ_STATUS_BASE = 204800,
        SCHEMA_WRITE_STATUS_BASE = 208896,
        INSTANCE_READ_STATUS_BASE = 212992,
        INSTANCE_WRITE_STATUS_BASE = 217088,
        SUPPLEMENTED_SCHEMA_STATUS_BASE = 221184,
    };

    public enum SupplementedSchemaStatus : int
    {
        SUPPLEMENTED_SCHEMA_STATUS_Success = 0,
        SUPPLEMENTED_SCHEMA_STATUS_Metadata_Missing = 221185,
        SUPPLEMENTED_SCHEMA_STATUS_Duplicate_Precedence_Error = 221186,
        SUPPLEMENTED_SCHEMA_STATUS_IECRelationship_Not_Allowed = 221187,
        SUPPLEMENTED_SCHEMA_STATUS_SchemaMergeException = 221188,
        SUPPLEMENTED_SCHEMA_STATUS_SupplementalClassHasBaseClass = 221189,
    };

    public enum EvaluationOptions : int
    {
        EVALOPT_Legacy = 0,
        EVALOPT_SuppressTypeConversions = 1,
        EVALOPT_EnforceUnits = 3,
        EVALOPT_EnforceGlobalRepresentation = 4,
    };

    public enum ExpressionStatus : int
    {
        ExprStatus_Success = 0,
        ExprStatus_UnknownError = 1,
        ExprStatus_UnknownMember = 2,
        ExprStatus_PrimitiveRequired = 3,
        ExprStatus_StructRequired = 4,
        ExprStatus_ArrayRequired = 5,
        ExprStatus_UnknownSymbol = 6,
        ExprStatus_DotNotSupported = 7,
        ExprStatus_NotImpl = 8,
        ExprStatus_NeedsLValue = 9,
        ExprStatus_WrongType = 10,
        ExprStatus_IncompatibleTypes = 11,
        ExprStatus_MethodRequired = 12,
        ExprStatus_InstanceMethodRequired = 13,
        ExprStatus_StaticMethodRequired = 14,
        ExprStatus_InvalidTypesForDivision = 15,
        ExprStatus_DivideByZero = 16,
        ExprStatus_WrongNumberOfArguments = 17,
        ExprStatus_IndexOutOfRange = 18,
        ExprStatus_IncompatibleUnits = 19,
    };

    public enum ArrayModifierFlags : int
    {
        PROPERTYLAYOUTMODIFIERFLAGS_None = 0,
        PROPERTYLAYOUTMODIFIERFLAGS_IsArrayFixedCount = 1,
        PROPERTYLAYOUTMODIFIERFLAGS_IsReadOnly = 2,
        PROPERTYLAYOUTMODIFIERFLAGS_IsCalculated = 4,
    };

    public enum PropertyFlagIndex : int
    {
        PROPERTYFLAGINDEX_IsLoaded = 0,
        PROPERTYFLAGINDEX_IsReadOnly = 1,
    };

    public enum MemoryInstanceUsageBitmask : int
    {
        MEMORYINSTANCEUSAGE_Empty = 0,
        MEMORYINSTANCEUSAGE_IsPartiallyLoaded = 1,
        MEMORYINSTANCEUSAGE_IsHidden = 2,
    };

    public enum ValueType : int
    {
        ValType_None = 0,
        ValType_ECValue = 1,
        ValType_Custom = 2,
        ValType_InstanceList = 3,
        ValType_ValueList = 4,
        ValType_Lambda = 5,
    };

    public enum ExpressionToken : int
    {
        TOKEN_None = 0,
        TOKEN_Null = 16,
        TOKEN_True = 17,
        TOKEN_False = 18,
        TOKEN_Like = 19,
        TOKEN_Is = 20,
        TOKEN_Star = 40,
        TOKEN_Plus = 41,
        TOKEN_Minus = 42,
        TOKEN_Slash = 43,
        TOKEN_Comma = 44,
        TOKEN_IntegerDivide = 45,
        TOKEN_LParen = 46,
        TOKEN_RParen = 47,
        TOKEN_Exponentiation = 48,
        TOKEN_And = 50,
        TOKEN_AndAlso = 51,
        TOKEN_Or = 52,
        TOKEN_OrElse = 53,
        TOKEN_Concatenate = 54,
        TOKEN_Mod = 55,
        TOKEN_ShiftLeft = 56,
        TOKEN_ShiftRight = 57,
        TOKEN_Colon = 58,
        TOKEN_LessEqual = 59,
        TOKEN_GreaterEqual = 60,
        TOKEN_Less = 61,
        TOKEN_Greater = 62,
        TOKEN_Equal = 63,
        TOKEN_NotEqual = 64,
        TOKEN_Not = 65,
        TOKEN_Xor = 66,
        TOKEN_UnsignedShiftRight = 68,
        TOKEN_LeftBracket = 69,
        TOKEN_RightBracket = 70,
        TOKEN_Dot = 71,
        TOKEN_IIf = 72,
        TOKEN_LCurly = 73,
        TOKEN_RCurly = 74,
        TOKEN_If = 75,
        TOKEN_Else = 76,
        TOKEN_ElseIf = 77,
        TOKEN_Select = 78,
        TOKEN_End = 79,
        TOKEN_EndIf = 80,
        TOKEN_Lambda = 85,
        TOKEN_DoubleColon = 100,
        TOKEN_Error = 181,
        TOKEN_Ident = 182,
        TOKEN_StringConst = 183,
        TOKEN_PointConst = 184,
        TOKEN_DateTimeConst = 185,
        TOKEN_IntegerConstant = 187,
        TOKEN_HexConstant = 188,
        TOKEN_FloatConst = 189,
        TOKEN_UnitsConst = 190,
        TOKEN_Unrecognized = 200,
        TOKEN_BadNumber = 201,
        TOKEN_BadOctalNumber = 202,
        TOKEN_BadHexNumber = 203,
        TOKEN_BadFloatingPointNumber = 204,
        TOKEN_UnterminatedString = 205,
        TOKEN_PrimaryList = 206,
    };

    public enum PropertySortPriority : int
    {
        VeryHigh = 400000,
        High = 300000,
        Medium = 200000,
        Low = 100000,
        VeryLow = 0,
    };

    public enum CategorySortPriority : int
    {
        VeryHigh = 400000,
        High = 300000,
        Medium = 200000,
        Low = 100000,
        VeryLow = 0,
    };

    public enum MstnProductIds : int
    {
        PRODUCT_MS = 10,
        PRODUCT_MDE = 20,
        PRODUCT_REVIEW = 30,
        PRODUCT_DEMO = 40,
        PRODUCT_DRAFT = 50,
        PRODUCT_MRTE = 60,
        PRODUCT_MODELER = 70,
        PRODUCT_POWERSCOPE = 100,
        PRODUCT_REDLINE = 100,
        PRODUCT_POWERMAP = 110,
        PRODUCT_GEOOUTLOOK = 110,
        PRODUCT_GEOGRAPHICS = 120,
        PRODUCT_AUTOTRANS = 130,
        PRODUCT_POWERMAP_FIELD = 140,
        PRODUCT_VIEW = 150,
        PRODUCT_NAVIGATOR = 160,
        PRODUCT_POWERCIVIL = 170,
        PRODUCT_HOST = 180,
        PRODUCT_MSPM = 10,
        PRODUCT_MSPS = 20,
        PRODUCT_MSD = 30,
    };

    public enum DgnLibSelector : int
    {
        None = 0,
        ElementStyles = 1,
        Rendering = 2,
        Links = 4,
        Printing = 8,
        ClashDetection = 16,
        GuiLibs = 32,
        SystemGuiLibs = 64,
        System = 128,
        LevelsOnly = 256,
        TextFavoritesOnly = 512,
        TextStylesOnly = 1024,
        DimensionStylesOnly = 2048,
        DisplayStylesOnly = 4096,
        DrawingSeedsOnly = 8192,
        LineStylesOnly = 16384,
        DetailingSymbolStylesOnly = 32768,
        NamedExpressions = 104,
    };

}
