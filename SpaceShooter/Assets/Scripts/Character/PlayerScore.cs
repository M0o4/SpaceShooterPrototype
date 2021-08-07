namespace Character
{
    public static class PlayerScore 
    {
        public static int BestScore
        {
            get => _bestScore;
            set => _bestScore = value < 0 ? 0 : value;
        }

        public static int Score => _score;
        private static int _score;
        private static int _bestScore;
        

        public static void IncreaseScore()
        {
            _score++;
        }

        public static void ResetScore()
        {
            _score = 0;
        }
    }
}
