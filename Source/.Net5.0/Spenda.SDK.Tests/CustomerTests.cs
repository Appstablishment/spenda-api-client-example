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
    public class CustomerTests : BaseTests
    {
        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/v3/Customers 
        /// </api>
        /// API to search all of the Operational Customers.
        /// </summary>
        /// <param name="isAccountCustomers"> true : Account Customers, false : Operational Customers </param>
        /// <param name="maxNoOfRecords"> Total number of records to return. </param>
        /// <param name="searchString"> Search string </param>
        /// <returns></returns>
        public List<CustomerT> SearchCustomers(bool isAccountCustomers, 
                                               int maxNoOfRecords = 10, 
                                               string searchString = null, 
                                               bool isExactMatch = false)
        {
            var request = new RestRequest("/api/v3/Customers");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);
            request.AddParameter("filter.IsShowAccountCustomersOnly", isAccountCustomers);

            //Optional parameters
            request.AddParameter("filter.search", searchString); // For this example we're assuming the search string is the Business Name
            request.AddParameter("filter.isExactMatch", isExactMatch);
            
            request.AddParameter("filter.sortField", "Name"); // Options include : Name, RefNumber, Phone1, ABN, CreatedDateTime, and ModifiedDateTime
            request.AddParameter("filter.sortAsc", true);

            var response = Get<PagedActionResultsOfCustomers>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        /// <summary>
        /// Get a collection of Operational Customers
        /// </summary>
        [TestMethod()]
        public void GetOperationalCustomers_Test()
        {
            var customers = SearchCustomers(isAccountCustomers: false);

            //loop through to display the records
            foreach (var customer in customers)
            {
                Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
            }
        }

        /// <summary>
        /// Get a collection of Account Customers
        /// </summary>
        [TestMethod()]
        public void GetAccountCustomers_Test()
        {
            var customers = SearchCustomers(isAccountCustomers: true);

            //loop through to display the records
            foreach (var customer in customers)
            {
                Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
            }
        }

        [TestMethod()]
        [DataRow("Bruce")]
        [DataRow("John")]
        [DataRow("Bill")]
        public void SearchOperationalCustomersByName_Test(string name)
        {
            var customers = SearchCustomers(isAccountCustomers: false, maxNoOfRecords: 10, searchString: name);

            foreach (var customer in customers)
            {
                Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");
            }
        }

        /// <summary>
        /// Call the 
        /// <api>
        /// GET /api/v3/Customers/{id}
        /// </api>
        /// API to get a specific Customer.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CustomerT GetCustomerByID(int id)
        {
            var request = new RestRequest($"/api/v3/Customers/{id}");

            var response = Get<EditResponseOfCustomerT>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            CustomerT customer = response.Value;

            Assert.IsNotNull(customer);

            Trace.WriteLine($"Customer Name: {customer.Name} {customer.Name2}, Customer Id: {customer.ID}");

            return customer;
        }

        /// <summary>
        /// Perform a search by name and use the ID to get a selected customer.
        /// </summary>
        [TestMethod()]
        [DataRow("Bruce")]
        public void GetAnOperationalCustomerByID_Test(string searchString)
        {
            // Get all customers first just so that we can get a valid ID
            var customers = SearchCustomers(isAccountCustomers: false, 10, searchString);

            if (!(customers?.Any() ?? false)) Assert.Fail("Customers found");

            //select the top customer ID
            var customerID = customers.FirstOrDefault()?.ID;

            Assert.IsNotNull(customerID);

            // Get the customer by ID
            var customer = GetCustomerByID(customerID.Value);

            Assert.IsNotNull(customer);
        }

        [TestMethod()]
        public void CreateNewOperationalCustomer_Test()
        {
            var newCustomer = Mocks.Customer.Get();

            var searchString = newCustomer.Object.Name;

            Assert.IsNotNull(searchString);

            // Search for existing customer record
            var customers = SearchCustomers(isAccountCustomers: false, 10, searchString, isExactMatch: true);

            if (customers?.Any() ?? false)
            {
                Assert.Fail($"Customer {searchString} already found");
                // Update ?
            }
            else
            {
                var body = JsonConvert.SerializeObject(newCustomer);

                var request = new RestRequest("/api/v3/Customers");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                var obj = Post<SynkSaveQueueResponseOfCustomerT>(request);

                AssertSuccess(obj.Messages, obj.IsSuccess);
                Trace.WriteLine($"Customer Ref Number: {obj.Value.RefNumber}, Customer Id: {obj.Value.ID}");
            }
            
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            var customerId = 971609;
            var refNumber = "CU-000004";
            var body = JsonConvert.SerializeObject(Mocks.Customer.Get(customerId, refNumber));

            var request = new RestRequest($"/api/v3/Customers?id={customerId}");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Put<SynkSaveQueueResponseOfCustomerT>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Customer Ref Number: {obj.Value.RefNumber}, Customer Id: {obj.Value.ID}");
        }
    }
}