using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration
{
    public class LoginRegistrationDB : DbContext
    {
        public LoginRegistrationDB(DbContextOptions<LoginRegistrationDB> dbContextOptions) : base(dbContextOptions)
        {

        }
       
        //add all the tables from the database like student table
    }
}
