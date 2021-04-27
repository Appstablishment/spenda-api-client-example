using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using SDK.SpendaApi.Examples;
using Swagger.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.SpendaApi.Examples.Tests
{
    [TestClass()]
    public class CustomerTests : BaseTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllCustomersTest()
        {
            LoginAndGetToken();
            var request = new RestRequest("/api/v3/Customers", Method.GET);
            AddHeaders(ref request);

            request.AddParameter("filter.maxResults", 10);

            var response = _restClient.Execute<PagedActionResultsOfCustomers>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var obj = JsonConvert.DeserializeObject<PagedActionResultsOfCustomers>(response.Content);
                AssertSuccess(obj);
                foreach (var customer in obj.Value)
                {
                    Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
                }
            }
        }

        [TestMethod()]
        public void GetCustomerSearchByNameRefNumberTest()
        {
            LoginAndGetToken();          

            var request = new RestRequest("/api/v3/Customers", Method.GET);
            AddHeaders(ref request);

            //request.AddParameter("filter.customerClassID", 10);
            request.AddParameter("filter.search", "Bruce");
            request.AddParameter("filter.isExactMatch", false);
            request.AddParameter("filter.sortAsc", true);
            request.AddParameter("filter.maxResults", 10);

            var response = _restClient.Execute<PagedActionResultsOfCustomers>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var obj = JsonConvert.DeserializeObject<PagedActionResultsOfCustomers>(response.Content);
                AssertSuccess(obj);
                foreach (var customer in obj.Value)
                {
                    Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
                }
            }
        }

        [TestMethod()]
        public void GetCustomerByIdTest()
        {
            LoginAndGetToken();

            var customerId = 971609;
            var url = "/api/v3/Customers/{id}";
            url = url.Replace("{id}", customerId.ToString());

            var request = new RestRequest(url, Method.GET);
            AddHeaders(ref request);

            request.AddParameter("req.iD", 971609);
            request.AddParameter("req.gUID", 971609);
            request.AddParameter("req.tenantID", 971609);

            var response = _restClient.Execute<EditResponseOfCustomerT>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var customer = JsonConvert.DeserializeObject<EditResponseOfCustomerT>(response.Content);
                AssertSuccess(customer);
                Trace.WriteLine($"Customer Name: {customer.Value.Name} {customer.Value.Name2}, Customer Id: {customer.Value.ID}");
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CreateCustomerTest()
        {
            LoginAndGetToken();
            var request = new RestRequest("/api/v3/Customers", Method.POST);
            AddHeaders(ref request);

            var body = JsonConvert.SerializeObject(SpendaApiTests.Mocks.Customer.GetCustomerObject());

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = _restClient.Execute<SynkSaveQueueResponseOfCustomerT>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var customer = JsonConvert.DeserializeObject<SynkSaveQueueResponseOfCustomerT>(response.Content);
                AssertSuccess(customer);
                Trace.WriteLine($"Customer Ref Number: {customer.Value.RefNumber}, Customer Id: {customer.Value.ID}");
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            var customerId = 971609;
            var refNumber = "CU-000004";
            var url = "/api/v3/Customers/{id}";
            url = url.Replace("{id}", customerId.ToString());

            LoginAndGetToken();
            var request = new RestRequest(url, Method.PUT);
            AddHeaders(ref request);

            var body = JsonConvert.SerializeObject(SpendaApiTests.Mocks.Customer.GetCustomerObject(customerId, refNumber));

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = _restClient.Execute<SynkSaveQueueResponseOfCustomerT>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var customer = JsonConvert.DeserializeObject<SynkSaveQueueResponseOfCustomerT>(response.Content);
                AssertSuccess(customer);
                Trace.WriteLine($"Customer Ref Number: {customer.Value.RefNumber}, Customer Id: {customer.Value.ID}");
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void getCustomerObjectTest()
        {
            Assert.Fail();
        }

        public void AssertSuccess(PagedActionResultsOfCustomers response)
        {
            var msg = response.Messages?.FirstOrDefault();
            Trace.WriteLine($"AssertSuccess ({response.IsSuccess}): {msg}");
            Assert.IsTrue(response.IsSuccess ?? false, msg);
        }

        public void AssertSuccess(EditResponseOfCustomerT response)
        {
            var msg = response.Messages?.FirstOrDefault();
            Trace.WriteLine($"\nAssertSuccess ({response.IsSuccess}): {msg}");
            Assert.IsTrue(response.IsSuccess ?? false, msg);
        }

        public void AssertSuccess(SynkSaveQueueResponseOfCustomerT response)
        {
            var msg = response.Messages?.FirstOrDefault();
            Trace.WriteLine($"\nAssertSuccess ({response.IsSuccess}): {msg}");
            Assert.IsTrue(response.IsSuccess ?? false, msg);
        }
    }
}