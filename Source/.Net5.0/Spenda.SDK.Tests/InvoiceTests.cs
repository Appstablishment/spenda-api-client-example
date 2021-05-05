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
        public List<BusTransSearchResultT> SearchInvoices(string searchString=null,
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
            request.AddParameter("filter.startDate", startDate);
            request.AddParameter("filter.endDate", endDate);
            request.AddParameter("filter.isApprovedForPOS", IsApprovedForPOS);

            var response = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            
            return response.Value;
        }
        
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice
        /// </api>
        /// API to get all of the Invoices.
        /// </summary>
        [TestMethod()]
        public void GetAllInvoice_Test()
        {
            var invoices = SearchInvoices();

            //loop through to display the records
            foreach (var invoice in invoices)
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
        public InvoiceT GetInvoiceByID(int id)
        {
            var request = new RestRequest($"/api/Invoice/{id}");
            var response = Get<TransactionEditResponseOfInvoiceT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            InvoiceT invoice = response.Value;

            Assert.IsNotNull(invoice);

            Trace.WriteLine($"Invoice Id: {invoice.ID}  Invoice RefNumber: {invoice.RefNumber}");
            return invoice;
        }

        /// <summary>
        /// Get a invoice by its ID
        /// </summary>  
        [TestMethod()]
        public void GetInvoiceById_Test()
        {
            // Get a collection of invoices so that we can get a valid ID
            var invoices = SearchInvoices();
            
            if (!(invoices?.Any() ?? false)) Assert.Fail("Not invoices found");

            //select the top invoice ID
            var invoiceId = invoices.FirstOrDefault()?.ID;

            // Get the Sales Order by ID
            var invoice = GetInvoiceByID(invoiceId.Value);

            Assert.IsNotNull(invoice);
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Invoice/
        /// </api>
        /// API to Create an Invoice.
        /// </summary>
        /// <param name="inventories"></param> A collection of inventory items
        /// <param name="customer"></param> a customer item
        /// <returns></returns>
        public SynkValidation CreateNewInvoice(CustomerT customer, List<InventoryItemT> inventoryItems)
        {
            var newInvoice = Mocks.Invoice.Get(customer, inventoryItems);
            var body = JsonConvert.SerializeObject(newInvoice);

            var request = new RestRequest("/api/Invoice/");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            return response.Value;
        }

        /// <summary>
        /// Post a new invoice getting a random operational customer and a random collection of inventories
        /// </summary>
        [TestMethod()]
        public void CreateInvoice_Test()
        {
            // Get a collection of customers and pick one randomly
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            // Get a collection of inventories and pick any randomly
            var inventoryTest = new InventoryTests();
            var inventories = inventoryTest.SearchInventories();
            var randomInventories = PickAny<InventoryItemT>(inventories, 3);

            //post new invoice based on inventories and customer
            var invoice = CreateNewInvoice(randomCustomer, randomInventories);

            Trace.WriteLine($"Invoice Id: {invoice.ID}");
        }
    }
}