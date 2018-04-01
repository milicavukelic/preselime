using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Preselime.Models.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email je obavezno polje")]
        public String Email { get; set; }
        [Required(ErrorMessage ="Lozinka je obavezno polje")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}