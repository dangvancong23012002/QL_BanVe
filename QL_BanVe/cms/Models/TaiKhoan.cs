using QL_BanVe.cms.Func;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using QL_BanVe.cms.Func;
using System.Collections.Specialized;

namespace QL_BanVe.cms.Models
{
    public class TaiKhoan
    {
        public static string[] getColumns()
        {
            string[] columns = new string[5] { "PK_sTenDangNhap", "sMatKhau", "sHoTen", "sSoDienThoai", "sVaiTro" };
            return columns;
        }
        public static DataTable thongTinTaiKhoanByTenDN_MK(string tenDN, string matKhau)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ThongTinTaiKhoanByTenDN_MK";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_sTenDangNhap", tenDN);
            cmd.Parameters.AddWithValue("@sMatKhau", matKhau);
            return Functions.getDataToTable(cmd);
        }

        public static void insertTaiKhoan(string tenDN, string matKhau, string hoTen, string dienThoai, string vaiTro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InsertTaiKhoan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_sTenDangNhap", tenDN);
            cmd.Parameters.AddWithValue("@sMatKhau", matKhau);
            cmd.Parameters.AddWithValue("@sHoTen", hoTen);
            cmd.Parameters.AddWithValue("@sDienThoai", dienThoai);
            cmd.Parameters.AddWithValue("@sVaiTro", vaiTro);
            Functions.excuteNonQuery(cmd);
        }
        public static DataTable thongTinUserByKey(string key)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectTaiKhoanByTenDN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_sTenDangNhap", key);
            DataTable dt = Functions.getDataToTable(cmd);
            
            foreach (DataRow row in dt.Rows)
            {
                string value = row["sMatKhau"].ToString();
                if (!String.IsNullOrEmpty(value))
                {
                    row.SetField("sMatKhau", Functions.decrypt(value));
                }
            }
            return dt;
        }
        public static DataTable adminPageGetUsers(string ID = "", string name = "", int limit = 10, int skip = 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AdminSelectTaiKhoan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_sTenDangNhap", ID);
            cmd.Parameters.AddWithValue("@sHoTen", name);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@skip", skip);
            return Func.Functions.getDataToTable(cmd);
        }
        public static string insertUser(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_InsertTaiKhoan";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)))
                    {
                        return "failed!";
                    }
                    else if (column == "PK_sTenDangNhap")
                    {
                        cmd.Parameters.AddWithValue("@PK_sTenTaiKhoan", data.Get(column));
                    }
                    else if (column == "sSoDienThoai")
                    {
                        cmd.Parameters.AddWithValue("@sDienThoai", data.Get(column));
                    }
                    else if (column == "sMatKhau")
                    {
                        string value = data.Get(column);
                        value = Functions.encrypt(value);
                        cmd.Parameters.AddWithValue("@" + column, value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string updateUser(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminUpdateTaiKhoan";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_sTenDangNhap")
                    {
                        return "failed!";
                    }
                    else if (column == "sMatKhau")
                    {
                        string value = data.Get(column);
                        value = Functions.encrypt(value);
                        cmd.Parameters.AddWithValue("@" + column, value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string deleteUser(string tenDN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminRemoveTaiKhoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_sTenDangNhap", tenDN);
                Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
    }
}