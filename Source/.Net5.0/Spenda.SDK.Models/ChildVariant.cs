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
  public class ChildVariant {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets SKU
    /// </summary>
    [DataMember(Name="SKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SKU")]
    public string SKU { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShortDescription")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets IsVariantPriceOverride
    /// </summary>
    [DataMember(Name="IsVariantPriceOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVariantPriceOverride")]
    public bool? IsVariantPriceOverride { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceEx
    /// </summary>
    [DataMember(Name="StandardSellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceEx")]
    public decimal? StandardSellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceInc
    /// </summary>
    [DataMember(Name="StandardSellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceInc")]
    public decimal? StandardSellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceEx
    /// </summary>
    [DataMember(Name="CostPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceEx")]
    public decimal? CostPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets VariationOptions
    /// </summary>
    [DataMember(Name="VariationOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationOptions")]
    public List<InventoryVariationOptionT> VariationOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChildVariant {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  SKU: ").Append(SKU).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  IsVariantPriceOverride: ").Append(IsVariantPriceOverride).Append("\n");
      sb.Append("  StandardSellPriceEx: ").Append(StandardSellPriceEx).Append("\n");
      sb.Append("  StandardSellPriceInc: ").Append(StandardSellPriceInc).Append("\n");
      sb.Append("  CostPriceEx: ").Append(CostPriceEx).Append("\n");
      sb.Append("  VariationOptions: ").Append(VariationOptions).Append("\n");
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
