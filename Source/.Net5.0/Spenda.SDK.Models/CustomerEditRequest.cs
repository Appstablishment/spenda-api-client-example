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
  public class CustomerEditRequest {
    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets BusinessID
    /// </summary>
    [DataMember(Name="BusinessID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessID")]
    public int? BusinessID { get; set; }

    /// <summary>
    /// Gets or Sets IsAutoAddClaimRequests
    /// </summary>
    [DataMember(Name="IsAutoAddClaimRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAutoAddClaimRequests")]
    public bool? IsAutoAddClaimRequests { get; set; }

    /// <summary>
    /// Gets or Sets DebtorCode
    /// </summary>
    [DataMember(Name="DebtorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DebtorCode")]
    public string DebtorCode { get; set; }

    /// <summary>
    /// Gets or Sets IsReturnEmptyCustomerIfNotFound
    /// </summary>
    [DataMember(Name="IsReturnEmptyCustomerIfNotFound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReturnEmptyCustomerIfNotFound")]
    public bool? IsReturnEmptyCustomerIfNotFound { get; set; }

    /// <summary>
    /// Gets or Sets IsGetNewTemplate
    /// </summary>
    [DataMember(Name="IsGetNewTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsGetNewTemplate")]
    public bool? IsGetNewTemplate { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets IsGetExtraInfo
    /// </summary>
    [DataMember(Name="IsGetExtraInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsGetExtraInfo")]
    public bool? IsGetExtraInfo { get; set; }

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
      sb.Append("class CustomerEditRequest {\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  BusinessID: ").Append(BusinessID).Append("\n");
      sb.Append("  IsAutoAddClaimRequests: ").Append(IsAutoAddClaimRequests).Append("\n");
      sb.Append("  DebtorCode: ").Append(DebtorCode).Append("\n");
      sb.Append("  IsReturnEmptyCustomerIfNotFound: ").Append(IsReturnEmptyCustomerIfNotFound).Append("\n");
      sb.Append("  IsGetNewTemplate: ").Append(IsGetNewTemplate).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  IsGetExtraInfo: ").Append(IsGetExtraInfo).Append("\n");
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
