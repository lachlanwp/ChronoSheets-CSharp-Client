/* 
 * ChronoSheets API
 *
 * ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.
 *
 * OpenAPI spec version: v1
 * Contact: lachlan@chronosheets.com
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
    /// CsApiApiResponseForPaginatedListOrgReportTrip
    /// </summary>
    [DataContract]
    public partial class CsApiApiResponseForPaginatedListOrgReportTrip :  IEquatable<CsApiApiResponseForPaginatedListOrgReportTrip>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Succeeded for value: Succeeded
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded = 1,
            
            /// <summary>
            /// Enum FatalException for value: FatalException
            /// </summary>
            [EnumMember(Value = "FatalException")]
            FatalException = 2,
            
            /// <summary>
            /// Enum GeneralError for value: GeneralError
            /// </summary>
            [EnumMember(Value = "GeneralError")]
            GeneralError = 3,
            
            /// <summary>
            /// Enum ValidationError for value: ValidationError
            /// </summary>
            [EnumMember(Value = "ValidationError")]
            ValidationError = 4,
            
            /// <summary>
            /// Enum UnAuthorized for value: UnAuthorized
            /// </summary>
            [EnumMember(Value = "UnAuthorized")]
            UnAuthorized = 5,
            
            /// <summary>
            /// Enum SessionExpired for value: SessionExpired
            /// </summary>
            [EnumMember(Value = "SessionExpired")]
            SessionExpired = 6
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiApiResponseForPaginatedListOrgReportTrip" /> class.
        /// </summary>
        /// <param name="TotalSetCount">TotalSetCount.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Message">Message.</param>
        public CsApiApiResponseForPaginatedListOrgReportTrip(int? TotalSetCount = default(int?), List<CsApiOrgReportTrip> Data = default(List<CsApiOrgReportTrip>), StatusEnum? Status = default(StatusEnum?), string Message = default(string))
        {
            this.TotalSetCount = TotalSetCount;
            this.Data = Data;
            this.Status = Status;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets TotalSetCount
        /// </summary>
        [DataMember(Name="TotalSetCount", EmitDefaultValue=false)]
        public int? TotalSetCount { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public List<CsApiOrgReportTrip> Data { get; set; }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiApiResponseForPaginatedListOrgReportTrip {\n");
            sb.Append("  TotalSetCount: ").Append(TotalSetCount).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CsApiApiResponseForPaginatedListOrgReportTrip);
        }

        /// <summary>
        /// Returns true if CsApiApiResponseForPaginatedListOrgReportTrip instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiApiResponseForPaginatedListOrgReportTrip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiApiResponseForPaginatedListOrgReportTrip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalSetCount == input.TotalSetCount ||
                    (this.TotalSetCount != null &&
                    this.TotalSetCount.Equals(input.TotalSetCount))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.TotalSetCount != null)
                    hashCode = hashCode * 59 + this.TotalSetCount.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
