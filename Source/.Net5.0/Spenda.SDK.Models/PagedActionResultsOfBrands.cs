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
  public class PagedActionResultsOfBrands {
    /// <summary>
    /// Gets or Sets MoreToGet
    /// </summary>
    [DataMember(Name="MoreToGet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MoreToGet")]
    public bool? MoreToGet { get; set; }

    /// <summary>
    /// Gets or Sets LastRowNumber
    /// </summary>
    [DataMember(Name="LastRowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastRowNumber")]
    public long? LastRowNumber { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="Count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets TotalRecordCount
    /// </summary>
    [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalRecordCount")]
    public long? TotalRecordCount { get; set; }

    /// <summary>
    /// Gets or Sets CountImported
    /// </summary>
    [DataMember(Name="CountImported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountImported")]
    public int? CountImported { get; set; }

    /// <summary>
    /// Gets or Sets CountInvalid
    /// </summary>
    [DataMember(Name="CountInvalid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountInvalid")]
    public int? CountInvalid { get; set; }

    /// <summary>
    /// Gets or Sets CountReady
    /// </summary>
    [DataMember(Name="CountReady", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountReady")]
    public int? CountReady { get; set; }

    /// <summary>
    /// Gets or Sets CountSynked
    /// </summary>
    [DataMember(Name="CountSynked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountSynked")]
    public int? CountSynked { get; set; }

    /// <summary>
    /// Gets or Sets CountIgnore
    /// </summary>
    [DataMember(Name="CountIgnore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountIgnore")]
    public int? CountIgnore { get; set; }

    /// <summary>
    /// Gets or Sets CountError
    /// </summary>
    [DataMember(Name="CountError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountError")]
    public int? CountError { get; set; }

    /// <summary>
    /// Gets or Sets CountArchived
    /// </summary>
    [DataMember(Name="CountArchived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountArchived")]
    public int? CountArchived { get; set; }

    /// <summary>
    /// Gets or Sets CountActive
    /// </summary>
    [DataMember(Name="CountActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountActive")]
    public int? CountActive { get; set; }

    /// <summary>
    /// Gets or Sets SumTotalEx
    /// </summary>
    [DataMember(Name="SumTotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumTotalEx")]
    public decimal? SumTotalEx { get; set; }

    /// <summary>
    /// Gets or Sets SumTotalTax
    /// </summary>
    [DataMember(Name="SumTotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumTotalTax")]
    public decimal? SumTotalTax { get; set; }

    /// <summary>
    /// Gets or Sets SumTotalBalance
    /// </summary>
    [DataMember(Name="SumTotalBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SumTotalBalance")]
    public decimal? SumTotalBalance { get; set; }

    /// <summary>
    /// Gets or Sets CountOpen
    /// </summary>
    [DataMember(Name="CountOpen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountOpen")]
    public int? CountOpen { get; set; }

    /// <summary>
    /// Gets or Sets CountClosed
    /// </summary>
    [DataMember(Name="CountClosed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountClosed")]
    public int? CountClosed { get; set; }

    /// <summary>
    /// Gets or Sets CountRequiresAttention
    /// </summary>
    [DataMember(Name="CountRequiresAttention", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountRequiresAttention")]
    public int? CountRequiresAttention { get; set; }

    /// <summary>
    /// Gets or Sets CountReadyForApproval
    /// </summary>
    [DataMember(Name="CountReadyForApproval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountReadyForApproval")]
    public int? CountReadyForApproval { get; set; }

    /// <summary>
    /// Gets or Sets CountApproved
    /// </summary>
    [DataMember(Name="CountApproved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountApproved")]
    public int? CountApproved { get; set; }

    /// <summary>
    /// Gets or Sets IsReadyToFinalise
    /// </summary>
    [DataMember(Name="IsReadyToFinalise", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReadyToFinalise")]
    public bool? IsReadyToFinalise { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public List<BrandT> Value { get; set; }

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
      sb.Append("class PagedActionResultsOfBrands {\n");
      sb.Append("  MoreToGet: ").Append(MoreToGet).Append("\n");
      sb.Append("  LastRowNumber: ").Append(LastRowNumber).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
      sb.Append("  CountImported: ").Append(CountImported).Append("\n");
      sb.Append("  CountInvalid: ").Append(CountInvalid).Append("\n");
      sb.Append("  CountReady: ").Append(CountReady).Append("\n");
      sb.Append("  CountSynked: ").Append(CountSynked).Append("\n");
      sb.Append("  CountIgnore: ").Append(CountIgnore).Append("\n");
      sb.Append("  CountError: ").Append(CountError).Append("\n");
      sb.Append("  CountArchived: ").Append(CountArchived).Append("\n");
      sb.Append("  CountActive: ").Append(CountActive).Append("\n");
      sb.Append("  SumTotalEx: ").Append(SumTotalEx).Append("\n");
      sb.Append("  SumTotalTax: ").Append(SumTotalTax).Append("\n");
      sb.Append("  SumTotalBalance: ").Append(SumTotalBalance).Append("\n");
      sb.Append("  CountOpen: ").Append(CountOpen).Append("\n");
      sb.Append("  CountClosed: ").Append(CountClosed).Append("\n");
      sb.Append("  CountRequiresAttention: ").Append(CountRequiresAttention).Append("\n");
      sb.Append("  CountReadyForApproval: ").Append(CountReadyForApproval).Append("\n");
      sb.Append("  CountApproved: ").Append(CountApproved).Append("\n");
      sb.Append("  IsReadyToFinalise: ").Append(IsReadyToFinalise).Append("\n");
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
