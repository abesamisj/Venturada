using SendGrid;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {
            try
            {
                string body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p> <br/><p>{3}</p><p>{4}</p>";

                string name = (string)Request.Form["contact_name"];
                string email = (string)Request.Form["contact_email"];
                string company = (string)Request.Form["contact_company"];
                string phone = (string)Request.Form["contact_phone"];
                string subject = (string)Request.Form["contact_subject"];
                string message = (string)Request.Form["contact_message"];
                // Create the email object first, then add the properties.
                SendGridMessage myMessage = new SendGridMessage();
                myMessage.AddTo("customerservice@venturadahogs.com");
                myMessage.From = new MailAddress(email, name);
                myMessage.Subject = subject;
                myMessage.Html = string.Format(body, name, email, message, company, phone);

                // Create credentials, specifying your user name and password.
                var credentials = new NetworkCredential("azure_7f39ae2dd3485e2ebd5811bd0838c5c7@azure.com", "Passw0rd123##");

                // Create an Web transport for sending email.
                var transportWeb = new Web(credentials);

                // Send the email, which returns an awaitable task.
                transportWeb.DeliverAsync(myMessage);

                return RedirectToAction("Sent");
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
           
            
            
        }

        public ActionResult Sent()
        {
            return View();
        }
	}
}