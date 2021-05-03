using DPaul_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace DPaul_Final.Controllers
{
    /// <summary>
    /// Controls the webpage
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;

        /// <summary>
        /// sets the logger and the http client factory
        /// </summary>
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientfactory)
        {
            _logger = logger;
            clientFactory = httpClientfactory;
        }

        /// <summary>
        /// returns the view for the index
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// connects to the api for todays weather
        /// </summary>
        /// <returns>
        /// The view with todays weather
        /// </returns>
        public async Task<IActionResult> Weather()
		{
            string uri;

            ViewData["Title"] = $"Weather Forecast";
			uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast";
			

			var client = clientFactory.CreateClient(
				name: "COMP494_FINAL");

			var request = new HttpRequestMessage(
				method: HttpMethod.Get, requestUri: uri);

            //requests information from the api            
            HttpResponseMessage response = await client.SendAsync(request);

            //parses that information into a var
            var model = await response.Content.ReadFromJsonAsync<WeatherForecast>();

			return View(model);

		}

        /// <summary>
        /// connects to the api for hourly weather
        /// </summary>
        /// <returns>
        /// The view with hourly weather
        /// </returns>
        public async Task<IActionResult> Hourly()
        {
            string uri;

            ViewData["Title"] = $"Hourly Weather Forecast";
            uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/hourly";


            var client = clientFactory.CreateClient(
                name: "COMP494_FINAL");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<IEnumerable<HourlyForecast>>();

            return View(model);

        }
        /// <summary>
        /// connects to the api for a detailed weather report
        /// </summary>
        /// <returns>
        /// The view with detailed weather information
        /// </returns>
        public async Task<IActionResult> Detailed()
        {
            string uri;

            ViewData["Title"] = $"Detailed Weather Forecast";
            uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/details";


            var client = clientFactory.CreateClient(
                name: "COMP494_FINAL");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);
            
            var model = await response.Content.ReadFromJsonAsync<DetailedForecast>();

            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
