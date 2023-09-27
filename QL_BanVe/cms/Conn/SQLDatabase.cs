using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QL_BanVe.cms.Conn
{
    public class SQLDatabase
    {
        public static string strConnection = ConfigurationManager.ConnectionStrings["ql_banvephim"].ConnectionString;
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}