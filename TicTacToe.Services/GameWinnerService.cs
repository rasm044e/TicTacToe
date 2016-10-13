using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';

        public char Validate(char[,] gameBoard)
        {
            var currentWinningSymbol = CheckForThreeInARowInTopRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowInMiddleRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowInBottomRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }
            
            currentWinningSymbol = CheckForThreeInARowInFirstColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowInSecondColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowInThirdColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            currentWinningSymbol = CheckForThreeInARowOppositeDiagonally(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            { return currentWinningSymbol; }

            else return SymbolForNoWinner;
        }



        private static char CheckForThreeInARowInFirstColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 0];
            var rowTwoChar = gameBoard[1, 0];
            var rowThreeChar = gameBoard[2, 0];
            if (rowOneChar == rowTwoChar &&
                rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInSecondColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 1];
            var rowTwoChar = gameBoard[1, 1];
            var rowThreeChar = gameBoard[2, 1];
            if (rowOneChar == rowTwoChar &&
                rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInThirdColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 2];
            var rowTwoChar = gameBoard[1, 2];
            var rowThreeChar = gameBoard[2, 2];
            if (rowOneChar == rowTwoChar &&
                rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInTopRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];
            if (columnOneChar == columnTwoChar && 
                columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInMiddleRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[1, 0];
            var columnTwoChar = gameBoard[1, 1];
            var columnThreeChar = gameBoard[1, 2];
            if (columnOneChar == columnTwoChar &&
                columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInBottomRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[2, 0];
            var columnTwoChar = gameBoard[2, 1];
            var columnThreeChar = gameBoard[2, 2];
            if (columnOneChar == columnTwoChar &&
                columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return SymbolForNoWinner;
        }



        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[0, 0];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 2];
            if (cellOneChar == cellTwoChar &&
                cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }
            return SymbolForNoWinner;
        }
        private static char CheckForThreeInARowOppositeDiagonally(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[2, 0];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[0, 2];
            if (cellOneChar == cellTwoChar &&
                cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }
            return SymbolForNoWinner;
        }
    }
}
