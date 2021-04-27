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
  public class LocationT {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Contacts
    /// </summary>
    [DataMember(Name="Contacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Contacts")]
    public List<ContactT> Contacts { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets IsDefaultLocation
    /// </summary>
    [DataMember(Name="IsDefaultLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDefaultLocation")]
    public bool? IsDefaultLocation { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or Sets Fax
    /// </summary>
    [DataMember(Name="Fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fax")]
    public string Fax { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets LocationName
    /// </summary>
    [DataMember(Name="LocationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocationName")]
    public string LocationName { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsVisibleToPublic
    /// </summary>
    [DataMember(Name="IsVisibleToPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVisibleToPublic")]
    public bool? IsVisibleToPublic { get; set; }

    /// <summary>
    /// Gets or Sets UtcOffset
    /// </summary>
    [DataMember(Name="UtcOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UtcOffset")]
    public int? UtcOffset { get; set; }

    /// <summary>
    /// Gets or Sets TimeZoneName
    /// </summary>
    [DataMember(Name="TimeZoneName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneName")]
    public string TimeZoneName { get; set; }

    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name="Addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Addresses")]
    public List<AddressT> Addresses { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LocationT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Contacts: ").Append(Contacts).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  IsDefaultLocation: ").Append(IsDefaultLocation).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  LocationName: ").Append(LocationName).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsVisibleToPublic: ").Append(IsVisibleToPublic).Append("\n");
      sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
      sb.Append("  TimeZoneName: ").Append(TimeZoneName).Append("\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
