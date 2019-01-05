using GymPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPortal.Data.Interfaces.Services
{
    public interface IUserService
    {
        int GetCount();

        User Get(int id);
        List<User> GetUsers();
    }
}
