using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels
{
    public class ContactViewModel
    {

        [Display(Name = "Тема")]
        [Required(ErrorMessage =  "Полето е задължително!")]
        public string Subject {get; set;}

        [Display(Name = "Име")]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string FirstName {get; set;}

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string LastName {get; set;}

        [Display(Name = "Имейл")]
        [EmailAddress(ErrorMessage = "Въведете валиден имейл адрес!")]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string Email {get; set;}

        [Required(ErrorMessage = "Полето е задължително!")]
        [Display(Name = "Съобщение")]
        public string Content {get; set;}

        [Required(ErrorMessage = "Моля въведете телефон за връзка!")]
        [Display(Name = "Телефон")]
        [Phone(ErrorMessage = "Моля въведете валиден телефон за в")]
        public string Phone {get; set;}
    }
}
