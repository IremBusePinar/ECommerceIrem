using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CoreEntity
{
    public interface IEntity<T>
    {
        T ID { get; set; }

    }
}
