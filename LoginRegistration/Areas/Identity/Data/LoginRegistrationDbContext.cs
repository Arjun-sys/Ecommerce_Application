using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginRegistration.Areas.Identity.Data;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Data
{
    public class LoginRegistrationDbContext : IdentityDbContext<LoginRegistrationUser>
    {
        public LoginRegistrationDbContext(DbContextOptions<LoginRegistrationDbContext> options)
            : base(options)
        {
        }
     
      
    }
}
