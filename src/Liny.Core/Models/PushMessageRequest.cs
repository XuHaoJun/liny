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
    public partial class PushMessageRequest : IEquatable<PushMessageRequest>
    {
        /// <summary>
        /// ID of the receiver.
        /// </summary>
        /// <value>ID of the receiver.</value>
        [Required]
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// List of Message objects.
        /// </summary>
        /// <value>List of Message objects.</value>
        [Required]
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// &#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false.
        /// </summary>
        /// <value>&#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false. </value>
        [DataMember(Name = "notificationDisabled", EmitDefaultValue = true)]
        public bool NotificationDisabled { get; set; } = false;

        /// <summary>
        /// List of aggregation unit name. Case-sensitive. This functions can only be used by corporate users who have submitted the required applications.
        /// </summary>
        /// <value>List of aggregation unit name. Case-sensitive. This functions can only be used by corporate users who have submitted the required applications. </value>
        [DataMember(Name = "customAggregationUnits", EmitDefaultValue = false)]
        public List<string> CustomAggregationUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushMessageRequest {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  NotificationDisabled: ").Append(NotificationDisabled).Append("\n");
            sb.Append("  CustomAggregationUnits: ").Append(CustomAggregationUnits).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PushMessageRequest)obj);
        }

        /// <summary>
        /// Returns true if PushMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PushMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushMessageRequest other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (To == other.To || To != null && To.Equals(other.To))
                && (
                    Messages == other.Messages
                    || Messages != null
                        && other.Messages != null
                        && Messages.SequenceEqual(other.Messages)
                )
                && (
                    NotificationDisabled == other.NotificationDisabled
                    || NotificationDisabled.Equals(other.NotificationDisabled)
                )
                && (
                    CustomAggregationUnits == other.CustomAggregationUnits
                    || CustomAggregationUnits != null
                        && other.CustomAggregationUnits != null
                        && CustomAggregationUnits.SequenceEqual(other.CustomAggregationUnits)
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
                if (To != null)
                    hashCode = hashCode * 59 + To.GetHashCode();
                if (Messages != null)
                    hashCode = hashCode * 59 + Messages.GetHashCode();

                hashCode = hashCode * 59 + NotificationDisabled.GetHashCode();
                if (CustomAggregationUnits != null)
                    hashCode = hashCode * 59 + CustomAggregationUnits.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(PushMessageRequest left, PushMessageRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PushMessageRequest left, PushMessageRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
