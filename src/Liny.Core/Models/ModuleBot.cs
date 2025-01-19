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
    /// basic information about the bot.
    /// </summary>
    [DataContract]
    public partial class ModuleBot : IEquatable<ModuleBot>
    {
        /// <summary>
        /// Bot&#39;s user ID
        /// </summary>
        /// <value>Bot&#39;s user ID</value>
        [Required]
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Bot&#39;s basic ID
        /// </summary>
        /// <value>Bot&#39;s basic ID</value>
        [Required]
        [DataMember(Name="basicId", EmitDefaultValue=false)]
        public string BasicId { get; set; }

        /// <summary>
        /// Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set.
        /// </summary>
        /// <value>Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set.</value>
        [DataMember(Name="premiumId", EmitDefaultValue=false)]
        public string PremiumId { get; set; }

        /// <summary>
        /// Bot&#39;s display name
        /// </summary>
        /// <value>Bot&#39;s display name</value>
        [Required]
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Profile image URL. Image URL starting with &#x60;https://&#x60;. Not included in the response if the bot doesn&#39;t have a profile image.
        /// </summary>
        /// <value>Profile image URL. Image URL starting with &#x60;https://&#x60;. Not included in the response if the bot doesn&#39;t have a profile image.</value>
        [DataMember(Name="pictureUrl", EmitDefaultValue=false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModuleBot {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  BasicId: ").Append(BasicId).Append("\n");
            sb.Append("  PremiumId: ").Append(PremiumId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ModuleBot)obj);
        }

        /// <summary>
        /// Returns true if ModuleBot instances are equal
        /// </summary>
        /// <param name="other">Instance of ModuleBot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModuleBot other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    BasicId == other.BasicId ||
                    BasicId != null &&
                    BasicId.Equals(other.BasicId)
                ) && 
                (
                    PremiumId == other.PremiumId ||
                    PremiumId != null &&
                    PremiumId.Equals(other.PremiumId)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    PictureUrl == other.PictureUrl ||
                    PictureUrl != null &&
                    PictureUrl.Equals(other.PictureUrl)
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
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (BasicId != null)
                    hashCode = hashCode * 59 + BasicId.GetHashCode();
                    if (PremiumId != null)
                    hashCode = hashCode * 59 + PremiumId.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (PictureUrl != null)
                    hashCode = hashCode * 59 + PictureUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ModuleBot left, ModuleBot right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ModuleBot left, ModuleBot right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
