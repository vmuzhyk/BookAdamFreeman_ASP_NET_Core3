﻿using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System.Linq;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*var names = new[] { "Kayak", "Lifejacket", "Soccer ball" }; 
            return View(names);*/

            var products = new[] 
            { 
                new { Name = "Kayak", Price = 275M }, 
                new { Name = "Lifejacket", Price = 48.95M }, 
                new { Name = "Soccer ball", Price = 19.50M }, 
                new { Name = "Corner flag", Price = 34.95M } 
            };
            //return View(products.Select(p => p.Name));
            return View(products.Select(p => p.GetType().Name));
        }
    }
}
