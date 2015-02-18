using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personet.Core.Domain
{
    public class Presence
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public string Description { get; set; }

        public DateTime LogTime { get; set; }

        public PresenceType PresenceType { get; set; }


    }

    public enum PresenceType
    {
        Absent = 0,
        Present = 1,
        TemporaryLeave = 2
    }
}
