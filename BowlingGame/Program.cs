using System;



namespace BowlingGameNS
{
    public class BowlingGame
    {
        public int score { get; private set; }
        public int frame {get; private set;}

        public int turns {get; private set;}

        public int pins {get; private set;}

        public BowlingGame()
        {
            score = 0;
            frame = 1;
            pins = 10;
            turns = 2;
        }
        public void Roll()
        {   
            //If turns == 0 Reset pins to 10 and increase frame by 1 and reset turns to two
            if (turns == 0) {
                pins = 10;
                frame += 1;
                turns = 2;
            }


            //If pins == 0 Reset pins to 10 and increase frame by 1** depending on spare/strike logic


            Random random = new Random();
            int randomRoll = random.Next(0, pins);
            pins -= randomRoll;
            score += randomRoll;
            turns -= 1;
            
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
            game.Roll();
            Console.WriteLine(game.score);
        }
    }
}

