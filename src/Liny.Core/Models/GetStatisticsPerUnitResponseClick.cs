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
    public partial class GetStatisticsPerUnitResponseClick
        : IEquatable<GetStatisticsPerUnitResponseClick>
    {
        /// <summary>
        /// The URL&#39;s serial number.
        /// </summary>
        /// <value>The URL&#39;s serial number.</value>
        [Required]
        [DataMember(Name = "seq", EmitDefaultValue = true)]
        public long Seq { get; set; }

        /// <summary>
        /// URL.
        /// </summary>
        /// <value>URL.</value>
        [Required]
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Number of times the URL in the bubble was opened.
        /// </summary>
        /// <value>Number of times the URL in the bubble was opened.</value>
        [DataMember(Name = "click", EmitDefaultValue = true)]
        public long? Click { get; set; }

        /// <summary>
        /// Number of users that opened the URL in the bubble.
        /// </summary>
        /// <value>Number of users that opened the URL in the bubble.</value>
        [DataMember(Name = "uniqueClick", EmitDefaultValue = true)]
        public long? UniqueClick { get; set; }

        /// <summary>
        /// Number of users who opened this url through any link in the message. If another message bubble contains the same URL and a user opens both links, it&#39;s counted only once.
        /// </summary>
        /// <value>Number of users who opened this url through any link in the message. If another message bubble contains the same URL and a user opens both links, it&#39;s counted only once. </value>
        [DataMember(Name = "uniqueClickOfRequest", EmitDefaultValue = true)]
        public long? UniqueClickOfRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatisticsPerUnitResponseClick {\n");
            sb.Append("  Seq: ").Append(Seq).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Click: ").Append(Click).Append("\n");
            sb.Append("  UniqueClick: ").Append(UniqueClick).Append("\n");
            sb.Append("  UniqueClickOfRequest: ").Append(UniqueClickOfRequest).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetStatisticsPerUnitResponseClick)obj);
        }

        /// <summary>
        /// Returns true if GetStatisticsPerUnitResponseClick instances are equal
        /// </summary>
        /// <param name="other">Instance of GetStatisticsPerUnitResponseClick to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticsPerUnitResponseClick other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Seq == other.Seq || Seq.Equals(other.Seq))
                && (Url == other.Url || Url != null && Url.Equals(other.Url))
                && (Click == other.Click || Click != null && Click.Equals(other.Click))
                && (
                    UniqueClick == other.UniqueClick
                    || UniqueClick != null && UniqueClick.Equals(other.UniqueClick)
                )
                && (
                    UniqueClickOfRequest == other.UniqueClickOfRequest
                    || UniqueClickOfRequest != null
                        && UniqueClickOfRequest.Equals(other.UniqueClickOfRequest)
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

                hashCode = hashCode * 59 + Seq.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Click != null)
                    hashCode = hashCode * 59 + Click.GetHashCode();
                if (UniqueClick != null)
                    hashCode = hashCode * 59 + UniqueClick.GetHashCode();
                if (UniqueClickOfRequest != null)
                    hashCode = hashCode * 59 + UniqueClickOfRequest.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            GetStatisticsPerUnitResponseClick left,
            GetStatisticsPerUnitResponseClick right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            GetStatisticsPerUnitResponseClick left,
            GetStatisticsPerUnitResponseClick right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
