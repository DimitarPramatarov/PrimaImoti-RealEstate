namespace PrimaImoti.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PrimaImoti.Data;
    using PrimaImoti.DataModels;
    using PrimaImoti.DataModels.Contact;
    using PrimaImoti.Services;
    using System.Globalization;
    using PrimaImoti.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [AllowAnonymous]
    public class ContactController : Controller
    {

        private readonly ApplicationDbContext context;

        public ContactController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel viewModel)
        {
            var firstName = viewModel.FirstName;
            var lastName = viewModel.LastName;
            var email = viewModel.Email;

          Person person = new Person(firstName, lastName, email);
          
          Message message = new Message
          {
              Title = viewModel.Subject,
              NewMessage = viewModel.Message
          };
          
           DateTime localDate = DateTime.Now;

          Contact contact = new Contact
          {
              Sender = person,
              Message = message,
              Created = localDate,
          };


            if (!ModelState.IsValid)
            {
                return View();
            }
          //
          // IEmailSender sender = new EmailSender();
          //
          //  sender.SendMail(viewModel.Message, viewModel.Email, viewModel.Subject, viewModel.FirstName, viewModel.LastName);
          //
            await context.Contacts.AddAsync(contact);
            await context.SaveChangesAsync();

            return Redirect("/");

        }

       
    }
}
