using FormASP.NET_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormASP.NET_Core.FakeRepo
{
    public class UsersRepo
    {
         public static List<User> Users = new List<User>
            {
                new User{Id = 1, ImagePath = "nerbala.jpg", Name = "Nerbala", Surname = "Xaladenliq Ustasi", Age = 49  },
                new User { Id = 1, Name = "John", Surname = "Cena", ImagePath = "jhon.jpg", Age = 47 }
            };

        

        public  List<User> getAllUsers()
        {
            return Users;
        }
    }
}
