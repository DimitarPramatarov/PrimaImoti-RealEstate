
using PrimaImoti.Services.Data.Messages.Models;
using System.Collections.Generic;

namespace PrimaImoti.ViewModels
{
    public class MessagesViewModel
    {
        public IEnumerable<MessageDetailsServiceModel> Messages { get; set; }
    }
}

