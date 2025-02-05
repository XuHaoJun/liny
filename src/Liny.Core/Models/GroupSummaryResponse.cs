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
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using Liny.Core.Converters;

namespace Liny.Core.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class GroupSummaryResponse : IEquatable<GroupSummaryResponse>
    {
        /// <summary>
        /// Group ID
        /// </summary>
        /// <value>Group ID</value>
        [Required]
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        /// <value>Group name</value>
        [Required]
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Group icon URL. Not included in the response if the user doesn&#39;t set a group profile icon.
        /// </summary>
        /// <value>Group icon URL. Not included in the response if the user doesn&#39;t set a group profile icon.</value>
        [DataMember(Name = "pictureUrl", EmitDefaultValue = false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSummaryResponse {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((GroupSummaryResponse)obj);
        }

        /// <summary>
        /// Returns true if GroupSummaryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSummaryResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (GroupId == other.GroupId || GroupId != null && GroupId.Equals(other.GroupId))
                && (
                    GroupName == other.GroupName
                    || GroupName != null && GroupName.Equals(other.GroupName)
                )
                && (
                    PictureUrl == other.PictureUrl
                    || PictureUrl != null && PictureUrl.Equals(other.PictureUrl)
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
                if (GroupId != null)
                    hashCode = hashCode * 59 + GroupId.GetHashCode();
                if (GroupName != null)
                    hashCode = hashCode * 59 + GroupName.GetHashCode();
                if (PictureUrl != null)
                    hashCode = hashCode * 59 + PictureUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GroupSummaryResponse left, GroupSummaryResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GroupSummaryResponse left, GroupSummaryResponse right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
