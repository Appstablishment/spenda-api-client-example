using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SDK.SpendaApi.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WarehouseTypeT {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseTypeID
    /// </summary>
    [DataMember(Name="WarehouseTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseTypeID")]
    public int? WarehouseTypeID { get; set; }

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
    /// Gets or Sets IsVirtual
    /// </summary>
    [DataMember(Name="IsVirtual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVirtual")]
    public bool? IsVirtual { get; set; }

    /// <summary>
    /// Gets or Sets RefNumberPrefix
    /// </summary>
    [DataMember(Name="RefNumberPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumberPrefix")]
    public string RefNumberPrefix { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WarehouseTypeT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  WarehouseTypeID: ").Append(WarehouseTypeID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
      sb.Append("  RefNumberPrefix: ").Append(RefNumberPrefix).Append("\n");
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
