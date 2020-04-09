using eUseControl.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace eUseControl.BusinessLogic
{
    class UserContext : DbContext
    {
        public UserContext() :
        base("name = MyProjectDB")
        {
        }
        public virtual DbSet<UserDbTable> Users { get; set; }
    }
}
