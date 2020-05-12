using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Domain.Enums;

namespace eUseControl.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public URole Level { get; set; }
    }
}