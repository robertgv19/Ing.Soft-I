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
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;            
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirmacion()
        {
            return View();
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