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
        /// Job status
        /// </summary>
        /// <value>Job status</value>
        
        public enum AudienceGroupJobStatus
        {
            
            /// <summary>
            /// Enum QUEUEDEnum for QUEUED
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUEDEnum = 1,
            
            /// <summary>
            /// Enum WORKINGEnum for WORKING
            /// </summary>
            [EnumMember(Value = "WORKING")]
            WORKINGEnum = 2,
            
            /// <summary>
            /// Enum FINISHEDEnum for FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHEDEnum = 3,
            
            /// <summary>
            /// Enum FAILEDEnum for FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILEDEnum = 4
        }
}
