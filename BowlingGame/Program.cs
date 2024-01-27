using System;



namespace BowlingGame
{
    class BowlingGame
    {
        public int score { get; private set; }

        public BowlingGame()
        {
            score = 0;
        }
        public void Roll(int pins)
        {
            score += pins;
        }

        // public int GetScore()
        // {
        //     return score;
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get ready to lose in bowling there bucko!");
            BowlingGame game = new BowlingGame();
            Console.WriteLine(game.score);
            game.Roll(4);
            Console.WriteLine(game.score);
        }
    }
}

