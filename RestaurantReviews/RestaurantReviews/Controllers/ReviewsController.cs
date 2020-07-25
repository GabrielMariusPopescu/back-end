using RestaurantReviews.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
  public class ReviewsController : Controller
  {
    // GET: Reviews
    public ActionResult Index()
    {
      var model = from r in reviews
                  orderby r.Name
                  select r;
      return View(model);
    }

    // GET: Reviews/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: Reviews/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Reviews/Create
    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // GET: Reviews/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: Reviews/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // GET: Reviews/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: Reviews/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    private static List<RestaurantReviewsModel> reviews = new List<RestaurantReviewsModel>
    {
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Urban21",
        City = "Targoviste",
        Rating = 6
      },
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Mastero",
        City = "Targoviste",
        Rating = 2
      },
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Dan & Danny",
        City = "Targoviste",
        Rating = 3
      },
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Nova",
        City = "Targoviste",
        Rating = 5
      },
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Alexo",
        City = "Targoviste",
        Rating = 4
      },
      new RestaurantReviewsModel
      {
        Id = 1,
        Name = "Home",
        City = "Targoviste",
        Rating = 1
      }
    };
  }
}
