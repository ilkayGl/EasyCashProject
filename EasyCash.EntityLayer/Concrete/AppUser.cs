using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [NotMapped]
        public string FullName => Name + " " + Surname;

        public string Districk { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }

        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
