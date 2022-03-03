using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avansTeam.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace avansTeam.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaContext _context;

        public MovieController(CinemaContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.ToListAsync();

            return View(movies);
        }
    }
}
