using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Preselime.Controllers
{
    public class MyController : Controller
    {
        public string RenderPartialView(string viewName, object model)
        {
            ViewData.Model = model;
            using (System.IO.StringWriter writer = new System.IO.StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, writer);
                viewResult.View.Render(viewContext, writer);
                return writer.GetStringBuilder().ToString();
            }
        }
    }
}