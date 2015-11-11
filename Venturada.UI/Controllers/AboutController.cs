using System;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Web.Mvc;
using Venturada.UI.Dataservice;
using Venturada.UI.ViewModels;
using System.Linq;
using Venturada.UI.Models;
using System.IO;

namespace Venturada.UI.Controllers
{
    public class AboutController : Controller
    {
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
            AboutUsViewModel auVM = new AboutUsViewModel();

            AboutUsDataService auDS = new AboutUsDataService();

            try
            {
                auVM.AboutUsModel = auDS.GenerateAboutUsModel();

                auVM.PartnersModel = auDS.GeneratePartnerModel();

                return View(auVM);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                auVM = null;
                auDS = null;
            }
            
        }
        public ActionResult Add()
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
        [HttpPost]
        public ActionResult AddImages()
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
            AboutUsDataService auDS = new AboutUsDataService();
            PartnersModel pm = new PartnersModel();
            try
            {
                string homeImage = (string)Request.Form["home_image"];


                WebImage photo = null;
                var newFileName = "";
                var imagePath = "";

                photo = WebImage.GetImageFromRequest();
                if (photo != null)
                {
                    newFileName = Guid.NewGuid().ToString() + "_" +
                        Path.GetFileName(photo.FileName);
                    imagePath = @"Contents\Images\About\" + newFileName;

                    photo.Save(@"~\" + imagePath);
                    auDS.InsertPartner(imagePath);
                }

                return RedirectToAction("Edit", "About");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                auDS = null;
            }
        }

        [HttpGet]
        public ActionResult DeleteImages(int partnerId)
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
            AboutUsDataService auDS = new AboutUsDataService();
            try
            {
                auDS.DeleteImage(partnerId);
                return RedirectToAction("Edit", "About");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                auDS = null;

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
            AboutUsViewModel auVM = new AboutUsViewModel();

            AboutUsDataService auDS = new AboutUsDataService();

            try
            {
                auVM.AboutUsModel = auDS.GenerateAboutUsModel();

                auVM.PartnersModel = auDS.GeneratePartnerModel();

                return View(auVM);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                auVM = null;
                auDS = null;
            }

        }
        [HttpPost]
        public ActionResult EditAboutUsImage()
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
            AboutUsDataService auDS = new AboutUsDataService();

            try
            {
                WebImage photo = null;
                var newFileName = "";
                var imagePath = "";
                string aboutUsId = (string)Request.Form["edit_AboutUsId"];
                string imageString = (string)Request.Form["edit_ImageUrl"];

                photo = WebImage.GetImageFromRequest();
                if (photo != null)
                {
                    newFileName = Guid.NewGuid().ToString() + "_" +
                        Path.GetFileName(photo.FileName);
                    imagePath = @"Contents\Images\About\" + newFileName;

                    photo.Save(@"~\" + imagePath);
                    auDS.UpdateAboutUsImage(int.Parse(aboutUsId), imagePath);
                }


                return RedirectToAction("Edit", "About");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                auDS = null;
            }
        }
        [HttpPost]
        public ActionResult EditAboutUs(AboutUsModel aum)
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
            AboutUsDataService auDS = new AboutUsDataService();
            string aboutUsId = (string)Request.Form["edit_AboutUsId"];
            string aboutUsTitle = (string)Request.Form["edit_AboutUsTitle"];
            try
            {
                if (ModelState.IsValid)
                {
                    aum.AboutUsId = int.Parse(aboutUsId);
                    auDS.UpdateAboutUs(aum);
                    return RedirectToAction("Edit", "About");
                }
                else
                {
                    aum = new AboutUsModel();
                    aum.AboutUsId = int.Parse(aboutUsId);
                    aum.AboutUsTitle = aboutUsTitle;
                    return View(aum);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                auDS = null;
            }
        }
        public void GetPhotoThumbnail(string imageString)
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
            // Loading a default photo for realties that don't have a Photo
            new WebImage(HostingEnvironment.MapPath(@"~/" + imageString)).Write();
        }
	}
}