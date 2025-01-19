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
        /// Gets or Sets SubscriptionPeriodDemographic
        /// </summary>
        
        public enum SubscriptionPeriodDemographic
        {
            
            /// <summary>
            /// Enum _7Enum for day_7
            /// </summary>
            [EnumMember(Value = "day_7")]
            _7Enum = 1,
            
            /// <summary>
            /// Enum _30Enum for day_30
            /// </summary>
            [EnumMember(Value = "day_30")]
            _30Enum = 2,
            
            /// <summary>
            /// Enum _90Enum for day_90
            /// </summary>
            [EnumMember(Value = "day_90")]
            _90Enum = 3,
            
            /// <summary>
            /// Enum _180Enum for day_180
            /// </summary>
            [EnumMember(Value = "day_180")]
            _180Enum = 4,
            
            /// <summary>
            /// Enum _365Enum for day_365
            /// </summary>
            [EnumMember(Value = "day_365")]
            _365Enum = 5
        }
}
