using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


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
                Trace.WriteLine($"Invoice Id: {invoice.ID} , Invoice refNumber: {invoice.RefNumber}");
            }
        }

         [TestMethod()]
         public void GetInvoiceByIdTest()
        {
            var invoiceid = 488284;
            var url = "/api/Invoice/{id}";
            url = url.Replace("{id}", invoiceid.ToString());

            var request = new RestRequest(url);
            var obj = Get<TransactionEditResponseOfInvoiceT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Invoice Id: {obj.Value.ID}  Invoice RefNumber: {obj.Value.RefNumber}");
        }

        [TestMethod()]
        public void CreateInvoiceTest()
        {
            var url = $"/api/v3/Customers/{971605}";
            var request = new RestRequest(url);
            var customer = Get<EditResponseOfCustomerT>(request);

            url = $"/api/Inventory/{1057343}";
            request = new RestRequest(url);
            var inventory = Get<InventoryEditResponse>(request);  
            var inventories = new List<InventoryItemT>() { inventory.Value };          

            var body = JsonConvert.SerializeObject(Mocks.Invoice.GetInvoiceObject(customer.Value, inventories));
             url = "/api/Invoice/";
            request = new RestRequest(url);

            var obj = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Invoice Id: {obj.Value.ID}");

        }

    }
    
}