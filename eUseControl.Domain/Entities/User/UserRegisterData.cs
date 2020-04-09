using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eUseControl.Domain.Entities.User
{
    public class UserRegisterData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Informatie { get; set; }
        public DateTime RegisterDateTime { get; set; }
    }
}