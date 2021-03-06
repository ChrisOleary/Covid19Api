﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Covid19Api.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Covid19Api.Services;

namespace Covid19Api.Controllers
{
    public class HomeController : Controller
    { 
        private readonly ICovidService _apiService;

        public HomeController(ICovidService apiservice)
        {
            _apiService = apiservice;
        }

        public async Task<ActionResult> Index()
        {
            var response = await _apiService.GetSummary<ApiRootObject>();

            return View(response);
        }

        public async Task<ActionResult> Countries()
        {
            var response = await _apiService.GetCountry<List<Countries>>();
            
            return View(response);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
