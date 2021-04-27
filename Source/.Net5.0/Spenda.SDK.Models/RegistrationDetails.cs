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
  public class RegistrationDetails {
    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="Customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Customer")]
    public CustomerT Customer { get; set; }

    /// <summary>
    /// Gets or Sets ProductModuleTypes
    /// </summary>
    [DataMember(Name="ProductModuleTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductModuleTypes")]
    public List<int?> ProductModuleTypes { get; set; }

    /// <summary>
    /// Gets or Sets Adaptors
    /// </summary>
    [DataMember(Name="Adaptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Adaptors")]
    public List<int?> Adaptors { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets IsPasswordRequired
    /// </summary>
    [DataMember(Name="IsPasswordRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPasswordRequired")]
    public bool? IsPasswordRequired { get; set; }

    /// <summary>
    /// Gets or Sets IsFreePlanAvailable
    /// </summary>
    [DataMember(Name="IsFreePlanAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsFreePlanAvailable")]
    public bool? IsFreePlanAvailable { get; set; }

    /// <summary>
    /// Gets or Sets IndustryTypes
    /// </summary>
    [DataMember(Name="IndustryTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IndustryTypes")]
    public List<string> IndustryTypes { get; set; }

    /// <summary>
    /// Gets or Sets DomainBlackList
    /// </summary>
    [DataMember(Name="DomainBlackList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainBlackList")]
    public List<string> DomainBlackList { get; set; }

    /// <summary>
    /// Gets or Sets InviteCode
    /// </summary>
    [DataMember(Name="InviteCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InviteCode")]
    public string InviteCode { get; set; }

    /// <summary>
    /// Gets or Sets IsSetupComplete
    /// </summary>
    [DataMember(Name="IsSetupComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSetupComplete")]
    public bool? IsSetupComplete { get; set; }

    /// <summary>
    /// Gets or Sets MarketPlacePath
    /// </summary>
    [DataMember(Name="MarketPlacePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MarketPlacePath")]
    public string MarketPlacePath { get; set; }

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
      sb.Append("class RegistrationDetails {\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  ProductModuleTypes: ").Append(ProductModuleTypes).Append("\n");
      sb.Append("  Adaptors: ").Append(Adaptors).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  IsPasswordRequired: ").Append(IsPasswordRequired).Append("\n");
      sb.Append("  IsFreePlanAvailable: ").Append(IsFreePlanAvailable).Append("\n");
      sb.Append("  IndustryTypes: ").Append(IndustryTypes).Append("\n");
      sb.Append("  DomainBlackList: ").Append(DomainBlackList).Append("\n");
      sb.Append("  InviteCode: ").Append(InviteCode).Append("\n");
      sb.Append("  IsSetupComplete: ").Append(IsSetupComplete).Append("\n");
      sb.Append("  MarketPlacePath: ").Append(MarketPlacePath).Append("\n");
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
