using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Web.Mvc;
using Venturada.UI.Common;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class HomeController : Controller
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


            CarouselsHelper carHelp = new CarouselsHelper();
            HomePageHelper homeHelp = new HomePageHelper();
            HomeViewModels hvm = new HomeViewModels();
            try
            {
                hvm.CarouselsViewModels = carHelp.GenerateCarousels();
                hvm.MainViewModels = homeHelp.GenerateMainViewModel();
                hvm.FeatureMainModel = homeHelp.GenerateFeatureMainModel();

                return View(hvm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carHelp = null;
                homeHelp = null;
                hvm = null;
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

            CarouselsHelper carHelp = new CarouselsHelper();
            HomePageHelper homeHelp = new HomePageHelper();
            HomeViewModels hvm = new HomeViewModels();
            try
            {
                hvm.CarouselsViewModels = carHelp.GenerateCarousels();
                hvm.MainViewModels = homeHelp.GenerateMainViewModel();
                hvm.FeatureMainModel = homeHelp.GenerateFeatureMainModel();

                return View(hvm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carHelp = null;
                homeHelp = null;
                hvm = null;
            }

        }
        
        public ActionResult Add()
        {   
            
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult DeleteImages(int carouselId)
        {
            CarouselsHelper carHelp = new CarouselsHelper();
            try
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
                carHelp.DeleteCarouselByCarouselId(carouselId);
                return RedirectToAction("Edit", "Home");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carHelp = null;
 
            }
        }

        [HttpGet]
        public ActionResult EditImage(int carouselId)
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
            CarouselsViewModels carVM = new CarouselsViewModels();
            CarouselsHelper carHelp = new CarouselsHelper();
            try
            {
                carVM = carHelp.GetCarouselByCarouselId(carouselId);
                return View(carVM);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carVM = null;
                carHelp = null;
            }
        }

        [HttpGet]
        public ActionResult EditFeature()
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
            FeatureHomeDataService fhDS = new FeatureHomeDataService();
            FeatureMainModel fmv = new FeatureMainModel();
            DataSet ds = new DataSet();
            try
            {
                string featureId = (string)Request.QueryString["featureId"];
                ds = fhDS.GetFeatureHomePageFeatureId(int.Parse(featureId));
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            fmv = new FeatureMainModel();
                            fmv.FeatureId = Convert.ToInt32(ds.Tables[0].Rows[0]["FeatureId"]);
                            fmv.FeatureImageURLString = Convert.ToString(ds.Tables[0].Rows[0]["FeatureImageURLString"]);
                            fmv.FeatureDescription = Convert.ToString(ds.Tables[0].Rows[0]["FeatureDescription"]);
                        } 
                    }
                    
                    
                }
                return View(fmv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fmv = null;
                ds = null;
                fhDS = null;
            }
        }


        [HttpPost]
        public ActionResult EditFeature(FeatureMainModel fmv)
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
            FeatureHomeDataService fhDS = new FeatureHomeDataService();
            string featureId = (string)Request.Form["edit_FeatureId"];
            string imageString = (string)Request.Form["edit_FeatureImageURLString"];
            string featureDescription = (string)Request.Form["edit_featureDescription"];
            try
            {
                
                if (ModelState.IsValid)
                {
                    WebImage photo = null;
                    var newFileName = "";
                    var imagePath = "";

                    photo = WebImage.GetImageFromRequest();
                    if (photo != null)
                    {
                        newFileName = Guid.NewGuid().ToString() + "_" +
                            Path.GetFileName(photo.FileName);
                        imagePath = @"Contents\Images\Home\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        fmv.FeatureId = int.Parse(featureId);
                        fmv.FeatureImageURLString = imagePath;



                    }
                    else
                    {
                        fmv.FeatureId = int.Parse(featureId);
                        fmv.FeatureImageURLString = imageString;
                    }

                    fhDS.UpdateFeatureHomePage(fmv);
                    return RedirectToAction("Edit", "Home");
                }
                else
                {

                    
                    fmv = new FeatureMainModel();
                    fmv.FeatureId = int.Parse(featureId);
                    fmv.FeatureDescription = featureDescription;
                    fmv.FeatureImageURLString = imageString;
                    return View(fmv);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fhDS = null;

            }
        }

        
        public ActionResult EditMain()
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
            HomePageHelper homeHelp = new HomePageHelper();
            MainViewModel mvm = new MainViewModel();
            try
            {

                mvm = homeHelp.GenerateMainViewModel();
                return View(mvm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                homeHelp = null;
                mvm = null;
            }
        }


        [HttpPost]
        public ActionResult EditMain(MainViewModel mvm)
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
            HomeViewDataService hvDS = new HomeViewDataService();
            try
            {
                if (ModelState.IsValid)
                {
                    hvDS.UpdateMainHomePage(mvm);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(mvm);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                hvDS = null;
            }
        }

        [HttpPost]
        public ActionResult EditImage()
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
            
            CarouselsHelper carHelp = new CarouselsHelper();
            try
            {
                WebImage photo = null;
                var newFileName = "";
                var imagePath = "";
                string carouselId = (string)Request.Form["edit_CarouselId"];
                string imageString = (string)Request.Form["edit_CarouselImageString"];
                string sequence = (string)Request.Form["edit_sequence"];


                photo = WebImage.GetImageFromRequest();
                if (photo != null)
                {
                    newFileName = Guid.NewGuid().ToString() + "_" +
                        Path.GetFileName(photo.FileName);
                    imagePath = @"Contents\Images\Home\" + newFileName;

                    photo.Save(@"~\" + imagePath);
                    carHelp.UpdateCarouselByCarouselId(int.Parse(carouselId), int.Parse(sequence), imagePath);

                }
                else
                {
                    carHelp.UpdateCarouselByCarouselId(int.Parse(carouselId), int.Parse(sequence), imageString);
                }

                
                return RedirectToAction("Edit", "Home");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carHelp = null;

            }
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
            CarouselsHelper carHelp = new CarouselsHelper();
            try
            {
                string homeImage = (string)Request.Form["home_image"];

                if (carHelp.GenerateCarousels().Count >= 3)
                {
                    return RedirectToAction("Edit", "Home");
                }
                WebImage photo = null;
                var newFileName = "";
                var imagePath = "";

                photo = WebImage.GetImageFromRequest();
                if (photo != null)
                {
                    newFileName = Guid.NewGuid().ToString() + "_" +
                        Path.GetFileName(photo.FileName);
                    imagePath = @"Contents\Images\Home\" + newFileName;

                    photo.Save(@"~\" + imagePath);
                    carHelp.InsertCarousels(imagePath);
                    ViewBag.Notification = homeImage;
                }
                
                return RedirectToAction("Edit", "Home");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carHelp = null;
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