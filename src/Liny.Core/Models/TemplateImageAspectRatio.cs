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
    /// Aspect ratio of the image. This is only for the `imageAspectRatio` in ButtonsTemplate. Specify one of the following values:  `rectangle`: 1.51:1 `square`: 1:1
    /// </summary>
    /// <value>Aspect ratio of the image. This is only for the `imageAspectRatio` in ButtonsTemplate. Specify one of the following values:  `rectangle`: 1.51:1 `square`: 1:1 </value>

    public enum TemplateImageAspectRatio
    {
        /// <summary>
        /// Enum RectangleEnum for rectangle
        /// </summary>
        [EnumMember(Value = "rectangle")]
        RectangleEnum = 1,

        /// <summary>
        /// Enum SquareEnum for square
        /// </summary>
        [EnumMember(Value = "square")]
        SquareEnum = 2,
    }
}
