# SDK.SpendaApi.Client.Api.PaymentApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentDelete**](PaymentApi.md#paymentdelete) | **DELETE** /api/Payment/{id} | 
[**PaymentGet**](PaymentApi.md#paymentget) | **GET** /api/Payment | 
[**PaymentGetByID**](PaymentApi.md#paymentgetbyid) | **GET** /api/Payment/{id} | 
[**PaymentGetPaymentWithAllocations**](PaymentApi.md#paymentgetpaymentwithallocations) | **GET** /api/Payment/{id}/allocations | 
[**PaymentGetStatus**](PaymentApi.md#paymentgetstatus) | **GET** /api/Payment/{id}/status | 
[**PaymentGetV2**](PaymentApi.md#paymentgetv2) | **GET** /api/v2/Payment | 
[**PaymentPost**](PaymentApi.md#paymentpost) | **POST** /api/Payment | 
[**PaymentPostRefund**](PaymentApi.md#paymentpostrefund) | **POST** /api/Payment/{id}/refund | 
[**PaymentPut**](PaymentApi.md#paymentput) | **PUT** /api/Payment/{id} | 
[**PaymentSetManualAllocationForAdhocPayments**](PaymentApi.md#paymentsetmanualallocationforadhocpayments) | **POST** /api/Payment/{id}/setmanualallocation | 
[**PaymentUpdateStatus**](PaymentApi.md#paymentupdatestatus) | **POST** /api/Payment/{id}/status | 

<a name="paymentdelete"></a>
# **PaymentDelete**
> ActionResults PaymentDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentDeleteExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PaymentDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentDelete: " + e.Message );
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

<a name="paymentget"></a>
# **PaymentGet**
> PagedActionResultsOfPayments PaymentGet (List<int?> filterStatuses, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentGetExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var filterStatuses = new List<int?>(); // List<int?> |  (optional) 
            var filterStatusStrings = new List<string>(); // List<string> |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
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

            try
            {
                PagedActionResultsOfPayments result = apiInstance.PaymentGet(filterStatuses, filterStatusStrings, filterSearchString, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStatuses** | [**List<int?>**](int?.md)|  | [optional] 
 **filterStatusStrings** | [**List<string>**](string.md)|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
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

### Return type

[**PagedActionResultsOfPayments**](PagedActionResultsOfPayments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentgetbyid"></a>
# **PaymentGetByID**
> EditResponseOfPaymentT PaymentGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentGetByIDExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var id = 56;  // int? | 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
                EditResponseOfPaymentT result = apiInstance.PaymentGetByID(id, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentGetByID: " + e.Message );
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

[**EditResponseOfPaymentT**](EditResponseOfPaymentT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentgetpaymentwithallocations"></a>
# **PaymentGetPaymentWithAllocations**
> ActionResults PaymentGetPaymentWithAllocations (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentGetPaymentWithAllocationsExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PaymentGetPaymentWithAllocations(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentGetPaymentWithAllocations: " + e.Message );
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

<a name="paymentgetstatus"></a>
# **PaymentGetStatus**
> ActionResultsOfPaymentT PaymentGetStatus (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentGetStatusExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfPaymentT result = apiInstance.PaymentGetStatus(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentGetStatus: " + e.Message );
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

[**ActionResultsOfPaymentT**](ActionResultsOfPaymentT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentgetv2"></a>
# **PaymentGetV2**
> PagedActionResultsOfPayments PaymentGetV2 (string filterReceiptID, int? filterPOSTerminalID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentGetV2Example
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var filterReceiptID = filterReceiptID_example;  // string | 
            var filterPOSTerminalID = 56;  // int? |  (optional) 

            try
            {
                PagedActionResultsOfPayments result = apiInstance.PaymentGetV2(filterReceiptID, filterPOSTerminalID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentGetV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterReceiptID** | **string**|  | 
 **filterPOSTerminalID** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfPayments**](PagedActionResultsOfPayments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentpost"></a>
# **PaymentPost**
> SynkSaveQueueResponseOfPaymentT PaymentPost (SaveRequestOfPaymentT body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentPostExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var body = new SaveRequestOfPaymentT(); // SaveRequestOfPaymentT | 

            try
            {
                SynkSaveQueueResponseOfPaymentT result = apiInstance.PaymentPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfPaymentT**](SaveRequestOfPaymentT.md)|  | 

### Return type

[**SynkSaveQueueResponseOfPaymentT**](SynkSaveQueueResponseOfPaymentT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentpostrefund"></a>
# **PaymentPostRefund**
> SynkSaveQueueResponseOfPaymentT PaymentPostRefund (SaveRequestOfPaymentT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentPostRefundExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var body = new SaveRequestOfPaymentT(); // SaveRequestOfPaymentT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponseOfPaymentT result = apiInstance.PaymentPostRefund(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentPostRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfPaymentT**](SaveRequestOfPaymentT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponseOfPaymentT**](SynkSaveQueueResponseOfPaymentT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentput"></a>
# **PaymentPut**
> SynkSaveQueueResponseOfPaymentT PaymentPut (SaveRequestOfPaymentT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentPutExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var body = new SaveRequestOfPaymentT(); // SaveRequestOfPaymentT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponseOfPaymentT result = apiInstance.PaymentPut(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfPaymentT**](SaveRequestOfPaymentT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponseOfPaymentT**](SynkSaveQueueResponseOfPaymentT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentsetmanualallocationforadhocpayments"></a>
# **PaymentSetManualAllocationForAdhocPayments**
> ActionResults PaymentSetManualAllocationForAdhocPayments (ActionRequestOfBoolean body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentSetManualAllocationForAdhocPaymentsExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var body = new ActionRequestOfBoolean(); // ActionRequestOfBoolean | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PaymentSetManualAllocationForAdhocPayments(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentSetManualAllocationForAdhocPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfBoolean**](ActionRequestOfBoolean.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="paymentupdatestatus"></a>
# **PaymentUpdateStatus**
> ActionResults PaymentUpdateStatus (StatusUpdateRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class PaymentUpdateStatusExample
    {
        public void main()
        {

            var apiInstance = new PaymentApi();
            var body = new StatusUpdateRequest(); // StatusUpdateRequest | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.PaymentUpdateStatus(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PaymentUpdateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StatusUpdateRequest**](StatusUpdateRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

