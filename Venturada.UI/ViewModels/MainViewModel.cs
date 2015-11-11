using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.ViewModels
{
    public class MainViewModel
    {
        [Display(Name = "Main Id")]
        public int MainId { get; set; }

        [Required(ErrorMessage = "Please enter your website main title")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Main title must be between 3 and 200 characters!")]
        [Display(Name = "Main Title")]
        public string MainTitle { get; set; }

        [Display(Name = "Main Sub Title")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Sub title must be between 3 and 1000 characters!")]
        [Required(ErrorMessage = "Please enter your website sub title")]
        public string MainSubTitle { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter your website main paragraph")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Image URL must be between 3 and 1000 characters!")]
        [Display(Name = "Main Paragraph")]
        public string MainParagraph { get; set; }
    }
}