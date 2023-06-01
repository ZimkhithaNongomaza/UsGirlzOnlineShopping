﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping2.Models;
using OnlineShopping2.Infrastructure;
using OnlineShopping2.Models.ViewModels;

namespace OnlineShopping2.Controllers
{
    public class CartController: Controller
    {
        private IProduct repository;
        private Cart cart;
        public CartController(IProduct repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;

        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
                {
                Cart = cart,
                    ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart( int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productId,string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (product !=null)
            {
               
                cart.RemoveLine(product);
          
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
        
    }
}
