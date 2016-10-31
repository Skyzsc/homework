using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 第一次work.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List(int page = 10)
        {
            string[] data = new string[] { "六中全会夯实从严治党政治根基 治国理政",
                                           "解读：加强党内监督如何监督 主要监督谁" ,
                                           "李克强:减税降费同样是积极财政政策 中国经济被看好",
                                           "洪秀柱拜谒中山陵并讲话：国民党坚定反“台独”"};

            ViewBag.data = data;
            ViewBag.Page = page;

            //ViewData["data"] = data;
            //ViewData.Model = data;
            return View();
        }
        /// <summary>
        /// 添加welcome
        /// </summary>
        /// <returns></returns>
        public ActionResult wel()
        {
            return View();
        }
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult add()
        {
            return View();
        }
        /// <summary>
        /// 保存新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }
    }
}