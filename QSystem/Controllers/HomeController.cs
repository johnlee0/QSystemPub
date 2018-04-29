using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QSystem.Models;

namespace Qystem.Controllers
{
    //【1】获取数据：接收请求数据
    //【2】业务处理：和Models交互
    //【3】控制跳转：返回视图或跳转到其他控制器
    public class HomeController : Controller//控制器必须要继承的基类controller
    {
        public ActionResult Index()//控制器中的控制方法，用于响应客户端请求并调用响应的视图向浏览器输出信息。
        {
            // linq  to sql 获取数据
            ServerContractDataContext serverData = new Models.ServerContractDataContext();

            ViewBag.WebApp = serverData.WebSolution.Where(p => p.PrimaryKey == "WebBS" || p.PrimaryKey == "WebSS" || p.PrimaryKey == "WebPS").ToList();
            ViewBag.SQLAurze = serverData.WebSolution.Where(p => p.PrimaryKey == "B" || p.PrimaryKey == "S0" || p.PrimaryKey == "S1").ToList();
            ViewBag.MySql = serverData.WebSolution.Where(p => p.PrimaryKey == "MS1" || p.PrimaryKey == "MS2").ToList();
            ViewBag.Store = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSSmall" || p.PrimaryKey == "BlockBlobLRSmedium").ToList();
            ViewBag.Store2 = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobGRSSmall" || p.PrimaryKey == "BlockBlobGRSmedium").ToList();

            ViewBag.VMBaiscA = serverData.WebSolution.Where(p => p.PrimaryKey == "BasicA1" || p.PrimaryKey == "BasicA2" || p.PrimaryKey == "BasicA3").ToList();
            ViewBag.VMStandardA = serverData.WebSolution.Where(p => p.PrimaryKey == "StanaderA1" || p.PrimaryKey == "StanaderA2" || p.PrimaryKey == "StanaderA3").ToList();
            ViewBag.VMAv2= serverData.WebSolution.Where(p => p.PrimaryKey == "A1_v2" || p.PrimaryKey == "A2_v2" || p.PrimaryKey == "A4_v2").ToList();

            return View();//该方法调用默认视图index（与index()方法同名）
        }

        public ActionResult IndexwebM()
        {
            // linq  to sql 获取数据
            ServerContractDataContext serverData = new Models.ServerContractDataContext();

            ViewBag.WebApp = serverData.WebSolution.Where(p => p.PrimaryKey == "WebBM" || p.PrimaryKey == "WebSM" || p.PrimaryKey == "WebPM").ToList();
            ViewBag.SQLAurze = serverData.WebSolution.Where(p => p.PrimaryKey == "S2" || p.PrimaryKey == "S3" || p.PrimaryKey == "P1").ToList();
            ViewBag.MySql = serverData.WebSolution.Where(p => p.PrimaryKey == "MS3" || p.PrimaryKey == "MS4").ToList();
            ViewBag.Store = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSmedium" || p.PrimaryKey == "BlockBlobLRSLarge").ToList();
            ViewBag.Store2 = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobGRSmedium" || p.PrimaryKey == "BlockBlobGRSLarge").ToList();

            ViewBag.VMStandardA = serverData.WebSolution.Where(p => p.PrimaryKey == "StanaderA4" || p.PrimaryKey == "StanaderA6" || p.PrimaryKey == "StanaderA7").ToList();
            ViewBag.VMAv2 = serverData.WebSolution.Where(p => p.PrimaryKey == "A4_v2" || p.PrimaryKey == "A8_v2" || p.PrimaryKey == "A8m_v2").ToList();
            ViewBag.VMStandardD = serverData.WebSolution.Where(p => p.PrimaryKey == "D3" || p.PrimaryKey == "D4").ToList();
            ViewBag.VMStandardDv2 = serverData.WebSolution.Where(p => p.PrimaryKey == "D3_v2" || p.PrimaryKey == "D4_v2" || p.PrimaryKey == "D5_v2").ToList();

            ViewBag.Redis = serverData.WebSolution.Where(p => p.PrimaryKey == "C1" || p.PrimaryKey == "C2" || p.PrimaryKey == "C3").ToList();

            return View();
        }



