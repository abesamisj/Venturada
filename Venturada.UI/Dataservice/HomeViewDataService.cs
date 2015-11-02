using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Dataservice
{
    public class HomeViewDataService : BasicDal
    {
        public DataSet GetMainHomePage()
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetMainHomePage");


                using (ds = db.ExecuteDataSet(dbComm))
                {
                    return ds;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateMainHomePage(MainViewModel mvm)
        {
            try
            {
                Database db = GetFactoryProvider();

                DbCommand dbcomm = db.GetStoredProcCommand("UpdateMainHomePage");

                db.AddInParameter(dbcomm, "@MainTitle", DbType.String, mvm.MainTitle);
                db.AddInParameter(dbcomm, "@MainSubTitle", DbType.String, mvm.MainSubTitle);
                db.AddInParameter(dbcomm, "@MainParagraph", DbType.String, mvm.MainParagraph);

                db.ExecuteNonQuery(dbcomm);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}