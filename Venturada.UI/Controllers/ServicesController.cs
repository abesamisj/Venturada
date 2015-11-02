using System.Web.Mvc;
using System;
using Venturada.UI.ViewModels;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;
using System.Web.Helpers;
using System.IO;
using System.Web.Hosting;

namespace Venturada.UI.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            ServicesViewModel viewModel = new ServicesViewModel();
            ServicesDataService dataservice = new ServicesDataService();
            try
            {
                int[] row1 = new int[] { 1,2,3};
                int[] row2 = new int[] { 6, 4, 5 };
                viewModel.ServicesModelRow1 = dataservice.GenerateServiceModelByServicesIds(row1);
                viewModel.ServicesModelRow2 = dataservice.GenerateServiceModelByServicesIds(row2);

                return View(viewModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                viewModel = null;
                dataservice = null;
            }
        }

        public ActionResult Edit()
        {
            ServicesViewModel viewModel = new ServicesViewModel();
            ServicesDataService dataservice = new ServicesDataService();
            try
            {
                int[] row1 = new int[] { 1, 2, 3 };
                int[] row2 = new int[] { 6, 4, 5 };
                viewModel.ServicesModelRow1 = dataservice.GenerateServiceModelByServicesIds(row1);
                viewModel.ServicesModelRow2 = dataservice.GenerateServiceModelByServicesIds(row2);

                return View(viewModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                viewModel = null;
                dataservice = null;
            }
        }

        //[HttpGet]
        //public ActionResult EditServices(ServicesModel model)
        //{
        //    ServicesDataService dataservice = new ServicesDataService();
        //    try
        //    {
        //        model = dataservice.GetServicesModelByServiceId(model);

        //        return View(model);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        model = null;
        //        dataservice = null;
        //    }
        //}

        [HttpGet]
        public ActionResult EditService(int id)
        {
            ServicesModel model = new ServicesModel();
            ServicesDataService dataservice = new ServicesDataService();
            try
            {
                model = dataservice.GetServicesModelByServiceId(id);

                return View(model);
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

        [HttpPost]
        public ActionResult EditService(ServicesModel model)
        {
            
            ServicesDataService dataservice = new ServicesDataService();
            string serviceId = (string)Request.Form["edit_ServicesId"];
            string imageString = (string)Request.Form["edit_ImageString"];
            string serviceName = (string)Request.Form["edit_ServiceName"];
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
                        imagePath = @"Contents\Images\Services\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        model.ServicesId = int.Parse(serviceId);
                        model.ImageString = imagePath;



                    }
                    else
                    {
                        model.ServicesId = int.Parse(serviceId);
                        model.ImageString = imageString;
                    }

                    dataservice.UpdateService(model);
                    return RedirectToAction("Edit", "Services");
                }
                else
                {
                    model.ServicesId = int.Parse(serviceId);
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