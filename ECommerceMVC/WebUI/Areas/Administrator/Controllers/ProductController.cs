using Common;
using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Administrator.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        SubCategoryService subCategoryService = new SubCategoryService();
        public ActionResult Index()
        {
            return View(productService.GetList());
        }

        public ActionResult Add()
        {
            ViewBag.SubCategories = new SelectList(subCategoryService.GetList(), "ID", "SubCategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product newProduct,HttpPostedFileBase ProductImagePath)
        {
           newProduct.ProductImagePath= ImageUploader.UploadImage("~/Content/productImages", ProductImagePath);
            productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.SubCategories = new SelectList(subCategoryService.GetList(), "ID", "SubCategoryName");
            return View();

        }
    }
}