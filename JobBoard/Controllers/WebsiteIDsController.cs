using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobBoard.Data;
using JobBoard.Models.WebsiteModel;

namespace JobBoard.Controllers
{
    public class WebsiteIDsController : Controller
    {
        private readonly JobBoardDbContext _context;

        public WebsiteIDsController(JobBoardDbContext context)
        {
            _context = context;    
        }

        // GET: WebsiteIDs
        public async Task<IActionResult> Index()
        {
            return View(await _context.WebsiteID.ToListAsync());
        }

        //// GET: Populate DB from JSON file
        //[HttpPost]
        //public Task<IActionResult> GetJSON(string path)
        //{
        //    return Index();
        //}

        // GET: WebsiteIDs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websiteID = await _context.WebsiteID.SingleOrDefaultAsync(m => m.ID == id);
            if (websiteID == null)
            {
                return NotFound();
            }

            return View(websiteID);
        }

        // GET: WebsiteIDs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebsiteIDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Company,DatePosted,Experience,Hours,JobTitle,Languages,Location,Salary,URL")] WebsiteID websiteID)
        {
            if (ModelState.IsValid)
            {
                _context.Add(websiteID);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(websiteID);
        }

        // GET: WebsiteIDs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websiteID = await _context.WebsiteID.SingleOrDefaultAsync(m => m.ID == id);
            if (websiteID == null)
            {
                return NotFound();
            }
            return View(websiteID);
        }

        // POST: WebsiteIDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Company,DatePosted,Experience,Hours,JobTitle,Languages,Location,Salary,URL")] WebsiteID websiteID)
        {
            if (id != websiteID.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(websiteID);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebsiteIDExists(websiteID.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(websiteID);
        }

        // GET: WebsiteIDs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var websiteID = await _context.WebsiteID.SingleOrDefaultAsync(m => m.ID == id);
            if (websiteID == null)
            {
                return NotFound();
            }

            return View(websiteID);
        }

        // POST: WebsiteIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var websiteID = await _context.WebsiteID.SingleOrDefaultAsync(m => m.ID == id);
            _context.WebsiteID.Remove(websiteID);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WebsiteIDExists(int id)
        {
            return _context.WebsiteID.Any(e => e.ID == id);
        }
    }
}
