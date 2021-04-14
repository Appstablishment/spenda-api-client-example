# SDK.SpendaApi.Client.Api.InvoiceApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoiceAddLines**](InvoiceApi.md#invoiceaddlines) | **POST** /api/Invoice/{id}/lines | 
[**InvoiceAddLinesPreview**](InvoiceApi.md#invoiceaddlinespreview) | **PUT** /api/Invoice/{id}/lines | 
[**InvoiceDelete**](InvoiceApi.md#invoicedelete) | **DELETE** /api/Invoice/{id} | 
[**InvoiceDeleteAttachment**](InvoiceApi.md#invoicedeleteattachment) | **DELETE** /api/Invoice/attachments | 
[**InvoiceGet**](InvoiceApi.md#invoiceget) | **GET** /api/Invoice | 
[**InvoiceGetByID**](InvoiceApi.md#invoicegetbyid) | **GET** /api/Invoice/{id} | 
[**InvoiceGetMessages**](InvoiceApi.md#invoicegetmessages) | **GET** /api/Invoice/{id}/messages | 
[**InvoicePost**](InvoiceApi.md#invoicepost) | **POST** /api/Invoice | 
[**InvoicePut**](InvoiceApi.md#invoiceput) | **PUT** /api/Invoice/{id} | 
[**InvoiceSaveAttachments**](InvoiceApi.md#invoicesaveattachments) | **POST** /api/Invoice/attachments | 
[**InvoiceSendMessage**](InvoiceApi.md#invoicesendmessage) | **POST** /api/Invoice/{id}/messages | 
[**InvoiceUpdateStatus**](InvoiceApi.md#invoiceupdatestatus) | **POST** /api/Invoice/{id}/status | 

<a name="invoiceaddlines"></a>
# **InvoiceAddLines**
> AddLinesResponseOfInvoiceT InvoiceAddLines (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceAddLinesExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfInvoiceT result = apiInstance.InvoiceAddLines(body, id);
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
 **body** | [**AddLinesRequest**](AddLinesRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**AddLinesResponseOfInvoiceT**](AddLinesResponseOfInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoiceaddlinespreview"></a>
# **InvoiceAddLinesPreview**
> AddLinesResponseOfInvoiceT InvoiceAddLinesPreview (AddLinesRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceAddLinesPreviewExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new AddLinesRequest(); // AddLinesRequest | 
            var id = 56;  // int? | 

            try
            {
                AddLinesResponseOfInvoiceT result = apiInstance.InvoiceAddLinesPreview(body, id);
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
 **body** | [**AddLinesRequest**](AddLinesRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**AddLinesResponseOfInvoiceT**](AddLinesResponseOfInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicedelete"></a>
# **InvoiceDelete**
> ActionResults InvoiceDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceDeleteExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicedeleteattachment"></a>
# **InvoiceDeleteAttachment**
> ActionResults InvoiceDeleteAttachment (BusTransAttachmentT body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceDeleteAttachmentExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new BusTransAttachmentT(); // BusTransAttachmentT | 

            try
            {
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
 **body** | [**BusTransAttachmentT**](BusTransAttachmentT.md)|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoiceget"></a>
# **InvoiceGet**
> PagedActionResultsOfBusTransSearchResultsT InvoiceGet (int? filterCustomerID, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, string filterSortField)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceGetExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterStatusStrings = new List<string>(); // List<string> |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 

            try
            {
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
 **filterCustomerID** | **int?**|  | [optional] 
 **filterStatusStrings** | [**List<string>**](string.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterStartDate** | **DateTime?**|  | [optional] 
 **filterEndDate** | **DateTime?**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 

### Return type

[**PagedActionResultsOfBusTransSearchResultsT**](PagedActionResultsOfBusTransSearchResultsT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicegetbyid"></a>
# **InvoiceGetByID**
> TransactionEditResponseOfInvoiceT InvoiceGetByID (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceGetByIDExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**TransactionEditResponseOfInvoiceT**](TransactionEditResponseOfInvoiceT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicegetmessages"></a>
# **InvoiceGetMessages**
> ActionResultsOfBusTransMessages InvoiceGetMessages (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceGetMessagesExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfBusTransMessages**](ActionResultsOfBusTransMessages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicepost"></a>
# **InvoicePost**
> SynkSaveQueueResponse InvoicePost (TransactionSaveRequestOfInvoiceT body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoicePostExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new TransactionSaveRequestOfInvoiceT(); // TransactionSaveRequestOfInvoiceT | 

            try
            {
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
 **body** | [**TransactionSaveRequestOfInvoiceT**](TransactionSaveRequestOfInvoiceT.md)|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoiceput"></a>
# **InvoicePut**
> SynkSaveQueueResponse InvoicePut (TransactionSaveRequestOfInvoiceT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoicePutExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new TransactionSaveRequestOfInvoiceT(); // TransactionSaveRequestOfInvoiceT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.InvoicePut(body, id);
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
 **body** | [**TransactionSaveRequestOfInvoiceT**](TransactionSaveRequestOfInvoiceT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicesaveattachments"></a>
# **InvoiceSaveAttachments**
> List<FileDetails> InvoiceSaveAttachments ()



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceSaveAttachmentsExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();

            try
            {
                List&lt;FileDetails&gt; result = apiInstance.InvoiceSaveAttachments();
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

[**List<FileDetails>**](FileDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoicesendmessage"></a>
# **InvoiceSendMessage**
> ActionResults InvoiceSendMessage (BusTransMessageT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceSendMessageExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new BusTransMessageT(); // BusTransMessageT | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.InvoiceSendMessage(body, id);
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
 **body** | [**BusTransMessageT**](BusTransMessageT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="invoiceupdatestatus"></a>
# **InvoiceUpdateStatus**
> ActionResults InvoiceUpdateStatus (UpdateTransStatusRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InvoiceUpdateStatusExample
    {
        public void main()
        {

            var apiInstance = new InvoiceApi();
            var body = new UpdateTransStatusRequest(); // UpdateTransStatusRequest | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.InvoiceUpdateStatus(body, id);
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
 **body** | [**UpdateTransStatusRequest**](UpdateTransStatusRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

