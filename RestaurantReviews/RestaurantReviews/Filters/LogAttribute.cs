using System.IO;
using System.Web.Mvc;

namespace RestaurantReviews.Filters
{
  public class LogAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
      File.WriteAllText("OnActionExecuted", filterContext.ActionDescriptor.ActionName);
    }

    public override void OnResultExecuted(ResultExecutedContext filterContext)
    {
      File.WriteAllText("OnResultExecuted", filterContext.Result.ToString());
    }
  }
}