using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class PromoDataService
    {
        public PromoModel GeneratePromoModel()
        {
            PromoModel model = new PromoModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Promos.ToList()
                                    orderby p.PromoId ascending
                                    select p;
                    if (tableList != null)
                    {
                        if (tableList.FirstOrDefault() != null)
                        {
                            model = new PromoModel();
                            model.PromoId = tableList.FirstOrDefault().PromoId;
                            model.PromoTitle = tableList.FirstOrDefault().PromoTitle;
                            model.PromoDescription = tableList.FirstOrDefault().PromoDescription;
                            model.ImageString = tableList.FirstOrDefault().ImageString;
                        }
                        
                    }
                    
                    return model;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdatePromo(PromoModel model)
        {
            try
            {
                Promo table = new Promo();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.Promos.Single(a => a.PromoId == model.PromoId);
                    table.PromoId = model.PromoId;
                    table.PromoTitle = model.PromoTitle;
                    table.PromoDescription = model.PromoDescription;
                    table.ImageString = model.ImageString;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}