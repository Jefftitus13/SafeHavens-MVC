﻿using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
