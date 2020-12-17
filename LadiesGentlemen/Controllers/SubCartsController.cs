using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LadiesGentlemen.Data;
using LadiesGentlmen.Models;

namespace LadiesGentlemen.Controllers
{
    public class SubCartsController : Controller
    {
        private readonly LadiesGentlemenContext _context;

        public SubCartsController(LadiesGentlemenContext context)
        {
            _context = context;
        }

        // GET: SubCarts
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubCart.ToListAsync());
        }

        // GET: SubCarts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCart = await _context.SubCart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCart == null)
            {
                return NotFound();
            }

            return View(subCart);
        }

        // GET: SubCarts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubCarts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity")] SubCart subCart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subCart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subCart);
        }

        // GET: SubCarts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCart = await _context.SubCart.FindAsync(id);
            if (subCart == null)
            {
                return NotFound();
            }
            return View(subCart);
        }

        // POST: SubCarts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity")] SubCart subCart)
        {
            if (id != subCart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subCart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCartExists(subCart.Id))
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
            return View(subCart);
        }

        // GET: SubCarts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCart = await _context.SubCart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCart == null)
            {
                return NotFound();
            }

            return View(subCart);
        }

        // POST: SubCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subCart = await _context.SubCart.FindAsync(id);
            _context.SubCart.Remove(subCart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCartExists(int id)
        {
            return _context.SubCart.Any(e => e.Id == id);
        }
    }
}
