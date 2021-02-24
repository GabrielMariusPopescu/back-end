using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.ViewModels;

namespace WeatherApp.Contracts
{
    public interface IBusinessLogic
    {
        Task<IEnumerable<WeatherViewModel>> GetWeatherForFiveDays();
    }
}
