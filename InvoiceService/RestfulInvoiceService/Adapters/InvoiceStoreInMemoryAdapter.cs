using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestfulInvoiceService.Models;

namespace RestfulInvoiceService.Adapters
{
    public class InvoiceStoreInMemoryAdapter : IInvoiceStore
    {
        public Invoice CreateNewInvoice(Invoice newInvoice)
        {
            Invoices.Add(newInvoice);
            return newInvoice;
        }

        public Invoice FindInvoiceById(long id)
        {
            for (int i = 0; i < Invoices.Count; i++)
            {
                if (Invoices[i].Id == id)
                    return Invoices[i];
            }

            return null;
        }

        public Invoice FindInvoiceByInvoiceNumber(String invoiceNumber)
        {
            for (int i = 0; i < Invoices.Count; i++)
            {
                if (Invoices[i].InvoiceNumber == invoiceNumber)
                    return Invoices[i];
            }

            return null;
        }


        public void UpdateInvoice(Invoice invoice)
        {
            // It's all in memory, so it's fine
            return;
        }


        private List<Invoice> Invoices = new List<Invoice>();
    }
}