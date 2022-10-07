// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.PowerShell;

    /// <summary>A condition of the scheduled query rule.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConditionTypeConverter))]
    public partial class Condition
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Condition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Condition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FailingPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriod = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionFailingPeriods) content.GetValueForProperty("FailingPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriod, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ConditionFailingPeriodsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Query"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Query = (string) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Query, global::System.Convert.ToString);
            }
            if (content.Contains("TimeAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).TimeAggregation = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.TimeAggregation?) content.GetValueForProperty("TimeAggregation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).TimeAggregation, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.TimeAggregation.CreateFrom);
            }
            if (content.Contains("MetricMeasureColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricMeasureColumn = (string) content.GetValueForProperty("MetricMeasureColumn",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricMeasureColumn, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).ResourceIdColumn = (string) content.GetValueForProperty("ResourceIdColumn",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).ResourceIdColumn, global::System.Convert.ToString);
            }
            if (content.Contains("Dimension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IDimension[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IDimension>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.DimensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Operator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Operator = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.ConditionOperator?) content.GetValueForProperty("Operator",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Operator, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.ConditionOperator.CreateFrom);
            }
            if (content.Contains("Threshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Threshold = (double?) content.GetValueForProperty("Threshold",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Threshold, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MetricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricName = (string) content.GetValueForProperty("MetricName",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricName, global::System.Convert.ToString);
            }
            if (content.Contains("FailingPeriodNumberOfEvaluationPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodNumberOfEvaluationPeriod = (long?) content.GetValueForProperty("FailingPeriodNumberOfEvaluationPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodNumberOfEvaluationPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FailingPeriodMinFailingPeriodsToAlert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodMinFailingPeriodsToAlert = (long?) content.GetValueForProperty("FailingPeriodMinFailingPeriodsToAlert",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodMinFailingPeriodsToAlert, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Condition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Condition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FailingPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriod = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionFailingPeriods) content.GetValueForProperty("FailingPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriod, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ConditionFailingPeriodsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Query"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Query = (string) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Query, global::System.Convert.ToString);
            }
            if (content.Contains("TimeAggregation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).TimeAggregation = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.TimeAggregation?) content.GetValueForProperty("TimeAggregation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).TimeAggregation, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.TimeAggregation.CreateFrom);
            }
            if (content.Contains("MetricMeasureColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricMeasureColumn = (string) content.GetValueForProperty("MetricMeasureColumn",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricMeasureColumn, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).ResourceIdColumn = (string) content.GetValueForProperty("ResourceIdColumn",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).ResourceIdColumn, global::System.Convert.ToString);
            }
            if (content.Contains("Dimension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IDimension[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IDimension>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.DimensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Operator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Operator = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.ConditionOperator?) content.GetValueForProperty("Operator",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Operator, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.ConditionOperator.CreateFrom);
            }
            if (content.Contains("Threshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Threshold = (double?) content.GetValueForProperty("Threshold",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).Threshold, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MetricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricName = (string) content.GetValueForProperty("MetricName",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).MetricName, global::System.Convert.ToString);
            }
            if (content.Contains("FailingPeriodNumberOfEvaluationPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodNumberOfEvaluationPeriod = (long?) content.GetValueForProperty("FailingPeriodNumberOfEvaluationPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodNumberOfEvaluationPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FailingPeriodMinFailingPeriodsToAlert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodMinFailingPeriodsToAlert = (long?) content.GetValueForProperty("FailingPeriodMinFailingPeriodsToAlert",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IConditionInternal)this).FailingPeriodMinFailingPeriodsToAlert, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Condition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ICondition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ICondition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Condition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Condition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ICondition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ICondition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Condition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Condition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Condition" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ICondition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// A condition of the scheduled query rule.
    [System.ComponentModel.TypeConverter(typeof(ConditionTypeConverter))]
    public partial interface ICondition

    {

    }
}