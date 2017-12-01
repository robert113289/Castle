using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class UserData
    {
        public static List<User> Users = new List<User>();


        public static void Add(User user)
        {
            Users.Add(user);
        }

        public static User GetbyId(int id)
        {
            return Users.Single(x => x.UserId == id);
        }

        public static List<User> GetAllUsers()
        {
            return Users;
        }
    }
}
