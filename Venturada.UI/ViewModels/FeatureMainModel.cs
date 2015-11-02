using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.ViewModels
{
    public class FeatureMainModel
    {
        [Display(Name = "Feature Id")]
        public int FeatureId { get; set; }

        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Image URL must be between 3 and 1000 characters!")]
        [Display(Name = "Image")]
        public string FeatureImageURLString { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter your description here")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 1000 characters!")]
        [Display(Name = "Feature Description")]
        public string FeatureDescription { get; set; }

    }
}