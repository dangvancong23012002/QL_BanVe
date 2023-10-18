<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QL_BanVe.UI.UI_TrangChu.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="margin-none">
        <!--//--- Banner ---//-->
        <div id="BodyContent_ctl00_sliderPanel" class="ecm-panel sliderpanel">
          <!-- BEGIN SLIDER -->
          <div class="page-slider margin-bottom-35">
            <div id="myCarousel" class="carousel slide" data-interval="3000" data-ride="carousel">
              <!-- Indicators -->
              <ol class="carousel-indicators">
      
                <li data-target="#myCarousel" data-slide-to="0" class=""></li>
      
                <li data-target="#myCarousel" data-slide-to="1" class=""></li>
      
                <li data-target="#myCarousel" data-slide-to="2" class=""></li>
      
                <li data-target="#myCarousel" data-slide-to="3" class=""></li>
      
                <li data-target="#myCarousel" data-slide-to="4" class="active"></li>
      
              </ol>
      
              <!-- Wrapper for slides -->
              <div class="carousel-inner">
      
                <div class="item">
                  <a href="https://betacinemas.vn/khuyen-mai-moi/trung-thu-xap-xinh-uu-dai-het-minh.htm">
                      <img src="https://files.betacorp.vn/files/ecm/2023/09/22/untitled-2-095758-220923-79.jpg" alt="" style="width:100%;">
                  </a>
                </div>
      
                <div class="item">
                  <a href="https://betacinemas.vn/khuyen-mai-moi/trung-thu-xap-xinh-uu-dai-het-minh.htm">
                      <img src="https://files.betacorp.vn/files/ecm/2023/09/22/untitled-2-095758-220923-79.jpg" alt="" style="width:100%;">
                  </a>
                </div>

                <div class="item">
                  <a href="https://betacinemas.vn/khuyen-mai-moi/trung-thu-xap-xinh-uu-dai-het-minh.htm">
                      <img src="https://files.betacorp.vn/files/ecm/2023/09/22/untitled-2-095758-220923-79.jpg" alt="" style="width:100%;">
                  </a>
                </div>

                  <div class="item">
                  <a href="https://betacinemas.vn/khuyen-mai-moi/trung-thu-xap-xinh-uu-dai-het-minh.htm">
                      <img src="https://files.betacorp.vn/files/ecm/2023/09/22/untitled-2-095758-220923-79.jpg" alt="" style="width:100%;">
                  </a>
                </div>

                <div class="item active">
                  <a href="https://betacinemas.vn/khuyen-mai-moi/trung-thu-xap-xinh-uu-dai-het-minh.htm">
                      <img src="https://files.betacorp.vn/files/ecm/2023/09/22/untitled-2-095758-220923-79.jpg" alt="" style="width:100%;">
                  </a>
                </div>
      
              </div>
      
              <!-- Left and right controls -->
              <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <i class="fa-solid fa-chevron-left"></i>
                <span class="sr-only">Previous</span>
              </a>
              <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <i class="fa-solid fa-chevron-right"></i>
                <span class="sr-only">Next</span>
              </a>
            </div>
            <!-- LayerSlider start -->
      
            <!-- LayerSlider end -->
          </div>
          <!-- END SLIDER -->
        </div>
        <!-- Main content -->
        <div id="BodyContent_ctl00_mainPanel" class="ecm-panel" style="position: relative;">
      
          <form method="post" action="./home.htm?url=home.htm" id="ctl00">
            
            <div class="container">
              <div class="margin-bottom-35">
                <div class="text-center">
                  <ul class="nav nav-tabs tab-films">
                    <li class="active"><a href="#tab-1" data-toggle="tab" id="dangchieu">
                      <h1 class="font-30 font-sm-15 font-xs-12">
                        PHIM ĐANG CHIẾU</h1>
                    </a></li>
                    <li><a href="#tab-2" data-toggle="tab" id="sapchieu">
                        <h1 class="font-30 font-sm-15 font-xs-12">
                          PHIM SẮP CHIẾU</h1>
                      </a></li>
                  </ul>
                </div>
                <div class="tab-content">
                  <div class="tab-pane fade in active" id="tab-1">
                    <div class="row" id="movie" runat="server">



                    </div>
                  </div>
                  <div class="tab-pane fade" id="tab-2">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30 col-588 col-sm-255 col-xs-255">
                          <div class="row">
                            <div class="col-lg-16 col-md-16 col-sm-8 col-xs-8">
                              <div class="product-item no-padding">
                                <div class="pi-img-wrapper"><img class="img-responsive border-radius-20" alt="" src="https://files.betacorp.vn/files/media%2fimages%2f2023%2f09%2f22%2fbatman-begins-poster-release-date-114902-220923-31.png"><span style="position: absolute;top: 10px;left: 10px;"><img src="https://betacinemas.vn/Assets/Common/icons/films/c-13.png" class="img-responsive"></span>
                                  <div class="border-radius-20"><a href="#product-pop-up" class="fancybox-fast-view"><i class="fa fa-play-circle"></i></a></div>
                                </div>
                              </div>
                            </div>
                            <div class="col-lg-16 col-md-16 col-sm-8 col-xs-8">
                              <div class="film-info film-xs-info">
                                <h3 class="text-center text-sm-left text-xs-left bold margin-top-5 font-sm-18 font-xs-14" style="max-height: 30px; min-height: 30px;"><a href="/chi-tiet-phim.htm?gf=041475ea-5dff-4f2a-a6a1-9a1dac68fa64">Người Dơi Bắt Đầu</a></h3>
                                <ul class="list-unstyled font-lg font-family-san font-sm-15 font-xs-14">
                                  <li style="max-height: 50px;"><span class="bold">Thể loại:</span> Hành động</li>
                                  <li><span class="bold">Thời lượng:</span> 140 phút</li>
                                  <li><span class="bold">Ngày khởi chiếu:</span> <span class="font-family-oswa color1">27/09/2023</span></li>
                                </ul>
                              </div>
                              <div class="text-center padding-bottom-30" style="min-height: 110px;"><a style="display: none;" href="#showtimes-pop-up" class="btn btn-2 btn-mua-ve2 fancybox-fast-view"><span><i class="fa fa-ticket mr3"></i></span>MUA VÉ</a></div>
                            </div>
                          </div>
                        </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </form>
          <!-- BEGIN fast view of a product -->
        </div>
    </div>
</asp:Content>
