using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class reservation
    {
        public int reservationID { get; set; }
        public int customerID { get; set; }
        public int employeeID { get; set; }
        public int roomID { get; set; }
        public DateTime checkinDateTime { get; set; }
        public DateTime checkoutDateTime { get; set; }
        public DateTime reservationDateTime { get; set; }
        public int reservationNight { get; set; }
        public int checkinoutStatus { get; set; }
        public bool reservationStatus { get; set; }
        public bool status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public reservation()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 reservationID+1  as lastID FROM reservation ORDER BY reservationID DESC";
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
        public DataSet selectReservationByDate(DateTime today)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE  DateDiff('d',reservation.reservationDateTime, @today)=0 order by reservation.checkinDateTime";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@today", DbType.String, today.ToString());
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectCheckoutToday(DateTime today)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE  DateDiff('d',reservation.checkoutDateTime, @today)=0 order by reservation.checkoutDateTime";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@today", DbType.String, today.ToString());
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectReservationToday(DateTime today)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE  DateDiff('d',reservation.checkinDateTime, @today)=0 order by reservation.checkinDateTime";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@today", DbType.String, today.ToString());
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectReservationByDate(DateTime today,int customerID)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE customer.customerID=@customerID and  DateDiff('d',reservation.reservationDateTime, @today)=0 order by reservation.checkinDateTime";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.AddInParameter(Dbcmd, "@today", DbType.String, today.ToString());
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet searchReservationAvariable(DateTime from, DateTime to, int roomTypeID)
        {

            try
            {
                str = "SELECT room.*,roomType.roomType from (room room";
                str += " left outer join roomType roomType on room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE room.roomTypeID=@roomTypeID  and room.roomID NOT IN (SELECT reservation.roomID FROM reservation reservation WHERE  (reservation.reservationStatus=true and reservation.checkinoutStatus in(0,1)) and ((reservation.checkinDateTime BETWEEN @from AND @to) OR (reservation.checkoutDateTime BETWEEN @from AND @to))) ";
                Dbcmd = db.GetSqlStringCommand(str);
                
                db.AddInParameter(Dbcmd, "@from", DbType.String, from.ToString());
                db.AddInParameter(Dbcmd, "@to", DbType.String, to.ToString());
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int32, roomTypeID);

                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet searchReservationCheckout(string roomCode, int customerID)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE customer.customerID=@customerID and room.roomCode=@roomCode order by reservation.checkoutDateTime";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.AddInParameter(Dbcmd, "@roomCode", DbType.String, roomCode);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet searchReservation(DateTime from, DateTime to, int roomTypeID)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE room.roomTypeID=@roomTypeID and ((reservation.checkinDateTime BETWEEN @from AND @to) OR (reservation.checkoutDateTime BETWEEN @from AND @to))";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int32, roomTypeID);
                db.AddInParameter(Dbcmd, "@from", DbType.String, from.ToString());
                db.AddInParameter(Dbcmd, "@to", DbType.String, to.ToString());
                

                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet searchReservation(DateTime from, DateTime to, int roomTypeID,int customerID)
        {

            try
            {
                str = "SELECT reservation.*,customer.title as customertitle,customer.firstName as customerfirstName,customer.lastName as customerlastName,employee.firstName as employeefirstName,employee.lastName as employeelastName,room.roomCode,room.roomTypeID,room.floor,room.building,roomType.roomType,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName,IIF (reservation.checkinoutStatus = 0 , 'waiting' , IIF(reservation.checkinoutStatus = 1,'Checkin','Checkout')) as checkinoutStatusName";
                str += " FROM ((((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " LEFT OUTER JOIN roomType roomType ON room.roomTypeID=roomType.roomTypeID)";
                str += " WHERE customer.customerID=@customerID and room.roomTypeID=@roomTypeID and ((reservation.checkinDateTime BETWEEN @from AND @to) OR (reservation.checkoutDateTime BETWEEN @from AND @to))";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int32, roomTypeID);
                db.AddInParameter(Dbcmd, "@from", DbType.String, from.ToString());
                db.AddInParameter(Dbcmd, "@to", DbType.String, to.ToString());


                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectReservationByID(int reservationID)
        {

            try
            {
                str = "SELECT reservation.*,IIF (reservation.status = true , 'Active' , 'Inactive' ) AS statusName";
                str += " FROM ((reservation reservation";
                str += " LEFT OUTER JOIN customer customer ON customer.customerID=reservation.customerID)";
                str += " LEFT OUTER JOIN employee employee ON employee.employeeID=reservation.employeeID)";
                str += " LEFT OUTER JOIN room room ON room.roomID=reservation.roomID)";
                str += " WHERE  reservation.reservationID=@reservationID";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean insertReservation()
        {
            try
            {
                str = "INSERT INTO reservation (customerID,employeeID,roomID,checkinDateTime,checkoutDateTime,reservationDateTime,reservationNight,checkinoutStatus,reservationStatus,status)VALUES(@customerID,@employeeID,@roomID,@checkinDateTime,@checkoutDateTime,@reservationDateTime,@reservationNight,@checkinoutStatus,@reservationStatus,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
                db.AddInParameter(Dbcmd, "@roomID", DbType.Int32, roomID);
                db.AddInParameter(Dbcmd, "@checkinDateTime", DbType.String, checkinDateTime);
                db.AddInParameter(Dbcmd, "@checkoutDateTime", DbType.String, checkoutDateTime);
                db.AddInParameter(Dbcmd, "@reservationDateTime", DbType.String, reservationDateTime);
                db.AddInParameter(Dbcmd, "@reservationNight", DbType.Int32, reservationNight);
                db.AddInParameter(Dbcmd, "@checkinoutStatus", DbType.Int32, checkinoutStatus);
                db.AddInParameter(Dbcmd, "@reservationStatus", DbType.Boolean, reservationStatus);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateReservation()
        {
            try
            {
                str = "UPDATE reservation SET customerID=@customerID,employeeID=@employeeID,roomID=@roomID,checkinDateTime=@checkinDateTime,checkoutDateTime=@checkoutDateTime,reservationDateTime=@reservationDateTime,reservationNight=@reservationNight,checkinoutStatus=@checkinoutStatus,reservationStatus=@reservationStatus,status=@status WHERE reservationID=@reservationID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@customerID", DbType.Int32, customerID);
                db.AddInParameter(Dbcmd, "@employeeID", DbType.Int32, employeeID);
                db.AddInParameter(Dbcmd, "@roomID", DbType.Int32, roomID);
                db.AddInParameter(Dbcmd, "@checkinDateTime", DbType.String, checkinDateTime);
                db.AddInParameter(Dbcmd, "@checkoutDateTime", DbType.String, checkoutDateTime);
                db.AddInParameter(Dbcmd, "@reservationDateTime", DbType.String, reservationDateTime);
                db.AddInParameter(Dbcmd, "@reservationNight", DbType.Int32, reservationNight);
                db.AddInParameter(Dbcmd, "@checkinoutStatus", DbType.Int32, checkinoutStatus);
                db.AddInParameter(Dbcmd, "@reservationStatus", DbType.Boolean, reservationStatus);
                db.AddInParameter(Dbcmd, "@status", DbType.Boolean, status);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateReservationCheckin(int reservationID)
        {
            try
            {
                str = "UPDATE reservation SET checkinoutStatus=1 WHERE reservationID=@reservationID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateReservationCheckout(int reservationID)
        {
            try
            {
                str = "UPDATE reservation SET checkinoutStatus=2 WHERE reservationID=@reservationID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteReservation(int reservationID)
        {
            try
            {
                str = "DELETE FROM reservation WHERE reservationID=@reservationID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@reservationID", DbType.Int32, reservationID);
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
