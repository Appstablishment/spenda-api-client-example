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
            var seq = 1;
            var lines = new List<BusTransLineT>();

            foreach (var inventory in inventories)
            {
                var line = new BusTransLineT()
                {
                    Code = inventory.Barcode,
                    UoM = "EA",
                    SequenceNumber = seq,
                    DeliveryMethod = "Cash_and_Carry",
                    InventoryID = inventory.ID,
                    TaxRate = 10,
                    UoMDescription = "Each",
                    PriceType = "Standard",
                    Description = inventory.Description,
                    ShortDescription = inventory.ShortDescription,
                    IsActive = true,
                    PriceDescription = "StandardSellPriceEx",
                    IsAmendedByOtherParty = false,
                    Quantity = 2
                };
                lines.Add(line);
                seq++;
            }

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
                    CreatedWith = "Zoho",
                    Status = "Open",
                    DiscountMode = "None",
                    Lines = lines,
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
    }
}
