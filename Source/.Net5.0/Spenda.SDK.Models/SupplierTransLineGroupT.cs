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
  public class SupplierTransLineGroupT {
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
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="Lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Lines")]
    public List<SupplierTransLineT> Lines { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransLineGroupT {\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
      sb.Append("  SupplierGUIDstring: ").Append(SupplierGUIDstring).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
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
