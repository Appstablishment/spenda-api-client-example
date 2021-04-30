﻿using Spenda.SDK.Models;
using System;
using System.Collections.Generic;

namespace Spenda.SDK.Tests.Mocks
{
    public static class Payment
    {
        public static SaveRequestOfPaymentT GetPaymentObject(InvoiceT invoice, CustomerT customer)
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
                _Object = new PaymentT
                {
                    RefNumber = "PY-123456",
                    DateTime = DateTime.Now,
                    Method = "Eftpos",
                    CustomerID = customer.ID,
                    CustomerName = customer.Name?.Trim() + customer.Name2?.Trim(),
                    IsActive = true,
                    CreatedWith = "Zoho",
                    Status = "Paid",
                    Amount = invoice.TotalInc,
                    RefBusTrans = RefBusTrans
                }
            };

            return newInvoice;
        }
    }
}
