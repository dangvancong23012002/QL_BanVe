using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe.UI.UI_TrangAdmin
{
    public partial class adminContent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = Attributes["content"];

            if (page != null)
            {
                string title = "",
                       placeholder = "",
                       label = "";
                switch (page)
                {
                    case "movie":
                        title = "Quản lý phim";
                        placeholder = "Mã phim hoặc tên phim";
                        label = "Mã phim dùng để cập nhật và xóa, Tên phim dùng để tìm kiếm";
                        break;
                    case "room":
                        title = "Quản lý phòng chiếu";
                        break;
                    case "category":
                        title = "Quản lý thể loại";
                        break;
                    case "product":
                        title = "Quản lý sản phẩm";
                        break;
                    case "users":
                        title = "Quản lý tài khoản";
                        break;
                    default: break;
                }
                adminPage_title.Text = title;
                inputKey.Attributes["placeholder"] = placeholder;
                description.Text = label;
                prevPage.Attributes["disabled"] = "true";
            }
        }
    }
}