using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class PaymentTests : BaseTests
    {
        [TestMethod()]
        public void PaymentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllPaymentsTests()
        {
            var request = new RestRequest("/api/Payment");
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfPayments>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);

            foreach (var payment in obj.Value)
            {
                Trace.WriteLine($"Payment Id: {payment.ID} , Payment refNumber: {payment.RefNumber}");
            }
        }

        [TestMethod()]
        public void GetPaymentByIdTest()
        {
            var paymentId = 488284;
            var url = "/api/Payment/{id}";
            url = url.Replace("{id}", paymentId.ToString());

            var request = new RestRequest(url);
            //request.AddParameter("req.iD", 971609);
            //request.AddParameter("req.gUID", 971609);
            //request.AddParameter("req.isGetExtraInfo", false);
            //request.AddParameter("req.tenantID", 971609);

            var obj = Get<EditResponseOfPaymentT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Payment Id: {obj.Value.ID}  Payment RefNumber: {obj.Value.RefNumber}");
        }

        [TestMethod()]
        public void CreatePaymentTest()
        {
            var url = $"/api/v3/Customers";
            var request = new RestRequest(url);
            request.AddParameter("filter.maxResults", 20);
            var customer = Get<PagedActionResultsOfCustomers>(request);

            Assert.AreNotEqual(customer.Value.Count, 0);

            var randomCustomer = pickAny<CustomerT>(customer.Value, 1);

            request = new RestRequest("/api/Invoice");
            request.AddParameter("filter.maxResults", 20);
            request.AddParameter("filter.statusStrings", "open");
            var invoice = Get<PagedActionResultsOfBusTransSearchResultsT>(request);

            Assert.AreNotEqual(invoice.Value.Count, 0);

            var randomInvoices = pickAny<BusTransSearchResultT>(invoice.Value, 3);

            var body = JsonConvert.SerializeObject(Mocks.Payment.GetPaymentObject(randomInvoices, randomCustomer[0]));

            request = new RestRequest("/api/Payment/");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponseOfPaymentT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Payment Id: {obj.Value.ID}  Payment RefNumber: {obj.Value.RefNumber}");
        }
    }
}
