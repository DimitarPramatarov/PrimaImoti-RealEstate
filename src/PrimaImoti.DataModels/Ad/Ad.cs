using PrimaImoti.DataModels.Contact;
using PrimaImoti.DataModels.Interfaces;
using System;

namespace PrimaImoti.DataModels.Ad
{
    public class Ad : IAd
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string Curency {get; set;}

        public DateTime CreatedOn {get; set;}

        public bool Aproved {get; set;} = false;

        public string Description { get; set; }

        public byte[] Images { get; set; }

        public EstateOwner EstateOwner {get; set;}

        public EstateProperty Estate { get; set; }

        public PropertyType Type { get; set; }
    }
}
