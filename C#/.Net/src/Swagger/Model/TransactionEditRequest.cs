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
  public class TransactionEditRequest {
    /// <summary>
    /// Gets or Sets LineSort
    /// </summary>
    [DataMember(Name="LineSort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineSort")]
    public string LineSort { get; set; }

    /// <summary>
    /// Gets or Sets IsLineSortDesc
    /// </summary>
    [DataMember(Name="IsLineSortDesc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLineSortDesc")]
    public bool? IsLineSortDesc { get; set; }

    /// <summary>
    /// Gets or Sets IsGetMessages
    /// </summary>
    [DataMember(Name="IsGetMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsGetMessages")]
    public bool? IsGetMessages { get; set; }

    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets IsPriceRefresh
    /// </summary>
    [DataMember(Name="IsPriceRefresh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPriceRefresh")]
    public bool? IsPriceRefresh { get; set; }

    /// <summary>
    /// Gets or Sets LineSearchFilter
    /// </summary>
    [DataMember(Name="LineSearchFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineSearchFilter")]
    public SearchFilter LineSearchFilter { get; set; }

    /// <summary>
    /// Gets or Sets IsExcludeFailedPayments
    /// </summary>
    [DataMember(Name="IsExcludeFailedPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExcludeFailedPayments")]
    public bool? IsExcludeFailedPayments { get; set; }

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
      sb.Append("class TransactionEditRequest {\n");
      sb.Append("  LineSort: ").Append(LineSort).Append("\n");
      sb.Append("  IsLineSortDesc: ").Append(IsLineSortDesc).Append("\n");
      sb.Append("  IsGetMessages: ").Append(IsGetMessages).Append("\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  IsPriceRefresh: ").Append(IsPriceRefresh).Append("\n");
      sb.Append("  LineSearchFilter: ").Append(LineSearchFilter).Append("\n");
      sb.Append("  IsExcludeFailedPayments: ").Append(IsExcludeFailedPayments).Append("\n");
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
