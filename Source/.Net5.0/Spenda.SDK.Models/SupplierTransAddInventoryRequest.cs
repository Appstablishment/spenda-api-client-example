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
  public class SupplierTransAddInventoryRequest {
    /// <summary>
    /// Gets or Sets InventoryList
    /// </summary>
    [DataMember(Name="InventoryList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryList")]
    public List<SupplierTransAddInventoryItem> InventoryList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransAddInventoryRequest {\n");
      sb.Append("  InventoryList: ").Append(InventoryList).Append("\n");
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
