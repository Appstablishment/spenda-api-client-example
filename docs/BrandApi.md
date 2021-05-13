# IO.Swagger.Api.BrandApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrandDelete**](BrandApi.md#branddelete) | **DELETE** /api/Brand/{id} | Brand_Delete
[**BrandGet**](BrandApi.md#brandget) | **GET** /api/Brand | Brand_Get
[**BrandGetByID**](BrandApi.md#brandgetbyid) | **GET** /api/Brand/{id} | Brand_GetByID
[**BrandPost**](BrandApi.md#brandpost) | **POST** /api/Brand | Brand_Post
[**BrandPut**](BrandApi.md#brandput) | **PUT** /api/Brand/{id} | Brand_Put

<a name="branddelete"></a>
# **BrandDelete**
> ActionResults BrandDelete (int? id)

Brand_Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandDeleteExample
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

            var apiInstance = new BrandApi();
            var id = 56;  // int? | Format - int32.

            try
            {
                // Brand_Delete
                ActionResults result = apiInstance.BrandDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.BrandDelete: " + e.Message );
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

<a name="brandget"></a>
# **BrandGet**
> PagedActionResultsOfBrands BrandGet (List filterStatuses, List filterStatusStrings, List filterStatus, string filterSearchString, string filterSearch, string filterStartDate, string filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List filterCategoryIDs, List filterBrandIDs, List filterIDs, List filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, int? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)

Brand_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandGetExample
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

            var apiInstance = new BrandApi();
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
                // Brand_Get
                PagedActionResultsOfBrands result = apiInstance.BrandGet(filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.BrandGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

[**PagedActionResultsOfBrands**](PagedActionResultsOfBrands.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandgetbyid"></a>
# **BrandGetByID**
> EditResponseOfBrandT BrandGetByID (int? id, int? reqID, string reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)

Brand_GetByID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandGetByIDExample
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

            var apiInstance = new BrandApi();
            var id = 56;  // int? | Format - int32.
            var reqID = 56;  // int? | Format - int32. (optional) 
            var reqGUID = reqGUID_example;  // string | Format - uuid. (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? | Format - int32. (optional) 
            var reqWebsiteID = 56;  // int? | Format - int32. (optional) 
            var reqUserID = 56;  // int? | Format - int32. (optional) 

            try
            {
                // Brand_GetByID
                EditResponseOfBrandT result = apiInstance.BrandGetByID(id, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.BrandGetByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **reqID** | **int?**| Format - int32. | [optional] 
 **reqGUID** | **string**| Format - uuid. | [optional] 
 **reqIsGetExtraInfo** | **bool?**|  | [optional] 
 **reqTenantID** | **int?**| Format - int32. | [optional] 
 **reqWebsiteID** | **int?**| Format - int32. | [optional] 
 **reqUserID** | **int?**| Format - int32. | [optional] 

### Return type

[**EditResponseOfBrandT**](EditResponseOfBrandT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandpost"></a>
# **BrandPost**
> SynkSaveQueueResponseOfBrandT BrandPost (SaveRequestOfBrandTRequestXml1 body)

Brand_Post

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandPostExample
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

            var apiInstance = new BrandApi();
            var body = new SaveRequestOfBrandTRequestXml1(); // SaveRequestOfBrandTRequestXml1 |  (optional) 

            try
            {
                // Brand_Post
                SynkSaveQueueResponseOfBrandT result = apiInstance.BrandPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.BrandPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfBrandTRequestXml1**](SaveRequestOfBrandTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponseOfBrandT**](SynkSaveQueueResponseOfBrandT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandput"></a>
# **BrandPut**
> SynkSaveQueueResponseOfBrandT BrandPut (int? id, SaveRequestOfBrandTRequestXml1 body)

Brand_Put

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandPutExample
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

            var apiInstance = new BrandApi();
            var id = 56;  // int? | Format - int32.
            var body = new SaveRequestOfBrandTRequestXml1(); // SaveRequestOfBrandTRequestXml1 |  (optional) 

            try
            {
                // Brand_Put
                SynkSaveQueueResponseOfBrandT result = apiInstance.BrandPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.BrandPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Format - int32. | 
 **body** | [**SaveRequestOfBrandTRequestXml1**](SaveRequestOfBrandTRequestXml1.md)|  | [optional] 

### Return type

[**SynkSaveQueueResponseOfBrandT**](SynkSaveQueueResponseOfBrandT.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

