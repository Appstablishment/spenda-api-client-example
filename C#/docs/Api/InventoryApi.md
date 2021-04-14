# SDK.SpendaApi.Client.Api.InventoryApi

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
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResults**](../Models/ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorycheckifallvariantscanbeunlinked"></a>
# **InventoryCheckIfAllVariantsCanBeUnlinked**
> ActionResultsOfBoolean InventoryCheckIfAllVariantsCanBeUnlinked (int? masterInventoryID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResultsOfBoolean**](../Models/ActionResultsOfBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorycreateandlinkvariant"></a>
# **InventoryCreateAndLinkVariant**
> ActionResults InventoryCreateAndLinkVariant (int? masterInventoryID, List<int?> reqVariationOptionIDs)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResults**](../Models/ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorydelete"></a>
# **InventoryDelete**
> Object InventoryDelete (ActionRequestOfInt32 body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**ActionRequestOfInt32**](../Models/ActionRequestOfInt32.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventoryget"></a>
# **InventoryGet**
> InventoryEditResponse InventoryGet (int? id, int? filterShowSOHFromWarehouseID, int? filterLinkedSupplierID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InventoryGetExample
    {
        public void main()
        {

            var apiInstance = new InventoryApi();
            var id = 56;  // int? | 
            var filterShowSOHFromWarehouseID = 56;  // int? |  (optional) 
            var filterLinkedSupplierID = 56;  // int? |  (optional) 

            try
            {
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
 **id** | **int?**|  | 
 **filterShowSOHFromWarehouseID** | **int?**|  | [optional] 
 **filterLinkedSupplierID** | **int?**|  | [optional] 

### Return type

[**InventoryEditResponse**](../Models/InventoryEditResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorygetdetailedsohv2"></a>
# **InventoryGetDetailedSOHV2**
> ActionResultsOfInventoryStockOnHandT InventoryGetDetailedSOHV2 (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResultsOfInventoryStockOnHandT**](../Models/ActionResultsOfInventoryStockOnHandT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorygetmedia"></a>
# **InventoryGetMedia**
> ActionResultsOfMediaFiles InventoryGetMedia (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResultsOfMediaFiles**](../Models/ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorygetvarianttemplate"></a>
# **InventoryGetVariantTemplate**
> ActionResultsOfInventoryItemT InventoryGetVariantTemplate (int? id, List<int?> reqVariationOptionIDs)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResultsOfInventoryItemT**](../Models/ActionResultsOfInventoryItemT.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorylinkvariant"></a>
# **InventoryLinkVariant**
> ActionResults InventoryLinkVariant (ActionRequestOfChildVariant body, int? masterInventoryID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**ActionRequestOfChildVariant**](../Models/ActionRequestOfChildVariant.md)|  | 
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResults**](../Models/ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorypost"></a>
# **InventoryPost**
> SynkSaveQueueResponse InventoryPost (InventorySaveRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**InventorySaveRequest**](../Models/InventorySaveRequest.md)|  | 

### Return type

[**SynkSaveQueueResponse**](../Models/SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventoryput"></a>
# **InventoryPut**
> SynkSaveQueueResponse InventoryPut (InventorySaveRequest body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**InventorySaveRequest**](../Models/InventorySaveRequest.md)|  | 
 **id** | **int?**|  | 

### Return type

[**SynkSaveQueueResponse**](../Models/SynkSaveQueueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorysavevariations"></a>
# **InventorySaveVariations**
> ActionResultsOfInventoryVariations InventorySaveVariations (ActionRequestOfInventoryVariations body, int? masterInventoryID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**ActionRequestOfInventoryVariations**](../Models/ActionRequestOfInventoryVariations.md)|  | 
 **masterInventoryID** | **int?**|  | 

### Return type

[**ActionResultsOfInventoryVariations**](../Models/ActionResultsOfInventoryVariations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorysearcht2"></a>
# **InventorySearchT2**
> PagedActionResultsOfInventoryItems InventorySearchT2 (int? filterWarehouseID, int? filterInventoryID, int? filterInventoryClassID, int? filterSupplierID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, int? filterVariantMasterInventoryID, string filterSearchString, bool? filterIsExactMatch, bool? filterIncludeDeleted, List<int?> filterBrandIDs, List<int?> filterIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InventorySearchT2Example
    {
        public void main()
        {

            var apiInstance = new InventoryApi();
            var filterWarehouseID = 56;  // int? |  (optional) 
            var filterInventoryID = 56;  // int? |  (optional) 
            var filterInventoryClassID = 56;  // int? |  (optional) 
            var filterSupplierID = 56;  // int? |  (optional) 
            var filterIsSearchSuppliersCatalog = true;  // bool? |  (optional) 
            var filterInventoryGUID = new Guid?(); // Guid? |  (optional) 
            var filterIsShowChildVariants = true;  // bool? |  (optional) 
            var filterIsIncludeCategories = true;  // bool? |  (optional) 
            var filterIsShowPostingInventoryOnly = true;  // bool? |  (optional) 
            var filterIsPurchased = true;  // bool? |  (optional) 
            var filterIsSold = true;  // bool? |  (optional) 
            var filterIsSOHTracked = true;  // bool? |  (optional) 
            var filterVariantMasterInventoryID = 56;  // int? |  (optional) 
            var filterSearchString = filterSearchString_example;  // string |  (optional) 
            var filterIsExactMatch = true;  // bool? |  (optional) 
            var filterIncludeDeleted = true;  // bool? |  (optional) 
            var filterBrandIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterIDs = new List<int?>(); // List<int?> |  (optional) 
            var filterLinkedSupplierID = 56;  // int? |  (optional) 
            var filterIsApprovedForPOS = true;  // bool? |  (optional) 
            var filterIsApprovedForWeb = true;  // bool? |  (optional) 
            var filterIsApprovedForService = true;  // bool? |  (optional) 
            var filterSortField = filterSortField_example;  // string |  (optional) 
            var filterGroupBy = filterGroupBy_example;  // string |  (optional) 
            var filterLastRowNumber = 789;  // long? |  (optional) 
            var filterMaxResults = 56;  // int? |  (optional) 
            var filterTenantID = 56;  // int? |  (optional) 

            try
            {
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
 **filterWarehouseID** | **int?**|  | [optional] 
 **filterInventoryID** | **int?**|  | [optional] 
 **filterInventoryClassID** | **int?**|  | [optional] 
 **filterSupplierID** | **int?**|  | [optional] 
 **filterIsSearchSuppliersCatalog** | **bool?**|  | [optional] 
 **filterInventoryGUID** | [**Guid?**](.md)|  | [optional] 
 **filterIsShowChildVariants** | **bool?**|  | [optional] 
 **filterIsIncludeCategories** | **bool?**|  | [optional] 
 **filterIsShowPostingInventoryOnly** | **bool?**|  | [optional] 
 **filterIsPurchased** | **bool?**|  | [optional] 
 **filterIsSold** | **bool?**|  | [optional] 
 **filterIsSOHTracked** | **bool?**|  | [optional] 
 **filterVariantMasterInventoryID** | **int?**|  | [optional] 
 **filterSearchString** | **string**|  | [optional] 
 **filterIsExactMatch** | **bool?**|  | [optional] 
 **filterIncludeDeleted** | **bool?**|  | [optional] 
 **filterBrandIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterIDs** | [**List<int?>**](int?.md)|  | [optional] 
 **filterLinkedSupplierID** | **int?**|  | [optional] 
 **filterIsApprovedForPOS** | **bool?**|  | [optional] 
 **filterIsApprovedForWeb** | **bool?**|  | [optional] 
 **filterIsApprovedForService** | **bool?**|  | [optional] 
 **filterSortField** | **string**|  | [optional] 
 **filterGroupBy** | **string**|  | [optional] 
 **filterLastRowNumber** | **long?**|  | [optional] 
 **filterMaxResults** | **int?**|  | [optional] 
 **filterTenantID** | **int?**|  | [optional] 

### Return type

[**PagedActionResultsOfInventoryItems**](../Models/PagedActionResultsOfInventoryItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventorysearchusingbarcode"></a>
# **InventorySearchUsingBarcode**
> PagedActionResultsOfInventoryItems InventorySearchUsingBarcode (bool? filterIsPurchased, bool? filterIsSold, string filterSearchString, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
{
    public class InventorySearchUsingBarcodeExample
    {
        public void main()
        {

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

[**PagedActionResultsOfInventoryItems**](../Models/PagedActionResultsOfInventoryItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventoryunlinkvariantsfrommaster"></a>
# **InventoryUnlinkVariantsFromMaster**
> ActionResults InventoryUnlinkVariantsFromMaster (int? masterInventoryID)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResults**](../Models/ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventoryupdatemedia"></a>
# **InventoryUpdateMedia**
> ActionResults InventoryUpdateMedia (List<MediaFileT> body, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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
 **body** | [**List<MediaFileT>**](../Models/MediaFileT.md)|  | 
 **id** | **int?**|  | 

### Return type

[**ActionResults**](../Models/ActionResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

<a name="inventoryuploadmedia"></a>
# **InventoryUploadMedia**
> ActionResultsOfMediaFiles InventoryUploadMedia (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using SDK.SpendaApi.Client.Api;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client
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

[**ActionResultsOfMediaFiles**](../Models/ActionResultsOfMediaFiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../Api) [[Back to Model list]](../Models) [[Back to README]](../README.md)

