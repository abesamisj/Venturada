using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class PriceListModel
    {
        public int PriceListId { get; set; }
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage = "Please enter the product name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Please enter the product price")]
        [Display(Name = "Price")]
        public string Price { get; set; } 
    }
}