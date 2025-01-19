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
    public partial class ImagemapMessage : Message, IEquatable<ImagemapMessage>
    {
        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [Required]
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets AltText
        /// </summary>
        [Required]
        [DataMember(Name="altText", EmitDefaultValue=false)]
        public string AltText { get; set; }

        /// <summary>
        /// Gets or Sets BaseSize
        /// </summary>
        [Required]
        [DataMember(Name="baseSize", EmitDefaultValue=false)]
        public ImagemapBaseSize BaseSize { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [Required]
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ImagemapAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public ImagemapVideo Video { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImagemapMessage {\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  BaseSize: ").Append(BaseSize).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImagemapMessage)obj);
        }

        /// <summary>
        /// Returns true if ImagemapMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ImagemapMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImagemapMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BaseUrl == other.BaseUrl ||
                    BaseUrl != null &&
                    BaseUrl.Equals(other.BaseUrl)
                ) && 
                (
                    AltText == other.AltText ||
                    AltText != null &&
                    AltText.Equals(other.AltText)
                ) && 
                (
                    BaseSize == other.BaseSize ||
                    BaseSize != null &&
                    BaseSize.Equals(other.BaseSize)
                ) && 
                (
                    Actions == other.Actions ||
                    Actions != null &&
                    other.Actions != null &&
                    Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    Video == other.Video ||
                    Video != null &&
                    Video.Equals(other.Video)
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
                    if (BaseUrl != null)
                    hashCode = hashCode * 59 + BaseUrl.GetHashCode();
                    if (AltText != null)
                    hashCode = hashCode * 59 + AltText.GetHashCode();
                    if (BaseSize != null)
                    hashCode = hashCode * 59 + BaseSize.GetHashCode();
                    if (Actions != null)
                    hashCode = hashCode * 59 + Actions.GetHashCode();
                    if (Video != null)
                    hashCode = hashCode * 59 + Video.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImagemapMessage left, ImagemapMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImagemapMessage left, ImagemapMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
