using PrimaImoti.DataModels;
using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels.ViewModels
{
    public class WaitingEstatesViewModel
    { 
        [Display(Name = "ID")]
        public int Id {get; set;}

        [Display(Name = "Име")]
        public string FirstName {get; set;}

        [Display(Name = "Фамилия")]
        public string LastName {get; set;}

        [Display(Name = "Телефон")]
        public string Phone {get; set;}

        [Display(Name = "Тип имот")]
        public PropertyType Type {get; set;}

        [Display(Name = "Точен")]
        public string Adress {get; set;}

        [Display(Name = "Дата")]
        public string Date {get; set;}

        [Display(Name = "Имейл")]
        public string Email {get; set;}
    }
}
