# IO.Swagger.Api.PurchaseOrdersApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PurchaseOrdersAddLines**](PurchaseOrdersApi.md#purchaseordersaddlines) | **POST** /api/PurchaseOrders/{id}/lines | 
[**PurchaseOrdersAddLinesPreview**](PurchaseOrdersApi.md#purchaseordersaddlinespreview) | **PUT** /api/PurchaseOrders/{id}/lines | 
[**PurchaseOrdersDelete**](PurchaseOrdersApi.md#purchaseordersdelete) | **DELETE** /api/PurchaseOrders/{id} | 
[**PurchaseOrdersDeleteAttachment**](PurchaseOrdersApi.md#purchaseordersdeleteattachment) | **DELETE** /api/PurchaseOrders/attachments | 
[**PurchaseOrdersGet**](PurchaseOrdersApi.md#purchaseordersget) | **GET** /api/PurchaseOrders | 
[**PurchaseOrdersGetByID**](PurchaseOrdersApi.md#purchaseordersgetbyid) | **GET** /api/PurchaseOrders/{id} | 
[**PurchaseOrdersGetMessages**](PurchaseOrdersApi.md#purchaseordersgetmessages) | **GET** /api/PurchaseOrders/{id}/messages | 
[**PurchaseOrdersGetSupplierOrderLines**](PurchaseOrdersApi.md#purchaseordersgetsupplierorderlines) | **GET** /api/PurchaseOrders/supplierorderlines | 
[**PurchaseOrdersGetSupplierOrders**](PurchaseOrdersApi.md#purchaseordersgetsupplierorders) | **GET** /api/PurchaseOrders/supplierorders | 
[**PurchaseOrdersMergeInventory**](PurchaseOrdersApi.md#purchaseordersmergeinventory) | **POST** /api/PurchaseOrders/{id}/lines/{lineID}/merge | 
[**PurchaseOrdersPost**](PurchaseOrdersApi.md#purchaseorderspost) | **POST** /api/PurchaseOrders | 
[**PurchaseOrdersPut**](PurchaseOrdersApi.md#purchaseordersput) | **PUT** /api/PurchaseOrders/{id} | 
[**PurchaseOrdersSaveAttachments**](PurchaseOrdersApi.md#purchaseorderssaveattachments) | **POST** /api/PurchaseOrders/attachments | 
[**PurchaseOrdersSendMessage**](PurchaseOrdersApi.md#purchaseorderssendmessage) | **POST** /api/PurchaseOrders/{id}/messages | 
[**PurchaseOrdersUpdateLine**](PurchaseOrdersApi.md#purchaseordersupdateline) | **PATCH** /api/PurchaseOrders/lines | 
[**PurchaseOrdersUpdateStatus**](PurchaseOrdersApi.md#purchaseordersupdatestatus) | **POST** /api/PurchaseOrders/{id}/status | 

<a name="purchaseordersaddlines"></a>
# **PurchaseOrdersAddLines**
> AddLinesResponseOfPurchaseOrderT PurchaseOrdersAddLines (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersAddLinesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfPurchaseOrderT result = apiInstance.PurchaseOrdersAddLines(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersAddLines: " + e.Message );
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

[**AddLinesResponseOfPurchaseOrderT**](AddLinesResponseOfPurchaseOrderT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersaddlinespreview"></a>
# **PurchaseOrdersAddLinesPreview**
> AddLinesResponseOfPurchaseOrderT PurchaseOrdersAddLinesPreview (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersAddLinesPreviewExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfPurchaseOrderT result = apiInstance.PurchaseOrdersAddLinesPreview(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersAddLinesPreview: " + e.Message );
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

[**AddLinesResponseOfPurchaseOrderT**](AddLinesResponseOfPurchaseOrderT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersdelete"></a>
# **PurchaseOrdersDelete**
> ActionResults PurchaseOrdersDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersDeleteExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseOrdersDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersDelete: " + e.Message );
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

<a name="purchaseordersdeleteattachment"></a>
# **PurchaseOrdersDeleteAttachment**
> ActionResults PurchaseOrdersDeleteAttachment (BusTransAttachmentT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersDeleteAttachmentExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new BusTransAttachmentT(); // BusTransAttachmentT | 

            try
            {
                ActionResults result = apiInstance.PurchaseOrdersDeleteAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersDeleteAttachment: " + e.Message );
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

<a name="purchaseordersget"></a>
# **PurchaseOrdersGet**
> PagedActionResultsOfBusTransSearchResultsT PurchaseOrdersGet (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List<string> filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
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
                PagedActionResultsOfBusTransSearchResultsT result = apiInstance.PurchaseOrdersGet(filterBusinessID, filterCustomerID, filterSupplierID, filterWarehouseID, filterDeliveryMethods, filterDatTypes, filterMaxExpiresInDays, filterRepUserID, filterIsCreatedByOtherPartyOnly, filterCreatedByUserId, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGet: " + e.Message );
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

<a name="purchaseordersgetbyid"></a>
# **PurchaseOrdersGetByID**
> TransactionEditResponseOfPurchaseOrderT PurchaseOrdersGetByID (int? id, string reqLineSort, bool? reqIsLineSortDesc, bool? reqIsGetMessages, int? reqCustomerID, int? reqSupplierID, bool? reqIsPriceRefresh, List<int?> reqLineSearchFilterStatuses, List<string> reqLineSearchFilterStatusStrings, List<string> reqLineSearchFilterStatus, string reqLineSearchFilterSearchString, string reqLineSearchFilterSearch, DateTime? reqLineSearchFilterStartDate, DateTime? reqLineSearchFilterEndDate, string reqLineSearchFilterDatePeriod, bool? reqLineSearchFilterIsExactMatch, bool? reqLineSearchFilterIsGetBasicInfo, bool? reqLineSearchFilterIncludeDeleted, bool? reqLineSearchFilterIncludeLogs, int? reqLineSearchFilterIgnoreID, int? reqLineSearchFilterParentID, bool? reqLineSearchFilterGetCountOnly, int? reqLineSearchFilterTransactionTypeDatTypeID, int? reqLineSearchFilterCategoryID, int? reqLineSearchFilterAdaptorID, List<int?> reqLineSearchFilterCategoryIDs, List<int?> reqLineSearchFilterBrandIDs, List<int?> reqLineSearchFilterIDs, List<string> reqLineSearchFilterGUIDs, int? reqLineSearchFilterLinkedSupplierID, bool? reqLineSearchFilterIsApprovedForPOS, bool? reqLineSearchFilterIsApprovedForWeb, bool? reqLineSearchFilterIsApprovedForService, int? reqLineSearchFilterID, bool? reqLineSearchFilterIsHierarchicalSort, List<string> reqLineSearchFilterTypes, bool? reqLineSearchFilterIsShowFavourites, bool? reqLineSearchFilterIsHidden, bool? reqLineSearchFilterIncludeSystemTasks, bool? reqLineSearchFilterIsSystem, string reqLineSearchFilterSortField, bool? reqLineSearchFilterSortAsc, string reqLineSearchFilterGroupBy, long? reqLineSearchFilterLastRowNumber, int? reqLineSearchFilterMaxResults, int? reqLineSearchFilterTenantID, int? reqLineSearchFilterWebsiteID, int? reqLineSearchFilterUserID, bool? reqIsExcludeFailedPayments, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetByIDExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
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
                TransactionEditResponseOfPurchaseOrderT result = apiInstance.PurchaseOrdersGetByID(id, reqLineSort, reqIsLineSortDesc, reqIsGetMessages, reqCustomerID, reqSupplierID, reqIsPriceRefresh, reqLineSearchFilterStatuses, reqLineSearchFilterStatusStrings, reqLineSearchFilterStatus, reqLineSearchFilterSearchString, reqLineSearchFilterSearch, reqLineSearchFilterStartDate, reqLineSearchFilterEndDate, reqLineSearchFilterDatePeriod, reqLineSearchFilterIsExactMatch, reqLineSearchFilterIsGetBasicInfo, reqLineSearchFilterIncludeDeleted, reqLineSearchFilterIncludeLogs, reqLineSearchFilterIgnoreID, reqLineSearchFilterParentID, reqLineSearchFilterGetCountOnly, reqLineSearchFilterTransactionTypeDatTypeID, reqLineSearchFilterCategoryID, reqLineSearchFilterAdaptorID, reqLineSearchFilterCategoryIDs, reqLineSearchFilterBrandIDs, reqLineSearchFilterIDs, reqLineSearchFilterGUIDs, reqLineSearchFilterLinkedSupplierID, reqLineSearchFilterIsApprovedForPOS, reqLineSearchFilterIsApprovedForWeb, reqLineSearchFilterIsApprovedForService, reqLineSearchFilterID, reqLineSearchFilterIsHierarchicalSort, reqLineSearchFilterTypes, reqLineSearchFilterIsShowFavourites, reqLineSearchFilterIsHidden, reqLineSearchFilterIncludeSystemTasks, reqLineSearchFilterIsSystem, reqLineSearchFilterSortField, reqLineSearchFilterSortAsc, reqLineSearchFilterGroupBy, reqLineSearchFilterLastRowNumber, reqLineSearchFilterMaxResults, reqLineSearchFilterTenantID, reqLineSearchFilterWebsiteID, reqLineSearchFilterUserID, reqIsExcludeFailedPayments, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetByID: " + e.Message );
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

[**TransactionEditResponseOfPurchaseOrderT**](TransactionEditResponseOfPurchaseOrderT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetmessages"></a>
# **PurchaseOrdersGetMessages**
> ActionResultsOfBusTransMessages PurchaseOrdersGetMessages (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetMessagesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfBusTransMessages result = apiInstance.PurchaseOrdersGetMessages(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetMessages: " + e.Message );
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

<a name="purchaseordersgetsupplierorderlines"></a>
# **PurchaseOrdersGetSupplierOrderLines**
> PagedActionResultsOfSupplierTransLineGroupT PurchaseOrdersGetSupplierOrderLines (int? filterSupplierID, int? filterWarehouseID, List<int?> filterTransIDs, string filterSortField, string filterSearchString, bool? filterSortAsc, int? filterStartRow, int? filterMaxResults)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetSupplierOrderLinesExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterTransIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterStartRow = 56;  // int? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 

            try
            {
                PagedActionResultsOfSupplierTransLineGroupT result = apiInstance.PurchaseOrdersGetSupplierOrderLines(filterSupplierID, filterWarehouseID, filterTransIDs, filterSortField, filterSearchString, filterSortAsc, filterStartRow, filterMaxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetSupplierOrderLines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSupplierID** | **int?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterTransIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterStartRow** | **int?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfSupplierTransLineGroupT**](PagedActionResultsOfSupplierTransLineGroupT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetsupplierorders"></a>
# **PurchaseOrdersGetSupplierOrders**
> PagedActionResultsOfSupplierTransGroups PurchaseOrdersGetSupplierOrders (int? filterSupplierID, int? filterWarehouseID, List<int?> filterTransIDs, string filterSortField, string filterSearchString, bool? filterSortAsc, int? filterStartRow, int? filterMaxResults)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetSupplierOrdersExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterTransIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterSortAsc = true;  // bool? |  (optional) 
            var filterStartRow = 56;  // int? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 

            try
            {
                PagedActionResultsOfSupplierTransGroups result = apiInstance.PurchaseOrdersGetSupplierOrders(filterSupplierID, filterWarehouseID, filterTransIDs, filterSortField, filterSearchString, filterSortAsc, filterStartRow, filterMaxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetSupplierOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSupplierID** | **int?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterTransIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterSortAsc** | **bool?**|  | [optional] 
 **filterStartRow** | **int?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfSupplierTransGroups**](PagedActionResultsOfSupplierTransGroups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersmergeinventory"></a>
# **PurchaseOrdersMergeInventory**
> MergeInventoryResponseOfBusTransLines PurchaseOrdersMergeInventory (MergeInventoryLineRequest body, int? id, int? lineID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersMergeInventoryExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new MergeInventoryLineRequest(); // MergeInventoryLineRequest | 
            var id = 56;  // int? | 
            var lineID = 56;  // int? | 

            try
            {
                MergeInventoryResponseOfBusTransLines result = apiInstance.PurchaseOrdersMergeInventory(body, id, lineID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersMergeInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MergeInventoryLineRequest**](MergeInventoryLineRequest.md)|  | 
 **id** | **int?**|  | 
 **lineID** | **int?**|  | 

### Return type

[**MergeInventoryResponseOfBusTransLines**](MergeInventoryResponseOfBusTransLines.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseorderspost"></a>
# **PurchaseOrdersPost**
> SynkSaveQueueResponse PurchaseOrdersPost (TransactionSaveRequestOfPurchaseOrderT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersPostExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new TransactionSaveRequestOfPurchaseOrderT(); // TransactionSaveRequestOfPurchaseOrderT | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.PurchaseOrdersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfPurchaseOrderT**](TransactionSaveRequestOfPurchaseOrderT.md)|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersput"></a>
# **PurchaseOrdersPut**
> SynkSaveQueueResponse PurchaseOrdersPut (TransactionSaveRequestOfPurchaseOrderT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersPutExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new TransactionSaveRequestOfPurchaseOrderT(); // TransactionSaveRequestOfPurchaseOrderT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.PurchaseOrdersPut(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfPurchaseOrderT**](TransactionSaveRequestOfPurchaseOrderT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseorderssaveattachments"></a>
# **PurchaseOrdersSaveAttachments**
> List<FileDetails> PurchaseOrdersSaveAttachments ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersSaveAttachmentsExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();

            try
            {
                List&lt;FileDetails&gt; result = apiInstance.PurchaseOrdersSaveAttachments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersSaveAttachments: " + e.Message );
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

<a name="purchaseorderssendmessage"></a>
# **PurchaseOrdersSendMessage**
> ActionResults PurchaseOrdersSendMessage (BusTransMessageT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersSendMessageExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new BusTransMessageT(); // BusTransMessageT | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseOrdersSendMessage(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersSendMessage: " + e.Message );
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

<a name="purchaseordersupdateline"></a>
# **PurchaseOrdersUpdateLine**
> ActionResults PurchaseOrdersUpdateLine (ActionRequestOfUpdateLinesRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersUpdateLineExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new ActionRequestOfUpdateLinesRequest(); // ActionRequestOfUpdateLinesRequest | 

            try
            {
                ActionResults result = apiInstance.PurchaseOrdersUpdateLine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersUpdateLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfUpdateLinesRequest**](ActionRequestOfUpdateLinesRequest.md)|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersupdatestatus"></a>
# **PurchaseOrdersUpdateStatus**
> ActionResults PurchaseOrdersUpdateStatus (UpdateTransStatusRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersUpdateStatusExample
    {
        public void main()
        {

            var apiInstance = new PurchaseOrdersApi();
            var body = new UpdateTransStatusRequest(); // UpdateTransStatusRequest | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PurchaseOrdersUpdateStatus(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersUpdateStatus: " + e.Message );
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

