using Core.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class SubCategory:BaseEntity
    {
        //todo: Sonsuz alt kategori tanımlanacak.
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
