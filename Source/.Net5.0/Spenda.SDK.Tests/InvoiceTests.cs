using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;
using System.Collections.Generic;


namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class InvoiceTests : BaseTests
    {
        [TestMethod()]
        public void InvoiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllInvoiceTest()
        {
            var request = new RestRequest("/api/Invoice");
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);

            foreach (var invoice in obj.Value)
            {
                Trace.WriteLine($"Invoice Id: {invoice.ID} , Invoice refNumber: {invoice.RefNumber},  {invoice.Status}");
            }
        }

        [TestMethod()]
        public void GetInvoiceByIdTest()
        {
            var request = new RestRequest($"/api/Invoice/{488284}");
            var obj = Get<TransactionEditResponseOfInvoiceT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Invoice Id: {obj.Value.ID}  Invoice RefNumber: {obj.Value.RefNumber}");
        }

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