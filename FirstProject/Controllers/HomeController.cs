﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Goog Afternoon";
            return View("MyView", viewModel);
        }

    }
}
