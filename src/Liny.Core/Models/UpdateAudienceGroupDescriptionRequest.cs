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
    /// Rename an audience
    /// </summary>
    [DataContract]
    public partial class UpdateAudienceGroupDescriptionRequest
        : IEquatable<UpdateAudienceGroupDescriptionRequest>
    {
        /// <summary>
        /// The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120
        /// </summary>
        /// <value>The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 </value>
        [StringLength(120, MinimumLength = 1)]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAudienceGroupDescriptionRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateAudienceGroupDescriptionRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateAudienceGroupDescriptionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAudienceGroupDescriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAudienceGroupDescriptionRequest other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                Description == other.Description
                || Description != null && Description.Equals(other.Description)
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            UpdateAudienceGroupDescriptionRequest left,
            UpdateAudienceGroupDescriptionRequest right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            UpdateAudienceGroupDescriptionRequest left,
            UpdateAudienceGroupDescriptionRequest right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
