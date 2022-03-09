using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avansTeam.Data;
using Microsoft.AspNetCore.Mvc;
using avansTeam.Models;
using Microsoft.EntityFrameworkCore;
namespace avansTeam.Controllers
{
    public class PdfController : Controller
    {
        // GET: /<PdfController>/<id>/
        private readonly CinemaContext _context;

        public PdfController(CinemaContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(int id)
        {
            var performances = await (from performance in _context.Performances
                                where performance.Id == id select performance).Include(p => p)
                                                .ThenInclude(performance => performance.Hall)
                                                .ToListAsync();

            return View(performances);
        }
    }

}

