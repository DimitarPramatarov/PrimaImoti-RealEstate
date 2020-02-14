using AutoMapper;
using PrimaImoti.Common.Mapping;
using PrimaImoti.DataModels;

namespace PrimaImoti.Services.Data.Messages.Models
{
    public class MessageDetailsServiceModel : IMapFrom<Message>, IHaveCustomMapping
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
