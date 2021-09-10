using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("Products");
            Property(x => x.ProductName).IsRequired();
            Property(x => x.ProductName).HasMaxLength(255);

        }
    }
}
