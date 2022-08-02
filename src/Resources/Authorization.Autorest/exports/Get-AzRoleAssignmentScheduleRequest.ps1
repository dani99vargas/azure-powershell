
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
Get the specified role assignment schedule request.
.Description
Get the specified role assignment schedule request.
.Example
$scope = "/subscriptions/38ab2ccc-3747-4567-b36b-9478f5602f0d"
Get-AzRoleAssignmentScheduleRequest -Scope $scope 
.Example
$scope = "/subscriptions/38ab2ccc-3747-4567-b36b-9478f5602f0d"
Get-AzRoleAssignmentScheduleRequest -Scope $scope -Filter "asTarget()"
.Example
$scope = "/subscriptions/38ab2ccc-3747-4567-b36b-9478f5602f0d"
Get-AzRoleAssignmentScheduleRequest -Scope $scope -Filter "asApprover()"
.Example
$scope = "/subscriptions/38ab2ccc-3747-4567-b36b-9478f5602f0d"
Get-AzRoleAssignmentScheduleRequest -Scope $scope -Name "2cc018c2-27f8-4730-a0bc-b6a8fcee3e70"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.IAuthorizationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleRequest
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAuthorizationIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [RoleAssignmentScheduleInstanceName <String>]: The name (hash of schedule name + time) of the role assignment schedule to get.
  [RoleAssignmentScheduleName <String>]: The name (guid) of the role assignment schedule to get.
  [RoleAssignmentScheduleRequestName <String>]: The name of the role assignment to create. It can be any valid GUID.
  [RoleEligibilityScheduleInstanceName <String>]: The name (hash of schedule name + time) of the role eligibility schedule to get.
  [RoleEligibilityScheduleName <String>]: The name (guid) of the role eligibility schedule to get.
  [RoleEligibilityScheduleRequestName <String>]: The name of the role eligibility to create. It can be any valid GUID.
  [RoleManagementPolicyAssignmentName <String>]: The name of format {guid_guid} the role management policy assignment to get.
  [RoleManagementPolicyName <String>]: The name (guid) of the role management policy to get.
  [Scope <String>]: The scope of the role management policy.
.Link
https://docs.microsoft.com/powershell/module/az.resources/get-azroleassignmentschedulerequest
#>
function Get-AzRoleAssignmentScheduleRequest {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleAssignmentScheduleRequest])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('RoleAssignmentScheduleRequestName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Path')]
    [System.String]
    # The name (guid) of the role assignment schedule request to get.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Path')]
    [System.String]
    # The scope of the role assignment schedule request.
    ${Scope},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.IAuthorizationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Query')]
    [System.String]
    # The filter to apply on the operation.
    # Use $filter=atScope() to return all role assignment schedule requests at or above the scope.
    # Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal.
    # Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user.
    # Use $filter=asTarget() to return all role assignment schedule requests created for the current user.
    # Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver.
    ${Filter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            Get = 'Az.Authorization.private\Get-AzRoleAssignmentScheduleRequest_Get';
            GetViaIdentity = 'Az.Authorization.private\Get-AzRoleAssignmentScheduleRequest_GetViaIdentity';
            List = 'Az.Authorization.private\Get-AzRoleAssignmentScheduleRequest_List';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
