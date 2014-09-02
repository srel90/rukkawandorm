using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class employeeType
    {
        public int employeeTypeID { get; set; }
        public string _employeeType { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public employeeType()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 employeeTypeID+1  as lastID FROM employeeType ORDER BY employeeTypeID DESC";
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
        public DataSet selectAllEmployeeType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM employeeType;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllActiveEmployeeType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM employeeType where status=true;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectEmployeeTypeByID(int employeeTypeID)
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM employeeType WHERE employeeTypeID=@employeeTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeTypeID", DbType.Int32, employeeTypeID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchEmployeeType(string keyword)
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
                        searchTermBits.Add("employeeType LIKE '%" + term + "%'");
                    }
                }
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM employeeType WHERE ";
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
        public Boolean insertEmployeeType()
        {
            try
            {
                str = "INSERT INTO employeeType (employeeType,status)VALUES(@employeeType,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeType", DbType.String, _employeeType);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateEmployeeType()
        {
            try
            {
                str = "UPDATE employeeType SET employeeType=@employeeType,status=@status WHERE employeeTypeID=@employeeTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeType", DbType.String, _employeeType);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@employeeTypeID", DbType.Int32, employeeTypeID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteEmployeeType(int employeeTypeID)
        {
            try
            {
                str = "DELETE FROM employeeType WHERE employeeTypeID=@employeeTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeTypeID", DbType.Int32, employeeTypeID);
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
