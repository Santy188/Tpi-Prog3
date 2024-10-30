using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User? GetByName(string name);
        int AddUser(User user);
        
    }
}
