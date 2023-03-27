// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.PowerShell;

    /// <summary>Set tempDb storage settings for SQL Server.</summary>
    [System.ComponentModel.TypeConverter(typeof(SqlTempDbSettingsTypeConverter))]
    public partial class SqlTempDbSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.SqlTempDbSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SqlTempDbSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.SqlTempDbSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SqlTempDbSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SqlTempDbSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SqlTempDbSettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.SqlTempDbSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SqlTempDbSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataFileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileSize = (int?) content.GetValueForProperty("DataFileSize",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataGrowth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataGrowth = (int?) content.GetValueForProperty("DataGrowth",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataGrowth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogFileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogFileSize = (int?) content.GetValueForProperty("LogFileSize",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogGrowth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogGrowth = (int?) content.GetValueForProperty("LogGrowth",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogGrowth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataFileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileCount = (int?) content.GetValueForProperty("DataFileCount",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PersistFolder"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolder = (bool?) content.GetValueForProperty("PersistFolder",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolder, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PersistFolderPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolderPath = (string) content.GetValueForProperty("PersistFolderPath",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolderPath, global::System.Convert.ToString);
            }
            if (content.Contains("Lun"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).Lun = (int[]) content.GetValueForProperty("Lun",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).Lun, __y => TypeConverterExtensions.SelectToArray<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("DefaultFilePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DefaultFilePath = (string) content.GetValueForProperty("DefaultFilePath",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DefaultFilePath, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.SqlTempDbSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SqlTempDbSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataFileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileSize = (int?) content.GetValueForProperty("DataFileSize",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataGrowth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataGrowth = (int?) content.GetValueForProperty("DataGrowth",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataGrowth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogFileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogFileSize = (int?) content.GetValueForProperty("LogFileSize",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogGrowth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogGrowth = (int?) content.GetValueForProperty("LogGrowth",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).LogGrowth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataFileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileCount = (int?) content.GetValueForProperty("DataFileCount",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DataFileCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PersistFolder"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolder = (bool?) content.GetValueForProperty("PersistFolder",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolder, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PersistFolderPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolderPath = (string) content.GetValueForProperty("PersistFolderPath",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).PersistFolderPath, global::System.Convert.ToString);
            }
            if (content.Contains("Lun"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).Lun = (int[]) content.GetValueForProperty("Lun",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).Lun, __y => TypeConverterExtensions.SelectToArray<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("DefaultFilePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DefaultFilePath = (string) content.GetValueForProperty("DefaultFilePath",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal)this).DefaultFilePath, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Set tempDb storage settings for SQL Server.
    [System.ComponentModel.TypeConverter(typeof(SqlTempDbSettingsTypeConverter))]
    public partial interface ISqlTempDbSettings

    {

    }
}