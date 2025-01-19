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
        /// Specify the setting for bot link feature with one of the following values:  `normal`: Display the option to add the LINE Official Account as a friend in the channel consent screen. `aggressive`: Display a screen with the option to add the LINE Official Account as a friend after the channel consent screen. `none`: Don't display the option to add the LINE Official Account as a friend.   The default value is none. 
        /// </summary>
        /// <value>Specify the setting for bot link feature with one of the following values:  `normal`: Display the option to add the LINE Official Account as a friend in the channel consent screen. `aggressive`: Display a screen with the option to add the LINE Official Account as a friend after the channel consent screen. `none`: Don't display the option to add the LINE Official Account as a friend.   The default value is none. </value>
        
        public enum LiffBotPrompt
        {
            
            /// <summary>
            /// Enum NormalEnum for normal
            /// </summary>
            [EnumMember(Value = "normal")]
            NormalEnum = 1,
            
            /// <summary>
            /// Enum AggressiveEnum for aggressive
            /// </summary>
            [EnumMember(Value = "aggressive")]
            AggressiveEnum = 2,
            
            /// <summary>
            /// Enum NoneEnum for none
            /// </summary>
            [EnumMember(Value = "none")]
            NoneEnum = 3
        }
}
