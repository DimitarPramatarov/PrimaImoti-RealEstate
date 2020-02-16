namespace PrimaImoti.Services.Data.Admin.Models
{
    using PrimaImoti.DataModels.Ad;
    using PrimaImoti.Services.Mappings;
    using System;

    public class AdminCreateAdServiceModel : IMapFrom<Ad>
    {
        public int Id {get; set;}

        public double Price {get; set;}

        public string Currency {get; set;}

        public DateTime CreatedOn {get; set;}

        public string Description { get; set; }

        public byte[] Images {get; set;}

        public string Type {get; set;}
    }
}
