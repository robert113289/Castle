using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        private static int nextUserId = 0;

        public User()
        {
            UserId = nextUserId;
            nextUserId++;
        }
    }
}
