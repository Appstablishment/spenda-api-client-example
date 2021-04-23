using System;
using System.Collections.Generic;
using RestSharp;
using Swagger.Client;

namespace Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountApi
    {
        /// <summary>
        /// Authorisation - Login Authorisation - Login
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body">Ensure the values inserted for the _username_ and _password_ have been properly HTML encoded. 

        //For more information about HTML encoding see [here](https://www.w3schools.com/tags/ref_urlencode.asp)

        //Simple encoding example: 

        //jim.citizen+spenda@email.net encoded &#x3D;&gt;  jim.citizen%2Bspenda%40email.net 

        // &#x27;+&#x27; symbol becomes &#x27;%2B&#x27; 

        // &#x27;@&#x27; symbol becomes &#x27;%40&#x27;</param>
        /// <returns></returns>
        void AuthorisationLogin(string contentType, string body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountApi : IAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Authorisation - Login Authorisation - Login
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body">Ensure the values inserted for the _username_ and _password_ have been properly HTML encoded. 

        //For more information about HTML encoding see [here](https://www.w3schools.com/tags/ref_urlencode.asp)

        //Simple encoding example: 

        //jim.citizen+spenda@email.net encoded &#x3D;&gt;  jim.citizen%2Bspenda%40email.net 

        // &#x27;+&#x27; symbol becomes &#x27;%2B&#x27; 

        // &#x27;@&#x27; symbol becomes &#x27;%40&#x27;</param>
        /// <returns></returns>
        public void AuthorisationLogin(string contentType, string body)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling AuthorisationLogin");

            var path = "/api/login";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            var grantType = "password";
            var username = "jv+zohotestingacct@cirralto.com.au";
            var password = "Passw0Rd@123!";
            var client_id = 1;

            queryParams.Add("grant_type", grantType);
            queryParams.Add("username", username);
            queryParams.Add("password", password);
            queryParams.Add("client_id", client_id.ToString());

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AuthorisationLogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AuthorisationLogin: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
