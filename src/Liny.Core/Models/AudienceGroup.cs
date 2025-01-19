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
    /// Audience group
    /// </summary>
    [DataContract]
    public partial class AudienceGroup : IEquatable<AudienceGroup>
    {
        /// <summary>
        /// The audience ID.
        /// </summary>
        /// <value>The audience ID.</value>
        [DataMember(Name="audienceGroupId", EmitDefaultValue=true)]
        public long AudienceGroupId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public AudienceGroupType Type { get; set; }

        /// <summary>
        /// The audience&#39;s name.
        /// </summary>
        /// <value>The audience&#39;s name.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public AudienceGroupStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets FailedType
        /// </summary>
        [DataMember(Name="failedType", EmitDefaultValue=true)]
        public AudienceGroupFailedType? FailedType { get; set; }

        /// <summary>
        /// The number of users included in the audience.
        /// </summary>
        /// <value>The number of users included in the audience.</value>
        [DataMember(Name="audienceCount", EmitDefaultValue=true)]
        public long AudienceCount { get; set; }

        /// <summary>
        /// When the audience was created (in UNIX time).
        /// </summary>
        /// <value>When the audience was created (in UNIX time).</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public long Created { get; set; }

        /// <summary>
        /// The request ID that was specified when the audience was created. This is only included when &#x60;audienceGroup.type&#x60; is CLICK or IMP. 
        /// </summary>
        /// <value>The request ID that was specified when the audience was created. This is only included when &#x60;audienceGroup.type&#x60; is CLICK or IMP. </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URL that was specified when the audience was created. This is only included when &#x60;audienceGroup.type&#x60; is CLICK and link URL is specified. 
        /// </summary>
        /// <value>The URL that was specified when the audience was created. This is only included when &#x60;audienceGroup.type&#x60; is CLICK and link URL is specified. </value>
        [DataMember(Name="clickUrl", EmitDefaultValue=false)]
        public string ClickUrl { get; set; }

        /// <summary>
        /// The value indicating the type of account to be sent, as specified when creating the audience for uploading user IDs. 
        /// </summary>
        /// <value>The value indicating the type of account to be sent, as specified when creating the audience for uploading user IDs. </value>
        [DataMember(Name="isIfaAudience", EmitDefaultValue=true)]
        public bool IsIfaAudience { get; set; }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=true)]
        public AudienceGroupPermission Permission { get; set; }

        /// <summary>
        /// Gets or Sets CreateRoute
        /// </summary>
        [DataMember(Name="createRoute", EmitDefaultValue=true)]
        public AudienceGroupCreateRoute CreateRoute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceGroup {\n");
            sb.Append("  AudienceGroupId: ").Append(AudienceGroupId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FailedType: ").Append(FailedType).Append("\n");
            sb.Append("  AudienceCount: ").Append(AudienceCount).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ClickUrl: ").Append(ClickUrl).Append("\n");
            sb.Append("  IsIfaAudience: ").Append(IsIfaAudience).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  CreateRoute: ").Append(CreateRoute).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AudienceGroup)obj);
        }

        /// <summary>
        /// Returns true if AudienceGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of AudienceGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceGroup other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AudienceGroupId == other.AudienceGroupId ||
                    
                    AudienceGroupId.Equals(other.AudienceGroupId)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Status == other.Status ||
                    
                    Status.Equals(other.Status)
                ) && 
                (
                    FailedType == other.FailedType ||
                    
                    FailedType.Equals(other.FailedType)
                ) && 
                (
                    AudienceCount == other.AudienceCount ||
                    
                    AudienceCount.Equals(other.AudienceCount)
                ) && 
                (
                    Created == other.Created ||
                    
                    Created.Equals(other.Created)
                ) && 
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) && 
                (
                    ClickUrl == other.ClickUrl ||
                    ClickUrl != null &&
                    ClickUrl.Equals(other.ClickUrl)
                ) && 
                (
                    IsIfaAudience == other.IsIfaAudience ||
                    
                    IsIfaAudience.Equals(other.IsIfaAudience)
                ) && 
                (
                    Permission == other.Permission ||
                    
                    Permission.Equals(other.Permission)
                ) && 
                (
                    CreateRoute == other.CreateRoute ||
                    
                    CreateRoute.Equals(other.CreateRoute)
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
                    
                    hashCode = hashCode * 59 + AudienceGroupId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    
                    hashCode = hashCode * 59 + FailedType.GetHashCode();
                    
                    hashCode = hashCode * 59 + AudienceCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                    if (ClickUrl != null)
                    hashCode = hashCode * 59 + ClickUrl.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsIfaAudience.GetHashCode();
                    
                    hashCode = hashCode * 59 + Permission.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreateRoute.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AudienceGroup left, AudienceGroup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AudienceGroup left, AudienceGroup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
