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
  public class UpdateTransStatusRequest {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusUpdateReason
    /// </summary>
    [DataMember(Name="StatusUpdateReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusUpdateReason")]
    public string StatusUpdateReason { get; set; }

    /// <summary>
    /// Gets or Sets IsQueue
    /// </summary>
    [DataMember(Name="IsQueue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsQueue")]
    public bool? IsQueue { get; set; }

    /// <summary>
    /// Gets or Sets IsSaveAutoQueue
    /// </summary>
    [DataMember(Name="IsSaveAutoQueue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSaveAutoQueue")]
    public bool? IsSaveAutoQueue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTransStatusRequest {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusUpdateReason: ").Append(StatusUpdateReason).Append("\n");
      sb.Append("  IsQueue: ").Append(IsQueue).Append("\n");
      sb.Append("  IsSaveAutoQueue: ").Append(IsSaveAutoQueue).Append("\n");
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
