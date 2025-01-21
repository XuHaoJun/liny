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
    public partial class VideoMessageContent : MessageContent, IEquatable<VideoMessageContent>
    {
        /// <summary>
        /// Length of video file (milliseconds)
        /// </summary>
        /// <value>Length of video file (milliseconds)</value>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long Duration { get; set; }

        /// <summary>
        /// Gets or Sets ContentProvider
        /// </summary>
        [Required]
        [DataMember(Name = "contentProvider", EmitDefaultValue = false)]
        public ContentProvider ContentProvider { get; set; }

        /// <summary>
        /// Quote token to quote this message.
        /// </summary>
        /// <value>Quote token to quote this message. </value>
        [Required]
        [DataMember(Name = "quoteToken", EmitDefaultValue = false)]
        public string QuoteToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMessageContent {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ContentProvider: ").Append(ContentProvider).Append("\n");
            sb.Append("  QuoteToken: ").Append(QuoteToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VideoMessageContent)obj);
        }

        /// <summary>
        /// Returns true if VideoMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMessageContent other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Duration == other.Duration || Duration.Equals(other.Duration))
                && (
                    ContentProvider == other.ContentProvider
                    || ContentProvider != null && ContentProvider.Equals(other.ContentProvider)
                )
                && (
                    QuoteToken == other.QuoteToken
                    || QuoteToken != null && QuoteToken.Equals(other.QuoteToken)
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

                hashCode = hashCode * 59 + Duration.GetHashCode();
                if (ContentProvider != null)
                    hashCode = hashCode * 59 + ContentProvider.GetHashCode();
                if (QuoteToken != null)
                    hashCode = hashCode * 59 + QuoteToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(VideoMessageContent left, VideoMessageContent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VideoMessageContent left, VideoMessageContent right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
