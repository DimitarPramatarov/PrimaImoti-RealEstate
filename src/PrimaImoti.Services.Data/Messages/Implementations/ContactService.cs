namespace PrimaImoti.Services.Data
{
    using PrimaImoti.Data;
    using PrimaImoti.DataModels;
    using PrimaImoti.Services.Data.Messages.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using PrimaImoti.Services.Mappings;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper.QueryableExtensions;

    public class ContactService : IContactService
    {

        private readonly ApplicationDbContext context;

        public ContactService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MessageDetailsServiceModel>> AllMessages()
            => await this.context
            .Messages
            .To<MessageDetailsServiceModel>()
            .OrderByDescending(x => x.Created)
            .ToListAsync();

         //  await this.context.Messages
         //   .OrderByDescending(a => a.Created)
         //   .Select(message => new  MessagesViewModel
         //   {
         //       FirstName = message.Sender.FirstName,
         //       LastName = message.Sender.LastName,
         //       Email = message.Sender.Email,
         //       Date = message.Created,
         //       Phone = message.Sender.Phone,
         //       Message = message.Content,
         //       Title = message.Title,
         //       
         //   }).ToListAsync();



        public async Task SendMessageAsync(string firstName, string lastName, string email, string content, string title)
        {
            var created = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            var sender = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
            };

            var message = new Message
            {
                Title = title,
                Content = content,
                Created = created,
                Sender = sender,
            };


            if (message == null)
            {
                throw new ArgumentException();
            }

            await this.context.AddAsync(message);
            await this.context.SaveChangesAsync();
        }
    }
}
