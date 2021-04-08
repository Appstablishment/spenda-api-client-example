# IO.Swagger.Api.PurchaseInvoiceApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PurchaseInvoiceAddInventory**](PurchaseInvoiceApi.md#purchaseinvoiceaddinventory) | **POST** /api/v2/PurchaseInvoice/{id}/inventory | 
[**PurchaseInvoiceAddLines**](PurchaseInvoiceApi.md#purchaseinvoiceaddlines) | **POST** /api/PurchaseInvoice/{id}/lines | 
[**PurchaseInvoiceAddLinesPreview**](PurchaseInvoiceApi.md#purchaseinvoiceaddlinespreview) | **PUT** /api/PurchaseInvoice/{id}/lines | 
[**PurchaseInvoiceCreateUsingDeliveryReceiptLines**](PurchaseInvoiceApi.md#purchaseinvoicecreateusingdeliveryreceiptlines) | **POST** /api/PurchaseInvoice/deliveryreceiptlines | 
[**PurchaseInvoiceDelete**](PurchaseInvoiceApi.md#purchaseinvoicedelete) | **DELETE** /api/PurchaseInvoice/{id} | 
[**PurchaseInvoiceDeleteAttachment**](PurchaseInvoiceApi.md#purchaseinvoicedeleteattachment) | **DELETE** /api/PurchaseInvoice/attachments | 
[**PurchaseInvoiceGet**](PurchaseInvoiceApi.md#purchaseinvoiceget) | **GET** /api/PurchaseInvoice | 
[**PurchaseInvoiceGetByID**](PurchaseInvoiceApi.md#purchaseinvoicegetbyid) | **GET** /api/PurchaseInvoice/{id} | 
[**PurchaseInvoiceGetMessages**](PurchaseInvoiceApi.md#purchaseinvoicegetmessages) | **GET** /api/PurchaseInvoice/{id}/messages | 
[**PurchaseInvoiceGetT**](PurchaseInvoiceApi.md#purchaseinvoicegett) | **GET** /api/v2/PurchaseInvoice/{id} | 
[**PurchaseInvoicePartialUpdate**](PurchaseInvoiceApi.md#purchaseinvoicepartialupdate) | **PATCH** /api/PurchaseInvoice/{id} | 
[**PurchaseInvoicePost**](PurchaseInvoiceApi.md#purchaseinvoicepost) | **POST** /api/PurchaseInvoice | 
[**PurchaseInvoicePut**](PurchaseInvoiceApi.md#purchaseinvoiceput) | **PUT** /api/PurchaseInvoice/{id} | 
[**PurchaseInvoiceSaveAttachments**](PurchaseInvoiceApi.md#purchaseinvoicesaveattachments) | **POST** /api/PurchaseInvoice/attachments | 
[**PurchaseInvoiceSendMessage**](PurchaseInvoiceApi.md#purchaseinvoicesendmessage) | **POST** /api/PurchaseInvoice/{id}/messages | 
[**PurchaseInvoiceUpdateStatus**](PurchaseInvoiceApi.md#purchaseinvoiceupdatestatus) | **POST** /api/PurchaseInvoice/{id}/status | 

<a name="purchaseinvoiceaddinventory"></a>
# **PurchaseInvoiceAddInventory**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceAddInventory (ActionRequestOfSupplierTransAddInventoryRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceAddInventoryExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new ActionRequestOfSupplierTransAddInventoryRequest(); // ActionRequestOfSupplierTransAddInventoryRequest | 
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddInventory(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceAddInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfSupplierTransAddInventoryRequest**](ActionRequestOfSupplierTransAddInventoryRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceaddlines"></a>
# **PurchaseInvoiceAddLines**
> AddLinesResponseOfPurchaseInvoiceT PurchaseInvoiceAddLines (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceAddLinesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddLines(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceAddLines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddLinesRequest**](AddLinesRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**AddLinesResponseOfPurchaseInvoiceT**](AddLinesResponseOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceaddlinespreview"></a>
# **PurchaseInvoiceAddLinesPreview**
> AddLinesResponseOfPurchaseInvoiceT PurchaseInvoiceAddLinesPreview (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceAddLinesPreviewExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddLinesPreview(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceAddLinesPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddLinesRequest**](AddLinesRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**AddLinesResponseOfPurchaseInvoiceT**](AddLinesResponseOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicecreateusingdeliveryreceiptlines"></a>
# **PurchaseInvoiceCreateUsingDeliveryReceiptLines**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceCreateUsingDeliveryReceiptLines (ActionRequestOfSupplierTransUsingTransLines body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceCreateUsingDeliveryReceiptLinesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new ActionRequestOfSupplierTransUsingTransLines(); // ActionRequestOfSupplierTransUsingTransLines | 

            try
            {
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceCreateUsingDeliveryReceiptLines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceCreateUsingDeliveryReceiptLines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfSupplierTransUsingTransLines**](ActionRequestOfSupplierTransUsingTransLines.md)|  | 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicedelete"></a>
# **PurchaseInvoiceDelete**
> ActionResults PurchaseInvoiceDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceDeleteExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseInvoiceDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceDelete: " + e.Message );
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

<a name="purchaseinvoicedeleteattachment"></a>
# **PurchaseInvoiceDeleteAttachment**
> ActionResults PurchaseInvoiceDeleteAttachment (BusTransAttachmentT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceDeleteAttachmentExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new BusTransAttachmentT(); // BusTransAttachmentT | 

            try
            {
                ActionResults result = apiInstance.PurchaseInvoiceDeleteAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceDeleteAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusTransAttachmentT**](BusTransAttachmentT.md)|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceget"></a>
# **PurchaseInvoiceGet**
> PagedActionResultsOfBusTransSearchResultsT PurchaseInvoiceGet (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List<string> filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceGetExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
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
                PagedActionResultsOfBusTransSearchResultsT result = apiInstance.PurchaseInvoiceGet(filterBusinessID, filterCustomerID, filterSupplierID, filterWarehouseID, filterDeliveryMethods, filterDatTypes, filterMaxExpiresInDays, filterRepUserID, filterIsCreatedByOtherPartyOnly, filterCreatedByUserId, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceGet: " + e.Message );
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

[**PagedActionResultsOfBusTransSearchResultsT**](PagedActionResultsOfBusTransSearchResultsT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicegetbyid"></a>
# **PurchaseInvoiceGetByID**
> TransactionEditResponseOfPurchaseInvoiceT PurchaseInvoiceGetByID (int? id, string reqLineSort, bool? reqIsLineSortDesc, bool? reqIsGetMessages, int? reqCustomerID, int? reqSupplierID, bool? reqIsPriceRefresh, List<int?> reqLineSearchFilterStatuses, List<string> reqLineSearchFilterStatusStrings, List<string> reqLineSearchFilterStatus, string reqLineSearchFilterSearchString, string reqLineSearchFilterSearch, DateTime? reqLineSearchFilterStartDate, DateTime? reqLineSearchFilterEndDate, string reqLineSearchFilterDatePeriod, bool? reqLineSearchFilterIsExactMatch, bool? reqLineSearchFilterIsGetBasicInfo, bool? reqLineSearchFilterIncludeDeleted, bool? reqLineSearchFilterIncludeLogs, int? reqLineSearchFilterIgnoreID, int? reqLineSearchFilterParentID, bool? reqLineSearchFilterGetCountOnly, int? reqLineSearchFilterTransactionTypeDatTypeID, int? reqLineSearchFilterCategoryID, int? reqLineSearchFilterAdaptorID, List<int?> reqLineSearchFilterCategoryIDs, List<int?> reqLineSearchFilterBrandIDs, List<int?> reqLineSearchFilterIDs, List<string> reqLineSearchFilterGUIDs, int? reqLineSearchFilterLinkedSupplierID, bool? reqLineSearchFilterIsApprovedForPOS, bool? reqLineSearchFilterIsApprovedForWeb, bool? reqLineSearchFilterIsApprovedForService, int? reqLineSearchFilterID, bool? reqLineSearchFilterIsHierarchicalSort, List<string> reqLineSearchFilterTypes, bool? reqLineSearchFilterIsShowFavourites, bool? reqLineSearchFilterIsHidden, bool? reqLineSearchFilterIncludeSystemTasks, bool? reqLineSearchFilterIsSystem, string reqLineSearchFilterSortField, bool? reqLineSearchFilterSortAsc, string reqLineSearchFilterGroupBy, long? reqLineSearchFilterLastRowNumber, int? reqLineSearchFilterMaxResults, int? reqLineSearchFilterTenantID, int? reqLineSearchFilterWebsiteID, int? reqLineSearchFilterUserID, bool? reqIsExcludeFailedPayments, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceGetByIDExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | 
            var reqLineSort = reqLineSort_example;  // string |  (optional) 
            var reqIsLineSortDesc = true;  // bool? |  (optional) 
            var reqIsGetMessages = true;  // bool? |  (optional) 
            var reqCustomerID = 56;  // int? |  (optional) 
            var reqSupplierID = 56;  // int? |  (optional) 
            var reqIsPriceRefresh = true;  // bool? |  (optional) 
            var reqLineSearchFilterStatuses = new List<int?>(); // List<int?> |  (optional) 
            var reqLineSearchFilterStatusStrings = new List<string>(); // List<string> |  (optional) 
            var reqLineSearchFilterStatus = new List<string>(); // List<string> |  (optional) 
            var reqLineSearchFilterSearchString = reqLineSearchFilterSearchString_example;  // string |  (optional) 
            var reqLineSearchFilterSearch = reqLineSearchFilterSearch_example;  // string |  (optional) 
            var reqLineSearchFilterStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var reqLineSearchFilterEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var reqLineSearchFilterDatePeriod = reqLineSearchFilterDatePeriod_example;  // string |  (optional) 
            var reqLineSearchFilterIsExactMatch = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsGetBasicInfo = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeDeleted = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeLogs = true;  // bool? |  (optional) 
            var reqLineSearchFilterIgnoreID = 56;  // int? |  (optional) 
            var reqLineSearchFilterParentID = 56;  // int? |  (optional) 
            var reqLineSearchFilterGetCountOnly = true;  // bool? |  (optional) 
            var reqLineSearchFilterTransactionTypeDatTypeID = 56;  // int? |  (optional) 
            var reqLineSearchFilterCategoryID = 56;  // int? |  (optional) 
            var reqLineSearchFilterAdaptorID = 56;  // int? |  (optional) 
            var reqLineSearchFilterCategoryIDs = new List<int?>(); // List<int?> |  (optional) 
            var reqLineSearchFilterBrandIDs = new List<int?>(); // List<int?> |  (optional) 
            var reqLineSearchFilterIDs = new List<int?>(); // List<int?> |  (optional) 
            var reqLineSearchFilterGUIDs = new List<string>(); // List<string> |  (optional) 
            var reqLineSearchFilterLinkedSupplierID = 56;  // int? |  (optional) 
            var reqLineSearchFilterIsApprovedForPOS = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsApprovedForWeb = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsApprovedForService = true;  // bool? |  (optional) 
            var reqLineSearchFilterID = 56;  // int? |  (optional) 
            var reqLineSearchFilterIsHierarchicalSort = true;  // bool? |  (optional) 
            var reqLineSearchFilterTypes = new List<string>(); // List<string> |  (optional) 
            var reqLineSearchFilterIsShowFavourites = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsHidden = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeSystemTasks = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsSystem = true;  // bool? |  (optional) 
            var reqLineSearchFilterSortField = reqLineSearchFilterSortField_example;  // string |  (optional) 
            var reqLineSearchFilterSortAsc = true;  // bool? |  (optional) 
            var reqLineSearchFilterGroupBy = reqLineSearchFilterGroupBy_example;  // string |  (optional) 
            var reqLineSearchFilterLastRowNumber = 789;  // long? |  (optional) 
            var reqLineSearchFilterMaxResults = 56;  // int? |  (optional) 
            var reqLineSearchFilterTenantID = 56;  // int? |  (optional) 
            var reqLineSearchFilterWebsiteID = 56;  // int? |  (optional) 
            var reqLineSearchFilterUserID = 56;  // int? |  (optional) 
            var reqIsExcludeFailedPayments = true;  // bool? |  (optional) 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
                TransactionEditResponseOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceGetByID(id, reqLineSort, reqIsLineSortDesc, reqIsGetMessages, reqCustomerID, reqSupplierID, reqIsPriceRefresh, reqLineSearchFilterStatuses, reqLineSearchFilterStatusStrings, reqLineSearchFilterStatus, reqLineSearchFilterSearchString, reqLineSearchFilterSearch, reqLineSearchFilterStartDate, reqLineSearchFilterEndDate, reqLineSearchFilterDatePeriod, reqLineSearchFilterIsExactMatch, reqLineSearchFilterIsGetBasicInfo, reqLineSearchFilterIncludeDeleted, reqLineSearchFilterIncludeLogs, reqLineSearchFilterIgnoreID, reqLineSearchFilterParentID, reqLineSearchFilterGetCountOnly, reqLineSearchFilterTransactionTypeDatTypeID, reqLineSearchFilterCategoryID, reqLineSearchFilterAdaptorID, reqLineSearchFilterCategoryIDs, reqLineSearchFilterBrandIDs, reqLineSearchFilterIDs, reqLineSearchFilterGUIDs, reqLineSearchFilterLinkedSupplierID, reqLineSearchFilterIsApprovedForPOS, reqLineSearchFilterIsApprovedForWeb, reqLineSearchFilterIsApprovedForService, reqLineSearchFilterID, reqLineSearchFilterIsHierarchicalSort, reqLineSearchFilterTypes, reqLineSearchFilterIsShowFavourites, reqLineSearchFilterIsHidden, reqLineSearchFilterIncludeSystemTasks, reqLineSearchFilterIsSystem, reqLineSearchFilterSortField, reqLineSearchFilterSortAsc, reqLineSearchFilterGroupBy, reqLineSearchFilterLastRowNumber, reqLineSearchFilterMaxResults, reqLineSearchFilterTenantID, reqLineSearchFilterWebsiteID, reqLineSearchFilterUserID, reqIsExcludeFailedPayments, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceGetByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **reqLineSort** | **string**|  | [optional] 
 **reqIsLineSortDesc** | **bool?**|  | [optional] 
 **reqIsGetMessages** | **bool?**|  | [optional] 
 **reqCustomerID** | **int?**|  | [optional] 
 **reqSupplierID** | **int?**|  | [optional] 
 **reqIsPriceRefresh** | **bool?**|  | [optional] 
 **reqLineSearchFilterStatuses** | [**List<int?>**](int?.md)|  | [optional] 
 **reqLineSearchFilterStatusStrings** | [**List<string>**](string.md)|  | [optional] 
 **reqLineSearchFilterStatus** | [**List<string>**](string.md)|  | [optional] 
 **reqLineSearchFilterSearchString** | **string**|  | [optional] 
 **reqLineSearchFilterSearch** | **string**|  | [optional] 
 **reqLineSearchFilterStartDate** | **DateTime?**|  | [optional] 
 **reqLineSearchFilterEndDate** | **DateTime?**|  | [optional] 
 **reqLineSearchFilterDatePeriod** | **string**|  | [optional] 
 **reqLineSearchFilterIsExactMatch** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsGetBasicInfo** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeDeleted** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeLogs** | **bool?**|  | [optional] 
 **reqLineSearchFilterIgnoreID** | **int?**|  | [optional] 
 **reqLineSearchFilterParentID** | **int?**|  | [optional] 
 **reqLineSearchFilterGetCountOnly** | **bool?**|  | [optional] 
 **reqLineSearchFilterTransactionTypeDatTypeID** | **int?**|  | [optional] 
 **reqLineSearchFilterCategoryID** | **int?**|  | [optional] 
 **reqLineSearchFilterAdaptorID** | **int?**|  | [optional] 
 **reqLineSearchFilterCategoryIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **reqLineSearchFilterBrandIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **reqLineSearchFilterIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **reqLineSearchFilterGUIDs** | [**List<string>**](string.md)|  | [optional] 
 **reqLineSearchFilterLinkedSupplierID** | **int?**|  | [optional] 
 **reqLineSearchFilterIsApprovedForPOS** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsApprovedForWeb** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsApprovedForService** | **bool?**|  | [optional] 
 **reqLineSearchFilterID** | **int?**|  | [optional] 
 **reqLineSearchFilterIsHierarchicalSort** | **bool?**|  | [optional] 
 **reqLineSearchFilterTypes** | [**List<string>**](string.md)|  | [optional] 
 **reqLineSearchFilterIsShowFavourites** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsHidden** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeSystemTasks** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsSystem** | **bool?**|  | [optional] 
 **reqLineSearchFilterSortField** | **string**|  | [optional] 
 **reqLineSearchFilterSortAsc** | **bool?**|  | [optional] 
 **reqLineSearchFilterGroupBy** | **string**|  | [optional] 
 **reqLineSearchFilterLastRowNumber** | **long?**|  | [optional] 
 **reqLineSearchFilterMaxResults** | **int?**|  | [optional] 
 **reqLineSearchFilterTenantID** | **int?**|  | [optional] 
 **reqLineSearchFilterWebsiteID** | **int?**|  | [optional] 
 **reqLineSearchFilterUserID** | **int?**|  | [optional] 
 **reqIsExcludeFailedPayments** | **bool?**|  | [optional] 
 **reqID** | **int?**|  | [optional] 
 **reqGUID** | [**Guid?**](.md)|  | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**|  | [optional] 
 **reqWebsiteID** | **int?**|  | [optional] 
 **reqUserID** | **int?**|  | [optional] 

### Return type

[**TransactionEditResponseOfPurchaseInvoiceT**](TransactionEditResponseOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicegetmessages"></a>
# **PurchaseInvoiceGetMessages**
> ActionResultsOfBusTransMessages PurchaseInvoiceGetMessages (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceGetMessagesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfBusTransMessages result = apiInstance.PurchaseInvoiceGetMessages(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceGetMessages: " + e.Message );
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

[**ActionResultsOfBusTransMessages**](ActionResultsOfBusTransMessages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicegett"></a>
# **PurchaseInvoiceGetT**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceGetT (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceGetTExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceGetT(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceGetT: " + e.Message );
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

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicepartialupdate"></a>
# **PurchaseInvoicePartialUpdate**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoicePartialUpdate (ActionRequestOfPurchaseInvoiceT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoicePartialUpdateExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new ActionRequestOfPurchaseInvoiceT(); // ActionRequestOfPurchaseInvoiceT | 
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoicePartialUpdate(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoicePartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfPurchaseInvoiceT**](ActionRequestOfPurchaseInvoiceT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicepost"></a>
# **PurchaseInvoicePost**
> SynkSaveQueueResponse PurchaseInvoicePost (TransactionSaveRequestOfPurchaseInvoiceT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoicePostExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new TransactionSaveRequestOfPurchaseInvoiceT(); // TransactionSaveRequestOfPurchaseInvoiceT | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.PurchaseInvoicePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoicePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfPurchaseInvoiceT**](TransactionSaveRequestOfPurchaseInvoiceT.md)|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceput"></a>
# **PurchaseInvoicePut**
> SynkSaveQueueResponse PurchaseInvoicePut (TransactionSaveRequestOfPurchaseInvoiceT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoicePutExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new TransactionSaveRequestOfPurchaseInvoiceT(); // TransactionSaveRequestOfPurchaseInvoiceT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.PurchaseInvoicePut(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoicePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfPurchaseInvoiceT**](TransactionSaveRequestOfPurchaseInvoiceT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicesaveattachments"></a>
# **PurchaseInvoiceSaveAttachments**
> List<FileDetails> PurchaseInvoiceSaveAttachments ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceSaveAttachmentsExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();

            try
            {
                List&lt;FileDetails&gt; result = apiInstance.PurchaseInvoiceSaveAttachments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceSaveAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FileDetails>**](FileDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicesendmessage"></a>
# **PurchaseInvoiceSendMessage**
> ActionResults PurchaseInvoiceSendMessage (BusTransMessageT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceSendMessageExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new BusTransMessageT(); // BusTransMessageT | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseInvoiceSendMessage(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceSendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusTransMessageT**](BusTransMessageT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceupdatestatus"></a>
# **PurchaseInvoiceUpdateStatus**
> ActionResults PurchaseInvoiceUpdateStatus (UpdateTransStatusRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseInvoiceUpdateStatusExample
    {
        public void main()
        {

            var apiInstance = new PurchaseInvoiceApi();
            var body = new UpdateTransStatusRequest(); // UpdateTransStatusRequest | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseInvoiceUpdateStatus(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseInvoiceApi.PurchaseInvoiceUpdateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateTransStatusRequest**](UpdateTransStatusRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

