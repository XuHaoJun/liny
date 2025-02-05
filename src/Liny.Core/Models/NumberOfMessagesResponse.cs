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
    public partial class NumberOfMessagesResponse : IEquatable<NumberOfMessagesResponse>
    {
        /// <summary>
        /// Aggregation process status. One of:  `ready`: The number of messages can be obtained. `unready`: We haven't finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. `unavailable_for_privacy`: The total number of messages on the specified day is less than 20. `out_of_service`: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018).
        /// </summary>
        /// <value>Aggregation process status. One of:  `ready`: The number of messages can be obtained. `unready`: We haven't finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. `unavailable_for_privacy`: The total number of messages on the specified day is less than 20. `out_of_service`: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). </value>

        public enum StatusEnum
        {
            /// <summary>
            /// Enum ReadyEnum for ready
            /// </summary>
            [EnumMember(Value = "ready")]
            ReadyEnum = 1,

            /// <summary>
            /// Enum UnreadyEnum for unready
            /// </summary>
            [EnumMember(Value = "unready")]
            UnreadyEnum = 2,

            /// <summary>
            /// Enum UnavailableForPrivacyEnum for unavailable_for_privacy
            /// </summary>
            [EnumMember(Value = "unavailable_for_privacy")]
            UnavailableForPrivacyEnum = 3,

            /// <summary>
            /// Enum OutOfServiceEnum for out_of_service
            /// </summary>
            [EnumMember(Value = "out_of_service")]
            OutOfServiceEnum = 4,
        }

        /// <summary>
        /// Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018).
        /// </summary>
        /// <value>Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). </value>
        [Required]
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// The number of messages delivered using the phone number on the date specified in &#x60;date&#x60;. The response has this property only when the value of &#x60;status&#x60; is &#x60;ready&#x60;.
        /// </summary>
        /// <value>The number of messages delivered using the phone number on the date specified in &#x60;date&#x60;. The response has this property only when the value of &#x60;status&#x60; is &#x60;ready&#x60;.  </value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public long Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberOfMessagesResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NumberOfMessagesResponse)obj);
        }

        /// <summary>
        /// Returns true if NumberOfMessagesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberOfMessagesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberOfMessagesResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Status == other.Status || Status.Equals(other.Status))
                && (Success == other.Success || Success.Equals(other.Success));
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

                hashCode = hashCode * 59 + Status.GetHashCode();

                hashCode = hashCode * 59 + Success.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            NumberOfMessagesResponse left,
            NumberOfMessagesResponse right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            NumberOfMessagesResponse left,
            NumberOfMessagesResponse right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
