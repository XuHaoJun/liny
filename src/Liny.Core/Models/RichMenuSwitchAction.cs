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
    public partial class RichMenuSwitchAction : Action, IEquatable<RichMenuSwitchAction>
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [StringLength(300, MinimumLength=0)]
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets RichMenuAliasId
        /// </summary>
        [StringLength(32, MinimumLength=0)]
        [DataMember(Name="richMenuAliasId", EmitDefaultValue=false)]
        public string RichMenuAliasId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RichMenuSwitchAction {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  RichMenuAliasId: ").Append(RichMenuAliasId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RichMenuSwitchAction)obj);
        }

        /// <summary>
        /// Returns true if RichMenuSwitchAction instances are equal
        /// </summary>
        /// <param name="other">Instance of RichMenuSwitchAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RichMenuSwitchAction other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    RichMenuAliasId == other.RichMenuAliasId ||
                    RichMenuAliasId != null &&
                    RichMenuAliasId.Equals(other.RichMenuAliasId)
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
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (RichMenuAliasId != null)
                    hashCode = hashCode * 59 + RichMenuAliasId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RichMenuSwitchAction left, RichMenuSwitchAction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RichMenuSwitchAction left, RichMenuSwitchAction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
