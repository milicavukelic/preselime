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
    public class SenderDashboardController : MyController
    {
        preselimeEntities db;

        public SenderDashboardController()
        {
            db = new preselimeEntities();
        }
        // GET: SenderDashboard
        public ActionResult Index()
        {
            UserModel model = new UserModel();
            return View("SenderDashboard", model);
        }

        public ActionResult NewMoveShipment()
        {
            SenderShipmentModel model = SenderDashboardBuilder.GetSenderShipmentModel(db);
            return Json(new { result = RenderPartialView("AddNewShipment",model)});
        }



    }

}