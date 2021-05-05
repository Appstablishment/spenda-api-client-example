using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class PaymentTests : BaseTests
    {
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Payment 
        /// </api>
        /// API to search all of the Sales Order.
        /// </summary>
        /// <param name="maxNoOfRecords"></param>
        /// <param name="transactionTypeDatTypeID"></param>
        /// <param name="includeLogs"></param>
        /// <returns></returns>
        public List<PaymentT> SearchPayments(int maxNoOfRecords = 10,
                                             int? transactionTypeDatTypeID = null,
                                             bool? includeLogs = null)
        {
            var request = new RestRequest("/api/Payment");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.transactionTypeDatTypeID", transactionTypeDatTypeID);
            request.AddParameter("filter.includeLogs", includeLogs);

            var response = Get<PagedActionResultsOfPayments>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetAllPaymentsTests()
        {
            var payments = SearchPayments();

            foreach (var payment in payments)
            {
                Trace.WriteLine($"Payment Id: {payment.ID} , Payment refNumber: {payment.RefNumber}");
            }
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/Payment/{id}
        /// </api>
        /// API to get a specific payment.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PaymentT GetPaymentByID(int id)
        {
            var request = new RestRequest($"/api/Payment/{id}");
            
            var response = Get<EditResponseOfPaymentT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            PaymentT payment = response.Value;

            Assert.IsNotNull(payment);

            Trace.WriteLine($"Payment Id: {payment.ID}, Payment RefNumber: {payment.RefNumber}");

            return payment;
        }

        /// <summary>
        /// Get a payment by its ID
        /// </summary>
        [TestMethod()]
        public void GetPaymentByIdTest()
        {
            //select any payments
            var payments = SearchPayments();

            if (!(payments?.Any() ?? false)) Assert.Fail("Payments found");

            //select the any payment ID
            var paymentID = PickOne<PaymentT>(payments).ID;

            // Get the payment by ID
            var payment = GetPaymentByID(paymentID.Value);

            Assert.IsNotNull(payment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="invoices"></param>
        /// <param name="salesOrder"></param>
        /// <returns></returns>
        public SynkValidation CreateNewPayment(CustomerT customer, InvoiceT invoices = null, BusTransSearchResultT salesOrder = null)
        {
            var newPayment = Mocks.Payment.Get(customer, invoices, salesOrder);
            var body = JsonConvert.SerializeObject(newPayment);

            var request = new RestRequest("/api/Payment/");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = Post<SynkSaveQueueResponseOfPaymentT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);
            return response.Value;
        }

        /// <summary>
        /// Post a new payment getting a random operational customer and a random sale order
        /// </summary>
        [TestMethod()]
        public void CreateSalesOrdersPayment_Test()
        {
            // Get a collection of customers and pick one randomly
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            // Get a collection of customers and pick one randomly
            var salesOrderTest = new SalesOrdersTests();
            var salesOrder = salesOrderTest.SearchSalesOrders();
            var randomSalesOrder = PickOne<BusTransSearchResultT>(salesOrder);

            //post new sale order based on inventories and customer
            var payment = CreateNewPayment(randomCustomer, null, randomSalesOrder);

            Trace.WriteLine($"Payment Id: {payment.ID}, Payment RefNumber: {payment.RefNumber}");
        }

        /// <summary>
        /// Post a new payment getting a random operational customer and a random sale order
        /// </summary>
        [TestMethod()]
        public void CreateInvoicePayment_Test()
        {
            // Get a collection of customers and pick one randomly
            var customerTest = new CustomerTests();
            var customer = customerTest.SearchCustomers(true, 10);
            var randomCustomer = PickOne<CustomerT>(customer);

            // Get a collection of customers and pick one randomly
            var salesOrderTest = new SalesOrdersTests();
            var salesOrder = salesOrderTest.SearchSalesOrders();
            var randomSalesOrder = PickOne<BusTransSearchResultT>(salesOrder);

            //post new sale order based on inventories and customer
            var payment = CreateNewPayment(randomCustomer, null, randomSalesOrder);

            Trace.WriteLine($"Payment Id: {payment.ID}, Payment RefNumber: {payment.RefNumber}");
        }
    }
}
