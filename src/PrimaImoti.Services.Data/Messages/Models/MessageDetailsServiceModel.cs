using AutoMapper;
using PrimaImoti.DataModels;
using PrimaImoti.Services.Mappings;

namespace PrimaImoti.Services.Data.Messages.Models
{
    public class MessageDetailsServiceModel : IMapFrom<Message>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

        public string Phone { get; set; }

        public string Created { get; set; }


        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Message, MessageDetailsServiceModel>()
                  .ForMember(a => a.FirstName, opt => opt.MapFrom(x => x.Sender.FirstName))
                  .ForMember(a => a.LastName, opt => opt.MapFrom(x => x.Sender.LastName))
                  .ForMember(a => a.Email, opt => opt.MapFrom(x => x.Sender.Email))
                  .ForMember(a => a.Phone, opt => opt.MapFrom(x => x.Sender.Phone))
                  .ForMember(a => a.Phone, opt => opt.MapFrom(x => x.Sender.Id));
        }
        //   => configuration
        //   .CreateMap<Message, MessageDetailsServiceModel>()

    }
}
