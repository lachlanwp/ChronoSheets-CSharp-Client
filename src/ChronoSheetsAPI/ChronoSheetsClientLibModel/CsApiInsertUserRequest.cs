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
    /// CsApiInsertUserRequest
    /// </summary>
    [DataContract]
    public partial class CsApiInsertUserRequest :  IEquatable<CsApiInsertUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiInsertUserRequest" /> class.
        /// </summary>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="IsSubscribedToNewsletter">IsSubscribedToNewsletter.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="AlertSettings">AlertSettings.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="HourlyPayRate">HourlyPayRate.</param>
        /// <param name="HourlyOvertimePayRate">HourlyOvertimePayRate.</param>
        /// <param name="CurrentDate">CurrentDate.</param>
        public CsApiInsertUserRequest(string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), bool? IsSubscribedToNewsletter = default(bool?), long? Roles = default(long?), long? AlertSettings = default(long?), string UserName = default(string), double? HourlyPayRate = default(double?), double? HourlyOvertimePayRate = default(double?), DateTime? CurrentDate = default(DateTime?))
        {
            this.EmailAddress = EmailAddress;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
            this.Roles = Roles;
            this.AlertSettings = AlertSettings;
            this.UserName = UserName;
            this.HourlyPayRate = HourlyPayRate;
            this.HourlyOvertimePayRate = HourlyOvertimePayRate;
            this.CurrentDate = CurrentDate;
        }
        
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedToNewsletter
        /// </summary>
        [DataMember(Name="IsSubscribedToNewsletter", EmitDefaultValue=false)]
        public bool? IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="Roles", EmitDefaultValue=false)]
        public long? Roles { get; set; }

        /// <summary>
        /// Gets or Sets AlertSettings
        /// </summary>
        [DataMember(Name="AlertSettings", EmitDefaultValue=false)]
        public long? AlertSettings { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets HourlyPayRate
        /// </summary>
        [DataMember(Name="HourlyPayRate", EmitDefaultValue=false)]
        public double? HourlyPayRate { get; set; }

        /// <summary>
        /// Gets or Sets HourlyOvertimePayRate
        /// </summary>
        [DataMember(Name="HourlyOvertimePayRate", EmitDefaultValue=false)]
        public double? HourlyOvertimePayRate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentDate
        /// </summary>
        [DataMember(Name="CurrentDate", EmitDefaultValue=false)]
        public DateTime? CurrentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiInsertUserRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  HourlyPayRate: ").Append(HourlyPayRate).Append("\n");
            sb.Append("  HourlyOvertimePayRate: ").Append(HourlyOvertimePayRate).Append("\n");
            sb.Append("  CurrentDate: ").Append(CurrentDate).Append("\n");
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
            return this.Equals(input as CsApiInsertUserRequest);
        }

        /// <summary>
        /// Returns true if CsApiInsertUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiInsertUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiInsertUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.IsSubscribedToNewsletter == input.IsSubscribedToNewsletter ||
                    (this.IsSubscribedToNewsletter != null &&
                    this.IsSubscribedToNewsletter.Equals(input.IsSubscribedToNewsletter))
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
                ) && 
                (
                    this.AlertSettings == input.AlertSettings ||
                    (this.AlertSettings != null &&
                    this.AlertSettings.Equals(input.AlertSettings))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.HourlyPayRate == input.HourlyPayRate ||
                    (this.HourlyPayRate != null &&
                    this.HourlyPayRate.Equals(input.HourlyPayRate))
                ) && 
                (
                    this.HourlyOvertimePayRate == input.HourlyOvertimePayRate ||
                    (this.HourlyOvertimePayRate != null &&
                    this.HourlyOvertimePayRate.Equals(input.HourlyOvertimePayRate))
                ) && 
                (
                    this.CurrentDate == input.CurrentDate ||
                    (this.CurrentDate != null &&
                    this.CurrentDate.Equals(input.CurrentDate))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.HourlyPayRate != null)
                    hashCode = hashCode * 59 + this.HourlyPayRate.GetHashCode();
                if (this.HourlyOvertimePayRate != null)
                    hashCode = hashCode * 59 + this.HourlyOvertimePayRate.GetHashCode();
                if (this.CurrentDate != null)
                    hashCode = hashCode * 59 + this.CurrentDate.GetHashCode();
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
