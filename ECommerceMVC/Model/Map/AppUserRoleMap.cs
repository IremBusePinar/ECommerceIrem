using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class AppUserRoleMap:CoreMap<AppUserRole>
    {
        public AppUserRoleMap()
        {
            ToTable("Roles");
        }
    }
}
