using Newtonsoft.Json;
using QL_BanVe.cms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_BanVe.UI.UI_TrangAdmin
{
    public partial class adminContent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {  
            string role = Session["Role"].ToString();

            if (role == "admin")
            {
                Init_Page();
            } else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Init_Page()
        {
            try
            {
                string page = Attributes["content"];
                string search = inputKey.Text;
                if (String.IsNullOrEmpty(search))
                {
                    search = "";
                }
                if (page != null)
                {
                    string title = "",
                           placeholder = "",
                           label = "Mã dùng để sửa và xóa và Tên dùng để tìm kiếm";
                    switch (page)
                    {
                        case "movie":
                            title = "Quản lý phim";
                            placeholder = "Mã phim hoặc tên phim";
                            break;
                        case "room":
                            title = "Quản lý phòng chiếu";
                            placeholder = "Mã phòng hoặc tên phòng";
                            break;
                        case "category":
                            title = "Quản lý thể loại";
                            placeholder = "Mã thể loại hoặc tên thể loại";
                            break;
                        case "product":
                            title = "Quản lý sản phẩm";
                            placeholder = "Mã sản phẩm hoặc tên sản phẩm";
                            break;
                        case "users":
                            title = "Quản lý tài khoản";
                            placeholder = "Tên đăng nhập hoặc họ tên";
                            label = "Tên đăng nhập để sửa và xóa, họ tên để search";
                            break;
                        default: break;
                    }
                    adminPage_title.Text = title;
                    inputKey.Attributes["placeholder"] = placeholder;
                    description.Text = label;
                    int skip = Convert.ToInt32(Session[page]);
                    if (skip == 0)
                    {
                        Session.Add(page, 0);
                    }
                    GetDataByPage(page, 0, search, 10, Convert.ToInt32(skip));
                }
            } catch (Exception ex)
            {

            }
        }

        protected void GetDataByPage(string page, int ID = 0, string search = "", int limit = 10, int skip = 0)
        {
            try
            {
                if (String.IsNullOrEmpty(page))
                {
                    return;
                }
                else
                {
                    DataTable dt = new DataTable();
                    switch (page)
                    {
                        case "movie":
                            dt = Phim.adminPageGetMovies(ID, search, limit, skip);
                            break;
                        case "room":
                            dt = Phong.adminPageGetRooms(ID, search, limit, skip);
                            break;
                        case "category":
                            dt = TheLoai.adminPageGetCategory(ID, search, limit, skip);
                            break;
                        case "product":
                            dt = DoAn.adminPageGetProduct(ID, search, limit, skip);
                            break;
                        case "users":
                            dt = TaiKhoan.adminPageGetUsers("", search, limit, skip);
                            break;
                        default: break;
                    }
                    RenderDataToPage(dt, limit, skip);
                }
            } catch (Exception err)
            {
                
            }
        }

        protected void RenderDataToPage(DataTable data, int pageSize = 10, int currentPage = 0)
        {
            try
            {
                if (data == null) { return; }
                string header = "<tr>",
                    body = "";
                double total = 0;
                foreach (DataColumn column in data.Columns)
                {
                    if (column.ColumnName != "total")
                    {
                        header += "<td>" + column.ColumnName + "</td>";
                    }
                }

                foreach (DataRow row in data.Rows)
                {
                    body += "<tr>";
                    foreach (DataColumn column in data.Columns)
                    {
                        if (column.ColumnName == "total")
                        {
                            
                            total = Convert.ToDouble(row["total"]);
                            continue;
                        }
                        String value = row[column.ColumnName].ToString();

                        if (column.DataType.Name == "Double")
                        {
                            value = String.Format(new CultureInfo("vi-VN"), "{0:#,##} VNĐ", row[column.ColumnName]);
                        }

                        if (value.IndexOf("/") >= 0 && value.IndexOf(".") >= 0)
                        {
                            if (value.EndsWith(".mp4"))
                            {
                                body += "<td data-cell='" + column.ColumnName + "'><video width='350' height='150' controls title='" + column.ColumnName + "'><source src='" + value + "' type=\"video/mp4\"></video></td>";
                            }
                            else
                            {
                                body += "<td data-cell='" + column.ColumnName + "'><img src='" + value + "' title='" + column.ColumnName + "'/></td>";
                            }
                        }
                        else
                        {
                            body += "<td ondblclick=\"alert(`" + value.ToString() + "`)\" title='Double click để xem toàn bộ nội dung' data-cell='" + column.ColumnName + "'><span>" + value + "</span></td>";
                        }

                    }
                    body += "</tr>";
                }

                header += "</tr>";
                table_header.InnerHtml = header;
                table_body.InnerHtml = body;
                double totalPage = Math.Ceiling((double)total / (double)pageSize);
                if (totalPage <= 0)
                {
                    totalPage = 1;
                }
                pageControl.Text = "Page " + (currentPage + 1) + " out of " + totalPage;
                currentPage += 1;
                if (currentPage > 1 && currentPage < totalPage)
                {
                    prevPage.Disabled = false;
                    nextPage.Disabled = false;
                } else if (totalPage == 1)
                {
                    prevPage.Disabled = true;
                    nextPage.Disabled = true;
                } else if (currentPage == 1)
                {
                    prevPage.Disabled = true;
                    nextPage.Disabled = false;
                } else if (currentPage == totalPage)
                {
                    prevPage.Disabled = false;
                    nextPage.Disabled = true;
                }
            } catch (Exception ex)
            {

            }
        }

        protected void prevPage_ServerClick(object sender, EventArgs e)
        {
            string page = Attributes["content"];
            int skip = Convert.ToInt32(Session[page]);
            if (skip == 0)
            {
                return;
            }
            skip -= 1;
            Session[page] = skip;
            this.Page_Load(sender, e);
        }

        protected void nextPage_ServerClick(object sender, EventArgs e)
        {
            string page = Attributes["content"];
            int skip = Convert.ToInt32(Session[page]);
            skip += 1;
            Session[page] = skip;
            this.Page_Load(sender, e);
        }
    }
}