using PrimaImoti.Data;
using PrimaImoti.DataModels;
using PrimaImoti.DataModels.Contact;
using PrimaImoti.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimaImoti.Services.Data
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext context;

        public ContactService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<IEnumerable<ContactViewModel>> AllMessages(int page = 1)
        {
            throw new System.NotImplementedException();
        }

        public async Task SendMessageAsync(string firstName, string lastName, string email, string newMessage, string title)
        {
            var created = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            var sender = new Person(firstName, lastName, email);

            var message = new Message(title, newMessage);

            var contact = new Contact(created, sender, message);

            if(contact == null)
            {
                throw new ArgumentException();
            }

            await this.context.AddAsync(contact);
            await this.context.SaveChangesAsync();
        }
    }
}
