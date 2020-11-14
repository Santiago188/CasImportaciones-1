using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CasImportaciones.Core.Domain;
using CasImportaciones.Infrastructure.Data;

namespace CasImportaciones.Web.Controllers
{
    public class OrdenVentaController : Controller
    {
        private readonly CasImportacionesDbContext _context;

        public OrdenVentaController(CasImportacionesDbContext context)
        {
            _context = context;
        }

        // GET: OrdenVentas
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdenVentas.ToListAsync());
        }

        // GET: OrdenVentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenVenta = await _context.OrdenVentas
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (ordenVenta == null)
            {
                return NotFound();
            }

            return View(ordenVenta);
        }

        // GET: OrdenVentas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdenVentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenta,FechaVenta,Cantidad,ValorTotal")] OrdenVenta ordenVenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordenVenta);
        }

        // GET: OrdenVentas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenVenta = await _context.OrdenVentas.FindAsync(id);
            if (ordenVenta == null)
            {
                return NotFound();
            }
            return View(ordenVenta);
        }

        // POST: OrdenVentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVenta,FechaVenta,Cantidad,ValorTotal")] OrdenVenta ordenVenta)
        {
            if (id != ordenVenta.IdVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenVenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenVentaExists(ordenVenta.IdVenta))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ordenVenta);
        }

        // GET: OrdenVentas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenVenta = await _context.OrdenVentas
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (ordenVenta == null)
            {
                return NotFound();
            }

            return View(ordenVenta);
        }

        // POST: OrdenVentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordenVenta = await _context.OrdenVentas.FindAsync(id);
            _context.OrdenVentas.Remove(ordenVenta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenVentaExists(int id)
        {
            return _context.OrdenVentas.Any(e => e.IdVenta == id);
        }
    }
}
