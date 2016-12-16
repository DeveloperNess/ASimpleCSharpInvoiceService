using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulInvoiceService.Models;

namespace RestfulInvoiceService.Adapters
{
    public interface IInvoiceStore
    {
        Invoice CreateNewInvoice(Invoice newInvoice);
        Invoice FindInvoiceById(long id);
        Invoice FindInvoiceByInvoiceNumber(String invoiceNumber);
        void UpdateInvoice(Invoice invoice);
    }
}
