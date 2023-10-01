using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

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
    }
}