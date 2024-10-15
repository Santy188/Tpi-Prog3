using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class UserService 
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
        public int AddUser(User user)
        {
            var obj = new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
            };
            return _userRepository.AddUser(obj);
        }
    }
}
