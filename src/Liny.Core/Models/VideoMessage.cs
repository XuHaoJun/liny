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
    public partial class VideoMessage : Message, IEquatable<VideoMessage>
    {
        /// <summary>
        /// Gets or Sets OriginalContentUrl
        /// </summary>
        [Required]
        [DataMember(Name="originalContentUrl", EmitDefaultValue=false)]
        public string OriginalContentUrl { get; set; }

        /// <summary>
        /// Gets or Sets PreviewImageUrl
        /// </summary>
        [Required]
        [DataMember(Name="previewImageUrl", EmitDefaultValue=false)]
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name="trackingId", EmitDefaultValue=false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMessage {\n");
            sb.Append("  OriginalContentUrl: ").Append(OriginalContentUrl).Append("\n");
            sb.Append("  PreviewImageUrl: ").Append(PreviewImageUrl).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VideoMessage)obj);
        }

        /// <summary>
        /// Returns true if VideoMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OriginalContentUrl == other.OriginalContentUrl ||
                    OriginalContentUrl != null &&
                    OriginalContentUrl.Equals(other.OriginalContentUrl)
                ) && 
                (
                    PreviewImageUrl == other.PreviewImageUrl ||
                    PreviewImageUrl != null &&
                    PreviewImageUrl.Equals(other.PreviewImageUrl)
                ) && 
                (
                    TrackingId == other.TrackingId ||
                    TrackingId != null &&
                    TrackingId.Equals(other.TrackingId)
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
                    if (OriginalContentUrl != null)
                    hashCode = hashCode * 59 + OriginalContentUrl.GetHashCode();
                    if (PreviewImageUrl != null)
                    hashCode = hashCode * 59 + PreviewImageUrl.GetHashCode();
                    if (TrackingId != null)
                    hashCode = hashCode * 59 + TrackingId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VideoMessage left, VideoMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VideoMessage left, VideoMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
