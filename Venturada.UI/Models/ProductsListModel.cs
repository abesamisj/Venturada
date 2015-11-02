using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class ProductsListModel
    {
        public int ProductsId { get; set; }
        public string MainDescriptionTitle { get; set; }
        [Required(ErrorMessage = "Please enter the products category")]
        [Display(Name = "Product Category")]
        public string MainDescription { get; set; }
        [Required(ErrorMessage = "Please enter the products list")]
        [Display(Name = "Product List")]
        [AllowHtml]
        public string DetailsDescription { get; set; }
    }
}