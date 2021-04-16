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
  public class InventoryVariationT {
    /// <summary>
    /// Gets or Sets MasterInventoryID
    /// </summary>
    [DataMember(Name="MasterInventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MasterInventoryID")]
    public int? MasterInventoryID { get; set; }

    /// <summary>
    /// Gets or Sets VariationID
    /// </summary>
    [DataMember(Name="VariationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationID")]
    public int? VariationID { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AbbreviatedName
    /// </summary>
    [DataMember(Name="AbbreviatedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AbbreviatedName")]
    public string AbbreviatedName { get; set; }

    /// <summary>
    /// Gets or Sets SequenceNumber
    /// </summary>
    [DataMember(Name="SequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SequenceNumber")]
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="Options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Options")]
    public List<InventoryVariationOptionT> Options { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryVariationT {\n");
      sb.Append("  MasterInventoryID: ").Append(MasterInventoryID).Append("\n");
      sb.Append("  VariationID: ").Append(VariationID).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
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
