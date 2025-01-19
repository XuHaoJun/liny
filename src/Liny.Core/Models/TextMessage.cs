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
    public partial class TextMessage : Message, IEquatable<TextMessage>
    {
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [Required]
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Emojis
        /// </summary>
        [DataMember(Name="emojis", EmitDefaultValue=false)]
        public List<Emoji> Emojis { get; set; }

        /// <summary>
        /// Quote token of the message you want to quote.
        /// </summary>
        /// <value>Quote token of the message you want to quote.</value>
        [DataMember(Name="quoteToken", EmitDefaultValue=false)]
        public string QuoteToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextMessage {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
            sb.Append("  QuoteToken: ").Append(QuoteToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TextMessage)obj);
        }

        /// <summary>
        /// Returns true if TextMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of TextMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Emojis == other.Emojis ||
                    Emojis != null &&
                    other.Emojis != null &&
                    Emojis.SequenceEqual(other.Emojis)
                ) && 
                (
                    QuoteToken == other.QuoteToken ||
                    QuoteToken != null &&
                    QuoteToken.Equals(other.QuoteToken)
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
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Emojis != null)
                    hashCode = hashCode * 59 + Emojis.GetHashCode();
                    if (QuoteToken != null)
                    hashCode = hashCode * 59 + QuoteToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TextMessage left, TextMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextMessage left, TextMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
