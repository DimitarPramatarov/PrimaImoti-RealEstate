using PrimaImoti.DataModels.Ad;
using PrimaImoti.Services.Mappings;
namespace PrimaImoti.Services.Data.Estates.Models
{
    using System.ComponentModel.DataAnnotations;

    public class WaitingEstatesServiceModel : IMapFrom<Ad>
    {
        [Display(Name = "ID")]

        public string Id { get; set; }

        [Display(Name = "Име")]
        public string Name { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Вид имот")]
        public string Type { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Дата")]
        public string CreatedOn { get; set; }

    }
}
