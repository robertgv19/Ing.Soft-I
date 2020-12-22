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
using Microsoft.AspNetCore.Identity;

namespace Ing.soft_I.Controllers
{
    public class InsumosController : Controller
    {
        private readonly ILogger<InsumosController> _logger;
        private readonly ApplicationDbContext _context;
     
        public InsumosController(ILogger<InsumosController> logger, ApplicationDbContext context)
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
        public IActionResult Insumo()
        {
            return View();
        }
        public IActionResult Editar()
        {
            var insumo = new insumo();
            return View(insumo);
        }
        [HttpPost]
        public IActionResult Insumo(insumo insumo){
                _context.Add(insumo);
                _context.SaveChanges();
                return RedirectToAction("index","Home");
        }
        public IActionResult Modificar_insumo(String id){
                 var entity = _context.insumo.FirstOrDefault(item => item.idinsumo == id);
                 return View(entity);            
        }
        [HttpPost]
        public IActionResult Editarr(insumo insumo){

                 var insumom = new insumo();
                insumom.idinsumo=insumo.idinsumo;
                insumom.nominsumo=insumo.nominsumo;
                insumom.descinsumo=insumo.descinsumo;
                insumom.cantinsumo=insumo.cantinsumo;
                _context.insumo.Update(insumom);
                _context.SaveChanges();
                 return View();             
        }
          public IActionResult Stock_insumos()
        {
            var insumos=_context.insumo.ToList();
            return View(insumos);
        }
        public IActionResult Nuevo_insumo()
        {
            return View();
        }
       
    }
}