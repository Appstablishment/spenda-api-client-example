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
  public class InventoryItemT {
    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets IsLinkedToSupplierInventory
    /// </summary>
    [DataMember(Name="IsLinkedToSupplierInventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLinkedToSupplierInventory")]
    public bool? IsLinkedToSupplierInventory { get; set; }

    /// <summary>
    /// Gets or Sets TotalSOH
    /// </summary>
    [DataMember(Name="TotalSOH", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalSOH")]
    public double? TotalSOH { get; set; }

    /// <summary>
    /// Gets or Sets DefaultImageURL
    /// </summary>
    [DataMember(Name="DefaultImageURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultImageURL")]
    public string DefaultImageURL { get; set; }

    /// <summary>
    /// Gets or Sets DefaultThumbnailURL
    /// </summary>
    [DataMember(Name="DefaultThumbnailURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultThumbnailURL")]
    public string DefaultThumbnailURL { get; set; }

    /// <summary>
    /// Gets or Sets MediaCount
    /// </summary>
    [DataMember(Name="MediaCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaCount")]
    public int? MediaCount { get; set; }

    /// <summary>
    /// Gets or Sets ParentSKU
    /// </summary>
    [DataMember(Name="ParentSKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentSKU")]
    public string ParentSKU { get; set; }

    /// <summary>
    /// Gets or Sets VariantMasterCode
    /// </summary>
    [DataMember(Name="VariantMasterCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariantMasterCode")]
    public string VariantMasterCode { get; set; }

    /// <summary>
    /// Gets or Sets IsShippable
    /// </summary>
    [DataMember(Name="IsShippable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsShippable")]
    public bool? IsShippable { get; set; }

    /// <summary>
    /// Gets or Sets IsReducable
    /// </summary>
    [DataMember(Name="IsReducable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReducable")]
    public bool? IsReducable { get; set; }

    /// <summary>
    /// Gets or Sets IsOrderable
    /// </summary>
    [DataMember(Name="IsOrderable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOrderable")]
    public bool? IsOrderable { get; set; }

    /// <summary>
    /// Gets or Sets IsInCatalogue
    /// </summary>
    [DataMember(Name="IsInCatalogue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsInCatalogue")]
    public bool? IsInCatalogue { get; set; }

    /// <summary>
    /// Gets or Sets IsUsingAverageCostPrice
    /// </summary>
    [DataMember(Name="IsUsingAverageCostPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsUsingAverageCostPrice")]
    public bool? IsUsingAverageCostPrice { get; set; }

    /// <summary>
    /// Gets or Sets MinMaxLevels
    /// </summary>
    [DataMember(Name="MinMaxLevels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinMaxLevels")]
    public List<WarehouseStockMinMaxLevelT> MinMaxLevels { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [DataMember(Name="IsSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets IsVariantPriceOverride
    /// </summary>
    [DataMember(Name="IsVariantPriceOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVariantPriceOverride")]
    public bool? IsVariantPriceOverride { get; set; }

    /// <summary>
    /// Gets or Sets VariantsCount
    /// </summary>
    [DataMember(Name="VariantsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariantsCount")]
    public int? VariantsCount { get; set; }

    /// <summary>
    /// Gets or Sets LinkedVariantsCount
    /// </summary>
    [DataMember(Name="LinkedVariantsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedVariantsCount")]
    public int? LinkedVariantsCount { get; set; }

    /// <summary>
    /// Gets or Sets UnlinkedVariantsCount
    /// </summary>
    [DataMember(Name="UnlinkedVariantsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UnlinkedVariantsCount")]
    public int? UnlinkedVariantsCount { get; set; }

    /// <summary>
    /// Gets or Sets IsIntegrated
    /// </summary>
    [DataMember(Name="IsIntegrated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsIntegrated")]
    public bool? IsIntegrated { get; set; }

    /// <summary>
    /// Gets or Sets MaxStandardSellPriceEx
    /// </summary>
    [DataMember(Name="MaxStandardSellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxStandardSellPriceEx")]
    public double? MaxStandardSellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets ChildVariants
    /// </summary>
    [DataMember(Name="ChildVariants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildVariants")]
    public List<ChildVariant> ChildVariants { get; set; }

    /// <summary>
    /// Gets or Sets ChildInventoryClassID
    /// </summary>
    [DataMember(Name="ChildInventoryClassID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildInventoryClassID")]
    public int? ChildInventoryClassID { get; set; }

    /// <summary>
    /// Gets or Sets ChildInventoryClassName
    /// </summary>
    [DataMember(Name="ChildInventoryClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildInventoryClassName")]
    public string ChildInventoryClassName { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPickingLocation
    /// </summary>
    [DataMember(Name="DefaultPickingLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPickingLocation")]
    public WarehouseLocationInfo DefaultPickingLocation { get; set; }

    /// <summary>
    /// Gets or Sets DefaultReceiveLocation
    /// </summary>
    [DataMember(Name="DefaultReceiveLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReceiveLocation")]
    public WarehouseLocationInfo DefaultReceiveLocation { get; set; }

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
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryCode
    /// </summary>
    [DataMember(Name="InventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryCode")]
    public string InventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets EAN
    /// </summary>
    [DataMember(Name="EAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EAN")]
    public string EAN { get; set; }

    /// <summary>
    /// Gets or Sets Barcode
    /// </summary>
    [DataMember(Name="Barcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Barcode")]
    public string Barcode { get; set; }

    /// <summary>
    /// Gets or Sets SKU
    /// </summary>
    [DataMember(Name="SKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SKU")]
    public string SKU { get; set; }

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
    /// Gets or Sets CreatedWith
    /// </summary>
    [DataMember(Name="CreatedWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedWith")]
    public string CreatedWith { get; set; }

    /// <summary>
    /// Gets or Sets InventoryClassID
    /// </summary>
    [DataMember(Name="InventoryClassID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryClassID")]
    public int? InventoryClassID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryClassName
    /// </summary>
    [DataMember(Name="InventoryClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryClassName")]
    public string InventoryClassName { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets IsDiscontinued
    /// </summary>
    [DataMember(Name="IsDiscontinued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDiscontinued")]
    public bool? IsDiscontinued { get; set; }

    /// <summary>
    /// Gets or Sets DiscontinuedDate
    /// </summary>
    [DataMember(Name="DiscontinuedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscontinuedDate")]
    public DateTime? DiscontinuedDate { get; set; }

    /// <summary>
    /// Gets or Sets IsAssetItem
    /// </summary>
    [DataMember(Name="IsAssetItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAssetItem")]
    public bool? IsAssetItem { get; set; }

    /// <summary>
    /// Gets or Sets IsSold
    /// </summary>
    [DataMember(Name="IsSold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSold")]
    public bool? IsSold { get; set; }

    /// <summary>
    /// Gets or Sets IsOrderTaxExempt
    /// </summary>
    [DataMember(Name="IsOrderTaxExempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOrderTaxExempt")]
    public bool? IsOrderTaxExempt { get; set; }

    /// <summary>
    /// Gets or Sets IsPhysical
    /// </summary>
    [DataMember(Name="IsPhysical", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPhysical")]
    public bool? IsPhysical { get; set; }

    /// <summary>
    /// Gets or Sets IsSOHTracked
    /// </summary>
    [DataMember(Name="IsSOHTracked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSOHTracked")]
    public bool? IsSOHTracked { get; set; }

    /// <summary>
    /// Gets or Sets IsPurchased
    /// </summary>
    [DataMember(Name="IsPurchased", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPurchased")]
    public bool? IsPurchased { get; set; }

    /// <summary>
    /// Gets or Sets AssetType
    /// </summary>
    [DataMember(Name="AssetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetType")]
    public string AssetType { get; set; }

    /// <summary>
    /// Gets or Sets IsOuterItem
    /// </summary>
    [DataMember(Name="IsOuterItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOuterItem")]
    public bool? IsOuterItem { get; set; }

    /// <summary>
    /// Gets or Sets IsInnerItem
    /// </summary>
    [DataMember(Name="IsInnerItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsInnerItem")]
    public bool? IsInnerItem { get; set; }

    /// <summary>
    /// Gets or Sets BaseUnitQty
    /// </summary>
    [DataMember(Name="BaseUnitQty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BaseUnitQty")]
    public int? BaseUnitQty { get; set; }

    /// <summary>
    /// Gets or Sets BaseUoM
    /// </summary>
    [DataMember(Name="BaseUoM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BaseUoM")]
    public string BaseUoM { get; set; }

    /// <summary>
    /// Gets or Sets BaseUoMDescription
    /// </summary>
    [DataMember(Name="BaseUoMDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BaseUoMDescription")]
    public string BaseUoMDescription { get; set; }

    /// <summary>
    /// Gets or Sets UoM
    /// </summary>
    [DataMember(Name="UoM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UoM")]
    public string UoM { get; set; }

    /// <summary>
    /// Gets or Sets UoMDescription
    /// </summary>
    [DataMember(Name="UoMDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UoMDescription")]
    public string UoMDescription { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShortDescription")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets RFID
    /// </summary>
    [DataMember(Name="RFID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RFID")]
    public string RFID { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="Note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Note")]
    public string Note { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceEx
    /// </summary>
    [DataMember(Name="StandardSellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceEx")]
    public double? StandardSellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceEx
    /// </summary>
    [DataMember(Name="CostPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceEx")]
    public double? CostPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceInc
    /// </summary>
    [DataMember(Name="StandardSellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceInc")]
    public double? StandardSellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets LastBuyPriceEx
    /// </summary>
    [DataMember(Name="LastBuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastBuyPriceEx")]
    public double? LastBuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets RRP
    /// </summary>
    [DataMember(Name="RRP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RRP")]
    public double? RRP { get; set; }

    /// <summary>
    /// Gets or Sets ExpenseAccount
    /// </summary>
    [DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpenseAccount")]
    public string ExpenseAccount { get; set; }

    /// <summary>
    /// Gets or Sets RevenueAccount
    /// </summary>
    [DataMember(Name="RevenueAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RevenueAccount")]
    public string RevenueAccount { get; set; }

    /// <summary>
    /// Gets or Sets AssetAccount
    /// </summary>
    [DataMember(Name="AssetAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetAccount")]
    public string AssetAccount { get; set; }

    /// <summary>
    /// Gets or Sets COGSAccount
    /// </summary>
    [DataMember(Name="COGSAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "COGSAccount")]
    public string COGSAccount { get; set; }

    /// <summary>
    /// Gets or Sets URL
    /// </summary>
    [DataMember(Name="URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URL")]
    public string URL { get; set; }

    /// <summary>
    /// Gets or Sets ManufacturerName
    /// </summary>
    [DataMember(Name="ManufacturerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManufacturerName")]
    public string ManufacturerName { get; set; }

    /// <summary>
    /// Gets or Sets ManufacturerModel
    /// </summary>
    [DataMember(Name="ManufacturerModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManufacturerModel")]
    public string ManufacturerModel { get; set; }

    /// <summary>
    /// Gets or Sets ModelNumber
    /// </summary>
    [DataMember(Name="ModelNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModelNumber")]
    public string ModelNumber { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSupplierName
    /// </summary>
    [DataMember(Name="DefaultSupplierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSupplierName")]
    public string DefaultSupplierName { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSupplierRefNumber
    /// </summary>
    [DataMember(Name="DefaultSupplierRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSupplierRefNumber")]
    public string DefaultSupplierRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSupplierID
    /// </summary>
    [DataMember(Name="DefaultSupplierID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSupplierID")]
    public int? DefaultSupplierID { get; set; }

    /// <summary>
    /// Gets or Sets LengthM
    /// </summary>
    [DataMember(Name="Length_m", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Length_m")]
    public double? LengthM { get; set; }

    /// <summary>
    /// Gets or Sets WidthM
    /// </summary>
    [DataMember(Name="Width_m", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Width_m")]
    public double? WidthM { get; set; }

    /// <summary>
    /// Gets or Sets WeightKg
    /// </summary>
    [DataMember(Name="Weight_kg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Weight_kg")]
    public double? WeightKg { get; set; }

    /// <summary>
    /// Gets or Sets DepthM
    /// </summary>
    [DataMember(Name="Depth_m", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Depth_m")]
    public double? DepthM { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTimeUtc
    /// </summary>
    [DataMember(Name="CreatedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime_utc")]
    public DateTime? CreatedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTimeUtc
    /// </summary>
    [DataMember(Name="ModifiedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedDateTime_utc")]
    public DateTime? ModifiedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets IsVariantMaster
    /// </summary>
    [DataMember(Name="IsVariantMaster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVariantMaster")]
    public bool? IsVariantMaster { get; set; }

    /// <summary>
    /// Gets or Sets PageTitle
    /// </summary>
    [DataMember(Name="PageTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageTitle")]
    public string PageTitle { get; set; }

    /// <summary>
    /// Gets or Sets PageHeading
    /// </summary>
    [DataMember(Name="PageHeading", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageHeading")]
    public string PageHeading { get; set; }

    /// <summary>
    /// Gets or Sets MetaDescription
    /// </summary>
    [DataMember(Name="MetaDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MetaDescription")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// Gets or Sets MetaKeywords
    /// </summary>
    [DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MetaKeywords")]
    public string MetaKeywords { get; set; }

    /// <summary>
    /// Gets or Sets CanonicalUrl
    /// </summary>
    [DataMember(Name="CanonicalUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanonicalUrl")]
    public string CanonicalUrl { get; set; }

    /// <summary>
    /// Gets or Sets HTMLDescription
    /// </summary>
    [DataMember(Name="HTMLDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HTMLDescription")]
    public string HTMLDescription { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets IsPublished
    /// </summary>
    [DataMember(Name="IsPublished", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPublished")]
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Gets or Sets SupplierInventoryGUIDstring
    /// </summary>
    [DataMember(Name="SupplierInventoryGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierInventoryGUIDstring")]
    public string SupplierInventoryGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets IsApproved
    /// </summary>
    [DataMember(Name="IsApproved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsApproved")]
    public bool? IsApproved { get; set; }

    /// <summary>
    /// Gets or Sets Volume
    /// </summary>
    [DataMember(Name="Volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Volume")]
    public double? Volume { get; set; }

    /// <summary>
    /// Gets or Sets MinSalesQty
    /// </summary>
    [DataMember(Name="MinSalesQty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinSalesQty")]
    public double? MinSalesQty { get; set; }

    /// <summary>
    /// Gets or Sets MaxSalesQty
    /// </summary>
    [DataMember(Name="MaxSalesQty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxSalesQty")]
    public double? MaxSalesQty { get; set; }

    /// <summary>
    /// Gets or Sets IsPostingInventoryItem
    /// </summary>
    [DataMember(Name="IsPostingInventoryItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPostingInventoryItem")]
    public bool? IsPostingInventoryItem { get; set; }

    /// <summary>
    /// Gets or Sets ChildIsSold
    /// </summary>
    [DataMember(Name="ChildIsSold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildIsSold")]
    public bool? ChildIsSold { get; set; }

    /// <summary>
    /// Gets or Sets ChildIsPurchased
    /// </summary>
    [DataMember(Name="ChildIsPurchased", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildIsPurchased")]
    public bool? ChildIsPurchased { get; set; }

    /// <summary>
    /// Gets or Sets ChildIsSOHTracked
    /// </summary>
    [DataMember(Name="ChildIsSOHTracked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildIsSOHTracked")]
    public bool? ChildIsSOHTracked { get; set; }

    /// <summary>
    /// Gets or Sets ChildIsPhysical
    /// </summary>
    [DataMember(Name="ChildIsPhysical", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildIsPhysical")]
    public bool? ChildIsPhysical { get; set; }

    /// <summary>
    /// Gets or Sets ChildExpenseAccount
    /// </summary>
    [DataMember(Name="ChildExpenseAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildExpenseAccount")]
    public string ChildExpenseAccount { get; set; }

    /// <summary>
    /// Gets or Sets ChildRevenueAccount
    /// </summary>
    [DataMember(Name="ChildRevenueAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildRevenueAccount")]
    public string ChildRevenueAccount { get; set; }

    /// <summary>
    /// Gets or Sets ChildAssetAccount
    /// </summary>
    [DataMember(Name="ChildAssetAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildAssetAccount")]
    public string ChildAssetAccount { get; set; }

    /// <summary>
    /// Gets or Sets ChildCOGSAccount
    /// </summary>
    [DataMember(Name="ChildCOGSAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChildCOGSAccount")]
    public string ChildCOGSAccount { get; set; }

    /// <summary>
    /// Gets or Sets StockOnHands
    /// </summary>
    [DataMember(Name="StockOnHands", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StockOnHands")]
    public List<StockOnHandT> StockOnHands { get; set; }

    /// <summary>
    /// Gets or Sets Prices
    /// </summary>
    [DataMember(Name="Prices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prices")]
    public List<PriceT> Prices { get; set; }

    /// <summary>
    /// Gets or Sets Brand
    /// </summary>
    [DataMember(Name="Brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Brand")]
    public BrandT Brand { get; set; }

    /// <summary>
    /// Gets or Sets InventoryClass
    /// </summary>
    [DataMember(Name="InventoryClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryClass")]
    public InventoryClassT InventoryClass { get; set; }

    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="Categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Categories")]
    public List<CategoryT> Categories { get; set; }

    /// <summary>
    /// Gets or Sets MediaFiles
    /// </summary>
    [DataMember(Name="MediaFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MediaFiles")]
    public List<MediaFileT> MediaFiles { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="Tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tags")]
    public List<TagT> Tags { get; set; }

    /// <summary>
    /// Gets or Sets MasterVariant
    /// </summary>
    [DataMember(Name="MasterVariant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MasterVariant")]
    public InventoryItemT MasterVariant { get; set; }

    /// <summary>
    /// Gets or Sets Variants
    /// </summary>
    [DataMember(Name="Variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Variants")]
    public List<InventoryItemT> Variants { get; set; }

    /// <summary>
    /// Gets or Sets SyncLogs
    /// </summary>
    [DataMember(Name="SyncLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncLogs")]
    public List<SyncLogT> SyncLogs { get; set; }

    /// <summary>
    /// Gets or Sets SupplierBuyPrices
    /// </summary>
    [DataMember(Name="SupplierBuyPrices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierBuyPrices")]
    public List<SupplierBuyPriceT> SupplierBuyPrices { get; set; }

    /// <summary>
    /// Gets or Sets Variations
    /// </summary>
    [DataMember(Name="Variations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Variations")]
    public List<InventoryVariationT> Variations { get; set; }

    /// <summary>
    /// Gets or Sets VariationOptions
    /// </summary>
    [DataMember(Name="VariationOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariationOptions")]
    public List<InventoryVariationOptionT> VariationOptions { get; set; }

    /// <summary>
    /// Gets or Sets VariantMasterInventoryID
    /// </summary>
    [DataMember(Name="VariantMasterInventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariantMasterInventoryID")]
    public int? VariantMasterInventoryID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventoryItemT {\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  IsLinkedToSupplierInventory: ").Append(IsLinkedToSupplierInventory).Append("\n");
      sb.Append("  TotalSOH: ").Append(TotalSOH).Append("\n");
      sb.Append("  DefaultImageURL: ").Append(DefaultImageURL).Append("\n");
      sb.Append("  DefaultThumbnailURL: ").Append(DefaultThumbnailURL).Append("\n");
      sb.Append("  MediaCount: ").Append(MediaCount).Append("\n");
      sb.Append("  ParentSKU: ").Append(ParentSKU).Append("\n");
      sb.Append("  VariantMasterCode: ").Append(VariantMasterCode).Append("\n");
      sb.Append("  IsShippable: ").Append(IsShippable).Append("\n");
      sb.Append("  IsReducable: ").Append(IsReducable).Append("\n");
      sb.Append("  IsOrderable: ").Append(IsOrderable).Append("\n");
      sb.Append("  IsInCatalogue: ").Append(IsInCatalogue).Append("\n");
      sb.Append("  IsUsingAverageCostPrice: ").Append(IsUsingAverageCostPrice).Append("\n");
      sb.Append("  MinMaxLevels: ").Append(MinMaxLevels).Append("\n");
      sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
      sb.Append("  IsVariantPriceOverride: ").Append(IsVariantPriceOverride).Append("\n");
      sb.Append("  VariantsCount: ").Append(VariantsCount).Append("\n");
      sb.Append("  LinkedVariantsCount: ").Append(LinkedVariantsCount).Append("\n");
      sb.Append("  UnlinkedVariantsCount: ").Append(UnlinkedVariantsCount).Append("\n");
      sb.Append("  IsIntegrated: ").Append(IsIntegrated).Append("\n");
      sb.Append("  MaxStandardSellPriceEx: ").Append(MaxStandardSellPriceEx).Append("\n");
      sb.Append("  ChildVariants: ").Append(ChildVariants).Append("\n");
      sb.Append("  ChildInventoryClassID: ").Append(ChildInventoryClassID).Append("\n");
      sb.Append("  ChildInventoryClassName: ").Append(ChildInventoryClassName).Append("\n");
      sb.Append("  DefaultPickingLocation: ").Append(DefaultPickingLocation).Append("\n");
      sb.Append("  DefaultReceiveLocation: ").Append(DefaultReceiveLocation).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  InventoryCode: ").Append(InventoryCode).Append("\n");
      sb.Append("  EAN: ").Append(EAN).Append("\n");
      sb.Append("  Barcode: ").Append(Barcode).Append("\n");
      sb.Append("  SKU: ").Append(SKU).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  BSID: ").Append(BSID).Append("\n");
      sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
      sb.Append("  InventoryClassID: ").Append(InventoryClassID).Append("\n");
      sb.Append("  InventoryClassName: ").Append(InventoryClassName).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  IsDiscontinued: ").Append(IsDiscontinued).Append("\n");
      sb.Append("  DiscontinuedDate: ").Append(DiscontinuedDate).Append("\n");
      sb.Append("  IsAssetItem: ").Append(IsAssetItem).Append("\n");
      sb.Append("  IsSold: ").Append(IsSold).Append("\n");
      sb.Append("  IsOrderTaxExempt: ").Append(IsOrderTaxExempt).Append("\n");
      sb.Append("  IsPhysical: ").Append(IsPhysical).Append("\n");
      sb.Append("  IsSOHTracked: ").Append(IsSOHTracked).Append("\n");
      sb.Append("  IsPurchased: ").Append(IsPurchased).Append("\n");
      sb.Append("  AssetType: ").Append(AssetType).Append("\n");
      sb.Append("  IsOuterItem: ").Append(IsOuterItem).Append("\n");
      sb.Append("  IsInnerItem: ").Append(IsInnerItem).Append("\n");
      sb.Append("  BaseUnitQty: ").Append(BaseUnitQty).Append("\n");
      sb.Append("  BaseUoM: ").Append(BaseUoM).Append("\n");
      sb.Append("  BaseUoMDescription: ").Append(BaseUoMDescription).Append("\n");
      sb.Append("  UoM: ").Append(UoM).Append("\n");
      sb.Append("  UoMDescription: ").Append(UoMDescription).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RFID: ").Append(RFID).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  StandardSellPriceEx: ").Append(StandardSellPriceEx).Append("\n");
      sb.Append("  CostPriceEx: ").Append(CostPriceEx).Append("\n");
      sb.Append("  StandardSellPriceInc: ").Append(StandardSellPriceInc).Append("\n");
      sb.Append("  LastBuyPriceEx: ").Append(LastBuyPriceEx).Append("\n");
      sb.Append("  RRP: ").Append(RRP).Append("\n");
      sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append("\n");
      sb.Append("  RevenueAccount: ").Append(RevenueAccount).Append("\n");
      sb.Append("  AssetAccount: ").Append(AssetAccount).Append("\n");
      sb.Append("  COGSAccount: ").Append(COGSAccount).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
      sb.Append("  ManufacturerName: ").Append(ManufacturerName).Append("\n");
      sb.Append("  ManufacturerModel: ").Append(ManufacturerModel).Append("\n");
      sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
      sb.Append("  DefaultSupplierName: ").Append(DefaultSupplierName).Append("\n");
      sb.Append("  DefaultSupplierRefNumber: ").Append(DefaultSupplierRefNumber).Append("\n");
      sb.Append("  DefaultSupplierID: ").Append(DefaultSupplierID).Append("\n");
      sb.Append("  LengthM: ").Append(LengthM).Append("\n");
      sb.Append("  WidthM: ").Append(WidthM).Append("\n");
      sb.Append("  WeightKg: ").Append(WeightKg).Append("\n");
      sb.Append("  DepthM: ").Append(DepthM).Append("\n");
      sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
      sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
      sb.Append("  IsVariantMaster: ").Append(IsVariantMaster).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  PageHeading: ").Append(PageHeading).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  CanonicalUrl: ").Append(CanonicalUrl).Append("\n");
      sb.Append("  HTMLDescription: ").Append(HTMLDescription).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
      sb.Append("  SupplierInventoryGUIDstring: ").Append(SupplierInventoryGUIDstring).Append("\n");
      sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  MinSalesQty: ").Append(MinSalesQty).Append("\n");
      sb.Append("  MaxSalesQty: ").Append(MaxSalesQty).Append("\n");
      sb.Append("  IsPostingInventoryItem: ").Append(IsPostingInventoryItem).Append("\n");
      sb.Append("  ChildIsSold: ").Append(ChildIsSold).Append("\n");
      sb.Append("  ChildIsPurchased: ").Append(ChildIsPurchased).Append("\n");
      sb.Append("  ChildIsSOHTracked: ").Append(ChildIsSOHTracked).Append("\n");
      sb.Append("  ChildIsPhysical: ").Append(ChildIsPhysical).Append("\n");
      sb.Append("  ChildExpenseAccount: ").Append(ChildExpenseAccount).Append("\n");
      sb.Append("  ChildRevenueAccount: ").Append(ChildRevenueAccount).Append("\n");
      sb.Append("  ChildAssetAccount: ").Append(ChildAssetAccount).Append("\n");
      sb.Append("  ChildCOGSAccount: ").Append(ChildCOGSAccount).Append("\n");
      sb.Append("  StockOnHands: ").Append(StockOnHands).Append("\n");
      sb.Append("  Prices: ").Append(Prices).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  InventoryClass: ").Append(InventoryClass).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  MediaFiles: ").Append(MediaFiles).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  MasterVariant: ").Append(MasterVariant).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
      sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
      sb.Append("  SupplierBuyPrices: ").Append(SupplierBuyPrices).Append("\n");
      sb.Append("  Variations: ").Append(Variations).Append("\n");
      sb.Append("  VariationOptions: ").Append(VariationOptions).Append("\n");
      sb.Append("  VariantMasterInventoryID: ").Append(VariantMasterInventoryID).Append("\n");
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
