using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukoGame
{
    public class Sudoku
    {
        public int[,] SudokuNumbers
        {
            get { return sudokuNumbers; }
        }

        private int[,] sudokuNumbers =
        {
            {0, 3, 0, 0, 1, 0, 9, 7, 0},
            {2, 4, 7, 9, 0, 6, 5, 0, 0},
            {0, 0, 0, 0, 2, 0, 0, 4, 0},

            {0, 5, 3, 0, 8, 0, 6, 0, 0},
            {0, 0, 0, 3, 0, 0, 0, 0, 8},
            {0, 9, 4, 0, 7, 2, 1, 5, 0},

            {0, 2, 0, 1, 0, 8, 0, 0, 5},
            {6, 7, 0, 0, 4, 0, 0, 1, 9},
            {3, 0, 0, 2, 0, 0, 8, 0, 0}
        };

        

    }
}
