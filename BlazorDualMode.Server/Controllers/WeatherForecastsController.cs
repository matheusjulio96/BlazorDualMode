﻿using BlazorDualMode.Client.Data;
using BlazorDualMode.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDualMode.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastsController : Controller
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastsController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public Task<IEnumerable<WeatherForecast>> Get()
        {
            return _weatherForecastService.GetForecastAsync();
        }
    }
}
