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
    public partial class TextMessageContent : MessageContent, IEquatable<TextMessageContent>
    {
        /// <summary>
        /// Message text.
        /// </summary>
        /// <value>Message text.</value>
        [Required]
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Array of one or more LINE emoji objects. Only included in the message event when the text property contains a LINE emoji.
        /// </summary>
        /// <value>Array of one or more LINE emoji objects. Only included in the message event when the text property contains a LINE emoji.</value>
        [DataMember(Name = "emojis", EmitDefaultValue = false)]
        public List<Emoji> Emojis { get; set; }

        /// <summary>
        /// Gets or Sets Mention
        /// </summary>
        [DataMember(Name = "mention", EmitDefaultValue = false)]
        public Mention Mention { get; set; }

        /// <summary>
        /// Quote token to quote this message.
        /// </summary>
        /// <value>Quote token to quote this message. </value>
        [Required]
        [DataMember(Name = "quoteToken", EmitDefaultValue = false)]
        public string QuoteToken { get; set; }

        /// <summary>
        /// Message ID of a quoted message. Only included when the received message quotes a past message.
        /// </summary>
        /// <value>Message ID of a quoted message. Only included when the received message quotes a past message.</value>
        [DataMember(Name = "quotedMessageId", EmitDefaultValue = false)]
        public string QuotedMessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextMessageContent {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
            sb.Append("  Mention: ").Append(Mention).Append("\n");
            sb.Append("  QuoteToken: ").Append(QuoteToken).Append("\n");
            sb.Append("  QuotedMessageId: ").Append(QuotedMessageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((TextMessageContent)obj);
        }

        /// <summary>
        /// Returns true if TextMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of TextMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextMessageContent other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Text == other.Text || Text != null && Text.Equals(other.Text))
                && (
                    Emojis == other.Emojis
                    || Emojis != null && other.Emojis != null && Emojis.SequenceEqual(other.Emojis)
                )
                && (Mention == other.Mention || Mention != null && Mention.Equals(other.Mention))
                && (
                    QuoteToken == other.QuoteToken
                    || QuoteToken != null && QuoteToken.Equals(other.QuoteToken)
                )
                && (
                    QuotedMessageId == other.QuotedMessageId
                    || QuotedMessageId != null && QuotedMessageId.Equals(other.QuotedMessageId)
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
                if (Mention != null)
                    hashCode = hashCode * 59 + Mention.GetHashCode();
                if (QuoteToken != null)
                    hashCode = hashCode * 59 + QuoteToken.GetHashCode();
                if (QuotedMessageId != null)
                    hashCode = hashCode * 59 + QuotedMessageId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TextMessageContent left, TextMessageContent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextMessageContent left, TextMessageContent right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
