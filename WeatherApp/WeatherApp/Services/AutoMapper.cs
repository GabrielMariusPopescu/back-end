using AutoMapper;
using System;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp.Services
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Weather, WeatherViewModel>()
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.weather_state_name))
                .ForMember(dest => dest.WindDirection, opt => opt.MapFrom(src => src.wind_direction_compass))
                .ForMember(dest => dest.WindAbbr, opt => opt.MapFrom(src => src.weather_state_abbr))
                .ForMember(dest => dest.Day, opt => opt.MapFrom(src => DateTime.Parse(src.applicable_date)))
                .ForMember(dest => dest.MinTemp, opt => opt.MapFrom(src => double.Parse(src.min_temp)))
                .ForMember(dest => dest.MaxTemp, opt => opt.MapFrom(src => double.Parse(src.max_temp)));

            CreateMap<WeatherViewModel, Weather>();
        }
    }
}
