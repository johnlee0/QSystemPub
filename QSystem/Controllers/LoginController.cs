using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qystem.Models;

namespace Qystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("QsLogin");
        }

        public ActionResult QsLogin()
        {
            //【获取数据】Params后的名称要与视图中的name="UserName"一致。
            string UserName = Request.Params["UserName"];
            string UserPwd = Request.Params["UserPwd"];

            Login objAdmin = new Login()
            {
                UserName = Request.Params["UserName"],
                UserPwd = Request.Params["UserPwd"]
            };
            //【业务处理】
            objAdmin = new LoginService().QsLogin(objAdmin);
            if (objAdmin != null)
            {
                Session[UserName] = 1;
                var fromUrl = Session["FromUrl"];


                ViewData["info"] = "欢迎：" + objAdmin.UserName;

                //if (string.IsNullOrEmpty(fromUrl))  fromUrl = "~/Home/Default";
                //Response.Redirect(fromUrl);
                return View("/Views/Home/Default.cshtml");
            }
            else
            {
                ViewData["info"] = "用户名或密码错误";
            }



            //【返回数据】
            return View();


        }
    }
}