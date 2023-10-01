using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = Request.Params["page"];
            if (page != null) {
                adminContent.Attributes["content"] = page;
            } else
            {
                adminPage_content.InnerHtml = "<div class='empty_page'>Chào mừng đến với màn hình quản trị</div>";
            }
        }
    }
}