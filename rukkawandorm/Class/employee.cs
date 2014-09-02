using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;


namespace rukkawandorm.Class
{
    class employee
    {
        public int employeeID { get; set; }
        public int employeeTypeID { get; set; }
        public string employeeCode { get; set; }
        public string idCard { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dob { get; set; }
        public string department { get; set; }
        public string position { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public bool status { get; set; }
        public string statusName { get; set; }
        public string employeeType { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public employee()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public string checkEmployee()
        {

            try
            {
                str = "SELECT * FROM employee WHERE username=@username AND password=@password AND status=true;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@username", DbType.String, username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, password);
                dt = db.ExecuteDataSet(Dbcmd).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    return dt.Rows[0]["employeeID"].ToString();
                }
                else
                {
                    return "false";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 employeeID+1  as lastID FROM employee ORDER BY employeeID DESC";
            int ret = 1;
            try
            {

                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                if (ds.Tables[0].Rows.Count!=0)
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
        public DataSet selectAllEmployee()
        {

            try
            {
                str = "SELECT employee.*,IIF (employee.status = true , 'Active' , 'Inactive' ) AS statusName,employeeType.employeeType  FROM employee employee LEFT OUTER JOIN employeeType employeeType on employee.employeeTypeID=employeeType.employeeTypeID";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectEmployeeByID(int employeeID)
        {

            try
            {
                str = "SELECT employee.*,IIF (employee.status = true , 'Active' , 'Inactive' ) AS statusName,employeeType.employeeType  FROM employee employee LEFT OUTER JOIN employeeType employeeType on employee.employeeTypeID=employeeType.employeeTypeID WHERE employee.employeeID=@employeeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchEmployee(string keyword)
        {

            try
            {
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex(@"[ ]{2,}", options);
                keyword = regex.Replace(keyword, @" ");
                string[] searchTerms = keyword.Split(' ');
                List<string> searchTermBits = new List<string>();
                foreach (string term in searchTerms)
                {
                    if (!term.Trim().Equals(string.Empty))
                    {
                        searchTermBits.Add("employee.employeeCode LIKE '%" + term + "%'");
                        searchTermBits.Add("employee.idCard LIKE '%" + term + "%'");
                        searchTermBits.Add("employee.firstName LIKE '%" + term + "%'");
                        searchTermBits.Add("employee.lastName LIKE '%" + term + "%'");
                        searchTermBits.Add("employee.username LIKE '%" + term + "%'");
                    }
                }
                str = "SELECT employee.*,IIF (employee.status = true , 'Active' , 'Inactive' ) AS statusName,employeeType.employeeType  FROM employee employee LEFT OUTER JOIN employeeType employeeType on employee.employeeTypeID=employeeType.employeeTypeID ";
                if (searchTermBits.Count != 0)
                {
                    str += " WHERE ";
                    str += String.Join<string>(" OR ", searchTermBits);
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
        public Boolean insertEmployee()
        {
            try
            {
                str = "INSERT INTO employee (employeeTypeID,employeeCode,idCard,[title],firstName,lastName,dob,[department],[position],[address],[phone],[email],[username],[password],[photo],[status])VALUES(@employeeTypeID,@employeeCode,@idCard,@title,@firstName,@lastName,@dob,@department,@position,@address,@phone,@email,@username,@password,@photo,@status);";
                Dbcmd = db.GetSqlStringCommand(str);

                db.AddInParameter(Dbcmd, "@employeeTypeID", DbType.Int32, employeeTypeID);
                db.AddInParameter(Dbcmd, "@employeeCode", DbType.String, employeeCode);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, idCard);
                db.AddInParameter(Dbcmd, "@title", DbType.String, title);
                db.AddInParameter(Dbcmd, "@firstName", DbType.String, firstName);
                db.AddInParameter(Dbcmd, "@lastName", DbType.String, lastName);
                db.AddInParameter(Dbcmd, "@dob", DbType.String, dob.ToString());
                db.AddInParameter(Dbcmd, "@department", DbType.String, department);
                db.AddInParameter(Dbcmd, "@position", DbType.String, position);
                db.AddInParameter(Dbcmd, "@address", DbType.String, address);
                db.AddInParameter(Dbcmd, "@phone", DbType.String, phone);
                db.AddInParameter(Dbcmd, "@email", DbType.String, email);
                db.AddInParameter(Dbcmd, "@username", DbType.String, username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, password);
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
        public Boolean updateEmployee()
        {
            try
            {
                if (!password.Equals(string.Empty))
                {
                    str = "UPDATE employee SET employeeTypeID=@employeeTypeID,idCard=@idCard,[title]=@title,firstName=@firstName,lastName=@lastName,dob=@dob,[department]=@department,[position]=@position,[address]=@address,[phone]=@phone,email=@email,username=@username,[password]=@password,[photo]=@photo,[status]=@status WHERE employeeID=@employeeID;";
                }
                else
                {
                    str = "UPDATE employee SET employeeTypeID=@employeeTypeID,idCard=@idCard,[title]=@title,firstName=@firstName,lastName=@lastName,dob=@dob,[department]=@department,[position]=@position,[address]=@address,[phone]=@phone,email=@email,username=@username,photo=@photo,[status]=@status WHERE employeeID=@employeeID;";
                }
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeTypeID", DbType.Int32, employeeTypeID);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, idCard);
                db.AddInParameter(Dbcmd, "@title", DbType.String, title);
                db.AddInParameter(Dbcmd, "@firstName", DbType.String, firstName);
                db.AddInParameter(Dbcmd, "@lastName", DbType.String, lastName);
                db.AddInParameter(Dbcmd, "@dob", DbType.String, dob.ToString());
                db.AddInParameter(Dbcmd, "@department", DbType.String, department);
                db.AddInParameter(Dbcmd, "@position", DbType.String, position);
                db.AddInParameter(Dbcmd, "@address", DbType.String, address);
                db.AddInParameter(Dbcmd, "@phone", DbType.String, phone);
                db.AddInParameter(Dbcmd, "@email", DbType.String, email);
                db.AddInParameter(Dbcmd, "@username", DbType.String, username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, password);
                db.AddInParameter(Dbcmd, "@photo", DbType.String, photo);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteEmployee(int employeeID)
        {
            try
            {
                str = "DELETE FROM employee WHERE employeeID=@employeeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
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
