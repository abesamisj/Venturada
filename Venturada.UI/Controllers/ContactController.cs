using SendGrid;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using Venturada.UI.ViewModels;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;

namespace Venturada.UI.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index(string ReturnUrl)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
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
                viewModel.EmailAddressModel = dataService.GenerateEmailAddressModelById(1);
                viewModel.ShoppingHoursModel = dataService.GenerateShoppingHoursModelById(1);
                viewModel.ContactAdditionalModel = dataService.GenerateContactAdditionalModelById(1);
                viewModel.SocialMediaModelFacebook = dataService.GenerateSocialMediaModelById(1);
                viewModel.SocialMediaModelTwitter = dataService.GenerateSocialMediaModelById(2);
                viewModel.SocialMediaModelYoutube = dataService.GenerateSocialMediaModelById(3);
                viewModel.SocialMediaModelInstagram = dataService.GenerateSocialMediaModelById(4);
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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
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
                viewModel.EmailAddressModel = dataService.GenerateEmailAddressModelById(1);
                viewModel.ShoppingHoursModel = dataService.GenerateShoppingHoursModelById(1);
                viewModel.ContactAdditionalModel = dataService.GenerateContactAdditionalModelById(1);

                viewModel.SocialMediaModelFacebook = dataService.GenerateSocialMediaModelById(1);
                viewModel.SocialMediaModelTwitter = dataService.GenerateSocialMediaModelById(2);
                viewModel.SocialMediaModelYoutube = dataService.GenerateSocialMediaModelById(3);
                viewModel.SocialMediaModelInstagram = dataService.GenerateSocialMediaModelById(4);
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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
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
        public ActionResult EditEmailAddress()
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
            try
            {
                string emailAddress = (string)Request.Form["emailAddress"];
                string emailAddressId = (string)Request.Form["emailAddressId"];
                dataService.UpdateEmailAddress(int.Parse(emailAddressId), emailAddress);

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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
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
        public ActionResult EditShoppingHours()
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
            try
            {
                string description = (string)Request.Form["description"];
                string id = (string)Request.Form["id"];
                dataService.UpdateShoppingHours(int.Parse(id), description);

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

        [HttpGet]
        public ActionResult EditContactAdditional(int contactAdditionalId)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
            try
            {
                ContactAdditionalModel model = new ContactAdditionalModel();
                model = dataService.GenerateContactAdditionalModelById(1);
                return View(model);

                //string id = (string)Request.Form["id"];
                
                //if (ModelState.IsValid)
                //{
                //    dataService.UpdateContactAdditional(int.Parse(id), "", model.ContactAdditionalModel.ContactDescription);

                //    return RedirectToAction("Edit", "Contact");
                //}
                //else
                //{

                //    model = new ContactViewModel();
                //    model.ContactAdditionalModel = new Models.ContactAdditionalModel();
                //    model.ContactAdditionalModel.ContactAdditionalId = int.Parse(id);
                //    model.ContactAdditionalModel.ContactDescription = model.ContactAdditionalModel.ContactDescription;
                //    return View(model.ContactAdditionalModel);
                //}
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

        [HttpGet]
        public ActionResult EditSocial(int socialMediaId)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            try
            {
                ContactDataService dataService = new ContactDataService();
                SocialMediaModel model = new SocialMediaModel();

                model = dataService.GenerateSocialMediaModelById(socialMediaId);
                return View(model);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult EditSocial(SocialMediaModel model)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
            try
            {
                string id = (string)Request.Form["id"];

                if (ModelState.IsValid)
                {
                    dataService.UpdateSocialMedia(int.Parse(id), model.SocialMediaUrl);

                    return RedirectToAction("Edit", "Contact");
                }
                else
                {

                    model = new SocialMediaModel();
                    model.SocialMediaId = int.Parse(id);
                    model.SocialMediaUrl = model.SocialMediaUrl;
                    return View(model);
                }
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
        public ActionResult EditContactAdditional(ContactAdditionalModel model)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
            try
            {
                string id = (string)Request.Form["id"];

                if (ModelState.IsValid)
                {
                    dataService.UpdateContactAdditional(int.Parse(id), "", model.ContactDescription);

                    return RedirectToAction("Edit", "Contact");
                }
                else
                {

                    model = new ContactAdditionalModel();
                    model.ContactAdditionalId = int.Parse(id);
                    model.ContactDescription = model.ContactDescription;
                    return View(model);
                }
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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ContactDataService dataService = new ContactDataService();
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
                myMessage.AddTo(dataService.GenerateEmailAddressModelById(1).EmailAddress);
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
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            return View();
        }
	}
}