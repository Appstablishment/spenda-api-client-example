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
  public class SynkSaveQueueResponseOfPaymentT {
    /// <summary>
    /// Gets or Sets _Object
    /// </summary>
    [DataMember(Name="Object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Object")]
    public PaymentT _Object { get; set; }

    /// <summary>
    /// Gets or Sets IsQueued
    /// </summary>
    [DataMember(Name="IsQueued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsQueued")]
    public bool? IsQueued { get; set; }

    /// <summary>
    /// Gets or Sets IsQueuePrompt
    /// </summary>
    [DataMember(Name="IsQueuePrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsQueuePrompt")]
    public bool? IsQueuePrompt { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public SynkValidation Value { get; set; }

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
      sb.Append("class SynkSaveQueueResponseOfPaymentT {\n");
      sb.Append("  _Object: ").Append(_Object).Append("\n");
      sb.Append("  IsQueued: ").Append(IsQueued).Append("\n");
      sb.Append("  IsQueuePrompt: ").Append(IsQueuePrompt).Append("\n");
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
