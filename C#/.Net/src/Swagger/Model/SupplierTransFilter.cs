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
  public class SupplierTransFilter {
    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets TransIDs
    /// </summary>
    [DataMember(Name="TransIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransIDs")]
    public List<int?> TransIDs { get; set; }

    /// <summary>
    /// Gets or Sets SortField
    /// </summary>
    [DataMember(Name="SortField", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SortField")]
    public string SortField { get; set; }

    /// <summary>
    /// Gets or Sets SearchString
    /// </summary>
    [DataMember(Name="SearchString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchString")]
    public string SearchString { get; set; }

    /// <summary>
    /// Gets or Sets SortAsc
    /// </summary>
    [DataMember(Name="SortAsc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SortAsc")]
    public bool? SortAsc { get; set; }

    /// <summary>
    /// Gets or Sets StartRow
    /// </summary>
    [DataMember(Name="StartRow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartRow")]
    public int? StartRow { get; set; }

    /// <summary>
    /// Gets or Sets MaxResults
    /// </summary>
    [DataMember(Name="MaxResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxResults")]
    public int? MaxResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransFilter {\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  TransIDs: ").Append(TransIDs).Append("\n");
      sb.Append("  SortField: ").Append(SortField).Append("\n");
      sb.Append("  SearchString: ").Append(SearchString).Append("\n");
      sb.Append("  SortAsc: ").Append(SortAsc).Append("\n");
      sb.Append("  StartRow: ").Append(StartRow).Append("\n");
      sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
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
