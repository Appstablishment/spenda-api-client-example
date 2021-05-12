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

        /// <summary>
        /// Get a collection of Sales Orders
        /// </summary>
        [TestMethod()]
        public void GetLastSalesOrders_Test()
        {
            var salesOrders = SearchSalesOrders(10);

            //loop through to display the records
            foreach (var salesOrder in salesOrders)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefNumber}, Sales Order Status: {salesOrder.Status}");
            }
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/SalesOrders/{id}
        /// </api>
        /// API to get a specific Sale Order.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get a Sales Order by its ID
        /// </summary>
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

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/SalesOrders/{id}/messages
        /// </api>
        /// API to get the messages for a specific Sale Order.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<BusTransMessageT> GetAllMessagesBySalesOrderByID(int id)
        {
            var request = new RestRequest($"/api/SalesOrders/{id}/messages");

            var response = Get<ActionResultsOfBusTransMessages>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        /// <summary>
        /// Get a collection of sales orders messages based on a saler order ID
        /// </summary>
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

            //loop through to display the records
            foreach (var salesOrdersMessage in salesOrdersMessages)
            {
                Trace.WriteLine($"Sales Order  Id: {salesOrdersMessage.ID}, Sales Order Message: {salesOrdersMessage.Message}");
            }
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// DELETE /api/SalesOrders/{id}
        /// </api>
        /// API to post a Sale Order.
        /// </summary>
        /// <param name="id"></param> sales order Id to be deleted
        /// <returns></returns>
        public ActionResults DeleteSalesOrderByID(int id)
        {
            var request = new RestRequest($"/api/SalesOrders/{id}");

            var response = Delete<ActionResults>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response;
        }

        /// <summary>
        /// Get a collection of sales orders and delete one randomly
        /// </summary>
        [TestMethod()]
        public void DeleteSalesOrderById_Test()
        {
            //select any Sales Order
            var salesOrders = SearchSalesOrders(10);

            if (!(salesOrders?.Any() ?? false)) Assert.Fail("Sales Orders found");

            //select the any Sales Order ID
            var salesOrderID = PickOne<BusTransSearchResultT>(salesOrders).ID;

            //delete a sale order by the its ID
            var salesOrder = DeleteSalesOrderByID(salesOrderID.Value);

            Assert.IsNotNull(salesOrder);
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// POST /api/SalesOrders
        /// </api>
        /// API to post a Sale Order.
        /// </summary>
        /// <param name="inventories"></param> A collection of inventory items
        /// <param name="customer"></param> a customer item
        /// <returns></returns>
        public SynkValidation CreateNewSalesOrder(List<InventoryItemT> inventories, CustomerT customer)
        {
            var newSalesOrder = Mocks.SalesOrders.Get(inventories, customer);
            var body = JsonConvert.SerializeObject(newSalesOrder);

            var request = new RestRequest("/api/SalesOrders");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            return response.Value;
        }

        /// <summary>
        /// Post a new sale order getting a random operational customer and a random collection of inventories
        /// </summary>
        [TestMethod()]
        public void CreateSalesOrders_Test()
        {
            // Get a collection of customers and pick one randomly
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            // Get a collection of inventories and pick any randomly
            var inventoryTest = new InventoryTests();
            var inventories = inventoryTest.SearchInventories();
            var randomInventories = PickAny<InventoryItemT>(inventories, 3);

            //post new sale order based on inventories and customer
            var salesOrder = CreateNewSalesOrder(randomInventories, randomCustomer);

            Trace.WriteLine($"Sales Order Id: {salesOrder.ID}, Sales Order RefNumber: {salesOrder.RefNumber}");
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// POST /api/SalesOrders/{id}/lines
        /// </api>
        /// API to post a Sale Order.
        /// </summary>
        /// <param name="salesOrder"></param> specific sales order to add lines
        /// <param name="inventories"></param> A collection of inventory items
        /// <param name="customer"></param> a customer item
        /// <returns></returns>
        public SalesOrderT AddLinesToExistingSalesOrder(int customerId, SalesOrderT salesOrder, List<InventoryItemT> inventories)
        {
            var newSalesOrder = Mocks.SalesOrders.addLinesRequest(customerId, salesOrder, inventories);
            var body = JsonConvert.SerializeObject(newSalesOrder);

            var request = new RestRequest($"/api/SalesOrders/{salesOrder.ID}/lines");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<AddLinesResponseOfSalesOrderT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Transaction;
        }

        /// <summary>
        /// Post multiple lines to an existing sales order based on a random collection of inventories.
        /// </summary>
        [TestMethod()]
        public void AddLineToSalesOrders_Test()
        {
            // Get a random collection of inventories
            var inventoryTest = new InventoryTests();
            var inventories = inventoryTest.SearchInventories();
            var randomInventories = PickAny<InventoryItemT>(inventories, 3);

            // Get a collection of sales orders and pick one randomly
            var salesOrders = SearchSalesOrders(10);
            var randomSalesOrder = PickOne<BusTransSearchResultT>(salesOrders);

            // Get the sale order by ID
            var orderToUpdate = GetSalesOrderByID(randomSalesOrder.ID.Value);

            Assert.IsNotNull(orderToUpdate);

            // Post new lines to existing sale order
            var updatedSalesOrder = AddLinesToExistingSalesOrder(orderToUpdate.CustomerID.Value, orderToUpdate, randomInventories);

            Trace.WriteLine($"Sales Order Id: {updatedSalesOrder.ID}, Sales Order RefNumber: {updatedSalesOrder.RefNumber}");
        }
    }
}
