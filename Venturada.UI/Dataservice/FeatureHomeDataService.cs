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
    public class FeatureHomeDataService : BasicDal
    {
        public DataSet GetFeatureHomePage()
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetFeatureHomePage");


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
        public DataSet GetFeatureHomePageFeatureId(int featureId)
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetFeatureHomePageByFeatureId");
                db.AddInParameter(dbComm, "@FeatureId", DbType.Int32, featureId);


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

        public void UpdateFeatureHomePage(FeatureMainModel fmv)
        {
            try
            {
                Database db = GetFactoryProvider();

                DbCommand dbcomm = db.GetStoredProcCommand("UpdateFeautreHomePageByFeatureId");

                db.AddInParameter(dbcomm, "@FeatureId", DbType.Int32, fmv.@FeatureId);
                db.AddInParameter(dbcomm, "@FeatureImageURLString", DbType.String, fmv.FeatureImageURLString);
                db.AddInParameter(dbcomm, "@FeatureDescription", DbType.String, fmv.FeatureDescription);

                db.ExecuteNonQuery(dbcomm);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}