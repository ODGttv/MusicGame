namespace Music_Game.Models.Clue
{
    public interface IClue
    {
        public string ClueText { get; }
        public string? ClueData { get; set; }
        public string GetClue();
        public void Generate();
    }
}
