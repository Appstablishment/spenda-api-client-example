using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SDK.SpendaApi.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BankAccountT {
    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

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
    /// Gets or Sets AccountName
    /// </summary>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets BSB
    /// </summary>
    [DataMember(Name="BSB", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSB")]
    public string BSB { get; set; }

    /// <summary>
    /// Gets or Sets IsRemainder
    /// </summary>
    [DataMember(Name="IsRemainder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRemainder")]
    public bool? IsRemainder { get; set; }

    /// <summary>
    /// Gets or Sets StatementText
    /// </summary>
    [DataMember(Name="StatementText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatementText")]
    public string StatementText { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankAccountT {\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  BSB: ").Append(BSB).Append("\n");
      sb.Append("  IsRemainder: ").Append(IsRemainder).Append("\n");
      sb.Append("  StatementText: ").Append(StatementText).Append("\n");
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
