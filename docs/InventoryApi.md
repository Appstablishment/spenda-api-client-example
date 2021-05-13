# IO.Swagger.Api.InventoryApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryAutoCreateUnlinkedVariants**](InventoryApi.md#inventoryautocreateunlinkedvariants) | **POST** /api/Inventory/{masterInventoryID}/generatevariants | Inventory_AutoCreateUnlinkedVariants
[**InventoryCheckIfAllVariantsCanBeUnlinked**](InventoryApi.md#inventorycheckifallvariantscanbeunlinked) | **GET** /api/Inventory/{masterInventoryID}/canunlink | Inventory_CheckIfAllVariantsCanBeUnlinked
[**InventoryCreateAndLinkVariant**](InventoryApi.md#inventorycreateandlinkvariant) | **POST** /api/Inventory/{masterInventoryID}/generatevariant | Inventory_CreateAndLinkVariant
[**InventoryDelete**](InventoryApi.md#inventorydelete) | **POST** /api/Inventory/Delete | Inventory_Delete
[**InventoryGet**](InventoryApi.md#inventoryget) | **GET** /api/Inventory/{id} | Inventory_Get
[**InventoryGetDetailedSOHV2**](InventoryApi.md#inventorygetdetailedsohv2) | **GET** /api/v2/Inventory/{id}/stockonhand | Inventory_GetDetailedSOHV2
[**InventoryGetMedia**](InventoryApi.md#inventorygetmedia) | **GET** /api/Inventory/{id}/media | Inventory_GetMedia
[**InventoryGetVariantTemplate**](InventoryApi.md#inventorygetvarianttemplate) | **GET** /api/Inventory/{id}/varianttemplate | Inventory_GetVariantTemplate
[**InventoryLinkVariant**](InventoryApi.md#inventorylinkvariant) | **POST** /api/Inventory/{masterInventoryID}/linkvariant | Inventory_LinkVariant
[**InventoryPost**](InventoryApi.md#inventorypost) | **POST** /api/Inventory | Inventory_Post
[**InventoryPut**](InventoryApi.md#inventoryput) | **PUT** /api/Inventory/{id} | Inventory_Put
[**InventorySaveVariations**](InventoryApi.md#inventorysavevariations) | **POST** /api/Inventory/{masterInventoryID}/variations | Inventory_SaveVariations
[**InventorySearchT2**](InventoryApi.md#inventorysearcht2) | **GET** /api/Inventory | Inventory_SearchT2
[**InventorySearchUsingBarcode**](InventoryApi.md#inventorysearchusingbarcode) | **GET** /api/Inventory/barcode | Inventory_SearchUsingBarcode
[**InventoryUnlinkVariantsFromMaster**](InventoryApi.md#inventoryunlinkvariantsfrommaster) | **POST** /api/Inventory/{masterInventoryID}/unlinkvariants | Inventory_UnlinkVariantsFromMaster
[**InventoryUpdateMedia**](InventoryApi.md#inventoryupdatemedia) | **PUT** /api/Inventory/{id}/media | Inventory_UpdateMedia
[**InventoryUploadMedia**](InventoryApi.md#inventoryuploadmedia) | **POST** /api/Inventory/{id}/media | Inventory_UploadMedia

<a name="inventoryautocreateunlinkedvariants"></a>
# **InventoryAutoCreateUnlinkedVariants**
> ActionResults InventoryAutoCreateUnlinkedVariants (int? masterInventoryID)

Inventory_AutoCreateUnlinkedVariants

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryAutoCreateUnlinkedVariantsExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.

            try
            {
                // Inventory_AutoCreateUnlinkedVariants
                ActionResults result = apiInstance.InventoryAutoCreateUnlinkedVariants(masterInventoryID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryAutoCreateUnlinkedVariants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorycheckifallvariantscanbeunlinked"></a>
# **InventoryCheckIfAllVariantsCanBeUnlinked**
> ActionResultsOfBoolean InventoryCheckIfAllVariantsCanBeUnlinked (int? masterInventoryID)

Inventory_CheckIfAllVariantsCanBeUnlinked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryCheckIfAllVariantsCanBeUnlinkedExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.

            try
            {
                // Inventory_CheckIfAllVariantsCanBeUnlinked
                ActionResultsOfBoolean result = apiInstance.InventoryCheckIfAllVariantsCanBeUnlinked(masterInventoryID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryCheckIfAllVariantsCanBeUnlinked: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 

### Return type

[**ActionResultsOfBoolean**](ActionResultsOfBoolean.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorycreateandlinkvariant"></a>
# **InventoryCreateAndLinkVariant**
> ActionResults InventoryCreateAndLinkVariant (int? masterInventoryID, List reqVariationOptionIDs)

Inventory_CreateAndLinkVariant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryCreateAndLinkVariantExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.
            var reqVariationOptionIDs = new List(); // List |  (optional) 

            try
            {
                // Inventory_CreateAndLinkVariant
                ActionResults result = apiInstance.InventoryCreateAndLinkVariant(masterInventoryID, reqVariationOptionIDs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryCreateAndLinkVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 
 **reqVariationOptionIDs** | [**List**](.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorydelete"></a>
# **InventoryDelete**
> ApiInventoryDeletePost200ApplicationJsonResponse InventoryDelete (ActionRequestOfInt32 body)

Inventory_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryDeleteExample
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

            var apiInstance = new InventoryApi();
            var body = new ActionRequestOfInt32(); // ActionRequestOfInt32 |  (optional) 

            try
            {
                // Inventory_Delete
                ApiInventoryDeletePost200ApplicationJsonResponse result = apiInstance.InventoryDelete(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionRequestOfInt32**](ActionRequestOfInt32.md)|  | [optional] 

### Return type

[**ApiInventoryDeletePost200ApplicationJsonResponse**](ApiInventoryDeletePost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryget"></a>
# **InventoryGet**
> InventoryEditResponse InventoryGet (int? id, int? filterShowSOHFromWarehouseID, int? filterLinkedSupplierID)

Inventory_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryGetExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.
            var filterShowSOHFromWarehouseID = 56;  // int? | Format - int32. (optional) 
            var filterLinkedSupplierID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Inventory_Get
                InventoryEditResponse result = apiInstance.InventoryGet(id, filterShowSOHFromWarehouseID, filterLinkedSupplierID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **filterShowSOHFromWarehouseID** | **int?**| Format - int32. | [optional] 
 **filterLinkedSupplierID** | **int?**| Format - int32. | [optional] 

### Return type

[**InventoryEditResponse**](InventoryEditResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetdetailedsohv2"></a>
# **InventoryGetDetailedSOHV2**
> ActionResultsOfInventoryStockOnHandT InventoryGetDetailedSOHV2 (int? id)

Inventory_GetDetailedSOHV2

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryGetDetailedSOHV2Example
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Inventory_GetDetailedSOHV2
                ActionResultsOfInventoryStockOnHandT result = apiInstance.InventoryGetDetailedSOHV2(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryGetDetailedSOHV2: " + e.Message );
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

[**ActionResultsOfInventoryStockOnHandT**](ActionResultsOfInventoryStockOnHandT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetmedia"></a>
# **InventoryGetMedia**
> ActionResultsOfMediaFiles InventoryGetMedia (int? id)

Inventory_GetMedia

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryGetMediaExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Inventory_GetMedia
                ActionResultsOfMediaFiles result = apiInstance.InventoryGetMedia(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryGetMedia: " + e.Message );
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

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetvarianttemplate"></a>
# **InventoryGetVariantTemplate**
> ActionResultsOfInventoryItemT InventoryGetVariantTemplate (int? id, List reqVariationOptionIDs)

Inventory_GetVariantTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryGetVariantTemplateExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.
            var reqVariationOptionIDs = new List(); // List |  (optional) 

            try
            {
                // Inventory_GetVariantTemplate
                ActionResultsOfInventoryItemT result = apiInstance.InventoryGetVariantTemplate(id, reqVariationOptionIDs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryGetVariantTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **reqVariationOptionIDs** | [**List**](.md)|  | [optional] 

### Return type

[**ActionResultsOfInventoryItemT**](ActionResultsOfInventoryItemT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkvariant"></a>
# **InventoryLinkVariant**
> ActionResults InventoryLinkVariant (int? masterInventoryID, ActionRequestOfChildVariant body)

Inventory_LinkVariant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryLinkVariantExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.
            var body = new ActionRequestOfChildVariant(); // ActionRequestOfChildVariant |  (optional) 

            try
            {
                // Inventory_LinkVariant
                ActionResults result = apiInstance.InventoryLinkVariant(masterInventoryID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryLinkVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 
 **body** | [**ActionRequestOfChildVariant**](ActionRequestOfChildVariant.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorypost"></a>
# **InventoryPost**
> SynkSaveQueueResponse InventoryPost (InventorySaveRequestRequestXml1 body)

Inventory_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryPostExample
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

            var apiInstance = new InventoryApi();
            var body = new InventorySaveRequestRequestXml1(); // InventorySaveRequestRequestXml1 |  (optional) 

            try
            {
                // Inventory_Post
                SynkSaveQueueResponse result = apiInstance.InventoryPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventorySaveRequestRequestXml1**](InventorySaveRequestRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryput"></a>
# **InventoryPut**
> SynkSaveQueueResponse InventoryPut (int? id, InventorySaveRequestRequestXml1 body)

Inventory_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryPutExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.
            var body = new InventorySaveRequestRequestXml1(); // InventorySaveRequestRequestXml1 |  (optional) 

            try
            {
                // Inventory_Put
                SynkSaveQueueResponse result = apiInstance.InventoryPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**InventorySaveRequestRequestXml1**](InventorySaveRequestRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysavevariations"></a>
# **InventorySaveVariations**
> ActionResultsOfInventoryVariations InventorySaveVariations (int? masterInventoryID, ActionRequestOfInventoryVariations body)

Inventory_SaveVariations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventorySaveVariationsExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.
            var body = new ActionRequestOfInventoryVariations(); // ActionRequestOfInventoryVariations |  (optional) 

            try
            {
                // Inventory_SaveVariations
                ActionResultsOfInventoryVariations result = apiInstance.InventorySaveVariations(masterInventoryID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventorySaveVariations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 
 **body** | [**ActionRequestOfInventoryVariations**](ActionRequestOfInventoryVariations.md)|  | [optional] 

### Return type

[**ActionResultsOfInventoryVariations**](ActionResultsOfInventoryVariations.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysearcht2"></a>
# **InventorySearchT2**
> PagedActionResultsOfInventoryItems InventorySearchT2 (int? filterWarehouseID, int? filterInventoryID, int? filterInventoryClassID, int? filterSupplierID, bool? filterIsSearchSuppliersCatalog, string filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, int? filterVariantMasterInventoryID, string filterSearchString, bool? filterIsExactMatch, bool? filterIncludeDeleted, List filterBrandIDs, List filterIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID)

Inventory_SearchT2

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventorySearchT2Example
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

            var apiInstance = new InventoryApi();
            var filterWarehouseID = 56;  // int? | Format - int32. (optional) 
            var filterInventoryID = 56;  // int? | Format - int32. (optional) 
            var filterInventoryClassID = 56;  // int? | Format - int32. (optional) 
            var filterSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterIsSearchSuppliersCatalog = true;  // bool? |  (optional) 
            var filterInventoryGUID = filterInventoryGUID_example;  // string | Format - uuid. (optional) 
            var filterIsShowChildVariants = true;  // bool? |  (optional) 
            var filterIsIncludeCategories = true;  // bool? |  (optional) 
            var filterIsShowPostingInventoryOnly = true;  // bool? |  (optional) 
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterIsSOHTracked = true;  // bool? |  (optional) 
            var filterVariantMasterInventoryID = 56;  // int? | Format - int32. (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterBrandIDs = new List(); // List |  (optional) 
            var filterIDs = new List(); // List |  (optional) 
            var filterLinkedSupplierID = 56;  // int? | Format - int32. (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 56;  // int? | Format - int64. (optional) 
            var filterMaxResults = 56;  // int? | Format - int32. (optional) 
            var filterTenantID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Inventory_SearchT2
                PagedActionResultsOfInventoryItems result = apiInstance.InventorySearchT2(filterWarehouseID, filterInventoryID, filterInventoryClassID, filterSupplierID, filterIsSearchSuppliersCatalog, filterInventoryGUID, filterIsShowChildVariants, filterIsIncludeCategories, filterIsShowPostingInventoryOnly, filterIsPurchased, filterIsSold, filterIsSOHTracked, filterVariantMasterInventoryID, filterSearchString, filterIsExactMatch, filterIncludeDeleted, filterBrandIDs, filterIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterSortField, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventorySearchT2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterWarehouseID** | **int?**| Format - int32. | [optional] 
 **filterInventoryID** | **int?**| Format - int32. | [optional] 
 **filterInventoryClassID** | **int?**| Format - int32. | [optional] 
 **filterSupplierID** | **int?**| Format - int32. | [optional] 
 **filterIsSearchSuppliersCatalog** | **bool?**|  | [optional] 
 **filterInventoryGUID** | **string**| Format - uuid. | [optional] 
 **filterIsShowChildVariants** | **bool?**|  | [optional] 
 **filterIsIncludeCategories** | **bool?**|  | [optional] 
 **filterIsShowPostingInventoryOnly** | **bool?**|  | [optional] 
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterIsSOHTracked** | **bool?**|  | [optional] 
 **filterVariantMasterInventoryID** | **int?**| Format - int32. | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterBrandIDs** | [**List**](.md)|  | [optional] 
 **filterIDs** | [**List**](.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**| Format - int32. | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **int?**| Format - int64. | [optional] 
 **filterMaxResults** | **int?**| Format - int32. | [optional] 
 **filterTenantID** | **int?**| Format - int32. | [optional] 

### Return type

[**PagedActionResultsOfInventoryItems**](PagedActionResultsOfInventoryItems.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysearchusingbarcode"></a>
# **InventorySearchUsingBarcode**
> PagedActionResultsOfInventoryItems InventorySearchUsingBarcode (bool? filterIsPurchased, bool? filterIsSold, string filterSearchString, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService)

Inventory_SearchUsingBarcode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventorySearchUsingBarcodeExample
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

            var apiInstance = new InventoryApi();
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 

            try
            {
                // Inventory_SearchUsingBarcode
                PagedActionResultsOfInventoryItems result = apiInstance.InventorySearchUsingBarcode(filterIsPurchased, filterIsSold, filterSearchString, filterIncludeDeleted, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventorySearchUsingBarcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 

### Return type

[**PagedActionResultsOfInventoryItems**](PagedActionResultsOfInventoryItems.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryunlinkvariantsfrommaster"></a>
# **InventoryUnlinkVariantsFromMaster**
> ActionResults InventoryUnlinkVariantsFromMaster (int? masterInventoryID)

Inventory_UnlinkVariantsFromMaster

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryUnlinkVariantsFromMasterExample
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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | Format - int32.

            try
            {
                // Inventory_UnlinkVariantsFromMaster
                ActionResults result = apiInstance.InventoryUnlinkVariantsFromMaster(masterInventoryID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryUnlinkVariantsFromMaster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterInventoryID** | **int?**| Format - int32. | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryupdatemedia"></a>
# **InventoryUpdateMedia**
> ActionResults InventoryUpdateMedia (int? id, List<MediaFileT> body)

Inventory_UpdateMedia

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryUpdateMediaExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.
            var body = new List<MediaFileT>(); // List<MediaFileT> |  (optional) 

            try
            {
                // Inventory_UpdateMedia
                ActionResults result = apiInstance.InventoryUpdateMedia(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryUpdateMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**List<MediaFileT>**](MediaFileT.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryuploadmedia"></a>
# **InventoryUploadMedia**
> ActionResultsOfMediaFiles InventoryUploadMedia (int? id)

Inventory_UploadMedia

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryUploadMediaExample
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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Inventory_UploadMedia
                ActionResultsOfMediaFiles result = apiInstance.InventoryUploadMedia(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryUploadMedia: " + e.Message );
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

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

