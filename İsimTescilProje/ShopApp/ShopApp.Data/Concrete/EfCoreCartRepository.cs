using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Data.Concrete
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart, ShopContext>, ICartRepository
    {
        public List<Cart> GetAllWithProduct()
        {
            using (var context = new ShopContext())
            {
                var All = context.Carts.Include(i => i.Product).ToList();
                return All;
            }
        }

        public Cart GetProductMatch(int productId)
        {
            using (var context = new ShopContext())
            {
                return context.Carts.Where(i => i.ProductId == productId).FirstOrDefault();
            }
        }

        public Cart GetByWithProduct(int cartId)
        {
            using (var context = new ShopContext())
            {
                return context.Carts.Where(i => i.ProductId == cartId).Include(i => i.Product).FirstOrDefault();
            }
        }
    }
}
