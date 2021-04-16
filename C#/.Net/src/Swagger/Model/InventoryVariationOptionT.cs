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
  public class InventoryVariationOptionT {
    /// <summary>
    /// Gets or Sets VariationName
    /// </summary>
    [DataMember(Name="VariationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationName")]
    public string VariationName { get; set; }

    /// <summary>
    /// Gets or Sets VariationAbbreviatedName
    /// </summary>
    [DataMember(Name="VariationAbbreviatedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationAbbreviatedName")]
    public string VariationAbbreviatedName { get; set; }

    /// <summary>
    /// Gets or Sets MediaFileUrl
    /// </summary>
    [DataMember(Name="MediaFileUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaFileUrl")]
    public string MediaFileUrl { get; set; }

    /// <summary>
    /// Gets or Sets MediaFileThumbnailUrl
    /// </summary>
    [DataMember(Name="MediaFileThumbnailUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaFileThumbnailUrl")]
    public string MediaFileThumbnailUrl { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceIncDelta
    /// </summary>
    [DataMember(Name="StandardSellPriceIncDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceIncDelta")]
    public double? StandardSellPriceIncDelta { get; set; }

    /// <summary>
    /// Gets or Sets VariationOptionID
    /// </summary>
    [DataMember(Name="VariationOptionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationOptionID")]
    public int? VariationOptionID { get; set; }

    /// <summary>
    /// Gets or Sets VariationID
    /// </summary>
    [DataMember(Name="VariationID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationID")]
    public int? VariationID { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AbbreviatedName
    /// </summary>
    [DataMember(Name="AbbreviatedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AbbreviatedName")]
    public string AbbreviatedName { get; set; }

    /// <summary>
    /// Gets or Sets Colour
    /// </summary>
    [DataMember(Name="Colour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Colour")]
    public string Colour { get; set; }

    /// <summary>
    /// Gets or Sets SequenceNumber
    /// </summary>
    [DataMember(Name="SequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SequenceNumber")]
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceExDelta
    /// </summary>
    [DataMember(Name="StandardSellPriceExDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceExDelta")]
    public double? StandardSellPriceExDelta { get; set; }

    /// <summary>
    /// Gets or Sets MediaFileID
    /// </summary>
    [DataMember(Name="MediaFileID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaFileID")]
    public int? MediaFileID { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryVariationOptionT {\n");
      sb.Append("  VariationName: ").Append(VariationName).Append("\n");
      sb.Append("  VariationAbbreviatedName: ").Append(VariationAbbreviatedName).Append("\n");
      sb.Append("  MediaFileUrl: ").Append(MediaFileUrl).Append("\n");
      sb.Append("  MediaFileThumbnailUrl: ").Append(MediaFileThumbnailUrl).Append("\n");
      sb.Append("  StandardSellPriceIncDelta: ").Append(StandardSellPriceIncDelta).Append("\n");
      sb.Append("  VariationOptionID: ").Append(VariationOptionID).Append("\n");
      sb.Append("  VariationID: ").Append(VariationID).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
      sb.Append("  Colour: ").Append(Colour).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  StandardSellPriceExDelta: ").Append(StandardSellPriceExDelta).Append("\n");
      sb.Append("  MediaFileID: ").Append(MediaFileID).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
