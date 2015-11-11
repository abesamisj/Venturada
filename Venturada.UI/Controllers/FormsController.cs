using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;

namespace Venturada.UI.Controllers
{
    public class FormsController : Controller
    {
        // GET: Forms
        public ActionResult Index()
        {
            PriceDataService dataService = new PriceDataService();
            //dataService.CreateOrderForm();
            List<ProductCategoryModel> modelList = new List<ProductCategoryModel>();

            modelList = dataService.GenerateProductCategoryModel();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=OrderForm.doc");
            Response.ContentType = "application/vnd.ms-word ";
            Response.Charset = string.Empty;

            StringWriter sw = new StringWriter();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<h1>ORDER FORM</h1>");
            sb.AppendLine("<h2>        FREE DELIVERY 20KG MINIMUM</h2>");
            sb.AppendLine("<h2>NAME :</h2>");
            sb.AppendLine("<h2>COMPANY:</h2>");
            sb.AppendLine("<h2>ADDRESS:</h2>");
            sb.AppendLine("<h2>CONTACT NO.</h2>");
            sb.AppendLine("<style>table, th, td {border: 1px solid black;}</style><div class=row>");
            foreach (var item in modelList)
            {
                
                




                sb.AppendLine("<div class=col-lg-12>");
                sb.AppendLine("<h2>" + item.ProductCategory + "</h2>");
                sb.AppendLine("</div>");
                sb.AppendLine("<table  width=100%>");
                sb.AppendLine("<thead>");
                sb.AppendLine("<tr><th>Product Name</th><th>Product Description</th><th>Price</th><th>Quantity</th></tr></thead><tbody>");
                        
                           if (item.PriceListModel.Count > 0)
                            {
                                foreach (var item3 in item.PriceListModel)
                                {
                                    sb.AppendLine("<tr>");
                                        sb.AppendLine("<td>" + item3.ProductName + "</td>");
                                        sb.AppendLine("<td>" + item3.ProductDescription + "</td>");
                                        sb.AppendLine("<td>" + item3.Price + "</td>");
                                        sb.AppendLine("<td></td>");
                                    sb.AppendLine("</tr>");
                                }
                            }
                                    
                    sb.AppendLine("</tbody>");
                sb.AppendLine("</table>");
            }

            sb.AppendLine("</div>");
            sb.AppendLine("<h2>TOTAL ORDER AMOUNT  =</h2>");
            
            //HtmlTextWriter htw = new HtmlTextWriter(sw);
            //gv.RenderControl(htw);
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();

            return RedirectToAction("Index", "Products");
            //return new FilePathResult("~/DownloadableForms/OrderForm.docx", System.Net.Mime.MediaTypeNames.Application.Octet); 
            //return File("/DownloadableForms/OrderForm.doc", System.Net.Mime.MediaTypeNames.Application.Octet);
        }

    }
}