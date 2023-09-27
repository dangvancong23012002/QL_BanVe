using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QL_BanVe.cms.Models
{
    public class Phim
    {
        public static DataTable thongTinPhim()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectPhim";
            cmd.CommandType = CommandType.StoredProcedure;
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable thongTinPhimByID(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectPhimByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iPhimID", id);
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable timPhim(string tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_TimPhim";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTuKhoa", tuKhoa);
            return Func.Functions.getDataToTable(cmd);
        }
    }
}