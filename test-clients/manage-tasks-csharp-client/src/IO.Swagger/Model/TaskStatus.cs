/* 
 * KieServerTaskManager
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0-SNAPSHOT
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines TaskStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskStatus
    {
        
        /// <summary>
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,
        
        /// <summary>
        /// Enum Ready for "Ready"
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready,
        
        /// <summary>
        /// Enum Reserved for "Reserved"
        /// </summary>
        [EnumMember(Value = "Reserved")]
        Reserved,
        
        /// <summary>
        /// Enum InProgress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress,
        
        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,
        
        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,
        
        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,
        
        /// <summary>
        /// Enum Exited for "Exited"
        /// </summary>
        [EnumMember(Value = "Exited")]
        Exited,
        
        /// <summary>
        /// Enum Obsolete for "Obsolete"
        /// </summary>
        [EnumMember(Value = "Obsolete")]
        Obsolete
    }

}