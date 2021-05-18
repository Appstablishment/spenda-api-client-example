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
  public class BusTransLineT {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets IsPriceRefresh
    /// </summary>
    [DataMember(Name="IsPriceRefresh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPriceRefresh")]
    public bool? IsPriceRefresh { get; set; }

    /// <summary>
    /// Gets or Sets AcquisitionMethod
    /// </summary>
    [DataMember(Name="AcquisitionMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcquisitionMethod")]
    public string AcquisitionMethod { get; set; }

    /// <summary>
    /// Gets or Sets AcquisitionWarehouseID
    /// </summary>
    [DataMember(Name="AcquisitionWarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcquisitionWarehouseID")]
    public int? AcquisitionWarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets AssetID
    /// </summary>
    [DataMember(Name="AssetID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetID")]
    public int? AssetID { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceExString
    /// </summary>
    [DataMember(Name="CostPriceExString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceExString")]
    public string CostPriceExString { get; set; }

    /// <summary>
    /// Gets or Sets DatTypeID
    /// </summary>
    [DataMember(Name="DatTypeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DatTypeID")]
    public int? DatTypeID { get; set; }

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
    /// Gets or Sets DeliveryMethodDescription
    /// </summary>
    [DataMember(Name="DeliveryMethodDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryMethodDescription")]
    public string DeliveryMethodDescription { get; set; }

    /// <summary>
    /// Gets or Sets FeePercentage
    /// </summary>
    [DataMember(Name="FeePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeePercentage")]
    public decimal? FeePercentage { get; set; }

    /// <summary>
    /// Gets or Sets LineID
    /// </summary>
    [DataMember(Name="LineID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineID")]
    public int? LineID { get; set; }

    /// <summary>
    /// Gets or Sets GUID
    /// </summary>
    [DataMember(Name="GUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUID")]
    public Guid? GUID { get; set; }

    /// <summary>
    /// Gets or Sets FeeGUID
    /// </summary>
    [DataMember(Name="FeeGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeGUID")]
    public Guid? FeeGUID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryGUID
    /// </summary>
    [DataMember(Name="InventoryGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryGUID")]
    public Guid? InventoryGUID { get; set; }

    /// <summary>
    /// Gets or Sets HasPriceBeenEdited
    /// </summary>
    [DataMember(Name="HasPriceBeenEdited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasPriceBeenEdited")]
    public bool? HasPriceBeenEdited { get; set; }

    /// <summary>
    /// Gets or Sets IsAssetItem
    /// </summary>
    [DataMember(Name="IsAssetItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAssetItem")]
    public bool? IsAssetItem { get; set; }

    /// <summary>
    /// Gets or Sets IsDiscontinued
    /// </summary>
    [DataMember(Name="IsDiscontinued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDiscontinued")]
    public bool? IsDiscontinued { get; set; }

    /// <summary>
    /// Gets or Sets IsOnSpecial
    /// </summary>
    [DataMember(Name="IsOnSpecial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOnSpecial")]
    public bool? IsOnSpecial { get; set; }

    /// <summary>
    /// Gets or Sets IsTaxable
    /// </summary>
    [DataMember(Name="IsTaxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsTaxable")]
    public bool? IsTaxable { get; set; }

    /// <summary>
    /// Gets or Sets IsVariantMaster
    /// </summary>
    [DataMember(Name="IsVariantMaster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVariantMaster")]
    public bool? IsVariantMaster { get; set; }

    /// <summary>
    /// Gets or Sets ItemID
    /// </summary>
    [DataMember(Name="ItemID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ItemID")]
    public int? ItemID { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalExString
    /// </summary>
    [DataMember(Name="LineTotalExString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalExString")]
    public string LineTotalExString { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalIncString
    /// </summary>
    [DataMember(Name="LineTotalIncString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalIncString")]
    public string LineTotalIncString { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalTaxString
    /// </summary>
    [DataMember(Name="LineTotalTaxString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalTaxString")]
    public string LineTotalTaxString { get; set; }

    /// <summary>
    /// Gets or Sets LineType
    /// </summary>
    [DataMember(Name="LineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineType")]
    public string LineType { get; set; }

    /// <summary>
    /// Gets or Sets MaxOrderQuantity
    /// </summary>
    [DataMember(Name="MaxOrderQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxOrderQuantity")]
    public decimal? MaxOrderQuantity { get; set; }

    /// <summary>
    /// Gets or Sets MinOrderQuantity
    /// </summary>
    [DataMember(Name="MinOrderQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinOrderQuantity")]
    public decimal? MinOrderQuantity { get; set; }

    /// <summary>
    /// Gets or Sets OrderTotalInc
    /// </summary>
    [DataMember(Name="OrderTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OrderTotalInc")]
    public decimal? OrderTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets OrderTotalIncDesc
    /// </summary>
    [DataMember(Name="OrderTotalIncDesc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OrderTotalIncDesc")]
    public string OrderTotalIncDesc { get; set; }

    /// <summary>
    /// Gets or Sets QuantityInCart
    /// </summary>
    [DataMember(Name="QuantityInCart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityInCart")]
    public decimal? QuantityInCart { get; set; }

    /// <summary>
    /// Gets or Sets QuantityInCartString
    /// </summary>
    [DataMember(Name="QuantityInCartString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityInCartString")]
    public string QuantityInCartString { get; set; }

    /// <summary>
    /// Gets or Sets QuantityCancelled
    /// </summary>
    [DataMember(Name="QuantityCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityCancelled")]
    public decimal? QuantityCancelled { get; set; }

    /// <summary>
    /// Gets or Sets ReturnInNumberOfWeeks
    /// </summary>
    [DataMember(Name="ReturnInNumberOfWeeks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReturnInNumberOfWeeks")]
    public decimal? ReturnInNumberOfWeeks { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceExString
    /// </summary>
    [DataMember(Name="SellPriceExString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceExString")]
    public string SellPriceExString { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceIncString
    /// </summary>
    [DataMember(Name="SellPriceIncString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceIncString")]
    public string SellPriceIncString { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceTaxString
    /// </summary>
    [DataMember(Name="SellPriceTaxString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceTaxString")]
    public string SellPriceTaxString { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceInc
    /// </summary>
    [DataMember(Name="StandardSellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceInc")]
    public decimal? StandardSellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets IsCreatedByOtherParty
    /// </summary>
    [DataMember(Name="IsCreatedByOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCreatedByOtherParty")]
    public bool? IsCreatedByOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets IsAmendedByOtherParty
    /// </summary>
    [DataMember(Name="IsAmendedByOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAmendedByOtherParty")]
    public bool? IsAmendedByOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets CommentFromOtherParty
    /// </summary>
    [DataMember(Name="CommentFromOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CommentFromOtherParty")]
    public string CommentFromOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets OriginalLine
    /// </summary>
    [DataMember(Name="OriginalLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OriginalLine")]
    public BusTransLineT OriginalLine { get; set; }

    /// <summary>
    /// Gets or Sets CurrentSuppliersInventoryGUID
    /// </summary>
    [DataMember(Name="CurrentSuppliersInventoryGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentSuppliersInventoryGUID")]
    public Guid? CurrentSuppliersInventoryGUID { get; set; }

    /// <summary>
    /// Gets or Sets IsCanUpdateInventoryOnMerge
    /// </summary>
    [DataMember(Name="IsCanUpdateInventoryOnMerge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCanUpdateInventoryOnMerge")]
    public bool? IsCanUpdateInventoryOnMerge { get; set; }

    /// <summary>
    /// Gets or Sets SupplierInventoryGUID
    /// </summary>
    [DataMember(Name="SupplierInventoryGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierInventoryGUID")]
    public Guid? SupplierInventoryGUID { get; set; }

    /// <summary>
    /// Gets or Sets GUIDstring
    /// </summary>
    [DataMember(Name="GUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GUIDstring")]
    public string GUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets FeeID
    /// </summary>
    [DataMember(Name="FeeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeID")]
    public int? FeeID { get; set; }

    /// <summary>
    /// Gets or Sets FeeGUIDstring
    /// </summary>
    [DataMember(Name="FeeGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeGUIDstring")]
    public string FeeGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets LabourRateID
    /// </summary>
    [DataMember(Name="LabourRateID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LabourRateID")]
    public int? LabourRateID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryID
    /// </summary>
    [DataMember(Name="InventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryID")]
    public int? InventoryID { get; set; }

    /// <summary>
    /// Gets or Sets SequenceNumber
    /// </summary>
    [DataMember(Name="SequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SequenceNumber")]
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="Code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets InventoryBSID
    /// </summary>
    [DataMember(Name="InventoryBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryBSID")]
    public string InventoryBSID { get; set; }

    /// <summary>
    /// Gets or Sets InventoryGUIDstring
    /// </summary>
    [DataMember(Name="InventoryGUIDstring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryGUIDstring")]
    public string InventoryGUIDstring { get; set; }

    /// <summary>
    /// Gets or Sets InventoryType
    /// </summary>
    [DataMember(Name="InventoryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InventoryType")]
    public string InventoryType { get; set; }

    /// <summary>
    /// Gets or Sets Barcode
    /// </summary>
    [DataMember(Name="Barcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Barcode")]
    public string Barcode { get; set; }

    /// <summary>
    /// Gets or Sets EAN
    /// </summary>
    [DataMember(Name="EAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EAN")]
    public string EAN { get; set; }

    /// <summary>
    /// Gets or Sets SKU
    /// </summary>
    [DataMember(Name="SKU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SKU")]
    public string SKU { get; set; }

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
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="Quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets StandardSellPriceEx
    /// </summary>
    [DataMember(Name="StandardSellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardSellPriceEx")]
    public decimal? StandardSellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceInc
    /// </summary>
    [DataMember(Name="CostPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceInc")]
    public decimal? CostPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceTax
    /// </summary>
    [DataMember(Name="CostPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceTax")]
    public decimal? CostPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets CostPriceEx
    /// </summary>
    [DataMember(Name="CostPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostPriceEx")]
    public decimal? CostPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceEx
    /// </summary>
    [DataMember(Name="SellPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceEx")]
    public decimal? SellPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceInc
    /// </summary>
    [DataMember(Name="SellPriceInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceInc")]
    public decimal? SellPriceInc { get; set; }

    /// <summary>
    /// Gets or Sets SellPriceTax
    /// </summary>
    [DataMember(Name="SellPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SellPriceTax")]
    public decimal? SellPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalEx
    /// </summary>
    [DataMember(Name="LineTotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalEx")]
    public decimal? LineTotalEx { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalInc
    /// </summary>
    [DataMember(Name="LineTotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalInc")]
    public decimal? LineTotalInc { get; set; }

    /// <summary>
    /// Gets or Sets LineTotalTax
    /// </summary>
    [DataMember(Name="LineTotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineTotalTax")]
    public decimal? LineTotalTax { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets WarehouseID
    /// </summary>
    [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WarehouseID")]
    public int? WarehouseID { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="IsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets PriceDescription
    /// </summary>
    [DataMember(Name="PriceDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceDescription")]
    public string PriceDescription { get; set; }

    /// <summary>
    /// Gets or Sets PricingMode
    /// </summary>
    [DataMember(Name="PricingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PricingMode")]
    public string PricingMode { get; set; }

    /// <summary>
    /// Gets or Sets PriceType
    /// </summary>
    [DataMember(Name="PriceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceType")]
    public string PriceType { get; set; }

    /// <summary>
    /// Gets or Sets IsSpecialPrice
    /// </summary>
    [DataMember(Name="IsSpecialPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSpecialPrice")]
    public bool? IsSpecialPrice { get; set; }

    /// <summary>
    /// Gets or Sets TaxRate
    /// </summary>
    [DataMember(Name="TaxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxRate")]
    public decimal? TaxRate { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryMethod
    /// </summary>
    [DataMember(Name="DeliveryMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliveryMethod")]
    public string DeliveryMethod { get; set; }

    /// <summary>
    /// Gets or Sets RefInventoryCode
    /// </summary>
    [DataMember(Name="RefInventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefInventoryCode")]
    public string RefInventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets RefBarCode
    /// </summary>
    [DataMember(Name="RefBarCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefBarCode")]
    public string RefBarCode { get; set; }

    /// <summary>
    /// Gets or Sets RefInventoryBSID
    /// </summary>
    [DataMember(Name="RefInventoryBSID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefInventoryBSID")]
    public string RefInventoryBSID { get; set; }

    /// <summary>
    /// Gets or Sets AccountCode
    /// </summary>
    [DataMember(Name="AccountCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCode")]
    public string AccountCode { get; set; }

    /// <summary>
    /// Gets or Sets TaxType
    /// </summary>
    [DataMember(Name="TaxType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaxType")]
    public string TaxType { get; set; }

    /// <summary>
    /// Gets or Sets IsPhysical
    /// </summary>
    [DataMember(Name="IsPhysical", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPhysical")]
    public bool? IsPhysical { get; set; }

    /// <summary>
    /// Gets or Sets ReturnReason
    /// </summary>
    [DataMember(Name="ReturnReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReturnReason")]
    public string ReturnReason { get; set; }

    /// <summary>
    /// Gets or Sets IsRejected
    /// </summary>
    [DataMember(Name="IsRejected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRejected")]
    public bool? IsRejected { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name="Attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attachments")]
    public List<BusTransAttachmentT> Attachments { get; set; }

    /// <summary>
    /// Gets or Sets Warehouse
    /// </summary>
    [DataMember(Name="Warehouse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Warehouse")]
    public WarehouseT Warehouse { get; set; }

    /// <summary>
    /// Gets or Sets QuantityPicked
    /// </summary>
    [DataMember(Name="QuantityPicked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityPicked")]
    public decimal? QuantityPicked { get; set; }

    /// <summary>
    /// Gets or Sets DiscountPercentage
    /// </summary>
    [DataMember(Name="DiscountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountPercentage")]
    public decimal? DiscountPercentage { get; set; }

    /// <summary>
    /// Gets or Sets PostingInventoryID
    /// </summary>
    [DataMember(Name="PostingInventoryID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostingInventoryID")]
    public int? PostingInventoryID { get; set; }

    /// <summary>
    /// Gets or Sets PostingInventoryCode
    /// </summary>
    [DataMember(Name="PostingInventoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostingInventoryCode")]
    public string PostingInventoryCode { get; set; }

    /// <summary>
    /// Gets or Sets QuantityOrdered
    /// </summary>
    [DataMember(Name="QuantityOrdered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityOrdered")]
    public decimal? QuantityOrdered { get; set; }

    /// <summary>
    /// Gets or Sets QuantityReceived
    /// </summary>
    [DataMember(Name="QuantityReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityReceived")]
    public decimal? QuantityReceived { get; set; }

    /// <summary>
    /// Gets or Sets QuantityFaulty
    /// </summary>
    [DataMember(Name="QuantityFaulty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityFaulty")]
    public decimal? QuantityFaulty { get; set; }

    /// <summary>
    /// Gets or Sets QuantityIncorrect
    /// </summary>
    [DataMember(Name="QuantityIncorrect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityIncorrect")]
    public decimal? QuantityIncorrect { get; set; }

    /// <summary>
    /// Gets or Sets QuantityOutofDate
    /// </summary>
    [DataMember(Name="QuantityOutofDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityOutofDate")]
    public decimal? QuantityOutofDate { get; set; }

    /// <summary>
    /// Gets or Sets TotalQuantityReceived
    /// </summary>
    [DataMember(Name="TotalQuantityReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalQuantityReceived")]
    public decimal? TotalQuantityReceived { get; set; }

    /// <summary>
    /// Gets or Sets ExpectedBuyPriceEx
    /// </summary>
    [DataMember(Name="ExpectedBuyPriceEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpectedBuyPriceEx")]
    public decimal? ExpectedBuyPriceEx { get; set; }

    /// <summary>
    /// Gets or Sets CalculatedBuyPriceTax
    /// </summary>
    [DataMember(Name="CalculatedBuyPriceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CalculatedBuyPriceTax")]
    public decimal? CalculatedBuyPriceTax { get; set; }

    /// <summary>
    /// Gets or Sets AdjustedQuantityReceived
    /// </summary>
    [DataMember(Name="AdjustedQuantityReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdjustedQuantityReceived")]
    public decimal? AdjustedQuantityReceived { get; set; }

    /// <summary>
    /// Gets or Sets SupplierInventoryGUIDString
    /// </summary>
    [DataMember(Name="SupplierInventoryGUIDString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupplierInventoryGUIDString")]
    public string SupplierInventoryGUIDString { get; set; }

    /// <summary>
    /// Gets or Sets QuantityRefunded
    /// </summary>
    [DataMember(Name="QuantityRefunded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityRefunded")]
    public decimal? QuantityRefunded { get; set; }

    /// <summary>
    /// Gets or Sets ClaimRequestLines
    /// </summary>
    [DataMember(Name="ClaimRequestLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClaimRequestLines")]
    public List<ClaimRequestLineT> ClaimRequestLines { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BusTransLineT {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  IsPriceRefresh: ").Append(IsPriceRefresh).Append("\n");
      sb.Append("  AcquisitionMethod: ").Append(AcquisitionMethod).Append("\n");
      sb.Append("  AcquisitionWarehouseID: ").Append(AcquisitionWarehouseID).Append("\n");
      sb.Append("  AssetID: ").Append(AssetID).Append("\n");
      sb.Append("  CostPriceExString: ").Append(CostPriceExString).Append("\n");
      sb.Append("  DatTypeID: ").Append(DatTypeID).Append("\n");
      sb.Append("  DefaultImageURL: ").Append(DefaultImageURL).Append("\n");
      sb.Append("  DefaultThumbnailURL: ").Append(DefaultThumbnailURL).Append("\n");
      sb.Append("  DeliveryMethodDescription: ").Append(DeliveryMethodDescription).Append("\n");
      sb.Append("  FeePercentage: ").Append(FeePercentage).Append("\n");
      sb.Append("  LineID: ").Append(LineID).Append("\n");
      sb.Append("  GUID: ").Append(GUID).Append("\n");
      sb.Append("  FeeGUID: ").Append(FeeGUID).Append("\n");
      sb.Append("  InventoryGUID: ").Append(InventoryGUID).Append("\n");
      sb.Append("  HasPriceBeenEdited: ").Append(HasPriceBeenEdited).Append("\n");
      sb.Append("  IsAssetItem: ").Append(IsAssetItem).Append("\n");
      sb.Append("  IsDiscontinued: ").Append(IsDiscontinued).Append("\n");
      sb.Append("  IsOnSpecial: ").Append(IsOnSpecial).Append("\n");
      sb.Append("  IsTaxable: ").Append(IsTaxable).Append("\n");
      sb.Append("  IsVariantMaster: ").Append(IsVariantMaster).Append("\n");
      sb.Append("  ItemID: ").Append(ItemID).Append("\n");
      sb.Append("  LineTotalExString: ").Append(LineTotalExString).Append("\n");
      sb.Append("  LineTotalIncString: ").Append(LineTotalIncString).Append("\n");
      sb.Append("  LineTotalTaxString: ").Append(LineTotalTaxString).Append("\n");
      sb.Append("  LineType: ").Append(LineType).Append("\n");
      sb.Append("  MaxOrderQuantity: ").Append(MaxOrderQuantity).Append("\n");
      sb.Append("  MinOrderQuantity: ").Append(MinOrderQuantity).Append("\n");
      sb.Append("  OrderTotalInc: ").Append(OrderTotalInc).Append("\n");
      sb.Append("  OrderTotalIncDesc: ").Append(OrderTotalIncDesc).Append("\n");
      sb.Append("  QuantityInCart: ").Append(QuantityInCart).Append("\n");
      sb.Append("  QuantityInCartString: ").Append(QuantityInCartString).Append("\n");
      sb.Append("  QuantityCancelled: ").Append(QuantityCancelled).Append("\n");
      sb.Append("  ReturnInNumberOfWeeks: ").Append(ReturnInNumberOfWeeks).Append("\n");
      sb.Append("  SellPriceExString: ").Append(SellPriceExString).Append("\n");
      sb.Append("  SellPriceIncString: ").Append(SellPriceIncString).Append("\n");
      sb.Append("  SellPriceTaxString: ").Append(SellPriceTaxString).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  StandardSellPriceInc: ").Append(StandardSellPriceInc).Append("\n");
      sb.Append("  IsCreatedByOtherParty: ").Append(IsCreatedByOtherParty).Append("\n");
      sb.Append("  IsAmendedByOtherParty: ").Append(IsAmendedByOtherParty).Append("\n");
      sb.Append("  CommentFromOtherParty: ").Append(CommentFromOtherParty).Append("\n");
      sb.Append("  OriginalLine: ").Append(OriginalLine).Append("\n");
      sb.Append("  CurrentSuppliersInventoryGUID: ").Append(CurrentSuppliersInventoryGUID).Append("\n");
      sb.Append("  IsCanUpdateInventoryOnMerge: ").Append(IsCanUpdateInventoryOnMerge).Append("\n");
      sb.Append("  SupplierInventoryGUID: ").Append(SupplierInventoryGUID).Append("\n");
      sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
      sb.Append("  FeeID: ").Append(FeeID).Append("\n");
      sb.Append("  FeeGUIDstring: ").Append(FeeGUIDstring).Append("\n");
      sb.Append("  LabourRateID: ").Append(LabourRateID).Append("\n");
      sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  InventoryBSID: ").Append(InventoryBSID).Append("\n");
      sb.Append("  InventoryGUIDstring: ").Append(InventoryGUIDstring).Append("\n");
      sb.Append("  InventoryType: ").Append(InventoryType).Append("\n");
      sb.Append("  Barcode: ").Append(Barcode).Append("\n");
      sb.Append("  EAN: ").Append(EAN).Append("\n");
      sb.Append("  SKU: ").Append(SKU).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  UoM: ").Append(UoM).Append("\n");
      sb.Append("  UoMDescription: ").Append(UoMDescription).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  StandardSellPriceEx: ").Append(StandardSellPriceEx).Append("\n");
      sb.Append("  CostPriceInc: ").Append(CostPriceInc).Append("\n");
      sb.Append("  CostPriceTax: ").Append(CostPriceTax).Append("\n");
      sb.Append("  CostPriceEx: ").Append(CostPriceEx).Append("\n");
      sb.Append("  SellPriceEx: ").Append(SellPriceEx).Append("\n");
      sb.Append("  SellPriceInc: ").Append(SellPriceInc).Append("\n");
      sb.Append("  SellPriceTax: ").Append(SellPriceTax).Append("\n");
      sb.Append("  LineTotalEx: ").Append(LineTotalEx).Append("\n");
      sb.Append("  LineTotalInc: ").Append(LineTotalInc).Append("\n");
      sb.Append("  LineTotalTax: ").Append(LineTotalTax).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  PriceDescription: ").Append(PriceDescription).Append("\n");
      sb.Append("  PricingMode: ").Append(PricingMode).Append("\n");
      sb.Append("  PriceType: ").Append(PriceType).Append("\n");
      sb.Append("  IsSpecialPrice: ").Append(IsSpecialPrice).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
      sb.Append("  RefInventoryCode: ").Append(RefInventoryCode).Append("\n");
      sb.Append("  RefBarCode: ").Append(RefBarCode).Append("\n");
      sb.Append("  RefInventoryBSID: ").Append(RefInventoryBSID).Append("\n");
      sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
      sb.Append("  TaxType: ").Append(TaxType).Append("\n");
      sb.Append("  IsPhysical: ").Append(IsPhysical).Append("\n");
      sb.Append("  ReturnReason: ").Append(ReturnReason).Append("\n");
      sb.Append("  IsRejected: ").Append(IsRejected).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
      sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
      sb.Append("  QuantityPicked: ").Append(QuantityPicked).Append("\n");
      sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
      sb.Append("  PostingInventoryID: ").Append(PostingInventoryID).Append("\n");
      sb.Append("  PostingInventoryCode: ").Append(PostingInventoryCode).Append("\n");
      sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
      sb.Append("  QuantityReceived: ").Append(QuantityReceived).Append("\n");
      sb.Append("  QuantityFaulty: ").Append(QuantityFaulty).Append("\n");
      sb.Append("  QuantityIncorrect: ").Append(QuantityIncorrect).Append("\n");
      sb.Append("  QuantityOutofDate: ").Append(QuantityOutofDate).Append("\n");
      sb.Append("  TotalQuantityReceived: ").Append(TotalQuantityReceived).Append("\n");
      sb.Append("  ExpectedBuyPriceEx: ").Append(ExpectedBuyPriceEx).Append("\n");
      sb.Append("  CalculatedBuyPriceTax: ").Append(CalculatedBuyPriceTax).Append("\n");
      sb.Append("  AdjustedQuantityReceived: ").Append(AdjustedQuantityReceived).Append("\n");
      sb.Append("  SupplierInventoryGUIDString: ").Append(SupplierInventoryGUIDString).Append("\n");
      sb.Append("  QuantityRefunded: ").Append(QuantityRefunded).Append("\n");
      sb.Append("  ClaimRequestLines: ").Append(ClaimRequestLines).Append("\n");
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
