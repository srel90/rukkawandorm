using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class customerType
    {
        public int customerTypeID { get; set; }
        public string _customerType { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public customerType()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 customerTypeID+1  as lastID FROM customerType ORDER BY customerTypeID DESC";
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
        public DataSet selectAllCustomerType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM customerType;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllActiveCustomerType()
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM customerType where status=true;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectCustomerTypeByID(int customerTypeID)
        {

            try
            {
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM customerType WHERE customerTypeID=@customerTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerTypeID", DbType.Int32, customerTypeID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchCustomerType(string keyword)
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
                        searchTermBits.Add("customerType LIKE '%" + term + "%'");
                    }
                }
                str = "SELECT *,IIF (status = true , 'Active' , 'Inactive' ) AS statusName  FROM customerType WHERE ";
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
        public Boolean insertCustomerType()
        {
            try
            {
                str = "INSERT INTO customerType (customerType,status)VALUES(@customerType,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerType", DbType.String, _customerType);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateCustomerType()
        {
            try
            {
                str = "UPDATE customerType SET customerType=@customerType,status=@status WHERE customerTypeID=@customerTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerType", DbType.String, _customerType);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@customerTypeID", DbType.Int32, customerTypeID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteCustomerType(int customerTypeID)
        {
            try
            {
                str = "DELETE FROM customerType WHERE customerTypeID=@customerTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerTypeID", DbType.Int32, customerTypeID);
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
