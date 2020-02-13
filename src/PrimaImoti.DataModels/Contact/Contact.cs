using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.DataModels.Contact
{
    public class Contact
    {
        public int Id {get; set;}

        public DateTime Created {get; set;}

        public Person Sender {get; set;}

        public Message Message {get; set;}
    }
}
