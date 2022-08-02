// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The migration status.</summary>
    public partial struct MigrationState :
        System.IEquatable<MigrationState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState DisableMigrationFailed = @"DisableMigrationFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState DisableMigrationInProgress = @"DisableMigrationInProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState EnableMigrationFailed = @"EnableMigrationFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState EnableMigrationInProgress = @"EnableMigrationInProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState InitialSeedingFailed = @"InitialSeedingFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState InitialSeedingInProgress = @"InitialSeedingInProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState MigrationFailed = @"MigrationFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState MigrationInProgress = @"MigrationInProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState MigrationSucceeded = @"MigrationSucceeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState Replicating = @"Replicating";

        /// <summary>the value for an instance of the <see cref="MigrationState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MigrationState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MigrationState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MigrationState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MigrationState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MigrationState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MigrationState && Equals((MigrationState)obj);
        }

        /// <summary>Returns hashCode for enum MigrationState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MigrationState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MigrationState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MigrationState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MigrationState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MigrationState" />.</param>

        public static implicit operator MigrationState(string value)
        {
            return new MigrationState(value);
        }

        /// <summary>Implicit operator to convert MigrationState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MigrationState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MigrationState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MigrationState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationState e2)
        {
            return e2.Equals(e1);
        }
    }
}