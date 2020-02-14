using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimaImoti.Data;
using PrimaImoti.ViewModels;
using PrimaImoti.ViewModels.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    FirstName = estateFromDb.EstateOwner.FirstName,
                    LastName = estateFromDb.EstateOwner.LastName,
                    Phone = estateFromDb.EstateOwner.Phone,
                    Email = estateFromDb.EstateOwner.Email,
                    Id = estateFromDb.Id,

                }).ToList();


            return View(waitingEstates);
        }

        [HttpPost]
        public async Task<IActionResult> AproveEstate(int id)
        {
            var aproval = _context.Ads.FirstOrDefault(x => x.Id == id);

            if (aproval == null)
            {
                return this.NotFound();
            }

            aproval.Aproved = true;
            await _context.SaveChangesAsync();


            return View();

        }

    }
}