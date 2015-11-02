using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Venturada.UI.Dataservice
{
    public class UserDataService : BasicDal
    {
        public DataSet GetUsersByUserName(string userName)
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetUsersByUserName");
                db.AddInParameter(dbComm, "@UserName", DbType.String, userName);

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
    }
}