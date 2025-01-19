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
    public partial class FlexBubbleStyles : IEquatable<FlexBubbleStyles>
    {
        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public FlexBlockStyle Header { get; set; }

        /// <summary>
        /// Gets or Sets Hero
        /// </summary>
        [DataMember(Name="hero", EmitDefaultValue=false)]
        public FlexBlockStyle Hero { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public FlexBlockStyle Body { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public FlexBlockStyle Footer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexBubbleStyles {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Hero: ").Append(Hero).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlexBubbleStyles)obj);
        }

        /// <summary>
        /// Returns true if FlexBubbleStyles instances are equal
        /// </summary>
        /// <param name="other">Instance of FlexBubbleStyles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlexBubbleStyles other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Header == other.Header ||
                    Header != null &&
                    Header.Equals(other.Header)
                ) && 
                (
                    Hero == other.Hero ||
                    Hero != null &&
                    Hero.Equals(other.Hero)
                ) && 
                (
                    Body == other.Body ||
                    Body != null &&
                    Body.Equals(other.Body)
                ) && 
                (
                    Footer == other.Footer ||
                    Footer != null &&
                    Footer.Equals(other.Footer)
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
                    if (Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();
                    if (Hero != null)
                    hashCode = hashCode * 59 + Hero.GetHashCode();
                    if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                    if (Footer != null)
                    hashCode = hashCode * 59 + Footer.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FlexBubbleStyles left, FlexBubbleStyles right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlexBubbleStyles left, FlexBubbleStyles right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
