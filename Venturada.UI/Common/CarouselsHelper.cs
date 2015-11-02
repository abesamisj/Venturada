using System;
using System.Collections.Generic;
using System.Data;
using Venturada.UI.Dataservice;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Common
{
    public class CarouselsHelper
    {
        public List<CarouselsViewModels> GenerateCarousels()
        {
            try
            {
                CarouselsDataService carouselDS = new CarouselsDataService();
                DataSet ds = new DataSet();
                List<CarouselsViewModels> viewModels = new List<CarouselsViewModels>();
                CarouselsViewModels viewModel = new CarouselsViewModels();

                ds = carouselDS.GetCarousels();

                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                viewModel = new CarouselsViewModels();
                                viewModel.CarouselId = Convert.ToInt32(ds.Tables[0].Rows[i]["CarouselId"]);
                                viewModel.Sequence = Convert.ToInt32(ds.Tables[0].Rows[i]["Sequence"]);
                                viewModel.CarouselImageString = Convert.ToString(ds.Tables[0].Rows[i]["CarouselImageString"]);
                                viewModel.CarouselDateCreated = Convert.ToDateTime(ds.Tables[0].Rows[i]["CarouselDateCreated"]);
                                viewModels.Add(viewModel);
                            }
                        }
                    }
                }

                return viewModels;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CarouselsViewModels GetCarouselByCarouselId(int carouselId)
        {
            try
            {
                CarouselsDataService carouselDS = new CarouselsDataService();
                DataSet ds = new DataSet();
                CarouselsViewModels viewModel = new CarouselsViewModels();

                ds = carouselDS.GetCarouselByCarouseldId(carouselId);

                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            viewModel = new CarouselsViewModels();
                            viewModel.CarouselId = Convert.ToInt32(ds.Tables[0].Rows[0]["CarouselId"]);
                            viewModel.Sequence = Convert.ToInt32(ds.Tables[0].Rows[0]["Sequence"]);
                            viewModel.CarouselImageString = Convert.ToString(ds.Tables[0].Rows[0]["CarouselImageString"]);
                            viewModel.CarouselDateCreated = Convert.ToDateTime(ds.Tables[0].Rows[0]["CarouselDateCreated"]);
                        }
                    }
                }

                return viewModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertCarousels(string imageString)
        {
            try
            {
                CarouselsDataService carouselDS = new CarouselsDataService();
                
                carouselDS.InsertCarousel(imageString);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteCarouselByCarouselId(int carouselId)
        {
            CarouselsDataService carouselDS = new CarouselsDataService();
            carouselDS.DeleteCarouselByCarouselId(carouselId);
        }

        public void UpdateCarouselByCarouselId(int carouselId, int sequence, string imageURL)
        {
            CarouselsDataService carouselDS = new CarouselsDataService();
            carouselDS.UpdateCarouselByCarouselId(carouselId, sequence, imageURL);
        }
    }
}