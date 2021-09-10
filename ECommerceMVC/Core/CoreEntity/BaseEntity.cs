using Core.CoreEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.CoreEntity
{
    public class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            Status = Status.Active;
            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName;
            CreatedAdUsername = WindowsIdentity.GetCurrent().Name;
            //todo: Ip getiren metot yazılacak.
            CreatedIP = "192.168.1.1";
            //todo: Login işlemi yapıldığında aşağıdaki property'e login yapan kullanıcının adı yazılacak.
            CreatedBy = "admin";
            //todo: Master Id yapılandırılacak.
        }
        public Guid ID { get ; set ; }

        public int MasterId { get; set; }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; } 
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedAdUsername { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedAdUsername { get; set; }
        public string UpdatedBy { get; set; }


    }
}
