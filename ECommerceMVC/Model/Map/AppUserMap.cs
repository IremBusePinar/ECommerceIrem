using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Users");
            Property(x => x.UserName).IsRequired();
            Property(x => x.UserName).HasMaxLength(50);
            Property(x => x.Password).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.BirthDate).IsOptional();

        }
    }
}
