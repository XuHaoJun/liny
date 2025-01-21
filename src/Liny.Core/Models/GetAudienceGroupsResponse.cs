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
    /// Gets data for more than one audience.
    /// </summary>
    [DataContract]
    public partial class GetAudienceGroupsResponse : IEquatable<GetAudienceGroupsResponse>
    {
        /// <summary>
        /// An array of audience data. If there are no audiences that match the specified filter, an empty array will be returned.
        /// </summary>
        /// <value>An array of audience data. If there are no audiences that match the specified filter, an empty array will be returned.</value>
        [DataMember(Name = "audienceGroups", EmitDefaultValue = false)]
        public List<AudienceGroup> AudienceGroups { get; set; }

        /// <summary>
        /// true when this is not the last page.
        /// </summary>
        /// <value>true when this is not the last page.</value>
        [DataMember(Name = "hasNextPage", EmitDefaultValue = true)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// The total number of audiences that can be returned with the specified filter.
        /// </summary>
        /// <value>The total number of audiences that can be returned with the specified filter.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = true)]
        public long TotalCount { get; set; }

        /// <summary>
        /// Of the audiences you can get with the specified filter, the number of audiences with the update permission set to READ_WRITE.
        /// </summary>
        /// <value>Of the audiences you can get with the specified filter, the number of audiences with the update permission set to READ_WRITE.</value>
        [DataMember(Name = "readWriteAudienceGroupTotalCount", EmitDefaultValue = true)]
        public long ReadWriteAudienceGroupTotalCount { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        /// <value>The current page number.</value>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public long Page { get; set; }

        /// <summary>
        /// The maximum number of audiences on the current page.
        /// </summary>
        /// <value>The maximum number of audiences on the current page.</value>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public long Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAudienceGroupsResponse {\n");
            sb.Append("  AudienceGroups: ").Append(AudienceGroups).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  ReadWriteAudienceGroupTotalCount: ")
                .Append(ReadWriteAudienceGroupTotalCount)
                .Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetAudienceGroupsResponse)obj);
        }

        /// <summary>
        /// Returns true if GetAudienceGroupsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetAudienceGroupsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAudienceGroupsResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    AudienceGroups == other.AudienceGroups
                    || AudienceGroups != null
                        && other.AudienceGroups != null
                        && AudienceGroups.SequenceEqual(other.AudienceGroups)
                )
                && (HasNextPage == other.HasNextPage || HasNextPage.Equals(other.HasNextPage))
                && (TotalCount == other.TotalCount || TotalCount.Equals(other.TotalCount))
                && (
                    ReadWriteAudienceGroupTotalCount == other.ReadWriteAudienceGroupTotalCount
                    || ReadWriteAudienceGroupTotalCount.Equals(
                        other.ReadWriteAudienceGroupTotalCount
                    )
                )
                && (Page == other.Page || Page.Equals(other.Page))
                && (Size == other.Size || Size.Equals(other.Size));
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
                if (AudienceGroups != null)
                    hashCode = hashCode * 59 + AudienceGroups.GetHashCode();

                hashCode = hashCode * 59 + HasNextPage.GetHashCode();

                hashCode = hashCode * 59 + TotalCount.GetHashCode();

                hashCode = hashCode * 59 + ReadWriteAudienceGroupTotalCount.GetHashCode();

                hashCode = hashCode * 59 + Page.GetHashCode();

                hashCode = hashCode * 59 + Size.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            GetAudienceGroupsResponse left,
            GetAudienceGroupsResponse right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            GetAudienceGroupsResponse left,
            GetAudienceGroupsResponse right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
