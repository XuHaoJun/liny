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
    public partial class FollowDetail : IEquatable<FollowDetail>
    {
        /// <summary>
        /// Whether a user has added your LINE Official Account as a friend or unblocked.
        /// </summary>
        /// <value>Whether a user has added your LINE Official Account as a friend or unblocked.</value>
        [Required]
        [DataMember(Name = "isUnblocked", EmitDefaultValue = true)]
        public bool IsUnblocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FollowDetail {\n");
            sb.Append("  IsUnblocked: ").Append(IsUnblocked).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FollowDetail)obj);
        }

        /// <summary>
        /// Returns true if FollowDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of FollowDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FollowDetail other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (IsUnblocked == other.IsUnblocked || IsUnblocked.Equals(other.IsUnblocked));
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

                hashCode = hashCode * 59 + IsUnblocked.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FollowDetail left, FollowDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FollowDetail left, FollowDetail right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
