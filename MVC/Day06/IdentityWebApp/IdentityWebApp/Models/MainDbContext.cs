using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdentityWebApp.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("conn")
        { }
        public DbSet<User> users { get; set; }
    }

}