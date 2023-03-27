// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>
    /// Configure SQL best practices Assessment for databases in your SQL virtual machine.
    /// </summary>
    public partial class AssessmentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAssessmentSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAssessmentSettingsInternal
    {

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Enable or disable SQL best practices Assessment feature on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Internal Acessors for Schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISchedule Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAssessmentSettingsInternal.Schedule { get => (this._schedule = this._schedule ?? new Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.Schedule()); set { {_schedule = value;} } }

        /// <summary>Backing field for <see cref="RunImmediately" /> property.</summary>
        private bool? _runImmediately;

        /// <summary>Run SQL best practices Assessment immediately on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? RunImmediately { get => this._runImmediately; set => this._runImmediately = value; }

        /// <summary>Backing field for <see cref="Schedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISchedule _schedule;

        /// <summary>Schedule for SQL best practices Assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISchedule Schedule { get => (this._schedule = this._schedule ?? new Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.Schedule()); set => this._schedule = value; }

        /// <summary>Day of the week to run assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? ScheduleDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).DayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).DayOfWeek = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek)""); }

        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public bool? ScheduleEnable { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).Enable; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).Enable = value ?? default(bool); }

        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public int? ScheduleMonthlyOccurrence { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).MonthlyOccurrence; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).MonthlyOccurrence = value ?? default(int); }

        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public string ScheduleStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).StartTime = value ?? null; }

        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public int? ScheduleWeeklyInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).WeeklyInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal)Schedule).WeeklyInterval = value ?? default(int); }

        /// <summary>Creates an new <see cref="AssessmentSettings" /> instance.</summary>
        public AssessmentSettings()
        {

        }
    }
    /// Configure SQL best practices Assessment for databases in your SQL virtual machine.
    public partial interface IAssessmentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>Enable or disable SQL best practices Assessment feature on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable SQL best practices Assessment feature on SQL virtual machine.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }
        /// <summary>Run SQL best practices Assessment immediately on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Run SQL best practices Assessment immediately on SQL virtual machine.",
        SerializedName = @"runImmediately",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RunImmediately { get; set; }
        /// <summary>Day of the week to run assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day of the week to run assessment.",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? ScheduleDayOfWeek { get; set; }
        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable assessment schedule on SQL virtual machine.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ScheduleEnable { get; set; }
        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek day of the month",
        SerializedName = @"monthlyOccurrence",
        PossibleTypes = new [] { typeof(int) })]
        int? ScheduleMonthlyOccurrence { get; set; }
        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time of the day in HH:mm format. Eg. 17:30",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleStartTime { get; set; }
        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of weeks to schedule between 2 assessment runs. Takes value from 1-6",
        SerializedName = @"weeklyInterval",
        PossibleTypes = new [] { typeof(int) })]
        int? ScheduleWeeklyInterval { get; set; }

    }
    /// Configure SQL best practices Assessment for databases in your SQL virtual machine.
    internal partial interface IAssessmentSettingsInternal

    {
        /// <summary>Enable or disable SQL best practices Assessment feature on SQL virtual machine.</summary>
        bool? Enable { get; set; }
        /// <summary>Run SQL best practices Assessment immediately on SQL virtual machine.</summary>
        bool? RunImmediately { get; set; }
        /// <summary>Schedule for SQL best practices Assessment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISchedule Schedule { get; set; }
        /// <summary>Day of the week to run assessment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? ScheduleDayOfWeek { get; set; }
        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        bool? ScheduleEnable { get; set; }
        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        int? ScheduleMonthlyOccurrence { get; set; }
        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        string ScheduleStartTime { get; set; }
        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        int? ScheduleWeeklyInterval { get; set; }

    }
}