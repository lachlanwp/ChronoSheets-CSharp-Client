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
    /// FleetSummaryReportItem
    /// </summary>
    [DataContract]
    public partial class FleetSummaryReportItem :  IEquatable<FleetSummaryReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetSummaryReportItem" /> class.
        /// </summary>
        /// <param name="totalDistanceMetersFiltered">totalDistanceMetersFiltered.</param>
        /// <param name="totalDistanceMeters">totalDistanceMeters.</param>
        /// <param name="totalRunningCostDollarsFiltered">totalRunningCostDollarsFiltered.</param>
        /// <param name="totalRunningCostDollars">totalRunningCostDollars.</param>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisationId.</param>
        /// <param name="name">name.</param>
        /// <param name="costPerKilometer">costPerKilometer.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="year">year.</param>
        /// <param name="licencePlateNumber">licencePlateNumber.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="permittedEmployees">permittedEmployees.</param>
        public FleetSummaryReportItem(double totalDistanceMetersFiltered = default(double), double totalDistanceMeters = default(double), double totalRunningCostDollarsFiltered = default(double), double totalRunningCostDollars = default(double), int id = default(int), int organisationId = default(int), string name = default(string), double costPerKilometer = default(double), string make = default(string), string model = default(string), string year = default(string), string licencePlateNumber = default(string), bool isDeleted = default(bool), List<int> permittedEmployees = default(List<int>))
        {
            this.TotalDistanceMetersFiltered = totalDistanceMetersFiltered;
            this.TotalDistanceMeters = totalDistanceMeters;
            this.TotalRunningCostDollarsFiltered = totalRunningCostDollarsFiltered;
            this.TotalRunningCostDollars = totalRunningCostDollars;
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Name = name;
            this.CostPerKilometer = costPerKilometer;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.LicencePlateNumber = licencePlateNumber;
            this.IsDeleted = isDeleted;
            this.PermittedEmployees = permittedEmployees;
        }
        
        /// <summary>
        /// Gets or Sets TotalDistanceMetersFiltered
        /// </summary>
        [DataMember(Name="TotalDistanceMetersFiltered", EmitDefaultValue=false)]
        public double TotalDistanceMetersFiltered { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistanceMeters
        /// </summary>
        [DataMember(Name="TotalDistanceMeters", EmitDefaultValue=false)]
        public double TotalDistanceMeters { get; set; }

        /// <summary>
        /// Gets or Sets TotalRunningCostDollarsFiltered
        /// </summary>
        [DataMember(Name="TotalRunningCostDollarsFiltered", EmitDefaultValue=false)]
        public double TotalRunningCostDollarsFiltered { get; set; }

        /// <summary>
        /// Gets or Sets TotalRunningCostDollars
        /// </summary>
        [DataMember(Name="TotalRunningCostDollars", EmitDefaultValue=false)]
        public double TotalRunningCostDollars { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CostPerKilometer
        /// </summary>
        [DataMember(Name="CostPerKilometer", EmitDefaultValue=false)]
        public double CostPerKilometer { get; set; }

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
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets PermittedEmployees
        /// </summary>
        [DataMember(Name="PermittedEmployees", EmitDefaultValue=false)]
        public List<int> PermittedEmployees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FleetSummaryReportItem {\n");
            sb.Append("  TotalDistanceMetersFiltered: ").Append(TotalDistanceMetersFiltered).Append("\n");
            sb.Append("  TotalDistanceMeters: ").Append(TotalDistanceMeters).Append("\n");
            sb.Append("  TotalRunningCostDollarsFiltered: ").Append(TotalRunningCostDollarsFiltered).Append("\n");
            sb.Append("  TotalRunningCostDollars: ").Append(TotalRunningCostDollars).Append("\n");
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
            return this.Equals(input as FleetSummaryReportItem);
        }

        /// <summary>
        /// Returns true if FleetSummaryReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FleetSummaryReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FleetSummaryReportItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalDistanceMetersFiltered == input.TotalDistanceMetersFiltered ||
                    (this.TotalDistanceMetersFiltered != null &&
                    this.TotalDistanceMetersFiltered.Equals(input.TotalDistanceMetersFiltered))
                ) && 
                (
                    this.TotalDistanceMeters == input.TotalDistanceMeters ||
                    (this.TotalDistanceMeters != null &&
                    this.TotalDistanceMeters.Equals(input.TotalDistanceMeters))
                ) && 
                (
                    this.TotalRunningCostDollarsFiltered == input.TotalRunningCostDollarsFiltered ||
                    (this.TotalRunningCostDollarsFiltered != null &&
                    this.TotalRunningCostDollarsFiltered.Equals(input.TotalRunningCostDollarsFiltered))
                ) && 
                (
                    this.TotalRunningCostDollars == input.TotalRunningCostDollars ||
                    (this.TotalRunningCostDollars != null &&
                    this.TotalRunningCostDollars.Equals(input.TotalRunningCostDollars))
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
                    input.PermittedEmployees != null &&
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
                if (this.TotalDistanceMetersFiltered != null)
                    hashCode = hashCode * 59 + this.TotalDistanceMetersFiltered.GetHashCode();
                if (this.TotalDistanceMeters != null)
                    hashCode = hashCode * 59 + this.TotalDistanceMeters.GetHashCode();
                if (this.TotalRunningCostDollarsFiltered != null)
                    hashCode = hashCode * 59 + this.TotalRunningCostDollarsFiltered.GetHashCode();
                if (this.TotalRunningCostDollars != null)
                    hashCode = hashCode * 59 + this.TotalRunningCostDollars.GetHashCode();
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
