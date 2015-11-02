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
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }
        [Required(ErrorMessage = "Please enter service sub title here")]
        [Display(Name = "Service Sub Title")]
        public string ServiceSubTitle { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter service description here")]
        [Display(Name = "Service Description")]
        public string ServiceDescription { get; set; }
        [Display(Name = "Image URL")]
        public string ImageString { get; set; }
    }
}