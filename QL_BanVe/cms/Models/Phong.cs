using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections.Specialized;

namespace QL_BanVe.cms.Models
{
    public class Phong
    {
        public static string[] getColumns()
        {
            string[] columns = new string[2] { "PK_iPhongID", "sTenPhong" };
            return columns;
        }
        public static DataTable thongTinPhong()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetAlltblPhong";
            cmd.CommandType = CommandType.StoredProcedure;
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable thongTinPhongByID(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectPhongByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iPhongID", id);
            return Func.Functions.getDataToTable(cmd);
        }
        public static DataTable adminPageGetRooms(int ID = 0, string name = "", int limit = 10, int skip = 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AdminSelectPhong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iPhongID", ID);
            cmd.Parameters.AddWithValue("@sTenPhong", name);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@skip", skip);
            return Func.Functions.getDataToTable(cmd);
        }
        public static string insertRoom(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminCreatePhong";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iPhongID")
                    {
                        return "failed!";
                    }
                    else if (column != "PK_iPhongID")
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string updateRoom(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminUpdatePhong";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iPhongID")
                    {
                        return "failed!";
                    }
                    else if (column == "PK_iPhongID")
                    {
                        cmd.Parameters.AddWithValue("@PK_iPhongID", Convert.ToInt32(data.Get("id")));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string deleteRoom(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminRemovePhong";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_iPhongID", ID);
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
    }
}