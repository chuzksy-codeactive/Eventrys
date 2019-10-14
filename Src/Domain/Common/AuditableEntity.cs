using System;

namespace Eventrys.Src.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; private set; } = DateTime.Now;
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; private set; } = DateTime.Now;
    }
}