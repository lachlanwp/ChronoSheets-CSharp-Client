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
    /// UsualHoursDay
    /// </summary>
    [DataContract]
    public partial class UsualHoursDay :  IEquatable<UsualHoursDay>, IValidatableObject
    {
        /// <summary>
        /// Specify which day this collection of Roster timeslots is for (Monday-Sunday)
        /// </summary>
        /// <value>Specify which day this collection of Roster timeslots is for (Monday-Sunday)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayTypeEnum
        {
            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 1,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 2,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 3,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 4,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 5,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 6,

            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 7

        }

        /// <summary>
        /// Specify which day this collection of Roster timeslots is for (Monday-Sunday)
        /// </summary>
        /// <value>Specify which day this collection of Roster timeslots is for (Monday-Sunday)</value>
        [DataMember(Name="DayType", EmitDefaultValue=false)]
        public DayTypeEnum? DayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsualHoursDay" /> class.
        /// </summary>
        /// <param name="dayType">Specify which day this collection of Roster timeslots is for (Monday-Sunday).</param>
        /// <param name="timeSlots">A collection of TimeSlots within this day.</param>
        /// <param name="deleteUsualHours">Mark here which existing UsualHours are to be deleted.</param>
        public UsualHoursDay(DayTypeEnum? dayType = default(DayTypeEnum?), List<TimeSlot> timeSlots = default(List<TimeSlot>), List<int> deleteUsualHours = default(List<int>))
        {
            this.DayType = dayType;
            this.TimeSlots = timeSlots;
            this.DeleteUsualHours = deleteUsualHours;
        }
        

        /// <summary>
        /// A collection of TimeSlots within this day
        /// </summary>
        /// <value>A collection of TimeSlots within this day</value>
        [DataMember(Name="TimeSlots", EmitDefaultValue=false)]
        public List<TimeSlot> TimeSlots { get; set; }

        /// <summary>
        /// Mark here which existing UsualHours are to be deleted
        /// </summary>
        /// <value>Mark here which existing UsualHours are to be deleted</value>
        [DataMember(Name="DeleteUsualHours", EmitDefaultValue=false)]
        public List<int> DeleteUsualHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsualHoursDay {\n");
            sb.Append("  DayType: ").Append(DayType).Append("\n");
            sb.Append("  TimeSlots: ").Append(TimeSlots).Append("\n");
            sb.Append("  DeleteUsualHours: ").Append(DeleteUsualHours).Append("\n");
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
            return this.Equals(input as UsualHoursDay);
        }

        /// <summary>
        /// Returns true if UsualHoursDay instances are equal
        /// </summary>
        /// <param name="input">Instance of UsualHoursDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsualHoursDay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayType == input.DayType ||
                    (this.DayType != null &&
                    this.DayType.Equals(input.DayType))
                ) && 
                (
                    this.TimeSlots == input.TimeSlots ||
                    this.TimeSlots != null &&
                    input.TimeSlots != null &&
                    this.TimeSlots.SequenceEqual(input.TimeSlots)
                ) && 
                (
                    this.DeleteUsualHours == input.DeleteUsualHours ||
                    this.DeleteUsualHours != null &&
                    input.DeleteUsualHours != null &&
                    this.DeleteUsualHours.SequenceEqual(input.DeleteUsualHours)
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
                if (this.DayType != null)
                    hashCode = hashCode * 59 + this.DayType.GetHashCode();
                if (this.TimeSlots != null)
                    hashCode = hashCode * 59 + this.TimeSlots.GetHashCode();
                if (this.DeleteUsualHours != null)
                    hashCode = hashCode * 59 + this.DeleteUsualHours.GetHashCode();
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