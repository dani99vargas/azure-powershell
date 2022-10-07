// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support
{

    /// <summary>Gets the state of virtual network rule.</summary>
    public partial struct State :
        System.IEquatable<State>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State Deprovisioning = @"deprovisioning";

        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State Failed = @"failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State NetworkSourceDeleted = @"networkSourceDeleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State Provisioning = @"provisioning";

        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State Succeeded = @"succeeded";

        /// <summary>the value for an instance of the <see cref="State" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to State</summary>
        /// <param name="value">the value to convert to an instance of <see cref="State" />.</param>
        internal static object CreateFrom(object value)
        {
            return new State(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type State</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type State (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is State && Equals((State)obj);
        }

        /// <summary>Returns hashCode for enum State</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="State"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private State(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for State</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to State</summary>
        /// <param name="value">the value to convert to an instance of <see cref="State" />.</param>

        public static implicit operator State(string value)
        {
            return new State(value);
        }

        /// <summary>Implicit operator to convert State to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="State" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum State</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e1, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum State</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e1, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.State e2)
        {
            return e2.Equals(e1);
        }
    }
}