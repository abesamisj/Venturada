using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class ContactDataService
    {
        public ContactModel GenerateContactModel()
        {
            try
            {

                ContactModel model = new ContactModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.Contacts.ToList()
                                  select p;

                    model = new ContactModel();
                    model.CompanyName = table.FirstOrDefault().CompanyName;
                    model.ContactId = table.FirstOrDefault().ContactId;

                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public AddressModel GenerateAddressModel()
        {
            try
            {

                AddressModel model = new AddressModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.Addresses.ToList()
                                select p;

                    model = new AddressModel();
                    model.AddressId = table.FirstOrDefault().AddressId;
                    model.AddressLine1 = table.FirstOrDefault().AddressLine1;
                    model.AddressLine2 = table.FirstOrDefault().AddressLine2;
                    model.Country = table.FirstOrDefault().Country;
                    model.PostCode = table.FirstOrDefault().PostCode;

                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ContactNumbersModel GenerateContactNumbersModelById(int contactNumberId)
        {
            try
            {

                ContactNumbersModel model = new ContactNumbersModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.ContactNumbers.ToList()
                                where p.ContactNumberId == contactNumberId
                                  select p;

                    model = new ContactNumbersModel();
                    model.ContactNumber = table.FirstOrDefault().ContactNumber1;
                    model.ContactNumberId = table.FirstOrDefault().ContactNumberId;

                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public EmailAddressModel GenerateEmailAddressModelById(int emailAddressId)
        {
            try
            {

                EmailAddressModel model = new EmailAddressModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.EmailAddresses.ToList()
                                where p.EmailAddressId == emailAddressId
                                select p;

                    model = new EmailAddressModel();
                    model.EmailAddressId = table.FirstOrDefault().EmailAddressId;
                    model.EmailAddress = table.FirstOrDefault().EmailAddress1;

                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ShoppingHoursModel GenerateShoppingHoursModelById(int shoopingHoursId)
        {
            try
            {

                ShoppingHoursModel model = new ShoppingHoursModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.ShoppingHours.ToList()
                                where p.ShoppingHoursId == shoopingHoursId
                                select p;

                    model = new ShoppingHoursModel();
                    model.ShoppingHoursId = table.FirstOrDefault().ShoppingHoursId;
                    model.ShoppingHours = table.FirstOrDefault().ShoppingHours;

                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ContactAdditionalModel GenerateContactAdditionalModelById(int id)
        {
            try
            {

                ContactAdditionalModel model = new ContactAdditionalModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.ContactAdditionals.ToList()
                                where p.ContactAdditionalId == id
                                select p;

                    model = new ContactAdditionalModel();
                    model.ContactAdditionalId = table.FirstOrDefault().ContactAdditionalId;
                    model.ContactTitle = table.FirstOrDefault().ContactTitle;
                    model.ContactDescription = table.FirstOrDefault().ContactDescription;
                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateCompanyName(int contactId, string companyName)
        {
            try
            {
                Contact table = new Contact();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.Contacts.Single(a => a.ContactId == contactId);
                    table.CompanyName = companyName;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateContactNumbers(int contactNumberId, string contactNumber)
        {
            try
            {
                ContactNumber table = new ContactNumber();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.ContactNumbers.Single(a => a.ContactNumberId == contactNumberId);
                    table.ContactNumber1 = contactNumber;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateEmailAddress(int emailAddressId, string emailAddress)
        {
            try
            {
                EmailAddress table = new EmailAddress();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.EmailAddresses.Single(a => a.EmailAddressId == emailAddressId);
                    table.EmailAddress1 = emailAddress;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateShoppingHours(int id, string description)
        {
            try
            {
                ShoppingHour table = new ShoppingHour();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.ShoppingHours.Single(a => a.ShoppingHoursId == id);
                    table.ShoppingHours = description;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateContactAdditional(int id, string title, string description)
        {
            try
            {
                ContactAdditional table = new ContactAdditional();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.ContactAdditionals.Single(a => a.ContactAdditionalId == id);
                    table.ContactDescription = description;
                    table.ContactTitle = title;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public SocialMediaModel GenerateSocialMediaModelById(int id)
        {
            try
            {

                SocialMediaModel model = new SocialMediaModel();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {

                    var table = from p in vdc.SocialMedias.ToList()
                                where p.SocialMediaId == id
                                select p;

                    model = new SocialMediaModel();
                    model.SocialMediaId = table.FirstOrDefault().SocialMediaId;
                    model.SocialMediaType = table.FirstOrDefault().SocialMediaType;
                    model.SocialMediaUrl = table.FirstOrDefault().SocialMediaUrl;
                    return model;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateSocialMedia(int id, string description)
        {
            try
            {
                SocialMedia table = new SocialMedia();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.SocialMedias.Single(a => a.SocialMediaId == id);
                    table.SocialMediaUrl = description;

                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}