namespace Music_Game.Models.Clue
{
    public class SongLetter : IClue
    {
        public string ClueText { 
            get 
            {
                return "Play a song that begins with the letter ";
            } 
        }

        public string? ClueData { get; set; }

        public SongLetter() { }

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
