using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Swagger.Api;
using Swagger.Client;
using Swagger.Model;

namespace SDK.SpendaApi.Examples
{
    public class Inventory
    {
        private ApiClient baseClient { get; set; }

        public Inventory(ApiClient baseClient)
        {
            this.baseClient = baseClient;
        }

        public List<InventoryItemT> GetAllInventory(int? filterWarehouseID = null, int? filterInventoryID = null, int? filterInventoryClassID = null, int? filterSupplierID = null, bool? filterIsSearchSuppliersCatalog = null, Guid? filterInventoryGUID = null, bool? filterIsShowChildVariants = null, bool? filterIsIncludeCategories = false, bool? filterIsShowPostingInventoryOnly = null, bool? filterIsPurchased = null, bool? filterIsSold = null, bool? filterIsSOHTracked = null, int? filterVariantMasterInventoryID = null, string filterSearchString = null, bool? filterIsExactMatch = null, bool? filterIncludeDeleted = null, List<int?> filterBrandIDs = null, List<int?> filterIDs = null, int? filterLinkedSupplierID = null, bool? filterIsApprovedForPOS = null, bool? filterIsApprovedForWeb = null, bool? filterIsApprovedForService = null, string filterSortField = null, string filterGroupBy = null, long? filterLastRowNumber = null, int? filterMaxResults = null, int? filterTenantID = null)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventorySearchT2(filterWarehouseID, filterInventoryID, filterInventoryClassID, filterSupplierID, filterIsSearchSuppliersCatalog, filterInventoryGUID, filterIsShowChildVariants, filterIsIncludeCategories, filterIsShowPostingInventoryOnly, filterIsPurchased, filterIsSold, filterIsSOHTracked, filterVariantMasterInventoryID, filterSearchString, filterIsExactMatch, filterIncludeDeleted, filterBrandIDs, filterIDs, filterLinkedSupplierID, filterIsApprovedForPOS, filterIsApprovedForWeb, filterIsApprovedForService, filterSortField, filterGroupBy, filterLastRowNumber, filterMaxResults, filterTenantID);

            return result.Value;
        }
        public InventoryItemT InventoryGet(int id)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventoryGet(id, null, null);

            return result.Value;
        }
        public SynkSaveQueueResponse InventoryPost(InventorySaveRequest newInventory)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventoryPost(newInventory);

            return result;
        }
        public SynkSaveQueueResponse InventoryPut(InventorySaveRequest newInventory)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventoryPut(newInventory, newInventory._Object.ID);

            return result;
        }
        public ActionResultsOfInventoryVariations InventoryVariantPost(ActionRequestOfInventoryVariations newInventoryVariant, int? masterID=null)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventorySaveVariations(newInventoryVariant,1057336);
            var generateVariant = inventoryClient.InventoryAutoCreateUnlinkedVariants(1057336);
            Console.WriteLine($"generateVariant: {generateVariant}");
            return result;
        }
        public SynkSaveQueueResponse InventoryVariantPut(InventorySaveRequest newInventory)
        {
            var inventoryClient = new InventoryApi(baseClient);
            var result = inventoryClient.InventoryPut(newInventory, newInventory._Object.ID);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public InventorySaveRequest getInventoryObject(int? Id = null)
        {
            var newInventory = new InventorySaveRequest
            {
                _Object = new InventoryItemT
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
                    IsVariantMaster = false,
                    Type = "Inventory",
                    IsPublished = false,
                    IsApproved = false,
                    MinSalesQty = 1.0000000000,
                    CreatedWith = "Zoho"
                }
            };

            return newInventory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionRequestOfInventoryVariations getVariantInventoryObject(int? Id = null)
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
    }
}
