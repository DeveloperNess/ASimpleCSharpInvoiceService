using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfulInvoiceService.Controllers;
using RestfulInvoiceService.Models;

namespace RestfulInvoiceService.Tests.Controllers
{
    [TestClass]
    public class InvoiceControllerTest
    {
        
        [TestMethod]
        public void GetById()
        {
            InvoiceController ic = new InvoiceController();
            Invoice i = ic.Get(1);
        }
    }
}
