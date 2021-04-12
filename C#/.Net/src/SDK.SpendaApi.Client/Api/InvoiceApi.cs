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
    public interface IInvoiceApi
    {
        AddLinesResponseOfInvoiceT InvoiceAddLines(AddLinesRequest body, int? id);
        AddLinesResponseOfInvoiceT InvoiceAddLines(string discountMode, double? discount, List<BusTransLineT> lines, bool? isOverridingLines, string refTransRefNumber, List<RefBusTranT> refBusTrans, double? totalRefund, string lineSort, bool? isLineSortDesc, bool? isGetMessages, int? customerID, int? supplierID, bool? isPriceRefresh, SearchFilter lineSearchFilter, bool? isExcludeFailedPayments, int? ID, Guid? GUID, bool? isGetExtraInfo, int? tenantID, int? websiteID, int? userID, int? id);
        AddLinesResponseOfInvoiceT InvoiceAddLinesPreview(AddLinesRequest body, int? id);
        AddLinesResponseOfInvoiceT InvoiceAddLinesPreview(string discountMode, double? discount, List<BusTransLineT> lines, bool? isOverridingLines, string refTransRefNumber, List<RefBusTranT> refBusTrans, double? totalRefund, string lineSort, bool? isLineSortDesc, bool? isGetMessages, int? customerID, int? supplierID, bool? isPriceRefresh, SearchFilter lineSearchFilter, bool? isExcludeFailedPayments, int? ID, Guid? GUID, bool? isGetExtraInfo, int? tenantID, int? websiteID, int? userID, int? id);
        ActionResults InvoiceDelete(int? id);
        ActionResults InvoiceDeleteAttachment(BusTransAttachmentT body);
        ActionResults InvoiceDeleteAttachment(Guid? GUID, string title, bool? isImage, bool? isPDF, int? ID, string gUIDstring, int? messageID, string URI, int? attachedByUserID, DateTime? attachedDateTimeUtc, bool? isActive, string caption, string thumbnailURI, string attachmentType, bool? isFromParent, int? lineID);
        PagedActionResultsOfBusTransSearchResultsT InvoiceGet(int? filterCustomerID, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, string filterSortField);
        TransactionEditResponseOfInvoiceT InvoiceGetByID(int? id);
        ActionResultsOfBusTransMessages InvoiceGetMessages(int? id);
        SynkSaveQueueResponse InvoicePost(TransactionSaveRequestOfInvoiceT body);
        SynkSaveQueueResponse InvoicePost(InvoiceT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID);
        SynkSaveQueueResponse InvoicePut(TransactionSaveRequestOfInvoiceT body, int? id);
        SynkSaveQueueResponse InvoicePut(InvoiceT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id);
        List<FileDetails> InvoiceSaveAttachments();
        ActionResults InvoiceSendMessage(BusTransMessageT body, int? id);
        ActionResults InvoiceSendMessage(Guid? GUID, int? ID, string gUIDstring, int? transID, string message, bool? isInbound, int? toUserID, int? fromUserID, DateTime? sentDateTimeUtc, DateTime? receivedDateTimeUtc, DateTime? readDateTimeUtc, bool? isActive, bool? isSystemMessage, bool? isFromParent, List<BusTransAttachmentT> attachments, int? id);
        ActionResults InvoiceUpdateStatus(UpdateTransStatusRequest body, int? id);
        ActionResults InvoiceUpdateStatus(int? ID, string status, string statusUpdateReason, bool? isQueue, bool? isSaveAutoQueue, int? id);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceApi : IInvoiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoiceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceApi(String basePath)
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
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>AddLinesResponseOfInvoiceT</returns>
        public AddLinesResponseOfInvoiceT InvoiceAddLines(AddLinesRequest body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceAddLines");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceAddLines");

            var path = "/api/Invoice/{id}/lines";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLines: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLines: " + response.ErrorMessage, response.ErrorMessage);

            return (AddLinesResponseOfInvoiceT)ApiClient.Deserialize(response.Content, typeof(AddLinesResponseOfInvoiceT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="discountMode"></param>
        /// <param name="discount"></param>
        /// <param name="lines"></param>
        /// <param name="isOverridingLines"></param>
        /// <param name="refTransRefNumber"></param>
        /// <param name="refBusTrans"></param>
        /// <param name="totalRefund"></param>
        /// <param name="lineSort"></param>
        /// <param name="isLineSortDesc"></param>
        /// <param name="isGetMessages"></param>
        /// <param name="customerID"></param>
        /// <param name="supplierID"></param>
        /// <param name="isPriceRefresh"></param>
        /// <param name="lineSearchFilter"></param>
        /// <param name="isExcludeFailedPayments"></param>
        /// <param name="ID"></param>
        /// <param name="GUID"></param>
        /// <param name="isGetExtraInfo"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>AddLinesResponseOfInvoiceT</returns>
        public AddLinesResponseOfInvoiceT InvoiceAddLines(string discountMode, double? discount, List<BusTransLineT> lines, bool? isOverridingLines, string refTransRefNumber, List<RefBusTranT> refBusTrans, double? totalRefund, string lineSort, bool? isLineSortDesc, bool? isGetMessages, int? customerID, int? supplierID, bool? isPriceRefresh, SearchFilter lineSearchFilter, bool? isExcludeFailedPayments, int? ID, Guid? GUID, bool? isGetExtraInfo, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter 'discountMode' is set
            if (discountMode == null) throw new ApiException(400, "Missing required parameter 'discountMode' when calling InvoiceAddLines");
            // verify the required parameter 'discount' is set
            if (discount == null) throw new ApiException(400, "Missing required parameter 'discount' when calling InvoiceAddLines");
            // verify the required parameter 'lines' is set
            if (lines == null) throw new ApiException(400, "Missing required parameter 'lines' when calling InvoiceAddLines");
            // verify the required parameter 'isOverridingLines' is set
            if (isOverridingLines == null) throw new ApiException(400, "Missing required parameter 'isOverridingLines' when calling InvoiceAddLines");
            // verify the required parameter 'refTransRefNumber' is set
            if (refTransRefNumber == null) throw new ApiException(400, "Missing required parameter 'refTransRefNumber' when calling InvoiceAddLines");
            // verify the required parameter 'refBusTrans' is set
            if (refBusTrans == null) throw new ApiException(400, "Missing required parameter 'refBusTrans' when calling InvoiceAddLines");
            // verify the required parameter 'totalRefund' is set
            if (totalRefund == null) throw new ApiException(400, "Missing required parameter 'totalRefund' when calling InvoiceAddLines");
            // verify the required parameter 'lineSort' is set
            if (lineSort == null) throw new ApiException(400, "Missing required parameter 'lineSort' when calling InvoiceAddLines");
            // verify the required parameter 'isLineSortDesc' is set
            if (isLineSortDesc == null) throw new ApiException(400, "Missing required parameter 'isLineSortDesc' when calling InvoiceAddLines");
            // verify the required parameter 'isGetMessages' is set
            if (isGetMessages == null) throw new ApiException(400, "Missing required parameter 'isGetMessages' when calling InvoiceAddLines");
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling InvoiceAddLines");
            // verify the required parameter 'supplierID' is set
            if (supplierID == null) throw new ApiException(400, "Missing required parameter 'supplierID' when calling InvoiceAddLines");
            // verify the required parameter 'isPriceRefresh' is set
            if (isPriceRefresh == null) throw new ApiException(400, "Missing required parameter 'isPriceRefresh' when calling InvoiceAddLines");
            // verify the required parameter 'lineSearchFilter' is set
            if (lineSearchFilter == null) throw new ApiException(400, "Missing required parameter 'lineSearchFilter' when calling InvoiceAddLines");
            // verify the required parameter 'isExcludeFailedPayments' is set
            if (isExcludeFailedPayments == null) throw new ApiException(400, "Missing required parameter 'isExcludeFailedPayments' when calling InvoiceAddLines");
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling InvoiceAddLines");
            // verify the required parameter 'GUID' is set
            if (GUID == null) throw new ApiException(400, "Missing required parameter 'GUID' when calling InvoiceAddLines");
            // verify the required parameter 'isGetExtraInfo' is set
            if (isGetExtraInfo == null) throw new ApiException(400, "Missing required parameter 'isGetExtraInfo' when calling InvoiceAddLines");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InvoiceAddLines");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InvoiceAddLines");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InvoiceAddLines");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceAddLines");

            var path = "/api/Invoice/{id}/lines";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (discountMode != null) formParams.Add("DiscountMode", ApiClient.ParameterToString(discountMode)); // form parameter
            if (discount != null) formParams.Add("Discount", ApiClient.ParameterToString(discount)); // form parameter
            if (lines != null) formParams.Add("Lines", ApiClient.ParameterToString(lines)); // form parameter
            if (isOverridingLines != null) formParams.Add("IsOverridingLines", ApiClient.ParameterToString(isOverridingLines)); // form parameter
            if (refTransRefNumber != null) formParams.Add("RefTransRefNumber", ApiClient.ParameterToString(refTransRefNumber)); // form parameter
            if (refBusTrans != null) formParams.Add("RefBusTrans", ApiClient.ParameterToString(refBusTrans)); // form parameter
            if (totalRefund != null) formParams.Add("TotalRefund", ApiClient.ParameterToString(totalRefund)); // form parameter
            if (lineSort != null) formParams.Add("LineSort", ApiClient.ParameterToString(lineSort)); // form parameter
            if (isLineSortDesc != null) formParams.Add("IsLineSortDesc", ApiClient.ParameterToString(isLineSortDesc)); // form parameter
            if (isGetMessages != null) formParams.Add("IsGetMessages", ApiClient.ParameterToString(isGetMessages)); // form parameter
            if (customerID != null) formParams.Add("CustomerID", ApiClient.ParameterToString(customerID)); // form parameter
            if (supplierID != null) formParams.Add("SupplierID", ApiClient.ParameterToString(supplierID)); // form parameter
            if (isPriceRefresh != null) formParams.Add("IsPriceRefresh", ApiClient.ParameterToString(isPriceRefresh)); // form parameter
            if (lineSearchFilter != null) formParams.Add("LineSearchFilter", ApiClient.ParameterToString(lineSearchFilter)); // form parameter
            if (isExcludeFailedPayments != null) formParams.Add("IsExcludeFailedPayments", ApiClient.ParameterToString(isExcludeFailedPayments)); // form parameter
            if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
            if (GUID != null) formParams.Add("GUID", ApiClient.ParameterToString(GUID)); // form parameter
            if (isGetExtraInfo != null) formParams.Add("IsGetExtraInfo", ApiClient.ParameterToString(isGetExtraInfo)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLines: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLines: " + response.ErrorMessage, response.ErrorMessage);

            return (AddLinesResponseOfInvoiceT)ApiClient.Deserialize(response.Content, typeof(AddLinesResponseOfInvoiceT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>AddLinesResponseOfInvoiceT</returns>
        public AddLinesResponseOfInvoiceT InvoiceAddLinesPreview(AddLinesRequest body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceAddLinesPreview");

            var path = "/api/Invoice/{id}/lines";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLinesPreview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLinesPreview: " + response.ErrorMessage, response.ErrorMessage);

            return (AddLinesResponseOfInvoiceT)ApiClient.Deserialize(response.Content, typeof(AddLinesResponseOfInvoiceT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="discountMode"></param>
        /// <param name="discount"></param>
        /// <param name="lines"></param>
        /// <param name="isOverridingLines"></param>
        /// <param name="refTransRefNumber"></param>
        /// <param name="refBusTrans"></param>
        /// <param name="totalRefund"></param>
        /// <param name="lineSort"></param>
        /// <param name="isLineSortDesc"></param>
        /// <param name="isGetMessages"></param>
        /// <param name="customerID"></param>
        /// <param name="supplierID"></param>
        /// <param name="isPriceRefresh"></param>
        /// <param name="lineSearchFilter"></param>
        /// <param name="isExcludeFailedPayments"></param>
        /// <param name="ID"></param>
        /// <param name="GUID"></param>
        /// <param name="isGetExtraInfo"></param>
        /// <param name="tenantID"></param>
        /// <param name="websiteID"></param>
        /// <param name="userID"></param>
        /// <param name="id"></param>
        /// <returns>AddLinesResponseOfInvoiceT</returns>
        public AddLinesResponseOfInvoiceT InvoiceAddLinesPreview(string discountMode, double? discount, List<BusTransLineT> lines, bool? isOverridingLines, string refTransRefNumber, List<RefBusTranT> refBusTrans, double? totalRefund, string lineSort, bool? isLineSortDesc, bool? isGetMessages, int? customerID, int? supplierID, bool? isPriceRefresh, SearchFilter lineSearchFilter, bool? isExcludeFailedPayments, int? ID, Guid? GUID, bool? isGetExtraInfo, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter 'discountMode' is set
            if (discountMode == null) throw new ApiException(400, "Missing required parameter 'discountMode' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'discount' is set
            if (discount == null) throw new ApiException(400, "Missing required parameter 'discount' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'lines' is set
            if (lines == null) throw new ApiException(400, "Missing required parameter 'lines' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isOverridingLines' is set
            if (isOverridingLines == null) throw new ApiException(400, "Missing required parameter 'isOverridingLines' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'refTransRefNumber' is set
            if (refTransRefNumber == null) throw new ApiException(400, "Missing required parameter 'refTransRefNumber' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'refBusTrans' is set
            if (refBusTrans == null) throw new ApiException(400, "Missing required parameter 'refBusTrans' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'totalRefund' is set
            if (totalRefund == null) throw new ApiException(400, "Missing required parameter 'totalRefund' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'lineSort' is set
            if (lineSort == null) throw new ApiException(400, "Missing required parameter 'lineSort' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isLineSortDesc' is set
            if (isLineSortDesc == null) throw new ApiException(400, "Missing required parameter 'isLineSortDesc' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isGetMessages' is set
            if (isGetMessages == null) throw new ApiException(400, "Missing required parameter 'isGetMessages' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'customerID' is set
            if (customerID == null) throw new ApiException(400, "Missing required parameter 'customerID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'supplierID' is set
            if (supplierID == null) throw new ApiException(400, "Missing required parameter 'supplierID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isPriceRefresh' is set
            if (isPriceRefresh == null) throw new ApiException(400, "Missing required parameter 'isPriceRefresh' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'lineSearchFilter' is set
            if (lineSearchFilter == null) throw new ApiException(400, "Missing required parameter 'lineSearchFilter' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isExcludeFailedPayments' is set
            if (isExcludeFailedPayments == null) throw new ApiException(400, "Missing required parameter 'isExcludeFailedPayments' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'GUID' is set
            if (GUID == null) throw new ApiException(400, "Missing required parameter 'GUID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'isGetExtraInfo' is set
            if (isGetExtraInfo == null) throw new ApiException(400, "Missing required parameter 'isGetExtraInfo' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InvoiceAddLinesPreview");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceAddLinesPreview");

            var path = "/api/Invoice/{id}/lines";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (discountMode != null) formParams.Add("DiscountMode", ApiClient.ParameterToString(discountMode)); // form parameter
            if (discount != null) formParams.Add("Discount", ApiClient.ParameterToString(discount)); // form parameter
            if (lines != null) formParams.Add("Lines", ApiClient.ParameterToString(lines)); // form parameter
            if (isOverridingLines != null) formParams.Add("IsOverridingLines", ApiClient.ParameterToString(isOverridingLines)); // form parameter
            if (refTransRefNumber != null) formParams.Add("RefTransRefNumber", ApiClient.ParameterToString(refTransRefNumber)); // form parameter
            if (refBusTrans != null) formParams.Add("RefBusTrans", ApiClient.ParameterToString(refBusTrans)); // form parameter
            if (totalRefund != null) formParams.Add("TotalRefund", ApiClient.ParameterToString(totalRefund)); // form parameter
            if (lineSort != null) formParams.Add("LineSort", ApiClient.ParameterToString(lineSort)); // form parameter
            if (isLineSortDesc != null) formParams.Add("IsLineSortDesc", ApiClient.ParameterToString(isLineSortDesc)); // form parameter
            if (isGetMessages != null) formParams.Add("IsGetMessages", ApiClient.ParameterToString(isGetMessages)); // form parameter
            if (customerID != null) formParams.Add("CustomerID", ApiClient.ParameterToString(customerID)); // form parameter
            if (supplierID != null) formParams.Add("SupplierID", ApiClient.ParameterToString(supplierID)); // form parameter
            if (isPriceRefresh != null) formParams.Add("IsPriceRefresh", ApiClient.ParameterToString(isPriceRefresh)); // form parameter
            if (lineSearchFilter != null) formParams.Add("LineSearchFilter", ApiClient.ParameterToString(lineSearchFilter)); // form parameter
            if (isExcludeFailedPayments != null) formParams.Add("IsExcludeFailedPayments", ApiClient.ParameterToString(isExcludeFailedPayments)); // form parameter
            if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
            if (GUID != null) formParams.Add("GUID", ApiClient.ParameterToString(GUID)); // form parameter
            if (isGetExtraInfo != null) formParams.Add("IsGetExtraInfo", ApiClient.ParameterToString(isGetExtraInfo)); // form parameter
            if (tenantID != null) formParams.Add("TenantID", ApiClient.ParameterToString(tenantID)); // form parameter
            if (websiteID != null) formParams.Add("WebsiteID", ApiClient.ParameterToString(websiteID)); // form parameter
            if (userID != null) formParams.Add("UserID", ApiClient.ParameterToString(userID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLinesPreview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceAddLinesPreview: " + response.ErrorMessage, response.ErrorMessage);

            return (AddLinesResponseOfInvoiceT)ApiClient.Deserialize(response.Content, typeof(AddLinesResponseOfInvoiceT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceDelete(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceDelete");

            var path = "/api/Invoice/{id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDelete: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceDeleteAttachment(BusTransAttachmentT body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceDeleteAttachment");

            var path = "/api/Invoice/attachments";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDeleteAttachment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDeleteAttachment: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="GUID"></param>
        /// <param name="title"></param>
        /// <param name="isImage"></param>
        /// <param name="isPDF"></param>
        /// <param name="ID"></param>
        /// <param name="gUIDstring"></param>
        /// <param name="messageID"></param>
        /// <param name="URI"></param>
        /// <param name="attachedByUserID"></param>
        /// <param name="attachedDateTimeUtc"></param>
        /// <param name="isActive"></param>
        /// <param name="caption"></param>
        /// <param name="thumbnailURI"></param>
        /// <param name="attachmentType"></param>
        /// <param name="isFromParent"></param>
        /// <param name="lineID"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceDeleteAttachment(Guid? GUID, string title, bool? isImage, bool? isPDF, int? ID, string gUIDstring, int? messageID, string URI, int? attachedByUserID, DateTime? attachedDateTimeUtc, bool? isActive, string caption, string thumbnailURI, string attachmentType, bool? isFromParent, int? lineID)
        {
            // verify the required parameter 'GUID' is set
            if (GUID == null) throw new ApiException(400, "Missing required parameter 'GUID' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'title' is set
            if (title == null) throw new ApiException(400, "Missing required parameter 'title' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'isImage' is set
            if (isImage == null) throw new ApiException(400, "Missing required parameter 'isImage' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'isPDF' is set
            if (isPDF == null) throw new ApiException(400, "Missing required parameter 'isPDF' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'gUIDstring' is set
            if (gUIDstring == null) throw new ApiException(400, "Missing required parameter 'gUIDstring' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'messageID' is set
            if (messageID == null) throw new ApiException(400, "Missing required parameter 'messageID' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'URI' is set
            if (URI == null) throw new ApiException(400, "Missing required parameter 'URI' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'attachedByUserID' is set
            if (attachedByUserID == null) throw new ApiException(400, "Missing required parameter 'attachedByUserID' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'attachedDateTimeUtc' is set
            if (attachedDateTimeUtc == null) throw new ApiException(400, "Missing required parameter 'attachedDateTimeUtc' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'isActive' is set
            if (isActive == null) throw new ApiException(400, "Missing required parameter 'isActive' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'caption' is set
            if (caption == null) throw new ApiException(400, "Missing required parameter 'caption' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'thumbnailURI' is set
            if (thumbnailURI == null) throw new ApiException(400, "Missing required parameter 'thumbnailURI' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'attachmentType' is set
            if (attachmentType == null) throw new ApiException(400, "Missing required parameter 'attachmentType' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'isFromParent' is set
            if (isFromParent == null) throw new ApiException(400, "Missing required parameter 'isFromParent' when calling InvoiceDeleteAttachment");
            // verify the required parameter 'lineID' is set
            if (lineID == null) throw new ApiException(400, "Missing required parameter 'lineID' when calling InvoiceDeleteAttachment");

            var path = "/api/Invoice/attachments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (GUID != null) formParams.Add("GUID", ApiClient.ParameterToString(GUID)); // form parameter
            if (title != null) formParams.Add("Title", ApiClient.ParameterToString(title)); // form parameter
            if (isImage != null) formParams.Add("IsImage", ApiClient.ParameterToString(isImage)); // form parameter
            if (isPDF != null) formParams.Add("IsPDF", ApiClient.ParameterToString(isPDF)); // form parameter
            if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
            if (gUIDstring != null) formParams.Add("GUIDstring", ApiClient.ParameterToString(gUIDstring)); // form parameter
            if (messageID != null) formParams.Add("MessageID", ApiClient.ParameterToString(messageID)); // form parameter
            if (URI != null) formParams.Add("URI", ApiClient.ParameterToString(URI)); // form parameter
            if (attachedByUserID != null) formParams.Add("AttachedByUserID", ApiClient.ParameterToString(attachedByUserID)); // form parameter
            if (attachedDateTimeUtc != null) formParams.Add("AttachedDateTime_utc", ApiClient.ParameterToString(attachedDateTimeUtc)); // form parameter
            if (isActive != null) formParams.Add("IsActive", ApiClient.ParameterToString(isActive)); // form parameter
            if (caption != null) formParams.Add("Caption", ApiClient.ParameterToString(caption)); // form parameter
            if (thumbnailURI != null) formParams.Add("ThumbnailURI", ApiClient.ParameterToString(thumbnailURI)); // form parameter
            if (attachmentType != null) formParams.Add("AttachmentType", ApiClient.ParameterToString(attachmentType)); // form parameter
            if (isFromParent != null) formParams.Add("IsFromParent", ApiClient.ParameterToString(isFromParent)); // form parameter
            if (lineID != null) formParams.Add("LineID", ApiClient.ParameterToString(lineID)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDeleteAttachment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceDeleteAttachment: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="filterCustomerID"></param>
        /// <param name="filterStatusStrings"></param>
        /// <param name="filterSearchString"></param>
        /// <param name="filterStartDate"></param>
        /// <param name="filterEndDate"></param>
        /// <param name="filterIsExactMatch"></param>
        /// <param name="filterIncludeDeleted"></param>
        /// <param name="filterIsApprovedForPOS"></param>
        /// <param name="filterSortField"></param>
        /// <returns>PagedActionResultsOfBusTransSearchResultsT</returns>
        public PagedActionResultsOfBusTransSearchResultsT InvoiceGet(int? filterCustomerID, List<string> filterStatusStrings, string filterSearchString, DateTime? filterStartDate, DateTime? filterEndDate, bool? filterIsExactMatch, bool? filterIncludeDeleted, bool? filterIsApprovedForPOS, string filterSortField)
        {

            var path = "/api/Invoice";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterCustomerID != null) queryParams.Add("filter.customerID", ApiClient.ParameterToString(filterCustomerID)); // query parameter
            if (filterStatusStrings != null) queryParams.Add("filter.statusStrings", ApiClient.ParameterToString(filterStatusStrings)); // query parameter
            if (filterSearchString != null) queryParams.Add("filter.searchString", ApiClient.ParameterToString(filterSearchString)); // query parameter
            if (filterStartDate != null) queryParams.Add("filter.startDate", ApiClient.ParameterToString(filterStartDate)); // query parameter
            if (filterEndDate != null) queryParams.Add("filter.endDate", ApiClient.ParameterToString(filterEndDate)); // query parameter
            if (filterIsExactMatch != null) queryParams.Add("filter.isExactMatch", ApiClient.ParameterToString(filterIsExactMatch)); // query parameter
            if (filterIncludeDeleted != null) queryParams.Add("filter.includeDeleted", ApiClient.ParameterToString(filterIncludeDeleted)); // query parameter
            if (filterIsApprovedForPOS != null) queryParams.Add("filter.isApprovedForPOS", ApiClient.ParameterToString(filterIsApprovedForPOS)); // query parameter
            if (filterSortField != null) queryParams.Add("filter.sortField", ApiClient.ParameterToString(filterSortField)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGet: " + response.ErrorMessage, response.ErrorMessage);

            return (PagedActionResultsOfBusTransSearchResultsT)ApiClient.Deserialize(response.Content, typeof(PagedActionResultsOfBusTransSearchResultsT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TransactionEditResponseOfInvoiceT</returns>
        public TransactionEditResponseOfInvoiceT InvoiceGetByID(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetByID");

            var path = "/api/Invoice/{id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetByID: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetByID: " + response.ErrorMessage, response.ErrorMessage);

            return (TransactionEditResponseOfInvoiceT)ApiClient.Deserialize(response.Content, typeof(TransactionEditResponseOfInvoiceT), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResultsOfBusTransMessages</returns>
        public ActionResultsOfBusTransMessages InvoiceGetMessages(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceGetMessages");

            var path = "/api/Invoice/{id}/messages";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceGetMessages: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResultsOfBusTransMessages)ApiClient.Deserialize(response.Content, typeof(ActionResultsOfBusTransMessages), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InvoicePost(TransactionSaveRequestOfInvoiceT body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoicePost");

            var path = "/api/Invoice";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
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
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InvoicePost(InvoiceT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling InvoicePost");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling InvoicePost");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling InvoicePost");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InvoicePost");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InvoicePost");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InvoicePost");

            var path = "/api/Invoice";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePost: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InvoicePut(TransactionSaveRequestOfInvoiceT body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoicePut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoicePut");

            var path = "/api/Invoice/{id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
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
        /// <returns>SynkSaveQueueResponse</returns>
        public SynkSaveQueueResponse InvoicePut(InvoiceT _object, bool? isQueue, bool? isSaveAutoQueue, int? tenantID, int? websiteID, int? userID, int? id)
        {
            // verify the required parameter '_object' is set
            if (_object == null) throw new ApiException(400, "Missing required parameter '_object' when calling InvoicePut");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling InvoicePut");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling InvoicePut");
            // verify the required parameter 'tenantID' is set
            if (tenantID == null) throw new ApiException(400, "Missing required parameter 'tenantID' when calling InvoicePut");
            // verify the required parameter 'websiteID' is set
            if (websiteID == null) throw new ApiException(400, "Missing required parameter 'websiteID' when calling InvoicePut");
            // verify the required parameter 'userID' is set
            if (userID == null) throw new ApiException(400, "Missing required parameter 'userID' when calling InvoicePut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoicePut");

            var path = "/api/Invoice/{id}";
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
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoicePut: " + response.ErrorMessage, response.ErrorMessage);

            return (SynkSaveQueueResponse)ApiClient.Deserialize(response.Content, typeof(SynkSaveQueueResponse), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;FileDetails&gt;</returns>
        public List<FileDetails> InvoiceSaveAttachments()
        {

            var path = "/api/Invoice/attachments";
            path = path.Replace("{format}", "json");

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
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSaveAttachments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSaveAttachments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<FileDetails>)ApiClient.Deserialize(response.Content, typeof(List<FileDetails>), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceSendMessage(BusTransMessageT body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceSendMessage");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceSendMessage");

            var path = "/api/Invoice/{id}/messages";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendMessage: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="GUID"></param>
        /// <param name="ID"></param>
        /// <param name="gUIDstring"></param>
        /// <param name="transID"></param>
        /// <param name="message"></param>
        /// <param name="isInbound"></param>
        /// <param name="toUserID"></param>
        /// <param name="fromUserID"></param>
        /// <param name="sentDateTimeUtc"></param>
        /// <param name="receivedDateTimeUtc"></param>
        /// <param name="readDateTimeUtc"></param>
        /// <param name="isActive"></param>
        /// <param name="isSystemMessage"></param>
        /// <param name="isFromParent"></param>
        /// <param name="attachments"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceSendMessage(Guid? GUID, int? ID, string gUIDstring, int? transID, string message, bool? isInbound, int? toUserID, int? fromUserID, DateTime? sentDateTimeUtc, DateTime? receivedDateTimeUtc, DateTime? readDateTimeUtc, bool? isActive, bool? isSystemMessage, bool? isFromParent, List<BusTransAttachmentT> attachments, int? id)
        {
            // verify the required parameter 'GUID' is set
            if (GUID == null) throw new ApiException(400, "Missing required parameter 'GUID' when calling InvoiceSendMessage");
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling InvoiceSendMessage");
            // verify the required parameter 'gUIDstring' is set
            if (gUIDstring == null) throw new ApiException(400, "Missing required parameter 'gUIDstring' when calling InvoiceSendMessage");
            // verify the required parameter 'transID' is set
            if (transID == null) throw new ApiException(400, "Missing required parameter 'transID' when calling InvoiceSendMessage");
            // verify the required parameter 'message' is set
            if (message == null) throw new ApiException(400, "Missing required parameter 'message' when calling InvoiceSendMessage");
            // verify the required parameter 'isInbound' is set
            if (isInbound == null) throw new ApiException(400, "Missing required parameter 'isInbound' when calling InvoiceSendMessage");
            // verify the required parameter 'toUserID' is set
            if (toUserID == null) throw new ApiException(400, "Missing required parameter 'toUserID' when calling InvoiceSendMessage");
            // verify the required parameter 'fromUserID' is set
            if (fromUserID == null) throw new ApiException(400, "Missing required parameter 'fromUserID' when calling InvoiceSendMessage");
            // verify the required parameter 'sentDateTimeUtc' is set
            if (sentDateTimeUtc == null) throw new ApiException(400, "Missing required parameter 'sentDateTimeUtc' when calling InvoiceSendMessage");
            // verify the required parameter 'receivedDateTimeUtc' is set
            if (receivedDateTimeUtc == null) throw new ApiException(400, "Missing required parameter 'receivedDateTimeUtc' when calling InvoiceSendMessage");
            // verify the required parameter 'readDateTimeUtc' is set
            if (readDateTimeUtc == null) throw new ApiException(400, "Missing required parameter 'readDateTimeUtc' when calling InvoiceSendMessage");
            // verify the required parameter 'isActive' is set
            if (isActive == null) throw new ApiException(400, "Missing required parameter 'isActive' when calling InvoiceSendMessage");
            // verify the required parameter 'isSystemMessage' is set
            if (isSystemMessage == null) throw new ApiException(400, "Missing required parameter 'isSystemMessage' when calling InvoiceSendMessage");
            // verify the required parameter 'isFromParent' is set
            if (isFromParent == null) throw new ApiException(400, "Missing required parameter 'isFromParent' when calling InvoiceSendMessage");
            // verify the required parameter 'attachments' is set
            if (attachments == null) throw new ApiException(400, "Missing required parameter 'attachments' when calling InvoiceSendMessage");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceSendMessage");

            var path = "/api/Invoice/{id}/messages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (GUID != null) formParams.Add("GUID", ApiClient.ParameterToString(GUID)); // form parameter
            if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
            if (gUIDstring != null) formParams.Add("GUIDstring", ApiClient.ParameterToString(gUIDstring)); // form parameter
            if (transID != null) formParams.Add("TransID", ApiClient.ParameterToString(transID)); // form parameter
            if (message != null) formParams.Add("Message", ApiClient.ParameterToString(message)); // form parameter
            if (isInbound != null) formParams.Add("IsInbound", ApiClient.ParameterToString(isInbound)); // form parameter
            if (toUserID != null) formParams.Add("ToUserID", ApiClient.ParameterToString(toUserID)); // form parameter
            if (fromUserID != null) formParams.Add("FromUserID", ApiClient.ParameterToString(fromUserID)); // form parameter
            if (sentDateTimeUtc != null) formParams.Add("SentDateTime_utc", ApiClient.ParameterToString(sentDateTimeUtc)); // form parameter
            if (receivedDateTimeUtc != null) formParams.Add("ReceivedDateTime_utc", ApiClient.ParameterToString(receivedDateTimeUtc)); // form parameter
            if (readDateTimeUtc != null) formParams.Add("ReadDateTime_utc", ApiClient.ParameterToString(readDateTimeUtc)); // form parameter
            if (isActive != null) formParams.Add("IsActive", ApiClient.ParameterToString(isActive)); // form parameter
            if (isSystemMessage != null) formParams.Add("IsSystemMessage", ApiClient.ParameterToString(isSystemMessage)); // form parameter
            if (isFromParent != null) formParams.Add("IsFromParent", ApiClient.ParameterToString(isFromParent)); // form parameter
            if (attachments != null) formParams.Add("Attachments", ApiClient.ParameterToString(attachments)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceSendMessage: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceUpdateStatus(UpdateTransStatusRequest body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceUpdateStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceUpdateStatus");

            var path = "/api/Invoice/{id}/status";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceUpdateStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceUpdateStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="status"></param>
        /// <param name="statusUpdateReason"></param>
        /// <param name="isQueue"></param>
        /// <param name="isSaveAutoQueue"></param>
        /// <param name="id"></param>
        /// <returns>ActionResults</returns>
        public ActionResults InvoiceUpdateStatus(int? ID, string status, string statusUpdateReason, bool? isQueue, bool? isSaveAutoQueue, int? id)
        {
            // verify the required parameter 'ID' is set
            if (ID == null) throw new ApiException(400, "Missing required parameter 'ID' when calling InvoiceUpdateStatus");
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling InvoiceUpdateStatus");
            // verify the required parameter 'statusUpdateReason' is set
            if (statusUpdateReason == null) throw new ApiException(400, "Missing required parameter 'statusUpdateReason' when calling InvoiceUpdateStatus");
            // verify the required parameter 'isQueue' is set
            if (isQueue == null) throw new ApiException(400, "Missing required parameter 'isQueue' when calling InvoiceUpdateStatus");
            // verify the required parameter 'isSaveAutoQueue' is set
            if (isSaveAutoQueue == null) throw new ApiException(400, "Missing required parameter 'isSaveAutoQueue' when calling InvoiceUpdateStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceUpdateStatus");

            var path = "/api/Invoice/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (ID != null) formParams.Add("ID", ApiClient.ParameterToString(ID)); // form parameter
            if (status != null) formParams.Add("Status", ApiClient.ParameterToString(status)); // form parameter
            if (statusUpdateReason != null) formParams.Add("StatusUpdateReason", ApiClient.ParameterToString(statusUpdateReason)); // form parameter
            if (isQueue != null) formParams.Add("IsQueue", ApiClient.ParameterToString(isQueue)); // form parameter
            if (isSaveAutoQueue != null) formParams.Add("IsSaveAutoQueue", ApiClient.ParameterToString(isSaveAutoQueue)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceUpdateStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling InvoiceUpdateStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionResults)ApiClient.Deserialize(response.Content, typeof(ActionResults), response.Headers);
        }

    }
}
