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
            LoginAndGetToken();
            var request = new RestRequest("/api/Invoice/", Method.GET);
            AddHeaders(ref request);

            request.AddParameter("filter.maxResults", 10);

            var response = _restClient.Execute<PagedActionResultsOfBusTransSearchResultsT>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var obj = JsonConvert.DeserializeObject<PagedActionResultsOfBusTransSearchResultsT>(response.Content);
                AssertSuccess(obj);
                foreach (var invoice in obj.Value)
                {
                    Trace.WriteLine($"Invoice Id: {invoice.ID}");
                }
            }
        }

         [TestMethod()]
        public void GetInvoiceByIdTest()
        {
            LoginAndGetToken();

            var invoiceId = 488286;
            var url = "/api/Invoice/{id}";
            url = url.Replace("{id}", invoiceId.ToString());

            var request = new RestRequest(url, Method.GET);
            AddHeaders(ref request);

            var response = _restClient.Execute<TransactionEditResponseOfInvoiceT>(request);
           
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var invoice = JsonConvert.DeserializeObject<TransactionEditResponseOfInvoiceT>(response.Content);
                AssertSuccess(invoice);
                Trace.WriteLine($"Invoice Id: {invoice.Value.ID}");
            }
            else
            {
                Assert.Fail();
            }
        }

        public void AssertSuccess(PagedActionResultsOfBusTransSearchResultsT response)
        {
            var msg = response.Messages?.FirstOrDefault();
            Trace.WriteLine($"AssertSuccess ({response.IsSuccess}): {msg}");
            Assert.IsTrue(response.IsSuccess ?? false, msg);
        }
        public void AssertSuccess(TransactionEditResponseOfInvoiceT response)
        {
            var msg = response.Messages?.FirstOrDefault();
            Trace.WriteLine($"AssertSuccess ({response.IsSuccess}): {msg}");
            Assert.IsTrue(response.IsSuccess ?? false, msg);
        }

    }
}