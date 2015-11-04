using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter your website company name")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}