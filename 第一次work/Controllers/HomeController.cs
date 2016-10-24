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
        public ActionResult News()
        {
            ViewData["Name"] = "Bruce";
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
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            return View();
        }
    }
}