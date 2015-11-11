using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class ContactAdditionalModel
    {
        public int ContactAdditionalId { get; set; }

        //[Required(ErrorMessage = "Please enter your contact title")]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }
        [AllowHtml]
        [Required(ErrorMessage = "Please enter your contact description")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Additional Contact Description must be between 3 and 500 characters!")]
        [Display(Name = "Additional Contact Description")]
        public string ContactDescription { get; set; }
    }
}