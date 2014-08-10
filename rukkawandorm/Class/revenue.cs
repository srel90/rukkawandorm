using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class revenue
    {
        public int revenueID { get; set; }
        public int reservationID { get; set; }
        public int employeeID { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double fines { get; set; }
        public double netAmount { get; set; }
        public DateTime realCheckinDateTime {get; set;}
        public DateTime realCheckoutDateTime { get; set; }
        public int nightStay { get; set; }
        public DateTime revenueDateTime { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public revenue()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 revenueID+1  as lastID FROM revenue ORDER BY revenueID DESC";
            int ret = 1;
            try
            {

                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ret = Convert.ToInt16(ds.Tables[0].Rows[0]["lastID"].ToString());
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllRevenue()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM revenue;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllRevenue(DateTime datefrom, DateTime dateto)
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM revenue where revenueDateTime between @datefrom and @dateto;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@datefrom", DbType.String, datefrom);
                db.AddInParameter(Dbcmd, "@dateto", DbType.String, dateto);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectRevenueByID(int revenueID)
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM revenue WHERE revenueID=@revenueID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@revenueID", DbType.Int32, revenueID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean insertRevenue()
        {
            try
            {
                str = "INSERT INTO revenue (reservationID,employeeID,amount,discount,fines,netAmount,realCheckinDateTime,realCheckoutDateTime,nightStay,revenueDateTime,status)VALUES(@reservationID,@employeeID,@amount,@discount,@fines,@netAmount,@realCheckinDateTime,@realCheckoutDateTime,@nightStay,@revenueDateTime,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
                db.AddInParameter(Dbcmd, "@amount", DbType.Double, amount);
                db.AddInParameter(Dbcmd, "@discount", DbType.Double, discount);
                db.AddInParameter(Dbcmd, "@fines", DbType.Double, fines);
                db.AddInParameter(Dbcmd, "@netAmount", DbType.Double, netAmount);
                db.AddInParameter(Dbcmd, "@realCheckinDateTime", DbType.String, realCheckinDateTime.ToString());
                db.AddInParameter(Dbcmd, "@realCheckoutDateTime", DbType.String, realCheckoutDateTime.ToString());
                db.AddInParameter(Dbcmd, "@nightStay", DbType.Int32, nightStay);
                db.AddInParameter(Dbcmd, "@revenueDateTime", DbType.String, revenueDateTime.ToString());
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
