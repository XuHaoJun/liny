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
    /// 
    /// </summary>
    [DataContract]
    public partial class RichMenuAliasResponse : IEquatable<RichMenuAliasResponse>
    {
        /// <summary>
        /// Rich menu alias ID.
        /// </summary>
        /// <value>Rich menu alias ID.</value>
        [Required]
        [DataMember(Name="richMenuAliasId", EmitDefaultValue=false)]
        public string RichMenuAliasId { get; set; }

        /// <summary>
        /// The rich menu ID associated with the rich menu alias.
        /// </summary>
        /// <value>The rich menu ID associated with the rich menu alias.</value>
        [Required]
        [DataMember(Name="richMenuId", EmitDefaultValue=false)]
        public string RichMenuId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RichMenuAliasResponse {\n");
            sb.Append("  RichMenuAliasId: ").Append(RichMenuAliasId).Append("\n");
            sb.Append("  RichMenuId: ").Append(RichMenuId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RichMenuAliasResponse)obj);
        }

        /// <summary>
        /// Returns true if RichMenuAliasResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RichMenuAliasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RichMenuAliasResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RichMenuAliasId == other.RichMenuAliasId ||
                    RichMenuAliasId != null &&
                    RichMenuAliasId.Equals(other.RichMenuAliasId)
                ) && 
                (
                    RichMenuId == other.RichMenuId ||
                    RichMenuId != null &&
                    RichMenuId.Equals(other.RichMenuId)
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
                    if (RichMenuAliasId != null)
                    hashCode = hashCode * 59 + RichMenuAliasId.GetHashCode();
                    if (RichMenuId != null)
                    hashCode = hashCode * 59 + RichMenuId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RichMenuAliasResponse left, RichMenuAliasResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RichMenuAliasResponse left, RichMenuAliasResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
