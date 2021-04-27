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
  public class CategoryT {
    /// <summary>
    /// Gets or Sets HierarchyLevel
    /// </summary>
    [DataMember(Name="HierarchyLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HierarchyLevel")]
    public int? HierarchyLevel { get; set; }

    /// <summary>
    /// Gets or Sets CategoryType
    /// </summary>
    [DataMember(Name="CategoryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CategoryType")]
    public string CategoryType { get; set; }

    /// <summary>
    /// Gets or Sets Sequence
    /// </summary>
    [DataMember(Name="Sequence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Sequence")]
    public int? Sequence { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

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
    /// Gets or Sets ParentID
    /// </summary>
    [DataMember(Name="ParentID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentID")]
    public int? ParentID { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets ParentName
    /// </summary>
    [DataMember(Name="ParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentName")]
    public string ParentName { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets Route
    /// </summary>
    [DataMember(Name="Route", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Route")]
    public string Route { get; set; }

    /// <summary>
    /// Gets or Sets BSID
    /// </summary>
    [DataMember(Name="BSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BSID")]
    public string BSID { get; set; }

    /// <summary>
    /// Gets or Sets PageTitle
    /// </summary>
    [DataMember(Name="PageTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageTitle")]
    public string PageTitle { get; set; }

    /// <summary>
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets PageHeading
    /// </summary>
    [DataMember(Name="PageHeading", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageHeading")]
    public string PageHeading { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets MetaDescription
    /// </summary>
    [DataMember(Name="MetaDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MetaDescription")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets MetaKeywords
    /// </summary>
    [DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MetaKeywords")]
    public string MetaKeywords { get; set; }

    /// <summary>
    /// Gets or Sets URL
    /// </summary>
    [DataMember(Name="URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URL")]
    public string URL { get; set; }

    /// <summary>
    /// Gets or Sets CanonicalUrl
    /// </summary>
    [DataMember(Name="CanonicalUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanonicalUrl")]
    public string CanonicalUrl { get; set; }

    /// <summary>
    /// Gets or Sets Slug
    /// </summary>
    [DataMember(Name="Slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Gets or Sets HTMLDescription
    /// </summary>
    [DataMember(Name="HTMLDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HTMLDescription")]
    public string HTMLDescription { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets MediaFiles
    /// </summary>
    [DataMember(Name="MediaFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaFiles")]
    public List<MediaFileT> MediaFiles { get; set; }

    /// <summary>
    /// Gets or Sets SyncLogs
    /// </summary>
    [DataMember(Name="SyncLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncLogs")]
    public List<SyncLogT> SyncLogs { get; set; }

    /// <summary>
    /// Gets or Sets ParentCategory
    /// </summary>
    [DataMember(Name="ParentCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentCategory")]
    public CategoryT ParentCategory { get; set; }

    /// <summary>
    /// Gets or Sets ChildCategories
    /// </summary>
    [DataMember(Name="ChildCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildCategories")]
    public List<CategoryT> ChildCategories { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCount
    /// </summary>
    [DataMember(Name="InventoryCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCount")]
    public int? InventoryCount { get; set; }

    /// <summary>
    /// Gets or Sets IsFavourite
    /// </summary>
    [DataMember(Name="IsFavourite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsFavourite")]
    public bool? IsFavourite { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryT {\n");
      sb.Append("  HierarchyLevel: ").Append(HierarchyLevel).Append("\n");
      sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
      sb.Append("  Sequence: ").Append(Sequence).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  ParentID: ").Append(ParentID).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  ParentName: ").Append(ParentName).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  Route: ").Append(Route).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  PageHeading: ").Append(PageHeading).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
      sb.Append("  CanonicalUrl: ").Append(CanonicalUrl).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  HTMLDescription: ").Append(HTMLDescription).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  MediaFiles: ").Append(MediaFiles).Append("\n");
      sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
      sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
      sb.Append("  ChildCategories: ").Append(ChildCategories).Append("\n");
      sb.Append("  InventoryCount: ").Append(InventoryCount).Append("\n");
      sb.Append("  IsFavourite: ").Append(IsFavourite).Append("\n");
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
