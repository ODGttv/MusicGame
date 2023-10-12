namespace Music_Game.Models.Clue
{
    public class ArtistLetter : IClue
    {
        public string ClueText { 
            get 
            {
                return "Play a song by an artist beginning with ";
            } 
        }
        public string? ClueData { get; set; }

        public ArtistLetter() { }

        public string GetClue()
        {
            return ClueText + ClueData;
        }

        public void Generate()
        {
            Random rnd = new Random();
            ClueData = ((char)(rnd.Next(65, 91))).ToString();
        }
    }
}
