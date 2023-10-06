using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
            {
                // Đã đăng nhập
            }
            else
            {
                // Nếu chưa đăng nhập -> Đẩy về trang Login.aspx
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                //username.InnerText = "Xin chào " + Session["TenDangNhap"].ToString();
            }
            loadPhim();
        }

        private void loadPhim()
        {
            DataTable table = new DataTable();
            table = cms.Models.Phim.thongTinPhim();
            string html = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                html += $"<div class='col c-6 l-2-4'>";
                html += $"  <a href='MovieDetail.aspx?id={table.Rows[i]["PK_iPhimID"]}' class='card__item'>";
                html += $"      <div class='card__item-img' style='background-image: url({table.Rows[i]["sAnh"]})'></div>";
                html += $"      <h4 class='card__item-name'>{table.Rows[i]["sTenPhim"]}</h4>";
                html += $"      <div class='card__item-date'>Thời lượng {table.Rows[i]["iThoiLuong"]} phút</div>";
                html += $"  </a>";
                html += $"</div> ";
            }
            list.InnerHtml = html;
        }
    }
}