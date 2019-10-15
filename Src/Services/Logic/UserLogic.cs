using System.Collections.Generic;
using System.Threading.Tasks;
using Eventrys.Src.Data;
using Eventrys.Src.Domain.Entities;
using Eventrys.Src.Model;
using Eventrys.Src.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eventrys.Src.Services.Logic
{
    public class UserLogic : IUser
    {
        public readonly EventrysDBContext _context;
        public UserLogic (EventrysDBContext context)
        {
            _context = context;
        }
        public Task<User> AuthenticateUser (AuthenticateUser authUser)
        {
            throw new System.NotImplementedException ();
        }

        public async Task<User> Create (User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword (user.Password);

            _context.Users.Add (user);
            await _context.SaveChangesAsync ();

            return new User
            {
                Id = user.Id,
                Username = user.Username,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Password = user.Password
            };
        }

        public Task<User> DeleteById (int id)
        {
            throw new System.NotImplementedException ();
        }

        public async Task<IEnumerable<User>> GetAll ()
        {
            var users = await _context.Users.ToListAsync ();

            if (users == null)
            {
                return null;
            }

            return users;
        }

        public async Task<User> GetById (int id)
        {
            var user = await _context.Users.FindAsync (id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public Task<User> UpdateById (int id)
        {
            throw new System.NotImplementedException ();
        }
    }
}