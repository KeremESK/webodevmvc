﻿using Microsoft.AspNetCore.Mvc;

namespace webodevmvc.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
