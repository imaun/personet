using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personet.Core.Domain
{
    public abstract class BaseEntity: IEntity
    {
        public DateTime CreateTime { get; set; }

        public DateTime ModifiedTime { get; set; }
    }
}
