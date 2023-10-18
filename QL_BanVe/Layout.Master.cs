using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
            {
                loaduser();
            }
            else
            {
                // Nếu chưa đăng nhập -> Đẩy về trang Login.aspx
                //Response.Redirect("Login.aspx");
                loadlogin();
            }
            if (!IsPostBack)
            {
                //username.InnerText = "Xin chào " + Session["TenDangNhap"].ToString();
            }
        }
        private void loadlogin()
        {
            string html = "";
            html += $"<li id = 'BodyContent_ctl00_ctl06_liLogin'><a href = 'Login.aspx'> Đăng nhập </a></li>";
            html += $"<li id = 'BodyContent_ctl00_ctl06_liRegister'><a href = 'Register.aspx'> Đăng ký </a></ li>";
            load.InnerHtml = html;
        }
        private void loaduser()
        {
            string html = "";
            html += $"<li id = 'BodyContent_ctl00_ctl06_liLogin'><a href = '#'> ";            
            load.InnerHtml = html + Session["TenDangNhap"].ToString() + "</a></li>";
        }
    }
}