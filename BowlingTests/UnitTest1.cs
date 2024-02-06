using BowlingGameNS;





namespace BowlingTests
{
    public class BowlingGameTests
    {
        [Fact]
        public void TestInitialCreation()
        {
            // Arrange
            BowlingGame bg = new BowlingGame();

            //Act
            int expected = 0;
            int actual = bg.score;
            //Assert
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void TestInitialRoll()
        {
            // Arrange
            BowlingGame bg = new BowlingGame();

            // Act
            bg.Roll();
            int actual = bg.score;
            int expected = 10 - bg.pins;

            //Assert
            Assert.Equal(expected, actual);
            
        }

         [Fact]
        public void TestInitialPins()
        {
            // Arrange
            BowlingGame bg = new BowlingGame();

            // Act
            int actual = bg.pins;
            int expected = 10;

            //Assert
            Assert.Equal(expected, actual);
            
        }



        [Fact]

        public void TestMultipleRandomRolls()
        {
            //Arrange
            BowlingGame bg = new BowlingGame();

            // Act
            bg.Roll();
            bg.Roll();
            bg.Roll();
            bg.Roll();
            bg.Roll();
            bg.Roll();
            int actual = bg.frame;
            int expected = 4;
         


            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]

        public void TestSingleTurn()
        {
            // Arrange
            BowlingGame bg = new BowlingGame();

            //Act

            bg.Roll();
            int expected = 1;
            int actual = bg.turns;

            // Assert
            Assert.Equal(expected, actual);

        }
        
        [Fact]

        public void TestPinReset()

        {
            BowlingGame bg = new BowlingGame();

            bg.Roll();
            bg.Roll();
     
            int expected = 10;
            int actual = bg.pins;

            Assert.Equal(expected,actual);
        }

        [Fact]

        public void TestRandomScore()
        {

            BowlingGame bg = new BowlingGame();

            bg.Roll();
            int expected = 10 - bg.pins ;
            int actual = bg.score;

            Assert.Equal(expected, actual);

        }

        [Fact]

        public void TestRandomScoreInRange()
        {
            BowlingGame bg = new BowlingGame();

            bg.Roll();
            int scoreValue = bg.score;

            Assert.InRange(scoreValue, -1, 11);

            
        }





    }


    
}
