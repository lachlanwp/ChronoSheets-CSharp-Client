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
    /// CsApiClientTotalsReportItem
    /// </summary>
    [DataContract]
    public partial class CsApiClientTotalsReportItem :  IEquatable<CsApiClientTotalsReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiClientTotalsReportItem" /> class.
        /// </summary>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="ClientName">ClientName.</param>
        /// <param name="SpanSeconds">SpanSeconds.</param>
        public CsApiClientTotalsReportItem(int? OrganisationId = default(int?), int? UserId = default(int?), int? ClientId = default(int?), string ClientName = default(string), int? SpanSeconds = default(int?))
        {
            this.OrganisationId = OrganisationId;
            this.UserId = UserId;
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.SpanSeconds = SpanSeconds;
        }
        
        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

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
            sb.Append("class CsApiClientTotalsReportItem {\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as CsApiClientTotalsReportItem);
        }

        /// <summary>
        /// Returns true if CsApiClientTotalsReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiClientTotalsReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiClientTotalsReportItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
