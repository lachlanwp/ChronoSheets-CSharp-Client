/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    /// Fields for inserting a new Organisation Group
    /// </summary>
    [DataContract]
    public partial class CSInsertOrganisationGroupRequest :  IEquatable<CSInsertOrganisationGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSInsertOrganisationGroupRequest" /> class.
        /// </summary>
        /// <param name="organisationGroupName">The name of the new Organisation Group.  This is used when you&#39;re looking up Organisation Groups elsewhere through ChronoSheets.</param>
        /// <param name="organisationGroupUserIds">The Ids of the Users that are going to be in this Organisation Group.</param>
        public CSInsertOrganisationGroupRequest(string organisationGroupName = default(string), List<int?> organisationGroupUserIds = default(List<int?>))
        {
            this.OrganisationGroupName = organisationGroupName;
            this.OrganisationGroupUserIds = organisationGroupUserIds;
        }
        
        /// <summary>
        /// The name of the new Organisation Group.  This is used when you&#39;re looking up Organisation Groups elsewhere through ChronoSheets
        /// </summary>
        /// <value>The name of the new Organisation Group.  This is used when you&#39;re looking up Organisation Groups elsewhere through ChronoSheets</value>
        [DataMember(Name="OrganisationGroupName", EmitDefaultValue=false)]
        public string OrganisationGroupName { get; set; }

        /// <summary>
        /// The Ids of the Users that are going to be in this Organisation Group
        /// </summary>
        /// <value>The Ids of the Users that are going to be in this Organisation Group</value>
        [DataMember(Name="OrganisationGroupUserIds", EmitDefaultValue=false)]
        public List<int?> OrganisationGroupUserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSInsertOrganisationGroupRequest {\n");
            sb.Append("  OrganisationGroupName: ").Append(OrganisationGroupName).Append("\n");
            sb.Append("  OrganisationGroupUserIds: ").Append(OrganisationGroupUserIds).Append("\n");
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
            return this.Equals(input as CSInsertOrganisationGroupRequest);
        }

        /// <summary>
        /// Returns true if CSInsertOrganisationGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSInsertOrganisationGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSInsertOrganisationGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganisationGroupName == input.OrganisationGroupName ||
                    (this.OrganisationGroupName != null &&
                    this.OrganisationGroupName.Equals(input.OrganisationGroupName))
                ) && 
                (
                    this.OrganisationGroupUserIds == input.OrganisationGroupUserIds ||
                    this.OrganisationGroupUserIds != null &&
                    this.OrganisationGroupUserIds.SequenceEqual(input.OrganisationGroupUserIds)
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
                if (this.OrganisationGroupName != null)
                    hashCode = hashCode * 59 + this.OrganisationGroupName.GetHashCode();
                if (this.OrganisationGroupUserIds != null)
                    hashCode = hashCode * 59 + this.OrganisationGroupUserIds.GetHashCode();
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
