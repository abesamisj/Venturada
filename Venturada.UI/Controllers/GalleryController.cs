using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Web.Mvc;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            GalleryDataService dataService = new GalleryDataService();
            GalleryViewModel viewModel = new GalleryViewModel();
            try
            {
                viewModel.GalleryModelRow1 = dataService.GenerateGalleryByRow(1);
                viewModel.GalleryModelRow2 = dataService.GenerateGalleryByRow(2);
                viewModel.GalleryModelRow3 = dataService.GenerateGalleryByRow(3);
                viewModel.GalleryModelRow4 = dataService.GenerateGalleryByRow(4);
                viewModel.GalleryModelRow5 = dataService.GenerateGalleryByRow(5);
                viewModel.GalleryModelRow6 = dataService.GenerateGalleryByRow(6);
                viewModel.GalleryModelRow7 = dataService.GenerateGalleryByRow(7);
                viewModel.GalleryModelRow8 = dataService.GenerateGalleryByRow(8);
                viewModel.GalleryModelRow9 = dataService.GenerateGalleryByRow(9);
                viewModel.GalleryModelRow10 = dataService.GenerateGalleryByRow(10);
                viewModel.GalleryModelRow11 = dataService.GenerateGalleryByRow(11);
                viewModel.GalleryModelRow12 = dataService.GenerateGalleryByRow(12);
                viewModel.GalleryModelRow13 = dataService.GenerateGalleryByRow(13);
                viewModel.GalleryModelRow14 = dataService.GenerateGalleryByRow(14);
                viewModel.GalleryModelRow15 = dataService.GenerateGalleryByRow(15);
                viewModel.GalleryModelRow16 = dataService.GenerateGalleryByRow(16);
                viewModel.GalleryModelRow17 = dataService.GenerateGalleryByRow(17);
                viewModel.GalleryModelRow18 = dataService.GenerateGalleryByRow(18);
                viewModel.GalleryModelRow19 = dataService.GenerateGalleryByRow(19);
                viewModel.GalleryModelRow20 = dataService.GenerateGalleryByRow(20);
                viewModel.GalleryModelRow21 = dataService.GenerateGalleryByRow(21);
                viewModel.GalleryModelRow22 = dataService.GenerateGalleryByRow(22);
                viewModel.GalleryModelRow23 = dataService.GenerateGalleryByRow(23);
                viewModel.GalleryModelRow24 = dataService.GenerateGalleryByRow(24);
                viewModel.GalleryModelRow25 = dataService.GenerateGalleryByRow(25);
                viewModel.GalleryModelRow26 = dataService.GenerateGalleryByRow(26);
                viewModel.GalleryModelRow27 = dataService.GenerateGalleryByRow(27);
                viewModel.GalleryModelRow28 = dataService.GenerateGalleryByRow(28);
                viewModel.GalleryModelRow29 = dataService.GenerateGalleryByRow(29);
                viewModel.GalleryModelRow30 = dataService.GenerateGalleryByRow(30);

                return View(viewModel);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        // GET: Gallery
        public ActionResult Edit()
        {
            GalleryDataService dataService = new GalleryDataService();
            GalleryViewModel viewModel = new GalleryViewModel();
            try
            {
                viewModel.GalleryModelRow1 = dataService.GenerateGalleryByRow(1);
                viewModel.GalleryModelRow2 = dataService.GenerateGalleryByRow(2);
                viewModel.GalleryModelRow3 = dataService.GenerateGalleryByRow(3);
                viewModel.GalleryModelRow4 = dataService.GenerateGalleryByRow(4);
                viewModel.GalleryModelRow5 = dataService.GenerateGalleryByRow(5);
                viewModel.GalleryModelRow6 = dataService.GenerateGalleryByRow(6);
                viewModel.GalleryModelRow7 = dataService.GenerateGalleryByRow(7);
                viewModel.GalleryModelRow8 = dataService.GenerateGalleryByRow(8);
                viewModel.GalleryModelRow9 = dataService.GenerateGalleryByRow(9);
                viewModel.GalleryModelRow10 = dataService.GenerateGalleryByRow(10);
                viewModel.GalleryModelRow11 = dataService.GenerateGalleryByRow(11);
                viewModel.GalleryModelRow12 = dataService.GenerateGalleryByRow(12);
                viewModel.GalleryModelRow13 = dataService.GenerateGalleryByRow(13);
                viewModel.GalleryModelRow14 = dataService.GenerateGalleryByRow(14);
                viewModel.GalleryModelRow15 = dataService.GenerateGalleryByRow(15);
                viewModel.GalleryModelRow16 = dataService.GenerateGalleryByRow(16);
                viewModel.GalleryModelRow17 = dataService.GenerateGalleryByRow(17);
                viewModel.GalleryModelRow18 = dataService.GenerateGalleryByRow(18);
                viewModel.GalleryModelRow19 = dataService.GenerateGalleryByRow(19);
                viewModel.GalleryModelRow20 = dataService.GenerateGalleryByRow(20);
                viewModel.GalleryModelRow21 = dataService.GenerateGalleryByRow(21);
                viewModel.GalleryModelRow22 = dataService.GenerateGalleryByRow(22);
                viewModel.GalleryModelRow23 = dataService.GenerateGalleryByRow(23);
                viewModel.GalleryModelRow24 = dataService.GenerateGalleryByRow(24);
                viewModel.GalleryModelRow25 = dataService.GenerateGalleryByRow(25);
                viewModel.GalleryModelRow26 = dataService.GenerateGalleryByRow(26);
                viewModel.GalleryModelRow27 = dataService.GenerateGalleryByRow(27);
                viewModel.GalleryModelRow28 = dataService.GenerateGalleryByRow(28);
                viewModel.GalleryModelRow29 = dataService.GenerateGalleryByRow(29);
                viewModel.GalleryModelRow30 = dataService.GenerateGalleryByRow(30);

                return View(viewModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public ActionResult Add()
        {
            GalleryModel model = new GalleryModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(GalleryModel model)
        {

            GalleryDataService dataservice = new GalleryDataService();
            string galleryId = (string)Request.Form["edit_GalleryId"];
            string imageString = (string)Request.Form["edit_ImageString"];
            string galleryTitle = (string)Request.Form["edit_GalleryTitle"];
            string galleryDescription = (string)Request.Form["edit_GalleryDescription"];
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
                        imagePath = @"Contents\Images\Gallery\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        //model.ServicesId = int.Parse(serviceId);
                        model.ImageString = imagePath;



                    }
                    else
                    {
                        //model.ServicesId = int.Parse(serviceId);
                        model.ImageString = imageString;
                    }

                    dataservice.InsertGallery(model);
                    return RedirectToAction("Edit", "Gallery");
                }
                else
                {
                    //model.ServicesId = int.Parse(serviceId);
                    model.ImageString = imageString;
                    return View(model);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                model = null;
                dataservice = null;
            }
        }
        [HttpGet]
        public ActionResult DeleteGallery(int galleryId)
        {
            GalleryDataService dataService = new GalleryDataService();
            try
            {
                dataService.DeleteGallery(galleryId);
                return RedirectToAction("Edit", "Gallery");
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
        public ActionResult EditGallery(int galleryId)
        {
            GalleryModel model = new GalleryModel();
            GalleryDataService dataService = new GalleryDataService();
            try
            {
                model = dataService.GetGalleryById(galleryId);
                return View(model);
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
        public ActionResult EditGallery(GalleryModel model)
        {

            GalleryDataService dataservice = new GalleryDataService();
            string galleryId = (string)Request.Form["edit_GalleryId"];
            string imageString = (string)Request.Form["edit_ImageString"];
            string galleryTitle = (string)Request.Form["edit_GalleryTitle"];
            string galleryDescription = (string)Request.Form["edit_GalleryDescription"];
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
                        imagePath = @"Contents\Images\Gallery\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        model.GalleryId = int.Parse(galleryId);
                        model.ImageString = imagePath;



                    }
                    else
                    {
                        model.GalleryId = int.Parse(galleryId);
                        model.ImageString = imageString;
                    }

                    dataservice.UpdateGallery(model);
                    return RedirectToAction("Edit", "Gallery");
                }
                else
                {
                    model.GalleryId = int.Parse(galleryId);
                    model.ImageString = imageString;
                    return View(model);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                model = null;
                dataservice = null;
            }
        }
        public void GetPhotoThumbnail(string imageString)
        {
            // Loading a default photo for realties that don't have a Photo
            new WebImage(HostingEnvironment.MapPath(@"~/" + imageString)).Write();
        }
    }
}