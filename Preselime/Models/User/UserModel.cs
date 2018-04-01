using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Preselime.Models.User
{
    public class UserModel
    {
        public int UserId { get; set; }
        public String Username { get; set; }
        public int UserTypeId { get; set; }
        public String Name { get; set; }
    }
}