using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Venturada.UI.Models
{
    public class PartnersModel
    {
        public int PartnerId { get; set; }
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public int Sequence { get; set; }
    }
}