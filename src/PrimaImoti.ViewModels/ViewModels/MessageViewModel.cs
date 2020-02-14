using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels
{
    public class MessagesViewModel
    {
        [Display(Name = "Заглавие")]
        [DataType(DataType.Text)]
        public string Title{get; set;}

        [Display(Name = "Име")]
        [DataType(DataType.Text)]
        public string FirstName {get; set;}

        [Display(Name = "Фамилия")]
        [DataType(DataType.Text)]
        public string LastName {get; set;}

        [Display(Name = "Телефон")]
        public string Phone {get; set;}

        [Display(Name = "Email")]
        public string Email {get; set;}

        [Display(Name = "Съобщение")]
        [DataType(DataType.MultilineText)]
        public string Message {get; set;}

        [Display(Name = "Дата")]
        public string Date {get; set;}

    }
}
