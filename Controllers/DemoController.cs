using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandlingMVCDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //server is the default location for the cache
        //[OutputCache(Duration =10,Location =System.Web.UI.OutputCacheLocation.Server,VaryByParam ="username")]
     //   [OutputCache(CacheProfile = "profile10")]
        [OutputCache(Duration =int.MaxValue,VaryByParam ="username")]
        public ActionResult Index(string username)
        {
            DateTime dt=GetDateandTime();
            string s = dt.ToLongTimeString();
            ViewBag.datetimeShow = "Hello " + username + " " + s;
            return View();
        }

        [ChildActionOnly]
        public DateTime GetDateandTime()
        {
            DateTime s = DateTime.Now;
            return s;
        }


        //public ActionResult Index()
        //{
        //        string s=DateTime.Now.ToLongTimeString();
        //    ViewBag.datetimeShow = s;
        //    return View();
        //}

    }
}