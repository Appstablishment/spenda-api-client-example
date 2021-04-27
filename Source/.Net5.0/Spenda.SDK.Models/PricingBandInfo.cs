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
  public class PricingBandInfo {
    /// <summary>
    /// Gets or Sets DiscountPercent
    /// </summary>
    [DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountPercent")]
    public double? DiscountPercent { get; set; }

    /// <summary>
    /// Gets or Sets CostPlusPercent
    /// </summary>
    [DataMember(Name="CostPlusPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPlusPercent")]
    public double? CostPlusPercent { get; set; }

    /// <summary>
    /// Gets or Sets GrossProfitValue
    /// </summary>
    [DataMember(Name="GrossProfitValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GrossProfitValue")]
    public double? GrossProfitValue { get; set; }

    /// <summary>
    /// Gets or Sets GrossProfitPercent
    /// </summary>
    [DataMember(Name="GrossProfitPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GrossProfitPercent")]
    public double? GrossProfitPercent { get; set; }

    /// <summary>
    /// Gets or Sets RoundingFactor
    /// </summary>
    [DataMember(Name="RoundingFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoundingFactor")]
    public int? RoundingFactor { get; set; }

    /// <summary>
    /// Gets or Sets PricingMode
    /// </summary>
    [DataMember(Name="PricingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PricingMode")]
    public int? PricingMode { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="Price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Price")]
    public double? Price { get; set; }

    /// <summary>
    /// Gets or Sets PricingModeString
    /// </summary>
    [DataMember(Name="PricingModeString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PricingModeString")]
    public string PricingModeString { get; set; }

    /// <summary>
    /// Gets or Sets PercentageAdjustmentString
    /// </summary>
    [DataMember(Name="PercentageAdjustmentString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PercentageAdjustmentString")]
    public string PercentageAdjustmentString { get; set; }

    /// <summary>
    /// Gets or Sets SpecialPriceList
    /// </summary>
    [DataMember(Name="SpecialPriceList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialPriceList")]
    public List<SpecialPriceItemInfo> SpecialPriceList { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

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
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="IsDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsCustomerDefault
    /// </summary>
    [DataMember(Name="IsCustomerDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCustomerDefault")]
    public bool? IsCustomerDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets ParentID
    /// </summary>
    [DataMember(Name="ParentID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentID")]
    public int? ParentID { get; set; }

    /// <summary>
    /// Gets or Sets ParentName
    /// </summary>
    [DataMember(Name="ParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentName")]
    public string ParentName { get; set; }

    /// <summary>
    /// Gets or Sets TenantID
    /// </summary>
    [DataMember(Name="TenantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantID")]
    public int? TenantID { get; set; }

    /// <summary>
    /// Gets or Sets WebsiteID
    /// </summary>
    [DataMember(Name="WebsiteID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebsiteID")]
    public int? WebsiteID { get; set; }

    /// <summary>
    /// Gets or Sets UserID
    /// </summary>
    [DataMember(Name="UserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserID")]
    public int? UserID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PricingBandInfo {\n");
      sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
      sb.Append("  CostPlusPercent: ").Append(CostPlusPercent).Append("\n");
      sb.Append("  GrossProfitValue: ").Append(GrossProfitValue).Append("\n");
      sb.Append("  GrossProfitPercent: ").Append(GrossProfitPercent).Append("\n");
      sb.Append("  RoundingFactor: ").Append(RoundingFactor).Append("\n");
      sb.Append("  PricingMode: ").Append(PricingMode).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PricingModeString: ").Append(PricingModeString).Append("\n");
      sb.Append("  PercentageAdjustmentString: ").Append(PercentageAdjustmentString).Append("\n");
      sb.Append("  SpecialPriceList: ").Append(SpecialPriceList).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  IsCustomerDefault: ").Append(IsCustomerDefault).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  ParentID: ").Append(ParentID).Append("\n");
      sb.Append("  ParentName: ").Append(ParentName).Append("\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  WebsiteID: ").Append(WebsiteID).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
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
