using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe.UI.UI_TrangChu
{
    public partial class MovieDetail1 : System.Web.UI.Page
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
            if (table.Rows.Count > 0)
            {
                html += $"<form method = 'post' id = 'ctl00' class='content' >";
                html += $"<div class='container'>";
                html += $"<h3 class='margin-bottom-20'>Trang chủ &gt; <span class='color1'>Biệt Đội Đánh Thuê 4</span></h3>";
                html += $"<div class='row'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-16'>";
                html += $"<div class='pi-img-wrapper'>";
                html += $"<img class='img-responsive-detail border-radius-20' style='width: 100%' alt='' src='https://files.betacorp.vn/files/media%2fimages%2f2023%2f09%2f13%2fposter-bddt4-4-2-115332-130923-33.png'>";
                html += $"<span style = 'position: absolute; top: 10px; left: 10px;' >";
                html += $"< img src='https://betacinemas.vn/Assets/Common/icons/films/c-18.png' class='img-responsive'>";
                html += $"</span>";
                html += $"</div>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-16 padding-xs-top-15'>";
                html += $"<h1 class='bold no-margin margin-bottom-15'>Biệt Đội Đánh Thuê 4</h1>";
                html += $"<p class='margin-bottom-15 font-lg font-family-san text-justify'>Sẵn sàng </p>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Đạo diễn</span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>Scott Waugh</div>";
                html += $"</div>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Diễn viên</span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>Jason Statham, 50 Cent, Megan Fox</div>";
                html += $"</div>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Thể loại: </span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>Hành động, Phiêu lưu</div>";
                html += $"</div>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Thời lượng: </span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>103 phút</div>";
                html += $"</div>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Ngôn ngữ: </span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>Tiếng Anh</div>";
                html += $"</div>";
                html += $"<div class='row font-lg font-family-san font-xs-14'>";
                html += $"<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>";
                html += $"<span class='bold font-transform-uppercase'>Ngày khởi chiếu: </span>";
                html += $"</div>";
                html += $"<div class='col-lg-12 col-md-12 col-sm-12 col-xs-10'>22/09/2023</div>";
                html += $"</div>";
                html += $"<div class='text-center padding-bottom-30' style='min-height: 85px; width: 300px;'>";
                html += $"<a style = 'display: block;' href='#showtimes-pop-up' class='btn btn-2 btn-mua-ve2 fancybox-fast-view'><span><i class='fa fa-ticket mr3'></i></span>MUA VÉ</a>";
                html += $"</div>";
                html += $"</div>";
                html += $"</div>";
                html += $"<div class='row'>";
                html += $"<div class='col-md-16 tab-style-1 margin-bottom-35'><br>";
                html += $"</div>";
                html += $"</div>";
                html += $"</div>";
                html += $"<div class='fullwidthbanner-container'>";
                html += $"<div class='container'>";
                html += $"<div class='text-center margin-top-20'>";
                html += $"<ul class='nav tab-films'>";
                html += $"<li class='active'><a data-toggle='tab' class='no-padding'>";
                html += $"<h1 style = 'color: #fff;' class='bold'>TRAILER</h1>";
                html += $"</a></li>";
                html += $"</ul>";
                html += $"</div>";
                html += $"<div class='row margin-bottom-20'>";
                html += $"<div class='col-md-12 col-md-offset-2 margin-bottom-35'>";
                html += $"<iframe style = 'width: 100%; height: 60vh' src='https://www.youtube.com/embed/TixcSyLkznw?rel=0&amp;showinfo=0&amp;autoplay=1' allowfullscreen=''></iframe>";
                html += $"</div>";
                html += $"<div class='col-md-16 margin-bottom-35'>";
                html += $"<div id = 'fb-root' ></ div >";
                html += $"< script async defer crossorigin = 'anonymous' src='https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v18.0' nonce='nRMHh8Ur'></script>";
                html += $"<div class='fb-comments' data-href='http://127.0.0.1:5500/moviedetail.html' data-width='auto' data-numposts='5'></div>";
                html += $"</div>";
                html += $"</div>";
                html += $"</div>";
                html += $"</div>";
                html += $"</form>";
                moviedetail.InnerHtml = html;
            }
        }
    }
}