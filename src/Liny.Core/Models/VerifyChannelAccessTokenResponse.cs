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
    /// Verification result
    /// </summary>
    [DataContract]
    public partial class VerifyChannelAccessTokenResponse
        : IEquatable<VerifyChannelAccessTokenResponse>
    {
        /// <summary>
        /// The channel ID for which the channel access token was issued.
        /// </summary>
        /// <value>The channel ID for which the channel access token was issued.</value>
        [Required]
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Number of seconds before the channel access token expires.
        /// </summary>
        /// <value>Number of seconds before the channel access token expires.</value>
        [Required]
        [DataMember(Name = "expires_in", EmitDefaultValue = true)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// Permissions granted to the channel access token.
        /// </summary>
        /// <value>Permissions granted to the channel access token.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyChannelAccessTokenResponse {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VerifyChannelAccessTokenResponse)obj);
        }

        /// <summary>
        /// Returns true if VerifyChannelAccessTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of VerifyChannelAccessTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyChannelAccessTokenResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    ClientId == other.ClientId
                    || ClientId != null && ClientId.Equals(other.ClientId)
                )
                && (ExpiresIn == other.ExpiresIn || ExpiresIn.Equals(other.ExpiresIn))
                && (Scope == other.Scope || Scope != null && Scope.Equals(other.Scope));
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
                if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();

                hashCode = hashCode * 59 + ExpiresIn.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            VerifyChannelAccessTokenResponse left,
            VerifyChannelAccessTokenResponse right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            VerifyChannelAccessTokenResponse left,
            VerifyChannelAccessTokenResponse right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
