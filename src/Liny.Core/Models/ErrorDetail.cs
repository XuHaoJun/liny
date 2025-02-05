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
    public partial class ErrorDetail : IEquatable<ErrorDetail>
    {
        /// <summary>
        /// Details of the error. Not included in the response under certain situations.
        /// </summary>
        /// <value>Details of the error. Not included in the response under certain situations.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Location of where the error occurred. Returns the JSON field name or query parameter name of the request. Not included in the response under certain situations.
        /// </summary>
        /// <value>Location of where the error occurred. Returns the JSON field name or query parameter name of the request. Not included in the response under certain situations.</value>
        [DataMember(Name = "property", EmitDefaultValue = false)]
        public string Property { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ErrorDetail)obj);
        }

        /// <summary>
        /// Returns true if ErrorDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetail other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Message == other.Message || Message != null && Message.Equals(other.Message))
                && (
                    Property == other.Property
                    || Property != null && Property.Equals(other.Property)
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
                if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                if (Property != null)
                    hashCode = hashCode * 59 + Property.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(ErrorDetail left, ErrorDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ErrorDetail left, ErrorDetail right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
