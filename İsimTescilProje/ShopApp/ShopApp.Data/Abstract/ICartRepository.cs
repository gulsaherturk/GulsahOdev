using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Data.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        List<Cart> GetAllWithProduct();
        Cart GetProductMatch(int productId);

        Cart GetByWithProduct(int cartId);
    }
}