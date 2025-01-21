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
    /// Statistics about how users interact with narrowcast messages or broadcast messages sent from your LINE Official Account.
    /// </summary>
    [DataContract]
    public partial class GetMessageEventResponse : IEquatable<GetMessageEventResponse>
    {
        /// <summary>
        /// Gets or Sets Overview
        /// </summary>
        [DataMember(Name = "overview", EmitDefaultValue = false)]
        public GetMessageEventResponseOverview Overview { get; set; }

        /// <summary>
        /// Array of information about individual message bubbles.
        /// </summary>
        /// <value>Array of information about individual message bubbles.</value>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<GetMessageEventResponseMessage> Messages { get; set; }

        /// <summary>
        /// Array of information about opened URLs in the message.
        /// </summary>
        /// <value>Array of information about opened URLs in the message.</value>
        [DataMember(Name = "clicks", EmitDefaultValue = false)]
        public List<GetMessageEventResponseClick> Clicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMessageEventResponse {\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetMessageEventResponse)obj);
        }

        /// <summary>
        /// Returns true if GetMessageEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetMessageEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMessageEventResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    Overview == other.Overview
                    || Overview != null && Overview.Equals(other.Overview)
                )
                && (
                    Messages == other.Messages
                    || Messages != null
                        && other.Messages != null
                        && Messages.SequenceEqual(other.Messages)
                )
                && (
                    Clicks == other.Clicks
                    || Clicks != null && other.Clicks != null && Clicks.SequenceEqual(other.Clicks)
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
                if (Overview != null)
                    hashCode = hashCode * 59 + Overview.GetHashCode();
                if (Messages != null)
                    hashCode = hashCode * 59 + Messages.GetHashCode();
                if (Clicks != null)
                    hashCode = hashCode * 59 + Clicks.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetMessageEventResponse left, GetMessageEventResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetMessageEventResponse left, GetMessageEventResponse right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
