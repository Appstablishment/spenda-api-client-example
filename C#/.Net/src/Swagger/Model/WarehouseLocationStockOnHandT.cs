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
  public class WarehouseLocationStockOnHandT {
    /// <summary>
    /// Gets or Sets WarehouseLocationID
    /// </summary>
    [DataMember(Name="WarehouseLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseLocationID")]
    public int? WarehouseLocationID { get; set; }

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
    /// Gets or Sets Barcode
    /// </summary>
    [DataMember(Name="Barcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Barcode")]
    public string Barcode { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseLocationTypeID
    /// </summary>
    [DataMember(Name="WarehouseLocationTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseLocationTypeID")]
    public int? WarehouseLocationTypeID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseLocationTypeName
    /// </summary>
    [DataMember(Name="WarehouseLocationTypeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseLocationTypeName")]
    public string WarehouseLocationTypeName { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets TotalSOH
    /// </summary>
    [DataMember(Name="TotalSOH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalSOH")]
    public double? TotalSOH { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WarehouseLocationStockOnHandT {\n");
      sb.Append("  WarehouseLocationID: ").Append(WarehouseLocationID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Barcode: ").Append(Barcode).Append("\n");
      sb.Append("  WarehouseLocationTypeID: ").Append(WarehouseLocationTypeID).Append("\n");
      sb.Append("  WarehouseLocationTypeName: ").Append(WarehouseLocationTypeName).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  TotalSOH: ").Append(TotalSOH).Append("\n");
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
