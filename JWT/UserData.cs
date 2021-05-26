using JWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT
{
    public static class UserData
    {
        public static List<UserModel> users = new List<UserModel>()
        {
            new UserModel()
            {
                Username="kapilsharma",
                Password="12345"
            }
        };


    }
}
