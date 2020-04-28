/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    /// CSClientSeriesReportItem
    /// </summary>
    [DataContract]
    public partial class CSClientSeriesReportItem :  IEquatable<CSClientSeriesReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSClientSeriesReportItem" /> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="spanSeconds">spanSeconds.</param>
        public CSClientSeriesReportItem(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), int? clientId = default(int?), string clientName = default(string), int? spanSeconds = default(int?))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.SpanSeconds = spanSeconds;
        }
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="ClientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets SpanSeconds
        /// </summary>
        [DataMember(Name="SpanSeconds", EmitDefaultValue=false)]
        public int? SpanSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSClientSeriesReportItem {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  SpanSeconds: ").Append(SpanSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CSClientSeriesReportItem);
        }

        /// <summary>
        /// Returns true if CSClientSeriesReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CSClientSeriesReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSClientSeriesReportItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.SpanSeconds == input.SpanSeconds ||
                    (this.SpanSeconds != null &&
                    this.SpanSeconds.Equals(input.SpanSeconds))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.SpanSeconds != null)
                    hashCode = hashCode * 59 + this.SpanSeconds.GetHashCode();
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
