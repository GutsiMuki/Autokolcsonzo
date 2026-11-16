using Microsoft.AspNetCore.Mvc;
using Autokolcsonzo.Services;
using AutokolcsonzoWEB.Models;
using Autokolcsonzo.Models;

namespace AutokolcsonzoWEB.Controllers
{
    public class UgyfelController : Controller
    {
        public readonly IAutokolcsonzoService Service;
        public UgyfelController(IAutokolcsonzoService s)
        {
            Service = s;
        }
        public IActionResult UjUgyfel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UjUgyfel(Ugyfel U)
        {
            bool sikeres = Service.UjUgyfel(U);
            if (sikeres)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
