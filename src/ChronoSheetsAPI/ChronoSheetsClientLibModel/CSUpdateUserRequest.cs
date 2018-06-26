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
    /// CSUpdateUserRequest
    /// </summary>
    [DataContract]
    public partial class CSUpdateUserRequest :  IEquatable<CSUpdateUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSUpdateUserRequest" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="IsSubscribedToNewsletter">IsSubscribedToNewsletter.</param>
        /// <param name="IsAccountActive">IsAccountActive.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="AlertSettings">AlertSettings.</param>
        public CSUpdateUserRequest(int? UserId = default(int?), string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), bool? IsSubscribedToNewsletter = default(bool?), bool? IsAccountActive = default(bool?), long? Roles = default(long?), long? AlertSettings = default(long?))
        {
            this.UserId = UserId;
            this.EmailAddress = EmailAddress;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
            this.IsAccountActive = IsAccountActive;
            this.Roles = Roles;
            this.AlertSettings = AlertSettings;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

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
        /// Gets or Sets IsAccountActive
        /// </summary>
        [DataMember(Name="IsAccountActive", EmitDefaultValue=false)]
        public bool? IsAccountActive { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSUpdateUserRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  IsAccountActive: ").Append(IsAccountActive).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
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
            return this.Equals(input as CSUpdateUserRequest);
        }

        /// <summary>
        /// Returns true if CSUpdateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSUpdateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSUpdateUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
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
                    this.IsAccountActive == input.IsAccountActive ||
                    (this.IsAccountActive != null &&
                    this.IsAccountActive.Equals(input.IsAccountActive))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.IsAccountActive != null)
                    hashCode = hashCode * 59 + this.IsAccountActive.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
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