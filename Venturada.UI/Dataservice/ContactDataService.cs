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
    }
}