using ExceptionHandlingMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandlingMVCDemo.Controllers
{
    public class ProductsController : Controller
    {


        public ActionResult Index()
        { 
        
        
        return View();  
        }

        [HttpPost]
        // GET: Products
        //  [HandleError]
        //[HandleError(ExceptionType = typeof(DivideByZeroException),View ="Error")]
        //   [HandleError(ExceptionType = typeof(ArithmeticException), View = "Error1")]
        [MyAppError]
        public ActionResult Index(int a,int b)
        {
            //int a = 10,b=0,c=0;//Divide by zero exception
            int c = a / b;
            //int i = a;
            //float j = b;
            ////int c = j;
            
            return View();
        }

       
        public ActionResult Details()
        {
            string msg=null;
            ViewBag.Message = msg.Length;
            return View();
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    base.OnException(filterContext);
        //    filterContext.ExceptionHandled = true;
        //    filterContext.Result = RedirectToAction("Error", "InternalError");
        //    filterContext.Result = new ViewResult { ViewName = "~/Views/Shared/InternalError.cshtml" };

        //    //or
        //    //string action=filterContext.RouteData.Values["action"].ToString();
        //    //Exception exception = filterContext.Exception;
        //    //filterContext.ExceptionHandled = true;
        //    //filterContext.Result = new ViewResult {ViewName="InternalError" };

        //}
    }
}