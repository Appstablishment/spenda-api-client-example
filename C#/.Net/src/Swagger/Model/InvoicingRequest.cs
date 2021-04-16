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
  public class InvoicingRequest {
    /// <summary>
    /// Gets or Sets IDs
    /// </summary>
    [DataMember(Name="IDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IDs")]
    public List<int?> IDs { get; set; }

    /// <summary>
    /// Gets or Sets IsForceRecreate
    /// </summary>
    [DataMember(Name="IsForceRecreate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsForceRecreate")]
    public bool? IsForceRecreate { get; set; }

    /// <summary>
    /// Gets or Sets IsPickedOnly
    /// </summary>
    [DataMember(Name="IsPickedOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPickedOnly")]
    public bool? IsPickedOnly { get; set; }

    /// <summary>
    /// Gets or Sets TenantID
    /// </summary>
    [DataMember(Name="TenantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantID")]
    public int? TenantID { get; set; }

    /// <summary>
    /// Gets or Sets WebsiteID
    /// </summary>
    [DataMember(Name="WebsiteID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebsiteID")]
    public int? WebsiteID { get; set; }

    /// <summary>
    /// Gets or Sets UserID
    /// </summary>
    [DataMember(Name="UserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserID")]
    public int? UserID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoicingRequest {\n");
      sb.Append("  IDs: ").Append(IDs).Append("\n");
      sb.Append("  IsForceRecreate: ").Append(IsForceRecreate).Append("\n");
      sb.Append("  IsPickedOnly: ").Append(IsPickedOnly).Append("\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  WebsiteID: ").Append(WebsiteID).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
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
