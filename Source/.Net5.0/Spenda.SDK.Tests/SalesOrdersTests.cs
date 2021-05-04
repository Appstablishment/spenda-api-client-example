using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class SalesOrdersTests : BaseTests
    {
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/SalesOrders 
        /// </api>
        /// API to search all of the Sales Order.
        /// </summary>
        /// <param name="maxNoOfRecords"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="status"></param>
        /// <param name="supplierID"></param>
        /// <returns></returns>
        public List<BusTransSearchResultT> SearchSalesOrders(int maxNoOfRecords = 10,
                                                            DateTime? startDate = null,
                                                            DateTime? endDate = null,
                                                            string status = null,
                                                            int? supplierID = null)
        {
            var request = new RestRequest("/api/SalesOrders");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.startDate", startDate);
            request.AddParameter("filter.endDate", endDate);
            request.AddParameter("filter.supplierID", supplierID);
            request.AddParameter("filter.statusStrings", status);

            request.AddParameter("filter.sortField", "RefNumber"); // Options include : RefNumber, TransDate, Status, CreatedDateTime, and ModifiedDateTime

            var response = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetLastSalesOrders_Test()
        {
            var salesOrders = SearchSalesOrders(10);

            //loop through to display the records
            foreach (var salesOrder in salesOrders)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefNumber}");
            }
        }

        public SalesOrderT GetSalesOrderByID(int id)
        {
            var request = new RestRequest($"/api/SalesOrders/{id}");

            var response = Get<TransactionEditResponseOfSalesOrderT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            SalesOrderT salesOrder = response.Value;

            Assert.IsNotNull(salesOrder);

            Trace.WriteLine($"Sales Order Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefSalesOrderRefNumber}");

            return salesOrder;
        }

        [TestMethod()]
        public void GetSalesOrderById_Test()
        {
            //select any Sales Order
            var salesOrders = SearchSalesOrders(10);

            if (!(salesOrders?.Any() ?? false)) Assert.Fail("Sales Orders found");

            //select the any Sales Order ID
            var salesOrderID = PickOne<BusTransSearchResultT>(salesOrders).ID;

            // Get the Sales Order by ID
            var salesOrder = GetSalesOrderByID(salesOrderID.Value);

            Assert.IsNotNull(salesOrder);
        }

        public List<BusTransMessageT> GetAllMessagesBySalesOrderByID(int id)
        {
            var request = new RestRequest($"/api/SalesOrders/{id}/messages");

            var response = Get<ActionResultsOfBusTransMessages>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetSalesOrderMessages_Test()
        {
            //select any Sales Order
            var salesOrders = SearchSalesOrders(10);

            if (!(salesOrders?.Any() ?? false)) Assert.Fail("Sales Orders found");

            //select the any Sales Order ID
            var salesOrderID = PickOne<BusTransSearchResultT>(salesOrders).ID;

            //select the sales order messages by sales order Id
            var salesOrdersMessages = GetAllMessagesBySalesOrderByID(salesOrderID.Value);

            foreach (var salesOrdersMessage in salesOrdersMessages)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrdersMessage.ID}, Sales Order Message: {salesOrdersMessage.Message}");
            }
        }

        public ActionResults DeleteSalesOrderByID(int id)
        {
            var request = new RestRequest($"/api/SalesOrders/{id}");

            var response = Delete<ActionResults>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response;
        }

        [TestMethod()]
        public void DeleteSalesOrderById_Test()
        {
            //select any Sales Order
            var salesOrders = SearchSalesOrders(10);

            if (!(salesOrders?.Any() ?? false)) Assert.Fail("Sales Orders found");

            //select the any Sales Order ID
            var salesOrderID = PickOne<BusTransSearchResultT>(salesOrders).ID;

            var salesOrder = DeleteSalesOrderByID(salesOrderID.Value);

            Assert.IsNotNull(salesOrder);
        }

        public SynkValidation CreateNewSalesOrder(List<InventoryItemT> randomInventories, CustomerT randomCustomer)
        {
            var body = JsonConvert.SerializeObject(Mocks.SalesOrders.GetSalesOrdersObject(randomInventories, randomCustomer));

            var request = new RestRequest("/api/SalesOrders");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            return response.Value;
        }

        [TestMethod()]
        public void CreateSalesOrders_Test()
        {
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            var inventoryTest = new InventoryTests();
            var inventories = inventoryTest.SearchInventories();
            var randomInventories = PickAny<InventoryItemT>(inventories, 3);

            var salesOrder = CreateNewSalesOrder(randomInventories, randomCustomer);

            Trace.WriteLine($"Sales Order Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefNumber}");
        }

        public SalesOrderT AddLinesToExistingSalesOrder(BusTransSearchResultT randomSalesOrder, List<InventoryItemT> randomInventories, CustomerT randomCustomer)
        {
            var body = JsonConvert.SerializeObject(Mocks.SalesOrders.addLinesRequest(randomSalesOrder, randomInventories, randomCustomer));

            var request = new RestRequest($"/api/SalesOrders/{randomSalesOrder.ID}/lines");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<AddLinesResponseOfSalesOrderT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Transaction;
        }

        [TestMethod()]
        public void AddLineToSalesOrders_Test()
        {
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            var inventoryTest = new InventoryTests();
            var inventories = inventoryTest.SearchInventories();
            var randomInventories = PickAny<InventoryItemT>(inventories, 3);

            var salesOrders = SearchSalesOrders(10);
            var randomSalesOrder = PickOne<BusTransSearchResultT>(salesOrders);

            var updatedSalesOrder = AddLinesToExistingSalesOrder(randomSalesOrder, randomInventories, randomCustomer);

            Trace.WriteLine($"Sales Order Id: {updatedSalesOrder.ID}, Sales Order RefNumber: {updatedSalesOrder.RefNumber}");
        }
    }
}
