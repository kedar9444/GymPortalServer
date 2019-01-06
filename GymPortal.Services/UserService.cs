using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymPortal.Data.Interfaces.Services;
using GymPortal.Data.Interfaces.Repository;
using GymPortal.Data;

namespace GymPortal.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int Add(User user)
        {
            // check existing user present
            var userExist = _userRepository.SingleOrDefault(x => x.name.ToLower() == user.name.ToLower() && x.surname.ToLower() == user.surname.ToLower());
            if (userExist != null)
            {
                return 0;
            }
            return _userRepository.Add(user).userId;
        }

        public User Get(int id)
        {
            return _userRepository.Get(id);
        }

        public int GetCount()
        {
            return _userRepository.GetCount();
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll().ToList();
        }
    }
}
