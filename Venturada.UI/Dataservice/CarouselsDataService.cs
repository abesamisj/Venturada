using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Venturada.UI.Dataservice
{
    public class CarouselsDataService : BasicDal
    {
        public DataSet GetCarousels()
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetCarousels");
                

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

        public DataSet GetCarouselByCarouseldId(int carouselId)
        {
            try
            {
                Database db = GetFactoryProvider();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DbCommand dbComm = db.GetStoredProcCommand("GetCarouselByCarouseId");
                db.AddInParameter(dbComm, "@CarouselId", DbType.Int32, carouselId);

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

        public void DeleteCarouselByCarouselId(int carouselId)
        {
            try
            {
                Database db = GetFactoryProvider();

                DbCommand dbcomm = db.GetStoredProcCommand("DeleteCarouselByCarouselId");

                db.AddInParameter(dbcomm, "@CarouselId", DbType.Int32, carouselId);

                db.ExecuteNonQuery(dbcomm);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public void UpdateCarouselByCarouselId(int carouselId, int sequence, string imageString)
        {
            try
            {
                Database db = GetFactoryProvider();

                DbCommand dbcomm = db.GetStoredProcCommand("UpdateCarouselByCarouselId");

                db.AddInParameter(dbcomm, "@CarouselId", DbType.Int32, carouselId);
                db.AddInParameter(dbcomm, "@Sequence", DbType.Int32, sequence);
                db.AddInParameter(dbcomm, "@CarouselImageString", DbType.String, imageString);

                db.ExecuteNonQuery(dbcomm);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void InsertCarousel(string imageString)
        {

            try
            {
                Database db = GetFactoryProvider();

                DbCommand dbcomm = db.GetStoredProcCommand("InsertCarousel");

                db.AddInParameter(dbcomm, "@CarouselImageString", DbType.String, imageString);

                db.ExecuteNonQuery(dbcomm);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}