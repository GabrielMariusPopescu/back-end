using AutoMapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Contracts;
using WeatherApp.Helpers;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Services
{
    public class BusinessLogic : IBusinessLogic
    {
        public BusinessLogic(IConfiguration configuration, IMapper mapper)
        {
            this.configuration = configuration;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WeatherViewModel>> GetWeatherForFiveDays()
        {
            var model = new List<WeatherViewModel>();
            var firstDay = GetDay();
            var secondDay = GetDay(1);
            var thirdDay = GetDay(2);
            var fourthDay = GetDay(3);
            var fifthDay = GetDay(4);
            model.Add(firstDay);
            model.Add(secondDay);
            model.Add(thirdDay);
            model.Add(fourthDay);
            model.Add(fifthDay);

            return await Task.FromResult(model);
        }

        //

        private readonly IConfiguration configuration;
        private readonly IMapper mapper;

        private Uri ApiBaseUrl => new Uri(configuration.GetValue<string>("MetaWeatherBaseUrl"));

        private WeatherViewModel GetDay(int day = 0)
        {
            var weather = GetData(DateTime.Today.AddDays(day));
            var model = weather.Result.Select(mapper.Map<WeatherViewModel>).ToList();
            return ProcessData(model);
        }

        private async Task<IEnumerable<Weather>> GetData(DateTime dateTime)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{ApiBaseUrl}/location/{Constants.BELFAST}/{dateTime:yyyy/MM/dd}")
            {
                Content = new StringContent("application/json")
            };
            var response = await client.GetAsync(request.RequestUri);

            var json = "";
            if (response.IsSuccessStatusCode)
            {
                json = await response.Content.ReadAsStringAsync();
            }

            var weathers = JsonConvert.DeserializeObject<IEnumerable<Weather>>(json);

            return await Task.FromResult(weathers);
        }

        private WeatherViewModel ProcessData(List<WeatherViewModel> model)
        {
            var state = model.GroupBy(it => it.State).OrderByDescending(grp => grp.Count()).First().Key;
            var windDirection = model.GroupBy(it => it.WindDirection).OrderByDescending(grp => grp.Count()).First().Key;
            var windAbbr = model.GroupBy(it => it.WindAbbr).OrderByDescending(grp => grp.Count()).First().Key;
            var date = model.Select(it => it.Day).FirstOrDefault();
            var minTemp = model.Select(it => it.MinTemp).Average();
            var maxTemp = model.Select(it => it.MaxTemp).Average();
            var weatherViewModel = new WeatherViewModel
            {
                State = state,
                WindDirection = windDirection,
                WindAbbr = windAbbr,
                Day = date,
                MinTemp = minTemp,
                MaxTemp = maxTemp
            };
            weatherViewModel.Image = $"https://www.metaweather.com/static/img/weather/png/64/{weatherViewModel.WindAbbr}.png";

            return weatherViewModel;
        }
    }
}
