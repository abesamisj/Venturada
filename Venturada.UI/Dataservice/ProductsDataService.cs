using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class ProductsDataService
    {
        public ProductsMainModel GenerateProductsMainModel()
        {
            ProductsMainModel pmm = new ProductsMainModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var productsMain = from p in vdc.ProductsMains.ToList()
                                  orderby p.ProductsMainId ascending
                                  select p;
                    if (productsMain.FirstOrDefault() != null)
                    {
                        pmm = new ProductsMainModel();
                        pmm.ProductsMainId = productsMain.FirstOrDefault().ProductsMainId;
                        pmm.ImageURLString = productsMain.FirstOrDefault().ImageURLString;
                        pmm.ProductMainParagraph = productsMain.FirstOrDefault().ProductMainParagraph;
                        pmm.ProductSubParagraph = productsMain.FirstOrDefault().ProductSubParagraph;
                        pmm.ProductMainParagraphTitle = productsMain.FirstOrDefault().ProductMainParagraphTitle;
                        pmm.ProductSubParagraphTitle = productsMain.FirstOrDefault().ProductSubParagraphTitle;
                    }
                    
                    return pmm;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ProductsListModel> GenerateProductsListModel()
        {
            List<ProductsListModel> plmList = new List<ProductsListModel>();
            ProductsListModel plm = new ProductsListModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var productsList = from p in vdc.ProductsLists.ToList()
                                       orderby p.ProductId ascending
                                       select p;

                    foreach (var item in productsList)
                    {
                        plm = new ProductsListModel();
                        plm.ProductsId = item.ProductId;
                        plm.MainDescription = item.MainDescription;
                        plm.DetailsDescription = item.DetailsDescription;
                        plmList.Add(plm);
                    }

                    return plmList;
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProductsListModel GetProductsListModelByProductId(int productId)
        {
            
            ProductsListModel model = new ProductsListModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var productsList = from p in vdc.ProductsLists.ToList()
                                       where p.ProductId == productId
                                       select p;

                    model = new ProductsListModel();
                    model.ProductsId = productsList.FirstOrDefault().ProductId;
                    model.MainDescription = productsList.FirstOrDefault().MainDescription;
                    model.DetailsDescription = productsList.FirstOrDefault().DetailsDescription;

                    return model;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateProductsMainImage(int id, string imageUrl)
        {
            try
            {
                ProductsMain au = new ProductsMain();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    au = vdc.ProductsMains.Single(a => a.ProductsMainId == id);
                    au.ImageURLString = imageUrl;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateProductsMain(ProductsMainModel aum)
        {
            try
            {
                ProductsMain au = new ProductsMain();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    au = vdc.ProductsMains.Single(a => a.ProductsMainId == aum.ProductsMainId);
                    au.ProductsMainId = aum.ProductsMainId;
                    au.ProductMainParagraph = aum.ProductMainParagraph;
                    au.ProductSubParagraph = aum.ProductSubParagraph;
                    au.ProductMainParagraphTitle = aum.ProductMainParagraphTitle;
                    au.ProductSubParagraphTitle = aum.ProductSubParagraphTitle;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void UpdateProductList(ProductsListModel aum)
        {
            try
            {
                ProductsList au = new ProductsList();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    au = vdc.ProductsLists.Single(a => a.ProductId == aum.ProductsId);
                    au.ProductId = aum.ProductsId;
                    au.MainDescription = aum.MainDescription;
                    au.DetailsDescription = aum.DetailsDescription;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void InsertProductList(ProductsListModel plm)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    ProductsList receivedPM = new ProductsList();
                    receivedPM.MainDescription = plm.MainDescription;
                    receivedPM.DetailsDescription = plm.DetailsDescription;

                    vdc.ProductsLists.InsertOnSubmit(receivedPM);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteProducts(int productId)
        {
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.ProductsLists
                                  where aremove.ProductId == productId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.ProductsLists.DeleteOnSubmit(remove);
                        vdc.SubmitChanges();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}