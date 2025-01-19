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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json;
using Liny.Core.Attributes;
using Liny.Core.Models;

namespace Liny.Core.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ChannelAccessTokenApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets all valid channel access token key IDs.</remarks>
        /// <param name="clientAssertionType">&#x60;urn:ietf:params:oauth:client-assertion-type:jwt-bearer&#x60;</param>
        /// <param name="clientAssertion">A JSON Web Token (JWT) (opens new window)the client needs to create and sign with the private key.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/oauth2/v2.1/tokens/kid")]
        [ValidateModelState]
        [SwaggerOperation("GetsAllValidChannelAccessTokenKeyIds")]
        [SwaggerResponse(statusCode: 200, type: typeof(ChannelAccessTokenKeyIdsResponse), description: "OK")]
        public virtual IActionResult GetsAllValidChannelAccessTokenKeyIds([FromQuery (Name = "client_assertion_type")][Required()]string clientAssertionType, [FromQuery (Name = "client_assertion")][Required()]string clientAssertion)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ChannelAccessTokenKeyIdsResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"kids\" : [ \"kids\", \"kids\" ]\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<ChannelAccessTokenKeyIdsResponse>(exampleJson)
            : default(ChannelAccessTokenKeyIdsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Issue short-lived channel access token</remarks>
        /// <param name="grantType">&#x60;client_credentials&#x60;</param>
        /// <param name="clientId">Channel ID.</param>
        /// <param name="clientSecret">Channel secret.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        [Route("/v2/oauth/accessToken")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("IssueChannelToken")]
        [SwaggerResponse(statusCode: 200, type: typeof(IssueShortLivedChannelAccessTokenResponse), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        public virtual IActionResult IssueChannelToken([FromForm (Name = "grant_type")][Required()]string grantType, [FromForm (Name = "client_id")][Required()]string clientId, [FromForm (Name = "client_secret")][Required()]string clientSecret)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IssueShortLivedChannelAccessTokenResponse));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"access_token\",\n  \"token_type\" : \"Bearer\",\n  \"expires_in\" : 0\n}";
            exampleJson = "{\n  \"details\" : [ {\n    \"property\" : \"property\",\n    \"message\" : \"message\"\n  }, {\n    \"property\" : \"property\",\n    \"message\" : \"message\"\n  } ],\n  \"message\" : \"message\",\n  \"sentMessages\" : [ {\n    \"quoteToken\" : \"quoteToken\",\n    \"id\" : \"id\"\n  }, {\n    \"quoteToken\" : \"quoteToken\",\n    \"id\" : \"id\"\n  }, {\n    \"quoteToken\" : \"quoteToken\",\n    \"id\" : \"id\"\n  }, {\n    \"quoteToken\" : \"quoteToken\",\n    \"id\" : \"id\"\n  }, {\n    \"quoteToken\" : \"quoteToken\",\n    \"id\" : \"id\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<IssueShortLivedChannelAccessTokenResponse>(exampleJson)
            : default(IssueShortLivedChannelAccessTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Issues a channel access token that allows you to specify a desired expiration date. This method lets you use JWT assertion for authentication.</remarks>
        /// <param name="grantType">client_credentials</param>
        /// <param name="clientAssertionType">urn:ietf:params:oauth:client-assertion-type:jwt-bearer</param>
        /// <param name="clientAssertion">A JSON Web Token the client needs to create and sign with the private key of the Assertion Signing Key.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/oauth2/v2.1/token")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("IssueChannelTokenByJWT")]
        [SwaggerResponse(statusCode: 200, type: typeof(IssueChannelAccessTokenResponse), description: "OK")]
        public virtual IActionResult IssueChannelTokenByJWT([FromForm (Name = "grant_type")][Required()]string grantType, [FromForm (Name = "client_assertion_type")][Required()]string clientAssertionType, [FromForm (Name = "client_assertion")][Required()]string clientAssertion)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IssueChannelAccessTokenResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"access_token\",\n  \"key_id\" : \"key_id\",\n  \"token_type\" : \"Bearer\",\n  \"expires_in\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<IssueChannelAccessTokenResponse>(exampleJson)
            : default(IssueChannelAccessTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Issues a new stateless channel access token, which doesn&#39;t have max active token limit unlike the other token types. The newly issued token is only valid for 15 minutes but can not be revoked until it naturally expires. </remarks>
        /// <param name="grantType">&#x60;client_credentials&#x60;</param>
        /// <param name="clientAssertionType">URL-encoded value of &#x60;urn:ietf:params:oauth:client-assertion-type:jwt-bearer&#x60;</param>
        /// <param name="clientAssertion">A JSON Web Token the client needs to create and sign with the private key of the Assertion Signing Key.</param>
        /// <param name="clientId">Channel ID.</param>
        /// <param name="clientSecret">Channel secret.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/oauth2/v3/token")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("IssueStatelessChannelToken")]
        [SwaggerResponse(statusCode: 200, type: typeof(IssueStatelessChannelAccessTokenResponse), description: "OK")]
        public virtual IActionResult IssueStatelessChannelToken([FromForm (Name = "grant_type")]string grantType, [FromForm (Name = "client_assertion_type")]string clientAssertionType, [FromForm (Name = "client_assertion")]string clientAssertion, [FromForm (Name = "client_id")]string clientId, [FromForm (Name = "client_secret")]string clientSecret)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IssueStatelessChannelAccessTokenResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"access_token\",\n  \"token_type\" : \"Bearer\",\n  \"expires_in\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<IssueStatelessChannelAccessTokenResponse>(exampleJson)
            : default(IssueStatelessChannelAccessTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Revoke short-lived or long-lived channel access token</remarks>
        /// <param name="accessToken">Channel access token</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v2/oauth/revoke")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("RevokeChannelToken")]
        public virtual IActionResult RevokeChannelToken([FromForm (Name = "access_token")][Required()]string accessToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Revoke channel access token v2.1</remarks>
        /// <param name="clientId">Channel ID</param>
        /// <param name="clientSecret">Channel Secret</param>
        /// <param name="accessToken">Channel access token</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/oauth2/v2.1/revoke")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("RevokeChannelTokenByJWT")]
        public virtual IActionResult RevokeChannelTokenByJWT([FromForm (Name = "client_id")][Required()]string clientId, [FromForm (Name = "client_secret")][Required()]string clientSecret, [FromForm (Name = "access_token")][Required()]string accessToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Verify the validity of short-lived and long-lived channel access tokens</remarks>
        /// <param name="accessToken">A short-lived or long-lived channel access token.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v2/oauth/verify")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("VerifyChannelToken")]
        [SwaggerResponse(statusCode: 200, type: typeof(VerifyChannelAccessTokenResponse), description: "OK")]
        public virtual IActionResult VerifyChannelToken([FromForm (Name = "access_token")][Required()]string accessToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(VerifyChannelAccessTokenResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"scope\" : \"scope\",\n  \"expires_in\" : 0,\n  \"client_id\" : \"client_id\"\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<VerifyChannelAccessTokenResponse>(exampleJson)
            : default(VerifyChannelAccessTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>You can verify whether a Channel access token with a user-specified expiration (Channel Access Token v2.1) is valid.</remarks>
        /// <param name="accessToken">Channel access token with a user-specified expiration (Channel Access Token v2.1).</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/oauth2/v2.1/verify")]
        [ValidateModelState]
        [SwaggerOperation("VerifyChannelTokenByJWT")]
        [SwaggerResponse(statusCode: 200, type: typeof(VerifyChannelAccessTokenResponse), description: "OK")]
        public virtual IActionResult VerifyChannelTokenByJWT([FromQuery (Name = "access_token")][Required()]string accessToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(VerifyChannelAccessTokenResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"scope\" : \"scope\",\n  \"expires_in\" : 0,\n  \"client_id\" : \"client_id\"\n}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<VerifyChannelAccessTokenResponse>(exampleJson)
            : default(VerifyChannelAccessTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
