namespace PrimaImoti.Controllers
{
    using AutoMapper;
    using System;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using PrimaImoti.Data;
    using PrimaImoti.DataModels;
    using PrimaImoti.ViewModels.ViewModels;
    using PrimaImoti.ViewModels;
    using PrimaImoti.DataModels.Ad;
    using PrimaImoti.DataModels.Estate;
    using PrimaImoti.Services.Data.Estates;
    using Microsoft.AspNetCore.Http;

    [AllowAnonymous]
    public class PropertyController : Controller
    {

        private readonly ApplicationDbContext context;
        private readonly IEstateService estateService;
        private readonly IMapper mapper;

        public PropertyController(ApplicationDbContext context, IEstateService estateService,
            IMapper mapper)
        {
            this.context = context;
            this.estateService = estateService;
            this.mapper = mapper;
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
            var image = CreateImage(model.FormFile);

            byte[] img = image;
            
            var estate = mapper.Map<Ad>(model);
            await this.estateService.CreateAsync(estate);


            if (!ModelState.IsValid)
            {
                return View();
            }

            await this.context.SaveChangesAsync();

            return View("_PropertyIsAdded");
        }

        [HttpGet]
        public IActionResult AllEstates()
        {
            List<AllEstatesViewModel> allEstates = this.context.Ads
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

        public byte[] CreateImage(IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                formFile.CopyTo(memoryStream);

                if (memoryStream.Length < 2097152)
                {
                    var image = memoryStream.ToArray();
                    return image;
                }
            }

            throw new ArgumentException();
        }
    }
}
