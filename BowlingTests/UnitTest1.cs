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
        public void TestTwoRolls()
        {
            // Arrange
            BowlingGame bg = new BowlingGame();

            // Act
            bg.Roll();
            bg.Roll();
            int actual = bg.score;
            int expected = 10 - bg.pins;

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
            int expected = 3;
         


            // Assert
            Assert.Equal(actual, expected);
        }

        // [fact]

        // public void TestSingleTurn()
        // {
        //     // Arrange
        //     BowlingGame bg = new BowlingGame();

        //     //Act

        //     bg.Roll();
        //     int expected = 1;
        //     int actual = bg.turns;

        //     // Assert
        //     Assert.Equal(expected, actual);

        // }

    }
    
}
