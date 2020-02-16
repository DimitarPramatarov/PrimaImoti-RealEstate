using Microsoft.AspNetCore.Http;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.Services.Data.Admin.Models;
using PrimaImoti.Services.Data.Estates.Models;
using PrimaImoti.Services.Mappings;
using PrimaImoti.ViewModels.AdViewModels;
using PrimaImoti.ViewModels.BindingModels;
using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels
{
    public class AddEstateViewModel : IMapFrom<Ad>
    {

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Цена")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        public string Currency { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Описание на имота")]
        public string Description { get; set; }


        [Required]
        public Person Person { get; set; }

        [Required]
        [Display(Name = "Тип Имот")]
        public PropertyType Type { get; set; }

        [Required]
        public EstateViewModel Estate { get; set; }


        [Required(ErrorMessage = "Добавете снимки")]
        [Display(Name = "Качи снимка")]
        public IFormFile FormFile { get; set; }
    }
}
