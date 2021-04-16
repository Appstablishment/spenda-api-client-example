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
  public class InventoryStockOnHandT {
    /// <summary>
    /// Gets or Sets RowNumber
    /// </summary>
    [DataMember(Name="RowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RowNumber")]
    public long? RowNumber { get; set; }

    /// <summary>
    /// Gets or Sets InventoryID
    /// </summary>
    [DataMember(Name="InventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryID")]
    public string InventoryID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCode
    /// </summary>
    [DataMember(Name="InventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCode")]
    public string InventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShortDescription")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets StockOnHand
    /// </summary>
    [DataMember(Name="StockOnHand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StockOnHand")]
    public List<WarehouseStockOnHandT> StockOnHand { get; set; }

    /// <summary>
    /// Gets or Sets TotalWarehouses
    /// </summary>
    [DataMember(Name="TotalWarehouses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalWarehouses")]
    public int? TotalWarehouses { get; set; }

    /// <summary>
    /// Gets or Sets TotalPhysicalWarehouses
    /// </summary>
    [DataMember(Name="TotalPhysicalWarehouses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalPhysicalWarehouses")]
    public int? TotalPhysicalWarehouses { get; set; }

    /// <summary>
    /// Gets or Sets TotalMobileWarehouses
    /// </summary>
    [DataMember(Name="TotalMobileWarehouses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalMobileWarehouses")]
    public int? TotalMobileWarehouses { get; set; }

    /// <summary>
    /// Gets or Sets TotalStockOnOrder
    /// </summary>
    [DataMember(Name="TotalStockOnOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalStockOnOrder")]
    public double? TotalStockOnOrder { get; set; }

    /// <summary>
    /// Gets or Sets TotalSOH
    /// </summary>
    [DataMember(Name="TotalSOH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalSOH")]
    public double? TotalSOH { get; set; }

    /// <summary>
    /// Gets or Sets TotalStockCommitted
    /// </summary>
    [DataMember(Name="TotalStockCommitted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalStockCommitted")]
    public double? TotalStockCommitted { get; set; }

    /// <summary>
    /// Gets or Sets TotalStockAvailable
    /// </summary>
    [DataMember(Name="TotalStockAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalStockAvailable")]
    public double? TotalStockAvailable { get; set; }

    /// <summary>
    /// Gets or Sets TotalStockInTransit
    /// </summary>
    [DataMember(Name="TotalStockInTransit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalStockInTransit")]
    public double? TotalStockInTransit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryStockOnHandT {\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  InventoryCode: ").Append(InventoryCode).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  StockOnHand: ").Append(StockOnHand).Append("\n");
      sb.Append("  TotalWarehouses: ").Append(TotalWarehouses).Append("\n");
      sb.Append("  TotalPhysicalWarehouses: ").Append(TotalPhysicalWarehouses).Append("\n");
      sb.Append("  TotalMobileWarehouses: ").Append(TotalMobileWarehouses).Append("\n");
      sb.Append("  TotalStockOnOrder: ").Append(TotalStockOnOrder).Append("\n");
      sb.Append("  TotalSOH: ").Append(TotalSOH).Append("\n");
      sb.Append("  TotalStockCommitted: ").Append(TotalStockCommitted).Append("\n");
      sb.Append("  TotalStockAvailable: ").Append(TotalStockAvailable).Append("\n");
      sb.Append("  TotalStockInTransit: ").Append(TotalStockInTransit).Append("\n");
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
