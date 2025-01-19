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
        /// Width of box border. This is only for `borderWidth` in FlexBox. A value of none means that borders are not rendered; the other values are listed in order of increasing width. 
        /// </summary>
        /// <value>Width of box border. This is only for `borderWidth` in FlexBox. A value of none means that borders are not rendered; the other values are listed in order of increasing width. </value>
        
        public enum FlexBoxBorderWidth
        {
            
            /// <summary>
            /// Enum NoneEnum for none
            /// </summary>
            [EnumMember(Value = "none")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum LightEnum for light
            /// </summary>
            [EnumMember(Value = "light")]
            LightEnum = 2,
            
            /// <summary>
            /// Enum NormalEnum for normal
            /// </summary>
            [EnumMember(Value = "normal")]
            NormalEnum = 3,
            
            /// <summary>
            /// Enum MediumEnum for medium
            /// </summary>
            [EnumMember(Value = "medium")]
            MediumEnum = 4,
            
            /// <summary>
            /// Enum SemiBoldEnum for semi-bold
            /// </summary>
            [EnumMember(Value = "semi-bold")]
            SemiBoldEnum = 5,
            
            /// <summary>
            /// Enum BoldEnum for bold
            /// </summary>
            [EnumMember(Value = "bold")]
            BoldEnum = 6
        }
}
