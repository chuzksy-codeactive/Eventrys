using System.Collections.Generic;
using Eventrys.Src.Domain.Entities;
using Eventrys.Src.Model;

namespace Eventrys.Src.Services.Interfaces
{
    public interface IUser
    {
        User AuthenticateUser (AuthenticateUser authUser);
        IEnumerable<User> GetAll ();
        User GetById (int id);
        User UpdateById (int id);
        User DeleteById (int id);
    }
}