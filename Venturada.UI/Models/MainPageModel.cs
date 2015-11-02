using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class MainPageModel
    {
        [Required]
        [AllowHtml]
        public string htmlContent { get; set; }
        [Required]
        public string mainTitle { get; set; }
        [Required]
        public string subTitle { get; set; }
    }
}