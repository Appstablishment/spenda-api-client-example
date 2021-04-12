using System;
using System.Collections.Generic;
using RestSharp;
using SDK.SpendaApi.Client.Client;
using SDK.SpendaApi.Client.Model;

namespace SDK.SpendaApi.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInventoryApi
    {
        ActionResults InventoryAutoCreateUnlinkedVariants(int? masterInventoryID);
        ActionResultsOfBoolean InventoryCheckIfAllVariantsCanBeUnlinked(int? masterInventoryID);
        ActionResults InventoryCreateAndLinkVariant(int? masterInventoryID, List<int?> reqVariationOptionIDs);
        Object InventoryDelete(ActionRequestOfInt32 body);
        Object InventoryDelete(int? value, int? tenantID, int? websiteID, int? userID);
        InventoryEditResponse InventoryGet(int? id, int? filterShowSOHFromWarehouseID, int? filterLinkedSupplierID);
        ActionResultsOfInventoryStockOnHandT InventoryGetDetailedSOHV2(int? id);
        ActionResultsOfMediaFiles InventoryGetMedia(int? id);
        ActionResultsOfInventoryItemT InventoryGetVariantTemplate(int? id, List<int?> reqVariationOptionIDs);
        ActionResults InventoryLinkVariant(ActionRequestOfChildVariant body, int? masterInventoryID);
        ActionResults InventoryLinkVariant(ChildVariant value, int? tenantID, int? websiteID, int? userID, int? masterInventoryID);
        SynkSaveQueueResponse InventoryPost(InventorySaveRequest body);
        SynkSaveQueueResponse InventoryPost(int? linkedSupplierID, InventoryItemT suppliersDetails, InventoryItemT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID);
        SynkSaveQueueResponse InventoryPut(InventorySaveRequest body, int? id);
        SynkSaveQueueResponse InventoryPut(int? linkedSupplierID, InventoryItemT suppliersDetails, InventoryItemT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id);
        ActionResultsOfInventoryVariations InventorySaveVariations(ActionRequestOfInventoryVariations body, int? masterInventoryID);
        ActionResultsOfInventoryVariations InventorySaveVariations(List<InventoryVariationT> value, int? tenantID, int? websiteID, int? userID, int? masterInventoryID);
        PagedActionResultsOfInventoryItems InventorySearchT2(int? filterWarehouseID, int? filterInventoryID, int? filterInventoryClassID, int? filterSupplierID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, int? filterVariantMasterInventoryID, string filterSearchString, bool? filterIsExactMatch, bool? filterIncludeDeleted, List<int?> filterBrandIDs, List<int?> filterIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID);
        PagedActionResultsOfInventoryItems InventorySearchUsingBarcode(bool? filterIsPurchased, bool? filterIsSold, string filterSearchString, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService);
        ActionResults InventoryUnlinkVariantsFromMaster(int? masterInventoryID);
        ActionResults InventoryUpdateMedia(List<MediaFileT> body, int? id);
        ActionResultsOfMediaFiles InventoryUploadMedia(int? id);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventoryApi : IInventoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InventoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventoryApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryAutoCreateUnlinkedVariants(int? masterInventoryID)
        {
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryAutoCreateUnlinkedVariants");

            var path = "/api/Inventory/{masterInventoryID}/generatevariants";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryAutoCreateUnlinkedVariants: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryAutoCreateUnlinkedVariants: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResultsOfBoolean</returns>
        public ActionResultsOfBoolean InventoryCheckIfAllVariantsCanBeUnlinked(int? masterInventoryID)
        {
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryCheckIfAllVariantsCanBeUnlinked");

            var path = "/api/Inventory/{masterInventoryID}/canunlink";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryCheckIfAllVariantsCanBeUnlinked: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryCheckIfAllVariantsCanBeUnlinked: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfBoolean)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfBoolean), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="masterInventoryID"></param>
        /// <param name="reqVariationOptionIDs"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryCreateAndLinkVariant(int? masterInventoryID, List<int?> reqVariationOptionIDs)
        {
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryCreateAndLinkVariant");

            var path = "/api/Inventory/{masterInventoryID}/generatevariant";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (reqVariationOptionIDs != null) queryParams.Add("req.variationOptionIDs", ApiClient.ParameterToString(reqVariationOptionIDs)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryCreateAndLinkVariant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryCreateAndLinkVariant: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        public Object InventoryDelete(ActionRequestOfInt32 body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventoryDelete");

            var path = "/api/Inventory/Delete";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryDelete: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <returns>Object</returns>
        public Object InventoryDelete(int? value, int? tenantID, int? websiteID, int? userID)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling InventoryDelete");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InventoryDelete");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InventoryDelete");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InventoryDelete");

            var path = "/api/Inventory/Delete";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (value != null) formParams.Add("Value", ApiClient.ParameterToString(value)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryDelete: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filterShowSOHFromWarehouseID"></param>
        /// <param name="filterLinkedSupplierID"></param>
        /// <returns>InventoryEditResponse</returns>
        public InventoryEditResponse InventoryGet(int? id, int? filterShowSOHFromWarehouseID, int? filterLinkedSupplierID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryGet");

            var path = "/api/Inventory/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterShowSOHFromWarehouseID != null) queryParams.Add("filter.showSOHFromWarehouseID", ApiClient.ParameterToString(filterShowSOHFromWarehouseID)); // query parameter
            if (filterLinkedSupplierID != null) queryParams.Add("filter.linkedSupplierID", ApiClient.ParameterToString(filterLinkedSupplierID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGet: " + response.ErrorMessage, response.ErrorMessage);

            return (InventoryEditResponse)ApiClient.Deserialize(response.Content, typeof(InventoryEditResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResultsOfInventoryStockOnHandT</returns>
        public ActionResultsOfInventoryStockOnHandT InventoryGetDetailedSOHV2(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryGetDetailedSOHV2");

            var path = "/api/v2/Inventory/{id}/stockonhand";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetDetailedSOHV2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetDetailedSOHV2: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfInventoryStockOnHandT)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfInventoryStockOnHandT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResultsOfMediaFiles</returns>
        public ActionResultsOfMediaFiles InventoryGetMedia(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryGetMedia");

            var path = "/api/Inventory/{id}/media";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetMedia: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetMedia: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfMediaFiles)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfMediaFiles), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reqVariationOptionIDs"></param>
        /// <returns>ActionResultsOfInventoryItemT</returns>
        public ActionResultsOfInventoryItemT InventoryGetVariantTemplate(int? id, List<int?> reqVariationOptionIDs)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryGetVariantTemplate");

            var path = "/api/Inventory/{id}/varianttemplate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (reqVariationOptionIDs != null) queryParams.Add("req.variationOptionIDs", ApiClient.ParameterToString(reqVariationOptionIDs)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetVariantTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryGetVariantTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfInventoryItemT)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfInventoryItemT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryLinkVariant(ActionRequestOfChildVariant body, int? masterInventoryID)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventoryLinkVariant");
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryLinkVariant");

            var path = "/api/Inventory/{masterInventoryID}/linkvariant";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryLinkVariant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryLinkVariant: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryLinkVariant(ChildVariant value, int? tenantID, int? websiteID, int? userID, int? masterInventoryID)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling InventoryLinkVariant");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InventoryLinkVariant");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InventoryLinkVariant");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InventoryLinkVariant");
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryLinkVariant");

            var path = "/api/Inventory/{masterInventoryID}/linkvariant";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (value != null) formParams.Add("Value", ApiClient.ParameterToString(value)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryLinkVariant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryLinkVariant: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InventoryPost(InventorySaveRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventoryPost");

            var path = "/api/Inventory";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="linkedSupplierID"></param>
        /// <param name="suppliersDetails"></param>
        /// <param name="_object"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InventoryPost(int? linkedSupplierID, InventoryItemT suppliersDetails, InventoryItemT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID)
        {
            // verify the required parameter 'linkedSupplierID' is set
            if (linkedSupplierID == null) throw new ApiException(400, "Missing required parameter 'linkedSupplierID' when calling InventoryPost");
            // verify the required parameter 'suppliersDetails' is set
            if (suppliersDetails == null) throw new ApiException(400, "Missing required parameter 'suppliersDetails' when calling InventoryPost");
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling InventoryPost");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling InventoryPost");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling InventoryPost");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InventoryPost");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InventoryPost");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InventoryPost");

            var path = "/api/Inventory";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (linkedSupplierID != null) formParams.Add("LinkedSupplierID", ApiClient.ParameterToString(linkedSupplierID)); // form parameter
            if (suppliersDetails != null) formParams.Add("SuppliersDetails", ApiClient.ParameterToString(suppliersDetails)); // form parameter
            if (_object != null) formParams.Add("Object", ApiClient.ParameterToString(_object)); // form parameter
            if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
            if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InventoryPut(InventorySaveRequest body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventoryPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryPut");

            var path = "/api/Inventory/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="linkedSupplierID"></param>
        /// <param name="suppliersDetails"></param>
        /// <param name="_object"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InventoryPut(int? linkedSupplierID, InventoryItemT suppliersDetails, InventoryItemT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter 'linkedSupplierID' is set
            if (linkedSupplierID == null) throw new ApiException(400, "Missing required parameter 'linkedSupplierID' when calling InventoryPut");
            // verify the required parameter 'suppliersDetails' is set
            if (suppliersDetails == null) throw new ApiException(400, "Missing required parameter 'suppliersDetails' when calling InventoryPut");
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling InventoryPut");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling InventoryPut");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling InventoryPut");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InventoryPut");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InventoryPut");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InventoryPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryPut");

            var path = "/api/Inventory/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (linkedSupplierID != null) formParams.Add("LinkedSupplierID", ApiClient.ParameterToString(linkedSupplierID)); // form parameter
            if (suppliersDetails != null) formParams.Add("SuppliersDetails", ApiClient.ParameterToString(suppliersDetails)); // form parameter
            if (_object != null) formParams.Add("Object", ApiClient.ParameterToString(_object)); // form parameter
            if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
            if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryPut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResultsOfInventoryVariations</returns>
        public ActionResultsOfInventoryVariations InventorySaveVariations(ActionRequestOfInventoryVariations body, int? masterInventoryID)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventorySaveVariations");
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventorySaveVariations");

            var path = "/api/Inventory/{masterInventoryID}/variations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySaveVariations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySaveVariations: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfInventoryVariations)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfInventoryVariations), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResultsOfInventoryVariations</returns>
        public ActionResultsOfInventoryVariations InventorySaveVariations(List<InventoryVariationT> value, int? tenantID, int? websiteID, int? userID, int? masterInventoryID)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling InventorySaveVariations");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InventorySaveVariations");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InventorySaveVariations");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InventorySaveVariations");
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventorySaveVariations");

            var path = "/api/Inventory/{masterInventoryID}/variations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (value != null) formParams.Add("Value", ApiClient.ParameterToString(value)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySaveVariations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySaveVariations: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfInventoryVariations)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfInventoryVariations), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterWarehouseID"></param>
        /// <param name="filterInventoryID"></param>
        /// <param name="filterInventoryClassID"></param>
        /// <param name="filterSupplierID"></param>
        /// <param name="filterIsSearchSuppliersCatalog"></param>
        /// <param name="filterInventoryGUID"></param>
        /// <param name="filterIsShowChildVariants"></param>
        /// <param name="filterIsIncludeCategories"></param>
        /// <param name="filterIsShowPostingInventoryOnly"></param>
        /// <param name="filterIsPurchased"></param>
        /// <param name="filterIsSold"></param>
        /// <param name="filterIsSOHTracked"></param>
        /// <param name="filterVariantMasterInventoryID"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterIsExactMatch"></param>
        /// <param name="filterIncludeDeleted"></param>
        /// <param name="filterBrandIDs"></param>
        /// <param name="filterIDs"></param>
        /// <param name="filterLinkedSupplierID"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterIsApprovedForWeb"></param>
        /// <param name="filterIsApprovedForService"></param>
        /// <param name="filterSortField"></param>
        /// <param name="filterGroupBy"></param>
        /// <param name="filterLastRowNumber"></param>
        /// <param name="filterMaxResults"></param>
        /// <param name="filterTenantID"></param>
        /// <returns>PagedActionResultsOfInventoryItems</returns>
        public PagedActionResultsOfInventoryItems InventorySearchT2(int? filterWarehouseID, int? filterInventoryID, int? filterInventoryClassID, int? filterSupplierID, bool? filterIsSearchSuppliersCatalog, Guid? filterInventoryGUID, bool? filterIsShowChildVariants, bool? filterIsIncludeCategories, bool? filterIsShowPostingInventoryOnly, bool? filterIsPurchased, bool? filterIsSold, bool? filterIsSOHTracked, int? filterVariantMasterInventoryID, string filterSearchString, bool? filterIsExactMatch, bool? filterIncludeDeleted, List<int?> filterBrandIDs, List<int?> filterIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID)
        {

            var path = "/api/Inventory";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterWarehouseID != null) queryParams.Add("filter.warehouseID", ApiClient.ParameterToString(filterWarehouseID)); // query parameter
            if (filterInventoryID != null) queryParams.Add("filter.inventoryID", ApiClient.ParameterToString(filterInventoryID)); // query parameter
            if (filterInventoryClassID != null) queryParams.Add("filter.inventoryClassID", ApiClient.ParameterToString(filterInventoryClassID)); // query parameter
            if (filterSupplierID != null) queryParams.Add("filter.supplierID", ApiClient.ParameterToString(filterSupplierID)); // query parameter
            if (filterIsSearchSuppliersCatalog != null) queryParams.Add("filter.isSearchSuppliersCatalog", ApiClient.ParameterToString(filterIsSearchSuppliersCatalog)); // query parameter
            if (filterInventoryGUID != null) queryParams.Add("filter.inventoryGUID", ApiClient.ParameterToString(filterInventoryGUID)); // query parameter
            if (filterIsShowChildVariants != null) queryParams.Add("filter.isShowChildVariants", ApiClient.ParameterToString(filterIsShowChildVariants)); // query parameter
            if (filterIsIncludeCategories != null) queryParams.Add("filter.isIncludeCategories", ApiClient.ParameterToString(filterIsIncludeCategories)); // query parameter
            if (filterIsShowPostingInventoryOnly != null) queryParams.Add("filter.isShowPostingInventoryOnly", ApiClient.ParameterToString(filterIsShowPostingInventoryOnly)); // query parameter
            if (filterIsPurchased != null) queryParams.Add("filter.isPurchased", ApiClient.ParameterToString(filterIsPurchased)); // query parameter
            if (filterIsSold != null) queryParams.Add("filter.isSold", ApiClient.ParameterToString(filterIsSold)); // query parameter
            if (filterIsSOHTracked != null) queryParams.Add("filter.isSOHTracked", ApiClient.ParameterToString(filterIsSOHTracked)); // query parameter
            if (filterVariantMasterInventoryID != null) queryParams.Add("filter.variantMasterInventoryID", ApiClient.ParameterToString(filterVariantMasterInventoryID)); // query parameter
            if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
            if (filterIsExactMatch != null) queryParams.Add("filter.isExactMatch", ApiClient.ParameterToString(filterIsExactMatch)); // query parameter
            if (filterIncludeDeleted != null) queryParams.Add("filter.includeDeleted", ApiClient.ParameterToString(filterIncludeDeleted)); // query parameter
            if (filterBrandIDs != null) queryParams.Add("filter.brandIDs", ApiClient.ParameterToString(filterBrandIDs)); // query parameter
            if (filterIDs != null) queryParams.Add("filter.iDs", ApiClient.ParameterToString(filterIDs)); // query parameter
            if (filterLinkedSupplierID != null) queryParams.Add("filter.linkedSupplierID", ApiClient.ParameterToString(filterLinkedSupplierID)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterIsApprovedForWeb != null) queryParams.Add("filter.isApprovedForWeb", ApiClient.ParameterToString(filterIsApprovedForWeb)); // query parameter
            if (filterIsApprovedForService != null) queryParams.Add("filter.isApprovedForService", ApiClient.ParameterToString(filterIsApprovedForService)); // query parameter
            if (filterSortField != null) queryParams.Add("filter.sortField", ApiClient.ParameterToString(filterSortField)); // query parameter
            if (filterGroupBy != null) queryParams.Add("filter.groupBy", ApiClient.ParameterToString(filterGroupBy)); // query parameter
            if (filterLastRowNumber != null) queryParams.Add("filter.lastRowNumber", ApiClient.ParameterToString(filterLastRowNumber)); // query parameter
            if (filterMaxResults != null) queryParams.Add("filter.maxResults", ApiClient.ParameterToString(filterMaxResults)); // query parameter
            if (filterTenantID != null) queryParams.Add("filter.tenantID", ApiClient.ParameterToString(filterTenantID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySearchT2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySearchT2: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfInventoryItems)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfInventoryItems), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterIsPurchased"></param>
        /// <param name="filterIsSold"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterIncludeDeleted"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterIsApprovedForWeb"></param>
        /// <param name="filterIsApprovedForService"></param>
        /// <returns>PagedActionResultsOfInventoryItems</returns>
        public PagedActionResultsOfInventoryItems InventorySearchUsingBarcode(bool? filterIsPurchased, bool? filterIsSold, string filterSearchString, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService)
        {

            var path = "/api/Inventory/barcode";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterIsPurchased != null) queryParams.Add("filter.isPurchased", ApiClient.ParameterToString(filterIsPurchased)); // query parameter
            if (filterIsSold != null) queryParams.Add("filter.isSold", ApiClient.ParameterToString(filterIsSold)); // query parameter
            if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
            if (filterIncludeDeleted != null) queryParams.Add("filter.includeDeleted", ApiClient.ParameterToString(filterIncludeDeleted)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterIsApprovedForWeb != null) queryParams.Add("filter.isApprovedForWeb", ApiClient.ParameterToString(filterIsApprovedForWeb)); // query parameter
            if (filterIsApprovedForService != null) queryParams.Add("filter.isApprovedForService", ApiClient.ParameterToString(filterIsApprovedForService)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySearchUsingBarcode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventorySearchUsingBarcode: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfInventoryItems)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfInventoryItems), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="masterInventoryID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryUnlinkVariantsFromMaster(int? masterInventoryID)
        {
            // verify the required parameter 'masterInventoryID' is set
            if (masterInventoryID == null) throw new ApiException(400, "Missing required parameter 'masterInventoryID' when calling InventoryUnlinkVariantsFromMaster");

            var path = "/api/Inventory/{masterInventoryID}/unlinkvariants";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "masterInventoryID" + "}", ApiClient.ParameterToString(masterInventoryID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUnlinkVariantsFromMaster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUnlinkVariantsFromMaster: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InventoryUpdateMedia(List<MediaFileT> body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InventoryUpdateMedia");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryUpdateMedia");

            var path = "/api/Inventory/{id}/media";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUpdateMedia: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUpdateMedia: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResultsOfMediaFiles</returns>
        public ActionResultsOfMediaFiles InventoryUploadMedia(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InventoryUploadMedia");

            var path = "/api/Inventory/{id}/media";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUploadMedia: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InventoryUploadMedia: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfMediaFiles)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfMediaFiles), response.Headers);
        }

    }
}
