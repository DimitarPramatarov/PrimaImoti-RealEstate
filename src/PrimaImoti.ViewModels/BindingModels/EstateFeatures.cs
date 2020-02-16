using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels.BindingModels
{
    public class EstateFeatures
    {
        [Display(Name = "С гараж")]
        public bool Garage {get; set; }

        [Display(Name = "С преход")]
        public bool Transition {get; set;} = false;

        [Display(Name = "С асансьор")]
        public bool Elevator {get; set;} = false;

        [Display(Name = "В строеж")]
        public bool InBuilding {get; set;} = false;

         [Display(Name = "Лизинг")]
        public bool Credit {get; set;} = false;

        [Display(Name = "Ипотекиран")]
        public bool Martgage {get; set;} = false;

        [Display(Name = "Паркинг")]
        public bool Parking {get; set;} = false;

        [Display(Name = "Бартер")]
        public bool Trade {get; set;} = false;

        [Display(Name = "Интернет връзка")]
        public bool InternetConnection {get; set; } = false;

        [Display(Name = "Видео наблюдение")]
        public bool VideoSecurity {get; set;} = false;

        [Display(Name = "Контрол на достъп")]
        public bool AccsessControl {get; set;} = false;

        [Display(Name = "Охрана")]
        public bool Security {get; set;} = false;

        [Display(Name = "Саниран")]
        public bool Renovated {get; set;}

        [Display(Name = "С действащ бизнес")]
        public bool WithBussines {get; set;}
    }
}
