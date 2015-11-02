using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Venturada.UI.Dataservice;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Common
{
    public class HomePageHelper
    {
        public MainViewModel GenerateMainViewModel()
        {
            try
            {
                HomeViewDataService carouselDS = new HomeViewDataService();
                DataSet ds = new DataSet();
                MainViewModel viewModel = new MainViewModel();

                ds = carouselDS.GetMainHomePage();

                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            viewModel.MainId = Convert.ToInt32(ds.Tables[0].Rows[0]["MainId"]);
                            viewModel.MainTitle = Convert.ToString(ds.Tables[0].Rows[0]["MainTitle"]);
                            viewModel.MainSubTitle = Convert.ToString(ds.Tables[0].Rows[0]["MainSubTitle"]);
                            viewModel.MainParagraph = Convert.ToString(ds.Tables[0].Rows[0]["MainParagraph"]);
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


        public List<FeatureMainModel> GenerateFeatureMainModel()
        {
            try
            {
                FeatureHomeDataService dataService = new FeatureHomeDataService();
                DataSet ds = new DataSet();
                List<FeatureMainModel> viewModels = new List<FeatureMainModel>();
                FeatureMainModel viewModel = new FeatureMainModel();

                ds = dataService.GetFeatureHomePage();

                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                viewModel = new FeatureMainModel();
                                viewModel.FeatureId = Convert.ToInt32(ds.Tables[0].Rows[i]["FeatureId"]);
                                viewModel.FeatureImageURLString = Convert.ToString(ds.Tables[0].Rows[i]["FeatureImageURLString"]);
                                viewModel.FeatureDescription = Convert.ToString(ds.Tables[0].Rows[i]["FeatureDescription"]);
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
    }
}