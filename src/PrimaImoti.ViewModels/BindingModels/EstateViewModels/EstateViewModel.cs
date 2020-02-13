using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels.EstateViewModels
{
    public class EstateViewModel
    {
        // public EstateViewModel(string adress, int area, string furniture, string building,
        //     int buildFloor, string heating, string location)
        // {
        //     this.Location = location;
        //     this.Adress = adress;
        //     this.Area = area;
        //     this.Furniture = furniture;
        //     this.Building = building;
        //     this.BuildFloor = buildFloor;
        //     this.Heating = heating;
        // }

        public EstateViewModel()
        {

        }

        [Required]
        [Display(Name = "Локация")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Required]
        [Range(0, 10000, ErrorMessage = "Въведете пложително число")]
        [Display(Name = "Площ Кв/м")]
        public int Area { get; set; }

        [Required]
        [Display(Name = "Обзавеждане")]
        public string Furniture { get; set; }

        [Required]
        [Display(Name = "Строителство")]
        public string Building { get; set; }

        [Required]
        [Display(Name = "Брой етажи на сградата")]
        public int BuildFloor { get; set; }

        [Required]
        [Display(Name = "Отопление")]
        public string Heating { get; set; }
    }
}
