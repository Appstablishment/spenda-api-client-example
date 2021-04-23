using System;
using System.Net.Http;
using Swagger.Api;
using Swagger.Client;
using Swagger.Model;
using SDK.SpendaApi.Examples;
using System.Linq;
using System.Collections.Generic;

namespace SDK.SpendaApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TODO
            var apiClient = new ApiClient();
            //Login(apiClient);

            apiClient.DefaultHeader.Add("Authorization", "Bearer jIw2LfBwdwScfT-RH6l3KVaeZ1xxerUiqvjXiCQ_TRV993ff6Vfher6hWx8M0nyC_XB5clBTfoWnPsRYqi2xCWAAdExbpOsL5ijq4qJRYRAeOCxQCDs5Jo-ktHsY3mYR_mDKqi33eAhf6p-FYlGISYES0ZGQ3Lr5YjfutOxiO8v2Dj2qPtJZ5q-H_4Pfe9f8ChJ2HAheqlhSO0LQw9NBBrJDhDMSzWkgiO2w41VfrQX9D1QTLu5FDLJ1hWB121YtAJxHcgQgO-oOvEhcLepIoXr0yj3R5nrZT9PoiQJsBH5raJibFptRFrj2yr3Z2PjqTVYln1SHrlDAuyzsxLAtaliXCHypXlIZtK-slu7FvrSeXhljDjFLvAMCh9A97-Y1B8TcJkDUFyhsMlniDJhOVpnuOAof8ItsakzY2G27a-lv_D4pZtxQPPsOAFcLvMVEfboCfmv_mwikv_KBunXAKklokAPyYAH1f6D7npcPdP6C26mIt607RY4Ha1hOxCvQ74JwTjfmZMrQskXRMtfkmkhqyj4PEJQevn4yUoRb_uqiy5Wsn2qMc69gU8J9yQI69nFSle__qz3vkDEXEwPWJ_aDVebEYKzSTLT-4bBmMD4Q1pX1");

            TestCase(apiClient);
            //===Customer===//
            //GetAllCustomers(apiClient);
            //GetCustomerById(apiClient);
            //CreateCustomer(apiClient);
            //UpdateCustomer(apiClient);
            //GetAndUpdateCustomer(apiClient);

            //===Inventory===//
            // GetAllInventory(apiClient);
            // SearchInventory(apiClient);
            //GetAllInventoryById(apiClient);
            //CreateInventory(apiClient);
            //GetAndUpdateInventory(apiClient);
            //UpdateInventory(apiClient);

            //===Invoice===//
            //CreateInvoice(apiClient);
            //GetInvoiceById(apiClient);

            //===Payment===//
            //CreatePayment(apiClient);
            //GetPaymentId(apiClient);
        }

        #region Authentication
        public static void Login(ApiClient apiClient)
        {
            var contentType = "application/x-www-form-urlencoded";

            var accountClient = new AccountApi(apiClient);

            accountClient.AuthorisationLogin(contentType, "");
        }
        #endregion

        public static void TestCase(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customerPost = customerClient.CreateCustomer(customerClient.getCustomerObject());
            var isSuccess = customerPost.IsSuccess.HasValue ? customerPost.IsSuccess.Value : false;

            if (!isSuccess && customerPost._Object == null) return;

            var customer = customerClient.GetCustomerById(customerPost.Value.ID??0);

            var inventoryClient = new Inventory(apiClient);
            var inventoryPost = inventoryClient.InventoryPost(inventoryClient.getInventoryObject());
            isSuccess = inventoryPost.IsSuccess.HasValue ? inventoryPost.IsSuccess.Value : false;
            
            if (!isSuccess && inventoryPost.Value == null) return;

            var inventory = inventoryClient.InventoryGet(inventoryPost.Value.ID??0);
            var inventories = new List<InventoryItemT>() { inventory };

            var invoiceClient = new Invoices(apiClient);
            var invoicePost = invoiceClient.CreateInvoice(invoiceClient.GetInvoiceObject(customer, inventories));
            isSuccess = invoicePost.IsSuccess.HasValue ? invoicePost.IsSuccess.Value : false;

            if (!isSuccess && invoicePost.Value == null) return;

            var invoice = invoiceClient.GetInvoiceById(invoicePost.Value.ID??0);

            if (invoice == null) return;

            var paymentClient = new Payment(apiClient);

            var payment = paymentClient.CreatePayment(paymentClient.GetPaymentObject(invoice, customer));
        }

        #region Customers
        /// <summary>
        /// Retrieve all Operational Customers for the current Tenant
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetAllCustomers(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customers = customerClient.GetAllCustomers();

            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Id:{item.ID} \nCustomer RefNumber: { item.RefNumber} ");
            }
        }

        /// <summary>
        /// get an operational customer based on its ID
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetCustomerById(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customer = customerClient.GetCustomerById(180620);

            if (customer == null) return;

            Console.WriteLine($"Customer Id:{customer.ID} \nCustomer RefNumber: { customer.RefNumber} ");

        }

        /// <summary>
        /// Search Customer based on filters and retrieves the number of rows asked.
        /// </summary>
        /// <param name="apiClient"></param>
        public static void SearchCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customers = customerClient.GetAllCustomers(null, true, 10, "CU-000080", "ID");

            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Id:{item.ID} \nCustomer RefNumber: { item.RefNumber} ");
            }
        }

        /// <summary>
        /// Create a new operational customer. when its saved the API will return Customer's Id. 
        /// RefNumber attribute can be used to stored the Customer ID from the third party system
        /// </summary>
        /// <param name="apiClient"></param>
        public static void CreateCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customer = customerClient.CreateCustomer(customerClient.getCustomerObject());

            var isSuccess = customer.IsSuccess.HasValue ? customer.IsSuccess.Value : false;
            if (isSuccess && customer._Object != null)
            {
                Console.WriteLine($"Customer Id:{customer._Object.ID} Customer RefNumber: { customer._Object.RefNumber}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void UpdateCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customer = customerClient.UpdateCustomer(customerClient.getCustomerObject(180620, "CU-000080"));

            var isSuccess = customer.IsSuccess.HasValue ? customer.IsSuccess.Value : false;
            if (isSuccess && customer._Object != null)
            {
                Console.WriteLine($"Customer Id:{customer._Object.ID} Customer RefNumber: { customer._Object.RefNumber}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetAndUpdateCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customers = customerClient.GetAllCustomers(false, true, 1, "Bruce", "ID");

            if (customers != null && customers.Count > 0)
            {
                customers.FirstOrDefault().Name = "Tony";
                customers.FirstOrDefault().CompanyName = "stark Industries";
            }

            var updateCustomer = new SaveRequestOfCustomerT { _Object = customers.FirstOrDefault() };

            var customer = customerClient.UpdateCustomer(updateCustomer);

            var isSuccess = customer.IsSuccess.HasValue ? customer.IsSuccess.Value : false;
            if (isSuccess && customer._Object != null)
            {
                Console.WriteLine($"Customer Id:{customer._Object.ID} Customer RefNumber: { customer._Object.RefNumber}");
            }
        }
        #endregion

        #region Inventory
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetAllInventory(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.GetAllInventory();

            foreach (var item in inventory)
            {
                Console.WriteLine($"Inventory Id:{item.ID}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void SearchInventory(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.GetAllInventory(null, null, null, null, null, null, null, null, null, null, null, null, null, "HB001");

            foreach (var item in inventory)
            {
                Console.WriteLine($"Inventory Id:{item.ID}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetAllInventoryById(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            // var inventory = inventoryClient.SearchInventory(null, null, null, null,null,null,null,null,null,null,null,null, null, null, null, null, null,1048989 );
            var inventory = inventoryClient.InventoryGet(1048989);
            if (inventory == null) return;

            Console.WriteLine($"Inventory Id:{inventory.ID}");
        }
        /// <summary>
        /// Create a new inventory then return Inventiory ID when its saved
        /// </summary>
        /// <param name="apiClient"></param>
        public static void CreateInventory(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.InventoryPost(inventoryClient.getInventoryObject());

            var isSuccess = inventory.IsSuccess.HasValue ? inventory.IsSuccess.Value : false;
            if (isSuccess && inventory.Value != null)
            {
                Console.WriteLine($"Inventory Id:{inventory.Value.ID}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void GetAndUpdateInventory(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.GetAllInventory(null, null, null, null, null, null, null, null, null, null, null, null, null, "IC1234");

            if (inventory != null && inventory.Count > 0)
            {
                inventory.FirstOrDefault().ShortDescription = "SOAP";
                inventory.FirstOrDefault().Description = "SOAP PRODUCT";
            }

            var updateInventory = new InventorySaveRequest { _Object = inventory.FirstOrDefault() };

            var inventoryUpdate = inventoryClient.InventoryPut(updateInventory);

            var isSuccess = inventoryUpdate.IsSuccess.HasValue ? inventoryUpdate.IsSuccess.Value : false;
            if (isSuccess && inventoryUpdate.Value != null)
            {
                Console.WriteLine($"Inventory Id:{inventoryUpdate.Value.ID}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        public static void UpdateInventory(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.InventoryPut(inventoryClient.getInventoryObject(1052527));

            var isSuccess = inventory.IsSuccess.HasValue ? inventory.IsSuccess.Value : false;
            if (isSuccess && inventory.Value != null)
            {
                Console.WriteLine($"Inventory Id:{inventory.Value.ID}");
            }
        }

        #endregion

        #region Invoices
        public static void CreateInvoice(ApiClient apiClient)
        {
            var inventoryClient = new Inventory(apiClient);
            var inventory = inventoryClient.InventoryGet(1048989);
            var inventories = new List<InventoryItemT>() { inventory };

            var customerClient = new Customer(apiClient);
            var customer = customerClient.GetCustomerById(180620);

            var invoiceClient = new Invoices(apiClient);

            var invoice = invoiceClient.CreateInvoice(invoiceClient.GetInvoiceObject(customer, inventories));

            var isSuccess = invoice.IsSuccess.HasValue ? invoice.IsSuccess.Value : false;
            if (isSuccess && invoice.Value != null)
            {
                Console.WriteLine($"Customer Id:{invoice.Value.ID} Customer RefNumber: { invoice.Value.RefNumber}");
            }
        }

        public static void GetInvoiceById(ApiClient apiClient)
        {
            var invoiceClient = new Invoices(apiClient);
            var invoice = invoiceClient.GetInvoiceById(488284);

            if (invoice == null) return;

            Console.WriteLine($"Customer Id:{invoice.ID} \nCustomer RefNumber: { invoice.RefNumber} ");
        }
        #endregion

        #region Payment
        public static void CreatePayment(ApiClient apiClient)
        {
            var invoiceClient = new Invoices(apiClient);
            var invoice = invoiceClient.GetInvoiceById(488284);

            var customerClient = new Customer(apiClient);
            var customer = customerClient.GetCustomerById(180620);

            var paymentClient = new Payment(apiClient);

            var payment = paymentClient.CreatePayment(paymentClient.GetPaymentObject(invoice, customer));

            var isSuccess = payment.IsSuccess.HasValue ? payment.IsSuccess.Value : false;
            if (isSuccess && payment.Value != null)
            {
                Console.WriteLine($"Customer Id:{payment.Value.ID} Customer RefNumber: { payment.Value.RefNumber}");
            }
        }

        public static void GetPaymentId(ApiClient apiClient)
        {
            var invoiceClient = new Invoices(apiClient);
            var invoice = invoiceClient.GetInvoiceById(488284);

            if (invoice == null) return;

            Console.WriteLine($"Customer Id:{invoice.ID} \nCustomer RefNumber: { invoice.RefNumber} ");
        }
        #endregion
    }
}
