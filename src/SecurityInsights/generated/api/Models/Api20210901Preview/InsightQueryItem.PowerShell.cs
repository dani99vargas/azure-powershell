// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Represents Insight Query.</summary>
    [System.ComponentModel.TypeConverter(typeof(InsightQueryItemTypeConverter))]
    public partial class InsightQueryItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItem"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InsightQueryItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItem"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InsightQueryItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InsightQueryItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InsightQueryItem" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItem FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InsightQueryItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityQueryKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityQueryKind.CreateFrom);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemPropertiesDataTypesItem[]) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DataType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemPropertiesDataTypesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityQueryItemPropertiesDataTypesItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("InputEntityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).InputEntityType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType?) content.GetValueForProperty("InputEntityType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).InputEntityType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType.CreateFrom);
            }
            if (content.Contains("RequiredInputFieldsSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).RequiredInputFieldsSet = (string[][]) content.GetValueForProperty("RequiredInputFieldsSet",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).RequiredInputFieldsSet, __y => TypeConverterExtensions.SelectToArray<string[]>(__y, __w => TypeConverterExtensions.SelectToArray<string>(__w, global::System.Convert.ToString)));
            }
            if (content.Contains("EntitiesFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).EntitiesFilter = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny) content.GetValueForProperty("EntitiesFilter",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).EntitiesFilter, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQuery) content.GetValueForProperty("TableQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesAdditionalQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesAdditionalQuery) content.GetValueForProperty("PropertiesAdditionalQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesAdditionalQueryTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultTimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRange = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesDefaultTimeRange) content.GetValueForProperty("DefaultTimeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRange, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesDefaultTimeRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceTimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRange = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesReferenceTimeRange) content.GetValueForProperty("ReferenceTimeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRange, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesReferenceTimeRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("BaseQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).BaseQuery = (string) content.GetValueForProperty("BaseQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).BaseQuery, global::System.Convert.ToString);
            }
            if (content.Contains("ChartQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ChartQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny) content.GetValueForProperty("ChartQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ChartQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQueryColumnsDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryColumnsDefinition = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem[]) content.GetValueForProperty("TableQueryColumnsDefinition",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryColumnsDefinition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryColumnsDefinitionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableQueryQueriesDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryQueriesDefinition = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryQueriesDefinitionsItem[]) content.GetValueForProperty("TableQueryQueriesDefinition",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryQueriesDefinition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryQueriesDefinitionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryQueriesDefinitionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesAdditionalQueryQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQueryQuery = (string) content.GetValueForProperty("PropertiesAdditionalQueryQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQueryQuery, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalQueryText"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).AdditionalQueryText = (string) content.GetValueForProperty("AdditionalQueryText",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).AdditionalQueryText, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTimeRangeBeforeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeBeforeRange = (string) content.GetValueForProperty("DefaultTimeRangeBeforeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeBeforeRange, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTimeRangeAfterRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeAfterRange = (string) content.GetValueForProperty("DefaultTimeRangeAfterRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeAfterRange, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceTimeRangeBeforeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRangeBeforeRange = (string) content.GetValueForProperty("ReferenceTimeRangeBeforeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRangeBeforeRange, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InsightQueryItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityQueryKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityQueryKind.CreateFrom);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemPropertiesDataTypesItem[]) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DataType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryItemPropertiesDataTypesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityQueryItemPropertiesDataTypesItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("InputEntityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).InputEntityType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType?) content.GetValueForProperty("InputEntityType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).InputEntityType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType.CreateFrom);
            }
            if (content.Contains("RequiredInputFieldsSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).RequiredInputFieldsSet = (string[][]) content.GetValueForProperty("RequiredInputFieldsSet",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).RequiredInputFieldsSet, __y => TypeConverterExtensions.SelectToArray<string[]>(__y, __w => TypeConverterExtensions.SelectToArray<string>(__w, global::System.Convert.ToString)));
            }
            if (content.Contains("EntitiesFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).EntitiesFilter = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny) content.GetValueForProperty("EntitiesFilter",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).EntitiesFilter, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQuery) content.GetValueForProperty("TableQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesAdditionalQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesAdditionalQuery) content.GetValueForProperty("PropertiesAdditionalQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesAdditionalQueryTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultTimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRange = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesDefaultTimeRange) content.GetValueForProperty("DefaultTimeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRange, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesDefaultTimeRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceTimeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRange = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesReferenceTimeRange) content.GetValueForProperty("ReferenceTimeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRange, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesReferenceTimeRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("BaseQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).BaseQuery = (string) content.GetValueForProperty("BaseQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).BaseQuery, global::System.Convert.ToString);
            }
            if (content.Contains("ChartQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ChartQuery = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny) content.GetValueForProperty("ChartQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ChartQuery, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableQueryColumnsDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryColumnsDefinition = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem[]) content.GetValueForProperty("TableQueryColumnsDefinition",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryColumnsDefinition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryColumnsDefinitionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryColumnsDefinitionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableQueryQueriesDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryQueriesDefinition = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryQueriesDefinitionsItem[]) content.GetValueForProperty("TableQueryQueriesDefinition",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).TableQueryQueriesDefinition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemPropertiesTableQueryQueriesDefinitionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InsightQueryItemPropertiesTableQueryQueriesDefinitionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesAdditionalQueryQuery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQueryQuery = (string) content.GetValueForProperty("PropertiesAdditionalQueryQuery",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).PropertiesAdditionalQueryQuery, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalQueryText"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).AdditionalQueryText = (string) content.GetValueForProperty("AdditionalQueryText",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).AdditionalQueryText, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTimeRangeBeforeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeBeforeRange = (string) content.GetValueForProperty("DefaultTimeRangeBeforeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeBeforeRange, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultTimeRangeAfterRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeAfterRange = (string) content.GetValueForProperty("DefaultTimeRangeAfterRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).DefaultTimeRangeAfterRange, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceTimeRangeBeforeRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRangeBeforeRange = (string) content.GetValueForProperty("ReferenceTimeRangeBeforeRange",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightQueryItemInternal)this).ReferenceTimeRangeBeforeRange, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents Insight Query.
    [System.ComponentModel.TypeConverter(typeof(InsightQueryItemTypeConverter))]
    public partial interface IInsightQueryItem

    {

    }
}