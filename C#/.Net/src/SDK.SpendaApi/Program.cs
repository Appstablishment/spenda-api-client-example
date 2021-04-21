using System;
using System.Net.Http;
using Swagger.Api;
using Swagger.Client;
using Swagger.Model;
using SDK.SpendaApi.Examples;
using System.Linq;

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

            apiClient.DefaultHeader.Add("Authorization", "Bearer QvnD0d6HPadCihauxwKlzccxo3tjWLDHooy5VgooJvE0IcfXR0rZqrLqlFJS8qIHl5cZxUB5D7ZSGPK9zzUf6jwWtzaM12dEHCP1xEHD2Cq72DZQPlGXZXKUDKg3dAmc32yttFhWM11ciIIez1i0K3JBDq5tdk59HA4pKz24URcCb2-1H9P27sRSgIh49sHKQniXMLzsIK3FSYHQB1ZqP3INYsfx2uu1F-gmcwqWDLgCi6nOwgSM7eFG6aIq_dubvFMHHsNoe7W9J-zBLev_PDMJen4VTFJGOE6cZ7p9bqPx4auEmr28vHRW8jBvSfNL-_qiOI5wcVEr9l0eHi6I37gl7M6-iX5zsOa8WKE6doXiRU7sZWAr_-05qxhG9uCiS63yfJvpo2yrhq4YEmy2gMT4J1-jUAV7RbXc6_iP8yvT1gBQ23iMwqd2TtfgKA6zzE6CE95kRMhQp4lHrIX9W2keQRCCGmGrFLthF19QMlXP6gStkMRAFJt0WJCOYNnZBobnu9HiIt_VfKPIJHOhLD6dx7A973KprALHo1Pnhtg3h4qTb_l1LApAqTJUfp-orJwmAUPuk-ESpGRB4CmVJl0BIKw");

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
            UpdateInventory(apiClient);
        }

        #region Authentication
        public static void Login(ApiClient apiClient)
        {
            var grantType = "password";
            var username = "fabian.moreno+wooBug@appstab.co";
            var password = "1qwerty";
            var client_id = 1;
            var contentType = "application/x-www-form-urlencoded";

            apiClient.DefaultHeader.Add("grant_type", grantType);
            apiClient.DefaultHeader.Add("username", username);
            apiClient.DefaultHeader.Add("password", password);
            apiClient.DefaultHeader.Add("client_id", client_id.ToString());

            var accountClient = new AccountApi(apiClient);

            accountClient.AuthorisationLogin(contentType, "");
        }
        #endregion

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
            var customer= customerClient.CreateCustomer(customerClient.getCustomerObject());

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
            var inventory = inventoryClient.GetAllInventory(null, null, null, null,null,null,null,null,null,null,null,null, null, "HB001");

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
            var inventory= inventoryClient.InventoryPost(inventoryClient.getInventoryObject());
    
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
            var inventory = inventoryClient.GetAllInventory(null, null, null, null,null,null,null,null,null,null,null,null, null, "IC1234");

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
    }
}
