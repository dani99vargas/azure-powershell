
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
Update a threat Intelligence indicator.
.Description
Update a threat Intelligence indicator.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorModelForRequestBody
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.ISecurityInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInformation
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

EXTERNALREFERENCE <IThreatIntelligenceExternalReference[]>: External References
  [Description <String>]: External reference description
  [ExternalId <String>]: External reference ID
  [Hash <IThreatIntelligenceExternalReferenceHashes>]: External reference hashes
    [(Any) <String>]: This indicates any property can be added to this object.
  [SourceName <String>]: External reference source name
  [Url <String>]: External reference URL

GRANULARMARKING <IThreatIntelligenceGranularMarkingModel[]>: Granular Markings
  [Language <String>]: Language granular marking model
  [MarkingRef <Int32?>]: marking reference granular marking model
  [Selector <String[]>]: granular marking model selectors

INPUTOBJECT <ISecurityInsightsIdentity>: Identity Parameter
  [ActionId <String>]: Action ID
  [AlertRuleTemplateId <String>]: Alert rule template ID
  [AutomationRuleId <String>]: Automation rule ID
  [BookmarkId <String>]: Bookmark ID
  [ConsentId <String>]: consent ID
  [DataConnectorId <String>]: Connector ID
  [EntityId <String>]: entity ID
  [EntityQueryId <String>]: entity query ID
  [EntityQueryTemplateId <String>]: entity query template ID
  [Id <String>]: Resource identity path
  [IncidentCommentId <String>]: Incident comment ID
  [IncidentId <String>]: Incident ID
  [MetadataName <String>]: The Metadata name.
  [Name <String>]: Threat intelligence indicator name field.
  [RelationName <String>]: Relation Name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RuleId <String>]: Alert rule ID
  [SentinelOnboardingStateName <String>]: The Sentinel onboarding state name. Supports - default
  [SettingsName <String>]: The setting name. Supports - Anomalies, EyesOn, EntityAnalytics, Ueba
  [SourceControlId <String>]: Source control Id
  [SubscriptionId <String>]: The ID of the target subscription.
  [WorkspaceName <String>]: The name of the workspace.

KILLCHAINPHASE <IThreatIntelligenceKillChainPhase[]>: Kill chain phases
  [KillChainName <String>]: Kill chainName name
  [PhaseName <String>]: Phase name

PARSEDPATTERN <IThreatIntelligenceParsedPattern[]>: Parsed patterns
  [PatternTypeKey <String>]: Pattern type key
  [PatternTypeValue <IThreatIntelligenceParsedPatternTypeValue[]>]: Pattern type keys
    [Value <String>]: Value of parsed pattern
    [ValueType <String>]: Type of the value

THREATINTELLIGENCEPROPERTY <IThreatIntelligenceIndicatorModelForRequestBody>: Threat intelligence indicator entity used in request body.
  [Confidence <Int32?>]: Confidence of threat intelligence entity
  [Created <String>]: Created by
  [CreatedByRef <String>]: Created by reference of threat intelligence entity
  [Defanged <Boolean?>]: Is threat intelligence entity defanged
  [Description <String>]: Description of a threat intelligence entity
  [DisplayName <String>]: Display name of a threat intelligence entity
  [Etag <String>]: Etag of the azure resource
  [Extension <IThreatIntelligenceIndicatorPropertiesExtensions>]: Extensions map
    [(Any) <Object>]: This indicates any property can be added to this object.
  [ExternalId <String>]: External ID of threat intelligence entity
  [ExternalLastUpdatedTimeUtc <String>]: External last updated time in UTC
  [ExternalReference <IThreatIntelligenceExternalReference[]>]: External References
    [Description <String>]: External reference description
    [ExternalId <String>]: External reference ID
    [Hash <IThreatIntelligenceExternalReferenceHashes>]: External reference hashes
      [(Any) <String>]: This indicates any property can be added to this object.
    [SourceName <String>]: External reference source name
    [Url <String>]: External reference URL
  [GranularMarking <IThreatIntelligenceGranularMarkingModel[]>]: Granular Markings
    [Language <String>]: Language granular marking model
    [MarkingRef <Int32?>]: marking reference granular marking model
    [Selector <String[]>]: granular marking model selectors
  [IndicatorType <String[]>]: Indicator types of threat intelligence entities
  [KillChainPhase <IThreatIntelligenceKillChainPhase[]>]: Kill chain phases
    [KillChainName <String>]: Kill chainName name
    [PhaseName <String>]: Phase name
  [Label <String[]>]: Labels  of threat intelligence entity
  [Language <String>]: Language of threat intelligence entity
  [LastUpdatedTimeUtc <String>]: Last updated time in UTC
  [Modified <String>]: Modified by
  [ObjectMarkingRef <String[]>]: Threat intelligence entity object marking references
  [ParsedPattern <IThreatIntelligenceParsedPattern[]>]: Parsed patterns
    [PatternTypeKey <String>]: Pattern type key
    [PatternTypeValue <IThreatIntelligenceParsedPatternTypeValue[]>]: Pattern type keys
      [Value <String>]: Value of parsed pattern
      [ValueType <String>]: Type of the value
  [Pattern <String>]: Pattern of a threat intelligence entity
  [PatternType <String>]: Pattern type of a threat intelligence entity
  [PatternVersion <String>]: Pattern version of a threat intelligence entity
  [Revoked <Boolean?>]: Is threat intelligence entity revoked
  [Source <String>]: Source of a threat intelligence entity
  [ThreatIntelligenceTag <String[]>]: List of tags
  [ThreatType <String[]>]: Threat types
  [ValidFrom <String>]: Valid from
  [ValidUntil <String>]: Valid until
