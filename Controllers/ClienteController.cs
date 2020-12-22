using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ing.soft_I.Data;
using Ing.soft_I.Models;

namespace Ing.soft_I.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ApplicationDbContext _context;
     
        public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext context)
        {
            _logger = logger; 
            _context = context;           
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
        public IActionResult Cliente()
        {
            return View();
        }
        public IActionResult Editar()
        {
            var cliente = new cliente();
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Cliente(cliente cliente){
                _context.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("index","Home");
        }
         [HttpPost]
        public IActionResult Editar(String documento){
                 var entity = _context.cliente.FirstOrDefault(item => item.documento == documento);
                 return View(entity);             
        }
        [HttpPost]
        public IActionResult Editarr(cliente cliente){

                 var clientem = new cliente();
                 clientem.documento=cliente.documento;
                 clientem.apepaterno=cliente.apepaterno;
                 clientem.apematerno=cliente.apematerno;
                _context.cliente.Update(clientem);
                _context.SaveChanges();
                 return View();             
        }
    }
}