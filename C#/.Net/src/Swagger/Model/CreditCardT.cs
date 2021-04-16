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
  public class CreditCardT {
    /// <summary>
    /// Gets or Sets CardType
    /// </summary>
    [DataMember(Name="CardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CardType")]
    public string CardType { get; set; }

    /// <summary>
    /// Gets or Sets CardNumber
    /// </summary>
    [DataMember(Name="CardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CardNumber")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Gets or Sets CardHolderName
    /// </summary>
    [DataMember(Name="CardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CardHolderName")]
    public string CardHolderName { get; set; }

    /// <summary>
    /// Gets or Sets ExpiryMMYY
    /// </summary>
    [DataMember(Name="ExpiryMMYY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpiryMMYY")]
    public string ExpiryMMYY { get; set; }

    /// <summary>
    /// Gets or Sets CardVerificationNumber
    /// </summary>
    [DataMember(Name="CardVerificationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CardVerificationNumber")]
    public string CardVerificationNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditCardT {\n");
      sb.Append("  CardType: ").Append(CardType).Append("\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
      sb.Append("  ExpiryMMYY: ").Append(ExpiryMMYY).Append("\n");
      sb.Append("  CardVerificationNumber: ").Append(CardVerificationNumber).Append("\n");
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
