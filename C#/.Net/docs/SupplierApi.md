# IO.Swagger.Api.SupplierApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SupplierDelete**](SupplierApi.md#supplierdelete) | **DELETE** /api/v3/Supplier/{id} | 
[**SupplierGet**](SupplierApi.md#supplierget) | **GET** /api/v3/Supplier | 
[**SupplierGetByID**](SupplierApi.md#suppliergetbyid) | **GET** /api/v3/Supplier/{id} | 
[**SupplierPost**](SupplierApi.md#supplierpost) | **POST** /api/v3/Supplier | 
[**SupplierPut**](SupplierApi.md#supplierput) | **PUT** /api/v3/Supplier/{id} | 

<a name="supplierdelete"></a>
# **SupplierDelete**
> ActionResults SupplierDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplierDeleteExample
    {
        public void main()
        {

            var apiInstance = new SupplierApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.SupplierDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierDelete: " + e.Message );
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

<a name="supplierget"></a>
# **SupplierGet**
> PagedActionResultsOfSuppliers SupplierGet (int? filterInventoryFulfilmentID, List<int?> filterInventoryIDs, List<string> filterSupplierTypes, bool? filterIsLinkedSuppliersOnly, int? filterIgnoreProspectID, bool? filterIsExactCodeSearch, bool? filterIsExactEmailSearch, int? filterSupplierID, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplierGetExample
    {
        public void main()
        {

            var apiInstance = new SupplierApi();
            var filterInventoryFulfilmentID = 56;  // int? |  (optional) 
            var filterInventoryIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterSupplierTypes = new List<string>(); // List<string> |  (optional) 
            var filterIsLinkedSuppliersOnly = true;  // bool? |  (optional) 
            var filterIgnoreProspectID = 56;  // int? |  (optional) 
            var filterIsExactCodeSearch = true;  // bool? |  (optional) 
            var filterIsExactEmailSearch = true;  // bool? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
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
                PagedActionResultsOfSuppliers result = apiInstance.SupplierGet(filterInventoryFulfilmentID, filterInventoryIDs, filterSupplierTypes, filterIsLinkedSuppliersOnly, filterIgnoreProspectID, filterIsExactCodeSearch, filterIsExactEmailSearch, filterSupplierID, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterInventoryFulfilmentID** | **int?**|  | [optional] 
 **filterInventoryIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterSupplierTypes** | [**List<string>**](string.md)|  | [optional] 
 **filterIsLinkedSuppliersOnly** | **bool?**|  | [optional] 
 **filterIgnoreProspectID** | **int?**|  | [optional] 
 **filterIsExactCodeSearch** | **bool?**|  | [optional] 
 **filterIsExactEmailSearch** | **bool?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
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

[**PagedActionResultsOfSuppliers**](PagedActionResultsOfSuppliers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suppliergetbyid"></a>
# **SupplierGetByID**
> EditResponseOfSupplierT SupplierGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplierGetByIDExample
    {
        public void main()
        {

            var apiInstance = new SupplierApi();
            var id = 56;  // int? | 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
                EditResponseOfSupplierT result = apiInstance.SupplierGetByID(id, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierGetByID: " + e.Message );
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

[**EditResponseOfSupplierT**](EditResponseOfSupplierT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="supplierpost"></a>
# **SupplierPost**
> SynkSaveQueueResponseOfSupplierT SupplierPost (SaveRequestOfSupplierT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplierPostExample
    {
        public void main()
        {

            var apiInstance = new SupplierApi();
            var body = new SaveRequestOfSupplierT(); // SaveRequestOfSupplierT | 

            try
            {
                SynkSaveQueueResponseOfSupplierT result = apiInstance.SupplierPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfSupplierT**](SaveRequestOfSupplierT.md)|  | 

### Return type

[**SynkSaveQueueResponseOfSupplierT**](SynkSaveQueueResponseOfSupplierT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="supplierput"></a>
# **SupplierPut**
> SynkSaveQueueResponseOfSupplierT SupplierPut (SaveRequestOfSupplierT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplierPutExample
    {
        public void main()
        {

            var apiInstance = new SupplierApi();
            var body = new SaveRequestOfSupplierT(); // SaveRequestOfSupplierT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponseOfSupplierT result = apiInstance.SupplierPut(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfSupplierT**](SaveRequestOfSupplierT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponseOfSupplierT**](SynkSaveQueueResponseOfSupplierT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

