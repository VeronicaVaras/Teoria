using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Busco.Models;
using Busco.Data;

namespace Busco.Controllers
{
    public class ProductoController : Controller
    {

       private readonly ILogger<ProductoController> _logger;
       private readonly ApplicationDbContext _context;


        public ProductoController(ILogger<ProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listProductos=_context.Productos.ToList();
            return View(listProductos);
        }

        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(Producto objProducto){
            if (ModelState.IsValid)
            {
                _context.Add(objProducto);
                _context.SaveChanges();
                objProducto.Response = "Gracias estamos en contacto";
                return RedirectToAction("Index");
            }
            return View(objProducto);
        }
       

    }
}