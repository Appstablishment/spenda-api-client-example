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
  public class BusTransMessageT {
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
    /// Gets or Sets TransID
    /// </summary>
    [DataMember(Name="TransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransID")]
    public int? TransID { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets IsInbound
    /// </summary>
    [DataMember(Name="IsInbound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsInbound")]
    public bool? IsInbound { get; set; }

    /// <summary>
    /// Gets or Sets ToUserID
    /// </summary>
    [DataMember(Name="ToUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ToUserID")]
    public int? ToUserID { get; set; }

    /// <summary>
    /// Gets or Sets FromUserID
    /// </summary>
    [DataMember(Name="FromUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromUserID")]
    public int? FromUserID { get; set; }

    /// <summary>
    /// Gets or Sets SentDateTimeUtc
    /// </summary>
    [DataMember(Name="SentDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SentDateTime_utc")]
    public DateTime? SentDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets ReceivedDateTimeUtc
    /// </summary>
    [DataMember(Name="ReceivedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReceivedDateTime_utc")]
    public DateTime? ReceivedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets ReadDateTimeUtc
    /// </summary>
    [DataMember(Name="ReadDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReadDateTime_utc")]
    public DateTime? ReadDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsSystemMessage
    /// </summary>
    [DataMember(Name="IsSystemMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemMessage")]
    public bool? IsSystemMessage { get; set; }

    /// <summary>
    /// Gets or Sets IsFromParent
    /// </summary>
    [DataMember(Name="IsFromParent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsFromParent")]
    public bool? IsFromParent { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name="Attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attachments")]
    public List<BusTransAttachmentT> Attachments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BusTransMessageT {\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  TransID: ").Append(TransID).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  IsInbound: ").Append(IsInbound).Append("\n");
      sb.Append("  ToUserID: ").Append(ToUserID).Append("\n");
      sb.Append("  FromUserID: ").Append(FromUserID).Append("\n");
      sb.Append("  SentDateTimeUtc: ").Append(SentDateTimeUtc).Append("\n");
      sb.Append("  ReceivedDateTimeUtc: ").Append(ReceivedDateTimeUtc).Append("\n");
      sb.Append("  ReadDateTimeUtc: ").Append(ReadDateTimeUtc).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsSystemMessage: ").Append(IsSystemMessage).Append("\n");
      sb.Append("  IsFromParent: ").Append(IsFromParent).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
