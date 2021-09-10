using Core.CoreMap;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class AppUserAndRoleMap:CoreMap<AppUserAndRole>
    {
        public AppUserAndRoleMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new { x.AppUserId, x.AppUserRoleId });
        }
    }
}
