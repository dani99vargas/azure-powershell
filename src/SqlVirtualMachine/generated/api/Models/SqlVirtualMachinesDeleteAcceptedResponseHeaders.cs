// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    public partial class SqlVirtualMachinesDeleteAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachinesDeleteAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachinesDeleteAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachinesDeleteAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>
        /// Creates an new <see cref="SqlVirtualMachinesDeleteAcceptedResponseHeaders" /> instance.
        /// </summary>
        public SqlVirtualMachinesDeleteAcceptedResponseHeaders()
        {

        }
    }
    public partial interface ISqlVirtualMachinesDeleteAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface ISqlVirtualMachinesDeleteAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}