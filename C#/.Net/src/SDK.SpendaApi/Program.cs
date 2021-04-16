using System;
using System.Net.Http;
using Swagger.Api;
using Swagger.Client;
using Swagger.Model;
using SDK.SpendaApi.Examples;

namespace SDK.SpendaApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var apiClient = new ApiClient();

            apiClient.DefaultHeader.Add("Authorization", "Bearer QvnD0d6HPadCihauxwKlzccxo3tjWLDHooy5VgooJvE0IcfXR0rZqrLqlFJS8qIHl5cZxUB5D7ZSGPK9zzUf6jwWtzaM12dEHCP1xEHD2Cq72DZQPlGXZXKUDKg3dAmc32yttFhWM11ciIIez1i0K3JBDq5tdk59HA4pKz24URcCb2-1H9P27sRSgIh49sHKQniXMLzsIK3FSYHQB1ZqP3INYsfx2uu1F-gmcwqWDLgCi6nOwgSM7eFG6aIq_dubvFMHHsNoe7W9J-zBLev_PDMJen4VTFJGOE6cZ7p9bqPx4auEmr28vHRW8jBvSfNL-_qiOI5wcVEr9l0eHi6I37gl7M6-iX5zsOa8WKE6doXiRU7sZWAr_-05qxhG9uCiS63yfJvpo2yrhq4YEmy2gMT4J1-jUAV7RbXc6_iP8yvT1gBQ23iMwqd2TtfgKA6zzE6CE95kRMhQp4lHrIX9W2keQRCCGmGrFLthF19QMlXP6gStkMRAFJt0WJCOYNnZBobnu9HiIt_VfKPIJHOhLD6dx7A973KprALHo1Pnhtg3h4qTb_l1LApAqTJUfp-orJwmAUPuk-ESpGRB4CmVJl0BIKw");

            GetAllCustomers(apiClient);
            //GetCustomerById(apiClient);
            //CreateCustomer(apiClient);
            //UpdateCustomer(apiClient);
            
        }

        #region Customers
        public static void GetAllCustomers(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customers = customerClient.GetAllCustomers();

            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Id:{item.ID} \nCustomer RefNumber: { item.RefNumber} ");
            }
        }

        public static void GetCustomerById(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);            
            var customer = customerClient.GetCustomerById(180620);

            if (customer == null) return;

            Console.WriteLine($"Customer Id:{customer.ID} \nCustomer RefNumber: { customer.RefNumber} ");

        }

        public static void SearchCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);
            var customers = customerClient.GetAllCustomers(null, true, 10, "CU-000080", "ID");

            foreach (var item in customers)
            {
                Console.WriteLine($"Customer Id:{item.ID} \nCustomer RefNumber: { item.RefNumber} ");
            }
        }

        public static void CreateCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);

            var customer= customerClient.CreateCustomer();

            var isSuccess = customer.IsSuccess.HasValue ? customer.IsSuccess.Value : false;
            if (isSuccess && customer._Object != null)
            {
                Console.WriteLine($"Customer Id:{customer._Object.ID} Customer RefNumber: { customer._Object.RefNumber}");
            }
        }

        public static void UpdateCustomer(ApiClient apiClient)
        {
            var customerClient = new Customer(apiClient);

            var customer = customerClient.UpdateCustomer();

            var isSuccess = customer.IsSuccess.HasValue ? customer.IsSuccess.Value : false;
            if (isSuccess && customer._Object != null)
            {
                Console.WriteLine($"Customer Id:{customer._Object.ID} Customer RefNumber: { customer._Object.RefNumber}");
            }
        }
        #endregion
    }
}
