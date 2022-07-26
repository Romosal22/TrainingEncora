using Microsoft.AspNetCore.Mvc;
using VideoGameStore_Excercise.Data;
using VideoGameStore_Excercise.Models.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameStore_Excercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        public readonly ApplicationDBContext _context;

        public VideoGameController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<VideoGameController>
        [HttpGet]
        public IEnumerable<GameTitle> GetAll()
        {
            List<GameTitle> videogames = _context.GameTitles.ToList();
            List<string> gametitles = new List<string>();
            foreach (var videogame in videogames)
            {
                gametitles.Add(videogame.Name);
            }

            return videogames;
        }

        // GET api/<VideoGameController>/5
        [HttpGet("{id}")]
        public GameTitle Get(int id)
        {
            var gameTitle = _context.GameTitles.FirstOrDefault(x => x.Id == id);

            return gameTitle;
        }

        // POST api/<VideoGameController>
        [HttpPost]
        public void Create(GameTitle game)
        {
            if (ModelState.IsValid)
            {
                _context.GameTitles.Add(game);
                _context.SaveChanges();
            }
        }

        // PUT api/<VideoGameController>/5
        [HttpPut]
        public void Put(GameTitle game)
        {

            if (ModelState.IsValid)
            {
                //var gameTitle = _context.GameTitles.FirstOrDefault(x => x.Id == id);
                _context.GameTitles.Update(game);
                _context.SaveChanges();
            }
        }

        // DELETE api/<VideoGameController>/5
        [HttpDelete("{id}")]
        public void Delete(int? id)
        {
            if(id != null)
            {
                var gameTitle = _context.GameTitles.FirstOrDefault(x => x.Id == id);
                _context.GameTitles.Remove(gameTitle);
                _context.SaveChanges();
            }
        }
    }
}
