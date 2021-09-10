using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Administrator.Controllers
{
    public class UserController : Controller
    {
        // GET: Administrator/User
        public ActionResult Index()
        {
            return View();
        }
    }
}