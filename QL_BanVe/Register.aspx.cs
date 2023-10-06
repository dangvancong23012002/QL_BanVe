using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QL_BanVe.cms.Models;
using QL_BanVe.cms.Func;

namespace QL_BanVe
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form["input-username"];
                string fullname = Request.Form["input-email"];
                string password = Request.Form["input-password"];
                if (Functions.checkKey("select * from tblTaiKhoan where PK_sTenDangNhap = '" + username + "'"))
                {
                    notice.InnerText = "Tên đăng nhập " + username + " đã tồn tại!";
                } else
                {
                    TaiKhoan.insertTaiKhoan(username, Functions.encrypt(password), fullname, "123456789", "user");
                    notice.InnerText = "Chúc mừng bạn đã tạo tài khoản " + username + " thành công!";
                }
            }
        }
    }
}