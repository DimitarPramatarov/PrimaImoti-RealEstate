﻿namespace PrimaImoti.Areas.Administration.Controllers
{

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    using PrimaImoti.Data;
    using PrimaImoti.Controllers;
    using PrimaImoti.Services.Data;
    using PrimaImoti.ViewModels;
    using PrimaImoti.Services.Data.Estates;
    using PrimaImoti.ViewModels.ViewModels;
    using System.Collections.Generic;

    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private readonly ApplicationDbContext context;
        private readonly IContactService contactService;
        private readonly IEstateService estateService;

        public AdminController(ApplicationDbContext context,
            IContactService contactService, IEstateService estateService)
        {
            this.context = context;
            this.contactService = contactService;
            this.estateService = estateService;
        }

        [HttpGet]
        public IActionResult DashBoard()
        {
            return View("DashBoard");
        }

        [HttpGet]
        public async Task<IActionResult> Messages()
        {

            var model = new MessagesViewModel
            {
                Messages = await this.contactService.AllMessages()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Messages(IEnumerable<int> values)
        {
              await this.contactService.DeleteMessage(values);

            return Redirect("/Admin/Dashboard");
        }


        [HttpGet]
        public async Task<IActionResult> WaitingEstates()
        {

            var model = new WaitingEstatesViewModel
            {
                WaitingEstates = await this.estateService.WaitingForAprove()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AproveEstate(int id)
        {
            var aproval = this.context.Ads.FirstOrDefault(x => x.Id == id);

            if (aproval == null)
            {
                return this.NotFound();
            }

            aproval.Aproved = true;
            await this.context.SaveChangesAsync();


            return View();

        }

    }
}