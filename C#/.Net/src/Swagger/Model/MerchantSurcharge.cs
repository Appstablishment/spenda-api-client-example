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
  public class MerchantSurcharge {
    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets AccountPaymentMethodID
    /// </summary>
    [DataMember(Name="AccountPaymentMethodID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountPaymentMethodID")]
    public int? AccountPaymentMethodID { get; set; }

    /// <summary>
    /// Gets or Sets AccountPaymentMethodName
    /// </summary>
    [DataMember(Name="AccountPaymentMethodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountPaymentMethodName")]
    public string AccountPaymentMethodName { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodID
    /// </summary>
    [DataMember(Name="PaymentMethodID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodID")]
    public int? PaymentMethodID { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodName
    /// </summary>
    [DataMember(Name="PaymentMethodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethodName")]
    public string PaymentMethodName { get; set; }

    /// <summary>
    /// Gets or Sets SurchargePercent
    /// </summary>
    [DataMember(Name="SurchargePercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SurchargePercent")]
    public double? SurchargePercent { get; set; }

    /// <summary>
    /// Gets or Sets SurchargeAmount
    /// </summary>
    [DataMember(Name="SurchargeAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SurchargeAmount")]
    public double? SurchargeAmount { get; set; }

    /// <summary>
    /// Gets or Sets PaymentAmount
    /// </summary>
    [DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentAmount")]
    public double? PaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets TotalAmount
    /// </summary>
    [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalAmount")]
    public double? TotalAmount { get; set; }

    /// <summary>
    /// Gets or Sets BusTrans
    /// </summary>
    [DataMember(Name="BusTrans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusTrans")]
    public List<RefBusTranT> BusTrans { get; set; }

    /// <summary>
    /// Gets or Sets RefBusTrans
    /// </summary>
    [DataMember(Name="RefBusTrans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefBusTrans")]
    public List<RefBusTranT> RefBusTrans { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantSurcharge {\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  AccountPaymentMethodID: ").Append(AccountPaymentMethodID).Append("\n");
      sb.Append("  AccountPaymentMethodName: ").Append(AccountPaymentMethodName).Append("\n");
      sb.Append("  PaymentMethodID: ").Append(PaymentMethodID).Append("\n");
      sb.Append("  PaymentMethodName: ").Append(PaymentMethodName).Append("\n");
      sb.Append("  SurchargePercent: ").Append(SurchargePercent).Append("\n");
      sb.Append("  SurchargeAmount: ").Append(SurchargeAmount).Append("\n");
      sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
      sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
      sb.Append("  BusTrans: ").Append(BusTrans).Append("\n");
      sb.Append("  RefBusTrans: ").Append(RefBusTrans).Append("\n");
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
