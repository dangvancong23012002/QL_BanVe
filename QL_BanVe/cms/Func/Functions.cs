using QL_BanVe.cms.Conn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace QL_BanVe.cms.Func
{
    public class Functions
    {
        public static DataTable getDataToTable(SqlCommand cmd)
        {

            DataTable table = new DataTable();
            using (SqlConnection conn = SQLDatabase.getConnection())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return table;
        }

        public static DataSet getData_OverDataSet(SqlCommand cmd)
        {
            DataSet dataSet = new DataSet();
            if (cmd.Connection != null)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataSet);
                }
            }
            else
            {
                using (SqlConnection conn = SQLDatabase.getConnection())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        using (DataSet data = new DataSet())
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(data);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Open();
                    }
                }
            }
            return dataSet;
        }

        public static void excuteNonQuery(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                using (SqlConnection conn = SQLDatabase.getConnection())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool checkKey(string sql)
        {
            using (SqlConnection conn = SQLDatabase.getConnection())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        #region Mã hoá mật khẩu
        public static string encrypt(string decrypted)
        {
            string hash = "cong@gmail.com";
            byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }
        #endregion

        #region Giải mã mật khẩu
        public static string decrypt(string encrypted)
        {
            string hash = "cong@gmail.com";
            byte[] data = Convert.FromBase64String(encrypted);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }
        #endregion
    }
}