using ShopOnline.Data.Interface;
using ShopOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(OnlineShopDBContext context) : base(context)
        {
        }
        public IEnumerable<Product> FindProductWithCondition(Expression<Func<Product, bool>> predicate)
        {
            if (predicate == null)
                return _context.Set<Product>();
            return _context.Set<Product>().Where(predicate);
        }
    }
}
