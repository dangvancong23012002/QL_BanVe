using QL_BanVe.cms.Func;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using QL_BanVe.cms.Func;

namespace QL_BanVe.cms.Models
{
    public class TaiKhoan
    {
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
            cmd.Parameters.AddWithValue("@PK_sTenTaiKhoan", tenDN);
            cmd.Parameters.AddWithValue("@sMatKhau", matKhau);
            cmd.Parameters.AddWithValue("@sHoTen", hoTen);
            cmd.Parameters.AddWithValue("@sDienThoai", dienThoai);
            cmd.Parameters.AddWithValue("@sVaiTro", vaiTro);
            Functions.excuteNonQuery(cmd);
        }
    }
}