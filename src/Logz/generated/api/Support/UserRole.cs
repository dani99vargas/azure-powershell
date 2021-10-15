// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Support
{

    /// <summary>User roles on configured in Logz.io account.</summary>
    public partial struct UserRole :
        System.IEquatable<UserRole>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole Admin = @"Admin";

        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole User = @"User";

        /// <summary>the value for an instance of the <see cref="UserRole" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UserRole</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UserRole" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UserRole(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UserRole</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UserRole (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UserRole && Equals((UserRole)obj);
        }

        /// <summary>Returns hashCode for enum UserRole</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UserRole</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UserRole" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UserRole(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UserRole</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UserRole" />.</param>

        public static implicit operator UserRole(string value)
        {
            return new UserRole(value);
        }

        /// <summary>Implicit operator to convert UserRole to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UserRole" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UserRole</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e1, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UserRole</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e1, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.UserRole e2)
        {
            return e2.Equals(e1);
        }
    }
}