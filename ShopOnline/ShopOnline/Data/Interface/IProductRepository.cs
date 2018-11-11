using ShopOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopOnline.Data.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindProductWithCondition(Expression<Func<Product, bool>> predicate);
    }
}
