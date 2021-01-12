﻿using Abc.Nortwind.Business.Abstract;
using Abc.Nortwind.Entities.Concrete;
using Abc.Nortwind.MvcWebUI.Models;
using Abc.Nortwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Nortwind.MvcWebUI.Controllers
{
    public class CartController : Controller
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
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product ,{0}, was succesfully added to cart!", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }
        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartListViewMoel = new CartSummaryViewModel
            {
                Cart = cart 
            };
            return View(cartListViewMoel);
        }
        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product was succesfully removed from cart!"));
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
            TempData.Add("message", String.Format("Thank you {0},your order in process",shippingDetails.FirstName));
            return View();
        }
    }
}
