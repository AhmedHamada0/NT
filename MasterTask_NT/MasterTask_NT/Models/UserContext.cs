using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasterTask_NT.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DevDBContext")
        {

        }

       public DbSet <ClsUser> Users { get; set; }

       public DbSet<ClsBooks> Books { get; set; }
    }
}