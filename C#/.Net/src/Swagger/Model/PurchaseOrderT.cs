using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PurchaseOrderT {
    /// <summary>
    /// Gets or Sets CampaignID
    /// </summary>
    [DataMember(Name="CampaignID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CampaignID")]
    public int? CampaignID { get; set; }

    /// <summary>
    /// Gets or Sets RequisitionID
    /// </summary>
    [DataMember(Name="RequisitionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequisitionID")]
    public int? RequisitionID { get; set; }

    /// <summary>
    /// Gets or Sets LineCount
    /// </summary>
    [DataMember(Name="LineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineCount")]
    public int? LineCount { get; set; }

    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets RowNumber
    /// </summary>
    [DataMember(Name="RowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RowNumber")]
    public long? RowNumber { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public double? Version { get; set; }

    /// <summary>
    /// Gets or Sets AccountBalance
    /// </summary>
    [DataMember(Name="AccountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountBalance")]
    public double? AccountBalance { get; set; }

    /// <summary>
    /// Gets or Sets AccountBalanceString
    /// </summary>
    [DataMember(Name="AccountBalanceString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountBalanceString")]
    public string AccountBalanceString { get; set; }

    /// <summary>
    /// Gets or Sets AvailableCredit
    /// </summary>
    [DataMember(Name="AvailableCredit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvailableCredit")]
    public double? AvailableCredit { get; set; }

    /// <summary>
    /// Gets or Sets AvailableCreditString
    /// </summary>
    [DataMember(Name="AvailableCreditString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvailableCreditString")]
    public string AvailableCreditString { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingAddress")]
    public AddressT BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets BusinessID
    /// </summary>
    [DataMember(Name="BusinessID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessID")]
    public int? BusinessID { get; set; }

    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name="Contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Contact")]
    public ContactT Contact { get; set; }

    /// <summary>
    /// Gets or Sets ContractID
    /// </summary>
    [DataMember(Name="ContractID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractID")]
    public int? ContractID { get; set; }

    /// <summary>
    /// Gets or Sets DatTypeID
    /// </summary>
    [DataMember(Name="DatTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DatTypeID")]
    public int? DatTypeID { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryMethod
    /// </summary>
    [DataMember(Name="DeliveryMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryMethod")]
    public string DeliveryMethod { get; set; }

    /// <summary>
    /// Gets or Sets DisplayAddress
    /// </summary>
    [DataMember(Name="DisplayAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayAddress")]
    public string DisplayAddress { get; set; }

    /// <summary>
    /// Gets or Sets ExternalNotes
    /// </summary>
    [DataMember(Name="ExternalNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExternalNotes")]
    public string ExternalNotes { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsReadOnly
    /// </summary>
    [DataMember(Name="IsReadOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReadOnly")]
    public bool? IsReadOnly { get; set; }

    /// <summary>
    /// Gets or Sets IsSeparateLines
    /// </summary>
    [DataMember(Name="IsSeparateLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSeparateLines")]
    public bool? IsSeparateLines { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets RepUserID
    /// </summary>
    [DataMember(Name="RepUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepUserID")]
    public int? RepUserID { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByUserName
    /// </summary>
    [DataMember(Name="CreatedByUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserName")]
    public string CreatedByUserName { get; set; }

    /// <summary>
    /// Gets or Sets ShippingAddress
    /// </summary>
    [DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShippingAddress")]
    public AddressT ShippingAddress { get; set; }

    /// <summary>
    /// Gets or Sets TotalExString
    /// </summary>
    [DataMember(Name="TotalExString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalExString")]
    public string TotalExString { get; set; }

    /// <summary>
    /// Gets or Sets TotalIncString
    /// </summary>
    [DataMember(Name="TotalIncString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalIncString")]
    public string TotalIncString { get; set; }

    /// <summary>
    /// Gets or Sets TotalOwing
    /// </summary>
    [DataMember(Name="TotalOwing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalOwing")]
    public double? TotalOwing { get; set; }

    /// <summary>
    /// Gets or Sets TotalOwingString
    /// </summary>
    [DataMember(Name="TotalOwingString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalOwingString")]
    public string TotalOwingString { get; set; }

    /// <summary>
    /// Gets or Sets TotalTaxString
    /// </summary>
    [DataMember(Name="TotalTaxString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTaxString")]
    public string TotalTaxString { get; set; }

    /// <summary>
    /// Gets or Sets TransDateString
    /// </summary>
    [DataMember(Name="TransDateString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDateString")]
    public string TransDateString { get; set; }

    /// <summary>
    /// Gets or Sets DueDateString
    /// </summary>
    [DataMember(Name="DueDateString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDateString")]
    public string DueDateString { get; set; }

    /// <summary>
    /// Gets or Sets TransType
    /// </summary>
    [DataMember(Name="TransType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransType")]
    public string TransType { get; set; }

    /// <summary>
    /// Gets or Sets UseIncPrices
    /// </summary>
    [DataMember(Name="UseIncPrices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseIncPrices")]
    public bool? UseIncPrices { get; set; }

    /// <summary>
    /// Gets or Sets IsSendable
    /// </summary>
    [DataMember(Name="IsSendable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSendable")]
    public bool? IsSendable { get; set; }

    /// <summary>
    /// Gets or Sets IsSentToUnlinked
    /// </summary>
    [DataMember(Name="IsSentToUnlinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSentToUnlinked")]
    public bool? IsSentToUnlinked { get; set; }

    /// <summary>
    /// Gets or Sets WasSentWhenLinked
    /// </summary>
    [DataMember(Name="WasSentWhenLinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasSentWhenLinked")]
    public bool? WasSentWhenLinked { get; set; }

    /// <summary>
    /// Gets or Sets WasSentWhenUnlinked
    /// </summary>
    [DataMember(Name="WasSentWhenUnlinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasSentWhenUnlinked")]
    public bool? WasSentWhenUnlinked { get; set; }

    /// <summary>
    /// Gets or Sets IsProcessed
    /// </summary>
    [DataMember(Name="IsProcessed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsProcessed")]
    public bool? IsProcessed { get; set; }

    /// <summary>
    /// Gets or Sets IsMessagesSendable
    /// </summary>
    [DataMember(Name="IsMessagesSendable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMessagesSendable")]
    public bool? IsMessagesSendable { get; set; }

    /// <summary>
    /// Gets or Sets IsCanCancel
    /// </summary>
    [DataMember(Name="IsCanCancel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCanCancel")]
    public bool? IsCanCancel { get; set; }

    /// <summary>
    /// Gets or Sets IsCanDelete
    /// </summary>
    [DataMember(Name="IsCanDelete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCanDelete")]
    public bool? IsCanDelete { get; set; }

    /// <summary>
    /// Gets or Sets HasBeenAmended
    /// </summary>
    [DataMember(Name="HasBeenAmended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasBeenAmended")]
    public bool? HasBeenAmended { get; set; }

    /// <summary>
    /// Gets or Sets HasBeenAmendedByOtherParty
    /// </summary>
    [DataMember(Name="HasBeenAmendedByOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasBeenAmendedByOtherParty")]
    public bool? HasBeenAmendedByOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets IsCreatedByOtherParty
    /// </summary>
    [DataMember(Name="IsCreatedByOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCreatedByOtherParty")]
    public bool? IsCreatedByOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets IsLinkedToOtherParty
    /// </summary>
    [DataMember(Name="IsLinkedToOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLinkedToOtherParty")]
    public bool? IsLinkedToOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets LinesWithUnmappedInventoryCount
    /// </summary>
    [DataMember(Name="LinesWithUnmappedInventoryCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinesWithUnmappedInventoryCount")]
    public int? LinesWithUnmappedInventoryCount { get; set; }

    /// <summary>
    /// Gets or Sets QuantityCount
    /// </summary>
    [DataMember(Name="QuantityCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityCount")]
    public double? QuantityCount { get; set; }

    /// <summary>
    /// Gets or Sets AttachmentCount
    /// </summary>
    [DataMember(Name="AttachmentCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AttachmentCount")]
    public int? AttachmentCount { get; set; }

    /// <summary>
    /// Gets or Sets AcceptedDateTimeUtc
    /// </summary>
    [DataMember(Name="AcceptedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcceptedDateTime_utc")]
    public DateTime? AcceptedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets SentDateTimeUtc
    /// </summary>
    [DataMember(Name="SentDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SentDateTime_utc")]
    public DateTime? SentDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets ReceivedDateTimeUtc
    /// </summary>
    [DataMember(Name="ReceivedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReceivedDateTime_utc")]
    public DateTime? ReceivedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets FinalisedDateTimeUtc
    /// </summary>
    [DataMember(Name="FinalisedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FinalisedDateTime_utc")]
    public DateTime? FinalisedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name="Token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or Sets InboxID
    /// </summary>
    [DataMember(Name="InboxID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboxID")]
    public int? InboxID { get; set; }

    /// <summary>
    /// Gets or Sets OriginalTotalEx
    /// </summary>
    [DataMember(Name="OriginalTotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalTotalEx")]
    public double? OriginalTotalEx { get; set; }

    /// <summary>
    /// Gets or Sets OriginalTotalInc
    /// </summary>
    [DataMember(Name="OriginalTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalTotalInc")]
    public double? OriginalTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets OriginalTotalTax
    /// </summary>
    [DataMember(Name="OriginalTotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalTotalTax")]
    public double? OriginalTotalTax { get; set; }

    /// <summary>
    /// Gets or Sets IsMoreLinesToGet
    /// </summary>
    [DataMember(Name="IsMoreLinesToGet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMoreLinesToGet")]
    public bool? IsMoreLinesToGet { get; set; }

    /// <summary>
    /// Gets or Sets LastLineRowNumber
    /// </summary>
    [DataMember(Name="LastLineRowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastLineRowNumber")]
    public long? LastLineRowNumber { get; set; }

    /// <summary>
    /// Gets or Sets TotalLineCount
    /// </summary>
    [DataMember(Name="TotalLineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalLineCount")]
    public long? TotalLineCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalPaid
    /// </summary>
    [DataMember(Name="TotalPaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalPaid")]
    public double? TotalPaid { get; set; }

    /// <summary>
    /// Gets or Sets TotalPaidString
    /// </summary>
    [DataMember(Name="TotalPaidString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalPaidString")]
    public string TotalPaidString { get; set; }

    /// <summary>
    /// Gets or Sets POSDeviceID
    /// </summary>
    [DataMember(Name="POSDeviceID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "POSDeviceID")]
    public string POSDeviceID { get; set; }

    /// <summary>
    /// Gets or Sets CustomerGUIDstring
    /// </summary>
    [DataMember(Name="CustomerGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerGUIDstring")]
    public string CustomerGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets CustomerName
    /// </summary>
    [DataMember(Name="CustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerName")]
    public string CustomerName { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets CustomerBSID
    /// </summary>
    [DataMember(Name="CustomerBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerBSID")]
    public string CustomerBSID { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets CustomerRefNumber
    /// </summary>
    [DataMember(Name="CustomerRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerRefNumber")]
    public string CustomerRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets TransDate
    /// </summary>
    [DataMember(Name="TransDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDate")]
    public DateTime? TransDate { get; set; }

    /// <summary>
    /// Gets or Sets CustomerContactCustomerName
    /// </summary>
    [DataMember(Name="CustomerContactCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerContactCustomerName")]
    public string CustomerContactCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerContactFirstName
    /// </summary>
    [DataMember(Name="CustomerContactFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerContactFirstName")]
    public string CustomerContactFirstName { get; set; }

    /// <summary>
    /// Gets or Sets RefTransID
    /// </summary>
    [DataMember(Name="RefTransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefTransID")]
    public int? RefTransID { get; set; }

    /// <summary>
    /// Gets or Sets CustomerContactLastName
    /// </summary>
    [DataMember(Name="CustomerContactLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerContactLastName")]
    public string CustomerContactLastName { get; set; }

    /// <summary>
    /// Gets or Sets RefTransRefNumber
    /// </summary>
    [DataMember(Name="RefTransRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefTransRefNumber")]
    public string RefTransRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerContactEmailAddress
    /// </summary>
    [DataMember(Name="CustomerContactEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerContactEmailAddress")]
    public string CustomerContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets CustomerRefTransRefNumber
    /// </summary>
    [DataMember(Name="CustomerRefTransRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerRefTransRefNumber")]
    public string CustomerRefTransRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerContactPhone
    /// </summary>
    [DataMember(Name="CustomerContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerContactPhone")]
    public string CustomerContactPhone { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerID
    /// </summary>
    [DataMember(Name="AccountCustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerID")]
    public int? AccountCustomerID { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerName
    /// </summary>
    [DataMember(Name="AccountCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerName")]
    public string AccountCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTime
    /// </summary>
    [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerRefNumber
    /// </summary>
    [DataMember(Name="AccountCustomerRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerRefNumber")]
    public string AccountCustomerRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTimeUtc
    /// </summary>
    [DataMember(Name="CreatedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime_utc")]
    public DateTime? CreatedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets IsAccountCustomer
    /// </summary>
    [DataMember(Name="IsAccountCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAccountCustomer")]
    public bool? IsAccountCustomer { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTimeOffset
    /// </summary>
    [DataMember(Name="CreatedDateTime_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime_offset")]
    public int? CreatedDateTimeOffset { get; set; }

    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets SupplierGUIDstring
    /// </summary>
    [DataMember(Name="SupplierGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierGUIDstring")]
    public string SupplierGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryDate
    /// </summary>
    [DataMember(Name="DeliveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryDate")]
    public DateTime? DeliveryDate { get; set; }

    /// <summary>
    /// Gets or Sets SupplierName
    /// </summary>
    [DataMember(Name="SupplierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierName")]
    public string SupplierName { get; set; }

    /// <summary>
    /// Gets or Sets DueDate
    /// </summary>
    [DataMember(Name="DueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or Sets SupplierBSID
    /// </summary>
    [DataMember(Name="SupplierBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierBSID")]
    public string SupplierBSID { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryNote
    /// </summary>
    [DataMember(Name="DeliveryNote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryNote")]
    public string DeliveryNote { get; set; }

    /// <summary>
    /// Gets or Sets SupplierRefNumber
    /// </summary>
    [DataMember(Name="SupplierRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierRefNumber")]
    public string SupplierRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets InternalNote
    /// </summary>
    [DataMember(Name="InternalNote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InternalNote")]
    public string InternalNote { get; set; }

    /// <summary>
    /// Gets or Sets SupplierContactFirstName
    /// </summary>
    [DataMember(Name="SupplierContactFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierContactFirstName")]
    public string SupplierContactFirstName { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierContactLastName
    /// </summary>
    [DataMember(Name="SupplierContactLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierContactLastName")]
    public string SupplierContactLastName { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseCode
    /// </summary>
    [DataMember(Name="WarehouseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseCode")]
    public string WarehouseCode { get; set; }

    /// <summary>
    /// Gets or Sets SupplierContactEmailAddress
    /// </summary>
    [DataMember(Name="SupplierContactEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierContactEmailAddress")]
    public string SupplierContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseName
    /// </summary>
    [DataMember(Name="WarehouseName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseName")]
    public string WarehouseName { get; set; }

    /// <summary>
    /// Gets or Sets SupplierContactPhone
    /// </summary>
    [DataMember(Name="SupplierContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierContactPhone")]
    public string SupplierContactPhone { get; set; }

    /// <summary>
    /// Gets or Sets CostCentreCode
    /// </summary>
    [DataMember(Name="CostCentreCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostCentreCode")]
    public string CostCentreCode { get; set; }

    /// <summary>
    /// Gets or Sets SupplierBusinessContactID
    /// </summary>
    [DataMember(Name="SupplierBusinessContactID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierBusinessContactID")]
    public int? SupplierBusinessContactID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseBSID
    /// </summary>
    [DataMember(Name="WarehouseBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseBSID")]
    public string WarehouseBSID { get; set; }

    /// <summary>
    /// Gets or Sets TenantBillingAddressID
    /// </summary>
    [DataMember(Name="TenantBillingAddressID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantBillingAddressID")]
    public int? TenantBillingAddressID { get; set; }

    /// <summary>
    /// Gets or Sets TerritoryID
    /// </summary>
    [DataMember(Name="TerritoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerritoryID")]
    public int? TerritoryID { get; set; }

    /// <summary>
    /// Gets or Sets TenantShippingAddressID
    /// </summary>
    [DataMember(Name="TenantShippingAddressID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantShippingAddressID")]
    public int? TenantShippingAddressID { get; set; }

    /// <summary>
    /// Gets or Sets TerritoryName
    /// </summary>
    [DataMember(Name="TerritoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerritoryName")]
    public string TerritoryName { get; set; }

    /// <summary>
    /// Gets or Sets TenantContactUserID
    /// </summary>
    [DataMember(Name="TenantContactUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantContactUserID")]
    public int? TenantContactUserID { get; set; }

    /// <summary>
    /// Gets or Sets RepFirstName
    /// </summary>
    [DataMember(Name="RepFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepFirstName")]
    public string RepFirstName { get; set; }

    /// <summary>
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="Lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Lines")]
    public List<BusTransLineT> Lines { get; set; }

    /// <summary>
    /// Gets or Sets RepLastName
    /// </summary>
    [DataMember(Name="RepLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepLastName")]
    public string RepLastName { get; set; }

    /// <summary>
    /// Gets or Sets SyncLogs
    /// </summary>
    [DataMember(Name="SyncLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncLogs")]
    public List<SyncLogT> SyncLogs { get; set; }

    /// <summary>
    /// Gets or Sets RepEmailAddress
    /// </summary>
    [DataMember(Name="RepEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepEmailAddress")]
    public string RepEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets RepUserName
    /// </summary>
    [DataMember(Name="RepUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepUserName")]
    public string RepUserName { get; set; }

    /// <summary>
    /// Gets or Sets BusinessContactID
    /// </summary>
    [DataMember(Name="BusinessContactID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessContactID")]
    public int? BusinessContactID { get; set; }

    /// <summary>
    /// Gets or Sets ContactFirstName
    /// </summary>
    [DataMember(Name="ContactFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactFirstName")]
    public string ContactFirstName { get; set; }

    /// <summary>
    /// Gets or Sets ContactLastName
    /// </summary>
    [DataMember(Name="ContactLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactLastName")]
    public string ContactLastName { get; set; }

    /// <summary>
    /// Gets or Sets ContactEmailAddress
    /// </summary>
    [DataMember(Name="ContactEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactEmailAddress")]
    public string ContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets ContactPhone
    /// </summary>
    [DataMember(Name="ContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactPhone")]
    public string ContactPhone { get; set; }

    /// <summary>
    /// Gets or Sets ContactCustomerName
    /// </summary>
    [DataMember(Name="ContactCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactCustomerName")]
    public string ContactCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets IsIndividual
    /// </summary>
    [DataMember(Name="IsIndividual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsIndividual")]
    public bool? IsIndividual { get; set; }

    /// <summary>
    /// Gets or Sets TotalEx
    /// </summary>
    [DataMember(Name="TotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalEx")]
    public double? TotalEx { get; set; }

    /// <summary>
    /// Gets or Sets TotalInc
    /// </summary>
    [DataMember(Name="TotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalInc")]
    public double? TotalInc { get; set; }

    /// <summary>
    /// Gets or Sets TotalTax
    /// </summary>
    [DataMember(Name="TotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTax")]
    public double? TotalTax { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="Balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// Gets or Sets Discount
    /// </summary>
    [DataMember(Name="Discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Discount")]
    public double? Discount { get; set; }

    /// <summary>
    /// Gets or Sets DiscountMode
    /// </summary>
    [DataMember(Name="DiscountMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountMode")]
    public string DiscountMode { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddressID
    /// </summary>
    [DataMember(Name="BillingAddressID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingAddressID")]
    public int? BillingAddressID { get; set; }

    /// <summary>
    /// Gets or Sets BillStreetAddress
    /// </summary>
    [DataMember(Name="BillStreetAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillStreetAddress")]
    public string BillStreetAddress { get; set; }

    /// <summary>
    /// Gets or Sets BillCity
    /// </summary>
    [DataMember(Name="BillCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCity")]
    public string BillCity { get; set; }

    /// <summary>
    /// Gets or Sets BillState
    /// </summary>
    [DataMember(Name="BillState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillState")]
    public string BillState { get; set; }

    /// <summary>
    /// Gets or Sets BillCountry
    /// </summary>
    [DataMember(Name="BillCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillCountry")]
    public string BillCountry { get; set; }

    /// <summary>
    /// Gets or Sets BillPostCode
    /// </summary>
    [DataMember(Name="BillPostCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillPostCode")]
    public string BillPostCode { get; set; }

    /// <summary>
    /// Gets or Sets BillLatitude
    /// </summary>
    [DataMember(Name="BillLatitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillLatitude")]
    public double? BillLatitude { get; set; }

    /// <summary>
    /// Gets or Sets BillLongitude
    /// </summary>
    [DataMember(Name="BillLongitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillLongitude")]
    public double? BillLongitude { get; set; }

    /// <summary>
    /// Gets or Sets ShippingAddressID
    /// </summary>
    [DataMember(Name="ShippingAddressID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShippingAddressID")]
    public int? ShippingAddressID { get; set; }

    /// <summary>
    /// Gets or Sets ShipStreetAddress
    /// </summary>
    [DataMember(Name="ShipStreetAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipStreetAddress")]
    public string ShipStreetAddress { get; set; }

    /// <summary>
    /// Gets or Sets ShipCity
    /// </summary>
    [DataMember(Name="ShipCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipCity")]
    public string ShipCity { get; set; }

    /// <summary>
    /// Gets or Sets ShipState
    /// </summary>
    [DataMember(Name="ShipState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipState")]
    public string ShipState { get; set; }

    /// <summary>
    /// Gets or Sets ShipCountry
    /// </summary>
    [DataMember(Name="ShipCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipCountry")]
    public string ShipCountry { get; set; }

    /// <summary>
    /// Gets or Sets ShipPostCode
    /// </summary>
    [DataMember(Name="ShipPostCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipPostCode")]
    public string ShipPostCode { get; set; }

    /// <summary>
    /// Gets or Sets ShipLatitude
    /// </summary>
    [DataMember(Name="ShipLatitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipLatitude")]
    public double? ShipLatitude { get; set; }

    /// <summary>
    /// Gets or Sets ShipLongitude
    /// </summary>
    [DataMember(Name="ShipLongitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShipLongitude")]
    public double? ShipLongitude { get; set; }

    /// <summary>
    /// Gets or Sets ExchangeRate
    /// </summary>
    [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExchangeRate")]
    public double? ExchangeRate { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets RefSalesOrderRefNumber
    /// </summary>
    [DataMember(Name="RefSalesOrderRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefSalesOrderRefNumber")]
    public string RefSalesOrderRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets ExternalTerminalName
    /// </summary>
    [DataMember(Name="ExternalTerminalName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExternalTerminalName")]
    public string ExternalTerminalName { get; set; }

    /// <summary>
    /// Gets or Sets IsSent
    /// </summary>
    [DataMember(Name="IsSent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSent")]
    public bool? IsSent { get; set; }

    /// <summary>
    /// Gets or Sets POSTerminalShiftID
    /// </summary>
    [DataMember(Name="POSTerminalShiftID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "POSTerminalShiftID")]
    public int? POSTerminalShiftID { get; set; }

    /// <summary>
    /// Gets or Sets CashPaymentRounding
    /// </summary>
    [DataMember(Name="CashPaymentRounding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CashPaymentRounding")]
    public double? CashPaymentRounding { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="Messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Messages")]
    public List<BusTransMessageT> Messages { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name="Attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attachments")]
    public List<BusTransAttachmentT> Attachments { get; set; }

    /// <summary>
    /// Gets or Sets LinkedTrans
    /// </summary>
    [DataMember(Name="LinkedTrans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedTrans")]
    public List<LinkedTransactionT> LinkedTrans { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurchaseOrderT {\n");
      sb.Append("  CampaignID: ").Append(CampaignID).Append("\n");
      sb.Append("  RequisitionID: ").Append(RequisitionID).Append("\n");
      sb.Append("  LineCount: ").Append(LineCount).Append("\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  AccountBalanceString: ").Append(AccountBalanceString).Append("\n");
      sb.Append("  AvailableCredit: ").Append(AvailableCredit).Append("\n");
      sb.Append("  AvailableCreditString: ").Append(AvailableCreditString).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  BusinessID: ").Append(BusinessID).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  ContractID: ").Append(ContractID).Append("\n");
      sb.Append("  DatTypeID: ").Append(DatTypeID).Append("\n");
      sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
      sb.Append("  DisplayAddress: ").Append(DisplayAddress).Append("\n");
      sb.Append("  ExternalNotes: ").Append(ExternalNotes).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
      sb.Append("  IsSeparateLines: ").Append(IsSeparateLines).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  RepUserID: ").Append(RepUserID).Append("\n");
      sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
      sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
      sb.Append("  TotalExString: ").Append(TotalExString).Append("\n");
      sb.Append("  TotalIncString: ").Append(TotalIncString).Append("\n");
      sb.Append("  TotalOwing: ").Append(TotalOwing).Append("\n");
      sb.Append("  TotalOwingString: ").Append(TotalOwingString).Append("\n");
      sb.Append("  TotalTaxString: ").Append(TotalTaxString).Append("\n");
      sb.Append("  TransDateString: ").Append(TransDateString).Append("\n");
      sb.Append("  DueDateString: ").Append(DueDateString).Append("\n");
      sb.Append("  TransType: ").Append(TransType).Append("\n");
      sb.Append("  UseIncPrices: ").Append(UseIncPrices).Append("\n");
      sb.Append("  IsSendable: ").Append(IsSendable).Append("\n");
      sb.Append("  IsSentToUnlinked: ").Append(IsSentToUnlinked).Append("\n");
      sb.Append("  WasSentWhenLinked: ").Append(WasSentWhenLinked).Append("\n");
      sb.Append("  WasSentWhenUnlinked: ").Append(WasSentWhenUnlinked).Append("\n");
      sb.Append("  IsProcessed: ").Append(IsProcessed).Append("\n");
      sb.Append("  IsMessagesSendable: ").Append(IsMessagesSendable).Append("\n");
      sb.Append("  IsCanCancel: ").Append(IsCanCancel).Append("\n");
      sb.Append("  IsCanDelete: ").Append(IsCanDelete).Append("\n");
      sb.Append("  HasBeenAmended: ").Append(HasBeenAmended).Append("\n");
      sb.Append("  HasBeenAmendedByOtherParty: ").Append(HasBeenAmendedByOtherParty).Append("\n");
      sb.Append("  IsCreatedByOtherParty: ").Append(IsCreatedByOtherParty).Append("\n");
      sb.Append("  IsLinkedToOtherParty: ").Append(IsLinkedToOtherParty).Append("\n");
      sb.Append("  LinesWithUnmappedInventoryCount: ").Append(LinesWithUnmappedInventoryCount).Append("\n");
      sb.Append("  QuantityCount: ").Append(QuantityCount).Append("\n");
      sb.Append("  AttachmentCount: ").Append(AttachmentCount).Append("\n");
      sb.Append("  AcceptedDateTimeUtc: ").Append(AcceptedDateTimeUtc).Append("\n");
      sb.Append("  SentDateTimeUtc: ").Append(SentDateTimeUtc).Append("\n");
      sb.Append("  ReceivedDateTimeUtc: ").Append(ReceivedDateTimeUtc).Append("\n");
      sb.Append("  FinalisedDateTimeUtc: ").Append(FinalisedDateTimeUtc).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  InboxID: ").Append(InboxID).Append("\n");
      sb.Append("  OriginalTotalEx: ").Append(OriginalTotalEx).Append("\n");
      sb.Append("  OriginalTotalInc: ").Append(OriginalTotalInc).Append("\n");
      sb.Append("  OriginalTotalTax: ").Append(OriginalTotalTax).Append("\n");
      sb.Append("  IsMoreLinesToGet: ").Append(IsMoreLinesToGet).Append("\n");
      sb.Append("  LastLineRowNumber: ").Append(LastLineRowNumber).Append("\n");
      sb.Append("  TotalLineCount: ").Append(TotalLineCount).Append("\n");
      sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
      sb.Append("  TotalPaidString: ").Append(TotalPaidString).Append("\n");
      sb.Append("  POSDeviceID: ").Append(POSDeviceID).Append("\n");
      sb.Append("  CustomerGUIDstring: ").Append(CustomerGUIDstring).Append("\n");
      sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  CustomerBSID: ").Append(CustomerBSID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  CustomerRefNumber: ").Append(CustomerRefNumber).Append("\n");
      sb.Append("  TransDate: ").Append(TransDate).Append("\n");
      sb.Append("  CustomerContactCustomerName: ").Append(CustomerContactCustomerName).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  CustomerContactFirstName: ").Append(CustomerContactFirstName).Append("\n");
      sb.Append("  RefTransID: ").Append(RefTransID).Append("\n");
      sb.Append("  CustomerContactLastName: ").Append(CustomerContactLastName).Append("\n");
      sb.Append("  RefTransRefNumber: ").Append(RefTransRefNumber).Append("\n");
      sb.Append("  CustomerContactEmailAddress: ").Append(CustomerContactEmailAddress).Append("\n");
      sb.Append("  CustomerRefTransRefNumber: ").Append(CustomerRefTransRefNumber).Append("\n");
      sb.Append("  CustomerContactPhone: ").Append(CustomerContactPhone).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  AccountCustomerID: ").Append(AccountCustomerID).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  AccountCustomerName: ").Append(AccountCustomerName).Append("\n");
      sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
      sb.Append("  AccountCustomerRefNumber: ").Append(AccountCustomerRefNumber).Append("\n");
      sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
      sb.Append("  IsAccountCustomer: ").Append(IsAccountCustomer).Append("\n");
      sb.Append("  CreatedDateTimeOffset: ").Append(CreatedDateTimeOffset).Append("\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SupplierGUIDstring: ").Append(SupplierGUIDstring).Append("\n");
      sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
      sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  SupplierBSID: ").Append(SupplierBSID).Append("\n");
      sb.Append("  DeliveryNote: ").Append(DeliveryNote).Append("\n");
      sb.Append("  SupplierRefNumber: ").Append(SupplierRefNumber).Append("\n");
      sb.Append("  InternalNote: ").Append(InternalNote).Append("\n");
      sb.Append("  SupplierContactFirstName: ").Append(SupplierContactFirstName).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  SupplierContactLastName: ").Append(SupplierContactLastName).Append("\n");
      sb.Append("  WarehouseCode: ").Append(WarehouseCode).Append("\n");
      sb.Append("  SupplierContactEmailAddress: ").Append(SupplierContactEmailAddress).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  SupplierContactPhone: ").Append(SupplierContactPhone).Append("\n");
      sb.Append("  CostCentreCode: ").Append(CostCentreCode).Append("\n");
      sb.Append("  SupplierBusinessContactID: ").Append(SupplierBusinessContactID).Append("\n");
      sb.Append("  WarehouseBSID: ").Append(WarehouseBSID).Append("\n");
      sb.Append("  TenantBillingAddressID: ").Append(TenantBillingAddressID).Append("\n");
      sb.Append("  TerritoryID: ").Append(TerritoryID).Append("\n");
      sb.Append("  TenantShippingAddressID: ").Append(TenantShippingAddressID).Append("\n");
      sb.Append("  TerritoryName: ").Append(TerritoryName).Append("\n");
      sb.Append("  TenantContactUserID: ").Append(TenantContactUserID).Append("\n");
      sb.Append("  RepFirstName: ").Append(RepFirstName).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
      sb.Append("  RepLastName: ").Append(RepLastName).Append("\n");
      sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
      sb.Append("  RepEmailAddress: ").Append(RepEmailAddress).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RepUserName: ").Append(RepUserName).Append("\n");
      sb.Append("  BusinessContactID: ").Append(BusinessContactID).Append("\n");
      sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
      sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
      sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
      sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
      sb.Append("  ContactCustomerName: ").Append(ContactCustomerName).Append("\n");
      sb.Append("  IsIndividual: ").Append(IsIndividual).Append("\n");
      sb.Append("  TotalEx: ").Append(TotalEx).Append("\n");
      sb.Append("  TotalInc: ").Append(TotalInc).Append("\n");
      sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  DiscountMode: ").Append(DiscountMode).Append("\n");
      sb.Append("  BillingAddressID: ").Append(BillingAddressID).Append("\n");
      sb.Append("  BillStreetAddress: ").Append(BillStreetAddress).Append("\n");
      sb.Append("  BillCity: ").Append(BillCity).Append("\n");
      sb.Append("  BillState: ").Append(BillState).Append("\n");
      sb.Append("  BillCountry: ").Append(BillCountry).Append("\n");
      sb.Append("  BillPostCode: ").Append(BillPostCode).Append("\n");
      sb.Append("  BillLatitude: ").Append(BillLatitude).Append("\n");
      sb.Append("  BillLongitude: ").Append(BillLongitude).Append("\n");
      sb.Append("  ShippingAddressID: ").Append(ShippingAddressID).Append("\n");
      sb.Append("  ShipStreetAddress: ").Append(ShipStreetAddress).Append("\n");
      sb.Append("  ShipCity: ").Append(ShipCity).Append("\n");
      sb.Append("  ShipState: ").Append(ShipState).Append("\n");
      sb.Append("  ShipCountry: ").Append(ShipCountry).Append("\n");
      sb.Append("  ShipPostCode: ").Append(ShipPostCode).Append("\n");
      sb.Append("  ShipLatitude: ").Append(ShipLatitude).Append("\n");
      sb.Append("  ShipLongitude: ").Append(ShipLongitude).Append("\n");
      sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  RefSalesOrderRefNumber: ").Append(RefSalesOrderRefNumber).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  ExternalTerminalName: ").Append(ExternalTerminalName).Append("\n");
      sb.Append("  IsSent: ").Append(IsSent).Append("\n");
      sb.Append("  POSTerminalShiftID: ").Append(POSTerminalShiftID).Append("\n");
      sb.Append("  CashPaymentRounding: ").Append(CashPaymentRounding).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
      sb.Append("  LinkedTrans: ").Append(LinkedTrans).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
