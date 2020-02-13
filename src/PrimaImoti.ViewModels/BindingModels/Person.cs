using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.ViewModels.BindingModels
{
    public class Person
    {
        [Display(Name = "Име")]
        [Required]
        public string FirstName {get; set;}

        [Display(Name = "Фамилия")]
        [Required]
        public string LastName {get; set;}

        [Display(Name = "Имейл")]
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        
        [Required]
        [Display(Name = "Телефон")]
        [Phone]
        public string Phone {get; set;}


    }
}
