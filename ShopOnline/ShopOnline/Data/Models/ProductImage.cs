using ShopOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlineData.Data.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImageLink { get; set; }
        public Product Product { get; set; }
    }
}
