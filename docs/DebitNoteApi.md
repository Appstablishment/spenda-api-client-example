# IO.Swagger.Api.DebitNoteApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DebitNoteAddLines**](DebitNoteApi.md#debitnoteaddlines) | **POST** /api/DebitNote/{id}/lines | DebitNote_AddLines
[**DebitNoteAddLinesPreview**](DebitNoteApi.md#debitnoteaddlinespreview) | **PUT** /api/DebitNote/{id}/lines | DebitNote_AddLinesPreview
[**DebitNoteDelete**](DebitNoteApi.md#debitnotedelete) | **DELETE** /api/DebitNote/{id} | DebitNote_Delete
[**DebitNoteDeleteAttachment**](DebitNoteApi.md#debitnotedeleteattachment) | **DELETE** /api/DebitNote/attachments | DebitNote_DeleteAttachment
[**DebitNoteGet**](DebitNoteApi.md#debitnoteget) | **GET** /api/DebitNote | DebitNote_Get
[**DebitNoteGetByID**](DebitNoteApi.md#debitnotegetbyid) | **GET** /api/DebitNote/{id} | DebitNote_GetByID
[**DebitNoteGetMessages**](DebitNoteApi.md#debitnotegetmessages) | **GET** /api/DebitNote/{id}/messages | DebitNote_GetMessages
[**DebitNotePost**](DebitNoteApi.md#debitnotepost) | **POST** /api/DebitNote | DebitNote_Post
[**DebitNotePut**](DebitNoteApi.md#debitnoteput) | **PUT** /api/DebitNote/{id} | DebitNote_Put
[**DebitNoteSaveAttachments**](DebitNoteApi.md#debitnotesaveattachments) | **POST** /api/DebitNote/attachments | DebitNote_SaveAttachments
[**DebitNoteSendMessage**](DebitNoteApi.md#debitnotesendmessage) | **POST** /api/DebitNote/{id}/messages | DebitNote_SendMessage
[**DebitNoteUpdateStatus**](DebitNoteApi.md#debitnoteupdatestatus) | **POST** /api/DebitNote/{id}/status | DebitNote_UpdateStatus

<a name="debitnoteaddlines"></a>
# **DebitNoteAddLines**
> AddLinesResponseOfDebitNoteT DebitNoteAddLines (int? id, AddLinesRequestRequestXml1 body)

DebitNote_AddLines

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteAddLinesExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // DebitNote_AddLines
                AddLinesResponseOfDebitNoteT result = apiInstance.DebitNoteAddLines(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteAddLines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**AddLinesRequestRequestXml1**](AddLinesRequestRequestXml1.md)|  | [optional] 

### Return type

[**AddLinesResponseOfDebitNoteT**](AddLinesResponseOfDebitNoteT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnoteaddlinespreview"></a>
# **DebitNoteAddLinesPreview**
> AddLinesResponseOfDebitNoteT DebitNoteAddLinesPreview (int? id, AddLinesRequestRequestXml1 body)

DebitNote_AddLinesPreview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteAddLinesPreviewExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // DebitNote_AddLinesPreview
                AddLinesResponseOfDebitNoteT result = apiInstance.DebitNoteAddLinesPreview(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteAddLinesPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**AddLinesRequestRequestXml1**](AddLinesRequestRequestXml1.md)|  | [optional] 

### Return type

[**AddLinesResponseOfDebitNoteT**](AddLinesResponseOfDebitNoteT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotedelete"></a>
# **DebitNoteDelete**
> ActionResults DebitNoteDelete (int? id)

DebitNote_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteDeleteExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // DebitNote_Delete
                ActionResults result = apiInstance.DebitNoteDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteDelete: " + e.Message );
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

<a name="debitnotedeleteattachment"></a>
# **DebitNoteDeleteAttachment**
> ActionResults DebitNoteDeleteAttachment (BusTransAttachmentTRequestXml1 body)

DebitNote_DeleteAttachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteDeleteAttachmentExample
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

            var apiInstance = new DebitNoteApi();
            var body = new BusTransAttachmentTRequestXml1(); // BusTransAttachmentTRequestXml1 |  (optional) 

            try
            {
                // DebitNote_DeleteAttachment
                ActionResults result = apiInstance.DebitNoteDeleteAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteDeleteAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusTransAttachmentTRequestXml1**](BusTransAttachmentTRequestXml1.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnoteget"></a>
# **DebitNoteGet**
> PagedActionResultsOfBusTransSearchResultsT DebitNoteGet (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

DebitNote_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteGetExample
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

            var apiInstance = new DebitNoteApi();
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
                // DebitNote_Get
                PagedActionResultsOfBusTransSearchResultsT result = apiInstance.DebitNoteGet(filterBusinessID, filterCustomerID, filterSupplierID, filterWarehouseID, filterDeliveryMethods, filterDatTypes, filterMaxExpiresInDays, filterRepUserID, filterIsCreatedByOtherPartyOnly, filterCreatedByUserId, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteGet: " + e.Message );
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

[**PagedActionResultsOfBusTransSearchResultsT**](PagedActionResultsOfBusTransSearchResultsT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotegetbyid"></a>
# **DebitNoteGetByID**
> TransactionEditResponseOfDebitNoteT DebitNoteGetByID (int? id, string reqLineSort, bool? reqIsLineSortDesc, bool? reqIsGetMessages, int? reqCustomerID, int? reqSupplierID, bool? reqIsPriceRefresh, List reqLineSearchFilterStatuses, List reqLineSearchFilterStatusStrings, List reqLineSearchFilterStatus, string reqLineSearchFilterSearchString, string reqLineSearchFilterSearch, string reqLineSearchFilterStartDate, string reqLineSearchFilterEndDate, string reqLineSearchFilterDatePeriod, bool? reqLineSearchFilterIsExactMatch, bool? reqLineSearchFilterIsGetBasicInfo, bool? reqLineSearchFilterIncludeDeleted, bool? reqLineSearchFilterIncludeLogs, int? reqLineSearchFilterIgnoreID, int? reqLineSearchFilterParentID, bool? reqLineSearchFilterGetCountOnly, int? reqLineSearchFilterTransactionTypeDatTypeID, int? reqLineSearchFilterCategoryID, int? reqLineSearchFilterAdaptorID, List reqLineSearchFilterCategoryIDs, List reqLineSearchFilterBrandIDs, List reqLineSearchFilterIDs, List reqLineSearchFilterGUIDs, int? reqLineSearchFilterLinkedSupplierID, bool? reqLineSearchFilterIsApprovedForPOS, bool? reqLineSearchFilterIsApprovedForWeb, bool? reqLineSearchFilterIsApprovedForService, int? reqLineSearchFilterID, bool? reqLineSearchFilterIsHierarchicalSort, List reqLineSearchFilterTypes, bool? reqLineSearchFilterIsShowFavourites, bool? reqLineSearchFilterIsHidden, bool? reqLineSearchFilterIncludeSystemTasks, bool? reqLineSearchFilterIsSystem, string reqLineSearchFilterSortField, bool? reqLineSearchFilterSortAsc, string reqLineSearchFilterGroupBy, int? reqLineSearchFilterLastRowNumber, int? reqLineSearchFilterMaxResults, int? reqLineSearchFilterTenantID, int? reqLineSearchFilterWebsiteID, int? reqLineSearchFilterUserID, bool? reqIsExcludeFailedPayments, int? reqID, string reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)

DebitNote_GetByID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteGetByIDExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var reqLineSort = reqLineSort_example;  // string |  (optional) 
            var reqIsLineSortDesc = true;  // bool? |  (optional) 
            var reqIsGetMessages = true;  // bool? |  (optional) 
            var reqCustomerID = 56;  // int? | Format - int32. (optional) 
            var reqSupplierID = 56;  // int? | Format - int32. (optional) 
            var reqIsPriceRefresh = true;  // bool? |  (optional) 
            var reqLineSearchFilterStatuses = new List(); // List |  (optional) 
            var reqLineSearchFilterStatusStrings = new List(); // List |  (optional) 
            var reqLineSearchFilterStatus = new List(); // List |  (optional) 
            var reqLineSearchFilterSearchString = reqLineSearchFilterSearchString_example;  // string |  (optional) 
            var reqLineSearchFilterSearch = reqLineSearchFilterSearch_example;  // string |  (optional) 
            var reqLineSearchFilterStartDate = reqLineSearchFilterStartDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var reqLineSearchFilterEndDate = reqLineSearchFilterEndDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var reqLineSearchFilterDatePeriod = reqLineSearchFilterDatePeriod_example;  // string |  (optional) 
            var reqLineSearchFilterIsExactMatch = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsGetBasicInfo = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeDeleted = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeLogs = true;  // bool? |  (optional) 
            var reqLineSearchFilterIgnoreID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterParentID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterGetCountOnly = true;  // bool? |  (optional) 
            var reqLineSearchFilterTransactionTypeDatTypeID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterCategoryID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterAdaptorID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterCategoryIDs = new List(); // List |  (optional) 
            var reqLineSearchFilterBrandIDs = new List(); // List |  (optional) 
            var reqLineSearchFilterIDs = new List(); // List |  (optional) 
            var reqLineSearchFilterGUIDs = new List(); // List |  (optional) 
            var reqLineSearchFilterLinkedSupplierID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterIsApprovedForPOS = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsApprovedForWeb = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsApprovedForService = true;  // bool? |  (optional) 
            var reqLineSearchFilterID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterIsHierarchicalSort = true;  // bool? |  (optional) 
            var reqLineSearchFilterTypes = new List(); // List |  (optional) 
            var reqLineSearchFilterIsShowFavourites = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsHidden = true;  // bool? |  (optional) 
            var reqLineSearchFilterIncludeSystemTasks = true;  // bool? |  (optional) 
            var reqLineSearchFilterIsSystem = true;  // bool? |  (optional) 
            var reqLineSearchFilterSortField = reqLineSearchFilterSortField_example;  // string |  (optional) 
            var reqLineSearchFilterSortAsc = true;  // bool? |  (optional) 
            var reqLineSearchFilterGroupBy = reqLineSearchFilterGroupBy_example;  // string |  (optional) 
            var reqLineSearchFilterLastRowNumber = 56;  // int? | Format - int64. (optional) 
            var reqLineSearchFilterMaxResults = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterTenantID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterWebsiteID = 56;  // int? | Format - int32. (optional) 
            var reqLineSearchFilterUserID = 56;  // int? | Format - int32. (optional) 
            var reqIsExcludeFailedPayments = true;  // bool? |  (optional) 
            var reqID = 56;  // int? | Format - int32. (optional) 
            var reqGUID = reqGUID_example;  // string | Format - uuid. (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? | Format - int32. (optional) 
            var reqWebsiteID = 56;  // int? | Format - int32. (optional) 
            var reqUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // DebitNote_GetByID
                TransactionEditResponseOfDebitNoteT result = apiInstance.DebitNoteGetByID(id, reqLineSort, reqIsLineSortDesc, reqIsGetMessages, reqCustomerID, reqSupplierID, reqIsPriceRefresh, reqLineSearchFilterStatuses, reqLineSearchFilterStatusStrings, reqLineSearchFilterStatus, reqLineSearchFilterSearchString, reqLineSearchFilterSearch, reqLineSearchFilterStartDate, reqLineSearchFilterEndDate, reqLineSearchFilterDatePeriod, reqLineSearchFilterIsExactMatch, reqLineSearchFilterIsGetBasicInfo, reqLineSearchFilterIncludeDeleted, reqLineSearchFilterIncludeLogs, reqLineSearchFilterIgnoreID, reqLineSearchFilterParentID, reqLineSearchFilterGetCountOnly, reqLineSearchFilterTransactionTypeDatTypeID, reqLineSearchFilterCategoryID, reqLineSearchFilterAdaptorID, reqLineSearchFilterCategoryIDs, reqLineSearchFilterBrandIDs, reqLineSearchFilterIDs, reqLineSearchFilterGUIDs, reqLineSearchFilterLinkedSupplierID, reqLineSearchFilterIsApprovedForPOS, reqLineSearchFilterIsApprovedForWeb, reqLineSearchFilterIsApprovedForService, reqLineSearchFilterID, reqLineSearchFilterIsHierarchicalSort, reqLineSearchFilterTypes, reqLineSearchFilterIsShowFavourites, reqLineSearchFilterIsHidden, reqLineSearchFilterIncludeSystemTasks, reqLineSearchFilterIsSystem, reqLineSearchFilterSortField, reqLineSearchFilterSortAsc, reqLineSearchFilterGroupBy, reqLineSearchFilterLastRowNumber, reqLineSearchFilterMaxResults, reqLineSearchFilterTenantID, reqLineSearchFilterWebsiteID, reqLineSearchFilterUserID, reqIsExcludeFailedPayments, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteGetByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **reqLineSort** | **string**|  | [optional] 
 **reqIsLineSortDesc** | **bool?**|  | [optional] 
 **reqIsGetMessages** | **bool?**|  | [optional] 
 **reqCustomerID** | **int?**| Format - int32. | [optional] 
 **reqSupplierID** | **int?**| Format - int32. | [optional] 
 **reqIsPriceRefresh** | **bool?**|  | [optional] 
 **reqLineSearchFilterStatuses** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterStatusStrings** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterStatus** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterSearchString** | **string**|  | [optional] 
 **reqLineSearchFilterSearch** | **string**|  | [optional] 
 **reqLineSearchFilterStartDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **reqLineSearchFilterEndDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **reqLineSearchFilterDatePeriod** | **string**|  | [optional] 
 **reqLineSearchFilterIsExactMatch** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsGetBasicInfo** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeDeleted** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeLogs** | **bool?**|  | [optional] 
 **reqLineSearchFilterIgnoreID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterParentID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterGetCountOnly** | **bool?**|  | [optional] 
 **reqLineSearchFilterTransactionTypeDatTypeID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterCategoryID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterAdaptorID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterCategoryIDs** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterBrandIDs** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterIDs** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterGUIDs** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterLinkedSupplierID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterIsApprovedForPOS** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsApprovedForWeb** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsApprovedForService** | **bool?**|  | [optional] 
 **reqLineSearchFilterID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterIsHierarchicalSort** | **bool?**|  | [optional] 
 **reqLineSearchFilterTypes** | [**List**](.md)|  | [optional] 
 **reqLineSearchFilterIsShowFavourites** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsHidden** | **bool?**|  | [optional] 
 **reqLineSearchFilterIncludeSystemTasks** | **bool?**|  | [optional] 
 **reqLineSearchFilterIsSystem** | **bool?**|  | [optional] 
 **reqLineSearchFilterSortField** | **string**|  | [optional] 
 **reqLineSearchFilterSortAsc** | **bool?**|  | [optional] 
 **reqLineSearchFilterGroupBy** | **string**|  | [optional] 
 **reqLineSearchFilterLastRowNumber** | **int?**| Format - int64. | [optional] 
 **reqLineSearchFilterMaxResults** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterTenantID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterWebsiteID** | **int?**| Format - int32. | [optional] 
 **reqLineSearchFilterUserID** | **int?**| Format - int32. | [optional] 
 **reqIsExcludeFailedPayments** | **bool?**|  | [optional] 
 **reqID** | **int?**| Format - int32. | [optional] 
 **reqGUID** | **string**| Format - uuid. | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**| Format - int32. | [optional] 
 **reqWebsiteID** | **int?**| Format - int32. | [optional] 
 **reqUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**TransactionEditResponseOfDebitNoteT**](TransactionEditResponseOfDebitNoteT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotegetmessages"></a>
# **DebitNoteGetMessages**
> ActionResultsOfBusTransMessages DebitNoteGetMessages (int? id)

DebitNote_GetMessages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteGetMessagesExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // DebitNote_GetMessages
                ActionResultsOfBusTransMessages result = apiInstance.DebitNoteGetMessages(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteGetMessages: " + e.Message );
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

[**ActionResultsOfBusTransMessages**](ActionResultsOfBusTransMessages.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotepost"></a>
# **DebitNotePost**
> SynkSaveQueueResponse DebitNotePost (TransactionSaveRequestOfDebitNoteTRequestXml1 body)

DebitNote_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNotePostExample
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

            var apiInstance = new DebitNoteApi();
            var body = new TransactionSaveRequestOfDebitNoteTRequestXml1(); // TransactionSaveRequestOfDebitNoteTRequestXml1 |  (optional) 

            try
            {
                // DebitNote_Post
                SynkSaveQueueResponse result = apiInstance.DebitNotePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNotePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfDebitNoteTRequestXml1**](TransactionSaveRequestOfDebitNoteTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnoteput"></a>
# **DebitNotePut**
> SynkSaveQueueResponse DebitNotePut (int? id, TransactionSaveRequestOfDebitNoteTRequestXml1 body)

DebitNote_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNotePutExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var body = new TransactionSaveRequestOfDebitNoteTRequestXml1(); // TransactionSaveRequestOfDebitNoteTRequestXml1 |  (optional) 

            try
            {
                // DebitNote_Put
                SynkSaveQueueResponse result = apiInstance.DebitNotePut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNotePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**TransactionSaveRequestOfDebitNoteTRequestXml1**](TransactionSaveRequestOfDebitNoteTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotesaveattachments"></a>
# **DebitNoteSaveAttachments**
> ApiDebitNoteAttachmentsPost200ApplicationJsonResponse DebitNoteSaveAttachments ()

DebitNote_SaveAttachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteSaveAttachmentsExample
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

            var apiInstance = new DebitNoteApi();

            try
            {
                // DebitNote_SaveAttachments
                ApiDebitNoteAttachmentsPost200ApplicationJsonResponse result = apiInstance.DebitNoteSaveAttachments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteSaveAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiDebitNoteAttachmentsPost200ApplicationJsonResponse**](ApiDebitNoteAttachmentsPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnotesendmessage"></a>
# **DebitNoteSendMessage**
> ActionResults DebitNoteSendMessage (int? id, BusTransMessageTRequestXml1 body)

DebitNote_SendMessage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteSendMessageExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var body = new BusTransMessageTRequestXml1(); // BusTransMessageTRequestXml1 |  (optional) 

            try
            {
                // DebitNote_SendMessage
                ActionResults result = apiInstance.DebitNoteSendMessage(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteSendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**BusTransMessageTRequestXml1**](BusTransMessageTRequestXml1.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="debitnoteupdatestatus"></a>
# **DebitNoteUpdateStatus**
> ActionResults DebitNoteUpdateStatus (int? id, UpdateTransStatusRequestRequestXml1 body)

DebitNote_UpdateStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DebitNoteUpdateStatusExample
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

            var apiInstance = new DebitNoteApi();
            var id = 56;  // int? | Format - int32.
            var body = new UpdateTransStatusRequestRequestXml1(); // UpdateTransStatusRequestRequestXml1 |  (optional) 

            try
            {
                // DebitNote_UpdateStatus
                ActionResults result = apiInstance.DebitNoteUpdateStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DebitNoteApi.DebitNoteUpdateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**UpdateTransStatusRequestRequestXml1**](UpdateTransStatusRequestRequestXml1.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

