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
  public class SupplierTransGroupT {
    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierName
    /// </summary>
    [DataMember(Name="SupplierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierName")]
    public string SupplierName { get; set; }

    /// <summary>
    /// Gets or Sets SupplierGUIDstring
    /// </summary>
    [DataMember(Name="SupplierGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierGUIDstring")]
    public string SupplierGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseName
    /// </summary>
    [DataMember(Name="WarehouseName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseName")]
    public string WarehouseName { get; set; }

    /// <summary>
    /// Gets or Sets TransCount
    /// </summary>
    [DataMember(Name="TransCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransCount")]
    public int? TransCount { get; set; }

    /// <summary>
    /// Gets or Sets LineCount
    /// </summary>
    [DataMember(Name="LineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineCount")]
    public int? LineCount { get; set; }

    /// <summary>
    /// Gets or Sets ProductCount
    /// </summary>
    [DataMember(Name="ProductCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductCount")]
    public int? ProductCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalBuyPriceEx
    /// </summary>
    [DataMember(Name="TotalBuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalBuyPriceEx")]
    public double? TotalBuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets TotalBuyPriceTax
    /// </summary>
    [DataMember(Name="TotalBuyPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalBuyPriceTax")]
    public double? TotalBuyPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets TotalBuyPriceInc
    /// </summary>
    [DataMember(Name="TotalBuyPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalBuyPriceInc")]
    public double? TotalBuyPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets TotalQuantity
    /// </summary>
    [DataMember(Name="TotalQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalQuantity")]
    public double? TotalQuantity { get; set; }

    /// <summary>
    /// Gets or Sets LinkedTransactions
    /// </summary>
    [DataMember(Name="LinkedTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedTransactions")]
    public List<LinkedTransactionT> LinkedTransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransGroupT {\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
      sb.Append("  SupplierGUIDstring: ").Append(SupplierGUIDstring).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  TransCount: ").Append(TransCount).Append("\n");
      sb.Append("  LineCount: ").Append(LineCount).Append("\n");
      sb.Append("  ProductCount: ").Append(ProductCount).Append("\n");
      sb.Append("  TotalBuyPriceEx: ").Append(TotalBuyPriceEx).Append("\n");
      sb.Append("  TotalBuyPriceTax: ").Append(TotalBuyPriceTax).Append("\n");
      sb.Append("  TotalBuyPriceInc: ").Append(TotalBuyPriceInc).Append("\n");
      sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
      sb.Append("  LinkedTransactions: ").Append(LinkedTransactions).Append("\n");
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
