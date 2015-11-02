using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class AboutUsDataService
    {
        public AboutUsModel GenerateAboutUsModel()
        {
            AboutUsModel aum = new AboutUsModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var aboutus = from about in vdc.AboutUs.ToList()
                                  orderby about.AboutUsId ascending
                                  select about;
                    aum = new AboutUsModel();
                    aum.AboutUsId = aboutus.FirstOrDefault().AboutUsId;
                    aum.AboutUsParagraph = aboutus.FirstOrDefault().AboutUsParagraph;
                    aum.AboutUsTitle = aboutus.FirstOrDefault().AboutUsTitle;
                    aum.ImageUrl = aboutus.FirstOrDefault().ImageUrl;
                    return aum;
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<PartnersModel> GeneratePartnerModel()
        {
            try
            {
                List<PartnersModel> pmList = new List<PartnersModel>();
                PartnersModel pm = new PartnersModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var partner = from p in vdc.Partners.ToList()
                                  orderby p.PartnerId ascending
                                  select p;

                    foreach (var item in partner)
                    {
                        pm = new PartnersModel();
                        pm.PartnerId = item.PartnerId;
                        pm.ImageUrl = item.ImageUrl;
                        pm.Description = item.Description;
                        pm.Sequence = item.Sequence;
                        pmList.Add(pm);
                    }
                    return pmList;
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public void UpdateAboutUs(AboutUsModel aum)
        {
            try
            {
                AboutUs au = new AboutUs();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    au = vdc.AboutUs.Single(a => a.AboutUsId == aum.AboutUsId);
                    au.AboutUsId = aum.AboutUsId;
                    au.AboutUsParagraph = aum.AboutUsParagraph;
                    au.AboutUsTitle = aum.AboutUsTitle;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
        public void UpdateAboutUsImage(int aboutUsId, string imageUrl)
        {
            try
            {
                AboutUs au = new AboutUs();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    au = vdc.AboutUs.Single(a => a.AboutUsId == aboutUsId);
                    au.ImageUrl = imageUrl;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void InsertPartner(string imageURL)
        {
            try
            {
                int sequence = 0;
                
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var partner = from p in vdc.Partners.ToList()
                                  orderby p.Sequence descending
                                  select p;
                    if (partner.Count() > 0)
                    {
                        sequence = partner.First().Sequence + 1;
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    Partner receivedPM = new Partner();
                    receivedPM.ImageUrl = imageURL;
                    receivedPM.Sequence = sequence;

                    vdc.Partners.InsertOnSubmit(receivedPM);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteImage(int partnerId)
        {
            try
            {
               

                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.Partners
                                  where aremove.PartnerId == partnerId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.Partners.DeleteOnSubmit(remove);
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