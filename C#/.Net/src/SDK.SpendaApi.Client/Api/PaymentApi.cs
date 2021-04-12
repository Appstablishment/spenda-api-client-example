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
    public interface IPaymentApi
    {
        ActionResults PaymentDelete (int? id);
        PagedActionResultsOfPayments PaymentGet (List<int?> filterStatuses, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID);
        EditResponseOfPaymentT PaymentGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID);
        ActionResults PaymentGetPaymentWithAllocations (int? id);
        ActionResultsOfPaymentT PaymentGetStatus (int? id);
        PagedActionResultsOfPayments PaymentGetV2 (string filterReceiptID, int? filterPOSTerminalID);
        SynkSaveQueueResponseOfPaymentT PaymentPost (SaveRequestOfPaymentT body);
        SynkSaveQueueResponseOfPaymentT PaymentPost (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID);
        SynkSaveQueueResponseOfPaymentT PaymentPostRefund (SaveRequestOfPaymentT body, int? id);
        SynkSaveQueueResponseOfPaymentT PaymentPostRefund (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id);
        SynkSaveQueueResponseOfPaymentT PaymentPut (SaveRequestOfPaymentT body, int? id);
        SynkSaveQueueResponseOfPaymentT PaymentPut (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id);
        ActionResults PaymentSetManualAllocationForAdhocPayments (ActionRequestOfBoolean body, int? id);
        ActionResults PaymentSetManualAllocationForAdhocPayments (bool? value, int? tenantID, int? websiteID, int? userID, int? id);
        ActionResults PaymentUpdateStatus (StatusUpdateRequest body, int? id);
        ActionResults PaymentUpdateStatus (int? ID, int? status, string statusString, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentApi : IPaymentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentApi(String basePath)
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentDelete");
    
            var path = "/api/Payment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterStatuses"></param>
        /// <param name="filterStatusStrings"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterStartDate"></param>
        /// <param name="filterEndDate"></param>
        /// <param name="filterDatePeriod"></param>
        /// <param name="filterIsExactMatch"></param>
        /// <param name="filterIsGetBasicInfo"></param>
        /// <param name="filterIncludeDeleted"></param>
        /// <param name="filterIncludeLogs"></param>
        /// <param name="filterIgnoreID"></param>
        /// <param name="filterParentID"></param>
        /// <param name="filterGetCountOnly"></param>
        /// <param name="filterTransactionTypeDatTypeID"></param>
        /// <returns>PagedActionResultsOfPayments</returns>
        public PagedActionResultsOfPayments PaymentGet (List<int?> filterStatuses, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID)
        {
    
            var path = "/api/Payment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterStatuses != null) queryParams.Add("filter.statuses", ApiClient.ParameterToString(filterStatuses)); // query parameter
 if (filterStatusStrings != null) queryParams.Add("filter.statusStrings", ApiClient.ParameterToString(filterStatusStrings)); // query parameter
 if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
 if (filterStartDate != null) queryParams.Add("filter.startDate", ApiClient.ParameterToString(filterStartDate)); // query parameter
 if (filterEndDate != null) queryParams.Add("filter.endDate", ApiClient.ParameterToString(filterEndDate)); // query parameter
 if (filterDatePeriod != null) queryParams.Add("filter.datePeriod", ApiClient.ParameterToString(filterDatePeriod)); // query parameter
 if (filterIsExactMatch != null) queryParams.Add("filter.isExactMatch", ApiClient.ParameterToString(filterIsExactMatch)); // query parameter
 if (filterIsGetBasicInfo != null) queryParams.Add("filter.isGetBasicInfo", ApiClient.ParameterToString(filterIsGetBasicInfo)); // query parameter
 if (filterIncludeDeleted != null) queryParams.Add("filter.includeDeleted", ApiClient.ParameterToString(filterIncludeDeleted)); // query parameter
 if (filterIncludeLogs != null) queryParams.Add("filter.includeLogs", ApiClient.ParameterToString(filterIncludeLogs)); // query parameter
 if (filterIgnoreID != null) queryParams.Add("filter.ignoreID", ApiClient.ParameterToString(filterIgnoreID)); // query parameter
 if (filterParentID != null) queryParams.Add("filter.parentID", ApiClient.ParameterToString(filterParentID)); // query parameter
 if (filterGetCountOnly != null) queryParams.Add("filter.getCountOnly", ApiClient.ParameterToString(filterGetCountOnly)); // query parameter
 if (filterTransactionTypeDatTypeID != null) queryParams.Add("filter.transactionTypeDatTypeID", ApiClient.ParameterToString(filterTransactionTypeDatTypeID)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PagedActionResultsOfPayments) ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfPayments), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reqID"></param>
        /// <param name="reqGUID"></param>
        /// <param name="reqIsGetExtraInfo"></param>
        /// <param name="reqTenantID"></param>
        /// <param name="reqWebsiteID"></param>
        /// <param name="reqUserID"></param>
        /// <returns>EditResponseOfPaymentT</returns>
        public EditResponseOfPaymentT PaymentGetByID (int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentGetByID");
    
            var path = "/api/Payment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (reqID != null) queryParams.Add("req.iD", ApiClient.ParameterToString(reqID)); // query parameter
 if (reqGUID != null) queryParams.Add("req.gUID", ApiClient.ParameterToString(reqGUID)); // query parameter
 if (reqIsGetExtraInfo != null) queryParams.Add("req.isGetExtraInfo", ApiClient.ParameterToString(reqIsGetExtraInfo)); // query parameter
 if (reqTenantID != null) queryParams.Add("req.tenantID", ApiClient.ParameterToString(reqTenantID)); // query parameter
 if (reqWebsiteID != null) queryParams.Add("req.websiteID", ApiClient.ParameterToString(reqWebsiteID)); // query parameter
 if (reqUserID != null) queryParams.Add("req.userID", ApiClient.ParameterToString(reqUserID)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetByID: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetByID: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EditResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(EditResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentGetPaymentWithAllocations (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentGetPaymentWithAllocations");
    
            var path = "/api/Payment/{id}/allocations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetPaymentWithAllocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetPaymentWithAllocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResultsOfPaymentT</returns>
        public ActionResultsOfPaymentT PaymentGetStatus (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentGetStatus");
    
            var path = "/api/Payment/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResultsOfPaymentT) ApiClient.Deserialize(response.Content, typeof(ActionResultsOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterReceiptID"></param>
        /// <param name="filterPOSTerminalID"></param>
        /// <returns>PagedActionResultsOfPayments</returns>
        public PagedActionResultsOfPayments PaymentGetV2 (string filterReceiptID, int? filterPOSTerminalID)
        {
            // verify the required parameter 'filterReceiptID' is set
            if (filterReceiptID == null) throw new ApiException(400, "Missing required parameter 'filterReceiptID' when calling PaymentGetV2");
    
            var path = "/api/v2/Payment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterReceiptID != null) queryParams.Add("filter.receiptID", ApiClient.ParameterToString(filterReceiptID)); // query parameter
 if (filterPOSTerminalID != null) queryParams.Add("filter.pOSTerminalID", ApiClient.ParameterToString(filterPOSTerminalID)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetV2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentGetV2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PagedActionResultsOfPayments) ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfPayments), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPost (SaveRequestOfPaymentT body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PaymentPost");
    
            var path = "/api/Payment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="_object"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPost (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling PaymentPost");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling PaymentPost");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling PaymentPost");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling PaymentPost");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling PaymentPost");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling PaymentPost");
    
            var path = "/api/Payment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (_object != null) formParams.Add("Object", ApiClient.ParameterToString(_object)); // form parameter
if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter
if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPostRefund (SaveRequestOfPaymentT body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PaymentPostRefund");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentPostRefund");
    
            var path = "/api/Payment/{id}/refund";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPostRefund: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPostRefund: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="_object"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPostRefund (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling PaymentPostRefund");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling PaymentPostRefund");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling PaymentPostRefund");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling PaymentPostRefund");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling PaymentPostRefund");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling PaymentPostRefund");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentPostRefund");
    
            var path = "/api/Payment/{id}/refund";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (_object != null) formParams.Add("Object", ApiClient.ParameterToString(_object)); // form parameter
if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter
if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPostRefund: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPostRefund: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPut (SaveRequestOfPaymentT body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PaymentPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentPut");
    
            var path = "/api/Payment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="_object"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponseOfPaymentT</returns>
        public SynkSaveQueueResponseOfPaymentT PaymentPut (PaymentT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling PaymentPut");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling PaymentPut");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling PaymentPut");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling PaymentPut");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling PaymentPut");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling PaymentPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentPut");
    
            var path = "/api/Payment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (_object != null) formParams.Add("Object", ApiClient.ParameterToString(_object)); // form parameter
if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter
if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SynkSaveQueueResponseOfPaymentT) ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfPaymentT), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentSetManualAllocationForAdhocPayments (ActionRequestOfBoolean body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PaymentSetManualAllocationForAdhocPayments");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentSetManualAllocationForAdhocPayments");
    
            var path = "/api/Payment/{id}/setmanualallocation";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentSetManualAllocationForAdhocPayments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentSetManualAllocationForAdhocPayments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentSetManualAllocationForAdhocPayments (bool? value, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling PaymentSetManualAllocationForAdhocPayments");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling PaymentSetManualAllocationForAdhocPayments");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling PaymentSetManualAllocationForAdhocPayments");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling PaymentSetManualAllocationForAdhocPayments");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentSetManualAllocationForAdhocPayments");
    
            var path = "/api/Payment/{id}/setmanualallocation";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentSetManualAllocationForAdhocPayments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentSetManualAllocationForAdhocPayments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentUpdateStatus (StatusUpdateRequest body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PaymentUpdateStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentUpdateStatus");
    
            var path = "/api/Payment/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentUpdateStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentUpdateStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="status"></param>
        /// <param name="statusString"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults PaymentUpdateStatus (int? ID, int? status, string statusString, int? id)
        {
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling PaymentUpdateStatus");
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling PaymentUpdateStatus");
            // verify the required parameter 'statusString' is set
            if (statusString == null) throw new ApiException(400, "Missing required parameter 'statusString' when calling PaymentUpdateStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentUpdateStatus");
    
            var path = "/api/Payment/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
if (status != null) formParams.Add("Status", ApiClient.ParameterToString(status)); // form parameter
if (statusString != null) formParams.Add("StatusString", ApiClient.ParameterToString(statusString)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentUpdateStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentUpdateStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResults) ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }
    
    }
}
