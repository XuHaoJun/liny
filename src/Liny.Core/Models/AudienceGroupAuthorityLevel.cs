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
        /// authority level
        /// </summary>
        /// <value>authority level</value>
        
        public enum AudienceGroupAuthorityLevel
        {
            
            /// <summary>
            /// Enum PUBLICEnum for PUBLIC
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            PUBLICEnum = 1,
            
            /// <summary>
            /// Enum PRIVATEEnum for PRIVATE
            /// </summary>
            [EnumMember(Value = "PRIVATE")]
            PRIVATEEnum = 2
        }
}
