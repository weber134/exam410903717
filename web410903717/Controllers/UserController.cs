using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace web410903717.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Music()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Music(string name, int? num)
        {
            var result = "";
            if (num.HasValue)
            {
                switch (num)
                {
                    case 1:
                        result = "do";
                        break;
                    case 2:
                        result = "re";
                        break;
                    case 3:
                        result = "mi";
                        break;
                    case 4:
                        result = "fa";
                        break;
                    case 5:
                        result = "so";
                        break;
                    case 6:
                        result = "la";
                        break;
                    case 7:
                        result = "xi";
                        break;
                    default:
                        result = "錯誤";
                        break;
                }
            }
            
            ViewBag.name = name;
            ViewBag.result = result;

            return View();

        }

    }
}