using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class roomType
    {
        public int roomTypeID { get; set; }
        public string _roomType { get; set; }
        public double price { get; set; }
        public bool bf { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public roomType()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 roomTypeID+1  as lastID FROM roomType ORDER BY roomTypeID DESC";
            int ret = 1;
            try
            {

                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                if (ds.Tables[0].Rows.Count!=0)
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
        public DataSet selectAllRoomType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM roomType;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllActiveRoomType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM roomType where status=true;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectRoomTypeByID(int roomTypeID)
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM roomType WHERE roomTypeID=@roomTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int32, roomTypeID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchRoomType(string keyword)
        {
            try
            {
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex(@"[ ]{2,}", options);
                keyword = regex.Replace(keyword, @" ");
                string[] searchTerms = keyword.Split(' ');
                ArrayList searchTermBits = new ArrayList();
                foreach (string term in searchTerms)
                {
                    if (!term.Trim().Equals(string.Empty))
                    {
                        searchTermBits.Add("roomType LIKE '%" + term + "%'");
                        searchTermBits.Add("price LIKE '%" + term + "%'");
                    }
                }
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM roomType WHERE ";
                str += string.Join(" OR ", searchTermBits.ToArray(typeof(string)) as string[]);
                Dbcmd = db.GetSqlStringCommand(@str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertRoomType()
        {
            try
            {
                str = "INSERT INTO roomType (roomType,price,status)VALUES(@roomType,@price,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomType", DbType.String, _roomType);
                db.AddInParameter(Dbcmd, "@price", DbType.Double, price);
                
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateRoomType()
        {
            try
            {
                str = "UPDATE roomType SET roomType=@roomType,price=@price,status=@status WHERE roomTypeID=@roomTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomType", DbType.String, _roomType);
                db.AddInParameter(Dbcmd, "@price", DbType.Double, price);
               
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int16, roomTypeID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteRoomType(int roomTypeID)
        {
            try
            {
                str = "DELETE FROM roomType WHERE roomTypeID=@roomTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int32, roomTypeID);
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
