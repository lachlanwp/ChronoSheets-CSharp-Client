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
    /// CsApiTimeSlot
    /// </summary>
    [DataContract]
    public partial class CsApiTimeSlot :  IEquatable<CsApiTimeSlot>, IValidatableObject
    {
        /// <summary>
        /// 0 &#x3D; Monday, 1 &#x3D; Tuesday, 2 &#x3D; Wednesday, 3 &#x3D; Thursday, 4 &#x3D; Friday, 5 &#x3D; Saturday, 6 &#x3D; Sunday
        /// </summary>
        /// <value>0 &#x3D; Monday, 1 &#x3D; Tuesday, 2 &#x3D; Wednesday, 3 &#x3D; Thursday, 4 &#x3D; Friday, 5 &#x3D; Saturday, 6 &#x3D; Sunday</value>
        public enum DayTypeEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5,
            
            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            
            NUMBER_6 = 6
        }

        /// <summary>
        /// 0 &#x3D; Monday, 1 &#x3D; Tuesday, 2 &#x3D; Wednesday, 3 &#x3D; Thursday, 4 &#x3D; Friday, 5 &#x3D; Saturday, 6 &#x3D; Sunday
        /// </summary>
        /// <value>0 &#x3D; Monday, 1 &#x3D; Tuesday, 2 &#x3D; Wednesday, 3 &#x3D; Thursday, 4 &#x3D; Friday, 5 &#x3D; Saturday, 6 &#x3D; Sunday</value>
        [DataMember(Name="DayType", EmitDefaultValue=false)]
        public DayTypeEnum? DayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiTimeSlot" /> class.
        /// </summary>
        /// <param name="DayType">0 &#x3D; Monday, 1 &#x3D; Tuesday, 2 &#x3D; Wednesday, 3 &#x3D; Thursday, 4 &#x3D; Friday, 5 &#x3D; Saturday, 6 &#x3D; Sunday.</param>
        /// <param name="UsualHourId">UsualHourId.</param>
        /// <param name="StartHour">StartHour.</param>
        /// <param name="StartMinute">StartMinute.</param>
        /// <param name="EndHour">EndHour.</param>
        /// <param name="EndMinute">EndMinute.</param>
        /// <param name="IsValid">IsValid.</param>
        public CsApiTimeSlot(DayTypeEnum? DayType = default(DayTypeEnum?), int? UsualHourId = default(int?), int? StartHour = default(int?), int? StartMinute = default(int?), int? EndHour = default(int?), int? EndMinute = default(int?), bool? IsValid = default(bool?))
        {
            this.DayType = DayType;
            this.UsualHourId = UsualHourId;
            this.StartHour = StartHour;
            this.StartMinute = StartMinute;
            this.EndHour = EndHour;
            this.EndMinute = EndMinute;
            this.IsValid = IsValid;
        }
        

        /// <summary>
        /// Gets or Sets UsualHourId
        /// </summary>
        [DataMember(Name="UsualHourId", EmitDefaultValue=false)]
        public int? UsualHourId { get; set; }

        /// <summary>
        /// Gets or Sets StartHour
        /// </summary>
        [DataMember(Name="StartHour", EmitDefaultValue=false)]
        public int? StartHour { get; set; }

        /// <summary>
        /// Gets or Sets StartMinute
        /// </summary>
        [DataMember(Name="StartMinute", EmitDefaultValue=false)]
        public int? StartMinute { get; set; }

        /// <summary>
        /// Gets or Sets EndHour
        /// </summary>
        [DataMember(Name="EndHour", EmitDefaultValue=false)]
        public int? EndHour { get; set; }

        /// <summary>
        /// Gets or Sets EndMinute
        /// </summary>
        [DataMember(Name="EndMinute", EmitDefaultValue=false)]
        public int? EndMinute { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiTimeSlot {\n");
            sb.Append("  DayType: ").Append(DayType).Append("\n");
            sb.Append("  UsualHourId: ").Append(UsualHourId).Append("\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
            sb.Append("  EndHour: ").Append(EndHour).Append("\n");
            sb.Append("  EndMinute: ").Append(EndMinute).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
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
            return this.Equals(input as CsApiTimeSlot);
        }

        /// <summary>
        /// Returns true if CsApiTimeSlot instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiTimeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiTimeSlot input)
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
                    this.UsualHourId == input.UsualHourId ||
                    (this.UsualHourId != null &&
                    this.UsualHourId.Equals(input.UsualHourId))
                ) && 
                (
                    this.StartHour == input.StartHour ||
                    (this.StartHour != null &&
                    this.StartHour.Equals(input.StartHour))
                ) && 
                (
                    this.StartMinute == input.StartMinute ||
                    (this.StartMinute != null &&
                    this.StartMinute.Equals(input.StartMinute))
                ) && 
                (
                    this.EndHour == input.EndHour ||
                    (this.EndHour != null &&
                    this.EndHour.Equals(input.EndHour))
                ) && 
                (
                    this.EndMinute == input.EndMinute ||
                    (this.EndMinute != null &&
                    this.EndMinute.Equals(input.EndMinute))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
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
                if (this.UsualHourId != null)
                    hashCode = hashCode * 59 + this.UsualHourId.GetHashCode();
                if (this.StartHour != null)
                    hashCode = hashCode * 59 + this.StartHour.GetHashCode();
                if (this.StartMinute != null)
                    hashCode = hashCode * 59 + this.StartMinute.GetHashCode();
                if (this.EndHour != null)
                    hashCode = hashCode * 59 + this.EndHour.GetHashCode();
                if (this.EndMinute != null)
                    hashCode = hashCode * 59 + this.EndMinute.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
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
