using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Preselime.Models.Register
{
    public class RegistrationCarrierModel
    {
        [Required(ErrorMessage ="Ime i prezime je obavezno polje")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Email je obavezno polje")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Lozinka je obavezno polje")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required(ErrorMessage = "Potvrda lozinke je obavezno polje")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Lozinka i potvrda lozinke nisu iste")]
        public String ConfirmPassword { get; set; }
        public String Phone { get; set; }
        [Required(ErrorMessage = "Drzava je obavezno polje")]
        public String Country { get; set; }
        [Required(ErrorMessage = "Grad je obavezno polje")]
        public String City { get; set; }
        public int UserTypeId { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}