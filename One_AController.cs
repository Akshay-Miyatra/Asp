using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignamnet_four_q1_Akshay.Controllers
{
    public class One_AController : Controller
    {
        // GET: One_A
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult test(int? start, int? end)
        {
            if (start == null || end == null)
            {
                ViewBag.Message = "Please enter valid start and end values.";
                return View();
            }
            ViewBag.st = start.Value;
            ViewBag.en = end.Value;
            return View();
        }


    }
}