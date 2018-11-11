using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Data.Models
{
    public class MainGroup
    {
        public int MainGroupId { get; set; }
        public string MainGroupName { get; set; }
        public  ICollection<Product> Products { get; set; }

    }
}
