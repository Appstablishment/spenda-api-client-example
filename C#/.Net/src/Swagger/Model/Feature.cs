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
  public class Feature {
    /// <summary>
    /// Gets or Sets FeatureID
    /// </summary>
    [DataMember(Name="FeatureID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureID")]
    public int? FeatureID { get; set; }

    /// <summary>
    /// Gets or Sets FeatureName
    /// </summary>
    [DataMember(Name="FeatureName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeatureName")]
    public string FeatureName { get; set; }

    /// <summary>
    /// Gets or Sets ValuesList
    /// </summary>
    [DataMember(Name="ValuesList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValuesList")]
    public List<FeatureValue> ValuesList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Feature {\n");
      sb.Append("  FeatureID: ").Append(FeatureID).Append("\n");
      sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
      sb.Append("  ValuesList: ").Append(ValuesList).Append("\n");
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
