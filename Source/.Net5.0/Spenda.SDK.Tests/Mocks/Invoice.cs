using Spenda.SDK.Models;
using System;
using System.Collections.Generic;

namespace Spenda.SDK.Tests.Mocks
{
    public static class Invoice
    {
        public static TransactionSaveRequestOfInvoiceT GetInvoiceObject(CustomerT customer, List<InventoryItemT> inventories)
        {
            if (inventories == null) return null;

            var lines = new List<BusTransLineT>();

            foreach (var inventory in inventories)
            {
                var line = new BusTransLineT()
                {
                    InventoryID = inventory.ID,
                    Code = inventory.InventoryCode,
                    UoM = "EA",
                    DeliveryMethod = "Cash_and_Carry",
                    WarehouseID = inventory.MinMaxLevels[0].WarehouseID,
                    UoMDescription = "Each",
                    HasPriceBeenEdited = false,
                    Quantity = 2,
                };

                lines.Add(line);
            }

            var newInvoice = new TransactionSaveRequestOfInvoiceT
            {
                IsQueue = true,
                _Object = new InvoiceT
                {
                    CustomerID = customer.ID,
                    Status = "Finalised",
                    DeliveryMethod = "Cash_and_Carry",
                    CreatedWith = "Zoho",
                    BillingAddress = customer.Locations[0].Addresses[0],
                    ShippingAddress = customer.Locations[0].Addresses[0],
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    TransDate = DateTime.Now,
                    Lines = lines
                }
            };

            return newInvoice;
        }
    }
}
