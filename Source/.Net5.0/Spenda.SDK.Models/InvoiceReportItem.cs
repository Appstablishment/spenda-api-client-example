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
  public class InvoiceReportItem {
    /// <summary>
    /// Gets or Sets InvoiceStatus
    /// </summary>
    [DataMember(Name="InvoiceStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceStatus")]
    public string InvoiceStatus { get; set; }

    /// <summary>
    /// Gets or Sets SalesChannel
    /// </summary>
    [DataMember(Name="SalesChannel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesChannel")]
    public string SalesChannel { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaymentMethod")]
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets TerminalID
    /// </summary>
    [DataMember(Name="TerminalID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerminalID")]
    public string TerminalID { get; set; }

    /// <summary>
    /// Gets or Sets SalesCount
    /// </summary>
    [DataMember(Name="SalesCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesCount")]
    public int? SalesCount { get; set; }

    /// <summary>
    /// Gets or Sets SumTotalInc
    /// </summary>
    [DataMember(Name="SumTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumTotalInc")]
    public double? SumTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets SumPaymentAmount
    /// </summary>
    [DataMember(Name="SumPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumPaymentAmount")]
    public double? SumPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoices
    /// </summary>
    [DataMember(Name="CountInvoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoices")]
    public int? CountInvoices { get; set; }

    /// <summary>
    /// Gets or Sets CountPayments
    /// </summary>
    [DataMember(Name="CountPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPayments")]
    public int? CountPayments { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoiceSynced
    /// </summary>
    [DataMember(Name="CountInvoiceSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoiceSynced")]
    public int? CountInvoiceSynced { get; set; }

    /// <summary>
    /// Gets or Sets CountInvoiceNotSynced
    /// </summary>
    [DataMember(Name="CountInvoiceNotSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvoiceNotSynced")]
    public int? CountInvoiceNotSynced { get; set; }

    /// <summary>
    /// Gets or Sets CountPaymentSynced
    /// </summary>
    [DataMember(Name="CountPaymentSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPaymentSynced")]
    public int? CountPaymentSynced { get; set; }

    /// <summary>
    /// Gets or Sets CountPaymentNotSynced
    /// </summary>
    [DataMember(Name="CountPaymentNotSynced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountPaymentNotSynced")]
    public int? CountPaymentNotSynced { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceReportItem {\n");
      sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
      sb.Append("  SalesChannel: ").Append(SalesChannel).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  TerminalID: ").Append(TerminalID).Append("\n");
      sb.Append("  SalesCount: ").Append(SalesCount).Append("\n");
      sb.Append("  SumTotalInc: ").Append(SumTotalInc).Append("\n");
      sb.Append("  SumPaymentAmount: ").Append(SumPaymentAmount).Append("\n");
      sb.Append("  CountInvoices: ").Append(CountInvoices).Append("\n");
      sb.Append("  CountPayments: ").Append(CountPayments).Append("\n");
      sb.Append("  CountInvoiceSynced: ").Append(CountInvoiceSynced).Append("\n");
      sb.Append("  CountInvoiceNotSynced: ").Append(CountInvoiceNotSynced).Append("\n");
      sb.Append("  CountPaymentSynced: ").Append(CountPaymentSynced).Append("\n");
      sb.Append("  CountPaymentNotSynced: ").Append(CountPaymentNotSynced).Append("\n");
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
