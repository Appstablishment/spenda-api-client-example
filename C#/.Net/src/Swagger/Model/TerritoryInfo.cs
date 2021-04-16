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
  public class TerritoryInfo {
    /// <summary>
    /// Gets or Sets TerritoryID
    /// </summary>
    [DataMember(Name="TerritoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerritoryID")]
    public int? TerritoryID { get; set; }

    /// <summary>
    /// Gets or Sets TenantLocationID
    /// </summary>
    [DataMember(Name="TenantLocationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantLocationID")]
    public int? TenantLocationID { get; set; }

    /// <summary>
    /// Gets or Sets TenantLocationName
    /// </summary>
    [DataMember(Name="TenantLocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantLocationName")]
    public string TenantLocationName { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPostingCode
    /// </summary>
    [DataMember(Name="DefaultPostingCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPostingCode")]
    public string DefaultPostingCode { get; set; }

    /// <summary>
    /// Gets or Sets IsUserDefault
    /// </summary>
    [DataMember(Name="IsUserDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsUserDefault")]
    public bool? IsUserDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsLocationDefault
    /// </summary>
    [DataMember(Name="IsLocationDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLocationDefault")]
    public bool? IsLocationDefault { get; set; }

    /// <summary>
    /// Gets or Sets SelectedForUser
    /// </summary>
    [DataMember(Name="SelectedForUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SelectedForUser")]
    public bool? SelectedForUser { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedByUserName
    /// </summary>
    [DataMember(Name="ModifiedByUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedByUserName")]
    public string ModifiedByUserName { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedByUserID
    /// </summary>
    [DataMember(Name="ModifiedByUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedByUserID")]
    public int? ModifiedByUserID { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTime
    /// </summary>
    [DataMember(Name="ModifiedDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedDateTime")]
    public DateTime? ModifiedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByUserID
    /// </summary>
    [DataMember(Name="CreatedByUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserID")]
    public int? CreatedByUserID { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfMembers
    /// </summary>
    [DataMember(Name="NumberOfMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfMembers")]
    public int? NumberOfMembers { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="IsDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsCustomerDefault
    /// </summary>
    [DataMember(Name="IsCustomerDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCustomerDefault")]
    public bool? IsCustomerDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets ParentID
    /// </summary>
    [DataMember(Name="ParentID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentID")]
    public int? ParentID { get; set; }

    /// <summary>
    /// Gets or Sets ParentName
    /// </summary>
    [DataMember(Name="ParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentName")]
    public string ParentName { get; set; }

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
      sb.Append("class TerritoryInfo {\n");
      sb.Append("  TerritoryID: ").Append(TerritoryID).Append("\n");
      sb.Append("  TenantLocationID: ").Append(TenantLocationID).Append("\n");
      sb.Append("  TenantLocationName: ").Append(TenantLocationName).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  DefaultPostingCode: ").Append(DefaultPostingCode).Append("\n");
      sb.Append("  IsUserDefault: ").Append(IsUserDefault).Append("\n");
      sb.Append("  IsLocationDefault: ").Append(IsLocationDefault).Append("\n");
      sb.Append("  SelectedForUser: ").Append(SelectedForUser).Append("\n");
      sb.Append("  ModifiedByUserName: ").Append(ModifiedByUserName).Append("\n");
      sb.Append("  ModifiedByUserID: ").Append(ModifiedByUserID).Append("\n");
      sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
      sb.Append("  CreatedByUserID: ").Append(CreatedByUserID).Append("\n");
      sb.Append("  NumberOfMembers: ").Append(NumberOfMembers).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  IsCustomerDefault: ").Append(IsCustomerDefault).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  ParentID: ").Append(ParentID).Append("\n");
      sb.Append("  ParentName: ").Append(ParentName).Append("\n");
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
