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
  public class FileDetails {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="Path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="Url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="Size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Size")]
    public long? Size { get; set; }

    /// <summary>
    /// Gets or Sets SizeFriendly
    /// </summary>
    [DataMember(Name="SizeFriendly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SizeFriendly")]
    public string SizeFriendly { get; set; }

    /// <summary>
    /// Gets or Sets Thumb
    /// </summary>
    [DataMember(Name="Thumb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Thumb")]
    public string Thumb { get; set; }

    /// <summary>
    /// Gets or Sets IsImage
    /// </summary>
    [DataMember(Name="IsImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsImage")]
    public bool? IsImage { get; set; }

    /// <summary>
    /// Gets or Sets IsSuccess
    /// </summary>
    [DataMember(Name="IsSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSuccess")]
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="Messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Messages")]
    public List<string> Messages { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorCode")]
    public int? ErrorCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileDetails {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  SizeFriendly: ").Append(SizeFriendly).Append("\n");
      sb.Append("  Thumb: ").Append(Thumb).Append("\n");
      sb.Append("  IsImage: ").Append(IsImage).Append("\n");
      sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
