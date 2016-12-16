using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulInvoiceService.Adapters;
using RestfulInvoiceService.Models;

namespace RestfulInvoiceService.Controllers
{
    public class InvoiceController : ApiController
    {
        public InvoiceController(IInvoiceStore invoiceStore)
        {
            InvoiceStore = invoiceStore;
        }

        public IInvoiceStore InvoiceStore { get; set; }

        public Invoice Get(int id)
        {
            return InvoiceStore.FindInvoiceById(id);            
        }

    }
}
