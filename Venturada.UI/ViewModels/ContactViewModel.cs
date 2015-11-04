using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.ViewModels
{
    public class ContactViewModel
    {
        public ContactModel ContactModel { get; set; }
        public AddressModel AddressModel { get; set; }
        public ContactNumbersModel ContactNumbersModel1 { get; set; }
        public ContactNumbersModel ContactNumbersModel2 { get; set; }
        public ContactNumbersModel ContactNumbersModel3 { get; set; }
        public ContactNumbersModel ContactNumbersModel4 { get; set; }
        public ContactNumbersModel ContactNumbersModel5 { get; set; }

        public EmailFormModel EmailFormModel { get; set; }
    }
}