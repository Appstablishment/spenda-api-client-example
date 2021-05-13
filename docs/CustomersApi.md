# IO.Swagger.Api.CustomersApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomersAccountExemptFromMerchantSurcharge**](CustomersApi.md#customersaccountexemptfrommerchantsurcharge) | **POST** /api/Customers/{customerID}/accountexemptfrommerchantsurcharge | Customers_AccountExemptFromMerchantSurcharge
[**CustomersDelete**](CustomersApi.md#customersdelete) | **DELETE** /api/v3/Customers/{id} | Customers_Delete
[**CustomersGet**](CustomersApi.md#customersget) | **GET** /api/v3/Customers | Customers_Get
[**CustomersGetAccountCustomerForOperational**](CustomersApi.md#customersgetaccountcustomerforoperational) | **GET** /api/v3/Customers/{id}/account | Customers_GetAccountCustomerForOperational
[**CustomersGetByID**](CustomersApi.md#customersgetbyid) | **GET** /api/v3/Customers/{id} | Customers_GetByID
[**CustomersGetCustomersWithUnpaidInvoices**](CustomersApi.md#customersgetcustomerswithunpaidinvoices) | **GET** /api/Customers/unpaidinvoices | Customers_GetCustomersWithUnpaidInvoices
[**CustomersGetMerchantSurcharge**](CustomersApi.md#customersgetmerchantsurcharge) | **POST** /api/Customers/{customerID}/merchantsurcharge | Customers_GetMerchantSurcharge
[**CustomersGetMerchantSurchargeForTransactions**](CustomersApi.md#customersgetmerchantsurchargefortransactions) | **POST** /api/Customers/{customerID}/merchantsurcharge/{paymentMethod} | Customers_GetMerchantSurchargeForTransactions
[**CustomersGetOperationalCustomersForAnAccountCustomer**](CustomersApi.md#customersgetoperationalcustomersforanaccountcustomer) | **GET** /api/v3/Customers/{id}/operational | Customers_GetOperationalCustomersForAnAccountCustomer
[**CustomersLinkCustomer**](CustomersApi.md#customerslinkcustomer) | **PUT** /api/v3/Customers/{id}/link | Customers_LinkCustomer
[**CustomersPost**](CustomersApi.md#customerspost) | **POST** /api/v3/Customers | Customers_Post
[**CustomersPut**](CustomersApi.md#customersput) | **PUT** /api/v3/Customers | Customers_Put
[**CustomersSetClass**](CustomersApi.md#customerssetclass) | **PUT** /api/v3/Customers/{id}/class | Customers_SetClass
[**CustomersUnlinkCustomer**](CustomersApi.md#customersunlinkcustomer) | **PUT** /api/v3/Customers/{id}/unlink | Customers_UnlinkCustomer

<a name="customersaccountexemptfrommerchantsurcharge"></a>
# **CustomersAccountExemptFromMerchantSurcharge**
> ActionResults CustomersAccountExemptFromMerchantSurcharge (int? customerID, bool? isExempt)

Customers_AccountExemptFromMerchantSurcharge

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersAccountExemptFromMerchantSurchargeExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var customerID = 56;  // int? | Format - int32.
            var isExempt = true;  // bool? |  (optional) 

            try
            {
                // Customers_AccountExemptFromMerchantSurcharge
                ActionResults result = apiInstance.CustomersAccountExemptFromMerchantSurcharge(customerID, isExempt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersAccountExemptFromMerchantSurcharge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerID** | **int?**| Format - int32. | 
 **isExempt** | **bool?**|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersdelete"></a>
# **CustomersDelete**
> ActionResults CustomersDelete (int? id)

Customers_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersDeleteExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Customers_Delete
                ActionResults result = apiInstance.CustomersDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersget"></a>
# **CustomersGet**
> PagedActionResultsOfCustomers CustomersGet (bool? filterGetIsValidForBillToOnly, bool? filterIsLinkedCustomersOnly, int? filterCustomerClassID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List filterStatus, string filterSearch, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, bool? filterSortAsc, int? filterLastRowNumber, int? filterMaxResults)

Customers_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var filterGetIsValidForBillToOnly = true;  // bool? |  (optional) 
            var filterIsLinkedCustomersOnly = true;  // bool? | true - Customers are linked to an account, false - Customers are not linked to an account, not set - both both Customer Types (optional) 
            var filterCustomerClassID = 56;  // int? | Format - int32. Customers who belong to the specified Customer Class ID (optional) 
            var filterIsShowAccountCustomersOnly = true;  // bool? | true - Account Customers only, false - Operational Customers only, not set - Both Customer Types (optional) 
            var filterAccountCustomerID = 56;  // int? | Format - int32. (optional) 
            var filterIsCODorPrePaidAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterStatus = new List(); // List | CustomerStatusTypes - New = 0, Active = 1, Suspended = 2, Declined = 3 (optional) 
            var filterSearch = filterSearch_example;  // string | character string to filter customer's search (optional) 
            var filterIsExactMatch = true;  // bool? | true - search character will bring data that matches, false - search charater will bring data that partially matches the data (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string | specify the customer field to be sorted (optional) 
            var filterSortAsc = true;  // bool? | true - sort results in ascending order by SortField, false - sort results in descending order by SortField (optional) 
            var filterLastRowNumber = 56;  // int? | Format - int64. (optional) 
            var filterMaxResults = 56;  // int? | Format - int32. Get the specify number of Customers in the result payload (optional) 

            try
            {
                // Customers_Get
                PagedActionResultsOfCustomers result = apiInstance.CustomersGet(filterGetIsValidForBillToOnly, filterIsLinkedCustomersOnly, filterCustomerClassID, filterIsShowAccountCustomersOnly, filterAccountCustomerID, filterIsCODorPrePaidAccountCustomersOnly, filterStatus, filterSearch, filterIsExactMatch, filterIncludeDeleted, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterSortField, filterSortAsc, filterLastRowNumber, filterMaxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterGetIsValidForBillToOnly** | **bool?**|  | [optional] 
 **filterIsLinkedCustomersOnly** | **bool?**| true - Customers are linked to an account, false - Customers are not linked to an account, not set - both both Customer Types | [optional] 
 **filterCustomerClassID** | **int?**| Format - int32. Customers who belong to the specified Customer Class ID | [optional] 
 **filterIsShowAccountCustomersOnly** | **bool?**| true - Account Customers only, false - Operational Customers only, not set - Both Customer Types | [optional] 
 **filterAccountCustomerID** | **int?**| Format - int32. | [optional] 
 **filterIsCODorPrePaidAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterStatus** | [**List**](.md)| CustomerStatusTypes - New &#x3D; 0, Active &#x3D; 1, Suspended &#x3D; 2, Declined &#x3D; 3 | [optional] 
 **filterSearch** | **string**| character string to filter customer&#x27;s search | [optional] 
 **filterIsExactMatch** | **bool?**| true - search character will bring data that matches, false - search charater will bring data that partially matches the data | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterSortField** | **string**| specify the customer field to be sorted | [optional] 
 **filterSortAsc** | **bool?**| true - sort results in ascending order by SortField, false - sort results in descending order by SortField | [optional] 
 **filterLastRowNumber** | **int?**| Format - int64. | [optional] 
 **filterMaxResults** | **int?**| Format - int32. Get the specify number of Customers in the result payload | [optional] 

### Return type

[**PagedActionResultsOfCustomers**](PagedActionResultsOfCustomers.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetaccountcustomerforoperational"></a>
# **CustomersGetAccountCustomerForOperational**
> EditResponseOfCustomerT CustomersGetAccountCustomerForOperational (int? id, int? reqCustomerID, int? reqBusinessID, bool? reqIsAutoAddClaimRequests, string reqDebtorCode, bool? reqIsReturnEmptyCustomerIfNotFound, bool? reqIsGetNewTemplate, int? reqID, string reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)

Customers_GetAccountCustomerForOperational

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetAccountCustomerForOperationalExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var reqCustomerID = 56;  // int? | Format - int32. (optional) 
            var reqBusinessID = 56;  // int? | Format - int32. (optional) 
            var reqIsAutoAddClaimRequests = true;  // bool? |  (optional) 
            var reqDebtorCode = reqDebtorCode_example;  // string |  (optional) 
            var reqIsReturnEmptyCustomerIfNotFound = true;  // bool? |  (optional) 
            var reqIsGetNewTemplate = true;  // bool? |  (optional) 
            var reqID = 56;  // int? | Format - int32. (optional) 
            var reqGUID = reqGUID_example;  // string | Format - uuid. (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? | Format - int32. (optional) 
            var reqWebsiteID = 56;  // int? | Format - int32. (optional) 
            var reqUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Customers_GetAccountCustomerForOperational
                EditResponseOfCustomerT result = apiInstance.CustomersGetAccountCustomerForOperational(id, reqCustomerID, reqBusinessID, reqIsAutoAddClaimRequests, reqDebtorCode, reqIsReturnEmptyCustomerIfNotFound, reqIsGetNewTemplate, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetAccountCustomerForOperational: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **reqCustomerID** | **int?**| Format - int32. | [optional] 
 **reqBusinessID** | **int?**| Format - int32. | [optional] 
 **reqIsAutoAddClaimRequests** | **bool?**|  | [optional] 
 **reqDebtorCode** | **string**|  | [optional] 
 **reqIsReturnEmptyCustomerIfNotFound** | **bool?**|  | [optional] 
 **reqIsGetNewTemplate** | **bool?**|  | [optional] 
 **reqID** | **int?**| Format - int32. | [optional] 
 **reqGUID** | **string**| Format - uuid. | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**| Format - int32. | [optional] 
 **reqWebsiteID** | **int?**| Format - int32. | [optional] 
 **reqUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**EditResponseOfCustomerT**](EditResponseOfCustomerT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetbyid"></a>
# **CustomersGetByID**
> EditResponseOfCustomerT CustomersGetByID (int? id, int? reqID, string reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)

Customers_GetByID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetByIDExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var reqID = 56;  // int? | Format - int32. (optional) 
            var reqGUID = reqGUID_example;  // string | Format - uuid. (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? | Format - int32. (optional) 
            var reqWebsiteID = 56;  // int? | Format - int32. (optional) 
            var reqUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Customers_GetByID
                EditResponseOfCustomerT result = apiInstance.CustomersGetByID(id, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **reqID** | **int?**| Format - int32. | [optional] 
 **reqGUID** | **string**| Format - uuid. | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**| Format - int32. | [optional] 
 **reqWebsiteID** | **int?**| Format - int32. | [optional] 
 **reqUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**EditResponseOfCustomerT**](EditResponseOfCustomerT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetcustomerswithunpaidinvoices"></a>
# **CustomersGetCustomersWithUnpaidInvoices**
> PagedActionResultsOfCustomerBalances CustomersGetCustomersWithUnpaidInvoices (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

Customers_GetCustomersWithUnpaidInvoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetCustomersWithUnpaidInvoicesExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var filterBusinessID = 56;  // int? | Format - int32. (optional) 
            var filterCustomerID = 56;  // int? | Format - int32. (optional) 
            var filterSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterWarehouseID = 56;  // int? | Format - int32. (optional) 
            var filterDeliveryMethods = filterDeliveryMethods_example;  // string |  (optional) 
            var filterDatTypes = new List(); // List |  (optional) 
            var filterMaxExpiresInDays = 56;  // int? | Format - int32. (optional) 
            var filterRepUserID = 56;  // int? | Format - int32. (optional) 
            var filterIsCreatedByOtherPartyOnly = true;  // bool? |  (optional) 
            var filterCreatedByUserId = 56;  // int? | Format - int32. (optional) 
            var filterStatuses = new List(); // List |  (optional) 
            var filterStatusStrings = new List(); // List |  (optional) 
            var filterStatus = new List(); // List |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSearch = filterSearch_example;  // string |  (optional) 
            var filterStartDate = filterStartDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterEndDate = filterEndDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterDatePeriod = filterDatePeriod_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIsGetBasicInfo = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIncludeLogs = true;  // bool? |  (optional) 
            var filterIgnoreID = 56;  // int? | Format - int32. (optional) 
            var filterParentID = 56;  // int? | Format - int32. (optional) 
            var filterGetCountOnly = true;  // bool? |  (optional) 
            var filterTransactionTypeDatTypeID = 56;  // int? | Format - int32. (optional) 
            var filterCategoryID = 56;  // int? | Format - int32. (optional) 
            var filterAdaptorID = 56;  // int? | Format - int32. (optional) 
            var filterCategoryIDs = new List(); // List |  (optional) 
            var filterBrandIDs = new List(); // List |  (optional) 
            var filterIDs = new List(); // List |  (optional) 
            var filterGUIDs = new List(); // List |  (optional) 
            var filterLinkedSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterID = 56;  // int? | Format - int32. (optional) 
            var filterIsHierarchicalSort = true;  // bool? |  (optional) 
            var filterTypes = new List(); // List |  (optional) 
            var filterIsShowFavourites = true;  // bool? |  (optional) 
            var filterIsHidden = true;  // bool? |  (optional) 
            var filterIncludeSystemTasks = true;  // bool? |  (optional) 
            var filterIsSystem = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 56;  // int? | Format - int64. (optional) 
            var filterMaxResults = 56;  // int? | Format - int32. (optional) 
            var filterTenantID = 56;  // int? | Format - int32. (optional) 
            var filterWebsiteID = 56;  // int? | Format - int32. (optional) 
            var filterUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Customers_GetCustomersWithUnpaidInvoices
                PagedActionResultsOfCustomerBalances result = apiInstance.CustomersGetCustomersWithUnpaidInvoices(filterBusinessID, filterCustomerID, filterSupplierID, filterWarehouseID, filterDeliveryMethods, filterDatTypes, filterMaxExpiresInDays, filterRepUserID, filterIsCreatedByOtherPartyOnly, filterCreatedByUserId, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetCustomersWithUnpaidInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterBusinessID** | **int?**| Format - int32. | [optional] 
 **filterCustomerID** | **int?**| Format - int32. | [optional] 
 **filterSupplierID** | **int?**| Format - int32. | [optional] 
 **filterWarehouseID** | **int?**| Format - int32. | [optional] 
 **filterDeliveryMethods** | **string**|  | [optional] 
 **filterDatTypes** | [**List**](.md)|  | [optional] 
 **filterMaxExpiresInDays** | **int?**| Format - int32. | [optional] 
 **filterRepUserID** | **int?**| Format - int32. | [optional] 
 **filterIsCreatedByOtherPartyOnly** | **bool?**|  | [optional] 
 **filterCreatedByUserId** | **int?**| Format - int32. | [optional] 
 **filterStatuses** | [**List**](.md)|  | [optional] 
 **filterStatusStrings** | [**List**](.md)|  | [optional] 
 **filterStatus** | [**List**](.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSearch** | **string**|  | [optional] 
 **filterStartDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterEndDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterDatePeriod** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIsGetBasicInfo** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIncludeLogs** | **bool?**|  | [optional] 
 **filterIgnoreID** | **int?**| Format - int32. | [optional] 
 **filterParentID** | **int?**| Format - int32. | [optional] 
 **filterGetCountOnly** | **bool?**|  | [optional] 
 **filterTransactionTypeDatTypeID** | **int?**| Format - int32. | [optional] 
 **filterCategoryID** | **int?**| Format - int32. | [optional] 
 **filterAdaptorID** | **int?**| Format - int32. | [optional] 
 **filterCategoryIDs** | [**List**](.md)|  | [optional] 
 **filterBrandIDs** | [**List**](.md)|  | [optional] 
 **filterIDs** | [**List**](.md)|  | [optional] 
 **filterGUIDs** | [**List**](.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**| Format - int32. | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterID** | **int?**| Format - int32. | [optional] 
 **filterIsHierarchicalSort** | **bool?**|  | [optional] 
 **filterTypes** | [**List**](.md)|  | [optional] 
 **filterIsShowFavourites** | **bool?**|  | [optional] 
 **filterIsHidden** | **bool?**|  | [optional] 
 **filterIncludeSystemTasks** | **bool?**|  | [optional] 
 **filterIsSystem** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **int?**| Format - int64. | [optional] 
 **filterMaxResults** | **int?**| Format - int32. | [optional] 
 **filterTenantID** | **int?**| Format - int32. | [optional] 
 **filterWebsiteID** | **int?**| Format - int32. | [optional] 
 **filterUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**PagedActionResultsOfCustomerBalances**](PagedActionResultsOfCustomerBalances.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetmerchantsurcharge"></a>
# **CustomersGetMerchantSurcharge**
> ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge (int? customerID, ActionRequestOfMerchantSurcharge body)

Customers_GetMerchantSurcharge

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetMerchantSurchargeExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var customerID = 56;  // int? | Format - int32.
            var body = new ActionRequestOfMerchantSurcharge(); // ActionRequestOfMerchantSurcharge |  (optional) 

            try
            {
                // Customers_GetMerchantSurcharge
                ActionResultsOfMerchantSurcharge result = apiInstance.CustomersGetMerchantSurcharge(customerID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetMerchantSurcharge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerID** | **int?**| Format - int32. | 
 **body** | [**ActionRequestOfMerchantSurcharge**](ActionRequestOfMerchantSurcharge.md)|  | [optional] 

### Return type

[**ActionResultsOfMerchantSurcharge**](ActionResultsOfMerchantSurcharge.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetmerchantsurchargefortransactions"></a>
# **CustomersGetMerchantSurchargeForTransactions**
> ActionResultsOfMerchantSurcharge CustomersGetMerchantSurchargeForTransactions (int? customerID, string paymentMethod, List<RefBusTranT> body)

Customers_GetMerchantSurchargeForTransactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetMerchantSurchargeForTransactionsExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var customerID = 56;  // int? | Format - int32.
            var paymentMethod = paymentMethod_example;  // string | 
            var body = new List<RefBusTranT>(); // List<RefBusTranT> |  (optional) 

            try
            {
                // Customers_GetMerchantSurchargeForTransactions
                ActionResultsOfMerchantSurcharge result = apiInstance.CustomersGetMerchantSurchargeForTransactions(customerID, paymentMethod, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetMerchantSurchargeForTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerID** | **int?**| Format - int32. | 
 **paymentMethod** | **string**|  | 
 **body** | [**List<RefBusTranT>**](RefBusTranT.md)|  | [optional] 

### Return type

[**ActionResultsOfMerchantSurcharge**](ActionResultsOfMerchantSurcharge.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetoperationalcustomersforanaccountcustomer"></a>
# **CustomersGetOperationalCustomersForAnAccountCustomer**
> PagedActionResultsOfCustomers CustomersGetOperationalCustomersForAnAccountCustomer (int? id, bool? filterGetIsValidForBillToOnly, int? filterCreatedByUserID, int? filterCustomerID, bool? filterIsLinkedCustomersOnly, int? filterIgnoreProspectID, int? filterCustomerClassID, int? filterTerritoryID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

Customers_GetOperationalCustomersForAnAccountCustomer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersGetOperationalCustomersForAnAccountCustomerExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var filterGetIsValidForBillToOnly = true;  // bool? |  (optional) 
            var filterCreatedByUserID = 56;  // int? | Format - int32. (optional) 
            var filterCustomerID = 56;  // int? | Format - int32. (optional) 
            var filterIsLinkedCustomersOnly = true;  // bool? |  (optional) 
            var filterIgnoreProspectID = 56;  // int? | Format - int32. (optional) 
            var filterCustomerClassID = 56;  // int? | Format - int32. (optional) 
            var filterTerritoryID = 56;  // int? | Format - int32. (optional) 
            var filterIsShowAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterAccountCustomerID = 56;  // int? | Format - int32. (optional) 
            var filterIsCODorPrePaidAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterStatuses = new List(); // List |  (optional) 
            var filterStatusStrings = new List(); // List |  (optional) 
            var filterStatus = new List(); // List |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSearch = filterSearch_example;  // string |  (optional) 
            var filterStartDate = filterStartDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterEndDate = filterEndDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterDatePeriod = filterDatePeriod_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIsGetBasicInfo = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIncludeLogs = true;  // bool? |  (optional) 
            var filterIgnoreID = 56;  // int? | Format - int32. (optional) 
            var filterParentID = 56;  // int? | Format - int32. (optional) 
            var filterGetCountOnly = true;  // bool? |  (optional) 
            var filterTransactionTypeDatTypeID = 56;  // int? | Format - int32. (optional) 
            var filterCategoryID = 56;  // int? | Format - int32. (optional) 
            var filterAdaptorID = 56;  // int? | Format - int32. (optional) 
            var filterCategoryIDs = new List(); // List |  (optional) 
            var filterBrandIDs = new List(); // List |  (optional) 
            var filterIDs = new List(); // List |  (optional) 
            var filterGUIDs = new List(); // List |  (optional) 
            var filterLinkedSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterID = 56;  // int? | Format - int32. (optional) 
            var filterIsHierarchicalSort = true;  // bool? |  (optional) 
            var filterTypes = new List(); // List |  (optional) 
            var filterIsShowFavourites = true;  // bool? |  (optional) 
            var filterIsHidden = true;  // bool? |  (optional) 
            var filterIncludeSystemTasks = true;  // bool? |  (optional) 
            var filterIsSystem = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 56;  // int? | Format - int64. (optional) 
            var filterMaxResults = 56;  // int? | Format - int32. (optional) 
            var filterTenantID = 56;  // int? | Format - int32. (optional) 
            var filterWebsiteID = 56;  // int? | Format - int32. (optional) 
            var filterUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Customers_GetOperationalCustomersForAnAccountCustomer
                PagedActionResultsOfCustomers result = apiInstance.CustomersGetOperationalCustomersForAnAccountCustomer(id, filterGetIsValidForBillToOnly, filterCreatedByUserID, filterCustomerID, filterIsLinkedCustomersOnly, filterIgnoreProspectID, filterCustomerClassID, filterTerritoryID, filterIsShowAccountCustomersOnly, filterAccountCustomerID, filterIsCODorPrePaidAccountCustomersOnly, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGetOperationalCustomersForAnAccountCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **filterGetIsValidForBillToOnly** | **bool?**|  | [optional] 
 **filterCreatedByUserID** | **int?**| Format - int32. | [optional] 
 **filterCustomerID** | **int?**| Format - int32. | [optional] 
 **filterIsLinkedCustomersOnly** | **bool?**|  | [optional] 
 **filterIgnoreProspectID** | **int?**| Format - int32. | [optional] 
 **filterCustomerClassID** | **int?**| Format - int32. | [optional] 
 **filterTerritoryID** | **int?**| Format - int32. | [optional] 
 **filterIsShowAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterAccountCustomerID** | **int?**| Format - int32. | [optional] 
 **filterIsCODorPrePaidAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterStatuses** | [**List**](.md)|  | [optional] 
 **filterStatusStrings** | [**List**](.md)|  | [optional] 
 **filterStatus** | [**List**](.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSearch** | **string**|  | [optional] 
 **filterStartDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterEndDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterDatePeriod** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIsGetBasicInfo** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIncludeLogs** | **bool?**|  | [optional] 
 **filterIgnoreID** | **int?**| Format - int32. | [optional] 
 **filterParentID** | **int?**| Format - int32. | [optional] 
 **filterGetCountOnly** | **bool?**|  | [optional] 
 **filterTransactionTypeDatTypeID** | **int?**| Format - int32. | [optional] 
 **filterCategoryID** | **int?**| Format - int32. | [optional] 
 **filterAdaptorID** | **int?**| Format - int32. | [optional] 
 **filterCategoryIDs** | [**List**](.md)|  | [optional] 
 **filterBrandIDs** | [**List**](.md)|  | [optional] 
 **filterIDs** | [**List**](.md)|  | [optional] 
 **filterGUIDs** | [**List**](.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**| Format - int32. | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterID** | **int?**| Format - int32. | [optional] 
 **filterIsHierarchicalSort** | **bool?**|  | [optional] 
 **filterTypes** | [**List**](.md)|  | [optional] 
 **filterIsShowFavourites** | **bool?**|  | [optional] 
 **filterIsHidden** | **bool?**|  | [optional] 
 **filterIncludeSystemTasks** | **bool?**|  | [optional] 
 **filterIsSystem** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **int?**| Format - int64. | [optional] 
 **filterMaxResults** | **int?**| Format - int32. | [optional] 
 **filterTenantID** | **int?**| Format - int32. | [optional] 
 **filterWebsiteID** | **int?**| Format - int32. | [optional] 
 **filterUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**PagedActionResultsOfCustomers**](PagedActionResultsOfCustomers.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerslinkcustomer"></a>
# **CustomersLinkCustomer**
> ActionResults CustomersLinkCustomer (int? id, int? customerToLinkID)

Customers_LinkCustomer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersLinkCustomerExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var customerToLinkID = 56;  // int? | Format - int32.

            try
            {
                // Customers_LinkCustomer
                ActionResults result = apiInstance.CustomersLinkCustomer(id, customerToLinkID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersLinkCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **customerToLinkID** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerspost"></a>
# **CustomersPost**
> SynkSaveQueueResponseOfCustomerT CustomersPost (SaveRequestOfCustomerTRequestXml1 body)

Customers_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var body = new SaveRequestOfCustomerTRequestXml1(); // SaveRequestOfCustomerTRequestXml1 |  (optional) 

            try
            {
                // Customers_Post
                SynkSaveQueueResponseOfCustomerT result = apiInstance.CustomersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfCustomerTRequestXml1**](SaveRequestOfCustomerTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponseOfCustomerT**](SynkSaveQueueResponseOfCustomerT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersput"></a>
# **CustomersPut**
> SynkSaveQueueResponseOfCustomerT CustomersPut (int? id, SaveRequestOfCustomerTRequestXml1 body)

Customers_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersPutExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var body = new SaveRequestOfCustomerTRequestXml1(); // SaveRequestOfCustomerTRequestXml1 |  (optional) 

            try
            {
                // Customers_Put
                SynkSaveQueueResponseOfCustomerT result = apiInstance.CustomersPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**SaveRequestOfCustomerTRequestXml1**](SaveRequestOfCustomerTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponseOfCustomerT**](SynkSaveQueueResponseOfCustomerT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerssetclass"></a>
# **CustomersSetClass**
> ActionResults CustomersSetClass (int? id, int? classID)

Customers_SetClass

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersSetClassExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var classID = 56;  // int? | Format - int32.

            try
            {
                // Customers_SetClass
                ActionResults result = apiInstance.CustomersSetClass(id, classID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersSetClass: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **classID** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersunlinkcustomer"></a>
# **CustomersUnlinkCustomer**
> ActionResults CustomersUnlinkCustomer (int? id, int? customerToUnlinkID)

Customers_UnlinkCustomer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomersUnlinkCustomerExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | Format - int32.
            var customerToUnlinkID = 56;  // int? | Format - int32.

            try
            {
                // Customers_UnlinkCustomer
                ActionResults result = apiInstance.CustomersUnlinkCustomer(id, customerToUnlinkID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersUnlinkCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **customerToUnlinkID** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

