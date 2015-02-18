using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personet.Core.Domain
{
    public class Structure: BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public int OrganizationId { get; set; }
    }
}
