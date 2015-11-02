using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class AboutUsModel
    {
        public int AboutUsId { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Please enter your website about us title")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "About Us Title must be between 3 and 100 characters!")]
        [Display(Name = "About Us Title")]
        public string AboutUsTitle { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter your website about us paragraph")]
        [Display(Name = "About Us Paragraph")]
        public string AboutUsParagraph { get; set; }
    }
}