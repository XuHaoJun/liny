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
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Liny.Core.Attributes;
using Liny.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Liny.Core.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [ApiController]
    public class InsightApiController : ControllerBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <remarks>Retrieves the demographic attributes for a LINE Official Account&#39;s friends.You can only retrieve information about friends for LINE Official Accounts created by users in Japan (JP), Thailand (TH), Taiwan (TW) and Indonesia (ID). </remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v2/bot/insight/demographic")]
        [ValidateModelState]
        [SwaggerOperation("GetFriendsDemographics")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(GetFriendsDemographicsResponse),
            description: "OK"
        )]
        public virtual IActionResult GetFriendsDemographics()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetFriendsDemographicsResponse));
            string exampleJson = null;
            exampleJson =
                "{\n  \"available\" : true,\n  \"ages\" : [ {\n    \"percentage\" : 6.027456183070403,\n    \"age\" : \"from0to14\"\n  }, {\n    \"percentage\" : 6.027456183070403,\n    \"age\" : \"from0to14\"\n  } ],\n  \"genders\" : [ {\n    \"gender\" : \"male\",\n    \"percentage\" : 0.8008281904610115\n  }, {\n    \"gender\" : \"male\",\n    \"percentage\" : 0.8008281904610115\n  } ],\n  \"areas\" : [ {\n    \"area\" : \"area\",\n    \"percentage\" : 1.4658129805029452\n  }, {\n    \"area\" : \"area\",\n    \"percentage\" : 1.4658129805029452\n  } ],\n  \"appTypes\" : [ {\n    \"appType\" : \"ios\",\n    \"percentage\" : 5.962133916683182\n  }, {\n    \"appType\" : \"ios\",\n    \"percentage\" : 5.962133916683182\n  } ],\n  \"subscriptionPeriods\" : [ {\n    \"subscriptionPeriod\" : \"within7days\",\n    \"percentage\" : 5.637376656633329\n  }, {\n    \"subscriptionPeriod\" : \"within7days\",\n    \"percentage\" : 5.637376656633329\n  } ]\n}";

            var example =
                exampleJson != null
                    ? JsonSerializer.Deserialize<GetFriendsDemographicsResponse>(exampleJson)
                    : default(GetFriendsDemographicsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get user interaction statistics
        /// </summary>
        /// <remarks>Returns statistics about how users interact with narrowcast messages or broadcast messages sent from your LINE Official Account. </remarks>
        /// <param name="requestId">Request ID of a narrowcast message or broadcast message. Each Messaging API request has a request ID. </param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v2/bot/insight/message/event")]
        [ValidateModelState]
        [SwaggerOperation("GetMessageEvent")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetMessageEventResponse), description: "OK")]
        public virtual IActionResult GetMessageEvent(
            [FromQuery(Name = "requestId")] [Required()] [MinLength(1)] string requestId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetMessageEventResponse));
            string exampleJson = null;
            exampleJson =
                "{\n  \"overview\" : {\n    \"uniqueMediaPlayed\" : 5,\n    \"uniqueMediaPlayed100Percent\" : 2,\n    \"requestId\" : \"requestId\",\n    \"uniqueImpression\" : 1,\n    \"uniqueClick\" : 5,\n    \"delivered\" : 6,\n    \"timestamp\" : 0\n  },\n  \"messages\" : [ {\n    \"uniqueMediaPlayed\" : 1,\n    \"uniqueMediaPlayed50Percent\" : 6,\n    \"uniqueMediaPlayed25Percent\" : 1,\n    \"uniqueMediaPlayed75Percent\" : 7,\n    \"uniqueMediaPlayed100Percent\" : 1,\n    \"mediaPlayed\" : 3,\n    \"impression\" : 9,\n    \"mediaPlayed100Percent\" : 1,\n    \"mediaPlayed75Percent\" : 7,\n    \"seq\" : 7,\n    \"mediaPlayed25Percent\" : 2,\n    \"mediaPlayed50Percent\" : 4\n  }, {\n    \"uniqueMediaPlayed\" : 1,\n    \"uniqueMediaPlayed50Percent\" : 6,\n    \"uniqueMediaPlayed25Percent\" : 1,\n    \"uniqueMediaPlayed75Percent\" : 7,\n    \"uniqueMediaPlayed100Percent\" : 1,\n    \"mediaPlayed\" : 3,\n    \"impression\" : 9,\n    \"mediaPlayed100Percent\" : 1,\n    \"mediaPlayed75Percent\" : 7,\n    \"seq\" : 7,\n    \"mediaPlayed25Percent\" : 2,\n    \"mediaPlayed50Percent\" : 4\n  } ],\n  \"clicks\" : [ {\n    \"uniqueClick\" : 9,\n    \"uniqueClickOfRequest\" : 9,\n    \"click\" : 5,\n    \"seq\" : 4,\n    \"url\" : \"url\"\n  }, {\n    \"uniqueClick\" : 9,\n    \"uniqueClickOfRequest\" : 9,\n    \"click\" : 5,\n    \"seq\" : 4,\n    \"url\" : \"url\"\n  } ]\n}";

            var example =
                exampleJson != null
                    ? JsonSerializer.Deserialize<GetMessageEventResponse>(exampleJson)
                    : default(GetMessageEventResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get number of followers
        /// </summary>
        /// <remarks>Returns the number of users who have added the LINE Official Account on or before a specified date. </remarks>
        /// <param name="date">Date for which to retrieve the number of followers.  Format: yyyyMMdd (e.g. 20191231) Timezone: UTC+9 </param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v2/bot/insight/followers")]
        [ValidateModelState]
        [SwaggerOperation("GetNumberOfFollowers")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(GetNumberOfFollowersResponse),
            description: "OK"
        )]
        public virtual IActionResult GetNumberOfFollowers(
            [FromQuery(Name = "date")]
            [RegularExpression("^[0-9]{8}$")]
            [StringLength(8, MinimumLength = 8)]
                string date
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetNumberOfFollowersResponse));
            string exampleJson = null;
            exampleJson =
                "{\n  \"followers\" : 0,\n  \"blocks\" : 1,\n  \"targetedReaches\" : 6,\n  \"status\" : \"ready\"\n}";

            var example =
                exampleJson != null
                    ? JsonSerializer.Deserialize<GetNumberOfFollowersResponse>(exampleJson)
                    : default(GetNumberOfFollowersResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get number of message deliveries
        /// </summary>
        /// <remarks>Returns the number of messages sent from LINE Official Account on a specified day. </remarks>
        /// <param name="date">Date for which to retrieve number of sent messages. - Format: yyyyMMdd (e.g. 20191231) - Timezone: UTC+9 </param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v2/bot/insight/message/delivery")]
        [ValidateModelState]
        [SwaggerOperation("GetNumberOfMessageDeliveries")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(GetNumberOfMessageDeliveriesResponse),
            description: "OK"
        )]
        public virtual IActionResult GetNumberOfMessageDeliveries(
            [FromQuery(Name = "date")]
            [Required()]
            [RegularExpression("^[0-9]{8}$")]
            [StringLength(8, MinimumLength = 8)]
                string date
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetNumberOfMessageDeliveriesResponse));
            string exampleJson = null;
            exampleJson =
                "{\n  \"broadcast\" : 0,\n  \"targeting\" : 6,\n  \"chat\" : 5,\n  \"apiBroadcast\" : 2,\n  \"autoResponse\" : 1,\n  \"welcomeResponse\" : 5,\n  \"apiMulticast\" : 9,\n  \"apiReply\" : 2,\n  \"apiPush\" : 7,\n  \"status\" : \"ready\",\n  \"apiNarrowcast\" : 3\n}";

            var example =
                exampleJson != null
                    ? JsonSerializer.Deserialize<GetNumberOfMessageDeliveriesResponse>(exampleJson)
                    : default(GetNumberOfMessageDeliveriesResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>You can check the per-unit statistics of how users interact with push messages and multicast messages sent from your LINE Official Account. </remarks>
        /// <param name="customAggregationUnit">Name of aggregation unit specified when sending the message. Case-sensitive. For example, &#x60;Promotion_a&#x60; and &#x60;Promotion_A&#x60; are regarded as different unit names. </param>
        /// <param name="from">Start date of aggregation period.  Format: yyyyMMdd (e.g. 20210301) Time zone: UTC+9 </param>
        /// <param name="to">End date of aggregation period. The end date can be specified for up to 30 days later. For example, if the start date is 20210301, the latest end date is 20210331.  Format: yyyyMMdd (e.g. 20210301) Time zone: UTC+9 </param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v2/bot/insight/message/event/aggregation")]
        [ValidateModelState]
        [SwaggerOperation("GetStatisticsPerUnit")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(GetStatisticsPerUnitResponse),
            description: "OK"
        )]
        public virtual IActionResult GetStatisticsPerUnit(
            [FromQuery(Name = "customAggregationUnit")]
            [Required()]
            [RegularExpression("^[a-zA-Z0-9_]{1,30}$")]
            [StringLength(30, MinimumLength = 1)]
                string customAggregationUnit,
            [FromQuery(Name = "from")]
            [Required()]
            [RegularExpression("^[0-9]{8}$")]
            [StringLength(8, MinimumLength = 8)]
                string from,
            [FromQuery(Name = "to")]
            [Required()]
            [RegularExpression("^[0-9]{8}$")]
            [StringLength(8, MinimumLength = 8)]
                string to
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetStatisticsPerUnitResponse));
            string exampleJson = null;
            exampleJson =
                "{\n  \"overview\" : {\n    \"uniqueMediaPlayed\" : 1,\n    \"uniqueMediaPlayed100Percent\" : 5,\n    \"uniqueImpression\" : 0,\n    \"uniqueClick\" : 6\n  },\n  \"messages\" : [ {\n    \"uniqueMediaPlayed\" : 1,\n    \"uniqueMediaPlayed75Percent\" : 6,\n    \"uniqueMediaPlayed100Percent\" : 7,\n    \"mediaPlayed\" : 7,\n    \"mediaPlayed100Percent\" : 4,\n    \"mediaPlayed50Percent\" : 3,\n    \"uniqueMediaPlayed50Percent\" : 1,\n    \"uniqueMediaPlayed25Percent\" : 1,\n    \"uniqueImpression\" : 7,\n    \"impression\" : 2,\n    \"mediaPlayed75Percent\" : 2,\n    \"seq\" : 5,\n    \"mediaPlayed25Percent\" : 9\n  }, {\n    \"uniqueMediaPlayed\" : 1,\n    \"uniqueMediaPlayed75Percent\" : 6,\n    \"uniqueMediaPlayed100Percent\" : 7,\n    \"mediaPlayed\" : 7,\n    \"mediaPlayed100Percent\" : 4,\n    \"mediaPlayed50Percent\" : 3,\n    \"uniqueMediaPlayed50Percent\" : 1,\n    \"uniqueMediaPlayed25Percent\" : 1,\n    \"uniqueImpression\" : 7,\n    \"impression\" : 2,\n    \"mediaPlayed75Percent\" : 2,\n    \"seq\" : 5,\n    \"mediaPlayed25Percent\" : 9\n  } ],\n  \"clicks\" : [ {\n    \"uniqueClick\" : 5,\n    \"uniqueClickOfRequest\" : 9,\n    \"click\" : 4,\n    \"seq\" : 1,\n    \"url\" : \"url\"\n  }, {\n    \"uniqueClick\" : 5,\n    \"uniqueClickOfRequest\" : 9,\n    \"click\" : 4,\n    \"seq\" : 1,\n    \"url\" : \"url\"\n  } ]\n}";

            var example =
                exampleJson != null
                    ? JsonSerializer.Deserialize<GetStatisticsPerUnitResponse>(exampleJson)
                    : default(GetStatisticsPerUnitResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
