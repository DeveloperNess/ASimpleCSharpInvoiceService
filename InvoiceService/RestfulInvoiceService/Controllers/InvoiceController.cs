using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulInvoiceService.Models;

namespace RestfulInvoiceService.Controllers
{
    public class InvoiceController : ApiController
    {

        public Invoice Get(int id)
        {
            Invoice invoice = new Invoice();
            invoice.Id = 1;
            invoice.InvoiceNumber = "INV-0001";
            invoice.LineItems = new List<Invoice.LineItem>();
            invoice.LineItems.Add(new Invoice.LineItem()
            {
                Count = 1,
                PriceEach = 10.99f,
                LineTotal = 10.99f,
            });
            invoice.Total = 10.99f;


            return invoice;
        }

    }
}
