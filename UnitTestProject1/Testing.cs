using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Services;


namespace TicTacToeTesting
{

    [TestClass]
    public class GameWinnerServiceTests 
    {
        private IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;

        [TestInitialize]
        public void SetupUnitTests()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3]
                  {
                      {' ', ' ', ' '},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                  };
        }
                           
        [TestMethod]
        public void PlayerWithAllSpacesInTopRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 0; rowIndex < 3; rowIndex++)//[0,?] - [0,0], [0,1], [0,2]
                {
                    _gameBoard[0, rowIndex] = expected[testnumber];
                }
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
            }

        
        [TestMethod]
        public void PlayerWithAllSpacesInMiddleRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 0; rowIndex < 3; rowIndex++)//[1,?] - [1,0], [1,1], [1,2]
                {
                    _gameBoard[1, rowIndex] = expected[testnumber];
                }
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
             }
        

        [TestMethod]
        public void PlayerWithAllSpacesInBottomRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 0; rowIndex < 3; rowIndex++)//[2,?] - [2,0], [2,1], [2,2]
                {
                    _gameBoard[2, rowIndex] = expected[testnumber];
                }
                    actual = _gameWinnerService.Validate(_gameBoard);
                    Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
            }
        
       
        [TestMethod]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    _gameBoard[columnIndex, 0] = expected[testnumber]; //[?,0] - [0,0], [1,0], [2,0]
                }
                    actual = _gameWinnerService.Validate(_gameBoard);
                    Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
              }
           }
        

        [TestMethod]
        public void PlayerWithAllSpacesInSecondColumnIsWinner()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    _gameBoard[columnIndex, 1] = expected[testnumber]; //[?,1] - [0,1], [1,1], [2,1]
                }
                    actual = _gameWinnerService.Validate(_gameBoard);
                    Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
            }
        

        [TestMethod]
        public void PlayerWithAllSpacesInThirdColumnIsWinner()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    _gameBoard[columnIndex, 2] = expected[testnumber]; //[?,2] - [0,2], [1,2], [2,2]
                }
                    actual = _gameWinnerService.Validate(_gameBoard);
                    Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
            }
        

        [TestMethod]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var cellIndex = 0; cellIndex < 3; cellIndex++)
                {
                    _gameBoard[cellIndex, cellIndex] = expected[testnumber]; // [0,0], [1,1], [2,2]
                }
                    actual = _gameWinnerService.Validate(_gameBoard);
                    Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
                }
            }
        

        [TestMethod]
        public void PlayerWithThreeInARowDiagonallyUpAndToRightIsWinner()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)// [2,0], [1,1], [0,2]
            {
                _gameBoard[2, 0] = expected[testnumber];
                _gameBoard[1, 1] = expected[testnumber];
                _gameBoard[0, 2] = expected[testnumber];

                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
            }
        }
    }
}