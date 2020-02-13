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
                .Where(estate => estate.Aproved == false)
                .Select(estateFromDb => new WaitingEstatesViewModel
                {
                    Date = estateFromDb.CreatedOn.ToString(),
                    Type = estateFromDb.Type,
                    Adress = estateFromDb.Estate.Adress,
                    FirstName = estateFromDb.Person.FirstName,
                    LastName = estateFromDb.Person.LastName,
                    Phone= estateFromDb.Person.Phone,
                    Email = estateFromDb.Person.Email,

                }).ToList();


            return View(waitingEstates);
        }

    }
}