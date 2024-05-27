using System;
using System.ComponentModel.DataAnnotations;

namespace TelerikBlazorDemos.Models.Form
{
    public class User
    {
      

        [Display(Name = "Email*:")]
        [Required(ErrorMessage = "You must specify email.")]
        public string Email { get; set; }

        [Display(Name = "Password*:")]
        [MinLength(8, ErrorMessage = "Your password should be at least 8 characters.")]
        [Required(ErrorMessage = "Your password should be at least 8 characters.")]
        public string Password { get; set; }

      
        public User()
        {
        }
    }
}