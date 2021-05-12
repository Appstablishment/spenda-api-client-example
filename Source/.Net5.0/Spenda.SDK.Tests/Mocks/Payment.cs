using Spenda.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Spenda.SDK.Tests.Mocks
{
    public static class Payment
    {
        public static SaveRequestOfPaymentT Get(CustomerT customer, InvoiceT invoice, BusTransSearchResultT salesOrder)
        {
            if (invoice != null && salesOrder == null)
                return GetPaymentInvoice(customer, invoice);

            if (invoice == null && salesOrder != null)
                return GetPaymentSalesOrder(customer, salesOrder);

            return null;
        }

        public static SaveRequestOfPaymentT GetPaymentSalesOrder(CustomerT customer, BusTransSearchResultT salesOrder)
        {
            var RefBusTrans = new List<RefBusTranT>();

            RefBusTrans.Add(new RefBusTranT
            {
                ID = salesOrder.ID,
                RefNumber = salesOrder.RefNumber,
                TransType = "SalesOrder",
                AppliedDate = DateTime.Now,
                AppliedAmount = salesOrder.TotalInc
            });

            var newInvoice = new SaveRequestOfPaymentT
            {
                Object = new PaymentT
                {
                    RefNumber = GetRandomPaymentRefNumber(6),
                    DateTime = DateTime.Now,
                    Method = "Visa",
                    CustomerID = customer.ID,
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    IsActive = true,
                    CreatedWith = "SDK",
                    Status = "Paid",
                    Amount = salesOrder.TotalInc,
                    RefBusTrans = RefBusTrans,
                    TransactionTypeDatTypeID = 21
                }
            };

            return newInvoice;
        }

        public static SaveRequestOfPaymentT GetPaymentInvoice(CustomerT customer, InvoiceT invoice)
        {
            var RefBusTrans = new List<RefBusTranT>();

            RefBusTrans.Add(new RefBusTranT
            {
                ID = invoice.ID,
                RefNumber = invoice.RefNumber,
                TransType = "Invoice",
                AppliedDate = DateTime.Now,
                AppliedAmount = invoice.TotalInc
            });

            var newInvoice = new SaveRequestOfPaymentT
            {
                Object = new PaymentT
                {
                    RefNumber = GetRandomPaymentRefNumber(6),
                    DateTime = DateTime.Now,
                    Method = "Eftpos",
                    CustomerID = customer.ID,
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    IsActive = true,
                    CreatedWith = "SDK",
                    Status = "Paid",
                    Amount = invoice.TotalInc,
                    RefBusTrans = RefBusTrans,
                    TransactionTypeDatTypeID = 51
                }
            };

            return newInvoice;
        }

        private static string GetRandomPaymentRefNumber(int digits)
        {
            var refNumber = "PY-";
            var rnd = new Random();
            for (int i = 0; i < digits; i++)
            {
                refNumber += rnd.Next(0, digits).ToString();
            }
            return refNumber;
        }

        public static SaveRequestOfPaymentT GetPaymentObject(List<BusTransSearchResultT> invoices, CustomerT customer)
        {
            var RefBusTrans = new List<RefBusTranT>();

            foreach (var invoice in invoices)
            {
                RefBusTrans.Add(new RefBusTranT
                {
                    ID = invoice.ID,
                    RefNumber = invoice.RefNumber,
                    TransType = "Invoice",
                    AppliedDate = DateTime.Now,
                    AppliedAmount = invoice.TotalInc
                });
            }

            var newInvoice = new SaveRequestOfPaymentT
            {
                Object = new PaymentT
                {
                    RefNumber = "PY-123456",
                    DateTime = DateTime.Now,
                    Method = "Eftpos",
                    CustomerID = customer.ID,
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    IsActive = true,
                    CreatedWith = "Zoho",
                    Status = "Paid",
                    Amount = invoices.Sum(t => t.TotalInc),
                    RefBusTrans = RefBusTrans
                }
            };

            return newInvoice;
        }
    }
}
