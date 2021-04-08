# SDK.SpendaApi.Client.Api.CustomersApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomersGet**](CustomersApi.md#customersget) | **GET** /api/v3/Customers | 
[**CustomersGetByID**](CustomersApi.md#customersgetbyid) | **GET** /api/v3/Customers/{id} | 
[**CustomersGetAccountCustomerForOperational**](CustomersApi.md#customersgetaccountcustomerforoperational) | **GET** /api/v3/Customers/{id}/account | 
[**CustomersGetCustomersWithUnpaidInvoices**](CustomersApi.md#customersgetcustomerswithunpaidinvoices) | **GET** /api/Customers/unpaidinvoices | 
[**CustomersGetOperationalCustomersForAnAccountCustomer**](CustomersApi.md#customersgetoperationalcustomersforanaccountcustomer) | **GET** /api/v3/Customers/{id}/operational | 
[**CustomersAccountExemptFromMerchantSurcharge**](CustomersApi.md#customersaccountexemptfrommerchantsurcharge) | **POST** /api/Customers/{customerID}/accountexemptfrommerchantsurcharge | 
[**CustomersGetMerchantSurcharge**](CustomersApi.md#customersgetmerchantsurcharge) | **POST** /api/Customers/{customerID}/merchantsurcharge | 
[**CustomersGetMerchantSurchargeForTransactions**](CustomersApi.md#customersgetmerchantsurchargefortransactions) | **POST** /api/Customers/{customerID}/merchantsurcharge/{paymentMethod} | 
[**CustomersPost**](CustomersApi.md#customerspost) | **POST** /api/v3/Customers | 
[**CustomersPut**](CustomersApi.md#customersput) | **PUT** /api/v3/Customers | 
[**CustomersSetClass**](CustomersApi.md#customerssetclass) | **PUT** /api/v3/Customers/{id}/class | 
[**CustomersLinkCustomer**](CustomersApi.md#customerslinkcustomer) | **PUT** /api/v3/Customers/{id}/link | 
[**CustomersUnlinkCustomer**](CustomersApi.md#customersunlinkcustomer) | **PUT** /api/v3/Customers/{id}/unlink | 
[**CustomersDelete**](CustomersApi.md#customersdelete) | **DELETE** /api/v3/Customers/{id} | 

<a name="customersaccountexemptfrommerchantsurcharge"></a>
# **CustomersAccountExemptFromMerchantSurcharge**
> ActionResults CustomersAccountExemptFromMerchantSurcharge (int? customerID, bool? isExempt)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersAccountExemptFromMerchantSurchargeExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var customerID = 56;  // int? | 
            var isExempt = true;  // bool? |  (optional) 

            try
            {
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
 **customerID** | **int?**|  | 
 **isExempt** | **bool?**|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersdelete"></a>
# **CustomersDelete**
> ActionResults CustomersDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersDeleteExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersget"></a>
# **CustomersGet**
> PagedActionResultsOfCustomers CustomersGet (bool? filterGetIsValidForBillToOnly, bool? filterIsLinkedCustomersOnly, int? filterCustomerClassID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<string> filterStatus, string filterSearch, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, bool? filterSortAsc, long? filterLastRowNumber, int? filterMaxResults)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var filterGetIsValidForBillToOnly = true;  // bool? |  (optional) 
            var filterIsLinkedCustomersOnly = true;  // bool? |  (optional) 
            var filterCustomerClassID = 56;  // int? |  (optional) 
            var filterIsShowAccountCustomersOnly = true;  // bool? | true - Account Customers only, false - Operational Customers only, not set - Both Customer Types (optional) 
            var filterAccountCustomerID = 56;  // int? |  (optional) 
            var filterIsCODorPrePaidAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterStatus = new List<string>(); // List<string> | CustomerStatusTypes - New = 0, Active = 1, Suspended = 2, Declined = 3 (optional) 
            var filterSearch = filterSearch_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
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
 **filterIsLinkedCustomersOnly** | **bool?**|  | [optional] 
 **filterCustomerClassID** | **int?**|  | [optional] 
 **filterIsShowAccountCustomersOnly** | **bool?**| true - Account Customers only, false - Operational Customers only, not set - Both Customer Types | [optional] 
 **filterAccountCustomerID** | **int?**|  | [optional] 
 **filterIsCODorPrePaidAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterStatus** | [**List<string>**](string.md)| CustomerStatusTypes - New &#x3D; 0, Active &#x3D; 1, Suspended &#x3D; 2, Declined &#x3D; 3 | [optional] 
 **filterSearch** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterLastRowNumber** | **long?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfCustomers**](PagedActionResultsOfCustomers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetaccountcustomerforoperational"></a>
# **CustomersGetAccountCustomerForOperational**
> EditResponseOfCustomerT CustomersGetAccountCustomerForOperational (int? id, int? reqCustomerID, int? reqBusinessID, bool? reqIsAutoAddClaimRequests, string reqDebtorCode, bool? reqIsReturnEmptyCustomerIfNotFound, bool? reqIsGetNewTemplate, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetAccountCustomerForOperationalExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var reqCustomerID = 56;  // int? |  (optional) 
            var reqBusinessID = 56;  // int? |  (optional) 
            var reqIsAutoAddClaimRequests = true;  // bool? |  (optional) 
            var reqDebtorCode = reqDebtorCode_example;  // string |  (optional) 
            var reqIsReturnEmptyCustomerIfNotFound = true;  // bool? |  (optional) 
            var reqIsGetNewTemplate = true;  // bool? |  (optional) 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
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
 **id** | **int?**|  | 
 **reqCustomerID** | **int?**|  | [optional] 
 **reqBusinessID** | **int?**|  | [optional] 
 **reqIsAutoAddClaimRequests** | **bool?**|  | [optional] 
 **reqDebtorCode** | **string**|  | [optional] 
 **reqIsReturnEmptyCustomerIfNotFound** | **bool?**|  | [optional] 
 **reqIsGetNewTemplate** | **bool?**|  | [optional] 
 **reqID** | **int?**|  | [optional] 
 **reqGUID** | [**Guid?**](.md)|  | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**|  | [optional] 
 **reqWebsiteID** | **int?**|  | [optional] 
 **reqUserID** | **int?**|  | [optional] 

### Return type

[**EditResponseOfCustomerT**](EditResponseOfCustomerT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetbyid"></a>
# **CustomersGetByID**
> EditResponseOfCustomerT CustomersGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetByIDExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
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
 **id** | **int?**|  | 
 **reqID** | **int?**|  | [optional] 
 **reqGUID** | [**Guid?**](.md)|  | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**|  | [optional] 
 **reqWebsiteID** | **int?**|  | [optional] 
 **reqUserID** | **int?**|  | [optional] 

### Return type

[**EditResponseOfCustomerT**](EditResponseOfCustomerT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetcustomerswithunpaidinvoices"></a>
# **CustomersGetCustomersWithUnpaidInvoices**
> PagedActionResultsOfCustomerBalances CustomersGetCustomersWithUnpaidInvoices (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List<string> filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetCustomersWithUnpaidInvoicesExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var filterBusinessID = 56;  // int? |  (optional) 
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterDeliveryMethods = filterDeliveryMethods_example;  // string |  (optional) 
            var filterDatTypes = new List<string>(); // List<string> |  (optional) 
            var filterMaxExpiresInDays = 56;  // int? |  (optional) 
            var filterRepUserID = 56;  // int? |  (optional) 
            var filterIsCreatedByOtherPartyOnly = true;  // bool? |  (optional) 
            var filterCreatedByUserId = 56;  // int? |  (optional) 
            var filterStatuses = new List<int?>(); // List<int?> |  (optional) 
            var filterStatusStrings = new List<string>(); // List<string> |  (optional) 
            var filterStatus = new List<string>(); // List<string> |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSearch = filterSearch_example;  // string |  (optional) 
            var filterStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterDatePeriod = filterDatePeriod_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIsGetBasicInfo = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIncludeLogs = true;  // bool? |  (optional) 
            var filterIgnoreID = 56;  // int? |  (optional) 
            var filterParentID = 56;  // int? |  (optional) 
            var filterGetCountOnly = true;  // bool? |  (optional) 
            var filterTransactionTypeDatTypeID = 56;  // int? |  (optional) 
            var filterCategoryID = 56;  // int? |  (optional) 
            var filterAdaptorID = 56;  // int? |  (optional) 
            var filterCategoryIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterBrandIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterGUIDs = new List<string>(); // List<string> |  (optional) 
            var filterLinkedSupplierID = 56;  // int? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterID = 56;  // int? |  (optional) 
            var filterIsHierarchicalSort = true;  // bool? |  (optional) 
            var filterTypes = new List<string>(); // List<string> |  (optional) 
            var filterIsShowFavourites = true;  // bool? |  (optional) 
            var filterIsHidden = true;  // bool? |  (optional) 
            var filterIncludeSystemTasks = true;  // bool? |  (optional) 
            var filterIsSystem = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 789;  // long? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 
            var filterTenantID = 56;  // int? |  (optional) 
            var filterWebsiteID = 56;  // int? |  (optional) 
            var filterUserID = 56;  // int? |  (optional) 

            try
            {
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
 **filterBusinessID** | **int?**|  | [optional] 
 **filterCustomerID** | **int?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterDeliveryMethods** | **string**|  | [optional] 
 **filterDatTypes** | [**List<string>**](string.md)|  | [optional] 
 **filterMaxExpiresInDays** | **int?**|  | [optional] 
 **filterRepUserID** | **int?**|  | [optional] 
 **filterIsCreatedByOtherPartyOnly** | **bool?**|  | [optional] 
 **filterCreatedByUserId** | **int?**|  | [optional] 
 **filterStatuses** | [**List<int?>**](int?.md)|  | [optional] 
 **filterStatusStrings** | [**List<string>**](string.md)|  | [optional] 
 **filterStatus** | [**List<string>**](string.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSearch** | **string**|  | [optional] 
 **filterStartDate** | **DateTime?**|  | [optional] 
 **filterEndDate** | **DateTime?**|  | [optional] 
 **filterDatePeriod** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIsGetBasicInfo** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIncludeLogs** | **bool?**|  | [optional] 
 **filterIgnoreID** | **int?**|  | [optional] 
 **filterParentID** | **int?**|  | [optional] 
 **filterGetCountOnly** | **bool?**|  | [optional] 
 **filterTransactionTypeDatTypeID** | **int?**|  | [optional] 
 **filterCategoryID** | **int?**|  | [optional] 
 **filterAdaptorID** | **int?**|  | [optional] 
 **filterCategoryIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterBrandIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterGUIDs** | [**List<string>**](string.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterID** | **int?**|  | [optional] 
 **filterIsHierarchicalSort** | **bool?**|  | [optional] 
 **filterTypes** | [**List<string>**](string.md)|  | [optional] 
 **filterIsShowFavourites** | **bool?**|  | [optional] 
 **filterIsHidden** | **bool?**|  | [optional] 
 **filterIncludeSystemTasks** | **bool?**|  | [optional] 
 **filterIsSystem** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **long?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 
 **filterTenantID** | **int?**|  | [optional] 
 **filterWebsiteID** | **int?**|  | [optional] 
 **filterUserID** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfCustomerBalances**](PagedActionResultsOfCustomerBalances.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetmerchantsurcharge"></a>
# **CustomersGetMerchantSurcharge**
> ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge (ActionRequestOfMerchantSurcharge body, int? customerID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetMerchantSurchargeExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var body = new ActionRequestOfMerchantSurcharge(); // ActionRequestOfMerchantSurcharge | 
            var customerID = 56;  // int? | 

            try
            {
                ActionResultsOfMerchantSurcharge result = apiInstance.CustomersGetMerchantSurcharge(body, customerID);
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
 **body** | [**ActionRequestOfMerchantSurcharge**](ActionRequestOfMerchantSurcharge.md)|  | 
 **customerID** | **int?**|  | 

### Return type

[**ActionResultsOfMerchantSurcharge**](ActionResultsOfMerchantSurcharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetmerchantsurchargefortransactions"></a>
# **CustomersGetMerchantSurchargeForTransactions**
> ActionResultsOfMerchantSurcharge CustomersGetMerchantSurchargeForTransactions (List<RefBusTranT> body, int? customerID, string paymentMethod)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetMerchantSurchargeForTransactionsExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var body = new List<RefBusTranT>(); // List<RefBusTranT> | 
            var customerID = 56;  // int? | 
            var paymentMethod = paymentMethod_example;  // string | 

            try
            {
                ActionResultsOfMerchantSurcharge result = apiInstance.CustomersGetMerchantSurchargeForTransactions(body, customerID, paymentMethod);
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
 **body** | [**List<RefBusTranT>**](RefBusTranT.md)|  | 
 **customerID** | **int?**|  | 
 **paymentMethod** | **string**|  | 

### Return type

[**ActionResultsOfMerchantSurcharge**](ActionResultsOfMerchantSurcharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersgetoperationalcustomersforanaccountcustomer"></a>
# **CustomersGetOperationalCustomersForAnAccountCustomer**
> PagedActionResultsOfCustomers CustomersGetOperationalCustomersForAnAccountCustomer (int? id, bool? filterGetIsValidForBillToOnly, int? filterCreatedByUserID, int? filterCustomerID, bool? filterIsLinkedCustomersOnly, int? filterIgnoreProspectID, int? filterCustomerClassID, int? filterTerritoryID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersGetOperationalCustomersForAnAccountCustomerExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var filterGetIsValidForBillToOnly = true;  // bool? |  (optional) 
            var filterCreatedByUserID = 56;  // int? |  (optional) 
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterIsLinkedCustomersOnly = true;  // bool? |  (optional) 
            var filterIgnoreProspectID = 56;  // int? |  (optional) 
            var filterCustomerClassID = 56;  // int? |  (optional) 
            var filterTerritoryID = 56;  // int? |  (optional) 
            var filterIsShowAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterAccountCustomerID = 56;  // int? |  (optional) 
            var filterIsCODorPrePaidAccountCustomersOnly = true;  // bool? |  (optional) 
            var filterStatuses = new List<int?>(); // List<int?> |  (optional) 
            var filterStatusStrings = new List<string>(); // List<string> |  (optional) 
            var filterStatus = new List<string>(); // List<string> |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSearch = filterSearch_example;  // string |  (optional) 
            var filterStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterDatePeriod = filterDatePeriod_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIsGetBasicInfo = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIncludeLogs = true;  // bool? |  (optional) 
            var filterIgnoreID = 56;  // int? |  (optional) 
            var filterParentID = 56;  // int? |  (optional) 
            var filterGetCountOnly = true;  // bool? |  (optional) 
            var filterTransactionTypeDatTypeID = 56;  // int? |  (optional) 
            var filterCategoryID = 56;  // int? |  (optional) 
            var filterAdaptorID = 56;  // int? |  (optional) 
            var filterCategoryIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterBrandIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterGUIDs = new List<string>(); // List<string> |  (optional) 
            var filterLinkedSupplierID = 56;  // int? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterID = 56;  // int? |  (optional) 
            var filterIsHierarchicalSort = true;  // bool? |  (optional) 
            var filterTypes = new List<string>(); // List<string> |  (optional) 
            var filterIsShowFavourites = true;  // bool? |  (optional) 
            var filterIsHidden = true;  // bool? |  (optional) 
            var filterIncludeSystemTasks = true;  // bool? |  (optional) 
            var filterIsSystem = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 789;  // long? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 
            var filterTenantID = 56;  // int? |  (optional) 
            var filterWebsiteID = 56;  // int? |  (optional) 
            var filterUserID = 56;  // int? |  (optional) 

            try
            {
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
 **id** | **int?**|  | 
 **filterGetIsValidForBillToOnly** | **bool?**|  | [optional] 
 **filterCreatedByUserID** | **int?**|  | [optional] 
 **filterCustomerID** | **int?**|  | [optional] 
 **filterIsLinkedCustomersOnly** | **bool?**|  | [optional] 
 **filterIgnoreProspectID** | **int?**|  | [optional] 
 **filterCustomerClassID** | **int?**|  | [optional] 
 **filterTerritoryID** | **int?**|  | [optional] 
 **filterIsShowAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterAccountCustomerID** | **int?**|  | [optional] 
 **filterIsCODorPrePaidAccountCustomersOnly** | **bool?**|  | [optional] 
 **filterStatuses** | [**List<int?>**](int?.md)|  | [optional] 
 **filterStatusStrings** | [**List<string>**](string.md)|  | [optional] 
 **filterStatus** | [**List<string>**](string.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSearch** | **string**|  | [optional] 
 **filterStartDate** | **DateTime?**|  | [optional] 
 **filterEndDate** | **DateTime?**|  | [optional] 
 **filterDatePeriod** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIsGetBasicInfo** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIncludeLogs** | **bool?**|  | [optional] 
 **filterIgnoreID** | **int?**|  | [optional] 
 **filterParentID** | **int?**|  | [optional] 
 **filterGetCountOnly** | **bool?**|  | [optional] 
 **filterTransactionTypeDatTypeID** | **int?**|  | [optional] 
 **filterCategoryID** | **int?**|  | [optional] 
 **filterAdaptorID** | **int?**|  | [optional] 
 **filterCategoryIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterBrandIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterGUIDs** | [**List<string>**](string.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterID** | **int?**|  | [optional] 
 **filterIsHierarchicalSort** | **bool?**|  | [optional] 
 **filterTypes** | [**List<string>**](string.md)|  | [optional] 
 **filterIsShowFavourites** | **bool?**|  | [optional] 
 **filterIsHidden** | **bool?**|  | [optional] 
 **filterIncludeSystemTasks** | **bool?**|  | [optional] 
 **filterIsSystem** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **long?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 
 **filterTenantID** | **int?**|  | [optional] 
 **filterWebsiteID** | **int?**|  | [optional] 
 **filterUserID** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfCustomers**](PagedActionResultsOfCustomers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerslinkcustomer"></a>
# **CustomersLinkCustomer**
> ActionResults CustomersLinkCustomer (int? id, int? customerToLinkID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersLinkCustomerExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var customerToLinkID = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 
 **customerToLinkID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerspost"></a>
# **CustomersPost**
> SynkSaveQueueResponseOfCustomerT CustomersPost (SaveRequestOfCustomerT body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersPostExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var body = new SaveRequestOfCustomerT(); // SaveRequestOfCustomerT | 

            try
            {
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
 **body** | [**SaveRequestOfCustomerT**](SaveRequestOfCustomerT.md)|  | 

### Return type

[**SynkSaveQueueResponseOfCustomerT**](SynkSaveQueueResponseOfCustomerT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersput"></a>
# **CustomersPut**
> SynkSaveQueueResponseOfCustomerT CustomersPut (SaveRequestOfCustomerT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersPutExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var body = new SaveRequestOfCustomerT(); // SaveRequestOfCustomerT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponseOfCustomerT result = apiInstance.CustomersPut(body, id);
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
 **body** | [**SaveRequestOfCustomerT**](SaveRequestOfCustomerT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponseOfCustomerT**](SynkSaveQueueResponseOfCustomerT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerssetclass"></a>
# **CustomersSetClass**
> ActionResults CustomersSetClass (int? id, int? classID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersSetClassExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var classID = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 
 **classID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersunlinkcustomer"></a>
# **CustomersUnlinkCustomer**
> ActionResults CustomersUnlinkCustomer (int? id, int? customerToUnlinkID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace Example
{
    public class CustomersUnlinkCustomerExample
    {
        public void main()
        {

            var apiInstance = new CustomersApi();
            var id = 56;  // int? | 
            var customerToUnlinkID = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 
 **customerToUnlinkID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

