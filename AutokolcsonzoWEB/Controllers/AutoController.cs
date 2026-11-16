using Microsoft.AspNetCore.Mvc;
using Autokolcsonzo.Services;
using AutokolcsonzoWEB.Models;

namespace AutokolcsonzoWEB.Controllers
{
    public class AutoController : Controller
    {
        public IAutokolcsonzoService Service;
        public AutoController(IAutokolcsonzoService s)
        {
            Service = s;
        }



        public IActionResult UjGyarto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UjGyarto(string nev)
        {
            bool sikeres = Service.UjGyarto(nev);
            if (sikeres)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult UjKategoria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UjKategoria(string nev)
        {
            bool sikeres = Service.UjKategoria(nev);
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
