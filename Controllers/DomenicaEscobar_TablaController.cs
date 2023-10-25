using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DomenicaEscobar_ExamenP1.Data;
using DomenicaEscobar_ExamenP1.Models;

namespace DomenicaEscobar_ExamenP1.Controllers
{
    public class DomenicaEscobar_TablaController : Controller
    {
        private readonly DomenicaEscobar_ExamenP1Context _context;

        public DomenicaEscobar_TablaController(DomenicaEscobar_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: DomenicaEscobar_Tabla
        public async Task<IActionResult> Index()
        {
              return _context.DomenicaEscobar_Tabla != null ? 
                          View(await _context.DomenicaEscobar_Tabla.ToListAsync()) :
                          Problem("Entity set 'DomenicaEscobar_ExamenP1Context.DomenicaEscobar_Tabla'  is null.");
        }

        // GET: DomenicaEscobar_Tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DomenicaEscobar_Tabla == null)
            {
                return NotFound();
            }

            var domenicaEscobar_Tabla = await _context.DomenicaEscobar_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domenicaEscobar_Tabla == null)
            {
                return NotFound();
            }

            return View(domenicaEscobar_Tabla);
        }

        // GET: DomenicaEscobar_Tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DomenicaEscobar_Tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DEAtributo1,DEAtributo2,DEAtributo3,DEFecha")] DomenicaEscobar_Tabla domenicaEscobar_Tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domenicaEscobar_Tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(domenicaEscobar_Tabla);
        }

        // GET: DomenicaEscobar_Tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DomenicaEscobar_Tabla == null)
            {
                return NotFound();
            }

            var domenicaEscobar_Tabla = await _context.DomenicaEscobar_Tabla.FindAsync(id);
            if (domenicaEscobar_Tabla == null)
            {
                return NotFound();
            }
            return View(domenicaEscobar_Tabla);
        }

        // POST: DomenicaEscobar_Tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DEAtributo1,DEAtributo2,DEAtributo3,DEFecha")] DomenicaEscobar_Tabla domenicaEscobar_Tabla)
        {
            if (id != domenicaEscobar_Tabla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domenicaEscobar_Tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomenicaEscobar_TablaExists(domenicaEscobar_Tabla.Id))
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
            return View(domenicaEscobar_Tabla);
        }

        // GET: DomenicaEscobar_Tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DomenicaEscobar_Tabla == null)
            {
                return NotFound();
            }

            var domenicaEscobar_Tabla = await _context.DomenicaEscobar_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domenicaEscobar_Tabla == null)
            {
                return NotFound();
            }

            return View(domenicaEscobar_Tabla);
        }

        // POST: DomenicaEscobar_Tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DomenicaEscobar_Tabla == null)
            {
                return Problem("Entity set 'DomenicaEscobar_ExamenP1Context.DomenicaEscobar_Tabla'  is null.");
            }
            var domenicaEscobar_Tabla = await _context.DomenicaEscobar_Tabla.FindAsync(id);
            if (domenicaEscobar_Tabla != null)
            {
                _context.DomenicaEscobar_Tabla.Remove(domenicaEscobar_Tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomenicaEscobar_TablaExists(int id)
        {
          return (_context.DomenicaEscobar_Tabla?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
