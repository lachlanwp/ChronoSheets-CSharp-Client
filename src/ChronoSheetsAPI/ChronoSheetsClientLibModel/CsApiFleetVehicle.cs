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
    /// CsApiFleetVehicle
    /// </summary>
    [DataContract]
    public partial class CsApiFleetVehicle :  IEquatable<CsApiFleetVehicle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiFleetVehicle" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="CostPerKilometer">CostPerKilometer.</param>
        /// <param name="Make">Make.</param>
        /// <param name="Model">Model.</param>
        /// <param name="Year">Year.</param>
        /// <param name="LicencePlateNumber">LicencePlateNumber.</param>
        /// <param name="IsDeleted">IsDeleted.</param>
        /// <param name="PermittedEmployees">PermittedEmployees.</param>
        public CsApiFleetVehicle(int? Id = default(int?), int? OrganisationId = default(int?), string Name = default(string), double? CostPerKilometer = default(double?), string Make = default(string), string Model = default(string), string Year = default(string), string LicencePlateNumber = default(string), bool? IsDeleted = default(bool?), List<int?> PermittedEmployees = default(List<int?>))
        {
            this.Id = Id;
            this.OrganisationId = OrganisationId;
            this.Name = Name;
            this.CostPerKilometer = CostPerKilometer;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.LicencePlateNumber = LicencePlateNumber;
            this.IsDeleted = IsDeleted;
            this.PermittedEmployees = PermittedEmployees;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CostPerKilometer
        /// </summary>
        [DataMember(Name="CostPerKilometer", EmitDefaultValue=false)]
        public double? CostPerKilometer { get; set; }

        /// <summary>
        /// Gets or Sets Make
        /// </summary>
        [DataMember(Name="Make", EmitDefaultValue=false)]
        public string Make { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="Model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="Year", EmitDefaultValue=false)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets LicencePlateNumber
        /// </summary>
        [DataMember(Name="LicencePlateNumber", EmitDefaultValue=false)]
        public string LicencePlateNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets PermittedEmployees
        /// </summary>
        [DataMember(Name="PermittedEmployees", EmitDefaultValue=false)]
        public List<int?> PermittedEmployees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiFleetVehicle {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CostPerKilometer: ").Append(CostPerKilometer).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  LicencePlateNumber: ").Append(LicencePlateNumber).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  PermittedEmployees: ").Append(PermittedEmployees).Append("\n");
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
            return this.Equals(input as CsApiFleetVehicle);
        }

        /// <summary>
        /// Returns true if CsApiFleetVehicle instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiFleetVehicle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiFleetVehicle input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CostPerKilometer == input.CostPerKilometer ||
                    (this.CostPerKilometer != null &&
                    this.CostPerKilometer.Equals(input.CostPerKilometer))
                ) && 
                (
                    this.Make == input.Make ||
                    (this.Make != null &&
                    this.Make.Equals(input.Make))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.LicencePlateNumber == input.LicencePlateNumber ||
                    (this.LicencePlateNumber != null &&
                    this.LicencePlateNumber.Equals(input.LicencePlateNumber))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.PermittedEmployees == input.PermittedEmployees ||
                    this.PermittedEmployees != null &&
                    this.PermittedEmployees.SequenceEqual(input.PermittedEmployees)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CostPerKilometer != null)
                    hashCode = hashCode * 59 + this.CostPerKilometer.GetHashCode();
                if (this.Make != null)
                    hashCode = hashCode * 59 + this.Make.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.LicencePlateNumber != null)
                    hashCode = hashCode * 59 + this.LicencePlateNumber.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.PermittedEmployees != null)
                    hashCode = hashCode * 59 + this.PermittedEmployees.GetHashCode();
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
