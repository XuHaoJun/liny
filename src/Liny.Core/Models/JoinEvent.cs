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
    /// Event object for when your LINE Official Account joins a group chat or multi-person chat. You can reply to join events.
    /// </summary>
    [DataContract]
    public partial class JoinEvent : Event, IEquatable<JoinEvent>
    {
        /// <summary>
        /// Reply token used to send reply message to this event
        /// </summary>
        /// <value>Reply token used to send reply message to this event</value>
        [Required]
        [DataMember(Name="replyToken", EmitDefaultValue=false)]
        public string ReplyToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinEvent {\n");
            sb.Append("  ReplyToken: ").Append(ReplyToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((JoinEvent)obj);
        }

        /// <summary>
        /// Returns true if JoinEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of JoinEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinEvent other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ReplyToken == other.ReplyToken ||
                    ReplyToken != null &&
                    ReplyToken.Equals(other.ReplyToken)
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
                    if (ReplyToken != null)
                    hashCode = hashCode * 59 + ReplyToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JoinEvent left, JoinEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JoinEvent left, JoinEvent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