.Link
https://learn.microsoft.com/powershell/module/az.securityinsights/update-azsentinelthreatintelligenceindicator
#>
function Update-AzSentinelThreatIntelligenceIndicator {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInformation])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [System.String]
    # Threat intelligence indicator name field.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.ISecurityInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.Int32]
    # Confidence of threat intelligence entity
    ${Confidence},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Created by
    ${Created},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Created by reference of threat intelligence entity
    ${CreatedByRef},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Is threat intelligence entity defanged
    ${Defanged},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Description of a threat intelligence entity
    ${Description},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Display name of a threat intelligence entity
    ${DisplayName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions]))]
    [System.Collections.Hashtable]
    # Extensions map
    ${Extension},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # External ID of threat intelligence entity
    ${ExternalId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # External last updated time in UTC
    ${ExternalLastUpdatedTimeUtc},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference[]]
    # External References
    # To construct, see NOTES section for EXTERNALREFERENCE properties and create a hash table.
    ${ExternalReference},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel[]]
    # Granular Markings
    # To construct, see NOTES section for GRANULARMARKING properties and create a hash table.
    ${GranularMarking},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    # Indicator types of threat intelligence entities
    ${IndicatorType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase[]]
    # Kill chain phases
    # To construct, see NOTES section for KILLCHAINPHASE properties and create a hash table.
    ${KillChainPhase},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    # Labels of threat intelligence entity
    ${Label},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Language of threat intelligence entity
    ${Language},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Last updated time in UTC
    ${LastUpdatedTimeUtc},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Modified by
    ${Modified},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    # Threat intelligence entity object marking references
    ${ObjectMarkingRef},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern[]]
    # Parsed patterns
    # To construct, see NOTES section for PARSEDPATTERN properties and create a hash table.
    ${ParsedPattern},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Pattern of a threat intelligence entity
    ${Pattern},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Pattern type of a threat intelligence entity
    ${PatternType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Pattern version of a threat intelligence entity
    ${PatternVersion},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Is threat intelligence entity revoked
    ${Revoked},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Source of a threat intelligence entity
    ${Source},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    # List of tags
    ${ThreatIntelligenceTag},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    # Threat types
    ${ThreatType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Valid from
    ${ValidFrom},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # Valid until
    ${ValidUntil},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorModelForRequestBody]
    # Threat intelligence indicator entity used in request body.
    # To construct, see NOTES section for THREATINTELLIGENCEPROPERTY properties and create a hash table.
    ${ThreatIntelligenceProperty},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
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

        $mapping = @{
            UpdateExpanded = 'Az.SecurityInsights.private\Update-AzSentinelThreatIntelligenceIndicator_UpdateExpanded';
            UpdateViaIdentity = 'Az.SecurityInsights.private\Update-AzSentinelThreatIntelligenceIndicator_UpdateViaIdentity';
            UpdateViaIdentityExpanded = 'Az.SecurityInsights.private\Update-AzSentinelThreatIntelligenceIndicator_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
