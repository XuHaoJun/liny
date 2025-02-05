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
    public partial class GetAggregationUnitNameListResponse
        : IEquatable<GetAggregationUnitNameListResponse>
    {
        /// <summary>
        /// An array of strings indicating the names of aggregation units used this month.
        /// </summary>
        /// <value>An array of strings indicating the names of aggregation units used this month.</value>
        [Required]
        [DataMember(Name = "customAggregationUnits", EmitDefaultValue = false)]
        public List<string> CustomAggregationUnits { get; set; }

        /// <summary>
        /// A continuation token to get the next array of unit names. Returned only when there are remaining aggregation units that weren&#39;t returned in customAggregationUnits in the original request.
        /// </summary>
        /// <value>A continuation token to get the next array of unit names. Returned only when there are remaining aggregation units that weren&#39;t returned in customAggregationUnits in the original request.  </value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAggregationUnitNameListResponse {\n");
            sb.Append("  CustomAggregationUnits: ").Append(CustomAggregationUnits).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetAggregationUnitNameListResponse)obj);
        }

        /// <summary>
        /// Returns true if GetAggregationUnitNameListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetAggregationUnitNameListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAggregationUnitNameListResponse other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    CustomAggregationUnits == other.CustomAggregationUnits
                    || CustomAggregationUnits != null
                        && other.CustomAggregationUnits != null
                        && CustomAggregationUnits.SequenceEqual(other.CustomAggregationUnits)
                ) && (Next == other.Next || Next != null && Next.Equals(other.Next));
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
                if (CustomAggregationUnits != null)
                    hashCode = hashCode * 59 + CustomAggregationUnits.GetHashCode();
                if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            GetAggregationUnitNameListResponse left,
            GetAggregationUnitNameListResponse right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            GetAggregationUnitNameListResponse left,
            GetAggregationUnitNameListResponse right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
