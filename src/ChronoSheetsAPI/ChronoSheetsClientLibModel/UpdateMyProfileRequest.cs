/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ChronoSheetsAPI.Client.OpenAPIDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// UpdateMyProfileRequest
    /// </summary>
    [DataContract]
    public partial class UpdateMyProfileRequest :  IEquatable<UpdateMyProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMyProfileRequest" /> class.
        /// </summary>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="oldPassword">oldPassword.</param>
        /// <param name="newPassword">newPassword.</param>
        /// <param name="confirmNewPassword">confirmNewPassword.</param>
        /// <param name="isSubscribedToNewsletter">isSubscribedToNewsletter.</param>
        /// <param name="wantsToChangePassword">wantsToChangePassword.</param>
        public UpdateMyProfileRequest(string emailAddress = default(string), string firstName = default(string), string lastName = default(string), string oldPassword = default(string), string newPassword = default(string), string confirmNewPassword = default(string), bool isSubscribedToNewsletter = default(bool), bool wantsToChangePassword = default(bool))
        {
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OldPassword = oldPassword;
            this.NewPassword = newPassword;
            this.ConfirmNewPassword = confirmNewPassword;
            this.IsSubscribedToNewsletter = isSubscribedToNewsletter;
            this.WantsToChangePassword = wantsToChangePassword;
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
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="OldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="NewPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmNewPassword
        /// </summary>
        [DataMember(Name="ConfirmNewPassword", EmitDefaultValue=false)]
        public string ConfirmNewPassword { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedToNewsletter
        /// </summary>
        [DataMember(Name="IsSubscribedToNewsletter", EmitDefaultValue=false)]
        public bool IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// Gets or Sets WantsToChangePassword
        /// </summary>
        [DataMember(Name="WantsToChangePassword", EmitDefaultValue=false)]
        public bool WantsToChangePassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMyProfileRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  ConfirmNewPassword: ").Append(ConfirmNewPassword).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  WantsToChangePassword: ").Append(WantsToChangePassword).Append("\n");
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
            return this.Equals(input as UpdateMyProfileRequest);
        }

        /// <summary>
        /// Returns true if UpdateMyProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMyProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMyProfileRequest input)
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
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.ConfirmNewPassword == input.ConfirmNewPassword ||
                    (this.ConfirmNewPassword != null &&
                    this.ConfirmNewPassword.Equals(input.ConfirmNewPassword))
                ) && 
                (
                    this.IsSubscribedToNewsletter == input.IsSubscribedToNewsletter ||
                    (this.IsSubscribedToNewsletter != null &&
                    this.IsSubscribedToNewsletter.Equals(input.IsSubscribedToNewsletter))
                ) && 
                (
                    this.WantsToChangePassword == input.WantsToChangePassword ||
                    (this.WantsToChangePassword != null &&
                    this.WantsToChangePassword.Equals(input.WantsToChangePassword))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.ConfirmNewPassword != null)
                    hashCode = hashCode * 59 + this.ConfirmNewPassword.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.WantsToChangePassword != null)
                    hashCode = hashCode * 59 + this.WantsToChangePassword.GetHashCode();
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
