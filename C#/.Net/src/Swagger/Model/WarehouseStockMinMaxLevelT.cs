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
  public class WarehouseStockMinMaxLevelT {
    /// <summary>
    /// Gets or Sets TenantID
    /// </summary>
    [DataMember(Name="TenantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantID")]
    public int? TenantID { get; set; }

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
    /// Gets or Sets MinSOHQuantity
    /// </summary>
    [DataMember(Name="MinSOHQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinSOHQuantity")]
    public double? MinSOHQuantity { get; set; }

    /// <summary>
    /// Gets or Sets MaxSOHQuantity
    /// </summary>
    [DataMember(Name="MaxSOHQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxSOHQuantity")]
    public double? MaxSOHQuantity { get; set; }

    /// <summary>
    /// Gets or Sets DefaultReceiveLocationID
    /// </summary>
    [DataMember(Name="DefaultReceiveLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReceiveLocationID")]
    public int? DefaultReceiveLocationID { get; set; }

    /// <summary>
    /// Gets or Sets DefaultReceiveLocationName
    /// </summary>
    [DataMember(Name="DefaultReceiveLocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReceiveLocationName")]
    public string DefaultReceiveLocationName { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPickingLocationID
    /// </summary>
    [DataMember(Name="DefaultPickingLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPickingLocationID")]
    public int? DefaultPickingLocationID { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPickingLocationName
    /// </summary>
    [DataMember(Name="DefaultPickingLocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPickingLocationName")]
    public string DefaultPickingLocationName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WarehouseStockMinMaxLevelT {\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  InventoryCode: ").Append(InventoryCode).Append("\n");
      sb.Append("  MinSOHQuantity: ").Append(MinSOHQuantity).Append("\n");
      sb.Append("  MaxSOHQuantity: ").Append(MaxSOHQuantity).Append("\n");
      sb.Append("  DefaultReceiveLocationID: ").Append(DefaultReceiveLocationID).Append("\n");
      sb.Append("  DefaultReceiveLocationName: ").Append(DefaultReceiveLocationName).Append("\n");
      sb.Append("  DefaultPickingLocationID: ").Append(DefaultPickingLocationID).Append("\n");
      sb.Append("  DefaultPickingLocationName: ").Append(DefaultPickingLocationName).Append("\n");
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
