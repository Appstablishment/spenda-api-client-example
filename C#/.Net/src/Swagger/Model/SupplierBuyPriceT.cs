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
  public class SupplierBuyPriceT {
    /// <summary>
    /// Gets or Sets SupplierID
    /// </summary>
    [DataMember(Name="SupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierID")]
    public int? SupplierID { get; set; }

    /// <summary>
    /// Gets or Sets SupplierInventoryCode
    /// </summary>
    [DataMember(Name="SupplierInventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierInventoryCode")]
    public string SupplierInventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets SupplierBarcode
    /// </summary>
    [DataMember(Name="SupplierBarcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierBarcode")]
    public string SupplierBarcode { get; set; }

    /// <summary>
    /// Gets or Sets BuyPriceEx
    /// </summary>
    [DataMember(Name="BuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuyPriceEx")]
    public double? BuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets LastPriceUpdateDateTimeUtc
    /// </summary>
    [DataMember(Name="LastPriceUpdateDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPriceUpdateDateTime_utc")]
    public DateTime? LastPriceUpdateDateTimeUtc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupplierBuyPriceT {\n");
      sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
      sb.Append("  SupplierInventoryCode: ").Append(SupplierInventoryCode).Append("\n");
      sb.Append("  SupplierBarcode: ").Append(SupplierBarcode).Append("\n");
      sb.Append("  BuyPriceEx: ").Append(BuyPriceEx).Append("\n");
      sb.Append("  LastPriceUpdateDateTimeUtc: ").Append(LastPriceUpdateDateTimeUtc).Append("\n");
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
