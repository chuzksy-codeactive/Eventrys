using Eventrys.Src.Domain.Common;

namespace Eventrys.Src.Domain.Entities
{
   public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public Role Role { get; set; }
    }
}