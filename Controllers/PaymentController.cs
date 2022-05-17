using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Payment_Sytem.Models;
using Payment_Sytem.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Sytem.Controllers
{
    public class PaymentController : Controller
    {
        private readonly Irepository _data;
        private readonly IWebHostEnvironment _webhodtd;

        public PaymentController(Irepository data, IWebHostEnvironment webhodtd)
        {
            _data = data;
            _webhodtd = webhodtd;
        }
      
        [HttpGet]
        [Route("/Payments")]
        public IActionResult Proof_OF_Payment()
        {
          

            var list = _data.ProofOfPaymment();
            return View(list);
       
        }
        
        [Route("")]
    
        public IActionResult Create()
        {
            ViewBag.Manager_Name = _data.GetMnagers();
            ViewBag.ManagerSignature = _data.GetSignature();
            return View();

        }
        [AllowAnonymous]
        
        //cOULD MAKE IT ASYNCRONOUS "ASYNC"
        public IActionResult Index(Payments Makepayments)
        {

            if (ModelState.IsValid) { }

                if (Makepayments.InvoicePdf != null) 
            {
                string folder = " Invoice";
                folder += Makepayments.InvoicePdf.FileName;
                Makepayments.InvoicePdfUrl = folder;
                string serverFolder = Path.Combine(_webhodtd.WebRootPath, folder);
                Makepayments.InvoicePdf.CopyTo(new FileStream(serverFolder, FileMode.Create));

            }

            _data.AddPayments(Makepayments);

            ModelState.Clear();
            //ViewBag.SuccessMessage = "Successfully payments";

            return RedirectToAction("Create");




        }

      
    }
}

