using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class SubCategoryMap:CoreMap<SubCategory>
    {
        public SubCategoryMap()
        {
            ToTable("SubCategory");
            Property(x => x.SubCategoryName).HasMaxLength(100);
            Property(x => x.Description).IsOptional();
            Property(x => x.Description).HasMaxLength(255);
        }
    }
}
