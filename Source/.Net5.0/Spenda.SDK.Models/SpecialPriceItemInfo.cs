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
  public class SpecialPriceItemInfo {
    /// <summary>
    /// Gets or Sets SpecialPriceItemID
    /// </summary>
    [DataMember(Name="SpecialPriceItemID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialPriceItemID")]
    public int? SpecialPriceItemID { get; set; }

    /// <summary>
    /// Gets or Sets SpecialPriceID
    /// </summary>
    [DataMember(Name="SpecialPriceID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialPriceID")]
    public int? SpecialPriceID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryClassID
    /// </summary>
    [DataMember(Name="InventoryClassID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryClassID")]
    public int? InventoryClassID { get; set; }

    /// <summary>
    /// Gets or Sets BrandID
    /// </summary>
    [DataMember(Name="BrandID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrandID")]
    public int? BrandID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryID
    /// </summary>
    [DataMember(Name="InventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryID")]
    public int? InventoryID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCode
    /// </summary>
    [DataMember(Name="InventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCode")]
    public string InventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets InventoryShortDescription
    /// </summary>
    [DataMember(Name="InventoryShortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryShortDescription")]
    public string InventoryShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets InventoryUoM
    /// </summary>
    [DataMember(Name="InventoryUoM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryUoM")]
    public string InventoryUoM { get; set; }

    /// <summary>
    /// Gets or Sets InventoryClassName
    /// </summary>
    [DataMember(Name="InventoryClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryClassName")]
    public string InventoryClassName { get; set; }

    /// <summary>
    /// Gets or Sets BrandName
    /// </summary>
    [DataMember(Name="BrandName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrandName")]
    public string BrandName { get; set; }

    /// <summary>
    /// Gets or Sets PriceBandName
    /// </summary>
    [DataMember(Name="PriceBandName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceBandName")]
    public string PriceBandName { get; set; }

    /// <summary>
    /// Gets or Sets PriceBandID
    /// </summary>
    [DataMember(Name="PriceBandID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceBandID")]
    public int? PriceBandID { get; set; }

    /// <summary>
    /// Gets or Sets PricingMode
    /// </summary>
    [DataMember(Name="PricingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PricingMode")]
    public int? PricingMode { get; set; }

    /// <summary>
    /// Gets or Sets PercentageAdjustment
    /// </summary>
    [DataMember(Name="PercentageAdjustment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PercentageAdjustment")]
    public double? PercentageAdjustment { get; set; }

    /// <summary>
    /// Gets or Sets SpecialPrice
    /// </summary>
    [DataMember(Name="SpecialPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialPrice")]
    public double? SpecialPrice { get; set; }

    /// <summary>
    /// Gets or Sets InventorySellPriceEx
    /// </summary>
    [DataMember(Name="InventorySellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventorySellPriceEx")]
    public double? InventorySellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets InventorySellPriceInc
    /// </summary>
    [DataMember(Name="InventorySellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventorySellPriceInc")]
    public double? InventorySellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCostPrice
    /// </summary>
    [DataMember(Name="InventoryCostPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCostPrice")]
    public double? InventoryCostPrice { get; set; }

    /// <summary>
    /// Gets or Sets SpecialPriceString
    /// </summary>
    [DataMember(Name="SpecialPriceString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialPriceString")]
    public string SpecialPriceString { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCostPriceString
    /// </summary>
    [DataMember(Name="InventoryCostPriceString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCostPriceString")]
    public string InventoryCostPriceString { get; set; }

    /// <summary>
    /// Gets or Sets InventorySellPriceExString
    /// </summary>
    [DataMember(Name="InventorySellPriceExString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventorySellPriceExString")]
    public string InventorySellPriceExString { get; set; }

    /// <summary>
    /// Gets or Sets InventorySellPriceIncString
    /// </summary>
    [DataMember(Name="InventorySellPriceIncString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventorySellPriceIncString")]
    public string InventorySellPriceIncString { get; set; }

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
      sb.Append("class SpecialPriceItemInfo {\n");
      sb.Append("  SpecialPriceItemID: ").Append(SpecialPriceItemID).Append("\n");
      sb.Append("  SpecialPriceID: ").Append(SpecialPriceID).Append("\n");
      sb.Append("  InventoryClassID: ").Append(InventoryClassID).Append("\n");
      sb.Append("  BrandID: ").Append(BrandID).Append("\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  InventoryCode: ").Append(InventoryCode).Append("\n");
      sb.Append("  InventoryShortDescription: ").Append(InventoryShortDescription).Append("\n");
      sb.Append("  InventoryUoM: ").Append(InventoryUoM).Append("\n");
      sb.Append("  InventoryClassName: ").Append(InventoryClassName).Append("\n");
      sb.Append("  BrandName: ").Append(BrandName).Append("\n");
      sb.Append("  PriceBandName: ").Append(PriceBandName).Append("\n");
      sb.Append("  PriceBandID: ").Append(PriceBandID).Append("\n");
      sb.Append("  PricingMode: ").Append(PricingMode).Append("\n");
      sb.Append("  PercentageAdjustment: ").Append(PercentageAdjustment).Append("\n");
      sb.Append("  SpecialPrice: ").Append(SpecialPrice).Append("\n");
      sb.Append("  InventorySellPriceEx: ").Append(InventorySellPriceEx).Append("\n");
      sb.Append("  InventorySellPriceInc: ").Append(InventorySellPriceInc).Append("\n");
      sb.Append("  InventoryCostPrice: ").Append(InventoryCostPrice).Append("\n");
      sb.Append("  SpecialPriceString: ").Append(SpecialPriceString).Append("\n");
      sb.Append("  InventoryCostPriceString: ").Append(InventoryCostPriceString).Append("\n");
      sb.Append("  InventorySellPriceExString: ").Append(InventorySellPriceExString).Append("\n");
      sb.Append("  InventorySellPriceIncString: ").Append(InventorySellPriceIncString).Append("\n");
      sb.Append("  PricingModeString: ").Append(PricingModeString).Append("\n");
      sb.Append("  PercentageAdjustmentString: ").Append(PercentageAdjustmentString).Append("\n");
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
