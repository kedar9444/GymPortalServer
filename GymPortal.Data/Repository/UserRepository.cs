﻿
using GymPortal.Data.Interfaces.Context;
using GymPortal.Data.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GymPortal.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        //public UserRepository() : base(IGymPortalContext context)
        //{
             
        //}
    }
}
