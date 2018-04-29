using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Qystem.Models
{
    public class LoginService
    {
        public Login QsLogin(Login objAdmin)
        {
            //    string sql = "select ChineseName from UserInfo where UserName=@UserName and UserPwd=@UserPwd";



            //    SqlParameter[] para = new SqlParameter[]
            //    {

            //            new SqlParameter("UserName",objAdmin.UserName),
            //            new SqlParameter("UserPwd",objAdmin.UserPwd),
            //            new SqlParameter("ChinesesName",objAdmin.ChineseName)
            //    };
            //    SqlDataReader objReader = SQLHelper.GetReader(sql);

            //    if (objReader.Read())


            //    {
            //        objAdmin.ChineseName = objReader["ChineseName"].ToString();
            //        //objAdmin.AdminName = objReader["AdminName"].ToString();
            //    }
            //    else
            //    {
            //        objAdmin = null;
            //    }
            //    objReader.Close();

            //    return objAdmin;

            //}

            string sql = "select ChineseName from UserInfo where UserName='{0}' and UserPwd='{1}'";
            sql = string.Format(sql, objAdmin.UserName, objAdmin.UserPwd);
            SqlDataReader objReader = SQLHelper.GetReader(sql);

            if (objReader.Read())
            {
                objAdmin.ChineseName = objReader["ChineseName"].ToString();
                //objAdmin.AdminName = objReader["AdminName"].ToString();
            }
            else
            {
                objAdmin = null;
            }
            objReader.Close();

            return objAdmin;

        }
    }
}