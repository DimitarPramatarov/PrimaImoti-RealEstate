using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimaImoti.Data;
using PrimaImoti.ViewModels;
using PrimaImoti.ViewModels.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PrimaImoti.Areas.Administration.Controllers
{
    [Authorize("Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult DashBoard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Messages()
        {
            List<MessagesViewModel> messages = _context.Contacts
                .Select(messagesFromDb => new MessagesViewModel
                {
                    Title = messagesFromDb.Message.Title,
                    FirstName = messagesFromDb.Sender.FirstName,
                    LastName = messagesFromDb.Sender.LastName,
                    Email = messagesFromDb.Sender.Email,
                    Message = messagesFromDb.Message.NewMessage,
                    Date = messagesFromDb.Created.ToString(),

                }).ToList();

            return View(messages);
        }

        [HttpGet]
        public IActionResult WaitingEstates()
        {
            List<WaitingEstatesViewModel> waitingEstates = _context.Ads
                .Where(estate => estate.Aproved == true)
                .Select(estateFromDb => new WaitingEstatesViewModel
                {
                    Date = estateFromDb.CreatedOn.ToString(),
                    Person = estateFromDb.Person,
                    Type = estateFromDb.Type,
                    Price = estateFromDb.Price,
                    Currency = estateFromDb.Curency,
                    Description = estateFromDb.Description,
                    Location = estateFromDb.Estate.Location,
                    Adress = estateFromDb.Estate.Adress,
                    SecondLocation = estateFromDb.Estate.SecondLocation,
                    Area = estateFromDb.Estate.Area,
                    Furniture = estateFromDb.Estate.Furniture,
                    Building = estateFromDb.Estate.Building,
                    Floor = estateFromDb.Estate.Floor,
                    Heating = estateFromDb.Estate.Heating,
                    Garage = estateFromDb.Estate.EstateFeatures.Garage,
                    WithTransition= estateFromDb.Estate.EstateFeatures.Transition,
                    WithElevator= estateFromDb.Estate.EstateFeatures.Elevator,
                    InBuildingProcess= estateFromDb.Estate.EstateFeatures.InBuilding,
                    Credit = estateFromDb.Estate.EstateFeatures.Credit,
                    iSMortgage = estateFromDb.Estate.EstateFeatures.Martgage,
                    
                }).ToList();


            return View(waitingEstates);
        }

    }
}