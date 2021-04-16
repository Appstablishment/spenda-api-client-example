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
  public class SupplierTransLineT {
    /// <summary>
    /// Gets or Sets LineID
    /// </summary>
    [DataMember(Name="LineID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineID")]
    public int? LineID { get; set; }

    /// <summary>
    /// Gets or Sets TransID
    /// </summary>
    [DataMember(Name="TransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransID")]
    public int? TransID { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets TransStatus
    /// </summary>
    [DataMember(Name="TransStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransStatus")]
    public string TransStatus { get; set; }

    /// <summary>
    /// Gets or Sets LineStatus
    /// </summary>
    [DataMember(Name="LineStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineStatus")]
    public string LineStatus { get; set; }

    /// <summary>
    /// Gets or Sets InventoryID
    /// </summary>
    [DataMember(Name="InventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryID")]
    public int? InventoryID { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShortDescription")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="Code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets UoM
    /// </summary>
    [DataMember(Name="UoM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UoM")]
    public string UoM { get; set; }

    /// <summary>
    /// Gets or Sets UoMDescription
    /// </summary>
    [DataMember(Name="UoMDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UoMDescription")]
    public string UoMDescription { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceEx
    /// </summary>
    [DataMember(Name="BuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceEx")]
    public double? BuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceTax
    /// </summary>
    [DataMember(Name="BuyPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceTax")]
    public double? BuyPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceInc
    /// </summary>
    [DataMember(Name="BuyPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceInc")]
    public double? BuyPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets QuantityOrdered
    /// </summary>
    [DataMember(Name="QuantityOrdered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityOrdered")]
    public double? QuantityOrdered { get; set; }

    /// <summary>
    /// Gets or Sets QuantityCancelled
    /// </summary>
    [DataMember(Name="QuantityCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityCancelled")]
    public double? QuantityCancelled { get; set; }

    /// <summary>
    /// Gets or Sets QuantityReceived
    /// </summary>
    [DataMember(Name="QuantityReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityReceived")]
    public double? QuantityReceived { get; set; }

    /// <summary>
    /// Gets or Sets QuantityToReceive
    /// </summary>
    [DataMember(Name="QuantityToReceive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityToReceive")]
    public double? QuantityToReceive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierTransLineT {\n");
      sb.Append("  LineID: ").Append(LineID).Append("\n");
      sb.Append("  TransID: ").Append(TransID).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
      sb.Append("  LineStatus: ").Append(LineStatus).Append("\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  UoM: ").Append(UoM).Append("\n");
      sb.Append("  UoMDescription: ").Append(UoMDescription).Append("\n");
      sb.Append("  BuyPriceEx: ").Append(BuyPriceEx).Append("\n");
      sb.Append("  BuyPriceTax: ").Append(BuyPriceTax).Append("\n");
      sb.Append("  BuyPriceInc: ").Append(BuyPriceInc).Append("\n");
      sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
      sb.Append("  QuantityCancelled: ").Append(QuantityCancelled).Append("\n");
      sb.Append("  QuantityReceived: ").Append(QuantityReceived).Append("\n");
      sb.Append("  QuantityToReceive: ").Append(QuantityToReceive).Append("\n");
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
