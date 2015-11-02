using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Controllers
{
    public class FormsController : Controller
    {
        // GET: Forms
        public FilePathResult Index()
        {
            return new FilePathResult("~/DownloadableForms/OrderForm.docx", System.Net.Mime.MediaTypeNames.Application.Octet); 
            //return File("/DownloadableForms/OrderForm.doc", System.Net.Mime.MediaTypeNames.Application.Octet);
        }

    }
}