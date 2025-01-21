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
    public partial class AddLiffAppResponse : IEquatable<AddLiffAppResponse>
    {
        /// <summary>
        /// Gets or Sets LiffId
        /// </summary>
        [Required]
        [DataMember(Name = "liffId", EmitDefaultValue = false)]
        public string LiffId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddLiffAppResponse {\n");
            sb.Append("  LiffId: ").Append(LiffId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AddLiffAppResponse)obj);
        }

        /// <summary>
        /// Returns true if AddLiffAppResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AddLiffAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLiffAppResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (LiffId == other.LiffId || LiffId != null && LiffId.Equals(other.LiffId));
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
                if (LiffId != null)
                    hashCode = hashCode * 59 + LiffId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(AddLiffAppResponse left, AddLiffAppResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AddLiffAppResponse left, AddLiffAppResponse right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
