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
    /// CsApiApiResponseListTimesheet
    /// </summary>
    [DataContract]
    public partial class CsApiApiResponseListTimesheet :  IEquatable<CsApiApiResponseListTimesheet>, IValidatableObject
    {
        /// <summary>
        /// 0 &#x3D; Succeeded, 1 &#x3D; FatalException, 2 &#x3D; GeneralError, 3 &#x3D; ValidationError, 4 &#x3D; UnAuthorized, 5 &#x3D; SessionExpired, 128 &#x3D; TestingABC
        /// </summary>
        /// <value>0 &#x3D; Succeeded, 1 &#x3D; FatalException, 2 &#x3D; GeneralError, 3 &#x3D; ValidationError, 4 &#x3D; UnAuthorized, 5 &#x3D; SessionExpired, 128 &#x3D; TestingABC</value>
        public enum StatusEnum
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
            /// Enum NUMBER_128 for value: 128
            /// </summary>
            
            NUMBER_128 = 128
        }

        /// <summary>
        /// 0 &#x3D; Succeeded, 1 &#x3D; FatalException, 2 &#x3D; GeneralError, 3 &#x3D; ValidationError, 4 &#x3D; UnAuthorized, 5 &#x3D; SessionExpired, 128 &#x3D; TestingABC
        /// </summary>
        /// <value>0 &#x3D; Succeeded, 1 &#x3D; FatalException, 2 &#x3D; GeneralError, 3 &#x3D; ValidationError, 4 &#x3D; UnAuthorized, 5 &#x3D; SessionExpired, 128 &#x3D; TestingABC</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsApiApiResponseListTimesheet" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Status">0 &#x3D; Succeeded, 1 &#x3D; FatalException, 2 &#x3D; GeneralError, 3 &#x3D; ValidationError, 4 &#x3D; UnAuthorized, 5 &#x3D; SessionExpired, 128 &#x3D; TestingABC.</param>
        /// <param name="Message">Message.</param>
        public CsApiApiResponseListTimesheet(List<CsApiTimesheet> Data = default(List<CsApiTimesheet>), StatusEnum? Status = default(StatusEnum?), string Message = default(string))
        {
            this.Data = Data;
            this.Status = Status;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public List<CsApiTimesheet> Data { get; set; }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsApiApiResponseListTimesheet {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CsApiApiResponseListTimesheet);
        }

        /// <summary>
        /// Returns true if CsApiApiResponseListTimesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of CsApiApiResponseListTimesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsApiApiResponseListTimesheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
