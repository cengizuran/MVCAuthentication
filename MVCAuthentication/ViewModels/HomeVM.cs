using MVCAuthentication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication.ViewModels
{
    public class HomeVM
    {
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }

    }
}