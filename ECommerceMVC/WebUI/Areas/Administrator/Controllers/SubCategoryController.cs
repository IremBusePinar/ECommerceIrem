using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Administrator.Controllers
{
    public class SubCategoryController : Controller
    {

        SubCategoryService subCategoryService = new SubCategoryService();
        CategoryService categoryService = new CategoryService();

        public ActionResult Index()
        {
            return View(subCategoryService.GetList());
        }

        public ActionResult Add()
        {
            ViewBag.Categories = new SelectList(categoryService.GetList(), "ID", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Add(SubCategory newSubCategory)
        {
           string result= subCategoryService.Add(newSubCategory);
            TempData["Result"] = result;

            return RedirectToAction("Index");
        }
    }
}