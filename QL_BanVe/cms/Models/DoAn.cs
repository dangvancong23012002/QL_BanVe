using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace QL_BanVe.cms.Models
{
    public class DoAn
    {
        public static string[] getColumns()
        {
            string[] columns = new string[4] { "PK_iDoAnID", "sTenDoAn", "fGia", "iSoLuong" };
            return columns;
        }
        public static DataTable thongTinDoAn()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectDoAn";
            cmd.CommandType = CommandType.StoredProcedure;
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable thongTinDoAnByID(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectDoAnByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iDoAnID", id);
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable adminPageGetProduct(int ID = 0, string name = "", int limit = 10, int skip = 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AdminSelectDoAn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iDoAnID", ID);
            cmd.Parameters.AddWithValue("@sTenDoAn", name);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@skip", skip);
            return Func.Functions.getDataToTable(cmd);
        }
        public static string insertProduct(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminCreateDoAn";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iDoAnID")
                    {
                        return "failed!";
                    }
                    else if (column != "PK_iDoAnID")
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
        public static string updateProduct(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminUpdateDoAn";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iDoAnID")
                    {
                        return "failed!";
                    }
                    else if (column == "PK_iDoAnID")
                    {
                        cmd.Parameters.AddWithValue("@PK_iDoAnID", Convert.ToInt32(data.Get("id")));
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
        public static string deleteProduct(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminRemoveDoAn";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_iDoAnID", ID);
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