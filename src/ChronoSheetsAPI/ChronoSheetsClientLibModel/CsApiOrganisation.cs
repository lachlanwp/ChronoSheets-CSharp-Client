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
    /// CsApiOrganisation
    /// </summary>
    [DataContract]
    public partial class CsApiOrganisation :  IEquatable<CsApiOrganisation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiOrganisation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="AddressLine01">AddressLine01.</param>
        /// <param name="AddressLine02">AddressLine02.</param>
        /// <param name="Suburb">Suburb.</param>
        /// <param name="State">State.</param>
        /// <param name="Postcode">Postcode.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="SubscriptionCustomerId">SubscriptionCustomerId.</param>
        /// <param name="SubscriptionPlanId">SubscriptionPlanId.</param>
        /// <param name="SignupToken">SignupToken.</param>
        /// <param name="NumberSeatsAvailable">NumberSeatsAvailable.</param>
        public CsApiOrganisation(int? Id = default(int?), string Name = default(string), string AddressLine01 = default(string), string AddressLine02 = default(string), string Suburb = default(string), string State = default(string), string Postcode = default(string), string Country = default(string), string Phone = default(string), string EmailAddress = default(string), string Timezone = default(string), string SubscriptionCustomerId = default(string), string SubscriptionPlanId = default(string), string SignupToken = default(string), int? NumberSeatsAvailable = default(int?))
        {
            this.Id = Id;
            this.Name = Name;
            this.AddressLine01 = AddressLine01;
            this.AddressLine02 = AddressLine02;
            this.Suburb = Suburb;
            this.State = State;
            this.Postcode = Postcode;
            this.Country = Country;
            this.Phone = Phone;
            this.EmailAddress = EmailAddress;
            this.Timezone = Timezone;
            this.SubscriptionCustomerId = SubscriptionCustomerId;
            this.SubscriptionPlanId = SubscriptionPlanId;
            this.SignupToken = SignupToken;
            this.NumberSeatsAvailable = NumberSeatsAvailable;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine01
        /// </summary>
        [DataMember(Name="AddressLine01", EmitDefaultValue=false)]
        public string AddressLine01 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine02
        /// </summary>
        [DataMember(Name="AddressLine02", EmitDefaultValue=false)]
        public string AddressLine02 { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="Suburb", EmitDefaultValue=false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="Postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="Timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionCustomerId
        /// </summary>
        [DataMember(Name="SubscriptionCustomerId", EmitDefaultValue=false)]
        public string SubscriptionCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlanId
        /// </summary>
        [DataMember(Name="SubscriptionPlanId", EmitDefaultValue=false)]
        public string SubscriptionPlanId { get; set; }

        /// <summary>
        /// Gets or Sets SignupToken
        /// </summary>
        [DataMember(Name="SignupToken", EmitDefaultValue=false)]
        public string SignupToken { get; set; }

        /// <summary>
        /// Gets or Sets NumberSeatsAvailable
        /// </summary>
        [DataMember(Name="NumberSeatsAvailable", EmitDefaultValue=false)]
        public int? NumberSeatsAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiOrganisation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AddressLine01: ").Append(AddressLine01).Append("\n");
            sb.Append("  AddressLine02: ").Append(AddressLine02).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  SubscriptionCustomerId: ").Append(SubscriptionCustomerId).Append("\n");
            sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
            sb.Append("  SignupToken: ").Append(SignupToken).Append("\n");
            sb.Append("  NumberSeatsAvailable: ").Append(NumberSeatsAvailable).Append("\n");
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
            return this.Equals(input as CsApiOrganisation);
        }

        /// <summary>
        /// Returns true if CsApiOrganisation instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiOrganisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiOrganisation input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AddressLine01 == input.AddressLine01 ||
                    (this.AddressLine01 != null &&
                    this.AddressLine01.Equals(input.AddressLine01))
                ) && 
                (
                    this.AddressLine02 == input.AddressLine02 ||
                    (this.AddressLine02 != null &&
                    this.AddressLine02.Equals(input.AddressLine02))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.SubscriptionCustomerId == input.SubscriptionCustomerId ||
                    (this.SubscriptionCustomerId != null &&
                    this.SubscriptionCustomerId.Equals(input.SubscriptionCustomerId))
                ) && 
                (
                    this.SubscriptionPlanId == input.SubscriptionPlanId ||
                    (this.SubscriptionPlanId != null &&
                    this.SubscriptionPlanId.Equals(input.SubscriptionPlanId))
                ) && 
                (
                    this.SignupToken == input.SignupToken ||
                    (this.SignupToken != null &&
                    this.SignupToken.Equals(input.SignupToken))
                ) && 
                (
                    this.NumberSeatsAvailable == input.NumberSeatsAvailable ||
                    (this.NumberSeatsAvailable != null &&
                    this.NumberSeatsAvailable.Equals(input.NumberSeatsAvailable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AddressLine01 != null)
                    hashCode = hashCode * 59 + this.AddressLine01.GetHashCode();
                if (this.AddressLine02 != null)
                    hashCode = hashCode * 59 + this.AddressLine02.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.SubscriptionCustomerId != null)
                    hashCode = hashCode * 59 + this.SubscriptionCustomerId.GetHashCode();
                if (this.SubscriptionPlanId != null)
                    hashCode = hashCode * 59 + this.SubscriptionPlanId.GetHashCode();
                if (this.SignupToken != null)
                    hashCode = hashCode * 59 + this.SignupToken.GetHashCode();
                if (this.NumberSeatsAvailable != null)
                    hashCode = hashCode * 59 + this.NumberSeatsAvailable.GetHashCode();
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
