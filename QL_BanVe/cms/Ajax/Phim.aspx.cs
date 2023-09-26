using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe.cms.Ajax
{
    public partial class Phim : System.Web.UI.Page
    {
        string thaoTac = "", tuKhoa = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["thaoTac"] != null)
            {
                thaoTac = Request.Params["thaoTac"];
            }
            if (Request.Params["tuKhoa"] != null)
            {
                tuKhoa = Request.Params["tuKhoa"];
            }
            switch (thaoTac)
            {
                case "hienThi":
                    thongTinPhim();
                    break;
                case "tim":
                    timPhim(tuKhoa);
                    break;
            }
        }

        private void thongTinPhim()
        {
            DataTable table = new DataTable();
            table = Models.Phim.thongTinPhim();
            if (table.Rows.Count > 0)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
                Response.Write(json);
                Response.End();
                Response.Flush();
            } else
            {
                Response.Write("Không có dữ liệu!");
                Response.End();
                Response.Flush();
            }
        }

        private void timPhim(string tuKhoa)
        {
            DataTable table = new DataTable();
            table = Models.Phim.timPhim(tuKhoa);
            if (table.Rows.Count > 0)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
                Response.Write(json);
                Response.End();
                Response.Flush();
            } else
            {
                Response.Write("Không tìm thấy!");
                Response.End();
                Response.Flush();
            }
        }
    }
}