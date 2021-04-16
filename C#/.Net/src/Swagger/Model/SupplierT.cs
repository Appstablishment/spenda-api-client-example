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
  public class SupplierT {
    /// <summary>
    /// Gets or Sets SupplierType
    /// </summary>
    [DataMember(Name="SupplierType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierType")]
    public string SupplierType { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets AvgPayDays
    /// </summary>
    [DataMember(Name="AvgPayDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvgPayDays")]
    public int? AvgPayDays { get; set; }

    /// <summary>
    /// Gets or Sets IsContractor
    /// </summary>
    [DataMember(Name="IsContractor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsContractor")]
    public bool? IsContractor { get; set; }

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
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets TenantID
    /// </summary>
    [DataMember(Name="TenantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantID")]
    public int? TenantID { get; set; }

    /// <summary>
    /// Gets or Sets BusinessGUID
    /// </summary>
    [DataMember(Name="BusinessGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessGUID")]
    public Guid? BusinessGUID { get; set; }

    /// <summary>
    /// Gets or Sets LinkedTenantGlobalID
    /// </summary>
    [DataMember(Name="LinkedTenantGlobalID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedTenantGlobalID")]
    public Guid? LinkedTenantGlobalID { get; set; }

    /// <summary>
    /// Gets or Sets IsReadOnly
    /// </summary>
    [DataMember(Name="IsReadOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReadOnly")]
    public bool? IsReadOnly { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTime
    /// </summary>
    [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets HasOpenTransactions
    /// </summary>
    [DataMember(Name="HasOpenTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasOpenTransactions")]
    public bool? HasOpenTransactions { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactFullName
    /// </summary>
    [DataMember(Name="PrimaryContactFullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactFullName")]
    public string PrimaryContactFullName { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactFirstName
    /// </summary>
    [DataMember(Name="PrimaryContactFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactFirstName")]
    public string PrimaryContactFirstName { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactLastName
    /// </summary>
    [DataMember(Name="PrimaryContactLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactLastName")]
    public string PrimaryContactLastName { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactPhone
    /// </summary>
    [DataMember(Name="PrimaryContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactPhone")]
    public string PrimaryContactPhone { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactMobile
    /// </summary>
    [DataMember(Name="PrimaryContactMobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactMobile")]
    public string PrimaryContactMobile { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactEmailAddress
    /// </summary>
    [DataMember(Name="PrimaryContactEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactEmailAddress")]
    public string PrimaryContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets RecentTransactions
    /// </summary>
    [DataMember(Name="RecentTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecentTransactions")]
    public ResultCollectionOfCustomerTransT RecentTransactions { get; set; }

    /// <summary>
    /// Gets or Sets DefaultLocation
    /// </summary>
    [DataMember(Name="DefaultLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultLocation")]
    public LocationT DefaultLocation { get; set; }

    /// <summary>
    /// Gets or Sets DefaultLocationName
    /// </summary>
    [DataMember(Name="DefaultLocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultLocationName")]
    public string DefaultLocationName { get; set; }

    /// <summary>
    /// Gets or Sets ShippingAddressString
    /// </summary>
    [DataMember(Name="ShippingAddressString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShippingAddressString")]
    public string ShippingAddressString { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddressString
    /// </summary>
    [DataMember(Name="BillingAddressString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingAddressString")]
    public string BillingAddressString { get; set; }

    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierRefNumber
    /// </summary>
    [DataMember(Name="SupplierRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierRefNumber")]
    public string SupplierRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets IsPrimaryContact
    /// </summary>
    [DataMember(Name="IsPrimaryContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPrimaryContact")]
    public bool? IsPrimaryContact { get; set; }

    /// <summary>
    /// Gets or Sets SearchFieldMatches
    /// </summary>
    [DataMember(Name="SearchFieldMatches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchFieldMatches")]
    public List<string> SearchFieldMatches { get; set; }

    /// <summary>
    /// Gets or Sets CustomerIsActive
    /// </summary>
    [DataMember(Name="CustomerIsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerIsActive")]
    public bool? CustomerIsActive { get; set; }

    /// <summary>
    /// Gets or Sets SupplierIsActive
    /// </summary>
    [DataMember(Name="SupplierIsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierIsActive")]
    public bool? SupplierIsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets IsAccountCustomer
    /// </summary>
    [DataMember(Name="IsAccountCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAccountCustomer")]
    public bool? IsAccountCustomer { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseNotes
    /// </summary>
    [DataMember(Name="PurchaseNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseNotes")]
    public string PurchaseNotes { get; set; }

    /// <summary>
    /// Gets or Sets MinOrderValue
    /// </summary>
    [DataMember(Name="MinOrderValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinOrderValue")]
    public double? MinOrderValue { get; set; }

    /// <summary>
    /// Gets or Sets BusinessID
    /// </summary>
    [DataMember(Name="BusinessID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessID")]
    public int? BusinessID { get; set; }

    /// <summary>
    /// Gets or Sets MinOrderValueNotification
    /// </summary>
    [DataMember(Name="MinOrderValueNotification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinOrderValueNotification")]
    public string MinOrderValueNotification { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets OrderLeadTimeDays
    /// </summary>
    [DataMember(Name="OrderLeadTimeDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OrderLeadTimeDays")]
    public int? OrderLeadTimeDays { get; set; }

    /// <summary>
    /// Gets or Sets BusinessGUIDstring
    /// </summary>
    [DataMember(Name="BusinessGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessGUIDstring")]
    public string BusinessGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets IsAllowBackOrders
    /// </summary>
    [DataMember(Name="IsAllowBackOrders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAllowBackOrders")]
    public bool? IsAllowBackOrders { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets FreightMethod
    /// </summary>
    [DataMember(Name="FreightMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FreightMethod")]
    public string FreightMethod { get; set; }

    /// <summary>
    /// Gets or Sets Name2
    /// </summary>
    [DataMember(Name="Name2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name2")]
    public string Name2 { get; set; }

    /// <summary>
    /// Gets or Sets SupplierInternationalID
    /// </summary>
    [DataMember(Name="SupplierInternationalID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierInternationalID")]
    public string SupplierInternationalID { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryName
    /// </summary>
    [DataMember(Name="SecondaryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryName")]
    public string SecondaryName { get; set; }

    /// <summary>
    /// Gets or Sets IsGSTExempt
    /// </summary>
    [DataMember(Name="IsGSTExempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsGSTExempt")]
    public bool? IsGSTExempt { get; set; }

    /// <summary>
    /// Gets or Sets ABN
    /// </summary>
    [DataMember(Name="ABN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ABN")]
    public string ABN { get; set; }

    /// <summary>
    /// Gets or Sets IsMinOrderValueEnforced
    /// </summary>
    [DataMember(Name="IsMinOrderValueEnforced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMinOrderValueEnforced")]
    public bool? IsMinOrderValueEnforced { get; set; }

    /// <summary>
    /// Gets or Sets IsIndividual
    /// </summary>
    [DataMember(Name="IsIndividual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsIndividual")]
    public bool? IsIndividual { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTimeUtc
    /// </summary>
    [DataMember(Name="ModifiedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedDateTime_utc")]
    public DateTime? ModifiedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets Phone1
    /// </summary>
    [DataMember(Name="Phone1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone1")]
    public string Phone1 { get; set; }

    /// <summary>
    /// Gets or Sets ModifiesDateTimeOffset
    /// </summary>
    [DataMember(Name="ModifiesDateTime_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiesDateTime_offset")]
    public int? ModifiesDateTimeOffset { get; set; }

    /// <summary>
    /// Gets or Sets PhoneFax
    /// </summary>
    [DataMember(Name="PhoneFax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneFax")]
    public string PhoneFax { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTimeUtc
    /// </summary>
    [DataMember(Name="CreatedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime_utc")]
    public DateTime? CreatedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets AnnualTurnOver
    /// </summary>
    [DataMember(Name="AnnualTurnOver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnnualTurnOver")]
    public int? AnnualTurnOver { get; set; }

    /// <summary>
    /// Gets or Sets SyncLogs
    /// </summary>
    [DataMember(Name="SyncLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncLogs")]
    public List<SyncLogT> SyncLogs { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfStaff
    /// </summary>
    [DataMember(Name="NumberOfStaff", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfStaff")]
    public int? NumberOfStaff { get; set; }

    /// <summary>
    /// Gets or Sets IncorporatedDate
    /// </summary>
    [DataMember(Name="IncorporatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncorporatedDate")]
    public DateTime? IncorporatedDate { get; set; }

    /// <summary>
    /// Gets or Sets WebSiteURL
    /// </summary>
    [DataMember(Name="WebSiteURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebSiteURL")]
    public string WebSiteURL { get; set; }

    /// <summary>
    /// Gets or Sets IndustryType
    /// </summary>
    [DataMember(Name="IndustryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IndustryType")]
    public string IndustryType { get; set; }

    /// <summary>
    /// Gets or Sets Structure
    /// </summary>
    [DataMember(Name="Structure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Structure")]
    public string Structure { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsLinked
    /// </summary>
    [DataMember(Name="IsLinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLinked")]
    public bool? IsLinked { get; set; }

    /// <summary>
    /// Gets or Sets AccountBalance
    /// </summary>
    [DataMember(Name="AccountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountBalance")]
    public double? AccountBalance { get; set; }

    /// <summary>
    /// Gets or Sets CreditLimit
    /// </summary>
    [DataMember(Name="CreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditLimit")]
    public double? CreditLimit { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryNotes
    /// </summary>
    [DataMember(Name="DeliveryNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryNotes")]
    public string DeliveryNotes { get; set; }

    /// <summary>
    /// Gets or Sets LinkedTenantGlobalCode
    /// </summary>
    [DataMember(Name="LinkedTenantGlobalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedTenantGlobalCode")]
    public string LinkedTenantGlobalCode { get; set; }

    /// <summary>
    /// Gets or Sets LinkedTenantGlobalIDstring
    /// </summary>
    [DataMember(Name="LinkedTenantGlobalIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedTenantGlobalIDstring")]
    public string LinkedTenantGlobalIDstring { get; set; }

    /// <summary>
    /// Gets or Sets Locations
    /// </summary>
    [DataMember(Name="Locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Locations")]
    public List<LocationT> Locations { get; set; }

    /// <summary>
    /// Gets or Sets Contacts
    /// </summary>
    [DataMember(Name="Contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Contacts")]
    public List<ContactT> Contacts { get; set; }

    /// <summary>
    /// Gets or Sets BankAccounts
    /// </summary>
    [DataMember(Name="BankAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankAccounts")]
    public List<BankAccountT> BankAccounts { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name="Attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attachments")]
    public List<BusTransAttachmentT> Attachments { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierT {\n");
      sb.Append("  SupplierType: ").Append(SupplierType).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  AvgPayDays: ").Append(AvgPayDays).Append("\n");
      sb.Append("  IsContractor: ").Append(IsContractor).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  BusinessGUID: ").Append(BusinessGUID).Append("\n");
      sb.Append("  LinkedTenantGlobalID: ").Append(LinkedTenantGlobalID).Append("\n");
      sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
      sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
      sb.Append("  HasOpenTransactions: ").Append(HasOpenTransactions).Append("\n");
      sb.Append("  PrimaryContactFullName: ").Append(PrimaryContactFullName).Append("\n");
      sb.Append("  PrimaryContactFirstName: ").Append(PrimaryContactFirstName).Append("\n");
      sb.Append("  PrimaryContactLastName: ").Append(PrimaryContactLastName).Append("\n");
      sb.Append("  PrimaryContactPhone: ").Append(PrimaryContactPhone).Append("\n");
      sb.Append("  PrimaryContactMobile: ").Append(PrimaryContactMobile).Append("\n");
      sb.Append("  PrimaryContactEmailAddress: ").Append(PrimaryContactEmailAddress).Append("\n");
      sb.Append("  RecentTransactions: ").Append(RecentTransactions).Append("\n");
      sb.Append("  DefaultLocation: ").Append(DefaultLocation).Append("\n");
      sb.Append("  DefaultLocationName: ").Append(DefaultLocationName).Append("\n");
      sb.Append("  ShippingAddressString: ").Append(ShippingAddressString).Append("\n");
      sb.Append("  BillingAddressString: ").Append(BillingAddressString).Append("\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  SupplierRefNumber: ").Append(SupplierRefNumber).Append("\n");
      sb.Append("  IsPrimaryContact: ").Append(IsPrimaryContact).Append("\n");
      sb.Append("  SearchFieldMatches: ").Append(SearchFieldMatches).Append("\n");
      sb.Append("  CustomerIsActive: ").Append(CustomerIsActive).Append("\n");
      sb.Append("  SupplierIsActive: ").Append(SupplierIsActive).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  IsAccountCustomer: ").Append(IsAccountCustomer).Append("\n");
      sb.Append("  PurchaseNotes: ").Append(PurchaseNotes).Append("\n");
      sb.Append("  MinOrderValue: ").Append(MinOrderValue).Append("\n");
      sb.Append("  BusinessID: ").Append(BusinessID).Append("\n");
      sb.Append("  MinOrderValueNotification: ").Append(MinOrderValueNotification).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  OrderLeadTimeDays: ").Append(OrderLeadTimeDays).Append("\n");
      sb.Append("  BusinessGUIDstring: ").Append(BusinessGUIDstring).Append("\n");
      sb.Append("  IsAllowBackOrders: ").Append(IsAllowBackOrders).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FreightMethod: ").Append(FreightMethod).Append("\n");
      sb.Append("  Name2: ").Append(Name2).Append("\n");
      sb.Append("  SupplierInternationalID: ").Append(SupplierInternationalID).Append("\n");
      sb.Append("  SecondaryName: ").Append(SecondaryName).Append("\n");
      sb.Append("  IsGSTExempt: ").Append(IsGSTExempt).Append("\n");
      sb.Append("  ABN: ").Append(ABN).Append("\n");
      sb.Append("  IsMinOrderValueEnforced: ").Append(IsMinOrderValueEnforced).Append("\n");
      sb.Append("  IsIndividual: ").Append(IsIndividual).Append("\n");
      sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
      sb.Append("  Phone1: ").Append(Phone1).Append("\n");
      sb.Append("  ModifiesDateTimeOffset: ").Append(ModifiesDateTimeOffset).Append("\n");
      sb.Append("  PhoneFax: ").Append(PhoneFax).Append("\n");
      sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
      sb.Append("  AnnualTurnOver: ").Append(AnnualTurnOver).Append("\n");
      sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
      sb.Append("  NumberOfStaff: ").Append(NumberOfStaff).Append("\n");
      sb.Append("  IncorporatedDate: ").Append(IncorporatedDate).Append("\n");
      sb.Append("  WebSiteURL: ").Append(WebSiteURL).Append("\n");
      sb.Append("  IndustryType: ").Append(IndustryType).Append("\n");
      sb.Append("  Structure: ").Append(Structure).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsLinked: ").Append(IsLinked).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
      sb.Append("  DeliveryNotes: ").Append(DeliveryNotes).Append("\n");
      sb.Append("  LinkedTenantGlobalCode: ").Append(LinkedTenantGlobalCode).Append("\n");
      sb.Append("  LinkedTenantGlobalIDstring: ").Append(LinkedTenantGlobalIDstring).Append("\n");
      sb.Append("  Locations: ").Append(Locations).Append("\n");
      sb.Append("  Contacts: ").Append(Contacts).Append("\n");
      sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
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
