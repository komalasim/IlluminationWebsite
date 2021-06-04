using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBProject.Models
{
    public class Cart
    {
        public string title { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public List<Cart> Cart_Info { get; set; }
    }
}