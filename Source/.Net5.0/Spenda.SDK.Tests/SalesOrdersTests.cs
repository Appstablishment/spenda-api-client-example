using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;
using System.Linq;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class SalesOrdersTests : BaseTests
    {
        [TestMethod()]
        public void SalesOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllSalesOrdersTest()
        {
            var request = new RestRequest("/api/SalesOrders");
            request.AddParameter("filter.maxResults", 10);
            //request.AddParameter("filter.businessID", 94894);
            //request.AddParameter("filter.customerID", 54854);
            //request.AddParameter("filter.supplierID", 98494);
            //request.AddParameter("filter.deliveryMethods", "");

            var obj = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            foreach (var salesOrder in obj.Value)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefNumber}");
            }
        }

        [TestMethod()]
        public void GetSalesOrderByIdTest()
        {
            var url = $"/api/SalesOrders/{142092}";
            var request = new RestRequest(url);

            var obj = Get<TransactionEditResponseOfSalesOrderT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Sales Order Id: {obj.Value.ID}, Sales Order RefNumber: {obj.Value.RefSalesOrderRefNumber}");
        }

        [TestMethod()]
        public void GetSalesOrderMessagestest()
        {
            var salesOrderId = 971609;
            var url = "/api/SalesOrders/{id}/messages";
            url = url.Replace("{id}", salesOrderId.ToString());

            var request = new RestRequest(url);

            var obj = Get<ActionResultsOfBusTransMessages>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            foreach (var salesOrder in obj.Value)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrder.ID}, Sales Order Message: {salesOrder.Message}");
            }
        }

        [TestMethod()]
        public void DeleteSalesOrderById()
        {
            var salesOrderId = 971609;
            var url = "/api/SalesOrders/{id}/messages";
            url = url.Replace("{id}", salesOrderId.ToString());

            var request = new RestRequest(url);

            var obj = Delete<ActionResults>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
        }

        [TestMethod()]
        public void CreateSalesOrdersTest()
        {
            var url = $"/api/v3/Customers";
            var request = new RestRequest(url);
            request.AddParameter("filter.maxResults", 10);
            var customer = Get<PagedActionResultsOfCustomers>(request);

            Assert.AreNotEqual(customer.Value.Count, 0);

            var randomCustomer = pickAny<CustomerT>(customer.Value, 1);

            url = $"/api/Inventory/";
            request = new RestRequest(url);
            request.AddParameter("filter.maxResults", 10);
            var inventories = Get<PagedActionResultsOfInventoryItems>(request);

            Assert.AreNotEqual(inventories.Value.Count, 0);

            var randomInventories = pickAny<InventoryItemT>(inventories.Value, 3);
            
            var body = JsonConvert.SerializeObject(Mocks.SalesOrders.GetSalesOrdersObject(randomInventories, randomCustomer.FirstOrDefault()));

            request = new RestRequest("/api/SalesOrders");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Sales Order Id: {obj.Value.ID}, Sales Order RefNumber: {obj.Value.RefNumber}");
        }

        [TestMethod()]
        public void AddLineToSalesOrdersTest()
        {
            var request = new RestRequest($"/api/v3/Customers");
            request.AddParameter("filter.maxResults", 20);
            var customer = Get<PagedActionResultsOfCustomers>(request);

            Assert.AreNotEqual(customer.Value.Count, 0);

            var randomCustomer = pickAny<CustomerT>(customer.Value, 1);

            request = new RestRequest($"/api/Inventory/");
            request.AddParameter("filter.maxResults", 20);
            var inventories = Get<PagedActionResultsOfInventoryItems>(request);

            Assert.AreNotEqual(inventories.Value.Count, 0);

            var randomInventories = pickAny<InventoryItemT>(inventories.Value, 3);

            request = new RestRequest("/api/SalesOrders");
            request.AddParameter("filter.maxResults", 10);
            var salesOrders = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            Assert.AreNotEqual(salesOrders.Value.Count, 0);

            var randomSalesOrder = pickAny<BusTransSearchResultT>(salesOrders.Value, 1);

            var body = JsonConvert.SerializeObject(Mocks.SalesOrders.addLinesRequest(randomSalesOrder[0], randomInventories, randomCustomer.FirstOrDefault()));

            request = new RestRequest($"/api/SalesOrders/{randomSalesOrder[0].ID}/lines");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<AddLinesResponseOfSalesOrderT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Sales Order Id: {obj.Transaction.ID}, Sales Order RefNumber: {obj.Transaction.RefNumber}");
        }
    }
}
