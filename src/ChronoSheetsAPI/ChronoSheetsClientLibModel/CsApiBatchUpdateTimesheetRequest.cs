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
    /// CsApiBatchUpdateTimesheetRequest
    /// </summary>
    [DataContract]
    public partial class CsApiBatchUpdateTimesheetRequest :  IEquatable<CsApiBatchUpdateTimesheetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiBatchUpdateTimesheetRequest" /> class.
        /// </summary>
        /// <param name="Timesheets">Timesheets.</param>
        public CsApiBatchUpdateTimesheetRequest(List<CsApiTimesheet> Timesheets = default(List<CsApiTimesheet>))
        {
            this.Timesheets = Timesheets;
        }
        
        /// <summary>
        /// Gets or Sets Timesheets
        /// </summary>
        [DataMember(Name="Timesheets", EmitDefaultValue=false)]
        public List<CsApiTimesheet> Timesheets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiBatchUpdateTimesheetRequest {\n");
            sb.Append("  Timesheets: ").Append(Timesheets).Append("\n");
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
            return this.Equals(input as CsApiBatchUpdateTimesheetRequest);
        }

        /// <summary>
        /// Returns true if CsApiBatchUpdateTimesheetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiBatchUpdateTimesheetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiBatchUpdateTimesheetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timesheets == input.Timesheets ||
                    this.Timesheets != null &&
                    this.Timesheets.SequenceEqual(input.Timesheets)
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
                if (this.Timesheets != null)
                    hashCode = hashCode * 59 + this.Timesheets.GetHashCode();
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
