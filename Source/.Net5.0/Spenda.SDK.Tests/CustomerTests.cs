using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;

namespace Spenda.SDK.Tests
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
            var request = new RestRequest("/api/v3/Customers");
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfCustomers>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            foreach (var customer in obj.Value)
            {
                Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
            }
        }

        [TestMethod()]
        public void GetCustomerSearchByNameRefNumberTest()
        {
            var request = new RestRequest("/api/v3/Customers");
            //request.AddParameter("filter.customerClassID", 10);
            request.AddParameter("filter.search", "Bruce");
            request.AddParameter("filter.isExactMatch", false);
            request.AddParameter("filter.sortAsc", true);
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfCustomers>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            foreach (var customer in obj.Value)
            {
                Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
            }
        }

        [TestMethod()]
        public void GetCustomerByIdTest()
        {
            var url = $"/api/v3/Customers/{971609}";
            var request = new RestRequest(url);
            //request.AddParameter("req.iD", 971609);
            //request.AddParameter("req.gUID", 971609);
            //request.AddParameter("req.tenantID", 971609);

            var obj = Get<EditResponseOfCustomerT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Customer Name: {obj.Value.Name} {obj.Value.Name2}, Customer Id: {obj.Value.ID}");
        }

        [TestMethod()]
        public void CreateCustomerTest()
        {
            var body = JsonConvert.SerializeObject(Mocks.Customer.GetCustomerObject());

            var request = new RestRequest("/api/v3/Customers");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponseOfCustomerT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Customer Ref Number: {obj.Value.RefNumber}, Customer Id: {obj.Value.ID}");
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            var customerId = 971609;
            var refNumber = "CU-000004";
            var body = JsonConvert.SerializeObject(Mocks.Customer.GetCustomerObject(customerId, refNumber));

            var request = new RestRequest($"/api/v3/Customers?id={customerId}");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Put<SynkSaveQueueResponseOfCustomerT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Customer Ref Number: {obj.Value.RefNumber}, Customer Id: {obj.Value.ID}");
        }
    }
}