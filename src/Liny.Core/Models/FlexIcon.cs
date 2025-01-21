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
    public partial class FlexIcon : FlexComponent, IEquatable<FlexIcon>
    {
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [Required]
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets AspectRatio
        /// </summary>
        [DataMember(Name = "aspectRatio", EmitDefaultValue = false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Gets or Sets Margin
        /// </summary>
        [DataMember(Name = "margin", EmitDefaultValue = false)]
        public string Margin { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>

        public enum PositionEnum
        {
            /// <summary>
            /// Enum RelativeEnum for relative
            /// </summary>
            [EnumMember(Value = "relative")]
            RelativeEnum = 1,

            /// <summary>
            /// Enum AbsoluteEnum for absolute
            /// </summary>
            [EnumMember(Value = "absolute")]
            AbsoluteEnum = 2,
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = true)]
        public PositionEnum Position { get; set; }

        /// <summary>
        /// Gets or Sets OffsetTop
        /// </summary>
        [DataMember(Name = "offsetTop", EmitDefaultValue = false)]
        public string OffsetTop { get; set; }

        /// <summary>
        /// Gets or Sets OffsetBottom
        /// </summary>
        [DataMember(Name = "offsetBottom", EmitDefaultValue = false)]
        public string OffsetBottom { get; set; }

        /// <summary>
        /// Gets or Sets OffsetStart
        /// </summary>
        [DataMember(Name = "offsetStart", EmitDefaultValue = false)]
        public string OffsetStart { get; set; }

        /// <summary>
        /// Gets or Sets OffsetEnd
        /// </summary>
        [DataMember(Name = "offsetEnd", EmitDefaultValue = false)]
        public string OffsetEnd { get; set; }

        /// <summary>
        /// Gets or Sets Scaling
        /// </summary>
        [DataMember(Name = "scaling", EmitDefaultValue = true)]
        public bool Scaling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexIcon {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  OffsetTop: ").Append(OffsetTop).Append("\n");
            sb.Append("  OffsetBottom: ").Append(OffsetBottom).Append("\n");
            sb.Append("  OffsetStart: ").Append(OffsetStart).Append("\n");
            sb.Append("  OffsetEnd: ").Append(OffsetEnd).Append("\n");
            sb.Append("  Scaling: ").Append(Scaling).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlexIcon)obj);
        }

        /// <summary>
        /// Returns true if FlexIcon instances are equal
        /// </summary>
        /// <param name="other">Instance of FlexIcon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlexIcon other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Url == other.Url || Url != null && Url.Equals(other.Url))
                && (Size == other.Size || Size != null && Size.Equals(other.Size))
                && (
                    AspectRatio == other.AspectRatio
                    || AspectRatio != null && AspectRatio.Equals(other.AspectRatio)
                )
                && (Margin == other.Margin || Margin != null && Margin.Equals(other.Margin))
                && (Position == other.Position || Position.Equals(other.Position))
                && (
                    OffsetTop == other.OffsetTop
                    || OffsetTop != null && OffsetTop.Equals(other.OffsetTop)
                )
                && (
                    OffsetBottom == other.OffsetBottom
                    || OffsetBottom != null && OffsetBottom.Equals(other.OffsetBottom)
                )
                && (
                    OffsetStart == other.OffsetStart
                    || OffsetStart != null && OffsetStart.Equals(other.OffsetStart)
                )
                && (
                    OffsetEnd == other.OffsetEnd
                    || OffsetEnd != null && OffsetEnd.Equals(other.OffsetEnd)
                )
                && (Scaling == other.Scaling || Scaling.Equals(other.Scaling));
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
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                if (AspectRatio != null)
                    hashCode = hashCode * 59 + AspectRatio.GetHashCode();
                if (Margin != null)
                    hashCode = hashCode * 59 + Margin.GetHashCode();

                hashCode = hashCode * 59 + Position.GetHashCode();
                if (OffsetTop != null)
                    hashCode = hashCode * 59 + OffsetTop.GetHashCode();
                if (OffsetBottom != null)
                    hashCode = hashCode * 59 + OffsetBottom.GetHashCode();
                if (OffsetStart != null)
                    hashCode = hashCode * 59 + OffsetStart.GetHashCode();
                if (OffsetEnd != null)
                    hashCode = hashCode * 59 + OffsetEnd.GetHashCode();

                hashCode = hashCode * 59 + Scaling.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FlexIcon left, FlexIcon right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlexIcon left, FlexIcon right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
