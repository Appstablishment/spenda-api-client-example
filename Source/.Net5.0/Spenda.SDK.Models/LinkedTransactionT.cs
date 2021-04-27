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
  public class LinkedTransactionT {
    /// <summary>
    /// Gets or Sets ShortDatTypeString
    /// </summary>
    [DataMember(Name="ShortDatTypeString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShortDatTypeString")]
    public string ShortDatTypeString { get; set; }

    /// <summary>
    /// Gets or Sets DatTypeString
    /// </summary>
    [DataMember(Name="DatTypeString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DatTypeString")]
    public string DatTypeString { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets DatTypeID
    /// </summary>
    [DataMember(Name="DatTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DatTypeID")]
    public int? DatTypeID { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets TotalInc
    /// </summary>
    [DataMember(Name="TotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalInc")]
    public double? TotalInc { get; set; }

    /// <summary>
    /// Gets or Sets Issues
    /// </summary>
    [DataMember(Name="Issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Issues")]
    public string Issues { get; set; }

    /// <summary>
    /// Gets or Sets RecipientName
    /// </summary>
    [DataMember(Name="RecipientName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecipientName")]
    public string RecipientName { get; set; }

    /// <summary>
    /// Gets or Sets LineCount
    /// </summary>
    [DataMember(Name="LineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineCount")]
    public int? LineCount { get; set; }

    /// <summary>
    /// Gets or Sets QuantityCount
    /// </summary>
    [DataMember(Name="QuantityCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityCount")]
    public double? QuantityCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalEx
    /// </summary>
    [DataMember(Name="TotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalEx")]
    public double? TotalEx { get; set; }

    /// <summary>
    /// Gets or Sets AppliedAmount
    /// </summary>
    [DataMember(Name="AppliedAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AppliedAmount")]
    public double? AppliedAmount { get; set; }

    /// <summary>
    /// Gets or Sets AppliedDate
    /// </summary>
    [DataMember(Name="AppliedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AppliedDate")]
    public DateTime? AppliedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LinkedTransactionT {\n");
      sb.Append("  ShortDatTypeString: ").Append(ShortDatTypeString).Append("\n");
      sb.Append("  DatTypeString: ").Append(DatTypeString).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  DatTypeID: ").Append(DatTypeID).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TotalInc: ").Append(TotalInc).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
      sb.Append("  LineCount: ").Append(LineCount).Append("\n");
      sb.Append("  QuantityCount: ").Append(QuantityCount).Append("\n");
      sb.Append("  TotalEx: ").Append(TotalEx).Append("\n");
      sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
      sb.Append("  AppliedDate: ").Append(AppliedDate).Append("\n");
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
