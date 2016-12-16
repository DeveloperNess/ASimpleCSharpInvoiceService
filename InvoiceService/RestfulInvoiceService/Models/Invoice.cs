using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulInvoiceService.Models
{
    public class Invoice
    {
        public long Id { get; set; }

        public String InvoiceNumber { get; set; }

        public List<LineItem> LineItems { get; set; }

        public float Total { get; set; }



        public class LineItem
        {
            public int Count { get; set; }
            public float PriceEach { get; set; }
            public float LineTotal { get; set; }    
        }
    }
}