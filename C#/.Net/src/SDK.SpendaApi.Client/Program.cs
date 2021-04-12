using System;
using System.Collections.Generic;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiInstance = new CustomersApi();
            var filterGetIsValidForBillToOnly = true;  // bool? |  (optional) 
            var filterIsLinkedCustomersOnly = true;  // bool? |  (optional) 
            var filterCustomerClassID = 56;  // int? |  (optional) 
            var filterIsShowAccountCustomersOnly = true;  // bool? | true - Account Customers only, false - Operational Customers only, not set - Both Customer Types (optional) 
            var filterAccountCustomerID = 56;  // int? |  (optional) 
            var filterIsCODorPrePaidAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterStatus = new List<string>(); // List<string> | CustomerStatusTypes - New = 0, Active = 1, Suspended = 2, Declined = 3 (optional) 
            var filterSearch = "";  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterSortField = "";  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterLastRowNumber = 789;  // long? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 

            try
            {
                PagedActionResultsOfCustomers result = apiInstance.CustomersGet(filterGetIsValidForBillToOnly, filterIsLinkedCustomersOnly, filterCustomerClassID, filterIsShowAccountCustomersOnly, filterAccountCustomerID, filterIsCODorPrePaidAccountCustomersOnly, filterStatus, filterSearch, filterIsExactMatch, filterIncludeDeleted, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterSortField, filterSortAsc, filterLastRowNumber, filterMaxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGet: " + e.Message);
            }
        }
    }
}
