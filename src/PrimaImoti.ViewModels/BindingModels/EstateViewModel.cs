namespace PrimaImoti.ViewModels.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class EstateViewModel
    {

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Локация")]
        public string Location { get; set; }


        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Точен Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Под район")]
        public string SecondLocation { get; set; }

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

        public EstateFeatures EstateFeatures { get; set; }

    }
}
