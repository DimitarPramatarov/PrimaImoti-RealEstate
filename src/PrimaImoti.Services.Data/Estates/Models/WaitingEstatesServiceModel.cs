using AutoMapper;
using PrimaImoti.DataModels;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.Services.Mappings;
using System;

namespace PrimaImoti.Services.Data.Estates.Models
{
    public class WaitingEstatesServiceModel : IMapFrom<Ad>, IHaveCustomMappings
    {
        public double Price { get; set; }

        public string Curency {get; set;}

        public DateTime CreatedOn {get; set;}

        public bool Aproved {get; set;} = false;

        public string Description { get; set; }

        public byte[] Images { get; set; }

        public Person Person {get; set;}

        public EstateProperty Estate { get; set; }

        public PropertyType Type { get; set; }

        public void CreateMappings(IProfileExpression configuration)
            => configuration
            .CreateMap<Ad, WaitingEstatesServiceModel>();

            // finish waiting services!
    }
}
