using System.Web.Mvc;

namespace Sod.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomeHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new JsonResult
                {
                    Data = new
                    {
                        success = false,
                        ErrorCode = 0001,
                        message = "We're sorry,an error has occurred.",
                        Redirect = "~/error"
                    }
                };
            }
            else
            {
                filterContext.Result = new RedirectResult("~/error");
            }
            base.OnException(filterContext);
        }
    }
}