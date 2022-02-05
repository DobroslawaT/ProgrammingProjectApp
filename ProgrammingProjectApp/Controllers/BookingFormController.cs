using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgrammingProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingProjectApp.Controllers
{
    public class BookingFormController : Controller
    {
        private readonly ILogger<BookingFormController> _logger;

        public BookingFormController(ILogger<BookingFormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
