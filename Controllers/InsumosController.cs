using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ing.soft_I.Controllers
{
    public class InsumosController : Controller
    {
        private readonly ILogger<InsumosController> _logger;
    

        public InsumosController(ILogger<InsumosController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar()
        {
            return View("Index");
        }

        public IActionResult Confirmacion()
        {
            return View("Index");
        }

        public IActionResult ConfirmacionUpdate()
        {
            return View();
        }

        public IActionResult Crear()
        {
            return View();
        }



        
    }
}