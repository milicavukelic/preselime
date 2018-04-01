using Preselime.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Preselime.Builders;
using Preselime.Models.User;
using Domain;

namespace Preselime.Controllers
{
    public class LoginController : Controller
    {
        preselimeEntities db;

        public LoginController()
        {
            db = new preselimeEntities();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                UserModel user = LoginBuilder.Login(login, db);
                if (user != null)
                {
                    if(user.UserTypeId == 1)
                    {
                        Session["CarrierLogedIn"] = user;
                        return RedirectToAction("Index","SenderDashboard");
                    }
                    else {
                        Session["SenderLogedIn"] = user;
                        return RedirectToAction("Index", "SenderDashboard");
                    }
                }
                else
                {
                    ViewBag.Message = "Logovanje nije uspelo";
                }
            }
            return View("Index");
        }
    }
}