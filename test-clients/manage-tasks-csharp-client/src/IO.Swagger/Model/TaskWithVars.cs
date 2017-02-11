/* 
 * project
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1-SNAPSHOT
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
    /// TaskWithVars
    /// </summary>
    [DataContract]
    public partial class TaskWithVars :  IEquatable<TaskWithVars>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWithVars" /> class.
        /// </summary>
        /// <param name="TaskId">TaskId.</param>
        /// <param name="TaskPriority">TaskPriority.</param>
        /// <param name="TaskName">TaskName.</param>
        /// <param name="TaskDescription">TaskDescription.</param>
        /// <param name="TaskStatus">TaskStatus.</param>
        /// <param name="TaskActualOwner">TaskActualOwner.</param>
        /// <param name="TaskCreatedBy">TaskCreatedBy.</param>
        /// <param name="TaskCreatedOn">TaskCreatedOn.</param>
        /// <param name="TaskActivationTime">TaskActivationTime.</param>
        /// <param name="TaskProcessInstanceId">TaskProcessInstanceId.</param>
        /// <param name="TaskProcessId">TaskProcessId.</param>
        /// <param name="TaskContainerId">TaskContainerId.</param>
        /// <param name="TaskInputData">TaskInputData.</param>
        public TaskWithVars(int? TaskId = default(int?), int? TaskPriority = default(int?), string TaskName = default(string), string TaskDescription = default(string), string TaskStatus = default(string), string TaskActualOwner = default(string), string TaskCreatedBy = default(string), DateTime? TaskCreatedOn = default(DateTime?), DateTime? TaskActivationTime = default(DateTime?), int? TaskProcessInstanceId = default(int?), string TaskProcessId = default(string), string TaskContainerId = default(string), Dictionary<string, string> TaskInputData = default(Dictionary<string, string>))
        {
            this.TaskId = TaskId;
            this.TaskPriority = TaskPriority;
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescription;
            this.TaskStatus = TaskStatus;
            this.TaskActualOwner = TaskActualOwner;
            this.TaskCreatedBy = TaskCreatedBy;
            this.TaskCreatedOn = TaskCreatedOn;
            this.TaskActivationTime = TaskActivationTime;
            this.TaskProcessInstanceId = TaskProcessInstanceId;
            this.TaskProcessId = TaskProcessId;
            this.TaskContainerId = TaskContainerId;
            this.TaskInputData = TaskInputData;
        }
        
        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="task-id", EmitDefaultValue=false)]
        public int? TaskId { get; set; }
        /// <summary>
        /// Gets or Sets TaskPriority
        /// </summary>
        [DataMember(Name="task-priority", EmitDefaultValue=false)]
        public int? TaskPriority { get; set; }
        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name="task-name", EmitDefaultValue=false)]
        public string TaskName { get; set; }
        /// <summary>
        /// Gets or Sets TaskDescription
        /// </summary>
        [DataMember(Name="task-description", EmitDefaultValue=false)]
        public string TaskDescription { get; set; }
        /// <summary>
        /// Gets or Sets TaskStatus
        /// </summary>
        [DataMember(Name="task-status", EmitDefaultValue=false)]
        public string TaskStatus { get; set; }
        /// <summary>
        /// Gets or Sets TaskActualOwner
        /// </summary>
        [DataMember(Name="task-actual-owner", EmitDefaultValue=false)]
        public string TaskActualOwner { get; set; }
        /// <summary>
        /// Gets or Sets TaskCreatedBy
        /// </summary>
        [DataMember(Name="task-created-by", EmitDefaultValue=false)]
        public string TaskCreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets TaskCreatedOn
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [DataMember(Name="task-created-on", EmitDefaultValue=false)]
        public DateTime? TaskCreatedOn { get; set; }
        /// <summary>
        /// Gets or Sets TaskActivationTime
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [DataMember(Name="task-activation-time", EmitDefaultValue=false)]
        public DateTime? TaskActivationTime { get; set; }
        /// <summary>
        /// Gets or Sets TaskProcessInstanceId
        /// </summary>
        [DataMember(Name="task-process-instance-id", EmitDefaultValue=false)]
        public int? TaskProcessInstanceId { get; set; }
        /// <summary>
        /// Gets or Sets TaskProcessId
        /// </summary>
        [DataMember(Name="task-process-id", EmitDefaultValue=false)]
        public string TaskProcessId { get; set; }
        /// <summary>
        /// Gets or Sets TaskContainerId
        /// </summary>
        [DataMember(Name="task-container-id", EmitDefaultValue=false)]
        public string TaskContainerId { get; set; }
        /// <summary>
        /// Gets or Sets TaskInputData
        /// </summary>
        [DataMember(Name="task-input-data", EmitDefaultValue=false)]
        public Dictionary<string, string> TaskInputData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWithVars {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TaskPriority: ").Append(TaskPriority).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  TaskDescription: ").Append(TaskDescription).Append("\n");
            sb.Append("  TaskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  TaskActualOwner: ").Append(TaskActualOwner).Append("\n");
            sb.Append("  TaskCreatedBy: ").Append(TaskCreatedBy).Append("\n");
            sb.Append("  TaskCreatedOn: ").Append(TaskCreatedOn).Append("\n");
            sb.Append("  TaskActivationTime: ").Append(TaskActivationTime).Append("\n");
            sb.Append("  TaskProcessInstanceId: ").Append(TaskProcessInstanceId).Append("\n");
            sb.Append("  TaskProcessId: ").Append(TaskProcessId).Append("\n");
            sb.Append("  TaskContainerId: ").Append(TaskContainerId).Append("\n");
            sb.Append("  TaskInputData: ").Append(TaskInputData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TaskWithVars);
        }

        /// <summary>
        /// Returns true if TaskWithVars instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskWithVars to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWithVars other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskId == other.TaskId ||
                    this.TaskId != null &&
                    this.TaskId.Equals(other.TaskId)
                ) && 
                (
                    this.TaskPriority == other.TaskPriority ||
                    this.TaskPriority != null &&
                    this.TaskPriority.Equals(other.TaskPriority)
                ) && 
                (
                    this.TaskName == other.TaskName ||
                    this.TaskName != null &&
                    this.TaskName.Equals(other.TaskName)
                ) && 
                (
                    this.TaskDescription == other.TaskDescription ||
                    this.TaskDescription != null &&
                    this.TaskDescription.Equals(other.TaskDescription)
                ) && 
                (
                    this.TaskStatus == other.TaskStatus ||
                    this.TaskStatus != null &&
                    this.TaskStatus.Equals(other.TaskStatus)
                ) && 
                (
                    this.TaskActualOwner == other.TaskActualOwner ||
                    this.TaskActualOwner != null &&
                    this.TaskActualOwner.Equals(other.TaskActualOwner)
                ) && 
                (
                    this.TaskCreatedBy == other.TaskCreatedBy ||
                    this.TaskCreatedBy != null &&
                    this.TaskCreatedBy.Equals(other.TaskCreatedBy)
                ) && 
                (
                    this.TaskCreatedOn == other.TaskCreatedOn ||
                    this.TaskCreatedOn != null &&
                    this.TaskCreatedOn.Equals(other.TaskCreatedOn)
                ) && 
                (
                    this.TaskActivationTime == other.TaskActivationTime ||
                    this.TaskActivationTime != null &&
                    this.TaskActivationTime.Equals(other.TaskActivationTime)
                ) && 
                (
                    this.TaskProcessInstanceId == other.TaskProcessInstanceId ||
                    this.TaskProcessInstanceId != null &&
                    this.TaskProcessInstanceId.Equals(other.TaskProcessInstanceId)
                ) && 
                (
                    this.TaskProcessId == other.TaskProcessId ||
                    this.TaskProcessId != null &&
                    this.TaskProcessId.Equals(other.TaskProcessId)
                ) && 
                (
                    this.TaskContainerId == other.TaskContainerId ||
                    this.TaskContainerId != null &&
                    this.TaskContainerId.Equals(other.TaskContainerId)
                ) && 
                (
                    this.TaskInputData == other.TaskInputData ||
                    this.TaskInputData != null &&
                    this.TaskInputData.SequenceEqual(other.TaskInputData)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TaskId != null)
                    hash = hash * 59 + this.TaskId.GetHashCode();
                if (this.TaskPriority != null)
                    hash = hash * 59 + this.TaskPriority.GetHashCode();
                if (this.TaskName != null)
                    hash = hash * 59 + this.TaskName.GetHashCode();
                if (this.TaskDescription != null)
                    hash = hash * 59 + this.TaskDescription.GetHashCode();
                if (this.TaskStatus != null)
                    hash = hash * 59 + this.TaskStatus.GetHashCode();
                if (this.TaskActualOwner != null)
                    hash = hash * 59 + this.TaskActualOwner.GetHashCode();
                if (this.TaskCreatedBy != null)
                    hash = hash * 59 + this.TaskCreatedBy.GetHashCode();
                if (this.TaskCreatedOn != null)
                    hash = hash * 59 + this.TaskCreatedOn.GetHashCode();
                if (this.TaskActivationTime != null)
                    hash = hash * 59 + this.TaskActivationTime.GetHashCode();
                if (this.TaskProcessInstanceId != null)
                    hash = hash * 59 + this.TaskProcessInstanceId.GetHashCode();
                if (this.TaskProcessId != null)
                    hash = hash * 59 + this.TaskProcessId.GetHashCode();
                if (this.TaskContainerId != null)
                    hash = hash * 59 + this.TaskContainerId.GetHashCode();
                if (this.TaskInputData != null)
                    hash = hash * 59 + this.TaskInputData.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
