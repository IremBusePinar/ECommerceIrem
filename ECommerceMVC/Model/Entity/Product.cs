using Core.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ProductImagePath { get; set; }

        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

    }
}
