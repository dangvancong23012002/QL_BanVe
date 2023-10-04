using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections.Specialized;

namespace QL_BanVe.cms.Models
{
    public class TheLoai
    {
        public int PK_iTheLoaiID { get; set; }
        public string sTenTheLoai { get; set; }
        public string sAnh { get; set; }
        public TheLoai(int id, string name, string image)
        {
            this.PK_iTheLoaiID = id;
            this.sTenTheLoai = name;
            this.sAnh = image;
        }
        public static string[] getColumns()
        {
            string[] columns = new string[3] { "PK_iTheLoaiID", "sTenTheLoai", "sAnh" };
            return columns;
        }
        public static DataTable adminPageGetCategory(int ID = 0, string name = "", int limit = 10, int skip = 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AdminSelectCategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iTheLoaiID", ID);
            cmd.Parameters.AddWithValue("@sTenTheLoai", name);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@skip", skip);
            return Func.Functions.getDataToTable(cmd);
        }
        public static string insertCategory(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminCreateTheLoai";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iTheLoaiID")
                    {
                        return "failed!";
                    }
                    else if (column != "PK_iTheLoaiID")
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
        public static string updateCategory(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminUpdateTheLoai";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iTheLoaiID")
                    {
                        return "failed!";
                    }
                    else if (column == "PK_iTheLoaiID")
                    {
                        cmd.Parameters.AddWithValue("@PK_iTheLoaiID", Convert.ToInt32(data.Get("id")));
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
        public static string deleteCategory(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminRemoveTheLoai";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_iTheLoaiID", ID);
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