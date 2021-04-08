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
  public class ContactT {
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
    /// Gets or Sets BusinessName
    /// </summary>
    [DataMember(Name="BusinessName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessName")]
    public string BusinessName { get; set; }

    /// <summary>
    /// Gets or Sets BusinessContactID
    /// </summary>
    [DataMember(Name="BusinessContactID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessContactID")]
    public int? BusinessContactID { get; set; }

    /// <summary>
    /// Gets or Sets BusinessID
    /// </summary>
    [DataMember(Name="BusinessID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessID")]
    public int? BusinessID { get; set; }

    /// <summary>
    /// Gets or Sets BusinessLocationGuid
    /// </summary>
    [DataMember(Name="BusinessLocationGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessLocationGuid")]
    public Guid? BusinessLocationGuid { get; set; }

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
    /// Gets or Sets Phone1
    /// </summary>
    [DataMember(Name="Phone1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone1")]
    public string Phone1 { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets PhoneMobile
    /// </summary>
    [DataMember(Name="PhoneMobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneMobile")]
    public string PhoneMobile { get; set; }

    /// <summary>
    /// Gets or Sets IsPrimaryContact
    /// </summary>
    [DataMember(Name="IsPrimaryContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPrimaryContact")]
    public bool? IsPrimaryContact { get; set; }

    /// <summary>
    /// Gets or Sets ContactRole
    /// </summary>
    [DataMember(Name="ContactRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactRole")]
    public string ContactRole { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="Gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or Sets Birthday
    /// </summary>
    [DataMember(Name="Birthday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Birthday")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets PositionOrOccupation
    /// </summary>
    [DataMember(Name="PositionOrOccupation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PositionOrOccupation")]
    public string PositionOrOccupation { get; set; }

    /// <summary>
    /// Gets or Sets LinkedUserGlobalIDstring
    /// </summary>
    [DataMember(Name="LinkedUserGlobalIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedUserGlobalIDstring")]
    public string LinkedUserGlobalIDstring { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets IsIncludeInEmails
    /// </summary>
    [DataMember(Name="IsIncludeInEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsIncludeInEmails")]
    public bool? IsIncludeInEmails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContactT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
      sb.Append("  BusinessContactID: ").Append(BusinessContactID).Append("\n");
      sb.Append("  BusinessID: ").Append(BusinessID).Append("\n");
      sb.Append("  BusinessLocationGuid: ").Append(BusinessLocationGuid).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Phone1: ").Append(Phone1).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  PhoneMobile: ").Append(PhoneMobile).Append("\n");
      sb.Append("  IsPrimaryContact: ").Append(IsPrimaryContact).Append("\n");
      sb.Append("  ContactRole: ").Append(ContactRole).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Birthday: ").Append(Birthday).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  PositionOrOccupation: ").Append(PositionOrOccupation).Append("\n");
      sb.Append("  LinkedUserGlobalIDstring: ").Append(LinkedUserGlobalIDstring).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  IsIncludeInEmails: ").Append(IsIncludeInEmails).Append("\n");
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
