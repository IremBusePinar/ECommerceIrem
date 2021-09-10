using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Areas.Administrator.Data;

namespace WebUI.Areas.Administrator.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();
        SubCategoryService subCategoryService = new SubCategoryService();

        public ActionResult Index()
        {
         List<CategoryVM> categoryVMList = new List<CategoryVM>();
            foreach (var c in categoryService.GetList())
            {
              
                CategoryVM categoryVM = new CategoryVM();
                categoryVM.CategoryName = c.CategoryName;
                categoryVM.Description = c.Description;
                categoryVM.SubCategories = subCategoryService.GetDefault(x => x.CategoryId == c.ID);
                categoryVMList.Add(categoryVM);
            }
            ViewBag.CategoryVM = categoryVMList;
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category newCategory)
        {
           string result= categoryService.Add(newCategory);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }

        //todo: Kategori Güncelleme

        //todo: Kategori Silme
    }
}