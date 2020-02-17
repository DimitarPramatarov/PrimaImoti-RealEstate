namespace PrimaImoti.Services.Data
{
    using PrimaImoti.Data;
    using PrimaImoti.DataModels;
    using PrimaImoti.Services.Data.Messages.Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper.QueryableExtensions;
    using AutoMapper;

    public class ContactService : IContactService
    {

        private readonly ApplicationDbContext context;

        private readonly IMapper mapper;

        public ContactService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<MessageDetailsServiceModel>> AllMessages()
            => await this.context
            .Messages
            .OrderByDescending(x => x.Created)
            .ProjectTo<MessageDetailsServiceModel>(mapper.ConfigurationProvider)
            .ToListAsync();

        public async Task DeleteMessage(int id)
        {

            var messageForDelete = this.context.Messages.Where(x => x.Id == id).FirstOrDefault();

            this.context.Messages.Remove(messageForDelete);
            await this.context.SaveChangesAsync();
        }

        public async Task GetMessageByIdAsync(int id)
            =>  this.context.Messages
            .Where(x => x.Id == id).FirstOrDefault();

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
