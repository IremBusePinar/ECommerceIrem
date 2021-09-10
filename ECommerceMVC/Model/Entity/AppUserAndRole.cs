using Core.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class AppUserAndRole:BaseEntity
    {
        public Guid AppUserId { get; set; }
        public Guid AppUserRoleId { get; set; }

        //Mapping
        public virtual AppUser AppUser { get; set; }
        public virtual AppUserRole AppUserRole { get; set; }
    }
}
