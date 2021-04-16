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
  public class ClaimRequestLineT {
    /// <summary>
    /// Gets or Sets ClaimRequestID
    /// </summary>
    [DataMember(Name="ClaimRequestID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClaimRequestID")]
    public int? ClaimRequestID { get; set; }

    /// <summary>
    /// Gets or Sets ClaimRequestLineID
    /// </summary>
    [DataMember(Name="ClaimRequestLineID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClaimRequestLineID")]
    public int? ClaimRequestLineID { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceEx
    /// </summary>
    [DataMember(Name="SellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceEx")]
    public double? SellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceInc
    /// </summary>
    [DataMember(Name="SellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceInc")]
    public double? SellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceTax
    /// </summary>
    [DataMember(Name="SellPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceTax")]
    public double? SellPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalEx
    /// </summary>
    [DataMember(Name="LineTotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalEx")]
    public double? LineTotalEx { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalInc
    /// </summary>
    [DataMember(Name="LineTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalInc")]
    public double? LineTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalTax
    /// </summary>
    [DataMember(Name="LineTotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalTax")]
    public double? LineTotalTax { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseName
    /// </summary>
    [DataMember(Name="WarehouseName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseName")]
    public string WarehouseName { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsReturnToStock
    /// </summary>
    [DataMember(Name="IsReturnToStock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReturnToStock")]
    public bool? IsReturnToStock { get; set; }

    /// <summary>
    /// Gets or Sets TransDate
    /// </summary>
    [DataMember(Name="TransDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDate")]
    public DateTime? TransDate { get; set; }

    /// <summary>
    /// Gets or Sets ClaimRequestStatus
    /// </summary>
    [DataMember(Name="ClaimRequestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClaimRequestStatus")]
    public string ClaimRequestStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClaimRequestLineT {\n");
      sb.Append("  ClaimRequestID: ").Append(ClaimRequestID).Append("\n");
      sb.Append("  ClaimRequestLineID: ").Append(ClaimRequestLineID).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  SellPriceEx: ").Append(SellPriceEx).Append("\n");
      sb.Append("  SellPriceInc: ").Append(SellPriceInc).Append("\n");
      sb.Append("  SellPriceTax: ").Append(SellPriceTax).Append("\n");
      sb.Append("  LineTotalEx: ").Append(LineTotalEx).Append("\n");
      sb.Append("  LineTotalInc: ").Append(LineTotalInc).Append("\n");
      sb.Append("  LineTotalTax: ").Append(LineTotalTax).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsReturnToStock: ").Append(IsReturnToStock).Append("\n");
      sb.Append("  TransDate: ").Append(TransDate).Append("\n");
      sb.Append("  ClaimRequestStatus: ").Append(ClaimRequestStatus).Append("\n");
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
