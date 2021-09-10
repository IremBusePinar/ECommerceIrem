using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Areas.Administrator.Data
{
    public class CategoryVM
    {
       
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}