using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Preselime.Filters
{
    public class AutorizeCarrier:  ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["CarrierLogedIn"] == null)
            {

                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    { "Controller","Login"},
                    { "Action", "Index"}
                });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}