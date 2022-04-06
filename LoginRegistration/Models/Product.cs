using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }

    }
    public class Acer : Product
    {
      
    }

    public class Dell : Product
    {

    }
    public class Asus : Product
    {

    }
    public class Hp : Product
    {

    }
    public class Lenovo : Product
    {

    }
}
