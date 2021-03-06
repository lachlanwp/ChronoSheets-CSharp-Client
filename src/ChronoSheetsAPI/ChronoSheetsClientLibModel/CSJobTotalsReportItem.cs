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
    /// CSJobTotalsReportItem
    /// </summary>
    [DataContract]
    public partial class CSJobTotalsReportItem :  IEquatable<CSJobTotalsReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSJobTotalsReportItem" /> class.
        /// </summary>
        /// <param name="organisationId">organisationId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="jobCode">jobCode.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="spanSeconds">spanSeconds.</param>
        public CSJobTotalsReportItem(int? organisationId = default(int?), int? jobId = default(int?), string jobCode = default(string), int? clientId = default(int?), string clientName = default(string), int? projectId = default(int?), string projectName = default(string), int? spanSeconds = default(int?))
        {
            this.OrganisationId = organisationId;
            this.JobId = jobId;
            this.JobCode = jobCode;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.SpanSeconds = spanSeconds;
        }
        
        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="JobId", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobCode
        /// </summary>
        [DataMember(Name="JobCode", EmitDefaultValue=false)]
        public string JobCode { get; set; }

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
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="ProjectId", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="ProjectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

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
            sb.Append("class CSJobTotalsReportItem {\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobCode: ").Append(JobCode).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
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
            return this.Equals(input as CSJobTotalsReportItem);
        }

        /// <summary>
        /// Returns true if CSJobTotalsReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CSJobTotalsReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSJobTotalsReportItem input)
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
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobCode == input.JobCode ||
                    (this.JobCode != null &&
                    this.JobCode.Equals(input.JobCode))
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobCode != null)
                    hashCode = hashCode * 59 + this.JobCode.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
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
