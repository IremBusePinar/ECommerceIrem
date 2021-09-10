using Core.CoreEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CoreMap
{
    public class CoreMap<T>: EntityTypeConfiguration<T> where T:BaseEntity
    {
        public CoreMap()
        {
            Property(x => x.CreatedAdUsername).IsOptional();
            Property(x => x.CreatedAdUsername).HasColumnName("CreatedAdminUserName");

        }
    }
}
