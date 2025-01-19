/*
 * Merged API
 *
 * Merged OpenAPI specification
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using Liny.Core.Converters;

namespace Liny.Core.Models
{ 
    /// <summary>
    /// Get audience data
    /// </summary>
    [DataContract]
    public partial class GetAudienceDataResponse : IEquatable<GetAudienceDataResponse>
    {
        /// <summary>
        /// Gets or Sets AudienceGroup
        /// </summary>
        [DataMember(Name="audienceGroup", EmitDefaultValue=false)]
        public AudienceGroup AudienceGroup { get; set; }

        /// <summary>
        /// An array of jobs. This array is used to keep track of each attempt to add new user IDs or IFAs to an audience for uploading user IDs. Empty array is returned for any other type of audience. Max: 50 
        /// </summary>
        /// <value>An array of jobs. This array is used to keep track of each attempt to add new user IDs or IFAs to an audience for uploading user IDs. Empty array is returned for any other type of audience. Max: 50 </value>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public List<AudienceGroupJob> Jobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAudienceDataResponse {\n");
            sb.Append("  AudienceGroup: ").Append(AudienceGroup).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((GetAudienceDataResponse)obj);
        }

        /// <summary>
        /// Returns true if GetAudienceDataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetAudienceDataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAudienceDataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AudienceGroup == other.AudienceGroup ||
                    AudienceGroup != null &&
                    AudienceGroup.Equals(other.AudienceGroup)
                ) && 
                (
                    Jobs == other.Jobs ||
                    Jobs != null &&
                    other.Jobs != null &&
                    Jobs.SequenceEqual(other.Jobs)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AudienceGroup != null)
                    hashCode = hashCode * 59 + AudienceGroup.GetHashCode();
                    if (Jobs != null)
                    hashCode = hashCode * 59 + Jobs.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetAudienceDataResponse left, GetAudienceDataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetAudienceDataResponse left, GetAudienceDataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
