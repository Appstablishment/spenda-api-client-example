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
    public class Payment
    {
        private ApiClient baseClient { get; set; }

        public Payment(ApiClient baseClient)
        {
            this.baseClient = baseClient;
        }

        public PaymentT GetPaymentById(int Id)
        {
            var paymentClient = new PaymentApi(baseClient);
            var result = paymentClient.PaymentGetByID(Id, null, null, null, null, null, null);

            return result.Value;
        }

        public SynkSaveQueueResponseOfPaymentT CreatePayment(SaveRequestOfPaymentT payment)
        {
            var paymentClient = new PaymentApi(baseClient);
            var result = paymentClient.PaymentPost(payment);

            return result;
        }

        public SaveRequestOfPaymentT GetPaymentObject(InvoiceT invoice, CustomerT customer)
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
                    RefNumber = "PY-" + customer.ID,
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
