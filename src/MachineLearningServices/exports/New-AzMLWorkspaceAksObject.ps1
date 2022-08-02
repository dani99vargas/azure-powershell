
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
Create an in-memory object for Aks.
.Description
Create an in-memory object for Aks.
.Example
New-AzMLWorkspaceAksObject -Description "aks compute"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.Aks
.Link
https://docs.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceAksObject
#>
function New-AzMLWorkspaceAksObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.Aks])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The description of the Machine Learning compute.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Boolean]
    # Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.
    ${DisableLocalAuth},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # ARM resource id of the underlying compute.
    ${ResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # Number of agents.
    ${AgentCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Agent virtual machine size.
    ${AgentVMSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # An IP address assigned to the Kubernetes DNS service.
    # It must be within the Kubernetes service address range specified in serviceCidr.
    ${AkNetworkingDnsServiceIP},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # A CIDR notation IP range assigned to the Docker bridge network.
    # It must not overlap with any Subnet IP ranges or the Kubernetes service address range.
    ${AkNetworkingDockerBridgeCidr},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # A CIDR notation IP range from which to assign service cluster IPs.
    # It must not overlap with any Subnet IP ranges.
    ${AkNetworkingServiceCidr},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Virtual network subnet resource ID the compute nodes belong to.
    ${AkNetworkingSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Cluster full qualified domain name.
    ${ClusterFqdn},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose]
    # Intended usage of the cluster.
    ${ClusterPurpose},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Load Balancer Subnet.
    ${LoadBalancerSubnet},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType]
    # Load Balancer Type.
    ${LoadBalancerType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Cert data.
    ${SslCert},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # CNAME of the cert.
    ${SslCname},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Key data.
    ${SslKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Leaf domain label of public endpoint.
    ${SslLeafDomainLabel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Boolean]
    # Indicates whether to overwrite existing domain label.
    ${SslOverwriteExistingDomain},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus]
    # Enable or disable ssl for scoring.
    ${SslStatus}
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
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            __AllParameterSets = 'Az.MachineLearningServices.custom\New-AzMLWorkspaceAksObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
