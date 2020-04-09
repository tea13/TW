using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eUseControl.Domain
{
    public class UserDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }



        [Required]
        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Name must be more than 4 characters")]
        public string Username { get; set; }



        [Required(ErrorMessage = "Required")]
        [Display(Name = "Password")]
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



        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }



    }
}