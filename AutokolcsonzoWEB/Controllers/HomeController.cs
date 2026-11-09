using Autokolcsonzo.Services;
using AutokolcsonzoWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutokolcsonzoWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAutokolcsonzoService _service;

        public HomeController(IAutokolcsonzoService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            
            return View(_service.Autok());
        }

    }
}