        public ActionResult Default()
        {
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult planspricing()
        {
            return View();
        }
        public ActionResult ArchVM()
        {
            return View();
        }

        public ActionResult ArchMedia()
        {

            return View();
        }
        public ActionResult ArchStorage()
        {
            return View();
        }
        public ActionResult ArchCDN()
        {
            return View();
        }
        public ActionResult ArchHDinsight()
        {
            return View();
        }


        public ActionResult PriceVMstd()
        {
            // linq  to sql 获取数据
            ServerContractDataContext serverData = new Models.ServerContractDataContext();

            ViewBag.VMBasicA = serverData.WebSolution.Where(p => p.PrimaryKey == "BasicA0" || p.PrimaryKey == "BasicA1" || p.PrimaryKey == "BasicA2"
            || p.PrimaryKey == "BasicA3" || p.PrimaryKey == "BasicA4").ToList();
            ViewBag.VMStandardA = serverData.WebSolution.Where(p => p.PrimaryKey == "StanaderA0" ||
            p.PrimaryKey == "StanaderA1" || p.PrimaryKey == "StanaderA2" || p.PrimaryKey == "StanaderA3"
            || p.PrimaryKey == "StanaderA4" || p.PrimaryKey == "StanaderA5" || p.PrimaryKey == "StanaderA6" || p.PrimaryKey == "StanaderA7").ToList();
            ViewBag.VMAv2 = serverData.WebSolution.Where(p => p.PrimaryKey == "A1_v2" || p.PrimaryKey == "A2_v2"
            || p.PrimaryKey == "A4_v2" || p.PrimaryKey == "A8_v2").ToList();
            ViewBag.VMStandardD = serverData.WebSolution.Where(p => p.PrimaryKey == "D1" || p.PrimaryKey == "D2" || p.PrimaryKey == "D3" || p.PrimaryKey == "D4").ToList();
            ViewBag.VMStandardDv2 = serverData.WebSolution.Where(p => p.PrimaryKey == "D1_v2" || p.PrimaryKey == "D2_v2" || p.PrimaryKey == "D3_v2" || p.PrimaryKey == "D4_v2" || p.PrimaryKey == "D5_v2").ToList();
            return View();
        }
        public ActionResult PriceVMcalcu()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.VMF = serverData.WebSolution.Where(p => p.PrimaryKey == "F1" || p.PrimaryKey == "F2"
           || p.PrimaryKey == "F4" || p.PrimaryKey == "F8" || p.PrimaryKey == "F16").ToList();
            return View();
        }
        public ActionResult PriceVMio()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.DS = serverData.WebSolution.Where(p => p.PrimaryKey == "DS1_V2" || p.PrimaryKey == "DS2_V2"
           || p.PrimaryKey == "DS3_V2" || p.PrimaryKey == "DS4_V2" || p.PrimaryKey == "DS5_V2").ToList();
            return View();
        }
        public ActionResult PriceVMram()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.DS = serverData.WebSolution.Where(p => p.PrimaryKey == "DS11_V2" || p.PrimaryKey == "DS12_V2"
           || p.PrimaryKey == "DS13_V2" || p.PrimaryKey == "DS14_V2" || p.PrimaryKey == "DS15_V2").ToList();
            ViewBag.VMAv2m = serverData.WebSolution.Where(p => p.PrimaryKey == "A2m_v2" || p.PrimaryKey == "A4m_v2"
           || p.PrimaryKey == "A8m_v2").ToList();
            ViewBag.VMStandardD = serverData.WebSolution.Where(p => p.PrimaryKey == "D11" || p.PrimaryKey == "D12" || p.PrimaryKey == "D13" 
            || p.PrimaryKey == "D14").ToList();
            ViewBag.VMStandardDv2 = serverData.WebSolution.Where(p => p.PrimaryKey == "D11_v2" || p.PrimaryKey == "D12_v2" 
            || p.PrimaryKey == "D13_v2" || p.PrimaryKey == "D14_v2" || p.PrimaryKey == "D15_v2").ToList();

