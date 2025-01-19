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
    /// Event object for when a user leaves a group chat or multi-person chat that the LINE Official Account is in.
    /// </summary>
    [DataContract]
    public partial class MemberLeftEvent : Event, IEquatable<MemberLeftEvent>
    {
        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [Required]
        [DataMember(Name="left", EmitDefaultValue=false)]
        public LeftMembers Left { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberLeftEvent {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((MemberLeftEvent)obj);
        }

        /// <summary>
        /// Returns true if MemberLeftEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of MemberLeftEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberLeftEvent other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Left == other.Left ||
                    Left != null &&
                    Left.Equals(other.Left)
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
                    if (Left != null)
                    hashCode = hashCode * 59 + Left.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MemberLeftEvent left, MemberLeftEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MemberLeftEvent left, MemberLeftEvent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
