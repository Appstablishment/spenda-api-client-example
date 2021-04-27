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
  public class ResultCollectionOfCustomerTransT {
    /// <summary>
    /// Gets or Sets ResultsList
    /// </summary>
    [DataMember(Name="ResultsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResultsList")]
    public List<CustomerTransT> ResultsList { get; set; }

    /// <summary>
    /// Gets or Sets RadioButtonList
    /// </summary>
    [DataMember(Name="RadioButtonList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RadioButtonList")]
    public List<Feature> RadioButtonList { get; set; }

    /// <summary>
    /// Gets or Sets CheckBoxList
    /// </summary>
    [DataMember(Name="CheckBoxList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckBoxList")]
    public List<Feature> CheckBoxList { get; set; }

    /// <summary>
    /// Gets or Sets BrandsList
    /// </summary>
    [DataMember(Name="BrandsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrandsList")]
    public List<Feature> BrandsList { get; set; }

    /// <summary>
    /// Gets or Sets TotalRecordCount
    /// </summary>
    [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalRecordCount")]
    public int? TotalRecordCount { get; set; }

    /// <summary>
    /// Gets or Sets ShowPrices
    /// </summary>
    [DataMember(Name="ShowPrices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowPrices")]
    public bool? ShowPrices { get; set; }

    /// <summary>
    /// Gets or Sets ShowExPrices
    /// </summary>
    [DataMember(Name="ShowExPrices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowExPrices")]
    public bool? ShowExPrices { get; set; }

    /// <summary>
    /// Gets or Sets IsSeparateLines
    /// </summary>
    [DataMember(Name="IsSeparateLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSeparateLines")]
    public bool? IsSeparateLines { get; set; }

    /// <summary>
    /// Gets or Sets WasSearchLimited
    /// </summary>
    [DataMember(Name="WasSearchLimited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasSearchLimited")]
    public bool? WasSearchLimited { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailImagePath
    /// </summary>
    [DataMember(Name="ThumbnailImagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ThumbnailImagePath")]
    public string ThumbnailImagePath { get; set; }

    /// <summary>
    /// Gets or Sets ImagePath
    /// </summary>
    [DataMember(Name="ImagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ImagePath")]
    public string ImagePath { get; set; }

    /// <summary>
    /// Gets or Sets MaxRowNumber
    /// </summary>
    [DataMember(Name="MaxRowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxRowNumber")]
    public long? MaxRowNumber { get; set; }

    /// <summary>
    /// Gets or Sets IsMore
    /// </summary>
    [DataMember(Name="IsMore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMore")]
    public bool? IsMore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResultCollectionOfCustomerTransT {\n");
      sb.Append("  ResultsList: ").Append(ResultsList).Append("\n");
      sb.Append("  RadioButtonList: ").Append(RadioButtonList).Append("\n");
      sb.Append("  CheckBoxList: ").Append(CheckBoxList).Append("\n");
      sb.Append("  BrandsList: ").Append(BrandsList).Append("\n");
      sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
      sb.Append("  ShowPrices: ").Append(ShowPrices).Append("\n");
      sb.Append("  ShowExPrices: ").Append(ShowExPrices).Append("\n");
      sb.Append("  IsSeparateLines: ").Append(IsSeparateLines).Append("\n");
      sb.Append("  WasSearchLimited: ").Append(WasSearchLimited).Append("\n");
      sb.Append("  ThumbnailImagePath: ").Append(ThumbnailImagePath).Append("\n");
      sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
      sb.Append("  MaxRowNumber: ").Append(MaxRowNumber).Append("\n");
      sb.Append("  IsMore: ").Append(IsMore).Append("\n");
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
