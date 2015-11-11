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

        public EmailAddressModel EmailAddressModel { get; set; }

        public ShoppingHoursModel ShoppingHoursModel { get; set; }
        public ContactAdditionalModel ContactAdditionalModel { get; set; }
        public SocialMediaModel SocialMediaModelFacebook { get; set; }
        public SocialMediaModel SocialMediaModelTwitter { get; set; }
        public SocialMediaModel SocialMediaModelYoutube { get; set; }
        public SocialMediaModel SocialMediaModelInstagram { get; set; }

        public EmailFormModel EmailFormModel { get; set; }
    }
}