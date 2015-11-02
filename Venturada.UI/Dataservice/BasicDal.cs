using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venturada.UI.Dataservice
{
    public abstract class BasicDal
    {
        public Database GetFactoryProvider()
        {
            try
            {
                DatabaseProviderFactory factoryProvider = new DatabaseProviderFactory();
                //factoryProvider.CreateDefault();
                return factoryProvider.Create("DefaultConnection");

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}