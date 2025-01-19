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
    public partial class LiffApp : IEquatable<LiffApp>
    {
        /// <summary>
        /// LIFF app ID
        /// </summary>
        /// <value>LIFF app ID</value>
        [DataMember(Name="liffId", EmitDefaultValue=false)]
        public string LiffId { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public LiffView View { get; set; }

        /// <summary>
        /// Name of the LIFF app
        /// </summary>
        /// <value>Name of the LIFF app</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public LiffFeatures Features { get; set; }

        /// <summary>
        /// How additional information in LIFF URLs is handled. concat is returned. 
        /// </summary>
        /// <value>How additional information in LIFF URLs is handled. concat is returned. </value>
        [DataMember(Name="permanentLinkPattern", EmitDefaultValue=false)]
        public string PermanentLinkPattern { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<LiffScope> Scope { get; set; }

        /// <summary>
        /// Gets or Sets BotPrompt
        /// </summary>
        [DataMember(Name="botPrompt", EmitDefaultValue=true)]
        public LiffBotPrompt BotPrompt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiffApp {\n");
            sb.Append("  LiffId: ").Append(LiffId).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  PermanentLinkPattern: ").Append(PermanentLinkPattern).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  BotPrompt: ").Append(BotPrompt).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LiffApp)obj);
        }

        /// <summary>
        /// Returns true if LiffApp instances are equal
        /// </summary>
        /// <param name="other">Instance of LiffApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiffApp other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LiffId == other.LiffId ||
                    LiffId != null &&
                    LiffId.Equals(other.LiffId)
                ) && 
                (
                    View == other.View ||
                    View != null &&
                    View.Equals(other.View)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Features == other.Features ||
                    Features != null &&
                    Features.Equals(other.Features)
                ) && 
                (
                    PermanentLinkPattern == other.PermanentLinkPattern ||
                    PermanentLinkPattern != null &&
                    PermanentLinkPattern.Equals(other.PermanentLinkPattern)
                ) && 
                (
                    Scope == other.Scope ||
                    Scope != null &&
                    other.Scope != null &&
                    Scope.SequenceEqual(other.Scope)
                ) && 
                (
                    BotPrompt == other.BotPrompt ||
                    
                    BotPrompt.Equals(other.BotPrompt)
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
                    if (LiffId != null)
                    hashCode = hashCode * 59 + LiffId.GetHashCode();
                    if (View != null)
                    hashCode = hashCode * 59 + View.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Features != null)
                    hashCode = hashCode * 59 + Features.GetHashCode();
                    if (PermanentLinkPattern != null)
                    hashCode = hashCode * 59 + PermanentLinkPattern.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                    
                    hashCode = hashCode * 59 + BotPrompt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LiffApp left, LiffApp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LiffApp left, LiffApp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
