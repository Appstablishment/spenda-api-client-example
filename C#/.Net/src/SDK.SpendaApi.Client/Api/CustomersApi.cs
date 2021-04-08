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
    public interface ICustomersApi
    {
        ActionResults CustomersAccountExemptFromMerchantSurcharge(int? customerID, bool? isExempt);
        ActionResults CustomersDelete(int? id);    
        PagedActionResultsOfCustomers CustomersGet(bool? filterGetIsValidForBillToOnly, bool? filterIsLinkedCustomersOnly, int? filterCustomerClassID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<string> filterStatus, string filterSearch, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, bool? filterSortAsc, long? filterLastRowNumber, int? filterMaxResults);
        EditResponseOfCustomerT CustomersGetAccountCustomerForOperational(int? id, int? reqCustomerID, int? reqBusinessID, bool? reqIsAutoAddClaimRequests, string reqDebtorCode, bool? reqIsReturnEmptyCustomerIfNotFound, bool? reqIsGetNewTemplate, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID);
        EditResponseOfCustomerT CustomersGetByID(int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID);
        PagedActionResultsOfCustomerBalances CustomersGetCustomersWithUnpaidInvoices(int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List<string> filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID);
        ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge(ActionRequestOfMerchantSurcharge body, int? customerID);
        ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge(MerchantSurcharge value, int? tenantID, int? websiteID, int? userID, int? customerID);
        ActionResultsOfMerchantSurcharge CustomersGetMerchantSurchargeForTransactions(List<RefBusTranT> body, int? customerID, string paymentMethod);
        PagedActionResultsOfCustomers CustomersGetOperationalCustomersForAnAccountCustomer(int? id, bool? filterGetIsValidForBillToOnly, int? filterCreatedByUserID, int? filterCustomerID, bool? filterIsLinkedCustomersOnly, int? filterIgnoreProspectID, int? filterCustomerClassID, int? filterTerritoryID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID);
        ActionResults CustomersLinkCustomer(int? id, int? customerToLinkID);
        SynkSaveQueueResponseOfCustomerT CustomersPost(SaveRequestOfCustomerT body);
        SynkSaveQueueResponseOfCustomerT CustomersPost(CustomerT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID);
        SynkSaveQueueResponseOfCustomerT CustomersPut(SaveRequestOfCustomerT body, int? id);
        SynkSaveQueueResponseOfCustomerT CustomersPut(CustomerT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id);
        ActionResults CustomersSetClass(int? id, int? classID);
        ActionResults CustomersUnlinkCustomer(int? id, int? customerToUnlinkID);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomersApi : ICustomersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomersApi(String basePath)
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
        /// <param name="customerID"></param>
        /// <param name="isExempt"></param>
        /// <returns>ActionResults</returns>
        public ActionResults CustomersAccountExemptFromMerchantSurcharge(int? customerID, bool? isExempt)
        {
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling CustomersAccountExemptFromMerchantSurcharge");

            var path = "/api/Customers/{customerID}/accountexemptfrommerchantsurcharge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customerID" + "}", ApiClient.ParameterToString(customerID));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (isExempt != null) queryParams.Add("IsExempt", ApiClient.ParameterToString(isExempt)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersAccountExemptFromMerchantSurcharge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersAccountExemptFromMerchantSurcharge: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults CustomersDelete(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersDelete");

            var path = "/api/v3/Customers/{id}";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersDelete: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterGetIsValidForBillToOnly"></param>
        /// <param name="filterIsLinkedCustomersOnly"></param>
        /// <param name="filterCustomerClassID"></param>
        /// <param name="filterIsShowAccountCustomersOnly">true - Account Customers only, false - Operational Customers only, not set - Both Customer Types</param>
        /// <param name="filterAccountCustomerID"></param>
        /// <param name="filterIsCODorPrePaidAccountCustomersOnly"></param>
        /// <param name="filterStatus">CustomerStatusTypes - New &#x3D; 0, Active &#x3D; 1, Suspended &#x3D; 2, Declined &#x3D; 3</param>
        /// <param name="filterSearch"></param>
        /// <param name="filterIsExactMatch"></param>
        /// <param name="filterIncludeDeleted"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterIsApprovedForWeb"></param>
        /// <param name="filterIsApprovedForService"></param>
        /// <param name="filterSortField"></param>
        /// <param name="filterSortAsc"></param>
        /// <param name="filterLastRowNumber"></param>
        /// <param name="filterMaxResults"></param>
        /// <returns>PagedActionResultsOfCustomers</returns>
        public PagedActionResultsOfCustomers CustomersGet(bool? filterGetIsValidForBillToOnly, bool? filterIsLinkedCustomersOnly, int? filterCustomerClassID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<string> filterStatus, string filterSearch, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, string filterSortField, bool? filterSortAsc, long? filterLastRowNumber, int? filterMaxResults)
        {

            var path = "/api/v3/Customers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterGetIsValidForBillToOnly != null) queryParams.Add("filter.getIsValidForBillToOnly", ApiClient.ParameterToString(filterGetIsValidForBillToOnly)); // query parameter
            if (filterIsLinkedCustomersOnly != null) queryParams.Add("filter.isLinkedCustomersOnly", ApiClient.ParameterToString(filterIsLinkedCustomersOnly)); // query parameter
            if (filterCustomerClassID != null) queryParams.Add("filter.customerClassID", ApiClient.ParameterToString(filterCustomerClassID)); // query parameter
            if (filterIsShowAccountCustomersOnly != null) queryParams.Add("filter.isShowAccountCustomersOnly", ApiClient.ParameterToString(filterIsShowAccountCustomersOnly)); // query parameter
            if (filterAccountCustomerID != null) queryParams.Add("filter.accountCustomerID", ApiClient.ParameterToString(filterAccountCustomerID)); // query parameter
            if (filterIsCODorPrePaidAccountCustomersOnly != null) queryParams.Add("filter.isCODorPrePaidAccountCustomersOnly", ApiClient.ParameterToString(filterIsCODorPrePaidAccountCustomersOnly)); // query parameter
            if (filterStatus != null) queryParams.Add("filter.status", ApiClient.ParameterToString(filterStatus)); // query parameter
            if (filterSearch != null) queryParams.Add("filter.search", ApiClient.ParameterToString(filterSearch)); // query parameter
            if (filterIsExactMatch != null) queryParams.Add("filter.isExactMatch", ApiClient.ParameterToString(filterIsExactMatch)); // query parameter
            if (filterIncludeDeleted != null) queryParams.Add("filter.includeDeleted", ApiClient.ParameterToString(filterIncludeDeleted)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterIsApprovedForWeb != null) queryParams.Add("filter.isApprovedForWeb", ApiClient.ParameterToString(filterIsApprovedForWeb)); // query parameter
            if (filterIsApprovedForService != null) queryParams.Add("filter.isApprovedForService", ApiClient.ParameterToString(filterIsApprovedForService)); // query parameter
            if (filterSortField != null) queryParams.Add("filter.sortField", ApiClient.ParameterToString(filterSortField)); // query parameter
            if (filterSortAsc != null) queryParams.Add("filter.sortAsc", ApiClient.ParameterToString(filterSortAsc)); // query parameter
            if (filterLastRowNumber != null) queryParams.Add("filter.lastRowNumber", ApiClient.ParameterToString(filterLastRowNumber)); // query parameter
            if (filterMaxResults != null) queryParams.Add("filter.maxResults", ApiClient.ParameterToString(filterMaxResults)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGet: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfCustomers)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfCustomers), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reqCustomerID"></param>
        /// <param name="reqBusinessID"></param>
        /// <param name="reqIsAutoAddClaimRequests"></param>
        /// <param name="reqDebtorCode"></param>
        /// <param name="reqIsReturnEmptyCustomerIfNotFound"></param>
        /// <param name="reqIsGetNewTemplate"></param>
        /// <param name="reqID"></param>
        /// <param name="reqGUID"></param>
        /// <param name="reqIsGetExtraInfo"></param>
        /// <param name="reqTenantID"></param>
        /// <param name="reqWebsiteID"></param>
        /// <param name="reqUserID"></param>
        /// <returns>EditResponseOfCustomerT</returns>
        public EditResponseOfCustomerT CustomersGetAccountCustomerForOperational(int? id, int? reqCustomerID, int? reqBusinessID, bool? reqIsAutoAddClaimRequests, string reqDebtorCode, bool? reqIsReturnEmptyCustomerIfNotFound, bool? reqIsGetNewTemplate, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersGetAccountCustomerForOperational");

            var path = "/api/v3/Customers/{id}/account";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (reqCustomerID != null) queryParams.Add("req.customerID", ApiClient.ParameterToString(reqCustomerID)); // query parameter
            if (reqBusinessID != null) queryParams.Add("req.businessID", ApiClient.ParameterToString(reqBusinessID)); // query parameter
            if (reqIsAutoAddClaimRequests != null) queryParams.Add("req.isAutoAddClaimRequests", ApiClient.ParameterToString(reqIsAutoAddClaimRequests)); // query parameter
            if (reqDebtorCode != null) queryParams.Add("req.debtorCode", ApiClient.ParameterToString(reqDebtorCode)); // query parameter
            if (reqIsReturnEmptyCustomerIfNotFound != null) queryParams.Add("req.isReturnEmptyCustomerIfNotFound", ApiClient.ParameterToString(reqIsReturnEmptyCustomerIfNotFound)); // query parameter
            if (reqIsGetNewTemplate != null) queryParams.Add("req.isGetNewTemplate", ApiClient.ParameterToString(reqIsGetNewTemplate)); // query parameter
            if (reqID != null) queryParams.Add("req.iD", ApiClient.ParameterToString(reqID)); // query parameter
            if (reqGUID != null) queryParams.Add("req.gUID", ApiClient.ParameterToString(reqGUID)); // query parameter
            if (reqIsGetExtraInfo != null) queryParams.Add("req.isGetExtraInfo", ApiClient.ParameterToString(reqIsGetExtraInfo)); // query parameter
            if (reqTenantID != null) queryParams.Add("req.tenantID", ApiClient.ParameterToString(reqTenantID)); // query parameter
            if (reqWebsiteID != null) queryParams.Add("req.websiteID", ApiClient.ParameterToString(reqWebsiteID)); // query parameter
            if (reqUserID != null) queryParams.Add("req.userID", ApiClient.ParameterToString(reqUserID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetAccountCustomerForOperational: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetAccountCustomerForOperational: " + response.ErrorMessage, response.ErrorMessage);

            return (EditResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(EditResponseOfCustomerT), response.Headers);
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
        /// <returns>EditResponseOfCustomerT</returns>
        public EditResponseOfCustomerT CustomersGetByID(int? id, int? reqID, Guid? reqGUID, bool? reqIsGetExtraInfo, int? reqTenantID, int? reqWebsiteID, int? reqUserID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersGetByID");

            var path = "/api/v3/Customers/{id}";
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

            //// authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetByID: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetByID: " + response.ErrorMessage, response.ErrorMessage);

            return (EditResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(EditResponseOfCustomerT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterBusinessID"></param>
        /// <param name="filterCustomerID"></param>
        /// <param name="filterSupplierID"></param>
        /// <param name="filterWarehouseID"></param>
        /// <param name="filterDeliveryMethods"></param>
        /// <param name="filterDatTypes"></param>
        /// <param name="filterMaxExpiresInDays"></param>
        /// <param name="filterRepUserID"></param>
        /// <param name="filterIsCreatedByOtherPartyOnly"></param>
        /// <param name="filterCreatedByUserId"></param>
        /// <param name="filterStatuses"></param>
        /// <param name="filterStatusStrings"></param>
        /// <param name="filterStatus"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterSearch"></param>
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
        /// <param name="filterCategoryID"></param>
        /// <param name="filterAdaptorID"></param>
        /// <param name="filterCategoryIDs"></param>
        /// <param name="filterBrandIDs"></param>
        /// <param name="filterIDs"></param>
        /// <param name="filterGUIDs"></param>
        /// <param name="filterLinkedSupplierID"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterIsApprovedForWeb"></param>
        /// <param name="filterIsApprovedForService"></param>
        /// <param name="filterID"></param>
        /// <param name="filterIsHierarchicalSort"></param>
        /// <param name="filterTypes"></param>
        /// <param name="filterIsShowFavourites"></param>
        /// <param name="filterIsHidden"></param>
        /// <param name="filterIncludeSystemTasks"></param>
        /// <param name="filterIsSystem"></param>
        /// <param name="filterSortField"></param>
        /// <param name="filterSortAsc"></param>
        /// <param name="filterGroupBy"></param>
        /// <param name="filterLastRowNumber"></param>
        /// <param name="filterMaxResults"></param>
        /// <param name="filterTenantID"></param>
        /// <param name="filterWebsiteID"></param>
        /// <param name="filterUserID"></param>
        /// <returns>PagedActionResultsOfCustomerBalances</returns>
        public PagedActionResultsOfCustomerBalances CustomersGetCustomersWithUnpaidInvoices(int? filterBusinessID, int? filterCustomerID, int? filterSupplierID, int? filterWarehouseID, string filterDeliveryMethods, List<string> filterDatTypes, int? filterMaxExpiresInDays, int? filterRepUserID, bool? filterIsCreatedByOtherPartyOnly, int? filterCreatedByUserId, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)
        {

            var path = "/api/Customers/unpaidinvoices";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterBusinessID != null) queryParams.Add("filter.businessID", ApiClient.ParameterToString(filterBusinessID)); // query parameter
            if (filterCustomerID != null) queryParams.Add("filter.customerID", ApiClient.ParameterToString(filterCustomerID)); // query parameter
            if (filterSupplierID != null) queryParams.Add("filter.supplierID", ApiClient.ParameterToString(filterSupplierID)); // query parameter
            if (filterWarehouseID != null) queryParams.Add("filter.warehouseID", ApiClient.ParameterToString(filterWarehouseID)); // query parameter
            if (filterDeliveryMethods != null) queryParams.Add("filter.deliveryMethods", ApiClient.ParameterToString(filterDeliveryMethods)); // query parameter
            if (filterDatTypes != null) queryParams.Add("filter.datTypes", ApiClient.ParameterToString(filterDatTypes)); // query parameter
            if (filterMaxExpiresInDays != null) queryParams.Add("filter.maxExpiresInDays", ApiClient.ParameterToString(filterMaxExpiresInDays)); // query parameter
            if (filterRepUserID != null) queryParams.Add("filter.repUserID", ApiClient.ParameterToString(filterRepUserID)); // query parameter
            if (filterIsCreatedByOtherPartyOnly != null) queryParams.Add("filter.isCreatedByOtherPartyOnly", ApiClient.ParameterToString(filterIsCreatedByOtherPartyOnly)); // query parameter
            if (filterCreatedByUserId != null) queryParams.Add("filter.createdByUserId", ApiClient.ParameterToString(filterCreatedByUserId)); // query parameter
            if (filterStatuses != null) queryParams.Add("filter.statuses", ApiClient.ParameterToString(filterStatuses)); // query parameter
            if (filterStatusStrings != null) queryParams.Add("filter.statusStrings", ApiClient.ParameterToString(filterStatusStrings)); // query parameter
            if (filterStatus != null) queryParams.Add("filter.status", ApiClient.ParameterToString(filterStatus)); // query parameter
            if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
            if (filterSearch != null) queryParams.Add("filter.search", ApiClient.ParameterToString(filterSearch)); // query parameter
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
            if (filterCategoryID != null) queryParams.Add("filter.categoryID", ApiClient.ParameterToString(filterCategoryID)); // query parameter
            if (filterAdaptorID != null) queryParams.Add("filter.adaptorID", ApiClient.ParameterToString(filterAdaptorID)); // query parameter
            if (filterCategoryIDs != null) queryParams.Add("filter.categoryIDs", ApiClient.ParameterToString(filterCategoryIDs)); // query parameter
            if (filterBrandIDs != null) queryParams.Add("filter.brandIDs", ApiClient.ParameterToString(filterBrandIDs)); // query parameter
            if (filterIDs != null) queryParams.Add("filter.iDs", ApiClient.ParameterToString(filterIDs)); // query parameter
            if (filterGUIDs != null) queryParams.Add("filter.gUIDs", ApiClient.ParameterToString(filterGUIDs)); // query parameter
            if (filterLinkedSupplierID != null) queryParams.Add("filter.linkedSupplierID", ApiClient.ParameterToString(filterLinkedSupplierID)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterIsApprovedForWeb != null) queryParams.Add("filter.isApprovedForWeb", ApiClient.ParameterToString(filterIsApprovedForWeb)); // query parameter
            if (filterIsApprovedForService != null) queryParams.Add("filter.isApprovedForService", ApiClient.ParameterToString(filterIsApprovedForService)); // query parameter
            if (filterID != null) queryParams.Add("filter.iD", ApiClient.ParameterToString(filterID)); // query parameter
            if (filterIsHierarchicalSort != null) queryParams.Add("filter.isHierarchicalSort", ApiClient.ParameterToString(filterIsHierarchicalSort)); // query parameter
            if (filterTypes != null) queryParams.Add("filter.types", ApiClient.ParameterToString(filterTypes)); // query parameter
            if (filterIsShowFavourites != null) queryParams.Add("filter.isShowFavourites", ApiClient.ParameterToString(filterIsShowFavourites)); // query parameter
            if (filterIsHidden != null) queryParams.Add("filter.isHidden", ApiClient.ParameterToString(filterIsHidden)); // query parameter
            if (filterIncludeSystemTasks != null) queryParams.Add("filter.includeSystemTasks", ApiClient.ParameterToString(filterIncludeSystemTasks)); // query parameter
            if (filterIsSystem != null) queryParams.Add("filter.isSystem", ApiClient.ParameterToString(filterIsSystem)); // query parameter
            if (filterSortField != null) queryParams.Add("filter.sortField", ApiClient.ParameterToString(filterSortField)); // query parameter
            if (filterSortAsc != null) queryParams.Add("filter.sortAsc", ApiClient.ParameterToString(filterSortAsc)); // query parameter
            if (filterGroupBy != null) queryParams.Add("filter.groupBy", ApiClient.ParameterToString(filterGroupBy)); // query parameter
            if (filterLastRowNumber != null) queryParams.Add("filter.lastRowNumber", ApiClient.ParameterToString(filterLastRowNumber)); // query parameter
            if (filterMaxResults != null) queryParams.Add("filter.maxResults", ApiClient.ParameterToString(filterMaxResults)); // query parameter
            if (filterTenantID != null) queryParams.Add("filter.tenantID", ApiClient.ParameterToString(filterTenantID)); // query parameter
            if (filterWebsiteID != null) queryParams.Add("filter.websiteID", ApiClient.ParameterToString(filterWebsiteID)); // query parameter
            if (filterUserID != null) queryParams.Add("filter.userID", ApiClient.ParameterToString(filterUserID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetCustomersWithUnpaidInvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetCustomersWithUnpaidInvoices: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfCustomerBalances)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfCustomerBalances), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="customerID"></param>
        /// <returns>ActionResultsOfMerchantSurcharge</returns>
        public ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge(ActionRequestOfMerchantSurcharge body, int? customerID)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomersGetMerchantSurcharge");
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling CustomersGetMerchantSurcharge");

            var path = "/api/Customers/{customerID}/merchantsurcharge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customerID" + "}", ApiClient.ParameterToString(customerID));

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
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurcharge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurcharge: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfMerchantSurcharge)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfMerchantSurcharge), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="customerID"></param>
        /// <returns>ActionResultsOfMerchantSurcharge</returns>
        public ActionResultsOfMerchantSurcharge CustomersGetMerchantSurcharge(MerchantSurcharge value, int? tenantID, int? websiteID, int? userID, int? customerID)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling CustomersGetMerchantSurcharge");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling CustomersGetMerchantSurcharge");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling CustomersGetMerchantSurcharge");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling CustomersGetMerchantSurcharge");
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling CustomersGetMerchantSurcharge");

            var path = "/api/Customers/{customerID}/merchantsurcharge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customerID" + "}", ApiClient.ParameterToString(customerID));

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
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurcharge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurcharge: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfMerchantSurcharge)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfMerchantSurcharge), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="customerID"></param>
        /// <param name="paymentMethod"></param>
        /// <returns>ActionResultsOfMerchantSurcharge</returns>
        public ActionResultsOfMerchantSurcharge CustomersGetMerchantSurchargeForTransactions(List<RefBusTranT> body, int? customerID, string paymentMethod)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomersGetMerchantSurchargeForTransactions");
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling CustomersGetMerchantSurchargeForTransactions");
            // verify the required parameter 'paymentMethod' is set
            if (paymentMethod == null) throw new ApiException(400, "Missing required parameter 'paymentMethod' when calling CustomersGetMerchantSurchargeForTransactions");

            var path = "/api/Customers/{customerID}/merchantsurcharge/{paymentMethod}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customerID" + "}", ApiClient.ParameterToString(customerID));
            path = path.Replace("{" + "paymentMethod" + "}", ApiClient.ParameterToString(paymentMethod));

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
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurchargeForTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetMerchantSurchargeForTransactions: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfMerchantSurcharge)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfMerchantSurcharge), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filterGetIsValidForBillToOnly"></param>
        /// <param name="filterCreatedByUserID"></param>
        /// <param name="filterCustomerID"></param>
        /// <param name="filterIsLinkedCustomersOnly"></param>
        /// <param name="filterIgnoreProspectID"></param>
        /// <param name="filterCustomerClassID"></param>
        /// <param name="filterTerritoryID"></param>
        /// <param name="filterIsShowAccountCustomersOnly"></param>
        /// <param name="filterAccountCustomerID"></param>
        /// <param name="filterIsCODorPrePaidAccountCustomersOnly"></param>
        /// <param name="filterStatuses"></param>
        /// <param name="filterStatusStrings"></param>
        /// <param name="filterStatus"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterSearch"></param>
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
        /// <param name="filterCategoryID"></param>
        /// <param name="filterAdaptorID"></param>
        /// <param name="filterCategoryIDs"></param>
        /// <param name="filterBrandIDs"></param>
        /// <param name="filterIDs"></param>
        /// <param name="filterGUIDs"></param>
        /// <param name="filterLinkedSupplierID"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterIsApprovedForWeb"></param>
        /// <param name="filterIsApprovedForService"></param>
        /// <param name="filterID"></param>
        /// <param name="filterIsHierarchicalSort"></param>
        /// <param name="filterTypes"></param>
        /// <param name="filterIsShowFavourites"></param>
        /// <param name="filterIsHidden"></param>
        /// <param name="filterIncludeSystemTasks"></param>
        /// <param name="filterIsSystem"></param>
        /// <param name="filterSortField"></param>
        /// <param name="filterSortAsc"></param>
        /// <param name="filterGroupBy"></param>
        /// <param name="filterLastRowNumber"></param>
        /// <param name="filterMaxResults"></param>
        /// <param name="filterTenantID"></param>
        /// <param name="filterWebsiteID"></param>
        /// <param name="filterUserID"></param>
        /// <returns>PagedActionResultsOfCustomers</returns>
        public PagedActionResultsOfCustomers CustomersGetOperationalCustomersForAnAccountCustomer(int? id, bool? filterGetIsValidForBillToOnly, int? filterCreatedByUserID, int? filterCustomerID, bool? filterIsLinkedCustomersOnly, int? filterIgnoreProspectID, int? filterCustomerClassID, int? filterTerritoryID, bool? filterIsShowAccountCustomersOnly, int? filterAccountCustomerID, bool? filterIsCODorPrePaidAccountCustomersOnly, List<int?> filterStatuses, List<string> filterStatusStrings, List<string> filterStatus, string filterSearchString, string filterSearch, DateTime? filterStartDate, DateTime? filterEndDate, string filterDatePeriod, bool? filterIsExactMatch, bool? filterIsGetBasicInfo, bool? filterIncludeDeleted, bool? filterIncludeLogs, int? filterIgnoreID, int? filterParentID, bool? filterGetCountOnly, int? filterTransactionTypeDatTypeID, int? filterCategoryID, int? filterAdaptorID, List<int?> filterCategoryIDs, List<int?> filterBrandIDs, List<int?> filterIDs, List<string> filterGUIDs, int? filterLinkedSupplierID, bool? filterIsApprovedForPOS, bool? filterIsApprovedForWeb, bool? filterIsApprovedForService, int? filterID, bool? filterIsHierarchicalSort, List<string> filterTypes, bool? filterIsShowFavourites, bool? filterIsHidden, bool? filterIncludeSystemTasks, bool? filterIsSystem, string filterSortField, bool? filterSortAsc, string filterGroupBy, long? filterLastRowNumber, int? filterMaxResults, int? filterTenantID, int? filterWebsiteID, int? filterUserID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersGetOperationalCustomersForAnAccountCustomer");

            var path = "/api/v3/Customers/{id}/operational";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterGetIsValidForBillToOnly != null) queryParams.Add("filter.getIsValidForBillToOnly", ApiClient.ParameterToString(filterGetIsValidForBillToOnly)); // query parameter
            if (filterCreatedByUserID != null) queryParams.Add("filter.createdByUserID", ApiClient.ParameterToString(filterCreatedByUserID)); // query parameter
            if (filterCustomerID != null) queryParams.Add("filter.customerID", ApiClient.ParameterToString(filterCustomerID)); // query parameter
            if (filterIsLinkedCustomersOnly != null) queryParams.Add("filter.isLinkedCustomersOnly", ApiClient.ParameterToString(filterIsLinkedCustomersOnly)); // query parameter
            if (filterIgnoreProspectID != null) queryParams.Add("filter.ignoreProspectID", ApiClient.ParameterToString(filterIgnoreProspectID)); // query parameter
            if (filterCustomerClassID != null) queryParams.Add("filter.customerClassID", ApiClient.ParameterToString(filterCustomerClassID)); // query parameter
            if (filterTerritoryID != null) queryParams.Add("filter.territoryID", ApiClient.ParameterToString(filterTerritoryID)); // query parameter
            if (filterIsShowAccountCustomersOnly != null) queryParams.Add("filter.isShowAccountCustomersOnly", ApiClient.ParameterToString(filterIsShowAccountCustomersOnly)); // query parameter
            if (filterAccountCustomerID != null) queryParams.Add("filter.accountCustomerID", ApiClient.ParameterToString(filterAccountCustomerID)); // query parameter
            if (filterIsCODorPrePaidAccountCustomersOnly != null) queryParams.Add("filter.isCODorPrePaidAccountCustomersOnly", ApiClient.ParameterToString(filterIsCODorPrePaidAccountCustomersOnly)); // query parameter
            if (filterStatuses != null) queryParams.Add("filter.statuses", ApiClient.ParameterToString(filterStatuses)); // query parameter
            if (filterStatusStrings != null) queryParams.Add("filter.statusStrings", ApiClient.ParameterToString(filterStatusStrings)); // query parameter
            if (filterStatus != null) queryParams.Add("filter.status", ApiClient.ParameterToString(filterStatus)); // query parameter
            if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
            if (filterSearch != null) queryParams.Add("filter.search", ApiClient.ParameterToString(filterSearch)); // query parameter
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
            if (filterCategoryID != null) queryParams.Add("filter.categoryID", ApiClient.ParameterToString(filterCategoryID)); // query parameter
            if (filterAdaptorID != null) queryParams.Add("filter.adaptorID", ApiClient.ParameterToString(filterAdaptorID)); // query parameter
            if (filterCategoryIDs != null) queryParams.Add("filter.categoryIDs", ApiClient.ParameterToString(filterCategoryIDs)); // query parameter
            if (filterBrandIDs != null) queryParams.Add("filter.brandIDs", ApiClient.ParameterToString(filterBrandIDs)); // query parameter
            if (filterIDs != null) queryParams.Add("filter.iDs", ApiClient.ParameterToString(filterIDs)); // query parameter
            if (filterGUIDs != null) queryParams.Add("filter.gUIDs", ApiClient.ParameterToString(filterGUIDs)); // query parameter
            if (filterLinkedSupplierID != null) queryParams.Add("filter.linkedSupplierID", ApiClient.ParameterToString(filterLinkedSupplierID)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterIsApprovedForWeb != null) queryParams.Add("filter.isApprovedForWeb", ApiClient.ParameterToString(filterIsApprovedForWeb)); // query parameter
            if (filterIsApprovedForService != null) queryParams.Add("filter.isApprovedForService", ApiClient.ParameterToString(filterIsApprovedForService)); // query parameter
            if (filterID != null) queryParams.Add("filter.iD", ApiClient.ParameterToString(filterID)); // query parameter
            if (filterIsHierarchicalSort != null) queryParams.Add("filter.isHierarchicalSort", ApiClient.ParameterToString(filterIsHierarchicalSort)); // query parameter
            if (filterTypes != null) queryParams.Add("filter.types", ApiClient.ParameterToString(filterTypes)); // query parameter
            if (filterIsShowFavourites != null) queryParams.Add("filter.isShowFavourites", ApiClient.ParameterToString(filterIsShowFavourites)); // query parameter
            if (filterIsHidden != null) queryParams.Add("filter.isHidden", ApiClient.ParameterToString(filterIsHidden)); // query parameter
            if (filterIncludeSystemTasks != null) queryParams.Add("filter.includeSystemTasks", ApiClient.ParameterToString(filterIncludeSystemTasks)); // query parameter
            if (filterIsSystem != null) queryParams.Add("filter.isSystem", ApiClient.ParameterToString(filterIsSystem)); // query parameter
            if (filterSortField != null) queryParams.Add("filter.sortField", ApiClient.ParameterToString(filterSortField)); // query parameter
            if (filterSortAsc != null) queryParams.Add("filter.sortAsc", ApiClient.ParameterToString(filterSortAsc)); // query parameter
            if (filterGroupBy != null) queryParams.Add("filter.groupBy", ApiClient.ParameterToString(filterGroupBy)); // query parameter
            if (filterLastRowNumber != null) queryParams.Add("filter.lastRowNumber", ApiClient.ParameterToString(filterLastRowNumber)); // query parameter
            if (filterMaxResults != null) queryParams.Add("filter.maxResults", ApiClient.ParameterToString(filterMaxResults)); // query parameter
            if (filterTenantID != null) queryParams.Add("filter.tenantID", ApiClient.ParameterToString(filterTenantID)); // query parameter
            if (filterWebsiteID != null) queryParams.Add("filter.websiteID", ApiClient.ParameterToString(filterWebsiteID)); // query parameter
            if (filterUserID != null) queryParams.Add("filter.userID", ApiClient.ParameterToString(filterUserID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetOperationalCustomersForAnAccountCustomer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersGetOperationalCustomersForAnAccountCustomer: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfCustomers)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfCustomers), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerToLinkID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults CustomersLinkCustomer(int? id, int? customerToLinkID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersLinkCustomer");
            // verify the required parameter 'customerToLinkID' is set
            if (customerToLinkID == null) throw new ApiException(400, "Missing required parameter 'customerToLinkID' when calling CustomersLinkCustomer");

            var path = "/api/v3/Customers/{id}/link";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (customerToLinkID != null) queryParams.Add("customerToLinkID", ApiClient.ParameterToString(customerToLinkID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersLinkCustomer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersLinkCustomer: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SynkSaveQueueResponseOfCustomerT</returns>
        public SynkSaveQueueResponseOfCustomerT CustomersPost(SaveRequestOfCustomerT body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomersPost");

            var path = "/api/v3/Customers";
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
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfCustomerT), response.Headers);
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
        /// <returns>SynkSaveQueueResponseOfCustomerT</returns>
        public SynkSaveQueueResponseOfCustomerT CustomersPost(CustomerT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling CustomersPost");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling CustomersPost");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling CustomersPost");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling CustomersPost");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling CustomersPost");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling CustomersPost");

            var path = "/api/v3/Customers";
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
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfCustomerT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponseOfCustomerT</returns>
        public SynkSaveQueueResponseOfCustomerT CustomersPut(SaveRequestOfCustomerT body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomersPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersPut");

            var path = "/api/v3/Customers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfCustomerT), response.Headers);
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
        /// <returns>SynkSaveQueueResponseOfCustomerT</returns>
        public SynkSaveQueueResponseOfCustomerT CustomersPut(CustomerT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling CustomersPut");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling CustomersPut");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling CustomersPut");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling CustomersPut");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling CustomersPut");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling CustomersPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersPut");

            var path = "/api/v3/Customers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
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
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersPut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponseOfCustomerT)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponseOfCustomerT), response.Headers);
        }

        public ActionResults CustomersSetClass(int? id, int? classID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersSetClass");
            // verify the required parameter 'classID' is set
            if (classID == null) throw new ApiException(400, "Missing required parameter 'classID' when calling CustomersSetClass");

            var path = "/api/v3/Customers/{id}/class";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (classID != null) queryParams.Add("classID", ApiClient.ParameterToString(classID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersSetClass: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersSetClass: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerToUnlinkID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults CustomersUnlinkCustomer(int? id, int? customerToUnlinkID)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomersUnlinkCustomer");
            // verify the required parameter 'customerToUnlinkID' is set
            if (customerToUnlinkID == null) throw new ApiException(400, "Missing required parameter 'customerToUnlinkID' when calling CustomersUnlinkCustomer");

            var path = "/api/v3/Customers/{id}/unlink";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (customerToUnlinkID != null) queryParams.Add("customerToUnlinkID", ApiClient.ParameterToString(customerToUnlinkID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersUnlinkCustomer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CustomersUnlinkCustomer: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

    }
}
