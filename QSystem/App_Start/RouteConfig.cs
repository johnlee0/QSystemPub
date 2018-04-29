using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Qystem
{
    public class RouteConfig
    {
        //注册路由的静态方法（分配用户的请求地址，总机或前台接待室）
        //Gittest
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//忽略不需要处理的特定请求

            routes.MapRoute(//
                name: "Default",
                url: "{controller}/{action}/{id}",//定义url规则，控制器+控制方法+ID
                                                  //defaults: new { controller = "Home", action = "Default", id = UrlParameter.Optional }

               defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }


            );
        }
    }
}
