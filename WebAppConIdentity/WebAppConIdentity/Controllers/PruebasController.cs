using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppConIdentity.Controllers
{
    public class PruebasController : Controller
    {
        public IActionResult Index()
        {
            return View("Informacion", "Esta es la página Principal");
        }

         public IActionResult Funcion1()
        {
            return View("Informacion", "Esta es una función sin acceso restringido");
        }

        [Authorize]
        public IActionResult Funcion2()
        {
            return View("Informacion", $"Esta es una función con acceso restringido. Está siendo accedida por {User?.Identity?.Name}");
        }
    }
}