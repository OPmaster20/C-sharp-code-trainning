using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{

public class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 1, 0, 0 },
            { 0, 1, 1, 1 },
            { 0, 0, 1, 1 }
        };

        FindPaths(matrix, 0, 0, new List<string>(), "");
    }

    static void FindPaths(int[,] matrix, int row, int col, List<string> path, string direction)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        path.Add(direction);

        if (row == numRows - 1 && col == numCols - 1)
        {
            Console.WriteLine(string.Join("", path));
        }
        else
        {

            if (col + 1 < numCols && matrix[row, col + 1] == 1)
            {
                FindPaths(matrix, row, col + 1, new List<string>(path), "R");
            }

            if (row + 1 < numRows && matrix[row + 1, col] == 1)
            {
                FindPaths(matrix, row + 1, col, new List<string>(path), "D");
            }
        }
    }
}

}