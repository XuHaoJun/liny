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
    public partial class TestWebhookEndpointResponse : IEquatable<TestWebhookEndpointResponse>
    {
        /// <summary>
        /// Result of the communication from the LINE platform to the webhook URL.
        /// </summary>
        /// <value>Result of the communication from the LINE platform to the webhook URL.</value>
        [DataMember(Name="success", EmitDefaultValue=true)]
        public bool Success { get; set; }

        /// <summary>
        /// Time of the event in milliseconds. Even in the case of a redelivered webhook, it represents the time the event occurred, not the time it was redelivered. 
        /// </summary>
        /// <value>Time of the event in milliseconds. Even in the case of a redelivered webhook, it represents the time the event occurred, not the time it was redelivered. </value>
        [Required]
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The HTTP status code. If the webhook response isn&#39;t received, the status code is set to zero or a negative number.
        /// </summary>
        /// <value>The HTTP status code. If the webhook response isn&#39;t received, the status code is set to zero or a negative number.</value>
        [Required]
        [DataMember(Name="statusCode", EmitDefaultValue=true)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Reason for the response.
        /// </summary>
        /// <value>Reason for the response.</value>
        [Required]
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Details of the response.
        /// </summary>
        /// <value>Details of the response.</value>
        [Required]
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestWebhookEndpointResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TestWebhookEndpointResponse)obj);
        }

        /// <summary>
        /// Returns true if TestWebhookEndpointResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TestWebhookEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestWebhookEndpointResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Success == other.Success ||
                    
                    Success.Equals(other.Success)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    StatusCode == other.StatusCode ||
                    
                    StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    Reason == other.Reason ||
                    Reason != null &&
                    Reason.Equals(other.Reason)
                ) && 
                (
                    Detail == other.Detail ||
                    Detail != null &&
                    Detail.Equals(other.Detail)
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
                    
                    hashCode = hashCode * 59 + Success.GetHashCode();
                    
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    
                    hashCode = hashCode * 59 + StatusCode.GetHashCode();
                    if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                    if (Detail != null)
                    hashCode = hashCode * 59 + Detail.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TestWebhookEndpointResponse left, TestWebhookEndpointResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TestWebhookEndpointResponse left, TestWebhookEndpointResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
