using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Swagger.Api;
using Swagger.Client;
using Swagger.Model;

namespace SDK.SpendaApi.Examples
{
    public class Customer
    {
        private ApiClient baseClient { get; set; }

        public Customer(ApiClient baseClient)
        {
            this.baseClient = baseClient;
        }

        public List<CustomerT> GetAllCustomers(bool? isFilterExactMatch = false, bool? isFilterAsc = false, int maxRows = 10, string search = "", string filterSortField = "")
        {
            var customerClient = new CustomersApi(baseClient);
            var status = new List<string>() { "0", "1" };
            var result = customerClient.CustomersGet(null, null, null, null, null, null, status, search, isFilterExactMatch, null, null, null, null, filterSortField, isFilterAsc, null, maxRows);

            return result.Value;
        }

        public List<CustomerT> GetCustomerSearchByNameRefNumber()
        {
            string name = "";
            string refNumber = "";

            var customerClient = new CustomersApi(baseClient);
            var status = new List<string>() { "o", "d" };
            var result = customerClient.CustomersGet(null, null, null, null, null, null, status, string.Empty, null, null, null, null, null, string.Empty, null, null, 10);

            return result.Value;
        }

        public CustomerT GetCustomerById(int Id)
        {
            var customerClient = new CustomersApi(baseClient);
            var result = customerClient.CustomersGetByID(Id, null, null, null, null, null, null);

            return result.Value;

        }

        public SynkSaveQueueResponseOfCustomerT CreateCustomer()
        {
            var newCustomer = getCustomerObject();
            var customerClient = new CustomersApi(baseClient);
            var result = customerClient.CustomersPost(newCustomer);

            return result;
        }

        public SynkSaveQueueResponseOfCustomerT UpdateCustomer()
        {
            var newCustomer = getCustomerObject(180620, "CU-000080");
            var customerClient = new CustomersApi(baseClient);
            var result = customerClient.CustomersPut(newCustomer, newCustomer._Object.ID);

            return result;
        }

        public SaveRequestOfCustomerT getCustomerObject(int? Id = null, string refNumber = null)
        {
            var newCustomer = new SaveRequestOfCustomerT
            {
                _Object = new CustomerT
                {
                    Contacts = new List<ContactT> {
                        new ContactT {
                            IsPrimaryContact = true,
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            IsActive = true
                        }
                    },
                    CompanyName = "Wayne Industries",
                    IsActive = true,
                    IsIndividual = false,
                    ID = Id,
                    RefNumber = refNumber,
                    Locations = new List<LocationT> {
                        new LocationT {
                            IsActive = true,
                            UtcOffset = 480,
                            IsDefaultLocation = true,
                            TimeZoneName = "Australia/Perth",
                            Addresses = new List<AddressT>()
                        }
                    }
                }
            };

            return newCustomer;
        }

    }
}
