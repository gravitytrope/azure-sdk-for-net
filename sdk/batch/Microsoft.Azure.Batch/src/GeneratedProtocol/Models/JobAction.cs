// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobAction
    {
        /// <summary>
        /// Take no action.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// Disable the Job. This is equivalent to calling the disable Job API,
        /// with a disableTasks value of requeue.
        /// </summary>
        [EnumMember(Value = "disable")]
        Disable,
        /// <summary>
        /// Terminate the Job. The terminateReason in the Job's executionInfo
        /// is set to "TaskFailed".
        /// </summary>
        [EnumMember(Value = "terminate")]
        Terminate
    }
    internal static class JobActionEnumExtension
    {
        internal static string ToSerializedValue(this JobAction? value)
        {
            return value == null ? null : ((JobAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobAction value)
        {
            switch( value )
            {
                case JobAction.None:
                    return "none";
                case JobAction.Disable:
                    return "disable";
                case JobAction.Terminate:
                    return "terminate";
            }
            return null;
        }

        internal static JobAction? ParseJobAction(this string value)
        {
            switch( value )
            {
                case "none":
                    return JobAction.None;
                case "disable":
                    return JobAction.Disable;
                case "terminate":
                    return JobAction.Terminate;
            }
            return null;
        }
    }
}