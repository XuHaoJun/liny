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
    public partial class RichMenuBatchProgressResponse : IEquatable<RichMenuBatchProgressResponse>
    {
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [Required]
        [DataMember(Name="phase", EmitDefaultValue=true)]
        public RichMenuBatchProgressPhase Phase { get; set; }

        /// <summary>
        /// The accepted time in milliseconds of the request of batch control the rich menu.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC 
        /// </summary>
        /// <value>The accepted time in milliseconds of the request of batch control the rich menu.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC </value>
        [Required]
        [DataMember(Name="acceptedTime", EmitDefaultValue=true)]
        public DateTime AcceptedTime { get; set; }

        /// <summary>
        /// The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC 
        /// </summary>
        /// <value>The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC </value>
        [DataMember(Name="completedTime", EmitDefaultValue=true)]
        public DateTime CompletedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RichMenuBatchProgressResponse {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  AcceptedTime: ").Append(AcceptedTime).Append("\n");
            sb.Append("  CompletedTime: ").Append(CompletedTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RichMenuBatchProgressResponse)obj);
        }

        /// <summary>
        /// Returns true if RichMenuBatchProgressResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RichMenuBatchProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RichMenuBatchProgressResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Phase == other.Phase ||
                    
                    Phase.Equals(other.Phase)
                ) && 
                (
                    AcceptedTime == other.AcceptedTime ||
                    
                    AcceptedTime.Equals(other.AcceptedTime)
                ) && 
                (
                    CompletedTime == other.CompletedTime ||
                    
                    CompletedTime.Equals(other.CompletedTime)
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
                    
                    hashCode = hashCode * 59 + Phase.GetHashCode();
                    
                    hashCode = hashCode * 59 + AcceptedTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + CompletedTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RichMenuBatchProgressResponse left, RichMenuBatchProgressResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RichMenuBatchProgressResponse left, RichMenuBatchProgressResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
