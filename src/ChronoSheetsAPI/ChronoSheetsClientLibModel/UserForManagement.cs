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
    /// UserForManagement
    /// </summary>
    [DataContract]
    public partial class UserForManagement :  IEquatable<UserForManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserForManagement" /> class.
        /// </summary>
        /// <param name="isAccountActive">isAccountActive.</param>
        /// <param name="id">The ID of the user.</param>
        /// <param name="organisationId">The ID of the organisation.</param>
        /// <param name="userName">The username of the user.</param>
        /// <param name="firstName">The first name of the user.</param>
        /// <param name="lastName">The last name of the user.</param>
        /// <param name="emailAddress">The email address of the user.</param>
        /// <param name="roles">A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details.</param>
        /// <param name="alertSettings">A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details.</param>
        /// <param name="setupWizardRequired">Whether or not the setup wizard is required.</param>
        /// <param name="isSubscribedToNewsletter">Whether or not the user is subscribed to the user.</param>
        /// <param name="organisation">organisation.</param>
        /// <param name="isPrimaryAccount">Whether or not this account is the organisation&#39;s primary account..</param>
        public UserForManagement(bool isAccountActive = default(bool), int id = default(int), int organisationId = default(int), string userName = default(string), string firstName = default(string), string lastName = default(string), string emailAddress = default(string), long roles = default(long), long alertSettings = default(long), bool setupWizardRequired = default(bool), bool isSubscribedToNewsletter = default(bool), Organisation organisation = default(Organisation), bool isPrimaryAccount = default(bool))
        {
            this.IsAccountActive = isAccountActive;
            this.Id = id;
            this.OrganisationId = organisationId;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Roles = roles;
            this.AlertSettings = alertSettings;
            this.SetupWizardRequired = setupWizardRequired;
            this.IsSubscribedToNewsletter = isSubscribedToNewsletter;
            this.Organisation = organisation;
            this.IsPrimaryAccount = isPrimaryAccount;
        }
        
        /// <summary>
        /// Gets or Sets IsAccountActive
        /// </summary>
        [DataMember(Name="IsAccountActive", EmitDefaultValue=false)]
        public bool IsAccountActive { get; set; }

        /// <summary>
        /// The ID of the user
        /// </summary>
        /// <value>The ID of the user</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the organisation
        /// </summary>
        /// <value>The ID of the organisation</value>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int OrganisationId { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details
        /// </summary>
        /// <value>A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details</value>
        [DataMember(Name="Roles", EmitDefaultValue=false)]
        public long Roles { get; set; }

        /// <summary>
        /// A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details
        /// </summary>
        /// <value>A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details</value>
        [DataMember(Name="AlertSettings", EmitDefaultValue=false)]
        public long AlertSettings { get; set; }

        /// <summary>
        /// Whether or not the setup wizard is required
        /// </summary>
        /// <value>Whether or not the setup wizard is required</value>
        [DataMember(Name="SetupWizardRequired", EmitDefaultValue=false)]
        public bool SetupWizardRequired { get; set; }

        /// <summary>
        /// Whether or not the user is subscribed to the user
        /// </summary>
        /// <value>Whether or not the user is subscribed to the user</value>
        [DataMember(Name="IsSubscribedToNewsletter", EmitDefaultValue=false)]
        public bool IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// Gets or Sets Organisation
        /// </summary>
        [DataMember(Name="Organisation", EmitDefaultValue=false)]
        public Organisation Organisation { get; set; }

        /// <summary>
        /// Whether or not this account is the organisation&#39;s primary account.
        /// </summary>
        /// <value>Whether or not this account is the organisation&#39;s primary account.</value>
        [DataMember(Name="IsPrimaryAccount", EmitDefaultValue=false)]
        public bool IsPrimaryAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserForManagement {\n");
            sb.Append("  IsAccountActive: ").Append(IsAccountActive).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
            sb.Append("  SetupWizardRequired: ").Append(SetupWizardRequired).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
            sb.Append("  IsPrimaryAccount: ").Append(IsPrimaryAccount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserForManagement);
        }

        /// <summary>
        /// Returns true if UserForManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of UserForManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserForManagement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAccountActive == input.IsAccountActive ||
                    (this.IsAccountActive != null &&
                    this.IsAccountActive.Equals(input.IsAccountActive))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                    this.SetupWizardRequired == input.SetupWizardRequired ||
                    (this.SetupWizardRequired != null &&
                    this.SetupWizardRequired.Equals(input.SetupWizardRequired))
                ) && 
                (
                    this.IsSubscribedToNewsletter == input.IsSubscribedToNewsletter ||
                    (this.IsSubscribedToNewsletter != null &&
                    this.IsSubscribedToNewsletter.Equals(input.IsSubscribedToNewsletter))
                ) && 
                (
                    this.Organisation == input.Organisation ||
                    (this.Organisation != null &&
                    this.Organisation.Equals(input.Organisation))
                ) && 
                (
                    this.IsPrimaryAccount == input.IsPrimaryAccount ||
                    (this.IsPrimaryAccount != null &&
                    this.IsPrimaryAccount.Equals(input.IsPrimaryAccount))
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
                if (this.IsAccountActive != null)
                    hashCode = hashCode * 59 + this.IsAccountActive.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
                if (this.SetupWizardRequired != null)
                    hashCode = hashCode * 59 + this.SetupWizardRequired.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.Organisation != null)
                    hashCode = hashCode * 59 + this.Organisation.GetHashCode();
                if (this.IsPrimaryAccount != null)
                    hashCode = hashCode * 59 + this.IsPrimaryAccount.GetHashCode();
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
