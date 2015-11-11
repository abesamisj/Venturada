using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class PriceDataService
    {
        public List<ProductCategoryModel> GenerateProductCategoryModel()
        {
            List<ProductCategoryModel> modelList = new List<ProductCategoryModel>();
            ProductCategoryModel model = new ProductCategoryModel();
            ProductHeaderModel model2 = new ProductHeaderModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.ProductCategories.ToList()
                                       orderby p.ProductCategoryId ascending
                                       select p;

                    foreach (var item in list)
                    {
                        model = new ProductCategoryModel();
                        model.ProductCategoryId = item.ProductCategoryId;
                        model.ProductCategory = item.ProductCategory1;
                        //model.ProductHeaderModel = GetProductHeaderByProductCategoryId(item.ProductCategoryId);
                        model.PriceListModel = GetPriceListByProductCategoryId(item.ProductCategoryId);
                        modelList.Add(model);
                    }

                    return modelList;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProductCategoryModel GetProductCategoryModelByProductCategoryId(int productCategoryId)
        {
            ProductCategoryModel model = new ProductCategoryModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.ProductCategories.ToList()
                               where p.ProductCategoryId == productCategoryId
                               select p;
                    if (list != null)
                    {
                        model.ProductCategoryId = list.FirstOrDefault().ProductCategoryId;
                        model.ProductCategory = list.FirstOrDefault().ProductCategory1;
                    }
                    


                    return model;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertProductCategory(ProductCategoryModel pcm)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    ProductCategory receivedPM = new ProductCategory();
                    receivedPM.ProductCategory1 = pcm.ProductCategory;
                    
                    vdc.ProductCategories.InsertOnSubmit(receivedPM);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateProductCategory(ProductCategoryModel pcm)
        {
            try
            {
                ProductCategory table = new ProductCategory();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.ProductCategories.Single(a => a.ProductCategoryId == pcm.ProductCategoryId);
                    table.ProductCategoryId = pcm.ProductCategoryId;
                    table.ProductCategory1 = pcm.ProductCategory;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ProductHeaderModel> GetProductHeaderByProductCategoryId(int productCategoryId)
        {
            List<ProductHeaderModel> modelList = new List<ProductHeaderModel>();
            ProductHeaderModel model = new ProductHeaderModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.ProductHeaders.ToList()
                                       where p.ProductCategoryId == productCategoryId
                                       orderby p.ProductLabelId ascending
                                       select p;

                    foreach (var item in list)
                    {
                        model = new ProductHeaderModel();
                        model.ProductLabelId = item.ProductLabelId;
                        model.ProductCategoryId = item.ProductCategoryId;
                        model.ProductTableTitleDescription = item.ProductTableTitleDescription;
                        modelList.Add(model);
                    }


                    return modelList;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PriceListModel> GetPriceListByProductCategoryId(int productCategoryId)
        {
            List<PriceListModel> modelList = new List<PriceListModel>();
            PriceListModel model = new PriceListModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.PriceLists.ToList()
                               where p.ProductCategoryId == productCategoryId
                               orderby p.PriceListId ascending
                               select p;

                    foreach (var item in list)
                    {
                        model = new PriceListModel();
                        model.PriceListId = item.PriceListId;
                        model.ProductCategoryId = item.ProductCategoryId;
                        model.ProductName = item.ProductName;
                        model.ProductDescription = item.ProductDescription;
                        model.Price = item.Price;
                        modelList.Add(model);
                    }


                    return modelList;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteProductCategory(int productCategoryId)
        {
            try
            {

                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.ProductCategories
                                  where aremove.ProductCategoryId == productCategoryId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.ProductCategories.DeleteOnSubmit(remove);
                        vdc.SubmitChanges();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void InsertProductHeader(ProductHeaderModel model)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    ProductHeader table = new ProductHeader();
                    table.ProductTableTitleDescription = model.ProductTableTitleDescription;
                    table.ProductCategoryId = model.ProductCategoryId;

                    vdc.ProductHeaders.InsertOnSubmit(table);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateHeader(ProductHeaderModel model)
        {
            try
            {
                ProductHeader table = new ProductHeader();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.ProductHeaders.Single(a => a.ProductLabelId == model.ProductLabelId);
                    table.ProductTableTitleDescription = model.ProductTableTitleDescription;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteHeader(int productLabelId)
        {
            try
            {

                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.ProductHeaders
                                  where aremove.ProductLabelId == productLabelId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.ProductHeaders.DeleteOnSubmit(remove);
                        vdc.SubmitChanges();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ProductHeaderModel GetProductHeaderByHeaderId(int productLabelId)
        {
            ProductHeaderModel model = new ProductHeaderModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.ProductHeaders.ToList()
                               where p.ProductLabelId == productLabelId
                               select p;
                    if (list != null)
                    {
                        model.ProductCategoryId = list.FirstOrDefault().ProductCategoryId;
                        model.ProductLabelId = list.FirstOrDefault().ProductLabelId;
                        model.ProductTableTitleDescription = list.FirstOrDefault().ProductTableTitleDescription;
                    }

                    return model;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertPriceList(PriceListModel model)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    PriceList table = new PriceList();
                    table.ProductCategoryId = model.ProductCategoryId;
                    table.ProductName = model.ProductName;
                    table.ProductDescription = model.ProductDescription;
                    table.Price = model.Price;

                    vdc.PriceLists.InsertOnSubmit(table);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdatePriceList(PriceListModel model)
        {
            try
            {
                PriceList table = new PriceList();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.PriceLists.Single(a => a.PriceListId == model.PriceListId);
                    table.ProductDescription = model.ProductDescription;
                    table.ProductName = model.ProductName;
                    table.Price = model.Price;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeletePriceList(int priceListId)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.PriceLists
                                  where aremove.PriceListId == priceListId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.PriceLists.DeleteOnSubmit(remove);
                        vdc.SubmitChanges();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public PriceListModel GetPriceListById(int priceListId)
        {
            PriceListModel model = new PriceListModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var list = from p in vdc.PriceLists.ToList()
                               where p.PriceListId == priceListId
                               select p;
                    if (list != null)
                    {
                        model.PriceListId = list.FirstOrDefault().PriceListId;
                        model.ProductCategoryId = list.FirstOrDefault().ProductCategoryId;
                        model.ProductName = list.FirstOrDefault().ProductName;
                        model.ProductDescription = list.FirstOrDefault().ProductDescription;
                        model.Price = list.FirstOrDefault().Price;
                    }

                    return model;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CreateOrderForm()
        {
            //// Modify to siut your machine:
            //string fileName = @"C:\OrderForm.docx";

            //// Create a document in memory:
            //var doc = DocX.Create(fileName);

            //// Insert a paragrpah:
            //doc.InsertParagraph("This is my first paragraph");

            //// Save to the output directory:
            ////doc.Save();
            //doc.SaveAs(fileName);
            //// Open in Word:
            //Process.Start("WINWORD.EXE", fileName);

            
        }
    }
}