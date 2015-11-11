using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class EmailAddressModel
    {
        public int EmailAddressId { get; set; }

        [Required(ErrorMessage = "Please enter your website email address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}