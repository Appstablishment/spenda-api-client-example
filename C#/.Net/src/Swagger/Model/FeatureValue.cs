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
  public class FeatureValue {
    /// <summary>
    /// Gets or Sets FeatureValueID
    /// </summary>
    [DataMember(Name="FeatureValueID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureValueID")]
    public int? FeatureValueID { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets IsBool
    /// </summary>
    [DataMember(Name="IsBool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsBool")]
    public bool? IsBool { get; set; }

    /// <summary>
    /// Gets or Sets RecordCount
    /// </summary>
    [DataMember(Name="RecordCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordCount")]
    public int? RecordCount { get; set; }

    /// <summary>
    /// Gets or Sets IsSelected
    /// </summary>
    [DataMember(Name="IsSelected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSelected")]
    public bool? IsSelected { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureValue {\n");
      sb.Append("  FeatureValueID: ").Append(FeatureValueID).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IsBool: ").Append(IsBool).Append("\n");
      sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
      sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
