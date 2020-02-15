using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimaImoti.Data;
using PrimaImoti.ViewModels.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimaImoti.Controllers;
using PrimaImoti.Services.Data;

namespace PrimaImoti.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IContactService contactService;
        public AdminController(ApplicationDbContext context,
            IContactService contactService)
        {
            _context = context;
            this.contactService = contactService;
                   }

        [HttpGet]
        public IActionResult DashBoard()
        {
            return View("DashBoard");
        }

        [HttpGet]
        public IActionResult Messages()
        {
            var messages = contactService.Messages();

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
                    Phone = estateFromDb.Person.Phone,
                    Email = estateFromDb.Person.Email,
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