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
    /// Change icon and display name
    /// </summary>
    [DataContract]
    public partial class Sender : IEquatable<Sender>
    {
        /// <summary>
        /// Display name. Certain words such as &#x60;LINE&#x60; may not be used.
        /// </summary>
        /// <value>Display name. Certain words such as &#x60;LINE&#x60; may not be used.</value>
        [MaxLength(20)]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// URL of the image to display as an icon when sending a message
        /// </summary>
        /// <value>URL of the image to display as an icon when sending a message</value>
        [MaxLength(2000)]
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sender {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Sender)obj);
        }

        /// <summary>
        /// Returns true if Sender instances are equal
        /// </summary>
        /// <param name="other">Instance of Sender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sender other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Name == other.Name || Name != null && Name.Equals(other.Name))
                && (IconUrl == other.IconUrl || IconUrl != null && IconUrl.Equals(other.IconUrl));
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (IconUrl != null)
                    hashCode = hashCode * 59 + IconUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Sender left, Sender right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Sender left, Sender right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
