using AutoMapper;
using PrimaImoti.DataModels;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.Services.Data.Estates.Models;
using PrimaImoti.Services.Data.Messages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            // Received messages in admin panel map
            CreateMap<Message, MessageDetailsServiceModel>()
                .ForMember(a => a.FirstName, cfg => cfg.MapFrom(b => b.Sender.FirstName))
                .ForMember(a => a.LastName, cfg => cfg.MapFrom(b => b.Sender.LastName))
                .ForMember(a => a.Phone, cfg => cfg.MapFrom(b => b.Sender.Phone))
                .ForMember(a => a.Email, cfg => cfg.MapFrom(b => b.Sender.Email))
                .ForMember(a => a.CreatedOn, cfg => cfg.MapFrom(b => b.Created));

            // Waiting for aprove client`s estates
            CreateMap<Ad, WaitingEstatesServiceModel>()
                .ForMember(a => a.Name, cfg => cfg.MapFrom(b => b.Person.FirstName + " " + b.Person.LastName))
                .ForMember(a => a.Phone, cfg => cfg.MapFrom(b => b.Person.Phone))
                .ForMember(a => a.Adress, cfg => cfg.MapFrom(b => b.Estate.Adress))
                .ForMember(a => a.Adress, cfg => cfg.MapFrom(b => b.Estate.Adress));
        }
    }
}
