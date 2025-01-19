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
        /// How the audience was created. One of:  - `OA_MANAGER`: Audience created with [LINE Official Account Manager](https://manager.line.biz/). - `MESSAGING_API`: Audience created with Messaging API. - `POINT_AD`: Audience created with [LINE Points Ads](https://www.linebiz.com/jp/service/line-point-ad/) (Japanese only). - `AD_MANAGER`: Audience created with [LINE Ads](https://admanager.line.biz/). 
        /// </summary>
        /// <value>How the audience was created. One of:  - `OA_MANAGER`: Audience created with [LINE Official Account Manager](https://manager.line.biz/). - `MESSAGING_API`: Audience created with Messaging API. - `POINT_AD`: Audience created with [LINE Points Ads](https://www.linebiz.com/jp/service/line-point-ad/) (Japanese only). - `AD_MANAGER`: Audience created with [LINE Ads](https://admanager.line.biz/). </value>
        
        public enum AudienceGroupCreateRoute
        {
            
            /// <summary>
            /// Enum OAMANAGEREnum for OA_MANAGER
            /// </summary>
            [EnumMember(Value = "OA_MANAGER")]
            OAMANAGEREnum = 1,
            
            /// <summary>
            /// Enum MESSAGINGAPIEnum for MESSAGING_API
            /// </summary>
            [EnumMember(Value = "MESSAGING_API")]
            MESSAGINGAPIEnum = 2,
            
            /// <summary>
            /// Enum POINTADEnum for POINT_AD
            /// </summary>
            [EnumMember(Value = "POINT_AD")]
            POINTADEnum = 3,
            
            /// <summary>
            /// Enum ADMANAGEREnum for AD_MANAGER
            /// </summary>
            [EnumMember(Value = "AD_MANAGER")]
            ADMANAGEREnum = 4
        }
}
