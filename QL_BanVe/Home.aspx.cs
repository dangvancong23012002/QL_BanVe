using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe.UI.UI_TrangChu
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadPhim();
        }
        private void loadPhim()
        {
            DataTable table = new DataTable();
            table = cms.Models.Phim.thongTinPhim();
            string html = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {

                html += $"<div class='col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30'>";
                html += $"  <div class='row'>";
                html += $"      <div class='col-lg-16 col-md-16 col-sm-8 col-xs-8'>";
                html += $"          <div class='product-item no-padding'>";
                html += $"              <div class='pi-img-wrapper'>";
                html += $"                  <img class='img-responsive border-radius-20' alt='ảnh' src='{table.Rows[i]["sAnh"]}'>";
                html += $"              </div>";
                html += $"          </div>";
                html += $"      </div>";
                html += $"      <div class='col-lg-16 col-md-16 col-sm-8 col-xs-8'>";
                html += $"          <div class='film-info film-xs-info'>";
                html += $"              <h3 class='text-center text-sm-left text-xs-left bold margin-top-5 font-sm-18 font-xs-14' style='max-height: 30px; min-height: 30px;'><a href ='MovieD.aspx?id={table.Rows[i]["PK_iPhimID"]}'> {table.Rows[i]["sTenPhim"]}</a></h3>";
                html += $"              <ul class='list-unstyled font-lg font-family-san font-sm-15 font-xs-14'>";
                html += $"                  <li style = 'max-height: 50px;'><span class='bold'>Thể loại:</span> {table.Rows[i]["sTenTheLoai"]}</li>";
                html += $"                  <li><span class='bold'>Thời lượng:</span> {table.Rows[i]["iThoiLuong"]} phút</li>";
                html += $"              </ul>";
                html += $"          </div>";
                html += $"      </div>";
                html += $"  </div>";
                html += $"</div>";
            }
            movie.InnerHtml = html;
        }
    }
}