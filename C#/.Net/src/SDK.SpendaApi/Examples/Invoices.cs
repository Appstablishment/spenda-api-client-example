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
    public class Invoices
    {
        private ApiClient baseClient { get; set; }

        public Invoices(ApiClient baseClient)
        {
            this.baseClient = baseClient;
        }

        public InvoiceT GetInvoiceById(int Id)
        {
            var invoiceClient = new InvoiceApi(baseClient);
            var result = invoiceClient.InvoiceGetByID(Id);

            return result.Value;
        }

        public SynkSaveQueueResponse CreateInvoice(TransactionSaveRequestOfInvoiceT invoice)
        {
            var invoiceClient = new InvoiceApi(baseClient);
            var result = invoiceClient.InvoicePost(invoice);

            return result;
        }

        public TransactionSaveRequestOfInvoiceT GetInvoiceObject(CustomerT customer, List<InventoryItemT> inventories)
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
                };

                lines.Add(line);
            }
                        
            var newInvoice = new TransactionSaveRequestOfInvoiceT
            {
                IsQueue = true,
                _Object = new InvoiceT
                {
                    RefNumber = "INV-" + customer.ID,
                    CustomerID = customer.ID,
                    Status = "Unfinalised",
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
