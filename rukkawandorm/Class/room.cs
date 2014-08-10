using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Text.RegularExpressions;
using System.Collections;


namespace rukkawandorm.Class
{
    class room
    {
        public int roomID { get; set; }
        public string roomCode { get; set; }
        public string roomName { get; set; }
        public int roomTypeID { get; set; }
        public string detail { get; set; }
        public string floor { get; set; }
        public string building { get; set; }
        public string remark { get; set; }
        public string status { get; set; }

        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public room()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public int getLastID()
        {
            str = "SELECT TOP 1 roomID+1  as lastID FROM room ORDER BY roomID DESC";
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
        public DataSet selectAllRoom()
        {

            try
            {
                str = "SELECT room.*,roomType.roomType,roomType.price  FROM room room LEFT OUTER JOIN roomType roomType on room.roomTypeID=roomType.roomTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectRoomByID(int roomID)
        {

            try
            {
                str = "SELECT room.*,roomType.roomType,roomType.price  FROM room room LEFT OUTER JOIN roomType roomType on room.roomTypeID=roomType.roomTypeID WHERE room.roomID=@roomID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomID", DbType.Int32, roomID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchRoom(string keyword)
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
                        searchTermBits.Add("room.roomCode LIKE '%" + term + "%'");
                        searchTermBits.Add("room.roomName LIKE '%" + term + "%'");
                        searchTermBits.Add("room.floor LIKE '%" + term + "%'");
                        searchTermBits.Add("room.building LIKE '%" + term + "%'");
                        searchTermBits.Add("room.remark LIKE '%" + term + "%'");
                    }
                }
                str = "SELECT room.*,roomType.roomType,roomType.price  FROM room room LEFT OUTER JOIN roomType roomType on room.roomTypeID=roomType.roomTypeID ";
                if (searchTermBits.Count != 0)
                {
                    str += " WHERE ";
                    str += string.Join(" OR ", searchTermBits.ToArray(typeof(string)) as string[]);
                }
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertRoom()
        {
            try
            {
                str = "INSERT INTO room (roomCode,roomName,roomTypeID,[detail],floor,building,[remark],[status])VALUES(@roomCode,@roomName,@roomTypeID,@detail,@floor,@building,@remark,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomCode", DbType.String, roomCode);
                db.AddInParameter(Dbcmd, "@roomName", DbType.String, roomName);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int16, roomTypeID);
                db.AddInParameter(Dbcmd, "@detail", DbType.String, detail);
                db.AddInParameter(Dbcmd, "@floor", DbType.String, floor);
                db.AddInParameter(Dbcmd, "@building", DbType.String, building);
                db.AddInParameter(Dbcmd, "@remark", DbType.String, remark);
                db.AddInParameter(Dbcmd, "@status", DbType.String, status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateRoom()
        {
            try
            {
                str = "UPDATE room SET roomCode=@roomCode,roomName=@roomName,roomTypeID=@roomTypeID,[detail]=@detail,floor=@floor,building=@building,[remark]=@remark,[status]=@status WHERE roomID=@roomID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomCode", DbType.String, roomCode);
                db.AddInParameter(Dbcmd, "@roomName", DbType.String, roomName);
                db.AddInParameter(Dbcmd, "@roomTypeID", DbType.Int16, roomTypeID);
                db.AddInParameter(Dbcmd, "@detail", DbType.String, detail);
                db.AddInParameter(Dbcmd, "@floor", DbType.String, floor);
                db.AddInParameter(Dbcmd, "@building", DbType.String, building);
                db.AddInParameter(Dbcmd, "@remark", DbType.String, remark);
                db.AddInParameter(Dbcmd, "@status", DbType.String, status);
                db.AddInParameter(Dbcmd, "@roomID", DbType.Int16, roomID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteRoom(int roomID)
        {
            try
            {
                str = "DELETE FROM room WHERE roomID=@roomID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@roomID", DbType.Int32, roomID);
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
