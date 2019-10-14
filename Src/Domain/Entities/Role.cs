using Eventrys.Src.Domain.Common;

namespace Eventrys.Src.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public int Id { get; set; }
        public string UserRole { get; set; }
        public bool IsActive { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}