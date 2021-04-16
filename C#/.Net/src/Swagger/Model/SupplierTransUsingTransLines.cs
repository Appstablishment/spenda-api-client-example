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
  public class SupplierTransUsingTransLines {
    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets TransID
    /// </summary>
    [DataMember(Name="TransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransID")]
    public int? TransID { get; set; }

    /// <summary>
    /// Gets or Sets LineIDs
    /// </summary>
    [DataMember(Name="LineIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineIDs")]
    public List<int?> LineIDs { get; set; }

    /// <summary>
    /// Gets or Sets TransDate
    /// </summary>
    [DataMember(Name="TransDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDate")]
    public DateTime? TransDate { get; set; }

    /// <summary>
    /// Gets or Sets DueDate
    /// </summary>
    [DataMember(Name="DueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or Sets ExpectedTotalInc
    /// </summary>
    [DataMember(Name="ExpectedTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpectedTotalInc")]
    public double? ExpectedTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets ExpectedTotalTax
    /// </summary>
    [DataMember(Name="ExpectedTotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpectedTotalTax")]
    public double? ExpectedTotalTax { get; set; }

    /// <summary>
    /// Gets or Sets PriceEntryMode
    /// </summary>
    [DataMember(Name="PriceEntryMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceEntryMode")]
    public string PriceEntryMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransUsingTransLines {\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  TransID: ").Append(TransID).Append("\n");
      sb.Append("  LineIDs: ").Append(LineIDs).Append("\n");
      sb.Append("  TransDate: ").Append(TransDate).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  ExpectedTotalInc: ").Append(ExpectedTotalInc).Append("\n");
      sb.Append("  ExpectedTotalTax: ").Append(ExpectedTotalTax).Append("\n");
      sb.Append("  PriceEntryMode: ").Append(PriceEntryMode).Append("\n");
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
