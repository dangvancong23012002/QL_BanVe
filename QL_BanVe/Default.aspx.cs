using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //// Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
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
                username.InnerText = "Xin chào " + Session["TenDangNhap"].ToString();
            }
        }
    }
}