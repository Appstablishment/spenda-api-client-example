using Spenda.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenda.SDK.Tests.Mocks
{
    public static class SalesOrders
    {
        public static TransactionSaveRequestOfSalesOrderT GetSalesOrdersObject(List<InventoryItemT> inventories, CustomerT customer)
        {
            var newSalesOrder = new TransactionSaveRequestOfSalesOrderT
            {
                _Object = new SalesOrderT
                {
                    DeliveryMethod = "Cash_and_Carry",
                    BillPostCode = "",
                    CustomerID = customer.CustomerID,
                    LineCount = 0,
                    ShipPostCode = "",
                    Discount = 0,
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    CreatedWith = "SDK",
                    Status = "Open",
                    DiscountMode = "None",
                    Lines = AddLines(inventories),
                    IsActive = true,
                    BillState = "",
                    ShipState = "",
                    IsLinkedToOtherParty = false,
                    CreatedDateTime = DateTime.Now,
                    IsMessagesSendable = false,
                    WasSentWhenLinked = false
                }
            };

            return newSalesOrder;
        }

        public static AddLinesRequest addLinesRequest(BusTransSearchResultT saleOrder, List<InventoryItemT> inventories, CustomerT customer)
        {
            var newLine = new AddLinesRequest
            {
                ID = saleOrder.ID,
                CustomerID = customer.ID,
                Lines = AddLines(inventories),
                DiscountMode = "None",
                Discount = 0
            };

            return newLine;
        }

        private static List<BusTransLineT> AddLines(List<InventoryItemT> inventories)
        {
            var seq = 1;
            var lines = new List<BusTransLineT>();

            foreach (var inventory in inventories)
            {
                var line = new BusTransLineT()
                {
                    Code = inventory.InventoryCode,
                    IsRejected = false,
                    UoM = "EA",
                    SequenceNumber = seq,
                    DeliveryMethod = "Cash_and_Carry",
                    InventoryID = inventory.ID,
                    IsCreatedByOtherParty = false,
                    TaxRate = 10,
                    UoMDescription = "Each",
                    HasPriceBeenEdited = false,
                    PriceType = "Standard",
                    Description = inventory.Description,
                    ShortDescription = inventory.ShortDescription,
                    IsActive = true,
                    StandardSellPriceEx = inventory.StandardSellPriceEx,
                    StandardSellPriceInc = inventory.StandardSellPriceInc,
                    PriceDescription = "StandardSellPriceEx",
                    IsAmendedByOtherParty = false,
                    Quantity = 2
                };
                lines.Add(line);
                seq++;
            }

            return lines;
        }
    }
}
