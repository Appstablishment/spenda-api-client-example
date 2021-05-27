using Spenda.SDK.Models;
using System.Collections.Generic;

namespace Spenda.SDK.Tests.Mocks
{
    public static class Inventory
    {
        public static InventorySaveRequest Get(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                Object = new InventoryItemT
                {
                    ID = Id,
                    IsShippable = true,
                    IsOrderable = true,
                    IsInCatalogue = false,
                    InventoryCode = "IC27GL63T123",
                    Barcode = "BC27GL63T123",
                    SKU = "SKU27GL63T123",
                    IsActive = true,
                    IsAssetItem = false,
                    IsSold = false,
                    IsOrderTaxExempt = false,
                    IsPhysical = true,
                    IsSOHTracked = false,
                    IsPurchased = false,
                    UoM = "EA",
                    UoMDescription = "Each",
                    ShortDescription = "LG 27GL63T 27inch",
                    Description = "LG 27GL63T 27inch 144Hz Full HD IPS Gaming Monitor",
                    StandardSellPriceEx = 500,
                    StandardSellPriceInc = 90,
                    LastBuyPriceEx = null,
                    RRP = 500,
                    IsVariantMaster = false,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000m,
                    CreatedWith = "SDK"
                }
            };

            return newInventory;
        }

        public static InventorySaveRequest GetInventoryWithCreatedBrands(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                Object = new InventoryItemT
                {
                    ID = Id,
                    IsShippable = true,
                    IsOrderable = true,
                    IsInCatalogue = false,
                    InventoryCode = "IC27GL63PROB9",
                    Barcode = "BC27GL63PROB9",
                    SKU = "SKU27GL63PROB9",
                    IsActive = true,
                    IsAssetItem = false,
                    IsSold = false,
                    IsOrderTaxExempt = false,
                    IsPhysical = true,
                    IsSOHTracked = false,
                    IsPurchased = false,
                    UoM = "EA",
                    UoMDescription = "Each",
                    ShortDescription = "Product Bug 9",
                    Description = "Product Bug 9",
                    StandardSellPriceEx = 500,
                    StandardSellPriceInc = 90,
                    LastBuyPriceEx = null,
                    RRP = 500,
                    IsVariantMaster = false,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000m,
                    CreatedWith = "SDK",
                    Brand = new BrandT
                    {
                        ID = 121456
                    }
                }
            };

