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
    public partial class FlexText : FlexComponent, IEquatable<FlexText>
    {
        /// <summary>
        /// Gets or Sets Flex
        /// </summary>
        [DataMember(Name="flex", EmitDefaultValue=true)]
        public int Flex { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }


        /// <summary>
        /// Gets or Sets Align
        /// </summary>
        
        public enum AlignEnum
        {
            
            /// <summary>
            /// Enum StartEnum for start
            /// </summary>
            [EnumMember(Value = "start")]
            StartEnum = 1,
            
            /// <summary>
            /// Enum EndEnum for end
            /// </summary>
            [EnumMember(Value = "end")]
            EndEnum = 2,
            
            /// <summary>
            /// Enum CenterEnum for center
            /// </summary>
            [EnumMember(Value = "center")]
            CenterEnum = 3
        }

        /// <summary>
        /// Gets or Sets Align
        /// </summary>
        [DataMember(Name="align", EmitDefaultValue=true)]
        public AlignEnum Align { get; set; }


        /// <summary>
        /// Gets or Sets Gravity
        /// </summary>
        
        public enum GravityEnum
        {
            
            /// <summary>
            /// Enum TopEnum for top
            /// </summary>
            [EnumMember(Value = "top")]
            TopEnum = 1,
            
            /// <summary>
            /// Enum BottomEnum for bottom
            /// </summary>
            [EnumMember(Value = "bottom")]
            BottomEnum = 2,
            
            /// <summary>
            /// Enum CenterEnum for center
            /// </summary>
            [EnumMember(Value = "center")]
            CenterEnum = 3
        }

        /// <summary>
        /// Gets or Sets Gravity
        /// </summary>
        [DataMember(Name="gravity", EmitDefaultValue=true)]
        public GravityEnum Gravity { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }


        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        
        public enum WeightEnum
        {
            
            /// <summary>
            /// Enum RegularEnum for regular
            /// </summary>
            [EnumMember(Value = "regular")]
            RegularEnum = 1,
            
            /// <summary>
            /// Enum BoldEnum for bold
            /// </summary>
            [EnumMember(Value = "bold")]
            BoldEnum = 2
        }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=true)]
        public WeightEnum Weight { get; set; }


        /// <summary>
        /// Gets or Sets Style
        /// </summary>
        
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum NormalEnum for normal
            /// </summary>
            [EnumMember(Value = "normal")]
            NormalEnum = 1,
            
            /// <summary>
            /// Enum ItalicEnum for italic
            /// </summary>
            [EnumMember(Value = "italic")]
            ItalicEnum = 2
        }

        /// <summary>
        /// Gets or Sets Style
        /// </summary>
        [DataMember(Name="style", EmitDefaultValue=true)]
        public StyleEnum Style { get; set; }


        /// <summary>
        /// Gets or Sets Decoration
        /// </summary>
        
        public enum DecorationEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for none
            /// </summary>
            [EnumMember(Value = "none")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum UnderlineEnum for underline
            /// </summary>
            [EnumMember(Value = "underline")]
            UnderlineEnum = 2,
            
            /// <summary>
            /// Enum LineThroughEnum for line-through
            /// </summary>
            [EnumMember(Value = "line-through")]
            LineThroughEnum = 3
        }

        /// <summary>
        /// Gets or Sets Decoration
        /// </summary>
        [DataMember(Name="decoration", EmitDefaultValue=true)]
        public DecorationEnum Decoration { get; set; }

        /// <summary>
        /// Gets or Sets Wrap
        /// </summary>
        [DataMember(Name="wrap", EmitDefaultValue=true)]
        public bool Wrap { get; set; }

        /// <summary>
        /// Gets or Sets LineSpacing
        /// </summary>
        [DataMember(Name="lineSpacing", EmitDefaultValue=false)]
        public string LineSpacing { get; set; }

        /// <summary>
        /// Gets or Sets Margin
        /// </summary>
        [DataMember(Name="margin", EmitDefaultValue=false)]
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
            AbsoluteEnum = 2
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=true)]
        public PositionEnum Position { get; set; }

        /// <summary>
        /// Gets or Sets OffsetTop
        /// </summary>
        [DataMember(Name="offsetTop", EmitDefaultValue=false)]
        public string OffsetTop { get; set; }

        /// <summary>
        /// Gets or Sets OffsetBottom
        /// </summary>
        [DataMember(Name="offsetBottom", EmitDefaultValue=false)]
        public string OffsetBottom { get; set; }

        /// <summary>
        /// Gets or Sets OffsetStart
        /// </summary>
        [DataMember(Name="offsetStart", EmitDefaultValue=false)]
        public string OffsetStart { get; set; }

        /// <summary>
        /// Gets or Sets OffsetEnd
        /// </summary>
        [DataMember(Name="offsetEnd", EmitDefaultValue=false)]
        public string OffsetEnd { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public Action Action { get; set; }

        /// <summary>
        /// Gets or Sets MaxLines
        /// </summary>
        [DataMember(Name="maxLines", EmitDefaultValue=true)]
        public int MaxLines { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public List<FlexSpan> Contents { get; set; }


        /// <summary>
        /// Gets or Sets AdjustMode
        /// </summary>
        
        public enum AdjustModeEnum
        {
            
            /// <summary>
            /// Enum ShrinkToFitEnum for shrink-to-fit
            /// </summary>
            [EnumMember(Value = "shrink-to-fit")]
            ShrinkToFitEnum = 1
        }

        /// <summary>
        /// Gets or Sets AdjustMode
        /// </summary>
        [DataMember(Name="adjustMode", EmitDefaultValue=true)]
        public AdjustModeEnum AdjustMode { get; set; }

        /// <summary>
        /// Gets or Sets Scaling
        /// </summary>
        [DataMember(Name="scaling", EmitDefaultValue=true)]
        public bool Scaling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexText {\n");
            sb.Append("  Flex: ").Append(Flex).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Gravity: ").Append(Gravity).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  Decoration: ").Append(Decoration).Append("\n");
            sb.Append("  Wrap: ").Append(Wrap).Append("\n");
            sb.Append("  LineSpacing: ").Append(LineSpacing).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  OffsetTop: ").Append(OffsetTop).Append("\n");
            sb.Append("  OffsetBottom: ").Append(OffsetBottom).Append("\n");
            sb.Append("  OffsetStart: ").Append(OffsetStart).Append("\n");
            sb.Append("  OffsetEnd: ").Append(OffsetEnd).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  MaxLines: ").Append(MaxLines).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  AdjustMode: ").Append(AdjustMode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlexText)obj);
        }

        /// <summary>
        /// Returns true if FlexText instances are equal
        /// </summary>
        /// <param name="other">Instance of FlexText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlexText other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Flex == other.Flex ||
                    
                    Flex.Equals(other.Flex)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Align == other.Align ||
                    
                    Align.Equals(other.Align)
                ) && 
                (
                    Gravity == other.Gravity ||
                    
                    Gravity.Equals(other.Gravity)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Weight == other.Weight ||
                    
                    Weight.Equals(other.Weight)
                ) && 
                (
                    Style == other.Style ||
                    
                    Style.Equals(other.Style)
                ) && 
                (
                    Decoration == other.Decoration ||
                    
                    Decoration.Equals(other.Decoration)
                ) && 
                (
                    Wrap == other.Wrap ||
                    
                    Wrap.Equals(other.Wrap)
                ) && 
                (
                    LineSpacing == other.LineSpacing ||
                    LineSpacing != null &&
                    LineSpacing.Equals(other.LineSpacing)
                ) && 
                (
                    Margin == other.Margin ||
                    Margin != null &&
                    Margin.Equals(other.Margin)
                ) && 
                (
                    Position == other.Position ||
                    
                    Position.Equals(other.Position)
                ) && 
                (
                    OffsetTop == other.OffsetTop ||
                    OffsetTop != null &&
                    OffsetTop.Equals(other.OffsetTop)
                ) && 
                (
                    OffsetBottom == other.OffsetBottom ||
                    OffsetBottom != null &&
                    OffsetBottom.Equals(other.OffsetBottom)
                ) && 
                (
                    OffsetStart == other.OffsetStart ||
                    OffsetStart != null &&
                    OffsetStart.Equals(other.OffsetStart)
                ) && 
                (
                    OffsetEnd == other.OffsetEnd ||
                    OffsetEnd != null &&
                    OffsetEnd.Equals(other.OffsetEnd)
                ) && 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
                ) && 
                (
                    MaxLines == other.MaxLines ||
                    
                    MaxLines.Equals(other.MaxLines)
                ) && 
                (
                    Contents == other.Contents ||
                    Contents != null &&
                    other.Contents != null &&
                    Contents.SequenceEqual(other.Contents)
                ) && 
                (
                    AdjustMode == other.AdjustMode ||
                    
                    AdjustMode.Equals(other.AdjustMode)
                ) && 
                (
                    Scaling == other.Scaling ||
                    
                    Scaling.Equals(other.Scaling)
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
                    
                    hashCode = hashCode * 59 + Flex.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    
                    hashCode = hashCode * 59 + Align.GetHashCode();
                    
                    hashCode = hashCode * 59 + Gravity.GetHashCode();
                    if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                    
                    hashCode = hashCode * 59 + Weight.GetHashCode();
                    
                    hashCode = hashCode * 59 + Style.GetHashCode();
                    
                    hashCode = hashCode * 59 + Decoration.GetHashCode();
                    
                    hashCode = hashCode * 59 + Wrap.GetHashCode();
                    if (LineSpacing != null)
                    hashCode = hashCode * 59 + LineSpacing.GetHashCode();
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
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    
                    hashCode = hashCode * 59 + MaxLines.GetHashCode();
                    if (Contents != null)
                    hashCode = hashCode * 59 + Contents.GetHashCode();
                    
                    hashCode = hashCode * 59 + AdjustMode.GetHashCode();
                    
                    hashCode = hashCode * 59 + Scaling.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FlexText left, FlexText right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlexText left, FlexText right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
