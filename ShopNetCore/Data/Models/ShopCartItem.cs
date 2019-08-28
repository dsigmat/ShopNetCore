using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car car { get; set; }
        public int Price { get; set; }

        public string ShopCartId { get; set; }
    }
}
