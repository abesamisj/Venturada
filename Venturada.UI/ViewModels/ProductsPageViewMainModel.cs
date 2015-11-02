using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.ViewModels
{
    public class ProductsPageViewMainModel
    {
        public ProductsMainModel ProductsMainModel { get; set; }
        public List<ProductsListModel> ProductsListModel { get; set; }
    }
}