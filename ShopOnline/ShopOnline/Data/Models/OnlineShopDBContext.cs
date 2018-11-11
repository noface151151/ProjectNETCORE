using Microsoft.EntityFrameworkCore;
using ShopOnlineData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Data.Models
{
    public class OnlineShopDBContext:DbContext
    {
        public OnlineShopDBContext(DbContextOptions<OnlineShopDBContext> options) : base(options)
        {

        }
        public OnlineShopDBContext() { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<MainGroup> MainGroups { get; set; }
    }
}