            return newInventory;
        }


        public static InventorySaveRequest GetInventoryWithCreatedCategories(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                Object = new InventoryItemT
                {
                    ID = Id,
                    IsShippable = true,
                    IsOrderable = true,
                    IsInCatalogue = false,
                    InventoryCode = "IC27GL63PROB17",
                    Barcode = "BC27GL63PROB17",
                    SKU = "SKU27GL63PROB17",
                    IsActive = true,
                    IsAssetItem = false,
                    IsSold = false,
                    IsOrderTaxExempt = false,
                    IsPhysical = true,
                    IsSOHTracked = false,
                    IsPurchased = false,
                    UoM = "EA",
                    UoMDescription = "Each",
                    ShortDescription = "Product Bug 17",
                    Description = "Product Bug 17",
                    StandardSellPriceEx = 500,
                    StandardSellPriceInc = 90,
                    LastBuyPriceEx = null,
                    RRP = 500,
                    IsVariantMaster = false,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000m,
                    CreatedWith = "SDK",
                    Categories = new List<CategoryT>()
                    {
                       new CategoryT(){ ID = 34313, Name = "cate 3"},
                    }
                }
            };

            return newInventory;
        }

        public static InventorySaveRequest GetInventoryWithNonCreatedCategories(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                Object = new InventoryItemT
                {
                    ID = Id,
                    IsShippable = true,
                    IsOrderable = true,
                    IsInCatalogue = false,
                    InventoryCode = "IC52GL63T123",
                    Barcode = "BC52GL63T123",
                    SKU = "SKU52GL63T123",
                    IsActive = true,
                    IsAssetItem = false,
                    IsSold = false,
                    IsOrderTaxExempt = false,
                    IsPhysical = true,
                    IsSOHTracked = false,
                    IsPurchased = false,
                    UoM = "EA",
                    UoMDescription = "Each",
                    ShortDescription = "LG 52GL63T 27inch",
                    Description = "LG 52GL63T 32inch 144Hz Full HD IPS Gaming Monitor",
                    StandardSellPriceEx = 500,
                    StandardSellPriceInc = 90,
                    LastBuyPriceEx = null,
                    RRP = 500,
                    IsVariantMaster = false,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000m,
                    CreatedWith = "SDK",
                    Categories = new List<CategoryT>()
                    {
                       new CategoryT(){ Description = "cate 4"},
                    }
                }
            };

            return newInventory;
        }

        public static ActionRequestOfInventoryVariations getVariantInventoryObject(int? Id = null)
        {
            var newInventoryVariant = new ActionRequestOfInventoryVariations
            {
                Value = new List<InventoryVariationT>
                {
                    new InventoryVariationT{
                        MasterInventoryID = Id,
                        Name = "Size",
                        SequenceNumber = 10,
                        IsActive = true,
                        Options = new List<InventoryVariationOptionT>
                        {
                            new InventoryVariationOptionT{
                                VariationName = "10",
                                Name = "10",
                                AbbreviatedName = "10",
                                IsActive = true,
                                SequenceNumber = 10,
                            },
                            new InventoryVariationOptionT{
                                VariationName = "20",
                                Name = "20",
                                AbbreviatedName = "20",
                                IsActive = true,
                                SequenceNumber = 20,
                            },
                            new InventoryVariationOptionT{
                                VariationName = "30",
                                Name = "30",
                                AbbreviatedName = "30",
                                IsActive = true,
                                SequenceNumber = 30,
                            }

                        }
                    }
                }
            };
            return newInventoryVariant;
        }

        public static InventorySaveRequest getInventoryWithVariationObject(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                Object = new InventoryItemT
                {
                    ID = Id,
                    IsShippable = true,
                    IsOrderable = true,
                    IsInCatalogue = false,
                    InventoryCode = "IC1234",
                    Barcode = "BC1234",
                    SKU = "SKU1234",
                    IsActive = true,
                    IsAssetItem = false,
                    IsSold = false,
                    IsOrderTaxExempt = false,
                    IsPhysical = true,
                    IsSOHTracked = false,
                    IsPurchased = false,
                    UoM = "EA",
                    UoMDescription = "Each",
                    ShortDescription = "SOAP PROD",
                    Description = "Soap Product",
                    StandardSellPriceEx = 500,
                    StandardSellPriceInc = 90,
                    LastBuyPriceEx = null,
                    RRP = 500,
                    IsVariantMaster = true,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000m,
                    CreatedWith = "Zoho",
                    Variations = new List<InventoryVariationT>{
                        new InventoryVariationT{
                            MasterInventoryID = Id,
                            Name = "Size",
                            SequenceNumber = 10,
                            IsActive = true,
                            Options = new List<InventoryVariationOptionT>
                            {
                                new InventoryVariationOptionT{
                                    VariationName = "10",
                                    Name = "10",
                                    AbbreviatedName = "10",
                                    IsActive = true,
                                    SequenceNumber = 10,
                                },
                                new InventoryVariationOptionT{
                                    VariationName = "20",
                                    Name = "20",
                                    AbbreviatedName = "20",
                                    IsActive = true,
                                    SequenceNumber = 20,
                                },
                                new InventoryVariationOptionT{
                                    VariationName = "30",
                                    Name = "30",
                                    AbbreviatedName = "30",
                                    IsActive = true,
                                    SequenceNumber = 30,
                                }

                            }
                        }
                    }
                }
            };
            return newInventory;
        }
    }
}
