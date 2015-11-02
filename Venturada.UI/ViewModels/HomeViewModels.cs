using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venturada.UI.ViewModels
{
    public class HomeViewModels
    {
        public List<CarouselsViewModels> CarouselsViewModels { get; set; }

        public MainViewModel MainViewModels { get; set; }

        public List<FeatureMainModel> FeatureMainModel { get; set; }
    }
}