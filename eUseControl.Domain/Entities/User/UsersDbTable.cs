using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Enums;



namespace eUseControl.Domain.Entities.User
{
    public class UsersDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }



        [Required]
        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Name must be more than 4 characters")]
        public string Username { get; set; }



        [Required]
        [Display(Name = "Password")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Password must be more than 8 characters")]
        public string Password { get; set; }



        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        [StringLength(30)]
        public string Email { get; set; }



        [Required]
        [Display(Name = "Info")]
        [StringLength(300)]
        public string Info { get; set; }

        public URole Level { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }



    }
}