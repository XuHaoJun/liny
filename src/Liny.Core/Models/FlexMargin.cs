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
    /// You can specify the minimum space before a child component with the `margin` property of the child component, in pixels or with a keyword. FlexMargin just provides only keywords.
    /// </summary>
    /// <value>You can specify the minimum space before a child component with the `margin` property of the child component, in pixels or with a keyword. FlexMargin just provides only keywords. </value>

    public enum FlexMargin
    {
        /// <summary>
        /// Enum NoneEnum for none
        /// </summary>
        [EnumMember(Value = "none")]
        NoneEnum = 1,

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
    }
}
