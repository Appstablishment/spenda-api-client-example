# IO.Swagger.Api.PurchaseInvoiceApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PurchaseInvoiceAddInventory**](PurchaseInvoiceApi.md#purchaseinvoiceaddinventory) | **POST** /api/v2/PurchaseInvoice/{id}/inventory | PurchaseInvoice_AddInventory
[**PurchaseInvoiceAddLines**](PurchaseInvoiceApi.md#purchaseinvoiceaddlines) | **POST** /api/PurchaseInvoice/{id}/lines | PurchaseInvoice_AddLines
[**PurchaseInvoiceAddLinesPreview**](PurchaseInvoiceApi.md#purchaseinvoiceaddlinespreview) | **PUT** /api/PurchaseInvoice/{id}/lines | PurchaseInvoice_AddLinesPreview
[**PurchaseInvoiceCreateUsingDeliveryReceiptLines**](PurchaseInvoiceApi.md#purchaseinvoicecreateusingdeliveryreceiptlines) | **POST** /api/PurchaseInvoice/deliveryreceiptlines | PurchaseInvoice_CreateUsingDeliveryReceiptLines
[**PurchaseInvoiceDelete**](PurchaseInvoiceApi.md#purchaseinvoicedelete) | **DELETE** /api/PurchaseInvoice/{id} | PurchaseInvoice_Delete
[**PurchaseInvoiceDeleteAttachment**](PurchaseInvoiceApi.md#purchaseinvoicedeleteattachment) | **DELETE** /api/PurchaseInvoice/attachments | PurchaseInvoice_DeleteAttachment
[**PurchaseInvoiceGet**](PurchaseInvoiceApi.md#purchaseinvoiceget) | **GET** /api/PurchaseInvoice | PurchaseInvoice_Get
[**PurchaseInvoiceGetByID**](PurchaseInvoiceApi.md#purchaseinvoicegetbyid) | **GET** /api/PurchaseInvoice/{id} | PurchaseInvoice_GetByID
[**PurchaseInvoiceGetMessages**](PurchaseInvoiceApi.md#purchaseinvoicegetmessages) | **GET** /api/PurchaseInvoice/{id}/messages | PurchaseInvoice_GetMessages
[**PurchaseInvoiceGetT**](PurchaseInvoiceApi.md#purchaseinvoicegett) | **GET** /api/v2/PurchaseInvoice/{id} | PurchaseInvoice_GetT
[**PurchaseInvoicePartialUpdate**](PurchaseInvoiceApi.md#purchaseinvoicepartialupdate) | **PATCH** /api/PurchaseInvoice/{id} | PurchaseInvoice_PartialUpdate
[**PurchaseInvoicePost**](PurchaseInvoiceApi.md#purchaseinvoicepost) | **POST** /api/PurchaseInvoice | PurchaseInvoice_Post
[**PurchaseInvoicePut**](PurchaseInvoiceApi.md#purchaseinvoiceput) | **PUT** /api/PurchaseInvoice/{id} | PurchaseInvoice_Put
[**PurchaseInvoiceSaveAttachments**](PurchaseInvoiceApi.md#purchaseinvoicesaveattachments) | **POST** /api/PurchaseInvoice/attachments | PurchaseInvoice_SaveAttachments
[**PurchaseInvoiceSendMessage**](PurchaseInvoiceApi.md#purchaseinvoicesendmessage) | **POST** /api/PurchaseInvoice/{id}/messages | PurchaseInvoice_SendMessage
[**PurchaseInvoiceUpdateStatus**](PurchaseInvoiceApi.md#purchaseinvoiceupdatestatus) | **POST** /api/PurchaseInvoice/{id}/status | PurchaseInvoice_UpdateStatus

<a name="purchaseinvoiceaddinventory"></a>
# **PurchaseInvoiceAddInventory**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceAddInventory (int? id, ActionRequestOfSupplierTransAddInventoryRequest body)

PurchaseInvoice_AddInventory

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new ActionRequestOfSupplierTransAddInventoryRequest(); // ActionRequestOfSupplierTransAddInventoryRequest |  (optional) 

            try
            {
                // PurchaseInvoice_AddInventory
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddInventory(id, body);
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
 **id** | **int?**| Format - int32. | 
 **body** | [**ActionRequestOfSupplierTransAddInventoryRequest**](ActionRequestOfSupplierTransAddInventoryRequest.md)|  | [optional] 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceaddlines"></a>
# **PurchaseInvoiceAddLines**
> AddLinesResponseOfPurchaseInvoiceT PurchaseInvoiceAddLines (int? id, AddLinesRequestRequestXml1 body)

PurchaseInvoice_AddLines

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_AddLines
                AddLinesResponseOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddLines(id, body);
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
 **id** | **int?**| Format - int32. | 
 **body** | [**AddLinesRequestRequestXml1**](AddLinesRequestRequestXml1.md)|  | [optional] 

### Return type

[**AddLinesResponseOfPurchaseInvoiceT**](AddLinesResponseOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceaddlinespreview"></a>
# **PurchaseInvoiceAddLinesPreview**
> AddLinesResponseOfPurchaseInvoiceT PurchaseInvoiceAddLinesPreview (int? id, AddLinesRequestRequestXml1 body)

PurchaseInvoice_AddLinesPreview

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_AddLinesPreview
                AddLinesResponseOfPurchaseInvoiceT result = apiInstance.PurchaseInvoiceAddLinesPreview(id, body);
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
 **id** | **int?**| Format - int32. | 
 **body** | [**AddLinesRequestRequestXml1**](AddLinesRequestRequestXml1.md)|  | [optional] 

### Return type

[**AddLinesResponseOfPurchaseInvoiceT**](AddLinesResponseOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicecreateusingdeliveryreceiptlines"></a>
# **PurchaseInvoiceCreateUsingDeliveryReceiptLines**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceCreateUsingDeliveryReceiptLines (ActionRequestOfSupplierTransUsingTransLines body)

PurchaseInvoice_CreateUsingDeliveryReceiptLines

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var body = new ActionRequestOfSupplierTransUsingTransLines(); // ActionRequestOfSupplierTransUsingTransLines |  (optional) 

            try
            {
                // PurchaseInvoice_CreateUsingDeliveryReceiptLines
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
 **body** | [**ActionRequestOfSupplierTransUsingTransLines**](ActionRequestOfSupplierTransUsingTransLines.md)|  | [optional] 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicedelete"></a>
# **PurchaseInvoiceDelete**
> ActionResults PurchaseInvoiceDelete (int? id)

PurchaseInvoice_Delete

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // PurchaseInvoice_Delete
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
 **id** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicedeleteattachment"></a>
# **PurchaseInvoiceDeleteAttachment**
> ActionResults PurchaseInvoiceDeleteAttachment (BusTransAttachmentTRequestXml1 body)

PurchaseInvoice_DeleteAttachment

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var body = new BusTransAttachmentTRequestXml1(); // BusTransAttachmentTRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_DeleteAttachment
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
 **body** | [**BusTransAttachmentTRequestXml1**](BusTransAttachmentTRequestXml1.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceget"></a>
# **PurchaseInvoiceGet**
> PagedActionResultsOfBusTransSearchResultsT PurchaseInvoiceGet (int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

PurchaseInvoice_Get

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
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
                // PurchaseInvoice_Get
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

<a name="purchaseinvoicegetbyid"></a>
# **PurchaseInvoiceGetByID**
> TransactionEditResponseOfPurchaseInvoiceT PurchaseInvoiceGetByID (int? id, string reqLineSort, bool? reqIsLineSortDesc, bool? reqIsGetMessages, int? reqCustomerID, int? reqSupplierID, bool? reqIsPriceRefresh, List reqLineSearchFilterStatuses, List reqLineSearchFilterStatusStrings, List reqLineSearchFilterStatus, string reqLineSearchFilterSearchString, string reqLineSearchFilterSearch, string reqLineSearchFilterStartDate, string reqLineSearchFilterEndDate, string reqLineSearchFilterDatePeriod, bool? reqLineSearchFilterIsExactMatch, bool? reqLineSearchFilterIsGetBasicInfo, bool? reqLineSearchFilterIncludeDeleted, bool? reqLineSearchFilterIncludeLogs, int? reqLineSearchFilterIgnoreID, int? reqLineSearchFilterParentID, bool? reqLineSearchFilterGetCountOnly, int? reqLineSearchFilterTransactionTypeDatTypeID, int? reqLineSearchFilterCategoryID, int? reqLineSearchFilterAdaptorID, List reqLineSearchFilterCategoryIDs, List reqLineSearchFilterBrandIDs, List reqLineSearchFilterIDs, List reqLineSearchFilterGUIDs, int? reqLineSearchFilterLinkedSupplierID, bool? reqLineSearchFilterIsApprovedForPOS, bool? reqLineSearchFilterIsApprovedForWeb, bool? reqLineSearchFilterIsApprovedForService, int? reqLineSearchFilterID, bool? reqLineSearchFilterIsHierarchicalSort, List reqLineSearchFilterTypes, bool? reqLineSearchFilterIsShowFavourites, bool? reqLineSearchFilterIsHidden, bool? reqLineSearchFilterIncludeSystemTasks, bool? reqLineSearchFilterIsSystem, string reqLineSearchFilterSortField, bool? reqLineSearchFilterSortAsc, string reqLineSearchFilterGroupBy, int? reqLineSearchFilterLastRowNumber, int? reqLineSearchFilterMaxResults, int? reqLineSearchFilterTenantID, int? reqLineSearchFilterWebsiteID, int? reqLineSearchFilterUserID, bool? reqIsExcludeFailedPayments, int? reqID, string reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)

PurchaseInvoice_GetByID

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
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
                // PurchaseInvoice_GetByID
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

[**TransactionEditResponseOfPurchaseInvoiceT**](TransactionEditResponseOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicegetmessages"></a>
# **PurchaseInvoiceGetMessages**
> ActionResultsOfBusTransMessages PurchaseInvoiceGetMessages (int? id)

PurchaseInvoice_GetMessages

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // PurchaseInvoice_GetMessages
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
 **id** | **int?**| Format - int32. | 

### Return type

[**ActionResultsOfBusTransMessages**](ActionResultsOfBusTransMessages.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicegett"></a>
# **PurchaseInvoiceGetT**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoiceGetT (int? id)

PurchaseInvoice_GetT

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // PurchaseInvoice_GetT
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
 **id** | **int?**| Format - int32. | 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicepartialupdate"></a>
# **PurchaseInvoicePartialUpdate**
> ActionResultsOfPurchaseInvoiceT PurchaseInvoicePartialUpdate (int? id, ActionRequestOfPurchaseInvoiceT body)

PurchaseInvoice_PartialUpdate

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new ActionRequestOfPurchaseInvoiceT(); // ActionRequestOfPurchaseInvoiceT |  (optional) 

            try
            {
                // PurchaseInvoice_PartialUpdate
                ActionResultsOfPurchaseInvoiceT result = apiInstance.PurchaseInvoicePartialUpdate(id, body);
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
 **id** | **int?**| Format - int32. | 
 **body** | [**ActionRequestOfPurchaseInvoiceT**](ActionRequestOfPurchaseInvoiceT.md)|  | [optional] 

### Return type

[**ActionResultsOfPurchaseInvoiceT**](ActionResultsOfPurchaseInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicepost"></a>
# **PurchaseInvoicePost**
> SynkSaveQueueResponse PurchaseInvoicePost (TransactionSaveRequestOfPurchaseInvoiceTRequestXml1 body)

PurchaseInvoice_Post

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var body = new TransactionSaveRequestOfPurchaseInvoiceTRequestXml1(); // TransactionSaveRequestOfPurchaseInvoiceTRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_Post
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
 **body** | [**TransactionSaveRequestOfPurchaseInvoiceTRequestXml1**](TransactionSaveRequestOfPurchaseInvoiceTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoiceput"></a>
# **PurchaseInvoicePut**
> SynkSaveQueueResponse PurchaseInvoicePut (int? id, TransactionSaveRequestOfPurchaseInvoiceTRequestXml1 body)

PurchaseInvoice_Put

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new TransactionSaveRequestOfPurchaseInvoiceTRequestXml1(); // TransactionSaveRequestOfPurchaseInvoiceTRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_Put
                SynkSaveQueueResponse result = apiInstance.PurchaseInvoicePut(id, body);
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
 **id** | **int?**| Format - int32. | 
 **body** | [**TransactionSaveRequestOfPurchaseInvoiceTRequestXml1**](TransactionSaveRequestOfPurchaseInvoiceTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicesaveattachments"></a>
# **PurchaseInvoiceSaveAttachments**
> ApiPurchaseInvoiceAttachmentsPost200ApplicationJsonResponse PurchaseInvoiceSaveAttachments ()

PurchaseInvoice_SaveAttachments

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();

            try
            {
                // PurchaseInvoice_SaveAttachments
                ApiPurchaseInvoiceAttachmentsPost200ApplicationJsonResponse result = apiInstance.PurchaseInvoiceSaveAttachments();
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

[**ApiPurchaseInvoiceAttachmentsPost200ApplicationJsonResponse**](ApiPurchaseInvoiceAttachmentsPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseinvoicesendmessage"></a>
# **PurchaseInvoiceSendMessage**
> ActionResults PurchaseInvoiceSendMessage (int? id, BusTransMessageTRequestXml1 body)

PurchaseInvoice_SendMessage

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new BusTransMessageTRequestXml1(); // BusTransMessageTRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_SendMessage
                ActionResults result = apiInstance.PurchaseInvoiceSendMessage(id, body);
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

<a name="purchaseinvoiceupdatestatus"></a>
# **PurchaseInvoiceUpdateStatus**
> ActionResults PurchaseInvoiceUpdateStatus (int? id, UpdateTransStatusRequestRequestXml1 body)

PurchaseInvoice_UpdateStatus

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

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new PurchaseInvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new UpdateTransStatusRequestRequestXml1(); // UpdateTransStatusRequestRequestXml1 |  (optional) 

            try
            {
                // PurchaseInvoice_UpdateStatus
                ActionResults result = apiInstance.PurchaseInvoiceUpdateStatus(id, body);
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

