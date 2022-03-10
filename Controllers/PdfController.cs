using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avansTeam.Data;
using Microsoft.AspNetCore.Mvc;
using avansTeam.Models;
using Microsoft.EntityFrameworkCore;
using Aspose.Pdf;

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
        public async Task<IActionResult> Index()
        {
            var movies = await (from movie in _context.Movies
                                where movie.Performances.Any()
                                select movie).Include(p =>
                                    p.Performances.Where(a =>
                                            a.startTime >= DateTime.Now && a.startTime <= DateTime.Today.AddDays(5)).OrderBy(o => o.startTime))
                                                .ThenInclude(performance => performance.Hall)
                                                .ToListAsync();

            // Initialize document object
            Document document = new Document();

            // Add page
            Page page = document.Pages.Add();

            // Add text to new page
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Bioscoopkaartje"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Spider man"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Far from Home"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("€12"));
            // Save PDF 
            document.Save("document.pdf");

            return View(movies);
        }
    }

}

