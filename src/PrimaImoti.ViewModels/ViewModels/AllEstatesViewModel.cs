using PrimaImoti.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimaImoti.ViewModels.ViewModels
{
    public class AllEstatesViewModel
    {

        [Display(Name = "Тип Имот")]
        public PropertyType Type { get; set; }

        [Display(Name = "Заглавие")]
        public decimal Price{ get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Локация")]
        public string Location { get; set; }

        [Display(Name = "Площ Кв/м")]
        public int Area { get; set; }

        [Display(Name = "Обзавеждане")]
        public string Furniture { get; set; }

        [Display(Name = "Строителство")]
        public string Building { get; set; }
               
        [Display(Name = "Отопление")]
        public string Heating { get; set; }

        public byte[] Images { get; set; }
    }
}
