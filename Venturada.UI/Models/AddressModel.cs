using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venturada.UI.Models
{
    public class AddressModel
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}