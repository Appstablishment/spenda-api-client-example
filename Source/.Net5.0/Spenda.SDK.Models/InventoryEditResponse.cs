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
  public class InventoryEditResponse {
    /// <summary>
    /// Gets or Sets UomTypes
    /// </summary>
    [DataMember(Name="UomTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UomTypes")]
    public List<UnitOfMeasure> UomTypes { get; set; }

    /// <summary>
    /// Gets or Sets Classes
    /// </summary>
    [DataMember(Name="Classes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Classes")]
    public List<InventoryClassT> Classes { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public InventoryItemT Value { get; set; }

    /// <summary>
    /// Gets or Sets IsSuccess
    /// </summary>
    [DataMember(Name="IsSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSuccess")]
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="Messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Messages")]
    public List<string> Messages { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorCode")]
    public int? ErrorCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryEditResponse {\n");
      sb.Append("  UomTypes: ").Append(UomTypes).Append("\n");
      sb.Append("  Classes: ").Append(Classes).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
