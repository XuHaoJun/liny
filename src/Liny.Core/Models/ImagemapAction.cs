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
using JsonSubTypes;
using Liny.Core.Converters;
using Swashbuckle.AspNetCore.Annotations;

namespace Liny.Core.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    [SwaggerDiscriminator("Type")]
    [JsonSubtypes.KnownSubType(typeof(ClipboardImagemapAction), "clipboard")]
    [SwaggerSubType(typeof(ClipboardImagemapAction), DiscriminatorValue = "clipboard")]
    [JsonSubtypes.KnownSubType(typeof(MessageImagemapAction), "message")]
    [SwaggerSubType(typeof(MessageImagemapAction), DiscriminatorValue = "message")]
    [JsonSubtypes.KnownSubType(typeof(URIImagemapAction), "uri")]
    [SwaggerSubType(typeof(URIImagemapAction), DiscriminatorValue = "uri")]
    public partial class ImagemapAction : IEquatable<ImagemapAction>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [Required]
        [DataMember(Name = "area", EmitDefaultValue = false)]
        public ImagemapArea Area { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImagemapAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImagemapAction)obj);
        }

        /// <summary>
        /// Returns true if ImagemapAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ImagemapAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImagemapAction other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Type == other.Type || Type != null && Type.Equals(other.Type))
                && (Area == other.Area || Area != null && Area.Equals(other.Area));
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
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Area != null)
                    hashCode = hashCode * 59 + Area.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(ImagemapAction left, ImagemapAction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImagemapAction left, ImagemapAction right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
