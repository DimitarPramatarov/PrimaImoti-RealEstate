using PrimaImoti.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.Services.Data
{
    public interface IMessages
    {
        void SendMessage(ContactViewModel model);

        void AllMessages();
    }
}
