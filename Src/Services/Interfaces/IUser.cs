using System.Collections.Generic;
using System.Threading.Tasks;
using Eventrys.Src.Domain.Entities;
using Eventrys.Src.Model;

namespace Eventrys.Src.Services.Interfaces
{
    public interface IUser
    {
        Task<User> AuthenticateUser (AuthenticateUser authUser);
        Task<IEnumerable<User>> GetAll ();
        Task<User> GetById (int id);
        Task<User> UpdateById (int id);
        Task<User> DeleteById (int id);
        Task<User> Create (User user);
    }
}