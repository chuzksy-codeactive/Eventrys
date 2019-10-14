using System;
using System.Collections.Generic;
using Eventrys.Src.Domain.Common;

namespace Eventrys.Src.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Event ()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Note { get; set; }
        public DateTimeOffset ScheduledDate { get; set; }
        public ICollection<User> Users { get; private set; }
    }
}