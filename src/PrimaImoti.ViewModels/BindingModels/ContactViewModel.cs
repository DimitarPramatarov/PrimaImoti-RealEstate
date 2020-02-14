using System.ComponentModel.DataAnnotations;
using PrimaImoti.Common;

namespace PrimaImoti.ViewModels
{
    public class ContactViewModel
    {

        [Display(Name = "Тема")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage =  "Полето е задължително!")]
        public string Subject {get; set;}

        [Display(Name = "Име")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string FirstName {get; set;}

        [Display(Name = "Фамилия")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string LastName {get; set;}

        [Display(Name = "Имейл")]
        [EmailAddress(ErrorMessage = "Въведете валиден имейл адрес!")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string Email {get; set;}

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Полето е задължително!")]
        public string Message {get; set;}

        [Required(ErrorMessage = "Моля въведете телефон за връзка!")]
        [Display(Name = "Телефон")]
        [Phone]
        public string Phone {get; set;}
    }
}
