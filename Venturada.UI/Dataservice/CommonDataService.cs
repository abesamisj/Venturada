using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class CommonDataService
    {
        public CommonModel GenerateCommonModel()
        {
            try
            {

                CommonModel model = new CommonModel();
                ContactDataService cds = new ContactDataService();

                model.FaceBook = cds.GenerateSocialMediaModelById(1).SocialMediaUrl;
                model.Twitter = cds.GenerateSocialMediaModelById(2).SocialMediaUrl;
                model.Youtube = cds.GenerateSocialMediaModelById(3).SocialMediaUrl;
                model.Instagram = cds.GenerateSocialMediaModelById(4).SocialMediaUrl;
                model.PhoneNumber = cds.GenerateContactNumbersModelById(1).ContactNumber;
                model.Email = cds.GenerateEmailAddressModelById(1).EmailAddress;
                model.ShoppingHours = cds.GenerateShoppingHoursModelById(1).ShoppingHours;

                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}