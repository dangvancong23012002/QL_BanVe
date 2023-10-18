<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MovieDt.aspx.cs" Inherits="QL_BanVe.UI.UI_TrangChu.MovieDetail1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form method="post" id="ctl00" class="content">
        <div class="container">
          <h3 class="margin-bottom-20">Trang chủ &gt; <span class="color1">Biệt Đội Đánh Thuê 4</span></h3>
          <div class="row">
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-16">
              <div class="pi-img-wrapper">
                <img class="img-responsive-detail border-radius-20" style="width: 100%" alt="" src="https://files.betacorp.vn/files/media%2fimages%2f2023%2f09%2f13%2fposter-bddt4-4-2-115332-130923-33.png">
                <span style="position: absolute; top: 10px; left: 10px;">
                  <img src="https://betacinemas.vn/Assets/Common/icons/films/c-18.png" class="img-responsive">
                </span>
              </div>
            </div>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-16 padding-xs-top-15">
              <h1 class="bold no-margin margin-bottom-15">Biệt Đội Đánh Thuê 4</h1>      
              <p class="margin-bottom-15 font-lg font-family-san text-justify">
                Sẵn sàng cho những màn cận chiến nghẹt thở từ “anh trọc” Jason Statham, “già gân” Sylvester Stallone cùng dàn sao mới toanh 50 Cent, Megan Fox và Tony Jaa
              </p>
      
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Đạo diễn: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">Scott Waugh</div>
              </div>
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Diễn viên: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">Jason Statham, 50 Cent, Megan Fox</div>
              </div>
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Thể loại: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">Hành động, Phiêu lưu</div>
              </div>
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Thời lượng: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">103 phút</div>
              </div>
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Ngôn ngữ: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">Tiếng Anh</div>
              </div>
              <div class="row font-lg font-family-san font-xs-14">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                  <span class="bold font-transform-uppercase">
                    Ngày khởi chiếu: </span>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-10">22/09/2023</div>
              </div>
              <div class="text-center padding-bottom-30" style="min-height: 85px; width: 300px;">
                <a style="display: block;" href="#showtimes-pop-up" class="btn btn-2 btn-mua-ve2 fancybox-fast-view"><span><i class="fa fa-ticket mr3"></i></span>
                  MUA VÉ</a>
              </div>
            </div>
          </div>
          <div class="row">
            <!-- TABS -->
            <div class="col-md-16 tab-style-1 margin-bottom-35">      
              <br>
            </div>
            <!-- END TABS -->
          </div>
        </div>
        <div class="fullwidthbanner-container">
          <div class="container">
            <div class="text-center margin-top-20">
              <ul class="nav tab-films">
                <li class="active"><a data-toggle="tab" class="no-padding">
                    <h1 style="color: #fff;" class="bold">TRAILER</h1>
                  </a></li>
              </ul>
            </div>
            <div class="row margin-bottom-20">
              <div class="col-md-12 col-md-offset-2 margin-bottom-35">
                <iframe style="width: 100%; height: 60vh" src="https://www.youtube.com/embed/TixcSyLkznw?rel=0&amp;showinfo=0&amp;autoplay=1" allowfullscreen=""></iframe>
      
              </div>
              <div class="col-md-16 margin-bottom-35">
                <div id="fb-root"></div>
                <script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v18.0" nonce="nRMHh8Ur"></script>
                <div class="fb-comments" data-href="http://127.0.0.1:5500/moviedetail.html" data-width="auto" data-numposts="5"></div>
              </div>
            </div>
          </div>
        </div>
    </form>
</asp:Content>
