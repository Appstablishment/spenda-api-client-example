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
  public class WarehouseStockOnHandT {
    /// <summary>
    /// Gets or Sets RowNumber
    /// </summary>
    [DataMember(Name="RowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RowNumber")]
    public long? RowNumber { get; set; }

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
    /// Gets or Sets WarehouseTypeName
    /// </summary>
    [DataMember(Name="WarehouseTypeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseTypeName")]
    public string WarehouseTypeName { get; set; }

    /// <summary>
    /// Gets or Sets IsStockOpeningBalanceComplete
    /// </summary>
    [DataMember(Name="IsStockOpeningBalanceComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsStockOpeningBalanceComplete")]
    public bool? IsStockOpeningBalanceComplete { get; set; }

    /// <summary>
    /// Gets or Sets TenantLocationAddress
    /// </summary>
    [DataMember(Name="TenantLocationAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantLocationAddress")]
    public AddressT TenantLocationAddress { get; set; }

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
    /// Gets or Sets DefaultPickingLocationID
    /// </summary>
    [DataMember(Name="DefaultPickingLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPickingLocationID")]
    public int? DefaultPickingLocationID { get; set; }

    /// <summary>
    /// Gets or Sets DefaultReceiveLocationID
    /// </summary>
    [DataMember(Name="DefaultReceiveLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReceiveLocationID")]
    public int? DefaultReceiveLocationID { get; set; }

    /// <summary>
    /// Gets or Sets Locations
    /// </summary>
    [DataMember(Name="Locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Locations")]
    public List<WarehouseLocationStockOnHandT> Locations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WarehouseStockOnHandT {\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  WarehouseTypeName: ").Append(WarehouseTypeName).Append("\n");
      sb.Append("  IsStockOpeningBalanceComplete: ").Append(IsStockOpeningBalanceComplete).Append("\n");
      sb.Append("  TenantLocationAddress: ").Append(TenantLocationAddress).Append("\n");
      sb.Append("  TotalStockOnOrder: ").Append(TotalStockOnOrder).Append("\n");
      sb.Append("  TotalSOH: ").Append(TotalSOH).Append("\n");
      sb.Append("  TotalStockCommitted: ").Append(TotalStockCommitted).Append("\n");
      sb.Append("  TotalStockAvailable: ").Append(TotalStockAvailable).Append("\n");
      sb.Append("  TotalStockInTransit: ").Append(TotalStockInTransit).Append("\n");
      sb.Append("  MinSOHQuantity: ").Append(MinSOHQuantity).Append("\n");
      sb.Append("  MaxSOHQuantity: ").Append(MaxSOHQuantity).Append("\n");
      sb.Append("  DefaultPickingLocationID: ").Append(DefaultPickingLocationID).Append("\n");
      sb.Append("  DefaultReceiveLocationID: ").Append(DefaultReceiveLocationID).Append("\n");
      sb.Append("  Locations: ").Append(Locations).Append("\n");
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
