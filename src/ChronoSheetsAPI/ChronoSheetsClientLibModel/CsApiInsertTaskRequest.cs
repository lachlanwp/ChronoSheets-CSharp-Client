/* 
 * ChronoSheets API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = ChronoSheetsAPI.Client.SwaggerDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// CsApiInsertTaskRequest
    /// </summary>
    [DataContract]
    public partial class CsApiInsertTaskRequest :  IEquatable<CsApiInsertTaskRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiInsertTaskRequest" /> class.
        /// </summary>
        /// <param name="TaskName">TaskName.</param>
        /// <param name="TripEnabled">TripEnabled.</param>
        public CsApiInsertTaskRequest(string TaskName = default(string), bool? TripEnabled = default(bool?))
        {
            this.TaskName = TaskName;
            this.TripEnabled = TripEnabled;
        }
        
        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name="TaskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or Sets TripEnabled
        /// </summary>
        [DataMember(Name="TripEnabled", EmitDefaultValue=false)]
        public bool? TripEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiInsertTaskRequest {\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  TripEnabled: ").Append(TripEnabled).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CsApiInsertTaskRequest);
        }

        /// <summary>
        /// Returns true if CsApiInsertTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiInsertTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiInsertTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.TripEnabled == input.TripEnabled ||
                    (this.TripEnabled != null &&
                    this.TripEnabled.Equals(input.TripEnabled))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TripEnabled != null)
                    hashCode = hashCode * 59 + this.TripEnabled.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
