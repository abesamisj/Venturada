using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Web.Mvc;
using Venturada.UI.Dataservice;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class PromoController : Controller
    {
        // GET: Promo
        public ActionResult Index()
        {
            PromoDataService dataService = new PromoDataService();
            PromoViewModel viewModel = new PromoViewModel();
            try
            {
                viewModel.PromoModel = dataService.GeneratePromoModel();
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
            PromoDataService dataService = new PromoDataService();
            PromoViewModel viewModel = new PromoViewModel();
            try
            {
                viewModel.PromoModel = dataService.GeneratePromoModel();
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
        public ActionResult Edit(PromoViewModel viewModel)
        {
            PromoDataService dataService = new PromoDataService();
            string promoId = (string)Request.Form["edit_PromoId"];
            string imageString = (string)Request.Form["edit_ImageString"];
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
                        imagePath = @"Contents\Images\Promo\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        viewModel.PromoModel.PromoId = int.Parse(promoId);
                        viewModel.PromoModel.ImageString = imagePath;



                    }
                    else
                    {
                        viewModel.PromoModel.PromoId = int.Parse(promoId);
                        viewModel.PromoModel.ImageString = imageString;
                    }

                    dataService.UpdatePromo(viewModel.PromoModel);
                    return RedirectToAction("Edit", "Promo");
                }
                else
                {
                    viewModel.PromoModel.PromoId = int.Parse(promoId);
                    viewModel.PromoModel.ImageString = imageString;
                    return View(viewModel);
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

        public void GetPhotoThumbnail(string imageString)
        {
            // Loading a default photo for realties that don't have a Photo
            new WebImage(HostingEnvironment.MapPath(@"~/" + imageString)).Write();
        }
    }
}