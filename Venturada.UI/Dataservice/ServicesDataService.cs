using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class ServicesDataService
    {
        public List<ServicesModel> GenerateServicesModel()
        {
            List<ServicesModel> modelList = new List<ServicesModel>();
            ServicesModel model = new ServicesModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Services.ToList()
                                       orderby p.ServicesId ascending
                                       select p;

                    foreach (var item in tableList)
                    {
                        model = new ServicesModel();
                        model.ServicesId = item.ServicesId;
                        model.ServiceName = item.ServiceName;
                        model.ServiceSubTitle = item.ServiceSubTitle;
                        model.ServiceDescription = item.ServiceDescription;
                        model.ImageString = item.ImageString;
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

        public ServicesModel GetServicesModelByServiceId(int id)
        {
            
            ServicesModel model = new ServicesModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Services.ToList()
                                    where p.ServicesId == id
                                    select p;

                    model = new ServicesModel();
                    model.ServicesId = tableList.FirstOrDefault().ServicesId;
                    model.ServiceName = tableList.FirstOrDefault().ServiceName;
                    model.ServiceSubTitle = tableList.FirstOrDefault().ServiceSubTitle;
                    model.ServiceDescription = tableList.FirstOrDefault().ServiceDescription;
                    model.ImageString = tableList.FirstOrDefault().ImageString;

                    return model;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateService(ServicesModel model)
        {
            try
            {
                Service table = new Service();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.Services.Single(a => a.ServicesId == model.ServicesId);
                    table.ServicesId = model.ServicesId;
                    table.ServiceName = model.ServiceName;
                    table.ServiceSubTitle = model.ServiceSubTitle;
                    table.ServiceDescription = model.ServiceDescription;
                    table.ImageString = model.ImageString;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ServicesModel> GenerateServiceModelByServicesIds(int[] servicesIds)
        {
            try
            {

                List<ServicesModel> modelList = new List<ServicesModel>();
                ServicesModel model = new ServicesModel();
                foreach (var item in servicesIds)
                {
                    using (VenturadaDataContext vdc = new VenturadaDataContext())
                    {
                        var tableList = from p in vdc.Services.ToList()
                                        where p.ServicesId == (int)item
                                        select p;

                        model = new ServicesModel();
                        model.ServicesId = tableList.FirstOrDefault().ServicesId;
                        model.ServiceName = tableList.FirstOrDefault().ServiceName;
                        model.ServiceSubTitle = tableList.FirstOrDefault().ServiceSubTitle;
                        model.ServiceDescription = tableList.FirstOrDefault().ServiceDescription;
                        model.ImageString = tableList.FirstOrDefault().ImageString;
                    }
                    modelList.Add(model);
                }
                return modelList;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}