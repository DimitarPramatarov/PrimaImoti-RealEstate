using Microsoft.AspNetCore.Http;
using PrimaImoti.ViewModels.AdViewModels;
using PrimaImoti.ViewModels.BindingModels;
using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels
{
    public class AddEstateViewModel
    {
        [Required]
        public Person Person {get; set;}

        [Required]
        [Display(Name = "Тип Имот")]
        public PropertyType Type { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Цена")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        public string Currency {get; set;}

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Описание на имота")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Локация")]
        public string Location { get; set; }

        
        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Точен Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Под район")]
        public string SecondLocation {get; set;}

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Квадратура")]
        public int Area { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Обзавеждане")]
        public string Furniture { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Строителство")]
        public string Building { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Етаж")]
        public int Floor { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Отопление")]
        public string Heating { get; set; }

        [Display(Name = "С гараж")]
        public bool Garage {get; set; }

        [Display(Name = "С преход")]
        public bool WithTransition {get; set;} = false;

        [Display(Name = "С асансьор")]
        public bool WithElevator {get; set;} = false;

        [Display(Name = "В строеж")]
        public bool InBuildingProcess {get; set;} = false;

         [Display(Name = "Лизинг")]
        public bool Credit {get; set;} = false;

        [Display(Name = "Ипотекиран")]
        public bool iSMortgage {get; set;} = false;

        [Display(Name = "Паркинг")]
        public bool Parking {get; set;} = false;

        [Display(Name = "Бартер")]
        public bool Trade {get; set;} = false;

        [Display(Name = "Интернет връзка")]
        public bool WithInternetConnection {get; set; } = false;

        [Display(Name = "Видео наблюдение")]
        public bool VideoSecurity {get; set;} = false;

        [Display(Name = "Контрол на достъп")]
        public bool AccsessControl {get; set;} = false;

        [Display(Name = "Охрана")]
        public bool Security {get; set;} = false;

        [Display(Name = "Саниран")]
        public bool Renovated {get; set;}

        [Display(Name = "С действащ бизнес")]
        public bool WithBussiness {get; set;}

        [Required(ErrorMessage = "Добавете снимки")]
        [Display(Name = "Качи снимка")]
        public IFormFile FormFile { get; set; }
    }
}
