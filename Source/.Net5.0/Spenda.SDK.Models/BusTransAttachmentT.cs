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
  public class BusTransAttachmentT {
    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets IsImage
    /// </summary>
    [DataMember(Name="IsImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsImage")]
    public bool? IsImage { get; set; }

    /// <summary>
    /// Gets or Sets IsPDF
    /// </summary>
    [DataMember(Name="IsPDF", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPDF")]
    public bool? IsPDF { get; set; }

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
    /// Gets or Sets MessageID
    /// </summary>
    [DataMember(Name="MessageID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessageID")]
    public int? MessageID { get; set; }

    /// <summary>
    /// Gets or Sets URI
    /// </summary>
    [DataMember(Name="URI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URI")]
    public string URI { get; set; }

    /// <summary>
    /// Gets or Sets AttachedByUserID
    /// </summary>
    [DataMember(Name="AttachedByUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AttachedByUserID")]
    public int? AttachedByUserID { get; set; }

    /// <summary>
    /// Gets or Sets AttachedDateTimeUtc
    /// </summary>
    [DataMember(Name="AttachedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AttachedDateTime_utc")]
    public DateTime? AttachedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Caption
    /// </summary>
    [DataMember(Name="Caption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Caption")]
    public string Caption { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailURI
    /// </summary>
    [DataMember(Name="ThumbnailURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ThumbnailURI")]
    public string ThumbnailURI { get; set; }

    /// <summary>
    /// Gets or Sets AttachmentType
    /// </summary>
    [DataMember(Name="AttachmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AttachmentType")]
    public string AttachmentType { get; set; }

    /// <summary>
    /// Gets or Sets IsFromParent
    /// </summary>
    [DataMember(Name="IsFromParent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsFromParent")]
    public bool? IsFromParent { get; set; }

    /// <summary>
    /// Gets or Sets LineID
    /// </summary>
    [DataMember(Name="LineID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineID")]
    public int? LineID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BusTransAttachmentT {\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  IsImage: ").Append(IsImage).Append("\n");
      sb.Append("  IsPDF: ").Append(IsPDF).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  MessageID: ").Append(MessageID).Append("\n");
      sb.Append("  URI: ").Append(URI).Append("\n");
      sb.Append("  AttachedByUserID: ").Append(AttachedByUserID).Append("\n");
      sb.Append("  AttachedDateTimeUtc: ").Append(AttachedDateTimeUtc).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Caption: ").Append(Caption).Append("\n");
      sb.Append("  ThumbnailURI: ").Append(ThumbnailURI).Append("\n");
      sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
      sb.Append("  IsFromParent: ").Append(IsFromParent).Append("\n");
      sb.Append("  LineID: ").Append(LineID).Append("\n");
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
