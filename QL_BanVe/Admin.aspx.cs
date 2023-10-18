using Newtonsoft.Json;
using QL_BanVe.cms.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
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
            object role = Session["Role"];
            if (role == null)
            {
                Response.Redirect("Login.aspx");
            }else if (role.ToString() != "admin")
            {
                Response.Redirect("Default.aspx");
            }
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
                handleEndpoint(pathInfo);
            }
        }

        protected void handleEndpoint(string route)
        {
            try
            {
                Response.ContentType = "application/json";
                DataTable dt = new DataTable();
                string ID = Request.Params["id"];
                switch (route)
                {
                    case "/getCategory":
                        dt = TheLoai.adminPageGetCategory(Convert.ToInt32(ID), "", -1, 0);
                        List<TheLoai> lists = new List<TheLoai>();
                        foreach (DataRow row in dt.Rows)
                        {
                            TheLoai cate = new TheLoai((int)row[0], (string)row[1], (string)row[2]);
                            lists.Add(cate);
                        }
                        Response.Write(JsonConvert.SerializeObject(lists));
                        break;
                    case "/getMovie":
                        if (String.IsNullOrEmpty(ID))
                        {
                            dt = Phim.thongTinPhim();
                            Response.Write(JsonConvert.SerializeObject(dt));
                        } else
                        {
                            dt = Phim.thongTinPhimByID(ID);
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        break;
                    case "/getRoom":
                        if (String.IsNullOrEmpty(ID))
                        {
                            dt = Phong.thongTinPhong();
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        else
                        {
                            dt = Phong.thongTinPhongByID(ID);
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        break;
                    case "/getProduct":
                        if (String.IsNullOrEmpty(ID))
                        {
                            dt = DoAn.thongTinDoAn();
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        else
                        {
                            dt = DoAn.thongTinDoAnByID(ID);
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        break;
                    case "/getUser":
                        if (!String.IsNullOrEmpty(ID))
                        {
                            dt = TaiKhoan.thongTinUserByKey(ID);
                            
                            Response.Write(JsonConvert.SerializeObject(dt));
                        }
                        break;
                    case "/handleForm":
                        handleFormData();
                        break;
                    case "/deleteData":
                        handleDeleteData();
                        break;
                    default:
                        Response.StatusCode = 404;
                        Response.Write("Not Found!");
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

        protected void handleDeleteData()
        {
            string ID = Request.Params["ID"];
            if (String.IsNullOrEmpty(ID))
            {
                Response.StatusCode = 401;
                Response.Write("Vui lòng nhập mã!");
                return;
            }
            else
            {
                string page = Request.Params["page"];
                string status = "failed";
                switch (page)
                {
                    case "movie":
                        status = Phim.deleteMovie(Convert.ToInt32(ID));
                        break;
                    case "room":
                        status = Phong.deleteRoom(Convert.ToInt32(ID));
                        break;
                    case "category":
                        status = TheLoai.deleteCategory(Convert.ToInt32(ID));
                        break;
                    case "product":
                        status = DoAn.deleteProduct(Convert.ToInt32(ID));
                        break;
                    case "users":
                        status = TaiKhoan.deleteUser(ID);
                        break;
                    default:
                        break;
                }
                if (status == "failed")
                {
                    Response.StatusCode = 401;
                    status = "Delete Failed!";
                }

                Response.Write(status);
            }
        }
        protected void handleFormData()
        {
            try
            {
                NameValueCollection formData = new NameValueCollection() { Request.Form };
                HttpFileCollection formFiles = Request.Files;
                foreach (string f in formFiles.AllKeys)
                {
                    HttpPostedFile file = formFiles[f];
                    if (file.ContentType.StartsWith("video/"))
                    {
                        file.SaveAs(@"C:\Users\PC\source\repos\QL_BanVe\QL_BanVe\assets\video\" + file.FileName);
                        formData.Set(f, "/assets/video/" + file.FileName);
                    } else
                    {
                        file.SaveAs(@"C:\Users\PC\source\repos\QL_BanVe\QL_BanVe\assets\img\" + file.FileName);
                        formData.Set(f, "/assets/img/" + file.FileName);
                    }
                }

                handleAction(formData);
            } catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.Write("System Error!");
            }
        }

        protected void handleAction(NameValueCollection data)
        {
            try
            {
                string action = Request.Params["action"];
                if (String.IsNullOrEmpty(action) || (action != "create" && action != "update"))
                {
                    Response.StatusCode = 500;
                    Response.Write("Invalid Action!");
                    return;

                }
                string page = Request.Params["page"];
                string status = "failed";
                switch (page)
                {
                    case "movie":
                        if (action == "create")
                        {
                            status = Phim.insertMovie(data);
                        }
                        else
                        {
                            status = Phim.updateMovie(data);
                        }
                        break;
                    case "room":
                        if (action == "create")
                        {
                            status = Phong.insertRoom(data);
                        }
                        else
                        {
                            status = Phong.updateRoom(data);
                        }
                        break;
                    case "category":
                        if (action == "create")
                        {
                            status = TheLoai.insertCategory(data);
                        }
                        else
                        {
                            status = TheLoai.updateCategory(data);
                        }
                        break;
                    case "product":
                        if (action == "create")
                        {
                            status = DoAn.insertProduct(data);
                        }
                        else
                        {
                            status = DoAn.updateProduct(data);
                        }
                        break;
                    case "users":
                        if (action == "create")
                        {
                            status = TaiKhoan.insertUser(data);
                        }
                        else
                        {
                            status = TaiKhoan.updateUser(data);
                        }
                        break;
                    default:
                        Response.StatusCode = 500;
                        Response.Write("Invalid Page!");
                        break;
                }

                if (status == "failed")
                {
                    Response.StatusCode = 500;
                }
                Response.Write(status);
            } catch (Exception e)
            {
                Response.StatusCode = 500;
                Response.Write("System Error!");
            }
        }
    }
}