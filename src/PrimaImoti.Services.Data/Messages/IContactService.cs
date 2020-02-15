using PrimaImoti.Services.Data.Messages.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimaImoti.Services.Data
{
    public interface IContactService
    {
        Task SendMessageAsync(string firstName, string lastName, string email, string content, string subject);

        Task<IEnumerable<MessageDetailsServiceModel>> AllMessages();

    }
}
