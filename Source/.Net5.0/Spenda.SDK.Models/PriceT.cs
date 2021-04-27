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
  public class PriceT {
    /// <summary>
    /// Gets or Sets DebtorBSID
    /// </summary>
    [DataMember(Name="DebtorBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DebtorBSID")]
    public string DebtorBSID { get; set; }

    /// <summary>
    /// Gets or Sets PriceBreaks
    /// </summary>
    [DataMember(Name="PriceBreaks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceBreaks")]
    public List<PriceBreakT> PriceBreaks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PriceT {\n");
      sb.Append("  DebtorBSID: ").Append(DebtorBSID).Append("\n");
      sb.Append("  PriceBreaks: ").Append(PriceBreaks).Append("\n");
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
