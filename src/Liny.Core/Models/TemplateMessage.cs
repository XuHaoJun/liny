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
    public partial class TemplateMessage : Message, IEquatable<TemplateMessage>
    {
        /// <summary>
        /// Gets or Sets AltText
        /// </summary>
        [Required]
        [DataMember(Name = "altText", EmitDefaultValue = false)]
        public string AltText { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [Required]
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public Template Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateMessage {\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TemplateMessage)obj);
        }

        /// <summary>
        /// Returns true if TemplateMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateMessage other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (AltText == other.AltText || AltText != null && AltText.Equals(other.AltText))
                && (
                    Template == other.Template
                    || Template != null && Template.Equals(other.Template)
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
                if (AltText != null)
                    hashCode = hashCode * 59 + AltText.GetHashCode();
                if (Template != null)
                    hashCode = hashCode * 59 + Template.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TemplateMessage left, TemplateMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemplateMessage left, TemplateMessage right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
