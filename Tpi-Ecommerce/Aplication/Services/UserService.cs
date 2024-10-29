using Aplication.Interfaces;
using Aplication.Models.Request;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
        public int AddUser(AddUserRequest newUser)
        {
            var obj = new User()
            {
                Name = newUser.Name,
                Email = newUser.Email,
                Password = newUser.Password,
                UserType = newUser.UserType,
            };
            return _userRepository.AddUser(obj);
        }

        public User? GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
