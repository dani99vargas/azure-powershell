
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
Creates or updates a contact profile.
.Description
Creates or updates a contact profile.
.Example
$linkChannel = New-AzOrbitalContactProfileLinkChannelObject -BandwidthMHz 15 -CenterFrequencyMHz 8160 -EndPointIPAddress 10.0.1.0 -EndPointName AQUA_command -EndPointPort 55555 -EndPointProtocol TCP -Name channel1 -DecodingConfiguration na -DemodulationConfiguration na -EncodingConfiguration AQUA_CMD_CCSDS -ModulationConfiguration AQUA_UPLINK_BPSK

$profileLink = New-AzOrbitalContactProfileLinkObject -Channel $linkChannel -Direction Downlink -Name RHCP_UL -Polarization RHCP -EirpdBw 45 -GainOverTemperature 0

New-AzOrbitalContactProfile -Name azps-orbital-contactprofile -ResourceGroupName azpstest-gp -Location westus2 -SubscriptionId 9e223dbe-3399-4e19-88eb-0975f02ac87f -AutoTrackingConfiguration xBand -EventHubUri /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/azpstest-gp/providers/Microsoft.EventHub/namespaces/eventhub-test -Link $profileLink -MinimumElevationDegree 10 -MinimumViableContactDuration PT1M -NetworkConfigurationSubnetId /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/azpstest-gp/providers/Microsoft.Network/virtualNetworks/orbital-virtualnetwork/subnets/orbital-vn

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfile
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

LINK <IContactProfileLink[]>: Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints.
  Channel <IContactProfileLinkChannel[]>: Contact Profile Link Channel.
    BandwidthMHz <Single>: Bandwidth in MHz.
    CenterFrequencyMHz <Single>: Center Frequency in MHz.
    EndPointIPAddress <String>: IP Address.
    EndPointName <String>: Name of an end point.
    EndPointPort <String>: TCP port to listen on to receive data.
    EndPointProtocol <Protocol>: Protocol either UDP or TCP.
    Name <String>: Channel name.
    [DecodingConfiguration <String>]: Currently unused.
    [DemodulationConfiguration <String>]: Copy of the modem configuration file such as Kratos QRadio or Kratos QuantumRx. Only valid for downlink directions. If provided, the modem connects to the customer endpoint and sends demodulated data instead of a VITA.49 stream.
    [EncodingConfiguration <String>]: Currently unused.
    [ModulationConfiguration <String>]: Copy of the modem configuration file such as Kratos QRadio. Only valid for uplink directions. If provided, the modem connects to the customer endpoint and accepts commands from the customer instead of a VITA.49 stream.
  Direction <Direction>: Direction (uplink or downlink).
  Name <String>: Link name.
  Polarization <Polarization>: Polarization. e.g. (RHCP, LHCP).
  [EirpdBw <Single?>]: Effective Isotropic Radiated Power (EIRP) in dBW. It is the required EIRP by the customer. Not used yet.
  [GainOverTemperature <Single?>]: Gain To Noise Temperature in db/K. It is the required G/T by the customer. Not used yet.
.Link
https://docs.microsoft.com/powershell/module/az.orbital/new-azorbitalcontactprofile
#>
function New-AzOrbitalContactProfile {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfile])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ContactProfileName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Path')]
    [System.String]
    # Contact Profile name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration])]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.AutoTrackingConfiguration]
    # Auto-tracking configuration.
    ${AutoTrackingConfiguration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [System.String]
    # ARM resource identifier of the Event Hub used for telemetry.
    # Requires granting Orbital Resource Provider the rights to send telemetry into the hub.
    ${EventHubUri},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactProfileLink[]]
    # Links of the Contact Profile.
    # Describes RF links, modem processing, and IP endpoints.
    # To construct, see NOTES section for LINK properties and create a hash table.
    ${Link},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [System.Single]
    # Minimum viable elevation for the contact in decimal degrees.
    # Used for listing the available contacts with a spacecraft at a given ground station.
    ${MinimumElevationDegree},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [System.String]
    # Minimum viable contact duration in ISO 8601 format.
    # Used for listing the available contacts with a spacecraft at a given ground station.
    ${MinimumViableContactDuration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [System.String]
    # ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways.
    # Needs to be at least a class C subnet, and should not have any IP created in it.
    ${NetworkConfigurationSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Category('Runtime')]
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
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Orbital.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.Orbital.private\New-AzOrbitalContactProfile_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Orbital.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
