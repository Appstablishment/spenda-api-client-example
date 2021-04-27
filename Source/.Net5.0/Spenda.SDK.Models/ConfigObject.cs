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
  public class ConfigObject {
    /// <summary>
    /// Gets or Sets ConfigID
    /// </summary>
    [DataMember(Name="ConfigID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConfigID")]
    public int? ConfigID { get; set; }

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
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="GroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupName")]
    public string GroupName { get; set; }

    /// <summary>
    /// Gets or Sets GroupFriendlyName
    /// </summary>
    [DataMember(Name="GroupFriendlyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupFriendlyName")]
    public string GroupFriendlyName { get; set; }

    /// <summary>
    /// Gets or Sets KeyName
    /// </summary>
    [DataMember(Name="KeyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyName")]
    public string KeyName { get; set; }

    /// <summary>
    /// Gets or Sets FriendlyName
    /// </summary>
    [DataMember(Name="FriendlyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FriendlyName")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets ValueType
    /// </summary>
    [DataMember(Name="ValueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValueType")]
    public string ValueType { get; set; }

    /// <summary>
    /// Gets or Sets ValueOptions
    /// </summary>
    [DataMember(Name="ValueOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValueOptions")]
    public List<string> ValueOptions { get; set; }

    /// <summary>
    /// Gets or Sets UserRoleID
    /// </summary>
    [DataMember(Name="UserRoleID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserRoleID")]
    public int? UserRoleID { get; set; }

    /// <summary>
    /// Gets or Sets UserID
    /// </summary>
    [DataMember(Name="UserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserID")]
    public int? UserID { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets UserCanEdit
    /// </summary>
    [DataMember(Name="UserCanEdit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserCanEdit")]
    public bool? UserCanEdit { get; set; }

    /// <summary>
    /// Gets or Sets IsReadOnly
    /// </summary>
    [DataMember(Name="IsReadOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReadOnly")]
    public bool? IsReadOnly { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets ValueAsDateTime
    /// </summary>
    [DataMember(Name="ValueAsDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValueAsDateTime")]
    public DateTime? ValueAsDateTime { get; set; }

    /// <summary>
    /// Gets or Sets IsEncrypted
    /// </summary>
    [DataMember(Name="IsEncrypted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEncrypted")]
    public bool? IsEncrypted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigObject {\n");
      sb.Append("  ConfigID: ").Append(ConfigID).Append("\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  WebsiteID: ").Append(WebsiteID).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  GroupFriendlyName: ").Append(GroupFriendlyName).Append("\n");
      sb.Append("  KeyName: ").Append(KeyName).Append("\n");
      sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
      sb.Append("  ValueOptions: ").Append(ValueOptions).Append("\n");
      sb.Append("  UserRoleID: ").Append(UserRoleID).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  UserCanEdit: ").Append(UserCanEdit).Append("\n");
      sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  ValueAsDateTime: ").Append(ValueAsDateTime).Append("\n");
      sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
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
