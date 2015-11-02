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
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductsPageViewMainModel ppvMM = new ProductsPageViewMainModel();

            ProductsDataService pDS = new ProductsDataService();

            try
            {
                ppvMM.ProductsMainModel = pDS.GenerateProductsMainModel();

                ppvMM.ProductsListModel = pDS.GenerateProductsListModel();

                return View(ppvMM);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ppvMM = null;
                pDS = null;
            }
        }

        public ActionResult Edit()
        {

            ProductsPageViewMainModel ppvMM = new ProductsPageViewMainModel();

            ProductsDataService pDS = new ProductsDataService();

            try
            {
                ppvMM.ProductsMainModel = pDS.GenerateProductsMainModel();

                ppvMM.ProductsListModel = pDS.GenerateProductsListModel();

                return View(ppvMM);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ppvMM = null;
                pDS = null;
            }
        }

        [HttpPost]
        public ActionResult EditProductsMainImage()
        {
            ProductsDataService auDS = new ProductsDataService();

            try
            {
                WebImage photo = null;
                var newFileName = "";
                var imagePath = "";
                string id = (string)Request.Form["edit_ProductsMainId"];

                photo = WebImage.GetImageFromRequest();
                if (photo != null)
                {
                    newFileName = Guid.NewGuid().ToString() + "_" +
                        Path.GetFileName(photo.FileName);
                    imagePath = @"Contents\Images\Products\" + newFileName;

                    photo.Save(@"~\" + imagePath);
                    auDS.UpdateProductsMainImage(int.Parse(id), imagePath);
                }


                return RedirectToAction("Edit", "Products");
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
        public ActionResult EditProductsMain(ProductsMainModel aum)
        {
            ProductsDataService auDS = new ProductsDataService();
            string id = (string)Request.Form["edit_ProductsMainId"];
            try
            {
                if (ModelState.IsValid)
                {
                    aum.ProductsMainId = int.Parse(id);
                    auDS.UpdateProductsMain(aum);
                    return RedirectToAction("Edit", "Products");
                }
                else
                {
                    aum = new ProductsMainModel();
                    aum.ProductsMainId = int.Parse(id);
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

        public ActionResult Add()
        {
            return View();            
        }

        [HttpPost]
        public ActionResult Add(ProductsListModel plm)
        {
            ProductsDataService dataService = new ProductsDataService();
            try
            {
                if (ModelState.IsValid)
                {
                    dataService.InsertProductList(plm);
                    return RedirectToAction("Edit", "Products");
                }
                else
                {
                    return View(plm);
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

        [HttpGet]
        public ActionResult DeleteProducts(int productId)
        {
            ProductsDataService dataService = new ProductsDataService();
            try
            {
                dataService.DeleteProducts(productId);
                return RedirectToAction("Edit", "Products");
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

        public ActionResult EditProduct(int productId)
        {

            ProductsListModel model = new ProductsListModel();

            ProductsDataService dataService = new ProductsDataService();

            try
            {
                model = dataService.GetProductsListModelByProductId(productId);

                return View(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                model = null;
                dataService = null;
            }
        }
        public void GetPhotoThumbnail(string imageString)
        {

            // Loading a default photo for realties that don't have a Photo
            new WebImage(HostingEnvironment.MapPath(@"~/" + imageString)).Write();
        }

        [HttpPost]
        public ActionResult EditProduct(ProductsListModel plm)
        {
            ProductsDataService dataService = new ProductsDataService();
            try
            {
                string id = (string)Request.Form["edit_ProductsId"];
                if (ModelState.IsValid)
                {
                    plm.ProductsId = int.Parse(id);
                    dataService.UpdateProductList(plm);
                    return RedirectToAction("Edit", "Products");
                }
                else
                {
                    plm = new ProductsListModel();
                    plm.ProductsId = int.Parse(id);
                    return View(plm);
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
    }
}