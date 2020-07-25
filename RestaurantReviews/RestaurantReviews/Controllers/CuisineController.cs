using RestaurantReviews.Filters;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
  public class CuisineController : Controller
  {
    //[Log]
    public ActionResult Search(string name)
    {
      var message = Server.HtmlEncode(name);
      return Content(message);
    }
  }
}