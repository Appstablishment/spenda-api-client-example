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
  public class SyncLogT {
    /// <summary>
    /// Gets or Sets LastImportDateTime
    /// </summary>
    [DataMember(Name="LastImportDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastImportDateTime")]
    public DateTime? LastImportDateTime { get; set; }

    /// <summary>
    /// Gets or Sets LastExportDateTime
    /// </summary>
    [DataMember(Name="LastExportDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastExportDateTime")]
    public DateTime? LastExportDateTime { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets AdaptorID
    /// </summary>
    [DataMember(Name="AdaptorID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdaptorID")]
    public int? AdaptorID { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets LastImportDateTimeUtc
    /// </summary>
    [DataMember(Name="LastImportDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastImportDateTime_utc")]
    public DateTime? LastImportDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets LastImportDateTimeOffset
    /// </summary>
    [DataMember(Name="LastImportDateTime_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastImportDateTime_offset")]
    public int? LastImportDateTimeOffset { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name="Details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Details")]
    public string Details { get; set; }

    /// <summary>
    /// Gets or Sets LastExportDateTimeUtc
    /// </summary>
    [DataMember(Name="LastExportDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastExportDateTime_utc")]
    public DateTime? LastExportDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets LastExportDateTimeOffset
    /// </summary>
    [DataMember(Name="LastExportDateTime_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastExportDateTime_offset")]
    public int? LastExportDateTimeOffset { get; set; }

    /// <summary>
    /// Gets or Sets SyncCode
    /// </summary>
    [DataMember(Name="SyncCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncCode")]
    public string SyncCode { get; set; }

    /// <summary>
    /// Gets or Sets LastModifiedDateTimeUtc
    /// </summary>
    [DataMember(Name="LastModifiedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastModifiedDateTime_utc")]
    public DateTime? LastModifiedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets LastModifiedDateTimeOffset
    /// </summary>
    [DataMember(Name="LastModifiedDateTime_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastModifiedDateTime_offset")]
    public int? LastModifiedDateTimeOffset { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SyncLogT {\n");
      sb.Append("  LastImportDateTime: ").Append(LastImportDateTime).Append("\n");
      sb.Append("  LastExportDateTime: ").Append(LastExportDateTime).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  AdaptorID: ").Append(AdaptorID).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  LastImportDateTimeUtc: ").Append(LastImportDateTimeUtc).Append("\n");
      sb.Append("  LastImportDateTimeOffset: ").Append(LastImportDateTimeOffset).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  LastExportDateTimeUtc: ").Append(LastExportDateTimeUtc).Append("\n");
      sb.Append("  LastExportDateTimeOffset: ").Append(LastExportDateTimeOffset).Append("\n");
      sb.Append("  SyncCode: ").Append(SyncCode).Append("\n");
      sb.Append("  LastModifiedDateTimeUtc: ").Append(LastModifiedDateTimeUtc).Append("\n");
      sb.Append("  LastModifiedDateTimeOffset: ").Append(LastModifiedDateTimeOffset).Append("\n");
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
