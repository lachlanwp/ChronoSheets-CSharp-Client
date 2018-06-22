/* 
 * ChronoSheets API Documentation
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
    /// CsApiUserHourlyRate
    /// </summary>
    [DataContract]
    public partial class CsApiUserHourlyRate :  IEquatable<CsApiUserHourlyRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiUserHourlyRate" /> class.
        /// </summary>
        /// <param name="RateId">RateId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="IsCurrent">IsCurrent.</param>
        /// <param name="HourlyRate">HourlyRate.</param>
        /// <param name="HourlyOvertimeRate">HourlyOvertimeRate.</param>
        /// <param name="StartDateTime">StartDateTime.</param>
        /// <param name="EndDateTime">EndDateTime.</param>
        public CsApiUserHourlyRate(int? RateId = default(int?), int? UserId = default(int?), int? OrganisationId = default(int?), bool? IsCurrent = default(bool?), double? HourlyRate = default(double?), double? HourlyOvertimeRate = default(double?), DateTime? StartDateTime = default(DateTime?), DateTime? EndDateTime = default(DateTime?))
        {
            this.RateId = RateId;
            this.UserId = UserId;
            this.OrganisationId = OrganisationId;
            this.IsCurrent = IsCurrent;
            this.HourlyRate = HourlyRate;
            this.HourlyOvertimeRate = HourlyOvertimeRate;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
        }
        
        /// <summary>
        /// Gets or Sets RateId
        /// </summary>
        [DataMember(Name="RateId", EmitDefaultValue=false)]
        public int? RateId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrent
        /// </summary>
        [DataMember(Name="IsCurrent", EmitDefaultValue=false)]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Gets or Sets HourlyRate
        /// </summary>
        [DataMember(Name="HourlyRate", EmitDefaultValue=false)]
        public double? HourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets HourlyOvertimeRate
        /// </summary>
        [DataMember(Name="HourlyOvertimeRate", EmitDefaultValue=false)]
        public double? HourlyOvertimeRate { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="StartDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="EndDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiUserHourlyRate {\n");
            sb.Append("  RateId: ").Append(RateId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("  HourlyRate: ").Append(HourlyRate).Append("\n");
            sb.Append("  HourlyOvertimeRate: ").Append(HourlyOvertimeRate).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
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
            return this.Equals(input as CsApiUserHourlyRate);
        }

        /// <summary>
        /// Returns true if CsApiUserHourlyRate instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiUserHourlyRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiUserHourlyRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RateId == input.RateId ||
                    (this.RateId != null &&
                    this.RateId.Equals(input.RateId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.IsCurrent == input.IsCurrent ||
                    (this.IsCurrent != null &&
                    this.IsCurrent.Equals(input.IsCurrent))
                ) && 
                (
                    this.HourlyRate == input.HourlyRate ||
                    (this.HourlyRate != null &&
                    this.HourlyRate.Equals(input.HourlyRate))
                ) && 
                (
                    this.HourlyOvertimeRate == input.HourlyOvertimeRate ||
                    (this.HourlyOvertimeRate != null &&
                    this.HourlyOvertimeRate.Equals(input.HourlyOvertimeRate))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
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
                if (this.RateId != null)
                    hashCode = hashCode * 59 + this.RateId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.IsCurrent != null)
                    hashCode = hashCode * 59 + this.IsCurrent.GetHashCode();
                if (this.HourlyRate != null)
                    hashCode = hashCode * 59 + this.HourlyRate.GetHashCode();
                if (this.HourlyOvertimeRate != null)
                    hashCode = hashCode * 59 + this.HourlyOvertimeRate.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
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
