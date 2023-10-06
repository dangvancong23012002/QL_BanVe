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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //Lấy dữ liệu
                string username = Request.Form["input-username"];
                string password = Request.Form["input-password"];

                // Kiểm tra xem database có tài khoản hay không
                DataTable table = new DataTable();
                table = TaiKhoan.thongTinTaiKhoanByTenDN_MK(username, Functions.encrypt(password));
                if (table.Rows.Count > 0)
                {
                    // Đăng nhập thành công -> lưu giá trị vào session
                    Session["DangNhap"] = "1";
                    Session["TenDangNhap"] = table.Rows[0]["sHoTen"];
                    if (table.Rows[0]["sVaiTro"].ToString() == "admin")
                    {
                        Response.Redirect("Admin.aspx");
                    } else
                    {
                        Response.Redirect("Default.aspx");
                    }
                }
                else
                {
                    notice.InnerText = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                }
                //Check rỗng, ..
                bool ck = true;
                if (username == "" && password == "")
                {
                    ck = false;
                }
                else
                {
                    ck = true;
                }

                
                //if (ck)
                //{


                //    bool Trung = false;
                //    foreach (user us in ds) //1 - k trùng 2- trùng 3- k trùng
                //    {
                //        if (username == us.username && password == us.password)
                //        {
                //            Trung = true;
                //            break;
                //        }
                //        else
                //        {
                //            Trung = false;

                //        }

                //    }
                //    if (Trung)
                //    {
                //        Session["daDangNhap"] = 1;
                //        Session["name"] = username;
                //        Response.Redirect("trangchu.aspx");
                //    }
                //    else
                //    {
                //        //messeage.InnerText = "Sai tên đăng nhập hoặc mật khẩu :))";
                //        int soLanDangNhapSai = Int32.Parse(Session["soLanDangNhap"].ToString()) + 1;
                //        Session["soLanDangNhap"] = soLanDangNhapSai;
                //        messeage.InnerText = $"So lan dn sai {Session["soLanDangNhap"].ToString()}";
                //        if (Session["soLanDangNhap"].ToString() == "3")
                //        {
                //            Response.Redirect("trangchu.aspx");
                //        }
                //    }
                //}
            }
        }
    }
}