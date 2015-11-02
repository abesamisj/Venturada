using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venturada.UI.ViewModels
{
    public class EmailFormModel
    {
        [StringLength(100, ErrorMessage = "Your name must be atleast 3 characters long", MinimumLength = 3)]
        [Required, Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Your company must be atleast 3 characters long", MinimumLength = 3)]
        [Required, Display(Name = "Company")]
        public string Company { get; set; }

        [Required, Display(Name = "Email Address"), EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage="Telephone Number Required"), Display(Name = "Phone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
        
        [StringLength(100, ErrorMessage = "Your subject must be atleast 3 characters long", MinimumLength = 3)]
        [Required, Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}