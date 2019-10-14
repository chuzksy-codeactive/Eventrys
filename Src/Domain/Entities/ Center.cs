using System.Collections.Generic;
using Eventrys.Src.Domain.Common;
using Eventrys.Src.Domain.Enums;

namespace Eventrys.Src.Domain.Entities
{
    public class Center : AuditableEntity
    {
        public Center ()
        {
            Facilities = new HashSet<Facility> ();
            Events = new HashSet<Event> ();
        }
        public int CenterId { get; set; }
        public string Name { get; set; }
        public int HallCapacity { get; set; }
        public string Location { get; set; }
        public ECenterType Type { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<Facility> Facilities { get; private set; }
        public ICollection<Event> Events { get; private set; }
    }
}