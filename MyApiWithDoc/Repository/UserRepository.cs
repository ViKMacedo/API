using System.Collections.Generic;
using System.Linq;
using API.Models;


namespace API.Repository
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "batman", Password = "6261746D616E", Role = "manager" },
                new User { Id = 2, Username = "robin", Password = "726F62696E", Role = "employee" }
            };
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
