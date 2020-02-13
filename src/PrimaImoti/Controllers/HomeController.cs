using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimaImoti.Data;
using PrimaImoti.Models;
using PrimaImoti.ViewModels.ViewModels;

namespace PrimaImoti.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var ads = _context.Ads
                .Select(DbEstate => new AllEstatesViewModel
                {
                    Type = DbEstate.Type,
                    Area = DbEstate.Estate.Area,
                    Description = DbEstate.Description,
                    Location = DbEstate.Estate.Location,
                    Furniture = DbEstate.Estate.Furniture,
                    Building = DbEstate.Estate.Building,
                    Heating = DbEstate.Estate.Heating,
                    Images = DbEstate.Estate.Image
                }).FirstOrDefault();

            return View(ads);
        }

        public IActionResult AboutUs()
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
