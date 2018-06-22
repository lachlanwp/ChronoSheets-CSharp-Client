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
    /// CsApiUserProfile
    /// </summary>
    [DataContract]
    public partial class CsApiUserProfile :  IEquatable<CsApiUserProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiUserProfile" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="IsSubscribedToNewsletter">IsSubscribedToNewsletter.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="AlertSettings">AlertSettings.</param>
        /// <param name="OrganisationName">OrganisationName.</param>
        /// <param name="OrganisationSuburb">OrganisationSuburb.</param>
        /// <param name="OrganisationCountry">OrganisationCountry.</param>
        public CsApiUserProfile(int? Id = default(int?), int? OrganisationId = default(int?), string UserName = default(string), string FirstName = default(string), string LastName = default(string), string EmailAddress = default(string), bool? IsSubscribedToNewsletter = default(bool?), long? Roles = default(long?), long? AlertSettings = default(long?), string OrganisationName = default(string), string OrganisationSuburb = default(string), string OrganisationCountry = default(string))
        {
            this.Id = Id;
            this.OrganisationId = OrganisationId;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
            this.Roles = Roles;
            this.AlertSettings = AlertSettings;
            this.OrganisationName = OrganisationName;
            this.OrganisationSuburb = OrganisationSuburb;
            this.OrganisationCountry = OrganisationCountry;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

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
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

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
        /// Gets or Sets OrganisationName
        /// </summary>
        [DataMember(Name="OrganisationName", EmitDefaultValue=false)]
        public string OrganisationName { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationSuburb
        /// </summary>
        [DataMember(Name="OrganisationSuburb", EmitDefaultValue=false)]
        public string OrganisationSuburb { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationCountry
        /// </summary>
        [DataMember(Name="OrganisationCountry", EmitDefaultValue=false)]
        public string OrganisationCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiUserProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  OrganisationSuburb: ").Append(OrganisationSuburb).Append("\n");
            sb.Append("  OrganisationCountry: ").Append(OrganisationCountry).Append("\n");
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
            return this.Equals(input as CsApiUserProfile);
        }

        /// <summary>
        /// Returns true if CsApiUserProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiUserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiUserProfile input)
        {
            if (input == null)
                return false;

            return 
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
                    this.OrganisationName == input.OrganisationName ||
                    (this.OrganisationName != null &&
                    this.OrganisationName.Equals(input.OrganisationName))
                ) && 
                (
                    this.OrganisationSuburb == input.OrganisationSuburb ||
                    (this.OrganisationSuburb != null &&
                    this.OrganisationSuburb.Equals(input.OrganisationSuburb))
                ) && 
                (
                    this.OrganisationCountry == input.OrganisationCountry ||
                    (this.OrganisationCountry != null &&
                    this.OrganisationCountry.Equals(input.OrganisationCountry))
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
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
                if (this.OrganisationName != null)
                    hashCode = hashCode * 59 + this.OrganisationName.GetHashCode();
                if (this.OrganisationSuburb != null)
                    hashCode = hashCode * 59 + this.OrganisationSuburb.GetHashCode();
                if (this.OrganisationCountry != null)
                    hashCode = hashCode * 59 + this.OrganisationCountry.GetHashCode();
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
