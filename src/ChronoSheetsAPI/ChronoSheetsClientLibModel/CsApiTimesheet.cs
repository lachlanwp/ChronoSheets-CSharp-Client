/* 
 * ChronoSheets API
 *
 * An API for integrating into ChronoSheets timesheets
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
    /// CsApiTimesheet
    /// </summary>
    [DataContract]
    public partial class CsApiTimesheet :  IEquatable<CsApiTimesheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiTimesheet" /> class.
        /// </summary>
        /// <param name="TimesheetId">TimesheetId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="JobId">JobId.</param>
        /// <param name="TaskId">TaskId.</param>
        /// <param name="StartDateTime">StartDateTime.</param>
        /// <param name="EndDateTime">EndDateTime.</param>
        /// <param name="Description">Description.</param>
        /// <param name="TripId">TripId.</param>
        /// <param name="FileAttachmentCount">FileAttachmentCount.</param>
        /// <param name="PayAmount">PayAmount.</param>
        /// <param name="OvertimePayAmount">OvertimePayAmount.</param>
        /// <param name="IncludesOvertime">IncludesOvertime.</param>
        public CsApiTimesheet(int? TimesheetId = default(int?), int? UserId = default(int?), int? JobId = default(int?), int? TaskId = default(int?), DateTime? StartDateTime = default(DateTime?), DateTime? EndDateTime = default(DateTime?), string Description = default(string), int? TripId = default(int?), int? FileAttachmentCount = default(int?), double? PayAmount = default(double?), double? OvertimePayAmount = default(double?), bool? IncludesOvertime = default(bool?))
        {
            this.TimesheetId = TimesheetId;
            this.UserId = UserId;
            this.JobId = JobId;
            this.TaskId = TaskId;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.Description = Description;
            this.TripId = TripId;
            this.FileAttachmentCount = FileAttachmentCount;
            this.PayAmount = PayAmount;
            this.OvertimePayAmount = OvertimePayAmount;
            this.IncludesOvertime = IncludesOvertime;
        }
        
        /// <summary>
        /// Gets or Sets TimesheetId
        /// </summary>
        [DataMember(Name="TimesheetId", EmitDefaultValue=false)]
        public int? TimesheetId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="JobId", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="TaskId", EmitDefaultValue=false)]
        public int? TaskId { get; set; }

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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets TripId
        /// </summary>
        [DataMember(Name="TripId", EmitDefaultValue=false)]
        public int? TripId { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentCount
        /// </summary>
        [DataMember(Name="FileAttachmentCount", EmitDefaultValue=false)]
        public int? FileAttachmentCount { get; set; }

        /// <summary>
        /// Gets or Sets PayAmount
        /// </summary>
        [DataMember(Name="PayAmount", EmitDefaultValue=false)]
        public double? PayAmount { get; set; }

        /// <summary>
        /// Gets or Sets OvertimePayAmount
        /// </summary>
        [DataMember(Name="OvertimePayAmount", EmitDefaultValue=false)]
        public double? OvertimePayAmount { get; set; }

        /// <summary>
        /// Gets or Sets IncludesOvertime
        /// </summary>
        [DataMember(Name="IncludesOvertime", EmitDefaultValue=false)]
        public bool? IncludesOvertime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiTimesheet {\n");
            sb.Append("  TimesheetId: ").Append(TimesheetId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TripId: ").Append(TripId).Append("\n");
            sb.Append("  FileAttachmentCount: ").Append(FileAttachmentCount).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  OvertimePayAmount: ").Append(OvertimePayAmount).Append("\n");
            sb.Append("  IncludesOvertime: ").Append(IncludesOvertime).Append("\n");
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
            return this.Equals(input as CsApiTimesheet);
        }

        /// <summary>
        /// Returns true if CsApiTimesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiTimesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiTimesheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimesheetId == input.TimesheetId ||
                    (this.TimesheetId != null &&
                    this.TimesheetId.Equals(input.TimesheetId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TripId == input.TripId ||
                    (this.TripId != null &&
                    this.TripId.Equals(input.TripId))
                ) && 
                (
                    this.FileAttachmentCount == input.FileAttachmentCount ||
                    (this.FileAttachmentCount != null &&
                    this.FileAttachmentCount.Equals(input.FileAttachmentCount))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.OvertimePayAmount == input.OvertimePayAmount ||
                    (this.OvertimePayAmount != null &&
                    this.OvertimePayAmount.Equals(input.OvertimePayAmount))
                ) && 
                (
                    this.IncludesOvertime == input.IncludesOvertime ||
                    (this.IncludesOvertime != null &&
                    this.IncludesOvertime.Equals(input.IncludesOvertime))
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
                if (this.TimesheetId != null)
                    hashCode = hashCode * 59 + this.TimesheetId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TripId != null)
                    hashCode = hashCode * 59 + this.TripId.GetHashCode();
                if (this.FileAttachmentCount != null)
                    hashCode = hashCode * 59 + this.FileAttachmentCount.GetHashCode();
                if (this.PayAmount != null)
                    hashCode = hashCode * 59 + this.PayAmount.GetHashCode();
                if (this.OvertimePayAmount != null)
                    hashCode = hashCode * 59 + this.OvertimePayAmount.GetHashCode();
                if (this.IncludesOvertime != null)
                    hashCode = hashCode * 59 + this.IncludesOvertime.GetHashCode();
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
