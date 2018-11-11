using ShopOnlineData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Desciption { get; set; }
        public decimal Price { get; set; }
        public MainGroup MainGroup { get; set; }
        public string ProductImage { get; set; }
    }
}
