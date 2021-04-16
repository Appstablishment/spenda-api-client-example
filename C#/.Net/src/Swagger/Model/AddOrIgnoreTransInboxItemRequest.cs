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
  public class AddOrIgnoreTransInboxItemRequest {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets SetCustomerToAutoAddItems
    /// </summary>
    [DataMember(Name="SetCustomerToAutoAddItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SetCustomerToAutoAddItems")]
    public bool? SetCustomerToAutoAddItems { get; set; }

    /// <summary>
    /// Gets or Sets InboxIDs
    /// </summary>
    [DataMember(Name="InboxIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboxIDs")]
    public List<int?> InboxIDs { get; set; }

    /// <summary>
    /// Gets or Sets AssignToUserID
    /// </summary>
    [DataMember(Name="AssignToUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssignToUserID")]
    public int? AssignToUserID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddOrIgnoreTransInboxItemRequest {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SetCustomerToAutoAddItems: ").Append(SetCustomerToAutoAddItems).Append("\n");
      sb.Append("  InboxIDs: ").Append(InboxIDs).Append("\n");
      sb.Append("  AssignToUserID: ").Append(AssignToUserID).Append("\n");
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
