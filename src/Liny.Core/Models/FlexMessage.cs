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
    public partial class FlexMessage : Message, IEquatable<FlexMessage>
    {
        /// <summary>
        /// Gets or Sets AltText
        /// </summary>
        [Required]
        [DataMember(Name="altText", EmitDefaultValue=false)]
        public string AltText { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [Required]
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public FlexContainer Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexMessage {\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlexMessage)obj);
        }

        /// <summary>
        /// Returns true if FlexMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of FlexMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlexMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AltText == other.AltText ||
                    AltText != null &&
                    AltText.Equals(other.AltText)
                ) && 
                (
                    Contents == other.Contents ||
                    Contents != null &&
                    Contents.Equals(other.Contents)
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
                    if (Contents != null)
                    hashCode = hashCode * 59 + Contents.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FlexMessage left, FlexMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlexMessage left, FlexMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
