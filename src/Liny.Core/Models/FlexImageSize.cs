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
    /// You can set the width of an Flex image component with the `size` property, in pixels, as a percentage, or with a keyword. FlexImageSize just provides only keywords.
    /// </summary>
    /// <value>You can set the width of an Flex image component with the `size` property, in pixels, as a percentage, or with a keyword. FlexImageSize just provides only keywords. </value>

    public enum FlexImageSize
    {
        /// <summary>
        /// Enum XxsEnum for xxs
        /// </summary>
        [EnumMember(Value = "xxs")]
        XxsEnum = 1,

        /// <summary>
        /// Enum XsEnum for xs
        /// </summary>
        [EnumMember(Value = "xs")]
        XsEnum = 2,

        /// <summary>
        /// Enum SmEnum for sm
        /// </summary>
        [EnumMember(Value = "sm")]
        SmEnum = 3,

        /// <summary>
        /// Enum MdEnum for md
        /// </summary>
        [EnumMember(Value = "md")]
        MdEnum = 4,

        /// <summary>
        /// Enum LgEnum for lg
        /// </summary>
        [EnumMember(Value = "lg")]
        LgEnum = 5,

        /// <summary>
        /// Enum XlEnum for xl
        /// </summary>
        [EnumMember(Value = "xl")]
        XlEnum = 6,

        /// <summary>
        /// Enum XxlEnum for xxl
        /// </summary>
        [EnumMember(Value = "xxl")]
        XxlEnum = 7,

        /// <summary>
        /// Enum _3xlEnum for 3xl
        /// </summary>
        [EnumMember(Value = "3xl")]
        _3xlEnum = 8,

        /// <summary>
        /// Enum _4xlEnum for 4xl
        /// </summary>
        [EnumMember(Value = "4xl")]
        _4xlEnum = 9,

        /// <summary>
        /// Enum _5xlEnum for 5xl
        /// </summary>
        [EnumMember(Value = "5xl")]
        _5xlEnum = 10,

        /// <summary>
        /// Enum FullEnum for full
        /// </summary>
        [EnumMember(Value = "full")]
        FullEnum = 11,
    }
}
