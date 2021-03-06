﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace LanguageFeatures.Controllers
{ public class HomeController : Controller
    {
        /*public ViewResult Index() 
        {
            IProductSelection cart = new ShoppingCart(
                new Product { Name = "Kayak", Price = 275M }, 
                new Product { Name = "Lifejacket", Price = 48.95M }, 
                new Product { Name = "Soccer ball", Price = 19.50M }, 
                new Product { Name = "Corner flag", Price = 34.95M }
                );
            return View(cart.Names);
        }*/
        /*public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength(); 
            return View(new string[] { $"Length:{length}" });
        }*/

        /*public async Task<ViewResult> Index()
        {
            List<string> output = new List<string>(); 
            await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
            { 
                output.Add($"Page length: { len}"); 
            }
            return View(output);
        }*/
        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
