﻿using Spenda.SDK.Models;
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
                    MinSalesQty = 1.0000000000,
                    CreatedWith = "SDK"
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
                    MinSalesQty = 1.0000000000,
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
