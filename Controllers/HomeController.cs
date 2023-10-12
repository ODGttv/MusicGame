using Microsoft.AspNetCore.Mvc;
using Music_Game.Models;
using Music_Game.Models.Clue;
using System.Diagnostics;

namespace Music_Game.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("GetClues")]
        public ActionResult<string[]> GetClueList(int length)
        {
            List<string> clues = new List<string>();
            Random rnd = new Random();
            
            while (clues.Count < length)
            {
                int clueType = rnd.Next(0, 3);
                IClue clue;
                if (clueType == 0)
                    clue = new Year();
                else if (clueType == 1)
                    clue = new ArtistLetter();
                else
                    clue = new SongLetter();

                clue.Generate();

                if (!clues.Contains(clue.GetClue()))
                    clues.Add(clue.GetClue());
            }

            return clues.ToArray();
        }
    }
}