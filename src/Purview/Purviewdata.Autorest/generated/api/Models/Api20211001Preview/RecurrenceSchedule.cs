// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class RecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleInternal
    {

        /// <summary>Backing field for <see cref="AdditionalProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties _additionalProperty;

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.RecurrenceScheduleAdditionalProperties()); set => this._additionalProperty = value; }

        /// <summary>Backing field for <see cref="Hour" /> property.</summary>
        private int[] _hour;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public int[] Hour { get => this._hour; set => this._hour = value; }

        /// <summary>Backing field for <see cref="Minute" /> property.</summary>
        private int[] _minute;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public int[] Minute { get => this._minute; set => this._minute = value; }

        /// <summary>Backing field for <see cref="MonthDay" /> property.</summary>
        private int[] _monthDay;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public int[] MonthDay { get => this._monthDay; set => this._monthDay = value; }

        /// <summary>Backing field for <see cref="MonthlyOccurrence" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] _monthlyOccurrence;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] MonthlyOccurrence { get => this._monthlyOccurrence; set => this._monthlyOccurrence = value; }

        /// <summary>Backing field for <see cref="WeekDay" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] _weekDay;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] WeekDay { get => this._weekDay; set => this._weekDay = value; }

        /// <summary>Creates an new <see cref="RecurrenceSchedule" /> instance.</summary>
        public RecurrenceSchedule()
        {

        }
    }
    public partial interface IRecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <any>",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        int[] Hour { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        int[] Minute { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        int[] MonthDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthlyOccurrences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] MonthlyOccurrence { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] WeekDay { get; set; }

    }
    internal partial interface IRecurrenceScheduleInternal

    {
        /// <summary>Dictionary of <any></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get; set; }

        int[] Hour { get; set; }

        int[] Minute { get; set; }

        int[] MonthDay { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] MonthlyOccurrence { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] WeekDay { get; set; }

    }
}