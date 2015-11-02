using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class GalleryModel
    {
        public int GalleryId { get; set; }

        [Required(ErrorMessage = "Please enter your gallery title")]
        [Display(Name = "Gallery Title")]
        public string GalleryTitle { get; set; }
        [Required(ErrorMessage = "Please enter your gallery description")]
        [Display(Name = "Gallery Description")]
        public string GalleryDescription { get; set; }
        public int Row { get; set; }
        public string ImageString { get; set; }
    }
}