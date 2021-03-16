using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoterSystem.Data;
using VoterSystem.Models;

namespace VoterSystem.Controllers
{
    public class ApplicantVotesController : Controller
    {
        private readonly ApplicantDbContext _context;

        public ApplicantVotesController(ApplicantDbContext context)
        {
            _context = context;
        }

        // GET: ApplicantVotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApplicantVotes.ToListAsync());
        }

        // GET: ApplicantVotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantVotes = await _context.ApplicantVotes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantVotes == null)
            {
                return NotFound();
            }

            return View(applicantVotes);
        }

        // GET: ApplicantVotes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicantVotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Applicant,ElectionCount")] ApplicantVotes applicantVotes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicantVotes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicantVotes);
        }

        // GET: ApplicantVotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantVotes = await _context.ApplicantVotes.FindAsync(id);
            if (applicantVotes == null)
            {
                return NotFound();
            }
            return View(applicantVotes);
        }

        // POST: ApplicantVotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Applicant,ElectionCount")] ApplicantVotes applicantVotes)
        {
            if (id != applicantVotes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicantVotes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantVotesExists(applicantVotes.Id))
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
            return View(applicantVotes);
        }

        // GET: ApplicantVotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantVotes = await _context.ApplicantVotes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantVotes == null)
            {
                return NotFound();
            }

            return View(applicantVotes);
        }

        // POST: ApplicantVotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicantVotes = await _context.ApplicantVotes.FindAsync(id);
            _context.ApplicantVotes.Remove(applicantVotes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantVotesExists(int id)
        {
            return _context.ApplicantVotes.Any(e => e.Id == id);
        }
    }
}
