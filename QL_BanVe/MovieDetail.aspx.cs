using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using QL_BanVe.cms;

namespace QL_BanVe
{
    public partial class MovieDetail : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Request.QueryString["id"];
            }
            thongTinPhim(id);
        }

        private void thongTinPhim(string id)
        {
            DataTable table = new DataTable();
            table = cms.Models.Phim.thongTinPhimByID(id);
            string html = "";
            if (table.Rows.Count > 0 )
            {
                html += $"  <div class='row'>";
                html += $"      <div class='col l-10'>";
                html += $"          <div class='row row-pad'>";
                html += $"              <div class='col l-4'>";
                html += $"                  <img src = '{table.Rows[0]["sAnh"]}' class='detail__img' />";
                html += $"              </div>";
                html += $"              <div class='col l-8'>";
                html += $"                  <div class='detail__content'>";
                html += $"                      <div class='detail__name-movie'>{table.Rows[0]["sTenPhim"]}</div>";
                html += $"                      <div class='detail__cost'>Giá vé: {table.Rows[0]["fGia"]} VNĐ</div>";
                html += $"                      <div class='detail__category'>Thể loại: {table.Rows[0]["sTenTheLoai"]}</div>";
                html += $"                      <div class='detail__calendar'>Khởi chiếu: {Convert.ToDateTime(table.Rows[0]["dNgayChieu"]).ToString("dd/MM/yyyy")}</div>";
                html += $"                      <div class='detail__time'>Thời lượng: {table.Rows[0]["iThoiLuong"]} phút</div>";
                html += $"                      <div class=''>Nội dung</div>";
                html += $"                          <div class='detail__box-info'>";
                html += $"                              <div class='detail__desc'>{table.Rows[0]["sNoiDung"]}</div>";
                html += $"                          </div>";
                html += $"                  </div>";
                html += $"              </div>";
                html += $"          </div>";
                html += $"      </div>";
                html += $"      <div class='col l-2'></div>";
                html += $"  </div>";
                html += $"  <div class='detail__trailer row-10px'>";
                html += $"      <div> Trailer</div>";
                html += $"      <video controls = 'controls'>";
                html += $"          <source src='{table.Rows[0]["sTrailer"]}' type='video/mp4' />";
                html += $"      </video>";
                html += $" </div>";
                detail.InnerHtml = html;   
            }
        }
    }
}