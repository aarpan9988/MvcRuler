using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcRuler.Data;
using MvcRuler.Models;

namespace MvcRuler.Controllers
{
    public class RulersController : Controller
    {
        private readonly MvcRulerContext _context;

        public RulersController(MvcRulerContext context)
        {
            _context = context;
        }

        // GET: Rulers

        public async Task<IActionResult> Index(string rulerMaterial, string searchString)
        {
            // Use LINQ to get list of Materials.
            IQueryable<string> materialQuery = from m in _context.Ruler
                                               orderby m.Material
                                               select m.Material;

            var rulers = from m in _context.Ruler
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                rulers = rulers.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(rulerMaterial))
            {
                rulers = rulers.Where(x => x.Material == rulerMaterial);
            }

            var rulerMaterialVM = new RulerMaterialViewModel
            {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Rulers = await rulers.ToListAsync()
            };

            return View(rulerMaterialVM);
        }
        [HttpPost]
        public string Index(string searchString, bool notUsed)                  // To specify the path of searchString in URL
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
        // GET: Rulers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // GET: Rulers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rulers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Purpose,Material,Length,Price")] Ruler ruler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ruler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ruler);
        }

        // GET: Rulers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler.FindAsync(id);
            if (ruler == null)
            {
                return NotFound();
            }
            return View(ruler);
        }

        // POST: Rulers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Purpose,Material,Length,Price")] Ruler ruler)
        {
            if (id != ruler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ruler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RulerExists(ruler.Id))
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
            return View(ruler);
        }

        // GET: Rulers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // POST: Rulers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ruler = await _context.Ruler.FindAsync(id);
            _context.Ruler.Remove(ruler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RulerExists(int id)
        {
            return _context.Ruler.Any(e => e.Id == id);
        }
    }
}
