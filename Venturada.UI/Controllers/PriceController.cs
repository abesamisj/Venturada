using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class PriceController : Controller
    {
        // GET: Price
        public ActionResult Index()
        {
            List<ProductCategoryModel> viewModel = new List<ProductCategoryModel>();

            PriceDataService dataService = new PriceDataService();

            try
            {
                viewModel = dataService.GenerateProductCategoryModel();

                return View(viewModel);
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

        public ActionResult Edit()
        {

            ProductCategoryViewModel viewModel = new ProductCategoryViewModel();

            PriceDataService dataService = new PriceDataService();

            try
            {
                viewModel.ProductCategoryModel = dataService.GenerateProductCategoryModel();



                return View(viewModel);
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
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductCategoryModel pcm)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.InsertProductCategory(pcm);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult EditCategory(int productCategoryId)
        {
            PriceDataService dataService = new PriceDataService();
            ProductCategoryModel model = new ProductCategoryModel();
            try
            {
                model = dataService.GetProductCategoryModelByProductCategoryId(productCategoryId);


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
        public ActionResult EditCategory(ProductCategoryModel pcm)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.UpdateProductCategory(pcm);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult DeleteCategory(int productCategoryId)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.DeleteProductCategory(productCategoryId);
                return RedirectToAction("Edit", "Price");
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

        public ActionResult AddHeader(int productCategoryId)
        {
            ViewBag.ProducCategoryId = productCategoryId;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeader(string tableHeader, int productCategoryId)
        {
            PriceDataService dataService = new PriceDataService();
            ProductHeaderModel model = new ProductHeaderModel();
            try
            {
                model.ProductCategoryId = productCategoryId;
                model.ProductTableTitleDescription = tableHeader;
                dataService.InsertProductHeader(model);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult DeleteHeader(int headerId)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.DeleteHeader(headerId);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult EditHeader(int headerId)
        {
            PriceDataService dataService = new PriceDataService();
            ProductHeaderModel model = new ProductHeaderModel();
            try
            {
                model = dataService.GetProductHeaderByHeaderId(headerId);
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
        public ActionResult EditHeader(int productLabelId, string productTableTitleDescription)
        {
            PriceDataService dataService = new PriceDataService();
            ProductHeaderModel model = new ProductHeaderModel();
            try
            {
                model.ProductLabelId = productLabelId;
                model.ProductTableTitleDescription = productTableTitleDescription;
                dataService.UpdateHeader(model);
                return RedirectToAction("Edit", "Price");
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

        public ActionResult AddPrice(int productCategoryId)
        {
            ViewBag.ProducCategoryId = productCategoryId;
            return View();
        }

        [HttpPost]
        public ActionResult AddPrice(PriceListModel pcm)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.InsertPriceList(pcm);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult DeletePrice(int priceListId)
        {
            PriceDataService dataService = new PriceDataService();
            try
            {
                dataService.DeletePriceList(priceListId);
                return RedirectToAction("Edit", "Price");
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
        public ActionResult EditPrice(int priceListId)
        {
            PriceDataService dataService = new PriceDataService();
            PriceListModel model = new PriceListModel();
            try
            {
                model = dataService.GetPriceListById(priceListId);
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
        public ActionResult EditPrice(PriceListModel plm)
        {
            PriceDataService dataService = new PriceDataService();
            PriceListModel model = new PriceListModel();
            try
            {
                if (ModelState.IsValid)
                {
                    model.PriceListId = plm.PriceListId;
                    model.ProductName = plm.ProductName;
                    model.ProductDescription = plm.ProductDescription;
                    model.Price = plm.Price;
                    dataService.UpdatePriceList(model);
                    return RedirectToAction("Edit", "Price");
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
    }
}