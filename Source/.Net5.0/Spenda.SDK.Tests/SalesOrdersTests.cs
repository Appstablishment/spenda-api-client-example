using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var salesOrderId = 971609;
            var url = "/api/SalesOrders/{id}";
            url = url.Replace("{id}", salesOrderId.ToString());

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
            var inventories = new List<InventoryItemT>();
            var customer = new CustomerT();

            var body = JsonConvert.SerializeObject(Mocks.SalesOrders.GetSalesOrdersObject(inventories, customer));

            var request = new RestRequest("/api/SalesOrders");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponse>(request);
            
            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Sales Order Id: {obj.Value.ID}, Sales Order RefNumber: {obj.Value.RefNumber}");
        }
    }
}
