using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            Property(x => x.CategoryName).HasMaxLength(100);
            Property(x => x.CategoryName).IsRequired();
            Property(x => x.Description).HasMaxLength(255);
        }
    }
}
