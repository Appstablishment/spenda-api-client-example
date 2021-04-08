# IO.Swagger.Api.InventoryApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryAutoCreateUnlinkedVariants**](InventoryApi.md#inventoryautocreateunlinkedvariants) | **POST** /api/Inventory/{masterInventoryID}/generatevariants | 
[**InventoryCheckIfAllVariantsCanBeUnlinked**](InventoryApi.md#inventorycheckifallvariantscanbeunlinked) | **GET** /api/Inventory/{masterInventoryID}/canunlink | 
[**InventoryCreateAndLinkVariant**](InventoryApi.md#inventorycreateandlinkvariant) | **POST** /api/Inventory/{masterInventoryID}/generatevariant | 
[**InventoryDelete**](InventoryApi.md#inventorydelete) | **POST** /api/Inventory/Delete | 
[**InventoryGet**](InventoryApi.md#inventoryget) | **GET** /api/Inventory/{id} | 
[**InventoryGetDetailedSOHV2**](InventoryApi.md#inventorygetdetailedsohv2) | **GET** /api/v2/Inventory/{id}/stockonhand | 
[**InventoryGetMedia**](InventoryApi.md#inventorygetmedia) | **GET** /api/Inventory/{id}/media | 
[**InventoryGetVariantTemplate**](InventoryApi.md#inventorygetvarianttemplate) | **GET** /api/Inventory/{id}/varianttemplate | 
[**InventoryLinkVariant**](InventoryApi.md#inventorylinkvariant) | **POST** /api/Inventory/{masterInventoryID}/linkvariant | 
[**InventoryPost**](InventoryApi.md#inventorypost) | **POST** /api/Inventory | 
[**InventoryPut**](InventoryApi.md#inventoryput) | **PUT** /api/Inventory/{id} | 
[**InventorySaveVariations**](InventoryApi.md#inventorysavevariations) | **POST** /api/Inventory/{masterInventoryID}/variations | 
[**InventorySearchT2**](InventoryApi.md#inventorysearcht2) | **GET** /api/Inventory | 
[**InventorySearchUsingBarcode**](InventoryApi.md#inventorysearchusingbarcode) | **GET** /api/Inventory/barcode | 
[**InventoryUnlinkVariantsFromMaster**](InventoryApi.md#inventoryunlinkvariantsfrommaster) | **POST** /api/Inventory/{masterInventoryID}/unlinkvariants | 
[**InventoryUpdateMedia**](InventoryApi.md#inventoryupdatemedia) | **PUT** /api/Inventory/{id}/media | 
[**InventoryUploadMedia**](InventoryApi.md#inventoryuploadmedia) | **POST** /api/Inventory/{id}/media | 

<a name="inventoryautocreateunlinkedvariants"></a>
# **InventoryAutoCreateUnlinkedVariants**
> ActionResults InventoryAutoCreateUnlinkedVariants (int? masterInventoryID)



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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | 

            try
            {
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
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorycheckifallvariantscanbeunlinked"></a>
# **InventoryCheckIfAllVariantsCanBeUnlinked**
> ActionResultsOfBoolean InventoryCheckIfAllVariantsCanBeUnlinked (int? masterInventoryID)



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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | 

            try
            {
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
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResultsOfBoolean**](ActionResultsOfBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorycreateandlinkvariant"></a>
# **InventoryCreateAndLinkVariant**
> ActionResults InventoryCreateAndLinkVariant (int? masterInventoryID, List<int?> reqVariationOptionIDs)



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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | 
            var reqVariationOptionIDs = new List<int?>(); // List<int?> |  (optional) 

            try
            {
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
 **masterInventoryID** | **int?**|  | 
 **reqVariationOptionIDs** | [**List<int?>**](int?.md)|  | [optional] 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorydelete"></a>
# **InventoryDelete**
> Object InventoryDelete (ActionRequestOfInt32 body)



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

            var apiInstance = new InventoryApi();
            var body = new ActionRequestOfInt32(); // ActionRequestOfInt32 | 

            try
            {
                Object result = apiInstance.InventoryDelete(body);
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
 **body** | [**ActionRequestOfInt32**](ActionRequestOfInt32.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryget"></a>
# **InventoryGet**
> InventoryEditResponse InventoryGet (int? id, string filterMustHave, string filterCanHave, string filterExclusions, List<> filterBrandList, bool? filterShowDeletedItems, int? filterWarehouseID, int? filterWarehouseLocationID, int? filterPurchaseOrderID, int? filterInventoryID, int? filterInventoryClassID, bool? filterExcludeItemsInMasterList, int? filterCustomerID, int? filterSupplierID, int? filterSearchType, int? filterStockTakeID, int? filterStartRow, string filterOrderBy, bool? filterIsShowPublishedOnly, int? filterInventoryClassGroupID, int? filterInventoryClassGroupTypeID, bool? filterIncludePickandPackedAssets, int? filterTransID, int? filterTransDatTypeID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, int? filterShowSOHFromWarehouseID, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, string filterViewMode, int? filterVariantMasterInventoryID, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 
            var filterMustHave = filterMustHave_example;  // string |  (optional) 
            var filterCanHave = filterCanHave_example;  // string |  (optional) 
            var filterExclusions = filterExclusions_example;  // string |  (optional) 
            var filterBrandList = new List<>(); // List<> |  (optional) 
            var filterShowDeletedItems = true;  // bool? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterWarehouseLocationID = 56;  // int? |  (optional) 
            var filterPurchaseOrderID = 56;  // int? |  (optional) 
            var filterInventoryID = 56;  // int? |  (optional) 
            var filterInventoryClassID = 56;  // int? |  (optional) 
            var filterExcludeItemsInMasterList = true;  // bool? |  (optional) 
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterSearchType = 56;  // int? |  (optional) 
            var filterStockTakeID = 56;  // int? |  (optional) 
            var filterStartRow = 56;  // int? |  (optional) 
            var filterOrderBy = filterOrderBy_example;  // string |  (optional) 
            var filterIsShowPublishedOnly = true;  // bool? |  (optional) 
            var filterInventoryClassGroupID = 56;  // int? |  (optional) 
            var filterInventoryClassGroupTypeID = 56;  // int? |  (optional) 
            var filterIncludePickandPackedAssets = true;  // bool? |  (optional) 
            var filterTransID = 56;  // int? |  (optional) 
            var filterTransDatTypeID = 56;  // int? |  (optional) 
            var filterIsSearchSuppliersCatalog = true;  // bool? |  (optional) 
            var filterInventoryGUID = new Guid?(); // Guid? |  (optional) 
            var filterIsShowChildVariants = true;  // bool? |  (optional) 
            var filterIsIncludeCategories = true;  // bool? |  (optional) 
            var filterIsShowPostingInventoryOnly = true;  // bool? |  (optional) 
            var filterShowSOHFromWarehouseID = 56;  // int? |  (optional) 
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterIsSOHTracked = true;  // bool? |  (optional) 
            var filterViewMode = filterViewMode_example;  // string |  (optional) 
            var filterVariantMasterInventoryID = 56;  // int? |  (optional) 
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
                InventoryEditResponse result = apiInstance.InventoryGet(id, filterMustHave, filterCanHave, filterExclusions, filterBrandList, filterShowDeletedItems, filterWarehouseID, filterWarehouseLocationID, filterPurchaseOrderID, filterInventoryID, filterInventoryClassID, filterExcludeItemsInMasterList, filterCustomerID, filterSupplierID, filterSearchType, filterStockTakeID, filterStartRow, filterOrderBy, filterIsShowPublishedOnly, filterInventoryClassGroupID, filterInventoryClassGroupTypeID, filterIncludePickandPackedAssets, filterTransID, filterTransDatTypeID, filterIsSearchSuppliersCatalog, filterInventoryGUID, filterIsShowChildVariants, filterIsIncludeCategories, filterIsShowPostingInventoryOnly, filterShowSOHFromWarehouseID, filterIsPurchased, filterIsSold, filterIsSOHTracked, filterViewMode, filterVariantMasterInventoryID, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
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
 **id** | **int?**|  | 
 **filterMustHave** | **string**|  | [optional] 
 **filterCanHave** | **string**|  | [optional] 
 **filterExclusions** | **string**|  | [optional] 
 **filterBrandList** | [**List<>**](.md)|  | [optional] 
 **filterShowDeletedItems** | **bool?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterWarehouseLocationID** | **int?**|  | [optional] 
 **filterPurchaseOrderID** | **int?**|  | [optional] 
 **filterInventoryID** | **int?**|  | [optional] 
 **filterInventoryClassID** | **int?**|  | [optional] 
 **filterExcludeItemsInMasterList** | **bool?**|  | [optional] 
 **filterCustomerID** | **int?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
 **filterSearchType** | **int?**|  | [optional] 
 **filterStockTakeID** | **int?**|  | [optional] 
 **filterStartRow** | **int?**|  | [optional] 
 **filterOrderBy** | **string**|  | [optional] 
 **filterIsShowPublishedOnly** | **bool?**|  | [optional] 
 **filterInventoryClassGroupID** | **int?**|  | [optional] 
 **filterInventoryClassGroupTypeID** | **int?**|  | [optional] 
 **filterIncludePickandPackedAssets** | **bool?**|  | [optional] 
 **filterTransID** | **int?**|  | [optional] 
 **filterTransDatTypeID** | **int?**|  | [optional] 
 **filterIsSearchSuppliersCatalog** | **bool?**|  | [optional] 
 **filterInventoryGUID** | [**Guid?**](.md)|  | [optional] 
 **filterIsShowChildVariants** | **bool?**|  | [optional] 
 **filterIsIncludeCategories** | **bool?**|  | [optional] 
 **filterIsShowPostingInventoryOnly** | **bool?**|  | [optional] 
 **filterShowSOHFromWarehouseID** | **int?**|  | [optional] 
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterIsSOHTracked** | **bool?**|  | [optional] 
 **filterViewMode** | **string**|  | [optional] 
 **filterVariantMasterInventoryID** | **int?**|  | [optional] 
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

[**InventoryEditResponse**](InventoryEditResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetdetailedsohv2"></a>
# **InventoryGetDetailedSOHV2**
> ActionResultsOfInventoryStockOnHandT InventoryGetDetailedSOHV2 (int? id)



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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfInventoryStockOnHandT**](ActionResultsOfInventoryStockOnHandT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetmedia"></a>
# **InventoryGetMedia**
> ActionResultsOfMediaFiles InventoryGetMedia (int? id)



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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetvarianttemplate"></a>
# **InventoryGetVariantTemplate**
> ActionResultsOfInventoryItemT InventoryGetVariantTemplate (int? id, List<int?> reqVariationOptionIDs)



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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 
            var reqVariationOptionIDs = new List<int?>(); // List<int?> |  (optional) 

            try
            {
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
 **id** | **int?**|  | 
 **reqVariationOptionIDs** | [**List<int?>**](int?.md)|  | [optional] 

### Return type

[**ActionResultsOfInventoryItemT**](ActionResultsOfInventoryItemT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorylinkvariant"></a>
# **InventoryLinkVariant**
> ActionResults InventoryLinkVariant (ActionRequestOfChildVariant body, int? masterInventoryID)



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

            var apiInstance = new InventoryApi();
            var body = new ActionRequestOfChildVariant(); // ActionRequestOfChildVariant | 
            var masterInventoryID = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.InventoryLinkVariant(body, masterInventoryID);
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
 **body** | [**ActionRequestOfChildVariant**](ActionRequestOfChildVariant.md)|  | 
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorypost"></a>
# **InventoryPost**
> SynkSaveQueueResponse InventoryPost (InventorySaveRequest body)



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

            var apiInstance = new InventoryApi();
            var body = new InventorySaveRequest(); // InventorySaveRequest | 

            try
            {
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
 **body** | [**InventorySaveRequest**](InventorySaveRequest.md)|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryput"></a>
# **InventoryPut**
> SynkSaveQueueResponse InventoryPut (InventorySaveRequest body, int? id)



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

            var apiInstance = new InventoryApi();
            var body = new InventorySaveRequest(); // InventorySaveRequest | 
            var id = 56;  // int? | 

            try
            {
                SynkSaveQueueResponse result = apiInstance.InventoryPut(body, id);
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
 **body** | [**InventorySaveRequest**](InventorySaveRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponse**](SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysavevariations"></a>
# **InventorySaveVariations**
> ActionResultsOfInventoryVariations InventorySaveVariations (ActionRequestOfInventoryVariations body, int? masterInventoryID)



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

            var apiInstance = new InventoryApi();
            var body = new ActionRequestOfInventoryVariations(); // ActionRequestOfInventoryVariations | 
            var masterInventoryID = 56;  // int? | 

            try
            {
                ActionResultsOfInventoryVariations result = apiInstance.InventorySaveVariations(body, masterInventoryID);
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
 **body** | [**ActionRequestOfInventoryVariations**](ActionRequestOfInventoryVariations.md)|  | 
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResultsOfInventoryVariations**](ActionResultsOfInventoryVariations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysearcht2"></a>
# **InventorySearchT2**
> PagedActionResultsOfInventoryItems InventorySearchT2 (string filterMustHave, string filterCanHave, string filterExclusions, List<> filterBrandList, bool? filterShowDeletedItems, int? filterWarehouseID, int? filterWarehouseLocationID, int? filterPurchaseOrderID, int? filterInventoryID, int? filterInventoryClassID, bool? filterExcludeItemsInMasterList, int? filterCustomerID, int? filterSupplierID, int? filterSearchType, int? filterStockTakeID, int? filterStartRow, string filterOrderBy, bool? filterIsShowPublishedOnly, int? filterInventoryClassGroupID, int? filterInventoryClassGroupTypeID, bool? filterIncludePickandPackedAssets, int? filterTransID, int? filterTransDatTypeID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, int? filterShowSOHFromWarehouseID, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, string filterViewMode, int? filterVariantMasterInventoryID, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



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

            var apiInstance = new InventoryApi();
            var filterMustHave = filterMustHave_example;  // string |  (optional) 
            var filterCanHave = filterCanHave_example;  // string |  (optional) 
            var filterExclusions = filterExclusions_example;  // string |  (optional) 
            var filterBrandList = new List<>(); // List<> |  (optional) 
            var filterShowDeletedItems = true;  // bool? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterWarehouseLocationID = 56;  // int? |  (optional) 
            var filterPurchaseOrderID = 56;  // int? |  (optional) 
            var filterInventoryID = 56;  // int? |  (optional) 
            var filterInventoryClassID = 56;  // int? |  (optional) 
            var filterExcludeItemsInMasterList = true;  // bool? |  (optional) 
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterSearchType = 56;  // int? |  (optional) 
            var filterStockTakeID = 56;  // int? |  (optional) 
            var filterStartRow = 56;  // int? |  (optional) 
            var filterOrderBy = filterOrderBy_example;  // string |  (optional) 
            var filterIsShowPublishedOnly = true;  // bool? |  (optional) 
            var filterInventoryClassGroupID = 56;  // int? |  (optional) 
            var filterInventoryClassGroupTypeID = 56;  // int? |  (optional) 
            var filterIncludePickandPackedAssets = true;  // bool? |  (optional) 
            var filterTransID = 56;  // int? |  (optional) 
            var filterTransDatTypeID = 56;  // int? |  (optional) 
            var filterIsSearchSuppliersCatalog = true;  // bool? |  (optional) 
            var filterInventoryGUID = new Guid?(); // Guid? |  (optional) 
            var filterIsShowChildVariants = true;  // bool? |  (optional) 
            var filterIsIncludeCategories = true;  // bool? |  (optional) 
            var filterIsShowPostingInventoryOnly = true;  // bool? |  (optional) 
            var filterShowSOHFromWarehouseID = 56;  // int? |  (optional) 
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterIsSOHTracked = true;  // bool? |  (optional) 
            var filterViewMode = filterViewMode_example;  // string |  (optional) 
            var filterVariantMasterInventoryID = 56;  // int? |  (optional) 
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
                PagedActionResultsOfInventoryItems result = apiInstance.InventorySearchT2(filterMustHave, filterCanHave, filterExclusions, filterBrandList, filterShowDeletedItems, filterWarehouseID, filterWarehouseLocationID, filterPurchaseOrderID, filterInventoryID, filterInventoryClassID, filterExcludeItemsInMasterList, filterCustomerID, filterSupplierID, filterSearchType, filterStockTakeID, filterStartRow, filterOrderBy, filterIsShowPublishedOnly, filterInventoryClassGroupID, filterInventoryClassGroupTypeID, filterIncludePickandPackedAssets, filterTransID, filterTransDatTypeID, filterIsSearchSuppliersCatalog, filterInventoryGUID, filterIsShowChildVariants, filterIsIncludeCategories, filterIsShowPostingInventoryOnly, filterShowSOHFromWarehouseID, filterIsPurchased, filterIsSold, filterIsSOHTracked, filterViewMode, filterVariantMasterInventoryID, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
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
 **filterMustHave** | **string**|  | [optional] 
 **filterCanHave** | **string**|  | [optional] 
 **filterExclusions** | **string**|  | [optional] 
 **filterBrandList** | [**List<>**](.md)|  | [optional] 
 **filterShowDeletedItems** | **bool?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterWarehouseLocationID** | **int?**|  | [optional] 
 **filterPurchaseOrderID** | **int?**|  | [optional] 
 **filterInventoryID** | **int?**|  | [optional] 
 **filterInventoryClassID** | **int?**|  | [optional] 
 **filterExcludeItemsInMasterList** | **bool?**|  | [optional] 
 **filterCustomerID** | **int?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
 **filterSearchType** | **int?**|  | [optional] 
 **filterStockTakeID** | **int?**|  | [optional] 
 **filterStartRow** | **int?**|  | [optional] 
 **filterOrderBy** | **string**|  | [optional] 
 **filterIsShowPublishedOnly** | **bool?**|  | [optional] 
 **filterInventoryClassGroupID** | **int?**|  | [optional] 
 **filterInventoryClassGroupTypeID** | **int?**|  | [optional] 
 **filterIncludePickandPackedAssets** | **bool?**|  | [optional] 
 **filterTransID** | **int?**|  | [optional] 
 **filterTransDatTypeID** | **int?**|  | [optional] 
 **filterIsSearchSuppliersCatalog** | **bool?**|  | [optional] 
 **filterInventoryGUID** | [**Guid?**](.md)|  | [optional] 
 **filterIsShowChildVariants** | **bool?**|  | [optional] 
 **filterIsIncludeCategories** | **bool?**|  | [optional] 
 **filterIsShowPostingInventoryOnly** | **bool?**|  | [optional] 
 **filterShowSOHFromWarehouseID** | **int?**|  | [optional] 
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterIsSOHTracked** | **bool?**|  | [optional] 
 **filterViewMode** | **string**|  | [optional] 
 **filterVariantMasterInventoryID** | **int?**|  | [optional] 
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

[**PagedActionResultsOfInventoryItems**](PagedActionResultsOfInventoryItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorysearchusingbarcode"></a>
# **InventorySearchUsingBarcode**
> PagedActionResultsOfInventoryItems InventorySearchUsingBarcode (string filterMustHave, string filterCanHave, string filterExclusions, List<> filterBrandList, bool? filterShowDeletedItems, int? filterWarehouseID, int? filterWarehouseLocationID, int? filterPurchaseOrderID, int? filterInventoryID, int? filterInventoryClassID, bool? filterExcludeItemsInMasterList, int? filterCustomerID, int? filterSupplierID, int? filterSearchType, int? filterStockTakeID, int? filterStartRow, string filterOrderBy, bool? filterIsShowPublishedOnly, int? filterInventoryClassGroupID, int? filterInventoryClassGroupTypeID, bool? filterIncludePickandPackedAssets, int? filterTransID, int? filterTransDatTypeID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, int? filterShowSOHFromWarehouseID, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, string filterViewMode, int? filterVariantMasterInventoryID, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)



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

            var apiInstance = new InventoryApi();
            var filterMustHave = filterMustHave_example;  // string |  (optional) 
            var filterCanHave = filterCanHave_example;  // string |  (optional) 
            var filterExclusions = filterExclusions_example;  // string |  (optional) 
            var filterBrandList = new List<>(); // List<> |  (optional) 
            var filterShowDeletedItems = true;  // bool? |  (optional) 
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterWarehouseLocationID = 56;  // int? |  (optional) 
            var filterPurchaseOrderID = 56;  // int? |  (optional) 
            var filterInventoryID = 56;  // int? |  (optional) 
            var filterInventoryClassID = 56;  // int? |  (optional) 
            var filterExcludeItemsInMasterList = true;  // bool? |  (optional) 
            var filterCustomerID = 56;  // int? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterSearchType = 56;  // int? |  (optional) 
            var filterStockTakeID = 56;  // int? |  (optional) 
            var filterStartRow = 56;  // int? |  (optional) 
            var filterOrderBy = filterOrderBy_example;  // string |  (optional) 
            var filterIsShowPublishedOnly = true;  // bool? |  (optional) 
            var filterInventoryClassGroupID = 56;  // int? |  (optional) 
            var filterInventoryClassGroupTypeID = 56;  // int? |  (optional) 
            var filterIncludePickandPackedAssets = true;  // bool? |  (optional) 
            var filterTransID = 56;  // int? |  (optional) 
            var filterTransDatTypeID = 56;  // int? |  (optional) 
            var filterIsSearchSuppliersCatalog = true;  // bool? |  (optional) 
            var filterInventoryGUID = new Guid?(); // Guid? |  (optional) 
            var filterIsShowChildVariants = true;  // bool? |  (optional) 
            var filterIsIncludeCategories = true;  // bool? |  (optional) 
            var filterIsShowPostingInventoryOnly = true;  // bool? |  (optional) 
            var filterShowSOHFromWarehouseID = 56;  // int? |  (optional) 
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterIsSOHTracked = true;  // bool? |  (optional) 
            var filterViewMode = filterViewMode_example;  // string |  (optional) 
            var filterVariantMasterInventoryID = 56;  // int? |  (optional) 
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
                PagedActionResultsOfInventoryItems result = apiInstance.InventorySearchUsingBarcode(filterMustHave, filterCanHave, filterExclusions, filterBrandList, filterShowDeletedItems, filterWarehouseID, filterWarehouseLocationID, filterPurchaseOrderID, filterInventoryID, filterInventoryClassID, filterExcludeItemsInMasterList, filterCustomerID, filterSupplierID, filterSearchType, filterStockTakeID, filterStartRow, filterOrderBy, filterIsShowPublishedOnly, filterInventoryClassGroupID, filterInventoryClassGroupTypeID, filterIncludePickandPackedAssets, filterTransID, filterTransDatTypeID, filterIsSearchSuppliersCatalog, filterInventoryGUID, filterIsShowChildVariants, filterIsIncludeCategories, filterIsShowPostingInventoryOnly, filterShowSOHFromWarehouseID, filterIsPurchased, filterIsSold, filterIsSOHTracked, filterViewMode, filterVariantMasterInventoryID, filterStatuses, filterStatusStrings, filterStatus, filterSearchString, filterSearch, filterStartDate, filterEndDate, filterDatePeriod, filterIsExactMatch, filterIsGetBasicInfo, filterIncludeDeleted, filterIncludeLogs, filterIgnoreID, filterParentID, filterGetCountOnly, filterTransactionTypeDatTypeID, filterCategoryID, filterAdaptorID, filterCategoryIDs, filterBrandIDs, filterIDs, filterGUIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterID, filterIsHierarchicalSort, filterTypes, filterIsShowFavourites, filterIsHidden, filterIncludeSystemTasks, filterIsSystem, filterSortField, filterSortAsc, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID, filterWebsiteID, filterUserID);
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
 **filterMustHave** | **string**|  | [optional] 
 **filterCanHave** | **string**|  | [optional] 
 **filterExclusions** | **string**|  | [optional] 
 **filterBrandList** | [**List<>**](.md)|  | [optional] 
 **filterShowDeletedItems** | **bool?**|  | [optional] 
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterWarehouseLocationID** | **int?**|  | [optional] 
 **filterPurchaseOrderID** | **int?**|  | [optional] 
 **filterInventoryID** | **int?**|  | [optional] 
 **filterInventoryClassID** | **int?**|  | [optional] 
 **filterExcludeItemsInMasterList** | **bool?**|  | [optional] 
 **filterCustomerID** | **int?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
 **filterSearchType** | **int?**|  | [optional] 
 **filterStockTakeID** | **int?**|  | [optional] 
 **filterStartRow** | **int?**|  | [optional] 
 **filterOrderBy** | **string**|  | [optional] 
 **filterIsShowPublishedOnly** | **bool?**|  | [optional] 
 **filterInventoryClassGroupID** | **int?**|  | [optional] 
 **filterInventoryClassGroupTypeID** | **int?**|  | [optional] 
 **filterIncludePickandPackedAssets** | **bool?**|  | [optional] 
 **filterTransID** | **int?**|  | [optional] 
 **filterTransDatTypeID** | **int?**|  | [optional] 
 **filterIsSearchSuppliersCatalog** | **bool?**|  | [optional] 
 **filterInventoryGUID** | [**Guid?**](.md)|  | [optional] 
 **filterIsShowChildVariants** | **bool?**|  | [optional] 
 **filterIsIncludeCategories** | **bool?**|  | [optional] 
 **filterIsShowPostingInventoryOnly** | **bool?**|  | [optional] 
 **filterShowSOHFromWarehouseID** | **int?**|  | [optional] 
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterIsSOHTracked** | **bool?**|  | [optional] 
 **filterViewMode** | **string**|  | [optional] 
 **filterVariantMasterInventoryID** | **int?**|  | [optional] 
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

[**PagedActionResultsOfInventoryItems**](PagedActionResultsOfInventoryItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryunlinkvariantsfrommaster"></a>
# **InventoryUnlinkVariantsFromMaster**
> ActionResults InventoryUnlinkVariantsFromMaster (int? masterInventoryID)



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

            var apiInstance = new InventoryApi();
            var masterInventoryID = 56;  // int? | 

            try
            {
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
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResults**](ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryupdatemedia"></a>
# **InventoryUpdateMedia**
> ActionResults InventoryUpdateMedia (List<MediaFileT> body, int? id)



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

            var apiInstance = new InventoryApi();
            var body = new List<MediaFileT>(); // List<MediaFileT> | 
            var id = 56;  // int? | 

            try
            {
                ActionResults result = apiInstance.InventoryUpdateMedia(body, id);
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

<a name="inventoryuploadmedia"></a>
# **InventoryUploadMedia**
> ActionResultsOfMediaFiles InventoryUploadMedia (int? id)



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

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

[**ActionResultsOfMediaFiles**](ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

