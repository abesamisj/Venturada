using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class PromoModel
    {
        public int PromoId { get; set; }
        [Required(ErrorMessage = "Please enter promo title here")]
        [Display(Name = "Promo Title")]
        public string PromoTitle { get; set; }
        [AllowHtml]
        [Required(ErrorMessage = "Please enter promo descriptions here")]
        [Display(Name = "Promo Descriptions")]
        public string PromoDescription { get; set; }
        public string ImageString { get; set; }
    }
}