using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qystem.Models;

namespace Qystem.Controllers
{
    public class CalulatorController : Controller
    {
        // GET: Calulator
        public ActionResult Index()
        {
            return View("MyCal");
        }

        public ActionResult GetAvgScore()
        {
            //【1】获取数据：接收请求数据
            int sumScore = Convert.ToInt32(Request.Params["sumScore"]);
            int sumSubject = Convert.ToInt32(Request.Params["sumSubject"]);
            //【2】业务处理：和Models交互
            Calculator objMyCal = new Calculator();
            int result = objMyCal.GetAvg(sumScore, sumSubject);
            //【3】控制跳转：返回视图或跳转到其他控制器
            ViewData["avgScore"] = "your avgSore:" + result;
            return View("MyCal");
        }
    }
}