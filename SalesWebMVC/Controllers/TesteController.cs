using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Teste()
        {
            return View();
        }

    }
}
