using Newtonsoft.Json;
using QL_BanVe.cms.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

            string pathInfo = Request.PathInfo;

            if (string.IsNullOrEmpty(pathInfo))
            {
                string page = Request.Params["page"];
                if (page != null)
                {
                    adminContent.Attributes["content"] = page;
                }
                else
                {
                    adminPage_content.InnerHtml = "<div class='empty_page'>Chào mừng đến với màn hình quản trị</div>";
                }
            } else
            {
                endpointGetData(pathInfo);
            }
        }

        protected void endpointGetData(string route)
        {
            try
            {
                Response.ContentType = "application/json";
                DataTable dt = new DataTable();
                switch (route)
                {
                    case "/getCategory":
                        dt = TheLoai.adminPageGetCategory(0, "", -1, 0);
                        List<TheLoai> lists = new List<TheLoai>();
                        foreach (DataRow row in dt.Rows)
                        {
                            TheLoai cate = new TheLoai((int)row[0], (string)row[1], (string)row[2]);
                            lists.Add(cate);
                        }
                        Response.Write(JsonConvert.SerializeObject(lists));
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.Write("System Error!");
            }
            finally
            {
                Response.End();
            }
        }
    }
}