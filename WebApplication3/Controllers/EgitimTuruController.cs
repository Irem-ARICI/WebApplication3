using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EgitimTuruController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext _applicationDbContext;
        public EgitimTuruController(ApplicationDbContext context)   //applicationDbContext
        {
            _applicationDbContext = context;
        }
        public IActionResult Index()
        {
            List<EgitimTuru> objEgitimTuruList = _applicationDbContext.EgitimTurleri.ToList();
            return View(objEgitimTuruList);
        }
    }
}
