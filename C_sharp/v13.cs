using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace HelloWorld
{

public class Program
{
    public static void Main()
    {
        int[,] matrix = {
            { 1, 0, 1, 1, 0 },
            { 1, 1, 1, 0, 0 },
            { 0, 1, 0, 1, 1 },
            { 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1 }
        };

        bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        int maxArea = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1 && !visited[i, j])
                {
                    int area = DFS(matrix, visited, i, j);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }

        Console.WriteLine("The largest area of neighboring passable cells is " + maxArea);
    }

    public static int DFS(int[,] matrix, bool[,] visited, int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1) || matrix[row, col] == 0 || visited[row, col])
        {
            return 0;
        }

        visited[row, col] = true;

        return 1
            + DFS(matrix, visited, row - 1, col)
            + DFS(matrix, visited, row + 1, col)
            + DFS(matrix, visited, row, col - 1)
            + DFS(matrix, visited, row, col + 1);
    }
}




}