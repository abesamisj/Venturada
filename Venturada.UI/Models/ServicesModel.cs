using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class ServicesModel
    {
        public int ServicesId { get; set; }
        [Required(ErrorMessage = "Please enter service name here")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Service Name must be between 3 and 100 characters!")]
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }
        [Required(ErrorMessage = "Please enter service sub title here")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Service Sub Title must be between 3 and 50 characters!")]
        [Display(Name = "Service Sub Title")]
        public string ServiceSubTitle { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter service description here")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 300 characters!")]
        [Display(Name = "Service Description")]
        public string ServiceDescription { get; set; }
        [Display(Name = "Image URL")]
        public string ImageString { get; set; }
    }
}