using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

         public User? GetByName(string name) { return _context.Users.FirstOrDefault(y => y.Name == name); }
         public int AddUser(User user)
         {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
         }
    }
}
