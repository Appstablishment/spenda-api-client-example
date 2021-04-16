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
  public class SynkValidation {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets DatType
    /// </summary>
    [DataMember(Name="DatType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DatType")]
    public int? DatType { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets RefEntityBSID
    /// </summary>
    [DataMember(Name="RefEntityBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefEntityBSID")]
    public string RefEntityBSID { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public int? Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusString
    /// </summary>
    [DataMember(Name="StatusString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusString")]
    public string StatusString { get; set; }

    /// <summary>
    /// Gets or Sets SyncStatus
    /// </summary>
    [DataMember(Name="SyncStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncStatus")]
    public string SyncStatus { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="Messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Messages")]
    public List<string> Messages { get; set; }

    /// <summary>
    /// Gets or Sets IsUpdate
    /// </summary>
    [DataMember(Name="IsUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsUpdate")]
    public bool? IsUpdate { get; set; }

    /// <summary>
    /// Gets or Sets Codes
    /// </summary>
    [DataMember(Name="Codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codes")]
    public List<int?> Codes { get; set; }

    /// <summary>
    /// Gets or Sets TransactionTypeDatTypeID
    /// </summary>
    [DataMember(Name="TransactionTypeDatTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionTypeDatTypeID")]
    public int? TransactionTypeDatTypeID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SynkValidation {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  DatType: ").Append(DatType).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  RefEntityBSID: ").Append(RefEntityBSID).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusString: ").Append(StatusString).Append("\n");
      sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
      sb.Append("  IsUpdate: ").Append(IsUpdate).Append("\n");
      sb.Append("  Codes: ").Append(Codes).Append("\n");
      sb.Append("  TransactionTypeDatTypeID: ").Append(TransactionTypeDatTypeID).Append("\n");
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
