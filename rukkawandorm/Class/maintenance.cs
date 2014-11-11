using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;

namespace rukkawandorm.Class
{
    class maintenance
    {
        public int maID { get; set; }
        public string employeeCode { get; set; }
        public string roomCode { get; set; }
        public string maType { get; set; }
        public DateTime maDatetimeFrom { get; set; }
        public DateTime maDatetimeTo { get; set; }
        public string maDetail { get; set; }
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;

        public maintenance()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 maID+1  as lastID FROM maintenance ORDER BY maID DESC";
            int ret = 1;
            try
            {

                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ret = Convert.ToInt32(ds.Tables[0].Rows[0]["lastID"].ToString());
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllMaintenance()
        {

            try
            {
                str = "SELECT * FROM maintenance;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet selectMaintenanceByID(int maID)
        {

            try
            {
                str = "SELECT * FROM maintenance WHERE maID=@maID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@maID", DbType.Int32, maID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchMaintenance()
        {
            try
            {

                str = "SELECT *  FROM maintenance WHERE ";
                str += "datediff('D',maDatetimeFrom,'"+maDatetimeFrom+"')<=0 and datediff('D',maDatetimeTo,'"+maDatetimeTo+"')>=0 and maType='"+maType+"'";
                Dbcmd = db.GetSqlStringCommand(@str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertMaintenance()
        {
            try
            {
                str = "INSERT INTO maintenance (employeeCode,roomCode,maType,maDatetimeFrom,maDatetimeTo,maDetail)VALUES(@employeeCode,@roomCode,@maType,@maDatetimeFrom,@maDatetimeTo,@maDetail);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeCode", DbType.String, employeeCode);
                db.AddInParameter(Dbcmd, "@roomCode", DbType.String, roomCode);
                db.AddInParameter(Dbcmd, "@maType", DbType.String, maType);
                db.AddInParameter(Dbcmd, "@maDatetimeFrom", DbType.DateTime, maDatetimeFrom);
                db.AddInParameter(Dbcmd, "@maDatetimeTo", DbType.DateTime, maDatetimeTo);
                db.AddInParameter(Dbcmd, "@maDetail", DbType.String, maDetail);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateMaintenance()
        {
            try
            {
                str = "UPDATE maintenance SET employeeCode=@employeeCode,roomCode=@roomCode,maType=@maType,maDatetimeFrom=@maDatetimeFrom ,maDatetimeTo=@maDatetimeTo,maDetail=@maDetail WHERE maID=@maID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeCode", DbType.String, employeeCode);
                db.AddInParameter(Dbcmd, "@roomCode", DbType.String, roomCode);
                db.AddInParameter(Dbcmd, "@maType", DbType.String, maType);
                db.AddInParameter(Dbcmd, "@maDatetimeFrom", DbType.DateTime, maDatetimeFrom);
                db.AddInParameter(Dbcmd, "@maDatetimeTo", DbType.DateTime, maDatetimeTo);
                db.AddInParameter(Dbcmd, "@maDetail", DbType.String, maDetail);
                db.AddInParameter(Dbcmd, "@maID", DbType.Int32, maID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteMaintenance(int maID)
        {
            try
            {
                str = "DELETE FROM maintenance WHERE maID=@maID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@maID", DbType.Int32, maID);
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
