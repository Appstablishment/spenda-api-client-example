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
  public class PriceBand {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DiscountPercentage
    /// </summary>
    [DataMember(Name="DiscountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountPercentage")]
    public decimal? DiscountPercentage { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="Price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Price")]
    public decimal? Price { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PriceBand {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
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