            return View();
        }
        public ActionResult PriceStorageStd()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.StorageBlcokBlob = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSSmall" || p.PrimaryKey == "BlockBlobLRSmedium"
            || p.PrimaryKey == "BlockBlobLRSLarge" || p.PrimaryKey == "BlockBlobGRSSmall" || p.PrimaryKey == "BlockBlobGRSmedium" || p.PrimaryKey == "BlockBlobGRSLarge").ToList();

            ViewBag.StoragePageBlob = serverData.WebSolution.Where(p => p.PrimaryKey == "PageBlobLRSSmall" || p.PrimaryKey == "PageBlobLRSmedium"
          || p.PrimaryKey == "PageBlobLRSLarge" || p.PrimaryKey == "PageBlobLRSXLarge" || p.PrimaryKey == "PageBlobLRSXXLarge" || p.PrimaryKey == "PageBlobLRSXXLarge"
          || p.PrimaryKey == "PageBlobGRSSmall"
          || p.PrimaryKey == "PageBlobGRSmedium" || p.PrimaryKey == "PageBlobGRSLarge" || p.PrimaryKey == "PageBlobGRSXLarge" || p.PrimaryKey == "PageBlobGRSXXLarge").ToList();

            ViewBag.StorageTable = serverData.WebSolution.Where(p => p.PrimaryKey == "TableLRSSmall" || p.PrimaryKey == "TableLRSmedium" || p.PrimaryKey == "TableLRSLarge"
            || p.PrimaryKey == "TableGRSSmall" || p.PrimaryKey == "TableGRSmedium"
            || p.PrimaryKey == "TableGRSLarge").ToList();

            ViewBag.StorageQueue = serverData.WebSolution.Where(p => p.PrimaryKey == "QueueLRSsmall" || p.PrimaryKey == "QueueLRSmedium" || p.PrimaryKey == "QueueLRSLarge"
            || p.PrimaryKey == "QueueGRSSmall" || p.PrimaryKey == "QueueGRSmedium"
            || p.PrimaryKey == "QueueGRSLarge").ToList();

            ViewBag.StorageDocument = serverData.WebSolution.Where(p => p.PrimaryKey == "DocumentLRS" || p.PrimaryKey == "DocumentGRS").ToList();

            ViewBag.PremiumPageBlob = serverData.WebSolution.Where(p => p.PrimaryKey == "PremiumPageBlobP10" || p.PrimaryKey == "PremiumPageBlobP20" || p.PrimaryKey == "PremiumPageBlobP30").ToList();

            return View();
        }
        public ActionResult PriceStorageBlob()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.BlockBlobBEcold = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSCold" || p.PrimaryKey == "BlockBlobGRSCold").ToList();

            ViewBag.BlockBlobBEhot = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSHot" || p.PrimaryKey == "BlockBlobGRSHot").ToList();

            return View();
        }

        public ActionResult PriceCDN()
        {
            ServerContractDataContext serverData = new Models.ServerContractDataContext();
            ViewBag.cdnS = serverData.WebSolution.Where(p => p.PrimaryKey == "CDN010s" || p.PrimaryKey == "CDN1050s" || p.PrimaryKey == "CDN1050s" || p.PrimaryKey == "CDN50100s"
            || p.PrimaryKey == "CDN100PLUSs" ).ToList();

            ViewBag.cdnP = serverData.WebSolution.Where(p => p.PrimaryKey == "CDN010p" || p.PrimaryKey == "CDN1050p" || p.PrimaryKey == "CDN1050p" || p.PrimaryKey == "CDN50100p"
            || p.PrimaryKey == "CDN100PLUSp").ToList();


            ViewBag.BlockBlobBEcold = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSCold" || p.PrimaryKey == "BlockBlobGRSCold").ToList();

            ViewBag.BlockBlobBEhot = serverData.WebSolution.Where(p => p.PrimaryKey == "BlockBlobLRSHot" || p.PrimaryKey == "BlockBlobGRSHot").ToList();

            return View();
        }


    }
}