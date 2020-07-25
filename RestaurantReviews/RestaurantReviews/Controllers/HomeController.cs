using System.Web.Mvc;
using RestaurantReviews.Models;

namespace RestaurantReviews.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "This is the About Page";

      var model = new AboutModel
      {
        Name = "My Name",
        Location = "Work Place"
      };

      return View(model);
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}