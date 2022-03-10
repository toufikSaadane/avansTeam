using Microsoft.AspNetCore.Mvc;

namespace avansTeam.Controllers
{
    public class Ticket : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
