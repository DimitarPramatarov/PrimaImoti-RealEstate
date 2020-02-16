using AutoMapper;
using PrimaImoti.DataModels;
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
            CreateMap<Message, MessageDetailsServiceModel>()
                .ForMember(a => a.FirstName, cfg => cfg.MapFrom(b => b.Sender.FirstName))
                .ForMember(a => a.LastName, cfg => cfg.MapFrom(b => b.Sender.LastName))
                .ForMember(a => a.Phone, cfg => cfg.MapFrom(b => b.Sender.Phone))
                .ForMember(a => a.Email, cfg => cfg.MapFrom(b => b.Sender.Email))
                .ForMember(a => a.CreatedOn, cfg => cfg.MapFrom(b => b.Created));
        }
    }
}
