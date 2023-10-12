using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Music_Game.Models.Clue
{
    public class Year : IClue
    {
        public string ClueText
        {
            get
            {
                return "Play a song from the ";
            }
        }
        public string? ClueData { get; set; }
        private string[] decades = { "1950's", "1960's", "1970's", "1980's", "1990's", "2000's", "2010's", "2020's" };

        public Year() { }

        public string GetClue()
        {
            return ClueText + ClueData;
        }

        public void Generate()
        {
            Random rnd = new Random();
            ClueData = decades[rnd.Next(0, decades.Length)];
        }
    }
}
