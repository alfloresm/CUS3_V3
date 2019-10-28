using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CUS3_V3.Models;

namespace CUS3_V3.Controllers
{
    public class TPuntajesController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TPuntajesController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TPuntajes
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TPuntaje.Include(t => t.FkVumtCodNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }


        // GET: TPuntajes/Create
        
        public IActionResult Create()
        {
            TempData["tanda"] = ViewData["tan"];
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod");
            return View();
        }
        

        // POST: TPuntajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIpCodP,IpPuntaje,IpNumeroJurado,FkVumtCod")] TPuntaje tPuntaje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tPuntaje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod", tPuntaje.FkVumtCod);
            return View(tPuntaje);
        }

        // GET: TPuntajes/Edit/5
      

        // POST: TPuntajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        private bool TPuntajeExists(int id)
        {
            return _context.TPuntaje.Any(e => e.PkIpCodP == id);
        }
    }
}
