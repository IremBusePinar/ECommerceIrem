using Model.Context;
using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {
            TempData["Categories"] = categoryService.GetList();
            return View();
        }
    }
}