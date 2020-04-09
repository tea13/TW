using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace eUseControl.Web.Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "• The Username field is empty.")]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "• Username must be more than 4 characters.")]



        public string Credential { get; set; }



        [Required(ErrorMessage = "• The Password field is empty.")]
        [Display(Name = "Password")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "• Password must be more than 5 characters.")]
        public string Password { get; set; }



        [Required(ErrorMessage = "• The Email field is empty.")]
        [EmailAddress(ErrorMessage = "• The Email Address field is not a valid e-mail address.")]
        [Display(Name = "Email Address")]
        [StringLength(30, ErrorMessage = "• Email must be less then 30 characters.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "• The Information field is empty.")]
        [Display(Name = "Info")]
        [StringLength(300, ErrorMessage = "• Information must be less then 300 characters.")]
        public string Informatie { get; set; }



    }
}