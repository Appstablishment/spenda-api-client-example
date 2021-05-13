# IO.Swagger.Api.SalesOrdersApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SalesOrdersAddLines**](SalesOrdersApi.md#salesordersaddlines) | **POST** /api/SalesOrders/{id}/lines | SalesOrders_AddLines
[**SalesOrdersAddLinesPreview**](SalesOrdersApi.md#salesordersaddlinespreview) | **PUT** /api/SalesOrders/{id}/lines | SalesOrders_AddLinesPreview
[**SalesOrdersAddOrIgnoreInboxItem**](SalesOrdersApi.md#salesordersaddorignoreinboxitem) | **POST** /api/SalesOrders/AddOrIgnoreInboxItem | SalesOrders_AddOrIgnoreInboxItem
[**SalesOrdersChargeToAccount**](SalesOrdersApi.md#salesorderschargetoaccount) | **POST** /api/SalesOrders/{id}/chargetoaccount | SalesOrders_ChargeToAccount
[**SalesOrdersCreateInvoices**](SalesOrdersApi.md#salesorderscreateinvoices) | **POST** /api/SalesOrders/invoices | SalesOrders_CreateInvoices
[**SalesOrdersCreatePurchaseOrders**](SalesOrdersApi.md#salesorderscreatepurchaseorders) | **POST** /api/SalesOrders/purchaseorders | SalesOrders_CreatePurchaseOrders
[**SalesOrdersDelete**](SalesOrdersApi.md#salesordersdelete) | **DELETE** /api/SalesOrders/{id} | SalesOrders_Delete
[**SalesOrdersDeleteAttachment**](SalesOrdersApi.md#salesordersdeleteattachment) | **DELETE** /api/SalesOrders/attachments | SalesOrders_DeleteAttachment
[**SalesOrdersGet**](SalesOrdersApi.md#salesordersget) | **GET** /api/SalesOrders | SalesOrders_Get
[**SalesOrdersGetByID**](SalesOrdersApi.md#salesordersgetbyid) | **GET** /api/SalesOrders/{id} | SalesOrders_GetByID
[**SalesOrdersGetMessages**](SalesOrdersApi.md#salesordersgetmessages) | **GET** /api/SalesOrders/{id}/messages | SalesOrders_GetMessages
[**SalesOrdersPost**](SalesOrdersApi.md#salesorderspost) | **POST** /api/SalesOrders | SalesOrders_Post
[**SalesOrdersPut**](SalesOrdersApi.md#salesordersput) | **PUT** /api/SalesOrders/{id} | SalesOrders_Put
[**SalesOrdersSaveAttachments**](SalesOrdersApi.md#salesorderssaveattachments) | **POST** /api/SalesOrders/attachments | SalesOrders_SaveAttachments
[**SalesOrdersSearchTransInInbox**](SalesOrdersApi.md#salesorderssearchtransininbox) | **GET** /api/SalesOrders/SearchTransInInbox | SalesOrders_SearchTransInInbox
[**SalesOrdersSendMessage**](SalesOrdersApi.md#salesorderssendmessage) | **POST** /api/SalesOrders/{id}/messages | SalesOrders_SendMessage
[**SalesOrdersUpdateStatus**](SalesOrdersApi.md#salesordersupdatestatus) | **POST** /api/SalesOrders/{id}/status | SalesOrders_UpdateStatus

<a name="salesordersaddlines"></a>
# **SalesOrdersAddLines**
> AddLinesResponseOfSalesOrderT SalesOrdersAddLines (int? id, AddLinesRequestRequestXml1 body)

SalesOrders_AddLines

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersAddLinesExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_AddLines
                AddLinesResponseOfSalesOrderT result = apiInstance.SalesOrdersAddLines(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersAddLines: " + e.Message );
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

[**AddLinesResponseOfSalesOrderT**](AddLinesResponseOfSalesOrderT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersaddlinespreview"></a>
# **SalesOrdersAddLinesPreview**
> AddLinesResponseOfSalesOrderT SalesOrdersAddLinesPreview (int? id, AddLinesRequestRequestXml1 body)

SalesOrders_AddLinesPreview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersAddLinesPreviewExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_AddLinesPreview
                AddLinesResponseOfSalesOrderT result = apiInstance.SalesOrdersAddLinesPreview(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersAddLinesPreview: " + e.Message );
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

[**AddLinesResponseOfSalesOrderT**](AddLinesResponseOfSalesOrderT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersaddorignoreinboxitem"></a>
# **SalesOrdersAddOrIgnoreInboxItem**
> ActionResults SalesOrdersAddOrIgnoreInboxItem (AddOrIgnoreTransInboxItemRequest body)

SalesOrders_AddOrIgnoreInboxItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersAddOrIgnoreInboxItemExample
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

            var apiInstance = new SalesOrdersApi();
            var body = new AddOrIgnoreTransInboxItemRequest(); // AddOrIgnoreTransInboxItemRequest |  (optional) 

            try
            {
                // SalesOrders_AddOrIgnoreInboxItem
                ActionResults result = apiInstance.SalesOrdersAddOrIgnoreInboxItem(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersAddOrIgnoreInboxItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddOrIgnoreTransInboxItemRequest**](AddOrIgnoreTransInboxItemRequest.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesorderschargetoaccount"></a>
# **SalesOrdersChargeToAccount**
> ActionResults SalesOrdersChargeToAccount (int? id)

SalesOrders_ChargeToAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersChargeToAccountExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // SalesOrders_ChargeToAccount
                ActionResults result = apiInstance.SalesOrdersChargeToAccount(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersChargeToAccount: " + e.Message );
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

<a name="salesorderscreateinvoices"></a>
# **SalesOrdersCreateInvoices**
> ActionResults SalesOrdersCreateInvoices (InvoicingRequest body)

SalesOrders_CreateInvoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersCreateInvoicesExample
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

            var apiInstance = new SalesOrdersApi();
            var body = new InvoicingRequest(); // InvoicingRequest |  (optional) 

            try
            {
                // SalesOrders_CreateInvoices
                ActionResults result = apiInstance.SalesOrdersCreateInvoices(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersCreateInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvoicingRequest**](InvoicingRequest.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesorderscreatepurchaseorders"></a>
# **SalesOrdersCreatePurchaseOrders**
> ActionResults SalesOrdersCreatePurchaseOrders (PurchaseOrderRequest body)

SalesOrders_CreatePurchaseOrders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersCreatePurchaseOrdersExample
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

            var apiInstance = new SalesOrdersApi();
            var body = new PurchaseOrderRequest(); // PurchaseOrderRequest |  (optional) 

            try
            {
                // SalesOrders_CreatePurchaseOrders
                ActionResults result = apiInstance.SalesOrdersCreatePurchaseOrders(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersCreatePurchaseOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderRequest**](PurchaseOrderRequest.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersdelete"></a>
# **SalesOrdersDelete**
> ActionResults SalesOrdersDelete (int? id)

SalesOrders_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersDeleteExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // SalesOrders_Delete
                ActionResults result = apiInstance.SalesOrdersDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersDelete: " + e.Message );
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

<a name="salesordersdeleteattachment"></a>
# **SalesOrdersDeleteAttachment**
> ActionResults SalesOrdersDeleteAttachment (BusTransAttachmentTRequestXml1 body)

SalesOrders_DeleteAttachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersDeleteAttachmentExample
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

            var apiInstance = new SalesOrdersApi();
            var body = new BusTransAttachmentTRequestXml1(); // BusTransAttachmentTRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_DeleteAttachment
                ActionResults result = apiInstance.SalesOrdersDeleteAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersDeleteAttachment: " + e.Message );
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

<a name="salesordersget"></a>
# **SalesOrdersGet**
> PagedActionResultsOfBusTransSearchResultsT SalesOrdersGet (int? filterSupplierID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List filterStatusStrings, string filterSearchString, string filterStartDate, string filterEndDate, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, string filterSortField, int? filterMaxResults, int? filterTenantID)

SalesOrders_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersGetExample
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

            var apiInstance = new SalesOrdersApi();
            var filterSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterIsCreatedByOtherPartyOnly = true;  // bool? |  (optional) 
            var filterCreatedByUserId = 56;  // int? | Format - int32. (optional) 
            var filterStatusStrings = new List(); // List |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterStartDate = filterStartDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterEndDate = filterEndDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterMaxResults = 56;  // int? | Format - int32. (optional) 
            var filterTenantID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // SalesOrders_Get
                PagedActionResultsOfBusTransSearchResultsT result = apiInstance.SalesOrdersGet(filterSupplierID, filterIsCreatedByOtherPartyOnly, filterCreatedByUserId, filterStatusStrings, filterSearchString, filterStartDate, filterEndDate, filterIsExactMatch, filterIncludeDeleted, filterIsApprovedForPOS, filterSortField, filterMaxResults, filterTenantID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSupplierID** | **int?**| Format - int32. | [optional] 
 **filterIsCreatedByOtherPartyOnly** | **bool?**|  | [optional] 
 **filterCreatedByUserId** | **int?**| Format - int32. | [optional] 
 **filterStatusStrings** | [**List**](.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterStartDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterEndDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterMaxResults** | **int?**| Format - int32. | [optional] 
 **filterTenantID** | **int?**| Format - int32. | [optional] 

### Return type

[**PagedActionResultsOfBusTransSearchResultsT**](PagedActionResultsOfBusTransSearchResultsT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersgetbyid"></a>
# **SalesOrdersGetByID**
> TransactionEditResponseOfSalesOrderT SalesOrdersGetByID (int? id, int? reqCustomerID)

SalesOrders_GetByID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersGetByIDExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var reqCustomerID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // SalesOrders_GetByID
                TransactionEditResponseOfSalesOrderT result = apiInstance.SalesOrdersGetByID(id, reqCustomerID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGetByID: " + e.Message );
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

### Return type

[**TransactionEditResponseOfSalesOrderT**](TransactionEditResponseOfSalesOrderT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersgetmessages"></a>
# **SalesOrdersGetMessages**
> ActionResultsOfBusTransMessages SalesOrdersGetMessages (int? id)

SalesOrders_GetMessages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersGetMessagesExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // SalesOrders_GetMessages
                ActionResultsOfBusTransMessages result = apiInstance.SalesOrdersGetMessages(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGetMessages: " + e.Message );
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

<a name="salesorderspost"></a>
# **SalesOrdersPost**
> SynkSaveQueueResponse SalesOrdersPost (TransactionSaveRequestOfSalesOrderTRequestXml1 body)

SalesOrders_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersPostExample
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

            var apiInstance = new SalesOrdersApi();
            var body = new TransactionSaveRequestOfSalesOrderTRequestXml1(); // TransactionSaveRequestOfSalesOrderTRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_Post
                SynkSaveQueueResponse result = apiInstance.SalesOrdersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfSalesOrderTRequestXml1**](TransactionSaveRequestOfSalesOrderTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesordersput"></a>
# **SalesOrdersPut**
> SynkSaveQueueResponse SalesOrdersPut (int? id, TransactionSaveRequestOfSalesOrderTRequestXml1 body)

SalesOrders_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersPutExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var body = new TransactionSaveRequestOfSalesOrderTRequestXml1(); // TransactionSaveRequestOfSalesOrderTRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_Put
                SynkSaveQueueResponse result = apiInstance.SalesOrdersPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**TransactionSaveRequestOfSalesOrderTRequestXml1**](TransactionSaveRequestOfSalesOrderTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesorderssaveattachments"></a>
# **SalesOrdersSaveAttachments**
> ApiSalesOrdersAttachmentsPost200ApplicationJsonResponse SalesOrdersSaveAttachments ()

SalesOrders_SaveAttachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersSaveAttachmentsExample
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

            var apiInstance = new SalesOrdersApi();

            try
            {
                // SalesOrders_SaveAttachments
                ApiSalesOrdersAttachmentsPost200ApplicationJsonResponse result = apiInstance.SalesOrdersSaveAttachments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersSaveAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiSalesOrdersAttachmentsPost200ApplicationJsonResponse**](ApiSalesOrdersAttachmentsPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesorderssearchtransininbox"></a>
# **SalesOrdersSearchTransInInbox**
> PagedActionResultsOfListOfBusTransT SalesOrdersSearchTransInInbox (int? filterDatTypeID, List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

SalesOrders_SearchTransInInbox

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersSearchTransInInboxExample
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

            var apiInstance = new SalesOrdersApi();
            var filterDatTypeID = 56;  // int? | Format - int32. (optional) 
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
                // SalesOrders_SearchTransInInbox
                PagedActionResultsOfListOfBusTransT result = apiInstance.SalesOrdersSearchTransInInbox(filterDatTypeID, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersSearchTransInInbox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterDatTypeID** | **int?**| Format - int32. | [optional] 
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

[**PagedActionResultsOfListOfBusTransT**](PagedActionResultsOfListOfBusTransT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="salesorderssendmessage"></a>
# **SalesOrdersSendMessage**
> ActionResults SalesOrdersSendMessage (int? id, BusTransMessageTRequestXml1 body)

SalesOrders_SendMessage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersSendMessageExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var body = new BusTransMessageTRequestXml1(); // BusTransMessageTRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_SendMessage
                ActionResults result = apiInstance.SalesOrdersSendMessage(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersSendMessage: " + e.Message );
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

<a name="salesordersupdatestatus"></a>
# **SalesOrdersUpdateStatus**
> ActionResults SalesOrdersUpdateStatus (int? id, UpdateTransStatusRequestRequestXml1 body)

SalesOrders_UpdateStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SalesOrdersUpdateStatusExample
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

            var apiInstance = new SalesOrdersApi();
            var id = 56;  // int? | Format - int32.
            var body = new UpdateTransStatusRequestRequestXml1(); // UpdateTransStatusRequestRequestXml1 |  (optional) 

            try
            {
                // SalesOrders_UpdateStatus
                ActionResults result = apiInstance.SalesOrdersUpdateStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersUpdateStatus: " + e.Message );
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

