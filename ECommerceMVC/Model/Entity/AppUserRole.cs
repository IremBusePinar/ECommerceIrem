using Core.CoreEntity;
using Core.CoreEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class AppUserRole:BaseEntity
    {
        public Role Role { get; set; }
    }
}
