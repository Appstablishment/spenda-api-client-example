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
  public class CustomerEditResponse {
    /// <summary>
    /// Gets or Sets DefaultCountry
    /// </summary>
    [DataMember(Name="DefaultCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultCountry")]
    public string DefaultCountry { get; set; }

    /// <summary>
    /// Gets or Sets IndustryTypes
    /// </summary>
    [DataMember(Name="IndustryTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IndustryTypes")]
    public List<string> IndustryTypes { get; set; }

    /// <summary>
    /// Gets or Sets Classes
    /// </summary>
    [DataMember(Name="Classes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Classes")]
    public List<CustomerClassT> Classes { get; set; }

    /// <summary>
    /// Gets or Sets PriceBands
    /// </summary>
    [DataMember(Name="PriceBands", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceBands")]
    public List<PricingBandInfo> PriceBands { get; set; }

    /// <summary>
    /// Gets or Sets Territories
    /// </summary>
    [DataMember(Name="Territories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Territories")]
    public List<TerritoryInfo> Territories { get; set; }

    /// <summary>
    /// Gets or Sets CashSaleAccounts
    /// </summary>
    [DataMember(Name="CashSaleAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CashSaleAccounts")]
    public List<string> CashSaleAccounts { get; set; }

    /// <summary>
    /// Gets or Sets Configs
    /// </summary>
    [DataMember(Name="Configs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Configs")]
    public List<ConfigObject> Configs { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public CustomerT Value { get; set; }

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
      sb.Append("class CustomerEditResponse {\n");
      sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
      sb.Append("  IndustryTypes: ").Append(IndustryTypes).Append("\n");
      sb.Append("  Classes: ").Append(Classes).Append("\n");
      sb.Append("  PriceBands: ").Append(PriceBands).Append("\n");
      sb.Append("  Territories: ").Append(Territories).Append("\n");
      sb.Append("  CashSaleAccounts: ").Append(CashSaleAccounts).Append("\n");
      sb.Append("  Configs: ").Append(Configs).Append("\n");
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
