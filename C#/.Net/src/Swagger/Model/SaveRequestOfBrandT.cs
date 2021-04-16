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
  public class SaveRequestOfBrandT {
    /// <summary>
    /// Gets or Sets _Object
    /// </summary>
    [DataMember(Name="Object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Object")]
    public BrandT _Object { get; set; }

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
      sb.Append("class SaveRequestOfBrandT {\n");
      sb.Append("  _Object: ").Append(_Object).Append("\n");
      sb.Append("  IsQueue: ").Append(IsQueue).Append("\n");
      sb.Append("  IsSaveAutoQueue: ").Append(IsSaveAutoQueue).Append("\n");
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
