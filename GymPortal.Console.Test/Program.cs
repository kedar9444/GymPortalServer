using GymPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymPortal.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GymPortalEntities())
            {

                var query = from b in db.users
                            orderby b.name
                            select b;

                System.Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    System.Console.WriteLine(item.userId + " " + item.name);
                }

                System.Console.WriteLine("Press any key to exit...");
                System.Console.ReadKey();
            }
        }
    }
}
