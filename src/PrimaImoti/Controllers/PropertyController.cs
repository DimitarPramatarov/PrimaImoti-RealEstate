using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimaImoti.Data;
using PrimaImoti.DataModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PrimaImoti.ViewModels.EstateViewModels;
using PrimaImoti.ViewModels.ViewModels;
using PrimaImoti.ViewModels;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.DataModels.Estate;
using System;
using PrimaImoti.DataModels.Contact;

namespace PrimaImoti.Controllers
{
    [AllowAnonymous]
    public class PropertyController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PropertyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AdEstate()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult AddEstate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEstate(AddEstateViewModel model)
        {
            bool aproved = false;
            var firstName = "";
            var lastName = "";
            var email = "";
            var phone = "";

            firstName = model.Person.FirstName;
            lastName = model.Person.LastName;
            email = model.Person.Email;
            phone = model.Person.Phone;
            aproved = false;


            EstateOwner owner = new EstateOwner(firstName, lastName, email, phone);

            EstateFeatures estateFeatures = new EstateFeatures
            {
                AccessControl = model.AccsessControl,
                Credit = model.Credit,
                Elevator = model.WithElevator,
                Garage = model.Garage,
                InBuilding = model.InBuildingProcess,
                InternetConnection = model.WithInternetConnection,
                Martgage = model.iSMortgage,
                Parking = model.iSMortgage,
                Renovated = model.Renovated,
                Security = model.Renovated,
                VideoScurity = model.VideoSecurity,
                Trade = model.Trade,
                Transition = model.WithTransition,
                WithBussines = model.WithTransition,
            };


            //upload the image and add house for sale
            using (var memoryStream = new MemoryStream())
            {
                await model.FormFile.CopyToAsync(memoryStream);

                if (memoryStream.Length < 2097152)
                {

                    var images = memoryStream.ToArray();



                    EstateProperty estate = new EstateProperty
                    {
                        Location = model.Location,
                        Adress = model.Adress,
                        Area = model.Area,
                        Furniture = model.Furniture,
                        Building = model.Building,
                        Floor = model.Floor,
                        Heating = model.Heating,
                        Image = images,
                        SecondLocation = model.SecondLocation,
                        EstateFeatures = estateFeatures,
                    };

                    Ad ad = new Ad
                    {
                        Price = model.Price,
                        Curency = model.Currency,
                        Description = model.Description,
                        Estate = estate,
                        Images = images,
                        CreatedOn = DateTime.UtcNow,
                        Aproved = aproved,
                        Person = owner,
                    };

                    if (!ModelState.IsValid)
                    {
                        return View();
                    }

                    await _context.Ads.AddAsync(ad);
                    await _context.SaveChangesAsync();
                }
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.SaveChangesAsync();

            return View("_PropertyIsAdded");
        }

        [HttpGet]
        public IActionResult AllEstates()
        {
            List<AllEstatesViewModel> allEstates = _context.Ads
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

                }).ToList();

            return View(allEstates);

        }


        [HttpPost]
        public async Task<IActionResult> CreateProperty(AddEstateViewModel adModel)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.SaveChangesAsync();

            //Create view for added Ad.
            return View();

        }
    }
}
