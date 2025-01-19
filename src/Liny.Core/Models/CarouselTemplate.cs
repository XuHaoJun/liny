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
    public partial class CarouselTemplate : Template, IEquatable<CarouselTemplate>
    {
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [Required]
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<CarouselColumn> Columns { get; set; }

        /// <summary>
        /// Gets or Sets ImageAspectRatio
        /// </summary>
        [DataMember(Name="imageAspectRatio", EmitDefaultValue=false)]
        public string ImageAspectRatio { get; set; }

        /// <summary>
        /// Gets or Sets ImageSize
        /// </summary>
        [DataMember(Name="imageSize", EmitDefaultValue=false)]
        public string ImageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarouselTemplate {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  ImageAspectRatio: ").Append(ImageAspectRatio).Append("\n");
            sb.Append("  ImageSize: ").Append(ImageSize).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CarouselTemplate)obj);
        }

        /// <summary>
        /// Returns true if CarouselTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of CarouselTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarouselTemplate other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Columns == other.Columns ||
                    Columns != null &&
                    other.Columns != null &&
                    Columns.SequenceEqual(other.Columns)
                ) && 
                (
                    ImageAspectRatio == other.ImageAspectRatio ||
                    ImageAspectRatio != null &&
                    ImageAspectRatio.Equals(other.ImageAspectRatio)
                ) && 
                (
                    ImageSize == other.ImageSize ||
                    ImageSize != null &&
                    ImageSize.Equals(other.ImageSize)
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
                    if (Columns != null)
                    hashCode = hashCode * 59 + Columns.GetHashCode();
                    if (ImageAspectRatio != null)
                    hashCode = hashCode * 59 + ImageAspectRatio.GetHashCode();
                    if (ImageSize != null)
                    hashCode = hashCode * 59 + ImageSize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CarouselTemplate left, CarouselTemplate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CarouselTemplate left, CarouselTemplate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
