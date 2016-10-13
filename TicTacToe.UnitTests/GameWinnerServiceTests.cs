﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToe.Services;


namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        private IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;
        
        [SetUp]
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
        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            const char expected = ' ';            
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }
        public void APlayerHasThreeInARow()
        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;
            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber], actual);
            }
        }

        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 0; rowIndex < 3; rowIndex++)
                {
                    _gameBoard[0, rowIndex] = expected[testnumber];
                }
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
            }
        }
        [Test]
        public void PlayerWithAllSpacesInMiddleRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 1; rowIndex < 3; rowIndex++)
                {
                    _gameBoard[1, rowIndex] = expected[testnumber];
                }
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
            }
        }

        [Test]
        public void PlayerWithAllSpacesInBottomRowIsWinner()

        {
            char[] expected = new char[2];
            expected[0] = 'X'; expected[1] = 'O';
            char actual;

            for (var testnumber = 0; testnumber < 2; testnumber++)
            {
                for (var rowIndex = 2; rowIndex < 3; rowIndex++)
                {
                    _gameBoard[2, rowIndex] = expected[testnumber];
                }
                actual = _gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected[testnumber].ToString(), actual.ToString());
            }
        }
        
        //public void NeitherPlayerHasThreeInARow()
        //{
        //    const char expected = ' ';
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected, actual);
        //}
        //public void NeitherPlayerHasThreeInThirdRow()
        //{
        //    const char expected = ' ';
        //    var actual = _gameWinnerService.Validate(_gameBoard);
        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            const char expected = 'X';
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, cellIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
