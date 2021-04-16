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
  public class UserT {
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
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Phone1
    /// </summary>
    [DataMember(Name="Phone1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone1")]
    public string Phone1 { get; set; }

    /// <summary>
    /// Gets or Sets PhoneMobile
    /// </summary>
    [DataMember(Name="PhoneMobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneMobile")]
    public string PhoneMobile { get; set; }

    /// <summary>
    /// Gets or Sets PositionOrOccupation
    /// </summary>
    [DataMember(Name="PositionOrOccupation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PositionOrOccupation")]
    public string PositionOrOccupation { get; set; }

    /// <summary>
    /// Gets or Sets IsPrimaryContact
    /// </summary>
    [DataMember(Name="IsPrimaryContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPrimaryContact")]
    public bool? IsPrimaryContact { get; set; }

    /// <summary>
    /// Gets or Sets IsEmployee
    /// </summary>
    [DataMember(Name="IsEmployee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmployee")]
    public bool? IsEmployee { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Phone1: ").Append(Phone1).Append("\n");
      sb.Append("  PhoneMobile: ").Append(PhoneMobile).Append("\n");
      sb.Append("  PositionOrOccupation: ").Append(PositionOrOccupation).Append("\n");
      sb.Append("  IsPrimaryContact: ").Append(IsPrimaryContact).Append("\n");
      sb.Append("  IsEmployee: ").Append(IsEmployee).Append("\n");
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
