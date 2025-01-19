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
    /// Provider of the media file.
    /// </summary>
    [DataContract]
    public partial class ContentProvider : IEquatable<ContentProvider>
    {

        /// <summary>
        /// Provider of the image file.
        /// </summary>
        /// <value>Provider of the image file.</value>
        
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum LineEnum for line
            /// </summary>
            [EnumMember(Value = "line")]
            LineEnum = 1,
            
            /// <summary>
            /// Enum ExternalEnum for external
            /// </summary>
            [EnumMember(Value = "external")]
            ExternalEnum = 2
        }

        /// <summary>
        /// Provider of the image file.
        /// </summary>
        /// <value>Provider of the image file.</value>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// URL of the image file. Only included when contentProvider.type is external.
        /// </summary>
        /// <value>URL of the image file. Only included when contentProvider.type is external.</value>
        [DataMember(Name="originalContentUrl", EmitDefaultValue=false)]
        public string OriginalContentUrl { get; set; }

        /// <summary>
        /// URL of the preview image. Only included when contentProvider.type is external.
        /// </summary>
        /// <value>URL of the preview image. Only included when contentProvider.type is external.</value>
        [DataMember(Name="previewImageUrl", EmitDefaultValue=false)]
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentProvider {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OriginalContentUrl: ").Append(OriginalContentUrl).Append("\n");
            sb.Append("  PreviewImageUrl: ").Append(PreviewImageUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ContentProvider)obj);
        }

        /// <summary>
        /// Returns true if ContentProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentProvider other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    OriginalContentUrl == other.OriginalContentUrl ||
                    OriginalContentUrl != null &&
                    OriginalContentUrl.Equals(other.OriginalContentUrl)
                ) && 
                (
                    PreviewImageUrl == other.PreviewImageUrl ||
                    PreviewImageUrl != null &&
                    PreviewImageUrl.Equals(other.PreviewImageUrl)
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
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (OriginalContentUrl != null)
                    hashCode = hashCode * 59 + OriginalContentUrl.GetHashCode();
                    if (PreviewImageUrl != null)
                    hashCode = hashCode * 59 + PreviewImageUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContentProvider left, ContentProvider right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContentProvider left, ContentProvider right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
