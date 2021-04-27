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
  public class SupplierTransAddInventoryItem {
    /// <summary>
    /// Gets or Sets InventoryID
    /// </summary>
    [DataMember(Name="InventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryID")]
    public int? InventoryID { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets AdjustedQuantityReceived
    /// </summary>
    [DataMember(Name="AdjustedQuantityReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustedQuantityReceived")]
    public double? AdjustedQuantityReceived { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceEx
    /// </summary>
    [DataMember(Name="BuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceEx")]
    public double? BuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceTax
    /// </summary>
    [DataMember(Name="BuyPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceTax")]
    public double? BuyPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets LineTotal
    /// </summary>
    [DataMember(Name="LineTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotal")]
    public double? LineTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransAddInventoryItem {\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  AdjustedQuantityReceived: ").Append(AdjustedQuantityReceived).Append("\n");
      sb.Append("  BuyPriceEx: ").Append(BuyPriceEx).Append("\n");
      sb.Append("  BuyPriceTax: ").Append(BuyPriceTax).Append("\n");
      sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
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
