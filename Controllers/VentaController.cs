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
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;
        private readonly ApplicationDbContext _context;
     
        public VentaController(ILogger<VentaController> logger, ApplicationDbContext context)
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
        public IActionResult Venta(venta venta){
                _context.Add(venta);
                _context.SaveChanges();
                return RedirectToAction("index","Home");
        }
         [HttpPost]
        public IActionResult Editar_venta(String id){
                 var entity = _context.venta.FirstOrDefault(item => item.idventa == id);
                 return View(entity);             
        }
        [HttpPost]
        public IActionResult Editarr(venta venta){

                 var ventam = new venta();
                 ventam.fechaventa=venta.fechaventa;
                 ventam.descventa=venta.descventa;
                 ventam.precio=venta.precio;
                 ventam.cliente_documento=venta.cliente_documento;
                _context.venta.Update(ventam);
                _context.SaveChanges();
                 return View();             
        }
         public IActionResult Listado_Venta()
        {
            var ventas=_context.venta.ToList();
            return View(ventas);
        }
        public IActionResult Venta_Queso()
        {
            return View();
        }
    }
}