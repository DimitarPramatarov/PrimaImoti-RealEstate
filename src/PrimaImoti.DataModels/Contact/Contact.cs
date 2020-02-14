using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.DataModels.Contact
{
    public class Contact
    {

        public Contact(string created, Person sender, Message message)
        {
            this.Created = created;
            this.Sender = sender;
            this.Message = message;
        }

        public Contact()
        {
        }

        public int Id {get; set;}

        public string Created {get; set;}

        public Person Sender {get; set;}

        public Message Message {get; set;}
    }
}
