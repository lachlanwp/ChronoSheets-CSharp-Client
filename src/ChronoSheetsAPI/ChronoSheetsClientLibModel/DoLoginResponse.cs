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
    /// A Response object containing important information that can be used after the user has logged in
    /// </summary>
    [DataContract]
    public partial class DoLoginResponse :  IEquatable<DoLoginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoLoginResponse" /> class.
        /// </summary>
        /// <param name="cSAuthToken">The ChronoSheets Auth Token.  Use this token for all subsequent requests to the API.  The Auth Token does these things: holds your session and gives you appropraite authorisation to access API endpoints based on your UserRoles.</param>
        /// <param name="loggedInUser">loggedInUser.</param>
        public DoLoginResponse(string cSAuthToken = default(string), ClientSideUser loggedInUser = default(ClientSideUser))
        {
            this.CSAuthToken = cSAuthToken;
            this.LoggedInUser = loggedInUser;
        }
        
        /// <summary>
        /// The ChronoSheets Auth Token.  Use this token for all subsequent requests to the API.  The Auth Token does these things: holds your session and gives you appropraite authorisation to access API endpoints based on your UserRoles
        /// </summary>
        /// <value>The ChronoSheets Auth Token.  Use this token for all subsequent requests to the API.  The Auth Token does these things: holds your session and gives you appropraite authorisation to access API endpoints based on your UserRoles</value>
        [DataMember(Name="CSAuthToken", EmitDefaultValue=false)]
        public string CSAuthToken { get; set; }

        /// <summary>
        /// Gets or Sets LoggedInUser
        /// </summary>
        [DataMember(Name="LoggedInUser", EmitDefaultValue=false)]
        public ClientSideUser LoggedInUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoLoginResponse {\n");
            sb.Append("  CSAuthToken: ").Append(CSAuthToken).Append("\n");
            sb.Append("  LoggedInUser: ").Append(LoggedInUser).Append("\n");
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
            return this.Equals(input as DoLoginResponse);
        }

        /// <summary>
        /// Returns true if DoLoginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DoLoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoLoginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CSAuthToken == input.CSAuthToken ||
                    (this.CSAuthToken != null &&
                    this.CSAuthToken.Equals(input.CSAuthToken))
                ) && 
                (
                    this.LoggedInUser == input.LoggedInUser ||
                    (this.LoggedInUser != null &&
                    this.LoggedInUser.Equals(input.LoggedInUser))
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
                if (this.CSAuthToken != null)
                    hashCode = hashCode * 59 + this.CSAuthToken.GetHashCode();
                if (this.LoggedInUser != null)
                    hashCode = hashCode * 59 + this.LoggedInUser.GetHashCode();
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
