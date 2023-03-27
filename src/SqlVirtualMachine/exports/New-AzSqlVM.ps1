
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a SQL virtual machine.
.Description
Creates or updates a SQL virtual machine.
.Example
New-AzSqlVM -ResourceGroupName 'ResourceGroup01' -Name 'sqlvm1' -Location 'eastus'
.Example
New-AzSqlVM -ResourceGroupName 'ResourceGroup01' -Name 'sqlvm1' -Location 'eastus' -Sku 'Developer' -LicenseType 'PAYG'

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine
.Link
https://learn.microsoft.com/powershell/module/az.sqlvirtualmachine/new-azsqlvm
#>
function New-AzSqlVM {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('SqlVirtualMachineName', 'SqlVMName')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the SQL virtual machine.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription ID that identifies an Azure subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable R services (SQL 2016 onwards).
    ${AdditionalFeatureServerConfigurationIsRServicesEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable SQL best practices Assessment feature on SQL virtual machine.
    ${AssessmentSettingEnable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Run SQL best practices Assessment immediately on SQL virtual machine.
    ${AssessmentSettingRunImmediately},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.BackupScheduleType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.BackupScheduleType]
    # Backup schedule type.
    ${AutoBackupSettingBackupScheduleType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Include or exclude system databases from auto backup.
    ${AutoBackupSettingBackupSystemDb},

    [Parameter()]
    [AllowEmptyCollection()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AutoBackupDaysOfWeek])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AutoBackupDaysOfWeek[]]
    # Days of the week for the backups when FullBackupFrequency is set to Weekly.
    ${AutoBackupSettingDaysOfWeek},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable autobackup on SQL virtual machine.
    ${AutoBackupSettingEnable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable encryption for backup on SQL virtual machine.
    ${AutoBackupSettingEnableEncryption},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.FullBackupFrequencyType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.FullBackupFrequencyType]
    # Frequency of full backups.
    # In both cases, full backups begin during the next scheduled time window.
    ${AutoBackupSettingFullBackupFrequency},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Start time of a given day during which full backups can take place.
    # 0-23 hours.
    ${AutoBackupSettingFullBackupStartTime},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Duration of the time window of a given day during which full backups can take place.
    # 1-23 hours.
    ${AutoBackupSettingFullBackupWindowHour},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Frequency of log backups.
    # 5-60 minutes.
    ${AutoBackupSettingLogBackupFrequency},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # Password for encryption on backup.
    ${AutoBackupSettingPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Retention period of backup: 1-90 days.
    ${AutoBackupSettingRetentionPeriod},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Storage account key where backup will be taken to.
    ${AutoBackupSettingStorageAccessKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Storage account url where backup will be taken to.
    ${AutoBackupSettingStorageAccountUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Storage container name where backup will be taken to.
    ${AutoBackupSettingStorageContainerName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DayOfWeek])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DayOfWeek]
    # Day of week to apply the patch on.
    ${AutoPatchingSettingDayOfWeek},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable autopatching on SQL virtual machine.
    ${AutoPatchingSettingEnable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Duration of patching.
    ${AutoPatchingSettingMaintenanceWindowDuration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Hour of the day when patching is initiated.
    # Local VM time.
    ${AutoPatchingSettingMaintenanceWindowStartingHour},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # The client Id of the Managed Identity to query Microsoft Graph API.
    # An empty string must be used for the system assigned Managed Identity
    ${AzureAdAuthenticationSettingClientId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable automatic upgrade of Sql IaaS extension Agent.
    ${EnableAutomaticUpgrade},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.IdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.IdentityType]
    # The identity type.
    # Set this to 'SystemAssigned' in order to automatically create and assign an Azure Active Directory principal for the resource.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Azure Key Vault url.
    ${KeyVaultCredentialSettingAzureKeyVaultUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Credential name.
    ${KeyVaultCredentialSettingCredentialName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable key vault credential setting.
    ${KeyVaultCredentialSettingEnable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Service principal name to access key vault.
    ${KeyVaultCredentialSettingServicePrincipalName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Service principal name secret to access key vault.
    ${KeyVaultCredentialSettingServicePrincipalSecret},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.LeastPrivilegeMode])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.LeastPrivilegeMode]
    # SQL IaaS Agent least privilege mode.
    ${LeastPrivilegeMode},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlServerLicenseType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlServerLicenseType]
    # SQL Server license type.
    ${LicenseType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL image offer.
    # Examples include SQL2016-WS2016, SQL2017-WS2016.
    ${Offer},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek]
    # Day of the week to run assessment.
    ${ScheduleDayOfWeek},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable assessment schedule on SQL virtual machine.
    ${ScheduleEnable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Occurrence of the DayOfWeek day within a month to schedule assessment.
    # Takes values: 1,2,3,4 and -1.
    # Use -1 for last DayOfWeek day of the month
    ${ScheduleMonthlyOccurrence},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Time of the day in HH:mm format.
    # Eg.
    # 17:30
    ${ScheduleStartTime},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Number of weeks to schedule between 2 assessment runs.
    # Takes value from 1-6
    ${ScheduleWeeklyInterval},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlImageSku])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlImageSku]
    # SQL Server edition type.
    ${Sku},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ConnectivityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ConnectivityType]
    # SQL Server connectivity option.
    ${SqlConnectivityUpdateSettingConnectivityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server port.
    ${SqlConnectivityUpdateSettingPort},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # SQL Server sysadmin login password.
    ${SqlConnectivityUpdateSettingSqlAuthUpdatePassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server sysadmin login to create.
    ${SqlConnectivityUpdateSettingSqlAuthUpdateUserName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server default file path
    ${SqlDataSettingDefaultFilePath},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32[]]
    # Logical Unit Numbers for the disks.
    ${SqlDataSettingLun},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server Collation.
    ${SqlInstanceSettingCollation},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # SQL Server IFI.
    ${SqlInstanceSettingIsIfiEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # SQL Server LPIM.
    ${SqlInstanceSettingIsLpimEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # SQL Server Optimize for Adhoc workloads.
    ${SqlInstanceSettingIsOptimizeForAdHocWorkloadsEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server MAXDOP.
    ${SqlInstanceSettingMaxDop},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server maximum memory.
    ${SqlInstanceSettingMaxServerMemoryMb},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server minimum memory.
    ${SqlInstanceSettingMinServerMemoryMb},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server default file path
    ${SqlLogSettingDefaultFilePath},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32[]]
    # Logical Unit Numbers for the disks.
    ${SqlLogSettingLun},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlManagementMode])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlManagementMode]
    # SQL Server Management type.
    ${SqlManagementType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DiskConfigurationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DiskConfigurationType]
    # Disk configuration to apply to SQL Server.
    ${SqlStorageUpdateSettingDiskConfigurationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Virtual machine disk count.
    ${SqlStorageUpdateSettingDiskCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # Device id of the first disk to be updated.
    ${SqlStorageUpdateSettingStartingDeviceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server tempdb data file count
    ${SqlTempDbSettingDataFileCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server tempdb data file size
    ${SqlTempDbSettingDataFileSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server tempdb data file autoGrowth size
    ${SqlTempDbSettingDataGrowth},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server default file path
    ${SqlTempDbSettingDefaultFilePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server tempdb log file size
    ${SqlTempDbSettingLogFileSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32]
    # SQL Server tempdb log file autoGrowth size
    ${SqlTempDbSettingLogGrowth},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Int32[]]
    # Logical Unit Numbers for the disks.
    ${SqlTempDbSettingLun},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # SQL Server tempdb persist folder choice
    ${SqlTempDbSettingPersistFolder},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # SQL Server tempdb persist folder location
    ${SqlTempDbSettingPersistFolderPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # ARM resource id of the SQL virtual machine group this SQL virtual machine is or will be part of.
    ${SqlVirtualMachineGroupResourceId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlWorkloadType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.SqlWorkloadType]
    # SQL Server workload type.
    ${SqlWorkloadTypeUpdateSettingSqlWorkloadType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DiskConfigurationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.DiskConfigurationType]
    # Disk configuration to apply to SQL Server.
    ${StorageConfigurationSettingDiskConfigurationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # SQL Server SystemDb Storage on DataPool if true.
    ${StorageConfigurationSettingSqlSystemDbOnDataDisk},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.StorageWorkloadType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.StorageWorkloadType]
    # Storage workload type.
    ${StorageConfigurationSettingStorageWorkloadType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # ARM Resource id of underlying virtual machine created from SQL marketplace image.
    ${VirtualMachineResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # Cluster bootstrap account password.
    ${WsfcDomainCredentialsClusterBootstrapAccountPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # Cluster operator account password.
    ${WsfcDomainCredentialsClusterOperatorAccountPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # SQL service account password.
    ${WsfcDomainCredentialsSqlServiceAccountPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Domain credentials for setting up Windows Server Failover Cluster for SQL availability group.
    ${WsfcStaticIP},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.SqlVirtualMachine.custom\New-AzSqlVM';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
