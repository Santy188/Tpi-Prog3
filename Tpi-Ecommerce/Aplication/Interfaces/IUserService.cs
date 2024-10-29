using Aplication.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IUserService
    {
        User? GetByName(string name);
        int AddUser(AddUserRequest user); 
    }
}
