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
  public class InvoiceReport {
    /// <summary>
    /// Gets or Sets InvoiceItems
    /// </summary>
    [DataMember(Name="InvoiceItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceItems")]
    public List<InvoiceReportItem> InvoiceItems { get; set; }

    /// <summary>
    /// Gets or Sets PaymentItems
    /// </summary>
    [DataMember(Name="PaymentItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentItems")]
    public List<InvoiceReportItem> PaymentItems { get; set; }

    /// <summary>
    /// Gets or Sets SumTotalInc
    /// </summary>
    [DataMember(Name="SumTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumTotalInc")]
    public decimal? SumTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoices
    /// </summary>
    [DataMember(Name="CountInvoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoices")]
    public int? CountInvoices { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoicesSynced
    /// </summary>
    [DataMember(Name="CountInvoicesSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoicesSynced")]
    public int? CountInvoicesSynced { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoicesNotSynced
    /// </summary>
    [DataMember(Name="CountInvoicesNotSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoicesNotSynced")]
    public int? CountInvoicesNotSynced { get; set; }

    /// <summary>
    /// Gets or Sets SumPaymentAmount
    /// </summary>
    [DataMember(Name="SumPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumPaymentAmount")]
    public decimal? SumPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets CountPayments
    /// </summary>
    [DataMember(Name="CountPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPayments")]
    public int? CountPayments { get; set; }

    /// <summary>
    /// Gets or Sets CountPaymentsSynced
    /// </summary>
    [DataMember(Name="CountPaymentsSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPaymentsSynced")]
    public int? CountPaymentsSynced { get; set; }

    /// <summary>
    /// Gets or Sets CountPaymentsNotSynced
    /// </summary>
    [DataMember(Name="CountPaymentsNotSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPaymentsNotSynced")]
    public int? CountPaymentsNotSynced { get; set; }

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
      sb.Append("class InvoiceReport {\n");
      sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
      sb.Append("  PaymentItems: ").Append(PaymentItems).Append("\n");
      sb.Append("  SumTotalInc: ").Append(SumTotalInc).Append("\n");
      sb.Append("  CountInvoices: ").Append(CountInvoices).Append("\n");
      sb.Append("  CountInvoicesSynced: ").Append(CountInvoicesSynced).Append("\n");
      sb.Append("  CountInvoicesNotSynced: ").Append(CountInvoicesNotSynced).Append("\n");
      sb.Append("  SumPaymentAmount: ").Append(SumPaymentAmount).Append("\n");
      sb.Append("  CountPayments: ").Append(CountPayments).Append("\n");
      sb.Append("  CountPaymentsSynced: ").Append(CountPaymentsSynced).Append("\n");
      sb.Append("  CountPaymentsNotSynced: ").Append(CountPaymentsNotSynced).Append("\n");
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
