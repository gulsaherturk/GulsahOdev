﻿using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void Create(Cart entity)
        {
            _cartRepository.Create(entity);
        }

        public void Delete(Cart entity)
        {
            _cartRepository.Delete(entity);
        }

        public List<Cart> GetAll()
        {
            return _cartRepository.GetAll();
        }

        public List<Cart> GetAllWithProduct()
        {
            return _cartRepository.GetAllWithProduct();
        }

        public Cart GetByWithProduct(int cart)
        {
            return _cartRepository.GetByWithProduct(cart);
        }

        public Cart GetProductMatch(int productId)
        {
            return _cartRepository.GetProductMatch(productId);
        }

        public Cart GeyById(int id)
        {
            return _cartRepository.GetById(id);
        }

        public void Update(Cart entity)
        {
            _cartRepository.Update(entity);
        }
    }
}
