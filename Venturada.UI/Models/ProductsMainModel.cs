using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class ProductsMainModel
    {
        public int ProductsMainId { get; set; }
        public string ImageURLString { get; set; }
        [Required(ErrorMessage = "Please enter your website products paragraph")]
        [Display(Name = "Products Main Paragraph")]
        [AllowHtml]
        public string ProductMainParagraph { get; set; }
        [Required(ErrorMessage = "Please enter your website products sub paragraph")]
        [Display(Name = "Products Sub Paragraph")]
        [AllowHtml]
        public string ProductSubParagraph { get; set; }
        [Required(ErrorMessage = "Please enter your website products main title")]
        [Display(Name = "Products Main Title")]
        public string ProductMainParagraphTitle { get; set; }
        [Required(ErrorMessage = "Please enter your website products sub title")]
        [Display(Name = "Products Sub Title")]
        public string ProductSubParagraphTitle { get; set; }
    }
}