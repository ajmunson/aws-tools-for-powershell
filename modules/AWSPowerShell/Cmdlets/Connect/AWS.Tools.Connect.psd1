#
# Module manifest for module 'AWS.Tools.Connect'
#

@{
    # Script module or binary module file associated with this manifest
    RootModule = 'AWS.Tools.Connect.dll'

    # Supported PSEditions
    CompatiblePSEditions = @('Core', 'Desktop')

    # Version number of this module.
    ModuleVersion = '0.0.0.0'

    # ID used to uniquely identify this module
    GUID = 'e8d44f59-ca47-4a78-a33e-3f2a1313bb1f'

    # Author of this module
    Author = 'Amazon.com, Inc'

    # Company or vendor of this module
    CompanyName = 'Amazon.com, Inc'

    # Copyright statement for this module
    Copyright = 'Copyright 2012-2023 Amazon.com, Inc. or its affiliates. All Rights Reserved.'

    # Description of the functionality provided by this module
    Description = 'The Connect module of AWS Tools for PowerShell lets developers and administrators manage Amazon Connect Service from the PowerShell scripting environment. In order to manage each AWS service, install the corresponding module (e.g. AWS.Tools.EC2, AWS.Tools.S3...).
The module AWS.Tools.Installer (https://www.powershellgallery.com/packages/AWS.Tools.Installer/) makes it easier to install, update and uninstall the AWS.Tools modules.
This version of AWS Tools for PowerShell is compatible with Windows PowerShell 5.1+ and PowerShell Core 6+ on Windows, Linux and macOS. When running on Windows PowerShell, .NET Framework 4.7.2 or newer is required. Alternative modules AWSPowerShell.NetCore and AWSPowerShell, provide support for all AWS services from a single module and also support older versions of Windows PowerShell and .NET Framework.'

    # Minimum version of the PowerShell engine required by this module
    PowerShellVersion = '5.1'

    # Name of the PowerShell host required by this module
    PowerShellHostName = ''

    # Minimum version of the PowerShell host required by this module
    PowerShellHostVersion = ''

    # Minimum version of the .NET Framework required by this module
    DotNetFrameworkVersion = '4.7.2'

    # Minimum version of the common language runtime (CLR) required by this module
    CLRVersion = ''

    # Processor architecture (None, X86, Amd64, IA64) required by this module
    ProcessorArchitecture = ''

    # Modules that must be imported into the global environment prior to importing this module
    RequiredModules = @(
        @{
            ModuleName = 'AWS.Tools.Common';
            RequiredVersion = '0.0.0.0';
            Guid = 'e5b05bf3-9eee-47b2-81f2-41ddc0501b86' }
    )

    # Assemblies that must be loaded prior to importing this module.
    RequiredAssemblies = @(
        'AWSSDK.Connect.dll'
    )

    # Script files (.ps1) that are run in the caller's environment prior to importing this module
    ScriptsToProcess = @(

    )

    # Type files (.ps1xml) to be loaded when importing this module
    TypesToProcess = @(

    )

    # Format files (.ps1xml) to be loaded when importing this module
    FormatsToProcess = @(
        'AWS.Tools.Connect.Format.ps1xml'
    )

    # Modules to import as nested modules of the module specified in ModuleToProcess
    NestedModules = @(
        'AWS.Tools.Connect.Completers.psm1',
        'AWS.Tools.Connect.Aliases.psm1'
    )

    # Functions to export from this module
    FunctionsToExport = ''

    # Cmdlets to export from this module
    CmdletsToExport = @(
        'Add-CONNApprovedOrigin', 
        'Add-CONNBot', 
        'Add-CONNDefaultVocabulary', 
        'Add-CONNInstanceStorageConfig', 
        'Add-CONNLambdaFunction', 
        'Add-CONNLexBot', 
        'Add-CONNPhoneNumberContactFlow', 
        'Add-CONNQueueQuickConnect', 
        'Add-CONNResourceTag', 
        'Add-CONNSecurityKey', 
        'Copy-CONNInstance', 
        'Disconnect-CONNRoutingProfileQueue', 
        'Get-CONNAgentStatus', 
        'Get-CONNAgentStatusList', 
        'Get-CONNApprovedOriginList', 
        'Get-CONNBotList', 
        'Get-CONNContact', 
        'Get-CONNContactAttribute', 
        'Get-CONNContactFlow', 
        'Get-CONNContactFlowList', 
        'Get-CONNContactFlowModule', 
        'Get-CONNContactFlowModuleList', 
        'Get-CONNContactReferenceList', 
        'Get-CONNCurrentMetricData', 
        'Get-CONNCurrentUserData', 
        'Get-CONNDefaultVocabularyList', 
        'Get-CONNFederationToken', 
        'Get-CONNHoursOfOperation', 
        'Get-CONNHoursOfOperationList', 
        'Get-CONNInstance', 
        'Get-CONNInstanceAttribute', 
        'Get-CONNInstanceAttributeList', 
        'Get-CONNInstanceList', 
        'Get-CONNInstanceStorageConfig', 
        'Get-CONNInstanceStorageConfigList', 
        'Get-CONNIntegrationAssociationList', 
        'Get-CONNLambdaFunctionList', 
        'Get-CONNLexBotList', 
        'Get-CONNMetricData', 
        'Get-CONNPhoneNumber', 
        'Get-CONNPhoneNumberList', 
        'Get-CONNPhoneNumbersV2List', 
        'Get-CONNPromptList', 
        'Get-CONNQueue', 
        'Get-CONNQueueList', 
        'Get-CONNQueueQuickConnectList', 
        'Get-CONNQuickConnect', 
        'Get-CONNQuickConnectList', 
        'Get-CONNResourceTag', 
        'Get-CONNRoutingProfile', 
        'Get-CONNRoutingProfileList', 
        'Get-CONNRoutingProfileQueueList', 
        'Get-CONNRule', 
        'Get-CONNRuleList', 
        'Get-CONNSecurityKeyList', 
        'Get-CONNSecurityProfile', 
        'Get-CONNSecurityProfileList', 
        'Get-CONNSecurityProfilePermissionList', 
        'Get-CONNTaskTemplate', 
        'Get-CONNTaskTemplateList', 
        'Get-CONNTrafficDistribution', 
        'Get-CONNTrafficDistributionGroup', 
        'Get-CONNTrafficDistributionGroupList', 
        'Get-CONNUseCaseList', 
        'Get-CONNUser', 
        'Get-CONNUserHierarchyGroup', 
        'Get-CONNUserHierarchyGroupList', 
        'Get-CONNUserHierarchyStructure', 
        'Get-CONNUserList', 
        'Get-CONNVocabulary', 
        'Join-CONNRoutingProfileQueue', 
        'Move-CONNContact', 
        'New-CONNAgentStatus', 
        'New-CONNContactFlow', 
        'New-CONNContactFlowModule', 
        'New-CONNHoursOfOperation', 
        'New-CONNInstance', 
        'New-CONNIntegrationAssociation', 
        'New-CONNQueue', 
        'New-CONNQuickConnect', 
        'New-CONNRoutingProfile', 
        'New-CONNRule', 
        'New-CONNSecurityProfile', 
        'New-CONNTaskTemplate', 
        'New-CONNTrafficDistributionGroup', 
        'New-CONNUseCase', 
        'New-CONNUser', 
        'New-CONNUserHierarchyGroup', 
        'New-CONNVocabulary', 
        'Remove-CONNApprovedOrigin', 
        'Remove-CONNBot', 
        'Remove-CONNContactFlow', 
        'Remove-CONNContactFlowModule', 
        'Remove-CONNHoursOfOperation', 
        'Remove-CONNInstance', 
        'Remove-CONNInstanceStorageConfig', 
        'Remove-CONNIntegrationAssociation', 
        'Remove-CONNLambdaFunction', 
        'Remove-CONNLexBot', 
        'Remove-CONNPhoneNumber', 
        'Remove-CONNPhoneNumberContactFlow', 
        'Remove-CONNQueueQuickConnect', 
        'Remove-CONNQuickConnect', 
        'Remove-CONNResourceTag', 
        'Remove-CONNRule', 
        'Remove-CONNSecurityKey', 
        'Remove-CONNSecurityProfile', 
        'Remove-CONNTaskTemplate', 
        'Remove-CONNTrafficDistributionGroup', 
        'Remove-CONNUseCase', 
        'Remove-CONNUser', 
        'Remove-CONNUserHierarchyGroup', 
        'Remove-CONNVocabulary', 
        'Request-CONNPhoneNumber', 
        'Resume-CONNContactRecording', 
        'Search-CONNAvailablePhoneNumber', 
        'Search-CONNQueue', 
        'Search-CONNRoutingProfile', 
        'Search-CONNSecurityProfile', 
        'Search-CONNUser', 
        'Search-CONNVocabulary', 
        'Start-CONNChatContact', 
        'Start-CONNContactMonitoring', 
        'Start-CONNContactRecording', 
        'Start-CONNContactStreaming', 
        'Start-CONNOutboundVoiceContact', 
        'Start-CONNTaskContact', 
        'Stop-CONNContact', 
        'Stop-CONNContactRecording', 
        'Stop-CONNContactStreaming', 
        'Suspend-CONNContactRecording', 
        'Update-CONNAgentStatus', 
        'Update-CONNContact', 
        'Update-CONNContactAttribute', 
        'Update-CONNContactFlowContent', 
        'Update-CONNContactFlowMetadata', 
        'Update-CONNContactFlowModuleContent', 
        'Update-CONNContactFlowModuleMetadata', 
        'Update-CONNContactFlowName', 
        'Update-CONNContactSchedule', 
        'Update-CONNHoursOfOperation', 
        'Update-CONNInstanceAttribute', 
        'Update-CONNInstanceStorageConfig', 
        'Update-CONNParticipantRoleConfig', 
        'Update-CONNPhoneNumber', 
        'Update-CONNQueueHoursOfOperation', 
        'Update-CONNQueueMaxContact', 
        'Update-CONNQueueName', 
        'Update-CONNQueueOutboundCallerConfig', 
        'Update-CONNQueueStatus', 
        'Update-CONNQuickConnectConfig', 
        'Update-CONNQuickConnectName', 
        'Update-CONNRoutingProfileConcurrency', 
        'Update-CONNRoutingProfileDefaultOutboundQueue', 
        'Update-CONNRoutingProfileName', 
        'Update-CONNRoutingProfileQueue', 
        'Update-CONNRule', 
        'Update-CONNSecurityProfile', 
        'Update-CONNTaskTemplate', 
        'Update-CONNTrafficDistribution', 
        'Update-CONNUserHierarchy', 
        'Update-CONNUserHierarchyGroupName', 
        'Update-CONNUserHierarchyStructure', 
        'Update-CONNUserIdentityInfo', 
        'Update-CONNUserPhoneConfig', 
        'Update-CONNUserRoutingProfile', 
        'Update-CONNUserSecurityProfile', 
        'Write-CONNUserContact', 
        'Write-CONNUserStatus')

    # Variables to export from this module
    VariablesToExport = '*'

    # Aliases to export from this module
    AliasesToExport = @()

    # List of all modules packaged with this module
    ModuleList = @()

    # List of all files packaged with this module
    FileList = @(
        'AWS.Tools.Connect.dll-Help.xml'
    )

    # Private data to pass to the module specified in ModuleToProcess
    PrivateData = @{

        PSData = @{
            Tags = @('AWS', 'cloud', 'Windows', 'PSEdition_Desktop', 'PSEdition_Core', 'Linux', 'MacOS', 'Mac')
            LicenseUri = 'https://aws.amazon.com/apache-2-0/'
            ProjectUri = 'https://github.com/aws/aws-tools-for-powershell'
            IconUri = 'https://sdk-for-net.amazonwebservices.com/images/AWSLogo128x128.png'
            ReleaseNotes = 'https://github.com/aws/aws-tools-for-powershell/blob/master/CHANGELOG.md'
        }
    }
}
