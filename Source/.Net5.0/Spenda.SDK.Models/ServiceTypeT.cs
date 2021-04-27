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
  public class ServiceTypeT {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets ServiceTypeID
    /// </summary>
    [DataMember(Name="ServiceTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceTypeID")]
    public int? ServiceTypeID { get; set; }

    /// <summary>
    /// Gets or Sets TenantID
    /// </summary>
    [DataMember(Name="TenantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TenantID")]
    public int? TenantID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="IsDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTimeUtc
    /// </summary>
    [DataMember(Name="ModifiedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedDateTime_utc")]
    public DateTime? ModifiedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets RowNumber
    /// </summary>
    [DataMember(Name="RowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RowNumber")]
    public long? RowNumber { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public double? Version { get; set; }

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
    /// Gets or Sets SyncLogs
    /// </summary>
    [DataMember(Name="SyncLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncLogs")]
    public List<SyncLogT> SyncLogs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceTypeT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  ServiceTypeID: ").Append(ServiceTypeID).Append("\n");
      sb.Append("  TenantID: ").Append(TenantID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
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
