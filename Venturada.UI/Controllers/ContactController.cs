using SendGrid;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using Venturada.UI.ViewModels;
using Venturada.UI.Dataservice;

namespace Venturada.UI.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index(string ReturnUrl)
        {
            ContactDataService dataService = new ContactDataService();
            ContactViewModel viewModel = new ContactViewModel();
            try
            {
                viewModel.ContactModel = dataService.GenerateContactModel();
                viewModel.AddressModel = dataService.GenerateAddressModel();
                viewModel.ContactNumbersModel1 = dataService.GenerateContactNumbersModelById(1);
                viewModel.ContactNumbersModel2 = dataService.GenerateContactNumbersModelById(2);
                viewModel.ContactNumbersModel3 = dataService.GenerateContactNumbersModelById(3);
                viewModel.ContactNumbersModel4 = dataService.GenerateContactNumbersModelById(4);
                viewModel.ContactNumbersModel5 = dataService.GenerateContactNumbersModelById(5);
                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataService = null;
                viewModel = null;
            }
        }

        public ActionResult Edit()
        {
            ContactDataService dataService = new ContactDataService();
            ContactViewModel viewModel = new ContactViewModel();
            try
            {
                viewModel.ContactModel = dataService.GenerateContactModel();
                viewModel.AddressModel = dataService.GenerateAddressModel();
                viewModel.ContactNumbersModel1 = dataService.GenerateContactNumbersModelById(1);
                viewModel.ContactNumbersModel2 = dataService.GenerateContactNumbersModelById(2);
                viewModel.ContactNumbersModel3 = dataService.GenerateContactNumbersModelById(3);
                viewModel.ContactNumbersModel4 = dataService.GenerateContactNumbersModelById(4);
                viewModel.ContactNumbersModel5 = dataService.GenerateContactNumbersModelById(5);
                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataService = null;
                viewModel = null;
            }
            
        }

        [HttpPost]
        public ActionResult EditContactNumber()
        {
            ContactDataService dataService = new ContactDataService();
            try
            {
                string contactNumber = (string)Request.Form["contactNumber"];
                string contactNumberId = (string)Request.Form["contactNumberId"];
                dataService.UpdateContactNumbers(int.Parse(contactNumberId), contactNumber);

                return RedirectToAction("Edit", "Contact");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataService = null;

            }
        }

        [HttpPost]
        public ActionResult EditCompanyName()
        {
            ContactDataService dataService = new ContactDataService();
            try
            {
                string companyName = (string)Request.Form["contact_company"];
                string companyId = (string)Request.Form["contact_id"];
                dataService.UpdateCompanyName(int.Parse(companyId), companyName);

                return RedirectToAction("Edit", "Contact");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataService = null;
 
            }
        }

        [HttpPost]
        public ActionResult EditCompanyAddress()
        {
            ContactDataService dataService = new ContactDataService();
            try
            {
                string addressId = (string)Request.Form["addressId"];
                string addressLine1 = (string)Request.Form["addressLine1"];
                string addressLine2 = (string)Request.Form["addressLine2"];
                string country = (string)Request.Form["country"];
                string postCode = (string)Request.Form["postCode"];

                return RedirectToAction("Edit", "Contact");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataService = null;

            }
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