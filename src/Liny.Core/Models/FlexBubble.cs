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
    public partial class FlexBubble : FlexContainer, IEquatable<FlexBubble>
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum LtrEnum for ltr
            /// </summary>
            [EnumMember(Value = "ltr")]
            LtrEnum = 1,
            
            /// <summary>
            /// Enum RtlEnum for rtl
            /// </summary>
            [EnumMember(Value = "rtl")]
            RtlEnum = 2
        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=true)]
        public DirectionEnum Direction { get; set; }

        /// <summary>
        /// Gets or Sets Styles
        /// </summary>
        [DataMember(Name="styles", EmitDefaultValue=false)]
        public FlexBubbleStyles Styles { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public FlexBox Header { get; set; }

        /// <summary>
        /// Gets or Sets Hero
        /// </summary>
        [DataMember(Name="hero", EmitDefaultValue=false)]
        public FlexComponent Hero { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public FlexBox Body { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public FlexBox Footer { get; set; }


        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        
        public enum SizeEnum
        {
            
            /// <summary>
            /// Enum NanoEnum for nano
            /// </summary>
            [EnumMember(Value = "nano")]
            NanoEnum = 1,
            
            /// <summary>
            /// Enum MicroEnum for micro
            /// </summary>
            [EnumMember(Value = "micro")]
            MicroEnum = 2,
            
            /// <summary>
            /// Enum DecaEnum for deca
            /// </summary>
            [EnumMember(Value = "deca")]
            DecaEnum = 3,
            
            /// <summary>
            /// Enum HectoEnum for hecto
            /// </summary>
            [EnumMember(Value = "hecto")]
            HectoEnum = 4,
            
            /// <summary>
            /// Enum KiloEnum for kilo
            /// </summary>
            [EnumMember(Value = "kilo")]
            KiloEnum = 5,
            
            /// <summary>
            /// Enum MegaEnum for mega
            /// </summary>
            [EnumMember(Value = "mega")]
            MegaEnum = 6,
            
            /// <summary>
            /// Enum GigaEnum for giga
            /// </summary>
            [EnumMember(Value = "giga")]
            GigaEnum = 7
        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=true)]
        public SizeEnum Size { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public Action Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexBubble {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Styles: ").Append(Styles).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Hero: ").Append(Hero).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlexBubble)obj);
        }

        /// <summary>
        /// Returns true if FlexBubble instances are equal
        /// </summary>
        /// <param name="other">Instance of FlexBubble to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlexBubble other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Direction == other.Direction ||
                    
                    Direction.Equals(other.Direction)
                ) && 
                (
                    Styles == other.Styles ||
                    Styles != null &&
                    Styles.Equals(other.Styles)
                ) && 
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
                ) && 
                (
                    Size == other.Size ||
                    
                    Size.Equals(other.Size)
                ) && 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
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
                    
                    hashCode = hashCode * 59 + Direction.GetHashCode();
                    if (Styles != null)
                    hashCode = hashCode * 59 + Styles.GetHashCode();
                    if (Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();
                    if (Hero != null)
                    hashCode = hashCode * 59 + Hero.GetHashCode();
                    if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                    if (Footer != null)
                    hashCode = hashCode * 59 + Footer.GetHashCode();
                    
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FlexBubble left, FlexBubble right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlexBubble left, FlexBubble right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
