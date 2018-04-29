using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace Qystem.Models
{
    public class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["QSystemConnectionString"].ToString();

        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                //将错误信息写入日志
                throw;
            }
        }
    }
}