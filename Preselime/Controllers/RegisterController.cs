using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Preselime.Models.Register;

namespace Preselime.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SenderRegistration()
        {
            
            return View("SenderRegistration");
        }
        [HttpPost]
        public ActionResult CarrierRegister(RegistrationCarrierModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View("SenderRegistration");
        }
    }
}