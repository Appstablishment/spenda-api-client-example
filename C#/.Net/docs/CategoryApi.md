# IO.Swagger.Api.CategoryApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CategoryDelete**](CategoryApi.md#categorydelete) | **DELETE** /api/Category/{id} | 
[**CategoryGet**](CategoryApi.md#categoryget) | **GET** /api/Category | 
[**CategoryGetByID**](CategoryApi.md#categorygetbyid) | **GET** /api/Category/{id} | 
[**CategoryGetMedia**](CategoryApi.md#categorygetmedia) | **GET** /api/Category/{id}/media | 
[**CategoryGetParentTree**](CategoryApi.md#categorygetparenttree) | **GET** /api/Category/{id}/tree | 
[**CategoryPost**](CategoryApi.md#categorypost) | **POST** /api/Category | 
[**CategoryPut**](CategoryApi.md#categoryput) | **PUT** /api/Category/{id} | 
[**CategorySaveCategoryTreeBranch**](CategoryApi.md#categorysavecategorytreebranch) | **POST** /api/Category/savecategorytreebranch | 
[**CategoryUpdateMedia**](CategoryApi.md#categoryupdatemedia) | **PUT** /api/Category/{id}/media | 
[**CategoryUploadMedia**](CategoryApi.md#categoryuploadmedia) | **POST** /api/Category/{id}/media | 

<a name="categorydelete"></a>
# **CategoryDelete**
> ActionResults CategoryDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryDeleteExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.CategoryDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryDelete: " + e.Message );
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

<a name="categoryget"></a>
# **CategoryGet**
> PagedActionResultsOfCategories CategoryGet (List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryGetExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
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
                PagedActionResultsOfCategories result = apiInstance.CategoryGet(filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryGet: " + e.Message );
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

[**PagedActionResultsOfCategories**](PagedActionResultsOfCategories.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorygetbyid"></a>
# **CategoryGetByID**
> EditResponseOfCategoryT CategoryGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryGetByIDExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var id = 56;  // int? | 
            var reqID = 56;  // int? |  (optional) 
            var reqGUID = new Guid?(); // Guid? |  (optional) 
            var reqIsGetExtraInfo = true;  // bool? |  (optional) 
            var reqTenantID = 56;  // int? |  (optional) 
            var reqWebsiteID = 56;  // int? |  (optional) 
            var reqUserID = 56;  // int? |  (optional) 

            try
            {
                EditResponseOfCategoryT result = apiInstance.CategoryGetByID(id, reqID, reqGUID, reqIsGetExtraInfo, reqTenantID, reqWebsiteID, reqUserID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryGetByID: " + e.Message );
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

[**EditResponseOfCategoryT**](EditResponseOfCategoryT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorygetmedia"></a>
# **CategoryGetMedia**
> ActionResultsOfMediaFiles CategoryGetMedia (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryGetMediaExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfMediaFiles result = apiInstance.CategoryGetMedia(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryGetMedia: " + e.Message );
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

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorygetparenttree"></a>
# **CategoryGetParentTree**
> ActionResultsListOfListOfCategoryTreeElement CategoryGetParentTree (int? id, bool? isParent)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryGetParentTreeExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var id = 56;  // int? | 
            var isParent = true;  // bool? | 

            try
            {
                ActionResultsListOfListOfCategoryTreeElement result = apiInstance.CategoryGetParentTree(id, isParent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryGetParentTree: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **isParent** | **bool?**|  | 

### Return type

[**ActionResultsListOfListOfCategoryTreeElement**](ActionResultsListOfListOfCategoryTreeElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorypost"></a>
# **CategoryPost**
> SynkSaveQueueResponseOfCategoryT CategoryPost (SaveRequestOfCategoryT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryPostExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var body = new SaveRequestOfCategoryT(); // SaveRequestOfCategoryT | 

            try
            {
                SynkSaveQueueResponseOfCategoryT result = apiInstance.CategoryPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfCategoryT**](SaveRequestOfCategoryT.md)|  | 

### Return type

[**SynkSaveQueueResponseOfCategoryT**](SynkSaveQueueResponseOfCategoryT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoryput"></a>
# **CategoryPut**
> SynkSaveQueueResponseOfCategoryT CategoryPut (SaveRequestOfCategoryT body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryPutExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var body = new SaveRequestOfCategoryT(); // SaveRequestOfCategoryT | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponseOfCategoryT result = apiInstance.CategoryPut(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfCategoryT**](SaveRequestOfCategoryT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponseOfCategoryT**](SynkSaveQueueResponseOfCategoryT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorysavecategorytreebranch"></a>
# **CategorySaveCategoryTreeBranch**
> SynkSaveQueueResponseOfCategoryT CategorySaveCategoryTreeBranch (SaveRequestOfCategoryT body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategorySaveCategoryTreeBranchExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var body = new SaveRequestOfCategoryT(); // SaveRequestOfCategoryT | 

            try
            {
                SynkSaveQueueResponseOfCategoryT result = apiInstance.CategorySaveCategoryTreeBranch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategorySaveCategoryTreeBranch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaveRequestOfCategoryT**](SaveRequestOfCategoryT.md)|  | 

### Return type

[**SynkSaveQueueResponseOfCategoryT**](SynkSaveQueueResponseOfCategoryT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoryupdatemedia"></a>
# **CategoryUpdateMedia**
> ActionResults CategoryUpdateMedia (List<MediaFileT> body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryUpdateMediaExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var body = new List<MediaFileT>(); // List<MediaFileT> | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.CategoryUpdateMedia(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryUpdateMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List<MediaFileT>**](MediaFileT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoryuploadmedia"></a>
# **CategoryUploadMedia**
> ActionResultsOfMediaFiles CategoryUploadMedia (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryUploadMediaExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var id = 56;  // int? | 

            try
            {
                ActionResultsOfMediaFiles result = apiInstance.CategoryUploadMedia(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryUploadMedia: " + e.Message );
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

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

