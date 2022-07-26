using Microsoft.AspNetCore.Mvc;
using VideoGameStore_Excercise.Data;
using VideoGameStore_Excercise.Models.Entities;

namespace VideoGameStore_Excercise.Controllers
{

    public class GameTitleController : Controller
    {
        public readonly ApplicationDBContext _context;

        public GameTitleController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<GameTitle> gametitles = _context.GameTitles.ToList();
            return View();
        }
    }
}
