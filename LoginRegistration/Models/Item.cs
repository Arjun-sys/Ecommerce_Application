using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.Models
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
  
    public class DellItem
    {
        public Dell Dell { get; set; }
        public int Quantity { get; set; }
    }
    public class AcerItem
    {
        public Acer Acer { get; set; }
        public int Quantity { get; set; }
    }
    public class HpItem
    {
        public Hp Hp { get; set; }
        public int Quantity { get; set; }
    }
    public class AsusItem
    {
        public Asus Asus { get; set; }
        public int Quantity { get; set; }
    }

    public class LenovoItem
    {
        public Lenovo Lenovo { get; set; }
        public int Quantity { get; set; }
    }
  





















}
