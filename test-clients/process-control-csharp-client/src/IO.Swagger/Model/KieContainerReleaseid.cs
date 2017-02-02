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
    /// KieContainerReleaseid
    /// </summary>
    [DataContract]
    public partial class KieContainerReleaseid :  IEquatable<KieContainerReleaseid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KieContainerReleaseid" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="ArtifactId">ArtifactId.</param>
        public KieContainerReleaseid(string Version = default(string), string GroupId = default(string), string ArtifactId = default(string))
        {
            this.Version = Version;
            this.GroupId = GroupId;
            this.ArtifactId = ArtifactId;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group-id", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// Gets or Sets ArtifactId
        /// </summary>
        [DataMember(Name="artifact-id", EmitDefaultValue=false)]
        public string ArtifactId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KieContainerReleaseid {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
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
            return this.Equals(obj as KieContainerReleaseid);
        }

        /// <summary>
        /// Returns true if KieContainerReleaseid instances are equal
        /// </summary>
        /// <param name="other">Instance of KieContainerReleaseid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KieContainerReleaseid other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.ArtifactId == other.ArtifactId ||
                    this.ArtifactId != null &&
                    this.ArtifactId.Equals(other.ArtifactId)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.ArtifactId != null)
                    hash = hash * 59 + this.ArtifactId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}