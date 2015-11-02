using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class ProductCategoryModel
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategory { get; set; }
        public List<ProductHeaderModel> ProductHeaderModel { get; set; }
        public List<PriceListModel> PriceListModel { get; set; }
    }
}