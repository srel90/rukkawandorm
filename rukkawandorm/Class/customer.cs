using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class customer
    {
        public int customerID { get; set; }
        public int customerTypeID { get; set; }
        public string customerType { get; set; }
        public string customerCode { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string idCard { get; set; }
        public DateTime dob { get; set; }
        public int gender { get; set; }
        public string level { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public string contactPerson { get; set; }
        public string photo { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public customer()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 customerID+1  as lastID FROM customer ORDER BY customerID DESC";
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
        public DataSet selectAllCustomer()
        {

            try
            {
                str = "SELECT customer.*,IIF (customer.status = true , 'Active' , 'Inactive' ) AS statusName,customerType.customerType  FROM customer customer LEFT OUTER JOIN customerType customerType on customer.customerTypeID=customerType.customerTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectCustomerByID(int customerID)
        {

            try
            {
                str = "SELECT customer.*,IIF (customer.status = true , 'Active' , 'Inactive' ) AS statusName,customerType.customerType  FROM customer customer LEFT OUTER JOIN customerType customerType on customer.customerTypeID=customerType.customerTypeID WHERE customer.customerID=@customerID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchCustomer(string keyword)
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
                        searchTermBits.Add("customer.customerCode LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.idCard LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.firstName LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.lastName LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.email LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.phone LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.mobile LIKE '%" + term + "%'");
                        searchTermBits.Add("customer.contactPerson LIKE '*" + term + "*'");
                    }
                }
                str = "SELECT customer.*,IIF (customer.status = true , 'Active' , 'Inactive' ) AS statusName,customerType.customerType  FROM customer customer LEFT OUTER JOIN customerType customerType on customer.customerTypeID=customerType.customerTypeID  ";
                if (searchTermBits.Count != 0)
                {
                    str += " WHERE ";
                    str += String.Join<string>(" OR ", searchTermBits.ToArray(typeof(string)) as string[]);
                }
                
                Dbcmd = db.GetSqlStringCommand(@str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertCustomer()
        {
            try
            {
                str = "INSERT INTO customer (customerTypeID,customerCode,[title],firstName,lastName,presentAddress,permanentAddress,idCard,dob,[gender],[level],email,[phone],[mobile],[fax],contactPerson,[photo],[status])VALUES(@customerTypeID,@customerCode,@title,@firstName,@lastName,@presentAddress,@permanentAddress,@idCard,@dob,@gender,@level,@email,@phone,@mobile,@fax,@contactPerson,@photo,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerTypeID", DbType.Int32, customerTypeID);
                db.AddInParameter(Dbcmd, "@customerCode", DbType.String, customerCode);
                db.AddInParameter(Dbcmd, "@title", DbType.String, title);
                db.AddInParameter(Dbcmd, "@firstName", DbType.String, firstName);
                db.AddInParameter(Dbcmd, "@lastName", DbType.String, lastName);
                db.AddInParameter(Dbcmd, "@presentAddress", DbType.String, presentAddress);
                db.AddInParameter(Dbcmd, "@permanentAddress", DbType.String, permanentAddress);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, idCard);
                db.AddInParameter(Dbcmd, "@dob", DbType.String, dob.ToString("yyyy-MM-dd"));
                db.AddInParameter(Dbcmd, "@gender", DbType.Int32, gender);
                db.AddInParameter(Dbcmd, "@level", DbType.String, level);
                db.AddInParameter(Dbcmd, "@email", DbType.String, email);
                db.AddInParameter(Dbcmd, "@phone", DbType.String, phone);
                db.AddInParameter(Dbcmd, "@mobile", DbType.String, mobile);
                db.AddInParameter(Dbcmd, "@fax", DbType.String, fax);
                db.AddInParameter(Dbcmd, "@contactPerson", DbType.String, contactPerson);
                db.AddInParameter(Dbcmd, "@photo", DbType.String, photo);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateCustomer()
        {
            try
            {
                str = "UPDATE customer SET customerTypeID=@customerTypeID,customerCode=@customerCode,[title]=@title,firstName=@firstName,lastName=@lastName,presentAddress=@presentAddress,permanentAddress=@permanentAddress,idCard=@idCard,dob=@dob,[gender]=@gender,[level]=@level,email=@email,[phone]=@phone,[mobile]=@mobile,[fax]=@fax,contactPerson=@contactPerson,[photo]=@photo,[status]=@status WHERE customerID=@customerID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerTypeID", DbType.Int32, customerTypeID);
                db.AddInParameter(Dbcmd, "@customerCode", DbType.String, customerCode);
                db.AddInParameter(Dbcmd, "@title", DbType.String, title);
                db.AddInParameter(Dbcmd, "@firstName", DbType.String, firstName);
                db.AddInParameter(Dbcmd, "@lastName", DbType.String, lastName);
                db.AddInParameter(Dbcmd, "@presentAddress", DbType.String, presentAddress);
                db.AddInParameter(Dbcmd, "@permanentAddress", DbType.String, permanentAddress);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, idCard);
                db.AddInParameter(Dbcmd, "@dob", DbType.String, dob.ToString("yyyy-MM-dd"));
                db.AddInParameter(Dbcmd, "@gender", DbType.Int32, gender);
                db.AddInParameter(Dbcmd, "@level", DbType.String, level);
                db.AddInParameter(Dbcmd, "@email", DbType.String, email);
                db.AddInParameter(Dbcmd, "@phone", DbType.String, phone);
                db.AddInParameter(Dbcmd, "@mobile", DbType.String, mobile);
                db.AddInParameter(Dbcmd, "@fax", DbType.String, fax);
                db.AddInParameter(Dbcmd, "@contactPerson", DbType.String, contactPerson);
                db.AddInParameter(Dbcmd, "@photo", DbType.String, photo);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteCustomer(int customerID)
        {
            try
            {
                str = "DELETE FROM customer WHERE customerID=@customerID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
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
