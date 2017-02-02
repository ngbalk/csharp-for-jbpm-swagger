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
    /// KieContainersStatus
    /// </summary>
    [DataContract]
    public partial class KieContainersStatus :  IEquatable<KieContainersStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KieContainersStatus" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Msg">Msg.</param>
        /// <param name="Result">Result.</param>
        public KieContainersStatus(string Type = default(string), string Msg = default(string), KieContainersStatusResult Result = default(KieContainersStatusResult))
        {
            this.Type = Type;
            this.Msg = Msg;
            this.Result = Result;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public KieContainersStatusResult Result { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KieContainersStatus {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as KieContainersStatus);
        }

        /// <summary>
        /// Returns true if KieContainersStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of KieContainersStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KieContainersStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Msg == other.Msg ||
                    this.Msg != null &&
                    this.Msg.Equals(other.Msg)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Msg != null)
                    hash = hash * 59 + this.Msg.GetHashCode();
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
