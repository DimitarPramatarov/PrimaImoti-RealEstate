using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimaImoti.Data;
using PrimaImoti.Services.Data;
using PrimaImoti.ViewModels;
using System.Threading.Tasks;

namespace PrimaImoti.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {

        private readonly IContactService contact;

        public ContactController(IContactService contact)
        {
            this.contact = contact;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(ContactViewModel viewModel)
        {


            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            await contact.SendMessageAsync(viewModel.FirstName, viewModel.LastName, 
                viewModel.Email, viewModel.Content, viewModel.Subject, viewModel.Phone);
        

            return Redirect("/");

        }

       
    }
}
