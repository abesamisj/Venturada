using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class ShoppingHoursModel
    {
        public int ShoppingHoursId { get; set; }

        [Required(ErrorMessage = "Please enter your shopping hours")]
        [Display(Name = "Shopping Hours")]
        public string ShoppingHours { get; set; }
    }
}