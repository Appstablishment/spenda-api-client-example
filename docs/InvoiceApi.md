# IO.Swagger.Api.InvoiceApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoiceAddLines**](InvoiceApi.md#invoiceaddlines) | **POST** /api/Invoice/{id}/lines | Invoice_AddLines
[**InvoiceAddLinesPreview**](InvoiceApi.md#invoiceaddlinespreview) | **PUT** /api/Invoice/{id}/lines | Invoice_AddLinesPreview
[**InvoiceDelete**](InvoiceApi.md#invoicedelete) | **DELETE** /api/Invoice/{id} | Invoice_Delete
[**InvoiceDeleteAttachment**](InvoiceApi.md#invoicedeleteattachment) | **DELETE** /api/Invoice/attachments | Invoice_DeleteAttachment
[**InvoiceGet**](InvoiceApi.md#invoiceget) | **GET** /api/Invoice | Invoice_Get
[**InvoiceGetByID**](InvoiceApi.md#invoicegetbyid) | **GET** /api/Invoice/{id} | Invoice_GetByID
[**InvoiceGetMessages**](InvoiceApi.md#invoicegetmessages) | **GET** /api/Invoice/{id}/messages | Invoice_GetMessages
[**InvoicePost**](InvoiceApi.md#invoicepost) | **POST** /api/Invoice | Invoice_Post
[**InvoicePut**](InvoiceApi.md#invoiceput) | **PUT** /api/Invoice/{id} | Invoice_Put
[**InvoiceSaveAttachments**](InvoiceApi.md#invoicesaveattachments) | **POST** /api/Invoice/attachments | Invoice_SaveAttachments
[**InvoiceSendMessage**](InvoiceApi.md#invoicesendmessage) | **POST** /api/Invoice/{id}/messages | Invoice_SendMessage
[**InvoiceUpdateStatus**](InvoiceApi.md#invoiceupdatestatus) | **POST** /api/Invoice/{id}/status | Invoice_UpdateStatus

<a name="invoiceaddlines"></a>
# **InvoiceAddLines**
> AddLinesResponseOfInvoiceT InvoiceAddLines (int? id, AddLinesRequestRequestXml1 body)

Invoice_AddLines

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceAddLinesExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // Invoice_AddLines
                AddLinesResponseOfInvoiceT result = apiInstance.InvoiceAddLines(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceAddLines: " + e.Message );
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

[**AddLinesResponseOfInvoiceT**](AddLinesResponseOfInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoiceaddlinespreview"></a>
# **InvoiceAddLinesPreview**
> AddLinesResponseOfInvoiceT InvoiceAddLinesPreview (int? id, AddLinesRequestRequestXml1 body)

Invoice_AddLinesPreview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceAddLinesPreviewExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new AddLinesRequestRequestXml1(); // AddLinesRequestRequestXml1 |  (optional) 

            try
            {
                // Invoice_AddLinesPreview
                AddLinesResponseOfInvoiceT result = apiInstance.InvoiceAddLinesPreview(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceAddLinesPreview: " + e.Message );
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

[**AddLinesResponseOfInvoiceT**](AddLinesResponseOfInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicedelete"></a>
# **InvoiceDelete**
> ActionResults InvoiceDelete (int? id)

Invoice_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceDeleteExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Invoice_Delete
                ActionResults result = apiInstance.InvoiceDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceDelete: " + e.Message );
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

<a name="invoicedeleteattachment"></a>
# **InvoiceDeleteAttachment**
> ActionResults InvoiceDeleteAttachment (BusTransAttachmentTRequestXml1 body)

Invoice_DeleteAttachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceDeleteAttachmentExample
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

            var apiInstance = new InvoiceApi();
            var body = new BusTransAttachmentTRequestXml1(); // BusTransAttachmentTRequestXml1 |  (optional) 

            try
            {
                // Invoice_DeleteAttachment
                ActionResults result = apiInstance.InvoiceDeleteAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceDeleteAttachment: " + e.Message );
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

<a name="invoiceget"></a>
# **InvoiceGet**
> PagedActionResultsOfBusTransSearchResultsT InvoiceGet (int? filterCustomerID, List filterStatusStrings, string filterSearchString, string filterStartDate, string filterEndDate, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, string filterSortField)

Invoice_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceGetExample
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

            var apiInstance = new InvoiceApi();
            var filterCustomerID = 56;  // int? | Format - int32. (optional) 
            var filterStatusStrings = new List(); // List |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterStartDate = filterStartDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterEndDate = filterEndDate_example;  // string | Format - date-time (as date-time in RFC3339). (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 

            try
            {
                // Invoice_Get
                PagedActionResultsOfBusTransSearchResultsT result = apiInstance.InvoiceGet(filterCustomerID, filterStatusStrings, filterSearchString, filterStartDate, filterEndDate, filterIsExactMatch, filterIncludeDeleted, filterIsApprovedForPOS, filterSortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCustomerID** | **int?**| Format - int32. | [optional] 
 **filterStatusStrings** | [**List**](.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterStartDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterEndDate** | **string**| Format - date-time (as date-time in RFC3339). | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 

### Return type

[**PagedActionResultsOfBusTransSearchResultsT**](PagedActionResultsOfBusTransSearchResultsT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetbyid"></a>
# **InvoiceGetByID**
> TransactionEditResponseOfInvoiceT InvoiceGetByID (int? id)

Invoice_GetByID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceGetByIDExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Invoice_GetByID
                TransactionEditResponseOfInvoiceT result = apiInstance.InvoiceGetByID(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetByID: " + e.Message );
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

[**TransactionEditResponseOfInvoiceT**](TransactionEditResponseOfInvoiceT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicegetmessages"></a>
# **InvoiceGetMessages**
> ActionResultsOfBusTransMessages InvoiceGetMessages (int? id)

Invoice_GetMessages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceGetMessagesExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Invoice_GetMessages
                ActionResultsOfBusTransMessages result = apiInstance.InvoiceGetMessages(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceGetMessages: " + e.Message );
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

<a name="invoicepost"></a>
# **InvoicePost**
> SynkSaveQueueResponse InvoicePost (TransactionSaveRequestOfInvoiceTRequestXml1 body)

Invoice_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePostExample
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

            var apiInstance = new InvoiceApi();
            var body = new TransactionSaveRequestOfInvoiceTRequestXml1(); // TransactionSaveRequestOfInvoiceTRequestXml1 |  (optional) 

            try
            {
                // Invoice_Post
                SynkSaveQueueResponse result = apiInstance.InvoicePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionSaveRequestOfInvoiceTRequestXml1**](TransactionSaveRequestOfInvoiceTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoiceput"></a>
# **InvoicePut**
> SynkSaveQueueResponse InvoicePut (int? id, TransactionSaveRequestOfInvoiceTRequestXml1 body)

Invoice_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePutExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new TransactionSaveRequestOfInvoiceTRequestXml1(); // TransactionSaveRequestOfInvoiceTRequestXml1 |  (optional) 

            try
            {
                // Invoice_Put
                SynkSaveQueueResponse result = apiInstance.InvoicePut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**TransactionSaveRequestOfInvoiceTRequestXml1**](TransactionSaveRequestOfInvoiceTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesaveattachments"></a>
# **InvoiceSaveAttachments**
> ApiInvoiceAttachmentsPost200ApplicationJsonResponse InvoiceSaveAttachments ()

Invoice_SaveAttachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceSaveAttachmentsExample
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

            var apiInstance = new InvoiceApi();

            try
            {
                // Invoice_SaveAttachments
                ApiInvoiceAttachmentsPost200ApplicationJsonResponse result = apiInstance.InvoiceSaveAttachments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceSaveAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiInvoiceAttachmentsPost200ApplicationJsonResponse**](ApiInvoiceAttachmentsPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesendmessage"></a>
# **InvoiceSendMessage**
> ActionResults InvoiceSendMessage (int? id, BusTransMessageTRequestXml1 body)

Invoice_SendMessage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceSendMessageExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new BusTransMessageTRequestXml1(); // BusTransMessageTRequestXml1 |  (optional) 

            try
            {
                // Invoice_SendMessage
                ActionResults result = apiInstance.InvoiceSendMessage(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceSendMessage: " + e.Message );
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

<a name="invoiceupdatestatus"></a>
# **InvoiceUpdateStatus**
> ActionResults InvoiceUpdateStatus (int? id, UpdateTransStatusRequestRequestXml1 body)

Invoice_UpdateStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceUpdateStatusExample
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

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | Format - int32.
            var body = new UpdateTransStatusRequestRequestXml1(); // UpdateTransStatusRequestRequestXml1 |  (optional) 

            try
            {
                // Invoice_UpdateStatus
                ActionResults result = apiInstance.InvoiceUpdateStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoiceUpdateStatus: " + e.Message );
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

