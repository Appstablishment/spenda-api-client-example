using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Spenda.SDK.Models {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CustomerClassT {
    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets HasBeenSaved
    /// </summary>
    [DataMember(Name="HasBeenSaved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasBeenSaved")]
    public bool? HasBeenSaved { get; set; }

    /// <summary>
    /// Gets or Sets IsAutoCreateGenericAccountCustomer
    /// </summary>
    [DataMember(Name="IsAutoCreateGenericAccountCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAutoCreateGenericAccountCustomer")]
    public bool? IsAutoCreateGenericAccountCustomer { get; set; }

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
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsBatchInvoice
    /// </summary>
    [DataMember(Name="IsBatchInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsBatchInvoice")]
    public bool? IsBatchInvoice { get; set; }

    /// <summary>
    /// Gets or Sets BatchInvoiceFrequencyDays
    /// </summary>
    [DataMember(Name="BatchInvoiceFrequencyDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BatchInvoiceFrequencyDays")]
    public int? BatchInvoiceFrequencyDays { get; set; }

    /// <summary>
    /// Gets or Sets BatchInvoicePrefix
    /// </summary>
    [DataMember(Name="BatchInvoicePrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BatchInvoicePrefix")]
    public string BatchInvoicePrefix { get; set; }

    /// <summary>
    /// Gets or Sets GenericAccountCustomerID
    /// </summary>
    [DataMember(Name="GenericAccountCustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GenericAccountCustomerID")]
    public int? GenericAccountCustomerID { get; set; }

    /// <summary>
    /// Gets or Sets GenericAccountCustomerName
    /// </summary>
    [DataMember(Name="GenericAccountCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GenericAccountCustomerName")]
    public string GenericAccountCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets PostingBehaviour
    /// </summary>
    [DataMember(Name="PostingBehaviour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostingBehaviour")]
    public string PostingBehaviour { get; set; }

    /// <summary>
    /// Gets or Sets CreditLimit
    /// </summary>
    [DataMember(Name="CreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditLimit")]
    public double? CreditLimit { get; set; }

    /// <summary>
    /// Gets or Sets TradingTermDays
    /// </summary>
    [DataMember(Name="TradingTermDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TradingTermDays")]
    public int? TradingTermDays { get; set; }

    /// <summary>
    /// Gets or Sets TradingTermID
    /// </summary>
    [DataMember(Name="TradingTermID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TradingTermID")]
    public int? TradingTermID { get; set; }

    /// <summary>
    /// Gets or Sets TradingTermType
    /// </summary>
    [DataMember(Name="TradingTermType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TradingTermType")]
    public string TradingTermType { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPricingBandID
    /// </summary>
    [DataMember(Name="DefaultPricingBandID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPricingBandID")]
    public int? DefaultPricingBandID { get; set; }

    /// <summary>
    /// Gets or Sets IsApprovedForWeb
    /// </summary>
    [DataMember(Name="IsApprovedForWeb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsApprovedForWeb")]
    public bool? IsApprovedForWeb { get; set; }

    /// <summary>
    /// Gets or Sets IsApprovedForService
    /// </summary>
    [DataMember(Name="IsApprovedForService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsApprovedForService")]
    public bool? IsApprovedForService { get; set; }

    /// <summary>
    /// Gets or Sets IsApprovedForPOS
    /// </summary>
    [DataMember(Name="IsApprovedForPOS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsApprovedForPOS")]
    public bool? IsApprovedForPOS { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerRefNumberPrefix
    /// </summary>
    [DataMember(Name="AccountCustomerRefNumberPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerRefNumberPrefix")]
    public string AccountCustomerRefNumberPrefix { get; set; }

    /// <summary>
    /// Gets or Sets CountOfCustomers
    /// </summary>
    [DataMember(Name="CountOfCustomers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountOfCustomers")]
    public int? CountOfCustomers { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets IsExemptFromMerchantSurcharge
    /// </summary>
    [DataMember(Name="IsExemptFromMerchantSurcharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExemptFromMerchantSurcharge")]
    public bool? IsExemptFromMerchantSurcharge { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerClassT {\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  HasBeenSaved: ").Append(HasBeenSaved).Append("\n");
      sb.Append("  IsAutoCreateGenericAccountCustomer: ").Append(IsAutoCreateGenericAccountCustomer).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsBatchInvoice: ").Append(IsBatchInvoice).Append("\n");
      sb.Append("  BatchInvoiceFrequencyDays: ").Append(BatchInvoiceFrequencyDays).Append("\n");
      sb.Append("  BatchInvoicePrefix: ").Append(BatchInvoicePrefix).Append("\n");
      sb.Append("  GenericAccountCustomerID: ").Append(GenericAccountCustomerID).Append("\n");
      sb.Append("  GenericAccountCustomerName: ").Append(GenericAccountCustomerName).Append("\n");
      sb.Append("  PostingBehaviour: ").Append(PostingBehaviour).Append("\n");
      sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
      sb.Append("  TradingTermDays: ").Append(TradingTermDays).Append("\n");
      sb.Append("  TradingTermID: ").Append(TradingTermID).Append("\n");
      sb.Append("  TradingTermType: ").Append(TradingTermType).Append("\n");
      sb.Append("  DefaultPricingBandID: ").Append(DefaultPricingBandID).Append("\n");
      sb.Append("  IsApprovedForWeb: ").Append(IsApprovedForWeb).Append("\n");
      sb.Append("  IsApprovedForService: ").Append(IsApprovedForService).Append("\n");
      sb.Append("  IsApprovedForPOS: ").Append(IsApprovedForPOS).Append("\n");
      sb.Append("  AccountCustomerRefNumberPrefix: ").Append(AccountCustomerRefNumberPrefix).Append("\n");
      sb.Append("  CountOfCustomers: ").Append(CountOfCustomers).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  IsExemptFromMerchantSurcharge: ").Append(IsExemptFromMerchantSurcharge).Append("\n");
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
