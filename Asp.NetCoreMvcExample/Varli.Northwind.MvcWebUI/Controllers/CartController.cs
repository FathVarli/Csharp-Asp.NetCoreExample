﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varli.Northwind.Business.Abstract;
using Varli.Northwind.Entities.Concrete;
using Varli.Northwind.MvcWebUI.Models;
using Varli.Northwind.MvcWebUI.Services;

namespace Varli.Northwind.MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService,ICartService cartService,IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product, {0}, was succesfully added to the cart!", productToBeAdded.ProductName));

            return RedirectToAction("index", "Product");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product was succesfully removed from the cart!"));
            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };

            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message",String.Format( "Thank you {0}, you order is in process", shippingDetails.FirstName));
            return View();
        }

    }
}
