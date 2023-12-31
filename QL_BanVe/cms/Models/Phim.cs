﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QL_BanVe.cms.Models
{
    public class Phim
    {
        public static string[] getColumns()
        {
            string[] columns = new string[10] { "PK_iPhimID", "FK_iTheLoaiID", "sTenPhim", "sAnh", "sAnhQuangCao", "dNgayChieu", "sNoiDung", "fGia", "sTrailer", "iThoiLuong" };
            return columns;
        }
        public static DataTable thongTinPhim()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectPhim";
            cmd.CommandType = CommandType.StoredProcedure;
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable thongTinPhimByID(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SelectPhimByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iPhimID", id);
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable timPhim(string tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_TimPhim";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTuKhoa", tuKhoa);
            return Func.Functions.getDataToTable(cmd);
        }

        public static DataTable adminPageGetMovies(int ID = 0, string name = "", int limit = 10, int skip = 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AdminSelectPhim";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PK_iPhimID", ID);
            cmd.Parameters.AddWithValue("@STenPhim", name);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@skip", skip);
            return Func.Functions.getDataToTable(cmd);
        }
        public static string insertMovie(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminCreatePhim";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iPhimID")
                    {
                        return "failed!";
                    }
                    else if (column != "PK_iPhimID")
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            } catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string updateMovie(NameValueCollection data)
        {
            try
            {
                string[] columns = getColumns();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminUpdatePhim";
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (string column in columns)
                {
                    if (String.IsNullOrEmpty(data.Get(column)) && column != "PK_iPhimID")
                    {
                        return "failed!";
                    }
                    else if (column == "PK_iPhimID")
                    {
                        cmd.Parameters.AddWithValue("@PK_iPhimID", Convert.ToInt32(data.Get("id")));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + column, data.Get(column));
                    }
                }
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            }
            catch (Exception ex)
            {
                return "failed";
            }
        }
        public static string deleteMovie(int ID)
        {
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_AdminRemovePhim";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_iPhimID", ID);
                Func.Functions.excuteNonQuery(cmd);
                return "success";
            } catch (Exception ex)
            {
                return "failed";
            }
        }
    }
}