﻿using RestSharp;
using SDK.SpendaApiTests.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.SpendaApi.Examples.Tests
{
    public class BaseTests
    {
        private const string baseUrl = "https://spenda-api.synkd.net";
        private const string subscriptionKey = "5aaec5a06ae3404097357667f6429589"; //TODO: change this to a demo user account
        private const string environment = "preprod";
        private const string username = "shane.nall+sdk@appstab.co";
        private const string password = "1qwerty";
        private const int websiteID = 1;

        protected RestClient _restClient;
        public string Token { get; private set; }

        public BaseTests()
        {
            _restClient = new RestClient(baseUrl);
        }

        public void LoginAndGetToken()
        {
            var request = new RestRequest("/api/login", Method.POST);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
            request.AddHeader("Api-Environment", environment);

            //var usernameEncoded = System.Web.HttpUtility.UrlEncode(username);

            //var body = $"grant_type=password&username={usernameEncoded}&password={password}&client_id=1";

            //request.AddBody(body);

            request.AddParameter("grant_type", "password");
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("client_id", websiteID);

            var response = _restClient.Execute<AuthResponse>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Token = response.Data.access_token;
                Trace.WriteLine(Token);
            }

            //Trace.WriteLine(response.Content);
        }

        public void AddHeaders(ref RestRequest request)
        {
            request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
            request.AddHeader("Api-Environment", environment);
            request.AddHeader("Authorization", $"bearer {Token}");
        }

    }
}
