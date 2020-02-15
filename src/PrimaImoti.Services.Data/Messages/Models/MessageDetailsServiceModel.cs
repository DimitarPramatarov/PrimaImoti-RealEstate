using AutoMapper;
using PrimaImoti.DataModels;
using PrimaImoti.Services.Mappings;

namespace PrimaImoti.Services.Data.Messages.Models
{
    public class MessageDetailsServiceModel : IMapFrom<Message>, IHaveCustomMappings
    {

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

        public string Phone {get; set;}

        public string Created { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Message, MessageDetailsServiceModel>();
    }
}
