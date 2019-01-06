using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPortal.Data.Configuration
{
    public static class ContextConfig
    {
        public static GymPortalEntities _Context = null;

        public static GymPortalEntities ConfigureContext()
        {
            if (_Context == null)
                _Context = new GymPortalEntities();
            else
                _Context = _Context as GymPortalEntities;
            return _Context;
        }

        public static void SaveChanges()
        {
            _Context.SaveChanges();
        }
    }
}
