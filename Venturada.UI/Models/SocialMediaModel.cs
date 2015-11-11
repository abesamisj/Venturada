using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class SocialMediaModel
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaType { get; set; }

        [Required(ErrorMessage = "Please enter your Social Media Url")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Social Media Url must be between 3 and 500 characters!")]
        [Display(Name = "Social Media Url")]
        public string SocialMediaUrl { get; set; }
    }
}