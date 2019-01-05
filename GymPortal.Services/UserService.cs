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
            throw new NotImplementedException();
        }
    }
}
