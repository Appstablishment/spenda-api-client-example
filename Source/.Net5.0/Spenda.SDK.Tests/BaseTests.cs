using RestSharp;
using System.Diagnostics;
using Spenda.SDK.Models;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Spenda.SDK.Tests
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

        public T Get<T>(RestRequest req)
        {
            if (string.IsNullOrEmpty(Token))
                LoginAndGetToken();

            req.Method = Method.GET;
            AddHeaders(ref req);

            var res = _restClient.Execute(req);
            var obj = JsonConvert.DeserializeObject<T>(res.Content);

            return obj;
        }

        public T Post<T>(RestRequest req)
        {
            if (string.IsNullOrEmpty(Token))
                LoginAndGetToken();

            req.Method = Method.POST;
            AddHeaders(ref req);

            var res = _restClient.Execute(req);
            var obj = JsonConvert.DeserializeObject<T>(res.Content);

            return obj;
        }

        public T Put<T>(RestRequest req)
        {
            if (string.IsNullOrEmpty(Token))
                LoginAndGetToken();

            req.Method = Method.PUT;
            AddHeaders(ref req);

            var res = _restClient.Execute(req);
            var obj = JsonConvert.DeserializeObject<T>(res.Content);

            return obj;
        }

        public T Delete<T>(RestRequest req)
        {
            if (string.IsNullOrEmpty(Token))
                LoginAndGetToken();

            req.Method = Method.DELETE;
            AddHeaders(ref req);

            var res = _restClient.Execute(req);
            var obj = JsonConvert.DeserializeObject<T>(res.Content);

            return obj;
        }

        public void AssertSuccess(List<string> messages, bool? isSuccess)
        {
            var msg = messages?.FirstOrDefault();
            Trace.WriteLine($"AssertSuccess ({isSuccess}): {msg}");
            Assert.IsTrue(isSuccess ?? false, msg);
        }

        public List<T> pickAny<T>(List<T> obj, int count)
        {
            var newList = new List<T>();
            for (int i = 0; i < count; i++)
            {
                var rnd = new Random();
                var any = rnd.Next(0, obj.Count());
                newList.Add((T)obj[any]);
            }
            return newList;
        }
    }
}
