using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;

namespace webAppCust.Models
{
    public class OrderExceptionHandler : HandleErrorAttribute
    {
        
        public override void OnException(ExceptionContext filterContext)
        {
            if(filterContext.ExceptionHandled || filterContext.HttpContext.IsCustomErrorEnabled == true)
            {
                return;
            }
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "myErrorPage"
            };

            base.OnException(filterContext);
        }
    }
}