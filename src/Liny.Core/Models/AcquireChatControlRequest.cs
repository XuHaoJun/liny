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
    /// Request entity of the Acquire Control API
    /// </summary>
    [DataContract]
    public partial class AcquireChatControlRequest : IEquatable<AcquireChatControlRequest>
    {
        /// <summary>
        /// &#x60;True&#x60;: After the time limit (ttl) has passed, the initiative (Chat Control) will return to the Primary Channel. (Default) &#x60;False&#x60;: There&#39;s no time limit and the initiative (Chat Control) doesn&#39;t change over time.
        /// </summary>
        /// <value>&#x60;True&#x60;: After the time limit (ttl) has passed, the initiative (Chat Control) will return to the Primary Channel. (Default) &#x60;False&#x60;: There&#39;s no time limit and the initiative (Chat Control) doesn&#39;t change over time. </value>
        /* <example>true</example> */
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        public bool Expired { get; set; }

        /// <summary>
        /// The time it takes for initiative (Chat Control) to return to the Primary Channel (the time that the module channel stays on the Active Channel). The value is specified in seconds. The maximum value is one year (3600 * 24 * 365). The default value is 3600 (1 hour).  * Ignored if the value of expired is false.
        /// </summary>
        /// <value>The time it takes for initiative (Chat Control) to return to the Primary Channel (the time that the module channel stays on the Active Channel). The value is specified in seconds. The maximum value is one year (3600 * 24 * 365). The default value is 3600 (1 hour).  * Ignored if the value of expired is false. </value>
        /* <example>3600</example> */
        [DataMember(Name = "ttl", EmitDefaultValue = true)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquireChatControlRequest {\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AcquireChatControlRequest)obj);
        }

        /// <summary>
        /// Returns true if AcquireChatControlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AcquireChatControlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquireChatControlRequest other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Expired == other.Expired || Expired.Equals(other.Expired))
                && (Ttl == other.Ttl || Ttl.Equals(other.Ttl));
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

                hashCode = hashCode * 59 + Expired.GetHashCode();

                hashCode = hashCode * 59 + Ttl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            AcquireChatControlRequest left,
            AcquireChatControlRequest right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            AcquireChatControlRequest left,
            AcquireChatControlRequest right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
