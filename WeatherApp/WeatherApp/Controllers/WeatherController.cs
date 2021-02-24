using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Contracts;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        public WeatherController(IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic;
        }

        [Authorize]
        public ActionResult Index()
        {
            var model = businessLogic.GetWeatherForFiveDays().Result;
            return View(model);
        }

        //


        private readonly IBusinessLogic businessLogic;
    }
}
