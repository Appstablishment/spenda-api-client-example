using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class InvoiceTests : BaseTests
    {
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice 
        /// </api>
        /// API to search all of the Invoice.
        /// </summary>
        /// <param name="maxNoOfRecords"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="searchString"></param>
        /// <param name="IsApprovedForPOS"></param>
        /// <param name="isExactMatch"></param>
        /// <returns></returns>
        public List<InvoiceT> SearchInvoices(string searchString=null,
                                          DateTime? startDate=null,
                                          DateTime? endDate=null,
                                          bool isExactMatch=false,
                                          bool IsApprovedForPOS=false,
                                          int maxNoOfRecords = 10)
        {
            var request = new RestRequest("/api/Invoice");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.searchString", searchString); 
            request.AddParameter("filter.isExactMatch", isExactMatch);

            var response = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            
            return response.Value;
        }
        
        [TestMethod()]
        public void InvoiceTest()
        {
            Assert.Fail();
        }
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice
        /// </api>
        /// API to get all of the Invoices.
        /// </summary>
        [TestMethod()]
        public void GetAllInvoiceTest()
        {
            var request = new RestRequest("/api/Invoice");

            //Added filter.maxResults to get 10 records only
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);

            //loop through to display the records
            foreach (var invoice in obj.Value)
            {
                Trace.WriteLine($"Invoice Id: {invoice.ID} , Invoice refNumber: {invoice.RefNumber},  {invoice.Status}");
            }
        }
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice/{id}
        /// </api>
        /// API to get a specific Invoice.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [TestMethod()]
        public void GetInvoiceByIdTest()
        {
            // Get all customers first just so that we can get a valid ID
            var invoices = SearchInvoices();
            if (!(invoices?.Any() ?? false)) Assert.Fail("invoices found");

            //select the top invoice ID
            var id = invoices.FirstOrDefault()?.ID;

            Assert.IsNotNull(id);

            var request = new RestRequest($"/api/Invoice/{id}");
            var obj = Get<TransactionEditResponseOfInvoiceT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Invoice Id: {obj.Value.ID}  Invoice RefNumber: {obj.Value.RefNumber}");
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice/
        /// </api>
        /// API to Create an Invoice.
        /// </summary>
        /// <returns></returns>
        [TestMethod()]
        public void CreateInvoiceTest()
        {
            var url = $"/api/v3/Customers";
            var request = new RestRequest(url);
            request.AddParameter("filter.maxResults", 20);
            var customer = Get<PagedActionResultsOfCustomers>(request);

            Assert.AreNotEqual(customer.Value.Count, 0);

            var randomCustomer = PickAny<CustomerT>(customer.Value, 1);

            url = $"/api/Inventory/";
            request = new RestRequest(url);
            request.AddParameter("filter.maxResults", 10);
            var inventories = Get<PagedActionResultsOfInventoryItems>(request);

            Assert.AreNotEqual(inventories.Value.Count, 0);

            var randomInventories = PickAny<InventoryItemT>(inventories.Value, 3);

            var body = JsonConvert.SerializeObject(Mocks.Invoice.GetInvoiceObject(randomCustomer[0], randomInventories));
            
            request = new RestRequest("/api/Invoice/");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Invoice Id: {obj.Value.ID}");
        }
    }
}