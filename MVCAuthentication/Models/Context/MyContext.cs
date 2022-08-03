using MVCAuthentication.DesignPatterns.StrategyPattern;
using MVCAuthentication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnectionWin")
        {
            Database.SetInitializer(new MyInit());
        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}