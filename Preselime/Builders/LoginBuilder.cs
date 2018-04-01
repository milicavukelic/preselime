using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Preselime.Models.User;
using Preselime.Models.Login;
using Domain;

namespace Preselime.Builders
{
    public static class LoginBuilder
    {
        public static UserModel Login(LoginModel loginModel,preselimeEntities db)
        {
            UserModel user = db.Users.Where(m => m.Email == loginModel.Email && m.Password == loginModel.Password).Select(c => new UserModel() { Name = c.Name, UserId = c.Id, UserTypeId = (int)c.UserTypeId }).FirstOrDefault();
            return user;
        }
    }
}