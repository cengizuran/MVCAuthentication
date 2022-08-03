using MVCAuthentication.Models.Context;
using MVCAuthentication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication.DesignPatterns.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            AppUser au = new AppUser
            {
                UserName = "admin",
                Password = "admin",
                Role = Models.Enums.UserRole.Admin
            };

            AppUser au2 = new AppUser
            {
                UserName = "member",
                Password = "member",
                Role = Models.Enums.UserRole.Member
            };

            context.AppUsers.Add(au);
            context.AppUsers.Add(au2);
            context.SaveChanges();
        }
        
    }
}