﻿using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
