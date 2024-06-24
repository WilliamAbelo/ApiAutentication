using ApiAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuthentication.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>{
                new() {Id = 1, UserName = "John", Password = "Rambo", Roles = new string[] {"manager"} },
                new() {Id = 2, UserName = "Chuck", Password = "Norris", Roles = new string[] {"admin"} },
                new() {Id = 2, UserName = "Arnold", Password = "Zeneger", Roles = new string[] {"employee"} }
            };
            return users
                .FirstOrDefault(x => string.Equals(x.UserName, username, StringComparison.CurrentCultureIgnoreCase)
                && x.Password == password);
        }
    }
}