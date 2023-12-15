using Apprisal.web.App_mvc_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Apprisal.web.App_mvc_.Controllers
{
    public class ApprisalsController : Controller
    {
        private readonly ApplicationContext _context;

        public ApprisalsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Apprisals
        public async Task<IActionResult> Index()
        {
            return _context.Form != null ?
                        View(await _context.Form.ToListAsync()) :
                        Problem("Entity set 'ApplicationContext.Form'  is null.");
        }

        // GET: Apprisals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Form == null)
            {
                return NotFound();
            }

            var apprisal = await _context.Form
                .FirstOrDefaultAsync(m => m.ApprisalId == id);
            if (apprisal == null)
            {
                return NotFound();
            }

            return View(apprisal);
        }

        // GET: Apprisals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Apprisals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApprisalEnitity apprisal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apprisal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(apprisal);
        }

        // GET: Apprisals/Edit/5    
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Form == null)
            {
                return NotFound();
            }

            var apprisal = await _context.Form.FindAsync(id);
            if (apprisal == null)
            {
                return NotFound();
            }
            return View(apprisal);
        }

        // POST: Apprisals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApprisalEnitity apprisal)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apprisal);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(ex);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(apprisal);
        }

        // GET: Apprisals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Form == null)
            {
                return NotFound();
            }

            var apprisal = await _context.Form
                .FirstOrDefaultAsync(m => m.ApprisalId == id);
            if (apprisal == null)
            {
                return NotFound();
            }

            return View(apprisal);
        }

        // POST: Apprisals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Form == null)
            {
                return Problem("Entity set 'ApplicationContext.Form'  is null.");
            }
            var apprisal = await _context.Form.FindAsync(id);
            if (apprisal != null)
            {
                _context.Form.Remove(apprisal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApprisalExists(int id)
        {
            return (_context.Form?.Any(e => e.ApprisalId == id)).GetValueOrDefault();
        }
    }
}
